using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOKCIAEIPON : IMessage<OOKCIAEIPON>, IMessage, IEquatable<OOKCIAEIPON>, IDeepCloneable<OOKCIAEIPON>, IBufferMessage
{
	private static readonly MessageParser<OOKCIAEIPON> _parser = new MessageParser<OOKCIAEIPON>(() => new OOKCIAEIPON());

	private UnknownFieldSet _unknownFields;

	public const int IMIHGLAOIEGFieldNumber = 1;

	private uint iMIHGLAOIEG_;

	public const int LJEECOOPMLMFieldNumber = 5;

	private uint lJEECOOPMLM_;

	public const int KKHNDGEJBHJFieldNumber = 6;

	private uint kKHNDGEJBHJ_;

	public const int GOODPDKGJAJFieldNumber = 7;

	private uint gOODPDKGJAJ_;

	public const int GFELHICKOGIFieldNumber = 12;

	private uint gFELHICKOGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOKCIAEIPON> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOKCIAEIPONReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMIHGLAOIEG
	{
		get
		{
			return iMIHGLAOIEG_;
		}
		set
		{
			iMIHGLAOIEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJEECOOPMLM
	{
		get
		{
			return lJEECOOPMLM_;
		}
		set
		{
			lJEECOOPMLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKHNDGEJBHJ
	{
		get
		{
			return kKHNDGEJBHJ_;
		}
		set
		{
			kKHNDGEJBHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GOODPDKGJAJ
	{
		get
		{
			return gOODPDKGJAJ_;
		}
		set
		{
			gOODPDKGJAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFELHICKOGI
	{
		get
		{
			return gFELHICKOGI_;
		}
		set
		{
			gFELHICKOGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKCIAEIPON()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKCIAEIPON(OOKCIAEIPON other)
		: this()
	{
		iMIHGLAOIEG_ = other.iMIHGLAOIEG_;
		lJEECOOPMLM_ = other.lJEECOOPMLM_;
		kKHNDGEJBHJ_ = other.kKHNDGEJBHJ_;
		gOODPDKGJAJ_ = other.gOODPDKGJAJ_;
		gFELHICKOGI_ = other.gFELHICKOGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKCIAEIPON Clone()
	{
		return new OOKCIAEIPON(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOKCIAEIPON);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOKCIAEIPON other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IMIHGLAOIEG != other.IMIHGLAOIEG)
		{
			return false;
		}
		if (LJEECOOPMLM != other.LJEECOOPMLM)
		{
			return false;
		}
		if (KKHNDGEJBHJ != other.KKHNDGEJBHJ)
		{
			return false;
		}
		if (GOODPDKGJAJ != other.GOODPDKGJAJ)
		{
			return false;
		}
		if (GFELHICKOGI != other.GFELHICKOGI)
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
		if (IMIHGLAOIEG != 0)
		{
			num ^= IMIHGLAOIEG.GetHashCode();
		}
		if (LJEECOOPMLM != 0)
		{
			num ^= LJEECOOPMLM.GetHashCode();
		}
		if (KKHNDGEJBHJ != 0)
		{
			num ^= KKHNDGEJBHJ.GetHashCode();
		}
		if (GOODPDKGJAJ != 0)
		{
			num ^= GOODPDKGJAJ.GetHashCode();
		}
		if (GFELHICKOGI != 0)
		{
			num ^= GFELHICKOGI.GetHashCode();
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
		if (IMIHGLAOIEG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IMIHGLAOIEG);
		}
		if (LJEECOOPMLM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LJEECOOPMLM);
		}
		if (KKHNDGEJBHJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KKHNDGEJBHJ);
		}
		if (GOODPDKGJAJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GOODPDKGJAJ);
		}
		if (GFELHICKOGI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GFELHICKOGI);
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
		if (IMIHGLAOIEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMIHGLAOIEG);
		}
		if (LJEECOOPMLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJEECOOPMLM);
		}
		if (KKHNDGEJBHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKHNDGEJBHJ);
		}
		if (GOODPDKGJAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GOODPDKGJAJ);
		}
		if (GFELHICKOGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFELHICKOGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOKCIAEIPON other)
	{
		if (other != null)
		{
			if (other.IMIHGLAOIEG != 0)
			{
				IMIHGLAOIEG = other.IMIHGLAOIEG;
			}
			if (other.LJEECOOPMLM != 0)
			{
				LJEECOOPMLM = other.LJEECOOPMLM;
			}
			if (other.KKHNDGEJBHJ != 0)
			{
				KKHNDGEJBHJ = other.KKHNDGEJBHJ;
			}
			if (other.GOODPDKGJAJ != 0)
			{
				GOODPDKGJAJ = other.GOODPDKGJAJ;
			}
			if (other.GFELHICKOGI != 0)
			{
				GFELHICKOGI = other.GFELHICKOGI;
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
				IMIHGLAOIEG = input.ReadUInt32();
				break;
			case 40u:
				LJEECOOPMLM = input.ReadUInt32();
				break;
			case 48u:
				KKHNDGEJBHJ = input.ReadUInt32();
				break;
			case 56u:
				GOODPDKGJAJ = input.ReadUInt32();
				break;
			case 96u:
				GFELHICKOGI = input.ReadUInt32();
				break;
			}
		}
	}
}
