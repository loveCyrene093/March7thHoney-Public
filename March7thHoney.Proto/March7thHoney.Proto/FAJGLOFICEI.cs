using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FAJGLOFICEI : IMessage<FAJGLOFICEI>, IMessage, IEquatable<FAJGLOFICEI>, IDeepCloneable<FAJGLOFICEI>, IBufferMessage
{
	private static readonly MessageParser<FAJGLOFICEI> _parser = new MessageParser<FAJGLOFICEI>(() => new FAJGLOFICEI());

	private UnknownFieldSet _unknownFields;

	public const int NFDAJHJDGOJFieldNumber = 5;

	private uint nFDAJHJDGOJ_;

	public const int JMIENBBMPAGFieldNumber = 10;

	private uint jMIENBBMPAG_;

	public const int ContentIdFieldNumber = 11;

	private uint contentId_;

	public const int ANBBPPHBCJHFieldNumber = 15;

	private uint aNBBPPHBCJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FAJGLOFICEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FAJGLOFICEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFDAJHJDGOJ
	{
		get
		{
			return nFDAJHJDGOJ_;
		}
		set
		{
			nFDAJHJDGOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JMIENBBMPAG
	{
		get
		{
			return jMIENBBMPAG_;
		}
		set
		{
			jMIENBBMPAG_ = value;
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
	public uint ANBBPPHBCJH
	{
		get
		{
			return aNBBPPHBCJH_;
		}
		set
		{
			aNBBPPHBCJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAJGLOFICEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAJGLOFICEI(FAJGLOFICEI other)
		: this()
	{
		nFDAJHJDGOJ_ = other.nFDAJHJDGOJ_;
		jMIENBBMPAG_ = other.jMIENBBMPAG_;
		contentId_ = other.contentId_;
		aNBBPPHBCJH_ = other.aNBBPPHBCJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAJGLOFICEI Clone()
	{
		return new FAJGLOFICEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FAJGLOFICEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FAJGLOFICEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NFDAJHJDGOJ != other.NFDAJHJDGOJ)
		{
			return false;
		}
		if (JMIENBBMPAG != other.JMIENBBMPAG)
		{
			return false;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (ANBBPPHBCJH != other.ANBBPPHBCJH)
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
		if (NFDAJHJDGOJ != 0)
		{
			num ^= NFDAJHJDGOJ.GetHashCode();
		}
		if (JMIENBBMPAG != 0)
		{
			num ^= JMIENBBMPAG.GetHashCode();
		}
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (ANBBPPHBCJH != 0)
		{
			num ^= ANBBPPHBCJH.GetHashCode();
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
		if (NFDAJHJDGOJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NFDAJHJDGOJ);
		}
		if (JMIENBBMPAG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JMIENBBMPAG);
		}
		if (ContentId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ContentId);
		}
		if (ANBBPPHBCJH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ANBBPPHBCJH);
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
		if (NFDAJHJDGOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFDAJHJDGOJ);
		}
		if (JMIENBBMPAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JMIENBBMPAG);
		}
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (ANBBPPHBCJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANBBPPHBCJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FAJGLOFICEI other)
	{
		if (other != null)
		{
			if (other.NFDAJHJDGOJ != 0)
			{
				NFDAJHJDGOJ = other.NFDAJHJDGOJ;
			}
			if (other.JMIENBBMPAG != 0)
			{
				JMIENBBMPAG = other.JMIENBBMPAG;
			}
			if (other.ContentId != 0)
			{
				ContentId = other.ContentId;
			}
			if (other.ANBBPPHBCJH != 0)
			{
				ANBBPPHBCJH = other.ANBBPPHBCJH;
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
			case 40u:
				NFDAJHJDGOJ = input.ReadUInt32();
				break;
			case 80u:
				JMIENBBMPAG = input.ReadUInt32();
				break;
			case 88u:
				ContentId = input.ReadUInt32();
				break;
			case 120u:
				ANBBPPHBCJH = input.ReadUInt32();
				break;
			}
		}
	}
}
