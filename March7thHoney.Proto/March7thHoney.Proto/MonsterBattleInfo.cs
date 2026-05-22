using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonsterBattleInfo : IMessage<MonsterBattleInfo>, IMessage, IEquatable<MonsterBattleInfo>, IDeepCloneable<MonsterBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<MonsterBattleInfo> _parser = new MessageParser<MonsterBattleInfo>(() => new MonsterBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int EntityIdFieldNumber = 1;

	private uint entityId_;

	public const int MonsterIdFieldNumber = 2;

	private uint monsterId_;

	public const int MNBLHKKMPNPFieldNumber = 3;

	private uint mNBLHKKMPNP_;

	public const int HPJNJGIOHDHFieldNumber = 4;

	private uint hPJNJGIOHDH_;

	public const int PLCHOKLFMFGFieldNumber = 5;

	private AMBFIEKDCEL pLCHOKLFMFG_;

	public const int TotalTurnsFieldNumber = 6;

	private uint totalTurns_;

	public const int TotalDamageFieldNumber = 7;

	private double totalDamage_;

	public const int TotalHealFieldNumber = 8;

	private double totalHeal_;

	public const int TotalDamageTakenFieldNumber = 9;

	private double totalDamageTaken_;

	public const int HGPLBOCPAEGFieldNumber = 10;

	private double hGPLBOCPAEG_;

	public const int TotalHpRecoverFieldNumber = 11;

	private double totalHpRecover_;

	public const int StageIdFieldNumber = 12;

	private uint stageId_;

	public const int BattleIdFieldNumber = 13;

	private uint battleId_;

	public const int KEIDACJFFFCFieldNumber = 14;

	private uint kEIDACJFFFC_;

	public const int AttackTypeDamageFieldNumber = 15;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeDamage_codec = FieldCodec.ForMessage(122u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int SkillTimesFieldNumber = 16;

	private static readonly FieldCodec<SkillUseProperty> _repeated_skillTimes_codec = FieldCodec.ForMessage(130u, SkillUseProperty.Parser);

	private readonly RepeatedField<SkillUseProperty> skillTimes_ = new RepeatedField<SkillUseProperty>();

	public const int StageTypeFieldNumber = 17;

	private uint stageType_;

	public const int JOJFNAMMBMEFieldNumber = 18;

	private double jOJFNAMMBME_;

	public const int DelayCumulateFieldNumber = 19;

	private double delayCumulate_;

	public const int GOMECPDAKFNFieldNumber = 20;

	private FBKBOKHCLLF gOMECPDAKFN_;

	public const int WaveFieldNumber = 21;

	private uint wave_;

	public const int CHBKGGOACEBFieldNumber = 22;

	private int cHBKGGOACEB_;

	public const int PhaseFieldNumber = 23;

	private uint phase_;

	public const int PMCNNECCCPLFieldNumber = 24;

	private uint pMCNNECCCPL_;

	public const int MHFMAELFPLDFieldNumber = 25;

	private OFKHIHFBNFG mHFMAELFPLD_;

	public const int SkillInfoFieldNumber = 26;

	private static readonly FieldCodec<PLDMGGBPHPB> _repeated_skillInfo_codec = FieldCodec.ForMessage(210u, PLDMGGBPHPB.Parser);

	private readonly RepeatedField<PLDMGGBPHPB> skillInfo_ = new RepeatedField<PLDMGGBPHPB>();

	public const int GKDGFLCOHOAFieldNumber = 27;

	private uint gKDGFLCOHOA_;

	public const int IGAFLCKJJKMFieldNumber = 28;

	private static readonly FieldCodec<PGPELNFKOMD> _repeated_iGAFLCKJJKM_codec = FieldCodec.ForMessage(226u, PGPELNFKOMD.Parser);

	private readonly RepeatedField<PGPELNFKOMD> iGAFLCKJJKM_ = new RepeatedField<PGPELNFKOMD>();

	public const int IOGCDGLFLCBFieldNumber = 29;

	private uint iOGCDGLFLCB_;

	public const int OFHLNFPMPHHFieldNumber = 30;

	private uint oFHLNFPMPHH_;

	public const int GJCKGLLEGAEFieldNumber = 31;

	private LEPDLLJHIPL gJCKGLLEGAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntityId
	{
		get
		{
			return entityId_;
		}
		set
		{
			entityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNBLHKKMPNP
	{
		get
		{
			return mNBLHKKMPNP_;
		}
		set
		{
			mNBLHKKMPNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HPJNJGIOHDH
	{
		get
		{
			return hPJNJGIOHDH_;
		}
		set
		{
			hPJNJGIOHDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMBFIEKDCEL PLCHOKLFMFG
	{
		get
		{
			return pLCHOKLFMFG_;
		}
		set
		{
			pLCHOKLFMFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalTurns
	{
		get
		{
			return totalTurns_;
		}
		set
		{
			totalTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalHeal
	{
		get
		{
			return totalHeal_;
		}
		set
		{
			totalHeal_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamageTaken
	{
		get
		{
			return totalDamageTaken_;
		}
		set
		{
			totalDamageTaken_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double HGPLBOCPAEG
	{
		get
		{
			return hGPLBOCPAEG_;
		}
		set
		{
			hGPLBOCPAEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalHpRecover
	{
		get
		{
			return totalHpRecover_;
		}
		set
		{
			totalHpRecover_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEIDACJFFFC
	{
		get
		{
			return kEIDACJFFFC_;
		}
		set
		{
			kEIDACJFFFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeDamage => attackTypeDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SkillUseProperty> SkillTimes => skillTimes_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageType
	{
		get
		{
			return stageType_;
		}
		set
		{
			stageType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double JOJFNAMMBME
	{
		get
		{
			return jOJFNAMMBME_;
		}
		set
		{
			jOJFNAMMBME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DelayCumulate
	{
		get
		{
			return delayCumulate_;
		}
		set
		{
			delayCumulate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBKBOKHCLLF GOMECPDAKFN
	{
		get
		{
			return gOMECPDAKFN_;
		}
		set
		{
			gOMECPDAKFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CHBKGGOACEB
	{
		get
		{
			return cHBKGGOACEB_;
		}
		set
		{
			cHBKGGOACEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Phase
	{
		get
		{
			return phase_;
		}
		set
		{
			phase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMCNNECCCPL
	{
		get
		{
			return pMCNNECCCPL_;
		}
		set
		{
			pMCNNECCCPL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFKHIHFBNFG MHFMAELFPLD
	{
		get
		{
			return mHFMAELFPLD_;
		}
		set
		{
			mHFMAELFPLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PLDMGGBPHPB> SkillInfo => skillInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKDGFLCOHOA
	{
		get
		{
			return gKDGFLCOHOA_;
		}
		set
		{
			gKDGFLCOHOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PGPELNFKOMD> IGAFLCKJJKM => iGAFLCKJJKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IOGCDGLFLCB
	{
		get
		{
			return iOGCDGLFLCB_;
		}
		set
		{
			iOGCDGLFLCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHLNFPMPHH
	{
		get
		{
			return oFHLNFPMPHH_;
		}
		set
		{
			oFHLNFPMPHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEPDLLJHIPL GJCKGLLEGAE
	{
		get
		{
			return gJCKGLLEGAE_;
		}
		set
		{
			gJCKGLLEGAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterBattleInfo(MonsterBattleInfo other)
		: this()
	{
		entityId_ = other.entityId_;
		monsterId_ = other.monsterId_;
		mNBLHKKMPNP_ = other.mNBLHKKMPNP_;
		hPJNJGIOHDH_ = other.hPJNJGIOHDH_;
		pLCHOKLFMFG_ = ((other.pLCHOKLFMFG_ != null) ? other.pLCHOKLFMFG_.Clone() : null);
		totalTurns_ = other.totalTurns_;
		totalDamage_ = other.totalDamage_;
		totalHeal_ = other.totalHeal_;
		totalDamageTaken_ = other.totalDamageTaken_;
		hGPLBOCPAEG_ = other.hGPLBOCPAEG_;
		totalHpRecover_ = other.totalHpRecover_;
		stageId_ = other.stageId_;
		battleId_ = other.battleId_;
		kEIDACJFFFC_ = other.kEIDACJFFFC_;
		attackTypeDamage_ = other.attackTypeDamage_.Clone();
		skillTimes_ = other.skillTimes_.Clone();
		stageType_ = other.stageType_;
		jOJFNAMMBME_ = other.jOJFNAMMBME_;
		delayCumulate_ = other.delayCumulate_;
		gOMECPDAKFN_ = other.gOMECPDAKFN_;
		wave_ = other.wave_;
		cHBKGGOACEB_ = other.cHBKGGOACEB_;
		phase_ = other.phase_;
		pMCNNECCCPL_ = other.pMCNNECCCPL_;
		mHFMAELFPLD_ = other.mHFMAELFPLD_;
		skillInfo_ = other.skillInfo_.Clone();
		gKDGFLCOHOA_ = other.gKDGFLCOHOA_;
		iGAFLCKJJKM_ = other.iGAFLCKJJKM_.Clone();
		iOGCDGLFLCB_ = other.iOGCDGLFLCB_;
		oFHLNFPMPHH_ = other.oFHLNFPMPHH_;
		gJCKGLLEGAE_ = other.gJCKGLLEGAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterBattleInfo Clone()
	{
		return new MonsterBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EntityId != other.EntityId)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (MNBLHKKMPNP != other.MNBLHKKMPNP)
		{
			return false;
		}
		if (HPJNJGIOHDH != other.HPJNJGIOHDH)
		{
			return false;
		}
		if (!object.Equals(PLCHOKLFMFG, other.PLCHOKLFMFG))
		{
			return false;
		}
		if (TotalTurns != other.TotalTurns)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalHeal, other.TotalHeal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamageTaken, other.TotalDamageTaken))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HGPLBOCPAEG, other.HGPLBOCPAEG))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalHpRecover, other.TotalHpRecover))
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (KEIDACJFFFC != other.KEIDACJFFFC)
		{
			return false;
		}
		if (!attackTypeDamage_.Equals(other.attackTypeDamage_))
		{
			return false;
		}
		if (!skillTimes_.Equals(other.skillTimes_))
		{
			return false;
		}
		if (StageType != other.StageType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(JOJFNAMMBME, other.JOJFNAMMBME))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DelayCumulate, other.DelayCumulate))
		{
			return false;
		}
		if (GOMECPDAKFN != other.GOMECPDAKFN)
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (CHBKGGOACEB != other.CHBKGGOACEB)
		{
			return false;
		}
		if (Phase != other.Phase)
		{
			return false;
		}
		if (PMCNNECCCPL != other.PMCNNECCCPL)
		{
			return false;
		}
		if (MHFMAELFPLD != other.MHFMAELFPLD)
		{
			return false;
		}
		if (!skillInfo_.Equals(other.skillInfo_))
		{
			return false;
		}
		if (GKDGFLCOHOA != other.GKDGFLCOHOA)
		{
			return false;
		}
		if (!iGAFLCKJJKM_.Equals(other.iGAFLCKJJKM_))
		{
			return false;
		}
		if (IOGCDGLFLCB != other.IOGCDGLFLCB)
		{
			return false;
		}
		if (OFHLNFPMPHH != other.OFHLNFPMPHH)
		{
			return false;
		}
		if (GJCKGLLEGAE != other.GJCKGLLEGAE)
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
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (MNBLHKKMPNP != 0)
		{
			num ^= MNBLHKKMPNP.GetHashCode();
		}
		if (HPJNJGIOHDH != 0)
		{
			num ^= HPJNJGIOHDH.GetHashCode();
		}
		if (pLCHOKLFMFG_ != null)
		{
			num ^= PLCHOKLFMFG.GetHashCode();
		}
		if (TotalTurns != 0)
		{
			num ^= TotalTurns.GetHashCode();
		}
		if (TotalDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamage);
		}
		if (TotalHeal != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalHeal);
		}
		if (TotalDamageTaken != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamageTaken);
		}
		if (HGPLBOCPAEG != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HGPLBOCPAEG);
		}
		if (TotalHpRecover != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalHpRecover);
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
		}
		if (KEIDACJFFFC != 0)
		{
			num ^= KEIDACJFFFC.GetHashCode();
		}
		num ^= attackTypeDamage_.GetHashCode();
		num ^= skillTimes_.GetHashCode();
		if (StageType != 0)
		{
			num ^= StageType.GetHashCode();
		}
		if (JOJFNAMMBME != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(JOJFNAMMBME);
		}
		if (DelayCumulate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DelayCumulate);
		}
		if (GOMECPDAKFN != FBKBOKHCLLF.Nmjbkomipnp)
		{
			num ^= GOMECPDAKFN.GetHashCode();
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (CHBKGGOACEB != 0)
		{
			num ^= CHBKGGOACEB.GetHashCode();
		}
		if (Phase != 0)
		{
			num ^= Phase.GetHashCode();
		}
		if (PMCNNECCCPL != 0)
		{
			num ^= PMCNNECCCPL.GetHashCode();
		}
		if (MHFMAELFPLD != OFKHIHFBNFG.Ceilokjmacj)
		{
			num ^= MHFMAELFPLD.GetHashCode();
		}
		num ^= skillInfo_.GetHashCode();
		if (GKDGFLCOHOA != 0)
		{
			num ^= GKDGFLCOHOA.GetHashCode();
		}
		num ^= iGAFLCKJJKM_.GetHashCode();
		if (IOGCDGLFLCB != 0)
		{
			num ^= IOGCDGLFLCB.GetHashCode();
		}
		if (OFHLNFPMPHH != 0)
		{
			num ^= OFHLNFPMPHH.GetHashCode();
		}
		if (GJCKGLLEGAE != LEPDLLJHIPL.Ldhliijjodp)
		{
			num ^= GJCKGLLEGAE.GetHashCode();
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
		if (EntityId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EntityId);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MonsterId);
		}
		if (MNBLHKKMPNP != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MNBLHKKMPNP);
		}
		if (HPJNJGIOHDH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HPJNJGIOHDH);
		}
		if (pLCHOKLFMFG_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PLCHOKLFMFG);
		}
		if (TotalTurns != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(TotalTurns);
		}
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(TotalDamage);
		}
		if (TotalHeal != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(TotalHeal);
		}
		if (TotalDamageTaken != 0.0)
		{
			output.WriteRawTag(73);
			output.WriteDouble(TotalDamageTaken);
		}
		if (HGPLBOCPAEG != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(HGPLBOCPAEG);
		}
		if (TotalHpRecover != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(TotalHpRecover);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(StageId);
		}
		if (BattleId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BattleId);
		}
		if (KEIDACJFFFC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KEIDACJFFFC);
		}
		attackTypeDamage_.WriteTo(ref output, _repeated_attackTypeDamage_codec);
		skillTimes_.WriteTo(ref output, _repeated_skillTimes_codec);
		if (StageType != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(StageType);
		}
		if (JOJFNAMMBME != 0.0)
		{
			output.WriteRawTag(145, 1);
			output.WriteDouble(JOJFNAMMBME);
		}
		if (DelayCumulate != 0.0)
		{
			output.WriteRawTag(153, 1);
			output.WriteDouble(DelayCumulate);
		}
		if (GOMECPDAKFN != FBKBOKHCLLF.Nmjbkomipnp)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)GOMECPDAKFN);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteUInt32(Wave);
		}
		if (CHBKGGOACEB != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(CHBKGGOACEB);
		}
		if (Phase != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteUInt32(Phase);
		}
		if (PMCNNECCCPL != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteUInt32(PMCNNECCCPL);
		}
		if (MHFMAELFPLD != OFKHIHFBNFG.Ceilokjmacj)
		{
			output.WriteRawTag(200, 1);
			output.WriteEnum((int)MHFMAELFPLD);
		}
		skillInfo_.WriteTo(ref output, _repeated_skillInfo_codec);
		if (GKDGFLCOHOA != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteUInt32(GKDGFLCOHOA);
		}
		iGAFLCKJJKM_.WriteTo(ref output, _repeated_iGAFLCKJJKM_codec);
		if (IOGCDGLFLCB != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteUInt32(IOGCDGLFLCB);
		}
		if (OFHLNFPMPHH != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteUInt32(OFHLNFPMPHH);
		}
		if (GJCKGLLEGAE != LEPDLLJHIPL.Ldhliijjodp)
		{
			output.WriteRawTag(248, 1);
			output.WriteEnum((int)GJCKGLLEGAE);
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
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (MNBLHKKMPNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNBLHKKMPNP);
		}
		if (HPJNJGIOHDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HPJNJGIOHDH);
		}
		if (pLCHOKLFMFG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLCHOKLFMFG);
		}
		if (TotalTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalTurns);
		}
		if (TotalDamage != 0.0)
		{
			num += 9;
		}
		if (TotalHeal != 0.0)
		{
			num += 9;
		}
		if (TotalDamageTaken != 0.0)
		{
			num += 9;
		}
		if (HGPLBOCPAEG != 0.0)
		{
			num += 9;
		}
		if (TotalHpRecover != 0.0)
		{
			num += 9;
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (KEIDACJFFFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEIDACJFFFC);
		}
		num += attackTypeDamage_.CalculateSize(_repeated_attackTypeDamage_codec);
		num += skillTimes_.CalculateSize(_repeated_skillTimes_codec);
		if (StageType != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(StageType);
		}
		if (JOJFNAMMBME != 0.0)
		{
			num += 10;
		}
		if (DelayCumulate != 0.0)
		{
			num += 10;
		}
		if (GOMECPDAKFN != FBKBOKHCLLF.Nmjbkomipnp)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)GOMECPDAKFN);
		}
		if (Wave != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (CHBKGGOACEB != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CHBKGGOACEB);
		}
		if (Phase != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(Phase);
		}
		if (PMCNNECCCPL != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PMCNNECCCPL);
		}
		if (MHFMAELFPLD != OFKHIHFBNFG.Ceilokjmacj)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)MHFMAELFPLD);
		}
		num += skillInfo_.CalculateSize(_repeated_skillInfo_codec);
		if (GKDGFLCOHOA != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GKDGFLCOHOA);
		}
		num += iGAFLCKJJKM_.CalculateSize(_repeated_iGAFLCKJJKM_codec);
		if (IOGCDGLFLCB != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(IOGCDGLFLCB);
		}
		if (OFHLNFPMPHH != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(OFHLNFPMPHH);
		}
		if (GJCKGLLEGAE != LEPDLLJHIPL.Ldhliijjodp)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)GJCKGLLEGAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterBattleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
		}
		if (other.MonsterId != 0)
		{
			MonsterId = other.MonsterId;
		}
		if (other.MNBLHKKMPNP != 0)
		{
			MNBLHKKMPNP = other.MNBLHKKMPNP;
		}
		if (other.HPJNJGIOHDH != 0)
		{
			HPJNJGIOHDH = other.HPJNJGIOHDH;
		}
		if (other.pLCHOKLFMFG_ != null)
		{
			if (pLCHOKLFMFG_ == null)
			{
				PLCHOKLFMFG = new AMBFIEKDCEL();
			}
			PLCHOKLFMFG.MergeFrom(other.PLCHOKLFMFG);
		}
		if (other.TotalTurns != 0)
		{
			TotalTurns = other.TotalTurns;
		}
		if (other.TotalDamage != 0.0)
		{
			TotalDamage = other.TotalDamage;
		}
		if (other.TotalHeal != 0.0)
		{
			TotalHeal = other.TotalHeal;
		}
		if (other.TotalDamageTaken != 0.0)
		{
			TotalDamageTaken = other.TotalDamageTaken;
		}
		if (other.HGPLBOCPAEG != 0.0)
		{
			HGPLBOCPAEG = other.HGPLBOCPAEG;
		}
		if (other.TotalHpRecover != 0.0)
		{
			TotalHpRecover = other.TotalHpRecover;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.BattleId != 0)
		{
			BattleId = other.BattleId;
		}
		if (other.KEIDACJFFFC != 0)
		{
			KEIDACJFFFC = other.KEIDACJFFFC;
		}
		attackTypeDamage_.Add(other.attackTypeDamage_);
		skillTimes_.Add(other.skillTimes_);
		if (other.StageType != 0)
		{
			StageType = other.StageType;
		}
		if (other.JOJFNAMMBME != 0.0)
		{
			JOJFNAMMBME = other.JOJFNAMMBME;
		}
		if (other.DelayCumulate != 0.0)
		{
			DelayCumulate = other.DelayCumulate;
		}
		if (other.GOMECPDAKFN != FBKBOKHCLLF.Nmjbkomipnp)
		{
			GOMECPDAKFN = other.GOMECPDAKFN;
		}
		if (other.Wave != 0)
		{
			Wave = other.Wave;
		}
		if (other.CHBKGGOACEB != 0)
		{
			CHBKGGOACEB = other.CHBKGGOACEB;
		}
		if (other.Phase != 0)
		{
			Phase = other.Phase;
		}
		if (other.PMCNNECCCPL != 0)
		{
			PMCNNECCCPL = other.PMCNNECCCPL;
		}
		if (other.MHFMAELFPLD != OFKHIHFBNFG.Ceilokjmacj)
		{
			MHFMAELFPLD = other.MHFMAELFPLD;
		}
		skillInfo_.Add(other.skillInfo_);
		if (other.GKDGFLCOHOA != 0)
		{
			GKDGFLCOHOA = other.GKDGFLCOHOA;
		}
		iGAFLCKJJKM_.Add(other.iGAFLCKJJKM_);
		if (other.IOGCDGLFLCB != 0)
		{
			IOGCDGLFLCB = other.IOGCDGLFLCB;
		}
		if (other.OFHLNFPMPHH != 0)
		{
			OFHLNFPMPHH = other.OFHLNFPMPHH;
		}
		if (other.GJCKGLLEGAE != LEPDLLJHIPL.Ldhliijjodp)
		{
			GJCKGLLEGAE = other.GJCKGLLEGAE;
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
				EntityId = input.ReadUInt32();
				break;
			case 16u:
				MonsterId = input.ReadUInt32();
				break;
			case 24u:
				MNBLHKKMPNP = input.ReadUInt32();
				break;
			case 32u:
				HPJNJGIOHDH = input.ReadUInt32();
				break;
			case 42u:
				if (pLCHOKLFMFG_ == null)
				{
					PLCHOKLFMFG = new AMBFIEKDCEL();
				}
				input.ReadMessage(PLCHOKLFMFG);
				break;
			case 48u:
				TotalTurns = input.ReadUInt32();
				break;
			case 57u:
				TotalDamage = input.ReadDouble();
				break;
			case 65u:
				TotalHeal = input.ReadDouble();
				break;
			case 73u:
				TotalDamageTaken = input.ReadDouble();
				break;
			case 81u:
				HGPLBOCPAEG = input.ReadDouble();
				break;
			case 89u:
				TotalHpRecover = input.ReadDouble();
				break;
			case 96u:
				StageId = input.ReadUInt32();
				break;
			case 104u:
				BattleId = input.ReadUInt32();
				break;
			case 112u:
				KEIDACJFFFC = input.ReadUInt32();
				break;
			case 122u:
				attackTypeDamage_.AddEntriesFrom(ref input, _repeated_attackTypeDamage_codec);
				break;
			case 130u:
				skillTimes_.AddEntriesFrom(ref input, _repeated_skillTimes_codec);
				break;
			case 136u:
				StageType = input.ReadUInt32();
				break;
			case 145u:
				JOJFNAMMBME = input.ReadDouble();
				break;
			case 153u:
				DelayCumulate = input.ReadDouble();
				break;
			case 160u:
				GOMECPDAKFN = (FBKBOKHCLLF)input.ReadEnum();
				break;
			case 168u:
				Wave = input.ReadUInt32();
				break;
			case 176u:
				CHBKGGOACEB = input.ReadInt32();
				break;
			case 184u:
				Phase = input.ReadUInt32();
				break;
			case 192u:
				PMCNNECCCPL = input.ReadUInt32();
				break;
			case 200u:
				MHFMAELFPLD = (OFKHIHFBNFG)input.ReadEnum();
				break;
			case 210u:
				skillInfo_.AddEntriesFrom(ref input, _repeated_skillInfo_codec);
				break;
			case 216u:
				GKDGFLCOHOA = input.ReadUInt32();
				break;
			case 226u:
				iGAFLCKJJKM_.AddEntriesFrom(ref input, _repeated_iGAFLCKJJKM_codec);
				break;
			case 232u:
				IOGCDGLFLCB = input.ReadUInt32();
				break;
			case 240u:
				OFHLNFPMPHH = input.ReadUInt32();
				break;
			case 248u:
				GJCKGLLEGAE = (LEPDLLJHIPL)input.ReadEnum();
				break;
			}
		}
	}
}
