using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueQuestFinishNotify : IMessage<ChessRogueQuestFinishNotify>, IMessage, IEquatable<ChessRogueQuestFinishNotify>, IDeepCloneable<ChessRogueQuestFinishNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueQuestFinishNotify> _parser = new MessageParser<ChessRogueQuestFinishNotify>(() => new ChessRogueQuestFinishNotify());

	private UnknownFieldSet _unknownFields;

	public const int QuestIdFieldNumber = 7;

	private uint questId_;

	public const int OGPIDLPHHGGFieldNumber = 9;

	private uint oGPIDLPHHGG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueQuestFinishNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueQuestFinishNotifyReflection.Descriptor.MessageTypes[0];

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
	public uint OGPIDLPHHGG
	{
		get
		{
			return oGPIDLPHHGG_;
		}
		set
		{
			oGPIDLPHHGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQuestFinishNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQuestFinishNotify(ChessRogueQuestFinishNotify other)
		: this()
	{
		questId_ = other.questId_;
		oGPIDLPHHGG_ = other.oGPIDLPHHGG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueQuestFinishNotify Clone()
	{
		return new ChessRogueQuestFinishNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueQuestFinishNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueQuestFinishNotify other)
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
		if (OGPIDLPHHGG != other.OGPIDLPHHGG)
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
		if (OGPIDLPHHGG != 0)
		{
			num ^= OGPIDLPHHGG.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(QuestId);
		}
		if (OGPIDLPHHGG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OGPIDLPHHGG);
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
		if (OGPIDLPHHGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGPIDLPHHGG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueQuestFinishNotify other)
	{
		if (other != null)
		{
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.OGPIDLPHHGG != 0)
			{
				OGPIDLPHHGG = other.OGPIDLPHHGG;
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
			case 56u:
				QuestId = input.ReadUInt32();
				break;
			case 72u:
				OGPIDLPHHGG = input.ReadUInt32();
				break;
			}
		}
	}
}
