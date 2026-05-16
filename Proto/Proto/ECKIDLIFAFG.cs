using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ECKIDLIFAFG : IMessage<ECKIDLIFAFG>, IMessage, IEquatable<ECKIDLIFAFG>, IDeepCloneable<ECKIDLIFAFG>, IBufferMessage
{
	private static readonly MessageParser<ECKIDLIFAFG> _parser = new MessageParser<ECKIDLIFAFG>(() => new ECKIDLIFAFG());

	private UnknownFieldSet _unknownFields;

	public const int PCPELPMKMCIFieldNumber = 1;

	private uint pCPELPMKMCI_;

	public const int MGIAPAEKOMBFieldNumber = 2;

	private uint mGIAPAEKOMB_;

	public const int IPGMEHBCJCOFieldNumber = 3;

	private uint iPGMEHBCJCO_;

	public const int MKALAGHLBPFFieldNumber = 4;

	private uint mKALAGHLBPF_;

	public const int BNEOOJJKKFMFieldNumber = 5;

	private uint bNEOOJJKKFM_;

	public const int LGIKOOEFLJMFieldNumber = 6;

	private uint lGIKOOEFLJM_;

	public const int BJBPFMMNDCMFieldNumber = 7;

	private uint bJBPFMMNDCM_;

	public const int EAJKJJADFLPFieldNumber = 8;

	private uint eAJKJJADFLP_;

	public const int BEDFEJONFNKFieldNumber = 9;

	private uint bEDFEJONFNK_;

	public const int OFAPPJDDIMMFieldNumber = 10;

	private uint oFAPPJDDIMM_;

	public const int CHCJICCNKBJFieldNumber = 11;

	private uint cHCJICCNKBJ_;

	public const int OCJEMODOHIKFieldNumber = 12;

	private uint oCJEMODOHIK_;

	public const int JFBPCDGCBNLFieldNumber = 13;

	private uint jFBPCDGCBNL_;

	public const int AKPAPLCNPDCFieldNumber = 14;

	private uint aKPAPLCNPDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ECKIDLIFAFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ECKIDLIFAFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PCPELPMKMCI
	{
		get
		{
			return pCPELPMKMCI_;
		}
		set
		{
			pCPELPMKMCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGIAPAEKOMB
	{
		get
		{
			return mGIAPAEKOMB_;
		}
		set
		{
			mGIAPAEKOMB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPGMEHBCJCO
	{
		get
		{
			return iPGMEHBCJCO_;
		}
		set
		{
			iPGMEHBCJCO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKALAGHLBPF
	{
		get
		{
			return mKALAGHLBPF_;
		}
		set
		{
			mKALAGHLBPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNEOOJJKKFM
	{
		get
		{
			return bNEOOJJKKFM_;
		}
		set
		{
			bNEOOJJKKFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGIKOOEFLJM
	{
		get
		{
			return lGIKOOEFLJM_;
		}
		set
		{
			lGIKOOEFLJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BJBPFMMNDCM
	{
		get
		{
			return bJBPFMMNDCM_;
		}
		set
		{
			bJBPFMMNDCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EAJKJJADFLP
	{
		get
		{
			return eAJKJJADFLP_;
		}
		set
		{
			eAJKJJADFLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEDFEJONFNK
	{
		get
		{
			return bEDFEJONFNK_;
		}
		set
		{
			bEDFEJONFNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFAPPJDDIMM
	{
		get
		{
			return oFAPPJDDIMM_;
		}
		set
		{
			oFAPPJDDIMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHCJICCNKBJ
	{
		get
		{
			return cHCJICCNKBJ_;
		}
		set
		{
			cHCJICCNKBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OCJEMODOHIK
	{
		get
		{
			return oCJEMODOHIK_;
		}
		set
		{
			oCJEMODOHIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFBPCDGCBNL
	{
		get
		{
			return jFBPCDGCBNL_;
		}
		set
		{
			jFBPCDGCBNL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKPAPLCNPDC
	{
		get
		{
			return aKPAPLCNPDC_;
		}
		set
		{
			aKPAPLCNPDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG(ECKIDLIFAFG other)
		: this()
	{
		pCPELPMKMCI_ = other.pCPELPMKMCI_;
		mGIAPAEKOMB_ = other.mGIAPAEKOMB_;
		iPGMEHBCJCO_ = other.iPGMEHBCJCO_;
		mKALAGHLBPF_ = other.mKALAGHLBPF_;
		bNEOOJJKKFM_ = other.bNEOOJJKKFM_;
		lGIKOOEFLJM_ = other.lGIKOOEFLJM_;
		bJBPFMMNDCM_ = other.bJBPFMMNDCM_;
		eAJKJJADFLP_ = other.eAJKJJADFLP_;
		bEDFEJONFNK_ = other.bEDFEJONFNK_;
		oFAPPJDDIMM_ = other.oFAPPJDDIMM_;
		cHCJICCNKBJ_ = other.cHCJICCNKBJ_;
		oCJEMODOHIK_ = other.oCJEMODOHIK_;
		jFBPCDGCBNL_ = other.jFBPCDGCBNL_;
		aKPAPLCNPDC_ = other.aKPAPLCNPDC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG Clone()
	{
		return new ECKIDLIFAFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ECKIDLIFAFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ECKIDLIFAFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PCPELPMKMCI != other.PCPELPMKMCI)
		{
			return false;
		}
		if (MGIAPAEKOMB != other.MGIAPAEKOMB)
		{
			return false;
		}
		if (IPGMEHBCJCO != other.IPGMEHBCJCO)
		{
			return false;
		}
		if (MKALAGHLBPF != other.MKALAGHLBPF)
		{
			return false;
		}
		if (BNEOOJJKKFM != other.BNEOOJJKKFM)
		{
			return false;
		}
		if (LGIKOOEFLJM != other.LGIKOOEFLJM)
		{
			return false;
		}
		if (BJBPFMMNDCM != other.BJBPFMMNDCM)
		{
			return false;
		}
		if (EAJKJJADFLP != other.EAJKJJADFLP)
		{
			return false;
		}
		if (BEDFEJONFNK != other.BEDFEJONFNK)
		{
			return false;
		}
		if (OFAPPJDDIMM != other.OFAPPJDDIMM)
		{
			return false;
		}
		if (CHCJICCNKBJ != other.CHCJICCNKBJ)
		{
			return false;
		}
		if (OCJEMODOHIK != other.OCJEMODOHIK)
		{
			return false;
		}
		if (JFBPCDGCBNL != other.JFBPCDGCBNL)
		{
			return false;
		}
		if (AKPAPLCNPDC != other.AKPAPLCNPDC)
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
		if (PCPELPMKMCI != 0)
		{
			num ^= PCPELPMKMCI.GetHashCode();
		}
		if (MGIAPAEKOMB != 0)
		{
			num ^= MGIAPAEKOMB.GetHashCode();
		}
		if (IPGMEHBCJCO != 0)
		{
			num ^= IPGMEHBCJCO.GetHashCode();
		}
		if (MKALAGHLBPF != 0)
		{
			num ^= MKALAGHLBPF.GetHashCode();
		}
		if (BNEOOJJKKFM != 0)
		{
			num ^= BNEOOJJKKFM.GetHashCode();
		}
		if (LGIKOOEFLJM != 0)
		{
			num ^= LGIKOOEFLJM.GetHashCode();
		}
		if (BJBPFMMNDCM != 0)
		{
			num ^= BJBPFMMNDCM.GetHashCode();
		}
		if (EAJKJJADFLP != 0)
		{
			num ^= EAJKJJADFLP.GetHashCode();
		}
		if (BEDFEJONFNK != 0)
		{
			num ^= BEDFEJONFNK.GetHashCode();
		}
		if (OFAPPJDDIMM != 0)
		{
			num ^= OFAPPJDDIMM.GetHashCode();
		}
		if (CHCJICCNKBJ != 0)
		{
			num ^= CHCJICCNKBJ.GetHashCode();
		}
		if (OCJEMODOHIK != 0)
		{
			num ^= OCJEMODOHIK.GetHashCode();
		}
		if (JFBPCDGCBNL != 0)
		{
			num ^= JFBPCDGCBNL.GetHashCode();
		}
		if (AKPAPLCNPDC != 0)
		{
			num ^= AKPAPLCNPDC.GetHashCode();
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
		if (PCPELPMKMCI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PCPELPMKMCI);
		}
		if (MGIAPAEKOMB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MGIAPAEKOMB);
		}
		if (IPGMEHBCJCO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IPGMEHBCJCO);
		}
		if (MKALAGHLBPF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MKALAGHLBPF);
		}
		if (BNEOOJJKKFM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BNEOOJJKKFM);
		}
		if (LGIKOOEFLJM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LGIKOOEFLJM);
		}
		if (BJBPFMMNDCM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BJBPFMMNDCM);
		}
		if (EAJKJJADFLP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EAJKJJADFLP);
		}
		if (BEDFEJONFNK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BEDFEJONFNK);
		}
		if (OFAPPJDDIMM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OFAPPJDDIMM);
		}
		if (CHCJICCNKBJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CHCJICCNKBJ);
		}
		if (OCJEMODOHIK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OCJEMODOHIK);
		}
		if (JFBPCDGCBNL != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JFBPCDGCBNL);
		}
		if (AKPAPLCNPDC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AKPAPLCNPDC);
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
		if (PCPELPMKMCI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PCPELPMKMCI);
		}
		if (MGIAPAEKOMB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGIAPAEKOMB);
		}
		if (IPGMEHBCJCO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPGMEHBCJCO);
		}
		if (MKALAGHLBPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKALAGHLBPF);
		}
		if (BNEOOJJKKFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNEOOJJKKFM);
		}
		if (LGIKOOEFLJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGIKOOEFLJM);
		}
		if (BJBPFMMNDCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BJBPFMMNDCM);
		}
		if (EAJKJJADFLP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EAJKJJADFLP);
		}
		if (BEDFEJONFNK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEDFEJONFNK);
		}
		if (OFAPPJDDIMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFAPPJDDIMM);
		}
		if (CHCJICCNKBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHCJICCNKBJ);
		}
		if (OCJEMODOHIK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OCJEMODOHIK);
		}
		if (JFBPCDGCBNL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFBPCDGCBNL);
		}
		if (AKPAPLCNPDC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AKPAPLCNPDC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ECKIDLIFAFG other)
	{
		if (other != null)
		{
			if (other.PCPELPMKMCI != 0)
			{
				PCPELPMKMCI = other.PCPELPMKMCI;
			}
			if (other.MGIAPAEKOMB != 0)
			{
				MGIAPAEKOMB = other.MGIAPAEKOMB;
			}
			if (other.IPGMEHBCJCO != 0)
			{
				IPGMEHBCJCO = other.IPGMEHBCJCO;
			}
			if (other.MKALAGHLBPF != 0)
			{
				MKALAGHLBPF = other.MKALAGHLBPF;
			}
			if (other.BNEOOJJKKFM != 0)
			{
				BNEOOJJKKFM = other.BNEOOJJKKFM;
			}
			if (other.LGIKOOEFLJM != 0)
			{
				LGIKOOEFLJM = other.LGIKOOEFLJM;
			}
			if (other.BJBPFMMNDCM != 0)
			{
				BJBPFMMNDCM = other.BJBPFMMNDCM;
			}
			if (other.EAJKJJADFLP != 0)
			{
				EAJKJJADFLP = other.EAJKJJADFLP;
			}
			if (other.BEDFEJONFNK != 0)
			{
				BEDFEJONFNK = other.BEDFEJONFNK;
			}
			if (other.OFAPPJDDIMM != 0)
			{
				OFAPPJDDIMM = other.OFAPPJDDIMM;
			}
			if (other.CHCJICCNKBJ != 0)
			{
				CHCJICCNKBJ = other.CHCJICCNKBJ;
			}
			if (other.OCJEMODOHIK != 0)
			{
				OCJEMODOHIK = other.OCJEMODOHIK;
			}
			if (other.JFBPCDGCBNL != 0)
			{
				JFBPCDGCBNL = other.JFBPCDGCBNL;
			}
			if (other.AKPAPLCNPDC != 0)
			{
				AKPAPLCNPDC = other.AKPAPLCNPDC;
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
				PCPELPMKMCI = input.ReadUInt32();
				break;
			case 16u:
				MGIAPAEKOMB = input.ReadUInt32();
				break;
			case 24u:
				IPGMEHBCJCO = input.ReadUInt32();
				break;
			case 32u:
				MKALAGHLBPF = input.ReadUInt32();
				break;
			case 40u:
				BNEOOJJKKFM = input.ReadUInt32();
				break;
			case 48u:
				LGIKOOEFLJM = input.ReadUInt32();
				break;
			case 56u:
				BJBPFMMNDCM = input.ReadUInt32();
				break;
			case 64u:
				EAJKJJADFLP = input.ReadUInt32();
				break;
			case 72u:
				BEDFEJONFNK = input.ReadUInt32();
				break;
			case 80u:
				OFAPPJDDIMM = input.ReadUInt32();
				break;
			case 88u:
				CHCJICCNKBJ = input.ReadUInt32();
				break;
			case 96u:
				OCJEMODOHIK = input.ReadUInt32();
				break;
			case 104u:
				JFBPCDGCBNL = input.ReadUInt32();
				break;
			case 112u:
				AKPAPLCNPDC = input.ReadUInt32();
				break;
			}
		}
	}
}
