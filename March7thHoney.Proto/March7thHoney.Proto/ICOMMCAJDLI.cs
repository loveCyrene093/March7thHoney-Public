using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ICOMMCAJDLI : IMessage<ICOMMCAJDLI>, IMessage, IEquatable<ICOMMCAJDLI>, IDeepCloneable<ICOMMCAJDLI>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		HMEFIMKFJJB = 93,
		EFCEICPLOPB = 114,
		NIJGCFPHOOA = 163,
		EAFMEDAPBCD = 169,
		KACLNCHFJBN = 206,
		OICGDJIFDHH = 257,
		EDOFNCKDIDF = 264,
		KNNLHEMFKBN = 326,
		HONKIOJGMDM = 485,
		NGDIFOLBLBB = 581,
		EGLOMNOCOAJ = 590,
		HEOJMIMGHFN = 649,
		MKMKIGKMPFP = 734,
		PLOHJJJFNNJ = 765,
		AGNHFMGIIAO = 777,
		PFBBHAMOAGB = 818,
		EBALDNBOHDC = 862,
		MLHAOGMNPCJ = 1053,
		JLLBHEPLKKP = 1064,
		ABFIDIHJLHE = 1098,
		FIDLIKNIJAK = 1251,
		KIOBOCMOONH = 1277,
		CLOLHIIJMPH = 1297,
		KMKGHJJIJCN = 1408,
		BCFEJAFMNPF = 1619,
		PFMBIGOLHBL = 1683,
		OIEIBBIIAMI = 1776,
		ALLPJKHDLIB = 1777,
		ODIOMDIDJIK = 1818,
		FOABDDDDFBP = 1862,
		NALNNBECBPA = 2041,
		CDJLDNEDADG = 2045
	}

	private static readonly MessageParser<ICOMMCAJDLI> _parser = new MessageParser<ICOMMCAJDLI>(() => new ICOMMCAJDLI());

	private UnknownFieldSet _unknownFields;

	public const int HMEFIMKFJJBFieldNumber = 93;

	public const int EFCEICPLOPBFieldNumber = 114;

	public const int NIJGCFPHOOAFieldNumber = 163;

	public const int EAFMEDAPBCDFieldNumber = 169;

	public const int KACLNCHFJBNFieldNumber = 206;

	public const int OICGDJIFDHHFieldNumber = 257;

	public const int EDOFNCKDIDFFieldNumber = 264;

	public const int KNNLHEMFKBNFieldNumber = 326;

	public const int HONKIOJGMDMFieldNumber = 485;

	public const int NGDIFOLBLBBFieldNumber = 581;

	public const int EGLOMNOCOAJFieldNumber = 590;

	public const int HEOJMIMGHFNFieldNumber = 649;

	public const int MKMKIGKMPFPFieldNumber = 734;

	public const int PLOHJJJFNNJFieldNumber = 765;

	public const int AGNHFMGIIAOFieldNumber = 777;

	public const int PFBBHAMOAGBFieldNumber = 818;

	public const int EBALDNBOHDCFieldNumber = 862;

	public const int MLHAOGMNPCJFieldNumber = 1053;

	public const int JLLBHEPLKKPFieldNumber = 1064;

	public const int ABFIDIHJLHEFieldNumber = 1098;

	public const int FIDLIKNIJAKFieldNumber = 1251;

	public const int KIOBOCMOONHFieldNumber = 1277;

	public const int CLOLHIIJMPHFieldNumber = 1297;

	public const int KMKGHJJIJCNFieldNumber = 1408;

	public const int BCFEJAFMNPFFieldNumber = 1619;

	public const int PFMBIGOLHBLFieldNumber = 1683;

	public const int OIEIBBIIAMIFieldNumber = 1776;

	public const int ALLPJKHDLIBFieldNumber = 1777;

	public const int ODIOMDIDJIKFieldNumber = 1818;

	public const int FOABDDDDFBPFieldNumber = 1862;

	public const int NALNNBECBPAFieldNumber = 2041;

	public const int CDJLDNEDADGFieldNumber = 2045;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ICOMMCAJDLI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ICOMMCAJDLIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGJDOKFHCHI HMEFIMKFJJB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HMEFIMKFJJB)
			{
				return null;
			}
			return (LGJDOKFHCHI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HMEFIMKFJJB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDEJHBJBMBH EFCEICPLOPB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EFCEICPLOPB)
			{
				return null;
			}
			return (DDEJHBJBMBH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EFCEICPLOPB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFCBPKOACJD NIJGCFPHOOA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NIJGCFPHOOA)
			{
				return null;
			}
			return (AFCBPKOACJD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NIJGCFPHOOA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBLMNBOAFCJ EAFMEDAPBCD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EAFMEDAPBCD)
			{
				return null;
			}
			return (LBLMNBOAFCJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EAFMEDAPBCD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEDDFOGLMJD KACLNCHFJBN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KACLNCHFJBN)
			{
				return null;
			}
			return (LEDDFOGLMJD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KACLNCHFJBN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ OICGDJIFDHH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OICGDJIFDHH)
			{
				return null;
			}
			return (GFPPKGGCOIJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OICGDJIFDHH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAKMDAIHDMN EDOFNCKDIDF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EDOFNCKDIDF)
			{
				return null;
			}
			return (MAKMDAIHDMN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EDOFNCKDIDF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLFAFBJBCOL KNNLHEMFKBN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KNNLHEMFKBN)
			{
				return null;
			}
			return (LLFAFBJBCOL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KNNLHEMFKBN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLIBMDCOFEF HONKIOJGMDM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HONKIOJGMDM)
			{
				return null;
			}
			return (CLIBMDCOFEF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HONKIOJGMDM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHLKKMFCFHF NGDIFOLBLBB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NGDIFOLBLBB)
			{
				return null;
			}
			return (LHLKKMFCFHF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NGDIFOLBLBB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPKCGFLJIG EGLOMNOCOAJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EGLOMNOCOAJ)
			{
				return null;
			}
			return (JFPKCGFLJIG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EGLOMNOCOAJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDGCGDGDLAK HEOJMIMGHFN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HEOJMIMGHFN)
			{
				return null;
			}
			return (KDGCGDGDLAK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HEOJMIMGHFN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBEKIEALFH MKMKIGKMPFP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MKMKIGKMPFP)
			{
				return null;
			}
			return (OEBEKIEALFH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MKMKIGKMPFP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBHPEOAAND PLOHJJJFNNJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PLOHJJJFNNJ)
			{
				return null;
			}
			return (BIBHPEOAAND)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PLOHJJJFNNJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJKGBOKKNOP AGNHFMGIIAO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AGNHFMGIIAO)
			{
				return null;
			}
			return (HJKGBOKKNOP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AGNHFMGIIAO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HNCKGFGHJAC PFBBHAMOAGB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PFBBHAMOAGB)
			{
				return null;
			}
			return (HNCKGFGHJAC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PFBBHAMOAGB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBCFBKHCHJE EBALDNBOHDC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EBALDNBOHDC)
			{
				return null;
			}
			return (EBCFBKHCHJE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EBALDNBOHDC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ MLHAOGMNPCJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MLHAOGMNPCJ)
			{
				return null;
			}
			return (GFPPKGGCOIJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MLHAOGMNPCJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFCONJKHCBN JLLBHEPLKKP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JLLBHEPLKKP)
			{
				return null;
			}
			return (KFCONJKHCBN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JLLBHEPLKKP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCJAIMKNINL ABFIDIHJLHE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ABFIDIHJLHE)
			{
				return null;
			}
			return (CCJAIMKNINL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ABFIDIHJLHE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCFFJAPIIFL FIDLIKNIJAK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FIDLIKNIJAK)
			{
				return null;
			}
			return (FCFFJAPIIFL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FIDLIKNIJAK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDNIEJENNII KIOBOCMOONH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KIOBOCMOONH)
			{
				return null;
			}
			return (MDNIEJENNII)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KIOBOCMOONH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ CLOLHIIJMPH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CLOLHIIJMPH)
			{
				return null;
			}
			return (GFPPKGGCOIJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CLOLHIIJMPH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBJAEJAFCKG KMKGHJJIJCN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KMKGHJJIJCN)
			{
				return null;
			}
			return (CBJAEJAFCKG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KMKGHJJIJCN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ BCFEJAFMNPF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BCFEJAFMNPF)
			{
				return null;
			}
			return (GFPPKGGCOIJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BCFEJAFMNPF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLHIJPEAMPJ PFMBIGOLHBL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PFMBIGOLHBL)
			{
				return null;
			}
			return (NLHIJPEAMPJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PFMBIGOLHBL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJDNKBGDFA OIEIBBIIAMI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OIEIBBIIAMI)
			{
				return null;
			}
			return (HCJDNKBGDFA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OIEIBBIIAMI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLOKAOLLHMP ALLPJKHDLIB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ALLPJKHDLIB)
			{
				return null;
			}
			return (HLOKAOLLHMP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ALLPJKHDLIB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLKILGMHPFM ODIOMDIDJIK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ODIOMDIDJIK)
			{
				return null;
			}
			return (DLKILGMHPFM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ODIOMDIDJIK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBEKIEALFH FOABDDDDFBP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FOABDDDDFBP)
			{
				return null;
			}
			return (OEBEKIEALFH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FOABDDDDFBP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHCKCDAEBA NALNNBECBPA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NALNNBECBPA)
			{
				return null;
			}
			return (IDHCKCDAEBA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NALNNBECBPA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBEKIEALFH CDJLDNEDADG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CDJLDNEDADG)
			{
				return null;
			}
			return (OEBEKIEALFH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CDJLDNEDADG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICOMMCAJDLI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICOMMCAJDLI(ICOMMCAJDLI other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HMEFIMKFJJB:
			HMEFIMKFJJB = other.HMEFIMKFJJB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EFCEICPLOPB:
			EFCEICPLOPB = other.EFCEICPLOPB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NIJGCFPHOOA:
			NIJGCFPHOOA = other.NIJGCFPHOOA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EAFMEDAPBCD:
			EAFMEDAPBCD = other.EAFMEDAPBCD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KACLNCHFJBN:
			KACLNCHFJBN = other.KACLNCHFJBN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OICGDJIFDHH:
			OICGDJIFDHH = other.OICGDJIFDHH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EDOFNCKDIDF:
			EDOFNCKDIDF = other.EDOFNCKDIDF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KNNLHEMFKBN:
			KNNLHEMFKBN = other.KNNLHEMFKBN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HONKIOJGMDM:
			HONKIOJGMDM = other.HONKIOJGMDM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NGDIFOLBLBB:
			NGDIFOLBLBB = other.NGDIFOLBLBB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EGLOMNOCOAJ:
			EGLOMNOCOAJ = other.EGLOMNOCOAJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HEOJMIMGHFN:
			HEOJMIMGHFN = other.HEOJMIMGHFN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MKMKIGKMPFP:
			MKMKIGKMPFP = other.MKMKIGKMPFP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PLOHJJJFNNJ:
			PLOHJJJFNNJ = other.PLOHJJJFNNJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AGNHFMGIIAO:
			AGNHFMGIIAO = other.AGNHFMGIIAO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PFBBHAMOAGB:
			PFBBHAMOAGB = other.PFBBHAMOAGB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EBALDNBOHDC:
			EBALDNBOHDC = other.EBALDNBOHDC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MLHAOGMNPCJ:
			MLHAOGMNPCJ = other.MLHAOGMNPCJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JLLBHEPLKKP:
			JLLBHEPLKKP = other.JLLBHEPLKKP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ABFIDIHJLHE:
			ABFIDIHJLHE = other.ABFIDIHJLHE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FIDLIKNIJAK:
			FIDLIKNIJAK = other.FIDLIKNIJAK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KIOBOCMOONH:
			KIOBOCMOONH = other.KIOBOCMOONH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CLOLHIIJMPH:
			CLOLHIIJMPH = other.CLOLHIIJMPH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KMKGHJJIJCN:
			KMKGHJJIJCN = other.KMKGHJJIJCN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BCFEJAFMNPF:
			BCFEJAFMNPF = other.BCFEJAFMNPF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PFMBIGOLHBL:
			PFMBIGOLHBL = other.PFMBIGOLHBL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OIEIBBIIAMI:
			OIEIBBIIAMI = other.OIEIBBIIAMI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ALLPJKHDLIB:
			ALLPJKHDLIB = other.ALLPJKHDLIB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ODIOMDIDJIK:
			ODIOMDIDJIK = other.ODIOMDIDJIK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FOABDDDDFBP:
			FOABDDDDFBP = other.FOABDDDDFBP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NALNNBECBPA:
			NALNNBECBPA = other.NALNNBECBPA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CDJLDNEDADG:
			CDJLDNEDADG = other.CDJLDNEDADG.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICOMMCAJDLI Clone()
	{
		return new ICOMMCAJDLI(this);
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
		return Equals(other as ICOMMCAJDLI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ICOMMCAJDLI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HMEFIMKFJJB, other.HMEFIMKFJJB))
		{
			return false;
		}
		if (!object.Equals(EFCEICPLOPB, other.EFCEICPLOPB))
		{
			return false;
		}
		if (!object.Equals(NIJGCFPHOOA, other.NIJGCFPHOOA))
		{
			return false;
		}
		if (!object.Equals(EAFMEDAPBCD, other.EAFMEDAPBCD))
		{
			return false;
		}
		if (!object.Equals(KACLNCHFJBN, other.KACLNCHFJBN))
		{
			return false;
		}
		if (!object.Equals(OICGDJIFDHH, other.OICGDJIFDHH))
		{
			return false;
		}
		if (!object.Equals(EDOFNCKDIDF, other.EDOFNCKDIDF))
		{
			return false;
		}
		if (!object.Equals(KNNLHEMFKBN, other.KNNLHEMFKBN))
		{
			return false;
		}
		if (!object.Equals(HONKIOJGMDM, other.HONKIOJGMDM))
		{
			return false;
		}
		if (!object.Equals(NGDIFOLBLBB, other.NGDIFOLBLBB))
		{
			return false;
		}
		if (!object.Equals(EGLOMNOCOAJ, other.EGLOMNOCOAJ))
		{
			return false;
		}
		if (!object.Equals(HEOJMIMGHFN, other.HEOJMIMGHFN))
		{
			return false;
		}
		if (!object.Equals(MKMKIGKMPFP, other.MKMKIGKMPFP))
		{
			return false;
		}
		if (!object.Equals(PLOHJJJFNNJ, other.PLOHJJJFNNJ))
		{
			return false;
		}
		if (!object.Equals(AGNHFMGIIAO, other.AGNHFMGIIAO))
		{
			return false;
		}
		if (!object.Equals(PFBBHAMOAGB, other.PFBBHAMOAGB))
		{
			return false;
		}
		if (!object.Equals(EBALDNBOHDC, other.EBALDNBOHDC))
		{
			return false;
		}
		if (!object.Equals(MLHAOGMNPCJ, other.MLHAOGMNPCJ))
		{
			return false;
		}
		if (!object.Equals(JLLBHEPLKKP, other.JLLBHEPLKKP))
		{
			return false;
		}
		if (!object.Equals(ABFIDIHJLHE, other.ABFIDIHJLHE))
		{
			return false;
		}
		if (!object.Equals(FIDLIKNIJAK, other.FIDLIKNIJAK))
		{
			return false;
		}
		if (!object.Equals(KIOBOCMOONH, other.KIOBOCMOONH))
		{
			return false;
		}
		if (!object.Equals(CLOLHIIJMPH, other.CLOLHIIJMPH))
		{
			return false;
		}
		if (!object.Equals(KMKGHJJIJCN, other.KMKGHJJIJCN))
		{
			return false;
		}
		if (!object.Equals(BCFEJAFMNPF, other.BCFEJAFMNPF))
		{
			return false;
		}
		if (!object.Equals(PFMBIGOLHBL, other.PFMBIGOLHBL))
		{
			return false;
		}
		if (!object.Equals(OIEIBBIIAMI, other.OIEIBBIIAMI))
		{
			return false;
		}
		if (!object.Equals(ALLPJKHDLIB, other.ALLPJKHDLIB))
		{
			return false;
		}
		if (!object.Equals(ODIOMDIDJIK, other.ODIOMDIDJIK))
		{
			return false;
		}
		if (!object.Equals(FOABDDDDFBP, other.FOABDDDDFBP))
		{
			return false;
		}
		if (!object.Equals(NALNNBECBPA, other.NALNNBECBPA))
		{
			return false;
		}
		if (!object.Equals(CDJLDNEDADG, other.CDJLDNEDADG))
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMEFIMKFJJB)
		{
			num ^= HMEFIMKFJJB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EFCEICPLOPB)
		{
			num ^= EFCEICPLOPB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NIJGCFPHOOA)
		{
			num ^= NIJGCFPHOOA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EAFMEDAPBCD)
		{
			num ^= EAFMEDAPBCD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KACLNCHFJBN)
		{
			num ^= KACLNCHFJBN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OICGDJIFDHH)
		{
			num ^= OICGDJIFDHH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EDOFNCKDIDF)
		{
			num ^= EDOFNCKDIDF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KNNLHEMFKBN)
		{
			num ^= KNNLHEMFKBN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HONKIOJGMDM)
		{
			num ^= HONKIOJGMDM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGDIFOLBLBB)
		{
			num ^= NGDIFOLBLBB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGLOMNOCOAJ)
		{
			num ^= EGLOMNOCOAJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HEOJMIMGHFN)
		{
			num ^= HEOJMIMGHFN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MKMKIGKMPFP)
		{
			num ^= MKMKIGKMPFP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PLOHJJJFNNJ)
		{
			num ^= PLOHJJJFNNJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGNHFMGIIAO)
		{
			num ^= AGNHFMGIIAO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFBBHAMOAGB)
		{
			num ^= PFBBHAMOAGB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBALDNBOHDC)
		{
			num ^= EBALDNBOHDC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLHAOGMNPCJ)
		{
			num ^= MLHAOGMNPCJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLLBHEPLKKP)
		{
			num ^= JLLBHEPLKKP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABFIDIHJLHE)
		{
			num ^= ABFIDIHJLHE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FIDLIKNIJAK)
		{
			num ^= FIDLIKNIJAK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIOBOCMOONH)
		{
			num ^= KIOBOCMOONH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLOLHIIJMPH)
		{
			num ^= CLOLHIIJMPH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMKGHJJIJCN)
		{
			num ^= KMKGHJJIJCN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BCFEJAFMNPF)
		{
			num ^= BCFEJAFMNPF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFMBIGOLHBL)
		{
			num ^= PFMBIGOLHBL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIEIBBIIAMI)
		{
			num ^= OIEIBBIIAMI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ALLPJKHDLIB)
		{
			num ^= ALLPJKHDLIB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ODIOMDIDJIK)
		{
			num ^= ODIOMDIDJIK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOABDDDDFBP)
		{
			num ^= FOABDDDDFBP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NALNNBECBPA)
		{
			num ^= NALNNBECBPA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CDJLDNEDADG)
		{
			num ^= CDJLDNEDADG.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMEFIMKFJJB)
		{
			output.WriteRawTag(234, 5);
			output.WriteMessage(HMEFIMKFJJB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EFCEICPLOPB)
		{
			output.WriteRawTag(146, 7);
			output.WriteMessage(EFCEICPLOPB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NIJGCFPHOOA)
		{
			output.WriteRawTag(154, 10);
			output.WriteMessage(NIJGCFPHOOA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EAFMEDAPBCD)
		{
			output.WriteRawTag(202, 10);
			output.WriteMessage(EAFMEDAPBCD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KACLNCHFJBN)
		{
			output.WriteRawTag(242, 12);
			output.WriteMessage(KACLNCHFJBN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OICGDJIFDHH)
		{
			output.WriteRawTag(138, 16);
			output.WriteMessage(OICGDJIFDHH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EDOFNCKDIDF)
		{
			output.WriteRawTag(194, 16);
			output.WriteMessage(EDOFNCKDIDF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KNNLHEMFKBN)
		{
			output.WriteRawTag(178, 20);
			output.WriteMessage(KNNLHEMFKBN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HONKIOJGMDM)
		{
			output.WriteRawTag(170, 30);
			output.WriteMessage(HONKIOJGMDM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGDIFOLBLBB)
		{
			output.WriteRawTag(170, 36);
			output.WriteMessage(NGDIFOLBLBB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGLOMNOCOAJ)
		{
			output.WriteRawTag(242, 36);
			output.WriteMessage(EGLOMNOCOAJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HEOJMIMGHFN)
		{
			output.WriteRawTag(202, 40);
			output.WriteMessage(HEOJMIMGHFN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MKMKIGKMPFP)
		{
			output.WriteRawTag(242, 45);
			output.WriteMessage(MKMKIGKMPFP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PLOHJJJFNNJ)
		{
			output.WriteRawTag(234, 47);
			output.WriteMessage(PLOHJJJFNNJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGNHFMGIIAO)
		{
			output.WriteRawTag(202, 48);
			output.WriteMessage(AGNHFMGIIAO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFBBHAMOAGB)
		{
			output.WriteRawTag(146, 51);
			output.WriteMessage(PFBBHAMOAGB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBALDNBOHDC)
		{
			output.WriteRawTag(242, 53);
			output.WriteMessage(EBALDNBOHDC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLHAOGMNPCJ)
		{
			output.WriteRawTag(234, 65);
			output.WriteMessage(MLHAOGMNPCJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLLBHEPLKKP)
		{
			output.WriteRawTag(194, 66);
			output.WriteMessage(JLLBHEPLKKP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABFIDIHJLHE)
		{
			output.WriteRawTag(210, 68);
			output.WriteMessage(ABFIDIHJLHE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FIDLIKNIJAK)
		{
			output.WriteRawTag(154, 78);
			output.WriteMessage(FIDLIKNIJAK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIOBOCMOONH)
		{
			output.WriteRawTag(234, 79);
			output.WriteMessage(KIOBOCMOONH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLOLHIIJMPH)
		{
			output.WriteRawTag(138, 81);
			output.WriteMessage(CLOLHIIJMPH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMKGHJJIJCN)
		{
			output.WriteRawTag(130, 88);
			output.WriteMessage(KMKGHJJIJCN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BCFEJAFMNPF)
		{
			output.WriteRawTag(154, 101);
			output.WriteMessage(BCFEJAFMNPF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFMBIGOLHBL)
		{
			output.WriteRawTag(154, 105);
			output.WriteMessage(PFMBIGOLHBL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIEIBBIIAMI)
		{
			output.WriteRawTag(130, 111);
			output.WriteMessage(OIEIBBIIAMI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ALLPJKHDLIB)
		{
			output.WriteRawTag(138, 111);
			output.WriteMessage(ALLPJKHDLIB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ODIOMDIDJIK)
		{
			output.WriteRawTag(210, 113);
			output.WriteMessage(ODIOMDIDJIK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOABDDDDFBP)
		{
			output.WriteRawTag(178, 116);
			output.WriteMessage(FOABDDDDFBP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NALNNBECBPA)
		{
			output.WriteRawTag(202, 127);
			output.WriteMessage(NALNNBECBPA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CDJLDNEDADG)
		{
			output.WriteRawTag(234, 127);
			output.WriteMessage(CDJLDNEDADG);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMEFIMKFJJB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HMEFIMKFJJB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EFCEICPLOPB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EFCEICPLOPB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NIJGCFPHOOA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NIJGCFPHOOA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EAFMEDAPBCD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EAFMEDAPBCD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KACLNCHFJBN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KACLNCHFJBN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OICGDJIFDHH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OICGDJIFDHH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EDOFNCKDIDF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EDOFNCKDIDF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KNNLHEMFKBN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KNNLHEMFKBN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HONKIOJGMDM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HONKIOJGMDM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGDIFOLBLBB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NGDIFOLBLBB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGLOMNOCOAJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EGLOMNOCOAJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HEOJMIMGHFN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HEOJMIMGHFN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MKMKIGKMPFP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MKMKIGKMPFP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PLOHJJJFNNJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PLOHJJJFNNJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGNHFMGIIAO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AGNHFMGIIAO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFBBHAMOAGB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PFBBHAMOAGB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBALDNBOHDC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EBALDNBOHDC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLHAOGMNPCJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MLHAOGMNPCJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLLBHEPLKKP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JLLBHEPLKKP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABFIDIHJLHE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ABFIDIHJLHE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FIDLIKNIJAK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FIDLIKNIJAK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIOBOCMOONH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KIOBOCMOONH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLOLHIIJMPH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CLOLHIIJMPH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMKGHJJIJCN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KMKGHJJIJCN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BCFEJAFMNPF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BCFEJAFMNPF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFMBIGOLHBL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PFMBIGOLHBL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIEIBBIIAMI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OIEIBBIIAMI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ALLPJKHDLIB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ALLPJKHDLIB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ODIOMDIDJIK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ODIOMDIDJIK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOABDDDDFBP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FOABDDDDFBP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NALNNBECBPA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NALNNBECBPA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CDJLDNEDADG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CDJLDNEDADG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ICOMMCAJDLI other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HMEFIMKFJJB:
			if (HMEFIMKFJJB == null)
			{
				HMEFIMKFJJB = new LGJDOKFHCHI();
			}
			HMEFIMKFJJB.MergeFrom(other.HMEFIMKFJJB);
			break;
		case BPIHFAJCLOCOneofCase.EFCEICPLOPB:
			if (EFCEICPLOPB == null)
			{
				EFCEICPLOPB = new DDEJHBJBMBH();
			}
			EFCEICPLOPB.MergeFrom(other.EFCEICPLOPB);
			break;
		case BPIHFAJCLOCOneofCase.NIJGCFPHOOA:
			if (NIJGCFPHOOA == null)
			{
				NIJGCFPHOOA = new AFCBPKOACJD();
			}
			NIJGCFPHOOA.MergeFrom(other.NIJGCFPHOOA);
			break;
		case BPIHFAJCLOCOneofCase.EAFMEDAPBCD:
			if (EAFMEDAPBCD == null)
			{
				EAFMEDAPBCD = new LBLMNBOAFCJ();
			}
			EAFMEDAPBCD.MergeFrom(other.EAFMEDAPBCD);
			break;
		case BPIHFAJCLOCOneofCase.KACLNCHFJBN:
			if (KACLNCHFJBN == null)
			{
				KACLNCHFJBN = new LEDDFOGLMJD();
			}
			KACLNCHFJBN.MergeFrom(other.KACLNCHFJBN);
			break;
		case BPIHFAJCLOCOneofCase.OICGDJIFDHH:
			if (OICGDJIFDHH == null)
			{
				OICGDJIFDHH = new GFPPKGGCOIJ();
			}
			OICGDJIFDHH.MergeFrom(other.OICGDJIFDHH);
			break;
		case BPIHFAJCLOCOneofCase.EDOFNCKDIDF:
			if (EDOFNCKDIDF == null)
			{
				EDOFNCKDIDF = new MAKMDAIHDMN();
			}
			EDOFNCKDIDF.MergeFrom(other.EDOFNCKDIDF);
			break;
		case BPIHFAJCLOCOneofCase.KNNLHEMFKBN:
			if (KNNLHEMFKBN == null)
			{
				KNNLHEMFKBN = new LLFAFBJBCOL();
			}
			KNNLHEMFKBN.MergeFrom(other.KNNLHEMFKBN);
			break;
		case BPIHFAJCLOCOneofCase.HONKIOJGMDM:
			if (HONKIOJGMDM == null)
			{
				HONKIOJGMDM = new CLIBMDCOFEF();
			}
			HONKIOJGMDM.MergeFrom(other.HONKIOJGMDM);
			break;
		case BPIHFAJCLOCOneofCase.NGDIFOLBLBB:
			if (NGDIFOLBLBB == null)
			{
				NGDIFOLBLBB = new LHLKKMFCFHF();
			}
			NGDIFOLBLBB.MergeFrom(other.NGDIFOLBLBB);
			break;
		case BPIHFAJCLOCOneofCase.EGLOMNOCOAJ:
			if (EGLOMNOCOAJ == null)
			{
				EGLOMNOCOAJ = new JFPKCGFLJIG();
			}
			EGLOMNOCOAJ.MergeFrom(other.EGLOMNOCOAJ);
			break;
		case BPIHFAJCLOCOneofCase.HEOJMIMGHFN:
			if (HEOJMIMGHFN == null)
			{
				HEOJMIMGHFN = new KDGCGDGDLAK();
			}
			HEOJMIMGHFN.MergeFrom(other.HEOJMIMGHFN);
			break;
		case BPIHFAJCLOCOneofCase.MKMKIGKMPFP:
			if (MKMKIGKMPFP == null)
			{
				MKMKIGKMPFP = new OEBEKIEALFH();
			}
			MKMKIGKMPFP.MergeFrom(other.MKMKIGKMPFP);
			break;
		case BPIHFAJCLOCOneofCase.PLOHJJJFNNJ:
			if (PLOHJJJFNNJ == null)
			{
				PLOHJJJFNNJ = new BIBHPEOAAND();
			}
			PLOHJJJFNNJ.MergeFrom(other.PLOHJJJFNNJ);
			break;
		case BPIHFAJCLOCOneofCase.AGNHFMGIIAO:
			if (AGNHFMGIIAO == null)
			{
				AGNHFMGIIAO = new HJKGBOKKNOP();
			}
			AGNHFMGIIAO.MergeFrom(other.AGNHFMGIIAO);
			break;
		case BPIHFAJCLOCOneofCase.PFBBHAMOAGB:
			if (PFBBHAMOAGB == null)
			{
				PFBBHAMOAGB = new HNCKGFGHJAC();
			}
			PFBBHAMOAGB.MergeFrom(other.PFBBHAMOAGB);
			break;
		case BPIHFAJCLOCOneofCase.EBALDNBOHDC:
			if (EBALDNBOHDC == null)
			{
				EBALDNBOHDC = new EBCFBKHCHJE();
			}
			EBALDNBOHDC.MergeFrom(other.EBALDNBOHDC);
			break;
		case BPIHFAJCLOCOneofCase.MLHAOGMNPCJ:
			if (MLHAOGMNPCJ == null)
			{
				MLHAOGMNPCJ = new GFPPKGGCOIJ();
			}
			MLHAOGMNPCJ.MergeFrom(other.MLHAOGMNPCJ);
			break;
		case BPIHFAJCLOCOneofCase.JLLBHEPLKKP:
			if (JLLBHEPLKKP == null)
			{
				JLLBHEPLKKP = new KFCONJKHCBN();
			}
			JLLBHEPLKKP.MergeFrom(other.JLLBHEPLKKP);
			break;
		case BPIHFAJCLOCOneofCase.ABFIDIHJLHE:
			if (ABFIDIHJLHE == null)
			{
				ABFIDIHJLHE = new CCJAIMKNINL();
			}
			ABFIDIHJLHE.MergeFrom(other.ABFIDIHJLHE);
			break;
		case BPIHFAJCLOCOneofCase.FIDLIKNIJAK:
			if (FIDLIKNIJAK == null)
			{
				FIDLIKNIJAK = new FCFFJAPIIFL();
			}
			FIDLIKNIJAK.MergeFrom(other.FIDLIKNIJAK);
			break;
		case BPIHFAJCLOCOneofCase.KIOBOCMOONH:
			if (KIOBOCMOONH == null)
			{
				KIOBOCMOONH = new MDNIEJENNII();
			}
			KIOBOCMOONH.MergeFrom(other.KIOBOCMOONH);
			break;
		case BPIHFAJCLOCOneofCase.CLOLHIIJMPH:
			if (CLOLHIIJMPH == null)
			{
				CLOLHIIJMPH = new GFPPKGGCOIJ();
			}
			CLOLHIIJMPH.MergeFrom(other.CLOLHIIJMPH);
			break;
		case BPIHFAJCLOCOneofCase.KMKGHJJIJCN:
			if (KMKGHJJIJCN == null)
			{
				KMKGHJJIJCN = new CBJAEJAFCKG();
			}
			KMKGHJJIJCN.MergeFrom(other.KMKGHJJIJCN);
			break;
		case BPIHFAJCLOCOneofCase.BCFEJAFMNPF:
			if (BCFEJAFMNPF == null)
			{
				BCFEJAFMNPF = new GFPPKGGCOIJ();
			}
			BCFEJAFMNPF.MergeFrom(other.BCFEJAFMNPF);
			break;
		case BPIHFAJCLOCOneofCase.PFMBIGOLHBL:
			if (PFMBIGOLHBL == null)
			{
				PFMBIGOLHBL = new NLHIJPEAMPJ();
			}
			PFMBIGOLHBL.MergeFrom(other.PFMBIGOLHBL);
			break;
		case BPIHFAJCLOCOneofCase.OIEIBBIIAMI:
			if (OIEIBBIIAMI == null)
			{
				OIEIBBIIAMI = new HCJDNKBGDFA();
			}
			OIEIBBIIAMI.MergeFrom(other.OIEIBBIIAMI);
			break;
		case BPIHFAJCLOCOneofCase.ALLPJKHDLIB:
			if (ALLPJKHDLIB == null)
			{
				ALLPJKHDLIB = new HLOKAOLLHMP();
			}
			ALLPJKHDLIB.MergeFrom(other.ALLPJKHDLIB);
			break;
		case BPIHFAJCLOCOneofCase.ODIOMDIDJIK:
			if (ODIOMDIDJIK == null)
			{
				ODIOMDIDJIK = new DLKILGMHPFM();
			}
			ODIOMDIDJIK.MergeFrom(other.ODIOMDIDJIK);
			break;
		case BPIHFAJCLOCOneofCase.FOABDDDDFBP:
			if (FOABDDDDFBP == null)
			{
				FOABDDDDFBP = new OEBEKIEALFH();
			}
			FOABDDDDFBP.MergeFrom(other.FOABDDDDFBP);
			break;
		case BPIHFAJCLOCOneofCase.NALNNBECBPA:
			if (NALNNBECBPA == null)
			{
				NALNNBECBPA = new IDHCKCDAEBA();
			}
			NALNNBECBPA.MergeFrom(other.NALNNBECBPA);
			break;
		case BPIHFAJCLOCOneofCase.CDJLDNEDADG:
			if (CDJLDNEDADG == null)
			{
				CDJLDNEDADG = new OEBEKIEALFH();
			}
			CDJLDNEDADG.MergeFrom(other.CDJLDNEDADG);
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
			case 746u:
			{
				LGJDOKFHCHI lGJDOKFHCHI = new LGJDOKFHCHI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMEFIMKFJJB)
				{
					lGJDOKFHCHI.MergeFrom(HMEFIMKFJJB);
				}
				input.ReadMessage(lGJDOKFHCHI);
				HMEFIMKFJJB = lGJDOKFHCHI;
				break;
			}
			case 914u:
			{
				DDEJHBJBMBH dDEJHBJBMBH = new DDEJHBJBMBH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EFCEICPLOPB)
				{
					dDEJHBJBMBH.MergeFrom(EFCEICPLOPB);
				}
				input.ReadMessage(dDEJHBJBMBH);
				EFCEICPLOPB = dDEJHBJBMBH;
				break;
			}
			case 1306u:
			{
				AFCBPKOACJD aFCBPKOACJD = new AFCBPKOACJD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NIJGCFPHOOA)
				{
					aFCBPKOACJD.MergeFrom(NIJGCFPHOOA);
				}
				input.ReadMessage(aFCBPKOACJD);
				NIJGCFPHOOA = aFCBPKOACJD;
				break;
			}
			case 1354u:
			{
				LBLMNBOAFCJ lBLMNBOAFCJ = new LBLMNBOAFCJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EAFMEDAPBCD)
				{
					lBLMNBOAFCJ.MergeFrom(EAFMEDAPBCD);
				}
				input.ReadMessage(lBLMNBOAFCJ);
				EAFMEDAPBCD = lBLMNBOAFCJ;
				break;
			}
			case 1650u:
			{
				LEDDFOGLMJD lEDDFOGLMJD = new LEDDFOGLMJD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KACLNCHFJBN)
				{
					lEDDFOGLMJD.MergeFrom(KACLNCHFJBN);
				}
				input.ReadMessage(lEDDFOGLMJD);
				KACLNCHFJBN = lEDDFOGLMJD;
				break;
			}
			case 2058u:
			{
				GFPPKGGCOIJ gFPPKGGCOIJ4 = new GFPPKGGCOIJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OICGDJIFDHH)
				{
					gFPPKGGCOIJ4.MergeFrom(OICGDJIFDHH);
				}
				input.ReadMessage(gFPPKGGCOIJ4);
				OICGDJIFDHH = gFPPKGGCOIJ4;
				break;
			}
			case 2114u:
			{
				MAKMDAIHDMN mAKMDAIHDMN = new MAKMDAIHDMN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EDOFNCKDIDF)
				{
					mAKMDAIHDMN.MergeFrom(EDOFNCKDIDF);
				}
				input.ReadMessage(mAKMDAIHDMN);
				EDOFNCKDIDF = mAKMDAIHDMN;
				break;
			}
			case 2610u:
			{
				LLFAFBJBCOL lLFAFBJBCOL = new LLFAFBJBCOL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KNNLHEMFKBN)
				{
					lLFAFBJBCOL.MergeFrom(KNNLHEMFKBN);
				}
				input.ReadMessage(lLFAFBJBCOL);
				KNNLHEMFKBN = lLFAFBJBCOL;
				break;
			}
			case 3882u:
			{
				CLIBMDCOFEF cLIBMDCOFEF = new CLIBMDCOFEF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HONKIOJGMDM)
				{
					cLIBMDCOFEF.MergeFrom(HONKIOJGMDM);
				}
				input.ReadMessage(cLIBMDCOFEF);
				HONKIOJGMDM = cLIBMDCOFEF;
				break;
			}
			case 4650u:
			{
				LHLKKMFCFHF lHLKKMFCFHF = new LHLKKMFCFHF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGDIFOLBLBB)
				{
					lHLKKMFCFHF.MergeFrom(NGDIFOLBLBB);
				}
				input.ReadMessage(lHLKKMFCFHF);
				NGDIFOLBLBB = lHLKKMFCFHF;
				break;
			}
			case 4722u:
			{
				JFPKCGFLJIG jFPKCGFLJIG = new JFPKCGFLJIG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGLOMNOCOAJ)
				{
					jFPKCGFLJIG.MergeFrom(EGLOMNOCOAJ);
				}
				input.ReadMessage(jFPKCGFLJIG);
				EGLOMNOCOAJ = jFPKCGFLJIG;
				break;
			}
			case 5194u:
			{
				KDGCGDGDLAK kDGCGDGDLAK = new KDGCGDGDLAK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HEOJMIMGHFN)
				{
					kDGCGDGDLAK.MergeFrom(HEOJMIMGHFN);
				}
				input.ReadMessage(kDGCGDGDLAK);
				HEOJMIMGHFN = kDGCGDGDLAK;
				break;
			}
			case 5874u:
			{
				OEBEKIEALFH oEBEKIEALFH3 = new OEBEKIEALFH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MKMKIGKMPFP)
				{
					oEBEKIEALFH3.MergeFrom(MKMKIGKMPFP);
				}
				input.ReadMessage(oEBEKIEALFH3);
				MKMKIGKMPFP = oEBEKIEALFH3;
				break;
			}
			case 6122u:
			{
				BIBHPEOAAND bIBHPEOAAND = new BIBHPEOAAND();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PLOHJJJFNNJ)
				{
					bIBHPEOAAND.MergeFrom(PLOHJJJFNNJ);
				}
				input.ReadMessage(bIBHPEOAAND);
				PLOHJJJFNNJ = bIBHPEOAAND;
				break;
			}
			case 6218u:
			{
				HJKGBOKKNOP hJKGBOKKNOP = new HJKGBOKKNOP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGNHFMGIIAO)
				{
					hJKGBOKKNOP.MergeFrom(AGNHFMGIIAO);
				}
				input.ReadMessage(hJKGBOKKNOP);
				AGNHFMGIIAO = hJKGBOKKNOP;
				break;
			}
			case 6546u:
			{
				HNCKGFGHJAC hNCKGFGHJAC = new HNCKGFGHJAC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFBBHAMOAGB)
				{
					hNCKGFGHJAC.MergeFrom(PFBBHAMOAGB);
				}
				input.ReadMessage(hNCKGFGHJAC);
				PFBBHAMOAGB = hNCKGFGHJAC;
				break;
			}
			case 6898u:
			{
				EBCFBKHCHJE eBCFBKHCHJE = new EBCFBKHCHJE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBALDNBOHDC)
				{
					eBCFBKHCHJE.MergeFrom(EBALDNBOHDC);
				}
				input.ReadMessage(eBCFBKHCHJE);
				EBALDNBOHDC = eBCFBKHCHJE;
				break;
			}
			case 8426u:
			{
				GFPPKGGCOIJ gFPPKGGCOIJ = new GFPPKGGCOIJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLHAOGMNPCJ)
				{
					gFPPKGGCOIJ.MergeFrom(MLHAOGMNPCJ);
				}
				input.ReadMessage(gFPPKGGCOIJ);
				MLHAOGMNPCJ = gFPPKGGCOIJ;
				break;
			}
			case 8514u:
			{
				KFCONJKHCBN kFCONJKHCBN = new KFCONJKHCBN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLLBHEPLKKP)
				{
					kFCONJKHCBN.MergeFrom(JLLBHEPLKKP);
				}
				input.ReadMessage(kFCONJKHCBN);
				JLLBHEPLKKP = kFCONJKHCBN;
				break;
			}
			case 8786u:
			{
				CCJAIMKNINL cCJAIMKNINL = new CCJAIMKNINL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABFIDIHJLHE)
				{
					cCJAIMKNINL.MergeFrom(ABFIDIHJLHE);
				}
				input.ReadMessage(cCJAIMKNINL);
				ABFIDIHJLHE = cCJAIMKNINL;
				break;
			}
			case 10010u:
			{
				FCFFJAPIIFL fCFFJAPIIFL = new FCFFJAPIIFL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FIDLIKNIJAK)
				{
					fCFFJAPIIFL.MergeFrom(FIDLIKNIJAK);
				}
				input.ReadMessage(fCFFJAPIIFL);
				FIDLIKNIJAK = fCFFJAPIIFL;
				break;
			}
			case 10218u:
			{
				MDNIEJENNII mDNIEJENNII = new MDNIEJENNII();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIOBOCMOONH)
				{
					mDNIEJENNII.MergeFrom(KIOBOCMOONH);
				}
				input.ReadMessage(mDNIEJENNII);
				KIOBOCMOONH = mDNIEJENNII;
				break;
			}
			case 10378u:
			{
				GFPPKGGCOIJ gFPPKGGCOIJ3 = new GFPPKGGCOIJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLOLHIIJMPH)
				{
					gFPPKGGCOIJ3.MergeFrom(CLOLHIIJMPH);
				}
				input.ReadMessage(gFPPKGGCOIJ3);
				CLOLHIIJMPH = gFPPKGGCOIJ3;
				break;
			}
			case 11266u:
			{
				CBJAEJAFCKG cBJAEJAFCKG = new CBJAEJAFCKG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMKGHJJIJCN)
				{
					cBJAEJAFCKG.MergeFrom(KMKGHJJIJCN);
				}
				input.ReadMessage(cBJAEJAFCKG);
				KMKGHJJIJCN = cBJAEJAFCKG;
				break;
			}
			case 12954u:
			{
				GFPPKGGCOIJ gFPPKGGCOIJ2 = new GFPPKGGCOIJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BCFEJAFMNPF)
				{
					gFPPKGGCOIJ2.MergeFrom(BCFEJAFMNPF);
				}
				input.ReadMessage(gFPPKGGCOIJ2);
				BCFEJAFMNPF = gFPPKGGCOIJ2;
				break;
			}
			case 13466u:
			{
				NLHIJPEAMPJ nLHIJPEAMPJ = new NLHIJPEAMPJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFMBIGOLHBL)
				{
					nLHIJPEAMPJ.MergeFrom(PFMBIGOLHBL);
				}
				input.ReadMessage(nLHIJPEAMPJ);
				PFMBIGOLHBL = nLHIJPEAMPJ;
				break;
			}
			case 14210u:
			{
				HCJDNKBGDFA hCJDNKBGDFA = new HCJDNKBGDFA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIEIBBIIAMI)
				{
					hCJDNKBGDFA.MergeFrom(OIEIBBIIAMI);
				}
				input.ReadMessage(hCJDNKBGDFA);
				OIEIBBIIAMI = hCJDNKBGDFA;
				break;
			}
			case 14218u:
			{
				HLOKAOLLHMP hLOKAOLLHMP = new HLOKAOLLHMP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ALLPJKHDLIB)
				{
					hLOKAOLLHMP.MergeFrom(ALLPJKHDLIB);
				}
				input.ReadMessage(hLOKAOLLHMP);
				ALLPJKHDLIB = hLOKAOLLHMP;
				break;
			}
			case 14546u:
			{
				DLKILGMHPFM dLKILGMHPFM = new DLKILGMHPFM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ODIOMDIDJIK)
				{
					dLKILGMHPFM.MergeFrom(ODIOMDIDJIK);
				}
				input.ReadMessage(dLKILGMHPFM);
				ODIOMDIDJIK = dLKILGMHPFM;
				break;
			}
			case 14898u:
			{
				OEBEKIEALFH oEBEKIEALFH2 = new OEBEKIEALFH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FOABDDDDFBP)
				{
					oEBEKIEALFH2.MergeFrom(FOABDDDDFBP);
				}
				input.ReadMessage(oEBEKIEALFH2);
				FOABDDDDFBP = oEBEKIEALFH2;
				break;
			}
			case 16330u:
			{
				IDHCKCDAEBA iDHCKCDAEBA = new IDHCKCDAEBA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NALNNBECBPA)
				{
					iDHCKCDAEBA.MergeFrom(NALNNBECBPA);
				}
				input.ReadMessage(iDHCKCDAEBA);
				NALNNBECBPA = iDHCKCDAEBA;
				break;
			}
			case 16362u:
			{
				OEBEKIEALFH oEBEKIEALFH = new OEBEKIEALFH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CDJLDNEDADG)
				{
					oEBEKIEALFH.MergeFrom(CDJLDNEDADG);
				}
				input.ReadMessage(oEBEKIEALFH);
				CDJLDNEDADG = oEBEKIEALFH;
				break;
			}
			}
		}
	}
}
