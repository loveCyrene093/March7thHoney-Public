using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FAIGHIPDKIG : IMessage<FAIGHIPDKIG>, IMessage, IEquatable<FAIGHIPDKIG>, IDeepCloneable<FAIGHIPDKIG>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		FMLNKEKMJIK = 1,
		KHCPHHIPOHJ = 2,
		BLBGFIGJBND = 4,
		NOANCKEBBDN = 5,
		APLGILKDAFJ = 8,
		PHONCGCFKGN = 9,
		JCEMJBMMCOG = 10,
		IMBFCCNNGPD = 12,
		ACFCPLKAIJG = 13,
		BDJFACMKPJN = 15,
		NMNOCJDJKOG = 185,
		GGJPCCHNHFB = 738,
		HAILIAKHDKN = 1394,
		IBEFAHEKCLB = 1453,
		GIGHOAEIDDF = 2013
	}

	private static readonly MessageParser<FAIGHIPDKIG> _parser = new MessageParser<FAIGHIPDKIG>(() => new FAIGHIPDKIG());

	private UnknownFieldSet _unknownFields;

	public const int FMLNKEKMJIKFieldNumber = 1;

	public const int KHCPHHIPOHJFieldNumber = 2;

	public const int BLBGFIGJBNDFieldNumber = 4;

	public const int NOANCKEBBDNFieldNumber = 5;

	public const int APLGILKDAFJFieldNumber = 8;

	public const int PHONCGCFKGNFieldNumber = 9;

	public const int JCEMJBMMCOGFieldNumber = 10;

	public const int IMBFCCNNGPDFieldNumber = 12;

	public const int ACFCPLKAIJGFieldNumber = 13;

	public const int BDJFACMKPJNFieldNumber = 15;

	public const int NMNOCJDJKOGFieldNumber = 185;

	public const int GGJPCCHNHFBFieldNumber = 738;

	public const int HAILIAKHDKNFieldNumber = 1394;

	public const int IBEFAHEKCLBFieldNumber = 1453;

	public const int GIGHOAEIDDFFieldNumber = 2013;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FAIGHIPDKIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FAIGHIPDKIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FMLNKEKMJIK
	{
		get
		{
			if (!HasFMLNKEKMJIK)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.FMLNKEKMJIK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFMLNKEKMJIK => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FMLNKEKMJIK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHCPHHIPOHJ
	{
		get
		{
			if (!HasKHCPHHIPOHJ)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.KHCPHHIPOHJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKHCPHHIPOHJ => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KHCPHHIPOHJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BLBGFIGJBND
	{
		get
		{
			if (!HasBLBGFIGJBND)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.BLBGFIGJBND;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBLBGFIGJBND => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BLBGFIGJBND;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMPODELCHFD NOANCKEBBDN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NOANCKEBBDN)
			{
				return null;
			}
			return (OMPODELCHFD)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NOANCKEBBDN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APLGILKDAFJ
	{
		get
		{
			if (!HasAPLGILKDAFJ)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.APLGILKDAFJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAPLGILKDAFJ => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.APLGILKDAFJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLJLHPEOIOC PHONCGCFKGN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PHONCGCFKGN)
			{
				return null;
			}
			return (NLJLHPEOIOC)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PHONCGCFKGN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADPDKFBHJPN JCEMJBMMCOG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JCEMJBMMCOG)
			{
				return null;
			}
			return (ADPDKFBHJPN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JCEMJBMMCOG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMBFCCNNGPD
	{
		get
		{
			if (!HasIMBFCCNNGPD)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.IMBFCCNNGPD;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasIMBFCCNNGPD => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IMBFCCNNGPD;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJJJCCIOHDK ACFCPLKAIJG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.ACFCPLKAIJG)
			{
				return null;
			}
			return (KJJJCCIOHDK)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.ACFCPLKAIJG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMCEJJJOCAP BDJFACMKPJN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.BDJFACMKPJN)
			{
				return null;
			}
			return (DMCEJJJOCAP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.BDJFACMKPJN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNPOHCGPDFP NMNOCJDJKOG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NMNOCJDJKOG)
			{
				return null;
			}
			return (CNPOHCGPDFP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NMNOCJDJKOG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKDEKJKOIJN GGJPCCHNHFB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.GGJPCCHNHFB)
			{
				return null;
			}
			return (GKDEKJKOIJN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.GGJPCCHNHFB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HAILIAKHDKN
	{
		get
		{
			if (!HasHAILIAKHDKN)
			{
				return false;
			}
			return (bool)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.HAILIAKHDKN;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHAILIAKHDKN => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HAILIAKHDKN;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAGAEJKHFPO IBEFAHEKCLB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.IBEFAHEKCLB)
			{
				return null;
			}
			return (PAGAEJKHFPO)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.IBEFAHEKCLB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIGHOAEIDDF
	{
		get
		{
			if (!HasGIGHOAEIDDF)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.GIGHOAEIDDF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGIGHOAEIDDF => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GIGHOAEIDDF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAIGHIPDKIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAIGHIPDKIG(FAIGHIPDKIG other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.FMLNKEKMJIK:
			FMLNKEKMJIK = other.FMLNKEKMJIK;
			break;
		case NLPPPCHGGPFOneofCase.KHCPHHIPOHJ:
			KHCPHHIPOHJ = other.KHCPHHIPOHJ;
			break;
		case NLPPPCHGGPFOneofCase.BLBGFIGJBND:
			BLBGFIGJBND = other.BLBGFIGJBND;
			break;
		case NLPPPCHGGPFOneofCase.NOANCKEBBDN:
			NOANCKEBBDN = other.NOANCKEBBDN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.APLGILKDAFJ:
			APLGILKDAFJ = other.APLGILKDAFJ;
			break;
		case NLPPPCHGGPFOneofCase.PHONCGCFKGN:
			PHONCGCFKGN = other.PHONCGCFKGN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JCEMJBMMCOG:
			JCEMJBMMCOG = other.JCEMJBMMCOG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.IMBFCCNNGPD:
			IMBFCCNNGPD = other.IMBFCCNNGPD;
			break;
		case NLPPPCHGGPFOneofCase.ACFCPLKAIJG:
			ACFCPLKAIJG = other.ACFCPLKAIJG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.BDJFACMKPJN:
			BDJFACMKPJN = other.BDJFACMKPJN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NMNOCJDJKOG:
			NMNOCJDJKOG = other.NMNOCJDJKOG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.GGJPCCHNHFB:
			GGJPCCHNHFB = other.GGJPCCHNHFB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.HAILIAKHDKN:
			HAILIAKHDKN = other.HAILIAKHDKN;
			break;
		case NLPPPCHGGPFOneofCase.IBEFAHEKCLB:
			IBEFAHEKCLB = other.IBEFAHEKCLB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.GIGHOAEIDDF:
			GIGHOAEIDDF = other.GIGHOAEIDDF;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAIGHIPDKIG Clone()
	{
		return new FAIGHIPDKIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFMLNKEKMJIK()
	{
		if (HasFMLNKEKMJIK)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKHCPHHIPOHJ()
	{
		if (HasKHCPHHIPOHJ)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBLBGFIGJBND()
	{
		if (HasBLBGFIGJBND)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAPLGILKDAFJ()
	{
		if (HasAPLGILKDAFJ)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearIMBFCCNNGPD()
	{
		if (HasIMBFCCNNGPD)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHAILIAKHDKN()
	{
		if (HasHAILIAKHDKN)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGIGHOAEIDDF()
	{
		if (HasGIGHOAEIDDF)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FAIGHIPDKIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FAIGHIPDKIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FMLNKEKMJIK != other.FMLNKEKMJIK)
		{
			return false;
		}
		if (KHCPHHIPOHJ != other.KHCPHHIPOHJ)
		{
			return false;
		}
		if (BLBGFIGJBND != other.BLBGFIGJBND)
		{
			return false;
		}
		if (!object.Equals(NOANCKEBBDN, other.NOANCKEBBDN))
		{
			return false;
		}
		if (APLGILKDAFJ != other.APLGILKDAFJ)
		{
			return false;
		}
		if (!object.Equals(PHONCGCFKGN, other.PHONCGCFKGN))
		{
			return false;
		}
		if (!object.Equals(JCEMJBMMCOG, other.JCEMJBMMCOG))
		{
			return false;
		}
		if (IMBFCCNNGPD != other.IMBFCCNNGPD)
		{
			return false;
		}
		if (!object.Equals(ACFCPLKAIJG, other.ACFCPLKAIJG))
		{
			return false;
		}
		if (!object.Equals(BDJFACMKPJN, other.BDJFACMKPJN))
		{
			return false;
		}
		if (!object.Equals(NMNOCJDJKOG, other.NMNOCJDJKOG))
		{
			return false;
		}
		if (!object.Equals(GGJPCCHNHFB, other.GGJPCCHNHFB))
		{
			return false;
		}
		if (HAILIAKHDKN != other.HAILIAKHDKN)
		{
			return false;
		}
		if (!object.Equals(IBEFAHEKCLB, other.IBEFAHEKCLB))
		{
			return false;
		}
		if (GIGHOAEIDDF != other.GIGHOAEIDDF)
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (HasFMLNKEKMJIK)
		{
			num ^= FMLNKEKMJIK.GetHashCode();
		}
		if (HasKHCPHHIPOHJ)
		{
			num ^= KHCPHHIPOHJ.GetHashCode();
		}
		if (HasBLBGFIGJBND)
		{
			num ^= BLBGFIGJBND.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NOANCKEBBDN)
		{
			num ^= NOANCKEBBDN.GetHashCode();
		}
		if (HasAPLGILKDAFJ)
		{
			num ^= APLGILKDAFJ.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHONCGCFKGN)
		{
			num ^= PHONCGCFKGN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JCEMJBMMCOG)
		{
			num ^= JCEMJBMMCOG.GetHashCode();
		}
		if (HasIMBFCCNNGPD)
		{
			num ^= IMBFCCNNGPD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ACFCPLKAIJG)
		{
			num ^= ACFCPLKAIJG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BDJFACMKPJN)
		{
			num ^= BDJFACMKPJN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NMNOCJDJKOG)
		{
			num ^= NMNOCJDJKOG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGJPCCHNHFB)
		{
			num ^= GGJPCCHNHFB.GetHashCode();
		}
		if (HasHAILIAKHDKN)
		{
			num ^= HAILIAKHDKN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IBEFAHEKCLB)
		{
			num ^= IBEFAHEKCLB.GetHashCode();
		}
		if (HasGIGHOAEIDDF)
		{
			num ^= GIGHOAEIDDF.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
		if (HasFMLNKEKMJIK)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FMLNKEKMJIK);
		}
		if (HasKHCPHHIPOHJ)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KHCPHHIPOHJ);
		}
		if (HasBLBGFIGJBND)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BLBGFIGJBND);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NOANCKEBBDN)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NOANCKEBBDN);
		}
		if (HasAPLGILKDAFJ)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(APLGILKDAFJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHONCGCFKGN)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PHONCGCFKGN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JCEMJBMMCOG)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JCEMJBMMCOG);
		}
		if (HasIMBFCCNNGPD)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IMBFCCNNGPD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ACFCPLKAIJG)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ACFCPLKAIJG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BDJFACMKPJN)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BDJFACMKPJN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NMNOCJDJKOG)
		{
			output.WriteRawTag(202, 11);
			output.WriteMessage(NMNOCJDJKOG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGJPCCHNHFB)
		{
			output.WriteRawTag(146, 46);
			output.WriteMessage(GGJPCCHNHFB);
		}
		if (HasHAILIAKHDKN)
		{
			output.WriteRawTag(144, 87);
			output.WriteBool(HAILIAKHDKN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IBEFAHEKCLB)
		{
			output.WriteRawTag(234, 90);
			output.WriteMessage(IBEFAHEKCLB);
		}
		if (HasGIGHOAEIDDF)
		{
			output.WriteRawTag(232, 125);
			output.WriteUInt32(GIGHOAEIDDF);
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
		if (HasFMLNKEKMJIK)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FMLNKEKMJIK);
		}
		if (HasKHCPHHIPOHJ)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHCPHHIPOHJ);
		}
		if (HasBLBGFIGJBND)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BLBGFIGJBND);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NOANCKEBBDN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOANCKEBBDN);
		}
		if (HasAPLGILKDAFJ)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APLGILKDAFJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHONCGCFKGN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PHONCGCFKGN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JCEMJBMMCOG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JCEMJBMMCOG);
		}
		if (HasIMBFCCNNGPD)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMBFCCNNGPD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ACFCPLKAIJG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ACFCPLKAIJG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BDJFACMKPJN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDJFACMKPJN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NMNOCJDJKOG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NMNOCJDJKOG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGJPCCHNHFB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GGJPCCHNHFB);
		}
		if (HasHAILIAKHDKN)
		{
			num += 3;
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IBEFAHEKCLB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IBEFAHEKCLB);
		}
		if (HasGIGHOAEIDDF)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GIGHOAEIDDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FAIGHIPDKIG other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.FMLNKEKMJIK:
			FMLNKEKMJIK = other.FMLNKEKMJIK;
			break;
		case NLPPPCHGGPFOneofCase.KHCPHHIPOHJ:
			KHCPHHIPOHJ = other.KHCPHHIPOHJ;
			break;
		case NLPPPCHGGPFOneofCase.BLBGFIGJBND:
			BLBGFIGJBND = other.BLBGFIGJBND;
			break;
		case NLPPPCHGGPFOneofCase.NOANCKEBBDN:
			if (NOANCKEBBDN == null)
			{
				NOANCKEBBDN = new OMPODELCHFD();
			}
			NOANCKEBBDN.MergeFrom(other.NOANCKEBBDN);
			break;
		case NLPPPCHGGPFOneofCase.APLGILKDAFJ:
			APLGILKDAFJ = other.APLGILKDAFJ;
			break;
		case NLPPPCHGGPFOneofCase.PHONCGCFKGN:
			if (PHONCGCFKGN == null)
			{
				PHONCGCFKGN = new NLJLHPEOIOC();
			}
			PHONCGCFKGN.MergeFrom(other.PHONCGCFKGN);
			break;
		case NLPPPCHGGPFOneofCase.JCEMJBMMCOG:
			if (JCEMJBMMCOG == null)
			{
				JCEMJBMMCOG = new ADPDKFBHJPN();
			}
			JCEMJBMMCOG.MergeFrom(other.JCEMJBMMCOG);
			break;
		case NLPPPCHGGPFOneofCase.IMBFCCNNGPD:
			IMBFCCNNGPD = other.IMBFCCNNGPD;
			break;
		case NLPPPCHGGPFOneofCase.ACFCPLKAIJG:
			if (ACFCPLKAIJG == null)
			{
				ACFCPLKAIJG = new KJJJCCIOHDK();
			}
			ACFCPLKAIJG.MergeFrom(other.ACFCPLKAIJG);
			break;
		case NLPPPCHGGPFOneofCase.BDJFACMKPJN:
			if (BDJFACMKPJN == null)
			{
				BDJFACMKPJN = new DMCEJJJOCAP();
			}
			BDJFACMKPJN.MergeFrom(other.BDJFACMKPJN);
			break;
		case NLPPPCHGGPFOneofCase.NMNOCJDJKOG:
			if (NMNOCJDJKOG == null)
			{
				NMNOCJDJKOG = new CNPOHCGPDFP();
			}
			NMNOCJDJKOG.MergeFrom(other.NMNOCJDJKOG);
			break;
		case NLPPPCHGGPFOneofCase.GGJPCCHNHFB:
			if (GGJPCCHNHFB == null)
			{
				GGJPCCHNHFB = new GKDEKJKOIJN();
			}
			GGJPCCHNHFB.MergeFrom(other.GGJPCCHNHFB);
			break;
		case NLPPPCHGGPFOneofCase.HAILIAKHDKN:
			HAILIAKHDKN = other.HAILIAKHDKN;
			break;
		case NLPPPCHGGPFOneofCase.IBEFAHEKCLB:
			if (IBEFAHEKCLB == null)
			{
				IBEFAHEKCLB = new PAGAEJKHFPO();
			}
			IBEFAHEKCLB.MergeFrom(other.IBEFAHEKCLB);
			break;
		case NLPPPCHGGPFOneofCase.GIGHOAEIDDF:
			GIGHOAEIDDF = other.GIGHOAEIDDF;
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
			case 8u:
				FMLNKEKMJIK = input.ReadUInt32();
				break;
			case 16u:
				KHCPHHIPOHJ = input.ReadUInt32();
				break;
			case 32u:
				BLBGFIGJBND = input.ReadUInt32();
				break;
			case 42u:
			{
				OMPODELCHFD oMPODELCHFD = new OMPODELCHFD();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NOANCKEBBDN)
				{
					oMPODELCHFD.MergeFrom(NOANCKEBBDN);
				}
				input.ReadMessage(oMPODELCHFD);
				NOANCKEBBDN = oMPODELCHFD;
				break;
			}
			case 64u:
				APLGILKDAFJ = input.ReadUInt32();
				break;
			case 74u:
			{
				NLJLHPEOIOC nLJLHPEOIOC = new NLJLHPEOIOC();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHONCGCFKGN)
				{
					nLJLHPEOIOC.MergeFrom(PHONCGCFKGN);
				}
				input.ReadMessage(nLJLHPEOIOC);
				PHONCGCFKGN = nLJLHPEOIOC;
				break;
			}
			case 82u:
			{
				ADPDKFBHJPN aDPDKFBHJPN = new ADPDKFBHJPN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JCEMJBMMCOG)
				{
					aDPDKFBHJPN.MergeFrom(JCEMJBMMCOG);
				}
				input.ReadMessage(aDPDKFBHJPN);
				JCEMJBMMCOG = aDPDKFBHJPN;
				break;
			}
			case 96u:
				IMBFCCNNGPD = input.ReadUInt32();
				break;
			case 106u:
			{
				KJJJCCIOHDK kJJJCCIOHDK = new KJJJCCIOHDK();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ACFCPLKAIJG)
				{
					kJJJCCIOHDK.MergeFrom(ACFCPLKAIJG);
				}
				input.ReadMessage(kJJJCCIOHDK);
				ACFCPLKAIJG = kJJJCCIOHDK;
				break;
			}
			case 122u:
			{
				DMCEJJJOCAP dMCEJJJOCAP = new DMCEJJJOCAP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BDJFACMKPJN)
				{
					dMCEJJJOCAP.MergeFrom(BDJFACMKPJN);
				}
				input.ReadMessage(dMCEJJJOCAP);
				BDJFACMKPJN = dMCEJJJOCAP;
				break;
			}
			case 1482u:
			{
				CNPOHCGPDFP cNPOHCGPDFP = new CNPOHCGPDFP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NMNOCJDJKOG)
				{
					cNPOHCGPDFP.MergeFrom(NMNOCJDJKOG);
				}
				input.ReadMessage(cNPOHCGPDFP);
				NMNOCJDJKOG = cNPOHCGPDFP;
				break;
			}
			case 5906u:
			{
				GKDEKJKOIJN gKDEKJKOIJN = new GKDEKJKOIJN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGJPCCHNHFB)
				{
					gKDEKJKOIJN.MergeFrom(GGJPCCHNHFB);
				}
				input.ReadMessage(gKDEKJKOIJN);
				GGJPCCHNHFB = gKDEKJKOIJN;
				break;
			}
			case 11152u:
				HAILIAKHDKN = input.ReadBool();
				break;
			case 11626u:
			{
				PAGAEJKHFPO pAGAEJKHFPO = new PAGAEJKHFPO();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IBEFAHEKCLB)
				{
					pAGAEJKHFPO.MergeFrom(IBEFAHEKCLB);
				}
				input.ReadMessage(pAGAEJKHFPO);
				IBEFAHEKCLB = pAGAEJKHFPO;
				break;
			}
			case 16104u:
				GIGHOAEIDDF = input.ReadUInt32();
				break;
			}
		}
	}
}
