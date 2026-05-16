using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCNFGGMIKJF : IMessage<CCNFGGMIKJF>, IMessage, IEquatable<CCNFGGMIKJF>, IDeepCloneable<CCNFGGMIKJF>, IBufferMessage
{
	private static readonly MessageParser<CCNFGGMIKJF> _parser = new MessageParser<CCNFGGMIKJF>(() => new CCNFGGMIKJF());

	private UnknownFieldSet _unknownFields;

	public const int AttackFieldNumber = 1;

	private int attack_;

	public const int MaxHpFieldNumber = 2;

	private int maxHp_;

	public const int MLDGPGGEDBKFieldNumber = 3;

	private DFKBFAICDJG mLDGPGGEDBK_;

	public const int TimeFieldNumber = 4;

	private float time_;

	public const int SkillIdFieldNumber = 5;

	private uint skillId_;

	public const int HpFieldNumber = 6;

	private int hp_;

	public const int KDJEEKJBPAOFieldNumber = 7;

	private uint kDJEEKJBPAO_;

	public const int BCIEHPOHPDPFieldNumber = 8;

	private uint bCIEHPOHPDP_;

	public const int IKAGBDAAMAGFieldNumber = 9;

	private KGCLNMHAAMM iKAGBDAAMAG_;

	public const int OAIMADEEEPEFieldNumber = 10;

	private KGCLNMHAAMM oAIMADEEEPE_;

	public const int JALKBDBKOKCFieldNumber = 11;

	private GPIOFJJJAMF jALKBDBKOKC_;

	public const int MBAFIOCLMAIFieldNumber = 12;

	private KGCLNMHAAMM mBAFIOCLMAI_;

	public const int IJJAKDLIPALFieldNumber = 13;

	private KGCLNMHAAMM iJJAKDLIPAL_;

	public const int IdFieldNumber = 14;

	private uint id_;

	public const int GFKKHOIMECFFieldNumber = 15;

	private KGCLNMHAAMM gFKKHOIMECF_;

	public const int PIPPIIFDEHAFieldNumber = 247;

	private uint pIPPIIFDEHA_;

	public const int OLKBHJNOIADFieldNumber = 486;

	private bool oLKBHJNOIAD_;

	public const int LevelFieldNumber = 535;

	private uint level_;

	public const int KHNNELPGKIMFieldNumber = 612;

	private float kHNNELPGKIM_;

	public const int IPACGBDKFNAFieldNumber = 686;

	private bool iPACGBDKFNA_;

	public const int NBEKCEIHJACFieldNumber = 706;

	private bool nBEKCEIHJAC_;

	public const int TextIdFieldNumber = 722;

	private uint textId_;

	public const int KFAEMIBBPHAFieldNumber = 763;

	private uint kFAEMIBBPHA_;

	public const int PGOIGOFLCDGFieldNumber = 910;

	private FightMarbleHpChangeType pGOIGOFLCDG_;

	public const int APEBCDDKGOGFieldNumber = 1015;

	private uint aPEBCDDKGOG_;

	public const int BuffIdFieldNumber = 1144;

	private uint buffId_;

	public const int HPEOJNOOHDDFieldNumber = 1396;

	private uint hPEOJNOOHDD_;

	public const int EMPIGIEDOMOFieldNumber = 1616;

	private uint eMPIGIEDOMO_;

	public const int ICLJEMJOOLPFieldNumber = 1753;

	private float iCLJEMJOOLP_;

	public const int AKHDCMLBGKNFieldNumber = 1996;

	private uint aKHDCMLBGKN_;

	public const int CCNJKIAOMFFFieldNumber = 2028;

	private int cCNJKIAOMFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCNFGGMIKJF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCNFGGMIKJFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Attack
	{
		get
		{
			return attack_;
		}
		set
		{
			attack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFKBFAICDJG MLDGPGGEDBK
	{
		get
		{
			return mLDGPGGEDBK_;
		}
		set
		{
			mLDGPGGEDBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KDJEEKJBPAO
	{
		get
		{
			return kDJEEKJBPAO_;
		}
		set
		{
			kDJEEKJBPAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCIEHPOHPDP
	{
		get
		{
			return bCIEHPOHPDP_;
		}
		set
		{
			bCIEHPOHPDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM IKAGBDAAMAG
	{
		get
		{
			return iKAGBDAAMAG_;
		}
		set
		{
			iKAGBDAAMAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM OAIMADEEEPE
	{
		get
		{
			return oAIMADEEEPE_;
		}
		set
		{
			oAIMADEEEPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPIOFJJJAMF JALKBDBKOKC
	{
		get
		{
			return jALKBDBKOKC_;
		}
		set
		{
			jALKBDBKOKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM MBAFIOCLMAI
	{
		get
		{
			return mBAFIOCLMAI_;
		}
		set
		{
			mBAFIOCLMAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM IJJAKDLIPAL
	{
		get
		{
			return iJJAKDLIPAL_;
		}
		set
		{
			iJJAKDLIPAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM GFKKHOIMECF
	{
		get
		{
			return gFKKHOIMECF_;
		}
		set
		{
			gFKKHOIMECF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PIPPIIFDEHA
	{
		get
		{
			return pIPPIIFDEHA_;
		}
		set
		{
			pIPPIIFDEHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OLKBHJNOIAD
	{
		get
		{
			return oLKBHJNOIAD_;
		}
		set
		{
			oLKBHJNOIAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float KHNNELPGKIM
	{
		get
		{
			return kHNNELPGKIM_;
		}
		set
		{
			kHNNELPGKIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IPACGBDKFNA
	{
		get
		{
			return iPACGBDKFNA_;
		}
		set
		{
			iPACGBDKFNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NBEKCEIHJAC
	{
		get
		{
			return nBEKCEIHJAC_;
		}
		set
		{
			nBEKCEIHJAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TextId
	{
		get
		{
			return textId_;
		}
		set
		{
			textId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFAEMIBBPHA
	{
		get
		{
			return kFAEMIBBPHA_;
		}
		set
		{
			kFAEMIBBPHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMarbleHpChangeType PGOIGOFLCDG
	{
		get
		{
			return pGOIGOFLCDG_;
		}
		set
		{
			pGOIGOFLCDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APEBCDDKGOG
	{
		get
		{
			return aPEBCDDKGOG_;
		}
		set
		{
			aPEBCDDKGOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HPEOJNOOHDD
	{
		get
		{
			return hPEOJNOOHDD_;
		}
		set
		{
			hPEOJNOOHDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMPIGIEDOMO
	{
		get
		{
			return eMPIGIEDOMO_;
		}
		set
		{
			eMPIGIEDOMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float ICLJEMJOOLP
	{
		get
		{
			return iCLJEMJOOLP_;
		}
		set
		{
			iCLJEMJOOLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKHDCMLBGKN
	{
		get
		{
			return aKHDCMLBGKN_;
		}
		set
		{
			aKHDCMLBGKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CCNJKIAOMFF
	{
		get
		{
			return cCNJKIAOMFF_;
		}
		set
		{
			cCNJKIAOMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCNFGGMIKJF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCNFGGMIKJF(CCNFGGMIKJF other)
		: this()
	{
		attack_ = other.attack_;
		maxHp_ = other.maxHp_;
		mLDGPGGEDBK_ = other.mLDGPGGEDBK_;
		time_ = other.time_;
		skillId_ = other.skillId_;
		hp_ = other.hp_;
		kDJEEKJBPAO_ = other.kDJEEKJBPAO_;
		bCIEHPOHPDP_ = other.bCIEHPOHPDP_;
		iKAGBDAAMAG_ = ((other.iKAGBDAAMAG_ != null) ? other.iKAGBDAAMAG_.Clone() : null);
		oAIMADEEEPE_ = ((other.oAIMADEEEPE_ != null) ? other.oAIMADEEEPE_.Clone() : null);
		jALKBDBKOKC_ = other.jALKBDBKOKC_;
		mBAFIOCLMAI_ = ((other.mBAFIOCLMAI_ != null) ? other.mBAFIOCLMAI_.Clone() : null);
		iJJAKDLIPAL_ = ((other.iJJAKDLIPAL_ != null) ? other.iJJAKDLIPAL_.Clone() : null);
		id_ = other.id_;
		gFKKHOIMECF_ = ((other.gFKKHOIMECF_ != null) ? other.gFKKHOIMECF_.Clone() : null);
		pIPPIIFDEHA_ = other.pIPPIIFDEHA_;
		oLKBHJNOIAD_ = other.oLKBHJNOIAD_;
		level_ = other.level_;
		kHNNELPGKIM_ = other.kHNNELPGKIM_;
		iPACGBDKFNA_ = other.iPACGBDKFNA_;
		nBEKCEIHJAC_ = other.nBEKCEIHJAC_;
		textId_ = other.textId_;
		kFAEMIBBPHA_ = other.kFAEMIBBPHA_;
		pGOIGOFLCDG_ = other.pGOIGOFLCDG_;
		aPEBCDDKGOG_ = other.aPEBCDDKGOG_;
		buffId_ = other.buffId_;
		hPEOJNOOHDD_ = other.hPEOJNOOHDD_;
		eMPIGIEDOMO_ = other.eMPIGIEDOMO_;
		iCLJEMJOOLP_ = other.iCLJEMJOOLP_;
		aKHDCMLBGKN_ = other.aKHDCMLBGKN_;
		cCNJKIAOMFF_ = other.cCNJKIAOMFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCNFGGMIKJF Clone()
	{
		return new CCNFGGMIKJF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCNFGGMIKJF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCNFGGMIKJF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Attack != other.Attack)
		{
			return false;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (MLDGPGGEDBK != other.MLDGPGGEDBK)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Time, other.Time))
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (KDJEEKJBPAO != other.KDJEEKJBPAO)
		{
			return false;
		}
		if (BCIEHPOHPDP != other.BCIEHPOHPDP)
		{
			return false;
		}
		if (!object.Equals(IKAGBDAAMAG, other.IKAGBDAAMAG))
		{
			return false;
		}
		if (!object.Equals(OAIMADEEEPE, other.OAIMADEEEPE))
		{
			return false;
		}
		if (JALKBDBKOKC != other.JALKBDBKOKC)
		{
			return false;
		}
		if (!object.Equals(MBAFIOCLMAI, other.MBAFIOCLMAI))
		{
			return false;
		}
		if (!object.Equals(IJJAKDLIPAL, other.IJJAKDLIPAL))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!object.Equals(GFKKHOIMECF, other.GFKKHOIMECF))
		{
			return false;
		}
		if (PIPPIIFDEHA != other.PIPPIIFDEHA)
		{
			return false;
		}
		if (OLKBHJNOIAD != other.OLKBHJNOIAD)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KHNNELPGKIM, other.KHNNELPGKIM))
		{
			return false;
		}
		if (IPACGBDKFNA != other.IPACGBDKFNA)
		{
			return false;
		}
		if (NBEKCEIHJAC != other.NBEKCEIHJAC)
		{
			return false;
		}
		if (TextId != other.TextId)
		{
			return false;
		}
		if (KFAEMIBBPHA != other.KFAEMIBBPHA)
		{
			return false;
		}
		if (PGOIGOFLCDG != other.PGOIGOFLCDG)
		{
			return false;
		}
		if (APEBCDDKGOG != other.APEBCDDKGOG)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (HPEOJNOOHDD != other.HPEOJNOOHDD)
		{
			return false;
		}
		if (EMPIGIEDOMO != other.EMPIGIEDOMO)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ICLJEMJOOLP, other.ICLJEMJOOLP))
		{
			return false;
		}
		if (AKHDCMLBGKN != other.AKHDCMLBGKN)
		{
			return false;
		}
		if (CCNJKIAOMFF != other.CCNJKIAOMFF)
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
		if (Attack != 0)
		{
			num ^= Attack.GetHashCode();
		}
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (MLDGPGGEDBK != DFKBFAICDJG.Pcmnnonnjio)
		{
			num ^= MLDGPGGEDBK.GetHashCode();
		}
		if (Time != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Time);
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (KDJEEKJBPAO != 0)
		{
			num ^= KDJEEKJBPAO.GetHashCode();
		}
		if (BCIEHPOHPDP != 0)
		{
			num ^= BCIEHPOHPDP.GetHashCode();
		}
		if (iKAGBDAAMAG_ != null)
		{
			num ^= IKAGBDAAMAG.GetHashCode();
		}
		if (oAIMADEEEPE_ != null)
		{
			num ^= OAIMADEEEPE.GetHashCode();
		}
		if (JALKBDBKOKC != GPIOFJJJAMF.Dbihmnglogl)
		{
			num ^= JALKBDBKOKC.GetHashCode();
		}
		if (mBAFIOCLMAI_ != null)
		{
			num ^= MBAFIOCLMAI.GetHashCode();
		}
		if (iJJAKDLIPAL_ != null)
		{
			num ^= IJJAKDLIPAL.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (gFKKHOIMECF_ != null)
		{
			num ^= GFKKHOIMECF.GetHashCode();
		}
		if (PIPPIIFDEHA != 0)
		{
			num ^= PIPPIIFDEHA.GetHashCode();
		}
		if (OLKBHJNOIAD)
		{
			num ^= OLKBHJNOIAD.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (KHNNELPGKIM != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KHNNELPGKIM);
		}
		if (IPACGBDKFNA)
		{
			num ^= IPACGBDKFNA.GetHashCode();
		}
		if (NBEKCEIHJAC)
		{
			num ^= NBEKCEIHJAC.GetHashCode();
		}
		if (TextId != 0)
		{
			num ^= TextId.GetHashCode();
		}
		if (KFAEMIBBPHA != 0)
		{
			num ^= KFAEMIBBPHA.GetHashCode();
		}
		if (PGOIGOFLCDG != FightMarbleHpChangeType.AghlhafiaejOppeoekldcj)
		{
			num ^= PGOIGOFLCDG.GetHashCode();
		}
		if (APEBCDDKGOG != 0)
		{
			num ^= APEBCDDKGOG.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (HPEOJNOOHDD != 0)
		{
			num ^= HPEOJNOOHDD.GetHashCode();
		}
		if (EMPIGIEDOMO != 0)
		{
			num ^= EMPIGIEDOMO.GetHashCode();
		}
		if (ICLJEMJOOLP != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ICLJEMJOOLP);
		}
		if (AKHDCMLBGKN != 0)
		{
			num ^= AKHDCMLBGKN.GetHashCode();
		}
		if (CCNJKIAOMFF != 0)
		{
			num ^= CCNJKIAOMFF.GetHashCode();
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
		if (Attack != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Attack);
		}
		if (MaxHp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MaxHp);
		}
		if (MLDGPGGEDBK != DFKBFAICDJG.Pcmnnonnjio)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)MLDGPGGEDBK);
		}
		if (Time != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(Time);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(SkillId);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Hp);
		}
		if (KDJEEKJBPAO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KDJEEKJBPAO);
		}
		if (BCIEHPOHPDP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BCIEHPOHPDP);
		}
		if (iKAGBDAAMAG_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(IKAGBDAAMAG);
		}
		if (oAIMADEEEPE_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(OAIMADEEEPE);
		}
		if (JALKBDBKOKC != GPIOFJJJAMF.Dbihmnglogl)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)JALKBDBKOKC);
		}
		if (mBAFIOCLMAI_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(MBAFIOCLMAI);
		}
		if (iJJAKDLIPAL_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(IJJAKDLIPAL);
		}
		if (Id != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Id);
		}
		if (gFKKHOIMECF_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GFKKHOIMECF);
		}
		if (PIPPIIFDEHA != 0)
		{
			output.WriteRawTag(184, 15);
			output.WriteUInt32(PIPPIIFDEHA);
		}
		if (OLKBHJNOIAD)
		{
			output.WriteRawTag(176, 30);
			output.WriteBool(OLKBHJNOIAD);
		}
		if (Level != 0)
		{
			output.WriteRawTag(184, 33);
			output.WriteUInt32(Level);
		}
		if (KHNNELPGKIM != 0f)
		{
			output.WriteRawTag(165, 38);
			output.WriteFloat(KHNNELPGKIM);
		}
		if (IPACGBDKFNA)
		{
			output.WriteRawTag(240, 42);
			output.WriteBool(IPACGBDKFNA);
		}
		if (NBEKCEIHJAC)
		{
			output.WriteRawTag(144, 44);
			output.WriteBool(NBEKCEIHJAC);
		}
		if (TextId != 0)
		{
			output.WriteRawTag(144, 45);
			output.WriteUInt32(TextId);
		}
		if (KFAEMIBBPHA != 0)
		{
			output.WriteRawTag(216, 47);
			output.WriteUInt32(KFAEMIBBPHA);
		}
		if (PGOIGOFLCDG != FightMarbleHpChangeType.AghlhafiaejOppeoekldcj)
		{
			output.WriteRawTag(240, 56);
			output.WriteEnum((int)PGOIGOFLCDG);
		}
		if (APEBCDDKGOG != 0)
		{
			output.WriteRawTag(184, 63);
			output.WriteUInt32(APEBCDDKGOG);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(192, 71);
			output.WriteUInt32(BuffId);
		}
		if (HPEOJNOOHDD != 0)
		{
			output.WriteRawTag(160, 87);
			output.WriteUInt32(HPEOJNOOHDD);
		}
		if (EMPIGIEDOMO != 0)
		{
			output.WriteRawTag(128, 101);
			output.WriteUInt32(EMPIGIEDOMO);
		}
		if (ICLJEMJOOLP != 0f)
		{
			output.WriteRawTag(205, 109);
			output.WriteFloat(ICLJEMJOOLP);
		}
		if (AKHDCMLBGKN != 0)
		{
			output.WriteRawTag(224, 124);
			output.WriteUInt32(AKHDCMLBGKN);
		}
		if (CCNJKIAOMFF != 0)
		{
			output.WriteRawTag(224, 126);
			output.WriteInt32(CCNJKIAOMFF);
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
		if (Attack != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Attack);
		}
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxHp);
		}
		if (MLDGPGGEDBK != DFKBFAICDJG.Pcmnnonnjio)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MLDGPGGEDBK);
		}
		if (Time != 0f)
		{
			num += 5;
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (KDJEEKJBPAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KDJEEKJBPAO);
		}
		if (BCIEHPOHPDP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCIEHPOHPDP);
		}
		if (iKAGBDAAMAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IKAGBDAAMAG);
		}
		if (oAIMADEEEPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OAIMADEEEPE);
		}
		if (JALKBDBKOKC != GPIOFJJJAMF.Dbihmnglogl)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JALKBDBKOKC);
		}
		if (mBAFIOCLMAI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBAFIOCLMAI);
		}
		if (iJJAKDLIPAL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IJJAKDLIPAL);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (gFKKHOIMECF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GFKKHOIMECF);
		}
		if (PIPPIIFDEHA != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PIPPIIFDEHA);
		}
		if (OLKBHJNOIAD)
		{
			num += 3;
		}
		if (Level != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (KHNNELPGKIM != 0f)
		{
			num += 6;
		}
		if (IPACGBDKFNA)
		{
			num += 3;
		}
		if (NBEKCEIHJAC)
		{
			num += 3;
		}
		if (TextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(TextId);
		}
		if (KFAEMIBBPHA != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KFAEMIBBPHA);
		}
		if (PGOIGOFLCDG != FightMarbleHpChangeType.AghlhafiaejOppeoekldcj)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)PGOIGOFLCDG);
		}
		if (APEBCDDKGOG != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(APEBCDDKGOG);
		}
		if (BuffId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (HPEOJNOOHDD != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HPEOJNOOHDD);
		}
		if (EMPIGIEDOMO != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EMPIGIEDOMO);
		}
		if (ICLJEMJOOLP != 0f)
		{
			num += 6;
		}
		if (AKHDCMLBGKN != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AKHDCMLBGKN);
		}
		if (CCNJKIAOMFF != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CCNJKIAOMFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCNFGGMIKJF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Attack != 0)
		{
			Attack = other.Attack;
		}
		if (other.MaxHp != 0)
		{
			MaxHp = other.MaxHp;
		}
		if (other.MLDGPGGEDBK != DFKBFAICDJG.Pcmnnonnjio)
		{
			MLDGPGGEDBK = other.MLDGPGGEDBK;
		}
		if (other.Time != 0f)
		{
			Time = other.Time;
		}
		if (other.SkillId != 0)
		{
			SkillId = other.SkillId;
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		if (other.KDJEEKJBPAO != 0)
		{
			KDJEEKJBPAO = other.KDJEEKJBPAO;
		}
		if (other.BCIEHPOHPDP != 0)
		{
			BCIEHPOHPDP = other.BCIEHPOHPDP;
		}
		if (other.iKAGBDAAMAG_ != null)
		{
			if (iKAGBDAAMAG_ == null)
			{
				IKAGBDAAMAG = new KGCLNMHAAMM();
			}
			IKAGBDAAMAG.MergeFrom(other.IKAGBDAAMAG);
		}
		if (other.oAIMADEEEPE_ != null)
		{
			if (oAIMADEEEPE_ == null)
			{
				OAIMADEEEPE = new KGCLNMHAAMM();
			}
			OAIMADEEEPE.MergeFrom(other.OAIMADEEEPE);
		}
		if (other.JALKBDBKOKC != GPIOFJJJAMF.Dbihmnglogl)
		{
			JALKBDBKOKC = other.JALKBDBKOKC;
		}
		if (other.mBAFIOCLMAI_ != null)
		{
			if (mBAFIOCLMAI_ == null)
			{
				MBAFIOCLMAI = new KGCLNMHAAMM();
			}
			MBAFIOCLMAI.MergeFrom(other.MBAFIOCLMAI);
		}
		if (other.iJJAKDLIPAL_ != null)
		{
			if (iJJAKDLIPAL_ == null)
			{
				IJJAKDLIPAL = new KGCLNMHAAMM();
			}
			IJJAKDLIPAL.MergeFrom(other.IJJAKDLIPAL);
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.gFKKHOIMECF_ != null)
		{
			if (gFKKHOIMECF_ == null)
			{
				GFKKHOIMECF = new KGCLNMHAAMM();
			}
			GFKKHOIMECF.MergeFrom(other.GFKKHOIMECF);
		}
		if (other.PIPPIIFDEHA != 0)
		{
			PIPPIIFDEHA = other.PIPPIIFDEHA;
		}
		if (other.OLKBHJNOIAD)
		{
			OLKBHJNOIAD = other.OLKBHJNOIAD;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.KHNNELPGKIM != 0f)
		{
			KHNNELPGKIM = other.KHNNELPGKIM;
		}
		if (other.IPACGBDKFNA)
		{
			IPACGBDKFNA = other.IPACGBDKFNA;
		}
		if (other.NBEKCEIHJAC)
		{
			NBEKCEIHJAC = other.NBEKCEIHJAC;
		}
		if (other.TextId != 0)
		{
			TextId = other.TextId;
		}
		if (other.KFAEMIBBPHA != 0)
		{
			KFAEMIBBPHA = other.KFAEMIBBPHA;
		}
		if (other.PGOIGOFLCDG != FightMarbleHpChangeType.AghlhafiaejOppeoekldcj)
		{
			PGOIGOFLCDG = other.PGOIGOFLCDG;
		}
		if (other.APEBCDDKGOG != 0)
		{
			APEBCDDKGOG = other.APEBCDDKGOG;
		}
		if (other.BuffId != 0)
		{
			BuffId = other.BuffId;
		}
		if (other.HPEOJNOOHDD != 0)
		{
			HPEOJNOOHDD = other.HPEOJNOOHDD;
		}
		if (other.EMPIGIEDOMO != 0)
		{
			EMPIGIEDOMO = other.EMPIGIEDOMO;
		}
		if (other.ICLJEMJOOLP != 0f)
		{
			ICLJEMJOOLP = other.ICLJEMJOOLP;
		}
		if (other.AKHDCMLBGKN != 0)
		{
			AKHDCMLBGKN = other.AKHDCMLBGKN;
		}
		if (other.CCNJKIAOMFF != 0)
		{
			CCNJKIAOMFF = other.CCNJKIAOMFF;
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
				Attack = input.ReadInt32();
				break;
			case 16u:
				MaxHp = input.ReadInt32();
				break;
			case 24u:
				MLDGPGGEDBK = (DFKBFAICDJG)input.ReadEnum();
				break;
			case 37u:
				Time = input.ReadFloat();
				break;
			case 40u:
				SkillId = input.ReadUInt32();
				break;
			case 48u:
				Hp = input.ReadInt32();
				break;
			case 56u:
				KDJEEKJBPAO = input.ReadUInt32();
				break;
			case 64u:
				BCIEHPOHPDP = input.ReadUInt32();
				break;
			case 74u:
				if (iKAGBDAAMAG_ == null)
				{
					IKAGBDAAMAG = new KGCLNMHAAMM();
				}
				input.ReadMessage(IKAGBDAAMAG);
				break;
			case 82u:
				if (oAIMADEEEPE_ == null)
				{
					OAIMADEEEPE = new KGCLNMHAAMM();
				}
				input.ReadMessage(OAIMADEEEPE);
				break;
			case 88u:
				JALKBDBKOKC = (GPIOFJJJAMF)input.ReadEnum();
				break;
			case 98u:
				if (mBAFIOCLMAI_ == null)
				{
					MBAFIOCLMAI = new KGCLNMHAAMM();
				}
				input.ReadMessage(MBAFIOCLMAI);
				break;
			case 106u:
				if (iJJAKDLIPAL_ == null)
				{
					IJJAKDLIPAL = new KGCLNMHAAMM();
				}
				input.ReadMessage(IJJAKDLIPAL);
				break;
			case 112u:
				Id = input.ReadUInt32();
				break;
			case 122u:
				if (gFKKHOIMECF_ == null)
				{
					GFKKHOIMECF = new KGCLNMHAAMM();
				}
				input.ReadMessage(GFKKHOIMECF);
				break;
			case 1976u:
				PIPPIIFDEHA = input.ReadUInt32();
				break;
			case 3888u:
				OLKBHJNOIAD = input.ReadBool();
				break;
			case 4280u:
				Level = input.ReadUInt32();
				break;
			case 4901u:
				KHNNELPGKIM = input.ReadFloat();
				break;
			case 5488u:
				IPACGBDKFNA = input.ReadBool();
				break;
			case 5648u:
				NBEKCEIHJAC = input.ReadBool();
				break;
			case 5776u:
				TextId = input.ReadUInt32();
				break;
			case 6104u:
				KFAEMIBBPHA = input.ReadUInt32();
				break;
			case 7280u:
				PGOIGOFLCDG = (FightMarbleHpChangeType)input.ReadEnum();
				break;
			case 8120u:
				APEBCDDKGOG = input.ReadUInt32();
				break;
			case 9152u:
				BuffId = input.ReadUInt32();
				break;
			case 11168u:
				HPEOJNOOHDD = input.ReadUInt32();
				break;
			case 12928u:
				EMPIGIEDOMO = input.ReadUInt32();
				break;
			case 14029u:
				ICLJEMJOOLP = input.ReadFloat();
				break;
			case 15968u:
				AKHDCMLBGKN = input.ReadUInt32();
				break;
			case 16224u:
				CCNJKIAOMFF = input.ReadInt32();
				break;
			}
		}
	}
}
