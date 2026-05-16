using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSyncData : IMessage<GridFightSyncData>, IMessage, IEquatable<GridFightSyncData>, IDeepCloneable<GridFightSyncData>, IBufferMessage
{
	public enum KCOCCGEOECOOneofCase
	{
		None = 0,
		CJEMKCOCECG = 19,
		RemoveOrbUniqueId = 53,
		EquipmentTrackSyncInfo = 57,
		MaxBattleRoleNum = 72,
		CFNPGNMPNDN = 140,
		AddRoleInfo = 210,
		AddNpcInfo = 230,
		HLFBBANMJDJ = 257,
		TraitSyncInfo = 258,
		PortalServerDataUpdate = 271,
		UpdateGameItemInfo = 284,
		AddForgeInfo = 386,
		UpdateRoleInfo = 393,
		AJIMOAMGCII = 423,
		GridFightDamageSttInfo = 437,
		GridFightComboWinNum = 461,
		SyncLockInfo = 468,
		GDPBJDHGFLB = 516,
		RemoveAugmentUniqueId = 523,
		GridFightMaxAvatarCount = 548,
		AugmentSyncInfo = 558,
		FinishPendingActionPos = 573,
		PendingAction = 786,
		POIPGNHONMA = 798,
		LevelSyncInfo = 838,
		GridFightMaxInterestGold = 855,
		UpdateForgeInfo = 909,
		PlayerLevel = 995,
		KACHJHDMNLM = 996,
		JIFKOHLNHAK = 1016,
		GridFightTutorialSync = 1022,
		GridFightOffFieldMaxCount = 1062,
		LockType = 1112,
		RemoveGameItemInfo = 1129,
		GridFightLineupHp = 1138,
		SectionRecordSyncInfo = 1155,
		GridFightSyncGameItemInfo = 1182,
		GridFightBuyExpCost = 1241,
		TraitTrackSyncInfo = 1345,
		BAODHPCOJLH = 1444,
		AddGameItemInfo = 1513,
		UpdateNpcInfo = 1517,
		RemoveForgeUniqueId = 1564,
		RemoveTraitEffectId = 1608,
		GMJLJDJDIGM = 1628,
		FHHHEBLMOBL = 1660,
		RemoveRoleUniqueId = 1704,
		EliteBranchSyncInfo = 1738,
		IBCEPCFFMOL = 1813,
		PGPKPMOIAIL = 1858,
		OrbSyncInfo = 1895,
		ItemValue = 1943,
		GridGameAugmentUpdate = 1994,
		ShopSyncInfo = 2039,
		RemoveNpcUniqueId = 2040
	}

	private static readonly MessageParser<GridFightSyncData> _parser = new MessageParser<GridFightSyncData>(() => new GridFightSyncData());

	private UnknownFieldSet _unknownFields;

	public const int CJEMKCOCECGFieldNumber = 19;

	public const int RemoveOrbUniqueIdFieldNumber = 53;

	public const int EquipmentTrackSyncInfoFieldNumber = 57;

	public const int MaxBattleRoleNumFieldNumber = 72;

	public const int CFNPGNMPNDNFieldNumber = 140;

	public const int AddRoleInfoFieldNumber = 210;

	public const int AddNpcInfoFieldNumber = 230;

	public const int HLFBBANMJDJFieldNumber = 257;

	public const int TraitSyncInfoFieldNumber = 258;

	public const int PortalServerDataUpdateFieldNumber = 271;

	public const int UpdateGameItemInfoFieldNumber = 284;

	public const int AddForgeInfoFieldNumber = 386;

	public const int UpdateRoleInfoFieldNumber = 393;

	public const int AJIMOAMGCIIFieldNumber = 423;

	public const int GridFightDamageSttInfoFieldNumber = 437;

	public const int GridFightComboWinNumFieldNumber = 461;

	public const int SyncLockInfoFieldNumber = 468;

	public const int GDPBJDHGFLBFieldNumber = 516;

	public const int RemoveAugmentUniqueIdFieldNumber = 523;

	public const int GridFightMaxAvatarCountFieldNumber = 548;

	public const int AugmentSyncInfoFieldNumber = 558;

	public const int FinishPendingActionPosFieldNumber = 573;

	public const int PendingActionFieldNumber = 786;

	public const int POIPGNHONMAFieldNumber = 798;

	public const int LevelSyncInfoFieldNumber = 838;

	public const int GridFightMaxInterestGoldFieldNumber = 855;

	public const int UpdateForgeInfoFieldNumber = 909;

	public const int PlayerLevelFieldNumber = 995;

	public const int KACHJHDMNLMFieldNumber = 996;

	public const int JIFKOHLNHAKFieldNumber = 1016;

	public const int GridFightTutorialSyncFieldNumber = 1022;

	public const int GridFightOffFieldMaxCountFieldNumber = 1062;

	public const int LockTypeFieldNumber = 1112;

	public const int RemoveGameItemInfoFieldNumber = 1129;

	public const int GridFightLineupHpFieldNumber = 1138;

	public const int SectionRecordSyncInfoFieldNumber = 1155;

	public const int GridFightSyncGameItemInfoFieldNumber = 1182;

	public const int GridFightBuyExpCostFieldNumber = 1241;

	public const int TraitTrackSyncInfoFieldNumber = 1345;

	public const int BAODHPCOJLHFieldNumber = 1444;

	public const int AddGameItemInfoFieldNumber = 1513;

	public const int UpdateNpcInfoFieldNumber = 1517;

	public const int RemoveForgeUniqueIdFieldNumber = 1564;

	public const int RemoveTraitEffectIdFieldNumber = 1608;

	public const int GMJLJDJDIGMFieldNumber = 1628;

	public const int FHHHEBLMOBLFieldNumber = 1660;

	public const int RemoveRoleUniqueIdFieldNumber = 1704;

	public const int EliteBranchSyncInfoFieldNumber = 1738;

	public const int IBCEPCFFMOLFieldNumber = 1813;

	public const int PGPKPMOIAILFieldNumber = 1858;

	public const int OrbSyncInfoFieldNumber = 1895;

	public const int ItemValueFieldNumber = 1943;

	public const int GridGameAugmentUpdateFieldNumber = 1994;

	public const int ShopSyncInfoFieldNumber = 2039;

	public const int RemoveNpcUniqueIdFieldNumber = 2040;

	private object kCOCCGEOECO_;

	private KCOCCGEOECOOneofCase kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSyncData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSyncDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJEMKCOCECG
	{
		get
		{
			if (!HasCJEMKCOCECG)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.CJEMKCOCECG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCJEMKCOCECG => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CJEMKCOCECG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveOrbUniqueId
	{
		get
		{
			if (!HasRemoveOrbUniqueId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.RemoveOrbUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveOrbUniqueId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveOrbUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RoleTrackEquipmentSyncInfo EquipmentTrackSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo)
			{
				return null;
			}
			return (RoleTrackEquipmentSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxBattleRoleNum
	{
		get
		{
			if (!HasMaxBattleRoleNum)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.MaxBattleRoleNum;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMaxBattleRoleNum => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.MaxBattleRoleNum;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMCJNKPKBEM CFNPGNMPNDN
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.CFNPGNMPNDN)
			{
				return null;
			}
			return (CMCJNKPKBEM)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.CFNPGNMPNDN : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameRoleInfo AddRoleInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.AddRoleInfo)
			{
				return null;
			}
			return (GridGameRoleInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.AddRoleInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameNpcInfo AddNpcInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.AddNpcInfo)
			{
				return null;
			}
			return (GridGameNpcInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.AddNpcInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HLFBBANMJDJ
	{
		get
		{
			if (!HasHLFBBANMJDJ)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.HLFBBANMJDJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHLFBBANMJDJ => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.HLFBBANMJDJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitSyncInfo TraitSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.TraitSyncInfo)
			{
				return null;
			}
			return (GridFightTraitSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.TraitSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalServerDataUpdate PortalServerDataUpdate
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.PortalServerDataUpdate)
			{
				return null;
			}
			return (GridFightPortalServerDataUpdate)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.PortalServerDataUpdate : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemSyncInfo UpdateGameItemInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.UpdateGameItemInfo)
			{
				return null;
			}
			return (GridFightGameItemSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.UpdateGameItemInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameForgeItemInfo AddForgeInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.AddForgeInfo)
			{
				return null;
			}
			return (GridGameForgeItemInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.AddForgeInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameRoleInfo UpdateRoleInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.UpdateRoleInfo)
			{
				return null;
			}
			return (GridGameRoleInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.UpdateRoleInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AJIMOAMGCII
	{
		get
		{
			if (!HasAJIMOAMGCII)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.AJIMOAMGCII;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAJIMOAMGCII => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AJIMOAMGCII;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDamageSttInfo GridFightDamageSttInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GridFightDamageSttInfo)
			{
				return null;
			}
			return (GridFightDamageSttInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GridFightDamageSttInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightComboWinNum
	{
		get
		{
			if (!HasGridFightComboWinNum)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.GridFightComboWinNum;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGridFightComboWinNum => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightComboWinNum;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockInfo SyncLockInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.SyncLockInfo)
			{
				return null;
			}
			return (GridFightLockInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.SyncLockInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDPBJDHGFLB
	{
		get
		{
			if (!HasGDPBJDHGFLB)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.GDPBJDHGFLB;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGDPBJDHGFLB => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GDPBJDHGFLB;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveAugmentUniqueId
	{
		get
		{
			if (!HasRemoveAugmentUniqueId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.RemoveAugmentUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveAugmentUniqueId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveAugmentUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightMaxAvatarCount
	{
		get
		{
			if (!HasGridFightMaxAvatarCount)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.GridFightMaxAvatarCount;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGridFightMaxAvatarCount => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightMaxAvatarCount;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentAdd AugmentSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.AugmentSyncInfo)
			{
				return null;
			}
			return (GridFightGameAugmentAdd)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.AugmentSyncInfo : KCOCCGEOECOOneofCase.None);
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
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.FinishPendingActionPos;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFinishPendingActionPos => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FinishPendingActionPos;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAction PendingAction
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.PendingAction)
			{
				return null;
			}
			return (GridFightPendingAction)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.PendingAction : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameOrbInfo POIPGNHONMA
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.POIPGNHONMA)
			{
				return null;
			}
			return (GridGameOrbInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.POIPGNHONMA : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLevelSyncInfo LevelSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.LevelSyncInfo)
			{
				return null;
			}
			return (GridFightLevelSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.LevelSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightMaxInterestGold
	{
		get
		{
			if (!HasGridFightMaxInterestGold)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.GridFightMaxInterestGold;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGridFightMaxInterestGold => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightMaxInterestGold;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameForgeItemInfo UpdateForgeInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.UpdateForgeInfo)
			{
				return null;
			}
			return (GridGameForgeItemInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.UpdateForgeInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPlayerLevelSyncInfo PlayerLevel
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.PlayerLevel)
			{
				return null;
			}
			return (GridFightPlayerLevelSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.PlayerLevel : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KACHJHDMNLM
	{
		get
		{
			if (!HasKACHJHDMNLM)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.KACHJHDMNLM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKACHJHDMNLM => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.KACHJHDMNLM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKCKIDHMMEG JIFKOHLNHAK
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.JIFKOHLNHAK)
			{
				return null;
			}
			return (CKCKIDHMMEG)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.JIFKOHLNHAK : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTutorialSyncInfo GridFightTutorialSync
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GridFightTutorialSync)
			{
				return null;
			}
			return (GridFightTutorialSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GridFightTutorialSync : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightOffFieldMaxCount
	{
		get
		{
			if (!HasGridFightOffFieldMaxCount)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.GridFightOffFieldMaxCount;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGridFightOffFieldMaxCount => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightOffFieldMaxCount;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockType LockType
	{
		get
		{
			if (!HasLockType)
			{
				return GridFightLockType.PjbmhhnlclbLnloohdeaeo;
			}
			return (GridFightLockType)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.LockType;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLockType => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LockType;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemSyncInfo RemoveGameItemInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.RemoveGameItemInfo)
			{
				return null;
			}
			return (GridFightGameItemSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.RemoveGameItemInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLineupHpSyncInfo GridFightLineupHp
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GridFightLineupHp)
			{
				return null;
			}
			return (GridFightLineupHpSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GridFightLineupHp : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionRecordInfo SectionRecordSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.SectionRecordSyncInfo)
			{
				return null;
			}
			return (GridFightSectionRecordInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.SectionRecordSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemInfo GridFightSyncGameItemInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo)
			{
				return null;
			}
			return (GridFightGameItemInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightBuyExpCost
	{
		get
		{
			if (!HasGridFightBuyExpCost)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.GridFightBuyExpCost;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGridFightBuyExpCost => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightBuyExpCost;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitTrackSyncInfo TraitTrackSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.TraitTrackSyncInfo)
			{
				return null;
			}
			return (GridFightTraitTrackSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.TraitTrackSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKCKIDHMMEG BAODHPCOJLH
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.BAODHPCOJLH)
			{
				return null;
			}
			return (CKCKIDHMMEG)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.BAODHPCOJLH : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemSyncInfo AddGameItemInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.AddGameItemInfo)
			{
				return null;
			}
			return (GridFightGameItemSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.AddGameItemInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameNpcInfo UpdateNpcInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.UpdateNpcInfo)
			{
				return null;
			}
			return (GridGameNpcInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.UpdateNpcInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveForgeUniqueId
	{
		get
		{
			if (!HasRemoveForgeUniqueId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.RemoveForgeUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveForgeUniqueId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveForgeUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveTraitEffectId
	{
		get
		{
			if (!HasRemoveTraitEffectId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.RemoveTraitEffectId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveTraitEffectId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveTraitEffectId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPBCKCDEGOM GMJLJDJDIGM
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GMJLJDJDIGM)
			{
				return null;
			}
			return (JPBCKCDEGOM)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GMJLJDJDIGM : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHHHEBLMOBL
	{
		get
		{
			if (!HasFHHHEBLMOBL)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.FHHHEBLMOBL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFHHHEBLMOBL => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FHHHEBLMOBL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveRoleUniqueId
	{
		get
		{
			if (!HasRemoveRoleUniqueId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.RemoveRoleUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveRoleUniqueId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveRoleUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEliteBranchSyncInfo EliteBranchSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.EliteBranchSyncInfo)
			{
				return null;
			}
			return (GridFightEliteBranchSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.EliteBranchSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIBJGAKOCLO IBCEPCFFMOL
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.IBCEPCFFMOL)
			{
				return null;
			}
			return (DIBJGAKOCLO)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.IBCEPCFFMOL : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLOEPPBCKGF PGPKPMOIAIL
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.PGPKPMOIAIL)
			{
				return null;
			}
			return (CLOEPPBCKGF)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.PGPKPMOIAIL : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightOrbSyncInfo OrbSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.OrbSyncInfo)
			{
				return null;
			}
			return (GridFightOrbSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.OrbSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			if (!HasItemValue)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.ItemValue;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasItemValue => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ItemValue;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentUpdate GridGameAugmentUpdate
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GridGameAugmentUpdate)
			{
				return null;
			}
			return (GridFightGameAugmentUpdate)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GridGameAugmentUpdate : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopSyncInfo ShopSyncInfo
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.ShopSyncInfo)
			{
				return null;
			}
			return (GridFightShopSyncInfo)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.ShopSyncInfo : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveNpcUniqueId
	{
		get
		{
			if (!HasRemoveNpcUniqueId)
			{
				return 0u;
			}
			return (uint)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.RemoveNpcUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveNpcUniqueId => kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveNpcUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCOCCGEOECOOneofCase KCOCCGEOECOCase => kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncData(GridFightSyncData other)
		: this()
	{
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.CJEMKCOCECG:
			CJEMKCOCECG = other.CJEMKCOCECG;
			break;
		case KCOCCGEOECOOneofCase.RemoveOrbUniqueId:
			RemoveOrbUniqueId = other.RemoveOrbUniqueId;
			break;
		case KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo:
			EquipmentTrackSyncInfo = other.EquipmentTrackSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.MaxBattleRoleNum:
			MaxBattleRoleNum = other.MaxBattleRoleNum;
			break;
		case KCOCCGEOECOOneofCase.CFNPGNMPNDN:
			CFNPGNMPNDN = other.CFNPGNMPNDN.Clone();
			break;
		case KCOCCGEOECOOneofCase.AddRoleInfo:
			AddRoleInfo = other.AddRoleInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.AddNpcInfo:
			AddNpcInfo = other.AddNpcInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.HLFBBANMJDJ:
			HLFBBANMJDJ = other.HLFBBANMJDJ;
			break;
		case KCOCCGEOECOOneofCase.TraitSyncInfo:
			TraitSyncInfo = other.TraitSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.PortalServerDataUpdate:
			PortalServerDataUpdate = other.PortalServerDataUpdate.Clone();
			break;
		case KCOCCGEOECOOneofCase.UpdateGameItemInfo:
			UpdateGameItemInfo = other.UpdateGameItemInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.AddForgeInfo:
			AddForgeInfo = other.AddForgeInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.UpdateRoleInfo:
			UpdateRoleInfo = other.UpdateRoleInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.AJIMOAMGCII:
			AJIMOAMGCII = other.AJIMOAMGCII;
			break;
		case KCOCCGEOECOOneofCase.GridFightDamageSttInfo:
			GridFightDamageSttInfo = other.GridFightDamageSttInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightComboWinNum:
			GridFightComboWinNum = other.GridFightComboWinNum;
			break;
		case KCOCCGEOECOOneofCase.SyncLockInfo:
			SyncLockInfo = other.SyncLockInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.GDPBJDHGFLB:
			GDPBJDHGFLB = other.GDPBJDHGFLB;
			break;
		case KCOCCGEOECOOneofCase.RemoveAugmentUniqueId:
			RemoveAugmentUniqueId = other.RemoveAugmentUniqueId;
			break;
		case KCOCCGEOECOOneofCase.GridFightMaxAvatarCount:
			GridFightMaxAvatarCount = other.GridFightMaxAvatarCount;
			break;
		case KCOCCGEOECOOneofCase.AugmentSyncInfo:
			AugmentSyncInfo = other.AugmentSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.FinishPendingActionPos:
			FinishPendingActionPos = other.FinishPendingActionPos;
			break;
		case KCOCCGEOECOOneofCase.PendingAction:
			PendingAction = other.PendingAction.Clone();
			break;
		case KCOCCGEOECOOneofCase.POIPGNHONMA:
			POIPGNHONMA = other.POIPGNHONMA.Clone();
			break;
		case KCOCCGEOECOOneofCase.LevelSyncInfo:
			LevelSyncInfo = other.LevelSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightMaxInterestGold:
			GridFightMaxInterestGold = other.GridFightMaxInterestGold;
			break;
		case KCOCCGEOECOOneofCase.UpdateForgeInfo:
			UpdateForgeInfo = other.UpdateForgeInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.PlayerLevel:
			PlayerLevel = other.PlayerLevel.Clone();
			break;
		case KCOCCGEOECOOneofCase.KACHJHDMNLM:
			KACHJHDMNLM = other.KACHJHDMNLM;
			break;
		case KCOCCGEOECOOneofCase.JIFKOHLNHAK:
			JIFKOHLNHAK = other.JIFKOHLNHAK.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightTutorialSync:
			GridFightTutorialSync = other.GridFightTutorialSync.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightOffFieldMaxCount:
			GridFightOffFieldMaxCount = other.GridFightOffFieldMaxCount;
			break;
		case KCOCCGEOECOOneofCase.LockType:
			LockType = other.LockType;
			break;
		case KCOCCGEOECOOneofCase.RemoveGameItemInfo:
			RemoveGameItemInfo = other.RemoveGameItemInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightLineupHp:
			GridFightLineupHp = other.GridFightLineupHp.Clone();
			break;
		case KCOCCGEOECOOneofCase.SectionRecordSyncInfo:
			SectionRecordSyncInfo = other.SectionRecordSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo:
			GridFightSyncGameItemInfo = other.GridFightSyncGameItemInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.GridFightBuyExpCost:
			GridFightBuyExpCost = other.GridFightBuyExpCost;
			break;
		case KCOCCGEOECOOneofCase.TraitTrackSyncInfo:
			TraitTrackSyncInfo = other.TraitTrackSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.BAODHPCOJLH:
			BAODHPCOJLH = other.BAODHPCOJLH.Clone();
			break;
		case KCOCCGEOECOOneofCase.AddGameItemInfo:
			AddGameItemInfo = other.AddGameItemInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.UpdateNpcInfo:
			UpdateNpcInfo = other.UpdateNpcInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.RemoveForgeUniqueId:
			RemoveForgeUniqueId = other.RemoveForgeUniqueId;
			break;
		case KCOCCGEOECOOneofCase.RemoveTraitEffectId:
			RemoveTraitEffectId = other.RemoveTraitEffectId;
			break;
		case KCOCCGEOECOOneofCase.GMJLJDJDIGM:
			GMJLJDJDIGM = other.GMJLJDJDIGM.Clone();
			break;
		case KCOCCGEOECOOneofCase.FHHHEBLMOBL:
			FHHHEBLMOBL = other.FHHHEBLMOBL;
			break;
		case KCOCCGEOECOOneofCase.RemoveRoleUniqueId:
			RemoveRoleUniqueId = other.RemoveRoleUniqueId;
			break;
		case KCOCCGEOECOOneofCase.EliteBranchSyncInfo:
			EliteBranchSyncInfo = other.EliteBranchSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.IBCEPCFFMOL:
			IBCEPCFFMOL = other.IBCEPCFFMOL.Clone();
			break;
		case KCOCCGEOECOOneofCase.PGPKPMOIAIL:
			PGPKPMOIAIL = other.PGPKPMOIAIL.Clone();
			break;
		case KCOCCGEOECOOneofCase.OrbSyncInfo:
			OrbSyncInfo = other.OrbSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.ItemValue:
			ItemValue = other.ItemValue;
			break;
		case KCOCCGEOECOOneofCase.GridGameAugmentUpdate:
			GridGameAugmentUpdate = other.GridGameAugmentUpdate.Clone();
			break;
		case KCOCCGEOECOOneofCase.ShopSyncInfo:
			ShopSyncInfo = other.ShopSyncInfo.Clone();
			break;
		case KCOCCGEOECOOneofCase.RemoveNpcUniqueId:
			RemoveNpcUniqueId = other.RemoveNpcUniqueId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncData Clone()
	{
		return new GridFightSyncData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCJEMKCOCECG()
	{
		if (HasCJEMKCOCECG)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveOrbUniqueId()
	{
		if (HasRemoveOrbUniqueId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMaxBattleRoleNum()
	{
		if (HasMaxBattleRoleNum)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHLFBBANMJDJ()
	{
		if (HasHLFBBANMJDJ)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAJIMOAMGCII()
	{
		if (HasAJIMOAMGCII)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGridFightComboWinNum()
	{
		if (HasGridFightComboWinNum)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGDPBJDHGFLB()
	{
		if (HasGDPBJDHGFLB)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveAugmentUniqueId()
	{
		if (HasRemoveAugmentUniqueId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGridFightMaxAvatarCount()
	{
		if (HasGridFightMaxAvatarCount)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFinishPendingActionPos()
	{
		if (HasFinishPendingActionPos)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGridFightMaxInterestGold()
	{
		if (HasGridFightMaxInterestGold)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKACHJHDMNLM()
	{
		if (HasKACHJHDMNLM)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGridFightOffFieldMaxCount()
	{
		if (HasGridFightOffFieldMaxCount)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLockType()
	{
		if (HasLockType)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGridFightBuyExpCost()
	{
		if (HasGridFightBuyExpCost)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveForgeUniqueId()
	{
		if (HasRemoveForgeUniqueId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveTraitEffectId()
	{
		if (HasRemoveTraitEffectId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFHHHEBLMOBL()
	{
		if (HasFHHHEBLMOBL)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveRoleUniqueId()
	{
		if (HasRemoveRoleUniqueId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearItemValue()
	{
		if (HasItemValue)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveNpcUniqueId()
	{
		if (HasRemoveNpcUniqueId)
		{
			ClearKCOCCGEOECO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKCOCCGEOECO()
	{
		kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.None;
		kCOCCGEOECO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSyncData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSyncData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CJEMKCOCECG != other.CJEMKCOCECG)
		{
			return false;
		}
		if (RemoveOrbUniqueId != other.RemoveOrbUniqueId)
		{
			return false;
		}
		if (!object.Equals(EquipmentTrackSyncInfo, other.EquipmentTrackSyncInfo))
		{
			return false;
		}
		if (MaxBattleRoleNum != other.MaxBattleRoleNum)
		{
			return false;
		}
		if (!object.Equals(CFNPGNMPNDN, other.CFNPGNMPNDN))
		{
			return false;
		}
		if (!object.Equals(AddRoleInfo, other.AddRoleInfo))
		{
			return false;
		}
		if (!object.Equals(AddNpcInfo, other.AddNpcInfo))
		{
			return false;
		}
		if (HLFBBANMJDJ != other.HLFBBANMJDJ)
		{
			return false;
		}
		if (!object.Equals(TraitSyncInfo, other.TraitSyncInfo))
		{
			return false;
		}
		if (!object.Equals(PortalServerDataUpdate, other.PortalServerDataUpdate))
		{
			return false;
		}
		if (!object.Equals(UpdateGameItemInfo, other.UpdateGameItemInfo))
		{
			return false;
		}
		if (!object.Equals(AddForgeInfo, other.AddForgeInfo))
		{
			return false;
		}
		if (!object.Equals(UpdateRoleInfo, other.UpdateRoleInfo))
		{
			return false;
		}
		if (AJIMOAMGCII != other.AJIMOAMGCII)
		{
			return false;
		}
		if (!object.Equals(GridFightDamageSttInfo, other.GridFightDamageSttInfo))
		{
			return false;
		}
		if (GridFightComboWinNum != other.GridFightComboWinNum)
		{
			return false;
		}
		if (!object.Equals(SyncLockInfo, other.SyncLockInfo))
		{
			return false;
		}
		if (GDPBJDHGFLB != other.GDPBJDHGFLB)
		{
			return false;
		}
		if (RemoveAugmentUniqueId != other.RemoveAugmentUniqueId)
		{
			return false;
		}
		if (GridFightMaxAvatarCount != other.GridFightMaxAvatarCount)
		{
			return false;
		}
		if (!object.Equals(AugmentSyncInfo, other.AugmentSyncInfo))
		{
			return false;
		}
		if (FinishPendingActionPos != other.FinishPendingActionPos)
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!object.Equals(POIPGNHONMA, other.POIPGNHONMA))
		{
			return false;
		}
		if (!object.Equals(LevelSyncInfo, other.LevelSyncInfo))
		{
			return false;
		}
		if (GridFightMaxInterestGold != other.GridFightMaxInterestGold)
		{
			return false;
		}
		if (!object.Equals(UpdateForgeInfo, other.UpdateForgeInfo))
		{
			return false;
		}
		if (!object.Equals(PlayerLevel, other.PlayerLevel))
		{
			return false;
		}
		if (KACHJHDMNLM != other.KACHJHDMNLM)
		{
			return false;
		}
		if (!object.Equals(JIFKOHLNHAK, other.JIFKOHLNHAK))
		{
			return false;
		}
		if (!object.Equals(GridFightTutorialSync, other.GridFightTutorialSync))
		{
			return false;
		}
		if (GridFightOffFieldMaxCount != other.GridFightOffFieldMaxCount)
		{
			return false;
		}
		if (LockType != other.LockType)
		{
			return false;
		}
		if (!object.Equals(RemoveGameItemInfo, other.RemoveGameItemInfo))
		{
			return false;
		}
		if (!object.Equals(GridFightLineupHp, other.GridFightLineupHp))
		{
			return false;
		}
		if (!object.Equals(SectionRecordSyncInfo, other.SectionRecordSyncInfo))
		{
			return false;
		}
		if (!object.Equals(GridFightSyncGameItemInfo, other.GridFightSyncGameItemInfo))
		{
			return false;
		}
		if (GridFightBuyExpCost != other.GridFightBuyExpCost)
		{
			return false;
		}
		if (!object.Equals(TraitTrackSyncInfo, other.TraitTrackSyncInfo))
		{
			return false;
		}
		if (!object.Equals(BAODHPCOJLH, other.BAODHPCOJLH))
		{
			return false;
		}
		if (!object.Equals(AddGameItemInfo, other.AddGameItemInfo))
		{
			return false;
		}
		if (!object.Equals(UpdateNpcInfo, other.UpdateNpcInfo))
		{
			return false;
		}
		if (RemoveForgeUniqueId != other.RemoveForgeUniqueId)
		{
			return false;
		}
		if (RemoveTraitEffectId != other.RemoveTraitEffectId)
		{
			return false;
		}
		if (!object.Equals(GMJLJDJDIGM, other.GMJLJDJDIGM))
		{
			return false;
		}
		if (FHHHEBLMOBL != other.FHHHEBLMOBL)
		{
			return false;
		}
		if (RemoveRoleUniqueId != other.RemoveRoleUniqueId)
		{
			return false;
		}
		if (!object.Equals(EliteBranchSyncInfo, other.EliteBranchSyncInfo))
		{
			return false;
		}
		if (!object.Equals(IBCEPCFFMOL, other.IBCEPCFFMOL))
		{
			return false;
		}
		if (!object.Equals(PGPKPMOIAIL, other.PGPKPMOIAIL))
		{
			return false;
		}
		if (!object.Equals(OrbSyncInfo, other.OrbSyncInfo))
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (!object.Equals(GridGameAugmentUpdate, other.GridGameAugmentUpdate))
		{
			return false;
		}
		if (!object.Equals(ShopSyncInfo, other.ShopSyncInfo))
		{
			return false;
		}
		if (RemoveNpcUniqueId != other.RemoveNpcUniqueId)
		{
			return false;
		}
		if (KCOCCGEOECOCase != other.KCOCCGEOECOCase)
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
		if (HasCJEMKCOCECG)
		{
			num ^= CJEMKCOCECG.GetHashCode();
		}
		if (HasRemoveOrbUniqueId)
		{
			num ^= RemoveOrbUniqueId.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo)
		{
			num ^= EquipmentTrackSyncInfo.GetHashCode();
		}
		if (HasMaxBattleRoleNum)
		{
			num ^= MaxBattleRoleNum.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CFNPGNMPNDN)
		{
			num ^= CFNPGNMPNDN.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddRoleInfo)
		{
			num ^= AddRoleInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddNpcInfo)
		{
			num ^= AddNpcInfo.GetHashCode();
		}
		if (HasHLFBBANMJDJ)
		{
			num ^= HLFBBANMJDJ.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitSyncInfo)
		{
			num ^= TraitSyncInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PortalServerDataUpdate)
		{
			num ^= PortalServerDataUpdate.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateGameItemInfo)
		{
			num ^= UpdateGameItemInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddForgeInfo)
		{
			num ^= AddForgeInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateRoleInfo)
		{
			num ^= UpdateRoleInfo.GetHashCode();
		}
		if (HasAJIMOAMGCII)
		{
			num ^= AJIMOAMGCII.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightDamageSttInfo)
		{
			num ^= GridFightDamageSttInfo.GetHashCode();
		}
		if (HasGridFightComboWinNum)
		{
			num ^= GridFightComboWinNum.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SyncLockInfo)
		{
			num ^= SyncLockInfo.GetHashCode();
		}
		if (HasGDPBJDHGFLB)
		{
			num ^= GDPBJDHGFLB.GetHashCode();
		}
		if (HasRemoveAugmentUniqueId)
		{
			num ^= RemoveAugmentUniqueId.GetHashCode();
		}
		if (HasGridFightMaxAvatarCount)
		{
			num ^= GridFightMaxAvatarCount.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AugmentSyncInfo)
		{
			num ^= AugmentSyncInfo.GetHashCode();
		}
		if (HasFinishPendingActionPos)
		{
			num ^= FinishPendingActionPos.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PendingAction)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.POIPGNHONMA)
		{
			num ^= POIPGNHONMA.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LevelSyncInfo)
		{
			num ^= LevelSyncInfo.GetHashCode();
		}
		if (HasGridFightMaxInterestGold)
		{
			num ^= GridFightMaxInterestGold.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateForgeInfo)
		{
			num ^= UpdateForgeInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PlayerLevel)
		{
			num ^= PlayerLevel.GetHashCode();
		}
		if (HasKACHJHDMNLM)
		{
			num ^= KACHJHDMNLM.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JIFKOHLNHAK)
		{
			num ^= JIFKOHLNHAK.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightTutorialSync)
		{
			num ^= GridFightTutorialSync.GetHashCode();
		}
		if (HasGridFightOffFieldMaxCount)
		{
			num ^= GridFightOffFieldMaxCount.GetHashCode();
		}
		if (HasLockType)
		{
			num ^= LockType.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveGameItemInfo)
		{
			num ^= RemoveGameItemInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightLineupHp)
		{
			num ^= GridFightLineupHp.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SectionRecordSyncInfo)
		{
			num ^= SectionRecordSyncInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo)
		{
			num ^= GridFightSyncGameItemInfo.GetHashCode();
		}
		if (HasGridFightBuyExpCost)
		{
			num ^= GridFightBuyExpCost.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitTrackSyncInfo)
		{
			num ^= TraitTrackSyncInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BAODHPCOJLH)
		{
			num ^= BAODHPCOJLH.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddGameItemInfo)
		{
			num ^= AddGameItemInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateNpcInfo)
		{
			num ^= UpdateNpcInfo.GetHashCode();
		}
		if (HasRemoveForgeUniqueId)
		{
			num ^= RemoveForgeUniqueId.GetHashCode();
		}
		if (HasRemoveTraitEffectId)
		{
			num ^= RemoveTraitEffectId.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GMJLJDJDIGM)
		{
			num ^= GMJLJDJDIGM.GetHashCode();
		}
		if (HasFHHHEBLMOBL)
		{
			num ^= FHHHEBLMOBL.GetHashCode();
		}
		if (HasRemoveRoleUniqueId)
		{
			num ^= RemoveRoleUniqueId.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EliteBranchSyncInfo)
		{
			num ^= EliteBranchSyncInfo.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.IBCEPCFFMOL)
		{
			num ^= IBCEPCFFMOL.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PGPKPMOIAIL)
		{
			num ^= PGPKPMOIAIL.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OrbSyncInfo)
		{
			num ^= OrbSyncInfo.GetHashCode();
		}
		if (HasItemValue)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridGameAugmentUpdate)
		{
			num ^= GridGameAugmentUpdate.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ShopSyncInfo)
		{
			num ^= ShopSyncInfo.GetHashCode();
		}
		if (HasRemoveNpcUniqueId)
		{
			num ^= RemoveNpcUniqueId.GetHashCode();
		}
		num ^= (int)kCOCCGEOECOCase_;
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
		if (HasCJEMKCOCECG)
		{
			output.WriteRawTag(152, 1);
			output.WriteUInt32(CJEMKCOCECG);
		}
		if (HasRemoveOrbUniqueId)
		{
			output.WriteRawTag(168, 3);
			output.WriteUInt32(RemoveOrbUniqueId);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo)
		{
			output.WriteRawTag(202, 3);
			output.WriteMessage(EquipmentTrackSyncInfo);
		}
		if (HasMaxBattleRoleNum)
		{
			output.WriteRawTag(192, 4);
			output.WriteUInt32(MaxBattleRoleNum);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CFNPGNMPNDN)
		{
			output.WriteRawTag(226, 8);
			output.WriteMessage(CFNPGNMPNDN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddRoleInfo)
		{
			output.WriteRawTag(146, 13);
			output.WriteMessage(AddRoleInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddNpcInfo)
		{
			output.WriteRawTag(178, 14);
			output.WriteMessage(AddNpcInfo);
		}
		if (HasHLFBBANMJDJ)
		{
			output.WriteRawTag(136, 16);
			output.WriteUInt32(HLFBBANMJDJ);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitSyncInfo)
		{
			output.WriteRawTag(146, 16);
			output.WriteMessage(TraitSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PortalServerDataUpdate)
		{
			output.WriteRawTag(250, 16);
			output.WriteMessage(PortalServerDataUpdate);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateGameItemInfo)
		{
			output.WriteRawTag(226, 17);
			output.WriteMessage(UpdateGameItemInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddForgeInfo)
		{
			output.WriteRawTag(146, 24);
			output.WriteMessage(AddForgeInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateRoleInfo)
		{
			output.WriteRawTag(202, 24);
			output.WriteMessage(UpdateRoleInfo);
		}
		if (HasAJIMOAMGCII)
		{
			output.WriteRawTag(184, 26);
			output.WriteUInt32(AJIMOAMGCII);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightDamageSttInfo)
		{
			output.WriteRawTag(170, 27);
			output.WriteMessage(GridFightDamageSttInfo);
		}
		if (HasGridFightComboWinNum)
		{
			output.WriteRawTag(232, 28);
			output.WriteUInt32(GridFightComboWinNum);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SyncLockInfo)
		{
			output.WriteRawTag(162, 29);
			output.WriteMessage(SyncLockInfo);
		}
		if (HasGDPBJDHGFLB)
		{
			output.WriteRawTag(160, 32);
			output.WriteUInt32(GDPBJDHGFLB);
		}
		if (HasRemoveAugmentUniqueId)
		{
			output.WriteRawTag(216, 32);
			output.WriteUInt32(RemoveAugmentUniqueId);
		}
		if (HasGridFightMaxAvatarCount)
		{
			output.WriteRawTag(160, 34);
			output.WriteUInt32(GridFightMaxAvatarCount);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AugmentSyncInfo)
		{
			output.WriteRawTag(242, 34);
			output.WriteMessage(AugmentSyncInfo);
		}
		if (HasFinishPendingActionPos)
		{
			output.WriteRawTag(232, 35);
			output.WriteUInt32(FinishPendingActionPos);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PendingAction)
		{
			output.WriteRawTag(146, 49);
			output.WriteMessage(PendingAction);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.POIPGNHONMA)
		{
			output.WriteRawTag(242, 49);
			output.WriteMessage(POIPGNHONMA);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LevelSyncInfo)
		{
			output.WriteRawTag(178, 52);
			output.WriteMessage(LevelSyncInfo);
		}
		if (HasGridFightMaxInterestGold)
		{
			output.WriteRawTag(184, 53);
			output.WriteUInt32(GridFightMaxInterestGold);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateForgeInfo)
		{
			output.WriteRawTag(234, 56);
			output.WriteMessage(UpdateForgeInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PlayerLevel)
		{
			output.WriteRawTag(154, 62);
			output.WriteMessage(PlayerLevel);
		}
		if (HasKACHJHDMNLM)
		{
			output.WriteRawTag(160, 62);
			output.WriteUInt32(KACHJHDMNLM);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JIFKOHLNHAK)
		{
			output.WriteRawTag(194, 63);
			output.WriteMessage(JIFKOHLNHAK);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightTutorialSync)
		{
			output.WriteRawTag(242, 63);
			output.WriteMessage(GridFightTutorialSync);
		}
		if (HasGridFightOffFieldMaxCount)
		{
			output.WriteRawTag(176, 66);
			output.WriteUInt32(GridFightOffFieldMaxCount);
		}
		if (HasLockType)
		{
			output.WriteRawTag(192, 69);
			output.WriteEnum((int)LockType);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveGameItemInfo)
		{
			output.WriteRawTag(202, 70);
			output.WriteMessage(RemoveGameItemInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightLineupHp)
		{
			output.WriteRawTag(146, 71);
			output.WriteMessage(GridFightLineupHp);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SectionRecordSyncInfo)
		{
			output.WriteRawTag(154, 72);
			output.WriteMessage(SectionRecordSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo)
		{
			output.WriteRawTag(242, 73);
			output.WriteMessage(GridFightSyncGameItemInfo);
		}
		if (HasGridFightBuyExpCost)
		{
			output.WriteRawTag(200, 77);
			output.WriteUInt32(GridFightBuyExpCost);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitTrackSyncInfo)
		{
			output.WriteRawTag(138, 84);
			output.WriteMessage(TraitTrackSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BAODHPCOJLH)
		{
			output.WriteRawTag(162, 90);
			output.WriteMessage(BAODHPCOJLH);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddGameItemInfo)
		{
			output.WriteRawTag(202, 94);
			output.WriteMessage(AddGameItemInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateNpcInfo)
		{
			output.WriteRawTag(234, 94);
			output.WriteMessage(UpdateNpcInfo);
		}
		if (HasRemoveForgeUniqueId)
		{
			output.WriteRawTag(224, 97);
			output.WriteUInt32(RemoveForgeUniqueId);
		}
		if (HasRemoveTraitEffectId)
		{
			output.WriteRawTag(192, 100);
			output.WriteUInt32(RemoveTraitEffectId);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GMJLJDJDIGM)
		{
			output.WriteRawTag(226, 101);
			output.WriteMessage(GMJLJDJDIGM);
		}
		if (HasFHHHEBLMOBL)
		{
			output.WriteRawTag(224, 103);
			output.WriteUInt32(FHHHEBLMOBL);
		}
		if (HasRemoveRoleUniqueId)
		{
			output.WriteRawTag(192, 106);
			output.WriteUInt32(RemoveRoleUniqueId);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EliteBranchSyncInfo)
		{
			output.WriteRawTag(210, 108);
			output.WriteMessage(EliteBranchSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.IBCEPCFFMOL)
		{
			output.WriteRawTag(170, 113);
			output.WriteMessage(IBCEPCFFMOL);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PGPKPMOIAIL)
		{
			output.WriteRawTag(146, 116);
			output.WriteMessage(PGPKPMOIAIL);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OrbSyncInfo)
		{
			output.WriteRawTag(186, 118);
			output.WriteMessage(OrbSyncInfo);
		}
		if (HasItemValue)
		{
			output.WriteRawTag(184, 121);
			output.WriteUInt32(ItemValue);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridGameAugmentUpdate)
		{
			output.WriteRawTag(210, 124);
			output.WriteMessage(GridGameAugmentUpdate);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ShopSyncInfo)
		{
			output.WriteRawTag(186, 127);
			output.WriteMessage(ShopSyncInfo);
		}
		if (HasRemoveNpcUniqueId)
		{
			output.WriteRawTag(192, 127);
			output.WriteUInt32(RemoveNpcUniqueId);
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
		if (HasCJEMKCOCECG)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(CJEMKCOCECG);
		}
		if (HasRemoveOrbUniqueId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(RemoveOrbUniqueId);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EquipmentTrackSyncInfo);
		}
		if (HasMaxBattleRoleNum)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MaxBattleRoleNum);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CFNPGNMPNDN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CFNPGNMPNDN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddRoleInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AddRoleInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddNpcInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AddNpcInfo);
		}
		if (HasHLFBBANMJDJ)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HLFBBANMJDJ);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TraitSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PortalServerDataUpdate)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PortalServerDataUpdate);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateGameItemInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpdateGameItemInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddForgeInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AddForgeInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateRoleInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpdateRoleInfo);
		}
		if (HasAJIMOAMGCII)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AJIMOAMGCII);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightDamageSttInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GridFightDamageSttInfo);
		}
		if (HasGridFightComboWinNum)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GridFightComboWinNum);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SyncLockInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SyncLockInfo);
		}
		if (HasGDPBJDHGFLB)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GDPBJDHGFLB);
		}
		if (HasRemoveAugmentUniqueId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(RemoveAugmentUniqueId);
		}
		if (HasGridFightMaxAvatarCount)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GridFightMaxAvatarCount);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AugmentSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AugmentSyncInfo);
		}
		if (HasFinishPendingActionPos)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(FinishPendingActionPos);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PendingAction)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.POIPGNHONMA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(POIPGNHONMA);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LevelSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LevelSyncInfo);
		}
		if (HasGridFightMaxInterestGold)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GridFightMaxInterestGold);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateForgeInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpdateForgeInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PlayerLevel)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerLevel);
		}
		if (HasKACHJHDMNLM)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KACHJHDMNLM);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JIFKOHLNHAK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JIFKOHLNHAK);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightTutorialSync)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GridFightTutorialSync);
		}
		if (HasGridFightOffFieldMaxCount)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GridFightOffFieldMaxCount);
		}
		if (HasLockType)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)LockType);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveGameItemInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RemoveGameItemInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightLineupHp)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GridFightLineupHp);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SectionRecordSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SectionRecordSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GridFightSyncGameItemInfo);
		}
		if (HasGridFightBuyExpCost)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GridFightBuyExpCost);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitTrackSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TraitTrackSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BAODHPCOJLH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BAODHPCOJLH);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddGameItemInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AddGameItemInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateNpcInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(UpdateNpcInfo);
		}
		if (HasRemoveForgeUniqueId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(RemoveForgeUniqueId);
		}
		if (HasRemoveTraitEffectId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(RemoveTraitEffectId);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GMJLJDJDIGM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GMJLJDJDIGM);
		}
		if (HasFHHHEBLMOBL)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(FHHHEBLMOBL);
		}
		if (HasRemoveRoleUniqueId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(RemoveRoleUniqueId);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EliteBranchSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EliteBranchSyncInfo);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.IBCEPCFFMOL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IBCEPCFFMOL);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PGPKPMOIAIL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PGPKPMOIAIL);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OrbSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OrbSyncInfo);
		}
		if (HasItemValue)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridGameAugmentUpdate)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GridGameAugmentUpdate);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ShopSyncInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ShopSyncInfo);
		}
		if (HasRemoveNpcUniqueId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(RemoveNpcUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSyncData other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.CJEMKCOCECG:
			CJEMKCOCECG = other.CJEMKCOCECG;
			break;
		case KCOCCGEOECOOneofCase.RemoveOrbUniqueId:
			RemoveOrbUniqueId = other.RemoveOrbUniqueId;
			break;
		case KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo:
			if (EquipmentTrackSyncInfo == null)
			{
				EquipmentTrackSyncInfo = new RoleTrackEquipmentSyncInfo();
			}
			EquipmentTrackSyncInfo.MergeFrom(other.EquipmentTrackSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.MaxBattleRoleNum:
			MaxBattleRoleNum = other.MaxBattleRoleNum;
			break;
		case KCOCCGEOECOOneofCase.CFNPGNMPNDN:
			if (CFNPGNMPNDN == null)
			{
				CFNPGNMPNDN = new CMCJNKPKBEM();
			}
			CFNPGNMPNDN.MergeFrom(other.CFNPGNMPNDN);
			break;
		case KCOCCGEOECOOneofCase.AddRoleInfo:
			if (AddRoleInfo == null)
			{
				AddRoleInfo = new GridGameRoleInfo();
			}
			AddRoleInfo.MergeFrom(other.AddRoleInfo);
			break;
		case KCOCCGEOECOOneofCase.AddNpcInfo:
			if (AddNpcInfo == null)
			{
				AddNpcInfo = new GridGameNpcInfo();
			}
			AddNpcInfo.MergeFrom(other.AddNpcInfo);
			break;
		case KCOCCGEOECOOneofCase.HLFBBANMJDJ:
			HLFBBANMJDJ = other.HLFBBANMJDJ;
			break;
		case KCOCCGEOECOOneofCase.TraitSyncInfo:
			if (TraitSyncInfo == null)
			{
				TraitSyncInfo = new GridFightTraitSyncInfo();
			}
			TraitSyncInfo.MergeFrom(other.TraitSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.PortalServerDataUpdate:
			if (PortalServerDataUpdate == null)
			{
				PortalServerDataUpdate = new GridFightPortalServerDataUpdate();
			}
			PortalServerDataUpdate.MergeFrom(other.PortalServerDataUpdate);
			break;
		case KCOCCGEOECOOneofCase.UpdateGameItemInfo:
			if (UpdateGameItemInfo == null)
			{
				UpdateGameItemInfo = new GridFightGameItemSyncInfo();
			}
			UpdateGameItemInfo.MergeFrom(other.UpdateGameItemInfo);
			break;
		case KCOCCGEOECOOneofCase.AddForgeInfo:
			if (AddForgeInfo == null)
			{
				AddForgeInfo = new GridGameForgeItemInfo();
			}
			AddForgeInfo.MergeFrom(other.AddForgeInfo);
			break;
		case KCOCCGEOECOOneofCase.UpdateRoleInfo:
			if (UpdateRoleInfo == null)
			{
				UpdateRoleInfo = new GridGameRoleInfo();
			}
			UpdateRoleInfo.MergeFrom(other.UpdateRoleInfo);
			break;
		case KCOCCGEOECOOneofCase.AJIMOAMGCII:
			AJIMOAMGCII = other.AJIMOAMGCII;
			break;
		case KCOCCGEOECOOneofCase.GridFightDamageSttInfo:
			if (GridFightDamageSttInfo == null)
			{
				GridFightDamageSttInfo = new GridFightDamageSttInfo();
			}
			GridFightDamageSttInfo.MergeFrom(other.GridFightDamageSttInfo);
			break;
		case KCOCCGEOECOOneofCase.GridFightComboWinNum:
			GridFightComboWinNum = other.GridFightComboWinNum;
			break;
		case KCOCCGEOECOOneofCase.SyncLockInfo:
			if (SyncLockInfo == null)
			{
				SyncLockInfo = new GridFightLockInfo();
			}
			SyncLockInfo.MergeFrom(other.SyncLockInfo);
			break;
		case KCOCCGEOECOOneofCase.GDPBJDHGFLB:
			GDPBJDHGFLB = other.GDPBJDHGFLB;
			break;
		case KCOCCGEOECOOneofCase.RemoveAugmentUniqueId:
			RemoveAugmentUniqueId = other.RemoveAugmentUniqueId;
			break;
		case KCOCCGEOECOOneofCase.GridFightMaxAvatarCount:
			GridFightMaxAvatarCount = other.GridFightMaxAvatarCount;
			break;
		case KCOCCGEOECOOneofCase.AugmentSyncInfo:
			if (AugmentSyncInfo == null)
			{
				AugmentSyncInfo = new GridFightGameAugmentAdd();
			}
			AugmentSyncInfo.MergeFrom(other.AugmentSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.FinishPendingActionPos:
			FinishPendingActionPos = other.FinishPendingActionPos;
			break;
		case KCOCCGEOECOOneofCase.PendingAction:
			if (PendingAction == null)
			{
				PendingAction = new GridFightPendingAction();
			}
			PendingAction.MergeFrom(other.PendingAction);
			break;
		case KCOCCGEOECOOneofCase.POIPGNHONMA:
			if (POIPGNHONMA == null)
			{
				POIPGNHONMA = new GridGameOrbInfo();
			}
			POIPGNHONMA.MergeFrom(other.POIPGNHONMA);
			break;
		case KCOCCGEOECOOneofCase.LevelSyncInfo:
			if (LevelSyncInfo == null)
			{
				LevelSyncInfo = new GridFightLevelSyncInfo();
			}
			LevelSyncInfo.MergeFrom(other.LevelSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.GridFightMaxInterestGold:
			GridFightMaxInterestGold = other.GridFightMaxInterestGold;
			break;
		case KCOCCGEOECOOneofCase.UpdateForgeInfo:
			if (UpdateForgeInfo == null)
			{
				UpdateForgeInfo = new GridGameForgeItemInfo();
			}
			UpdateForgeInfo.MergeFrom(other.UpdateForgeInfo);
			break;
		case KCOCCGEOECOOneofCase.PlayerLevel:
			if (PlayerLevel == null)
			{
				PlayerLevel = new GridFightPlayerLevelSyncInfo();
			}
			PlayerLevel.MergeFrom(other.PlayerLevel);
			break;
		case KCOCCGEOECOOneofCase.KACHJHDMNLM:
			KACHJHDMNLM = other.KACHJHDMNLM;
			break;
		case KCOCCGEOECOOneofCase.JIFKOHLNHAK:
			if (JIFKOHLNHAK == null)
			{
				JIFKOHLNHAK = new CKCKIDHMMEG();
			}
			JIFKOHLNHAK.MergeFrom(other.JIFKOHLNHAK);
			break;
		case KCOCCGEOECOOneofCase.GridFightTutorialSync:
			if (GridFightTutorialSync == null)
			{
				GridFightTutorialSync = new GridFightTutorialSyncInfo();
			}
			GridFightTutorialSync.MergeFrom(other.GridFightTutorialSync);
			break;
		case KCOCCGEOECOOneofCase.GridFightOffFieldMaxCount:
			GridFightOffFieldMaxCount = other.GridFightOffFieldMaxCount;
			break;
		case KCOCCGEOECOOneofCase.LockType:
			LockType = other.LockType;
			break;
		case KCOCCGEOECOOneofCase.RemoveGameItemInfo:
			if (RemoveGameItemInfo == null)
			{
				RemoveGameItemInfo = new GridFightGameItemSyncInfo();
			}
			RemoveGameItemInfo.MergeFrom(other.RemoveGameItemInfo);
			break;
		case KCOCCGEOECOOneofCase.GridFightLineupHp:
			if (GridFightLineupHp == null)
			{
				GridFightLineupHp = new GridFightLineupHpSyncInfo();
			}
			GridFightLineupHp.MergeFrom(other.GridFightLineupHp);
			break;
		case KCOCCGEOECOOneofCase.SectionRecordSyncInfo:
			if (SectionRecordSyncInfo == null)
			{
				SectionRecordSyncInfo = new GridFightSectionRecordInfo();
			}
			SectionRecordSyncInfo.MergeFrom(other.SectionRecordSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo:
			if (GridFightSyncGameItemInfo == null)
			{
				GridFightSyncGameItemInfo = new GridFightGameItemInfo();
			}
			GridFightSyncGameItemInfo.MergeFrom(other.GridFightSyncGameItemInfo);
			break;
		case KCOCCGEOECOOneofCase.GridFightBuyExpCost:
			GridFightBuyExpCost = other.GridFightBuyExpCost;
			break;
		case KCOCCGEOECOOneofCase.TraitTrackSyncInfo:
			if (TraitTrackSyncInfo == null)
			{
				TraitTrackSyncInfo = new GridFightTraitTrackSyncInfo();
			}
			TraitTrackSyncInfo.MergeFrom(other.TraitTrackSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.BAODHPCOJLH:
			if (BAODHPCOJLH == null)
			{
				BAODHPCOJLH = new CKCKIDHMMEG();
			}
			BAODHPCOJLH.MergeFrom(other.BAODHPCOJLH);
			break;
		case KCOCCGEOECOOneofCase.AddGameItemInfo:
			if (AddGameItemInfo == null)
			{
				AddGameItemInfo = new GridFightGameItemSyncInfo();
			}
			AddGameItemInfo.MergeFrom(other.AddGameItemInfo);
			break;
		case KCOCCGEOECOOneofCase.UpdateNpcInfo:
			if (UpdateNpcInfo == null)
			{
				UpdateNpcInfo = new GridGameNpcInfo();
			}
			UpdateNpcInfo.MergeFrom(other.UpdateNpcInfo);
			break;
		case KCOCCGEOECOOneofCase.RemoveForgeUniqueId:
			RemoveForgeUniqueId = other.RemoveForgeUniqueId;
			break;
		case KCOCCGEOECOOneofCase.RemoveTraitEffectId:
			RemoveTraitEffectId = other.RemoveTraitEffectId;
			break;
		case KCOCCGEOECOOneofCase.GMJLJDJDIGM:
			if (GMJLJDJDIGM == null)
			{
				GMJLJDJDIGM = new JPBCKCDEGOM();
			}
			GMJLJDJDIGM.MergeFrom(other.GMJLJDJDIGM);
			break;
		case KCOCCGEOECOOneofCase.FHHHEBLMOBL:
			FHHHEBLMOBL = other.FHHHEBLMOBL;
			break;
		case KCOCCGEOECOOneofCase.RemoveRoleUniqueId:
			RemoveRoleUniqueId = other.RemoveRoleUniqueId;
			break;
		case KCOCCGEOECOOneofCase.EliteBranchSyncInfo:
			if (EliteBranchSyncInfo == null)
			{
				EliteBranchSyncInfo = new GridFightEliteBranchSyncInfo();
			}
			EliteBranchSyncInfo.MergeFrom(other.EliteBranchSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.IBCEPCFFMOL:
			if (IBCEPCFFMOL == null)
			{
				IBCEPCFFMOL = new DIBJGAKOCLO();
			}
			IBCEPCFFMOL.MergeFrom(other.IBCEPCFFMOL);
			break;
		case KCOCCGEOECOOneofCase.PGPKPMOIAIL:
			if (PGPKPMOIAIL == null)
			{
				PGPKPMOIAIL = new CLOEPPBCKGF();
			}
			PGPKPMOIAIL.MergeFrom(other.PGPKPMOIAIL);
			break;
		case KCOCCGEOECOOneofCase.OrbSyncInfo:
			if (OrbSyncInfo == null)
			{
				OrbSyncInfo = new GridFightOrbSyncInfo();
			}
			OrbSyncInfo.MergeFrom(other.OrbSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.ItemValue:
			ItemValue = other.ItemValue;
			break;
		case KCOCCGEOECOOneofCase.GridGameAugmentUpdate:
			if (GridGameAugmentUpdate == null)
			{
				GridGameAugmentUpdate = new GridFightGameAugmentUpdate();
			}
			GridGameAugmentUpdate.MergeFrom(other.GridGameAugmentUpdate);
			break;
		case KCOCCGEOECOOneofCase.ShopSyncInfo:
			if (ShopSyncInfo == null)
			{
				ShopSyncInfo = new GridFightShopSyncInfo();
			}
			ShopSyncInfo.MergeFrom(other.ShopSyncInfo);
			break;
		case KCOCCGEOECOOneofCase.RemoveNpcUniqueId:
			RemoveNpcUniqueId = other.RemoveNpcUniqueId;
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
			case 152u:
				CJEMKCOCECG = input.ReadUInt32();
				break;
			case 424u:
				RemoveOrbUniqueId = input.ReadUInt32();
				break;
			case 458u:
			{
				RoleTrackEquipmentSyncInfo roleTrackEquipmentSyncInfo = new RoleTrackEquipmentSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EquipmentTrackSyncInfo)
				{
					roleTrackEquipmentSyncInfo.MergeFrom(EquipmentTrackSyncInfo);
				}
				input.ReadMessage(roleTrackEquipmentSyncInfo);
				EquipmentTrackSyncInfo = roleTrackEquipmentSyncInfo;
				break;
			}
			case 576u:
				MaxBattleRoleNum = input.ReadUInt32();
				break;
			case 1122u:
			{
				CMCJNKPKBEM cMCJNKPKBEM = new CMCJNKPKBEM();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.CFNPGNMPNDN)
				{
					cMCJNKPKBEM.MergeFrom(CFNPGNMPNDN);
				}
				input.ReadMessage(cMCJNKPKBEM);
				CFNPGNMPNDN = cMCJNKPKBEM;
				break;
			}
			case 1682u:
			{
				GridGameRoleInfo gridGameRoleInfo2 = new GridGameRoleInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddRoleInfo)
				{
					gridGameRoleInfo2.MergeFrom(AddRoleInfo);
				}
				input.ReadMessage(gridGameRoleInfo2);
				AddRoleInfo = gridGameRoleInfo2;
				break;
			}
			case 1842u:
			{
				GridGameNpcInfo gridGameNpcInfo2 = new GridGameNpcInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddNpcInfo)
				{
					gridGameNpcInfo2.MergeFrom(AddNpcInfo);
				}
				input.ReadMessage(gridGameNpcInfo2);
				AddNpcInfo = gridGameNpcInfo2;
				break;
			}
			case 2056u:
				HLFBBANMJDJ = input.ReadUInt32();
				break;
			case 2066u:
			{
				GridFightTraitSyncInfo gridFightTraitSyncInfo = new GridFightTraitSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitSyncInfo)
				{
					gridFightTraitSyncInfo.MergeFrom(TraitSyncInfo);
				}
				input.ReadMessage(gridFightTraitSyncInfo);
				TraitSyncInfo = gridFightTraitSyncInfo;
				break;
			}
			case 2170u:
			{
				GridFightPortalServerDataUpdate gridFightPortalServerDataUpdate = new GridFightPortalServerDataUpdate();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PortalServerDataUpdate)
				{
					gridFightPortalServerDataUpdate.MergeFrom(PortalServerDataUpdate);
				}
				input.ReadMessage(gridFightPortalServerDataUpdate);
				PortalServerDataUpdate = gridFightPortalServerDataUpdate;
				break;
			}
			case 2274u:
			{
				GridFightGameItemSyncInfo gridFightGameItemSyncInfo2 = new GridFightGameItemSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateGameItemInfo)
				{
					gridFightGameItemSyncInfo2.MergeFrom(UpdateGameItemInfo);
				}
				input.ReadMessage(gridFightGameItemSyncInfo2);
				UpdateGameItemInfo = gridFightGameItemSyncInfo2;
				break;
			}
			case 3090u:
			{
				GridGameForgeItemInfo gridGameForgeItemInfo2 = new GridGameForgeItemInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddForgeInfo)
				{
					gridGameForgeItemInfo2.MergeFrom(AddForgeInfo);
				}
				input.ReadMessage(gridGameForgeItemInfo2);
				AddForgeInfo = gridGameForgeItemInfo2;
				break;
			}
			case 3146u:
			{
				GridGameRoleInfo gridGameRoleInfo = new GridGameRoleInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateRoleInfo)
				{
					gridGameRoleInfo.MergeFrom(UpdateRoleInfo);
				}
				input.ReadMessage(gridGameRoleInfo);
				UpdateRoleInfo = gridGameRoleInfo;
				break;
			}
			case 3384u:
				AJIMOAMGCII = input.ReadUInt32();
				break;
			case 3498u:
			{
				GridFightDamageSttInfo gridFightDamageSttInfo = new GridFightDamageSttInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightDamageSttInfo)
				{
					gridFightDamageSttInfo.MergeFrom(GridFightDamageSttInfo);
				}
				input.ReadMessage(gridFightDamageSttInfo);
				GridFightDamageSttInfo = gridFightDamageSttInfo;
				break;
			}
			case 3688u:
				GridFightComboWinNum = input.ReadUInt32();
				break;
			case 3746u:
			{
				GridFightLockInfo gridFightLockInfo = new GridFightLockInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SyncLockInfo)
				{
					gridFightLockInfo.MergeFrom(SyncLockInfo);
				}
				input.ReadMessage(gridFightLockInfo);
				SyncLockInfo = gridFightLockInfo;
				break;
			}
			case 4128u:
				GDPBJDHGFLB = input.ReadUInt32();
				break;
			case 4184u:
				RemoveAugmentUniqueId = input.ReadUInt32();
				break;
			case 4384u:
				GridFightMaxAvatarCount = input.ReadUInt32();
				break;
			case 4466u:
			{
				GridFightGameAugmentAdd gridFightGameAugmentAdd = new GridFightGameAugmentAdd();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AugmentSyncInfo)
				{
					gridFightGameAugmentAdd.MergeFrom(AugmentSyncInfo);
				}
				input.ReadMessage(gridFightGameAugmentAdd);
				AugmentSyncInfo = gridFightGameAugmentAdd;
				break;
			}
			case 4584u:
				FinishPendingActionPos = input.ReadUInt32();
				break;
			case 6290u:
			{
				GridFightPendingAction gridFightPendingAction = new GridFightPendingAction();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PendingAction)
				{
					gridFightPendingAction.MergeFrom(PendingAction);
				}
				input.ReadMessage(gridFightPendingAction);
				PendingAction = gridFightPendingAction;
				break;
			}
			case 6386u:
			{
				GridGameOrbInfo gridGameOrbInfo = new GridGameOrbInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.POIPGNHONMA)
				{
					gridGameOrbInfo.MergeFrom(POIPGNHONMA);
				}
				input.ReadMessage(gridGameOrbInfo);
				POIPGNHONMA = gridGameOrbInfo;
				break;
			}
			case 6706u:
			{
				GridFightLevelSyncInfo gridFightLevelSyncInfo = new GridFightLevelSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LevelSyncInfo)
				{
					gridFightLevelSyncInfo.MergeFrom(LevelSyncInfo);
				}
				input.ReadMessage(gridFightLevelSyncInfo);
				LevelSyncInfo = gridFightLevelSyncInfo;
				break;
			}
			case 6840u:
				GridFightMaxInterestGold = input.ReadUInt32();
				break;
			case 7274u:
			{
				GridGameForgeItemInfo gridGameForgeItemInfo = new GridGameForgeItemInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateForgeInfo)
				{
					gridGameForgeItemInfo.MergeFrom(UpdateForgeInfo);
				}
				input.ReadMessage(gridGameForgeItemInfo);
				UpdateForgeInfo = gridGameForgeItemInfo;
				break;
			}
			case 7962u:
			{
				GridFightPlayerLevelSyncInfo gridFightPlayerLevelSyncInfo = new GridFightPlayerLevelSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PlayerLevel)
				{
					gridFightPlayerLevelSyncInfo.MergeFrom(PlayerLevel);
				}
				input.ReadMessage(gridFightPlayerLevelSyncInfo);
				PlayerLevel = gridFightPlayerLevelSyncInfo;
				break;
			}
			case 7968u:
				KACHJHDMNLM = input.ReadUInt32();
				break;
			case 8130u:
			{
				CKCKIDHMMEG cKCKIDHMMEG = new CKCKIDHMMEG();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JIFKOHLNHAK)
				{
					cKCKIDHMMEG.MergeFrom(JIFKOHLNHAK);
				}
				input.ReadMessage(cKCKIDHMMEG);
				JIFKOHLNHAK = cKCKIDHMMEG;
				break;
			}
			case 8178u:
			{
				GridFightTutorialSyncInfo gridFightTutorialSyncInfo = new GridFightTutorialSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightTutorialSync)
				{
					gridFightTutorialSyncInfo.MergeFrom(GridFightTutorialSync);
				}
				input.ReadMessage(gridFightTutorialSyncInfo);
				GridFightTutorialSync = gridFightTutorialSyncInfo;
				break;
			}
			case 8496u:
				GridFightOffFieldMaxCount = input.ReadUInt32();
				break;
			case 8896u:
				kCOCCGEOECO_ = input.ReadEnum();
				kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.LockType;
				break;
			case 9034u:
			{
				GridFightGameItemSyncInfo gridFightGameItemSyncInfo3 = new GridFightGameItemSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.RemoveGameItemInfo)
				{
					gridFightGameItemSyncInfo3.MergeFrom(RemoveGameItemInfo);
				}
				input.ReadMessage(gridFightGameItemSyncInfo3);
				RemoveGameItemInfo = gridFightGameItemSyncInfo3;
				break;
			}
			case 9106u:
			{
				GridFightLineupHpSyncInfo gridFightLineupHpSyncInfo = new GridFightLineupHpSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightLineupHp)
				{
					gridFightLineupHpSyncInfo.MergeFrom(GridFightLineupHp);
				}
				input.ReadMessage(gridFightLineupHpSyncInfo);
				GridFightLineupHp = gridFightLineupHpSyncInfo;
				break;
			}
			case 9242u:
			{
				GridFightSectionRecordInfo gridFightSectionRecordInfo = new GridFightSectionRecordInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.SectionRecordSyncInfo)
				{
					gridFightSectionRecordInfo.MergeFrom(SectionRecordSyncInfo);
				}
				input.ReadMessage(gridFightSectionRecordInfo);
				SectionRecordSyncInfo = gridFightSectionRecordInfo;
				break;
			}
			case 9458u:
			{
				GridFightGameItemInfo gridFightGameItemInfo = new GridFightGameItemInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridFightSyncGameItemInfo)
				{
					gridFightGameItemInfo.MergeFrom(GridFightSyncGameItemInfo);
				}
				input.ReadMessage(gridFightGameItemInfo);
				GridFightSyncGameItemInfo = gridFightGameItemInfo;
				break;
			}
			case 9928u:
				GridFightBuyExpCost = input.ReadUInt32();
				break;
			case 10762u:
			{
				GridFightTraitTrackSyncInfo gridFightTraitTrackSyncInfo = new GridFightTraitTrackSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.TraitTrackSyncInfo)
				{
					gridFightTraitTrackSyncInfo.MergeFrom(TraitTrackSyncInfo);
				}
				input.ReadMessage(gridFightTraitTrackSyncInfo);
				TraitTrackSyncInfo = gridFightTraitTrackSyncInfo;
				break;
			}
			case 11554u:
			{
				CKCKIDHMMEG cKCKIDHMMEG2 = new CKCKIDHMMEG();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BAODHPCOJLH)
				{
					cKCKIDHMMEG2.MergeFrom(BAODHPCOJLH);
				}
				input.ReadMessage(cKCKIDHMMEG2);
				BAODHPCOJLH = cKCKIDHMMEG2;
				break;
			}
			case 12106u:
			{
				GridFightGameItemSyncInfo gridFightGameItemSyncInfo = new GridFightGameItemSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AddGameItemInfo)
				{
					gridFightGameItemSyncInfo.MergeFrom(AddGameItemInfo);
				}
				input.ReadMessage(gridFightGameItemSyncInfo);
				AddGameItemInfo = gridFightGameItemSyncInfo;
				break;
			}
			case 12138u:
			{
				GridGameNpcInfo gridGameNpcInfo = new GridGameNpcInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.UpdateNpcInfo)
				{
					gridGameNpcInfo.MergeFrom(UpdateNpcInfo);
				}
				input.ReadMessage(gridGameNpcInfo);
				UpdateNpcInfo = gridGameNpcInfo;
				break;
			}
			case 12512u:
				RemoveForgeUniqueId = input.ReadUInt32();
				break;
			case 12864u:
				RemoveTraitEffectId = input.ReadUInt32();
				break;
			case 13026u:
			{
				JPBCKCDEGOM jPBCKCDEGOM = new JPBCKCDEGOM();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GMJLJDJDIGM)
				{
					jPBCKCDEGOM.MergeFrom(GMJLJDJDIGM);
				}
				input.ReadMessage(jPBCKCDEGOM);
				GMJLJDJDIGM = jPBCKCDEGOM;
				break;
			}
			case 13280u:
				FHHHEBLMOBL = input.ReadUInt32();
				break;
			case 13632u:
				RemoveRoleUniqueId = input.ReadUInt32();
				break;
			case 13906u:
			{
				GridFightEliteBranchSyncInfo gridFightEliteBranchSyncInfo = new GridFightEliteBranchSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EliteBranchSyncInfo)
				{
					gridFightEliteBranchSyncInfo.MergeFrom(EliteBranchSyncInfo);
				}
				input.ReadMessage(gridFightEliteBranchSyncInfo);
				EliteBranchSyncInfo = gridFightEliteBranchSyncInfo;
				break;
			}
			case 14506u:
			{
				DIBJGAKOCLO dIBJGAKOCLO = new DIBJGAKOCLO();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.IBCEPCFFMOL)
				{
					dIBJGAKOCLO.MergeFrom(IBCEPCFFMOL);
				}
				input.ReadMessage(dIBJGAKOCLO);
				IBCEPCFFMOL = dIBJGAKOCLO;
				break;
			}
			case 14866u:
			{
				CLOEPPBCKGF cLOEPPBCKGF = new CLOEPPBCKGF();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PGPKPMOIAIL)
				{
					cLOEPPBCKGF.MergeFrom(PGPKPMOIAIL);
				}
				input.ReadMessage(cLOEPPBCKGF);
				PGPKPMOIAIL = cLOEPPBCKGF;
				break;
			}
			case 15162u:
			{
				GridFightOrbSyncInfo gridFightOrbSyncInfo = new GridFightOrbSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OrbSyncInfo)
				{
					gridFightOrbSyncInfo.MergeFrom(OrbSyncInfo);
				}
				input.ReadMessage(gridFightOrbSyncInfo);
				OrbSyncInfo = gridFightOrbSyncInfo;
				break;
			}
			case 15544u:
				ItemValue = input.ReadUInt32();
				break;
			case 15954u:
			{
				GridFightGameAugmentUpdate gridFightGameAugmentUpdate = new GridFightGameAugmentUpdate();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GridGameAugmentUpdate)
				{
					gridFightGameAugmentUpdate.MergeFrom(GridGameAugmentUpdate);
				}
				input.ReadMessage(gridFightGameAugmentUpdate);
				GridGameAugmentUpdate = gridFightGameAugmentUpdate;
				break;
			}
			case 16314u:
			{
				GridFightShopSyncInfo gridFightShopSyncInfo = new GridFightShopSyncInfo();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ShopSyncInfo)
				{
					gridFightShopSyncInfo.MergeFrom(ShopSyncInfo);
				}
				input.ReadMessage(gridFightShopSyncInfo);
				ShopSyncInfo = gridFightShopSyncInfo;
				break;
			}
			case 16320u:
				RemoveNpcUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
