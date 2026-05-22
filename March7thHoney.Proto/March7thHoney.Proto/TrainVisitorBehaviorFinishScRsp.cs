using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainVisitorBehaviorFinishScRsp : IMessage<TrainVisitorBehaviorFinishScRsp>, IMessage, IEquatable<TrainVisitorBehaviorFinishScRsp>, IDeepCloneable<TrainVisitorBehaviorFinishScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainVisitorBehaviorFinishScRsp> _parser = new MessageParser<TrainVisitorBehaviorFinishScRsp>(() => new TrainVisitorBehaviorFinishScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 8;

	private ItemList reward_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int VisitorIdFieldNumber = 15;

	private uint visitorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainVisitorBehaviorFinishScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainVisitorBehaviorFinishScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint VisitorId
	{
		get
		{
			return visitorId_;
		}
		set
		{
			visitorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorBehaviorFinishScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorBehaviorFinishScRsp(TrainVisitorBehaviorFinishScRsp other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		visitorId_ = other.visitorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorBehaviorFinishScRsp Clone()
	{
		return new TrainVisitorBehaviorFinishScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainVisitorBehaviorFinishScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainVisitorBehaviorFinishScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (VisitorId != other.VisitorId)
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (VisitorId != 0)
		{
			num ^= VisitorId.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (VisitorId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(VisitorId);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (VisitorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VisitorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainVisitorBehaviorFinishScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.VisitorId != 0)
		{
			VisitorId = other.VisitorId;
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
			case 66u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				VisitorId = input.ReadUInt32();
				break;
			}
		}
	}
}
