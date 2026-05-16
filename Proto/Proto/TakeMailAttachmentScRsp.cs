using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeMailAttachmentScRsp : IMessage<TakeMailAttachmentScRsp>, IMessage, IEquatable<TakeMailAttachmentScRsp>, IDeepCloneable<TakeMailAttachmentScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeMailAttachmentScRsp> _parser = new MessageParser<TakeMailAttachmentScRsp>(() => new TakeMailAttachmentScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int FailMailListFieldNumber = 6;

	private static readonly FieldCodec<KEOAIHACHKG> _repeated_failMailList_codec = FieldCodec.ForMessage(50u, KEOAIHACHKG.Parser);

	private readonly RepeatedField<KEOAIHACHKG> failMailList_ = new RepeatedField<KEOAIHACHKG>();

	public const int AttachmentFieldNumber = 7;

	private ItemList attachment_;

	public const int SuccMailIdListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_succMailIdList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> succMailIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeMailAttachmentScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeMailAttachmentScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<KEOAIHACHKG> FailMailList => failMailList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Attachment
	{
		get
		{
			return attachment_;
		}
		set
		{
			attachment_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SuccMailIdList => succMailIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMailAttachmentScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMailAttachmentScRsp(TakeMailAttachmentScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		failMailList_ = other.failMailList_.Clone();
		attachment_ = ((other.attachment_ != null) ? other.attachment_.Clone() : null);
		succMailIdList_ = other.succMailIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMailAttachmentScRsp Clone()
	{
		return new TakeMailAttachmentScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeMailAttachmentScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeMailAttachmentScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!failMailList_.Equals(other.failMailList_))
		{
			return false;
		}
		if (!object.Equals(Attachment, other.Attachment))
		{
			return false;
		}
		if (!succMailIdList_.Equals(other.succMailIdList_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= failMailList_.GetHashCode();
		if (attachment_ != null)
		{
			num ^= Attachment.GetHashCode();
		}
		num ^= succMailIdList_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		failMailList_.WriteTo(ref output, _repeated_failMailList_codec);
		if (attachment_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Attachment);
		}
		succMailIdList_.WriteTo(ref output, _repeated_succMailIdList_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += failMailList_.CalculateSize(_repeated_failMailList_codec);
		if (attachment_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Attachment);
		}
		num += succMailIdList_.CalculateSize(_repeated_succMailIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeMailAttachmentScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		failMailList_.Add(other.failMailList_);
		if (other.attachment_ != null)
		{
			if (attachment_ == null)
			{
				Attachment = new ItemList();
			}
			Attachment.MergeFrom(other.Attachment);
		}
		succMailIdList_.Add(other.succMailIdList_);
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
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				failMailList_.AddEntriesFrom(ref input, _repeated_failMailList_codec);
				break;
			case 58u:
				if (attachment_ == null)
				{
					Attachment = new ItemList();
				}
				input.ReadMessage(Attachment);
				break;
			case 80u:
			case 82u:
				succMailIdList_.AddEntriesFrom(ref input, _repeated_succMailIdList_codec);
				break;
			}
		}
	}
}
