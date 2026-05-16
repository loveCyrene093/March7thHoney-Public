using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveTakeQuestEquipCsReq : IMessage<IdleLiveTakeQuestEquipCsReq>, IMessage, IEquatable<IdleLiveTakeQuestEquipCsReq>, IDeepCloneable<IdleLiveTakeQuestEquipCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveTakeQuestEquipCsReq> _parser = new MessageParser<IdleLiveTakeQuestEquipCsReq>(() => new IdleLiveTakeQuestEquipCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DiscardedFieldNumber = 1;

	private bool discarded_;

	public const int QuestIdFieldNumber = 14;

	private uint questId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveTakeQuestEquipCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveTakeQuestEquipCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Discarded
	{
		get
		{
			return discarded_;
		}
		set
		{
			discarded_ = value;
		}
	}

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
	public IdleLiveTakeQuestEquipCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveTakeQuestEquipCsReq(IdleLiveTakeQuestEquipCsReq other)
		: this()
	{
		discarded_ = other.discarded_;
		questId_ = other.questId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveTakeQuestEquipCsReq Clone()
	{
		return new IdleLiveTakeQuestEquipCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveTakeQuestEquipCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveTakeQuestEquipCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Discarded != other.Discarded)
		{
			return false;
		}
		if (QuestId != other.QuestId)
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
		if (Discarded)
		{
			num ^= Discarded.GetHashCode();
		}
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
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
		if (Discarded)
		{
			output.WriteRawTag(8);
			output.WriteBool(Discarded);
		}
		if (QuestId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(QuestId);
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
		if (Discarded)
		{
			num += 2;
		}
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QuestId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveTakeQuestEquipCsReq other)
	{
		if (other != null)
		{
			if (other.Discarded)
			{
				Discarded = other.Discarded;
			}
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
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
				Discarded = input.ReadBool();
				break;
			case 112u:
				QuestId = input.ReadUInt32();
				break;
			}
		}
	}
}
