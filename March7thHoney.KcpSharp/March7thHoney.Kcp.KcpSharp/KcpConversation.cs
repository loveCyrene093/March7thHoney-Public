using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using March7thHoney.Util;

namespace March7thHoney.Kcp.KcpSharp;

public sealed class KcpConversation : IKcpConversation, IDisposable, IKcpExceptionProducer<KcpConversation>
{
	private struct KcpFlushAsyncMethodBuilder
	{
		private abstract class StateMachineBox : IValueTaskSource
		{
			protected Action? _moveNextAction;

			protected ManualResetValueTaskSourceCore<bool> _mrvtsc;

			public virtual Action MoveNextAction => _moveNextAction;

			public short Version => _mrvtsc.Version;

			public ValueTaskSourceStatus GetStatus(short token)
			{
				return _mrvtsc.GetStatus(token);
			}

			public void OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				_mrvtsc.OnCompleted(continuation, state, token, flags);
			}

			void IValueTaskSource.GetResult(short token)
			{
				throw new NotSupportedException();
			}

			public void SetResult()
			{
				_mrvtsc.SetResult(result: true);
			}

			public void SetException(Exception error)
			{
				_mrvtsc.SetException(error);
			}
		}

		private sealed class SyncSuccessSentinelStateMachineBox : StateMachineBox
		{
			public SyncSuccessSentinelStateMachineBox()
			{
				SetResult();
			}
		}

		private sealed class StateMachineBox<TStateMachine> : StateMachineBox, IValueTaskSource where TStateMachine : IAsyncStateMachine
		{
			private KcpConversation? _conversation;

			[MaybeNull]
			public TStateMachine StateMachine;

			public override Action MoveNextAction => MoveNext;

			internal StateMachineBox(KcpConversation? conversation)
			{
				_conversation = conversation;
			}

			void IValueTaskSource.GetResult(short token)
			{
				try
				{
					_mrvtsc.GetResult(token);
				}
				finally
				{
					ReturnOrDropBox();
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static StateMachineBox<TStateMachine> GetOrCreateBox(KcpConversation conversation)
			{
				if (conversation._flushStateMachine is StateMachineBox<TStateMachine> stateMachineBox)
				{
					stateMachineBox._conversation = conversation;
					conversation._flushStateMachine = null;
					return stateMachineBox;
				}
				return new StateMachineBox<TStateMachine>(conversation);
			}

			public void MoveNext()
			{
				if (StateMachine != null)
				{
					StateMachine.MoveNext();
				}
			}

			private void ReturnOrDropBox()
			{
				StateMachine = default(TStateMachine);
				_mrvtsc.Reset();
				if (_conversation != null)
				{
					_conversation._flushStateMachine = this;
					_conversation = null;
				}
			}
		}

		private readonly KcpConversation _conversation;

		private StateMachineBox? _task;

		private static readonly StateMachineBox s_syncSuccessSentinel = new SyncSuccessSentinelStateMachineBox();

		public ValueTask Task
		{
			get
			{
				if (_task == s_syncSuccessSentinel)
				{
					return default(ValueTask);
				}
				StateMachineBox stateMachineBox = _task ?? (_task = CreateWeaklyTypedStateMachineBox());
				return new ValueTask(stateMachineBox, stateMachineBox.Version);
			}
		}

		public KcpFlushAsyncMethodBuilder(KcpConversation conversation)
		{
			_conversation = conversation;
			_task = null;
		}

		public static KcpFlushAsyncMethodBuilder Create()
		{
			KcpConversation? s_currentObject = KcpConversation.s_currentObject;
			KcpConversation.s_currentObject = null;
			return new KcpFlushAsyncMethodBuilder(s_currentObject);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			stateMachine.MoveNext();
		}

		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		public void SetResult()
		{
			if (_task == null)
			{
				_task = s_syncSuccessSentinel;
			}
			else
			{
				_task.SetResult();
			}
		}

		public void SetException(Exception exception)
		{
			SetException(exception, ref _task);
		}

		private static void SetException(Exception exception, ref StateMachineBox? boxFieldRef)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			(boxFieldRef ?? (boxFieldRef = CreateWeaklyTypedStateMachineBox())).SetException(exception);
		}

		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AwaitOnCompleted(ref awaiter, ref stateMachine, ref _task, _conversation);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine, ref _task, _conversation);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine, ref StateMachineBox? boxRef, KcpConversation conversation) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			StateMachineBox stateMachineBox = GetStateMachineBox(ref stateMachine, ref boxRef, conversation);
			AwaitUnsafeOnCompleted(ref awaiter, stateMachineBox);
		}

		private static void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine, ref StateMachineBox? box, KcpConversation conversation) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				awaiter.OnCompleted(GetStateMachineBox(ref stateMachine, ref box, conversation).MoveNextAction);
			}
			catch (Exception source)
			{
				ExceptionDispatchInfo state = ExceptionDispatchInfo.Capture(source);
				ThreadPool.QueueUserWorkItem(delegate(object? obj)
				{
					((ExceptionDispatchInfo)obj).Throw();
				}, state);
			}
		}

		private static void AwaitUnsafeOnCompleted<TAwaiter>(ref TAwaiter awaiter, StateMachineBox box) where TAwaiter : ICriticalNotifyCompletion
		{
			try
			{
				awaiter.UnsafeOnCompleted(box.MoveNextAction);
			}
			catch (Exception source)
			{
				ExceptionDispatchInfo state = ExceptionDispatchInfo.Capture(source);
				ThreadPool.QueueUserWorkItem(delegate(object? obj)
				{
					((ExceptionDispatchInfo)obj).Throw();
				}, state);
			}
		}

		private static StateMachineBox CreateWeaklyTypedStateMachineBox()
		{
			return new StateMachineBox<IAsyncStateMachine>(null);
		}

		private static StateMachineBox GetStateMachineBox<TStateMachine>(ref TStateMachine stateMachine, ref StateMachineBox? boxFieldRef, KcpConversation conversation) where TStateMachine : IAsyncStateMachine
		{
			if (boxFieldRef is StateMachineBox<TStateMachine> result)
			{
				return result;
			}
			if (boxFieldRef is StateMachineBox<IAsyncStateMachine> stateMachineBox)
			{
				if (stateMachineBox.StateMachine == null)
				{
					Debugger.NotifyOfCrossThreadDependency();
					stateMachineBox.StateMachine = stateMachine;
				}
				return stateMachineBox;
			}
			Debugger.NotifyOfCrossThreadDependency();
			StateMachineBox<TStateMachine> obj = (StateMachineBox<TStateMachine>)(boxFieldRef = StateMachineBox<TStateMachine>.GetOrCreateBox(conversation));
			obj.StateMachine = stateMachine;
			return obj;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFlushCore2Async_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public KcpFlushAsyncMethodBuilder _003C_003Et__builder;

		public KcpConversation _003C_003E4__this;

		public CancellationToken cancellationToken;

		private int _003CpreBufferSize_003E5__2;

		private int _003CpostBufferSize_003E5__3;

		private int _003CpacketHeaderSize_003E5__4;

		private int _003CsizeLimitBeforePostBuffer_003E5__5;

		private ushort _003CwindowSize_003E5__6;

		private uint _003Cunacknowledged_003E5__7;

		private KcpRentedBuffer _003CbufferOwner_003E5__8;

		private Memory<byte> _003Cbuffer_003E5__9;

		private uint _003Ccurrent_003E5__10;

		private uint _003Ccwnd_003E5__11;

		private uint _003Cresent_003E5__12;

		private uint _003Crtomin_003E5__13;

		private bool _003Clost_003E5__14;

		private bool _003Cchange_003E5__15;

		private LinkedListNode<KcpSendReceiveBufferItem> _003CsegmentNode_003E5__16;

		private int _003Cindex_003E5__17;

		private uint _003CserialNumber_003E5__18;

		private uint _003Ctimestamp_003E5__19;

		private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__1;

		private LinkedListNode<KcpSendReceiveBufferItem> _003CnextSegmentNode_003E5__20;

		private KcpPacketHeader _003Cheader_003E5__21;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			KcpConversation kcpConversation = _003C_003E4__this;
			try
			{
				bool flag = default(bool);
				if ((uint)num > 5u)
				{
					_003CpreBufferSize_003E5__2 = kcpConversation._preBufferSize;
					_003CpostBufferSize_003E5__3 = kcpConversation._postBufferSize;
					_003CpacketHeaderSize_003E5__4 = (kcpConversation._id.HasValue ? 28 : 20);
					_003CsizeLimitBeforePostBuffer_003E5__5 = kcpConversation._mtu - kcpConversation._postBufferSize;
					flag = false;
					_003CwindowSize_003E5__6 = (ushort)kcpConversation.GetUnusedReceiveWindow();
					_003Cunacknowledged_003E5__7 = kcpConversation._rcv_nxt;
					_003CbufferOwner_003E5__8 = kcpConversation._bufferPool.Rent(new KcpBufferPoolRentOptions(kcpConversation._mtu + (kcpConversation._mtu - _003CpreBufferSize_003E5__2 - _003CpostBufferSize_003E5__3), isOutbound: true));
				}
				try
				{
					int num2 = default(int);
					Span<byte> span;
					ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter awaiter;
					Span<byte> span2;
					bool lockTaken2;
					Span<byte> span3;
					int bytesWritten2;
					Span<byte> span4;
					Span<byte> span5;
					int bytesWritten3;
					int bytesWritten4;
					LinkedListNode<KcpSendReceiveBufferItem> obj;
					bool lockTaken;
					switch (num)
					{
					default:
						_003Cbuffer_003E5__9 = _003CbufferOwner_003E5__8.Memory;
						num2 = _003CpreBufferSize_003E5__2;
						span = _003Cbuffer_003E5__9.Span.Slice(0, num2);
						span.Clear();
						_003Cindex_003E5__17 = 0;
						goto IL_0103;
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01f4;
					case 1:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0650;
					case 2:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_08ed;
					case 3:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0a41;
					case 4:
						try
						{
							if (num != 4)
							{
								awaiter = kcpConversation._transport.SendPacketAsync(_003Cbuffer_003E5__9.Slice(0, num2 + _003CpostBufferSize_003E5__3), kcpConversation._remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_003C_003E1__state = 4);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
								num = (_003C_003E1__state = -1);
							}
							awaiter.GetResult();
						}
						catch (Exception e)
						{
							new Logger("KcpServer").Error("transport send error", e);
						}
						kcpConversation._lastSendTick = GetTimestamp();
						goto IL_0baf;
					case 5:
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_0103:
						if (kcpConversation._ackList.TryGetAt(_003Cindex_003E5__17++, out _003CserialNumber_003E5__18, out _003Ctimestamp_003E5__19))
						{
							if (num2 + _003CpacketHeaderSize_003E5__4 > _003CsizeLimitBeforePostBuffer_003E5__5)
							{
								span = _003Cbuffer_003E5__9.Span;
								span2 = span.Slice(num2, _003CpostBufferSize_003E5__3);
								span2.Clear();
								awaiter = kcpConversation._transport.SendPacketAsync(_003Cbuffer_003E5__9.Slice(0, num2 + _003CpostBufferSize_003E5__3), kcpConversation._remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_01f4;
							}
							goto IL_022e;
						}
						_003Ccurrent_003E5__10 = GetTimestamp();
						_003Ccwnd_003E5__11 = Math.Min(kcpConversation._snd_wnd, kcpConversation._rmt_wnd);
						if (!kcpConversation._nocwnd)
						{
							_003Ccwnd_003E5__11 = Math.Min(kcpConversation._cwnd, _003Ccwnd_003E5__11);
						}
						while (true)
						{
							if (TimeDiff(kcpConversation._snd_nxt, kcpConversation._snd_una + _003Ccwnd_003E5__11) < 0 && kcpConversation._sendQueue.TryDequeue(out var data, out var fragment))
							{
								LinkedList<KcpSendReceiveBufferItem> sndBuf = kcpConversation._sndBuf;
								lockTaken = false;
								try
								{
									Monitor.Enter(sndBuf, ref lockTaken);
									if (kcpConversation.TransportClosed)
									{
										data.Release();
										break;
									}
									kcpConversation._sndBuf.AddLast(kcpConversation.CreateSendBufferItem(in data, fragment, _003Ccurrent_003E5__10, _003CwindowSize_003E5__6, (uint)(Interlocked.Increment(ref Unsafe.As<uint, int>(ref kcpConversation._snd_nxt)) - 1), _003Cunacknowledged_003E5__7, kcpConversation._rx_rto));
								}
								finally
								{
									if (num < 0 && lockTaken)
									{
										Monitor.Exit(sndBuf);
									}
								}
								continue;
							}
							_003Cresent_003E5__12 = ((kcpConversation._fastresend > 0) ? ((uint)kcpConversation._fastresend) : uint.MaxValue);
							_003Crtomin_003E5__13 = ((!kcpConversation._nodelay) ? (kcpConversation._rx_rto >> 3) : 0u);
							_003Clost_003E5__14 = false;
							_003Cchange_003E5__15 = false;
							_003CsegmentNode_003E5__16 = kcpConversation._sndBuf.First;
							goto IL_0741;
						}
						goto end_IL_00a7;
						IL_0baf:
						lockTaken2 = false;
						try
						{
							kcpConversation._cwndUpdateLock.Enter(ref lockTaken2);
							uint num3 = kcpConversation._cwnd;
							uint incr = kcpConversation._incr;
							if (_003Cchange_003E5__15)
							{
								uint num4 = kcpConversation._snd_nxt - kcpConversation._snd_una;
								kcpConversation._ssthresh = Math.Max(num4 / 2, 2u);
								num3 = kcpConversation._ssthresh + _003Cresent_003E5__12;
								incr = num3 * (uint)kcpConversation._mss;
							}
							if (_003Clost_003E5__14)
							{
								kcpConversation._ssthresh = Math.Max(_003Ccwnd_003E5__11 / 2, 2u);
								num3 = 1u;
								incr = (uint)kcpConversation._mss;
							}
							if (num3 < 1)
							{
								num3 = 1u;
								incr = (uint)kcpConversation._mss;
							}
							kcpConversation._cwnd = num3;
							kcpConversation._incr = incr;
						}
						finally
						{
							if (num < 0 && lockTaken2)
							{
								kcpConversation._cwndUpdateLock.Exit();
							}
						}
						if (kcpConversation._keepAliveEnabled && TimeDiff(GetTimestamp(), kcpConversation._lastSendTick) > kcpConversation._keepAliveInterval)
						{
							new KcpPacketHeader(KcpCommand.WindowSize, 0, _003CwindowSize_003E5__6, 0u, 0u, _003Cunacknowledged_003E5__7).EncodeHeader(kcpConversation._id, 0, _003Cbuffer_003E5__9.Span, out var bytesWritten);
							awaiter = kcpConversation._transport.SendPacketAsync(_003Cbuffer_003E5__9.Slice(0, bytesWritten), kcpConversation._remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 5);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto end_IL_00a7;
						IL_08ed:
						awaiter.GetResult();
						kcpConversation._lastSendTick = GetTimestamp();
						num2 = _003CpreBufferSize_003E5__2;
						span3 = _003Cbuffer_003E5__9.Span;
						span3.Slice(0, num2).Clear();
						flag = true;
						goto IL_0927;
						IL_072e:
						_003CsegmentNode_003E5__16 = _003CnextSegmentNode_003E5__20;
						_003CnextSegmentNode_003E5__20 = null;
						goto IL_0741;
						IL_01f4:
						awaiter.GetResult();
						kcpConversation._lastSendTick = GetTimestamp();
						num2 = _003CpreBufferSize_003E5__2;
						span2 = _003Cbuffer_003E5__9.Span;
						span2.Slice(0, num2).Clear();
						flag = true;
						goto IL_022e;
						IL_022e:
						new KcpPacketHeader(KcpCommand.Ack, 0, _003CwindowSize_003E5__6, _003Ctimestamp_003E5__19, _003CserialNumber_003E5__18, _003Cunacknowledged_003E5__7).EncodeHeader(kcpConversation._id, 0, _003Cbuffer_003E5__9.Span.Slice(num2), out bytesWritten2);
						num2 += bytesWritten2;
						goto IL_0103;
						IL_0969:
						if (!flag && kcpConversation.ShouldSendWindowSize(_003Ccurrent_003E5__10))
						{
							if (num2 + _003CpacketHeaderSize_003E5__4 > _003CsizeLimitBeforePostBuffer_003E5__5)
							{
								span4 = _003Cbuffer_003E5__9.Span.Slice(num2, _003CpostBufferSize_003E5__3);
								span4.Clear();
								awaiter = kcpConversation._transport.SendPacketAsync(_003Cbuffer_003E5__9.Slice(0, num2 + _003CpostBufferSize_003E5__3), kcpConversation._remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0a41;
							}
							goto IL_0a79;
						}
						goto IL_0abb;
						IL_0a41:
						awaiter.GetResult();
						kcpConversation._lastSendTick = GetTimestamp();
						num2 = _003CpreBufferSize_003E5__2;
						span4 = _003Cbuffer_003E5__9.Span;
						span4.Slice(0, num2).Clear();
						goto IL_0a79;
						IL_0741:
						if (_003CsegmentNode_003E5__16 != null && !kcpConversation.TransportClosed)
						{
							_003CnextSegmentNode_003E5__20 = _003CsegmentNode_003E5__16.Next;
							bool flag2 = false;
							KcpSendSegmentStats stats = _003CsegmentNode_003E5__16.ValueRef.Stats;
							if (_003CsegmentNode_003E5__16.ValueRef.Stats.TransmitCount == 0)
							{
								flag2 = true;
								_003CsegmentNode_003E5__16.ValueRef.Stats = new KcpSendSegmentStats(_003Ccurrent_003E5__10 + _003CsegmentNode_003E5__16.ValueRef.Stats.Rto + _003Crtomin_003E5__13, kcpConversation._rx_rto, stats.FastAck, stats.TransmitCount + 1);
							}
							else if (TimeDiff(_003Ccurrent_003E5__10, stats.ResendTimestamp) >= 0)
							{
								flag2 = true;
								uint rto = stats.Rto;
								if (!kcpConversation._nodelay)
								{
									rto += Math.Max(stats.Rto, kcpConversation._rx_rto);
								}
								else
								{
									uint num5 = rto;
									rto += num5 / 2;
								}
								_003CsegmentNode_003E5__16.ValueRef.Stats = new KcpSendSegmentStats(_003Ccurrent_003E5__10 + rto, rto, stats.FastAck, stats.TransmitCount + 1);
								_003Clost_003E5__14 = true;
							}
							else if (stats.FastAck > _003Cresent_003E5__12 && (stats.TransmitCount <= kcpConversation._fastlimit || kcpConversation._fastlimit == 0))
							{
								flag2 = true;
								_003CsegmentNode_003E5__16.ValueRef.Stats = new KcpSendSegmentStats(_003Ccurrent_003E5__10, stats.Rto, 0u, stats.TransmitCount + 1);
								_003Cchange_003E5__15 = true;
							}
							if (flag2)
							{
								_003Cheader_003E5__21 = DeplicateHeader(ref _003CsegmentNode_003E5__16.ValueRef.Segment, _003Ccurrent_003E5__10, _003CwindowSize_003E5__6, _003Cunacknowledged_003E5__7);
								int num6 = _003CpacketHeaderSize_003E5__4 + _003CsegmentNode_003E5__16.ValueRef.Data.Length;
								if (num2 + num6 > _003CsizeLimitBeforePostBuffer_003E5__5)
								{
									span5 = _003Cbuffer_003E5__9.Span.Slice(num2, _003CpostBufferSize_003E5__3);
									span5.Clear();
									awaiter = kcpConversation._transport.SendPacketAsync(_003Cbuffer_003E5__9.Slice(0, num2 + _003CpostBufferSize_003E5__3), kcpConversation._remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = (_003C_003E1__state = 1);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_0650;
								}
								goto IL_068a;
							}
							goto IL_072e;
						}
						kcpConversation._ackList.Clear();
						if (kcpConversation._rmt_wnd == 0)
						{
							if (kcpConversation._probe_wait == 0)
							{
								kcpConversation._probe_wait = 7000u;
								kcpConversation._ts_probe = _003Ccurrent_003E5__10 + kcpConversation._probe_wait;
							}
							else if (TimeDiff(_003Ccurrent_003E5__10, kcpConversation._ts_probe) >= 0)
							{
								if (kcpConversation._probe_wait < 7000)
								{
									kcpConversation._probe_wait = 7000u;
								}
								kcpConversation._probe_wait += kcpConversation._probe_wait / 2;
								if (kcpConversation._probe_wait > 120000)
								{
									kcpConversation._probe_wait = 120000u;
								}
								kcpConversation._ts_probe = _003Ccurrent_003E5__10 + kcpConversation._probe_wait;
								kcpConversation._probe |= KcpProbeType.AskSend;
							}
						}
						else
						{
							kcpConversation._ts_probe = 0u;
							kcpConversation._probe_wait = 0u;
						}
						if ((kcpConversation._probe & KcpProbeType.AskSend) != KcpProbeType.None)
						{
							if (num2 + _003CpacketHeaderSize_003E5__4 > _003CsizeLimitBeforePostBuffer_003E5__5)
							{
								span3 = _003Cbuffer_003E5__9.Span.Slice(num2, _003CpostBufferSize_003E5__3);
								span3.Clear();
								awaiter = kcpConversation._transport.SendPacketAsync(_003Cbuffer_003E5__9.Slice(0, num2 + _003CpostBufferSize_003E5__3), kcpConversation._remoteEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_08ed;
							}
							goto IL_0927;
						}
						goto IL_0969;
						IL_0abb:
						kcpConversation._probe = KcpProbeType.None;
						if (num2 > _003CpreBufferSize_003E5__2)
						{
							_003Cbuffer_003E5__9.Span.Slice(num2, _003CpostBufferSize_003E5__3).Clear();
							goto case 4;
						}
						goto IL_0baf;
						IL_0927:
						new KcpPacketHeader(KcpCommand.WindowProbe, 0, _003CwindowSize_003E5__6, 0u, 0u, _003Cunacknowledged_003E5__7).EncodeHeader(kcpConversation._id, 0, _003Cbuffer_003E5__9.Span.Slice(num2), out bytesWritten3);
						num2 += bytesWritten3;
						goto IL_0969;
						IL_0a79:
						new KcpPacketHeader(KcpCommand.WindowSize, 0, _003CwindowSize_003E5__6, 0u, 0u, _003Cunacknowledged_003E5__7).EncodeHeader(kcpConversation._id, 0, _003Cbuffer_003E5__9.Span.Slice(num2), out bytesWritten4);
						num2 += bytesWritten4;
						goto IL_0abb;
						IL_0650:
						awaiter.GetResult();
						kcpConversation._lastSendTick = GetTimestamp();
						num2 = _003CpreBufferSize_003E5__2;
						span5 = _003Cbuffer_003E5__9.Span;
						span5.Slice(0, num2).Clear();
						flag = true;
						goto IL_068a;
						IL_068a:
						obj = _003CsegmentNode_003E5__16;
						lockTaken = false;
						try
						{
							Monitor.Enter(obj, ref lockTaken);
							KcpBuffer data2 = _003CsegmentNode_003E5__16.ValueRef.Data;
							if (!kcpConversation.TransportClosed)
							{
								_003Cheader_003E5__21.EncodeHeader(kcpConversation._id, data2.Length, _003Cbuffer_003E5__9.Span.Slice(num2), out var bytesWritten5);
								num2 += bytesWritten5;
								if (data2.Length > 0)
								{
									data2.DataRegion.CopyTo(_003Cbuffer_003E5__9.Slice(num2));
									num2 += data2.Length;
								}
							}
						}
						finally
						{
							if (num < 0 && lockTaken)
							{
								Monitor.Exit(obj);
							}
						}
						goto IL_072e;
					}
					awaiter.GetResult();
					kcpConversation._lastSendTick = GetTimestamp();
					end_IL_00a7:;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)_003CbufferOwner_003E5__8/*cast due to constrained. prefix*/).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CbufferOwner_003E5__8 = default(KcpRentedBuffer);
				_003Cbuffer_003E5__9 = default(Memory<byte>);
				_003CsegmentNode_003E5__16 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CbufferOwner_003E5__8 = default(KcpRentedBuffer);
			_003Cbuffer_003E5__9 = default(Memory<byte>);
			_003CsegmentNode_003E5__16 = null;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private readonly IKcpBufferPool _bufferPool;

	private readonly IKcpTransport _transport;

	private readonly IPEndPoint _remoteEndPoint;

	private readonly ulong? _id;

	private readonly int _mtu;

	private readonly int _mss;

	private readonly int _preBufferSize;

	private readonly int _postBufferSize;

	private uint _snd_una;

	private uint _snd_nxt;

	private uint _rcv_nxt;

	private uint _ssthresh;

	private int _rx_rttval;

	private int _rx_srtt;

	private uint _rx_rto;

	private readonly uint _rx_minrto;

	private readonly uint _snd_wnd;

	private readonly uint _rcv_wnd;

	private uint _rmt_wnd;

	private uint _cwnd;

	private KcpProbeType _probe;

	private SpinLock _cwndUpdateLock;

	private readonly uint _interval;

	private uint _ts_flush;

	private readonly bool _nodelay;

	private uint _ts_probe;

	private uint _probe_wait;

	private uint _incr;

	private readonly KcpSendReceiveQueueItemCache _queueItemCache;

	private readonly KcpSendQueue _sendQueue;

	private readonly KcpReceiveQueue _receiveQueue;

	private readonly LinkedList<KcpSendReceiveBufferItem> _sndBuf = new LinkedList<KcpSendReceiveBufferItem>();

	private readonly LinkedList<KcpSendReceiveBufferItem> _rcvBuf = new LinkedList<KcpSendReceiveBufferItem>();

	private KcpSendReceiveBufferItemCache _cache = KcpSendReceiveBufferItemCache.Create();

	private readonly KcpAcknowledgeList _ackList;

	private readonly int _fastresend;

	private readonly int _fastlimit;

	private readonly bool _nocwnd;

	private readonly bool _keepAliveEnabled;

	private readonly uint _keepAliveInterval;

	private readonly uint _keepAliveGracePeriod;

	private uint _lastReceiveTick;

	private uint _lastSendTick;

	private readonly KcpReceiveWindowNotificationOptions? _receiveWindowNotificationOptions;

	private uint _ts_rcv_notify;

	private uint _ts_rcv_notify_wait;

	private KcpConversationUpdateActivation? _updateActivation;

	private CancellationTokenSource? _updateLoopCts;

	private bool _disposed;

	private Func<Exception, KcpConversation, object?, bool>? _exceptionHandler;

	private object? _exceptionHandlerState;

	private const uint IKCP_RTO_MAX = 60000u;

	private const int IKCP_THRESH_MIN = 2;

	private const uint IKCP_PROBE_INIT = 7000u;

	private const uint IKCP_PROBE_LIMIT = 120000u;

	[ThreadStatic]
	private static KcpConversation? s_currentObject;

	private object? _flushStateMachine;

	public long? ConversationId => (long?)_id;

	public bool TransportClosed { get; private set; }

	public bool StreamMode { get; }

	public long UnflushedBytes => _sendQueue.GetUnflushedBytes();

	public KcpConversation(IPEndPoint remoteEndpoint, IKcpTransport transport, KcpConversationOptions? options)
		: this(remoteEndpoint, transport, null, options)
	{
	}

	public KcpConversation(IPEndPoint remoteEndpoint, IKcpTransport transport, long conversationId, KcpConversationOptions? options)
		: this(remoteEndpoint, transport, (ulong)conversationId, options)
	{
	}

	private KcpConversation(IPEndPoint remoteEndpoint, IKcpTransport transport, ulong? conversationId, KcpConversationOptions? options)
	{
		_bufferPool = options?.BufferPool ?? DefaultArrayPoolBufferAllocator.Default;
		_transport = transport;
		_remoteEndPoint = remoteEndpoint;
		_id = conversationId;
		if (options == null)
		{
			_mtu = 1400;
		}
		else
		{
			if (options.Mtu < 50)
			{
				throw new ArgumentException("MTU must be at least 50.", "options");
			}
			_mtu = options.Mtu;
		}
		_preBufferSize = options?.PreBufferSize ?? 0;
		_postBufferSize = options?.PostBufferSize ?? 0;
		if (_preBufferSize < 0)
		{
			throw new ArgumentException("PreBufferSize must be a non-negative integer.", "options");
		}
		if (_postBufferSize < 0)
		{
			throw new ArgumentException("PostBufferSize must be a non-negative integer.", "options");
		}
		if ((uint)(_preBufferSize + _postBufferSize) >= (uint)(_mtu - 20))
		{
			throw new ArgumentException("The sum of PreBufferSize and PostBufferSize is too large. There is not enough space in the packet for the KCP header.", "options");
		}
		if (conversationId.HasValue && (uint)(_preBufferSize + _postBufferSize) >= (uint)(_mtu - 28))
		{
			throw new ArgumentException("The sum of PreBufferSize and PostBufferSize is too large. There is not enough space in the packet for the KCP header.", "options");
		}
		_mss = (conversationId.HasValue ? (_mtu - 28) : (_mtu - 20));
		_mss = _mss - _preBufferSize - _postBufferSize;
		_ssthresh = 2u;
		_nodelay = options?.NoDelay ?? false;
		if (_nodelay)
		{
			_rx_minrto = 30u;
		}
		else
		{
			_rx_rto = 200u;
			_rx_minrto = 100u;
		}
		_snd_wnd = ((options == null || options.SendWindow <= 0) ? 32u : ((uint)options.SendWindow));
		_rcv_wnd = ((options == null || options.ReceiveWindow <= 0) ? 128u : ((uint)options.ReceiveWindow));
		_rmt_wnd = ((options == null || options.RemoteReceiveWindow <= 0) ? 128u : ((uint)options.RemoteReceiveWindow));
		_rcv_nxt = 0u;
		_interval = ((options == null || options.UpdateInterval < 10) ? 100u : ((uint)options.UpdateInterval));
		_fastresend = options?.FastResend ?? 0;
		_fastlimit = 5;
		_nocwnd = options?.DisableCongestionControl ?? false;
		StreamMode = options?.StreamMode ?? false;
		_updateActivation = new KcpConversationUpdateActivation((int)_interval);
		_queueItemCache = new KcpSendReceiveQueueItemCache();
		_sendQueue = new KcpSendQueue(_bufferPool, _updateActivation, StreamMode, (options == null || options.SendQueueSize <= 0) ? 32 : options.SendQueueSize, _mss, _queueItemCache);
		_receiveQueue = new KcpReceiveQueue(StreamMode, (options == null || options.ReceiveQueueSize <= 0) ? 32 : options.ReceiveQueueSize, _queueItemCache);
		_ackList = new KcpAcknowledgeList(_sendQueue, (int)_snd_wnd);
		_updateLoopCts = new CancellationTokenSource();
		_ts_flush = GetTimestamp();
		_lastSendTick = _ts_flush;
		_lastReceiveTick = _ts_flush;
		KcpKeepAliveOptions kcpKeepAliveOptions = options?.KeepAliveOptions;
		if (kcpKeepAliveOptions != null)
		{
			_keepAliveEnabled = true;
			_keepAliveInterval = (uint)kcpKeepAliveOptions.SendInterval;
			_keepAliveGracePeriod = (uint)kcpKeepAliveOptions.GracePeriod;
		}
		_receiveWindowNotificationOptions = options?.ReceiveWindowNotificationOptions;
		if (_receiveWindowNotificationOptions != null)
		{
			_ts_rcv_notify_wait = 0u;
			_ts_rcv_notify = _ts_flush + (uint)_receiveWindowNotificationOptions.InitialInterval;
		}
		RunUpdateOnActivation();
	}

	public void SetExceptionHandler(Func<Exception, KcpConversation, object?, bool> handler, object? state)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		_exceptionHandler = handler;
		_exceptionHandlerState = state;
	}

	public bool TryGetSendQueueAvailableSpace(out int byteCount, out int segmentCount)
	{
		return _sendQueue.TryGetAvailableSpace(out byteCount, out segmentCount);
	}

	public bool TrySend(ReadOnlySpan<byte> buffer)
	{
		int bytesWritten;
		return _sendQueue.TrySend(buffer, allowPartialSend: false, out bytesWritten);
	}

	public bool TrySend(ReadOnlySpan<byte> buffer, bool allowPartialSend, out int bytesWritten)
	{
		return _sendQueue.TrySend(buffer, allowPartialSend, out bytesWritten);
	}

	public ValueTask<bool> WaitForSendQueueAvailableSpaceAsync(int minimumBytes, int minimumSegments, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _sendQueue.WaitForAvailableSpaceAsync(minimumBytes, minimumSegments, cancellationToken);
	}

	public ValueTask<bool> SendAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _sendQueue.SendAsync(buffer, cancellationToken);
	}

	internal ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
	{
		return _sendQueue.WriteAsync(buffer, cancellationToken);
	}

	public bool CancelPendingSend()
	{
		return _sendQueue.CancelPendingOperation(null, default(CancellationToken));
	}

	public bool CancelPendingSend(Exception? innerException, CancellationToken cancellationToken)
	{
		return _sendQueue.CancelPendingOperation(innerException, cancellationToken);
	}

	public ValueTask<bool> FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return _sendQueue.FlushAsync(cancellationToken);
	}

	internal ValueTask FlushForStreamAsync(CancellationToken cancellationToken)
	{
		return _sendQueue.FlushForStreamAsync(cancellationToken);
	}

	private ValueTask FlushCoreAsync(CancellationToken cancellationToken)
	{
		s_currentObject = this;
		return FlushCore2Async(cancellationToken);
	}

	[AsyncStateMachine(typeof(_003CFlushCore2Async_003Ed__81))]
	[AsyncMethodBuilder(typeof(KcpFlushAsyncMethodBuilder))]
	private ValueTask FlushCore2Async(CancellationToken cancellationToken)
	{
		_003CFlushCore2Async_003Ed__81 stateMachine = default(_003CFlushCore2Async_003Ed__81);
		stateMachine._003C_003Et__builder = KcpFlushAsyncMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private bool ShouldSendWindowSize(uint current)
	{
		if ((_probe & KcpProbeType.AskTell) != KcpProbeType.None)
		{
			return true;
		}
		KcpReceiveWindowNotificationOptions receiveWindowNotificationOptions = _receiveWindowNotificationOptions;
		if (receiveWindowNotificationOptions == null)
		{
			return false;
		}
		if (TimeDiff(current, _ts_rcv_notify) < 0)
		{
			return false;
		}
		uint initialInterval = (uint)receiveWindowNotificationOptions.InitialInterval;
		uint maximumInterval = (uint)receiveWindowNotificationOptions.MaximumInterval;
		if (_ts_rcv_notify_wait < initialInterval)
		{
			_ts_rcv_notify_wait = initialInterval;
		}
		else if (_ts_rcv_notify_wait >= maximumInterval)
		{
			_ts_rcv_notify_wait = maximumInterval;
		}
		else
		{
			_ts_rcv_notify_wait = Math.Min(maximumInterval, _ts_rcv_notify_wait + _ts_rcv_notify_wait / 2);
		}
		_ts_rcv_notify = current + _ts_rcv_notify_wait;
		return true;
	}

	private LinkedListNode<KcpSendReceiveBufferItem> CreateSendBufferItem(in KcpBuffer data, byte fragment, uint current, ushort windowSize, uint serialNumber, uint unacknowledged, uint rto)
	{
		KcpSendReceiveBufferItem item = new KcpSendReceiveBufferItem
		{
			Data = data,
			Segment = new KcpPacketHeader(KcpCommand.Push, fragment, windowSize, current, serialNumber, unacknowledged),
			Stats = new KcpSendSegmentStats(current, rto, 0u, 0u)
		};
		return _cache.Allocate(in item);
	}

	private static KcpPacketHeader DeplicateHeader(ref KcpPacketHeader header, uint timestamp, ushort windowSize, uint unacknowledged)
	{
		return new KcpPacketHeader(header.Command, header.Fragment, windowSize, timestamp, header.SerialNumber, unacknowledged);
	}

	private uint GetUnusedReceiveWindow()
	{
		uint queueSize = (uint)_receiveQueue.GetQueueSize();
		if (queueSize < _rcv_wnd)
		{
			return _rcv_wnd - queueSize;
		}
		return 0u;
	}

	private async void RunUpdateOnActivation()
	{
		CancellationToken cancellationToken = _updateLoopCts?.Token ?? new CancellationToken(canceled: true);
		KcpConversationUpdateActivation activation = _updateActivation;
		if (activation == null)
		{
			return;
		}
		while (!cancellationToken.IsCancellationRequested)
		{
			bool update = false;
			using (KcpConversationUpdateNotification kcpConversationUpdateNotification = await activation.WaitAsync(CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false))
			{
				if (TransportClosed)
				{
					break;
				}
				ReadOnlyMemory<byte> packet = kcpConversationUpdateNotification.Packet;
				if (!packet.IsEmpty)
				{
					try
					{
						update = SetInput(packet.Span);
					}
					catch (Exception e)
					{
						new Logger("KcpServer").Error("Update error", e);
					}
				}
				if (TransportClosed)
				{
					break;
				}
				update |= kcpConversationUpdateNotification.TimerNotification;
			}
			try
			{
				if (update)
				{
					await UpdateCoreAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			catch (OperationCanceledException)
			{
				break;
			}
			catch (Exception ex2)
			{
				if (!HandleFlushException(ex2))
				{
					break;
				}
			}
			if (_keepAliveEnabled && TimeDiff(GetTimestamp(), _lastReceiveTick) > _keepAliveGracePeriod)
			{
				SetTransportClosed();
			}
		}
	}

	private ValueTask UpdateCoreAsync(CancellationToken cancellationToken)
	{
		uint timestamp = GetTimestamp();
		long num = TimeDiff(timestamp, _ts_flush);
		if (num > 10000 || num < -10000)
		{
			_ts_flush = timestamp;
			num = 0L;
		}
		if (num >= 0 || _nodelay)
		{
			_ts_flush += _interval;
			if (TimeDiff(timestamp, _ts_flush) >= 0)
			{
				_ts_flush = timestamp + _interval;
			}
			return FlushCoreAsync(cancellationToken);
		}
		return default(ValueTask);
	}

	private bool HandleFlushException(Exception ex)
	{
		Func<Exception, KcpConversation, object, bool> exceptionHandler = _exceptionHandler;
		object exceptionHandlerState = _exceptionHandlerState;
		bool flag = false;
		if (exceptionHandler != null)
		{
			try
			{
				flag = exceptionHandler(ex, this, exceptionHandlerState);
			}
			catch
			{
				flag = false;
			}
		}
		if (!flag)
		{
			SetTransportClosed();
		}
		return flag;
	}

	public ValueTask InputPakcetAsync(UdpReceiveResult packet, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (cancellationToken.IsCancellationRequested)
		{
			return new ValueTask(Task.FromCanceled(cancellationToken));
		}
		int num = (_id.HasValue ? 28 : 20);
		if (packet.Buffer.Length < num)
		{
			return default(ValueTask);
		}
		ReadOnlySpan<byte> readOnlySpan = packet.Buffer.AsSpan();
		if (_id.HasValue)
		{
			if (BinaryPrimitives.ReadUInt64BigEndian(packet.Buffer.AsSpan()) != _id.GetValueOrDefault())
			{
				return default(ValueTask);
			}
			readOnlySpan = readOnlySpan.Slice(8);
		}
		if (BinaryPrimitives.ReadUInt32LittleEndian(readOnlySpan.Slice(16)) > (uint)(readOnlySpan.Length - 20))
		{
			return default(ValueTask);
		}
		return _updateActivation?.InputPacketAsync(packet.Buffer.AsMemory(), cancellationToken) ?? default(ValueTask);
	}

	private bool SetInput(ReadOnlySpan<byte> packet)
	{
		uint timestamp = GetTimestamp();
		int num = (_id.HasValue ? 28 : 20);
		uint snd_una = _snd_una;
		uint num2 = 0u;
		uint timestamp2 = 0u;
		bool flag = false;
		bool flag2 = false;
		while (packet.Length >= num)
		{
			if (_id.HasValue)
			{
				if (BinaryPrimitives.ReadUInt64BigEndian(packet) != _id.GetValueOrDefault())
				{
					return flag2;
				}
				packet = packet.Slice(8);
			}
			KcpPacketHeader header = KcpPacketHeader.Parse(packet);
			int num3 = BinaryPrimitives.ReadInt32LittleEndian(packet.Slice(16));
			packet = packet.Slice(20);
			if ((uint)num3 > (uint)packet.Length)
			{
				return flag2;
			}
			if (header.Command != KcpCommand.Push && header.Command != KcpCommand.Ack && header.Command != KcpCommand.WindowProbe && header.Command != KcpCommand.WindowSize)
			{
				return flag2;
			}
			_lastReceiveTick = timestamp;
			_rmt_wnd = header.WindowSize;
			flag2 = HandleUnacknowledged(header.Unacknowledged) || flag2;
			flag2 = UpdateSendUnacknowledged() || flag2;
			if (header.Command == KcpCommand.Ack)
			{
				int num4 = TimeDiff(timestamp, header.Timestamp);
				if (num4 >= 0)
				{
					UpdateRto(num4);
				}
				flag2 = HandleAck(header.SerialNumber) || flag2;
				flag2 = UpdateSendUnacknowledged() || flag2;
				if (!flag)
				{
					flag = true;
					num2 = header.SerialNumber;
					timestamp2 = header.Timestamp;
				}
				else if (TimeDiff(_snd_nxt, num2) > 0)
				{
					num2 = header.SerialNumber;
					timestamp2 = header.Timestamp;
				}
			}
			else if (header.Command == KcpCommand.Push)
			{
				if (TimeDiff(header.SerialNumber, _rcv_nxt + _rcv_wnd) < 0)
				{
					AckPush(header.SerialNumber, header.Timestamp);
					if (TimeDiff(header.SerialNumber, _rcv_nxt) >= 0)
					{
						flag2 = HandleData(header, packet.Slice(0, num3)) || flag2;
					}
					if (_receiveWindowNotificationOptions != null && _ts_rcv_notify_wait != 0)
					{
						_ts_rcv_notify_wait = 0u;
						_ts_rcv_notify = timestamp + (uint)_receiveWindowNotificationOptions.InitialInterval;
					}
				}
			}
			else if (header.Command == KcpCommand.WindowProbe)
			{
				_probe |= KcpProbeType.AskTell;
			}
			else if (header.Command != KcpCommand.WindowSize)
			{
				return flag2;
			}
			packet = packet.Slice(num3);
		}
		if (flag)
		{
			HandleFastAck(num2, timestamp2);
		}
		if (TimeDiff(_snd_una, snd_una) > 0)
		{
			bool lockTaken = false;
			try
			{
				_cwndUpdateLock.Enter(ref lockTaken);
				uint num5 = _cwnd;
				uint num6 = _incr;
				if (num5 < _rmt_wnd)
				{
					uint mss = (uint)_mss;
					if (num5 < _ssthresh)
					{
						num5++;
						num6 += mss;
					}
					else
					{
						if (num6 < mss)
						{
							num6 = mss;
						}
						num6 += mss * mss / num6 + mss / 16;
						num5 = (num6 + mss - 1) / ((mss == 0) ? 1 : mss);
					}
					if (num5 > _rmt_wnd)
					{
						num5 = _rmt_wnd;
						num6 = _rmt_wnd * mss;
					}
				}
				_cwnd = num5;
				_incr = num6;
			}
			finally
			{
				if (lockTaken)
				{
					_cwndUpdateLock.Exit();
				}
			}
		}
		return flag2;
	}

	private bool HandleUnacknowledged(uint una)
	{
		bool result = false;
		lock (_sndBuf)
		{
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode = _sndBuf.First;
			while (linkedListNode != null)
			{
				LinkedListNode<KcpSendReceiveBufferItem> next = linkedListNode.Next;
				if (TimeDiff(una, linkedListNode.ValueRef.Segment.SerialNumber) > 0)
				{
					_sndBuf.Remove(linkedListNode);
					ref KcpBuffer data = ref linkedListNode.ValueRef.Data;
					_sendQueue.SubtractUnflushedBytes(data.Length);
					data.Release();
					data = default(KcpBuffer);
					_cache.Return(linkedListNode);
					result = true;
					linkedListNode = next;
					continue;
				}
				break;
			}
		}
		return result;
	}

	private bool UpdateSendUnacknowledged()
	{
		lock (_sndBuf)
		{
			uint num = _sndBuf.First?.ValueRef.Segment.SerialNumber ?? _snd_nxt;
			uint num2 = (uint)Interlocked.Exchange(ref Unsafe.As<uint, int>(ref _snd_una), (int)num);
			return num != num2;
		}
	}

	private void UpdateRto(int rtt)
	{
		if (_rx_srtt == 0)
		{
			_rx_srtt = rtt;
			_rx_rttval = rtt / 2;
		}
		else
		{
			int num = rtt - _rx_srtt;
			if (num < 0)
			{
				num = -num;
			}
			_rx_rttval = (3 * _rx_rttval + num) / 4;
			_rx_srtt = (7 * _rx_srtt + rtt) / 8;
			if (_rx_srtt < 1)
			{
				_rx_srtt = 1;
			}
		}
		int value = _rx_srtt + Math.Max((int)_interval, 4 * _rx_rttval);
		_rx_rto = Math.Clamp((uint)value, _rx_minrto, 60000u);
	}

	private bool HandleAck(uint serialNumber)
	{
		if (TimeDiff(serialNumber, _snd_una) < 0 || TimeDiff(serialNumber, _snd_nxt) >= 0)
		{
			return false;
		}
		lock (_sndBuf)
		{
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode = _sndBuf.First;
			while (linkedListNode != null)
			{
				LinkedListNode<KcpSendReceiveBufferItem> next = linkedListNode.Next;
				if (serialNumber == linkedListNode.ValueRef.Segment.SerialNumber)
				{
					_sndBuf.Remove(linkedListNode);
					ref KcpBuffer data = ref linkedListNode.ValueRef.Data;
					_sendQueue.SubtractUnflushedBytes(data.Length);
					data.Release();
					data = default(KcpBuffer);
					_cache.Return(linkedListNode);
					return true;
				}
				if (TimeDiff(serialNumber, linkedListNode.ValueRef.Segment.SerialNumber) < 0)
				{
					return false;
				}
				linkedListNode = next;
			}
		}
		return false;
	}

	private bool HandleData(KcpPacketHeader header, ReadOnlySpan<byte> data)
	{
		uint serialNumber = header.SerialNumber;
		if (TimeDiff(serialNumber, _rcv_nxt + _rcv_wnd) >= 0 || TimeDiff(serialNumber, _rcv_nxt) < 0)
		{
			return false;
		}
		bool result = false;
		bool flag = false;
		lock (_rcvBuf)
		{
			if (TransportClosed)
			{
				return false;
			}
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode;
			for (linkedListNode = _rcvBuf.Last; linkedListNode != null; linkedListNode = linkedListNode.Previous)
			{
				uint serialNumber2 = linkedListNode.ValueRef.Segment.SerialNumber;
				if (serialNumber == serialNumber2)
				{
					flag = true;
					break;
				}
				if (TimeDiff(serialNumber, serialNumber2) > 0)
				{
					break;
				}
			}
			if (!flag)
			{
				KcpRentedBuffer buffer = _bufferPool.Rent(new KcpBufferPoolRentOptions(data.Length, isOutbound: false));
				KcpSendReceiveBufferItem item = new KcpSendReceiveBufferItem
				{
					Data = KcpBuffer.CreateFromSpan(buffer, data),
					Segment = header
				};
				if (linkedListNode == null)
				{
					_rcvBuf.AddFirst(_cache.Allocate(in item));
				}
				else
				{
					_rcvBuf.AddAfter(linkedListNode, _cache.Allocate(in item));
				}
				result = true;
			}
			linkedListNode = _rcvBuf.First;
			while (linkedListNode != null)
			{
				LinkedListNode<KcpSendReceiveBufferItem> next = linkedListNode.Next;
				if (linkedListNode.ValueRef.Segment.SerialNumber == _rcv_nxt && _receiveQueue.GetQueueSize() < _rcv_wnd)
				{
					_rcvBuf.Remove(linkedListNode);
					_receiveQueue.Enqueue(linkedListNode.ValueRef.Data, linkedListNode.ValueRef.Segment.Fragment);
					linkedListNode.ValueRef.Data = default(KcpBuffer);
					_cache.Return(linkedListNode);
					_rcv_nxt++;
					result = true;
					linkedListNode = next;
					continue;
				}
				break;
			}
		}
		return result;
	}

	private void AckPush(uint serialNumber, uint timestamp)
	{
		_ackList.Add(serialNumber, timestamp);
	}

	private void HandleFastAck(uint serialNumber, uint timestamp)
	{
		if (TimeDiff(serialNumber, _snd_una) < 0 || TimeDiff(serialNumber, _snd_nxt) >= 0)
		{
			return;
		}
		lock (_sndBuf)
		{
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode = _sndBuf.First;
			while (linkedListNode != null)
			{
				LinkedListNode<KcpSendReceiveBufferItem> next = linkedListNode.Next;
				if (TimeDiff(serialNumber, linkedListNode.ValueRef.Segment.SerialNumber) < 0)
				{
					break;
				}
				if (serialNumber != linkedListNode.ValueRef.Segment.SerialNumber)
				{
					ref KcpSendSegmentStats stats = ref linkedListNode.ValueRef.Stats;
					stats = new KcpSendSegmentStats(stats.ResendTimestamp, stats.Rto, stats.FastAck + 1, stats.TransmitCount);
				}
				linkedListNode = next;
			}
		}
	}

	private static uint GetTimestamp()
	{
		return (uint)Environment.TickCount;
	}

	private static int TimeDiff(uint later, uint earlier)
	{
		return (int)(later - earlier);
	}

	public bool TryPeek(out KcpConversationReceiveResult result)
	{
		return _receiveQueue.TryPeek(out result);
	}

	public bool TryReceive(Span<byte> buffer, out KcpConversationReceiveResult result)
	{
		return _receiveQueue.TryReceive(buffer, out result);
	}

	public ValueTask<KcpConversationReceiveResult> WaitToReceiveAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return _receiveQueue.WaitToReceiveAsync(cancellationToken);
	}

	public ValueTask<bool> WaitForReceiveQueueAvailableDataAsync(int minimumBytes, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _receiveQueue.WaitForAvailableDataAsync(minimumBytes, 0, cancellationToken);
	}

	public ValueTask<bool> WaitForReceiveQueueAvailableDataAsync(int minimumBytes, int minimumSegments, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _receiveQueue.WaitForAvailableDataAsync(minimumBytes, minimumSegments, cancellationToken);
	}

	public ValueTask<KcpConversationReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _receiveQueue.ReceiveAsync(buffer, cancellationToken);
	}

	internal ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
	{
		return _receiveQueue.ReadAsync(buffer, cancellationToken);
	}

	public bool CancelPendingReceive()
	{
		return _receiveQueue.CancelPendingOperation(null, default(CancellationToken));
	}

	public bool CancelPendingReceive(Exception? innerException, CancellationToken cancellationToken)
	{
		return _receiveQueue.CancelPendingOperation(innerException, cancellationToken);
	}

	public void SetTransportClosed()
	{
		TransportClosed = true;
		Interlocked.Exchange(ref _updateActivation, null)?.Dispose();
		CancellationTokenSource cancellationTokenSource = Interlocked.Exchange(ref _updateLoopCts, null);
		if (cancellationTokenSource != null)
		{
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
		}
		_sendQueue.SetTransportClosed();
		_receiveQueue.SetTransportClosed();
		lock (_sndBuf)
		{
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode = _sndBuf.First;
			LinkedListNode<KcpSendReceiveBufferItem> linkedListNode2 = linkedListNode?.Next;
			while (linkedListNode != null)
			{
				lock (linkedListNode)
				{
					linkedListNode.ValueRef.Data.Release();
					linkedListNode.ValueRef = default(KcpSendReceiveBufferItem);
				}
				_sndBuf.Remove(linkedListNode);
				linkedListNode = linkedListNode2;
				linkedListNode2 = linkedListNode?.Next;
			}
		}
		lock (_rcvBuf)
		{
			for (LinkedListNode<KcpSendReceiveBufferItem> linkedListNode3 = _rcvBuf.First; linkedListNode3 != null; linkedListNode3 = linkedListNode3.Next)
			{
				linkedListNode3.ValueRef.Data.Release();
			}
			_rcvBuf.Clear();
		}
		_queueItemCache.Clear();
	}

	public void Dispose()
	{
		bool disposed = _disposed;
		_disposed = true;
		SetTransportClosed();
		if (!disposed)
		{
			_sendQueue.Dispose();
			_receiveQueue.Dispose();
		}
	}
}
