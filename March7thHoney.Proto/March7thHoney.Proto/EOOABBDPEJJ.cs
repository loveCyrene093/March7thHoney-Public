using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EOOABBDPEJJ : IMessage<EOOABBDPEJJ>, IMessage, IEquatable<EOOABBDPEJJ>, IDeepCloneable<EOOABBDPEJJ>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		MALOADHCLPH = 1,
		KCKEMAPBCOF = 2,
		JEFCNPJCPMN = 3,
		AFDGEDFKAGG = 4,
		NCGPNEOILPC = 5,
		APPELIAGBEE = 6,
		PAJDKFMMAEO = 7,
		AddGameItemInfo = 8,
		KFGBKEADAJG = 9,
		PPGFGHIPEPH = 10,
		CLAJDOECAHE = 11,
		ECMOFEBPNGM = 12,
		FCEEEBLCBAJ = 13,
		IPFOGBIFCFG = 14,
		LBPLNAPFAIM = 15,
		FJCODOOIGKG = 77,
		FOGCABKJOLM = 127,
		MLCCEEBNHOL = 128,
		NEPKHDPCKPF = 185,
		LIECNMCDHEB = 367,
		IBODBCMEJIG = 398,
		BBIEALHDKFJ = 710,
		LJEMGMMJIBO = 885,
		MMDJPIBEICK = 1280,
		IHNDGCHCNBE = 1526,
		FHEPDALECNE = 1528,
		CNPGENEOAHA = 1562,
		KGAJNAHHAIJ = 1967
	}

	private static readonly MessageParser<EOOABBDPEJJ> _parser = new MessageParser<EOOABBDPEJJ>(() => new EOOABBDPEJJ());

	private UnknownFieldSet _unknownFields;

	public const int MALOADHCLPHFieldNumber = 1;

	public const int KCKEMAPBCOFFieldNumber = 2;

	public const int JEFCNPJCPMNFieldNumber = 3;

	public const int AFDGEDFKAGGFieldNumber = 4;

	public const int NCGPNEOILPCFieldNumber = 5;

	public const int APPELIAGBEEFieldNumber = 6;

	public const int PAJDKFMMAEOFieldNumber = 7;

	public const int AddGameItemInfoFieldNumber = 8;

	public const int KFGBKEADAJGFieldNumber = 9;

	public const int PPGFGHIPEPHFieldNumber = 10;

	public const int CLAJDOECAHEFieldNumber = 11;

	public const int ECMOFEBPNGMFieldNumber = 12;

	public const int FCEEEBLCBAJFieldNumber = 13;

	public const int IPFOGBIFCFGFieldNumber = 14;

	public const int LBPLNAPFAIMFieldNumber = 15;

	public const int FJCODOOIGKGFieldNumber = 77;

	public const int FOGCABKJOLMFieldNumber = 127;

	public const int MLCCEEBNHOLFieldNumber = 128;

	public const int NEPKHDPCKPFFieldNumber = 185;

	public const int LIECNMCDHEBFieldNumber = 367;

	public const int IBODBCMEJIGFieldNumber = 398;

	public const int BBIEALHDKFJFieldNumber = 710;

	public const int LJEMGMMJIBOFieldNumber = 885;

	public const int MMDJPIBEICKFieldNumber = 1280;

	public const int IHNDGCHCNBEFieldNumber = 1526;

	public const int FHEPDALECNEFieldNumber = 1528;

	public const int CNPGENEOAHAFieldNumber = 1562;

	public const int KGAJNAHHAIJFieldNumber = 1967;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EOOABBDPEJJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EOOABBDPEJJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBJMGIHILGB MALOADHCLPH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MALOADHCLPH)
			{
				return null;
			}
			return (LBJMGIHILGB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MALOADHCLPH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCACHJFLGHH KCKEMAPBCOF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KCKEMAPBCOF)
			{
				return null;
			}
			return (GCACHJFLGHH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KCKEMAPBCOF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBJMGIHILGB JEFCNPJCPMN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JEFCNPJCPMN)
			{
				return null;
			}
			return (LBJMGIHILGB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JEFCNPJCPMN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGJFDIHCFIH AFDGEDFKAGG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AFDGEDFKAGG)
			{
				return null;
			}
			return (GGJFDIHCFIH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AFDGEDFKAGG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGAOJNNBALA NCGPNEOILPC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NCGPNEOILPC)
			{
				return null;
			}
			return (AGAOJNNBALA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NCGPNEOILPC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCACHJFLGHH APPELIAGBEE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.APPELIAGBEE)
			{
				return null;
			}
			return (GCACHJFLGHH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.APPELIAGBEE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIKMHADLJFL PAJDKFMMAEO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PAJDKFMMAEO)
			{
				return null;
			}
			return (IIKMHADLJFL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PAJDKFMMAEO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNMOPCFJDPD AddGameItemInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AddGameItemInfo)
			{
				return null;
			}
			return (JNMOPCFJDPD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AddGameItemInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGAOJNNBALA KFGBKEADAJG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KFGBKEADAJG)
			{
				return null;
			}
			return (AGAOJNNBALA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KFGBKEADAJG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNMOPCFJDPD PPGFGHIPEPH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PPGFGHIPEPH)
			{
				return null;
			}
			return (JNMOPCFJDPD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PPGFGHIPEPH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFHMIKIFLPO CLAJDOECAHE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CLAJDOECAHE)
			{
				return null;
			}
			return (HFHMIKIFLPO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CLAJDOECAHE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIKMHADLJFL ECMOFEBPNGM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ECMOFEBPNGM)
			{
				return null;
			}
			return (IIKMHADLJFL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ECMOFEBPNGM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFHMIKIFLPO FCEEEBLCBAJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FCEEEBLCBAJ)
			{
				return null;
			}
			return (HFHMIKIFLPO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FCEEEBLCBAJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHAOFLALHBL IPFOGBIFCFG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IPFOGBIFCFG)
			{
				return null;
			}
			return (OHAOFLALHBL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IPFOGBIFCFG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesUnlockChange LBPLNAPFAIM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LBPLNAPFAIM)
			{
				return null;
			}
			return (PlanetFesUnlockChange)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LBPLNAPFAIM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOGAPHFIBG FJCODOOIGKG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FJCODOOIGKG)
			{
				return null;
			}
			return (BBOGAPHFIBG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FJCODOOIGKG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHKHKGDAMNB FOGCABKJOLM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FOGCABKJOLM)
			{
				return null;
			}
			return (HHKHKGDAMNB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FOGCABKJOLM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBMNFGPKECH MLCCEEBNHOL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MLCCEEBNHOL)
			{
				return null;
			}
			return (HBMNFGPKECH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MLCCEEBNHOL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCEEJNOPNIB NEPKHDPCKPF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NEPKHDPCKPF)
			{
				return null;
			}
			return (LCEEJNOPNIB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NEPKHDPCKPF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMDAMOLKFL LIECNMCDHEB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LIECNMCDHEB)
			{
				return null;
			}
			return (IEMDAMOLKFL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LIECNMCDHEB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLIFHDOLJMO IBODBCMEJIG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IBODBCMEJIG)
			{
				return null;
			}
			return (GLIFHDOLJMO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IBODBCMEJIG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFKFKHHEOG BBIEALHDKFJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BBIEALHDKFJ)
			{
				return null;
			}
			return (FFFKFKHHEOG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BBIEALHDKFJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGAOJNNBALA LJEMGMMJIBO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LJEMGMMJIBO)
			{
				return null;
			}
			return (AGAOJNNBALA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LJEMGMMJIBO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCHLAEEOBIF MMDJPIBEICK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MMDJPIBEICK)
			{
				return null;
			}
			return (NCHLAEEOBIF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MMDJPIBEICK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPMNBMJIFHJ IHNDGCHCNBE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IHNDGCHCNBE)
			{
				return null;
			}
			return (GPMNBMJIFHJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IHNDGCHCNBE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJMLNLKCOJJ FHEPDALECNE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FHEPDALECNE)
			{
				return null;
			}
			return (HJMLNLKCOJJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FHEPDALECNE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHLDMADOHHF CNPGENEOAHA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CNPGENEOAHA)
			{
				return null;
			}
			return (GHLDMADOHHF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CNPGENEOAHA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLNDMMGFML KGAJNAHHAIJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KGAJNAHHAIJ)
			{
				return null;
			}
			return (AGLNDMMGFML)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KGAJNAHHAIJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOABBDPEJJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOABBDPEJJ(EOOABBDPEJJ other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.MALOADHCLPH:
			MALOADHCLPH = other.MALOADHCLPH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KCKEMAPBCOF:
			KCKEMAPBCOF = other.KCKEMAPBCOF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JEFCNPJCPMN:
			JEFCNPJCPMN = other.JEFCNPJCPMN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AFDGEDFKAGG:
			AFDGEDFKAGG = other.AFDGEDFKAGG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NCGPNEOILPC:
			NCGPNEOILPC = other.NCGPNEOILPC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.APPELIAGBEE:
			APPELIAGBEE = other.APPELIAGBEE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PAJDKFMMAEO:
			PAJDKFMMAEO = other.PAJDKFMMAEO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AddGameItemInfo:
			AddGameItemInfo = other.AddGameItemInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KFGBKEADAJG:
			KFGBKEADAJG = other.KFGBKEADAJG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PPGFGHIPEPH:
			PPGFGHIPEPH = other.PPGFGHIPEPH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CLAJDOECAHE:
			CLAJDOECAHE = other.CLAJDOECAHE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ECMOFEBPNGM:
			ECMOFEBPNGM = other.ECMOFEBPNGM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FCEEEBLCBAJ:
			FCEEEBLCBAJ = other.FCEEEBLCBAJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IPFOGBIFCFG:
			IPFOGBIFCFG = other.IPFOGBIFCFG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LBPLNAPFAIM:
			LBPLNAPFAIM = other.LBPLNAPFAIM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FJCODOOIGKG:
			FJCODOOIGKG = other.FJCODOOIGKG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FOGCABKJOLM:
			FOGCABKJOLM = other.FOGCABKJOLM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MLCCEEBNHOL:
			MLCCEEBNHOL = other.MLCCEEBNHOL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NEPKHDPCKPF:
			NEPKHDPCKPF = other.NEPKHDPCKPF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LIECNMCDHEB:
			LIECNMCDHEB = other.LIECNMCDHEB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IBODBCMEJIG:
			IBODBCMEJIG = other.IBODBCMEJIG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BBIEALHDKFJ:
			BBIEALHDKFJ = other.BBIEALHDKFJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LJEMGMMJIBO:
			LJEMGMMJIBO = other.LJEMGMMJIBO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MMDJPIBEICK:
			MMDJPIBEICK = other.MMDJPIBEICK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IHNDGCHCNBE:
			IHNDGCHCNBE = other.IHNDGCHCNBE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FHEPDALECNE:
			FHEPDALECNE = other.FHEPDALECNE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CNPGENEOAHA:
			CNPGENEOAHA = other.CNPGENEOAHA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KGAJNAHHAIJ:
			KGAJNAHHAIJ = other.KGAJNAHHAIJ.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOABBDPEJJ Clone()
	{
		return new EOOABBDPEJJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EOOABBDPEJJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EOOABBDPEJJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MALOADHCLPH, other.MALOADHCLPH))
		{
			return false;
		}
		if (!object.Equals(KCKEMAPBCOF, other.KCKEMAPBCOF))
		{
			return false;
		}
		if (!object.Equals(JEFCNPJCPMN, other.JEFCNPJCPMN))
		{
			return false;
		}
		if (!object.Equals(AFDGEDFKAGG, other.AFDGEDFKAGG))
		{
			return false;
		}
		if (!object.Equals(NCGPNEOILPC, other.NCGPNEOILPC))
		{
			return false;
		}
		if (!object.Equals(APPELIAGBEE, other.APPELIAGBEE))
		{
			return false;
		}
		if (!object.Equals(PAJDKFMMAEO, other.PAJDKFMMAEO))
		{
			return false;
		}
		if (!object.Equals(AddGameItemInfo, other.AddGameItemInfo))
		{
			return false;
		}
		if (!object.Equals(KFGBKEADAJG, other.KFGBKEADAJG))
		{
			return false;
		}
		if (!object.Equals(PPGFGHIPEPH, other.PPGFGHIPEPH))
		{
			return false;
		}
		if (!object.Equals(CLAJDOECAHE, other.CLAJDOECAHE))
		{
			return false;
		}
		if (!object.Equals(ECMOFEBPNGM, other.ECMOFEBPNGM))
		{
			return false;
		}
		if (!object.Equals(FCEEEBLCBAJ, other.FCEEEBLCBAJ))
		{
			return false;
		}
		if (!object.Equals(IPFOGBIFCFG, other.IPFOGBIFCFG))
		{
			return false;
		}
		if (!object.Equals(LBPLNAPFAIM, other.LBPLNAPFAIM))
		{
			return false;
		}
		if (!object.Equals(FJCODOOIGKG, other.FJCODOOIGKG))
		{
			return false;
		}
		if (!object.Equals(FOGCABKJOLM, other.FOGCABKJOLM))
		{
			return false;
		}
		if (!object.Equals(MLCCEEBNHOL, other.MLCCEEBNHOL))
		{
			return false;
		}
		if (!object.Equals(NEPKHDPCKPF, other.NEPKHDPCKPF))
		{
			return false;
		}
		if (!object.Equals(LIECNMCDHEB, other.LIECNMCDHEB))
		{
			return false;
		}
		if (!object.Equals(IBODBCMEJIG, other.IBODBCMEJIG))
		{
			return false;
		}
		if (!object.Equals(BBIEALHDKFJ, other.BBIEALHDKFJ))
		{
			return false;
		}
		if (!object.Equals(LJEMGMMJIBO, other.LJEMGMMJIBO))
		{
			return false;
		}
		if (!object.Equals(MMDJPIBEICK, other.MMDJPIBEICK))
		{
			return false;
		}
		if (!object.Equals(IHNDGCHCNBE, other.IHNDGCHCNBE))
		{
			return false;
		}
		if (!object.Equals(FHEPDALECNE, other.FHEPDALECNE))
		{
			return false;
		}
		if (!object.Equals(CNPGENEOAHA, other.CNPGENEOAHA))
		{
			return false;
		}
		if (!object.Equals(KGAJNAHHAIJ, other.KGAJNAHHAIJ))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MALOADHCLPH)
		{
			num ^= MALOADHCLPH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCKEMAPBCOF)
		{
			num ^= KCKEMAPBCOF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEFCNPJCPMN)
		{
			num ^= JEFCNPJCPMN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFDGEDFKAGG)
		{
			num ^= AFDGEDFKAGG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NCGPNEOILPC)
		{
			num ^= NCGPNEOILPC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.APPELIAGBEE)
		{
			num ^= APPELIAGBEE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PAJDKFMMAEO)
		{
			num ^= PAJDKFMMAEO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AddGameItemInfo)
		{
			num ^= AddGameItemInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFGBKEADAJG)
		{
			num ^= KFGBKEADAJG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPGFGHIPEPH)
		{
			num ^= PPGFGHIPEPH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLAJDOECAHE)
		{
			num ^= CLAJDOECAHE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECMOFEBPNGM)
		{
			num ^= ECMOFEBPNGM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCEEEBLCBAJ)
		{
			num ^= FCEEEBLCBAJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPFOGBIFCFG)
		{
			num ^= IPFOGBIFCFG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LBPLNAPFAIM)
		{
			num ^= LBPLNAPFAIM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJCODOOIGKG)
		{
			num ^= FJCODOOIGKG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOGCABKJOLM)
		{
			num ^= FOGCABKJOLM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLCCEEBNHOL)
		{
			num ^= MLCCEEBNHOL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEPKHDPCKPF)
		{
			num ^= NEPKHDPCKPF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIECNMCDHEB)
		{
			num ^= LIECNMCDHEB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IBODBCMEJIG)
		{
			num ^= IBODBCMEJIG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBIEALHDKFJ)
		{
			num ^= BBIEALHDKFJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJEMGMMJIBO)
		{
			num ^= LJEMGMMJIBO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MMDJPIBEICK)
		{
			num ^= MMDJPIBEICK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IHNDGCHCNBE)
		{
			num ^= IHNDGCHCNBE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FHEPDALECNE)
		{
			num ^= FHEPDALECNE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CNPGENEOAHA)
		{
			num ^= CNPGENEOAHA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KGAJNAHHAIJ)
		{
			num ^= KGAJNAHHAIJ.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MALOADHCLPH)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MALOADHCLPH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCKEMAPBCOF)
		{
			output.WriteRawTag(18);
			output.WriteMessage(KCKEMAPBCOF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEFCNPJCPMN)
		{
			output.WriteRawTag(26);
			output.WriteMessage(JEFCNPJCPMN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFDGEDFKAGG)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AFDGEDFKAGG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NCGPNEOILPC)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NCGPNEOILPC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.APPELIAGBEE)
		{
			output.WriteRawTag(50);
			output.WriteMessage(APPELIAGBEE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PAJDKFMMAEO)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PAJDKFMMAEO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AddGameItemInfo)
		{
			output.WriteRawTag(66);
			output.WriteMessage(AddGameItemInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFGBKEADAJG)
		{
			output.WriteRawTag(74);
			output.WriteMessage(KFGBKEADAJG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPGFGHIPEPH)
		{
			output.WriteRawTag(82);
			output.WriteMessage(PPGFGHIPEPH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLAJDOECAHE)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CLAJDOECAHE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECMOFEBPNGM)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ECMOFEBPNGM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCEEEBLCBAJ)
		{
			output.WriteRawTag(106);
			output.WriteMessage(FCEEEBLCBAJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPFOGBIFCFG)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IPFOGBIFCFG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LBPLNAPFAIM)
		{
			output.WriteRawTag(122);
			output.WriteMessage(LBPLNAPFAIM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJCODOOIGKG)
		{
			output.WriteRawTag(234, 4);
			output.WriteMessage(FJCODOOIGKG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOGCABKJOLM)
		{
			output.WriteRawTag(250, 7);
			output.WriteMessage(FOGCABKJOLM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLCCEEBNHOL)
		{
			output.WriteRawTag(130, 8);
			output.WriteMessage(MLCCEEBNHOL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEPKHDPCKPF)
		{
			output.WriteRawTag(202, 11);
			output.WriteMessage(NEPKHDPCKPF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIECNMCDHEB)
		{
			output.WriteRawTag(250, 22);
			output.WriteMessage(LIECNMCDHEB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IBODBCMEJIG)
		{
			output.WriteRawTag(242, 24);
			output.WriteMessage(IBODBCMEJIG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBIEALHDKFJ)
		{
			output.WriteRawTag(178, 44);
			output.WriteMessage(BBIEALHDKFJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJEMGMMJIBO)
		{
			output.WriteRawTag(170, 55);
			output.WriteMessage(LJEMGMMJIBO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MMDJPIBEICK)
		{
			output.WriteRawTag(130, 80);
			output.WriteMessage(MMDJPIBEICK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IHNDGCHCNBE)
		{
			output.WriteRawTag(178, 95);
			output.WriteMessage(IHNDGCHCNBE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FHEPDALECNE)
		{
			output.WriteRawTag(194, 95);
			output.WriteMessage(FHEPDALECNE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CNPGENEOAHA)
		{
			output.WriteRawTag(210, 97);
			output.WriteMessage(CNPGENEOAHA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KGAJNAHHAIJ)
		{
			output.WriteRawTag(250, 122);
			output.WriteMessage(KGAJNAHHAIJ);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MALOADHCLPH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MALOADHCLPH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCKEMAPBCOF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KCKEMAPBCOF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEFCNPJCPMN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JEFCNPJCPMN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFDGEDFKAGG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFDGEDFKAGG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NCGPNEOILPC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCGPNEOILPC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.APPELIAGBEE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(APPELIAGBEE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PAJDKFMMAEO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PAJDKFMMAEO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AddGameItemInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AddGameItemInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFGBKEADAJG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KFGBKEADAJG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPGFGHIPEPH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPGFGHIPEPH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLAJDOECAHE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CLAJDOECAHE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECMOFEBPNGM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECMOFEBPNGM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCEEEBLCBAJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCEEEBLCBAJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPFOGBIFCFG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IPFOGBIFCFG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LBPLNAPFAIM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBPLNAPFAIM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJCODOOIGKG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FJCODOOIGKG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOGCABKJOLM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FOGCABKJOLM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLCCEEBNHOL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MLCCEEBNHOL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEPKHDPCKPF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NEPKHDPCKPF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIECNMCDHEB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LIECNMCDHEB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IBODBCMEJIG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IBODBCMEJIG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBIEALHDKFJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BBIEALHDKFJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJEMGMMJIBO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LJEMGMMJIBO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MMDJPIBEICK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MMDJPIBEICK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IHNDGCHCNBE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IHNDGCHCNBE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FHEPDALECNE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FHEPDALECNE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CNPGENEOAHA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CNPGENEOAHA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KGAJNAHHAIJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KGAJNAHHAIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EOOABBDPEJJ other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.MALOADHCLPH:
			if (MALOADHCLPH == null)
			{
				MALOADHCLPH = new LBJMGIHILGB();
			}
			MALOADHCLPH.MergeFrom(other.MALOADHCLPH);
			break;
		case BPIHFAJCLOCOneofCase.KCKEMAPBCOF:
			if (KCKEMAPBCOF == null)
			{
				KCKEMAPBCOF = new GCACHJFLGHH();
			}
			KCKEMAPBCOF.MergeFrom(other.KCKEMAPBCOF);
			break;
		case BPIHFAJCLOCOneofCase.JEFCNPJCPMN:
			if (JEFCNPJCPMN == null)
			{
				JEFCNPJCPMN = new LBJMGIHILGB();
			}
			JEFCNPJCPMN.MergeFrom(other.JEFCNPJCPMN);
			break;
		case BPIHFAJCLOCOneofCase.AFDGEDFKAGG:
			if (AFDGEDFKAGG == null)
			{
				AFDGEDFKAGG = new GGJFDIHCFIH();
			}
			AFDGEDFKAGG.MergeFrom(other.AFDGEDFKAGG);
			break;
		case BPIHFAJCLOCOneofCase.NCGPNEOILPC:
			if (NCGPNEOILPC == null)
			{
				NCGPNEOILPC = new AGAOJNNBALA();
			}
			NCGPNEOILPC.MergeFrom(other.NCGPNEOILPC);
			break;
		case BPIHFAJCLOCOneofCase.APPELIAGBEE:
			if (APPELIAGBEE == null)
			{
				APPELIAGBEE = new GCACHJFLGHH();
			}
			APPELIAGBEE.MergeFrom(other.APPELIAGBEE);
			break;
		case BPIHFAJCLOCOneofCase.PAJDKFMMAEO:
			if (PAJDKFMMAEO == null)
			{
				PAJDKFMMAEO = new IIKMHADLJFL();
			}
			PAJDKFMMAEO.MergeFrom(other.PAJDKFMMAEO);
			break;
		case BPIHFAJCLOCOneofCase.AddGameItemInfo:
			if (AddGameItemInfo == null)
			{
				AddGameItemInfo = new JNMOPCFJDPD();
			}
			AddGameItemInfo.MergeFrom(other.AddGameItemInfo);
			break;
		case BPIHFAJCLOCOneofCase.KFGBKEADAJG:
			if (KFGBKEADAJG == null)
			{
				KFGBKEADAJG = new AGAOJNNBALA();
			}
			KFGBKEADAJG.MergeFrom(other.KFGBKEADAJG);
			break;
		case BPIHFAJCLOCOneofCase.PPGFGHIPEPH:
			if (PPGFGHIPEPH == null)
			{
				PPGFGHIPEPH = new JNMOPCFJDPD();
			}
			PPGFGHIPEPH.MergeFrom(other.PPGFGHIPEPH);
			break;
		case BPIHFAJCLOCOneofCase.CLAJDOECAHE:
			if (CLAJDOECAHE == null)
			{
				CLAJDOECAHE = new HFHMIKIFLPO();
			}
			CLAJDOECAHE.MergeFrom(other.CLAJDOECAHE);
			break;
		case BPIHFAJCLOCOneofCase.ECMOFEBPNGM:
			if (ECMOFEBPNGM == null)
			{
				ECMOFEBPNGM = new IIKMHADLJFL();
			}
			ECMOFEBPNGM.MergeFrom(other.ECMOFEBPNGM);
			break;
		case BPIHFAJCLOCOneofCase.FCEEEBLCBAJ:
			if (FCEEEBLCBAJ == null)
			{
				FCEEEBLCBAJ = new HFHMIKIFLPO();
			}
			FCEEEBLCBAJ.MergeFrom(other.FCEEEBLCBAJ);
			break;
		case BPIHFAJCLOCOneofCase.IPFOGBIFCFG:
			if (IPFOGBIFCFG == null)
			{
				IPFOGBIFCFG = new OHAOFLALHBL();
			}
			IPFOGBIFCFG.MergeFrom(other.IPFOGBIFCFG);
			break;
		case BPIHFAJCLOCOneofCase.LBPLNAPFAIM:
			if (LBPLNAPFAIM == null)
			{
				LBPLNAPFAIM = new PlanetFesUnlockChange();
			}
			LBPLNAPFAIM.MergeFrom(other.LBPLNAPFAIM);
			break;
		case BPIHFAJCLOCOneofCase.FJCODOOIGKG:
			if (FJCODOOIGKG == null)
			{
				FJCODOOIGKG = new BBOGAPHFIBG();
			}
			FJCODOOIGKG.MergeFrom(other.FJCODOOIGKG);
			break;
		case BPIHFAJCLOCOneofCase.FOGCABKJOLM:
			if (FOGCABKJOLM == null)
			{
				FOGCABKJOLM = new HHKHKGDAMNB();
			}
			FOGCABKJOLM.MergeFrom(other.FOGCABKJOLM);
			break;
		case BPIHFAJCLOCOneofCase.MLCCEEBNHOL:
			if (MLCCEEBNHOL == null)
			{
				MLCCEEBNHOL = new HBMNFGPKECH();
			}
			MLCCEEBNHOL.MergeFrom(other.MLCCEEBNHOL);
			break;
		case BPIHFAJCLOCOneofCase.NEPKHDPCKPF:
			if (NEPKHDPCKPF == null)
			{
				NEPKHDPCKPF = new LCEEJNOPNIB();
			}
			NEPKHDPCKPF.MergeFrom(other.NEPKHDPCKPF);
			break;
		case BPIHFAJCLOCOneofCase.LIECNMCDHEB:
			if (LIECNMCDHEB == null)
			{
				LIECNMCDHEB = new IEMDAMOLKFL();
			}
			LIECNMCDHEB.MergeFrom(other.LIECNMCDHEB);
			break;
		case BPIHFAJCLOCOneofCase.IBODBCMEJIG:
			if (IBODBCMEJIG == null)
			{
				IBODBCMEJIG = new GLIFHDOLJMO();
			}
			IBODBCMEJIG.MergeFrom(other.IBODBCMEJIG);
			break;
		case BPIHFAJCLOCOneofCase.BBIEALHDKFJ:
			if (BBIEALHDKFJ == null)
			{
				BBIEALHDKFJ = new FFFKFKHHEOG();
			}
			BBIEALHDKFJ.MergeFrom(other.BBIEALHDKFJ);
			break;
		case BPIHFAJCLOCOneofCase.LJEMGMMJIBO:
			if (LJEMGMMJIBO == null)
			{
				LJEMGMMJIBO = new AGAOJNNBALA();
			}
			LJEMGMMJIBO.MergeFrom(other.LJEMGMMJIBO);
			break;
		case BPIHFAJCLOCOneofCase.MMDJPIBEICK:
			if (MMDJPIBEICK == null)
			{
				MMDJPIBEICK = new NCHLAEEOBIF();
			}
			MMDJPIBEICK.MergeFrom(other.MMDJPIBEICK);
			break;
		case BPIHFAJCLOCOneofCase.IHNDGCHCNBE:
			if (IHNDGCHCNBE == null)
			{
				IHNDGCHCNBE = new GPMNBMJIFHJ();
			}
			IHNDGCHCNBE.MergeFrom(other.IHNDGCHCNBE);
			break;
		case BPIHFAJCLOCOneofCase.FHEPDALECNE:
			if (FHEPDALECNE == null)
			{
				FHEPDALECNE = new HJMLNLKCOJJ();
			}
			FHEPDALECNE.MergeFrom(other.FHEPDALECNE);
			break;
		case BPIHFAJCLOCOneofCase.CNPGENEOAHA:
			if (CNPGENEOAHA == null)
			{
				CNPGENEOAHA = new GHLDMADOHHF();
			}
			CNPGENEOAHA.MergeFrom(other.CNPGENEOAHA);
			break;
		case BPIHFAJCLOCOneofCase.KGAJNAHHAIJ:
			if (KGAJNAHHAIJ == null)
			{
				KGAJNAHHAIJ = new AGLNDMMGFML();
			}
			KGAJNAHHAIJ.MergeFrom(other.KGAJNAHHAIJ);
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
				LBJMGIHILGB lBJMGIHILGB = new LBJMGIHILGB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MALOADHCLPH)
				{
					lBJMGIHILGB.MergeFrom(MALOADHCLPH);
				}
				input.ReadMessage(lBJMGIHILGB);
				MALOADHCLPH = lBJMGIHILGB;
				break;
			}
			case 18u:
			{
				GCACHJFLGHH gCACHJFLGHH2 = new GCACHJFLGHH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCKEMAPBCOF)
				{
					gCACHJFLGHH2.MergeFrom(KCKEMAPBCOF);
				}
				input.ReadMessage(gCACHJFLGHH2);
				KCKEMAPBCOF = gCACHJFLGHH2;
				break;
			}
			case 26u:
			{
				LBJMGIHILGB lBJMGIHILGB2 = new LBJMGIHILGB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEFCNPJCPMN)
				{
					lBJMGIHILGB2.MergeFrom(JEFCNPJCPMN);
				}
				input.ReadMessage(lBJMGIHILGB2);
				JEFCNPJCPMN = lBJMGIHILGB2;
				break;
			}
			case 34u:
			{
				GGJFDIHCFIH gGJFDIHCFIH = new GGJFDIHCFIH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFDGEDFKAGG)
				{
					gGJFDIHCFIH.MergeFrom(AFDGEDFKAGG);
				}
				input.ReadMessage(gGJFDIHCFIH);
				AFDGEDFKAGG = gGJFDIHCFIH;
				break;
			}
			case 42u:
			{
				AGAOJNNBALA aGAOJNNBALA = new AGAOJNNBALA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NCGPNEOILPC)
				{
					aGAOJNNBALA.MergeFrom(NCGPNEOILPC);
				}
				input.ReadMessage(aGAOJNNBALA);
				NCGPNEOILPC = aGAOJNNBALA;
				break;
			}
			case 50u:
			{
				GCACHJFLGHH gCACHJFLGHH = new GCACHJFLGHH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.APPELIAGBEE)
				{
					gCACHJFLGHH.MergeFrom(APPELIAGBEE);
				}
				input.ReadMessage(gCACHJFLGHH);
				APPELIAGBEE = gCACHJFLGHH;
				break;
			}
			case 58u:
			{
				IIKMHADLJFL iIKMHADLJFL = new IIKMHADLJFL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PAJDKFMMAEO)
				{
					iIKMHADLJFL.MergeFrom(PAJDKFMMAEO);
				}
				input.ReadMessage(iIKMHADLJFL);
				PAJDKFMMAEO = iIKMHADLJFL;
				break;
			}
			case 66u:
			{
				JNMOPCFJDPD jNMOPCFJDPD2 = new JNMOPCFJDPD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AddGameItemInfo)
				{
					jNMOPCFJDPD2.MergeFrom(AddGameItemInfo);
				}
				input.ReadMessage(jNMOPCFJDPD2);
				AddGameItemInfo = jNMOPCFJDPD2;
				break;
			}
			case 74u:
			{
				AGAOJNNBALA aGAOJNNBALA3 = new AGAOJNNBALA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFGBKEADAJG)
				{
					aGAOJNNBALA3.MergeFrom(KFGBKEADAJG);
				}
				input.ReadMessage(aGAOJNNBALA3);
				KFGBKEADAJG = aGAOJNNBALA3;
				break;
			}
			case 82u:
			{
				JNMOPCFJDPD jNMOPCFJDPD = new JNMOPCFJDPD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPGFGHIPEPH)
				{
					jNMOPCFJDPD.MergeFrom(PPGFGHIPEPH);
				}
				input.ReadMessage(jNMOPCFJDPD);
				PPGFGHIPEPH = jNMOPCFJDPD;
				break;
			}
			case 90u:
			{
				HFHMIKIFLPO hFHMIKIFLPO = new HFHMIKIFLPO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLAJDOECAHE)
				{
					hFHMIKIFLPO.MergeFrom(CLAJDOECAHE);
				}
				input.ReadMessage(hFHMIKIFLPO);
				CLAJDOECAHE = hFHMIKIFLPO;
				break;
			}
			case 98u:
			{
				IIKMHADLJFL iIKMHADLJFL2 = new IIKMHADLJFL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECMOFEBPNGM)
				{
					iIKMHADLJFL2.MergeFrom(ECMOFEBPNGM);
				}
				input.ReadMessage(iIKMHADLJFL2);
				ECMOFEBPNGM = iIKMHADLJFL2;
				break;
			}
			case 106u:
			{
				HFHMIKIFLPO hFHMIKIFLPO2 = new HFHMIKIFLPO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCEEEBLCBAJ)
				{
					hFHMIKIFLPO2.MergeFrom(FCEEEBLCBAJ);
				}
				input.ReadMessage(hFHMIKIFLPO2);
				FCEEEBLCBAJ = hFHMIKIFLPO2;
				break;
			}
			case 114u:
			{
				OHAOFLALHBL oHAOFLALHBL = new OHAOFLALHBL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPFOGBIFCFG)
				{
					oHAOFLALHBL.MergeFrom(IPFOGBIFCFG);
				}
				input.ReadMessage(oHAOFLALHBL);
				IPFOGBIFCFG = oHAOFLALHBL;
				break;
			}
			case 122u:
			{
				PlanetFesUnlockChange planetFesUnlockChange = new PlanetFesUnlockChange();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LBPLNAPFAIM)
				{
					planetFesUnlockChange.MergeFrom(LBPLNAPFAIM);
				}
				input.ReadMessage(planetFesUnlockChange);
				LBPLNAPFAIM = planetFesUnlockChange;
				break;
			}
			case 618u:
			{
				BBOGAPHFIBG bBOGAPHFIBG = new BBOGAPHFIBG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FJCODOOIGKG)
				{
					bBOGAPHFIBG.MergeFrom(FJCODOOIGKG);
				}
				input.ReadMessage(bBOGAPHFIBG);
				FJCODOOIGKG = bBOGAPHFIBG;
				break;
			}
			case 1018u:
			{
				HHKHKGDAMNB hHKHKGDAMNB = new HHKHKGDAMNB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOGCABKJOLM)
				{
					hHKHKGDAMNB.MergeFrom(FOGCABKJOLM);
				}
				input.ReadMessage(hHKHKGDAMNB);
				FOGCABKJOLM = hHKHKGDAMNB;
				break;
			}
			case 1026u:
			{
				HBMNFGPKECH hBMNFGPKECH = new HBMNFGPKECH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLCCEEBNHOL)
				{
					hBMNFGPKECH.MergeFrom(MLCCEEBNHOL);
				}
				input.ReadMessage(hBMNFGPKECH);
				MLCCEEBNHOL = hBMNFGPKECH;
				break;
			}
			case 1482u:
			{
				LCEEJNOPNIB lCEEJNOPNIB = new LCEEJNOPNIB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEPKHDPCKPF)
				{
					lCEEJNOPNIB.MergeFrom(NEPKHDPCKPF);
				}
				input.ReadMessage(lCEEJNOPNIB);
				NEPKHDPCKPF = lCEEJNOPNIB;
				break;
			}
			case 2938u:
			{
				IEMDAMOLKFL iEMDAMOLKFL = new IEMDAMOLKFL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIECNMCDHEB)
				{
					iEMDAMOLKFL.MergeFrom(LIECNMCDHEB);
				}
				input.ReadMessage(iEMDAMOLKFL);
				LIECNMCDHEB = iEMDAMOLKFL;
				break;
			}
			case 3186u:
			{
				GLIFHDOLJMO gLIFHDOLJMO = new GLIFHDOLJMO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IBODBCMEJIG)
				{
					gLIFHDOLJMO.MergeFrom(IBODBCMEJIG);
				}
				input.ReadMessage(gLIFHDOLJMO);
				IBODBCMEJIG = gLIFHDOLJMO;
				break;
			}
			case 5682u:
			{
				FFFKFKHHEOG fFFKFKHHEOG = new FFFKFKHHEOG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBIEALHDKFJ)
				{
					fFFKFKHHEOG.MergeFrom(BBIEALHDKFJ);
				}
				input.ReadMessage(fFFKFKHHEOG);
				BBIEALHDKFJ = fFFKFKHHEOG;
				break;
			}
			case 7082u:
			{
				AGAOJNNBALA aGAOJNNBALA2 = new AGAOJNNBALA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJEMGMMJIBO)
				{
					aGAOJNNBALA2.MergeFrom(LJEMGMMJIBO);
				}
				input.ReadMessage(aGAOJNNBALA2);
				LJEMGMMJIBO = aGAOJNNBALA2;
				break;
			}
			case 10242u:
			{
				NCHLAEEOBIF nCHLAEEOBIF = new NCHLAEEOBIF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MMDJPIBEICK)
				{
					nCHLAEEOBIF.MergeFrom(MMDJPIBEICK);
				}
				input.ReadMessage(nCHLAEEOBIF);
				MMDJPIBEICK = nCHLAEEOBIF;
				break;
			}
			case 12210u:
			{
				GPMNBMJIFHJ gPMNBMJIFHJ = new GPMNBMJIFHJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IHNDGCHCNBE)
				{
					gPMNBMJIFHJ.MergeFrom(IHNDGCHCNBE);
				}
				input.ReadMessage(gPMNBMJIFHJ);
				IHNDGCHCNBE = gPMNBMJIFHJ;
				break;
			}
			case 12226u:
			{
				HJMLNLKCOJJ hJMLNLKCOJJ = new HJMLNLKCOJJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FHEPDALECNE)
				{
					hJMLNLKCOJJ.MergeFrom(FHEPDALECNE);
				}
				input.ReadMessage(hJMLNLKCOJJ);
				FHEPDALECNE = hJMLNLKCOJJ;
				break;
			}
			case 12498u:
			{
				GHLDMADOHHF gHLDMADOHHF = new GHLDMADOHHF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CNPGENEOAHA)
				{
					gHLDMADOHHF.MergeFrom(CNPGENEOAHA);
				}
				input.ReadMessage(gHLDMADOHHF);
				CNPGENEOAHA = gHLDMADOHHF;
				break;
			}
			case 15738u:
			{
				AGLNDMMGFML aGLNDMMGFML = new AGLNDMMGFML();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KGAJNAHHAIJ)
				{
					aGLNDMMGFML.MergeFrom(KGAJNAHHAIJ);
				}
				input.ReadMessage(aGLNDMMGFML);
				KGAJNAHHAIJ = aGLNDMMGFML;
				break;
			}
			}
		}
	}
}
