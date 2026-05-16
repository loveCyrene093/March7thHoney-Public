using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNFLEFIFKMN : IMessage<KNFLEFIFKMN>, IMessage, IEquatable<KNFLEFIFKMN>, IDeepCloneable<KNFLEFIFKMN>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		LDEENKDMDJK = 1,
		DFOKPKOKFOK = 2,
		JDFGFPGAGPG = 3,
		NEHJPHGALEK = 4,
		BMOLIEJFMGB = 5,
		FOGLALKHAGB = 6,
		NGLFFKAJAAD = 7,
		EHCNDFEPLOM = 8,
		HNDCCFMMNOH = 9,
		KODJPKPIHBH = 10,
		CFMDAFKGDHN = 11,
		FHGHOEFCAGG = 12,
		GFMCIODFODB = 13,
		JMGEPDEKGIH = 14,
		DNIBGDGFMGJ = 15,
		NHBMFFAGLLK = 259,
		NCCMNPGFAGK = 631,
		PFOILMHKJJM = 978,
		FLIALKEIDKD = 1209,
		CBIFAKPDNEI = 1375,
		PAKFHBLBCOM = 1596,
		JHLBDAMENAG = 1733
	}

	private static readonly MessageParser<KNFLEFIFKMN> _parser = new MessageParser<KNFLEFIFKMN>(() => new KNFLEFIFKMN());

	private UnknownFieldSet _unknownFields;

	public const int LDEENKDMDJKFieldNumber = 1;

	public const int DFOKPKOKFOKFieldNumber = 2;

	public const int JDFGFPGAGPGFieldNumber = 3;

	public const int NEHJPHGALEKFieldNumber = 4;

	public const int BMOLIEJFMGBFieldNumber = 5;

	public const int FOGLALKHAGBFieldNumber = 6;

	public const int NGLFFKAJAADFieldNumber = 7;

	public const int EHCNDFEPLOMFieldNumber = 8;

	public const int HNDCCFMMNOHFieldNumber = 9;

	public const int KODJPKPIHBHFieldNumber = 10;

	public const int CFMDAFKGDHNFieldNumber = 11;

	public const int FHGHOEFCAGGFieldNumber = 12;

	public const int GFMCIODFODBFieldNumber = 13;

	public const int JMGEPDEKGIHFieldNumber = 14;

	public const int DNIBGDGFMGJFieldNumber = 15;

	public const int NHBMFFAGLLKFieldNumber = 259;

	public const int NCCMNPGFAGKFieldNumber = 631;

	public const int PFOILMHKJJMFieldNumber = 978;

	public const int FLIALKEIDKDFieldNumber = 1209;

	public const int CBIFAKPDNEIFieldNumber = 1375;

	public const int PAKFHBLBCOMFieldNumber = 1596;

	public const int JHLBDAMENAGFieldNumber = 1733;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNFLEFIFKMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNFLEFIFKMNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECMFDCIIIHJ LDEENKDMDJK
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.LDEENKDMDJK)
			{
				return null;
			}
			return (ECMFDCIIIHJ)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.LDEENKDMDJK : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJDPFOGCIN DFOKPKOKFOK
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.DFOKPKOKFOK)
			{
				return null;
			}
			return (IIJDPFOGCIN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.DFOKPKOKFOK : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALEOPCNHNPD JDFGFPGAGPG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JDFGFPGAGPG)
			{
				return null;
			}
			return (ALEOPCNHNPD)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JDFGFPGAGPG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHAHKDLIPKF NEHJPHGALEK
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NEHJPHGALEK)
			{
				return null;
			}
			return (KHAHKDLIPKF)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NEHJPHGALEK : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNPJCNDIPOM BMOLIEJFMGB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.BMOLIEJFMGB)
			{
				return null;
			}
			return (BNPJCNDIPOM)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.BMOLIEJFMGB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKFAKPHNEPP FOGLALKHAGB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FOGLALKHAGB)
			{
				return null;
			}
			return (BKFAKPHNEPP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FOGLALKHAGB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIJKPCEHEKC NGLFFKAJAAD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NGLFFKAJAAD)
			{
				return null;
			}
			return (KIJKPCEHEKC)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NGLFFKAJAAD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODEGFOPOKAD EHCNDFEPLOM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.EHCNDFEPLOM)
			{
				return null;
			}
			return (ODEGFOPOKAD)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.EHCNDFEPLOM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBINEIHNOGC HNDCCFMMNOH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.HNDCCFMMNOH)
			{
				return null;
			}
			return (MBINEIHNOGC)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.HNDCCFMMNOH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBPOBEEODAF KODJPKPIHBH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.KODJPKPIHBH)
			{
				return null;
			}
			return (OBPOBEEODAF)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.KODJPKPIHBH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOAGJBOKKFM CFMDAFKGDHN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CFMDAFKGDHN)
			{
				return null;
			}
			return (AOAGJBOKKFM)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CFMDAFKGDHN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFNEINEOEN FHGHOEFCAGG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FHGHOEFCAGG)
			{
				return null;
			}
			return (DNFNEINEOEN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FHGHOEFCAGG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADLDDMAIFAI GFMCIODFODB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.GFMCIODFODB)
			{
				return null;
			}
			return (ADLDDMAIFAI)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.GFMCIODFODB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMDGNJPPKO JMGEPDEKGIH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JMGEPDEKGIH)
			{
				return null;
			}
			return (LBMDGNJPPKO)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JMGEPDEKGIH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGBPPHJAOAF DNIBGDGFMGJ
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.DNIBGDGFMGJ)
			{
				return null;
			}
			return (DGBPPHJAOAF)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.DNIBGDGFMGJ : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BOCNDEJFCGC NHBMFFAGLLK
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NHBMFFAGLLK)
			{
				return null;
			}
			return (BOCNDEJFCGC)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NHBMFFAGLLK : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMMIBLOHOKA NCCMNPGFAGK
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NCCMNPGFAGK)
			{
				return null;
			}
			return (EMMIBLOHOKA)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NCCMNPGFAGK : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFCAMIIAKJ PFOILMHKJJM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PFOILMHKJJM)
			{
				return null;
			}
			return (DNFCAMIIAKJ)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PFOILMHKJJM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIKCDKMPDHL FLIALKEIDKD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FLIALKEIDKD)
			{
				return null;
			}
			return (HIKCDKMPDHL)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FLIALKEIDKD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOBCGDDNII CBIFAKPDNEI
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CBIFAKPDNEI)
			{
				return null;
			}
			return (GCOBCGDDNII)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CBIFAKPDNEI : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNOCKAECKII PAKFHBLBCOM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PAKFHBLBCOM)
			{
				return null;
			}
			return (KNOCKAECKII)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PAKFHBLBCOM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLLIDMPEFOD JHLBDAMENAG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JHLBDAMENAG)
			{
				return null;
			}
			return (MLLIDMPEFOD)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JHLBDAMENAG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNFLEFIFKMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNFLEFIFKMN(KNFLEFIFKMN other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.LDEENKDMDJK:
			LDEENKDMDJK = other.LDEENKDMDJK.Clone();
			break;
		case NLPPPCHGGPFOneofCase.DFOKPKOKFOK:
			DFOKPKOKFOK = other.DFOKPKOKFOK.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JDFGFPGAGPG:
			JDFGFPGAGPG = other.JDFGFPGAGPG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NEHJPHGALEK:
			NEHJPHGALEK = other.NEHJPHGALEK.Clone();
			break;
		case NLPPPCHGGPFOneofCase.BMOLIEJFMGB:
			BMOLIEJFMGB = other.BMOLIEJFMGB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FOGLALKHAGB:
			FOGLALKHAGB = other.FOGLALKHAGB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NGLFFKAJAAD:
			NGLFFKAJAAD = other.NGLFFKAJAAD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.EHCNDFEPLOM:
			EHCNDFEPLOM = other.EHCNDFEPLOM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.HNDCCFMMNOH:
			HNDCCFMMNOH = other.HNDCCFMMNOH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.KODJPKPIHBH:
			KODJPKPIHBH = other.KODJPKPIHBH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CFMDAFKGDHN:
			CFMDAFKGDHN = other.CFMDAFKGDHN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FHGHOEFCAGG:
			FHGHOEFCAGG = other.FHGHOEFCAGG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.GFMCIODFODB:
			GFMCIODFODB = other.GFMCIODFODB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JMGEPDEKGIH:
			JMGEPDEKGIH = other.JMGEPDEKGIH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.DNIBGDGFMGJ:
			DNIBGDGFMGJ = other.DNIBGDGFMGJ.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NHBMFFAGLLK:
			NHBMFFAGLLK = other.NHBMFFAGLLK.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NCCMNPGFAGK:
			NCCMNPGFAGK = other.NCCMNPGFAGK.Clone();
			break;
		case NLPPPCHGGPFOneofCase.PFOILMHKJJM:
			PFOILMHKJJM = other.PFOILMHKJJM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FLIALKEIDKD:
			FLIALKEIDKD = other.FLIALKEIDKD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CBIFAKPDNEI:
			CBIFAKPDNEI = other.CBIFAKPDNEI.Clone();
			break;
		case NLPPPCHGGPFOneofCase.PAKFHBLBCOM:
			PAKFHBLBCOM = other.PAKFHBLBCOM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JHLBDAMENAG:
			JHLBDAMENAG = other.JHLBDAMENAG.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNFLEFIFKMN Clone()
	{
		return new KNFLEFIFKMN(this);
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
		return Equals(other as KNFLEFIFKMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNFLEFIFKMN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LDEENKDMDJK, other.LDEENKDMDJK))
		{
			return false;
		}
		if (!object.Equals(DFOKPKOKFOK, other.DFOKPKOKFOK))
		{
			return false;
		}
		if (!object.Equals(JDFGFPGAGPG, other.JDFGFPGAGPG))
		{
			return false;
		}
		if (!object.Equals(NEHJPHGALEK, other.NEHJPHGALEK))
		{
			return false;
		}
		if (!object.Equals(BMOLIEJFMGB, other.BMOLIEJFMGB))
		{
			return false;
		}
		if (!object.Equals(FOGLALKHAGB, other.FOGLALKHAGB))
		{
			return false;
		}
		if (!object.Equals(NGLFFKAJAAD, other.NGLFFKAJAAD))
		{
			return false;
		}
		if (!object.Equals(EHCNDFEPLOM, other.EHCNDFEPLOM))
		{
			return false;
		}
		if (!object.Equals(HNDCCFMMNOH, other.HNDCCFMMNOH))
		{
			return false;
		}
		if (!object.Equals(KODJPKPIHBH, other.KODJPKPIHBH))
		{
			return false;
		}
		if (!object.Equals(CFMDAFKGDHN, other.CFMDAFKGDHN))
		{
			return false;
		}
		if (!object.Equals(FHGHOEFCAGG, other.FHGHOEFCAGG))
		{
			return false;
		}
		if (!object.Equals(GFMCIODFODB, other.GFMCIODFODB))
		{
			return false;
		}
		if (!object.Equals(JMGEPDEKGIH, other.JMGEPDEKGIH))
		{
			return false;
		}
		if (!object.Equals(DNIBGDGFMGJ, other.DNIBGDGFMGJ))
		{
			return false;
		}
		if (!object.Equals(NHBMFFAGLLK, other.NHBMFFAGLLK))
		{
			return false;
		}
		if (!object.Equals(NCCMNPGFAGK, other.NCCMNPGFAGK))
		{
			return false;
		}
		if (!object.Equals(PFOILMHKJJM, other.PFOILMHKJJM))
		{
			return false;
		}
		if (!object.Equals(FLIALKEIDKD, other.FLIALKEIDKD))
		{
			return false;
		}
		if (!object.Equals(CBIFAKPDNEI, other.CBIFAKPDNEI))
		{
			return false;
		}
		if (!object.Equals(PAKFHBLBCOM, other.PAKFHBLBCOM))
		{
			return false;
		}
		if (!object.Equals(JHLBDAMENAG, other.JHLBDAMENAG))
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDEENKDMDJK)
		{
			num ^= LDEENKDMDJK.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DFOKPKOKFOK)
		{
			num ^= DFOKPKOKFOK.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JDFGFPGAGPG)
		{
			num ^= JDFGFPGAGPG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NEHJPHGALEK)
		{
			num ^= NEHJPHGALEK.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BMOLIEJFMGB)
		{
			num ^= BMOLIEJFMGB.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FOGLALKHAGB)
		{
			num ^= FOGLALKHAGB.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGLFFKAJAAD)
		{
			num ^= NGLFFKAJAAD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EHCNDFEPLOM)
		{
			num ^= EHCNDFEPLOM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HNDCCFMMNOH)
		{
			num ^= HNDCCFMMNOH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KODJPKPIHBH)
		{
			num ^= KODJPKPIHBH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CFMDAFKGDHN)
		{
			num ^= CFMDAFKGDHN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHGHOEFCAGG)
		{
			num ^= FHGHOEFCAGG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GFMCIODFODB)
		{
			num ^= GFMCIODFODB.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JMGEPDEKGIH)
		{
			num ^= JMGEPDEKGIH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DNIBGDGFMGJ)
		{
			num ^= DNIBGDGFMGJ.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHBMFFAGLLK)
		{
			num ^= NHBMFFAGLLK.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NCCMNPGFAGK)
		{
			num ^= NCCMNPGFAGK.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PFOILMHKJJM)
		{
			num ^= PFOILMHKJJM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FLIALKEIDKD)
		{
			num ^= FLIALKEIDKD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CBIFAKPDNEI)
		{
			num ^= CBIFAKPDNEI.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PAKFHBLBCOM)
		{
			num ^= PAKFHBLBCOM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JHLBDAMENAG)
		{
			num ^= JHLBDAMENAG.GetHashCode();
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDEENKDMDJK)
		{
			output.WriteRawTag(10);
			output.WriteMessage(LDEENKDMDJK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DFOKPKOKFOK)
		{
			output.WriteRawTag(18);
			output.WriteMessage(DFOKPKOKFOK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JDFGFPGAGPG)
		{
			output.WriteRawTag(26);
			output.WriteMessage(JDFGFPGAGPG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NEHJPHGALEK)
		{
			output.WriteRawTag(34);
			output.WriteMessage(NEHJPHGALEK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BMOLIEJFMGB)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BMOLIEJFMGB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FOGLALKHAGB)
		{
			output.WriteRawTag(50);
			output.WriteMessage(FOGLALKHAGB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGLFFKAJAAD)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NGLFFKAJAAD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EHCNDFEPLOM)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EHCNDFEPLOM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HNDCCFMMNOH)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HNDCCFMMNOH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KODJPKPIHBH)
		{
			output.WriteRawTag(82);
			output.WriteMessage(KODJPKPIHBH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CFMDAFKGDHN)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CFMDAFKGDHN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHGHOEFCAGG)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FHGHOEFCAGG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GFMCIODFODB)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GFMCIODFODB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JMGEPDEKGIH)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JMGEPDEKGIH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DNIBGDGFMGJ)
		{
			output.WriteRawTag(122);
			output.WriteMessage(DNIBGDGFMGJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHBMFFAGLLK)
		{
			output.WriteRawTag(154, 16);
			output.WriteMessage(NHBMFFAGLLK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NCCMNPGFAGK)
		{
			output.WriteRawTag(186, 39);
			output.WriteMessage(NCCMNPGFAGK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PFOILMHKJJM)
		{
			output.WriteRawTag(146, 61);
			output.WriteMessage(PFOILMHKJJM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FLIALKEIDKD)
		{
			output.WriteRawTag(202, 75);
			output.WriteMessage(FLIALKEIDKD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CBIFAKPDNEI)
		{
			output.WriteRawTag(250, 85);
			output.WriteMessage(CBIFAKPDNEI);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PAKFHBLBCOM)
		{
			output.WriteRawTag(226, 99);
			output.WriteMessage(PAKFHBLBCOM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JHLBDAMENAG)
		{
			output.WriteRawTag(170, 108);
			output.WriteMessage(JHLBDAMENAG);
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDEENKDMDJK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LDEENKDMDJK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DFOKPKOKFOK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DFOKPKOKFOK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JDFGFPGAGPG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JDFGFPGAGPG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NEHJPHGALEK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NEHJPHGALEK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BMOLIEJFMGB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMOLIEJFMGB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FOGLALKHAGB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FOGLALKHAGB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGLFFKAJAAD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NGLFFKAJAAD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EHCNDFEPLOM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EHCNDFEPLOM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HNDCCFMMNOH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HNDCCFMMNOH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KODJPKPIHBH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KODJPKPIHBH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CFMDAFKGDHN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CFMDAFKGDHN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHGHOEFCAGG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHGHOEFCAGG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GFMCIODFODB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GFMCIODFODB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JMGEPDEKGIH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JMGEPDEKGIH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DNIBGDGFMGJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DNIBGDGFMGJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHBMFFAGLLK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NHBMFFAGLLK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NCCMNPGFAGK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NCCMNPGFAGK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PFOILMHKJJM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PFOILMHKJJM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FLIALKEIDKD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FLIALKEIDKD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CBIFAKPDNEI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CBIFAKPDNEI);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PAKFHBLBCOM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PAKFHBLBCOM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JHLBDAMENAG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JHLBDAMENAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNFLEFIFKMN other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.LDEENKDMDJK:
			if (LDEENKDMDJK == null)
			{
				LDEENKDMDJK = new ECMFDCIIIHJ();
			}
			LDEENKDMDJK.MergeFrom(other.LDEENKDMDJK);
			break;
		case NLPPPCHGGPFOneofCase.DFOKPKOKFOK:
			if (DFOKPKOKFOK == null)
			{
				DFOKPKOKFOK = new IIJDPFOGCIN();
			}
			DFOKPKOKFOK.MergeFrom(other.DFOKPKOKFOK);
			break;
		case NLPPPCHGGPFOneofCase.JDFGFPGAGPG:
			if (JDFGFPGAGPG == null)
			{
				JDFGFPGAGPG = new ALEOPCNHNPD();
			}
			JDFGFPGAGPG.MergeFrom(other.JDFGFPGAGPG);
			break;
		case NLPPPCHGGPFOneofCase.NEHJPHGALEK:
			if (NEHJPHGALEK == null)
			{
				NEHJPHGALEK = new KHAHKDLIPKF();
			}
			NEHJPHGALEK.MergeFrom(other.NEHJPHGALEK);
			break;
		case NLPPPCHGGPFOneofCase.BMOLIEJFMGB:
			if (BMOLIEJFMGB == null)
			{
				BMOLIEJFMGB = new BNPJCNDIPOM();
			}
			BMOLIEJFMGB.MergeFrom(other.BMOLIEJFMGB);
			break;
		case NLPPPCHGGPFOneofCase.FOGLALKHAGB:
			if (FOGLALKHAGB == null)
			{
				FOGLALKHAGB = new BKFAKPHNEPP();
			}
			FOGLALKHAGB.MergeFrom(other.FOGLALKHAGB);
			break;
		case NLPPPCHGGPFOneofCase.NGLFFKAJAAD:
			if (NGLFFKAJAAD == null)
			{
				NGLFFKAJAAD = new KIJKPCEHEKC();
			}
			NGLFFKAJAAD.MergeFrom(other.NGLFFKAJAAD);
			break;
		case NLPPPCHGGPFOneofCase.EHCNDFEPLOM:
			if (EHCNDFEPLOM == null)
			{
				EHCNDFEPLOM = new ODEGFOPOKAD();
			}
			EHCNDFEPLOM.MergeFrom(other.EHCNDFEPLOM);
			break;
		case NLPPPCHGGPFOneofCase.HNDCCFMMNOH:
			if (HNDCCFMMNOH == null)
			{
				HNDCCFMMNOH = new MBINEIHNOGC();
			}
			HNDCCFMMNOH.MergeFrom(other.HNDCCFMMNOH);
			break;
		case NLPPPCHGGPFOneofCase.KODJPKPIHBH:
			if (KODJPKPIHBH == null)
			{
				KODJPKPIHBH = new OBPOBEEODAF();
			}
			KODJPKPIHBH.MergeFrom(other.KODJPKPIHBH);
			break;
		case NLPPPCHGGPFOneofCase.CFMDAFKGDHN:
			if (CFMDAFKGDHN == null)
			{
				CFMDAFKGDHN = new AOAGJBOKKFM();
			}
			CFMDAFKGDHN.MergeFrom(other.CFMDAFKGDHN);
			break;
		case NLPPPCHGGPFOneofCase.FHGHOEFCAGG:
			if (FHGHOEFCAGG == null)
			{
				FHGHOEFCAGG = new DNFNEINEOEN();
			}
			FHGHOEFCAGG.MergeFrom(other.FHGHOEFCAGG);
			break;
		case NLPPPCHGGPFOneofCase.GFMCIODFODB:
			if (GFMCIODFODB == null)
			{
				GFMCIODFODB = new ADLDDMAIFAI();
			}
			GFMCIODFODB.MergeFrom(other.GFMCIODFODB);
			break;
		case NLPPPCHGGPFOneofCase.JMGEPDEKGIH:
			if (JMGEPDEKGIH == null)
			{
				JMGEPDEKGIH = new LBMDGNJPPKO();
			}
			JMGEPDEKGIH.MergeFrom(other.JMGEPDEKGIH);
			break;
		case NLPPPCHGGPFOneofCase.DNIBGDGFMGJ:
			if (DNIBGDGFMGJ == null)
			{
				DNIBGDGFMGJ = new DGBPPHJAOAF();
			}
			DNIBGDGFMGJ.MergeFrom(other.DNIBGDGFMGJ);
			break;
		case NLPPPCHGGPFOneofCase.NHBMFFAGLLK:
			if (NHBMFFAGLLK == null)
			{
				NHBMFFAGLLK = new BOCNDEJFCGC();
			}
			NHBMFFAGLLK.MergeFrom(other.NHBMFFAGLLK);
			break;
		case NLPPPCHGGPFOneofCase.NCCMNPGFAGK:
			if (NCCMNPGFAGK == null)
			{
				NCCMNPGFAGK = new EMMIBLOHOKA();
			}
			NCCMNPGFAGK.MergeFrom(other.NCCMNPGFAGK);
			break;
		case NLPPPCHGGPFOneofCase.PFOILMHKJJM:
			if (PFOILMHKJJM == null)
			{
				PFOILMHKJJM = new DNFCAMIIAKJ();
			}
			PFOILMHKJJM.MergeFrom(other.PFOILMHKJJM);
			break;
		case NLPPPCHGGPFOneofCase.FLIALKEIDKD:
			if (FLIALKEIDKD == null)
			{
				FLIALKEIDKD = new HIKCDKMPDHL();
			}
			FLIALKEIDKD.MergeFrom(other.FLIALKEIDKD);
			break;
		case NLPPPCHGGPFOneofCase.CBIFAKPDNEI:
			if (CBIFAKPDNEI == null)
			{
				CBIFAKPDNEI = new GCOBCGDDNII();
			}
			CBIFAKPDNEI.MergeFrom(other.CBIFAKPDNEI);
			break;
		case NLPPPCHGGPFOneofCase.PAKFHBLBCOM:
			if (PAKFHBLBCOM == null)
			{
				PAKFHBLBCOM = new KNOCKAECKII();
			}
			PAKFHBLBCOM.MergeFrom(other.PAKFHBLBCOM);
			break;
		case NLPPPCHGGPFOneofCase.JHLBDAMENAG:
			if (JHLBDAMENAG == null)
			{
				JHLBDAMENAG = new MLLIDMPEFOD();
			}
			JHLBDAMENAG.MergeFrom(other.JHLBDAMENAG);
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
				ECMFDCIIIHJ eCMFDCIIIHJ = new ECMFDCIIIHJ();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDEENKDMDJK)
				{
					eCMFDCIIIHJ.MergeFrom(LDEENKDMDJK);
				}
				input.ReadMessage(eCMFDCIIIHJ);
				LDEENKDMDJK = eCMFDCIIIHJ;
				break;
			}
			case 18u:
			{
				IIJDPFOGCIN iIJDPFOGCIN = new IIJDPFOGCIN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DFOKPKOKFOK)
				{
					iIJDPFOGCIN.MergeFrom(DFOKPKOKFOK);
				}
				input.ReadMessage(iIJDPFOGCIN);
				DFOKPKOKFOK = iIJDPFOGCIN;
				break;
			}
			case 26u:
			{
				ALEOPCNHNPD aLEOPCNHNPD = new ALEOPCNHNPD();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JDFGFPGAGPG)
				{
					aLEOPCNHNPD.MergeFrom(JDFGFPGAGPG);
				}
				input.ReadMessage(aLEOPCNHNPD);
				JDFGFPGAGPG = aLEOPCNHNPD;
				break;
			}
			case 34u:
			{
				KHAHKDLIPKF kHAHKDLIPKF = new KHAHKDLIPKF();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NEHJPHGALEK)
				{
					kHAHKDLIPKF.MergeFrom(NEHJPHGALEK);
				}
				input.ReadMessage(kHAHKDLIPKF);
				NEHJPHGALEK = kHAHKDLIPKF;
				break;
			}
			case 42u:
			{
				BNPJCNDIPOM bNPJCNDIPOM = new BNPJCNDIPOM();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BMOLIEJFMGB)
				{
					bNPJCNDIPOM.MergeFrom(BMOLIEJFMGB);
				}
				input.ReadMessage(bNPJCNDIPOM);
				BMOLIEJFMGB = bNPJCNDIPOM;
				break;
			}
			case 50u:
			{
				BKFAKPHNEPP bKFAKPHNEPP = new BKFAKPHNEPP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FOGLALKHAGB)
				{
					bKFAKPHNEPP.MergeFrom(FOGLALKHAGB);
				}
				input.ReadMessage(bKFAKPHNEPP);
				FOGLALKHAGB = bKFAKPHNEPP;
				break;
			}
			case 58u:
			{
				KIJKPCEHEKC kIJKPCEHEKC = new KIJKPCEHEKC();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGLFFKAJAAD)
				{
					kIJKPCEHEKC.MergeFrom(NGLFFKAJAAD);
				}
				input.ReadMessage(kIJKPCEHEKC);
				NGLFFKAJAAD = kIJKPCEHEKC;
				break;
			}
			case 66u:
			{
				ODEGFOPOKAD oDEGFOPOKAD = new ODEGFOPOKAD();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EHCNDFEPLOM)
				{
					oDEGFOPOKAD.MergeFrom(EHCNDFEPLOM);
				}
				input.ReadMessage(oDEGFOPOKAD);
				EHCNDFEPLOM = oDEGFOPOKAD;
				break;
			}
			case 74u:
			{
				MBINEIHNOGC mBINEIHNOGC = new MBINEIHNOGC();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HNDCCFMMNOH)
				{
					mBINEIHNOGC.MergeFrom(HNDCCFMMNOH);
				}
				input.ReadMessage(mBINEIHNOGC);
				HNDCCFMMNOH = mBINEIHNOGC;
				break;
			}
			case 82u:
			{
				OBPOBEEODAF oBPOBEEODAF = new OBPOBEEODAF();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KODJPKPIHBH)
				{
					oBPOBEEODAF.MergeFrom(KODJPKPIHBH);
				}
				input.ReadMessage(oBPOBEEODAF);
				KODJPKPIHBH = oBPOBEEODAF;
				break;
			}
			case 90u:
			{
				AOAGJBOKKFM aOAGJBOKKFM = new AOAGJBOKKFM();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CFMDAFKGDHN)
				{
					aOAGJBOKKFM.MergeFrom(CFMDAFKGDHN);
				}
				input.ReadMessage(aOAGJBOKKFM);
				CFMDAFKGDHN = aOAGJBOKKFM;
				break;
			}
			case 98u:
			{
				DNFNEINEOEN dNFNEINEOEN = new DNFNEINEOEN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHGHOEFCAGG)
				{
					dNFNEINEOEN.MergeFrom(FHGHOEFCAGG);
				}
				input.ReadMessage(dNFNEINEOEN);
				FHGHOEFCAGG = dNFNEINEOEN;
				break;
			}
			case 106u:
			{
				ADLDDMAIFAI aDLDDMAIFAI = new ADLDDMAIFAI();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GFMCIODFODB)
				{
					aDLDDMAIFAI.MergeFrom(GFMCIODFODB);
				}
				input.ReadMessage(aDLDDMAIFAI);
				GFMCIODFODB = aDLDDMAIFAI;
				break;
			}
			case 114u:
			{
				LBMDGNJPPKO lBMDGNJPPKO = new LBMDGNJPPKO();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JMGEPDEKGIH)
				{
					lBMDGNJPPKO.MergeFrom(JMGEPDEKGIH);
				}
				input.ReadMessage(lBMDGNJPPKO);
				JMGEPDEKGIH = lBMDGNJPPKO;
				break;
			}
			case 122u:
			{
				DGBPPHJAOAF dGBPPHJAOAF = new DGBPPHJAOAF();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DNIBGDGFMGJ)
				{
					dGBPPHJAOAF.MergeFrom(DNIBGDGFMGJ);
				}
				input.ReadMessage(dGBPPHJAOAF);
				DNIBGDGFMGJ = dGBPPHJAOAF;
				break;
			}
			case 2074u:
			{
				BOCNDEJFCGC bOCNDEJFCGC = new BOCNDEJFCGC();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHBMFFAGLLK)
				{
					bOCNDEJFCGC.MergeFrom(NHBMFFAGLLK);
				}
				input.ReadMessage(bOCNDEJFCGC);
				NHBMFFAGLLK = bOCNDEJFCGC;
				break;
			}
			case 5050u:
			{
				EMMIBLOHOKA eMMIBLOHOKA = new EMMIBLOHOKA();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NCCMNPGFAGK)
				{
					eMMIBLOHOKA.MergeFrom(NCCMNPGFAGK);
				}
				input.ReadMessage(eMMIBLOHOKA);
				NCCMNPGFAGK = eMMIBLOHOKA;
				break;
			}
			case 7826u:
			{
				DNFCAMIIAKJ dNFCAMIIAKJ = new DNFCAMIIAKJ();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PFOILMHKJJM)
				{
					dNFCAMIIAKJ.MergeFrom(PFOILMHKJJM);
				}
				input.ReadMessage(dNFCAMIIAKJ);
				PFOILMHKJJM = dNFCAMIIAKJ;
				break;
			}
			case 9674u:
			{
				HIKCDKMPDHL hIKCDKMPDHL = new HIKCDKMPDHL();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FLIALKEIDKD)
				{
					hIKCDKMPDHL.MergeFrom(FLIALKEIDKD);
				}
				input.ReadMessage(hIKCDKMPDHL);
				FLIALKEIDKD = hIKCDKMPDHL;
				break;
			}
			case 11002u:
			{
				GCOBCGDDNII gCOBCGDDNII = new GCOBCGDDNII();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CBIFAKPDNEI)
				{
					gCOBCGDDNII.MergeFrom(CBIFAKPDNEI);
				}
				input.ReadMessage(gCOBCGDDNII);
				CBIFAKPDNEI = gCOBCGDDNII;
				break;
			}
			case 12770u:
			{
				KNOCKAECKII kNOCKAECKII = new KNOCKAECKII();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PAKFHBLBCOM)
				{
					kNOCKAECKII.MergeFrom(PAKFHBLBCOM);
				}
				input.ReadMessage(kNOCKAECKII);
				PAKFHBLBCOM = kNOCKAECKII;
				break;
			}
			case 13866u:
			{
				MLLIDMPEFOD mLLIDMPEFOD = new MLLIDMPEFOD();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JHLBDAMENAG)
				{
					mLLIDMPEFOD.MergeFrom(JHLBDAMENAG);
				}
				input.ReadMessage(mLLIDMPEFOD);
				JHLBDAMENAG = mLLIDMPEFOD;
				break;
			}
			}
		}
	}
}
