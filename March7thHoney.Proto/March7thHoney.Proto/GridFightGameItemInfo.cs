using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameItemInfo : IMessage<GridFightGameItemInfo>, IMessage, IEquatable<GridFightGameItemInfo>, IDeepCloneable<GridFightGameItemInfo>, IBufferMessage
{
	public enum HIIIMGDJELJOneofCase
	{
		None = 0,
		ANAEEHCDNOK = 77,
		ONJFAJOAFOG = 215,
		BJLMCIJHGLH = 221,
		LJGEGCJGBNP = 273,
		BCCLPDCLDMN = 290,
		GIPJOGOONNG = 320,
		EGIEMFBLLDC = 469,
		FLPKFGIAJJA = 677,
		BOAIGAIEONI = 680,
		MGEMPKLCDBI = 689,
		KNAAEIHLMPH = 750,
		EBKLGLIECAL = 795,
		MENCJLIEIJK = 858,
		IFGPGILMCAG = 931,
		OOPPCDFFCKC = 1180,
		OJNNFEKNMGA = 1275,
		CMKPGOIIFHE = 1301,
		KAFBOFPKMFM = 1306,
		LMGLPGNACLP = 1318,
		MDFGMBJONAM = 1439,
		EHMHDKFJOED = 1474,
		CKGKBDPDHGM = 1657,
		ALPMCFFFLBF = 1677,
		GIHHCLKHPBL = 1710,
		KLCJBPKLJDN = 1776,
		LCDNAPGOJLJ = 1835,
		POBFCOHLOGA = 1853,
		CMKOMDAFFNP = 1854,
		CJPMGPEIFGG = 1855,
		ICHGMGIDHHC = 1874,
		DIFKACOLAFK = 1927,
		BGJIFEINIAO = 1999,
		BCMGMMJCEJC = 2009
	}

	private static readonly MessageParser<GridFightGameItemInfo> _parser = new MessageParser<GridFightGameItemInfo>(() => new GridFightGameItemInfo());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 3;

	private uint uniqueId_;

	public const int ANAEEHCDNOKFieldNumber = 77;

	public const int ONJFAJOAFOGFieldNumber = 215;

	public const int BJLMCIJHGLHFieldNumber = 221;

	public const int LJGEGCJGBNPFieldNumber = 273;

	public const int BCCLPDCLDMNFieldNumber = 290;

	public const int GIPJOGOONNGFieldNumber = 320;

	public const int EGIEMFBLLDCFieldNumber = 469;

	public const int FLPKFGIAJJAFieldNumber = 677;

	public const int BOAIGAIEONIFieldNumber = 680;

	public const int MGEMPKLCDBIFieldNumber = 689;

	public const int KNAAEIHLMPHFieldNumber = 750;

	public const int EBKLGLIECALFieldNumber = 795;

	public const int MENCJLIEIJKFieldNumber = 858;

	public const int IFGPGILMCAGFieldNumber = 931;

	public const int OOPPCDFFCKCFieldNumber = 1180;

	public const int OJNNFEKNMGAFieldNumber = 1275;

	public const int CMKPGOIIFHEFieldNumber = 1301;

	public const int KAFBOFPKMFMFieldNumber = 1306;

	public const int LMGLPGNACLPFieldNumber = 1318;

	public const int MDFGMBJONAMFieldNumber = 1439;

	public const int EHMHDKFJOEDFieldNumber = 1474;

	public const int CKGKBDPDHGMFieldNumber = 1657;

	public const int ALPMCFFFLBFFieldNumber = 1677;

	public const int GIHHCLKHPBLFieldNumber = 1710;

	public const int KLCJBPKLJDNFieldNumber = 1776;

	public const int LCDNAPGOJLJFieldNumber = 1835;

	public const int POBFCOHLOGAFieldNumber = 1853;

	public const int CMKOMDAFFNPFieldNumber = 1854;

	public const int CJPMGPEIFGGFieldNumber = 1855;

	public const int ICHGMGIDHHCFieldNumber = 1874;

	public const int DIFKACOLAFKFieldNumber = 1927;

	public const int BGJIFEINIAOFieldNumber = 1999;

	public const int BCMGMMJCEJCFieldNumber = 2009;

	private object hIIIMGDJELJ_;

	private HIIIMGDJELJOneofCase hIIIMGDJELJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameItemInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameItemInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACDGMLBDJJN ANAEEHCDNOK
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.ANAEEHCDNOK)
			{
				return null;
			}
			return (ACDGMLBDJJN)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.ANAEEHCDNOK : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPNJMMPJDKG ONJFAJOAFOG
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.ONJFAJOAFOG)
			{
				return null;
			}
			return (KPNJMMPJDKG)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.ONJFAJOAFOG : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCEJGBDBEDH BJLMCIJHGLH
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.BJLMCIJHGLH)
			{
				return null;
			}
			return (PCEJGBDBEDH)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.BJLMCIJHGLH : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOJKNKDOECP LJGEGCJGBNP
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.LJGEGCJGBNP)
			{
				return null;
			}
			return (OOJKNKDOECP)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.LJGEGCJGBNP : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFFHOPOPFJD BCCLPDCLDMN
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.BCCLPDCLDMN)
			{
				return null;
			}
			return (LFFHOPOPFJD)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.BCCLPDCLDMN : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDDNDPOPOIA GIPJOGOONNG
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.GIPJOGOONNG)
			{
				return null;
			}
			return (FDDNDPOPOIA)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.GIPJOGOONNG : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHKBPIEOLFB EGIEMFBLLDC
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.EGIEMFBLLDC)
			{
				return null;
			}
			return (JHKBPIEOLFB)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.EGIEMFBLLDC : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCOIEIDPKB FLPKFGIAJJA
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.FLPKFGIAJJA)
			{
				return null;
			}
			return (DLCOIEIDPKB)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.FLPKFGIAJJA : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKPICJKFILN BOAIGAIEONI
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.BOAIGAIEONI)
			{
				return null;
			}
			return (OKPICJKFILN)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.BOAIGAIEONI : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFODMHGNIKF MGEMPKLCDBI
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.MGEMPKLCDBI)
			{
				return null;
			}
			return (AFODMHGNIKF)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.MGEMPKLCDBI : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODGNBDDFEPD KNAAEIHLMPH
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.KNAAEIHLMPH)
			{
				return null;
			}
			return (ODGNBDDFEPD)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.KNAAEIHLMPH : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFBFFEBOAHL EBKLGLIECAL
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.EBKLGLIECAL)
			{
				return null;
			}
			return (HFBFFEBOAHL)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.EBKLGLIECAL : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBAEGAGNGKA MENCJLIEIJK
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.MENCJLIEIJK)
			{
				return null;
			}
			return (OBAEGAGNGKA)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.MENCJLIEIJK : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEPLFBAKEFC IFGPGILMCAG
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.IFGPGILMCAG)
			{
				return null;
			}
			return (MEPLFBAKEFC)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.IFGPGILMCAG : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDCFBOMKLLP OOPPCDFFCKC
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.OOPPCDFFCKC)
			{
				return null;
			}
			return (EDCFBOMKLLP)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.OOPPCDFFCKC : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMNAKOBKPFF OJNNFEKNMGA
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.OJNNFEKNMGA)
			{
				return null;
			}
			return (KMNAKOBKPFF)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.OJNNFEKNMGA : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENFNLCCOLEF CMKPGOIIFHE
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.CMKPGOIIFHE)
			{
				return null;
			}
			return (ENFNLCCOLEF)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.CMKPGOIIFHE : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIMPCMFDOME KAFBOFPKMFM
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.KAFBOFPKMFM)
			{
				return null;
			}
			return (BIMPCMFDOME)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.KAFBOFPKMFM : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCGINOONGLH LMGLPGNACLP
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.LMGLPGNACLP)
			{
				return null;
			}
			return (DCGINOONGLH)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.LMGLPGNACLP : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJJHNNDAEPF MDFGMBJONAM
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.MDFGMBJONAM)
			{
				return null;
			}
			return (HJJHNNDAEPF)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.MDFGMBJONAM : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACBBLDJNOFE EHMHDKFJOED
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.EHMHDKFJOED)
			{
				return null;
			}
			return (ACBBLDJNOFE)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.EHMHDKFJOED : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBCKKPEGLNM CKGKBDPDHGM
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.CKGKBDPDHGM)
			{
				return null;
			}
			return (NBCKKPEGLNM)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.CKGKBDPDHGM : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOOMPDMKKAJ ALPMCFFFLBF
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.ALPMCFFFLBF)
			{
				return null;
			}
			return (MOOMPDMKKAJ)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.ALPMCFFFLBF : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKLHLJGNGP GIHHCLKHPBL
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.GIHHCLKHPBL)
			{
				return null;
			}
			return (NBKLHLJGNGP)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.GIHHCLKHPBL : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHAPMJILBG KLCJBPKLJDN
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.KLCJBPKLJDN)
			{
				return null;
			}
			return (AOHAPMJILBG)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.KLCJBPKLJDN : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMLAPDGBKJO LCDNAPGOJLJ
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.LCDNAPGOJLJ)
			{
				return null;
			}
			return (HMLAPDGBKJO)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.LCDNAPGOJLJ : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFFHJIHOJFL POBFCOHLOGA
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.POBFCOHLOGA)
			{
				return null;
			}
			return (GFFHJIHOJFL)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.POBFCOHLOGA : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEBIOHPFBP CMKOMDAFFNP
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.CMKOMDAFFNP)
			{
				return null;
			}
			return (KCEBIOHPFBP)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.CMKOMDAFFNP : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFBNMHEFKIG CJPMGPEIFGG
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.CJPMGPEIFGG)
			{
				return null;
			}
			return (BFBNMHEFKIG)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.CJPMGPEIFGG : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEELLLEIJBL ICHGMGIDHHC
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.ICHGMGIDHHC)
			{
				return null;
			}
			return (CEELLLEIJBL)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.ICHGMGIDHHC : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEBNNLDNKGG DIFKACOLAFK
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.DIFKACOLAFK)
			{
				return null;
			}
			return (GEBNNLDNKGG)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.DIFKACOLAFK : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCADPJKFAJK BGJIFEINIAO
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.BGJIFEINIAO)
			{
				return null;
			}
			return (DCADPJKFAJK)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.BGJIFEINIAO : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLKEEGBIDII BCMGMMJCEJC
	{
		get
		{
			if (hIIIMGDJELJCase_ != HIIIMGDJELJOneofCase.BCMGMMJCEJC)
			{
				return null;
			}
			return (BLKEEGBIDII)hIIIMGDJELJ_;
		}
		set
		{
			hIIIMGDJELJ_ = value;
			hIIIMGDJELJCase_ = ((value != null) ? HIIIMGDJELJOneofCase.BCMGMMJCEJC : HIIIMGDJELJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIIIMGDJELJOneofCase HIIIMGDJELJCase => hIIIMGDJELJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemInfo(GridFightGameItemInfo other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		switch (other.HIIIMGDJELJCase)
		{
		case HIIIMGDJELJOneofCase.ANAEEHCDNOK:
			ANAEEHCDNOK = other.ANAEEHCDNOK.Clone();
			break;
		case HIIIMGDJELJOneofCase.ONJFAJOAFOG:
			ONJFAJOAFOG = other.ONJFAJOAFOG.Clone();
			break;
		case HIIIMGDJELJOneofCase.BJLMCIJHGLH:
			BJLMCIJHGLH = other.BJLMCIJHGLH.Clone();
			break;
		case HIIIMGDJELJOneofCase.LJGEGCJGBNP:
			LJGEGCJGBNP = other.LJGEGCJGBNP.Clone();
			break;
		case HIIIMGDJELJOneofCase.BCCLPDCLDMN:
			BCCLPDCLDMN = other.BCCLPDCLDMN.Clone();
			break;
		case HIIIMGDJELJOneofCase.GIPJOGOONNG:
			GIPJOGOONNG = other.GIPJOGOONNG.Clone();
			break;
		case HIIIMGDJELJOneofCase.EGIEMFBLLDC:
			EGIEMFBLLDC = other.EGIEMFBLLDC.Clone();
			break;
		case HIIIMGDJELJOneofCase.FLPKFGIAJJA:
			FLPKFGIAJJA = other.FLPKFGIAJJA.Clone();
			break;
		case HIIIMGDJELJOneofCase.BOAIGAIEONI:
			BOAIGAIEONI = other.BOAIGAIEONI.Clone();
			break;
		case HIIIMGDJELJOneofCase.MGEMPKLCDBI:
			MGEMPKLCDBI = other.MGEMPKLCDBI.Clone();
			break;
		case HIIIMGDJELJOneofCase.KNAAEIHLMPH:
			KNAAEIHLMPH = other.KNAAEIHLMPH.Clone();
			break;
		case HIIIMGDJELJOneofCase.EBKLGLIECAL:
			EBKLGLIECAL = other.EBKLGLIECAL.Clone();
			break;
		case HIIIMGDJELJOneofCase.MENCJLIEIJK:
			MENCJLIEIJK = other.MENCJLIEIJK.Clone();
			break;
		case HIIIMGDJELJOneofCase.IFGPGILMCAG:
			IFGPGILMCAG = other.IFGPGILMCAG.Clone();
			break;
		case HIIIMGDJELJOneofCase.OOPPCDFFCKC:
			OOPPCDFFCKC = other.OOPPCDFFCKC.Clone();
			break;
		case HIIIMGDJELJOneofCase.OJNNFEKNMGA:
			OJNNFEKNMGA = other.OJNNFEKNMGA.Clone();
			break;
		case HIIIMGDJELJOneofCase.CMKPGOIIFHE:
			CMKPGOIIFHE = other.CMKPGOIIFHE.Clone();
			break;
		case HIIIMGDJELJOneofCase.KAFBOFPKMFM:
			KAFBOFPKMFM = other.KAFBOFPKMFM.Clone();
			break;
		case HIIIMGDJELJOneofCase.LMGLPGNACLP:
			LMGLPGNACLP = other.LMGLPGNACLP.Clone();
			break;
		case HIIIMGDJELJOneofCase.MDFGMBJONAM:
			MDFGMBJONAM = other.MDFGMBJONAM.Clone();
			break;
		case HIIIMGDJELJOneofCase.EHMHDKFJOED:
			EHMHDKFJOED = other.EHMHDKFJOED.Clone();
			break;
		case HIIIMGDJELJOneofCase.CKGKBDPDHGM:
			CKGKBDPDHGM = other.CKGKBDPDHGM.Clone();
			break;
		case HIIIMGDJELJOneofCase.ALPMCFFFLBF:
			ALPMCFFFLBF = other.ALPMCFFFLBF.Clone();
			break;
		case HIIIMGDJELJOneofCase.GIHHCLKHPBL:
			GIHHCLKHPBL = other.GIHHCLKHPBL.Clone();
			break;
		case HIIIMGDJELJOneofCase.KLCJBPKLJDN:
			KLCJBPKLJDN = other.KLCJBPKLJDN.Clone();
			break;
		case HIIIMGDJELJOneofCase.LCDNAPGOJLJ:
			LCDNAPGOJLJ = other.LCDNAPGOJLJ.Clone();
			break;
		case HIIIMGDJELJOneofCase.POBFCOHLOGA:
			POBFCOHLOGA = other.POBFCOHLOGA.Clone();
			break;
		case HIIIMGDJELJOneofCase.CMKOMDAFFNP:
			CMKOMDAFFNP = other.CMKOMDAFFNP.Clone();
			break;
		case HIIIMGDJELJOneofCase.CJPMGPEIFGG:
			CJPMGPEIFGG = other.CJPMGPEIFGG.Clone();
			break;
		case HIIIMGDJELJOneofCase.ICHGMGIDHHC:
			ICHGMGIDHHC = other.ICHGMGIDHHC.Clone();
			break;
		case HIIIMGDJELJOneofCase.DIFKACOLAFK:
			DIFKACOLAFK = other.DIFKACOLAFK.Clone();
			break;
		case HIIIMGDJELJOneofCase.BGJIFEINIAO:
			BGJIFEINIAO = other.BGJIFEINIAO.Clone();
			break;
		case HIIIMGDJELJOneofCase.BCMGMMJCEJC:
			BCMGMMJCEJC = other.BCMGMMJCEJC.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemInfo Clone()
	{
		return new GridFightGameItemInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHIIIMGDJELJ()
	{
		hIIIMGDJELJCase_ = HIIIMGDJELJOneofCase.None;
		hIIIMGDJELJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameItemInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameItemInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(ANAEEHCDNOK, other.ANAEEHCDNOK))
		{
			return false;
		}
		if (!object.Equals(ONJFAJOAFOG, other.ONJFAJOAFOG))
		{
			return false;
		}
		if (!object.Equals(BJLMCIJHGLH, other.BJLMCIJHGLH))
		{
			return false;
		}
		if (!object.Equals(LJGEGCJGBNP, other.LJGEGCJGBNP))
		{
			return false;
		}
		if (!object.Equals(BCCLPDCLDMN, other.BCCLPDCLDMN))
		{
			return false;
		}
		if (!object.Equals(GIPJOGOONNG, other.GIPJOGOONNG))
		{
			return false;
		}
		if (!object.Equals(EGIEMFBLLDC, other.EGIEMFBLLDC))
		{
			return false;
		}
		if (!object.Equals(FLPKFGIAJJA, other.FLPKFGIAJJA))
		{
			return false;
		}
		if (!object.Equals(BOAIGAIEONI, other.BOAIGAIEONI))
		{
			return false;
		}
		if (!object.Equals(MGEMPKLCDBI, other.MGEMPKLCDBI))
		{
			return false;
		}
		if (!object.Equals(KNAAEIHLMPH, other.KNAAEIHLMPH))
		{
			return false;
		}
		if (!object.Equals(EBKLGLIECAL, other.EBKLGLIECAL))
		{
			return false;
		}
		if (!object.Equals(MENCJLIEIJK, other.MENCJLIEIJK))
		{
			return false;
		}
		if (!object.Equals(IFGPGILMCAG, other.IFGPGILMCAG))
		{
			return false;
		}
		if (!object.Equals(OOPPCDFFCKC, other.OOPPCDFFCKC))
		{
			return false;
		}
		if (!object.Equals(OJNNFEKNMGA, other.OJNNFEKNMGA))
		{
			return false;
		}
		if (!object.Equals(CMKPGOIIFHE, other.CMKPGOIIFHE))
		{
			return false;
		}
		if (!object.Equals(KAFBOFPKMFM, other.KAFBOFPKMFM))
		{
			return false;
		}
		if (!object.Equals(LMGLPGNACLP, other.LMGLPGNACLP))
		{
			return false;
		}
		if (!object.Equals(MDFGMBJONAM, other.MDFGMBJONAM))
		{
			return false;
		}
		if (!object.Equals(EHMHDKFJOED, other.EHMHDKFJOED))
		{
			return false;
		}
		if (!object.Equals(CKGKBDPDHGM, other.CKGKBDPDHGM))
		{
			return false;
		}
		if (!object.Equals(ALPMCFFFLBF, other.ALPMCFFFLBF))
		{
			return false;
		}
		if (!object.Equals(GIHHCLKHPBL, other.GIHHCLKHPBL))
		{
			return false;
		}
		if (!object.Equals(KLCJBPKLJDN, other.KLCJBPKLJDN))
		{
			return false;
		}
		if (!object.Equals(LCDNAPGOJLJ, other.LCDNAPGOJLJ))
		{
			return false;
		}
		if (!object.Equals(POBFCOHLOGA, other.POBFCOHLOGA))
		{
			return false;
		}
		if (!object.Equals(CMKOMDAFFNP, other.CMKOMDAFFNP))
		{
			return false;
		}
		if (!object.Equals(CJPMGPEIFGG, other.CJPMGPEIFGG))
		{
			return false;
		}
		if (!object.Equals(ICHGMGIDHHC, other.ICHGMGIDHHC))
		{
			return false;
		}
		if (!object.Equals(DIFKACOLAFK, other.DIFKACOLAFK))
		{
			return false;
		}
		if (!object.Equals(BGJIFEINIAO, other.BGJIFEINIAO))
		{
			return false;
		}
		if (!object.Equals(BCMGMMJCEJC, other.BCMGMMJCEJC))
		{
			return false;
		}
		if (HIIIMGDJELJCase != other.HIIIMGDJELJCase)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ANAEEHCDNOK)
		{
			num ^= ANAEEHCDNOK.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ONJFAJOAFOG)
		{
			num ^= ONJFAJOAFOG.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BJLMCIJHGLH)
		{
			num ^= BJLMCIJHGLH.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LJGEGCJGBNP)
		{
			num ^= LJGEGCJGBNP.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCCLPDCLDMN)
		{
			num ^= BCCLPDCLDMN.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIPJOGOONNG)
		{
			num ^= GIPJOGOONNG.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EGIEMFBLLDC)
		{
			num ^= EGIEMFBLLDC.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.FLPKFGIAJJA)
		{
			num ^= FLPKFGIAJJA.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BOAIGAIEONI)
		{
			num ^= BOAIGAIEONI.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MGEMPKLCDBI)
		{
			num ^= MGEMPKLCDBI.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KNAAEIHLMPH)
		{
			num ^= KNAAEIHLMPH.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EBKLGLIECAL)
		{
			num ^= EBKLGLIECAL.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MENCJLIEIJK)
		{
			num ^= MENCJLIEIJK.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.IFGPGILMCAG)
		{
			num ^= IFGPGILMCAG.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OOPPCDFFCKC)
		{
			num ^= OOPPCDFFCKC.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OJNNFEKNMGA)
		{
			num ^= OJNNFEKNMGA.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKPGOIIFHE)
		{
			num ^= CMKPGOIIFHE.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KAFBOFPKMFM)
		{
			num ^= KAFBOFPKMFM.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LMGLPGNACLP)
		{
			num ^= LMGLPGNACLP.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MDFGMBJONAM)
		{
			num ^= MDFGMBJONAM.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EHMHDKFJOED)
		{
			num ^= EHMHDKFJOED.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CKGKBDPDHGM)
		{
			num ^= CKGKBDPDHGM.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ALPMCFFFLBF)
		{
			num ^= ALPMCFFFLBF.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIHHCLKHPBL)
		{
			num ^= GIHHCLKHPBL.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KLCJBPKLJDN)
		{
			num ^= KLCJBPKLJDN.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LCDNAPGOJLJ)
		{
			num ^= LCDNAPGOJLJ.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.POBFCOHLOGA)
		{
			num ^= POBFCOHLOGA.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKOMDAFFNP)
		{
			num ^= CMKOMDAFFNP.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CJPMGPEIFGG)
		{
			num ^= CJPMGPEIFGG.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ICHGMGIDHHC)
		{
			num ^= ICHGMGIDHHC.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.DIFKACOLAFK)
		{
			num ^= DIFKACOLAFK.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BGJIFEINIAO)
		{
			num ^= BGJIFEINIAO.GetHashCode();
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCMGMMJCEJC)
		{
			num ^= BCMGMMJCEJC.GetHashCode();
		}
		num ^= (int)hIIIMGDJELJCase_;
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(UniqueId);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ANAEEHCDNOK)
		{
			output.WriteRawTag(234, 4);
			output.WriteMessage(ANAEEHCDNOK);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ONJFAJOAFOG)
		{
			output.WriteRawTag(186, 13);
			output.WriteMessage(ONJFAJOAFOG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BJLMCIJHGLH)
		{
			output.WriteRawTag(234, 13);
			output.WriteMessage(BJLMCIJHGLH);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LJGEGCJGBNP)
		{
			output.WriteRawTag(138, 17);
			output.WriteMessage(LJGEGCJGBNP);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCCLPDCLDMN)
		{
			output.WriteRawTag(146, 18);
			output.WriteMessage(BCCLPDCLDMN);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIPJOGOONNG)
		{
			output.WriteRawTag(130, 20);
			output.WriteMessage(GIPJOGOONNG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EGIEMFBLLDC)
		{
			output.WriteRawTag(170, 29);
			output.WriteMessage(EGIEMFBLLDC);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.FLPKFGIAJJA)
		{
			output.WriteRawTag(170, 42);
			output.WriteMessage(FLPKFGIAJJA);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BOAIGAIEONI)
		{
			output.WriteRawTag(194, 42);
			output.WriteMessage(BOAIGAIEONI);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MGEMPKLCDBI)
		{
			output.WriteRawTag(138, 43);
			output.WriteMessage(MGEMPKLCDBI);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KNAAEIHLMPH)
		{
			output.WriteRawTag(242, 46);
			output.WriteMessage(KNAAEIHLMPH);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EBKLGLIECAL)
		{
			output.WriteRawTag(218, 49);
			output.WriteMessage(EBKLGLIECAL);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MENCJLIEIJK)
		{
			output.WriteRawTag(210, 53);
			output.WriteMessage(MENCJLIEIJK);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.IFGPGILMCAG)
		{
			output.WriteRawTag(154, 58);
			output.WriteMessage(IFGPGILMCAG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OOPPCDFFCKC)
		{
			output.WriteRawTag(226, 73);
			output.WriteMessage(OOPPCDFFCKC);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OJNNFEKNMGA)
		{
			output.WriteRawTag(218, 79);
			output.WriteMessage(OJNNFEKNMGA);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKPGOIIFHE)
		{
			output.WriteRawTag(170, 81);
			output.WriteMessage(CMKPGOIIFHE);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KAFBOFPKMFM)
		{
			output.WriteRawTag(210, 81);
			output.WriteMessage(KAFBOFPKMFM);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LMGLPGNACLP)
		{
			output.WriteRawTag(178, 82);
			output.WriteMessage(LMGLPGNACLP);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MDFGMBJONAM)
		{
			output.WriteRawTag(250, 89);
			output.WriteMessage(MDFGMBJONAM);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EHMHDKFJOED)
		{
			output.WriteRawTag(146, 92);
			output.WriteMessage(EHMHDKFJOED);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CKGKBDPDHGM)
		{
			output.WriteRawTag(202, 103);
			output.WriteMessage(CKGKBDPDHGM);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ALPMCFFFLBF)
		{
			output.WriteRawTag(234, 104);
			output.WriteMessage(ALPMCFFFLBF);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIHHCLKHPBL)
		{
			output.WriteRawTag(242, 106);
			output.WriteMessage(GIHHCLKHPBL);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KLCJBPKLJDN)
		{
			output.WriteRawTag(130, 111);
			output.WriteMessage(KLCJBPKLJDN);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LCDNAPGOJLJ)
		{
			output.WriteRawTag(218, 114);
			output.WriteMessage(LCDNAPGOJLJ);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.POBFCOHLOGA)
		{
			output.WriteRawTag(234, 115);
			output.WriteMessage(POBFCOHLOGA);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKOMDAFFNP)
		{
			output.WriteRawTag(242, 115);
			output.WriteMessage(CMKOMDAFFNP);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CJPMGPEIFGG)
		{
			output.WriteRawTag(250, 115);
			output.WriteMessage(CJPMGPEIFGG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ICHGMGIDHHC)
		{
			output.WriteRawTag(146, 117);
			output.WriteMessage(ICHGMGIDHHC);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.DIFKACOLAFK)
		{
			output.WriteRawTag(186, 120);
			output.WriteMessage(DIFKACOLAFK);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BGJIFEINIAO)
		{
			output.WriteRawTag(250, 124);
			output.WriteMessage(BGJIFEINIAO);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCMGMMJCEJC)
		{
			output.WriteRawTag(202, 125);
			output.WriteMessage(BCMGMMJCEJC);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ANAEEHCDNOK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ANAEEHCDNOK);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ONJFAJOAFOG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ONJFAJOAFOG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BJLMCIJHGLH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BJLMCIJHGLH);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LJGEGCJGBNP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LJGEGCJGBNP);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCCLPDCLDMN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BCCLPDCLDMN);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIPJOGOONNG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GIPJOGOONNG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EGIEMFBLLDC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EGIEMFBLLDC);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.FLPKFGIAJJA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FLPKFGIAJJA);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BOAIGAIEONI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BOAIGAIEONI);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MGEMPKLCDBI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MGEMPKLCDBI);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KNAAEIHLMPH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KNAAEIHLMPH);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EBKLGLIECAL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EBKLGLIECAL);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MENCJLIEIJK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MENCJLIEIJK);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.IFGPGILMCAG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IFGPGILMCAG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OOPPCDFFCKC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OOPPCDFFCKC);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OJNNFEKNMGA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OJNNFEKNMGA);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKPGOIIFHE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CMKPGOIIFHE);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KAFBOFPKMFM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KAFBOFPKMFM);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LMGLPGNACLP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LMGLPGNACLP);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MDFGMBJONAM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MDFGMBJONAM);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EHMHDKFJOED)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EHMHDKFJOED);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CKGKBDPDHGM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CKGKBDPDHGM);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ALPMCFFFLBF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ALPMCFFFLBF);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIHHCLKHPBL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GIHHCLKHPBL);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KLCJBPKLJDN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KLCJBPKLJDN);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LCDNAPGOJLJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LCDNAPGOJLJ);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.POBFCOHLOGA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(POBFCOHLOGA);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKOMDAFFNP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CMKOMDAFFNP);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CJPMGPEIFGG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CJPMGPEIFGG);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ICHGMGIDHHC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ICHGMGIDHHC);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.DIFKACOLAFK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DIFKACOLAFK);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BGJIFEINIAO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BGJIFEINIAO);
		}
		if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCMGMMJCEJC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BCMGMMJCEJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameItemInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		switch (other.HIIIMGDJELJCase)
		{
		case HIIIMGDJELJOneofCase.ANAEEHCDNOK:
			if (ANAEEHCDNOK == null)
			{
				ANAEEHCDNOK = new ACDGMLBDJJN();
			}
			ANAEEHCDNOK.MergeFrom(other.ANAEEHCDNOK);
			break;
		case HIIIMGDJELJOneofCase.ONJFAJOAFOG:
			if (ONJFAJOAFOG == null)
			{
				ONJFAJOAFOG = new KPNJMMPJDKG();
			}
			ONJFAJOAFOG.MergeFrom(other.ONJFAJOAFOG);
			break;
		case HIIIMGDJELJOneofCase.BJLMCIJHGLH:
			if (BJLMCIJHGLH == null)
			{
				BJLMCIJHGLH = new PCEJGBDBEDH();
			}
			BJLMCIJHGLH.MergeFrom(other.BJLMCIJHGLH);
			break;
		case HIIIMGDJELJOneofCase.LJGEGCJGBNP:
			if (LJGEGCJGBNP == null)
			{
				LJGEGCJGBNP = new OOJKNKDOECP();
			}
			LJGEGCJGBNP.MergeFrom(other.LJGEGCJGBNP);
			break;
		case HIIIMGDJELJOneofCase.BCCLPDCLDMN:
			if (BCCLPDCLDMN == null)
			{
				BCCLPDCLDMN = new LFFHOPOPFJD();
			}
			BCCLPDCLDMN.MergeFrom(other.BCCLPDCLDMN);
			break;
		case HIIIMGDJELJOneofCase.GIPJOGOONNG:
			if (GIPJOGOONNG == null)
			{
				GIPJOGOONNG = new FDDNDPOPOIA();
			}
			GIPJOGOONNG.MergeFrom(other.GIPJOGOONNG);
			break;
		case HIIIMGDJELJOneofCase.EGIEMFBLLDC:
			if (EGIEMFBLLDC == null)
			{
				EGIEMFBLLDC = new JHKBPIEOLFB();
			}
			EGIEMFBLLDC.MergeFrom(other.EGIEMFBLLDC);
			break;
		case HIIIMGDJELJOneofCase.FLPKFGIAJJA:
			if (FLPKFGIAJJA == null)
			{
				FLPKFGIAJJA = new DLCOIEIDPKB();
			}
			FLPKFGIAJJA.MergeFrom(other.FLPKFGIAJJA);
			break;
		case HIIIMGDJELJOneofCase.BOAIGAIEONI:
			if (BOAIGAIEONI == null)
			{
				BOAIGAIEONI = new OKPICJKFILN();
			}
			BOAIGAIEONI.MergeFrom(other.BOAIGAIEONI);
			break;
		case HIIIMGDJELJOneofCase.MGEMPKLCDBI:
			if (MGEMPKLCDBI == null)
			{
				MGEMPKLCDBI = new AFODMHGNIKF();
			}
			MGEMPKLCDBI.MergeFrom(other.MGEMPKLCDBI);
			break;
		case HIIIMGDJELJOneofCase.KNAAEIHLMPH:
			if (KNAAEIHLMPH == null)
			{
				KNAAEIHLMPH = new ODGNBDDFEPD();
			}
			KNAAEIHLMPH.MergeFrom(other.KNAAEIHLMPH);
			break;
		case HIIIMGDJELJOneofCase.EBKLGLIECAL:
			if (EBKLGLIECAL == null)
			{
				EBKLGLIECAL = new HFBFFEBOAHL();
			}
			EBKLGLIECAL.MergeFrom(other.EBKLGLIECAL);
			break;
		case HIIIMGDJELJOneofCase.MENCJLIEIJK:
			if (MENCJLIEIJK == null)
			{
				MENCJLIEIJK = new OBAEGAGNGKA();
			}
			MENCJLIEIJK.MergeFrom(other.MENCJLIEIJK);
			break;
		case HIIIMGDJELJOneofCase.IFGPGILMCAG:
			if (IFGPGILMCAG == null)
			{
				IFGPGILMCAG = new MEPLFBAKEFC();
			}
			IFGPGILMCAG.MergeFrom(other.IFGPGILMCAG);
			break;
		case HIIIMGDJELJOneofCase.OOPPCDFFCKC:
			if (OOPPCDFFCKC == null)
			{
				OOPPCDFFCKC = new EDCFBOMKLLP();
			}
			OOPPCDFFCKC.MergeFrom(other.OOPPCDFFCKC);
			break;
		case HIIIMGDJELJOneofCase.OJNNFEKNMGA:
			if (OJNNFEKNMGA == null)
			{
				OJNNFEKNMGA = new KMNAKOBKPFF();
			}
			OJNNFEKNMGA.MergeFrom(other.OJNNFEKNMGA);
			break;
		case HIIIMGDJELJOneofCase.CMKPGOIIFHE:
			if (CMKPGOIIFHE == null)
			{
				CMKPGOIIFHE = new ENFNLCCOLEF();
			}
			CMKPGOIIFHE.MergeFrom(other.CMKPGOIIFHE);
			break;
		case HIIIMGDJELJOneofCase.KAFBOFPKMFM:
			if (KAFBOFPKMFM == null)
			{
				KAFBOFPKMFM = new BIMPCMFDOME();
			}
			KAFBOFPKMFM.MergeFrom(other.KAFBOFPKMFM);
			break;
		case HIIIMGDJELJOneofCase.LMGLPGNACLP:
			if (LMGLPGNACLP == null)
			{
				LMGLPGNACLP = new DCGINOONGLH();
			}
			LMGLPGNACLP.MergeFrom(other.LMGLPGNACLP);
			break;
		case HIIIMGDJELJOneofCase.MDFGMBJONAM:
			if (MDFGMBJONAM == null)
			{
				MDFGMBJONAM = new HJJHNNDAEPF();
			}
			MDFGMBJONAM.MergeFrom(other.MDFGMBJONAM);
			break;
		case HIIIMGDJELJOneofCase.EHMHDKFJOED:
			if (EHMHDKFJOED == null)
			{
				EHMHDKFJOED = new ACBBLDJNOFE();
			}
			EHMHDKFJOED.MergeFrom(other.EHMHDKFJOED);
			break;
		case HIIIMGDJELJOneofCase.CKGKBDPDHGM:
			if (CKGKBDPDHGM == null)
			{
				CKGKBDPDHGM = new NBCKKPEGLNM();
			}
			CKGKBDPDHGM.MergeFrom(other.CKGKBDPDHGM);
			break;
		case HIIIMGDJELJOneofCase.ALPMCFFFLBF:
			if (ALPMCFFFLBF == null)
			{
				ALPMCFFFLBF = new MOOMPDMKKAJ();
			}
			ALPMCFFFLBF.MergeFrom(other.ALPMCFFFLBF);
			break;
		case HIIIMGDJELJOneofCase.GIHHCLKHPBL:
			if (GIHHCLKHPBL == null)
			{
				GIHHCLKHPBL = new NBKLHLJGNGP();
			}
			GIHHCLKHPBL.MergeFrom(other.GIHHCLKHPBL);
			break;
		case HIIIMGDJELJOneofCase.KLCJBPKLJDN:
			if (KLCJBPKLJDN == null)
			{
				KLCJBPKLJDN = new AOHAPMJILBG();
			}
			KLCJBPKLJDN.MergeFrom(other.KLCJBPKLJDN);
			break;
		case HIIIMGDJELJOneofCase.LCDNAPGOJLJ:
			if (LCDNAPGOJLJ == null)
			{
				LCDNAPGOJLJ = new HMLAPDGBKJO();
			}
			LCDNAPGOJLJ.MergeFrom(other.LCDNAPGOJLJ);
			break;
		case HIIIMGDJELJOneofCase.POBFCOHLOGA:
			if (POBFCOHLOGA == null)
			{
				POBFCOHLOGA = new GFFHJIHOJFL();
			}
			POBFCOHLOGA.MergeFrom(other.POBFCOHLOGA);
			break;
		case HIIIMGDJELJOneofCase.CMKOMDAFFNP:
			if (CMKOMDAFFNP == null)
			{
				CMKOMDAFFNP = new KCEBIOHPFBP();
			}
			CMKOMDAFFNP.MergeFrom(other.CMKOMDAFFNP);
			break;
		case HIIIMGDJELJOneofCase.CJPMGPEIFGG:
			if (CJPMGPEIFGG == null)
			{
				CJPMGPEIFGG = new BFBNMHEFKIG();
			}
			CJPMGPEIFGG.MergeFrom(other.CJPMGPEIFGG);
			break;
		case HIIIMGDJELJOneofCase.ICHGMGIDHHC:
			if (ICHGMGIDHHC == null)
			{
				ICHGMGIDHHC = new CEELLLEIJBL();
			}
			ICHGMGIDHHC.MergeFrom(other.ICHGMGIDHHC);
			break;
		case HIIIMGDJELJOneofCase.DIFKACOLAFK:
			if (DIFKACOLAFK == null)
			{
				DIFKACOLAFK = new GEBNNLDNKGG();
			}
			DIFKACOLAFK.MergeFrom(other.DIFKACOLAFK);
			break;
		case HIIIMGDJELJOneofCase.BGJIFEINIAO:
			if (BGJIFEINIAO == null)
			{
				BGJIFEINIAO = new DCADPJKFAJK();
			}
			BGJIFEINIAO.MergeFrom(other.BGJIFEINIAO);
			break;
		case HIIIMGDJELJOneofCase.BCMGMMJCEJC:
			if (BCMGMMJCEJC == null)
			{
				BCMGMMJCEJC = new BLKEEGBIDII();
			}
			BCMGMMJCEJC.MergeFrom(other.BCMGMMJCEJC);
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
			case 24u:
				UniqueId = input.ReadUInt32();
				break;
			case 618u:
			{
				ACDGMLBDJJN aCDGMLBDJJN = new ACDGMLBDJJN();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ANAEEHCDNOK)
				{
					aCDGMLBDJJN.MergeFrom(ANAEEHCDNOK);
				}
				input.ReadMessage(aCDGMLBDJJN);
				ANAEEHCDNOK = aCDGMLBDJJN;
				break;
			}
			case 1722u:
			{
				KPNJMMPJDKG kPNJMMPJDKG = new KPNJMMPJDKG();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ONJFAJOAFOG)
				{
					kPNJMMPJDKG.MergeFrom(ONJFAJOAFOG);
				}
				input.ReadMessage(kPNJMMPJDKG);
				ONJFAJOAFOG = kPNJMMPJDKG;
				break;
			}
			case 1770u:
			{
				PCEJGBDBEDH pCEJGBDBEDH = new PCEJGBDBEDH();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BJLMCIJHGLH)
				{
					pCEJGBDBEDH.MergeFrom(BJLMCIJHGLH);
				}
				input.ReadMessage(pCEJGBDBEDH);
				BJLMCIJHGLH = pCEJGBDBEDH;
				break;
			}
			case 2186u:
			{
				OOJKNKDOECP oOJKNKDOECP = new OOJKNKDOECP();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LJGEGCJGBNP)
				{
					oOJKNKDOECP.MergeFrom(LJGEGCJGBNP);
				}
				input.ReadMessage(oOJKNKDOECP);
				LJGEGCJGBNP = oOJKNKDOECP;
				break;
			}
			case 2322u:
			{
				LFFHOPOPFJD lFFHOPOPFJD = new LFFHOPOPFJD();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCCLPDCLDMN)
				{
					lFFHOPOPFJD.MergeFrom(BCCLPDCLDMN);
				}
				input.ReadMessage(lFFHOPOPFJD);
				BCCLPDCLDMN = lFFHOPOPFJD;
				break;
			}
			case 2562u:
			{
				FDDNDPOPOIA fDDNDPOPOIA = new FDDNDPOPOIA();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIPJOGOONNG)
				{
					fDDNDPOPOIA.MergeFrom(GIPJOGOONNG);
				}
				input.ReadMessage(fDDNDPOPOIA);
				GIPJOGOONNG = fDDNDPOPOIA;
				break;
			}
			case 3754u:
			{
				JHKBPIEOLFB jHKBPIEOLFB = new JHKBPIEOLFB();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EGIEMFBLLDC)
				{
					jHKBPIEOLFB.MergeFrom(EGIEMFBLLDC);
				}
				input.ReadMessage(jHKBPIEOLFB);
				EGIEMFBLLDC = jHKBPIEOLFB;
				break;
			}
			case 5418u:
			{
				DLCOIEIDPKB dLCOIEIDPKB = new DLCOIEIDPKB();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.FLPKFGIAJJA)
				{
					dLCOIEIDPKB.MergeFrom(FLPKFGIAJJA);
				}
				input.ReadMessage(dLCOIEIDPKB);
				FLPKFGIAJJA = dLCOIEIDPKB;
				break;
			}
			case 5442u:
			{
				OKPICJKFILN oKPICJKFILN = new OKPICJKFILN();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BOAIGAIEONI)
				{
					oKPICJKFILN.MergeFrom(BOAIGAIEONI);
				}
				input.ReadMessage(oKPICJKFILN);
				BOAIGAIEONI = oKPICJKFILN;
				break;
			}
			case 5514u:
			{
				AFODMHGNIKF aFODMHGNIKF = new AFODMHGNIKF();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MGEMPKLCDBI)
				{
					aFODMHGNIKF.MergeFrom(MGEMPKLCDBI);
				}
				input.ReadMessage(aFODMHGNIKF);
				MGEMPKLCDBI = aFODMHGNIKF;
				break;
			}
			case 6002u:
			{
				ODGNBDDFEPD oDGNBDDFEPD = new ODGNBDDFEPD();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KNAAEIHLMPH)
				{
					oDGNBDDFEPD.MergeFrom(KNAAEIHLMPH);
				}
				input.ReadMessage(oDGNBDDFEPD);
				KNAAEIHLMPH = oDGNBDDFEPD;
				break;
			}
			case 6362u:
			{
				HFBFFEBOAHL hFBFFEBOAHL = new HFBFFEBOAHL();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EBKLGLIECAL)
				{
					hFBFFEBOAHL.MergeFrom(EBKLGLIECAL);
				}
				input.ReadMessage(hFBFFEBOAHL);
				EBKLGLIECAL = hFBFFEBOAHL;
				break;
			}
			case 6866u:
			{
				OBAEGAGNGKA oBAEGAGNGKA = new OBAEGAGNGKA();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MENCJLIEIJK)
				{
					oBAEGAGNGKA.MergeFrom(MENCJLIEIJK);
				}
				input.ReadMessage(oBAEGAGNGKA);
				MENCJLIEIJK = oBAEGAGNGKA;
				break;
			}
			case 7450u:
			{
				MEPLFBAKEFC mEPLFBAKEFC = new MEPLFBAKEFC();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.IFGPGILMCAG)
				{
					mEPLFBAKEFC.MergeFrom(IFGPGILMCAG);
				}
				input.ReadMessage(mEPLFBAKEFC);
				IFGPGILMCAG = mEPLFBAKEFC;
				break;
			}
			case 9442u:
			{
				EDCFBOMKLLP eDCFBOMKLLP = new EDCFBOMKLLP();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OOPPCDFFCKC)
				{
					eDCFBOMKLLP.MergeFrom(OOPPCDFFCKC);
				}
				input.ReadMessage(eDCFBOMKLLP);
				OOPPCDFFCKC = eDCFBOMKLLP;
				break;
			}
			case 10202u:
			{
				KMNAKOBKPFF kMNAKOBKPFF = new KMNAKOBKPFF();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.OJNNFEKNMGA)
				{
					kMNAKOBKPFF.MergeFrom(OJNNFEKNMGA);
				}
				input.ReadMessage(kMNAKOBKPFF);
				OJNNFEKNMGA = kMNAKOBKPFF;
				break;
			}
			case 10410u:
			{
				ENFNLCCOLEF eNFNLCCOLEF = new ENFNLCCOLEF();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKPGOIIFHE)
				{
					eNFNLCCOLEF.MergeFrom(CMKPGOIIFHE);
				}
				input.ReadMessage(eNFNLCCOLEF);
				CMKPGOIIFHE = eNFNLCCOLEF;
				break;
			}
			case 10450u:
			{
				BIMPCMFDOME bIMPCMFDOME = new BIMPCMFDOME();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KAFBOFPKMFM)
				{
					bIMPCMFDOME.MergeFrom(KAFBOFPKMFM);
				}
				input.ReadMessage(bIMPCMFDOME);
				KAFBOFPKMFM = bIMPCMFDOME;
				break;
			}
			case 10546u:
			{
				DCGINOONGLH dCGINOONGLH = new DCGINOONGLH();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LMGLPGNACLP)
				{
					dCGINOONGLH.MergeFrom(LMGLPGNACLP);
				}
				input.ReadMessage(dCGINOONGLH);
				LMGLPGNACLP = dCGINOONGLH;
				break;
			}
			case 11514u:
			{
				HJJHNNDAEPF hJJHNNDAEPF = new HJJHNNDAEPF();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.MDFGMBJONAM)
				{
					hJJHNNDAEPF.MergeFrom(MDFGMBJONAM);
				}
				input.ReadMessage(hJJHNNDAEPF);
				MDFGMBJONAM = hJJHNNDAEPF;
				break;
			}
			case 11794u:
			{
				ACBBLDJNOFE aCBBLDJNOFE = new ACBBLDJNOFE();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.EHMHDKFJOED)
				{
					aCBBLDJNOFE.MergeFrom(EHMHDKFJOED);
				}
				input.ReadMessage(aCBBLDJNOFE);
				EHMHDKFJOED = aCBBLDJNOFE;
				break;
			}
			case 13258u:
			{
				NBCKKPEGLNM nBCKKPEGLNM = new NBCKKPEGLNM();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CKGKBDPDHGM)
				{
					nBCKKPEGLNM.MergeFrom(CKGKBDPDHGM);
				}
				input.ReadMessage(nBCKKPEGLNM);
				CKGKBDPDHGM = nBCKKPEGLNM;
				break;
			}
			case 13418u:
			{
				MOOMPDMKKAJ mOOMPDMKKAJ = new MOOMPDMKKAJ();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ALPMCFFFLBF)
				{
					mOOMPDMKKAJ.MergeFrom(ALPMCFFFLBF);
				}
				input.ReadMessage(mOOMPDMKKAJ);
				ALPMCFFFLBF = mOOMPDMKKAJ;
				break;
			}
			case 13682u:
			{
				NBKLHLJGNGP nBKLHLJGNGP = new NBKLHLJGNGP();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.GIHHCLKHPBL)
				{
					nBKLHLJGNGP.MergeFrom(GIHHCLKHPBL);
				}
				input.ReadMessage(nBKLHLJGNGP);
				GIHHCLKHPBL = nBKLHLJGNGP;
				break;
			}
			case 14210u:
			{
				AOHAPMJILBG aOHAPMJILBG = new AOHAPMJILBG();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.KLCJBPKLJDN)
				{
					aOHAPMJILBG.MergeFrom(KLCJBPKLJDN);
				}
				input.ReadMessage(aOHAPMJILBG);
				KLCJBPKLJDN = aOHAPMJILBG;
				break;
			}
			case 14682u:
			{
				HMLAPDGBKJO hMLAPDGBKJO = new HMLAPDGBKJO();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.LCDNAPGOJLJ)
				{
					hMLAPDGBKJO.MergeFrom(LCDNAPGOJLJ);
				}
				input.ReadMessage(hMLAPDGBKJO);
				LCDNAPGOJLJ = hMLAPDGBKJO;
				break;
			}
			case 14826u:
			{
				GFFHJIHOJFL gFFHJIHOJFL = new GFFHJIHOJFL();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.POBFCOHLOGA)
				{
					gFFHJIHOJFL.MergeFrom(POBFCOHLOGA);
				}
				input.ReadMessage(gFFHJIHOJFL);
				POBFCOHLOGA = gFFHJIHOJFL;
				break;
			}
			case 14834u:
			{
				KCEBIOHPFBP kCEBIOHPFBP = new KCEBIOHPFBP();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CMKOMDAFFNP)
				{
					kCEBIOHPFBP.MergeFrom(CMKOMDAFFNP);
				}
				input.ReadMessage(kCEBIOHPFBP);
				CMKOMDAFFNP = kCEBIOHPFBP;
				break;
			}
			case 14842u:
			{
				BFBNMHEFKIG bFBNMHEFKIG = new BFBNMHEFKIG();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.CJPMGPEIFGG)
				{
					bFBNMHEFKIG.MergeFrom(CJPMGPEIFGG);
				}
				input.ReadMessage(bFBNMHEFKIG);
				CJPMGPEIFGG = bFBNMHEFKIG;
				break;
			}
			case 14994u:
			{
				CEELLLEIJBL cEELLLEIJBL = new CEELLLEIJBL();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.ICHGMGIDHHC)
				{
					cEELLLEIJBL.MergeFrom(ICHGMGIDHHC);
				}
				input.ReadMessage(cEELLLEIJBL);
				ICHGMGIDHHC = cEELLLEIJBL;
				break;
			}
			case 15418u:
			{
				GEBNNLDNKGG gEBNNLDNKGG = new GEBNNLDNKGG();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.DIFKACOLAFK)
				{
					gEBNNLDNKGG.MergeFrom(DIFKACOLAFK);
				}
				input.ReadMessage(gEBNNLDNKGG);
				DIFKACOLAFK = gEBNNLDNKGG;
				break;
			}
			case 15994u:
			{
				DCADPJKFAJK dCADPJKFAJK = new DCADPJKFAJK();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BGJIFEINIAO)
				{
					dCADPJKFAJK.MergeFrom(BGJIFEINIAO);
				}
				input.ReadMessage(dCADPJKFAJK);
				BGJIFEINIAO = dCADPJKFAJK;
				break;
			}
			case 16074u:
			{
				BLKEEGBIDII bLKEEGBIDII = new BLKEEGBIDII();
				if (hIIIMGDJELJCase_ == HIIIMGDJELJOneofCase.BCMGMMJCEJC)
				{
					bLKEEGBIDII.MergeFrom(BCMGMMJCEJC);
				}
				input.ReadMessage(bLKEEGBIDII);
				BCMGMMJCEJC = bLKEEGBIDII;
				break;
			}
			}
		}
	}
}
