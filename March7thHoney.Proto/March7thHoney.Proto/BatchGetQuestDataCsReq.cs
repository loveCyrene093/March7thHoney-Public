using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BatchGetQuestDataCsReq : IMessage<BatchGetQuestDataCsReq>, IMessage, IEquatable<BatchGetQuestDataCsReq>, IDeepCloneable<BatchGetQuestDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<BatchGetQuestDataCsReq> _parser = new MessageParser<BatchGetQuestDataCsReq>(() => new BatchGetQuestDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int QuestListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_questList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> questList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BatchGetQuestDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BatchGetQuestDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> QuestList => questList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchGetQuestDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchGetQuestDataCsReq(BatchGetQuestDataCsReq other)
		: this()
	{
		questList_ = other.questList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchGetQuestDataCsReq Clone()
	{
		return new BatchGetQuestDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BatchGetQuestDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BatchGetQuestDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!questList_.Equals(other.questList_))
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
		num ^= questList_.GetHashCode();
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
		questList_.WriteTo(ref output, _repeated_questList_codec);
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
		num += questList_.CalculateSize(_repeated_questList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BatchGetQuestDataCsReq other)
	{
		if (other != null)
		{
			questList_.Add(other.questList_);
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
			if (num != 40 && num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				questList_.AddEntriesFrom(ref input, _repeated_questList_codec);
			}
		}
	}
}
