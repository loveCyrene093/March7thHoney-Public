using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BatchMarkChatEmojiScRsp : IMessage<BatchMarkChatEmojiScRsp>, IMessage, IEquatable<BatchMarkChatEmojiScRsp>, IDeepCloneable<BatchMarkChatEmojiScRsp>, IBufferMessage
{
	private static readonly MessageParser<BatchMarkChatEmojiScRsp> _parser = new MessageParser<BatchMarkChatEmojiScRsp>(() => new BatchMarkChatEmojiScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MarkedEmojiIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_markedEmojiIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> markedEmojiIdList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BatchMarkChatEmojiScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BatchMarkChatEmojiScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MarkedEmojiIdList => markedEmojiIdList_;

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
	public BatchMarkChatEmojiScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchMarkChatEmojiScRsp(BatchMarkChatEmojiScRsp other)
		: this()
	{
		markedEmojiIdList_ = other.markedEmojiIdList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BatchMarkChatEmojiScRsp Clone()
	{
		return new BatchMarkChatEmojiScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BatchMarkChatEmojiScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BatchMarkChatEmojiScRsp other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		markedEmojiIdList_.WriteTo(ref output, _repeated_markedEmojiIdList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
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
		num += markedEmojiIdList_.CalculateSize(_repeated_markedEmojiIdList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BatchMarkChatEmojiScRsp other)
	{
		if (other != null)
		{
			markedEmojiIdList_.Add(other.markedEmojiIdList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 16u:
			case 18u:
				markedEmojiIdList_.AddEntriesFrom(ref input, _repeated_markedEmojiIdList_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
