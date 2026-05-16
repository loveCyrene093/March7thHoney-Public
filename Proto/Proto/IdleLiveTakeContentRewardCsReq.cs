using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveTakeContentRewardCsReq : IMessage<IdleLiveTakeContentRewardCsReq>, IMessage, IEquatable<IdleLiveTakeContentRewardCsReq>, IDeepCloneable<IdleLiveTakeContentRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveTakeContentRewardCsReq> _parser = new MessageParser<IdleLiveTakeContentRewardCsReq>(() => new IdleLiveTakeContentRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MKHDINDGHMDFieldNumber = 4;

	private MHGDJPMEFFN mKHDINDGHMD_;

	public const int ContentIdFieldNumber = 9;

	private uint contentId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveTakeContentRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveTakeContentRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHGDJPMEFFN MKHDINDGHMD
	{
		get
		{
			return mKHDINDGHMD_;
		}
		set
		{
			mKHDINDGHMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveTakeContentRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveTakeContentRewardCsReq(IdleLiveTakeContentRewardCsReq other)
		: this()
	{
		mKHDINDGHMD_ = other.mKHDINDGHMD_;
		contentId_ = other.contentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveTakeContentRewardCsReq Clone()
	{
		return new IdleLiveTakeContentRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveTakeContentRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveTakeContentRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MKHDINDGHMD != other.MKHDINDGHMD)
		{
			return false;
		}
		if (ContentId != other.ContentId)
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
		if (MKHDINDGHMD != MHGDJPMEFFN.Pcpdhelpkem)
		{
			num ^= MKHDINDGHMD.GetHashCode();
		}
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
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
		if (MKHDINDGHMD != MHGDJPMEFFN.Pcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)MKHDINDGHMD);
		}
		if (ContentId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ContentId);
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
		if (MKHDINDGHMD != MHGDJPMEFFN.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MKHDINDGHMD);
		}
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveTakeContentRewardCsReq other)
	{
		if (other != null)
		{
			if (other.MKHDINDGHMD != MHGDJPMEFFN.Pcpdhelpkem)
			{
				MKHDINDGHMD = other.MKHDINDGHMD;
			}
			if (other.ContentId != 0)
			{
				ContentId = other.ContentId;
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
			case 32u:
				MKHDINDGHMD = (MHGDJPMEFFN)input.ReadEnum();
				break;
			case 72u:
				ContentId = input.ReadUInt32();
				break;
			}
		}
	}
}
