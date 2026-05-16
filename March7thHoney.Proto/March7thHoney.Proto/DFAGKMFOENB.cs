using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFAGKMFOENB : IMessage<DFAGKMFOENB>, IMessage, IEquatable<DFAGKMFOENB>, IDeepCloneable<DFAGKMFOENB>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		LMIICENMOBI = 8,
		PJFKJHLAAPF = 14,
		OAMPHBHNNBK = 32,
		ADEHMLEICHL = 36,
		NEHOMOBBPEN = 41,
		AOGMPAJBFBH = 213,
		AHLMICKLGHP = 215,
		AIFJPNDMACI = 289,
		BGHMFOMMLOH = 291,
		PMGCGIGPNFG = 294,
		NFPKFFCHLHF = 301,
		HHPMJNKNKHN = 302,
		NGGADJOOMEK = 400,
		NMELOCJNOAP = 440,
		FBFHMKCFBPD = 456,
		LPILMOECPLA = 469,
		KECBLOHENKO = 477,
		EGKOIJHKNFE = 499,
		AACOABBJHKO = 600,
		PKINLGBPHBP = 755,
		OMFBJPDFDBJ = 790,
		AFENAIBNKGI = 803,
		EIMAFPEBCAE = 877,
		CEFGOMFNHGO = 996,
		JEEKEIGMDJN = 1095,
		KIIDBLFLAJN = 1097,
		GAFENFCGIFK = 1153,
		JNKFEGHCABK = 1222,
		MDGJHBJPDJH = 1257,
		IMJNJFCCJPC = 1292,
		HNLAEIBDFJM = 1294,
		GEEMCLCCFCN = 1309,
		IDCGKOMADPL = 1457,
		COIKELCNIIP = 1492,
		EIOKOADEOFC = 1580,
		HPGEDIAGCLI = 1596,
		AGKGMLOMDGE = 1627,
		NKLCEHNFCKM = 1650,
		BJCFPBDCCBG = 1733,
		OMKLLPFPABL = 1955,
		NHLCPDMOFLA = 1965
	}

	private static readonly MessageParser<DFAGKMFOENB> _parser = new MessageParser<DFAGKMFOENB>(() => new DFAGKMFOENB());

	private UnknownFieldSet _unknownFields;

	public const int LMIICENMOBIFieldNumber = 8;

	public const int PJFKJHLAAPFFieldNumber = 14;

	public const int OAMPHBHNNBKFieldNumber = 32;

	public const int ADEHMLEICHLFieldNumber = 36;

	public const int NEHOMOBBPENFieldNumber = 41;

	public const int AOGMPAJBFBHFieldNumber = 213;

	public const int AHLMICKLGHPFieldNumber = 215;

	public const int AIFJPNDMACIFieldNumber = 289;

	public const int BGHMFOMMLOHFieldNumber = 291;

	public const int PMGCGIGPNFGFieldNumber = 294;

	public const int NFPKFFCHLHFFieldNumber = 301;

	public const int HHPMJNKNKHNFieldNumber = 302;

	public const int NGGADJOOMEKFieldNumber = 400;

	public const int NMELOCJNOAPFieldNumber = 440;

	public const int FBFHMKCFBPDFieldNumber = 456;

	public const int LPILMOECPLAFieldNumber = 469;

	public const int KECBLOHENKOFieldNumber = 477;

	public const int EGKOIJHKNFEFieldNumber = 499;

	public const int AACOABBJHKOFieldNumber = 600;

	public const int PKINLGBPHBPFieldNumber = 755;

	public const int OMFBJPDFDBJFieldNumber = 790;

	public const int AFENAIBNKGIFieldNumber = 803;

	public const int EIMAFPEBCAEFieldNumber = 877;

	public const int CEFGOMFNHGOFieldNumber = 996;

	public const int JEEKEIGMDJNFieldNumber = 1095;

	public const int KIIDBLFLAJNFieldNumber = 1097;

	public const int GAFENFCGIFKFieldNumber = 1153;

	public const int JNKFEGHCABKFieldNumber = 1222;

	public const int MDGJHBJPDJHFieldNumber = 1257;

	public const int IMJNJFCCJPCFieldNumber = 1292;

	public const int HNLAEIBDFJMFieldNumber = 1294;

	public const int GEEMCLCCFCNFieldNumber = 1309;

	public const int IDCGKOMADPLFieldNumber = 1457;

	public const int COIKELCNIIPFieldNumber = 1492;

	public const int EIOKOADEOFCFieldNumber = 1580;

	public const int HPGEDIAGCLIFieldNumber = 1596;

	public const int AGKGMLOMDGEFieldNumber = 1627;

	public const int NKLCEHNFCKMFieldNumber = 1650;

	public const int BJCFPBDCCBGFieldNumber = 1733;

	public const int OMKLLPFPABLFieldNumber = 1955;

	public const int NHLCPDMOFLAFieldNumber = 1965;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFAGKMFOENB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFAGKMFOENBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAFOOOIKFOF LMIICENMOBI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LMIICENMOBI)
			{
				return null;
			}
			return (PAFOOOIKFOF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LMIICENMOBI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAFOOOIKFOF PJFKJHLAAPF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PJFKJHLAAPF)
			{
				return null;
			}
			return (PAFOOOIKFOF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PJFKJHLAAPF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABABHKAGHEJ OAMPHBHNNBK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OAMPHBHNNBK)
			{
				return null;
			}
			return (ABABHKAGHEJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OAMPHBHNNBK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJIIPFCMJCJ ADEHMLEICHL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ADEHMLEICHL)
			{
				return null;
			}
			return (FJIIPFCMJCJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ADEHMLEICHL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNMGDLDLMLJ NEHOMOBBPEN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NEHOMOBBPEN)
			{
				return null;
			}
			return (FNMGDLDLMLJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NEHOMOBBPEN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJGFDIKDIHO AOGMPAJBFBH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AOGMPAJBFBH)
			{
				return null;
			}
			return (HJGFDIKDIHO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AOGMPAJBFBH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED AHLMICKLGHP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AHLMICKLGHP)
			{
				return null;
			}
			return (KHHHFHEODED)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AHLMICKLGHP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDHMNEJBOEB AIFJPNDMACI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AIFJPNDMACI)
			{
				return null;
			}
			return (FDHMNEJBOEB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AIFJPNDMACI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBDBNDEAPMN BGHMFOMMLOH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BGHMFOMMLOH)
			{
				return null;
			}
			return (NBDBNDEAPMN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BGHMFOMMLOH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED PMGCGIGPNFG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PMGCGIGPNFG)
			{
				return null;
			}
			return (KHHHFHEODED)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PMGCGIGPNFG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFPKKEMKKPO NFPKFFCHLHF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NFPKFFCHLHF)
			{
				return null;
			}
			return (CFPKKEMKKPO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NFPKFFCHLHF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECIILPLNPHJ HHPMJNKNKHN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HHPMJNKNKHN)
			{
				return null;
			}
			return (ECIILPLNPHJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HHPMJNKNKHN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHHKGHEGJOG NGGADJOOMEK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NGGADJOOMEK)
			{
				return null;
			}
			return (OHHKGHEGJOG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NGGADJOOMEK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGNCGFBCNHP NMELOCJNOAP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NMELOCJNOAP)
			{
				return null;
			}
			return (CGNCGFBCNHP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NMELOCJNOAP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEMNHGMPMPD FBFHMKCFBPD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FBFHMKCFBPD)
			{
				return null;
			}
			return (OEMNHGMPMPD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FBFHMKCFBPD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFAFDPGCEPO LPILMOECPLA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LPILMOECPLA)
			{
				return null;
			}
			return (OFAFDPGCEPO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LPILMOECPLA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEIOIDGJCIL KECBLOHENKO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KECBLOHENKO)
			{
				return null;
			}
			return (EEIOIDGJCIL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KECBLOHENKO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOPKIOKGEBP EGKOIJHKNFE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EGKOIJHKNFE)
			{
				return null;
			}
			return (HOPKIOKGEBP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EGKOIJHKNFE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCFKHLNHMAJ AACOABBJHKO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AACOABBJHKO)
			{
				return null;
			}
			return (NCFKHLNHMAJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AACOABBJHKO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIIOLIIOGIG PKINLGBPHBP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PKINLGBPHBP)
			{
				return null;
			}
			return (MIIOLIIOGIG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PKINLGBPHBP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCEBFJEEFOL OMFBJPDFDBJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OMFBJPDFDBJ)
			{
				return null;
			}
			return (GCEBFJEEFOL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OMFBJPDFDBJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOMNPCJECBH AFENAIBNKGI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AFENAIBNKGI)
			{
				return null;
			}
			return (HOMNPCJECBH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AFENAIBNKGI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLFNGEJOHC EIMAFPEBCAE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EIMAFPEBCAE)
			{
				return null;
			}
			return (DMLFNGEJOHC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EIMAFPEBCAE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEELJKHDLDH CEFGOMFNHGO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CEFGOMFNHGO)
			{
				return null;
			}
			return (DEELJKHDLDH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CEFGOMFNHGO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED JEEKEIGMDJN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JEEKEIGMDJN)
			{
				return null;
			}
			return (KHHHFHEODED)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JEEKEIGMDJN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAEINLJIBPB KIIDBLFLAJN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KIIDBLFLAJN)
			{
				return null;
			}
			return (CAEINLJIBPB)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KIIDBLFLAJN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEECFCALMFN GAFENFCGIFK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GAFENFCGIFK)
			{
				return null;
			}
			return (DEECFCALMFN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GAFENFCGIFK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCIJHCFBGKG JNKFEGHCABK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JNKFEGHCABK)
			{
				return null;
			}
			return (JCIJHCFBGKG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JNKFEGHCABK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAEOAGNKNBL MDGJHBJPDJH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MDGJHBJPDJH)
			{
				return null;
			}
			return (JAEOAGNKNBL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MDGJHBJPDJH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEMAIGNDNPK IMJNJFCCJPC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IMJNJFCCJPC)
			{
				return null;
			}
			return (GEMAIGNDNPK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IMJNJFCCJPC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJGFDIKDIHO HNLAEIBDFJM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HNLAEIBDFJM)
			{
				return null;
			}
			return (HJGFDIKDIHO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HNLAEIBDFJM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPEJGPJNECF GEEMCLCCFCN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GEEMCLCCFCN)
			{
				return null;
			}
			return (GPEJGPJNECF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GEEMCLCCFCN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGMCJLBNNLF IDCGKOMADPL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IDCGKOMADPL)
			{
				return null;
			}
			return (PGMCJLBNNLF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IDCGKOMADPL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFGJBNMFDC COIKELCNIIP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.COIKELCNIIP)
			{
				return null;
			}
			return (ACFGJBNMFDC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.COIKELCNIIP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOGGIDNINJP EIOKOADEOFC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EIOKOADEOFC)
			{
				return null;
			}
			return (DOGGIDNINJP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EIOKOADEOFC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDEHDNAOKBC HPGEDIAGCLI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HPGEDIAGCLI)
			{
				return null;
			}
			return (PDEHDNAOKBC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HPGEDIAGCLI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBKAPDCECDN AGKGMLOMDGE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AGKGMLOMDGE)
			{
				return null;
			}
			return (BBKAPDCECDN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AGKGMLOMDGE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDEHDNAOKBC NKLCEHNFCKM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NKLCEHNFCKM)
			{
				return null;
			}
			return (PDEHDNAOKBC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NKLCEHNFCKM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILIFCCNAPH BJCFPBDCCBG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BJCFPBDCCBG)
			{
				return null;
			}
			return (FILIFCCNAPH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BJCFPBDCCBG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFEENNNCBL OMKLLPFPABL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OMKLLPFPABL)
			{
				return null;
			}
			return (JCFEENNNCBL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OMKLLPFPABL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNBKKPOLLAA NHLCPDMOFLA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NHLCPDMOFLA)
			{
				return null;
			}
			return (GNBKKPOLLAA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NHLCPDMOFLA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAGKMFOENB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAGKMFOENB(DFAGKMFOENB other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.LMIICENMOBI:
			LMIICENMOBI = other.LMIICENMOBI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PJFKJHLAAPF:
			PJFKJHLAAPF = other.PJFKJHLAAPF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OAMPHBHNNBK:
			OAMPHBHNNBK = other.OAMPHBHNNBK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ADEHMLEICHL:
			ADEHMLEICHL = other.ADEHMLEICHL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NEHOMOBBPEN:
			NEHOMOBBPEN = other.NEHOMOBBPEN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AOGMPAJBFBH:
			AOGMPAJBFBH = other.AOGMPAJBFBH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AHLMICKLGHP:
			AHLMICKLGHP = other.AHLMICKLGHP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AIFJPNDMACI:
			AIFJPNDMACI = other.AIFJPNDMACI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BGHMFOMMLOH:
			BGHMFOMMLOH = other.BGHMFOMMLOH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PMGCGIGPNFG:
			PMGCGIGPNFG = other.PMGCGIGPNFG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NFPKFFCHLHF:
			NFPKFFCHLHF = other.NFPKFFCHLHF.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HHPMJNKNKHN:
			HHPMJNKNKHN = other.HHPMJNKNKHN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NGGADJOOMEK:
			NGGADJOOMEK = other.NGGADJOOMEK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NMELOCJNOAP:
			NMELOCJNOAP = other.NMELOCJNOAP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FBFHMKCFBPD:
			FBFHMKCFBPD = other.FBFHMKCFBPD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LPILMOECPLA:
			LPILMOECPLA = other.LPILMOECPLA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KECBLOHENKO:
			KECBLOHENKO = other.KECBLOHENKO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EGKOIJHKNFE:
			EGKOIJHKNFE = other.EGKOIJHKNFE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AACOABBJHKO:
			AACOABBJHKO = other.AACOABBJHKO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PKINLGBPHBP:
			PKINLGBPHBP = other.PKINLGBPHBP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OMFBJPDFDBJ:
			OMFBJPDFDBJ = other.OMFBJPDFDBJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AFENAIBNKGI:
			AFENAIBNKGI = other.AFENAIBNKGI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EIMAFPEBCAE:
			EIMAFPEBCAE = other.EIMAFPEBCAE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CEFGOMFNHGO:
			CEFGOMFNHGO = other.CEFGOMFNHGO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JEEKEIGMDJN:
			JEEKEIGMDJN = other.JEEKEIGMDJN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KIIDBLFLAJN:
			KIIDBLFLAJN = other.KIIDBLFLAJN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GAFENFCGIFK:
			GAFENFCGIFK = other.GAFENFCGIFK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JNKFEGHCABK:
			JNKFEGHCABK = other.JNKFEGHCABK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MDGJHBJPDJH:
			MDGJHBJPDJH = other.MDGJHBJPDJH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IMJNJFCCJPC:
			IMJNJFCCJPC = other.IMJNJFCCJPC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HNLAEIBDFJM:
			HNLAEIBDFJM = other.HNLAEIBDFJM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GEEMCLCCFCN:
			GEEMCLCCFCN = other.GEEMCLCCFCN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IDCGKOMADPL:
			IDCGKOMADPL = other.IDCGKOMADPL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.COIKELCNIIP:
			COIKELCNIIP = other.COIKELCNIIP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EIOKOADEOFC:
			EIOKOADEOFC = other.EIOKOADEOFC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HPGEDIAGCLI:
			HPGEDIAGCLI = other.HPGEDIAGCLI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AGKGMLOMDGE:
			AGKGMLOMDGE = other.AGKGMLOMDGE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NKLCEHNFCKM:
			NKLCEHNFCKM = other.NKLCEHNFCKM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BJCFPBDCCBG:
			BJCFPBDCCBG = other.BJCFPBDCCBG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OMKLLPFPABL:
			OMKLLPFPABL = other.OMKLLPFPABL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NHLCPDMOFLA:
			NHLCPDMOFLA = other.NHLCPDMOFLA.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAGKMFOENB Clone()
	{
		return new DFAGKMFOENB(this);
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
		return Equals(other as DFAGKMFOENB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFAGKMFOENB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LMIICENMOBI, other.LMIICENMOBI))
		{
			return false;
		}
		if (!object.Equals(PJFKJHLAAPF, other.PJFKJHLAAPF))
		{
			return false;
		}
		if (!object.Equals(OAMPHBHNNBK, other.OAMPHBHNNBK))
		{
			return false;
		}
		if (!object.Equals(ADEHMLEICHL, other.ADEHMLEICHL))
		{
			return false;
		}
		if (!object.Equals(NEHOMOBBPEN, other.NEHOMOBBPEN))
		{
			return false;
		}
		if (!object.Equals(AOGMPAJBFBH, other.AOGMPAJBFBH))
		{
			return false;
		}
		if (!object.Equals(AHLMICKLGHP, other.AHLMICKLGHP))
		{
			return false;
		}
		if (!object.Equals(AIFJPNDMACI, other.AIFJPNDMACI))
		{
			return false;
		}
		if (!object.Equals(BGHMFOMMLOH, other.BGHMFOMMLOH))
		{
			return false;
		}
		if (!object.Equals(PMGCGIGPNFG, other.PMGCGIGPNFG))
		{
			return false;
		}
		if (!object.Equals(NFPKFFCHLHF, other.NFPKFFCHLHF))
		{
			return false;
		}
		if (!object.Equals(HHPMJNKNKHN, other.HHPMJNKNKHN))
		{
			return false;
		}
		if (!object.Equals(NGGADJOOMEK, other.NGGADJOOMEK))
		{
			return false;
		}
		if (!object.Equals(NMELOCJNOAP, other.NMELOCJNOAP))
		{
			return false;
		}
		if (!object.Equals(FBFHMKCFBPD, other.FBFHMKCFBPD))
		{
			return false;
		}
		if (!object.Equals(LPILMOECPLA, other.LPILMOECPLA))
		{
			return false;
		}
		if (!object.Equals(KECBLOHENKO, other.KECBLOHENKO))
		{
			return false;
		}
		if (!object.Equals(EGKOIJHKNFE, other.EGKOIJHKNFE))
		{
			return false;
		}
		if (!object.Equals(AACOABBJHKO, other.AACOABBJHKO))
		{
			return false;
		}
		if (!object.Equals(PKINLGBPHBP, other.PKINLGBPHBP))
		{
			return false;
		}
		if (!object.Equals(OMFBJPDFDBJ, other.OMFBJPDFDBJ))
		{
			return false;
		}
		if (!object.Equals(AFENAIBNKGI, other.AFENAIBNKGI))
		{
			return false;
		}
		if (!object.Equals(EIMAFPEBCAE, other.EIMAFPEBCAE))
		{
			return false;
		}
		if (!object.Equals(CEFGOMFNHGO, other.CEFGOMFNHGO))
		{
			return false;
		}
		if (!object.Equals(JEEKEIGMDJN, other.JEEKEIGMDJN))
		{
			return false;
		}
		if (!object.Equals(KIIDBLFLAJN, other.KIIDBLFLAJN))
		{
			return false;
		}
		if (!object.Equals(GAFENFCGIFK, other.GAFENFCGIFK))
		{
			return false;
		}
		if (!object.Equals(JNKFEGHCABK, other.JNKFEGHCABK))
		{
			return false;
		}
		if (!object.Equals(MDGJHBJPDJH, other.MDGJHBJPDJH))
		{
			return false;
		}
		if (!object.Equals(IMJNJFCCJPC, other.IMJNJFCCJPC))
		{
			return false;
		}
		if (!object.Equals(HNLAEIBDFJM, other.HNLAEIBDFJM))
		{
			return false;
		}
		if (!object.Equals(GEEMCLCCFCN, other.GEEMCLCCFCN))
		{
			return false;
		}
		if (!object.Equals(IDCGKOMADPL, other.IDCGKOMADPL))
		{
			return false;
		}
		if (!object.Equals(COIKELCNIIP, other.COIKELCNIIP))
		{
			return false;
		}
		if (!object.Equals(EIOKOADEOFC, other.EIOKOADEOFC))
		{
			return false;
		}
		if (!object.Equals(HPGEDIAGCLI, other.HPGEDIAGCLI))
		{
			return false;
		}
		if (!object.Equals(AGKGMLOMDGE, other.AGKGMLOMDGE))
		{
			return false;
		}
		if (!object.Equals(NKLCEHNFCKM, other.NKLCEHNFCKM))
		{
			return false;
		}
		if (!object.Equals(BJCFPBDCCBG, other.BJCFPBDCCBG))
		{
			return false;
		}
		if (!object.Equals(OMKLLPFPABL, other.OMKLLPFPABL))
		{
			return false;
		}
		if (!object.Equals(NHLCPDMOFLA, other.NHLCPDMOFLA))
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMIICENMOBI)
		{
			num ^= LMIICENMOBI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJFKJHLAAPF)
		{
			num ^= PJFKJHLAAPF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OAMPHBHNNBK)
		{
			num ^= OAMPHBHNNBK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ADEHMLEICHL)
		{
			num ^= ADEHMLEICHL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEHOMOBBPEN)
		{
			num ^= NEHOMOBBPEN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AOGMPAJBFBH)
		{
			num ^= AOGMPAJBFBH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHLMICKLGHP)
		{
			num ^= AHLMICKLGHP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AIFJPNDMACI)
		{
			num ^= AIFJPNDMACI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BGHMFOMMLOH)
		{
			num ^= BGHMFOMMLOH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PMGCGIGPNFG)
		{
			num ^= PMGCGIGPNFG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NFPKFFCHLHF)
		{
			num ^= NFPKFFCHLHF.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HHPMJNKNKHN)
		{
			num ^= HHPMJNKNKHN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGGADJOOMEK)
		{
			num ^= NGGADJOOMEK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NMELOCJNOAP)
		{
			num ^= NMELOCJNOAP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBFHMKCFBPD)
		{
			num ^= FBFHMKCFBPD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LPILMOECPLA)
		{
			num ^= LPILMOECPLA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KECBLOHENKO)
		{
			num ^= KECBLOHENKO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGKOIJHKNFE)
		{
			num ^= EGKOIJHKNFE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AACOABBJHKO)
		{
			num ^= AACOABBJHKO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKINLGBPHBP)
		{
			num ^= PKINLGBPHBP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMFBJPDFDBJ)
		{
			num ^= OMFBJPDFDBJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFENAIBNKGI)
		{
			num ^= AFENAIBNKGI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIMAFPEBCAE)
		{
			num ^= EIMAFPEBCAE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEFGOMFNHGO)
		{
			num ^= CEFGOMFNHGO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEEKEIGMDJN)
		{
			num ^= JEEKEIGMDJN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIIDBLFLAJN)
		{
			num ^= KIIDBLFLAJN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAFENFCGIFK)
		{
			num ^= GAFENFCGIFK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKFEGHCABK)
		{
			num ^= JNKFEGHCABK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MDGJHBJPDJH)
		{
			num ^= MDGJHBJPDJH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMJNJFCCJPC)
		{
			num ^= IMJNJFCCJPC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HNLAEIBDFJM)
		{
			num ^= HNLAEIBDFJM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GEEMCLCCFCN)
		{
			num ^= GEEMCLCCFCN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IDCGKOMADPL)
		{
			num ^= IDCGKOMADPL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.COIKELCNIIP)
		{
			num ^= COIKELCNIIP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIOKOADEOFC)
		{
			num ^= EIOKOADEOFC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HPGEDIAGCLI)
		{
			num ^= HPGEDIAGCLI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGKGMLOMDGE)
		{
			num ^= AGKGMLOMDGE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKLCEHNFCKM)
		{
			num ^= NKLCEHNFCKM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BJCFPBDCCBG)
		{
			num ^= BJCFPBDCCBG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMKLLPFPABL)
		{
			num ^= OMKLLPFPABL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHLCPDMOFLA)
		{
			num ^= NHLCPDMOFLA.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMIICENMOBI)
		{
			output.WriteRawTag(66);
			output.WriteMessage(LMIICENMOBI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJFKJHLAAPF)
		{
			output.WriteRawTag(114);
			output.WriteMessage(PJFKJHLAAPF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OAMPHBHNNBK)
		{
			output.WriteRawTag(130, 2);
			output.WriteMessage(OAMPHBHNNBK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ADEHMLEICHL)
		{
			output.WriteRawTag(162, 2);
			output.WriteMessage(ADEHMLEICHL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEHOMOBBPEN)
		{
			output.WriteRawTag(202, 2);
			output.WriteMessage(NEHOMOBBPEN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AOGMPAJBFBH)
		{
			output.WriteRawTag(170, 13);
			output.WriteMessage(AOGMPAJBFBH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHLMICKLGHP)
		{
			output.WriteRawTag(186, 13);
			output.WriteMessage(AHLMICKLGHP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AIFJPNDMACI)
		{
			output.WriteRawTag(138, 18);
			output.WriteMessage(AIFJPNDMACI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BGHMFOMMLOH)
		{
			output.WriteRawTag(154, 18);
			output.WriteMessage(BGHMFOMMLOH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PMGCGIGPNFG)
		{
			output.WriteRawTag(178, 18);
			output.WriteMessage(PMGCGIGPNFG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NFPKFFCHLHF)
		{
			output.WriteRawTag(234, 18);
			output.WriteMessage(NFPKFFCHLHF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HHPMJNKNKHN)
		{
			output.WriteRawTag(242, 18);
			output.WriteMessage(HHPMJNKNKHN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGGADJOOMEK)
		{
			output.WriteRawTag(130, 25);
			output.WriteMessage(NGGADJOOMEK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NMELOCJNOAP)
		{
			output.WriteRawTag(194, 27);
			output.WriteMessage(NMELOCJNOAP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBFHMKCFBPD)
		{
			output.WriteRawTag(194, 28);
			output.WriteMessage(FBFHMKCFBPD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LPILMOECPLA)
		{
			output.WriteRawTag(170, 29);
			output.WriteMessage(LPILMOECPLA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KECBLOHENKO)
		{
			output.WriteRawTag(234, 29);
			output.WriteMessage(KECBLOHENKO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGKOIJHKNFE)
		{
			output.WriteRawTag(154, 31);
			output.WriteMessage(EGKOIJHKNFE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AACOABBJHKO)
		{
			output.WriteRawTag(194, 37);
			output.WriteMessage(AACOABBJHKO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKINLGBPHBP)
		{
			output.WriteRawTag(154, 47);
			output.WriteMessage(PKINLGBPHBP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMFBJPDFDBJ)
		{
			output.WriteRawTag(178, 49);
			output.WriteMessage(OMFBJPDFDBJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFENAIBNKGI)
		{
			output.WriteRawTag(154, 50);
			output.WriteMessage(AFENAIBNKGI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIMAFPEBCAE)
		{
			output.WriteRawTag(234, 54);
			output.WriteMessage(EIMAFPEBCAE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEFGOMFNHGO)
		{
			output.WriteRawTag(162, 62);
			output.WriteMessage(CEFGOMFNHGO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEEKEIGMDJN)
		{
			output.WriteRawTag(186, 68);
			output.WriteMessage(JEEKEIGMDJN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIIDBLFLAJN)
		{
			output.WriteRawTag(202, 68);
			output.WriteMessage(KIIDBLFLAJN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAFENFCGIFK)
		{
			output.WriteRawTag(138, 72);
			output.WriteMessage(GAFENFCGIFK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKFEGHCABK)
		{
			output.WriteRawTag(178, 76);
			output.WriteMessage(JNKFEGHCABK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MDGJHBJPDJH)
		{
			output.WriteRawTag(202, 78);
			output.WriteMessage(MDGJHBJPDJH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMJNJFCCJPC)
		{
			output.WriteRawTag(226, 80);
			output.WriteMessage(IMJNJFCCJPC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HNLAEIBDFJM)
		{
			output.WriteRawTag(242, 80);
			output.WriteMessage(HNLAEIBDFJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GEEMCLCCFCN)
		{
			output.WriteRawTag(234, 81);
			output.WriteMessage(GEEMCLCCFCN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IDCGKOMADPL)
		{
			output.WriteRawTag(138, 91);
			output.WriteMessage(IDCGKOMADPL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.COIKELCNIIP)
		{
			output.WriteRawTag(162, 93);
			output.WriteMessage(COIKELCNIIP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIOKOADEOFC)
		{
			output.WriteRawTag(226, 98);
			output.WriteMessage(EIOKOADEOFC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HPGEDIAGCLI)
		{
			output.WriteRawTag(226, 99);
			output.WriteMessage(HPGEDIAGCLI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGKGMLOMDGE)
		{
			output.WriteRawTag(218, 101);
			output.WriteMessage(AGKGMLOMDGE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKLCEHNFCKM)
		{
			output.WriteRawTag(146, 103);
			output.WriteMessage(NKLCEHNFCKM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BJCFPBDCCBG)
		{
			output.WriteRawTag(170, 108);
			output.WriteMessage(BJCFPBDCCBG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMKLLPFPABL)
		{
			output.WriteRawTag(154, 122);
			output.WriteMessage(OMKLLPFPABL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHLCPDMOFLA)
		{
			output.WriteRawTag(234, 122);
			output.WriteMessage(NHLCPDMOFLA);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMIICENMOBI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LMIICENMOBI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJFKJHLAAPF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJFKJHLAAPF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OAMPHBHNNBK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OAMPHBHNNBK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ADEHMLEICHL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ADEHMLEICHL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEHOMOBBPEN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NEHOMOBBPEN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AOGMPAJBFBH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AOGMPAJBFBH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHLMICKLGHP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AHLMICKLGHP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AIFJPNDMACI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AIFJPNDMACI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BGHMFOMMLOH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BGHMFOMMLOH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PMGCGIGPNFG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PMGCGIGPNFG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NFPKFFCHLHF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NFPKFFCHLHF);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HHPMJNKNKHN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HHPMJNKNKHN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGGADJOOMEK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NGGADJOOMEK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NMELOCJNOAP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NMELOCJNOAP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBFHMKCFBPD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FBFHMKCFBPD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LPILMOECPLA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LPILMOECPLA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KECBLOHENKO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KECBLOHENKO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGKOIJHKNFE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EGKOIJHKNFE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AACOABBJHKO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AACOABBJHKO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKINLGBPHBP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PKINLGBPHBP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMFBJPDFDBJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OMFBJPDFDBJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFENAIBNKGI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AFENAIBNKGI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIMAFPEBCAE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EIMAFPEBCAE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEFGOMFNHGO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CEFGOMFNHGO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEEKEIGMDJN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JEEKEIGMDJN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIIDBLFLAJN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KIIDBLFLAJN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAFENFCGIFK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GAFENFCGIFK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKFEGHCABK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JNKFEGHCABK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MDGJHBJPDJH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MDGJHBJPDJH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMJNJFCCJPC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IMJNJFCCJPC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HNLAEIBDFJM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HNLAEIBDFJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GEEMCLCCFCN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GEEMCLCCFCN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IDCGKOMADPL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IDCGKOMADPL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.COIKELCNIIP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(COIKELCNIIP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIOKOADEOFC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EIOKOADEOFC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HPGEDIAGCLI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HPGEDIAGCLI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGKGMLOMDGE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AGKGMLOMDGE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKLCEHNFCKM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NKLCEHNFCKM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BJCFPBDCCBG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BJCFPBDCCBG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMKLLPFPABL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OMKLLPFPABL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHLCPDMOFLA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NHLCPDMOFLA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DFAGKMFOENB other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.LMIICENMOBI:
			if (LMIICENMOBI == null)
			{
				LMIICENMOBI = new PAFOOOIKFOF();
			}
			LMIICENMOBI.MergeFrom(other.LMIICENMOBI);
			break;
		case BPIHFAJCLOCOneofCase.PJFKJHLAAPF:
			if (PJFKJHLAAPF == null)
			{
				PJFKJHLAAPF = new PAFOOOIKFOF();
			}
			PJFKJHLAAPF.MergeFrom(other.PJFKJHLAAPF);
			break;
		case BPIHFAJCLOCOneofCase.OAMPHBHNNBK:
			if (OAMPHBHNNBK == null)
			{
				OAMPHBHNNBK = new ABABHKAGHEJ();
			}
			OAMPHBHNNBK.MergeFrom(other.OAMPHBHNNBK);
			break;
		case BPIHFAJCLOCOneofCase.ADEHMLEICHL:
			if (ADEHMLEICHL == null)
			{
				ADEHMLEICHL = new FJIIPFCMJCJ();
			}
			ADEHMLEICHL.MergeFrom(other.ADEHMLEICHL);
			break;
		case BPIHFAJCLOCOneofCase.NEHOMOBBPEN:
			if (NEHOMOBBPEN == null)
			{
				NEHOMOBBPEN = new FNMGDLDLMLJ();
			}
			NEHOMOBBPEN.MergeFrom(other.NEHOMOBBPEN);
			break;
		case BPIHFAJCLOCOneofCase.AOGMPAJBFBH:
			if (AOGMPAJBFBH == null)
			{
				AOGMPAJBFBH = new HJGFDIKDIHO();
			}
			AOGMPAJBFBH.MergeFrom(other.AOGMPAJBFBH);
			break;
		case BPIHFAJCLOCOneofCase.AHLMICKLGHP:
			if (AHLMICKLGHP == null)
			{
				AHLMICKLGHP = new KHHHFHEODED();
			}
			AHLMICKLGHP.MergeFrom(other.AHLMICKLGHP);
			break;
		case BPIHFAJCLOCOneofCase.AIFJPNDMACI:
			if (AIFJPNDMACI == null)
			{
				AIFJPNDMACI = new FDHMNEJBOEB();
			}
			AIFJPNDMACI.MergeFrom(other.AIFJPNDMACI);
			break;
		case BPIHFAJCLOCOneofCase.BGHMFOMMLOH:
			if (BGHMFOMMLOH == null)
			{
				BGHMFOMMLOH = new NBDBNDEAPMN();
			}
			BGHMFOMMLOH.MergeFrom(other.BGHMFOMMLOH);
			break;
		case BPIHFAJCLOCOneofCase.PMGCGIGPNFG:
			if (PMGCGIGPNFG == null)
			{
				PMGCGIGPNFG = new KHHHFHEODED();
			}
			PMGCGIGPNFG.MergeFrom(other.PMGCGIGPNFG);
			break;
		case BPIHFAJCLOCOneofCase.NFPKFFCHLHF:
			if (NFPKFFCHLHF == null)
			{
				NFPKFFCHLHF = new CFPKKEMKKPO();
			}
			NFPKFFCHLHF.MergeFrom(other.NFPKFFCHLHF);
			break;
		case BPIHFAJCLOCOneofCase.HHPMJNKNKHN:
			if (HHPMJNKNKHN == null)
			{
				HHPMJNKNKHN = new ECIILPLNPHJ();
			}
			HHPMJNKNKHN.MergeFrom(other.HHPMJNKNKHN);
			break;
		case BPIHFAJCLOCOneofCase.NGGADJOOMEK:
			if (NGGADJOOMEK == null)
			{
				NGGADJOOMEK = new OHHKGHEGJOG();
			}
			NGGADJOOMEK.MergeFrom(other.NGGADJOOMEK);
			break;
		case BPIHFAJCLOCOneofCase.NMELOCJNOAP:
			if (NMELOCJNOAP == null)
			{
				NMELOCJNOAP = new CGNCGFBCNHP();
			}
			NMELOCJNOAP.MergeFrom(other.NMELOCJNOAP);
			break;
		case BPIHFAJCLOCOneofCase.FBFHMKCFBPD:
			if (FBFHMKCFBPD == null)
			{
				FBFHMKCFBPD = new OEMNHGMPMPD();
			}
			FBFHMKCFBPD.MergeFrom(other.FBFHMKCFBPD);
			break;
		case BPIHFAJCLOCOneofCase.LPILMOECPLA:
			if (LPILMOECPLA == null)
			{
				LPILMOECPLA = new OFAFDPGCEPO();
			}
			LPILMOECPLA.MergeFrom(other.LPILMOECPLA);
			break;
		case BPIHFAJCLOCOneofCase.KECBLOHENKO:
			if (KECBLOHENKO == null)
			{
				KECBLOHENKO = new EEIOIDGJCIL();
			}
			KECBLOHENKO.MergeFrom(other.KECBLOHENKO);
			break;
		case BPIHFAJCLOCOneofCase.EGKOIJHKNFE:
			if (EGKOIJHKNFE == null)
			{
				EGKOIJHKNFE = new HOPKIOKGEBP();
			}
			EGKOIJHKNFE.MergeFrom(other.EGKOIJHKNFE);
			break;
		case BPIHFAJCLOCOneofCase.AACOABBJHKO:
			if (AACOABBJHKO == null)
			{
				AACOABBJHKO = new NCFKHLNHMAJ();
			}
			AACOABBJHKO.MergeFrom(other.AACOABBJHKO);
			break;
		case BPIHFAJCLOCOneofCase.PKINLGBPHBP:
			if (PKINLGBPHBP == null)
			{
				PKINLGBPHBP = new MIIOLIIOGIG();
			}
			PKINLGBPHBP.MergeFrom(other.PKINLGBPHBP);
			break;
		case BPIHFAJCLOCOneofCase.OMFBJPDFDBJ:
			if (OMFBJPDFDBJ == null)
			{
				OMFBJPDFDBJ = new GCEBFJEEFOL();
			}
			OMFBJPDFDBJ.MergeFrom(other.OMFBJPDFDBJ);
			break;
		case BPIHFAJCLOCOneofCase.AFENAIBNKGI:
			if (AFENAIBNKGI == null)
			{
				AFENAIBNKGI = new HOMNPCJECBH();
			}
			AFENAIBNKGI.MergeFrom(other.AFENAIBNKGI);
			break;
		case BPIHFAJCLOCOneofCase.EIMAFPEBCAE:
			if (EIMAFPEBCAE == null)
			{
				EIMAFPEBCAE = new DMLFNGEJOHC();
			}
			EIMAFPEBCAE.MergeFrom(other.EIMAFPEBCAE);
			break;
		case BPIHFAJCLOCOneofCase.CEFGOMFNHGO:
			if (CEFGOMFNHGO == null)
			{
				CEFGOMFNHGO = new DEELJKHDLDH();
			}
			CEFGOMFNHGO.MergeFrom(other.CEFGOMFNHGO);
			break;
		case BPIHFAJCLOCOneofCase.JEEKEIGMDJN:
			if (JEEKEIGMDJN == null)
			{
				JEEKEIGMDJN = new KHHHFHEODED();
			}
			JEEKEIGMDJN.MergeFrom(other.JEEKEIGMDJN);
			break;
		case BPIHFAJCLOCOneofCase.KIIDBLFLAJN:
			if (KIIDBLFLAJN == null)
			{
				KIIDBLFLAJN = new CAEINLJIBPB();
			}
			KIIDBLFLAJN.MergeFrom(other.KIIDBLFLAJN);
			break;
		case BPIHFAJCLOCOneofCase.GAFENFCGIFK:
			if (GAFENFCGIFK == null)
			{
				GAFENFCGIFK = new DEECFCALMFN();
			}
			GAFENFCGIFK.MergeFrom(other.GAFENFCGIFK);
			break;
		case BPIHFAJCLOCOneofCase.JNKFEGHCABK:
			if (JNKFEGHCABK == null)
			{
				JNKFEGHCABK = new JCIJHCFBGKG();
			}
			JNKFEGHCABK.MergeFrom(other.JNKFEGHCABK);
			break;
		case BPIHFAJCLOCOneofCase.MDGJHBJPDJH:
			if (MDGJHBJPDJH == null)
			{
				MDGJHBJPDJH = new JAEOAGNKNBL();
			}
			MDGJHBJPDJH.MergeFrom(other.MDGJHBJPDJH);
			break;
		case BPIHFAJCLOCOneofCase.IMJNJFCCJPC:
			if (IMJNJFCCJPC == null)
			{
				IMJNJFCCJPC = new GEMAIGNDNPK();
			}
			IMJNJFCCJPC.MergeFrom(other.IMJNJFCCJPC);
			break;
		case BPIHFAJCLOCOneofCase.HNLAEIBDFJM:
			if (HNLAEIBDFJM == null)
			{
				HNLAEIBDFJM = new HJGFDIKDIHO();
			}
			HNLAEIBDFJM.MergeFrom(other.HNLAEIBDFJM);
			break;
		case BPIHFAJCLOCOneofCase.GEEMCLCCFCN:
			if (GEEMCLCCFCN == null)
			{
				GEEMCLCCFCN = new GPEJGPJNECF();
			}
			GEEMCLCCFCN.MergeFrom(other.GEEMCLCCFCN);
			break;
		case BPIHFAJCLOCOneofCase.IDCGKOMADPL:
			if (IDCGKOMADPL == null)
			{
				IDCGKOMADPL = new PGMCJLBNNLF();
			}
			IDCGKOMADPL.MergeFrom(other.IDCGKOMADPL);
			break;
		case BPIHFAJCLOCOneofCase.COIKELCNIIP:
			if (COIKELCNIIP == null)
			{
				COIKELCNIIP = new ACFGJBNMFDC();
			}
			COIKELCNIIP.MergeFrom(other.COIKELCNIIP);
			break;
		case BPIHFAJCLOCOneofCase.EIOKOADEOFC:
			if (EIOKOADEOFC == null)
			{
				EIOKOADEOFC = new DOGGIDNINJP();
			}
			EIOKOADEOFC.MergeFrom(other.EIOKOADEOFC);
			break;
		case BPIHFAJCLOCOneofCase.HPGEDIAGCLI:
			if (HPGEDIAGCLI == null)
			{
				HPGEDIAGCLI = new PDEHDNAOKBC();
			}
			HPGEDIAGCLI.MergeFrom(other.HPGEDIAGCLI);
			break;
		case BPIHFAJCLOCOneofCase.AGKGMLOMDGE:
			if (AGKGMLOMDGE == null)
			{
				AGKGMLOMDGE = new BBKAPDCECDN();
			}
			AGKGMLOMDGE.MergeFrom(other.AGKGMLOMDGE);
			break;
		case BPIHFAJCLOCOneofCase.NKLCEHNFCKM:
			if (NKLCEHNFCKM == null)
			{
				NKLCEHNFCKM = new PDEHDNAOKBC();
			}
			NKLCEHNFCKM.MergeFrom(other.NKLCEHNFCKM);
			break;
		case BPIHFAJCLOCOneofCase.BJCFPBDCCBG:
			if (BJCFPBDCCBG == null)
			{
				BJCFPBDCCBG = new FILIFCCNAPH();
			}
			BJCFPBDCCBG.MergeFrom(other.BJCFPBDCCBG);
			break;
		case BPIHFAJCLOCOneofCase.OMKLLPFPABL:
			if (OMKLLPFPABL == null)
			{
				OMKLLPFPABL = new JCFEENNNCBL();
			}
			OMKLLPFPABL.MergeFrom(other.OMKLLPFPABL);
			break;
		case BPIHFAJCLOCOneofCase.NHLCPDMOFLA:
			if (NHLCPDMOFLA == null)
			{
				NHLCPDMOFLA = new GNBKKPOLLAA();
			}
			NHLCPDMOFLA.MergeFrom(other.NHLCPDMOFLA);
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
			case 66u:
			{
				PAFOOOIKFOF pAFOOOIKFOF = new PAFOOOIKFOF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMIICENMOBI)
				{
					pAFOOOIKFOF.MergeFrom(LMIICENMOBI);
				}
				input.ReadMessage(pAFOOOIKFOF);
				LMIICENMOBI = pAFOOOIKFOF;
				break;
			}
			case 114u:
			{
				PAFOOOIKFOF pAFOOOIKFOF2 = new PAFOOOIKFOF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJFKJHLAAPF)
				{
					pAFOOOIKFOF2.MergeFrom(PJFKJHLAAPF);
				}
				input.ReadMessage(pAFOOOIKFOF2);
				PJFKJHLAAPF = pAFOOOIKFOF2;
				break;
			}
			case 258u:
			{
				ABABHKAGHEJ aBABHKAGHEJ = new ABABHKAGHEJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OAMPHBHNNBK)
				{
					aBABHKAGHEJ.MergeFrom(OAMPHBHNNBK);
				}
				input.ReadMessage(aBABHKAGHEJ);
				OAMPHBHNNBK = aBABHKAGHEJ;
				break;
			}
			case 290u:
			{
				FJIIPFCMJCJ fJIIPFCMJCJ = new FJIIPFCMJCJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ADEHMLEICHL)
				{
					fJIIPFCMJCJ.MergeFrom(ADEHMLEICHL);
				}
				input.ReadMessage(fJIIPFCMJCJ);
				ADEHMLEICHL = fJIIPFCMJCJ;
				break;
			}
			case 330u:
			{
				FNMGDLDLMLJ fNMGDLDLMLJ = new FNMGDLDLMLJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NEHOMOBBPEN)
				{
					fNMGDLDLMLJ.MergeFrom(NEHOMOBBPEN);
				}
				input.ReadMessage(fNMGDLDLMLJ);
				NEHOMOBBPEN = fNMGDLDLMLJ;
				break;
			}
			case 1706u:
			{
				HJGFDIKDIHO hJGFDIKDIHO = new HJGFDIKDIHO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AOGMPAJBFBH)
				{
					hJGFDIKDIHO.MergeFrom(AOGMPAJBFBH);
				}
				input.ReadMessage(hJGFDIKDIHO);
				AOGMPAJBFBH = hJGFDIKDIHO;
				break;
			}
			case 1722u:
			{
				KHHHFHEODED kHHHFHEODED3 = new KHHHFHEODED();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHLMICKLGHP)
				{
					kHHHFHEODED3.MergeFrom(AHLMICKLGHP);
				}
				input.ReadMessage(kHHHFHEODED3);
				AHLMICKLGHP = kHHHFHEODED3;
				break;
			}
			case 2314u:
			{
				FDHMNEJBOEB fDHMNEJBOEB = new FDHMNEJBOEB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AIFJPNDMACI)
				{
					fDHMNEJBOEB.MergeFrom(AIFJPNDMACI);
				}
				input.ReadMessage(fDHMNEJBOEB);
				AIFJPNDMACI = fDHMNEJBOEB;
				break;
			}
			case 2330u:
			{
				NBDBNDEAPMN nBDBNDEAPMN = new NBDBNDEAPMN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BGHMFOMMLOH)
				{
					nBDBNDEAPMN.MergeFrom(BGHMFOMMLOH);
				}
				input.ReadMessage(nBDBNDEAPMN);
				BGHMFOMMLOH = nBDBNDEAPMN;
				break;
			}
			case 2354u:
			{
				KHHHFHEODED kHHHFHEODED2 = new KHHHFHEODED();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PMGCGIGPNFG)
				{
					kHHHFHEODED2.MergeFrom(PMGCGIGPNFG);
				}
				input.ReadMessage(kHHHFHEODED2);
				PMGCGIGPNFG = kHHHFHEODED2;
				break;
			}
			case 2410u:
			{
				CFPKKEMKKPO cFPKKEMKKPO = new CFPKKEMKKPO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NFPKFFCHLHF)
				{
					cFPKKEMKKPO.MergeFrom(NFPKFFCHLHF);
				}
				input.ReadMessage(cFPKKEMKKPO);
				NFPKFFCHLHF = cFPKKEMKKPO;
				break;
			}
			case 2418u:
			{
				ECIILPLNPHJ eCIILPLNPHJ = new ECIILPLNPHJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HHPMJNKNKHN)
				{
					eCIILPLNPHJ.MergeFrom(HHPMJNKNKHN);
				}
				input.ReadMessage(eCIILPLNPHJ);
				HHPMJNKNKHN = eCIILPLNPHJ;
				break;
			}
			case 3202u:
			{
				OHHKGHEGJOG oHHKGHEGJOG = new OHHKGHEGJOG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NGGADJOOMEK)
				{
					oHHKGHEGJOG.MergeFrom(NGGADJOOMEK);
				}
				input.ReadMessage(oHHKGHEGJOG);
				NGGADJOOMEK = oHHKGHEGJOG;
				break;
			}
			case 3522u:
			{
				CGNCGFBCNHP cGNCGFBCNHP = new CGNCGFBCNHP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NMELOCJNOAP)
				{
					cGNCGFBCNHP.MergeFrom(NMELOCJNOAP);
				}
				input.ReadMessage(cGNCGFBCNHP);
				NMELOCJNOAP = cGNCGFBCNHP;
				break;
			}
			case 3650u:
			{
				OEMNHGMPMPD oEMNHGMPMPD = new OEMNHGMPMPD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FBFHMKCFBPD)
				{
					oEMNHGMPMPD.MergeFrom(FBFHMKCFBPD);
				}
				input.ReadMessage(oEMNHGMPMPD);
				FBFHMKCFBPD = oEMNHGMPMPD;
				break;
			}
			case 3754u:
			{
				OFAFDPGCEPO oFAFDPGCEPO = new OFAFDPGCEPO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LPILMOECPLA)
				{
					oFAFDPGCEPO.MergeFrom(LPILMOECPLA);
				}
				input.ReadMessage(oFAFDPGCEPO);
				LPILMOECPLA = oFAFDPGCEPO;
				break;
			}
			case 3818u:
			{
				EEIOIDGJCIL eEIOIDGJCIL = new EEIOIDGJCIL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KECBLOHENKO)
				{
					eEIOIDGJCIL.MergeFrom(KECBLOHENKO);
				}
				input.ReadMessage(eEIOIDGJCIL);
				KECBLOHENKO = eEIOIDGJCIL;
				break;
			}
			case 3994u:
			{
				HOPKIOKGEBP hOPKIOKGEBP = new HOPKIOKGEBP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGKOIJHKNFE)
				{
					hOPKIOKGEBP.MergeFrom(EGKOIJHKNFE);
				}
				input.ReadMessage(hOPKIOKGEBP);
				EGKOIJHKNFE = hOPKIOKGEBP;
				break;
			}
			case 4802u:
			{
				NCFKHLNHMAJ nCFKHLNHMAJ = new NCFKHLNHMAJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AACOABBJHKO)
				{
					nCFKHLNHMAJ.MergeFrom(AACOABBJHKO);
				}
				input.ReadMessage(nCFKHLNHMAJ);
				AACOABBJHKO = nCFKHLNHMAJ;
				break;
			}
			case 6042u:
			{
				MIIOLIIOGIG mIIOLIIOGIG = new MIIOLIIOGIG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PKINLGBPHBP)
				{
					mIIOLIIOGIG.MergeFrom(PKINLGBPHBP);
				}
				input.ReadMessage(mIIOLIIOGIG);
				PKINLGBPHBP = mIIOLIIOGIG;
				break;
			}
			case 6322u:
			{
				GCEBFJEEFOL gCEBFJEEFOL = new GCEBFJEEFOL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMFBJPDFDBJ)
				{
					gCEBFJEEFOL.MergeFrom(OMFBJPDFDBJ);
				}
				input.ReadMessage(gCEBFJEEFOL);
				OMFBJPDFDBJ = gCEBFJEEFOL;
				break;
			}
			case 6426u:
			{
				HOMNPCJECBH hOMNPCJECBH = new HOMNPCJECBH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AFENAIBNKGI)
				{
					hOMNPCJECBH.MergeFrom(AFENAIBNKGI);
				}
				input.ReadMessage(hOMNPCJECBH);
				AFENAIBNKGI = hOMNPCJECBH;
				break;
			}
			case 7018u:
			{
				DMLFNGEJOHC dMLFNGEJOHC = new DMLFNGEJOHC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIMAFPEBCAE)
				{
					dMLFNGEJOHC.MergeFrom(EIMAFPEBCAE);
				}
				input.ReadMessage(dMLFNGEJOHC);
				EIMAFPEBCAE = dMLFNGEJOHC;
				break;
			}
			case 7970u:
			{
				DEELJKHDLDH dEELJKHDLDH = new DEELJKHDLDH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CEFGOMFNHGO)
				{
					dEELJKHDLDH.MergeFrom(CEFGOMFNHGO);
				}
				input.ReadMessage(dEELJKHDLDH);
				CEFGOMFNHGO = dEELJKHDLDH;
				break;
			}
			case 8762u:
			{
				KHHHFHEODED kHHHFHEODED = new KHHHFHEODED();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JEEKEIGMDJN)
				{
					kHHHFHEODED.MergeFrom(JEEKEIGMDJN);
				}
				input.ReadMessage(kHHHFHEODED);
				JEEKEIGMDJN = kHHHFHEODED;
				break;
			}
			case 8778u:
			{
				CAEINLJIBPB cAEINLJIBPB = new CAEINLJIBPB();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KIIDBLFLAJN)
				{
					cAEINLJIBPB.MergeFrom(KIIDBLFLAJN);
				}
				input.ReadMessage(cAEINLJIBPB);
				KIIDBLFLAJN = cAEINLJIBPB;
				break;
			}
			case 9226u:
			{
				DEECFCALMFN dEECFCALMFN = new DEECFCALMFN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAFENFCGIFK)
				{
					dEECFCALMFN.MergeFrom(GAFENFCGIFK);
				}
				input.ReadMessage(dEECFCALMFN);
				GAFENFCGIFK = dEECFCALMFN;
				break;
			}
			case 9778u:
			{
				JCIJHCFBGKG jCIJHCFBGKG = new JCIJHCFBGKG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKFEGHCABK)
				{
					jCIJHCFBGKG.MergeFrom(JNKFEGHCABK);
				}
				input.ReadMessage(jCIJHCFBGKG);
				JNKFEGHCABK = jCIJHCFBGKG;
				break;
			}
			case 10058u:
			{
				JAEOAGNKNBL jAEOAGNKNBL = new JAEOAGNKNBL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MDGJHBJPDJH)
				{
					jAEOAGNKNBL.MergeFrom(MDGJHBJPDJH);
				}
				input.ReadMessage(jAEOAGNKNBL);
				MDGJHBJPDJH = jAEOAGNKNBL;
				break;
			}
			case 10338u:
			{
				GEMAIGNDNPK gEMAIGNDNPK = new GEMAIGNDNPK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMJNJFCCJPC)
				{
					gEMAIGNDNPK.MergeFrom(IMJNJFCCJPC);
				}
				input.ReadMessage(gEMAIGNDNPK);
				IMJNJFCCJPC = gEMAIGNDNPK;
				break;
			}
			case 10354u:
			{
				HJGFDIKDIHO hJGFDIKDIHO2 = new HJGFDIKDIHO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HNLAEIBDFJM)
				{
					hJGFDIKDIHO2.MergeFrom(HNLAEIBDFJM);
				}
				input.ReadMessage(hJGFDIKDIHO2);
				HNLAEIBDFJM = hJGFDIKDIHO2;
				break;
			}
			case 10474u:
			{
				GPEJGPJNECF gPEJGPJNECF = new GPEJGPJNECF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GEEMCLCCFCN)
				{
					gPEJGPJNECF.MergeFrom(GEEMCLCCFCN);
				}
				input.ReadMessage(gPEJGPJNECF);
				GEEMCLCCFCN = gPEJGPJNECF;
				break;
			}
			case 11658u:
			{
				PGMCJLBNNLF pGMCJLBNNLF = new PGMCJLBNNLF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IDCGKOMADPL)
				{
					pGMCJLBNNLF.MergeFrom(IDCGKOMADPL);
				}
				input.ReadMessage(pGMCJLBNNLF);
				IDCGKOMADPL = pGMCJLBNNLF;
				break;
			}
			case 11938u:
			{
				ACFGJBNMFDC aCFGJBNMFDC = new ACFGJBNMFDC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.COIKELCNIIP)
				{
					aCFGJBNMFDC.MergeFrom(COIKELCNIIP);
				}
				input.ReadMessage(aCFGJBNMFDC);
				COIKELCNIIP = aCFGJBNMFDC;
				break;
			}
			case 12642u:
			{
				DOGGIDNINJP dOGGIDNINJP = new DOGGIDNINJP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EIOKOADEOFC)
				{
					dOGGIDNINJP.MergeFrom(EIOKOADEOFC);
				}
				input.ReadMessage(dOGGIDNINJP);
				EIOKOADEOFC = dOGGIDNINJP;
				break;
			}
			case 12770u:
			{
				PDEHDNAOKBC pDEHDNAOKBC2 = new PDEHDNAOKBC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HPGEDIAGCLI)
				{
					pDEHDNAOKBC2.MergeFrom(HPGEDIAGCLI);
				}
				input.ReadMessage(pDEHDNAOKBC2);
				HPGEDIAGCLI = pDEHDNAOKBC2;
				break;
			}
			case 13018u:
			{
				BBKAPDCECDN bBKAPDCECDN = new BBKAPDCECDN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AGKGMLOMDGE)
				{
					bBKAPDCECDN.MergeFrom(AGKGMLOMDGE);
				}
				input.ReadMessage(bBKAPDCECDN);
				AGKGMLOMDGE = bBKAPDCECDN;
				break;
			}
			case 13202u:
			{
				PDEHDNAOKBC pDEHDNAOKBC = new PDEHDNAOKBC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NKLCEHNFCKM)
				{
					pDEHDNAOKBC.MergeFrom(NKLCEHNFCKM);
				}
				input.ReadMessage(pDEHDNAOKBC);
				NKLCEHNFCKM = pDEHDNAOKBC;
				break;
			}
			case 13866u:
			{
				FILIFCCNAPH fILIFCCNAPH = new FILIFCCNAPH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BJCFPBDCCBG)
				{
					fILIFCCNAPH.MergeFrom(BJCFPBDCCBG);
				}
				input.ReadMessage(fILIFCCNAPH);
				BJCFPBDCCBG = fILIFCCNAPH;
				break;
			}
			case 15642u:
			{
				JCFEENNNCBL jCFEENNNCBL = new JCFEENNNCBL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OMKLLPFPABL)
				{
					jCFEENNNCBL.MergeFrom(OMKLLPFPABL);
				}
				input.ReadMessage(jCFEENNNCBL);
				OMKLLPFPABL = jCFEENNNCBL;
				break;
			}
			case 15722u:
			{
				GNBKKPOLLAA gNBKKPOLLAA = new GNBKKPOLLAA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHLCPDMOFLA)
				{
					gNBKKPOLLAA.MergeFrom(NHLCPDMOFLA);
				}
				input.ReadMessage(gNBKKPOLLAA);
				NHLCPDMOFLA = gNBKKPOLLAA;
				break;
			}
			}
		}
	}
}
