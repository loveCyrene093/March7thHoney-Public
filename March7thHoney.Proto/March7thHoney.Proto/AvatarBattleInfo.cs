using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AvatarBattleInfo : IMessage<AvatarBattleInfo>, IMessage, IEquatable<AvatarBattleInfo>, IDeepCloneable<AvatarBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<AvatarBattleInfo> _parser = new MessageParser<AvatarBattleInfo>(() => new AvatarBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int AvatarTypeFieldNumber = 1;

	private AvatarType avatarType_;

	public const int IdFieldNumber = 2;

	private uint id_;

	public const int AvatarLevelFieldNumber = 3;

	private uint avatarLevel_;

	public const int AvatarRankFieldNumber = 4;

	private uint avatarRank_;

	public const int AvatarPromotionFieldNumber = 5;

	private uint avatarPromotion_;

	public const int AvatarStatusFieldNumber = 6;

	private AvatarProperty avatarStatus_;

	public const int AvatarSkillFieldNumber = 7;

	private static readonly FieldCodec<AvatarSkillTree> _repeated_avatarSkill_codec = FieldCodec.ForMessage(58u, AvatarSkillTree.Parser);

	private readonly RepeatedField<AvatarSkillTree> avatarSkill_ = new RepeatedField<AvatarSkillTree>();

	public const int AvatarEquipmentFieldNumber = 8;

	private static readonly FieldCodec<EquipmentProperty> _repeated_avatarEquipment_codec = FieldCodec.ForMessage(66u, EquipmentProperty.Parser);

	private readonly RepeatedField<EquipmentProperty> avatarEquipment_ = new RepeatedField<EquipmentProperty>();

	public const int TotalTurnsFieldNumber = 9;

	private uint totalTurns_;

	public const int TotalDamageFieldNumber = 10;

	private double totalDamage_;

	public const int TotalHealFieldNumber = 11;

	private double totalHeal_;

	public const int TotalDamageTakenFieldNumber = 12;

	private double totalDamageTaken_;

	public const int TotalHpRecoverFieldNumber = 13;

	private double totalHpRecover_;

	public const int TotalSpCostFieldNumber = 14;

	private double totalSpCost_;

	public const int StageIdFieldNumber = 15;

	private uint stageId_;

	public const int StageTypeFieldNumber = 16;

	private uint stageType_;

	public const int TotalBreakDamageFieldNumber = 17;

	private double totalBreakDamage_;

	public const int AttackTypeDamageFieldNumber = 18;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeDamage_codec = FieldCodec.ForMessage(146u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int AttackTypeBreakDamageFieldNumber = 19;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeBreakDamage_codec = FieldCodec.ForMessage(154u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeBreakDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int AttackTypeMaxDamageFieldNumber = 20;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeMaxDamage_codec = FieldCodec.ForMessage(162u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeMaxDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int SkillTimesFieldNumber = 21;

	private static readonly FieldCodec<SkillUseProperty> _repeated_skillTimes_codec = FieldCodec.ForMessage(170u, SkillUseProperty.Parser);

	private readonly RepeatedField<SkillUseProperty> skillTimes_ = new RepeatedField<SkillUseProperty>();

	public const int DelayCumulateFieldNumber = 22;

	private double delayCumulate_;

	public const int TotalSpAddFieldNumber = 23;

	private uint totalSpAdd_;

	public const int SpAddSourceFieldNumber = 24;

	private static readonly FieldCodec<SpAddSource> _repeated_spAddSource_codec = FieldCodec.ForMessage(194u, March7thHoney.Proto.SpAddSource.Parser);

	private readonly RepeatedField<SpAddSource> spAddSource_ = new RepeatedField<SpAddSource>();

	public const int TotalBpCostFieldNumber = 25;

	private uint totalBpCost_;

	public const int DieTimesFieldNumber = 26;

	private uint dieTimes_;

	public const int ReviveTimesFieldNumber = 27;

	private uint reviveTimes_;

	public const int BreakTimesFieldNumber = 28;

	private uint breakTimes_;

	public const int ExtraTurnsFieldNumber = 29;

	private uint extraTurns_;

	public const int TotalShieldFieldNumber = 30;

	private double totalShield_;

	public const int TotalShieldTakenFieldNumber = 31;

	private double totalShieldTaken_;

	public const int TotalShieldDamageFieldNumber = 32;

	private double totalShieldDamage_;

	public const int InitialStatusFieldNumber = 33;

	private AvatarProperty initialStatus_;

	public const int RelicsFieldNumber = 34;

	private static readonly FieldCodec<BattleRelic> _repeated_relics_codec = FieldCodec.ForMessage(274u, BattleRelic.Parser);

	private readonly RepeatedField<BattleRelic> relics_ = new RepeatedField<BattleRelic>();

	public const int AssistUidFieldNumber = 35;

	private uint assistUid_;

	public const int HLOOFKLELLJFieldNumber = 36;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_hLOOFKLELLJ_codec = FieldCodec.ForMessage(290u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> hLOOFKLELLJ_ = new RepeatedField<AttackDamageProperty>();

	public const int OEJPKJPMKBCFieldNumber = 37;

	private double oEJPKJPMKBC_;

	public const int OGDGEKFJAFOFieldNumber = 38;

	private double oGDGEKFJAFO_;

	public const int AGLKPIJKKGNFieldNumber = 39;

	private double aGLKPIJKKGN_;

	public const int KONMGBJBIEAFieldNumber = 40;

	private double kONMGBJBIEA_;

	public const int GDAHCGCKOBOFieldNumber = 41;

	private static readonly FieldCodec<OEMOCFJLGFI> _repeated_gDAHCGCKOBO_codec = FieldCodec.ForMessage(330u, OEMOCFJLGFI.Parser);

	private readonly RepeatedField<OEMOCFJLGFI> gDAHCGCKOBO_ = new RepeatedField<OEMOCFJLGFI>();

	public const int HOOFEMEKKOBFieldNumber = 42;

	private uint hOOFEMEKKOB_;

	public const int DOAPBOLJOGFFieldNumber = 43;

	private uint dOAPBOLJOGF_;

	public const int FJLIHMDENMLFieldNumber = 44;

	private double fJLIHMDENML_;

	public const int LLCNOCGHJOOFieldNumber = 45;

	private double lLCNOCGHJOO_;

	public const int GFBLNAEHPCHFieldNumber = 46;

	private double gFBLNAEHPCH_;

	public const int KNGOCHGELCEFieldNumber = 47;

	private double kNGOCHGELCE_;

	public const int FODKMBNLCKAFieldNumber = 48;

	private double fODKMBNLCKA_;

	public const int LNIHALFAAGAFieldNumber = 49;

	private uint lNIHALFAAGA_;

	public const int BENJFNNODEFFieldNumber = 50;

	private uint bENJFNNODEF_;

	public const int LBLAJJAFFBHFieldNumber = 51;

	private uint lBLAJJAFFBH_;

	public const int DPDAAIHDGAAFieldNumber = 52;

	private double dPDAAIHDGAA_;

	public const int MGOHBOKJBKDFieldNumber = 53;

	private uint mGOHBOKJBKD_;

	public const int HMIFOFDMCCCFieldNumber = 54;

	private uint hMIFOFDMCCC_;

	public const int EnhancedIdFieldNumber = 55;

	private uint enhancedId_;

	public const int ANMBAIFOBJPFieldNumber = 56;

	private uint aNMBAIFOBJP_;

	public const int NODDDNJAALPFieldNumber = 57;

	private HBFAMLLHFAF nODDDNJAALP_;

	public const int MNHIJDJBKLBFieldNumber = 58;

	private DHNFGJBHMAA mNHIJDJBKLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AvatarBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarType AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
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
	public uint AvatarLevel
	{
		get
		{
			return avatarLevel_;
		}
		set
		{
			avatarLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarRank
	{
		get
		{
			return avatarRank_;
		}
		set
		{
			avatarRank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarPromotion
	{
		get
		{
			return avatarPromotion_;
		}
		set
		{
			avatarPromotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarProperty AvatarStatus
	{
		get
		{
			return avatarStatus_;
		}
		set
		{
			avatarStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarSkillTree> AvatarSkill => avatarSkill_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipmentProperty> AvatarEquipment => avatarEquipment_;

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
	public double TotalSpCost
	{
		get
		{
			return totalSpCost_;
		}
		set
		{
			totalSpCost_ = value;
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
	public double TotalBreakDamage
	{
		get
		{
			return totalBreakDamage_;
		}
		set
		{
			totalBreakDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeDamage => attackTypeDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeBreakDamage => attackTypeBreakDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeMaxDamage => attackTypeMaxDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SkillUseProperty> SkillTimes => skillTimes_;

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
	public uint TotalSpAdd
	{
		get
		{
			return totalSpAdd_;
		}
		set
		{
			totalSpAdd_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SpAddSource> SpAddSource => spAddSource_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalBpCost
	{
		get
		{
			return totalBpCost_;
		}
		set
		{
			totalBpCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DieTimes
	{
		get
		{
			return dieTimes_;
		}
		set
		{
			dieTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ReviveTimes
	{
		get
		{
			return reviveTimes_;
		}
		set
		{
			reviveTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BreakTimes
	{
		get
		{
			return breakTimes_;
		}
		set
		{
			breakTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExtraTurns
	{
		get
		{
			return extraTurns_;
		}
		set
		{
			extraTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalShield
	{
		get
		{
			return totalShield_;
		}
		set
		{
			totalShield_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalShieldTaken
	{
		get
		{
			return totalShieldTaken_;
		}
		set
		{
			totalShieldTaken_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalShieldDamage
	{
		get
		{
			return totalShieldDamage_;
		}
		set
		{
			totalShieldDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarProperty InitialStatus
	{
		get
		{
			return initialStatus_;
		}
		set
		{
			initialStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleRelic> Relics => relics_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AssistUid
	{
		get
		{
			return assistUid_;
		}
		set
		{
			assistUid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> HLOOFKLELLJ => hLOOFKLELLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double OEJPKJPMKBC
	{
		get
		{
			return oEJPKJPMKBC_;
		}
		set
		{
			oEJPKJPMKBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double OGDGEKFJAFO
	{
		get
		{
			return oGDGEKFJAFO_;
		}
		set
		{
			oGDGEKFJAFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double AGLKPIJKKGN
	{
		get
		{
			return aGLKPIJKKGN_;
		}
		set
		{
			aGLKPIJKKGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double KONMGBJBIEA
	{
		get
		{
			return kONMGBJBIEA_;
		}
		set
		{
			kONMGBJBIEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OEMOCFJLGFI> GDAHCGCKOBO => gDAHCGCKOBO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOOFEMEKKOB
	{
		get
		{
			return hOOFEMEKKOB_;
		}
		set
		{
			hOOFEMEKKOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAPBOLJOGF
	{
		get
		{
			return dOAPBOLJOGF_;
		}
		set
		{
			dOAPBOLJOGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double FJLIHMDENML
	{
		get
		{
			return fJLIHMDENML_;
		}
		set
		{
			fJLIHMDENML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double LLCNOCGHJOO
	{
		get
		{
			return lLCNOCGHJOO_;
		}
		set
		{
			lLCNOCGHJOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double GFBLNAEHPCH
	{
		get
		{
			return gFBLNAEHPCH_;
		}
		set
		{
			gFBLNAEHPCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double KNGOCHGELCE
	{
		get
		{
			return kNGOCHGELCE_;
		}
		set
		{
			kNGOCHGELCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double FODKMBNLCKA
	{
		get
		{
			return fODKMBNLCKA_;
		}
		set
		{
			fODKMBNLCKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNIHALFAAGA
	{
		get
		{
			return lNIHALFAAGA_;
		}
		set
		{
			lNIHALFAAGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BENJFNNODEF
	{
		get
		{
			return bENJFNNODEF_;
		}
		set
		{
			bENJFNNODEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBLAJJAFFBH
	{
		get
		{
			return lBLAJJAFFBH_;
		}
		set
		{
			lBLAJJAFFBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DPDAAIHDGAA
	{
		get
		{
			return dPDAAIHDGAA_;
		}
		set
		{
			dPDAAIHDGAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGOHBOKJBKD
	{
		get
		{
			return mGOHBOKJBKD_;
		}
		set
		{
			mGOHBOKJBKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HMIFOFDMCCC
	{
		get
		{
			return hMIFOFDMCCC_;
		}
		set
		{
			hMIFOFDMCCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnhancedId
	{
		get
		{
			return enhancedId_;
		}
		set
		{
			enhancedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANMBAIFOBJP
	{
		get
		{
			return aNMBAIFOBJP_;
		}
		set
		{
			aNMBAIFOBJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBFAMLLHFAF NODDDNJAALP
	{
		get
		{
			return nODDDNJAALP_;
		}
		set
		{
			nODDDNJAALP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHNFGJBHMAA MNHIJDJBKLB
	{
		get
		{
			return mNHIJDJBKLB_;
		}
		set
		{
			mNHIJDJBKLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarBattleInfo(AvatarBattleInfo other)
		: this()
	{
		avatarType_ = other.avatarType_;
		id_ = other.id_;
		avatarLevel_ = other.avatarLevel_;
		avatarRank_ = other.avatarRank_;
		avatarPromotion_ = other.avatarPromotion_;
		avatarStatus_ = ((other.avatarStatus_ != null) ? other.avatarStatus_.Clone() : null);
		avatarSkill_ = other.avatarSkill_.Clone();
		avatarEquipment_ = other.avatarEquipment_.Clone();
		totalTurns_ = other.totalTurns_;
		totalDamage_ = other.totalDamage_;
		totalHeal_ = other.totalHeal_;
		totalDamageTaken_ = other.totalDamageTaken_;
		totalHpRecover_ = other.totalHpRecover_;
		totalSpCost_ = other.totalSpCost_;
		stageId_ = other.stageId_;
		stageType_ = other.stageType_;
		totalBreakDamage_ = other.totalBreakDamage_;
		attackTypeDamage_ = other.attackTypeDamage_.Clone();
		attackTypeBreakDamage_ = other.attackTypeBreakDamage_.Clone();
		attackTypeMaxDamage_ = other.attackTypeMaxDamage_.Clone();
		skillTimes_ = other.skillTimes_.Clone();
		delayCumulate_ = other.delayCumulate_;
		totalSpAdd_ = other.totalSpAdd_;
		spAddSource_ = other.spAddSource_.Clone();
		totalBpCost_ = other.totalBpCost_;
		dieTimes_ = other.dieTimes_;
		reviveTimes_ = other.reviveTimes_;
		breakTimes_ = other.breakTimes_;
		extraTurns_ = other.extraTurns_;
		totalShield_ = other.totalShield_;
		totalShieldTaken_ = other.totalShieldTaken_;
		totalShieldDamage_ = other.totalShieldDamage_;
		initialStatus_ = ((other.initialStatus_ != null) ? other.initialStatus_.Clone() : null);
		relics_ = other.relics_.Clone();
		assistUid_ = other.assistUid_;
		hLOOFKLELLJ_ = other.hLOOFKLELLJ_.Clone();
		oEJPKJPMKBC_ = other.oEJPKJPMKBC_;
		oGDGEKFJAFO_ = other.oGDGEKFJAFO_;
		aGLKPIJKKGN_ = other.aGLKPIJKKGN_;
		kONMGBJBIEA_ = other.kONMGBJBIEA_;
		gDAHCGCKOBO_ = other.gDAHCGCKOBO_.Clone();
		hOOFEMEKKOB_ = other.hOOFEMEKKOB_;
		dOAPBOLJOGF_ = other.dOAPBOLJOGF_;
		fJLIHMDENML_ = other.fJLIHMDENML_;
		lLCNOCGHJOO_ = other.lLCNOCGHJOO_;
		gFBLNAEHPCH_ = other.gFBLNAEHPCH_;
		kNGOCHGELCE_ = other.kNGOCHGELCE_;
		fODKMBNLCKA_ = other.fODKMBNLCKA_;
		lNIHALFAAGA_ = other.lNIHALFAAGA_;
		bENJFNNODEF_ = other.bENJFNNODEF_;
		lBLAJJAFFBH_ = other.lBLAJJAFFBH_;
		dPDAAIHDGAA_ = other.dPDAAIHDGAA_;
		mGOHBOKJBKD_ = other.mGOHBOKJBKD_;
		hMIFOFDMCCC_ = other.hMIFOFDMCCC_;
		enhancedId_ = other.enhancedId_;
		aNMBAIFOBJP_ = other.aNMBAIFOBJP_;
		nODDDNJAALP_ = ((other.nODDDNJAALP_ != null) ? other.nODDDNJAALP_.Clone() : null);
		mNHIJDJBKLB_ = ((other.mNHIJDJBKLB_ != null) ? other.mNHIJDJBKLB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarBattleInfo Clone()
	{
		return new AvatarBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AvatarBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AvatarBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (AvatarLevel != other.AvatarLevel)
		{
			return false;
		}
		if (AvatarRank != other.AvatarRank)
		{
			return false;
		}
		if (AvatarPromotion != other.AvatarPromotion)
		{
			return false;
		}
		if (!object.Equals(AvatarStatus, other.AvatarStatus))
		{
			return false;
		}
		if (!avatarSkill_.Equals(other.avatarSkill_))
		{
			return false;
		}
		if (!avatarEquipment_.Equals(other.avatarEquipment_))
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
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalHpRecover, other.TotalHpRecover))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalSpCost, other.TotalSpCost))
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (StageType != other.StageType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalBreakDamage, other.TotalBreakDamage))
		{
			return false;
		}
		if (!attackTypeDamage_.Equals(other.attackTypeDamage_))
		{
			return false;
		}
		if (!attackTypeBreakDamage_.Equals(other.attackTypeBreakDamage_))
		{
			return false;
		}
		if (!attackTypeMaxDamage_.Equals(other.attackTypeMaxDamage_))
		{
			return false;
		}
		if (!skillTimes_.Equals(other.skillTimes_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DelayCumulate, other.DelayCumulate))
		{
			return false;
		}
		if (TotalSpAdd != other.TotalSpAdd)
		{
			return false;
		}
		if (!spAddSource_.Equals(other.spAddSource_))
		{
			return false;
		}
		if (TotalBpCost != other.TotalBpCost)
		{
			return false;
		}
		if (DieTimes != other.DieTimes)
		{
			return false;
		}
		if (ReviveTimes != other.ReviveTimes)
		{
			return false;
		}
		if (BreakTimes != other.BreakTimes)
		{
			return false;
		}
		if (ExtraTurns != other.ExtraTurns)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalShield, other.TotalShield))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalShieldTaken, other.TotalShieldTaken))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalShieldDamage, other.TotalShieldDamage))
		{
			return false;
		}
		if (!object.Equals(InitialStatus, other.InitialStatus))
		{
			return false;
		}
		if (!relics_.Equals(other.relics_))
		{
			return false;
		}
		if (AssistUid != other.AssistUid)
		{
			return false;
		}
		if (!hLOOFKLELLJ_.Equals(other.hLOOFKLELLJ_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OEJPKJPMKBC, other.OEJPKJPMKBC))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OGDGEKFJAFO, other.OGDGEKFJAFO))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AGLKPIJKKGN, other.AGLKPIJKKGN))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(KONMGBJBIEA, other.KONMGBJBIEA))
		{
			return false;
		}
		if (!gDAHCGCKOBO_.Equals(other.gDAHCGCKOBO_))
		{
			return false;
		}
		if (HOOFEMEKKOB != other.HOOFEMEKKOB)
		{
			return false;
		}
		if (DOAPBOLJOGF != other.DOAPBOLJOGF)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FJLIHMDENML, other.FJLIHMDENML))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LLCNOCGHJOO, other.LLCNOCGHJOO))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GFBLNAEHPCH, other.GFBLNAEHPCH))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(KNGOCHGELCE, other.KNGOCHGELCE))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FODKMBNLCKA, other.FODKMBNLCKA))
		{
			return false;
		}
		if (LNIHALFAAGA != other.LNIHALFAAGA)
		{
			return false;
		}
		if (BENJFNNODEF != other.BENJFNNODEF)
		{
			return false;
		}
		if (LBLAJJAFFBH != other.LBLAJJAFFBH)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DPDAAIHDGAA, other.DPDAAIHDGAA))
		{
			return false;
		}
		if (MGOHBOKJBKD != other.MGOHBOKJBKD)
		{
			return false;
		}
		if (HMIFOFDMCCC != other.HMIFOFDMCCC)
		{
			return false;
		}
		if (EnhancedId != other.EnhancedId)
		{
			return false;
		}
		if (ANMBAIFOBJP != other.ANMBAIFOBJP)
		{
			return false;
		}
		if (!object.Equals(NODDDNJAALP, other.NODDDNJAALP))
		{
			return false;
		}
		if (!object.Equals(MNHIJDJBKLB, other.MNHIJDJBKLB))
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
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (AvatarLevel != 0)
		{
			num ^= AvatarLevel.GetHashCode();
		}
		if (AvatarRank != 0)
		{
			num ^= AvatarRank.GetHashCode();
		}
		if (AvatarPromotion != 0)
		{
			num ^= AvatarPromotion.GetHashCode();
		}
		if (avatarStatus_ != null)
		{
			num ^= AvatarStatus.GetHashCode();
		}
		num ^= avatarSkill_.GetHashCode();
		num ^= avatarEquipment_.GetHashCode();
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
		if (TotalHpRecover != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalHpRecover);
		}
		if (TotalSpCost != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalSpCost);
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (StageType != 0)
		{
			num ^= StageType.GetHashCode();
		}
		if (TotalBreakDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalBreakDamage);
		}
		num ^= attackTypeDamage_.GetHashCode();
		num ^= attackTypeBreakDamage_.GetHashCode();
		num ^= attackTypeMaxDamage_.GetHashCode();
		num ^= skillTimes_.GetHashCode();
		if (DelayCumulate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DelayCumulate);
		}
		if (TotalSpAdd != 0)
		{
			num ^= TotalSpAdd.GetHashCode();
		}
		num ^= spAddSource_.GetHashCode();
		if (TotalBpCost != 0)
		{
			num ^= TotalBpCost.GetHashCode();
		}
		if (DieTimes != 0)
		{
			num ^= DieTimes.GetHashCode();
		}
		if (ReviveTimes != 0)
		{
			num ^= ReviveTimes.GetHashCode();
		}
		if (BreakTimes != 0)
		{
			num ^= BreakTimes.GetHashCode();
		}
		if (ExtraTurns != 0)
		{
			num ^= ExtraTurns.GetHashCode();
		}
		if (TotalShield != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalShield);
		}
		if (TotalShieldTaken != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalShieldTaken);
		}
		if (TotalShieldDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalShieldDamage);
		}
		if (initialStatus_ != null)
		{
			num ^= InitialStatus.GetHashCode();
		}
		num ^= relics_.GetHashCode();
		if (AssistUid != 0)
		{
			num ^= AssistUid.GetHashCode();
		}
		num ^= hLOOFKLELLJ_.GetHashCode();
		if (OEJPKJPMKBC != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OEJPKJPMKBC);
		}
		if (OGDGEKFJAFO != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OGDGEKFJAFO);
		}
		if (AGLKPIJKKGN != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AGLKPIJKKGN);
		}
		if (KONMGBJBIEA != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(KONMGBJBIEA);
		}
		num ^= gDAHCGCKOBO_.GetHashCode();
		if (HOOFEMEKKOB != 0)
		{
			num ^= HOOFEMEKKOB.GetHashCode();
		}
		if (DOAPBOLJOGF != 0)
		{
			num ^= DOAPBOLJOGF.GetHashCode();
		}
		if (FJLIHMDENML != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FJLIHMDENML);
		}
		if (LLCNOCGHJOO != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LLCNOCGHJOO);
		}
		if (GFBLNAEHPCH != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GFBLNAEHPCH);
		}
		if (KNGOCHGELCE != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(KNGOCHGELCE);
		}
		if (FODKMBNLCKA != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FODKMBNLCKA);
		}
		if (LNIHALFAAGA != 0)
		{
			num ^= LNIHALFAAGA.GetHashCode();
		}
		if (BENJFNNODEF != 0)
		{
			num ^= BENJFNNODEF.GetHashCode();
		}
		if (LBLAJJAFFBH != 0)
		{
			num ^= LBLAJJAFFBH.GetHashCode();
		}
		if (DPDAAIHDGAA != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DPDAAIHDGAA);
		}
		if (MGOHBOKJBKD != 0)
		{
			num ^= MGOHBOKJBKD.GetHashCode();
		}
		if (HMIFOFDMCCC != 0)
		{
			num ^= HMIFOFDMCCC.GetHashCode();
		}
		if (EnhancedId != 0)
		{
			num ^= EnhancedId.GetHashCode();
		}
		if (ANMBAIFOBJP != 0)
		{
			num ^= ANMBAIFOBJP.GetHashCode();
		}
		if (nODDDNJAALP_ != null)
		{
			num ^= NODDDNJAALP.GetHashCode();
		}
		if (mNHIJDJBKLB_ != null)
		{
			num ^= MNHIJDJBKLB.GetHashCode();
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
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)AvatarType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Id);
		}
		if (AvatarLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AvatarLevel);
		}
		if (AvatarRank != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AvatarRank);
		}
		if (AvatarPromotion != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AvatarPromotion);
		}
		if (avatarStatus_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AvatarStatus);
		}
		avatarSkill_.WriteTo(ref output, _repeated_avatarSkill_codec);
		avatarEquipment_.WriteTo(ref output, _repeated_avatarEquipment_codec);
		if (TotalTurns != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(TotalTurns);
		}
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(TotalDamage);
		}
		if (TotalHeal != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(TotalHeal);
		}
		if (TotalDamageTaken != 0.0)
		{
			output.WriteRawTag(97);
			output.WriteDouble(TotalDamageTaken);
		}
		if (TotalHpRecover != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(TotalHpRecover);
		}
		if (TotalSpCost != 0.0)
		{
			output.WriteRawTag(113);
			output.WriteDouble(TotalSpCost);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(StageId);
		}
		if (StageType != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(StageType);
		}
		if (TotalBreakDamage != 0.0)
		{
			output.WriteRawTag(137, 1);
			output.WriteDouble(TotalBreakDamage);
		}
		attackTypeDamage_.WriteTo(ref output, _repeated_attackTypeDamage_codec);
		attackTypeBreakDamage_.WriteTo(ref output, _repeated_attackTypeBreakDamage_codec);
		attackTypeMaxDamage_.WriteTo(ref output, _repeated_attackTypeMaxDamage_codec);
		skillTimes_.WriteTo(ref output, _repeated_skillTimes_codec);
		if (DelayCumulate != 0.0)
		{
			output.WriteRawTag(177, 1);
			output.WriteDouble(DelayCumulate);
		}
		if (TotalSpAdd != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteUInt32(TotalSpAdd);
		}
		spAddSource_.WriteTo(ref output, _repeated_spAddSource_codec);
		if (TotalBpCost != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteUInt32(TotalBpCost);
		}
		if (DieTimes != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteUInt32(DieTimes);
		}
		if (ReviveTimes != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteUInt32(ReviveTimes);
		}
		if (BreakTimes != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteUInt32(BreakTimes);
		}
		if (ExtraTurns != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteUInt32(ExtraTurns);
		}
		if (TotalShield != 0.0)
		{
			output.WriteRawTag(241, 1);
			output.WriteDouble(TotalShield);
		}
		if (TotalShieldTaken != 0.0)
		{
			output.WriteRawTag(249, 1);
			output.WriteDouble(TotalShieldTaken);
		}
		if (TotalShieldDamage != 0.0)
		{
			output.WriteRawTag(129, 2);
			output.WriteDouble(TotalShieldDamage);
		}
		if (initialStatus_ != null)
		{
			output.WriteRawTag(138, 2);
			output.WriteMessage(InitialStatus);
		}
		relics_.WriteTo(ref output, _repeated_relics_codec);
		if (AssistUid != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteUInt32(AssistUid);
		}
		hLOOFKLELLJ_.WriteTo(ref output, _repeated_hLOOFKLELLJ_codec);
		if (OEJPKJPMKBC != 0.0)
		{
			output.WriteRawTag(169, 2);
			output.WriteDouble(OEJPKJPMKBC);
		}
		if (OGDGEKFJAFO != 0.0)
		{
			output.WriteRawTag(177, 2);
			output.WriteDouble(OGDGEKFJAFO);
		}
		if (AGLKPIJKKGN != 0.0)
		{
			output.WriteRawTag(185, 2);
			output.WriteDouble(AGLKPIJKKGN);
		}
		if (KONMGBJBIEA != 0.0)
		{
			output.WriteRawTag(193, 2);
			output.WriteDouble(KONMGBJBIEA);
		}
		gDAHCGCKOBO_.WriteTo(ref output, _repeated_gDAHCGCKOBO_codec);
		if (HOOFEMEKKOB != 0)
		{
			output.WriteRawTag(208, 2);
			output.WriteUInt32(HOOFEMEKKOB);
		}
		if (DOAPBOLJOGF != 0)
		{
			output.WriteRawTag(216, 2);
			output.WriteUInt32(DOAPBOLJOGF);
		}
		if (FJLIHMDENML != 0.0)
		{
			output.WriteRawTag(225, 2);
			output.WriteDouble(FJLIHMDENML);
		}
		if (LLCNOCGHJOO != 0.0)
		{
			output.WriteRawTag(233, 2);
			output.WriteDouble(LLCNOCGHJOO);
		}
		if (GFBLNAEHPCH != 0.0)
		{
			output.WriteRawTag(241, 2);
			output.WriteDouble(GFBLNAEHPCH);
		}
		if (KNGOCHGELCE != 0.0)
		{
			output.WriteRawTag(249, 2);
			output.WriteDouble(KNGOCHGELCE);
		}
		if (FODKMBNLCKA != 0.0)
		{
			output.WriteRawTag(129, 3);
			output.WriteDouble(FODKMBNLCKA);
		}
		if (LNIHALFAAGA != 0)
		{
			output.WriteRawTag(136, 3);
			output.WriteUInt32(LNIHALFAAGA);
		}
		if (BENJFNNODEF != 0)
		{
			output.WriteRawTag(144, 3);
			output.WriteUInt32(BENJFNNODEF);
		}
		if (LBLAJJAFFBH != 0)
		{
			output.WriteRawTag(152, 3);
			output.WriteUInt32(LBLAJJAFFBH);
		}
		if (DPDAAIHDGAA != 0.0)
		{
			output.WriteRawTag(161, 3);
			output.WriteDouble(DPDAAIHDGAA);
		}
		if (MGOHBOKJBKD != 0)
		{
			output.WriteRawTag(168, 3);
			output.WriteUInt32(MGOHBOKJBKD);
		}
		if (HMIFOFDMCCC != 0)
		{
			output.WriteRawTag(176, 3);
			output.WriteUInt32(HMIFOFDMCCC);
		}
		if (EnhancedId != 0)
		{
			output.WriteRawTag(184, 3);
			output.WriteUInt32(EnhancedId);
		}
		if (ANMBAIFOBJP != 0)
		{
			output.WriteRawTag(192, 3);
			output.WriteUInt32(ANMBAIFOBJP);
		}
		if (nODDDNJAALP_ != null)
		{
			output.WriteRawTag(202, 3);
			output.WriteMessage(NODDDNJAALP);
		}
		if (mNHIJDJBKLB_ != null)
		{
			output.WriteRawTag(210, 3);
			output.WriteMessage(MNHIJDJBKLB);
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
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (AvatarLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarLevel);
		}
		if (AvatarRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarRank);
		}
		if (AvatarPromotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarPromotion);
		}
		if (avatarStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AvatarStatus);
		}
		num += avatarSkill_.CalculateSize(_repeated_avatarSkill_codec);
		num += avatarEquipment_.CalculateSize(_repeated_avatarEquipment_codec);
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
		if (TotalHpRecover != 0.0)
		{
			num += 9;
		}
		if (TotalSpCost != 0.0)
		{
			num += 9;
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (StageType != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(StageType);
		}
		if (TotalBreakDamage != 0.0)
		{
			num += 10;
		}
		num += attackTypeDamage_.CalculateSize(_repeated_attackTypeDamage_codec);
		num += attackTypeBreakDamage_.CalculateSize(_repeated_attackTypeBreakDamage_codec);
		num += attackTypeMaxDamage_.CalculateSize(_repeated_attackTypeMaxDamage_codec);
		num += skillTimes_.CalculateSize(_repeated_skillTimes_codec);
		if (DelayCumulate != 0.0)
		{
			num += 10;
		}
		if (TotalSpAdd != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(TotalSpAdd);
		}
		num += spAddSource_.CalculateSize(_repeated_spAddSource_codec);
		if (TotalBpCost != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(TotalBpCost);
		}
		if (DieTimes != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DieTimes);
		}
		if (ReviveTimes != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ReviveTimes);
		}
		if (BreakTimes != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BreakTimes);
		}
		if (ExtraTurns != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ExtraTurns);
		}
		if (TotalShield != 0.0)
		{
			num += 10;
		}
		if (TotalShieldTaken != 0.0)
		{
			num += 10;
		}
		if (TotalShieldDamage != 0.0)
		{
			num += 10;
		}
		if (initialStatus_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(InitialStatus);
		}
		num += relics_.CalculateSize(_repeated_relics_codec);
		if (AssistUid != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AssistUid);
		}
		num += hLOOFKLELLJ_.CalculateSize(_repeated_hLOOFKLELLJ_codec);
		if (OEJPKJPMKBC != 0.0)
		{
			num += 10;
		}
		if (OGDGEKFJAFO != 0.0)
		{
			num += 10;
		}
		if (AGLKPIJKKGN != 0.0)
		{
			num += 10;
		}
		if (KONMGBJBIEA != 0.0)
		{
			num += 10;
		}
		num += gDAHCGCKOBO_.CalculateSize(_repeated_gDAHCGCKOBO_codec);
		if (HOOFEMEKKOB != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HOOFEMEKKOB);
		}
		if (DOAPBOLJOGF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DOAPBOLJOGF);
		}
		if (FJLIHMDENML != 0.0)
		{
			num += 10;
		}
		if (LLCNOCGHJOO != 0.0)
		{
			num += 10;
		}
		if (GFBLNAEHPCH != 0.0)
		{
			num += 10;
		}
		if (KNGOCHGELCE != 0.0)
		{
			num += 10;
		}
		if (FODKMBNLCKA != 0.0)
		{
			num += 10;
		}
		if (LNIHALFAAGA != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LNIHALFAAGA);
		}
		if (BENJFNNODEF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BENJFNNODEF);
		}
		if (LBLAJJAFFBH != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LBLAJJAFFBH);
		}
		if (DPDAAIHDGAA != 0.0)
		{
			num += 10;
		}
		if (MGOHBOKJBKD != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MGOHBOKJBKD);
		}
		if (HMIFOFDMCCC != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HMIFOFDMCCC);
		}
		if (EnhancedId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EnhancedId);
		}
		if (ANMBAIFOBJP != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ANMBAIFOBJP);
		}
		if (nODDDNJAALP_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NODDDNJAALP);
		}
		if (mNHIJDJBKLB_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MNHIJDJBKLB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AvatarBattleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AvatarType != AvatarType.None)
		{
			AvatarType = other.AvatarType;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.AvatarLevel != 0)
		{
			AvatarLevel = other.AvatarLevel;
		}
		if (other.AvatarRank != 0)
		{
			AvatarRank = other.AvatarRank;
		}
		if (other.AvatarPromotion != 0)
		{
			AvatarPromotion = other.AvatarPromotion;
		}
		if (other.avatarStatus_ != null)
		{
			if (avatarStatus_ == null)
			{
				AvatarStatus = new AvatarProperty();
			}
			AvatarStatus.MergeFrom(other.AvatarStatus);
		}
		avatarSkill_.Add(other.avatarSkill_);
		avatarEquipment_.Add(other.avatarEquipment_);
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
		if (other.TotalHpRecover != 0.0)
		{
			TotalHpRecover = other.TotalHpRecover;
		}
		if (other.TotalSpCost != 0.0)
		{
			TotalSpCost = other.TotalSpCost;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.StageType != 0)
		{
			StageType = other.StageType;
		}
		if (other.TotalBreakDamage != 0.0)
		{
			TotalBreakDamage = other.TotalBreakDamage;
		}
		attackTypeDamage_.Add(other.attackTypeDamage_);
		attackTypeBreakDamage_.Add(other.attackTypeBreakDamage_);
		attackTypeMaxDamage_.Add(other.attackTypeMaxDamage_);
		skillTimes_.Add(other.skillTimes_);
		if (other.DelayCumulate != 0.0)
		{
			DelayCumulate = other.DelayCumulate;
		}
		if (other.TotalSpAdd != 0)
		{
			TotalSpAdd = other.TotalSpAdd;
		}
		spAddSource_.Add(other.spAddSource_);
		if (other.TotalBpCost != 0)
		{
			TotalBpCost = other.TotalBpCost;
		}
		if (other.DieTimes != 0)
		{
			DieTimes = other.DieTimes;
		}
		if (other.ReviveTimes != 0)
		{
			ReviveTimes = other.ReviveTimes;
		}
		if (other.BreakTimes != 0)
		{
			BreakTimes = other.BreakTimes;
		}
		if (other.ExtraTurns != 0)
		{
			ExtraTurns = other.ExtraTurns;
		}
		if (other.TotalShield != 0.0)
		{
			TotalShield = other.TotalShield;
		}
		if (other.TotalShieldTaken != 0.0)
		{
			TotalShieldTaken = other.TotalShieldTaken;
		}
		if (other.TotalShieldDamage != 0.0)
		{
			TotalShieldDamage = other.TotalShieldDamage;
		}
		if (other.initialStatus_ != null)
		{
			if (initialStatus_ == null)
			{
				InitialStatus = new AvatarProperty();
			}
			InitialStatus.MergeFrom(other.InitialStatus);
		}
		relics_.Add(other.relics_);
		if (other.AssistUid != 0)
		{
			AssistUid = other.AssistUid;
		}
		hLOOFKLELLJ_.Add(other.hLOOFKLELLJ_);
		if (other.OEJPKJPMKBC != 0.0)
		{
			OEJPKJPMKBC = other.OEJPKJPMKBC;
		}
		if (other.OGDGEKFJAFO != 0.0)
		{
			OGDGEKFJAFO = other.OGDGEKFJAFO;
		}
		if (other.AGLKPIJKKGN != 0.0)
		{
			AGLKPIJKKGN = other.AGLKPIJKKGN;
		}
		if (other.KONMGBJBIEA != 0.0)
		{
			KONMGBJBIEA = other.KONMGBJBIEA;
		}
		gDAHCGCKOBO_.Add(other.gDAHCGCKOBO_);
		if (other.HOOFEMEKKOB != 0)
		{
			HOOFEMEKKOB = other.HOOFEMEKKOB;
		}
		if (other.DOAPBOLJOGF != 0)
		{
			DOAPBOLJOGF = other.DOAPBOLJOGF;
		}
		if (other.FJLIHMDENML != 0.0)
		{
			FJLIHMDENML = other.FJLIHMDENML;
		}
		if (other.LLCNOCGHJOO != 0.0)
		{
			LLCNOCGHJOO = other.LLCNOCGHJOO;
		}
		if (other.GFBLNAEHPCH != 0.0)
		{
			GFBLNAEHPCH = other.GFBLNAEHPCH;
		}
		if (other.KNGOCHGELCE != 0.0)
		{
			KNGOCHGELCE = other.KNGOCHGELCE;
		}
		if (other.FODKMBNLCKA != 0.0)
		{
			FODKMBNLCKA = other.FODKMBNLCKA;
		}
		if (other.LNIHALFAAGA != 0)
		{
			LNIHALFAAGA = other.LNIHALFAAGA;
		}
		if (other.BENJFNNODEF != 0)
		{
			BENJFNNODEF = other.BENJFNNODEF;
		}
		if (other.LBLAJJAFFBH != 0)
		{
			LBLAJJAFFBH = other.LBLAJJAFFBH;
		}
		if (other.DPDAAIHDGAA != 0.0)
		{
			DPDAAIHDGAA = other.DPDAAIHDGAA;
		}
		if (other.MGOHBOKJBKD != 0)
		{
			MGOHBOKJBKD = other.MGOHBOKJBKD;
		}
		if (other.HMIFOFDMCCC != 0)
		{
			HMIFOFDMCCC = other.HMIFOFDMCCC;
		}
		if (other.EnhancedId != 0)
		{
			EnhancedId = other.EnhancedId;
		}
		if (other.ANMBAIFOBJP != 0)
		{
			ANMBAIFOBJP = other.ANMBAIFOBJP;
		}
		if (other.nODDDNJAALP_ != null)
		{
			if (nODDDNJAALP_ == null)
			{
				NODDDNJAALP = new HBFAMLLHFAF();
			}
			NODDDNJAALP.MergeFrom(other.NODDDNJAALP);
		}
		if (other.mNHIJDJBKLB_ != null)
		{
			if (mNHIJDJBKLB_ == null)
			{
				MNHIJDJBKLB = new DHNFGJBHMAA();
			}
			MNHIJDJBKLB.MergeFrom(other.MNHIJDJBKLB);
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
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 16u:
				Id = input.ReadUInt32();
				break;
			case 24u:
				AvatarLevel = input.ReadUInt32();
				break;
			case 32u:
				AvatarRank = input.ReadUInt32();
				break;
			case 40u:
				AvatarPromotion = input.ReadUInt32();
				break;
			case 50u:
				if (avatarStatus_ == null)
				{
					AvatarStatus = new AvatarProperty();
				}
				input.ReadMessage(AvatarStatus);
				break;
			case 58u:
				avatarSkill_.AddEntriesFrom(ref input, _repeated_avatarSkill_codec);
				break;
			case 66u:
				avatarEquipment_.AddEntriesFrom(ref input, _repeated_avatarEquipment_codec);
				break;
			case 72u:
				TotalTurns = input.ReadUInt32();
				break;
			case 81u:
				TotalDamage = input.ReadDouble();
				break;
			case 89u:
				TotalHeal = input.ReadDouble();
				break;
			case 97u:
				TotalDamageTaken = input.ReadDouble();
				break;
			case 105u:
				TotalHpRecover = input.ReadDouble();
				break;
			case 113u:
				TotalSpCost = input.ReadDouble();
				break;
			case 120u:
				StageId = input.ReadUInt32();
				break;
			case 128u:
				StageType = input.ReadUInt32();
				break;
			case 137u:
				TotalBreakDamage = input.ReadDouble();
				break;
			case 146u:
				attackTypeDamage_.AddEntriesFrom(ref input, _repeated_attackTypeDamage_codec);
				break;
			case 154u:
				attackTypeBreakDamage_.AddEntriesFrom(ref input, _repeated_attackTypeBreakDamage_codec);
				break;
			case 162u:
				attackTypeMaxDamage_.AddEntriesFrom(ref input, _repeated_attackTypeMaxDamage_codec);
				break;
			case 170u:
				skillTimes_.AddEntriesFrom(ref input, _repeated_skillTimes_codec);
				break;
			case 177u:
				DelayCumulate = input.ReadDouble();
				break;
			case 184u:
				TotalSpAdd = input.ReadUInt32();
				break;
			case 194u:
				spAddSource_.AddEntriesFrom(ref input, _repeated_spAddSource_codec);
				break;
			case 200u:
				TotalBpCost = input.ReadUInt32();
				break;
			case 208u:
				DieTimes = input.ReadUInt32();
				break;
			case 216u:
				ReviveTimes = input.ReadUInt32();
				break;
			case 224u:
				BreakTimes = input.ReadUInt32();
				break;
			case 232u:
				ExtraTurns = input.ReadUInt32();
				break;
			case 241u:
				TotalShield = input.ReadDouble();
				break;
			case 249u:
				TotalShieldTaken = input.ReadDouble();
				break;
			case 257u:
				TotalShieldDamage = input.ReadDouble();
				break;
			case 266u:
				if (initialStatus_ == null)
				{
					InitialStatus = new AvatarProperty();
				}
				input.ReadMessage(InitialStatus);
				break;
			case 274u:
				relics_.AddEntriesFrom(ref input, _repeated_relics_codec);
				break;
			case 280u:
				AssistUid = input.ReadUInt32();
				break;
			case 290u:
				hLOOFKLELLJ_.AddEntriesFrom(ref input, _repeated_hLOOFKLELLJ_codec);
				break;
			case 297u:
				OEJPKJPMKBC = input.ReadDouble();
				break;
			case 305u:
				OGDGEKFJAFO = input.ReadDouble();
				break;
			case 313u:
				AGLKPIJKKGN = input.ReadDouble();
				break;
			case 321u:
				KONMGBJBIEA = input.ReadDouble();
				break;
			case 330u:
				gDAHCGCKOBO_.AddEntriesFrom(ref input, _repeated_gDAHCGCKOBO_codec);
				break;
			case 336u:
				HOOFEMEKKOB = input.ReadUInt32();
				break;
			case 344u:
				DOAPBOLJOGF = input.ReadUInt32();
				break;
			case 353u:
				FJLIHMDENML = input.ReadDouble();
				break;
			case 361u:
				LLCNOCGHJOO = input.ReadDouble();
				break;
			case 369u:
				GFBLNAEHPCH = input.ReadDouble();
				break;
			case 377u:
				KNGOCHGELCE = input.ReadDouble();
				break;
			case 385u:
				FODKMBNLCKA = input.ReadDouble();
				break;
			case 392u:
				LNIHALFAAGA = input.ReadUInt32();
				break;
			case 400u:
				BENJFNNODEF = input.ReadUInt32();
				break;
			case 408u:
				LBLAJJAFFBH = input.ReadUInt32();
				break;
			case 417u:
				DPDAAIHDGAA = input.ReadDouble();
				break;
			case 424u:
				MGOHBOKJBKD = input.ReadUInt32();
				break;
			case 432u:
				HMIFOFDMCCC = input.ReadUInt32();
				break;
			case 440u:
				EnhancedId = input.ReadUInt32();
				break;
			case 448u:
				ANMBAIFOBJP = input.ReadUInt32();
				break;
			case 458u:
				if (nODDDNJAALP_ == null)
				{
					NODDDNJAALP = new HBFAMLLHFAF();
				}
				input.ReadMessage(NODDDNJAALP);
				break;
			case 466u:
				if (mNHIJDJBKLB_ == null)
				{
					MNHIJDJBKLB = new DHNFGJBHMAA();
				}
				input.ReadMessage(MNHIJDJBKLB);
				break;
			}
		}
	}
}
