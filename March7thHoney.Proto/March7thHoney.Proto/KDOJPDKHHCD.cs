using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KDOJPDKHHCD : IMessage<KDOJPDKHHCD>, IMessage, IEquatable<KDOJPDKHHCD>, IDeepCloneable<KDOJPDKHHCD>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		JNNCIIGOKJP = 1,
		ONBNEGNKEBJ = 2,
		KBLCCGMGKMG = 3,
		MAMFDAPMOAM = 4,
		CurHp = 5,
		JAHLPJPCLLN = 6,
		CNDMCCDJFCF = 7,
		FIOEFPCMFKE = 8,
		LDBHDHFENKF = 10,
		PLJKONDBELB = 11,
		PHCOBLKPMGH = 12,
		CKKGIMMDIJH = 14,
		RogueMoney = 15,
		PendingAction = 89,
		NIGENMMJMHN = 182,
		FBCKOEIHIFH = 184,
		KGLLCMIMEMF = 213,
		GLJOMGJLPMH = 648,
		JJABPPDILOK = 695,
		JHICKEFLHNP = 727,
		HFOEGNAMFFK = 924,
		KJDLJPIKGME = 944,
		IKKMNDMELLN = 989,
		KAFMKMCPPGJ = 995,
		GGHBLGFOGCA = 1442,
		NDOAGAKFMNL = 1488,
		KFGBKEADAJG = 1559,
		PDHEBCMOADM = 1595,
		KDCHCIFBOMG = 1644,
		FinishPendingActionPos = 1802,
		BOHGEGCEGDH = 1926
	}

	private static readonly MessageParser<KDOJPDKHHCD> _parser = new MessageParser<KDOJPDKHHCD>(() => new KDOJPDKHHCD());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 208;

	private MCAFGBPLFEH source_;

	public const int JNNCIIGOKJPFieldNumber = 1;

	public const int ONBNEGNKEBJFieldNumber = 2;

	public const int KBLCCGMGKMGFieldNumber = 3;

	public const int MAMFDAPMOAMFieldNumber = 4;

	public const int CurHpFieldNumber = 5;

	public const int JAHLPJPCLLNFieldNumber = 6;

	public const int CNDMCCDJFCFFieldNumber = 7;

	public const int FIOEFPCMFKEFieldNumber = 8;

	public const int LDBHDHFENKFFieldNumber = 10;

	public const int PLJKONDBELBFieldNumber = 11;

	public const int PHCOBLKPMGHFieldNumber = 12;

	public const int CKKGIMMDIJHFieldNumber = 14;

	public const int RogueMoneyFieldNumber = 15;

	public const int PendingActionFieldNumber = 89;

	public const int NIGENMMJMHNFieldNumber = 182;

	public const int FBCKOEIHIFHFieldNumber = 184;

	public const int KGLLCMIMEMFFieldNumber = 213;

	public const int GLJOMGJLPMHFieldNumber = 648;

	public const int JJABPPDILOKFieldNumber = 695;

	public const int JHICKEFLHNPFieldNumber = 727;

	public const int HFOEGNAMFFKFieldNumber = 924;

	public const int KJDLJPIKGMEFieldNumber = 944;

	public const int IKKMNDMELLNFieldNumber = 989;

	public const int KAFMKMCPPGJFieldNumber = 995;

	public const int GGHBLGFOGCAFieldNumber = 1442;

	public const int NDOAGAKFMNLFieldNumber = 1488;

	public const int KFGBKEADAJGFieldNumber = 1559;

	public const int PDHEBCMOADMFieldNumber = 1595;

	public const int KDCHCIFBOMGFieldNumber = 1644;

	public const int FinishPendingActionPosFieldNumber = 1802;

	public const int BOHGEGCEGDHFieldNumber = 1926;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KDOJPDKHHCD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KDOJPDKHHCDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKFLIFAODGK JNNCIIGOKJP
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JNNCIIGOKJP)
			{
				return null;
			}
			return (OKFLIFAODGK)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JNNCIIGOKJP : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMNAALFCNMI ONBNEGNKEBJ
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.ONBNEGNKEBJ)
			{
				return null;
			}
			return (PMNAALFCNMI)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.ONBNEGNKEBJ : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBLCCGMGKMG
	{
		get
		{
			if (!HasKBLCCGMGKMG)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.KBLCCGMGKMG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKBLCCGMGKMG => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KBLCCGMGKMG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POCFNJMAHMD MAMFDAPMOAM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.MAMFDAPMOAM)
			{
				return null;
			}
			return (POCFNJMAHMD)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.MAMFDAPMOAM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			if (!HasCurHp)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.CurHp;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCurHp => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CurHp;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAPCAHCHMFN JAHLPJPCLLN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JAHLPJPCLLN)
			{
				return null;
			}
			return (AAPCAHCHMFN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JAHLPJPCLLN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLMLCCDEOPP CNDMCCDJFCF
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CNDMCCDJFCF)
			{
				return null;
			}
			return (BLMLCCDEOPP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CNDMCCDJFCF : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMMGJABOCB FIOEFPCMFKE
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FIOEFPCMFKE)
			{
				return null;
			}
			return (HHMMGJABOCB)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FIOEFPCMFKE : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEEMOEKEECM LDBHDHFENKF
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.LDBHDHFENKF)
			{
				return null;
			}
			return (DEEMOEKEECM)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.LDBHDHFENKF : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKDFOOJMHIE PLJKONDBELB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PLJKONDBELB)
			{
				return null;
			}
			return (LKDFOOJMHIE)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PLJKONDBELB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHDICMGKLMB PHCOBLKPMGH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PHCOBLKPMGH)
			{
				return null;
			}
			return (AHDICMGKLMB)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PHCOBLKPMGH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIDLPPKAJPO CKKGIMMDIJH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CKKGIMMDIJH)
			{
				return null;
			}
			return (CIDLPPKAJPO)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CKKGIMMDIJH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RogueMoney
	{
		get
		{
			if (!HasRogueMoney)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.RogueMoney;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRogueMoney => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.RogueMoney;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDIINAHJAF PendingAction
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PendingAction)
			{
				return null;
			}
			return (PNDIINAHJAF)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PendingAction : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICCCIJAKOJL NIGENMMJMHN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NIGENMMJMHN)
			{
				return null;
			}
			return (ICCCIJAKOJL)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NIGENMMJMHN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJDACJOJGLE FBCKOEIHIFH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FBCKOEIHIFH)
			{
				return null;
			}
			return (DJDACJOJGLE)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FBCKOEIHIFH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPDMGOACIEP KGLLCMIMEMF
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.KGLLCMIMEMF)
			{
				return null;
			}
			return (OPDMGOACIEP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.KGLLCMIMEMF : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBLLDKAFIII GLJOMGJLPMH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.GLJOMGJLPMH)
			{
				return null;
			}
			return (HBLLDKAFIII)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.GLJOMGJLPMH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJABPPDILOK
	{
		get
		{
			if (!HasJJABPPDILOK)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.JJABPPDILOK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJJABPPDILOK => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JJABPPDILOK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHICKEFLHNP
	{
		get
		{
			if (!HasJHICKEFLHNP)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.JHICKEFLHNP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJHICKEFLHNP => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JHICKEFLHNP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFOEGNAMFFK
	{
		get
		{
			if (!HasHFOEGNAMFFK)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.HFOEGNAMFFK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHFOEGNAMFFK => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HFOEGNAMFFK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIGCEPLMKA KJDLJPIKGME
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.KJDLJPIKGME)
			{
				return null;
			}
			return (OKIGCEPLMKA)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.KJDLJPIKGME : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCLDNHOHPII IKKMNDMELLN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.IKKMNDMELLN)
			{
				return null;
			}
			return (FCLDNHOHPII)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.IKKMNDMELLN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMKCEBGKKN KAFMKMCPPGJ
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.KAFMKMCPPGJ)
			{
				return null;
			}
			return (DIMKCEBGKKN)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.KAFMKMCPPGJ : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COBPAMNPPNH GGHBLGFOGCA
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.GGHBLGFOGCA)
			{
				return null;
			}
			return (COBPAMNPPNH)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.GGHBLGFOGCA : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLJODGHMADG NDOAGAKFMNL
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NDOAGAKFMNL)
			{
				return null;
			}
			return (LLJODGHMADG)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NDOAGAKFMNL : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KFGBKEADAJG
	{
		get
		{
			if (!HasKFGBKEADAJG)
			{
				return 0uL;
			}
			return (ulong)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.KFGBKEADAJG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKFGBKEADAJG => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KFGBKEADAJG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCGFNMNAFEK PDHEBCMOADM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PDHEBCMOADM)
			{
				return null;
			}
			return (GCGFNMNAFEK)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PDHEBCMOADM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMDNCPJME KDCHCIFBOMG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.KDCHCIFBOMG)
			{
				return null;
			}
			return (EPJMDNCPJME)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.KDCHCIFBOMG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FinishPendingActionPos
	{
		get
		{
			if (!HasFinishPendingActionPos)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.FinishPendingActionPos;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFinishPendingActionPos => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FinishPendingActionPos;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLGENHNODNI BOHGEGCEGDH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.BOHGEGCEGDH)
			{
				return null;
			}
			return (FLGENHNODNI)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.BOHGEGCEGDH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDOJPDKHHCD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDOJPDKHHCD(KDOJPDKHHCD other)
		: this()
	{
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.JNNCIIGOKJP:
			JNNCIIGOKJP = other.JNNCIIGOKJP.Clone();
			break;
		case NLPPPCHGGPFOneofCase.ONBNEGNKEBJ:
			ONBNEGNKEBJ = other.ONBNEGNKEBJ.Clone();
			break;
		case NLPPPCHGGPFOneofCase.KBLCCGMGKMG:
			KBLCCGMGKMG = other.KBLCCGMGKMG;
			break;
		case NLPPPCHGGPFOneofCase.MAMFDAPMOAM:
			MAMFDAPMOAM = other.MAMFDAPMOAM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CurHp:
			CurHp = other.CurHp;
			break;
		case NLPPPCHGGPFOneofCase.JAHLPJPCLLN:
			JAHLPJPCLLN = other.JAHLPJPCLLN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CNDMCCDJFCF:
			CNDMCCDJFCF = other.CNDMCCDJFCF.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FIOEFPCMFKE:
			FIOEFPCMFKE = other.FIOEFPCMFKE.Clone();
			break;
		case NLPPPCHGGPFOneofCase.LDBHDHFENKF:
			LDBHDHFENKF = other.LDBHDHFENKF.Clone();
			break;
		case NLPPPCHGGPFOneofCase.PLJKONDBELB:
			PLJKONDBELB = other.PLJKONDBELB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.PHCOBLKPMGH:
			PHCOBLKPMGH = other.PHCOBLKPMGH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CKKGIMMDIJH:
			CKKGIMMDIJH = other.CKKGIMMDIJH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.RogueMoney:
			RogueMoney = other.RogueMoney;
			break;
		case NLPPPCHGGPFOneofCase.PendingAction:
			PendingAction = other.PendingAction.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NIGENMMJMHN:
			NIGENMMJMHN = other.NIGENMMJMHN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FBCKOEIHIFH:
			FBCKOEIHIFH = other.FBCKOEIHIFH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.KGLLCMIMEMF:
			KGLLCMIMEMF = other.KGLLCMIMEMF.Clone();
			break;
		case NLPPPCHGGPFOneofCase.GLJOMGJLPMH:
			GLJOMGJLPMH = other.GLJOMGJLPMH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JJABPPDILOK:
			JJABPPDILOK = other.JJABPPDILOK;
			break;
		case NLPPPCHGGPFOneofCase.JHICKEFLHNP:
			JHICKEFLHNP = other.JHICKEFLHNP;
			break;
		case NLPPPCHGGPFOneofCase.HFOEGNAMFFK:
			HFOEGNAMFFK = other.HFOEGNAMFFK;
			break;
		case NLPPPCHGGPFOneofCase.KJDLJPIKGME:
			KJDLJPIKGME = other.KJDLJPIKGME.Clone();
			break;
		case NLPPPCHGGPFOneofCase.IKKMNDMELLN:
			IKKMNDMELLN = other.IKKMNDMELLN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.KAFMKMCPPGJ:
			KAFMKMCPPGJ = other.KAFMKMCPPGJ.Clone();
			break;
		case NLPPPCHGGPFOneofCase.GGHBLGFOGCA:
			GGHBLGFOGCA = other.GGHBLGFOGCA.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NDOAGAKFMNL:
			NDOAGAKFMNL = other.NDOAGAKFMNL.Clone();
			break;
		case NLPPPCHGGPFOneofCase.KFGBKEADAJG:
			KFGBKEADAJG = other.KFGBKEADAJG;
			break;
		case NLPPPCHGGPFOneofCase.PDHEBCMOADM:
			PDHEBCMOADM = other.PDHEBCMOADM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.KDCHCIFBOMG:
			KDCHCIFBOMG = other.KDCHCIFBOMG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FinishPendingActionPos:
			FinishPendingActionPos = other.FinishPendingActionPos;
			break;
		case NLPPPCHGGPFOneofCase.BOHGEGCEGDH:
			BOHGEGCEGDH = other.BOHGEGCEGDH.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDOJPDKHHCD Clone()
	{
		return new KDOJPDKHHCD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKBLCCGMGKMG()
	{
		if (HasKBLCCGMGKMG)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCurHp()
	{
		if (HasCurHp)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRogueMoney()
	{
		if (HasRogueMoney)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJJABPPDILOK()
	{
		if (HasJJABPPDILOK)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJHICKEFLHNP()
	{
		if (HasJHICKEFLHNP)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHFOEGNAMFFK()
	{
		if (HasHFOEGNAMFFK)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKFGBKEADAJG()
	{
		if (HasKFGBKEADAJG)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFinishPendingActionPos()
	{
		if (HasFinishPendingActionPos)
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
		return Equals(other as KDOJPDKHHCD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KDOJPDKHHCD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (!object.Equals(JNNCIIGOKJP, other.JNNCIIGOKJP))
		{
			return false;
		}
		if (!object.Equals(ONBNEGNKEBJ, other.ONBNEGNKEBJ))
		{
			return false;
		}
		if (KBLCCGMGKMG != other.KBLCCGMGKMG)
		{
			return false;
		}
		if (!object.Equals(MAMFDAPMOAM, other.MAMFDAPMOAM))
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (!object.Equals(JAHLPJPCLLN, other.JAHLPJPCLLN))
		{
			return false;
		}
		if (!object.Equals(CNDMCCDJFCF, other.CNDMCCDJFCF))
		{
			return false;
		}
		if (!object.Equals(FIOEFPCMFKE, other.FIOEFPCMFKE))
		{
			return false;
		}
		if (!object.Equals(LDBHDHFENKF, other.LDBHDHFENKF))
		{
			return false;
		}
		if (!object.Equals(PLJKONDBELB, other.PLJKONDBELB))
		{
			return false;
		}
		if (!object.Equals(PHCOBLKPMGH, other.PHCOBLKPMGH))
		{
			return false;
		}
		if (!object.Equals(CKKGIMMDIJH, other.CKKGIMMDIJH))
		{
			return false;
		}
		if (RogueMoney != other.RogueMoney)
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!object.Equals(NIGENMMJMHN, other.NIGENMMJMHN))
		{
			return false;
		}
		if (!object.Equals(FBCKOEIHIFH, other.FBCKOEIHIFH))
		{
			return false;
		}
		if (!object.Equals(KGLLCMIMEMF, other.KGLLCMIMEMF))
		{
			return false;
		}
		if (!object.Equals(GLJOMGJLPMH, other.GLJOMGJLPMH))
		{
			return false;
		}
		if (JJABPPDILOK != other.JJABPPDILOK)
		{
			return false;
		}
		if (JHICKEFLHNP != other.JHICKEFLHNP)
		{
			return false;
		}
		if (HFOEGNAMFFK != other.HFOEGNAMFFK)
		{
			return false;
		}
		if (!object.Equals(KJDLJPIKGME, other.KJDLJPIKGME))
		{
			return false;
		}
		if (!object.Equals(IKKMNDMELLN, other.IKKMNDMELLN))
		{
			return false;
		}
		if (!object.Equals(KAFMKMCPPGJ, other.KAFMKMCPPGJ))
		{
			return false;
		}
		if (!object.Equals(GGHBLGFOGCA, other.GGHBLGFOGCA))
		{
			return false;
		}
		if (!object.Equals(NDOAGAKFMNL, other.NDOAGAKFMNL))
		{
			return false;
		}
		if (KFGBKEADAJG != other.KFGBKEADAJG)
		{
			return false;
		}
		if (!object.Equals(PDHEBCMOADM, other.PDHEBCMOADM))
		{
			return false;
		}
		if (!object.Equals(KDCHCIFBOMG, other.KDCHCIFBOMG))
		{
			return false;
		}
		if (FinishPendingActionPos != other.FinishPendingActionPos)
		{
			return false;
		}
		if (!object.Equals(BOHGEGCEGDH, other.BOHGEGCEGDH))
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
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JNNCIIGOKJP)
		{
			num ^= JNNCIIGOKJP.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ONBNEGNKEBJ)
		{
			num ^= ONBNEGNKEBJ.GetHashCode();
		}
		if (HasKBLCCGMGKMG)
		{
			num ^= KBLCCGMGKMG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAMFDAPMOAM)
		{
			num ^= MAMFDAPMOAM.GetHashCode();
		}
		if (HasCurHp)
		{
			num ^= CurHp.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JAHLPJPCLLN)
		{
			num ^= JAHLPJPCLLN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CNDMCCDJFCF)
		{
			num ^= CNDMCCDJFCF.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FIOEFPCMFKE)
		{
			num ^= FIOEFPCMFKE.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDBHDHFENKF)
		{
			num ^= LDBHDHFENKF.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PLJKONDBELB)
		{
			num ^= PLJKONDBELB.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHCOBLKPMGH)
		{
			num ^= PHCOBLKPMGH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CKKGIMMDIJH)
		{
			num ^= CKKGIMMDIJH.GetHashCode();
		}
		if (HasRogueMoney)
		{
			num ^= RogueMoney.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PendingAction)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NIGENMMJMHN)
		{
			num ^= NIGENMMJMHN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FBCKOEIHIFH)
		{
			num ^= FBCKOEIHIFH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KGLLCMIMEMF)
		{
			num ^= KGLLCMIMEMF.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GLJOMGJLPMH)
		{
			num ^= GLJOMGJLPMH.GetHashCode();
		}
		if (HasJJABPPDILOK)
		{
			num ^= JJABPPDILOK.GetHashCode();
		}
		if (HasJHICKEFLHNP)
		{
			num ^= JHICKEFLHNP.GetHashCode();
		}
		if (HasHFOEGNAMFFK)
		{
			num ^= HFOEGNAMFFK.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KJDLJPIKGME)
		{
			num ^= KJDLJPIKGME.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IKKMNDMELLN)
		{
			num ^= IKKMNDMELLN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KAFMKMCPPGJ)
		{
			num ^= KAFMKMCPPGJ.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGHBLGFOGCA)
		{
			num ^= GGHBLGFOGCA.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NDOAGAKFMNL)
		{
			num ^= NDOAGAKFMNL.GetHashCode();
		}
		if (HasKFGBKEADAJG)
		{
			num ^= KFGBKEADAJG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PDHEBCMOADM)
		{
			num ^= PDHEBCMOADM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KDCHCIFBOMG)
		{
			num ^= KDCHCIFBOMG.GetHashCode();
		}
		if (HasFinishPendingActionPos)
		{
			num ^= FinishPendingActionPos.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BOHGEGCEGDH)
		{
			num ^= BOHGEGCEGDH.GetHashCode();
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JNNCIIGOKJP)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JNNCIIGOKJP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ONBNEGNKEBJ)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ONBNEGNKEBJ);
		}
		if (HasKBLCCGMGKMG)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KBLCCGMGKMG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAMFDAPMOAM)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MAMFDAPMOAM);
		}
		if (HasCurHp)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CurHp);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JAHLPJPCLLN)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JAHLPJPCLLN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CNDMCCDJFCF)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CNDMCCDJFCF);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FIOEFPCMFKE)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FIOEFPCMFKE);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDBHDHFENKF)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LDBHDHFENKF);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PLJKONDBELB)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PLJKONDBELB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHCOBLKPMGH)
		{
			output.WriteRawTag(98);
			output.WriteMessage(PHCOBLKPMGH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CKKGIMMDIJH)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CKKGIMMDIJH);
		}
		if (HasRogueMoney)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RogueMoney);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PendingAction)
		{
			output.WriteRawTag(202, 5);
			output.WriteMessage(PendingAction);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NIGENMMJMHN)
		{
			output.WriteRawTag(178, 11);
			output.WriteMessage(NIGENMMJMHN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FBCKOEIHIFH)
		{
			output.WriteRawTag(194, 11);
			output.WriteMessage(FBCKOEIHIFH);
		}
		if (source_ != null)
		{
			output.WriteRawTag(130, 13);
			output.WriteMessage(Source);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KGLLCMIMEMF)
		{
			output.WriteRawTag(170, 13);
			output.WriteMessage(KGLLCMIMEMF);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GLJOMGJLPMH)
		{
			output.WriteRawTag(194, 40);
			output.WriteMessage(GLJOMGJLPMH);
		}
		if (HasJJABPPDILOK)
		{
			output.WriteRawTag(184, 43);
			output.WriteUInt32(JJABPPDILOK);
		}
		if (HasJHICKEFLHNP)
		{
			output.WriteRawTag(184, 45);
			output.WriteUInt32(JHICKEFLHNP);
		}
		if (HasHFOEGNAMFFK)
		{
			output.WriteRawTag(224, 57);
			output.WriteUInt32(HFOEGNAMFFK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KJDLJPIKGME)
		{
			output.WriteRawTag(130, 59);
			output.WriteMessage(KJDLJPIKGME);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IKKMNDMELLN)
		{
			output.WriteRawTag(234, 61);
			output.WriteMessage(IKKMNDMELLN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KAFMKMCPPGJ)
		{
			output.WriteRawTag(154, 62);
			output.WriteMessage(KAFMKMCPPGJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGHBLGFOGCA)
		{
			output.WriteRawTag(146, 90);
			output.WriteMessage(GGHBLGFOGCA);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NDOAGAKFMNL)
		{
			output.WriteRawTag(130, 93);
			output.WriteMessage(NDOAGAKFMNL);
		}
		if (HasKFGBKEADAJG)
		{
			output.WriteRawTag(184, 97);
			output.WriteUInt64(KFGBKEADAJG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PDHEBCMOADM)
		{
			output.WriteRawTag(218, 99);
			output.WriteMessage(PDHEBCMOADM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KDCHCIFBOMG)
		{
			output.WriteRawTag(226, 102);
			output.WriteMessage(KDCHCIFBOMG);
		}
		if (HasFinishPendingActionPos)
		{
			output.WriteRawTag(208, 112);
			output.WriteUInt32(FinishPendingActionPos);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BOHGEGCEGDH)
		{
			output.WriteRawTag(178, 120);
			output.WriteMessage(BOHGEGCEGDH);
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
		if (source_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JNNCIIGOKJP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNNCIIGOKJP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ONBNEGNKEBJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONBNEGNKEBJ);
		}
		if (HasKBLCCGMGKMG)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBLCCGMGKMG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAMFDAPMOAM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAMFDAPMOAM);
		}
		if (HasCurHp)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JAHLPJPCLLN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JAHLPJPCLLN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CNDMCCDJFCF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CNDMCCDJFCF);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FIOEFPCMFKE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FIOEFPCMFKE);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDBHDHFENKF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LDBHDHFENKF);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PLJKONDBELB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLJKONDBELB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHCOBLKPMGH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PHCOBLKPMGH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CKKGIMMDIJH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CKKGIMMDIJH);
		}
		if (HasRogueMoney)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueMoney);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PendingAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NIGENMMJMHN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NIGENMMJMHN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FBCKOEIHIFH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FBCKOEIHIFH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KGLLCMIMEMF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KGLLCMIMEMF);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GLJOMGJLPMH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GLJOMGJLPMH);
		}
		if (HasJJABPPDILOK)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(JJABPPDILOK);
		}
		if (HasJHICKEFLHNP)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(JHICKEFLHNP);
		}
		if (HasHFOEGNAMFFK)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HFOEGNAMFFK);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KJDLJPIKGME)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KJDLJPIKGME);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IKKMNDMELLN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IKKMNDMELLN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KAFMKMCPPGJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KAFMKMCPPGJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGHBLGFOGCA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GGHBLGFOGCA);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NDOAGAKFMNL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NDOAGAKFMNL);
		}
		if (HasKFGBKEADAJG)
		{
			num += 2 + CodedOutputStream.ComputeUInt64Size(KFGBKEADAJG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PDHEBCMOADM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PDHEBCMOADM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KDCHCIFBOMG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KDCHCIFBOMG);
		}
		if (HasFinishPendingActionPos)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(FinishPendingActionPos);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BOHGEGCEGDH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BOHGEGCEGDH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KDOJPDKHHCD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new MCAFGBPLFEH();
			}
			Source.MergeFrom(other.Source);
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.JNNCIIGOKJP:
			if (JNNCIIGOKJP == null)
			{
				JNNCIIGOKJP = new OKFLIFAODGK();
			}
			JNNCIIGOKJP.MergeFrom(other.JNNCIIGOKJP);
			break;
		case NLPPPCHGGPFOneofCase.ONBNEGNKEBJ:
			if (ONBNEGNKEBJ == null)
			{
				ONBNEGNKEBJ = new PMNAALFCNMI();
			}
			ONBNEGNKEBJ.MergeFrom(other.ONBNEGNKEBJ);
			break;
		case NLPPPCHGGPFOneofCase.KBLCCGMGKMG:
			KBLCCGMGKMG = other.KBLCCGMGKMG;
			break;
		case NLPPPCHGGPFOneofCase.MAMFDAPMOAM:
			if (MAMFDAPMOAM == null)
			{
				MAMFDAPMOAM = new POCFNJMAHMD();
			}
			MAMFDAPMOAM.MergeFrom(other.MAMFDAPMOAM);
			break;
		case NLPPPCHGGPFOneofCase.CurHp:
			CurHp = other.CurHp;
			break;
		case NLPPPCHGGPFOneofCase.JAHLPJPCLLN:
			if (JAHLPJPCLLN == null)
			{
				JAHLPJPCLLN = new AAPCAHCHMFN();
			}
			JAHLPJPCLLN.MergeFrom(other.JAHLPJPCLLN);
			break;
		case NLPPPCHGGPFOneofCase.CNDMCCDJFCF:
			if (CNDMCCDJFCF == null)
			{
				CNDMCCDJFCF = new BLMLCCDEOPP();
			}
			CNDMCCDJFCF.MergeFrom(other.CNDMCCDJFCF);
			break;
		case NLPPPCHGGPFOneofCase.FIOEFPCMFKE:
			if (FIOEFPCMFKE == null)
			{
				FIOEFPCMFKE = new HHMMGJABOCB();
			}
			FIOEFPCMFKE.MergeFrom(other.FIOEFPCMFKE);
			break;
		case NLPPPCHGGPFOneofCase.LDBHDHFENKF:
			if (LDBHDHFENKF == null)
			{
				LDBHDHFENKF = new DEEMOEKEECM();
			}
			LDBHDHFENKF.MergeFrom(other.LDBHDHFENKF);
			break;
		case NLPPPCHGGPFOneofCase.PLJKONDBELB:
			if (PLJKONDBELB == null)
			{
				PLJKONDBELB = new LKDFOOJMHIE();
			}
			PLJKONDBELB.MergeFrom(other.PLJKONDBELB);
			break;
		case NLPPPCHGGPFOneofCase.PHCOBLKPMGH:
			if (PHCOBLKPMGH == null)
			{
				PHCOBLKPMGH = new AHDICMGKLMB();
			}
			PHCOBLKPMGH.MergeFrom(other.PHCOBLKPMGH);
			break;
		case NLPPPCHGGPFOneofCase.CKKGIMMDIJH:
			if (CKKGIMMDIJH == null)
			{
				CKKGIMMDIJH = new CIDLPPKAJPO();
			}
			CKKGIMMDIJH.MergeFrom(other.CKKGIMMDIJH);
			break;
		case NLPPPCHGGPFOneofCase.RogueMoney:
			RogueMoney = other.RogueMoney;
			break;
		case NLPPPCHGGPFOneofCase.PendingAction:
			if (PendingAction == null)
			{
				PendingAction = new PNDIINAHJAF();
			}
			PendingAction.MergeFrom(other.PendingAction);
			break;
		case NLPPPCHGGPFOneofCase.NIGENMMJMHN:
			if (NIGENMMJMHN == null)
			{
				NIGENMMJMHN = new ICCCIJAKOJL();
			}
			NIGENMMJMHN.MergeFrom(other.NIGENMMJMHN);
			break;
		case NLPPPCHGGPFOneofCase.FBCKOEIHIFH:
			if (FBCKOEIHIFH == null)
			{
				FBCKOEIHIFH = new DJDACJOJGLE();
			}
			FBCKOEIHIFH.MergeFrom(other.FBCKOEIHIFH);
			break;
		case NLPPPCHGGPFOneofCase.KGLLCMIMEMF:
			if (KGLLCMIMEMF == null)
			{
				KGLLCMIMEMF = new OPDMGOACIEP();
			}
			KGLLCMIMEMF.MergeFrom(other.KGLLCMIMEMF);
			break;
		case NLPPPCHGGPFOneofCase.GLJOMGJLPMH:
			if (GLJOMGJLPMH == null)
			{
				GLJOMGJLPMH = new HBLLDKAFIII();
			}
			GLJOMGJLPMH.MergeFrom(other.GLJOMGJLPMH);
			break;
		case NLPPPCHGGPFOneofCase.JJABPPDILOK:
			JJABPPDILOK = other.JJABPPDILOK;
			break;
		case NLPPPCHGGPFOneofCase.JHICKEFLHNP:
			JHICKEFLHNP = other.JHICKEFLHNP;
			break;
		case NLPPPCHGGPFOneofCase.HFOEGNAMFFK:
			HFOEGNAMFFK = other.HFOEGNAMFFK;
			break;
		case NLPPPCHGGPFOneofCase.KJDLJPIKGME:
			if (KJDLJPIKGME == null)
			{
				KJDLJPIKGME = new OKIGCEPLMKA();
			}
			KJDLJPIKGME.MergeFrom(other.KJDLJPIKGME);
			break;
		case NLPPPCHGGPFOneofCase.IKKMNDMELLN:
			if (IKKMNDMELLN == null)
			{
				IKKMNDMELLN = new FCLDNHOHPII();
			}
			IKKMNDMELLN.MergeFrom(other.IKKMNDMELLN);
			break;
		case NLPPPCHGGPFOneofCase.KAFMKMCPPGJ:
			if (KAFMKMCPPGJ == null)
			{
				KAFMKMCPPGJ = new DIMKCEBGKKN();
			}
			KAFMKMCPPGJ.MergeFrom(other.KAFMKMCPPGJ);
			break;
		case NLPPPCHGGPFOneofCase.GGHBLGFOGCA:
			if (GGHBLGFOGCA == null)
			{
				GGHBLGFOGCA = new COBPAMNPPNH();
			}
			GGHBLGFOGCA.MergeFrom(other.GGHBLGFOGCA);
			break;
		case NLPPPCHGGPFOneofCase.NDOAGAKFMNL:
			if (NDOAGAKFMNL == null)
			{
				NDOAGAKFMNL = new LLJODGHMADG();
			}
			NDOAGAKFMNL.MergeFrom(other.NDOAGAKFMNL);
			break;
		case NLPPPCHGGPFOneofCase.KFGBKEADAJG:
			KFGBKEADAJG = other.KFGBKEADAJG;
			break;
		case NLPPPCHGGPFOneofCase.PDHEBCMOADM:
			if (PDHEBCMOADM == null)
			{
				PDHEBCMOADM = new GCGFNMNAFEK();
			}
			PDHEBCMOADM.MergeFrom(other.PDHEBCMOADM);
			break;
		case NLPPPCHGGPFOneofCase.KDCHCIFBOMG:
			if (KDCHCIFBOMG == null)
			{
				KDCHCIFBOMG = new EPJMDNCPJME();
			}
			KDCHCIFBOMG.MergeFrom(other.KDCHCIFBOMG);
			break;
		case NLPPPCHGGPFOneofCase.FinishPendingActionPos:
			FinishPendingActionPos = other.FinishPendingActionPos;
			break;
		case NLPPPCHGGPFOneofCase.BOHGEGCEGDH:
			if (BOHGEGCEGDH == null)
			{
				BOHGEGCEGDH = new FLGENHNODNI();
			}
			BOHGEGCEGDH.MergeFrom(other.BOHGEGCEGDH);
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
				OKFLIFAODGK oKFLIFAODGK = new OKFLIFAODGK();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JNNCIIGOKJP)
				{
					oKFLIFAODGK.MergeFrom(JNNCIIGOKJP);
				}
				input.ReadMessage(oKFLIFAODGK);
				JNNCIIGOKJP = oKFLIFAODGK;
				break;
			}
			case 18u:
			{
				PMNAALFCNMI pMNAALFCNMI = new PMNAALFCNMI();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ONBNEGNKEBJ)
				{
					pMNAALFCNMI.MergeFrom(ONBNEGNKEBJ);
				}
				input.ReadMessage(pMNAALFCNMI);
				ONBNEGNKEBJ = pMNAALFCNMI;
				break;
			}
			case 24u:
				KBLCCGMGKMG = input.ReadUInt32();
				break;
			case 34u:
			{
				POCFNJMAHMD pOCFNJMAHMD = new POCFNJMAHMD();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAMFDAPMOAM)
				{
					pOCFNJMAHMD.MergeFrom(MAMFDAPMOAM);
				}
				input.ReadMessage(pOCFNJMAHMD);
				MAMFDAPMOAM = pOCFNJMAHMD;
				break;
			}
			case 40u:
				CurHp = input.ReadUInt32();
				break;
			case 50u:
			{
				AAPCAHCHMFN aAPCAHCHMFN = new AAPCAHCHMFN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JAHLPJPCLLN)
				{
					aAPCAHCHMFN.MergeFrom(JAHLPJPCLLN);
				}
				input.ReadMessage(aAPCAHCHMFN);
				JAHLPJPCLLN = aAPCAHCHMFN;
				break;
			}
			case 58u:
			{
				BLMLCCDEOPP bLMLCCDEOPP = new BLMLCCDEOPP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CNDMCCDJFCF)
				{
					bLMLCCDEOPP.MergeFrom(CNDMCCDJFCF);
				}
				input.ReadMessage(bLMLCCDEOPP);
				CNDMCCDJFCF = bLMLCCDEOPP;
				break;
			}
			case 66u:
			{
				HHMMGJABOCB hHMMGJABOCB = new HHMMGJABOCB();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FIOEFPCMFKE)
				{
					hHMMGJABOCB.MergeFrom(FIOEFPCMFKE);
				}
				input.ReadMessage(hHMMGJABOCB);
				FIOEFPCMFKE = hHMMGJABOCB;
				break;
			}
			case 82u:
			{
				DEEMOEKEECM dEEMOEKEECM = new DEEMOEKEECM();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LDBHDHFENKF)
				{
					dEEMOEKEECM.MergeFrom(LDBHDHFENKF);
				}
				input.ReadMessage(dEEMOEKEECM);
				LDBHDHFENKF = dEEMOEKEECM;
				break;
			}
			case 90u:
			{
				LKDFOOJMHIE lKDFOOJMHIE = new LKDFOOJMHIE();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PLJKONDBELB)
				{
					lKDFOOJMHIE.MergeFrom(PLJKONDBELB);
				}
				input.ReadMessage(lKDFOOJMHIE);
				PLJKONDBELB = lKDFOOJMHIE;
				break;
			}
			case 98u:
			{
				AHDICMGKLMB aHDICMGKLMB = new AHDICMGKLMB();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PHCOBLKPMGH)
				{
					aHDICMGKLMB.MergeFrom(PHCOBLKPMGH);
				}
				input.ReadMessage(aHDICMGKLMB);
				PHCOBLKPMGH = aHDICMGKLMB;
				break;
			}
			case 114u:
			{
				CIDLPPKAJPO cIDLPPKAJPO = new CIDLPPKAJPO();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CKKGIMMDIJH)
				{
					cIDLPPKAJPO.MergeFrom(CKKGIMMDIJH);
				}
				input.ReadMessage(cIDLPPKAJPO);
				CKKGIMMDIJH = cIDLPPKAJPO;
				break;
			}
			case 120u:
				RogueMoney = input.ReadUInt32();
				break;
			case 714u:
			{
				PNDIINAHJAF pNDIINAHJAF = new PNDIINAHJAF();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PendingAction)
				{
					pNDIINAHJAF.MergeFrom(PendingAction);
				}
				input.ReadMessage(pNDIINAHJAF);
				PendingAction = pNDIINAHJAF;
				break;
			}
			case 1458u:
			{
				ICCCIJAKOJL iCCCIJAKOJL = new ICCCIJAKOJL();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NIGENMMJMHN)
				{
					iCCCIJAKOJL.MergeFrom(NIGENMMJMHN);
				}
				input.ReadMessage(iCCCIJAKOJL);
				NIGENMMJMHN = iCCCIJAKOJL;
				break;
			}
			case 1474u:
			{
				DJDACJOJGLE dJDACJOJGLE = new DJDACJOJGLE();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FBCKOEIHIFH)
				{
					dJDACJOJGLE.MergeFrom(FBCKOEIHIFH);
				}
				input.ReadMessage(dJDACJOJGLE);
				FBCKOEIHIFH = dJDACJOJGLE;
				break;
			}
			case 1666u:
				if (source_ == null)
				{
					Source = new MCAFGBPLFEH();
				}
				input.ReadMessage(Source);
				break;
			case 1706u:
			{
				OPDMGOACIEP oPDMGOACIEP = new OPDMGOACIEP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KGLLCMIMEMF)
				{
					oPDMGOACIEP.MergeFrom(KGLLCMIMEMF);
				}
				input.ReadMessage(oPDMGOACIEP);
				KGLLCMIMEMF = oPDMGOACIEP;
				break;
			}
			case 5186u:
			{
				HBLLDKAFIII hBLLDKAFIII = new HBLLDKAFIII();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GLJOMGJLPMH)
				{
					hBLLDKAFIII.MergeFrom(GLJOMGJLPMH);
				}
				input.ReadMessage(hBLLDKAFIII);
				GLJOMGJLPMH = hBLLDKAFIII;
				break;
			}
			case 5560u:
				JJABPPDILOK = input.ReadUInt32();
				break;
			case 5816u:
				JHICKEFLHNP = input.ReadUInt32();
				break;
			case 7392u:
				HFOEGNAMFFK = input.ReadUInt32();
				break;
			case 7554u:
			{
				OKIGCEPLMKA oKIGCEPLMKA = new OKIGCEPLMKA();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KJDLJPIKGME)
				{
					oKIGCEPLMKA.MergeFrom(KJDLJPIKGME);
				}
				input.ReadMessage(oKIGCEPLMKA);
				KJDLJPIKGME = oKIGCEPLMKA;
				break;
			}
			case 7914u:
			{
				FCLDNHOHPII fCLDNHOHPII = new FCLDNHOHPII();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.IKKMNDMELLN)
				{
					fCLDNHOHPII.MergeFrom(IKKMNDMELLN);
				}
				input.ReadMessage(fCLDNHOHPII);
				IKKMNDMELLN = fCLDNHOHPII;
				break;
			}
			case 7962u:
			{
				DIMKCEBGKKN dIMKCEBGKKN = new DIMKCEBGKKN();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KAFMKMCPPGJ)
				{
					dIMKCEBGKKN.MergeFrom(KAFMKMCPPGJ);
				}
				input.ReadMessage(dIMKCEBGKKN);
				KAFMKMCPPGJ = dIMKCEBGKKN;
				break;
			}
			case 11538u:
			{
				COBPAMNPPNH cOBPAMNPPNH = new COBPAMNPPNH();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GGHBLGFOGCA)
				{
					cOBPAMNPPNH.MergeFrom(GGHBLGFOGCA);
				}
				input.ReadMessage(cOBPAMNPPNH);
				GGHBLGFOGCA = cOBPAMNPPNH;
				break;
			}
			case 11906u:
			{
				LLJODGHMADG lLJODGHMADG = new LLJODGHMADG();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NDOAGAKFMNL)
				{
					lLJODGHMADG.MergeFrom(NDOAGAKFMNL);
				}
				input.ReadMessage(lLJODGHMADG);
				NDOAGAKFMNL = lLJODGHMADG;
				break;
			}
			case 12472u:
				KFGBKEADAJG = input.ReadUInt64();
				break;
			case 12762u:
			{
				GCGFNMNAFEK gCGFNMNAFEK = new GCGFNMNAFEK();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PDHEBCMOADM)
				{
					gCGFNMNAFEK.MergeFrom(PDHEBCMOADM);
				}
				input.ReadMessage(gCGFNMNAFEK);
				PDHEBCMOADM = gCGFNMNAFEK;
				break;
			}
			case 13154u:
			{
				EPJMDNCPJME ePJMDNCPJME = new EPJMDNCPJME();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KDCHCIFBOMG)
				{
					ePJMDNCPJME.MergeFrom(KDCHCIFBOMG);
				}
				input.ReadMessage(ePJMDNCPJME);
				KDCHCIFBOMG = ePJMDNCPJME;
				break;
			}
			case 14416u:
				FinishPendingActionPos = input.ReadUInt32();
				break;
			case 15410u:
			{
				FLGENHNODNI fLGENHNODNI = new FLGENHNODNI();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.BOHGEGCEGDH)
				{
					fLGENHNODNI.MergeFrom(BOHGEGCEGDH);
				}
				input.ReadMessage(fLGENHNODNI);
				BOHGEGCEGDH = fLGENHNODNI;
				break;
			}
			}
		}
	}
}
