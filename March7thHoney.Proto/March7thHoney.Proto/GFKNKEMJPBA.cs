using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFKNKEMJPBA : IMessage<GFKNKEMJPBA>, IMessage, IEquatable<GFKNKEMJPBA>, IDeepCloneable<GFKNKEMJPBA>, IBufferMessage
{
	public enum DKPKPIEODIGOneofCase
	{
		None = 0,
		HCBGLCBLBDF = 1,
		HBHGAFJFNCJ = 2,
		LPBONPFMCOK = 3,
		AFHLJCCLHCK = 5,
		CIFAFAHAFKA = 6,
		GCIIMIOKFKL = 8,
		PCNEEFIHAEK = 9,
		ALDADLDPLOH = 10,
		ACGHNDBBJCB = 11,
		APLLKCCEGON = 12,
		COKIGCEDDPK = 13,
		OAABLJOFPGL = 14
	}

	private static readonly MessageParser<GFKNKEMJPBA> _parser = new MessageParser<GFKNKEMJPBA>(() => new GFKNKEMJPBA());

	private UnknownFieldSet _unknownFields;

	public const int HCBGLCBLBDFFieldNumber = 1;

	public const int HBHGAFJFNCJFieldNumber = 2;

	public const int LPBONPFMCOKFieldNumber = 3;

	public const int AFHLJCCLHCKFieldNumber = 5;

	public const int CIFAFAHAFKAFieldNumber = 6;

	public const int GCIIMIOKFKLFieldNumber = 8;

	public const int PCNEEFIHAEKFieldNumber = 9;

	public const int ALDADLDPLOHFieldNumber = 10;

	public const int ACGHNDBBJCBFieldNumber = 11;

	public const int APLLKCCEGONFieldNumber = 12;

	public const int COKIGCEDDPKFieldNumber = 13;

	public const int OAABLJOFPGLFieldNumber = 14;

	private object dKPKPIEODIG_;

	private DKPKPIEODIGOneofCase dKPKPIEODIGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFKNKEMJPBA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFKNKEMJPBAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FINPEANNNKB HCBGLCBLBDF
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.HCBGLCBLBDF)
			{
				return null;
			}
			return (FINPEANNNKB)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.HCBGLCBLBDF : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNLNNNNFPO HBHGAFJFNCJ
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.HBHGAFJFNCJ)
			{
				return null;
			}
			return (OBNLNNNNFPO)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.HBHGAFJFNCJ : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMHNBMOMLAC LPBONPFMCOK
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.LPBONPFMCOK)
			{
				return null;
			}
			return (IMHNBMOMLAC)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.LPBONPFMCOK : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKGDGAJHJPO AFHLJCCLHCK
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.AFHLJCCLHCK)
			{
				return null;
			}
			return (HKGDGAJHJPO)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.AFHLJCCLHCK : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFLGEJEND CIFAFAHAFKA
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.CIFAFAHAFKA)
			{
				return null;
			}
			return (GOFFLGEJEND)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.CIFAFAHAFKA : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GCIIMIOKFKL
	{
		get
		{
			if (!HasGCIIMIOKFKL)
			{
				return false;
			}
			return (bool)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = DKPKPIEODIGOneofCase.GCIIMIOKFKL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGCIIMIOKFKL => dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.GCIIMIOKFKL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PCNEEFIHAEK
	{
		get
		{
			if (!HasPCNEEFIHAEK)
			{
				return 0u;
			}
			return (uint)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = DKPKPIEODIGOneofCase.PCNEEFIHAEK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPCNEEFIHAEK => dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.PCNEEFIHAEK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBCLLNPDIAH ALDADLDPLOH
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.ALDADLDPLOH)
			{
				return null;
			}
			return (BBCLLNPDIAH)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.ALDADLDPLOH : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACGHNDBBJCB
	{
		get
		{
			if (!HasACGHNDBBJCB)
			{
				return 0u;
			}
			return (uint)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = DKPKPIEODIGOneofCase.ACGHNDBBJCB;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasACGHNDBBJCB => dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.ACGHNDBBJCB;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APLLKCCEGON
	{
		get
		{
			if (!HasAPLLKCCEGON)
			{
				return 0u;
			}
			return (uint)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = DKPKPIEODIGOneofCase.APLLKCCEGON;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAPLLKCCEGON => dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.APLLKCCEGON;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLEIOFJEAKC COKIGCEDDPK
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.COKIGCEDDPK)
			{
				return null;
			}
			return (HLEIOFJEAKC)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.COKIGCEDDPK : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKPEIHOLADP OAABLJOFPGL
	{
		get
		{
			if (dKPKPIEODIGCase_ != DKPKPIEODIGOneofCase.OAABLJOFPGL)
			{
				return null;
			}
			return (CKPEIHOLADP)dKPKPIEODIG_;
		}
		set
		{
			dKPKPIEODIG_ = value;
			dKPKPIEODIGCase_ = ((value != null) ? DKPKPIEODIGOneofCase.OAABLJOFPGL : DKPKPIEODIGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKPKPIEODIGOneofCase DKPKPIEODIGCase => dKPKPIEODIGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKNKEMJPBA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKNKEMJPBA(GFKNKEMJPBA other)
		: this()
	{
		switch (other.DKPKPIEODIGCase)
		{
		case DKPKPIEODIGOneofCase.HCBGLCBLBDF:
			HCBGLCBLBDF = other.HCBGLCBLBDF.Clone();
			break;
		case DKPKPIEODIGOneofCase.HBHGAFJFNCJ:
			HBHGAFJFNCJ = other.HBHGAFJFNCJ.Clone();
			break;
		case DKPKPIEODIGOneofCase.LPBONPFMCOK:
			LPBONPFMCOK = other.LPBONPFMCOK.Clone();
			break;
		case DKPKPIEODIGOneofCase.AFHLJCCLHCK:
			AFHLJCCLHCK = other.AFHLJCCLHCK.Clone();
			break;
		case DKPKPIEODIGOneofCase.CIFAFAHAFKA:
			CIFAFAHAFKA = other.CIFAFAHAFKA.Clone();
			break;
		case DKPKPIEODIGOneofCase.GCIIMIOKFKL:
			GCIIMIOKFKL = other.GCIIMIOKFKL;
			break;
		case DKPKPIEODIGOneofCase.PCNEEFIHAEK:
			PCNEEFIHAEK = other.PCNEEFIHAEK;
			break;
		case DKPKPIEODIGOneofCase.ALDADLDPLOH:
			ALDADLDPLOH = other.ALDADLDPLOH.Clone();
			break;
		case DKPKPIEODIGOneofCase.ACGHNDBBJCB:
			ACGHNDBBJCB = other.ACGHNDBBJCB;
			break;
		case DKPKPIEODIGOneofCase.APLLKCCEGON:
			APLLKCCEGON = other.APLLKCCEGON;
			break;
		case DKPKPIEODIGOneofCase.COKIGCEDDPK:
			COKIGCEDDPK = other.COKIGCEDDPK.Clone();
			break;
		case DKPKPIEODIGOneofCase.OAABLJOFPGL:
			OAABLJOFPGL = other.OAABLJOFPGL.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKNKEMJPBA Clone()
	{
		return new GFKNKEMJPBA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGCIIMIOKFKL()
	{
		if (HasGCIIMIOKFKL)
		{
			ClearDKPKPIEODIG();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPCNEEFIHAEK()
	{
		if (HasPCNEEFIHAEK)
		{
			ClearDKPKPIEODIG();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearACGHNDBBJCB()
	{
		if (HasACGHNDBBJCB)
		{
			ClearDKPKPIEODIG();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAPLLKCCEGON()
	{
		if (HasAPLLKCCEGON)
		{
			ClearDKPKPIEODIG();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDKPKPIEODIG()
	{
		dKPKPIEODIGCase_ = DKPKPIEODIGOneofCase.None;
		dKPKPIEODIG_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFKNKEMJPBA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFKNKEMJPBA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HCBGLCBLBDF, other.HCBGLCBLBDF))
		{
			return false;
		}
		if (!object.Equals(HBHGAFJFNCJ, other.HBHGAFJFNCJ))
		{
			return false;
		}
		if (!object.Equals(LPBONPFMCOK, other.LPBONPFMCOK))
		{
			return false;
		}
		if (!object.Equals(AFHLJCCLHCK, other.AFHLJCCLHCK))
		{
			return false;
		}
		if (!object.Equals(CIFAFAHAFKA, other.CIFAFAHAFKA))
		{
			return false;
		}
		if (GCIIMIOKFKL != other.GCIIMIOKFKL)
		{
			return false;
		}
		if (PCNEEFIHAEK != other.PCNEEFIHAEK)
		{
			return false;
		}
		if (!object.Equals(ALDADLDPLOH, other.ALDADLDPLOH))
		{
			return false;
		}
		if (ACGHNDBBJCB != other.ACGHNDBBJCB)
		{
			return false;
		}
		if (APLLKCCEGON != other.APLLKCCEGON)
		{
			return false;
		}
		if (!object.Equals(COKIGCEDDPK, other.COKIGCEDDPK))
		{
			return false;
		}
		if (!object.Equals(OAABLJOFPGL, other.OAABLJOFPGL))
		{
			return false;
		}
		if (DKPKPIEODIGCase != other.DKPKPIEODIGCase)
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
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HCBGLCBLBDF)
		{
			num ^= HCBGLCBLBDF.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HBHGAFJFNCJ)
		{
			num ^= HBHGAFJFNCJ.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.LPBONPFMCOK)
		{
			num ^= LPBONPFMCOK.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.AFHLJCCLHCK)
		{
			num ^= AFHLJCCLHCK.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.CIFAFAHAFKA)
		{
			num ^= CIFAFAHAFKA.GetHashCode();
		}
		if (HasGCIIMIOKFKL)
		{
			num ^= GCIIMIOKFKL.GetHashCode();
		}
		if (HasPCNEEFIHAEK)
		{
			num ^= PCNEEFIHAEK.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.ALDADLDPLOH)
		{
			num ^= ALDADLDPLOH.GetHashCode();
		}
		if (HasACGHNDBBJCB)
		{
			num ^= ACGHNDBBJCB.GetHashCode();
		}
		if (HasAPLLKCCEGON)
		{
			num ^= APLLKCCEGON.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.COKIGCEDDPK)
		{
			num ^= COKIGCEDDPK.GetHashCode();
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.OAABLJOFPGL)
		{
			num ^= OAABLJOFPGL.GetHashCode();
		}
		num ^= (int)dKPKPIEODIGCase_;
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
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HCBGLCBLBDF)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HCBGLCBLBDF);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HBHGAFJFNCJ)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HBHGAFJFNCJ);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.LPBONPFMCOK)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LPBONPFMCOK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.AFHLJCCLHCK)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AFHLJCCLHCK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.CIFAFAHAFKA)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CIFAFAHAFKA);
		}
		if (HasGCIIMIOKFKL)
		{
			output.WriteRawTag(64);
			output.WriteBool(GCIIMIOKFKL);
		}
		if (HasPCNEEFIHAEK)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PCNEEFIHAEK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.ALDADLDPLOH)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ALDADLDPLOH);
		}
		if (HasACGHNDBBJCB)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ACGHNDBBJCB);
		}
		if (HasAPLLKCCEGON)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(APLLKCCEGON);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.COKIGCEDDPK)
		{
			output.WriteRawTag(106);
			output.WriteMessage(COKIGCEDDPK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.OAABLJOFPGL)
		{
			output.WriteRawTag(114);
			output.WriteMessage(OAABLJOFPGL);
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
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HCBGLCBLBDF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HCBGLCBLBDF);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HBHGAFJFNCJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HBHGAFJFNCJ);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.LPBONPFMCOK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LPBONPFMCOK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.AFHLJCCLHCK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFHLJCCLHCK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.CIFAFAHAFKA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CIFAFAHAFKA);
		}
		if (HasGCIIMIOKFKL)
		{
			num += 2;
		}
		if (HasPCNEEFIHAEK)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PCNEEFIHAEK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.ALDADLDPLOH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ALDADLDPLOH);
		}
		if (HasACGHNDBBJCB)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACGHNDBBJCB);
		}
		if (HasAPLLKCCEGON)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APLLKCCEGON);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.COKIGCEDDPK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(COKIGCEDDPK);
		}
		if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.OAABLJOFPGL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OAABLJOFPGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFKNKEMJPBA other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.DKPKPIEODIGCase)
		{
		case DKPKPIEODIGOneofCase.HCBGLCBLBDF:
			if (HCBGLCBLBDF == null)
			{
				HCBGLCBLBDF = new FINPEANNNKB();
			}
			HCBGLCBLBDF.MergeFrom(other.HCBGLCBLBDF);
			break;
		case DKPKPIEODIGOneofCase.HBHGAFJFNCJ:
			if (HBHGAFJFNCJ == null)
			{
				HBHGAFJFNCJ = new OBNLNNNNFPO();
			}
			HBHGAFJFNCJ.MergeFrom(other.HBHGAFJFNCJ);
			break;
		case DKPKPIEODIGOneofCase.LPBONPFMCOK:
			if (LPBONPFMCOK == null)
			{
				LPBONPFMCOK = new IMHNBMOMLAC();
			}
			LPBONPFMCOK.MergeFrom(other.LPBONPFMCOK);
			break;
		case DKPKPIEODIGOneofCase.AFHLJCCLHCK:
			if (AFHLJCCLHCK == null)
			{
				AFHLJCCLHCK = new HKGDGAJHJPO();
			}
			AFHLJCCLHCK.MergeFrom(other.AFHLJCCLHCK);
			break;
		case DKPKPIEODIGOneofCase.CIFAFAHAFKA:
			if (CIFAFAHAFKA == null)
			{
				CIFAFAHAFKA = new GOFFLGEJEND();
			}
			CIFAFAHAFKA.MergeFrom(other.CIFAFAHAFKA);
			break;
		case DKPKPIEODIGOneofCase.GCIIMIOKFKL:
			GCIIMIOKFKL = other.GCIIMIOKFKL;
			break;
		case DKPKPIEODIGOneofCase.PCNEEFIHAEK:
			PCNEEFIHAEK = other.PCNEEFIHAEK;
			break;
		case DKPKPIEODIGOneofCase.ALDADLDPLOH:
			if (ALDADLDPLOH == null)
			{
				ALDADLDPLOH = new BBCLLNPDIAH();
			}
			ALDADLDPLOH.MergeFrom(other.ALDADLDPLOH);
			break;
		case DKPKPIEODIGOneofCase.ACGHNDBBJCB:
			ACGHNDBBJCB = other.ACGHNDBBJCB;
			break;
		case DKPKPIEODIGOneofCase.APLLKCCEGON:
			APLLKCCEGON = other.APLLKCCEGON;
			break;
		case DKPKPIEODIGOneofCase.COKIGCEDDPK:
			if (COKIGCEDDPK == null)
			{
				COKIGCEDDPK = new HLEIOFJEAKC();
			}
			COKIGCEDDPK.MergeFrom(other.COKIGCEDDPK);
			break;
		case DKPKPIEODIGOneofCase.OAABLJOFPGL:
			if (OAABLJOFPGL == null)
			{
				OAABLJOFPGL = new CKPEIHOLADP();
			}
			OAABLJOFPGL.MergeFrom(other.OAABLJOFPGL);
			break;
		}
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
			case 10u:
			{
				FINPEANNNKB fINPEANNNKB = new FINPEANNNKB();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HCBGLCBLBDF)
				{
					fINPEANNNKB.MergeFrom(HCBGLCBLBDF);
				}
				input.ReadMessage(fINPEANNNKB);
				HCBGLCBLBDF = fINPEANNNKB;
				break;
			}
			case 18u:
			{
				OBNLNNNNFPO oBNLNNNNFPO = new OBNLNNNNFPO();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.HBHGAFJFNCJ)
				{
					oBNLNNNNFPO.MergeFrom(HBHGAFJFNCJ);
				}
				input.ReadMessage(oBNLNNNNFPO);
				HBHGAFJFNCJ = oBNLNNNNFPO;
				break;
			}
			case 26u:
			{
				IMHNBMOMLAC iMHNBMOMLAC = new IMHNBMOMLAC();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.LPBONPFMCOK)
				{
					iMHNBMOMLAC.MergeFrom(LPBONPFMCOK);
				}
				input.ReadMessage(iMHNBMOMLAC);
				LPBONPFMCOK = iMHNBMOMLAC;
				break;
			}
			case 42u:
			{
				HKGDGAJHJPO hKGDGAJHJPO = new HKGDGAJHJPO();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.AFHLJCCLHCK)
				{
					hKGDGAJHJPO.MergeFrom(AFHLJCCLHCK);
				}
				input.ReadMessage(hKGDGAJHJPO);
				AFHLJCCLHCK = hKGDGAJHJPO;
				break;
			}
			case 50u:
			{
				GOFFLGEJEND gOFFLGEJEND = new GOFFLGEJEND();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.CIFAFAHAFKA)
				{
					gOFFLGEJEND.MergeFrom(CIFAFAHAFKA);
				}
				input.ReadMessage(gOFFLGEJEND);
				CIFAFAHAFKA = gOFFLGEJEND;
				break;
			}
			case 64u:
				GCIIMIOKFKL = input.ReadBool();
				break;
			case 72u:
				PCNEEFIHAEK = input.ReadUInt32();
				break;
			case 82u:
			{
				BBCLLNPDIAH bBCLLNPDIAH = new BBCLLNPDIAH();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.ALDADLDPLOH)
				{
					bBCLLNPDIAH.MergeFrom(ALDADLDPLOH);
				}
				input.ReadMessage(bBCLLNPDIAH);
				ALDADLDPLOH = bBCLLNPDIAH;
				break;
			}
			case 88u:
				ACGHNDBBJCB = input.ReadUInt32();
				break;
			case 96u:
				APLLKCCEGON = input.ReadUInt32();
				break;
			case 106u:
			{
				HLEIOFJEAKC hLEIOFJEAKC = new HLEIOFJEAKC();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.COKIGCEDDPK)
				{
					hLEIOFJEAKC.MergeFrom(COKIGCEDDPK);
				}
				input.ReadMessage(hLEIOFJEAKC);
				COKIGCEDDPK = hLEIOFJEAKC;
				break;
			}
			case 114u:
			{
				CKPEIHOLADP cKPEIHOLADP = new CKPEIHOLADP();
				if (dKPKPIEODIGCase_ == DKPKPIEODIGOneofCase.OAABLJOFPGL)
				{
					cKPEIHOLADP.MergeFrom(OAABLJOFPGL);
				}
				input.ReadMessage(cKPEIHOLADP);
				OAABLJOFPGL = cKPEIHOLADP;
				break;
			}
			}
		}
	}
}
