using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KJJJCCIOHDK : IMessage<KJJJCCIOHDK>, IMessage, IEquatable<KJJJCCIOHDK>, IDeepCloneable<KJJJCCIOHDK>, IBufferMessage
{
	private static readonly MessageParser<KJJJCCIOHDK> _parser = new MessageParser<KJJJCCIOHDK>(() => new KJJJCCIOHDK());

	private UnknownFieldSet _unknownFields;

	public const int MKHDINDGHMDFieldNumber = 1;

	private MHGDJPMEFFN mKHDINDGHMD_;

	public const int ContentIdFieldNumber = 10;

	private uint contentId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KJJJCCIOHDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KJJJCCIOHDKReflection.Descriptor.MessageTypes[0];

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
	public KJJJCCIOHDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJJJCCIOHDK(KJJJCCIOHDK other)
		: this()
	{
		mKHDINDGHMD_ = other.mKHDINDGHMD_;
		contentId_ = other.contentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJJJCCIOHDK Clone()
	{
		return new KJJJCCIOHDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KJJJCCIOHDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KJJJCCIOHDK other)
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
			output.WriteRawTag(8);
			output.WriteEnum((int)MKHDINDGHMD);
		}
		if (ContentId != 0)
		{
			output.WriteRawTag(80);
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
	public void MergeFrom(KJJJCCIOHDK other)
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
			case 8u:
				MKHDINDGHMD = (MHGDJPMEFFN)input.ReadEnum();
				break;
			case 80u:
				ContentId = input.ReadUInt32();
				break;
			}
		}
	}
}
