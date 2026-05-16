using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerSyncScNotify : IMessage<PlayerSyncScNotify>, IMessage, IEquatable<PlayerSyncScNotify>, IDeepCloneable<PlayerSyncScNotify>, IBufferMessage
{
	private static readonly MessageParser<PlayerSyncScNotify> _parser = new MessageParser<PlayerSyncScNotify>(() => new PlayerSyncScNotify());

	private UnknownFieldSet _unknownFields;

	public const int AvatarSyncFieldNumber = 1;

	private AvatarSync avatarSync_;

	public const int MissionSyncFieldNumber = 4;

	private MissionSync missionSync_;

	public const int RelicListFieldNumber = 5;

	private static readonly FieldCodec<Relic> _repeated_relicList_codec = FieldCodec.ForMessage(42u, Relic.Parser);

	private readonly RepeatedField<Relic> relicList_ = new RepeatedField<Relic>();

	public const int EquipmentListFieldNumber = 6;

	private static readonly FieldCodec<Equipment> _repeated_equipmentList_codec = FieldCodec.ForMessage(50u, Equipment.Parser);

	private readonly RepeatedField<Equipment> equipmentList_ = new RepeatedField<Equipment>();

	public const int CJEFCMACJLGFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_cJEFCMACJLG_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> cJEFCMACJLG_ = new RepeatedField<uint>();

	public const int WaitDelResourceListFieldNumber = 9;

	private static readonly FieldCodec<WaitDelResource> _repeated_waitDelResourceList_codec = FieldCodec.ForMessage(74u, WaitDelResource.Parser);

	private readonly RepeatedField<WaitDelResource> waitDelResourceList_ = new RepeatedField<WaitDelResource>();

	public const int DelRelicListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_delRelicList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> delRelicList_ = new RepeatedField<uint>();

	public const int BasicModuleSyncFieldNumber = 11;

	private BasicModuleSync basicModuleSync_;

	public const int MaterialListFieldNumber = 12;

	private static readonly FieldCodec<Material> _repeated_materialList_codec = FieldCodec.ForMessage(98u, Material.Parser);

	private readonly RepeatedField<Material> materialList_ = new RepeatedField<Material>();

	public const int QuestListFieldNumber = 13;

	private static readonly FieldCodec<Quest> _repeated_questList_codec = FieldCodec.ForMessage(106u, Quest.Parser);

	private readonly RepeatedField<Quest> questList_ = new RepeatedField<Quest>();

	public const int BasicInfoFieldNumber = 14;

	private PlayerBasicInfo basicInfo_;

	public const int IIBDADNFLFPFieldNumber = 34;

	private static readonly FieldCodec<DPBEGBNICPG> _repeated_iIBDADNFLFP_codec = FieldCodec.ForMessage(274u, DPBEGBNICPG.Parser);

	private readonly RepeatedField<DPBEGBNICPG> iIBDADNFLFP_ = new RepeatedField<DPBEGBNICPG>();

	public const int EDAHGEAMDCFFieldNumber = 69;

	private ItemList eDAHGEAMDCF_;

	public const int FFEENBPPGNGFieldNumber = 220;

	private IEBAILGKMLB fFEENBPPGNG_;

	public const int GHGKCFIFMBBFieldNumber = 231;

	private static readonly FieldCodec<Material> _repeated_gHGKCFIFMBB_codec = FieldCodec.ForMessage(1850u, Material.Parser);

	private readonly RepeatedField<Material> gHGKCFIFMBB_ = new RepeatedField<Material>();

	public const int SyncStatusFieldNumber = 322;

	private SyncStatus syncStatus_;

	public const int TotalAchievementExpFieldNumber = 1013;

	private uint totalAchievementExp_;

	public const int PlayerOutfitDataFieldNumber = 1170;

	private PlayerOutfitInfo playerOutfitData_;

	public const int PEFMKLKKCFJFieldNumber = 1287;

	private static readonly FieldCodec<PFFDAFJLNOO> _repeated_pEFMKLKKCFJ_codec = FieldCodec.ForMessage(10298u, PFFDAFJLNOO.Parser);

	private readonly RepeatedField<PFFDAFJLNOO> pEFMKLKKCFJ_ = new RepeatedField<PFFDAFJLNOO>();

	public const int PlayerboardModuleSyncFieldNumber = 1335;

	private PlayerBoardModuleSync playerboardModuleSync_;

	public const int DelEquipmentListFieldNumber = 1474;

	private static readonly FieldCodec<uint> _repeated_delEquipmentList_codec = FieldCodec.ForUInt32(11794u);

	private readonly RepeatedField<uint> delEquipmentList_ = new RepeatedField<uint>();

	public const int NAJNBCDBIHOFieldNumber = 1836;

	private static readonly FieldCodec<LAEHDNHPGCC> _repeated_nAJNBCDBIHO_codec = FieldCodec.ForMessage(14690u, LAEHDNHPGCC.Parser);

	private readonly RepeatedField<LAEHDNHPGCC> nAJNBCDBIHO_ = new RepeatedField<LAEHDNHPGCC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerSyncScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerSyncScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarSync AvatarSync
	{
		get
		{
			return avatarSync_;
		}
		set
		{
			avatarSync_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSync MissionSync
	{
		get
		{
			return missionSync_;
		}
		set
		{
			missionSync_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Relic> RelicList => relicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Equipment> EquipmentList => equipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CJEFCMACJLG => cJEFCMACJLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<WaitDelResource> WaitDelResourceList => waitDelResourceList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DelRelicList => delRelicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicModuleSync BasicModuleSync
	{
		get
		{
			return basicModuleSync_;
		}
		set
		{
			basicModuleSync_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Material> MaterialList => materialList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Quest> QuestList => questList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBasicInfo BasicInfo
	{
		get
		{
			return basicInfo_;
		}
		set
		{
			basicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPBEGBNICPG> IIBDADNFLFP => iIBDADNFLFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList EDAHGEAMDCF
	{
		get
		{
			return eDAHGEAMDCF_;
		}
		set
		{
			eDAHGEAMDCF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEBAILGKMLB FFEENBPPGNG
	{
		get
		{
			return fFEENBPPGNG_;
		}
		set
		{
			fFEENBPPGNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Material> GHGKCFIFMBB => gHGKCFIFMBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncStatus SyncStatus
	{
		get
		{
			return syncStatus_;
		}
		set
		{
			syncStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalAchievementExp
	{
		get
		{
			return totalAchievementExp_;
		}
		set
		{
			totalAchievementExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerOutfitInfo PlayerOutfitData
	{
		get
		{
			return playerOutfitData_;
		}
		set
		{
			playerOutfitData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PFFDAFJLNOO> PEFMKLKKCFJ => pEFMKLKKCFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBoardModuleSync PlayerboardModuleSync
	{
		get
		{
			return playerboardModuleSync_;
		}
		set
		{
			playerboardModuleSync_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DelEquipmentList => delEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LAEHDNHPGCC> NAJNBCDBIHO => nAJNBCDBIHO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSyncScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSyncScNotify(PlayerSyncScNotify other)
		: this()
	{
		avatarSync_ = ((other.avatarSync_ != null) ? other.avatarSync_.Clone() : null);
		missionSync_ = ((other.missionSync_ != null) ? other.missionSync_.Clone() : null);
		relicList_ = other.relicList_.Clone();
		equipmentList_ = other.equipmentList_.Clone();
		cJEFCMACJLG_ = other.cJEFCMACJLG_.Clone();
		waitDelResourceList_ = other.waitDelResourceList_.Clone();
		delRelicList_ = other.delRelicList_.Clone();
		basicModuleSync_ = ((other.basicModuleSync_ != null) ? other.basicModuleSync_.Clone() : null);
		materialList_ = other.materialList_.Clone();
		questList_ = other.questList_.Clone();
		basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
		iIBDADNFLFP_ = other.iIBDADNFLFP_.Clone();
		eDAHGEAMDCF_ = ((other.eDAHGEAMDCF_ != null) ? other.eDAHGEAMDCF_.Clone() : null);
		fFEENBPPGNG_ = ((other.fFEENBPPGNG_ != null) ? other.fFEENBPPGNG_.Clone() : null);
		gHGKCFIFMBB_ = other.gHGKCFIFMBB_.Clone();
		syncStatus_ = ((other.syncStatus_ != null) ? other.syncStatus_.Clone() : null);
		totalAchievementExp_ = other.totalAchievementExp_;
		playerOutfitData_ = ((other.playerOutfitData_ != null) ? other.playerOutfitData_.Clone() : null);
		pEFMKLKKCFJ_ = other.pEFMKLKKCFJ_.Clone();
		playerboardModuleSync_ = ((other.playerboardModuleSync_ != null) ? other.playerboardModuleSync_.Clone() : null);
		delEquipmentList_ = other.delEquipmentList_.Clone();
		nAJNBCDBIHO_ = other.nAJNBCDBIHO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSyncScNotify Clone()
	{
		return new PlayerSyncScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerSyncScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerSyncScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AvatarSync, other.AvatarSync))
		{
			return false;
		}
		if (!object.Equals(MissionSync, other.MissionSync))
		{
			return false;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (!equipmentList_.Equals(other.equipmentList_))
		{
			return false;
		}
		if (!cJEFCMACJLG_.Equals(other.cJEFCMACJLG_))
		{
			return false;
		}
		if (!waitDelResourceList_.Equals(other.waitDelResourceList_))
		{
			return false;
		}
		if (!delRelicList_.Equals(other.delRelicList_))
		{
			return false;
		}
		if (!object.Equals(BasicModuleSync, other.BasicModuleSync))
		{
			return false;
		}
		if (!materialList_.Equals(other.materialList_))
		{
			return false;
		}
		if (!questList_.Equals(other.questList_))
		{
			return false;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (!iIBDADNFLFP_.Equals(other.iIBDADNFLFP_))
		{
			return false;
		}
		if (!object.Equals(EDAHGEAMDCF, other.EDAHGEAMDCF))
		{
			return false;
		}
		if (!object.Equals(FFEENBPPGNG, other.FFEENBPPGNG))
		{
			return false;
		}
		if (!gHGKCFIFMBB_.Equals(other.gHGKCFIFMBB_))
		{
			return false;
		}
		if (!object.Equals(SyncStatus, other.SyncStatus))
		{
			return false;
		}
		if (TotalAchievementExp != other.TotalAchievementExp)
		{
			return false;
		}
		if (!object.Equals(PlayerOutfitData, other.PlayerOutfitData))
		{
			return false;
		}
		if (!pEFMKLKKCFJ_.Equals(other.pEFMKLKKCFJ_))
		{
			return false;
		}
		if (!object.Equals(PlayerboardModuleSync, other.PlayerboardModuleSync))
		{
			return false;
		}
		if (!delEquipmentList_.Equals(other.delEquipmentList_))
		{
			return false;
		}
		if (!nAJNBCDBIHO_.Equals(other.nAJNBCDBIHO_))
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
		if (avatarSync_ != null)
		{
			num ^= AvatarSync.GetHashCode();
		}
		if (missionSync_ != null)
		{
			num ^= MissionSync.GetHashCode();
		}
		num ^= relicList_.GetHashCode();
		num ^= equipmentList_.GetHashCode();
		num ^= cJEFCMACJLG_.GetHashCode();
		num ^= waitDelResourceList_.GetHashCode();
		num ^= delRelicList_.GetHashCode();
		if (basicModuleSync_ != null)
		{
			num ^= BasicModuleSync.GetHashCode();
		}
		num ^= materialList_.GetHashCode();
		num ^= questList_.GetHashCode();
		if (basicInfo_ != null)
		{
			num ^= BasicInfo.GetHashCode();
		}
		num ^= iIBDADNFLFP_.GetHashCode();
		if (eDAHGEAMDCF_ != null)
		{
			num ^= EDAHGEAMDCF.GetHashCode();
		}
		if (fFEENBPPGNG_ != null)
		{
			num ^= FFEENBPPGNG.GetHashCode();
		}
		num ^= gHGKCFIFMBB_.GetHashCode();
		if (syncStatus_ != null)
		{
			num ^= SyncStatus.GetHashCode();
		}
		if (TotalAchievementExp != 0)
		{
			num ^= TotalAchievementExp.GetHashCode();
		}
		if (playerOutfitData_ != null)
		{
			num ^= PlayerOutfitData.GetHashCode();
		}
		num ^= pEFMKLKKCFJ_.GetHashCode();
		if (playerboardModuleSync_ != null)
		{
			num ^= PlayerboardModuleSync.GetHashCode();
		}
		num ^= delEquipmentList_.GetHashCode();
		num ^= nAJNBCDBIHO_.GetHashCode();
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
		if (avatarSync_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(AvatarSync);
		}
		if (missionSync_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MissionSync);
		}
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		equipmentList_.WriteTo(ref output, _repeated_equipmentList_codec);
		cJEFCMACJLG_.WriteTo(ref output, _repeated_cJEFCMACJLG_codec);
		waitDelResourceList_.WriteTo(ref output, _repeated_waitDelResourceList_codec);
		delRelicList_.WriteTo(ref output, _repeated_delRelicList_codec);
		if (basicModuleSync_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BasicModuleSync);
		}
		materialList_.WriteTo(ref output, _repeated_materialList_codec);
		questList_.WriteTo(ref output, _repeated_questList_codec);
		if (basicInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BasicInfo);
		}
		iIBDADNFLFP_.WriteTo(ref output, _repeated_iIBDADNFLFP_codec);
		if (eDAHGEAMDCF_ != null)
		{
			output.WriteRawTag(170, 4);
			output.WriteMessage(EDAHGEAMDCF);
		}
		if (fFEENBPPGNG_ != null)
		{
			output.WriteRawTag(226, 13);
			output.WriteMessage(FFEENBPPGNG);
		}
		gHGKCFIFMBB_.WriteTo(ref output, _repeated_gHGKCFIFMBB_codec);
		if (syncStatus_ != null)
		{
			output.WriteRawTag(146, 20);
			output.WriteMessage(SyncStatus);
		}
		if (TotalAchievementExp != 0)
		{
			output.WriteRawTag(168, 63);
			output.WriteUInt32(TotalAchievementExp);
		}
		if (playerOutfitData_ != null)
		{
			output.WriteRawTag(146, 73);
			output.WriteMessage(PlayerOutfitData);
		}
		pEFMKLKKCFJ_.WriteTo(ref output, _repeated_pEFMKLKKCFJ_codec);
		if (playerboardModuleSync_ != null)
		{
			output.WriteRawTag(186, 83);
			output.WriteMessage(PlayerboardModuleSync);
		}
		delEquipmentList_.WriteTo(ref output, _repeated_delEquipmentList_codec);
		nAJNBCDBIHO_.WriteTo(ref output, _repeated_nAJNBCDBIHO_codec);
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
		if (avatarSync_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AvatarSync);
		}
		if (missionSync_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MissionSync);
		}
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		num += equipmentList_.CalculateSize(_repeated_equipmentList_codec);
		num += cJEFCMACJLG_.CalculateSize(_repeated_cJEFCMACJLG_codec);
		num += waitDelResourceList_.CalculateSize(_repeated_waitDelResourceList_codec);
		num += delRelicList_.CalculateSize(_repeated_delRelicList_codec);
		if (basicModuleSync_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicModuleSync);
		}
		num += materialList_.CalculateSize(_repeated_materialList_codec);
		num += questList_.CalculateSize(_repeated_questList_codec);
		if (basicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		num += iIBDADNFLFP_.CalculateSize(_repeated_iIBDADNFLFP_codec);
		if (eDAHGEAMDCF_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EDAHGEAMDCF);
		}
		if (fFEENBPPGNG_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FFEENBPPGNG);
		}
		num += gHGKCFIFMBB_.CalculateSize(_repeated_gHGKCFIFMBB_codec);
		if (syncStatus_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SyncStatus);
		}
		if (TotalAchievementExp != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(TotalAchievementExp);
		}
		if (playerOutfitData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerOutfitData);
		}
		num += pEFMKLKKCFJ_.CalculateSize(_repeated_pEFMKLKKCFJ_codec);
		if (playerboardModuleSync_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerboardModuleSync);
		}
		num += delEquipmentList_.CalculateSize(_repeated_delEquipmentList_codec);
		num += nAJNBCDBIHO_.CalculateSize(_repeated_nAJNBCDBIHO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerSyncScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.avatarSync_ != null)
		{
			if (avatarSync_ == null)
			{
				AvatarSync = new AvatarSync();
			}
			AvatarSync.MergeFrom(other.AvatarSync);
		}
		if (other.missionSync_ != null)
		{
			if (missionSync_ == null)
			{
				MissionSync = new MissionSync();
			}
			MissionSync.MergeFrom(other.MissionSync);
		}
		relicList_.Add(other.relicList_);
		equipmentList_.Add(other.equipmentList_);
		cJEFCMACJLG_.Add(other.cJEFCMACJLG_);
		waitDelResourceList_.Add(other.waitDelResourceList_);
		delRelicList_.Add(other.delRelicList_);
		if (other.basicModuleSync_ != null)
		{
			if (basicModuleSync_ == null)
			{
				BasicModuleSync = new BasicModuleSync();
			}
			BasicModuleSync.MergeFrom(other.BasicModuleSync);
		}
		materialList_.Add(other.materialList_);
		questList_.Add(other.questList_);
		if (other.basicInfo_ != null)
		{
			if (basicInfo_ == null)
			{
				BasicInfo = new PlayerBasicInfo();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
		}
		iIBDADNFLFP_.Add(other.iIBDADNFLFP_);
		if (other.eDAHGEAMDCF_ != null)
		{
			if (eDAHGEAMDCF_ == null)
			{
				EDAHGEAMDCF = new ItemList();
			}
			EDAHGEAMDCF.MergeFrom(other.EDAHGEAMDCF);
		}
		if (other.fFEENBPPGNG_ != null)
		{
			if (fFEENBPPGNG_ == null)
			{
				FFEENBPPGNG = new IEBAILGKMLB();
			}
			FFEENBPPGNG.MergeFrom(other.FFEENBPPGNG);
		}
		gHGKCFIFMBB_.Add(other.gHGKCFIFMBB_);
		if (other.syncStatus_ != null)
		{
			if (syncStatus_ == null)
			{
				SyncStatus = new SyncStatus();
			}
			SyncStatus.MergeFrom(other.SyncStatus);
		}
		if (other.TotalAchievementExp != 0)
		{
			TotalAchievementExp = other.TotalAchievementExp;
		}
		if (other.playerOutfitData_ != null)
		{
			if (playerOutfitData_ == null)
			{
				PlayerOutfitData = new PlayerOutfitInfo();
			}
			PlayerOutfitData.MergeFrom(other.PlayerOutfitData);
		}
		pEFMKLKKCFJ_.Add(other.pEFMKLKKCFJ_);
		if (other.playerboardModuleSync_ != null)
		{
			if (playerboardModuleSync_ == null)
			{
				PlayerboardModuleSync = new PlayerBoardModuleSync();
			}
			PlayerboardModuleSync.MergeFrom(other.PlayerboardModuleSync);
		}
		delEquipmentList_.Add(other.delEquipmentList_);
		nAJNBCDBIHO_.Add(other.nAJNBCDBIHO_);
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
				if (avatarSync_ == null)
				{
					AvatarSync = new AvatarSync();
				}
				input.ReadMessage(AvatarSync);
				break;
			case 34u:
				if (missionSync_ == null)
				{
					MissionSync = new MissionSync();
				}
				input.ReadMessage(MissionSync);
				break;
			case 42u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 50u:
				equipmentList_.AddEntriesFrom(ref input, _repeated_equipmentList_codec);
				break;
			case 56u:
			case 58u:
				cJEFCMACJLG_.AddEntriesFrom(ref input, _repeated_cJEFCMACJLG_codec);
				break;
			case 74u:
				waitDelResourceList_.AddEntriesFrom(ref input, _repeated_waitDelResourceList_codec);
				break;
			case 80u:
			case 82u:
				delRelicList_.AddEntriesFrom(ref input, _repeated_delRelicList_codec);
				break;
			case 90u:
				if (basicModuleSync_ == null)
				{
					BasicModuleSync = new BasicModuleSync();
				}
				input.ReadMessage(BasicModuleSync);
				break;
			case 98u:
				materialList_.AddEntriesFrom(ref input, _repeated_materialList_codec);
				break;
			case 106u:
				questList_.AddEntriesFrom(ref input, _repeated_questList_codec);
				break;
			case 114u:
				if (basicInfo_ == null)
				{
					BasicInfo = new PlayerBasicInfo();
				}
				input.ReadMessage(BasicInfo);
				break;
			case 274u:
				iIBDADNFLFP_.AddEntriesFrom(ref input, _repeated_iIBDADNFLFP_codec);
				break;
			case 554u:
				if (eDAHGEAMDCF_ == null)
				{
					EDAHGEAMDCF = new ItemList();
				}
				input.ReadMessage(EDAHGEAMDCF);
				break;
			case 1762u:
				if (fFEENBPPGNG_ == null)
				{
					FFEENBPPGNG = new IEBAILGKMLB();
				}
				input.ReadMessage(FFEENBPPGNG);
				break;
			case 1850u:
				gHGKCFIFMBB_.AddEntriesFrom(ref input, _repeated_gHGKCFIFMBB_codec);
				break;
			case 2578u:
				if (syncStatus_ == null)
				{
					SyncStatus = new SyncStatus();
				}
				input.ReadMessage(SyncStatus);
				break;
			case 8104u:
				TotalAchievementExp = input.ReadUInt32();
				break;
			case 9362u:
				if (playerOutfitData_ == null)
				{
					PlayerOutfitData = new PlayerOutfitInfo();
				}
				input.ReadMessage(PlayerOutfitData);
				break;
			case 10298u:
				pEFMKLKKCFJ_.AddEntriesFrom(ref input, _repeated_pEFMKLKKCFJ_codec);
				break;
			case 10682u:
				if (playerboardModuleSync_ == null)
				{
					PlayerboardModuleSync = new PlayerBoardModuleSync();
				}
				input.ReadMessage(PlayerboardModuleSync);
				break;
			case 11792u:
			case 11794u:
				delEquipmentList_.AddEntriesFrom(ref input, _repeated_delEquipmentList_codec);
				break;
			case 14690u:
				nAJNBCDBIHO_.AddEntriesFrom(ref input, _repeated_nAJNBCDBIHO_codec);
				break;
			}
		}
	}
}
