using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishFirstTalkByPerformanceNpcScRsp : IMessage<FinishFirstTalkByPerformanceNpcScRsp>, IMessage, IEquatable<FinishFirstTalkByPerformanceNpcScRsp>, IDeepCloneable<FinishFirstTalkByPerformanceNpcScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishFirstTalkByPerformanceNpcScRsp> _parser = new MessageParser<FinishFirstTalkByPerformanceNpcScRsp>(() => new FinishFirstTalkByPerformanceNpcScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PerformanceIdFieldNumber = 1;

	private uint performanceId_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int RewardFieldNumber = 10;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishFirstTalkByPerformanceNpcScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishFirstTalkByPerformanceNpcScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PerformanceId
	{
		get
		{
			return performanceId_;
		}
		set
		{
			performanceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFirstTalkByPerformanceNpcScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFirstTalkByPerformanceNpcScRsp(FinishFirstTalkByPerformanceNpcScRsp other)
		: this()
	{
		performanceId_ = other.performanceId_;
		retcode_ = other.retcode_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFirstTalkByPerformanceNpcScRsp Clone()
	{
		return new FinishFirstTalkByPerformanceNpcScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishFirstTalkByPerformanceNpcScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishFirstTalkByPerformanceNpcScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformanceId != other.PerformanceId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		if (PerformanceId != 0)
		{
			num ^= PerformanceId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (PerformanceId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PerformanceId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Reward);
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
		if (PerformanceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PerformanceId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishFirstTalkByPerformanceNpcScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PerformanceId != 0)
		{
			PerformanceId = other.PerformanceId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
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
			case 8u:
				PerformanceId = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			}
		}
	}
}
