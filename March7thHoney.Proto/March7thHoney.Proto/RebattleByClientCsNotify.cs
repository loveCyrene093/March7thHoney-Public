using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RebattleByClientCsNotify : IMessage<RebattleByClientCsNotify>, IMessage, IEquatable<RebattleByClientCsNotify>, IDeepCloneable<RebattleByClientCsNotify>, IBufferMessage
{
	private static readonly MessageParser<RebattleByClientCsNotify> _parser = new MessageParser<RebattleByClientCsNotify>(() => new RebattleByClientCsNotify());

	private UnknownFieldSet _unknownFields;

	public const int SttFieldNumber = 2;

	private BattleStatistics stt_;

	public const int MGABMCBOHMKFieldNumber = 9;

	private RebattleType mGABMCBOHMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RebattleByClientCsNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RebattleByClientCsNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleType MGABMCBOHMK
	{
		get
		{
			return mGABMCBOHMK_;
		}
		set
		{
			mGABMCBOHMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleByClientCsNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleByClientCsNotify(RebattleByClientCsNotify other)
		: this()
	{
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		mGABMCBOHMK_ = other.mGABMCBOHMK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleByClientCsNotify Clone()
	{
		return new RebattleByClientCsNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RebattleByClientCsNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RebattleByClientCsNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (MGABMCBOHMK != other.MGABMCBOHMK)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		if (MGABMCBOHMK != RebattleType.None)
		{
			num ^= MGABMCBOHMK.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (stt_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Stt);
		}
		if (MGABMCBOHMK != RebattleType.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MGABMCBOHMK);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (MGABMCBOHMK != RebattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MGABMCBOHMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RebattleByClientCsNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new BattleStatistics();
			}
			Stt.MergeFrom(other.Stt);
		}
		if (other.MGABMCBOHMK != RebattleType.None)
		{
			MGABMCBOHMK = other.MGABMCBOHMK;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				if (stt_ == null)
				{
					Stt = new BattleStatistics();
				}
				input.ReadMessage(Stt);
				break;
			case 72u:
				MGABMCBOHMK = (RebattleType)input.ReadEnum();
				break;
			}
		}
	}
}
