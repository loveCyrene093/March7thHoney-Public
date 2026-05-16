using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectRogueBonusReq : IMessage<SelectRogueBonusReq>, IMessage, IEquatable<SelectRogueBonusReq>, IDeepCloneable<SelectRogueBonusReq>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		MBBKHCJMGGL = 30,
		PCNEJJBDELC = 171,
		ILAKOOPEODP = 257,
		LCDOOHHNCOD = 276,
		JCEHPPPCIPN = 306,
		DJFJKBBAGEO = 310,
		CLLLFIDINIM = 318,
		BEMOELCIBAI = 366,
		IICKOJJADNH = 371,
		PONMAHEIHMJ = 405,
		MIPEGJNMEEJ = 542,
		PDGCLGLOFKK = 587,
		LIMEFKDHOLD = 688,
		HJPIKLALKOD = 794,
		JPANPNNMOOF = 796,
		GCKDDBHIHDB = 824,
		HCGNAHNJCHA = 850,
		FLIKEAKPKJC = 866,
		PFKBADDNGDL = 960,
		IACIAJGBOOO = 969,
		AEIMJCGCPLH = 996,
		PJMCAEAFIKH = 1086,
		CKAACNLOIAO = 1136,
		PNIOGGNHMOA = 1269,
		KEFGOLHKCDB = 1326,
		JENBGMOEAHI = 1331,
		EBBDGALMBJI = 1366,
		JBPJALBOEAP = 1434,
		GJFPEIFHHHD = 1560,
		EGBDLDKHEMG = 1587,
		AADLFJDEMJM = 1602,
		JOMKONFFCKH = 1617,
		JCPJHLICHFJ = 1670,
		GJDECBLAJDM = 1695,
		HOFIOBKIMGP = 1816,
		EMPHNDEJGCL = 1901,
		EODFHPDLFNO = 1966,
		PJNDBKMFIKH = 1971,
		JJFGEJFFCCC = 40134,
		MBMDOJFBAJN = 108150
	}

	private static readonly MessageParser<SelectRogueBonusReq> _parser = new MessageParser<SelectRogueBonusReq>(() => new SelectRogueBonusReq());

	private UnknownFieldSet _unknownFields;

	public const int MJPCBEAAABJFieldNumber = 12;

	private uint mJPCBEAAABJ_;

	public const int MBBKHCJMGGLFieldNumber = 30;

	public const int PCNEJJBDELCFieldNumber = 171;

	public const int ILAKOOPEODPFieldNumber = 257;

	public const int LCDOOHHNCODFieldNumber = 276;

	public const int JCEHPPPCIPNFieldNumber = 306;

	public const int DJFJKBBAGEOFieldNumber = 310;

	public const int CLLLFIDINIMFieldNumber = 318;

	public const int BEMOELCIBAIFieldNumber = 366;

	public const int IICKOJJADNHFieldNumber = 371;

	public const int PONMAHEIHMJFieldNumber = 405;

	public const int MIPEGJNMEEJFieldNumber = 542;

	public const int PDGCLGLOFKKFieldNumber = 587;

	public const int LIMEFKDHOLDFieldNumber = 688;

	public const int HJPIKLALKODFieldNumber = 794;

	public const int JPANPNNMOOFFieldNumber = 796;

	public const int GCKDDBHIHDBFieldNumber = 824;

	public const int HCGNAHNJCHAFieldNumber = 850;

	public const int FLIKEAKPKJCFieldNumber = 866;

	public const int PFKBADDNGDLFieldNumber = 960;

	public const int IACIAJGBOOOFieldNumber = 969;

	public const int AEIMJCGCPLHFieldNumber = 996;

	public const int PJMCAEAFIKHFieldNumber = 1086;

	public const int CKAACNLOIAOFieldNumber = 1136;

	public const int PNIOGGNHMOAFieldNumber = 1269;

	public const int KEFGOLHKCDBFieldNumber = 1326;

	public const int JENBGMOEAHIFieldNumber = 1331;

	public const int EBBDGALMBJIFieldNumber = 1366;

	public const int JBPJALBOEAPFieldNumber = 1434;

	public const int GJFPEIFHHHDFieldNumber = 1560;

	public const int EGBDLDKHEMGFieldNumber = 1587;

	public const int AADLFJDEMJMFieldNumber = 1602;

	public const int JOMKONFFCKHFieldNumber = 1617;

	public const int JCPJHLICHFJFieldNumber = 1670;

	public const int GJDECBLAJDMFieldNumber = 1695;

	public const int HOFIOBKIMGPFieldNumber = 1816;

	public const int EMPHNDEJGCLFieldNumber = 1901;

	public const int EODFHPDLFNOFieldNumber = 1966;

	public const int PJNDBKMFIKHFieldNumber = 1971;

	public const int JJFGEJFFCCCFieldNumber = 40134;

	public const int MBMDOJFBAJNFieldNumber = 108150;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectRogueBonusReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectRogueBonusReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MJPCBEAAABJ
	{
		get
		{
			return mJPCBEAAABJ_;
		}
		set
		{
			mJPCBEAAABJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA MBBKHCJMGGL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MBBKHCJMGGL)
			{
				return null;
			}
			return (HILCNKINEIA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MBBKHCJMGGL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMIHJIMCIEA PCNEJJBDELC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PCNEJJBDELC)
			{
				return null;
			}
			return (HMIHJIMCIEA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PCNEJJBDELC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMOMLFAAIE ILAKOOPEODP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ILAKOOPEODP)
			{
				return null;
			}
			return (IEMOMLFAAIE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ILAKOOPEODP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOADBBOFBJA LCDOOHHNCOD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LCDOOHHNCOD)
			{
				return null;
			}
			return (DOADBBOFBJA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LCDOOHHNCOD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJPGLAFNJAB JCEHPPPCIPN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JCEHPPPCIPN)
			{
				return null;
			}
			return (MJPGLAFNJAB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JCEHPPPCIPN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPOHKOPAPE DJFJKBBAGEO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.DJFJKBBAGEO)
			{
				return null;
			}
			return (MKPOHKOPAPE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.DJFJKBBAGEO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIAGLOKBBMI CLLLFIDINIM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CLLLFIDINIM)
			{
				return null;
			}
			return (BIAGLOKBBMI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CLLLFIDINIM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAIELCIAKAN BEMOELCIBAI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BEMOELCIBAI)
			{
				return null;
			}
			return (JAIELCIAKAN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BEMOELCIBAI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA IICKOJJADNH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IICKOJJADNH)
			{
				return null;
			}
			return (HILCNKINEIA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IICKOJJADNH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDLLKHHBIID PONMAHEIHMJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PONMAHEIHMJ)
			{
				return null;
			}
			return (IDLLKHHBIID)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PONMAHEIHMJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEOEOJBLIBP MIPEGJNMEEJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MIPEGJNMEEJ)
			{
				return null;
			}
			return (DEOEOJBLIBP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MIPEGJNMEEJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDGFEGPHKKO PDGCLGLOFKK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PDGCLGLOFKK)
			{
				return null;
			}
			return (BDGFEGPHKKO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PDGCLGLOFKK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKDMDNEKAMN LIMEFKDHOLD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LIMEFKDHOLD)
			{
				return null;
			}
			return (EKDMDNEKAMN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LIMEFKDHOLD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPPNAHLPAFG HJPIKLALKOD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HJPIKLALKOD)
			{
				return null;
			}
			return (OPPNAHLPAFG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HJPIKLALKOD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJKEOBOMAGP JPANPNNMOOF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JPANPNNMOOF)
			{
				return null;
			}
			return (MJKEOBOMAGP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JPANPNNMOOF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDGFEGPHKKO GCKDDBHIHDB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GCKDDBHIHDB)
			{
				return null;
			}
			return (BDGFEGPHKKO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GCKDDBHIHDB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLHELOLDKA HCGNAHNJCHA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HCGNAHNJCHA)
			{
				return null;
			}
			return (IFLHELOLDKA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HCGNAHNJCHA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA FLIKEAKPKJC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FLIKEAKPKJC)
			{
				return null;
			}
			return (HILCNKINEIA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FLIKEAKPKJC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGCMJNNHFGP PFKBADDNGDL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PFKBADDNGDL)
			{
				return null;
			}
			return (DGCMJNNHFGP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PFKBADDNGDL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIELAAMEPDK IACIAJGBOOO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IACIAJGBOOO)
			{
				return null;
			}
			return (BIELAAMEPDK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IACIAJGBOOO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIFOPBNNKON AEIMJCGCPLH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AEIMJCGCPLH)
			{
				return null;
			}
			return (JIFOPBNNKON)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AEIMJCGCPLH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAPHFGPNCIJ PJMCAEAFIKH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PJMCAEAFIKH)
			{
				return null;
			}
			return (PAPHFGPNCIJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PJMCAEAFIKH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFGMHLCEAOM CKAACNLOIAO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CKAACNLOIAO)
			{
				return null;
			}
			return (FFGMHLCEAOM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CKAACNLOIAO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOBHKMGJGPG PNIOGGNHMOA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PNIOGGNHMOA)
			{
				return null;
			}
			return (EOBHKMGJGPG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PNIOGGNHMOA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPLCHBNNAHD KEFGOLHKCDB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KEFGOLHKCDB)
			{
				return null;
			}
			return (FPLCHBNNAHD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KEFGOLHKCDB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFGMHLCEAOM JENBGMOEAHI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JENBGMOEAHI)
			{
				return null;
			}
			return (FFGMHLCEAOM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JENBGMOEAHI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANBPMJHPLOP EBBDGALMBJI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EBBDGALMBJI)
			{
				return null;
			}
			return (ANBPMJHPLOP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EBBDGALMBJI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGDAPABKALH JBPJALBOEAP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JBPJALBOEAP)
			{
				return null;
			}
			return (LGDAPABKALH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JBPJALBOEAP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HGCIDHBILAC GJFPEIFHHHD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GJFPEIFHHHD)
			{
				return null;
			}
			return (HGCIDHBILAC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GJFPEIFHHHD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALHGCBPJLMO EGBDLDKHEMG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EGBDLDKHEMG)
			{
				return null;
			}
			return (ALHGCBPJLMO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EGBDLDKHEMG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HILCNKINEIA AADLFJDEMJM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AADLFJDEMJM)
			{
				return null;
			}
			return (HILCNKINEIA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AADLFJDEMJM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAMEJNMMOB JOMKONFFCKH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JOMKONFFCKH)
			{
				return null;
			}
			return (BAAMEJNMMOB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JOMKONFFCKH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMDBMLAICLB JCPJHLICHFJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JCPJHLICHFJ)
			{
				return null;
			}
			return (KMDBMLAICLB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JCPJHLICHFJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECGEFDKBCCB GJDECBLAJDM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GJDECBLAJDM)
			{
				return null;
			}
			return (ECGEFDKBCCB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GJDECBLAJDM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCMLDKKIIKA HOFIOBKIMGP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HOFIOBKIMGP)
			{
				return null;
			}
			return (BCMLDKKIIKA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HOFIOBKIMGP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNDBFOIPPFK EMPHNDEJGCL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EMPHNDEJGCL)
			{
				return null;
			}
			return (FNDBFOIPPFK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EMPHNDEJGCL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPLPCJKLIIH EODFHPDLFNO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EODFHPDLFNO)
			{
				return null;
			}
			return (GPLPCJKLIIH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EODFHPDLFNO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDGFEGPHKKO PJNDBKMFIKH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PJNDBKMFIKH)
			{
				return null;
			}
			return (BDGFEGPHKKO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PJNDBKMFIKH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFLNLJELJEM JJFGEJFFCCC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JJFGEJFFCCC)
			{
				return null;
			}
			return (OFLNLJELJEM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JJFGEJFFCCC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBLHPOBOOPE MBMDOJFBAJN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MBMDOJFBAJN)
			{
				return null;
			}
			return (IBLHPOBOOPE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MBMDOJFBAJN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectRogueBonusReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectRogueBonusReq(SelectRogueBonusReq other)
		: this()
	{
		mJPCBEAAABJ_ = other.mJPCBEAAABJ_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.MBBKHCJMGGL:
			MBBKHCJMGGL = other.MBBKHCJMGGL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PCNEJJBDELC:
			PCNEJJBDELC = other.PCNEJJBDELC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ILAKOOPEODP:
			ILAKOOPEODP = other.ILAKOOPEODP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LCDOOHHNCOD:
			LCDOOHHNCOD = other.LCDOOHHNCOD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JCEHPPPCIPN:
			JCEHPPPCIPN = other.JCEHPPPCIPN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.DJFJKBBAGEO:
			DJFJKBBAGEO = other.DJFJKBBAGEO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CLLLFIDINIM:
			CLLLFIDINIM = other.CLLLFIDINIM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BEMOELCIBAI:
			BEMOELCIBAI = other.BEMOELCIBAI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IICKOJJADNH:
			IICKOJJADNH = other.IICKOJJADNH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PONMAHEIHMJ:
			PONMAHEIHMJ = other.PONMAHEIHMJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MIPEGJNMEEJ:
			MIPEGJNMEEJ = other.MIPEGJNMEEJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PDGCLGLOFKK:
			PDGCLGLOFKK = other.PDGCLGLOFKK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LIMEFKDHOLD:
			LIMEFKDHOLD = other.LIMEFKDHOLD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HJPIKLALKOD:
			HJPIKLALKOD = other.HJPIKLALKOD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JPANPNNMOOF:
			JPANPNNMOOF = other.JPANPNNMOOF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GCKDDBHIHDB:
			GCKDDBHIHDB = other.GCKDDBHIHDB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HCGNAHNJCHA:
			HCGNAHNJCHA = other.HCGNAHNJCHA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FLIKEAKPKJC:
			FLIKEAKPKJC = other.FLIKEAKPKJC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PFKBADDNGDL:
			PFKBADDNGDL = other.PFKBADDNGDL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IACIAJGBOOO:
			IACIAJGBOOO = other.IACIAJGBOOO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AEIMJCGCPLH:
			AEIMJCGCPLH = other.AEIMJCGCPLH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PJMCAEAFIKH:
			PJMCAEAFIKH = other.PJMCAEAFIKH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CKAACNLOIAO:
			CKAACNLOIAO = other.CKAACNLOIAO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PNIOGGNHMOA:
			PNIOGGNHMOA = other.PNIOGGNHMOA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KEFGOLHKCDB:
			KEFGOLHKCDB = other.KEFGOLHKCDB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JENBGMOEAHI:
			JENBGMOEAHI = other.JENBGMOEAHI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EBBDGALMBJI:
			EBBDGALMBJI = other.EBBDGALMBJI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JBPJALBOEAP:
			JBPJALBOEAP = other.JBPJALBOEAP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GJFPEIFHHHD:
			GJFPEIFHHHD = other.GJFPEIFHHHD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EGBDLDKHEMG:
			EGBDLDKHEMG = other.EGBDLDKHEMG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AADLFJDEMJM:
			AADLFJDEMJM = other.AADLFJDEMJM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JOMKONFFCKH:
			JOMKONFFCKH = other.JOMKONFFCKH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JCPJHLICHFJ:
			JCPJHLICHFJ = other.JCPJHLICHFJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GJDECBLAJDM:
			GJDECBLAJDM = other.GJDECBLAJDM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HOFIOBKIMGP:
			HOFIOBKIMGP = other.HOFIOBKIMGP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EMPHNDEJGCL:
			EMPHNDEJGCL = other.EMPHNDEJGCL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EODFHPDLFNO:
			EODFHPDLFNO = other.EODFHPDLFNO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PJNDBKMFIKH:
			PJNDBKMFIKH = other.PJNDBKMFIKH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JJFGEJFFCCC:
			JJFGEJFFCCC = other.JJFGEJFFCCC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MBMDOJFBAJN:
			MBMDOJFBAJN = other.MBMDOJFBAJN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectRogueBonusReq Clone()
	{
		return new SelectRogueBonusReq(this);
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
		return Equals(other as SelectRogueBonusReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectRogueBonusReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MJPCBEAAABJ != other.MJPCBEAAABJ)
		{
			return false;
		}
		if (!object.Equals(MBBKHCJMGGL, other.MBBKHCJMGGL))
		{
			return false;
		}
		if (!object.Equals(PCNEJJBDELC, other.PCNEJJBDELC))
		{
			return false;
		}
		if (!object.Equals(ILAKOOPEODP, other.ILAKOOPEODP))
		{
			return false;
		}
		if (!object.Equals(LCDOOHHNCOD, other.LCDOOHHNCOD))
		{
			return false;
		}
		if (!object.Equals(JCEHPPPCIPN, other.JCEHPPPCIPN))
		{
			return false;
		}
		if (!object.Equals(DJFJKBBAGEO, other.DJFJKBBAGEO))
		{
			return false;
		}
		if (!object.Equals(CLLLFIDINIM, other.CLLLFIDINIM))
		{
			return false;
		}
		if (!object.Equals(BEMOELCIBAI, other.BEMOELCIBAI))
		{
			return false;
		}
		if (!object.Equals(IICKOJJADNH, other.IICKOJJADNH))
		{
			return false;
		}
		if (!object.Equals(PONMAHEIHMJ, other.PONMAHEIHMJ))
		{
			return false;
		}
		if (!object.Equals(MIPEGJNMEEJ, other.MIPEGJNMEEJ))
		{
			return false;
		}
		if (!object.Equals(PDGCLGLOFKK, other.PDGCLGLOFKK))
		{
			return false;
		}
		if (!object.Equals(LIMEFKDHOLD, other.LIMEFKDHOLD))
		{
			return false;
		}
		if (!object.Equals(HJPIKLALKOD, other.HJPIKLALKOD))
		{
			return false;
		}
		if (!object.Equals(JPANPNNMOOF, other.JPANPNNMOOF))
		{
			return false;
		}
		if (!object.Equals(GCKDDBHIHDB, other.GCKDDBHIHDB))
		{
			return false;
		}
		if (!object.Equals(HCGNAHNJCHA, other.HCGNAHNJCHA))
		{
			return false;
		}
		if (!object.Equals(FLIKEAKPKJC, other.FLIKEAKPKJC))
		{
			return false;
		}
		if (!object.Equals(PFKBADDNGDL, other.PFKBADDNGDL))
		{
			return false;
		}
		if (!object.Equals(IACIAJGBOOO, other.IACIAJGBOOO))
		{
			return false;
		}
		if (!object.Equals(AEIMJCGCPLH, other.AEIMJCGCPLH))
		{
			return false;
		}
		if (!object.Equals(PJMCAEAFIKH, other.PJMCAEAFIKH))
		{
			return false;
		}
		if (!object.Equals(CKAACNLOIAO, other.CKAACNLOIAO))
		{
			return false;
		}
		if (!object.Equals(PNIOGGNHMOA, other.PNIOGGNHMOA))
		{
			return false;
		}
		if (!object.Equals(KEFGOLHKCDB, other.KEFGOLHKCDB))
		{
			return false;
		}
		if (!object.Equals(JENBGMOEAHI, other.JENBGMOEAHI))
		{
			return false;
		}
		if (!object.Equals(EBBDGALMBJI, other.EBBDGALMBJI))
		{
			return false;
		}
		if (!object.Equals(JBPJALBOEAP, other.JBPJALBOEAP))
		{
			return false;
		}
		if (!object.Equals(GJFPEIFHHHD, other.GJFPEIFHHHD))
		{
			return false;
		}
		if (!object.Equals(EGBDLDKHEMG, other.EGBDLDKHEMG))
		{
			return false;
		}
		if (!object.Equals(AADLFJDEMJM, other.AADLFJDEMJM))
		{
			return false;
		}
		if (!object.Equals(JOMKONFFCKH, other.JOMKONFFCKH))
		{
			return false;
		}
		if (!object.Equals(JCPJHLICHFJ, other.JCPJHLICHFJ))
		{
			return false;
		}
		if (!object.Equals(GJDECBLAJDM, other.GJDECBLAJDM))
		{
			return false;
		}
		if (!object.Equals(HOFIOBKIMGP, other.HOFIOBKIMGP))
		{
			return false;
		}
		if (!object.Equals(EMPHNDEJGCL, other.EMPHNDEJGCL))
		{
			return false;
		}
		if (!object.Equals(EODFHPDLFNO, other.EODFHPDLFNO))
		{
			return false;
		}
		if (!object.Equals(PJNDBKMFIKH, other.PJNDBKMFIKH))
		{
			return false;
		}
		if (!object.Equals(JJFGEJFFCCC, other.JJFGEJFFCCC))
		{
			return false;
		}
		if (!object.Equals(MBMDOJFBAJN, other.MBMDOJFBAJN))
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
		if (MJPCBEAAABJ != 0)
		{
			num ^= MJPCBEAAABJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBBKHCJMGGL)
		{
			num ^= MBBKHCJMGGL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PCNEJJBDELC)
		{
			num ^= PCNEJJBDELC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
		{
			num ^= ILAKOOPEODP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LCDOOHHNCOD)
		{
			num ^= LCDOOHHNCOD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCEHPPPCIPN)
		{
			num ^= JCEHPPPCIPN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DJFJKBBAGEO)
		{
			num ^= DJFJKBBAGEO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLLLFIDINIM)
		{
			num ^= CLLLFIDINIM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BEMOELCIBAI)
		{
			num ^= BEMOELCIBAI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IICKOJJADNH)
		{
			num ^= IICKOJJADNH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PONMAHEIHMJ)
		{
			num ^= PONMAHEIHMJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MIPEGJNMEEJ)
		{
			num ^= MIPEGJNMEEJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PDGCLGLOFKK)
		{
			num ^= PDGCLGLOFKK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIMEFKDHOLD)
		{
			num ^= LIMEFKDHOLD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJPIKLALKOD)
		{
			num ^= HJPIKLALKOD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JPANPNNMOOF)
		{
			num ^= JPANPNNMOOF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GCKDDBHIHDB)
		{
			num ^= GCKDDBHIHDB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HCGNAHNJCHA)
		{
			num ^= HCGNAHNJCHA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FLIKEAKPKJC)
		{
			num ^= FLIKEAKPKJC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFKBADDNGDL)
		{
			num ^= PFKBADDNGDL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IACIAJGBOOO)
		{
			num ^= IACIAJGBOOO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AEIMJCGCPLH)
		{
			num ^= AEIMJCGCPLH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJMCAEAFIKH)
		{
			num ^= PJMCAEAFIKH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKAACNLOIAO)
		{
			num ^= CKAACNLOIAO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PNIOGGNHMOA)
		{
			num ^= PNIOGGNHMOA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KEFGOLHKCDB)
		{
			num ^= KEFGOLHKCDB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JENBGMOEAHI)
		{
			num ^= JENBGMOEAHI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBBDGALMBJI)
		{
			num ^= EBBDGALMBJI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JBPJALBOEAP)
		{
			num ^= JBPJALBOEAP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJFPEIFHHHD)
		{
			num ^= GJFPEIFHHHD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGBDLDKHEMG)
		{
			num ^= EGBDLDKHEMG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AADLFJDEMJM)
		{
			num ^= AADLFJDEMJM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JOMKONFFCKH)
		{
			num ^= JOMKONFFCKH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCPJHLICHFJ)
		{
			num ^= JCPJHLICHFJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJDECBLAJDM)
		{
			num ^= GJDECBLAJDM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HOFIOBKIMGP)
		{
			num ^= HOFIOBKIMGP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EMPHNDEJGCL)
		{
			num ^= EMPHNDEJGCL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EODFHPDLFNO)
		{
			num ^= EODFHPDLFNO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJNDBKMFIKH)
		{
			num ^= PJNDBKMFIKH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JJFGEJFFCCC)
		{
			num ^= JJFGEJFFCCC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBMDOJFBAJN)
		{
			num ^= MBMDOJFBAJN.GetHashCode();
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
		if (MJPCBEAAABJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MJPCBEAAABJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBBKHCJMGGL)
		{
			output.WriteRawTag(242, 1);
			output.WriteMessage(MBBKHCJMGGL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PCNEJJBDELC)
		{
			output.WriteRawTag(218, 10);
			output.WriteMessage(PCNEJJBDELC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
		{
			output.WriteRawTag(138, 16);
			output.WriteMessage(ILAKOOPEODP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LCDOOHHNCOD)
		{
			output.WriteRawTag(162, 17);
			output.WriteMessage(LCDOOHHNCOD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCEHPPPCIPN)
		{
			output.WriteRawTag(146, 19);
			output.WriteMessage(JCEHPPPCIPN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DJFJKBBAGEO)
		{
			output.WriteRawTag(178, 19);
			output.WriteMessage(DJFJKBBAGEO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLLLFIDINIM)
		{
			output.WriteRawTag(242, 19);
			output.WriteMessage(CLLLFIDINIM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BEMOELCIBAI)
		{
			output.WriteRawTag(242, 22);
			output.WriteMessage(BEMOELCIBAI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IICKOJJADNH)
		{
			output.WriteRawTag(154, 23);
			output.WriteMessage(IICKOJJADNH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PONMAHEIHMJ)
		{
			output.WriteRawTag(170, 25);
			output.WriteMessage(PONMAHEIHMJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MIPEGJNMEEJ)
		{
			output.WriteRawTag(242, 33);
			output.WriteMessage(MIPEGJNMEEJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PDGCLGLOFKK)
		{
			output.WriteRawTag(218, 36);
			output.WriteMessage(PDGCLGLOFKK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIMEFKDHOLD)
		{
			output.WriteRawTag(130, 43);
			output.WriteMessage(LIMEFKDHOLD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJPIKLALKOD)
		{
			output.WriteRawTag(210, 49);
			output.WriteMessage(HJPIKLALKOD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JPANPNNMOOF)
		{
			output.WriteRawTag(226, 49);
			output.WriteMessage(JPANPNNMOOF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GCKDDBHIHDB)
		{
			output.WriteRawTag(194, 51);
			output.WriteMessage(GCKDDBHIHDB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HCGNAHNJCHA)
		{
			output.WriteRawTag(146, 53);
			output.WriteMessage(HCGNAHNJCHA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FLIKEAKPKJC)
		{
			output.WriteRawTag(146, 54);
			output.WriteMessage(FLIKEAKPKJC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFKBADDNGDL)
		{
			output.WriteRawTag(130, 60);
			output.WriteMessage(PFKBADDNGDL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IACIAJGBOOO)
		{
			output.WriteRawTag(202, 60);
			output.WriteMessage(IACIAJGBOOO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AEIMJCGCPLH)
		{
			output.WriteRawTag(162, 62);
			output.WriteMessage(AEIMJCGCPLH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJMCAEAFIKH)
		{
			output.WriteRawTag(242, 67);
			output.WriteMessage(PJMCAEAFIKH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKAACNLOIAO)
		{
			output.WriteRawTag(130, 71);
			output.WriteMessage(CKAACNLOIAO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PNIOGGNHMOA)
		{
			output.WriteRawTag(170, 79);
			output.WriteMessage(PNIOGGNHMOA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KEFGOLHKCDB)
		{
			output.WriteRawTag(242, 82);
			output.WriteMessage(KEFGOLHKCDB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JENBGMOEAHI)
		{
			output.WriteRawTag(154, 83);
			output.WriteMessage(JENBGMOEAHI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBBDGALMBJI)
		{
			output.WriteRawTag(178, 85);
			output.WriteMessage(EBBDGALMBJI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JBPJALBOEAP)
		{
			output.WriteRawTag(210, 89);
			output.WriteMessage(JBPJALBOEAP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJFPEIFHHHD)
		{
			output.WriteRawTag(194, 97);
			output.WriteMessage(GJFPEIFHHHD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGBDLDKHEMG)
		{
			output.WriteRawTag(154, 99);
			output.WriteMessage(EGBDLDKHEMG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AADLFJDEMJM)
		{
			output.WriteRawTag(146, 100);
			output.WriteMessage(AADLFJDEMJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JOMKONFFCKH)
		{
			output.WriteRawTag(138, 101);
			output.WriteMessage(JOMKONFFCKH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCPJHLICHFJ)
		{
			output.WriteRawTag(178, 104);
			output.WriteMessage(JCPJHLICHFJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJDECBLAJDM)
		{
			output.WriteRawTag(250, 105);
			output.WriteMessage(GJDECBLAJDM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HOFIOBKIMGP)
		{
			output.WriteRawTag(194, 113);
			output.WriteMessage(HOFIOBKIMGP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EMPHNDEJGCL)
		{
			output.WriteRawTag(234, 118);
			output.WriteMessage(EMPHNDEJGCL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EODFHPDLFNO)
		{
			output.WriteRawTag(242, 122);
			output.WriteMessage(EODFHPDLFNO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJNDBKMFIKH)
		{
			output.WriteRawTag(154, 123);
			output.WriteMessage(PJNDBKMFIKH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JJFGEJFFCCC)
		{
			output.WriteRawTag(178, 204, 19);
			output.WriteMessage(JJFGEJFFCCC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBMDOJFBAJN)
		{
			output.WriteRawTag(178, 231, 52);
			output.WriteMessage(MBMDOJFBAJN);
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
		if (MJPCBEAAABJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MJPCBEAAABJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBBKHCJMGGL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MBBKHCJMGGL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PCNEJJBDELC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PCNEJJBDELC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ILAKOOPEODP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LCDOOHHNCOD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LCDOOHHNCOD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCEHPPPCIPN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JCEHPPPCIPN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DJFJKBBAGEO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DJFJKBBAGEO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLLLFIDINIM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CLLLFIDINIM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BEMOELCIBAI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BEMOELCIBAI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IICKOJJADNH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IICKOJJADNH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PONMAHEIHMJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PONMAHEIHMJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MIPEGJNMEEJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MIPEGJNMEEJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PDGCLGLOFKK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PDGCLGLOFKK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIMEFKDHOLD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LIMEFKDHOLD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJPIKLALKOD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HJPIKLALKOD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JPANPNNMOOF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JPANPNNMOOF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GCKDDBHIHDB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GCKDDBHIHDB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HCGNAHNJCHA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HCGNAHNJCHA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FLIKEAKPKJC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FLIKEAKPKJC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFKBADDNGDL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PFKBADDNGDL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IACIAJGBOOO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IACIAJGBOOO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AEIMJCGCPLH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AEIMJCGCPLH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJMCAEAFIKH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PJMCAEAFIKH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKAACNLOIAO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CKAACNLOIAO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PNIOGGNHMOA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PNIOGGNHMOA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KEFGOLHKCDB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KEFGOLHKCDB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JENBGMOEAHI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JENBGMOEAHI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBBDGALMBJI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EBBDGALMBJI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JBPJALBOEAP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JBPJALBOEAP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJFPEIFHHHD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GJFPEIFHHHD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGBDLDKHEMG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EGBDLDKHEMG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AADLFJDEMJM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AADLFJDEMJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JOMKONFFCKH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JOMKONFFCKH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCPJHLICHFJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JCPJHLICHFJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJDECBLAJDM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GJDECBLAJDM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HOFIOBKIMGP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HOFIOBKIMGP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EMPHNDEJGCL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EMPHNDEJGCL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EODFHPDLFNO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EODFHPDLFNO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJNDBKMFIKH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PJNDBKMFIKH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JJFGEJFFCCC)
		{
			num += 3 + CodedOutputStream.ComputeMessageSize(JJFGEJFFCCC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBMDOJFBAJN)
		{
			num += 3 + CodedOutputStream.ComputeMessageSize(MBMDOJFBAJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectRogueBonusReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MJPCBEAAABJ != 0)
		{
			MJPCBEAAABJ = other.MJPCBEAAABJ;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.MBBKHCJMGGL:
			if (MBBKHCJMGGL == null)
			{
				MBBKHCJMGGL = new HILCNKINEIA();
			}
			MBBKHCJMGGL.MergeFrom(other.MBBKHCJMGGL);
			break;
		case BPIHFAJCLOCOneofCase.PCNEJJBDELC:
			if (PCNEJJBDELC == null)
			{
				PCNEJJBDELC = new HMIHJIMCIEA();
			}
			PCNEJJBDELC.MergeFrom(other.PCNEJJBDELC);
			break;
		case BPIHFAJCLOCOneofCase.ILAKOOPEODP:
			if (ILAKOOPEODP == null)
			{
				ILAKOOPEODP = new IEMOMLFAAIE();
			}
			ILAKOOPEODP.MergeFrom(other.ILAKOOPEODP);
			break;
		case BPIHFAJCLOCOneofCase.LCDOOHHNCOD:
			if (LCDOOHHNCOD == null)
			{
				LCDOOHHNCOD = new DOADBBOFBJA();
			}
			LCDOOHHNCOD.MergeFrom(other.LCDOOHHNCOD);
			break;
		case BPIHFAJCLOCOneofCase.JCEHPPPCIPN:
			if (JCEHPPPCIPN == null)
			{
				JCEHPPPCIPN = new MJPGLAFNJAB();
			}
			JCEHPPPCIPN.MergeFrom(other.JCEHPPPCIPN);
			break;
		case BPIHFAJCLOCOneofCase.DJFJKBBAGEO:
			if (DJFJKBBAGEO == null)
			{
				DJFJKBBAGEO = new MKPOHKOPAPE();
			}
			DJFJKBBAGEO.MergeFrom(other.DJFJKBBAGEO);
			break;
		case BPIHFAJCLOCOneofCase.CLLLFIDINIM:
			if (CLLLFIDINIM == null)
			{
				CLLLFIDINIM = new BIAGLOKBBMI();
			}
			CLLLFIDINIM.MergeFrom(other.CLLLFIDINIM);
			break;
		case BPIHFAJCLOCOneofCase.BEMOELCIBAI:
			if (BEMOELCIBAI == null)
			{
				BEMOELCIBAI = new JAIELCIAKAN();
			}
			BEMOELCIBAI.MergeFrom(other.BEMOELCIBAI);
			break;
		case BPIHFAJCLOCOneofCase.IICKOJJADNH:
			if (IICKOJJADNH == null)
			{
				IICKOJJADNH = new HILCNKINEIA();
			}
			IICKOJJADNH.MergeFrom(other.IICKOJJADNH);
			break;
		case BPIHFAJCLOCOneofCase.PONMAHEIHMJ:
			if (PONMAHEIHMJ == null)
			{
				PONMAHEIHMJ = new IDLLKHHBIID();
			}
			PONMAHEIHMJ.MergeFrom(other.PONMAHEIHMJ);
			break;
		case BPIHFAJCLOCOneofCase.MIPEGJNMEEJ:
			if (MIPEGJNMEEJ == null)
			{
				MIPEGJNMEEJ = new DEOEOJBLIBP();
			}
			MIPEGJNMEEJ.MergeFrom(other.MIPEGJNMEEJ);
			break;
		case BPIHFAJCLOCOneofCase.PDGCLGLOFKK:
			if (PDGCLGLOFKK == null)
			{
				PDGCLGLOFKK = new BDGFEGPHKKO();
			}
			PDGCLGLOFKK.MergeFrom(other.PDGCLGLOFKK);
			break;
		case BPIHFAJCLOCOneofCase.LIMEFKDHOLD:
			if (LIMEFKDHOLD == null)
			{
				LIMEFKDHOLD = new EKDMDNEKAMN();
			}
			LIMEFKDHOLD.MergeFrom(other.LIMEFKDHOLD);
			break;
		case BPIHFAJCLOCOneofCase.HJPIKLALKOD:
			if (HJPIKLALKOD == null)
			{
				HJPIKLALKOD = new OPPNAHLPAFG();
			}
			HJPIKLALKOD.MergeFrom(other.HJPIKLALKOD);
			break;
		case BPIHFAJCLOCOneofCase.JPANPNNMOOF:
			if (JPANPNNMOOF == null)
			{
				JPANPNNMOOF = new MJKEOBOMAGP();
			}
			JPANPNNMOOF.MergeFrom(other.JPANPNNMOOF);
			break;
		case BPIHFAJCLOCOneofCase.GCKDDBHIHDB:
			if (GCKDDBHIHDB == null)
			{
				GCKDDBHIHDB = new BDGFEGPHKKO();
			}
			GCKDDBHIHDB.MergeFrom(other.GCKDDBHIHDB);
			break;
		case BPIHFAJCLOCOneofCase.HCGNAHNJCHA:
			if (HCGNAHNJCHA == null)
			{
				HCGNAHNJCHA = new IFLHELOLDKA();
			}
			HCGNAHNJCHA.MergeFrom(other.HCGNAHNJCHA);
			break;
		case BPIHFAJCLOCOneofCase.FLIKEAKPKJC:
			if (FLIKEAKPKJC == null)
			{
				FLIKEAKPKJC = new HILCNKINEIA();
			}
			FLIKEAKPKJC.MergeFrom(other.FLIKEAKPKJC);
			break;
		case BPIHFAJCLOCOneofCase.PFKBADDNGDL:
			if (PFKBADDNGDL == null)
			{
				PFKBADDNGDL = new DGCMJNNHFGP();
			}
			PFKBADDNGDL.MergeFrom(other.PFKBADDNGDL);
			break;
		case BPIHFAJCLOCOneofCase.IACIAJGBOOO:
			if (IACIAJGBOOO == null)
			{
				IACIAJGBOOO = new BIELAAMEPDK();
			}
			IACIAJGBOOO.MergeFrom(other.IACIAJGBOOO);
			break;
		case BPIHFAJCLOCOneofCase.AEIMJCGCPLH:
			if (AEIMJCGCPLH == null)
			{
				AEIMJCGCPLH = new JIFOPBNNKON();
			}
			AEIMJCGCPLH.MergeFrom(other.AEIMJCGCPLH);
			break;
		case BPIHFAJCLOCOneofCase.PJMCAEAFIKH:
			if (PJMCAEAFIKH == null)
			{
				PJMCAEAFIKH = new PAPHFGPNCIJ();
			}
			PJMCAEAFIKH.MergeFrom(other.PJMCAEAFIKH);
			break;
		case BPIHFAJCLOCOneofCase.CKAACNLOIAO:
			if (CKAACNLOIAO == null)
			{
				CKAACNLOIAO = new FFGMHLCEAOM();
			}
			CKAACNLOIAO.MergeFrom(other.CKAACNLOIAO);
			break;
		case BPIHFAJCLOCOneofCase.PNIOGGNHMOA:
			if (PNIOGGNHMOA == null)
			{
				PNIOGGNHMOA = new EOBHKMGJGPG();
			}
			PNIOGGNHMOA.MergeFrom(other.PNIOGGNHMOA);
			break;
		case BPIHFAJCLOCOneofCase.KEFGOLHKCDB:
			if (KEFGOLHKCDB == null)
			{
				KEFGOLHKCDB = new FPLCHBNNAHD();
			}
			KEFGOLHKCDB.MergeFrom(other.KEFGOLHKCDB);
			break;
		case BPIHFAJCLOCOneofCase.JENBGMOEAHI:
			if (JENBGMOEAHI == null)
			{
				JENBGMOEAHI = new FFGMHLCEAOM();
			}
			JENBGMOEAHI.MergeFrom(other.JENBGMOEAHI);
			break;
		case BPIHFAJCLOCOneofCase.EBBDGALMBJI:
			if (EBBDGALMBJI == null)
			{
				EBBDGALMBJI = new ANBPMJHPLOP();
			}
			EBBDGALMBJI.MergeFrom(other.EBBDGALMBJI);
			break;
		case BPIHFAJCLOCOneofCase.JBPJALBOEAP:
			if (JBPJALBOEAP == null)
			{
				JBPJALBOEAP = new LGDAPABKALH();
			}
			JBPJALBOEAP.MergeFrom(other.JBPJALBOEAP);
			break;
		case BPIHFAJCLOCOneofCase.GJFPEIFHHHD:
			if (GJFPEIFHHHD == null)
			{
				GJFPEIFHHHD = new HGCIDHBILAC();
			}
			GJFPEIFHHHD.MergeFrom(other.GJFPEIFHHHD);
			break;
		case BPIHFAJCLOCOneofCase.EGBDLDKHEMG:
			if (EGBDLDKHEMG == null)
			{
				EGBDLDKHEMG = new ALHGCBPJLMO();
			}
			EGBDLDKHEMG.MergeFrom(other.EGBDLDKHEMG);
			break;
		case BPIHFAJCLOCOneofCase.AADLFJDEMJM:
			if (AADLFJDEMJM == null)
			{
				AADLFJDEMJM = new HILCNKINEIA();
			}
			AADLFJDEMJM.MergeFrom(other.AADLFJDEMJM);
			break;
		case BPIHFAJCLOCOneofCase.JOMKONFFCKH:
			if (JOMKONFFCKH == null)
			{
				JOMKONFFCKH = new BAAMEJNMMOB();
			}
			JOMKONFFCKH.MergeFrom(other.JOMKONFFCKH);
			break;
		case BPIHFAJCLOCOneofCase.JCPJHLICHFJ:
			if (JCPJHLICHFJ == null)
			{
				JCPJHLICHFJ = new KMDBMLAICLB();
			}
			JCPJHLICHFJ.MergeFrom(other.JCPJHLICHFJ);
			break;
		case BPIHFAJCLOCOneofCase.GJDECBLAJDM:
			if (GJDECBLAJDM == null)
			{
				GJDECBLAJDM = new ECGEFDKBCCB();
			}
			GJDECBLAJDM.MergeFrom(other.GJDECBLAJDM);
			break;
		case BPIHFAJCLOCOneofCase.HOFIOBKIMGP:
			if (HOFIOBKIMGP == null)
			{
				HOFIOBKIMGP = new BCMLDKKIIKA();
			}
			HOFIOBKIMGP.MergeFrom(other.HOFIOBKIMGP);
			break;
		case BPIHFAJCLOCOneofCase.EMPHNDEJGCL:
			if (EMPHNDEJGCL == null)
			{
				EMPHNDEJGCL = new FNDBFOIPPFK();
			}
			EMPHNDEJGCL.MergeFrom(other.EMPHNDEJGCL);
			break;
		case BPIHFAJCLOCOneofCase.EODFHPDLFNO:
			if (EODFHPDLFNO == null)
			{
				EODFHPDLFNO = new GPLPCJKLIIH();
			}
			EODFHPDLFNO.MergeFrom(other.EODFHPDLFNO);
			break;
		case BPIHFAJCLOCOneofCase.PJNDBKMFIKH:
			if (PJNDBKMFIKH == null)
			{
				PJNDBKMFIKH = new BDGFEGPHKKO();
			}
			PJNDBKMFIKH.MergeFrom(other.PJNDBKMFIKH);
			break;
		case BPIHFAJCLOCOneofCase.JJFGEJFFCCC:
			if (JJFGEJFFCCC == null)
			{
				JJFGEJFFCCC = new OFLNLJELJEM();
			}
			JJFGEJFFCCC.MergeFrom(other.JJFGEJFFCCC);
			break;
		case BPIHFAJCLOCOneofCase.MBMDOJFBAJN:
			if (MBMDOJFBAJN == null)
			{
				MBMDOJFBAJN = new IBLHPOBOOPE();
			}
			MBMDOJFBAJN.MergeFrom(other.MBMDOJFBAJN);
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
			case 96u:
				MJPCBEAAABJ = input.ReadUInt32();
				break;
			case 242u:
			{
				HILCNKINEIA hILCNKINEIA3 = new HILCNKINEIA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBBKHCJMGGL)
				{
					hILCNKINEIA3.MergeFrom(MBBKHCJMGGL);
				}
				input.ReadMessage(hILCNKINEIA3);
				MBBKHCJMGGL = hILCNKINEIA3;
				break;
			}
			case 1370u:
			{
				HMIHJIMCIEA hMIHJIMCIEA = new HMIHJIMCIEA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PCNEJJBDELC)
				{
					hMIHJIMCIEA.MergeFrom(PCNEJJBDELC);
				}
				input.ReadMessage(hMIHJIMCIEA);
				PCNEJJBDELC = hMIHJIMCIEA;
				break;
			}
			case 2058u:
			{
				IEMOMLFAAIE iEMOMLFAAIE = new IEMOMLFAAIE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
				{
					iEMOMLFAAIE.MergeFrom(ILAKOOPEODP);
				}
				input.ReadMessage(iEMOMLFAAIE);
				ILAKOOPEODP = iEMOMLFAAIE;
				break;
			}
			case 2210u:
			{
				DOADBBOFBJA dOADBBOFBJA = new DOADBBOFBJA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LCDOOHHNCOD)
				{
					dOADBBOFBJA.MergeFrom(LCDOOHHNCOD);
				}
				input.ReadMessage(dOADBBOFBJA);
				LCDOOHHNCOD = dOADBBOFBJA;
				break;
			}
			case 2450u:
			{
				MJPGLAFNJAB mJPGLAFNJAB = new MJPGLAFNJAB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCEHPPPCIPN)
				{
					mJPGLAFNJAB.MergeFrom(JCEHPPPCIPN);
				}
				input.ReadMessage(mJPGLAFNJAB);
				JCEHPPPCIPN = mJPGLAFNJAB;
				break;
			}
			case 2482u:
			{
				MKPOHKOPAPE mKPOHKOPAPE = new MKPOHKOPAPE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DJFJKBBAGEO)
				{
					mKPOHKOPAPE.MergeFrom(DJFJKBBAGEO);
				}
				input.ReadMessage(mKPOHKOPAPE);
				DJFJKBBAGEO = mKPOHKOPAPE;
				break;
			}
			case 2546u:
			{
				BIAGLOKBBMI bIAGLOKBBMI = new BIAGLOKBBMI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CLLLFIDINIM)
				{
					bIAGLOKBBMI.MergeFrom(CLLLFIDINIM);
				}
				input.ReadMessage(bIAGLOKBBMI);
				CLLLFIDINIM = bIAGLOKBBMI;
				break;
			}
			case 2930u:
			{
				JAIELCIAKAN jAIELCIAKAN = new JAIELCIAKAN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BEMOELCIBAI)
				{
					jAIELCIAKAN.MergeFrom(BEMOELCIBAI);
				}
				input.ReadMessage(jAIELCIAKAN);
				BEMOELCIBAI = jAIELCIAKAN;
				break;
			}
			case 2970u:
			{
				HILCNKINEIA hILCNKINEIA = new HILCNKINEIA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IICKOJJADNH)
				{
					hILCNKINEIA.MergeFrom(IICKOJJADNH);
				}
				input.ReadMessage(hILCNKINEIA);
				IICKOJJADNH = hILCNKINEIA;
				break;
			}
			case 3242u:
			{
				IDLLKHHBIID iDLLKHHBIID = new IDLLKHHBIID();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PONMAHEIHMJ)
				{
					iDLLKHHBIID.MergeFrom(PONMAHEIHMJ);
				}
				input.ReadMessage(iDLLKHHBIID);
				PONMAHEIHMJ = iDLLKHHBIID;
				break;
			}
			case 4338u:
			{
				DEOEOJBLIBP dEOEOJBLIBP = new DEOEOJBLIBP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MIPEGJNMEEJ)
				{
					dEOEOJBLIBP.MergeFrom(MIPEGJNMEEJ);
				}
				input.ReadMessage(dEOEOJBLIBP);
				MIPEGJNMEEJ = dEOEOJBLIBP;
				break;
			}
			case 4698u:
			{
				BDGFEGPHKKO bDGFEGPHKKO3 = new BDGFEGPHKKO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PDGCLGLOFKK)
				{
					bDGFEGPHKKO3.MergeFrom(PDGCLGLOFKK);
				}
				input.ReadMessage(bDGFEGPHKKO3);
				PDGCLGLOFKK = bDGFEGPHKKO3;
				break;
			}
			case 5506u:
			{
				EKDMDNEKAMN eKDMDNEKAMN = new EKDMDNEKAMN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LIMEFKDHOLD)
				{
					eKDMDNEKAMN.MergeFrom(LIMEFKDHOLD);
				}
				input.ReadMessage(eKDMDNEKAMN);
				LIMEFKDHOLD = eKDMDNEKAMN;
				break;
			}
			case 6354u:
			{
				OPPNAHLPAFG oPPNAHLPAFG = new OPPNAHLPAFG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJPIKLALKOD)
				{
					oPPNAHLPAFG.MergeFrom(HJPIKLALKOD);
				}
				input.ReadMessage(oPPNAHLPAFG);
				HJPIKLALKOD = oPPNAHLPAFG;
				break;
			}
			case 6370u:
			{
				MJKEOBOMAGP mJKEOBOMAGP = new MJKEOBOMAGP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JPANPNNMOOF)
				{
					mJKEOBOMAGP.MergeFrom(JPANPNNMOOF);
				}
				input.ReadMessage(mJKEOBOMAGP);
				JPANPNNMOOF = mJKEOBOMAGP;
				break;
			}
			case 6594u:
			{
				BDGFEGPHKKO bDGFEGPHKKO2 = new BDGFEGPHKKO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GCKDDBHIHDB)
				{
					bDGFEGPHKKO2.MergeFrom(GCKDDBHIHDB);
				}
				input.ReadMessage(bDGFEGPHKKO2);
				GCKDDBHIHDB = bDGFEGPHKKO2;
				break;
			}
			case 6802u:
			{
				IFLHELOLDKA iFLHELOLDKA = new IFLHELOLDKA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HCGNAHNJCHA)
				{
					iFLHELOLDKA.MergeFrom(HCGNAHNJCHA);
				}
				input.ReadMessage(iFLHELOLDKA);
				HCGNAHNJCHA = iFLHELOLDKA;
				break;
			}
			case 6930u:
			{
				HILCNKINEIA hILCNKINEIA4 = new HILCNKINEIA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FLIKEAKPKJC)
				{
					hILCNKINEIA4.MergeFrom(FLIKEAKPKJC);
				}
				input.ReadMessage(hILCNKINEIA4);
				FLIKEAKPKJC = hILCNKINEIA4;
				break;
			}
			case 7682u:
			{
				DGCMJNNHFGP dGCMJNNHFGP = new DGCMJNNHFGP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PFKBADDNGDL)
				{
					dGCMJNNHFGP.MergeFrom(PFKBADDNGDL);
				}
				input.ReadMessage(dGCMJNNHFGP);
				PFKBADDNGDL = dGCMJNNHFGP;
				break;
			}
			case 7754u:
			{
				BIELAAMEPDK bIELAAMEPDK = new BIELAAMEPDK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IACIAJGBOOO)
				{
					bIELAAMEPDK.MergeFrom(IACIAJGBOOO);
				}
				input.ReadMessage(bIELAAMEPDK);
				IACIAJGBOOO = bIELAAMEPDK;
				break;
			}
			case 7970u:
			{
				JIFOPBNNKON jIFOPBNNKON = new JIFOPBNNKON();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AEIMJCGCPLH)
				{
					jIFOPBNNKON.MergeFrom(AEIMJCGCPLH);
				}
				input.ReadMessage(jIFOPBNNKON);
				AEIMJCGCPLH = jIFOPBNNKON;
				break;
			}
			case 8690u:
			{
				PAPHFGPNCIJ pAPHFGPNCIJ = new PAPHFGPNCIJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJMCAEAFIKH)
				{
					pAPHFGPNCIJ.MergeFrom(PJMCAEAFIKH);
				}
				input.ReadMessage(pAPHFGPNCIJ);
				PJMCAEAFIKH = pAPHFGPNCIJ;
				break;
			}
			case 9090u:
			{
				FFGMHLCEAOM fFGMHLCEAOM2 = new FFGMHLCEAOM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKAACNLOIAO)
				{
					fFGMHLCEAOM2.MergeFrom(CKAACNLOIAO);
				}
				input.ReadMessage(fFGMHLCEAOM2);
				CKAACNLOIAO = fFGMHLCEAOM2;
				break;
			}
			case 10154u:
			{
				EOBHKMGJGPG eOBHKMGJGPG = new EOBHKMGJGPG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PNIOGGNHMOA)
				{
					eOBHKMGJGPG.MergeFrom(PNIOGGNHMOA);
				}
				input.ReadMessage(eOBHKMGJGPG);
				PNIOGGNHMOA = eOBHKMGJGPG;
				break;
			}
			case 10610u:
			{
				FPLCHBNNAHD fPLCHBNNAHD = new FPLCHBNNAHD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KEFGOLHKCDB)
				{
					fPLCHBNNAHD.MergeFrom(KEFGOLHKCDB);
				}
				input.ReadMessage(fPLCHBNNAHD);
				KEFGOLHKCDB = fPLCHBNNAHD;
				break;
			}
			case 10650u:
			{
				FFGMHLCEAOM fFGMHLCEAOM = new FFGMHLCEAOM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JENBGMOEAHI)
				{
					fFGMHLCEAOM.MergeFrom(JENBGMOEAHI);
				}
				input.ReadMessage(fFGMHLCEAOM);
				JENBGMOEAHI = fFGMHLCEAOM;
				break;
			}
			case 10930u:
			{
				ANBPMJHPLOP aNBPMJHPLOP = new ANBPMJHPLOP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EBBDGALMBJI)
				{
					aNBPMJHPLOP.MergeFrom(EBBDGALMBJI);
				}
				input.ReadMessage(aNBPMJHPLOP);
				EBBDGALMBJI = aNBPMJHPLOP;
				break;
			}
			case 11474u:
			{
				LGDAPABKALH lGDAPABKALH = new LGDAPABKALH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JBPJALBOEAP)
				{
					lGDAPABKALH.MergeFrom(JBPJALBOEAP);
				}
				input.ReadMessage(lGDAPABKALH);
				JBPJALBOEAP = lGDAPABKALH;
				break;
			}
			case 12482u:
			{
				HGCIDHBILAC hGCIDHBILAC = new HGCIDHBILAC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJFPEIFHHHD)
				{
					hGCIDHBILAC.MergeFrom(GJFPEIFHHHD);
				}
				input.ReadMessage(hGCIDHBILAC);
				GJFPEIFHHHD = hGCIDHBILAC;
				break;
			}
			case 12698u:
			{
				ALHGCBPJLMO aLHGCBPJLMO = new ALHGCBPJLMO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGBDLDKHEMG)
				{
					aLHGCBPJLMO.MergeFrom(EGBDLDKHEMG);
				}
				input.ReadMessage(aLHGCBPJLMO);
				EGBDLDKHEMG = aLHGCBPJLMO;
				break;
			}
			case 12818u:
			{
				HILCNKINEIA hILCNKINEIA2 = new HILCNKINEIA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AADLFJDEMJM)
				{
					hILCNKINEIA2.MergeFrom(AADLFJDEMJM);
				}
				input.ReadMessage(hILCNKINEIA2);
				AADLFJDEMJM = hILCNKINEIA2;
				break;
			}
			case 12938u:
			{
				BAAMEJNMMOB bAAMEJNMMOB = new BAAMEJNMMOB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JOMKONFFCKH)
				{
					bAAMEJNMMOB.MergeFrom(JOMKONFFCKH);
				}
				input.ReadMessage(bAAMEJNMMOB);
				JOMKONFFCKH = bAAMEJNMMOB;
				break;
			}
			case 13362u:
			{
				KMDBMLAICLB kMDBMLAICLB = new KMDBMLAICLB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JCPJHLICHFJ)
				{
					kMDBMLAICLB.MergeFrom(JCPJHLICHFJ);
				}
				input.ReadMessage(kMDBMLAICLB);
				JCPJHLICHFJ = kMDBMLAICLB;
				break;
			}
			case 13562u:
			{
				ECGEFDKBCCB eCGEFDKBCCB = new ECGEFDKBCCB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJDECBLAJDM)
				{
					eCGEFDKBCCB.MergeFrom(GJDECBLAJDM);
				}
				input.ReadMessage(eCGEFDKBCCB);
				GJDECBLAJDM = eCGEFDKBCCB;
				break;
			}
			case 14530u:
			{
				BCMLDKKIIKA bCMLDKKIIKA = new BCMLDKKIIKA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HOFIOBKIMGP)
				{
					bCMLDKKIIKA.MergeFrom(HOFIOBKIMGP);
				}
				input.ReadMessage(bCMLDKKIIKA);
				HOFIOBKIMGP = bCMLDKKIIKA;
				break;
			}
			case 15210u:
			{
				FNDBFOIPPFK fNDBFOIPPFK = new FNDBFOIPPFK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EMPHNDEJGCL)
				{
					fNDBFOIPPFK.MergeFrom(EMPHNDEJGCL);
				}
				input.ReadMessage(fNDBFOIPPFK);
				EMPHNDEJGCL = fNDBFOIPPFK;
				break;
			}
			case 15730u:
			{
				GPLPCJKLIIH gPLPCJKLIIH = new GPLPCJKLIIH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EODFHPDLFNO)
				{
					gPLPCJKLIIH.MergeFrom(EODFHPDLFNO);
				}
				input.ReadMessage(gPLPCJKLIIH);
				EODFHPDLFNO = gPLPCJKLIIH;
				break;
			}
			case 15770u:
			{
				BDGFEGPHKKO bDGFEGPHKKO = new BDGFEGPHKKO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJNDBKMFIKH)
				{
					bDGFEGPHKKO.MergeFrom(PJNDBKMFIKH);
				}
				input.ReadMessage(bDGFEGPHKKO);
				PJNDBKMFIKH = bDGFEGPHKKO;
				break;
			}
			case 321074u:
			{
				OFLNLJELJEM oFLNLJELJEM = new OFLNLJELJEM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JJFGEJFFCCC)
				{
					oFLNLJELJEM.MergeFrom(JJFGEJFFCCC);
				}
				input.ReadMessage(oFLNLJELJEM);
				JJFGEJFFCCC = oFLNLJELJEM;
				break;
			}
			case 865202u:
			{
				IBLHPOBOOPE iBLHPOBOOPE = new IBLHPOBOOPE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MBMDOJFBAJN)
				{
					iBLHPOBOOPE.MergeFrom(MBMDOJFBAJN);
				}
				input.ReadMessage(iBLHPOBOOPE);
				MBMDOJFBAJN = iBLHPOBOOPE;
				break;
			}
			}
		}
	}
}
