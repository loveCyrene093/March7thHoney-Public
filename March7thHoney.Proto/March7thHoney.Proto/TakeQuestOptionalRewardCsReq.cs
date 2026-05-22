using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeQuestOptionalRewardCsReq : IMessage<TakeQuestOptionalRewardCsReq>, IMessage, IEquatable<TakeQuestOptionalRewardCsReq>, IDeepCloneable<TakeQuestOptionalRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeQuestOptionalRewardCsReq> _parser = new MessageParser<TakeQuestOptionalRewardCsReq>(() => new TakeQuestOptionalRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int QuestIdFieldNumber = 1;

	private uint questId_;

	public const int OptionalRewardIdFieldNumber = 6;

	private uint optionalRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeQuestOptionalRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeQuestOptionalRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QuestId
	{
		get
		{
			return questId_;
		}
		set
		{
			questId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OptionalRewardId
	{
		get
		{
			return optionalRewardId_;
		}
		set
		{
			optionalRewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeQuestOptionalRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeQuestOptionalRewardCsReq(TakeQuestOptionalRewardCsReq other)
		: this()
	{
		questId_ = other.questId_;
		optionalRewardId_ = other.optionalRewardId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeQuestOptionalRewardCsReq Clone()
	{
		return new TakeQuestOptionalRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeQuestOptionalRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeQuestOptionalRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QuestId != other.QuestId)
		{
			return false;
		}
		if (OptionalRewardId != other.OptionalRewardId)
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
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (OptionalRewardId != 0)
		{
			num ^= OptionalRewardId.GetHashCode();
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
		if (QuestId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(QuestId);
		}
		if (OptionalRewardId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(OptionalRewardId);
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
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QuestId);
		}
		if (OptionalRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeQuestOptionalRewardCsReq other)
	{
		if (other != null)
		{
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.OptionalRewardId != 0)
			{
				OptionalRewardId = other.OptionalRewardId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				QuestId = input.ReadUInt32();
				break;
			case 48u:
				OptionalRewardId = input.ReadUInt32();
				break;
			}
		}
	}
}
