using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BatchMarkChatEmojiCsReq : IMessage<BatchMarkChatEmojiCsReq>, IMessage, IEquatable<BatchMarkChatEmojiCsReq>, IDeepCloneable<BatchMarkChatEmojiCsReq>, IBufferMessage
{
	private static readonly MessageParser<BatchMarkChatEmojiCsReq> _parser = new MessageParser<BatchMarkChatEmojiCsReq>(() => new BatchMarkChatEmojiCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MarkedEmojiIdListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_markedEmojiIdList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> markedEmojiIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BatchMarkChatEmojiCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BatchMarkChatEmojiCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MarkedEmojiIdList => markedEmojiIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchMarkChatEmojiCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchMarkChatEmojiCsReq(BatchMarkChatEmojiCsReq other)
		: this()
	{
		markedEmojiIdList_ = other.markedEmojiIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchMarkChatEmojiCsReq Clone()
	{
		return new BatchMarkChatEmojiCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BatchMarkChatEmojiCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BatchMarkChatEmojiCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!markedEmojiIdList_.Equals(other.markedEmojiIdList_))
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
		num ^= markedEmojiIdList_.GetHashCode();
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
		markedEmojiIdList_.WriteTo(ref output, _repeated_markedEmojiIdList_codec);
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
		num += markedEmojiIdList_.CalculateSize(_repeated_markedEmojiIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BatchMarkChatEmojiCsReq other)
	{
		if (other != null)
		{
			markedEmojiIdList_.Add(other.markedEmojiIdList_);
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
			if (num != 56 && num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				markedEmojiIdList_.AddEntriesFrom(ref input, _repeated_markedEmojiIdList_codec);
			}
		}
	}
}
