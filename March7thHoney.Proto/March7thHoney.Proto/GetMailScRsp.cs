using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMailScRsp : IMessage<GetMailScRsp>, IMessage, IEquatable<GetMailScRsp>, IDeepCloneable<GetMailScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMailScRsp> _parser = new MessageParser<GetMailScRsp>(() => new GetMailScRsp());

	private UnknownFieldSet _unknownFields;

	public const int StartFieldNumber = 1;

	private uint start_;

	public const int MailListFieldNumber = 7;

	private static readonly FieldCodec<ClientMail> _repeated_mailList_codec = FieldCodec.ForMessage(58u, ClientMail.Parser);

	private readonly RepeatedField<ClientMail> mailList_ = new RepeatedField<ClientMail>();

	public const int TotalNumFieldNumber = 8;

	private uint totalNum_;

	public const int IsEndFieldNumber = 9;

	private bool isEnd_;

	public const int NoticeMailListFieldNumber = 10;

	private static readonly FieldCodec<ClientMail> _repeated_noticeMailList_codec = FieldCodec.ForMessage(82u, ClientMail.Parser);

	private readonly RepeatedField<ClientMail> noticeMailList_ = new RepeatedField<ClientMail>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMailScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMailScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Start
	{
		get
		{
			return start_;
		}
		set
		{
			start_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ClientMail> MailList => mailList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalNum
	{
		get
		{
			return totalNum_;
		}
		set
		{
			totalNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsEnd
	{
		get
		{
			return isEnd_;
		}
		set
		{
			isEnd_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ClientMail> NoticeMailList => noticeMailList_;

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
	public GetMailScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMailScRsp(GetMailScRsp other)
		: this()
	{
		start_ = other.start_;
		mailList_ = other.mailList_.Clone();
		totalNum_ = other.totalNum_;
		isEnd_ = other.isEnd_;
		noticeMailList_ = other.noticeMailList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMailScRsp Clone()
	{
		return new GetMailScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMailScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMailScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Start != other.Start)
		{
			return false;
		}
		if (!mailList_.Equals(other.mailList_))
		{
			return false;
		}
		if (TotalNum != other.TotalNum)
		{
			return false;
		}
		if (IsEnd != other.IsEnd)
		{
			return false;
		}
		if (!noticeMailList_.Equals(other.noticeMailList_))
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
		if (Start != 0)
		{
			num ^= Start.GetHashCode();
		}
		num ^= mailList_.GetHashCode();
		if (TotalNum != 0)
		{
			num ^= TotalNum.GetHashCode();
		}
		if (IsEnd)
		{
			num ^= IsEnd.GetHashCode();
		}
		num ^= noticeMailList_.GetHashCode();
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
		if (Start != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Start);
		}
		mailList_.WriteTo(ref output, _repeated_mailList_codec);
		if (TotalNum != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(TotalNum);
		}
		if (IsEnd)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsEnd);
		}
		noticeMailList_.WriteTo(ref output, _repeated_noticeMailList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (Start != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Start);
		}
		num += mailList_.CalculateSize(_repeated_mailList_codec);
		if (TotalNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalNum);
		}
		if (IsEnd)
		{
			num += 2;
		}
		num += noticeMailList_.CalculateSize(_repeated_noticeMailList_codec);
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
	public void MergeFrom(GetMailScRsp other)
	{
		if (other != null)
		{
			if (other.Start != 0)
			{
				Start = other.Start;
			}
			mailList_.Add(other.mailList_);
			if (other.TotalNum != 0)
			{
				TotalNum = other.TotalNum;
			}
			if (other.IsEnd)
			{
				IsEnd = other.IsEnd;
			}
			noticeMailList_.Add(other.noticeMailList_);
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
			case 8u:
				Start = input.ReadUInt32();
				break;
			case 58u:
				mailList_.AddEntriesFrom(ref input, _repeated_mailList_codec);
				break;
			case 64u:
				TotalNum = input.ReadUInt32();
				break;
			case 72u:
				IsEnd = input.ReadBool();
				break;
			case 82u:
				noticeMailList_.AddEntriesFrom(ref input, _repeated_noticeMailList_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
