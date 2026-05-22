using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeMailAttachmentCsReq : IMessage<TakeMailAttachmentCsReq>, IMessage, IEquatable<TakeMailAttachmentCsReq>, IDeepCloneable<TakeMailAttachmentCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeMailAttachmentCsReq> _parser = new MessageParser<TakeMailAttachmentCsReq>(() => new TakeMailAttachmentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OptionalRewardIdFieldNumber = 13;

	private uint optionalRewardId_;

	public const int MailIdListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_mailIdList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> mailIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeMailAttachmentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeMailAttachmentCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> MailIdList => mailIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMailAttachmentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMailAttachmentCsReq(TakeMailAttachmentCsReq other)
		: this()
	{
		optionalRewardId_ = other.optionalRewardId_;
		mailIdList_ = other.mailIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMailAttachmentCsReq Clone()
	{
		return new TakeMailAttachmentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeMailAttachmentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeMailAttachmentCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OptionalRewardId != other.OptionalRewardId)
		{
			return false;
		}
		if (!mailIdList_.Equals(other.mailIdList_))
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
		if (OptionalRewardId != 0)
		{
			num ^= OptionalRewardId.GetHashCode();
		}
		num ^= mailIdList_.GetHashCode();
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
		if (OptionalRewardId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OptionalRewardId);
		}
		mailIdList_.WriteTo(ref output, _repeated_mailIdList_codec);
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
		if (OptionalRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
		}
		num += mailIdList_.CalculateSize(_repeated_mailIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeMailAttachmentCsReq other)
	{
		if (other != null)
		{
			if (other.OptionalRewardId != 0)
			{
				OptionalRewardId = other.OptionalRewardId;
			}
			mailIdList_.Add(other.mailIdList_);
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
			case 104u:
				OptionalRewardId = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				mailIdList_.AddEntriesFrom(ref input, _repeated_mailIdList_codec);
				break;
			}
		}
	}
}
