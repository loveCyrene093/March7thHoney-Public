using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HandleRogueCommonPendingActionScRsp : IMessage<HandleRogueCommonPendingActionScRsp>, IMessage, IEquatable<HandleRogueCommonPendingActionScRsp>, IDeepCloneable<HandleRogueCommonPendingActionScRsp>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		ECBDOFCDHKK = 36,
		JKDHIJFLHAJ = 47,
		PEMHIBDBCGG = 63,
		LKBHNGLPEGP = 124,
		FGAEOEEOIFD = 129,
		IJOMKIDEOEG = 183,
		KCCIDNOGPPA = 341,
		CMHGGDOMAAK = 408,
		BFMONEFDILP = 435,
		KMFILFDMILI = 558,
		IJHKIDFCAHO = 729,
		CICIDMFLIHL = 773,
		MCOPMAMMAKP = 786,
		PKBFJJJOEBD = 860,
		BOJPHPFIPNK = 963,
		FBJMOIEEHFF = 1010,
		KMALKBCNJHK = 1017,
		OPKPJCIDFIC = 1033,
		DEIDEEJDJLB = 1085,
		ILAKOOPEODP = 1138,
		DOBFKCAGMJB = 1157,
		LAJICPMLKCA = 1200,
		BBEPLGMEJGN = 1206,
		CEPBLFDKFFJ = 1207,
		KHNAKEMGNJM = 1214,
		BBEHJAJPHBK = 1379,
		JLIINFBLMKI = 1438,
		HJCJCEACDHJ = 1474,
		NKMIGFDPFNJ = 1610,
		CCGGGDCAIGJ = 1750,
		OFEECJDAHLB = 1850,
		DDAKCDJJOPI = 1928,
		BAKPFNPNMOP = 1975,
		IPPOGINBKIE = 1986,
		FMAJDANLJEB = 2040
	}

	private static readonly MessageParser<HandleRogueCommonPendingActionScRsp> _parser = new MessageParser<HandleRogueCommonPendingActionScRsp>(() => new HandleRogueCommonPendingActionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MJPCBEAAABJFieldNumber = 2;

	private uint mJPCBEAAABJ_;

	public const int QueuePositionFieldNumber = 13;

	private uint queuePosition_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int ECBDOFCDHKKFieldNumber = 36;

	public const int JKDHIJFLHAJFieldNumber = 47;

	public const int PEMHIBDBCGGFieldNumber = 63;

	public const int LKBHNGLPEGPFieldNumber = 124;

	public const int FGAEOEEOIFDFieldNumber = 129;

	public const int IJOMKIDEOEGFieldNumber = 183;

	public const int KCCIDNOGPPAFieldNumber = 341;

	public const int CMHGGDOMAAKFieldNumber = 408;

	public const int BFMONEFDILPFieldNumber = 435;

	public const int KMFILFDMILIFieldNumber = 558;

	public const int IJHKIDFCAHOFieldNumber = 729;

	public const int CICIDMFLIHLFieldNumber = 773;

	public const int MCOPMAMMAKPFieldNumber = 786;

	public const int PKBFJJJOEBDFieldNumber = 860;

	public const int BOJPHPFIPNKFieldNumber = 963;

	public const int FBJMOIEEHFFFieldNumber = 1010;

	public const int KMALKBCNJHKFieldNumber = 1017;

	public const int OPKPJCIDFICFieldNumber = 1033;

	public const int DEIDEEJDJLBFieldNumber = 1085;

	public const int ILAKOOPEODPFieldNumber = 1138;

	public const int DOBFKCAGMJBFieldNumber = 1157;

	public const int LAJICPMLKCAFieldNumber = 1200;

	public const int BBEPLGMEJGNFieldNumber = 1206;

	public const int CEPBLFDKFFJFieldNumber = 1207;

	public const int KHNAKEMGNJMFieldNumber = 1214;

	public const int BBEHJAJPHBKFieldNumber = 1379;

	public const int JLIINFBLMKIFieldNumber = 1438;

	public const int HJCJCEACDHJFieldNumber = 1474;

	public const int NKMIGFDPFNJFieldNumber = 1610;

	public const int CCGGGDCAIGJFieldNumber = 1750;

	public const int OFEECJDAHLBFieldNumber = 1850;

	public const int DDAKCDJJOPIFieldNumber = 1928;

	public const int BAKPFNPNMOPFieldNumber = 1975;

	public const int IPPOGINBKIEFieldNumber = 1986;

	public const int FMAJDANLJEBFieldNumber = 2040;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HandleRogueCommonPendingActionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HandleRogueCommonPendingActionScRspReflection.Descriptor.MessageTypes[0];

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
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JICGMEBFBJF ECBDOFCDHKK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ECBDOFCDHKK)
			{
				return null;
			}
			return (JICGMEBFBJF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ECBDOFCDHKK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHMDKPCOAEC JKDHIJFLHAJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JKDHIJFLHAJ)
			{
				return null;
			}
			return (OHMDKPCOAEC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JKDHIJFLHAJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNPGMMLHGJH PEMHIBDBCGG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PEMHIBDBCGG)
			{
				return null;
			}
			return (JNPGMMLHGJH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PEMHIBDBCGG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMHMPNEJFOP LKBHNGLPEGP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LKBHNGLPEGP)
			{
				return null;
			}
			return (MMHMPNEJFOP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LKBHNGLPEGP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHIINCNKEI FGAEOEEOIFD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FGAEOEEOIFD)
			{
				return null;
			}
			return (DPHIINCNKEI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FGAEOEEOIFD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLDLMHPFBCM IJOMKIDEOEG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IJOMKIDEOEG)
			{
				return null;
			}
			return (BLDLMHPFBCM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IJOMKIDEOEG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJFFAHEHFDJ KCCIDNOGPPA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KCCIDNOGPPA)
			{
				return null;
			}
			return (LJFFAHEHFDJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KCCIDNOGPPA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFIKJKGABEI CMHGGDOMAAK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CMHGGDOMAAK)
			{
				return null;
			}
			return (CFIKJKGABEI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CMHGGDOMAAK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJGGFCJFKEL BFMONEFDILP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BFMONEFDILP)
			{
				return null;
			}
			return (AJGGFCJFKEL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BFMONEFDILP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGNIAAPANO KMFILFDMILI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KMFILFDMILI)
			{
				return null;
			}
			return (MAGNIAAPANO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KMFILFDMILI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GACNMNIKJBF IJHKIDFCAHO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IJHKIDFCAHO)
			{
				return null;
			}
			return (GACNMNIKJBF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IJHKIDFCAHO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIDKGPCEDHE CICIDMFLIHL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CICIDMFLIHL)
			{
				return null;
			}
			return (LIDKGPCEDHE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CICIDMFLIHL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFPOEAEPHIJ MCOPMAMMAKP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MCOPMAMMAKP)
			{
				return null;
			}
			return (NFPOEAEPHIJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MCOPMAMMAKP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLNOGDMKBOD PKBFJJJOEBD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PKBFJJJOEBD)
			{
				return null;
			}
			return (NLNOGDMKBOD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PKBFJJJOEBD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBHMOJNPHEJ BOJPHPFIPNK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BOJPHPFIPNK)
			{
				return null;
			}
			return (MBHMOJNPHEJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BOJPHPFIPNK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBAMALALOGG FBJMOIEEHFF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FBJMOIEEHFF)
			{
				return null;
			}
			return (HBAMALALOGG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FBJMOIEEHFF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOHHEPOECML KMALKBCNJHK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KMALKBCNJHK)
			{
				return null;
			}
			return (FOHHEPOECML)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KMALKBCNJHK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIKAEDCJHFM OPKPJCIDFIC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OPKPJCIDFIC)
			{
				return null;
			}
			return (DIKAEDCJHFM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OPKPJCIDFIC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HGFKGMPPOIM DEIDEEJDJLB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.DEIDEEJDJLB)
			{
				return null;
			}
			return (HGFKGMPPOIM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.DEIDEEJDJLB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOGMCBOFNMO ILAKOOPEODP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ILAKOOPEODP)
			{
				return null;
			}
			return (AOGMCBOFNMO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ILAKOOPEODP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGNIAAPANO DOBFKCAGMJB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.DOBFKCAGMJB)
			{
				return null;
			}
			return (MAGNIAAPANO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.DOBFKCAGMJB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDKNKIBFHAF LAJICPMLKCA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LAJICPMLKCA)
			{
				return null;
			}
			return (JDKNKIBFHAF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LAJICPMLKCA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPPDGFLMDEB BBEPLGMEJGN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BBEPLGMEJGN)
			{
				return null;
			}
			return (MPPDGFLMDEB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BBEPLGMEJGN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCFNNAKLMPD CEPBLFDKFFJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CEPBLFDKFFJ)
			{
				return null;
			}
			return (GCFNNAKLMPD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CEPBLFDKFFJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEDCCGBPOFL KHNAKEMGNJM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KHNAKEMGNJM)
			{
				return null;
			}
			return (GEDCCGBPOFL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KHNAKEMGNJM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IOGMLLBFDPG BBEHJAJPHBK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BBEHJAJPHBK)
			{
				return null;
			}
			return (IOGMLLBFDPG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BBEHJAJPHBK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKEBEPBJHCE JLIINFBLMKI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JLIINFBLMKI)
			{
				return null;
			}
			return (IKEBEPBJHCE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JLIINFBLMKI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBCOPDHBMLJ HJCJCEACDHJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HJCJCEACDHJ)
			{
				return null;
			}
			return (PBCOPDHBMLJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HJCJCEACDHJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAHKCDIPGJH NKMIGFDPFNJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NKMIGFDPFNJ)
			{
				return null;
			}
			return (HAHKCDIPGJH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NKMIGFDPFNJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPPGLJPCFNC CCGGGDCAIGJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CCGGGDCAIGJ)
			{
				return null;
			}
			return (JPPGLJPCFNC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CCGGGDCAIGJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMNDEJMILO OFEECJDAHLB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OFEECJDAHLB)
			{
				return null;
			}
			return (JAMNDEJMILO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OFEECJDAHLB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IADIBNIPHBO DDAKCDJJOPI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.DDAKCDJJOPI)
			{
				return null;
			}
			return (IADIBNIPHBO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.DDAKCDJJOPI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFDADBFIABN BAKPFNPNMOP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BAKPFNPNMOP)
			{
				return null;
			}
			return (EFDADBFIABN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BAKPFNPNMOP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGKDBECKMBM IPPOGINBKIE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IPPOGINBKIE)
			{
				return null;
			}
			return (LGKDBECKMBM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IPPOGINBKIE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJEFKOGFNCH FMAJDANLJEB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FMAJDANLJEB)
			{
				return null;
			}
			return (GJEFKOGFNCH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FMAJDANLJEB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HandleRogueCommonPendingActionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HandleRogueCommonPendingActionScRsp(HandleRogueCommonPendingActionScRsp other)
		: this()
	{
		mJPCBEAAABJ_ = other.mJPCBEAAABJ_;
		queuePosition_ = other.queuePosition_;
		retcode_ = other.retcode_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.ECBDOFCDHKK:
			ECBDOFCDHKK = other.ECBDOFCDHKK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JKDHIJFLHAJ:
			JKDHIJFLHAJ = other.JKDHIJFLHAJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PEMHIBDBCGG:
			PEMHIBDBCGG = other.PEMHIBDBCGG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LKBHNGLPEGP:
			LKBHNGLPEGP = other.LKBHNGLPEGP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FGAEOEEOIFD:
			FGAEOEEOIFD = other.FGAEOEEOIFD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IJOMKIDEOEG:
			IJOMKIDEOEG = other.IJOMKIDEOEG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KCCIDNOGPPA:
			KCCIDNOGPPA = other.KCCIDNOGPPA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CMHGGDOMAAK:
			CMHGGDOMAAK = other.CMHGGDOMAAK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BFMONEFDILP:
			BFMONEFDILP = other.BFMONEFDILP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KMFILFDMILI:
			KMFILFDMILI = other.KMFILFDMILI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IJHKIDFCAHO:
			IJHKIDFCAHO = other.IJHKIDFCAHO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CICIDMFLIHL:
			CICIDMFLIHL = other.CICIDMFLIHL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MCOPMAMMAKP:
			MCOPMAMMAKP = other.MCOPMAMMAKP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PKBFJJJOEBD:
			PKBFJJJOEBD = other.PKBFJJJOEBD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BOJPHPFIPNK:
			BOJPHPFIPNK = other.BOJPHPFIPNK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FBJMOIEEHFF:
			FBJMOIEEHFF = other.FBJMOIEEHFF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KMALKBCNJHK:
			KMALKBCNJHK = other.KMALKBCNJHK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OPKPJCIDFIC:
			OPKPJCIDFIC = other.OPKPJCIDFIC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.DEIDEEJDJLB:
			DEIDEEJDJLB = other.DEIDEEJDJLB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ILAKOOPEODP:
			ILAKOOPEODP = other.ILAKOOPEODP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.DOBFKCAGMJB:
			DOBFKCAGMJB = other.DOBFKCAGMJB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LAJICPMLKCA:
			LAJICPMLKCA = other.LAJICPMLKCA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BBEPLGMEJGN:
			BBEPLGMEJGN = other.BBEPLGMEJGN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CEPBLFDKFFJ:
			CEPBLFDKFFJ = other.CEPBLFDKFFJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KHNAKEMGNJM:
			KHNAKEMGNJM = other.KHNAKEMGNJM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BBEHJAJPHBK:
			BBEHJAJPHBK = other.BBEHJAJPHBK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JLIINFBLMKI:
			JLIINFBLMKI = other.JLIINFBLMKI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HJCJCEACDHJ:
			HJCJCEACDHJ = other.HJCJCEACDHJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NKMIGFDPFNJ:
			NKMIGFDPFNJ = other.NKMIGFDPFNJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CCGGGDCAIGJ:
			CCGGGDCAIGJ = other.CCGGGDCAIGJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OFEECJDAHLB:
			OFEECJDAHLB = other.OFEECJDAHLB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.DDAKCDJJOPI:
			DDAKCDJJOPI = other.DDAKCDJJOPI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BAKPFNPNMOP:
			BAKPFNPNMOP = other.BAKPFNPNMOP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IPPOGINBKIE:
			IPPOGINBKIE = other.IPPOGINBKIE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FMAJDANLJEB:
			FMAJDANLJEB = other.FMAJDANLJEB.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HandleRogueCommonPendingActionScRsp Clone()
	{
		return new HandleRogueCommonPendingActionScRsp(this);
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
		return Equals(other as HandleRogueCommonPendingActionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HandleRogueCommonPendingActionScRsp other)
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
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(ECBDOFCDHKK, other.ECBDOFCDHKK))
		{
			return false;
		}
		if (!object.Equals(JKDHIJFLHAJ, other.JKDHIJFLHAJ))
		{
			return false;
		}
		if (!object.Equals(PEMHIBDBCGG, other.PEMHIBDBCGG))
		{
			return false;
		}
		if (!object.Equals(LKBHNGLPEGP, other.LKBHNGLPEGP))
		{
			return false;
		}
		if (!object.Equals(FGAEOEEOIFD, other.FGAEOEEOIFD))
		{
			return false;
		}
		if (!object.Equals(IJOMKIDEOEG, other.IJOMKIDEOEG))
		{
			return false;
		}
		if (!object.Equals(KCCIDNOGPPA, other.KCCIDNOGPPA))
		{
			return false;
		}
		if (!object.Equals(CMHGGDOMAAK, other.CMHGGDOMAAK))
		{
			return false;
		}
		if (!object.Equals(BFMONEFDILP, other.BFMONEFDILP))
		{
			return false;
		}
		if (!object.Equals(KMFILFDMILI, other.KMFILFDMILI))
		{
			return false;
		}
		if (!object.Equals(IJHKIDFCAHO, other.IJHKIDFCAHO))
		{
			return false;
		}
		if (!object.Equals(CICIDMFLIHL, other.CICIDMFLIHL))
		{
			return false;
		}
		if (!object.Equals(MCOPMAMMAKP, other.MCOPMAMMAKP))
		{
			return false;
		}
		if (!object.Equals(PKBFJJJOEBD, other.PKBFJJJOEBD))
		{
			return false;
		}
		if (!object.Equals(BOJPHPFIPNK, other.BOJPHPFIPNK))
		{
			return false;
		}
		if (!object.Equals(FBJMOIEEHFF, other.FBJMOIEEHFF))
		{
			return false;
		}
		if (!object.Equals(KMALKBCNJHK, other.KMALKBCNJHK))
		{
			return false;
		}
		if (!object.Equals(OPKPJCIDFIC, other.OPKPJCIDFIC))
		{
			return false;
		}
		if (!object.Equals(DEIDEEJDJLB, other.DEIDEEJDJLB))
		{
			return false;
		}
		if (!object.Equals(ILAKOOPEODP, other.ILAKOOPEODP))
		{
			return false;
		}
		if (!object.Equals(DOBFKCAGMJB, other.DOBFKCAGMJB))
		{
			return false;
		}
		if (!object.Equals(LAJICPMLKCA, other.LAJICPMLKCA))
		{
			return false;
		}
		if (!object.Equals(BBEPLGMEJGN, other.BBEPLGMEJGN))
		{
			return false;
		}
		if (!object.Equals(CEPBLFDKFFJ, other.CEPBLFDKFFJ))
		{
			return false;
		}
		if (!object.Equals(KHNAKEMGNJM, other.KHNAKEMGNJM))
		{
			return false;
		}
		if (!object.Equals(BBEHJAJPHBK, other.BBEHJAJPHBK))
		{
			return false;
		}
		if (!object.Equals(JLIINFBLMKI, other.JLIINFBLMKI))
		{
			return false;
		}
		if (!object.Equals(HJCJCEACDHJ, other.HJCJCEACDHJ))
		{
			return false;
		}
		if (!object.Equals(NKMIGFDPFNJ, other.NKMIGFDPFNJ))
		{
			return false;
		}
		if (!object.Equals(CCGGGDCAIGJ, other.CCGGGDCAIGJ))
		{
			return false;
		}
		if (!object.Equals(OFEECJDAHLB, other.OFEECJDAHLB))
		{
			return false;
		}
		if (!object.Equals(DDAKCDJJOPI, other.DDAKCDJJOPI))
		{
			return false;
		}
		if (!object.Equals(BAKPFNPNMOP, other.BAKPFNPNMOP))
		{
			return false;
		}
		if (!object.Equals(IPPOGINBKIE, other.IPPOGINBKIE))
		{
			return false;
		}
		if (!object.Equals(FMAJDANLJEB, other.FMAJDANLJEB))
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECBDOFCDHKK)
		{
			num ^= ECBDOFCDHKK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JKDHIJFLHAJ)
		{
			num ^= JKDHIJFLHAJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMHIBDBCGG)
		{
			num ^= PEMHIBDBCGG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKBHNGLPEGP)
		{
			num ^= LKBHNGLPEGP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FGAEOEEOIFD)
		{
			num ^= FGAEOEEOIFD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJOMKIDEOEG)
		{
			num ^= IJOMKIDEOEG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCCIDNOGPPA)
		{
			num ^= KCCIDNOGPPA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMHGGDOMAAK)
		{
			num ^= CMHGGDOMAAK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BFMONEFDILP)
		{
			num ^= BFMONEFDILP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMFILFDMILI)
		{
			num ^= KMFILFDMILI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJHKIDFCAHO)
		{
			num ^= IJHKIDFCAHO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CICIDMFLIHL)
		{
			num ^= CICIDMFLIHL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MCOPMAMMAKP)
		{
			num ^= MCOPMAMMAKP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKBFJJJOEBD)
		{
			num ^= PKBFJJJOEBD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BOJPHPFIPNK)
		{
			num ^= BOJPHPFIPNK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBJMOIEEHFF)
		{
			num ^= FBJMOIEEHFF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMALKBCNJHK)
		{
			num ^= KMALKBCNJHK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPKPJCIDFIC)
		{
			num ^= OPKPJCIDFIC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DEIDEEJDJLB)
		{
			num ^= DEIDEEJDJLB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
		{
			num ^= ILAKOOPEODP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DOBFKCAGMJB)
		{
			num ^= DOBFKCAGMJB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LAJICPMLKCA)
		{
			num ^= LAJICPMLKCA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEPLGMEJGN)
		{
			num ^= BBEPLGMEJGN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEPBLFDKFFJ)
		{
			num ^= CEPBLFDKFFJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KHNAKEMGNJM)
		{
			num ^= KHNAKEMGNJM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEHJAJPHBK)
		{
			num ^= BBEHJAJPHBK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLIINFBLMKI)
		{
			num ^= JLIINFBLMKI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJCJCEACDHJ)
		{
			num ^= HJCJCEACDHJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKMIGFDPFNJ)
		{
			num ^= NKMIGFDPFNJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CCGGGDCAIGJ)
		{
			num ^= CCGGGDCAIGJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OFEECJDAHLB)
		{
			num ^= OFEECJDAHLB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DDAKCDJJOPI)
		{
			num ^= DDAKCDJJOPI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAKPFNPNMOP)
		{
			num ^= BAKPFNPNMOP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPPOGINBKIE)
		{
			num ^= IPPOGINBKIE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FMAJDANLJEB)
		{
			num ^= FMAJDANLJEB.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(MJPCBEAAABJ);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(QueuePosition);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECBDOFCDHKK)
		{
			output.WriteRawTag(162, 2);
			output.WriteMessage(ECBDOFCDHKK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JKDHIJFLHAJ)
		{
			output.WriteRawTag(250, 2);
			output.WriteMessage(JKDHIJFLHAJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMHIBDBCGG)
		{
			output.WriteRawTag(250, 3);
			output.WriteMessage(PEMHIBDBCGG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKBHNGLPEGP)
		{
			output.WriteRawTag(226, 7);
			output.WriteMessage(LKBHNGLPEGP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FGAEOEEOIFD)
		{
			output.WriteRawTag(138, 8);
			output.WriteMessage(FGAEOEEOIFD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJOMKIDEOEG)
		{
			output.WriteRawTag(186, 11);
			output.WriteMessage(IJOMKIDEOEG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCCIDNOGPPA)
		{
			output.WriteRawTag(170, 21);
			output.WriteMessage(KCCIDNOGPPA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMHGGDOMAAK)
		{
			output.WriteRawTag(194, 25);
			output.WriteMessage(CMHGGDOMAAK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BFMONEFDILP)
		{
			output.WriteRawTag(154, 27);
			output.WriteMessage(BFMONEFDILP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMFILFDMILI)
		{
			output.WriteRawTag(242, 34);
			output.WriteMessage(KMFILFDMILI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJHKIDFCAHO)
		{
			output.WriteRawTag(202, 45);
			output.WriteMessage(IJHKIDFCAHO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CICIDMFLIHL)
		{
			output.WriteRawTag(170, 48);
			output.WriteMessage(CICIDMFLIHL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MCOPMAMMAKP)
		{
			output.WriteRawTag(146, 49);
			output.WriteMessage(MCOPMAMMAKP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKBFJJJOEBD)
		{
			output.WriteRawTag(226, 53);
			output.WriteMessage(PKBFJJJOEBD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BOJPHPFIPNK)
		{
			output.WriteRawTag(154, 60);
			output.WriteMessage(BOJPHPFIPNK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBJMOIEEHFF)
		{
			output.WriteRawTag(146, 63);
			output.WriteMessage(FBJMOIEEHFF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMALKBCNJHK)
		{
			output.WriteRawTag(202, 63);
			output.WriteMessage(KMALKBCNJHK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPKPJCIDFIC)
		{
			output.WriteRawTag(202, 64);
			output.WriteMessage(OPKPJCIDFIC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DEIDEEJDJLB)
		{
			output.WriteRawTag(234, 67);
			output.WriteMessage(DEIDEEJDJLB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
		{
			output.WriteRawTag(146, 71);
			output.WriteMessage(ILAKOOPEODP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DOBFKCAGMJB)
		{
			output.WriteRawTag(170, 72);
			output.WriteMessage(DOBFKCAGMJB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LAJICPMLKCA)
		{
			output.WriteRawTag(130, 75);
			output.WriteMessage(LAJICPMLKCA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEPLGMEJGN)
		{
			output.WriteRawTag(178, 75);
			output.WriteMessage(BBEPLGMEJGN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEPBLFDKFFJ)
		{
			output.WriteRawTag(186, 75);
			output.WriteMessage(CEPBLFDKFFJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KHNAKEMGNJM)
		{
			output.WriteRawTag(242, 75);
			output.WriteMessage(KHNAKEMGNJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEHJAJPHBK)
		{
			output.WriteRawTag(154, 86);
			output.WriteMessage(BBEHJAJPHBK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLIINFBLMKI)
		{
			output.WriteRawTag(242, 89);
			output.WriteMessage(JLIINFBLMKI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJCJCEACDHJ)
		{
			output.WriteRawTag(146, 92);
			output.WriteMessage(HJCJCEACDHJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKMIGFDPFNJ)
		{
			output.WriteRawTag(210, 100);
			output.WriteMessage(NKMIGFDPFNJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CCGGGDCAIGJ)
		{
			output.WriteRawTag(178, 109);
			output.WriteMessage(CCGGGDCAIGJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OFEECJDAHLB)
		{
			output.WriteRawTag(210, 115);
			output.WriteMessage(OFEECJDAHLB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DDAKCDJJOPI)
		{
			output.WriteRawTag(194, 120);
			output.WriteMessage(DDAKCDJJOPI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAKPFNPNMOP)
		{
			output.WriteRawTag(186, 123);
			output.WriteMessage(BAKPFNPNMOP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPPOGINBKIE)
		{
			output.WriteRawTag(146, 124);
			output.WriteMessage(IPPOGINBKIE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FMAJDANLJEB)
		{
			output.WriteRawTag(194, 127);
			output.WriteMessage(FMAJDANLJEB);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECBDOFCDHKK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ECBDOFCDHKK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JKDHIJFLHAJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JKDHIJFLHAJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMHIBDBCGG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PEMHIBDBCGG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKBHNGLPEGP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LKBHNGLPEGP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FGAEOEEOIFD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FGAEOEEOIFD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJOMKIDEOEG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IJOMKIDEOEG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCCIDNOGPPA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KCCIDNOGPPA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMHGGDOMAAK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CMHGGDOMAAK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BFMONEFDILP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BFMONEFDILP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMFILFDMILI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KMFILFDMILI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJHKIDFCAHO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IJHKIDFCAHO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CICIDMFLIHL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CICIDMFLIHL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MCOPMAMMAKP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MCOPMAMMAKP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKBFJJJOEBD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PKBFJJJOEBD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BOJPHPFIPNK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BOJPHPFIPNK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBJMOIEEHFF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FBJMOIEEHFF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMALKBCNJHK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KMALKBCNJHK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPKPJCIDFIC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OPKPJCIDFIC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DEIDEEJDJLB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DEIDEEJDJLB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ILAKOOPEODP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DOBFKCAGMJB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DOBFKCAGMJB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LAJICPMLKCA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LAJICPMLKCA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEPLGMEJGN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BBEPLGMEJGN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEPBLFDKFFJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CEPBLFDKFFJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KHNAKEMGNJM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KHNAKEMGNJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEHJAJPHBK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BBEHJAJPHBK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLIINFBLMKI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JLIINFBLMKI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJCJCEACDHJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HJCJCEACDHJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKMIGFDPFNJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NKMIGFDPFNJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CCGGGDCAIGJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CCGGGDCAIGJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OFEECJDAHLB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OFEECJDAHLB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DDAKCDJJOPI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DDAKCDJJOPI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAKPFNPNMOP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BAKPFNPNMOP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPPOGINBKIE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IPPOGINBKIE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FMAJDANLJEB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FMAJDANLJEB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HandleRogueCommonPendingActionScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MJPCBEAAABJ != 0)
		{
			MJPCBEAAABJ = other.MJPCBEAAABJ;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.ECBDOFCDHKK:
			if (ECBDOFCDHKK == null)
			{
				ECBDOFCDHKK = new JICGMEBFBJF();
			}
			ECBDOFCDHKK.MergeFrom(other.ECBDOFCDHKK);
			break;
		case BPIHFAJCLOCOneofCase.JKDHIJFLHAJ:
			if (JKDHIJFLHAJ == null)
			{
				JKDHIJFLHAJ = new OHMDKPCOAEC();
			}
			JKDHIJFLHAJ.MergeFrom(other.JKDHIJFLHAJ);
			break;
		case BPIHFAJCLOCOneofCase.PEMHIBDBCGG:
			if (PEMHIBDBCGG == null)
			{
				PEMHIBDBCGG = new JNPGMMLHGJH();
			}
			PEMHIBDBCGG.MergeFrom(other.PEMHIBDBCGG);
			break;
		case BPIHFAJCLOCOneofCase.LKBHNGLPEGP:
			if (LKBHNGLPEGP == null)
			{
				LKBHNGLPEGP = new MMHMPNEJFOP();
			}
			LKBHNGLPEGP.MergeFrom(other.LKBHNGLPEGP);
			break;
		case BPIHFAJCLOCOneofCase.FGAEOEEOIFD:
			if (FGAEOEEOIFD == null)
			{
				FGAEOEEOIFD = new DPHIINCNKEI();
			}
			FGAEOEEOIFD.MergeFrom(other.FGAEOEEOIFD);
			break;
		case BPIHFAJCLOCOneofCase.IJOMKIDEOEG:
			if (IJOMKIDEOEG == null)
			{
				IJOMKIDEOEG = new BLDLMHPFBCM();
			}
			IJOMKIDEOEG.MergeFrom(other.IJOMKIDEOEG);
			break;
		case BPIHFAJCLOCOneofCase.KCCIDNOGPPA:
			if (KCCIDNOGPPA == null)
			{
				KCCIDNOGPPA = new LJFFAHEHFDJ();
			}
			KCCIDNOGPPA.MergeFrom(other.KCCIDNOGPPA);
			break;
		case BPIHFAJCLOCOneofCase.CMHGGDOMAAK:
			if (CMHGGDOMAAK == null)
			{
				CMHGGDOMAAK = new CFIKJKGABEI();
			}
			CMHGGDOMAAK.MergeFrom(other.CMHGGDOMAAK);
			break;
		case BPIHFAJCLOCOneofCase.BFMONEFDILP:
			if (BFMONEFDILP == null)
			{
				BFMONEFDILP = new AJGGFCJFKEL();
			}
			BFMONEFDILP.MergeFrom(other.BFMONEFDILP);
			break;
		case BPIHFAJCLOCOneofCase.KMFILFDMILI:
			if (KMFILFDMILI == null)
			{
				KMFILFDMILI = new MAGNIAAPANO();
			}
			KMFILFDMILI.MergeFrom(other.KMFILFDMILI);
			break;
		case BPIHFAJCLOCOneofCase.IJHKIDFCAHO:
			if (IJHKIDFCAHO == null)
			{
				IJHKIDFCAHO = new GACNMNIKJBF();
			}
			IJHKIDFCAHO.MergeFrom(other.IJHKIDFCAHO);
			break;
		case BPIHFAJCLOCOneofCase.CICIDMFLIHL:
			if (CICIDMFLIHL == null)
			{
				CICIDMFLIHL = new LIDKGPCEDHE();
			}
			CICIDMFLIHL.MergeFrom(other.CICIDMFLIHL);
			break;
		case BPIHFAJCLOCOneofCase.MCOPMAMMAKP:
			if (MCOPMAMMAKP == null)
			{
				MCOPMAMMAKP = new NFPOEAEPHIJ();
			}
			MCOPMAMMAKP.MergeFrom(other.MCOPMAMMAKP);
			break;
		case BPIHFAJCLOCOneofCase.PKBFJJJOEBD:
			if (PKBFJJJOEBD == null)
			{
				PKBFJJJOEBD = new NLNOGDMKBOD();
			}
			PKBFJJJOEBD.MergeFrom(other.PKBFJJJOEBD);
			break;
		case BPIHFAJCLOCOneofCase.BOJPHPFIPNK:
			if (BOJPHPFIPNK == null)
			{
				BOJPHPFIPNK = new MBHMOJNPHEJ();
			}
			BOJPHPFIPNK.MergeFrom(other.BOJPHPFIPNK);
			break;
		case BPIHFAJCLOCOneofCase.FBJMOIEEHFF:
			if (FBJMOIEEHFF == null)
			{
				FBJMOIEEHFF = new HBAMALALOGG();
			}
			FBJMOIEEHFF.MergeFrom(other.FBJMOIEEHFF);
			break;
		case BPIHFAJCLOCOneofCase.KMALKBCNJHK:
			if (KMALKBCNJHK == null)
			{
				KMALKBCNJHK = new FOHHEPOECML();
			}
			KMALKBCNJHK.MergeFrom(other.KMALKBCNJHK);
			break;
		case BPIHFAJCLOCOneofCase.OPKPJCIDFIC:
			if (OPKPJCIDFIC == null)
			{
				OPKPJCIDFIC = new DIKAEDCJHFM();
			}
			OPKPJCIDFIC.MergeFrom(other.OPKPJCIDFIC);
			break;
		case BPIHFAJCLOCOneofCase.DEIDEEJDJLB:
			if (DEIDEEJDJLB == null)
			{
				DEIDEEJDJLB = new HGFKGMPPOIM();
			}
			DEIDEEJDJLB.MergeFrom(other.DEIDEEJDJLB);
			break;
		case BPIHFAJCLOCOneofCase.ILAKOOPEODP:
			if (ILAKOOPEODP == null)
			{
				ILAKOOPEODP = new AOGMCBOFNMO();
			}
			ILAKOOPEODP.MergeFrom(other.ILAKOOPEODP);
			break;
		case BPIHFAJCLOCOneofCase.DOBFKCAGMJB:
			if (DOBFKCAGMJB == null)
			{
				DOBFKCAGMJB = new MAGNIAAPANO();
			}
			DOBFKCAGMJB.MergeFrom(other.DOBFKCAGMJB);
			break;
		case BPIHFAJCLOCOneofCase.LAJICPMLKCA:
			if (LAJICPMLKCA == null)
			{
				LAJICPMLKCA = new JDKNKIBFHAF();
			}
			LAJICPMLKCA.MergeFrom(other.LAJICPMLKCA);
			break;
		case BPIHFAJCLOCOneofCase.BBEPLGMEJGN:
			if (BBEPLGMEJGN == null)
			{
				BBEPLGMEJGN = new MPPDGFLMDEB();
			}
			BBEPLGMEJGN.MergeFrom(other.BBEPLGMEJGN);
			break;
		case BPIHFAJCLOCOneofCase.CEPBLFDKFFJ:
			if (CEPBLFDKFFJ == null)
			{
				CEPBLFDKFFJ = new GCFNNAKLMPD();
			}
			CEPBLFDKFFJ.MergeFrom(other.CEPBLFDKFFJ);
			break;
		case BPIHFAJCLOCOneofCase.KHNAKEMGNJM:
			if (KHNAKEMGNJM == null)
			{
				KHNAKEMGNJM = new GEDCCGBPOFL();
			}
			KHNAKEMGNJM.MergeFrom(other.KHNAKEMGNJM);
			break;
		case BPIHFAJCLOCOneofCase.BBEHJAJPHBK:
			if (BBEHJAJPHBK == null)
			{
				BBEHJAJPHBK = new IOGMLLBFDPG();
			}
			BBEHJAJPHBK.MergeFrom(other.BBEHJAJPHBK);
			break;
		case BPIHFAJCLOCOneofCase.JLIINFBLMKI:
			if (JLIINFBLMKI == null)
			{
				JLIINFBLMKI = new IKEBEPBJHCE();
			}
			JLIINFBLMKI.MergeFrom(other.JLIINFBLMKI);
			break;
		case BPIHFAJCLOCOneofCase.HJCJCEACDHJ:
			if (HJCJCEACDHJ == null)
			{
				HJCJCEACDHJ = new PBCOPDHBMLJ();
			}
			HJCJCEACDHJ.MergeFrom(other.HJCJCEACDHJ);
			break;
		case BPIHFAJCLOCOneofCase.NKMIGFDPFNJ:
			if (NKMIGFDPFNJ == null)
			{
				NKMIGFDPFNJ = new HAHKCDIPGJH();
			}
			NKMIGFDPFNJ.MergeFrom(other.NKMIGFDPFNJ);
			break;
		case BPIHFAJCLOCOneofCase.CCGGGDCAIGJ:
			if (CCGGGDCAIGJ == null)
			{
				CCGGGDCAIGJ = new JPPGLJPCFNC();
			}
			CCGGGDCAIGJ.MergeFrom(other.CCGGGDCAIGJ);
			break;
		case BPIHFAJCLOCOneofCase.OFEECJDAHLB:
			if (OFEECJDAHLB == null)
			{
				OFEECJDAHLB = new JAMNDEJMILO();
			}
			OFEECJDAHLB.MergeFrom(other.OFEECJDAHLB);
			break;
		case BPIHFAJCLOCOneofCase.DDAKCDJJOPI:
			if (DDAKCDJJOPI == null)
			{
				DDAKCDJJOPI = new IADIBNIPHBO();
			}
			DDAKCDJJOPI.MergeFrom(other.DDAKCDJJOPI);
			break;
		case BPIHFAJCLOCOneofCase.BAKPFNPNMOP:
			if (BAKPFNPNMOP == null)
			{
				BAKPFNPNMOP = new EFDADBFIABN();
			}
			BAKPFNPNMOP.MergeFrom(other.BAKPFNPNMOP);
			break;
		case BPIHFAJCLOCOneofCase.IPPOGINBKIE:
			if (IPPOGINBKIE == null)
			{
				IPPOGINBKIE = new LGKDBECKMBM();
			}
			IPPOGINBKIE.MergeFrom(other.IPPOGINBKIE);
			break;
		case BPIHFAJCLOCOneofCase.FMAJDANLJEB:
			if (FMAJDANLJEB == null)
			{
				FMAJDANLJEB = new GJEFKOGFNCH();
			}
			FMAJDANLJEB.MergeFrom(other.FMAJDANLJEB);
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
			case 16u:
				MJPCBEAAABJ = input.ReadUInt32();
				break;
			case 104u:
				QueuePosition = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 290u:
			{
				JICGMEBFBJF jICGMEBFBJF = new JICGMEBFBJF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ECBDOFCDHKK)
				{
					jICGMEBFBJF.MergeFrom(ECBDOFCDHKK);
				}
				input.ReadMessage(jICGMEBFBJF);
				ECBDOFCDHKK = jICGMEBFBJF;
				break;
			}
			case 378u:
			{
				OHMDKPCOAEC oHMDKPCOAEC = new OHMDKPCOAEC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JKDHIJFLHAJ)
				{
					oHMDKPCOAEC.MergeFrom(JKDHIJFLHAJ);
				}
				input.ReadMessage(oHMDKPCOAEC);
				JKDHIJFLHAJ = oHMDKPCOAEC;
				break;
			}
			case 506u:
			{
				JNPGMMLHGJH jNPGMMLHGJH = new JNPGMMLHGJH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMHIBDBCGG)
				{
					jNPGMMLHGJH.MergeFrom(PEMHIBDBCGG);
				}
				input.ReadMessage(jNPGMMLHGJH);
				PEMHIBDBCGG = jNPGMMLHGJH;
				break;
			}
			case 994u:
			{
				MMHMPNEJFOP mMHMPNEJFOP = new MMHMPNEJFOP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKBHNGLPEGP)
				{
					mMHMPNEJFOP.MergeFrom(LKBHNGLPEGP);
				}
				input.ReadMessage(mMHMPNEJFOP);
				LKBHNGLPEGP = mMHMPNEJFOP;
				break;
			}
			case 1034u:
			{
				DPHIINCNKEI dPHIINCNKEI = new DPHIINCNKEI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FGAEOEEOIFD)
				{
					dPHIINCNKEI.MergeFrom(FGAEOEEOIFD);
				}
				input.ReadMessage(dPHIINCNKEI);
				FGAEOEEOIFD = dPHIINCNKEI;
				break;
			}
			case 1466u:
			{
				BLDLMHPFBCM bLDLMHPFBCM = new BLDLMHPFBCM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJOMKIDEOEG)
				{
					bLDLMHPFBCM.MergeFrom(IJOMKIDEOEG);
				}
				input.ReadMessage(bLDLMHPFBCM);
				IJOMKIDEOEG = bLDLMHPFBCM;
				break;
			}
			case 2730u:
			{
				LJFFAHEHFDJ lJFFAHEHFDJ = new LJFFAHEHFDJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCCIDNOGPPA)
				{
					lJFFAHEHFDJ.MergeFrom(KCCIDNOGPPA);
				}
				input.ReadMessage(lJFFAHEHFDJ);
				KCCIDNOGPPA = lJFFAHEHFDJ;
				break;
			}
			case 3266u:
			{
				CFIKJKGABEI cFIKJKGABEI = new CFIKJKGABEI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CMHGGDOMAAK)
				{
					cFIKJKGABEI.MergeFrom(CMHGGDOMAAK);
				}
				input.ReadMessage(cFIKJKGABEI);
				CMHGGDOMAAK = cFIKJKGABEI;
				break;
			}
			case 3482u:
			{
				AJGGFCJFKEL aJGGFCJFKEL = new AJGGFCJFKEL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BFMONEFDILP)
				{
					aJGGFCJFKEL.MergeFrom(BFMONEFDILP);
				}
				input.ReadMessage(aJGGFCJFKEL);
				BFMONEFDILP = aJGGFCJFKEL;
				break;
			}
			case 4466u:
			{
				MAGNIAAPANO mAGNIAAPANO2 = new MAGNIAAPANO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMFILFDMILI)
				{
					mAGNIAAPANO2.MergeFrom(KMFILFDMILI);
				}
				input.ReadMessage(mAGNIAAPANO2);
				KMFILFDMILI = mAGNIAAPANO2;
				break;
			}
			case 5834u:
			{
				GACNMNIKJBF gACNMNIKJBF = new GACNMNIKJBF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IJHKIDFCAHO)
				{
					gACNMNIKJBF.MergeFrom(IJHKIDFCAHO);
				}
				input.ReadMessage(gACNMNIKJBF);
				IJHKIDFCAHO = gACNMNIKJBF;
				break;
			}
			case 6186u:
			{
				LIDKGPCEDHE lIDKGPCEDHE = new LIDKGPCEDHE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CICIDMFLIHL)
				{
					lIDKGPCEDHE.MergeFrom(CICIDMFLIHL);
				}
				input.ReadMessage(lIDKGPCEDHE);
				CICIDMFLIHL = lIDKGPCEDHE;
				break;
			}
			case 6290u:
			{
				NFPOEAEPHIJ nFPOEAEPHIJ = new NFPOEAEPHIJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MCOPMAMMAKP)
				{
					nFPOEAEPHIJ.MergeFrom(MCOPMAMMAKP);
				}
				input.ReadMessage(nFPOEAEPHIJ);
				MCOPMAMMAKP = nFPOEAEPHIJ;
				break;
			}
			case 6882u:
			{
				NLNOGDMKBOD nLNOGDMKBOD = new NLNOGDMKBOD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKBFJJJOEBD)
				{
					nLNOGDMKBOD.MergeFrom(PKBFJJJOEBD);
				}
				input.ReadMessage(nLNOGDMKBOD);
				PKBFJJJOEBD = nLNOGDMKBOD;
				break;
			}
			case 7706u:
			{
				MBHMOJNPHEJ mBHMOJNPHEJ = new MBHMOJNPHEJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BOJPHPFIPNK)
				{
					mBHMOJNPHEJ.MergeFrom(BOJPHPFIPNK);
				}
				input.ReadMessage(mBHMOJNPHEJ);
				BOJPHPFIPNK = mBHMOJNPHEJ;
				break;
			}
			case 8082u:
			{
				HBAMALALOGG hBAMALALOGG = new HBAMALALOGG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBJMOIEEHFF)
				{
					hBAMALALOGG.MergeFrom(FBJMOIEEHFF);
				}
				input.ReadMessage(hBAMALALOGG);
				FBJMOIEEHFF = hBAMALALOGG;
				break;
			}
			case 8138u:
			{
				FOHHEPOECML fOHHEPOECML = new FOHHEPOECML();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KMALKBCNJHK)
				{
					fOHHEPOECML.MergeFrom(KMALKBCNJHK);
				}
				input.ReadMessage(fOHHEPOECML);
				KMALKBCNJHK = fOHHEPOECML;
				break;
			}
			case 8266u:
			{
				DIKAEDCJHFM dIKAEDCJHFM = new DIKAEDCJHFM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPKPJCIDFIC)
				{
					dIKAEDCJHFM.MergeFrom(OPKPJCIDFIC);
				}
				input.ReadMessage(dIKAEDCJHFM);
				OPKPJCIDFIC = dIKAEDCJHFM;
				break;
			}
			case 8682u:
			{
				HGFKGMPPOIM hGFKGMPPOIM = new HGFKGMPPOIM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DEIDEEJDJLB)
				{
					hGFKGMPPOIM.MergeFrom(DEIDEEJDJLB);
				}
				input.ReadMessage(hGFKGMPPOIM);
				DEIDEEJDJLB = hGFKGMPPOIM;
				break;
			}
			case 9106u:
			{
				AOGMCBOFNMO aOGMCBOFNMO = new AOGMCBOFNMO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ILAKOOPEODP)
				{
					aOGMCBOFNMO.MergeFrom(ILAKOOPEODP);
				}
				input.ReadMessage(aOGMCBOFNMO);
				ILAKOOPEODP = aOGMCBOFNMO;
				break;
			}
			case 9258u:
			{
				MAGNIAAPANO mAGNIAAPANO = new MAGNIAAPANO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DOBFKCAGMJB)
				{
					mAGNIAAPANO.MergeFrom(DOBFKCAGMJB);
				}
				input.ReadMessage(mAGNIAAPANO);
				DOBFKCAGMJB = mAGNIAAPANO;
				break;
			}
			case 9602u:
			{
				JDKNKIBFHAF jDKNKIBFHAF = new JDKNKIBFHAF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LAJICPMLKCA)
				{
					jDKNKIBFHAF.MergeFrom(LAJICPMLKCA);
				}
				input.ReadMessage(jDKNKIBFHAF);
				LAJICPMLKCA = jDKNKIBFHAF;
				break;
			}
			case 9650u:
			{
				MPPDGFLMDEB mPPDGFLMDEB = new MPPDGFLMDEB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEPLGMEJGN)
				{
					mPPDGFLMDEB.MergeFrom(BBEPLGMEJGN);
				}
				input.ReadMessage(mPPDGFLMDEB);
				BBEPLGMEJGN = mPPDGFLMDEB;
				break;
			}
			case 9658u:
			{
				GCFNNAKLMPD gCFNNAKLMPD = new GCFNNAKLMPD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEPBLFDKFFJ)
				{
					gCFNNAKLMPD.MergeFrom(CEPBLFDKFFJ);
				}
				input.ReadMessage(gCFNNAKLMPD);
				CEPBLFDKFFJ = gCFNNAKLMPD;
				break;
			}
			case 9714u:
			{
				GEDCCGBPOFL gEDCCGBPOFL = new GEDCCGBPOFL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KHNAKEMGNJM)
				{
					gEDCCGBPOFL.MergeFrom(KHNAKEMGNJM);
				}
				input.ReadMessage(gEDCCGBPOFL);
				KHNAKEMGNJM = gEDCCGBPOFL;
				break;
			}
			case 11034u:
			{
				IOGMLLBFDPG iOGMLLBFDPG = new IOGMLLBFDPG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBEHJAJPHBK)
				{
					iOGMLLBFDPG.MergeFrom(BBEHJAJPHBK);
				}
				input.ReadMessage(iOGMLLBFDPG);
				BBEHJAJPHBK = iOGMLLBFDPG;
				break;
			}
			case 11506u:
			{
				IKEBEPBJHCE iKEBEPBJHCE = new IKEBEPBJHCE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLIINFBLMKI)
				{
					iKEBEPBJHCE.MergeFrom(JLIINFBLMKI);
				}
				input.ReadMessage(iKEBEPBJHCE);
				JLIINFBLMKI = iKEBEPBJHCE;
				break;
			}
			case 11794u:
			{
				PBCOPDHBMLJ pBCOPDHBMLJ = new PBCOPDHBMLJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HJCJCEACDHJ)
				{
					pBCOPDHBMLJ.MergeFrom(HJCJCEACDHJ);
				}
				input.ReadMessage(pBCOPDHBMLJ);
				HJCJCEACDHJ = pBCOPDHBMLJ;
				break;
			}
			case 12882u:
			{
				HAHKCDIPGJH hAHKCDIPGJH = new HAHKCDIPGJH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKMIGFDPFNJ)
				{
					hAHKCDIPGJH.MergeFrom(NKMIGFDPFNJ);
				}
				input.ReadMessage(hAHKCDIPGJH);
				NKMIGFDPFNJ = hAHKCDIPGJH;
				break;
			}
			case 14002u:
			{
				JPPGLJPCFNC jPPGLJPCFNC = new JPPGLJPCFNC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CCGGGDCAIGJ)
				{
					jPPGLJPCFNC.MergeFrom(CCGGGDCAIGJ);
				}
				input.ReadMessage(jPPGLJPCFNC);
				CCGGGDCAIGJ = jPPGLJPCFNC;
				break;
			}
			case 14802u:
			{
				JAMNDEJMILO jAMNDEJMILO = new JAMNDEJMILO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OFEECJDAHLB)
				{
					jAMNDEJMILO.MergeFrom(OFEECJDAHLB);
				}
				input.ReadMessage(jAMNDEJMILO);
				OFEECJDAHLB = jAMNDEJMILO;
				break;
			}
			case 15426u:
			{
				IADIBNIPHBO iADIBNIPHBO = new IADIBNIPHBO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DDAKCDJJOPI)
				{
					iADIBNIPHBO.MergeFrom(DDAKCDJJOPI);
				}
				input.ReadMessage(iADIBNIPHBO);
				DDAKCDJJOPI = iADIBNIPHBO;
				break;
			}
			case 15802u:
			{
				EFDADBFIABN eFDADBFIABN = new EFDADBFIABN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAKPFNPNMOP)
				{
					eFDADBFIABN.MergeFrom(BAKPFNPNMOP);
				}
				input.ReadMessage(eFDADBFIABN);
				BAKPFNPNMOP = eFDADBFIABN;
				break;
			}
			case 15890u:
			{
				LGKDBECKMBM lGKDBECKMBM = new LGKDBECKMBM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IPPOGINBKIE)
				{
					lGKDBECKMBM.MergeFrom(IPPOGINBKIE);
				}
				input.ReadMessage(lGKDBECKMBM);
				IPPOGINBKIE = lGKDBECKMBM;
				break;
			}
			case 16322u:
			{
				GJEFKOGFNCH gJEFKOGFNCH = new GJEFKOGFNCH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FMAJDANLJEB)
				{
					gJEFKOGFNCH.MergeFrom(FMAJDANLJEB);
				}
				input.ReadMessage(gJEFKOGFNCH);
				FMAJDANLJEB = gJEFKOGFNCH;
				break;
			}
			}
		}
	}
}
