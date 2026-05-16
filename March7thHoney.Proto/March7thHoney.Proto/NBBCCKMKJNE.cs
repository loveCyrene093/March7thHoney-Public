using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBBCCKMKJNE : IMessage<NBBCCKMKJNE>, IMessage, IEquatable<NBBCCKMKJNE>, IDeepCloneable<NBBCCKMKJNE>, IBufferMessage
{
	private static readonly MessageParser<NBBCCKMKJNE> _parser = new MessageParser<NBBCCKMKJNE>(() => new NBBCCKMKJNE());

	private UnknownFieldSet _unknownFields;

	public const int OPIBBDHMCGOFieldNumber = 1;

	private uint oPIBBDHMCGO_;

	public const int DHNDLHLNMJBFieldNumber = 2;

	private uint dHNDLHLNMJB_;

	public const int FJGCNBDBMMGFieldNumber = 3;

	private uint fJGCNBDBMMG_;

	public const int BKAANCLCOAHFieldNumber = 4;

	private uint bKAANCLCOAH_;

	public const int LBPBGNJFAIOFieldNumber = 5;

	private uint lBPBGNJFAIO_;

	public const int CHDNOCOLLHJFieldNumber = 6;

	private uint cHDNOCOLLHJ_;

	public const int IACHBBGOHLHFieldNumber = 7;

	private uint iACHBBGOHLH_;

	public const int PHHLMDICENJFieldNumber = 8;

	private uint pHHLMDICENJ_;

	public const int CHODEHNFCLJFieldNumber = 9;

	private uint cHODEHNFCLJ_;

	public const int PLIJJNGPEIMFieldNumber = 10;

	private uint pLIJJNGPEIM_;

	public const int CBKNDPBFBJLFieldNumber = 11;

	private uint cBKNDPBFBJL_;

	public const int IMKAOJLJIDKFieldNumber = 12;

	private uint iMKAOJLJIDK_;

	public const int LFBBONLCFPHFieldNumber = 13;

	private uint lFBBONLCFPH_;

	public const int LMPNJDMGOBBFieldNumber = 14;

	private uint lMPNJDMGOBB_;

	public const int GENOMEOLOJBFieldNumber = 15;

	private uint gENOMEOLOJB_;

	public const int TypeFieldNumber = 684;

	private uint type_;

	public const int OLDBJILBGLDFieldNumber = 1376;

	private string oLDBJILBGLD_ = "";

	public const int OOPMDDKLNKPFieldNumber = 1508;

	private string oOPMDDKLNKP_ = "";

	public const int PanelIdFieldNumber = 1645;

	private uint panelId_;

	public const int DNGGPHPOHHDFieldNumber = 1893;

	private string dNGGPHPOHHD_ = "";

	public const int DKIACFLBEKDFieldNumber = 1981;

	private uint dKIACFLBEKD_;

	public const int FCBFCDAGFOAFieldNumber = 2032;

	private string fCBFCDAGFOA_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBBCCKMKJNE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBBCCKMKJNEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPIBBDHMCGO
	{
		get
		{
			return oPIBBDHMCGO_;
		}
		set
		{
			oPIBBDHMCGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHNDLHLNMJB
	{
		get
		{
			return dHNDLHLNMJB_;
		}
		set
		{
			dHNDLHLNMJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJGCNBDBMMG
	{
		get
		{
			return fJGCNBDBMMG_;
		}
		set
		{
			fJGCNBDBMMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKAANCLCOAH
	{
		get
		{
			return bKAANCLCOAH_;
		}
		set
		{
			bKAANCLCOAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBPBGNJFAIO
	{
		get
		{
			return lBPBGNJFAIO_;
		}
		set
		{
			lBPBGNJFAIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHDNOCOLLHJ
	{
		get
		{
			return cHDNOCOLLHJ_;
		}
		set
		{
			cHDNOCOLLHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IACHBBGOHLH
	{
		get
		{
			return iACHBBGOHLH_;
		}
		set
		{
			iACHBBGOHLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHHLMDICENJ
	{
		get
		{
			return pHHLMDICENJ_;
		}
		set
		{
			pHHLMDICENJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHODEHNFCLJ
	{
		get
		{
			return cHODEHNFCLJ_;
		}
		set
		{
			cHODEHNFCLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PLIJJNGPEIM
	{
		get
		{
			return pLIJJNGPEIM_;
		}
		set
		{
			pLIJJNGPEIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBKNDPBFBJL
	{
		get
		{
			return cBKNDPBFBJL_;
		}
		set
		{
			cBKNDPBFBJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMKAOJLJIDK
	{
		get
		{
			return iMKAOJLJIDK_;
		}
		set
		{
			iMKAOJLJIDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFBBONLCFPH
	{
		get
		{
			return lFBBONLCFPH_;
		}
		set
		{
			lFBBONLCFPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMPNJDMGOBB
	{
		get
		{
			return lMPNJDMGOBB_;
		}
		set
		{
			lMPNJDMGOBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GENOMEOLOJB
	{
		get
		{
			return gENOMEOLOJB_;
		}
		set
		{
			gENOMEOLOJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OLDBJILBGLD
	{
		get
		{
			return oLDBJILBGLD_;
		}
		set
		{
			oLDBJILBGLD_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OOPMDDKLNKP
	{
		get
		{
			return oOPMDDKLNKP_;
		}
		set
		{
			oOPMDDKLNKP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DNGGPHPOHHD
	{
		get
		{
			return dNGGPHPOHHD_;
		}
		set
		{
			dNGGPHPOHHD_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKIACFLBEKD
	{
		get
		{
			return dKIACFLBEKD_;
		}
		set
		{
			dKIACFLBEKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FCBFCDAGFOA
	{
		get
		{
			return fCBFCDAGFOA_;
		}
		set
		{
			fCBFCDAGFOA_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBCCKMKJNE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBCCKMKJNE(NBBCCKMKJNE other)
		: this()
	{
		oPIBBDHMCGO_ = other.oPIBBDHMCGO_;
		dHNDLHLNMJB_ = other.dHNDLHLNMJB_;
		fJGCNBDBMMG_ = other.fJGCNBDBMMG_;
		bKAANCLCOAH_ = other.bKAANCLCOAH_;
		lBPBGNJFAIO_ = other.lBPBGNJFAIO_;
		cHDNOCOLLHJ_ = other.cHDNOCOLLHJ_;
		iACHBBGOHLH_ = other.iACHBBGOHLH_;
		pHHLMDICENJ_ = other.pHHLMDICENJ_;
		cHODEHNFCLJ_ = other.cHODEHNFCLJ_;
		pLIJJNGPEIM_ = other.pLIJJNGPEIM_;
		cBKNDPBFBJL_ = other.cBKNDPBFBJL_;
		iMKAOJLJIDK_ = other.iMKAOJLJIDK_;
		lFBBONLCFPH_ = other.lFBBONLCFPH_;
		lMPNJDMGOBB_ = other.lMPNJDMGOBB_;
		gENOMEOLOJB_ = other.gENOMEOLOJB_;
		type_ = other.type_;
		oLDBJILBGLD_ = other.oLDBJILBGLD_;
		oOPMDDKLNKP_ = other.oOPMDDKLNKP_;
		panelId_ = other.panelId_;
		dNGGPHPOHHD_ = other.dNGGPHPOHHD_;
		dKIACFLBEKD_ = other.dKIACFLBEKD_;
		fCBFCDAGFOA_ = other.fCBFCDAGFOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBCCKMKJNE Clone()
	{
		return new NBBCCKMKJNE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBBCCKMKJNE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBBCCKMKJNE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OPIBBDHMCGO != other.OPIBBDHMCGO)
		{
			return false;
		}
		if (DHNDLHLNMJB != other.DHNDLHLNMJB)
		{
			return false;
		}
		if (FJGCNBDBMMG != other.FJGCNBDBMMG)
		{
			return false;
		}
		if (BKAANCLCOAH != other.BKAANCLCOAH)
		{
			return false;
		}
		if (LBPBGNJFAIO != other.LBPBGNJFAIO)
		{
			return false;
		}
		if (CHDNOCOLLHJ != other.CHDNOCOLLHJ)
		{
			return false;
		}
		if (IACHBBGOHLH != other.IACHBBGOHLH)
		{
			return false;
		}
		if (PHHLMDICENJ != other.PHHLMDICENJ)
		{
			return false;
		}
		if (CHODEHNFCLJ != other.CHODEHNFCLJ)
		{
			return false;
		}
		if (PLIJJNGPEIM != other.PLIJJNGPEIM)
		{
			return false;
		}
		if (CBKNDPBFBJL != other.CBKNDPBFBJL)
		{
			return false;
		}
		if (IMKAOJLJIDK != other.IMKAOJLJIDK)
		{
			return false;
		}
		if (LFBBONLCFPH != other.LFBBONLCFPH)
		{
			return false;
		}
		if (LMPNJDMGOBB != other.LMPNJDMGOBB)
		{
			return false;
		}
		if (GENOMEOLOJB != other.GENOMEOLOJB)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (OLDBJILBGLD != other.OLDBJILBGLD)
		{
			return false;
		}
		if (OOPMDDKLNKP != other.OOPMDDKLNKP)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (DNGGPHPOHHD != other.DNGGPHPOHHD)
		{
			return false;
		}
		if (DKIACFLBEKD != other.DKIACFLBEKD)
		{
			return false;
		}
		if (FCBFCDAGFOA != other.FCBFCDAGFOA)
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
		if (OPIBBDHMCGO != 0)
		{
			num ^= OPIBBDHMCGO.GetHashCode();
		}
		if (DHNDLHLNMJB != 0)
		{
			num ^= DHNDLHLNMJB.GetHashCode();
		}
		if (FJGCNBDBMMG != 0)
		{
			num ^= FJGCNBDBMMG.GetHashCode();
		}
		if (BKAANCLCOAH != 0)
		{
			num ^= BKAANCLCOAH.GetHashCode();
		}
		if (LBPBGNJFAIO != 0)
		{
			num ^= LBPBGNJFAIO.GetHashCode();
		}
		if (CHDNOCOLLHJ != 0)
		{
			num ^= CHDNOCOLLHJ.GetHashCode();
		}
		if (IACHBBGOHLH != 0)
		{
			num ^= IACHBBGOHLH.GetHashCode();
		}
		if (PHHLMDICENJ != 0)
		{
			num ^= PHHLMDICENJ.GetHashCode();
		}
		if (CHODEHNFCLJ != 0)
		{
			num ^= CHODEHNFCLJ.GetHashCode();
		}
		if (PLIJJNGPEIM != 0)
		{
			num ^= PLIJJNGPEIM.GetHashCode();
		}
		if (CBKNDPBFBJL != 0)
		{
			num ^= CBKNDPBFBJL.GetHashCode();
		}
		if (IMKAOJLJIDK != 0)
		{
			num ^= IMKAOJLJIDK.GetHashCode();
		}
		if (LFBBONLCFPH != 0)
		{
			num ^= LFBBONLCFPH.GetHashCode();
		}
		if (LMPNJDMGOBB != 0)
		{
			num ^= LMPNJDMGOBB.GetHashCode();
		}
		if (GENOMEOLOJB != 0)
		{
			num ^= GENOMEOLOJB.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (OLDBJILBGLD.Length != 0)
		{
			num ^= OLDBJILBGLD.GetHashCode();
		}
		if (OOPMDDKLNKP.Length != 0)
		{
			num ^= OOPMDDKLNKP.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (DNGGPHPOHHD.Length != 0)
		{
			num ^= DNGGPHPOHHD.GetHashCode();
		}
		if (DKIACFLBEKD != 0)
		{
			num ^= DKIACFLBEKD.GetHashCode();
		}
		if (FCBFCDAGFOA.Length != 0)
		{
			num ^= FCBFCDAGFOA.GetHashCode();
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
		if (OPIBBDHMCGO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OPIBBDHMCGO);
		}
		if (DHNDLHLNMJB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DHNDLHLNMJB);
		}
		if (FJGCNBDBMMG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FJGCNBDBMMG);
		}
		if (BKAANCLCOAH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BKAANCLCOAH);
		}
		if (LBPBGNJFAIO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LBPBGNJFAIO);
		}
		if (CHDNOCOLLHJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CHDNOCOLLHJ);
		}
		if (IACHBBGOHLH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IACHBBGOHLH);
		}
		if (PHHLMDICENJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PHHLMDICENJ);
		}
		if (CHODEHNFCLJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CHODEHNFCLJ);
		}
		if (PLIJJNGPEIM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PLIJJNGPEIM);
		}
		if (CBKNDPBFBJL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CBKNDPBFBJL);
		}
		if (IMKAOJLJIDK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IMKAOJLJIDK);
		}
		if (LFBBONLCFPH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LFBBONLCFPH);
		}
		if (LMPNJDMGOBB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LMPNJDMGOBB);
		}
		if (GENOMEOLOJB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GENOMEOLOJB);
		}
		if (Type != 0)
		{
			output.WriteRawTag(224, 42);
			output.WriteUInt32(Type);
		}
		if (OLDBJILBGLD.Length != 0)
		{
			output.WriteRawTag(130, 86);
			output.WriteString(OLDBJILBGLD);
		}
		if (OOPMDDKLNKP.Length != 0)
		{
			output.WriteRawTag(162, 94);
			output.WriteString(OOPMDDKLNKP);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(232, 102);
			output.WriteUInt32(PanelId);
		}
		if (DNGGPHPOHHD.Length != 0)
		{
			output.WriteRawTag(170, 118);
			output.WriteString(DNGGPHPOHHD);
		}
		if (DKIACFLBEKD != 0)
		{
			output.WriteRawTag(232, 123);
			output.WriteUInt32(DKIACFLBEKD);
		}
		if (FCBFCDAGFOA.Length != 0)
		{
			output.WriteRawTag(130, 127);
			output.WriteString(FCBFCDAGFOA);
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
		if (OPIBBDHMCGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPIBBDHMCGO);
		}
		if (DHNDLHLNMJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHNDLHLNMJB);
		}
		if (FJGCNBDBMMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJGCNBDBMMG);
		}
		if (BKAANCLCOAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKAANCLCOAH);
		}
		if (LBPBGNJFAIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LBPBGNJFAIO);
		}
		if (CHDNOCOLLHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHDNOCOLLHJ);
		}
		if (IACHBBGOHLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IACHBBGOHLH);
		}
		if (PHHLMDICENJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHHLMDICENJ);
		}
		if (CHODEHNFCLJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHODEHNFCLJ);
		}
		if (PLIJJNGPEIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PLIJJNGPEIM);
		}
		if (CBKNDPBFBJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBKNDPBFBJL);
		}
		if (IMKAOJLJIDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMKAOJLJIDK);
		}
		if (LFBBONLCFPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFBBONLCFPH);
		}
		if (LMPNJDMGOBB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMPNJDMGOBB);
		}
		if (GENOMEOLOJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GENOMEOLOJB);
		}
		if (Type != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (OLDBJILBGLD.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(OLDBJILBGLD);
		}
		if (OOPMDDKLNKP.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(OOPMDDKLNKP);
		}
		if (PanelId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (DNGGPHPOHHD.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DNGGPHPOHHD);
		}
		if (DKIACFLBEKD != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DKIACFLBEKD);
		}
		if (FCBFCDAGFOA.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(FCBFCDAGFOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBBCCKMKJNE other)
	{
		if (other != null)
		{
			if (other.OPIBBDHMCGO != 0)
			{
				OPIBBDHMCGO = other.OPIBBDHMCGO;
			}
			if (other.DHNDLHLNMJB != 0)
			{
				DHNDLHLNMJB = other.DHNDLHLNMJB;
			}
			if (other.FJGCNBDBMMG != 0)
			{
				FJGCNBDBMMG = other.FJGCNBDBMMG;
			}
			if (other.BKAANCLCOAH != 0)
			{
				BKAANCLCOAH = other.BKAANCLCOAH;
			}
			if (other.LBPBGNJFAIO != 0)
			{
				LBPBGNJFAIO = other.LBPBGNJFAIO;
			}
			if (other.CHDNOCOLLHJ != 0)
			{
				CHDNOCOLLHJ = other.CHDNOCOLLHJ;
			}
			if (other.IACHBBGOHLH != 0)
			{
				IACHBBGOHLH = other.IACHBBGOHLH;
			}
			if (other.PHHLMDICENJ != 0)
			{
				PHHLMDICENJ = other.PHHLMDICENJ;
			}
			if (other.CHODEHNFCLJ != 0)
			{
				CHODEHNFCLJ = other.CHODEHNFCLJ;
			}
			if (other.PLIJJNGPEIM != 0)
			{
				PLIJJNGPEIM = other.PLIJJNGPEIM;
			}
			if (other.CBKNDPBFBJL != 0)
			{
				CBKNDPBFBJL = other.CBKNDPBFBJL;
			}
			if (other.IMKAOJLJIDK != 0)
			{
				IMKAOJLJIDK = other.IMKAOJLJIDK;
			}
			if (other.LFBBONLCFPH != 0)
			{
				LFBBONLCFPH = other.LFBBONLCFPH;
			}
			if (other.LMPNJDMGOBB != 0)
			{
				LMPNJDMGOBB = other.LMPNJDMGOBB;
			}
			if (other.GENOMEOLOJB != 0)
			{
				GENOMEOLOJB = other.GENOMEOLOJB;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.OLDBJILBGLD.Length != 0)
			{
				OLDBJILBGLD = other.OLDBJILBGLD;
			}
			if (other.OOPMDDKLNKP.Length != 0)
			{
				OOPMDDKLNKP = other.OOPMDDKLNKP;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.DNGGPHPOHHD.Length != 0)
			{
				DNGGPHPOHHD = other.DNGGPHPOHHD;
			}
			if (other.DKIACFLBEKD != 0)
			{
				DKIACFLBEKD = other.DKIACFLBEKD;
			}
			if (other.FCBFCDAGFOA.Length != 0)
			{
				FCBFCDAGFOA = other.FCBFCDAGFOA;
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
				OPIBBDHMCGO = input.ReadUInt32();
				break;
			case 16u:
				DHNDLHLNMJB = input.ReadUInt32();
				break;
			case 24u:
				FJGCNBDBMMG = input.ReadUInt32();
				break;
			case 32u:
				BKAANCLCOAH = input.ReadUInt32();
				break;
			case 40u:
				LBPBGNJFAIO = input.ReadUInt32();
				break;
			case 48u:
				CHDNOCOLLHJ = input.ReadUInt32();
				break;
			case 56u:
				IACHBBGOHLH = input.ReadUInt32();
				break;
			case 64u:
				PHHLMDICENJ = input.ReadUInt32();
				break;
			case 72u:
				CHODEHNFCLJ = input.ReadUInt32();
				break;
			case 80u:
				PLIJJNGPEIM = input.ReadUInt32();
				break;
			case 88u:
				CBKNDPBFBJL = input.ReadUInt32();
				break;
			case 96u:
				IMKAOJLJIDK = input.ReadUInt32();
				break;
			case 104u:
				LFBBONLCFPH = input.ReadUInt32();
				break;
			case 112u:
				LMPNJDMGOBB = input.ReadUInt32();
				break;
			case 120u:
				GENOMEOLOJB = input.ReadUInt32();
				break;
			case 5472u:
				Type = input.ReadUInt32();
				break;
			case 11010u:
				OLDBJILBGLD = input.ReadString();
				break;
			case 12066u:
				OOPMDDKLNKP = input.ReadString();
				break;
			case 13160u:
				PanelId = input.ReadUInt32();
				break;
			case 15146u:
				DNGGPHPOHHD = input.ReadString();
				break;
			case 15848u:
				DKIACFLBEKD = input.ReadUInt32();
				break;
			case 16258u:
				FCBFCDAGFOA = input.ReadString();
				break;
			}
		}
	}
}
