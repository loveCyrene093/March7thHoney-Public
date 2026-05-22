using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainVisitorRewardSendNotify : IMessage<TrainVisitorRewardSendNotify>, IMessage, IEquatable<TrainVisitorRewardSendNotify>, IDeepCloneable<TrainVisitorRewardSendNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainVisitorRewardSendNotify> _parser = new MessageParser<TrainVisitorRewardSendNotify>(() => new TrainVisitorRewardSendNotify());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 6;

	private uint visitorId_;

	public const int TypeFieldNumber = 10;

	private PLHBBMEMDBG type_;

	public const int RewardFieldNumber = 13;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainVisitorRewardSendNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainVisitorRewardSendNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PLHBBMEMDBG Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
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
	public TrainVisitorRewardSendNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorRewardSendNotify(TrainVisitorRewardSendNotify other)
		: this()
	{
		visitorId_ = other.visitorId_;
		type_ = other.type_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorRewardSendNotify Clone()
	{
		return new TrainVisitorRewardSendNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainVisitorRewardSendNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainVisitorRewardSendNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VisitorId != other.VisitorId)
		{
			return false;
		}
		if (Type != other.Type)
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
		if (VisitorId != 0)
		{
			num ^= VisitorId.GetHashCode();
		}
		if (Type != PLHBBMEMDBG.Nmhbefnnoac)
		{
			num ^= Type.GetHashCode();
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
		if (VisitorId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(VisitorId);
		}
		if (Type != PLHBBMEMDBG.Nmhbefnnoac)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)Type);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(106);
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
		if (VisitorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VisitorId);
		}
		if (Type != PLHBBMEMDBG.Nmhbefnnoac)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
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
	public void MergeFrom(TrainVisitorRewardSendNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.VisitorId != 0)
		{
			VisitorId = other.VisitorId;
		}
		if (other.Type != PLHBBMEMDBG.Nmhbefnnoac)
		{
			Type = other.Type;
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
			case 48u:
				VisitorId = input.ReadUInt32();
				break;
			case 80u:
				Type = (PLHBBMEMDBG)input.ReadEnum();
				break;
			case 106u:
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
