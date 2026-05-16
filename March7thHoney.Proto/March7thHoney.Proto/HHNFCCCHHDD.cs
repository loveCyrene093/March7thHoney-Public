using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHNFCCCHHDD : IMessage<HHNFCCCHHDD>, IMessage, IEquatable<HHNFCCCHHDD>, IDeepCloneable<HHNFCCCHHDD>, IBufferMessage
{
	private static readonly MessageParser<HHNFCCCHHDD> _parser = new MessageParser<HHNFCCCHHDD>(() => new HHNFCCCHHDD());

	private UnknownFieldSet _unknownFields;

	public const int HGJDMIFJKPOFieldNumber = 1;

	private int hGJDMIFJKPO_;

	public const int LHADAIMMHMPFieldNumber = 2;

	private int lHADAIMMHMP_;

	public const int BFPLPAKPBLLFieldNumber = 3;

	private int bFPLPAKPBLL_;

	public const int PGDAPDFOIDDFieldNumber = 4;

	private int pGDAPDFOIDD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHNFCCCHHDD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHNFCCCHHDDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HGJDMIFJKPO
	{
		get
		{
			return hGJDMIFJKPO_;
		}
		set
		{
			hGJDMIFJKPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LHADAIMMHMP
	{
		get
		{
			return lHADAIMMHMP_;
		}
		set
		{
			lHADAIMMHMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BFPLPAKPBLL
	{
		get
		{
			return bFPLPAKPBLL_;
		}
		set
		{
			bFPLPAKPBLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PGDAPDFOIDD
	{
		get
		{
			return pGDAPDFOIDD_;
		}
		set
		{
			pGDAPDFOIDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHNFCCCHHDD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHNFCCCHHDD(HHNFCCCHHDD other)
		: this()
	{
		hGJDMIFJKPO_ = other.hGJDMIFJKPO_;
		lHADAIMMHMP_ = other.lHADAIMMHMP_;
		bFPLPAKPBLL_ = other.bFPLPAKPBLL_;
		pGDAPDFOIDD_ = other.pGDAPDFOIDD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHNFCCCHHDD Clone()
	{
		return new HHNFCCCHHDD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHNFCCCHHDD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHNFCCCHHDD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HGJDMIFJKPO != other.HGJDMIFJKPO)
		{
			return false;
		}
		if (LHADAIMMHMP != other.LHADAIMMHMP)
		{
			return false;
		}
		if (BFPLPAKPBLL != other.BFPLPAKPBLL)
		{
			return false;
		}
		if (PGDAPDFOIDD != other.PGDAPDFOIDD)
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
		if (HGJDMIFJKPO != 0)
		{
			num ^= HGJDMIFJKPO.GetHashCode();
		}
		if (LHADAIMMHMP != 0)
		{
			num ^= LHADAIMMHMP.GetHashCode();
		}
		if (BFPLPAKPBLL != 0)
		{
			num ^= BFPLPAKPBLL.GetHashCode();
		}
		if (PGDAPDFOIDD != 0)
		{
			num ^= PGDAPDFOIDD.GetHashCode();
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
		if (HGJDMIFJKPO != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(HGJDMIFJKPO);
		}
		if (LHADAIMMHMP != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LHADAIMMHMP);
		}
		if (BFPLPAKPBLL != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BFPLPAKPBLL);
		}
		if (PGDAPDFOIDD != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PGDAPDFOIDD);
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
		if (HGJDMIFJKPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HGJDMIFJKPO);
		}
		if (LHADAIMMHMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LHADAIMMHMP);
		}
		if (BFPLPAKPBLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BFPLPAKPBLL);
		}
		if (PGDAPDFOIDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PGDAPDFOIDD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHNFCCCHHDD other)
	{
		if (other != null)
		{
			if (other.HGJDMIFJKPO != 0)
			{
				HGJDMIFJKPO = other.HGJDMIFJKPO;
			}
			if (other.LHADAIMMHMP != 0)
			{
				LHADAIMMHMP = other.LHADAIMMHMP;
			}
			if (other.BFPLPAKPBLL != 0)
			{
				BFPLPAKPBLL = other.BFPLPAKPBLL;
			}
			if (other.PGDAPDFOIDD != 0)
			{
				PGDAPDFOIDD = other.PGDAPDFOIDD;
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
				HGJDMIFJKPO = input.ReadInt32();
				break;
			case 16u:
				LHADAIMMHMP = input.ReadInt32();
				break;
			case 24u:
				BFPLPAKPBLL = input.ReadInt32();
				break;
			case 32u:
				PGDAPDFOIDD = input.ReadInt32();
				break;
			}
		}
	}
}
