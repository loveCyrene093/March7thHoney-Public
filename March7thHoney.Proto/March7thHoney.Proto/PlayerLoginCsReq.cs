using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerLoginCsReq : IMessage<PlayerLoginCsReq>, IMessage, IEquatable<PlayerLoginCsReq>, IDeepCloneable<PlayerLoginCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayerLoginCsReq> _parser = new MessageParser<PlayerLoginCsReq>(() => new PlayerLoginCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MCKPMFDFBGPFieldNumber = 1;

	private string mCKPMFDFBGP_ = "";

	public const int LoginRandomFieldNumber = 2;

	private ulong loginRandom_;

	public const int GGDPMLCODPHFieldNumber = 3;

	private string gGDPMLCODPH_ = "";

	public const int KILCHABDDLCFieldNumber = 4;

	private string kILCHABDDLC_ = "";

	public const int IBDEALLKDAMFieldNumber = 5;

	private string iBDEALLKDAM_ = "";

	public const int PlatformFieldNumber = 6;

	private PlatformType platform_;

	public const int HFFGCAGBNLOFieldNumber = 7;

	private string hFFGCAGBNLO_ = "";

	public const int BNPGKDAEJPBFieldNumber = 8;

	private LanguageType bNPGKDAEJPB_;

	public const int ClientResVersionFieldNumber = 9;

	private uint clientResVersion_;

	public const int IPICOGJIBAEFieldNumber = 10;

	private uint iPICOGJIBAE_;

	public const int RogueGetInfoFieldNumber = 11;

	private string rogueGetInfo_ = "";

	public const int LJIMJGAHMKMFieldNumber = 12;

	private string lJIMJGAHMKM_ = "";

	public const int JBCNGGAGFCDFieldNumber = 13;

	private string jBCNGGAGFCD_ = "";

	public const int ENECPEOGEKGFieldNumber = 14;

	private string eNECPEOGEKG_ = "";

	public const int SignatureFieldNumber = 15;

	private string signature_ = "";

	public const int HEJKBACFHBGFieldNumber = 42;

	private DNJFGOLLCCB hEJKBACFHBG_;

	public const int GNODLEJAOJPFieldNumber = 84;

	private string gNODLEJAOJP_ = "";

	public const int CABLACHJKIDFieldNumber = 189;

	private string cABLACHJKID_ = "";

	public const int CJCFGAMHMCGFieldNumber = 273;

	private string cJCFGAMHMCG_ = "";

	public const int MMFJFMPNJMNFieldNumber = 386;

	private bool mMFJFMPNJMN_;

	public const int PEKKCPFGCCLFieldNumber = 416;

	private uint pEKKCPFGCCL_;

	public const int EFKCMFIJGIJFieldNumber = 437;

	private uint eFKCMFIJGIJ_;

	public const int ICJIGHOMDNLFieldNumber = 729;

	private string iCJIGHOMDNL_ = "";

	public const int JMFANJEHDMGFieldNumber = 765;

	private bool jMFANJEHDMG_;

	public const int ABFNMCHIIFIFieldNumber = 809;

	private COKHGIMNLEK aBFNMCHIIFI_;

	public const int NCHFFCBPIFBFieldNumber = 878;

	private uint nCHFFCBPIFB_;

	public const int HBIDCAFOPMGFieldNumber = 1132;

	private string hBIDCAFOPMG_ = "";

	public const int BLEGPLIACMKFieldNumber = 1248;

	private string bLEGPLIACMK_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerLoginCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerLoginCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MCKPMFDFBGP
	{
		get
		{
			return mCKPMFDFBGP_;
		}
		set
		{
			mCKPMFDFBGP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong LoginRandom
	{
		get
		{
			return loginRandom_;
		}
		set
		{
			loginRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GGDPMLCODPH
	{
		get
		{
			return gGDPMLCODPH_;
		}
		set
		{
			gGDPMLCODPH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string KILCHABDDLC
	{
		get
		{
			return kILCHABDDLC_;
		}
		set
		{
			kILCHABDDLC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IBDEALLKDAM
	{
		get
		{
			return iBDEALLKDAM_;
		}
		set
		{
			iBDEALLKDAM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlatformType Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HFFGCAGBNLO
	{
		get
		{
			return hFFGCAGBNLO_;
		}
		set
		{
			hFFGCAGBNLO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LanguageType BNPGKDAEJPB
	{
		get
		{
			return bNPGKDAEJPB_;
		}
		set
		{
			bNPGKDAEJPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClientResVersion
	{
		get
		{
			return clientResVersion_;
		}
		set
		{
			clientResVersion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPICOGJIBAE
	{
		get
		{
			return iPICOGJIBAE_;
		}
		set
		{
			iPICOGJIBAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RogueGetInfo
	{
		get
		{
			return rogueGetInfo_;
		}
		set
		{
			rogueGetInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LJIMJGAHMKM
	{
		get
		{
			return lJIMJGAHMKM_;
		}
		set
		{
			lJIMJGAHMKM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string JBCNGGAGFCD
	{
		get
		{
			return jBCNGGAGFCD_;
		}
		set
		{
			jBCNGGAGFCD_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ENECPEOGEKG
	{
		get
		{
			return eNECPEOGEKG_;
		}
		set
		{
			eNECPEOGEKG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Signature
	{
		get
		{
			return signature_;
		}
		set
		{
			signature_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNJFGOLLCCB HEJKBACFHBG
	{
		get
		{
			return hEJKBACFHBG_;
		}
		set
		{
			hEJKBACFHBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GNODLEJAOJP
	{
		get
		{
			return gNODLEJAOJP_;
		}
		set
		{
			gNODLEJAOJP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CABLACHJKID
	{
		get
		{
			return cABLACHJKID_;
		}
		set
		{
			cABLACHJKID_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CJCFGAMHMCG
	{
		get
		{
			return cJCFGAMHMCG_;
		}
		set
		{
			cJCFGAMHMCG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MMFJFMPNJMN
	{
		get
		{
			return mMFJFMPNJMN_;
		}
		set
		{
			mMFJFMPNJMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEKKCPFGCCL
	{
		get
		{
			return pEKKCPFGCCL_;
		}
		set
		{
			pEKKCPFGCCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EFKCMFIJGIJ
	{
		get
		{
			return eFKCMFIJGIJ_;
		}
		set
		{
			eFKCMFIJGIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ICJIGHOMDNL
	{
		get
		{
			return iCJIGHOMDNL_;
		}
		set
		{
			iCJIGHOMDNL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JMFANJEHDMG
	{
		get
		{
			return jMFANJEHDMG_;
		}
		set
		{
			jMFANJEHDMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COKHGIMNLEK ABFNMCHIIFI
	{
		get
		{
			return aBFNMCHIIFI_;
		}
		set
		{
			aBFNMCHIIFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCHFFCBPIFB
	{
		get
		{
			return nCHFFCBPIFB_;
		}
		set
		{
			nCHFFCBPIFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HBIDCAFOPMG
	{
		get
		{
			return hBIDCAFOPMG_;
		}
		set
		{
			hBIDCAFOPMG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BLEGPLIACMK
	{
		get
		{
			return bLEGPLIACMK_;
		}
		set
		{
			bLEGPLIACMK_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerLoginCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerLoginCsReq(PlayerLoginCsReq other)
		: this()
	{
		mCKPMFDFBGP_ = other.mCKPMFDFBGP_;
		loginRandom_ = other.loginRandom_;
		gGDPMLCODPH_ = other.gGDPMLCODPH_;
		kILCHABDDLC_ = other.kILCHABDDLC_;
		iBDEALLKDAM_ = other.iBDEALLKDAM_;
		platform_ = other.platform_;
		hFFGCAGBNLO_ = other.hFFGCAGBNLO_;
		bNPGKDAEJPB_ = other.bNPGKDAEJPB_;
		clientResVersion_ = other.clientResVersion_;
		iPICOGJIBAE_ = other.iPICOGJIBAE_;
		rogueGetInfo_ = other.rogueGetInfo_;
		lJIMJGAHMKM_ = other.lJIMJGAHMKM_;
		jBCNGGAGFCD_ = other.jBCNGGAGFCD_;
		eNECPEOGEKG_ = other.eNECPEOGEKG_;
		signature_ = other.signature_;
		hEJKBACFHBG_ = ((other.hEJKBACFHBG_ != null) ? other.hEJKBACFHBG_.Clone() : null);
		gNODLEJAOJP_ = other.gNODLEJAOJP_;
		cABLACHJKID_ = other.cABLACHJKID_;
		cJCFGAMHMCG_ = other.cJCFGAMHMCG_;
		mMFJFMPNJMN_ = other.mMFJFMPNJMN_;
		pEKKCPFGCCL_ = other.pEKKCPFGCCL_;
		eFKCMFIJGIJ_ = other.eFKCMFIJGIJ_;
		iCJIGHOMDNL_ = other.iCJIGHOMDNL_;
		jMFANJEHDMG_ = other.jMFANJEHDMG_;
		aBFNMCHIIFI_ = ((other.aBFNMCHIIFI_ != null) ? other.aBFNMCHIIFI_.Clone() : null);
		nCHFFCBPIFB_ = other.nCHFFCBPIFB_;
		hBIDCAFOPMG_ = other.hBIDCAFOPMG_;
		bLEGPLIACMK_ = other.bLEGPLIACMK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerLoginCsReq Clone()
	{
		return new PlayerLoginCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerLoginCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerLoginCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MCKPMFDFBGP != other.MCKPMFDFBGP)
		{
			return false;
		}
		if (LoginRandom != other.LoginRandom)
		{
			return false;
		}
		if (GGDPMLCODPH != other.GGDPMLCODPH)
		{
			return false;
		}
		if (KILCHABDDLC != other.KILCHABDDLC)
		{
			return false;
		}
		if (IBDEALLKDAM != other.IBDEALLKDAM)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (HFFGCAGBNLO != other.HFFGCAGBNLO)
		{
			return false;
		}
		if (BNPGKDAEJPB != other.BNPGKDAEJPB)
		{
			return false;
		}
		if (ClientResVersion != other.ClientResVersion)
		{
			return false;
		}
		if (IPICOGJIBAE != other.IPICOGJIBAE)
		{
			return false;
		}
		if (RogueGetInfo != other.RogueGetInfo)
		{
			return false;
		}
		if (LJIMJGAHMKM != other.LJIMJGAHMKM)
		{
			return false;
		}
		if (JBCNGGAGFCD != other.JBCNGGAGFCD)
		{
			return false;
		}
		if (ENECPEOGEKG != other.ENECPEOGEKG)
		{
			return false;
		}
		if (Signature != other.Signature)
		{
			return false;
		}
		if (!object.Equals(HEJKBACFHBG, other.HEJKBACFHBG))
		{
			return false;
		}
		if (GNODLEJAOJP != other.GNODLEJAOJP)
		{
			return false;
		}
		if (CABLACHJKID != other.CABLACHJKID)
		{
			return false;
		}
		if (CJCFGAMHMCG != other.CJCFGAMHMCG)
		{
			return false;
		}
		if (MMFJFMPNJMN != other.MMFJFMPNJMN)
		{
			return false;
		}
		if (PEKKCPFGCCL != other.PEKKCPFGCCL)
		{
			return false;
		}
		if (EFKCMFIJGIJ != other.EFKCMFIJGIJ)
		{
			return false;
		}
		if (ICJIGHOMDNL != other.ICJIGHOMDNL)
		{
			return false;
		}
		if (JMFANJEHDMG != other.JMFANJEHDMG)
		{
			return false;
		}
		if (!object.Equals(ABFNMCHIIFI, other.ABFNMCHIIFI))
		{
			return false;
		}
		if (NCHFFCBPIFB != other.NCHFFCBPIFB)
		{
			return false;
		}
		if (HBIDCAFOPMG != other.HBIDCAFOPMG)
		{
			return false;
		}
		if (BLEGPLIACMK != other.BLEGPLIACMK)
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
		if (MCKPMFDFBGP.Length != 0)
		{
			num ^= MCKPMFDFBGP.GetHashCode();
		}
		if (LoginRandom != 0L)
		{
			num ^= LoginRandom.GetHashCode();
		}
		if (GGDPMLCODPH.Length != 0)
		{
			num ^= GGDPMLCODPH.GetHashCode();
		}
		if (KILCHABDDLC.Length != 0)
		{
			num ^= KILCHABDDLC.GetHashCode();
		}
		if (IBDEALLKDAM.Length != 0)
		{
			num ^= IBDEALLKDAM.GetHashCode();
		}
		if (Platform != PlatformType.Editor)
		{
			num ^= Platform.GetHashCode();
		}
		if (HFFGCAGBNLO.Length != 0)
		{
			num ^= HFFGCAGBNLO.GetHashCode();
		}
		if (BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			num ^= BNPGKDAEJPB.GetHashCode();
		}
		if (ClientResVersion != 0)
		{
			num ^= ClientResVersion.GetHashCode();
		}
		if (IPICOGJIBAE != 0)
		{
			num ^= IPICOGJIBAE.GetHashCode();
		}
		if (RogueGetInfo.Length != 0)
		{
			num ^= RogueGetInfo.GetHashCode();
		}
		if (LJIMJGAHMKM.Length != 0)
		{
			num ^= LJIMJGAHMKM.GetHashCode();
		}
		if (JBCNGGAGFCD.Length != 0)
		{
			num ^= JBCNGGAGFCD.GetHashCode();
		}
		if (ENECPEOGEKG.Length != 0)
		{
			num ^= ENECPEOGEKG.GetHashCode();
		}
		if (Signature.Length != 0)
		{
			num ^= Signature.GetHashCode();
		}
		if (hEJKBACFHBG_ != null)
		{
			num ^= HEJKBACFHBG.GetHashCode();
		}
		if (GNODLEJAOJP.Length != 0)
		{
			num ^= GNODLEJAOJP.GetHashCode();
		}
		if (CABLACHJKID.Length != 0)
		{
			num ^= CABLACHJKID.GetHashCode();
		}
		if (CJCFGAMHMCG.Length != 0)
		{
			num ^= CJCFGAMHMCG.GetHashCode();
		}
		if (MMFJFMPNJMN)
		{
			num ^= MMFJFMPNJMN.GetHashCode();
		}
		if (PEKKCPFGCCL != 0)
		{
			num ^= PEKKCPFGCCL.GetHashCode();
		}
		if (EFKCMFIJGIJ != 0)
		{
			num ^= EFKCMFIJGIJ.GetHashCode();
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			num ^= ICJIGHOMDNL.GetHashCode();
		}
		if (JMFANJEHDMG)
		{
			num ^= JMFANJEHDMG.GetHashCode();
		}
		if (aBFNMCHIIFI_ != null)
		{
			num ^= ABFNMCHIIFI.GetHashCode();
		}
		if (NCHFFCBPIFB != 0)
		{
			num ^= NCHFFCBPIFB.GetHashCode();
		}
		if (HBIDCAFOPMG.Length != 0)
		{
			num ^= HBIDCAFOPMG.GetHashCode();
		}
		if (BLEGPLIACMK.Length != 0)
		{
			num ^= BLEGPLIACMK.GetHashCode();
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
		if (MCKPMFDFBGP.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MCKPMFDFBGP);
		}
		if (LoginRandom != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(LoginRandom);
		}
		if (GGDPMLCODPH.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GGDPMLCODPH);
		}
		if (KILCHABDDLC.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(KILCHABDDLC);
		}
		if (IBDEALLKDAM.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(IBDEALLKDAM);
		}
		if (Platform != PlatformType.Editor)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Platform);
		}
		if (HFFGCAGBNLO.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(HFFGCAGBNLO);
		}
		if (BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)BNPGKDAEJPB);
		}
		if (ClientResVersion != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ClientResVersion);
		}
		if (IPICOGJIBAE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IPICOGJIBAE);
		}
		if (RogueGetInfo.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(RogueGetInfo);
		}
		if (LJIMJGAHMKM.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(LJIMJGAHMKM);
		}
		if (JBCNGGAGFCD.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(JBCNGGAGFCD);
		}
		if (ENECPEOGEKG.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(ENECPEOGEKG);
		}
		if (Signature.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(Signature);
		}
		if (hEJKBACFHBG_ != null)
		{
			output.WriteRawTag(210, 2);
			output.WriteMessage(HEJKBACFHBG);
		}
		if (GNODLEJAOJP.Length != 0)
		{
			output.WriteRawTag(162, 5);
			output.WriteString(GNODLEJAOJP);
		}
		if (CABLACHJKID.Length != 0)
		{
			output.WriteRawTag(234, 11);
			output.WriteString(CABLACHJKID);
		}
		if (CJCFGAMHMCG.Length != 0)
		{
			output.WriteRawTag(138, 17);
			output.WriteString(CJCFGAMHMCG);
		}
		if (MMFJFMPNJMN)
		{
			output.WriteRawTag(144, 24);
			output.WriteBool(MMFJFMPNJMN);
		}
		if (PEKKCPFGCCL != 0)
		{
			output.WriteRawTag(128, 26);
			output.WriteUInt32(PEKKCPFGCCL);
		}
		if (EFKCMFIJGIJ != 0)
		{
			output.WriteRawTag(168, 27);
			output.WriteUInt32(EFKCMFIJGIJ);
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			output.WriteRawTag(202, 45);
			output.WriteString(ICJIGHOMDNL);
		}
		if (JMFANJEHDMG)
		{
			output.WriteRawTag(232, 47);
			output.WriteBool(JMFANJEHDMG);
		}
		if (aBFNMCHIIFI_ != null)
		{
			output.WriteRawTag(202, 50);
			output.WriteMessage(ABFNMCHIIFI);
		}
		if (NCHFFCBPIFB != 0)
		{
			output.WriteRawTag(240, 54);
			output.WriteUInt32(NCHFFCBPIFB);
		}
		if (HBIDCAFOPMG.Length != 0)
		{
			output.WriteRawTag(226, 70);
			output.WriteString(HBIDCAFOPMG);
		}
		if (BLEGPLIACMK.Length != 0)
		{
			output.WriteRawTag(130, 78);
			output.WriteString(BLEGPLIACMK);
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
		if (MCKPMFDFBGP.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MCKPMFDFBGP);
		}
		if (LoginRandom != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(LoginRandom);
		}
		if (GGDPMLCODPH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GGDPMLCODPH);
		}
		if (KILCHABDDLC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KILCHABDDLC);
		}
		if (IBDEALLKDAM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IBDEALLKDAM);
		}
		if (Platform != PlatformType.Editor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Platform);
		}
		if (HFFGCAGBNLO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HFFGCAGBNLO);
		}
		if (BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BNPGKDAEJPB);
		}
		if (ClientResVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientResVersion);
		}
		if (IPICOGJIBAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPICOGJIBAE);
		}
		if (RogueGetInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RogueGetInfo);
		}
		if (LJIMJGAHMKM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LJIMJGAHMKM);
		}
		if (JBCNGGAGFCD.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JBCNGGAGFCD);
		}
		if (ENECPEOGEKG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ENECPEOGEKG);
		}
		if (Signature.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Signature);
		}
		if (hEJKBACFHBG_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HEJKBACFHBG);
		}
		if (GNODLEJAOJP.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(GNODLEJAOJP);
		}
		if (CABLACHJKID.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CABLACHJKID);
		}
		if (CJCFGAMHMCG.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CJCFGAMHMCG);
		}
		if (MMFJFMPNJMN)
		{
			num += 3;
		}
		if (PEKKCPFGCCL != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PEKKCPFGCCL);
		}
		if (EFKCMFIJGIJ != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EFKCMFIJGIJ);
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ICJIGHOMDNL);
		}
		if (JMFANJEHDMG)
		{
			num += 3;
		}
		if (aBFNMCHIIFI_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ABFNMCHIIFI);
		}
		if (NCHFFCBPIFB != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NCHFFCBPIFB);
		}
		if (HBIDCAFOPMG.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HBIDCAFOPMG);
		}
		if (BLEGPLIACMK.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BLEGPLIACMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerLoginCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MCKPMFDFBGP.Length != 0)
		{
			MCKPMFDFBGP = other.MCKPMFDFBGP;
		}
		if (other.LoginRandom != 0L)
		{
			LoginRandom = other.LoginRandom;
		}
		if (other.GGDPMLCODPH.Length != 0)
		{
			GGDPMLCODPH = other.GGDPMLCODPH;
		}
		if (other.KILCHABDDLC.Length != 0)
		{
			KILCHABDDLC = other.KILCHABDDLC;
		}
		if (other.IBDEALLKDAM.Length != 0)
		{
			IBDEALLKDAM = other.IBDEALLKDAM;
		}
		if (other.Platform != PlatformType.Editor)
		{
			Platform = other.Platform;
		}
		if (other.HFFGCAGBNLO.Length != 0)
		{
			HFFGCAGBNLO = other.HFFGCAGBNLO;
		}
		if (other.BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			BNPGKDAEJPB = other.BNPGKDAEJPB;
		}
		if (other.ClientResVersion != 0)
		{
			ClientResVersion = other.ClientResVersion;
		}
		if (other.IPICOGJIBAE != 0)
		{
			IPICOGJIBAE = other.IPICOGJIBAE;
		}
		if (other.RogueGetInfo.Length != 0)
		{
			RogueGetInfo = other.RogueGetInfo;
		}
		if (other.LJIMJGAHMKM.Length != 0)
		{
			LJIMJGAHMKM = other.LJIMJGAHMKM;
		}
		if (other.JBCNGGAGFCD.Length != 0)
		{
			JBCNGGAGFCD = other.JBCNGGAGFCD;
		}
		if (other.ENECPEOGEKG.Length != 0)
		{
			ENECPEOGEKG = other.ENECPEOGEKG;
		}
		if (other.Signature.Length != 0)
		{
			Signature = other.Signature;
		}
		if (other.hEJKBACFHBG_ != null)
		{
			if (hEJKBACFHBG_ == null)
			{
				HEJKBACFHBG = new DNJFGOLLCCB();
			}
			HEJKBACFHBG.MergeFrom(other.HEJKBACFHBG);
		}
		if (other.GNODLEJAOJP.Length != 0)
		{
			GNODLEJAOJP = other.GNODLEJAOJP;
		}
		if (other.CABLACHJKID.Length != 0)
		{
			CABLACHJKID = other.CABLACHJKID;
		}
		if (other.CJCFGAMHMCG.Length != 0)
		{
			CJCFGAMHMCG = other.CJCFGAMHMCG;
		}
		if (other.MMFJFMPNJMN)
		{
			MMFJFMPNJMN = other.MMFJFMPNJMN;
		}
		if (other.PEKKCPFGCCL != 0)
		{
			PEKKCPFGCCL = other.PEKKCPFGCCL;
		}
		if (other.EFKCMFIJGIJ != 0)
		{
			EFKCMFIJGIJ = other.EFKCMFIJGIJ;
		}
		if (other.ICJIGHOMDNL.Length != 0)
		{
			ICJIGHOMDNL = other.ICJIGHOMDNL;
		}
		if (other.JMFANJEHDMG)
		{
			JMFANJEHDMG = other.JMFANJEHDMG;
		}
		if (other.aBFNMCHIIFI_ != null)
		{
			if (aBFNMCHIIFI_ == null)
			{
				ABFNMCHIIFI = new COKHGIMNLEK();
			}
			ABFNMCHIIFI.MergeFrom(other.ABFNMCHIIFI);
		}
		if (other.NCHFFCBPIFB != 0)
		{
			NCHFFCBPIFB = other.NCHFFCBPIFB;
		}
		if (other.HBIDCAFOPMG.Length != 0)
		{
			HBIDCAFOPMG = other.HBIDCAFOPMG;
		}
		if (other.BLEGPLIACMK.Length != 0)
		{
			BLEGPLIACMK = other.BLEGPLIACMK;
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
				MCKPMFDFBGP = input.ReadString();
				break;
			case 16u:
				LoginRandom = input.ReadUInt64();
				break;
			case 26u:
				GGDPMLCODPH = input.ReadString();
				break;
			case 34u:
				KILCHABDDLC = input.ReadString();
				break;
			case 42u:
				IBDEALLKDAM = input.ReadString();
				break;
			case 48u:
				Platform = (PlatformType)input.ReadEnum();
				break;
			case 58u:
				HFFGCAGBNLO = input.ReadString();
				break;
			case 64u:
				BNPGKDAEJPB = (LanguageType)input.ReadEnum();
				break;
			case 72u:
				ClientResVersion = input.ReadUInt32();
				break;
			case 80u:
				IPICOGJIBAE = input.ReadUInt32();
				break;
			case 90u:
				RogueGetInfo = input.ReadString();
				break;
			case 98u:
				LJIMJGAHMKM = input.ReadString();
				break;
			case 106u:
				JBCNGGAGFCD = input.ReadString();
				break;
			case 114u:
				ENECPEOGEKG = input.ReadString();
				break;
			case 122u:
				Signature = input.ReadString();
				break;
			case 338u:
				if (hEJKBACFHBG_ == null)
				{
					HEJKBACFHBG = new DNJFGOLLCCB();
				}
				input.ReadMessage(HEJKBACFHBG);
				break;
			case 674u:
				GNODLEJAOJP = input.ReadString();
				break;
			case 1514u:
				CABLACHJKID = input.ReadString();
				break;
			case 2186u:
				CJCFGAMHMCG = input.ReadString();
				break;
			case 3088u:
				MMFJFMPNJMN = input.ReadBool();
				break;
			case 3328u:
				PEKKCPFGCCL = input.ReadUInt32();
				break;
			case 3496u:
				EFKCMFIJGIJ = input.ReadUInt32();
				break;
			case 5834u:
				ICJIGHOMDNL = input.ReadString();
				break;
			case 6120u:
				JMFANJEHDMG = input.ReadBool();
				break;
			case 6474u:
				if (aBFNMCHIIFI_ == null)
				{
					ABFNMCHIIFI = new COKHGIMNLEK();
				}
				input.ReadMessage(ABFNMCHIIFI);
				break;
			case 7024u:
				NCHFFCBPIFB = input.ReadUInt32();
				break;
			case 9058u:
				HBIDCAFOPMG = input.ReadString();
				break;
			case 9986u:
				BLEGPLIACMK = input.ReadString();
				break;
			}
		}
	}
}
