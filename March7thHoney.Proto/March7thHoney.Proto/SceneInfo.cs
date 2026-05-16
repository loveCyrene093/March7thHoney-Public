using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneInfo : IMessage<SceneInfo>, IMessage, IEquatable<SceneInfo>, IDeepCloneable<SceneInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneInfo> _parser = new MessageParser<SceneInfo>(() => new SceneInfo());

	private UnknownFieldSet _unknownFields;

	public const int GameModeTypeFieldNumber = 1;

	private uint gameModeType_;

	public const int NHOFMHMBKGKFieldNumber = 3;

	private static readonly FieldCodec<NBCOOLLEOID> _repeated_nHOFMHMBKGK_codec = FieldCodec.ForMessage(26u, NBCOOLLEOID.Parser);

	private readonly RepeatedField<NBCOOLLEOID> nHOFMHMBKGK_ = new RepeatedField<NBCOOLLEOID>();

	public const int ClientPosVersionFieldNumber = 4;

	private uint clientPosVersion_;

	public const int PlaneIdFieldNumber = 5;

	private uint planeId_;

	public const int KHHOPNJJABHFieldNumber = 6;

	private static readonly MapField<uint, IAHHLIOLCDB>.Codec _map_kHHOPNJJABH_codec = new MapField<uint, IAHHLIOLCDB>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, IAHHLIOLCDB.Parser), 50u);

	private readonly MapField<uint, IAHHLIOLCDB> kHHOPNJJABH_ = new MapField<uint, IAHHLIOLCDB>();

	public const int CustomDataListFieldNumber = 7;

	private static readonly FieldCodec<CustomSaveData> _repeated_customDataList_codec = FieldCodec.ForMessage(58u, CustomSaveData.Parser);

	private readonly RepeatedField<CustomSaveData> customDataList_ = new RepeatedField<CustomSaveData>();

	public const int EntityListFieldNumber = 9;

	private static readonly FieldCodec<SceneEntityInfo> _repeated_entityList_codec = FieldCodec.ForMessage(74u, SceneEntityInfo.Parser);

	private readonly RepeatedField<SceneEntityInfo> entityList_ = new RepeatedField<SceneEntityInfo>();

	public const int FloorIdFieldNumber = 10;

	private uint floorId_;

	public const int SceneBuffInfoListFieldNumber = 11;

	private static readonly FieldCodec<BuffInfo> _repeated_sceneBuffInfoList_codec = FieldCodec.ForMessage(90u, BuffInfo.Parser);

	private readonly RepeatedField<BuffInfo> sceneBuffInfoList_ = new RepeatedField<BuffInfo>();

	public const int EntryIdFieldNumber = 12;

	private uint entryId_;

	public const int LeaderEntityIdFieldNumber = 13;

	private uint leaderEntityId_;

	public const int LightenSectionListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_lightenSectionList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> lightenSectionList_ = new RepeatedField<uint>();

	public const int WorldIdFieldNumber = 15;

	private uint worldId_;

	public const int DimensionIdFieldNumber = 531;

	private uint dimensionId_;

	public const int GameStoryLineIdFieldNumber = 602;

	private uint gameStoryLineId_;

	public const int FloorSavedDataFieldNumber = 680;

	private static readonly MapField<string, int>.Codec _map_floorSavedData_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 5442u);

	private readonly MapField<string, int> floorSavedData_ = new MapField<string, int>();

	public const int OpenedChestsListFieldNumber = 719;

	private static readonly FieldCodec<uint> _repeated_openedChestsList_codec = FieldCodec.ForUInt32(5754u);

	private readonly RepeatedField<uint> openedChestsList_ = new RepeatedField<uint>();

	public const int ContentIdFieldNumber = 986;

	private uint contentId_;

	public const int EntityGroupListFieldNumber = 1153;

	private static readonly FieldCodec<SceneEntityGroupInfo> _repeated_entityGroupList_codec = FieldCodec.ForMessage(9226u, SceneEntityGroupInfo.Parser);

	private readonly RepeatedField<SceneEntityGroupInfo> entityGroupList_ = new RepeatedField<SceneEntityGroupInfo>();

	public const int OCKNKCCIJAIFieldNumber = 1337;

	private DPNDJIGACFJ oCKNKCCIJAI_;

	public const int SceneMissionInfoFieldNumber = 1537;

	private MissionStatusBySceneInfo sceneMissionInfo_;

	public const int GroupStateListFieldNumber = 1553;

	private static readonly FieldCodec<SceneGroupState> _repeated_groupStateList_codec = FieldCodec.ForMessage(12426u, SceneGroupState.Parser);

	private readonly RepeatedField<SceneGroupState> groupStateList_ = new RepeatedField<SceneGroupState>();

	public const int InteractIdFieldNumber = 1744;

	private ulong interactId_;

	public const int SceneIdentifierFieldNumber = 1947;

	private SceneIdentifier sceneIdentifier_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GameModeType
	{
		get
		{
			return gameModeType_;
		}
		set
		{
			gameModeType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBCOOLLEOID> NHOFMHMBKGK => nHOFMHMBKGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClientPosVersion
	{
		get
		{
			return clientPosVersion_;
		}
		set
		{
			clientPosVersion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, IAHHLIOLCDB> KHHOPNJJABH => kHHOPNJJABH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CustomSaveData> CustomDataList => customDataList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneEntityInfo> EntityList => entityList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BuffInfo> SceneBuffInfoList => sceneBuffInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LeaderEntityId
	{
		get
		{
			return leaderEntityId_;
		}
		set
		{
			leaderEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LightenSectionList => lightenSectionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldId
	{
		get
		{
			return worldId_;
		}
		set
		{
			worldId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DimensionId
	{
		get
		{
			return dimensionId_;
		}
		set
		{
			dimensionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GameStoryLineId
	{
		get
		{
			return gameStoryLineId_;
		}
		set
		{
			gameStoryLineId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> FloorSavedData => floorSavedData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OpenedChestsList => openedChestsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneEntityGroupInfo> EntityGroupList => entityGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPNDJIGACFJ OCKNKCCIJAI
	{
		get
		{
			return oCKNKCCIJAI_;
		}
		set
		{
			oCKNKCCIJAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionStatusBySceneInfo SceneMissionInfo
	{
		get
		{
			return sceneMissionInfo_;
		}
		set
		{
			sceneMissionInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneGroupState> GroupStateList => groupStateList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneIdentifier SceneIdentifier
	{
		get
		{
			return sceneIdentifier_;
		}
		set
		{
			sceneIdentifier_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneInfo(SceneInfo other)
		: this()
	{
		gameModeType_ = other.gameModeType_;
		nHOFMHMBKGK_ = other.nHOFMHMBKGK_.Clone();
		clientPosVersion_ = other.clientPosVersion_;
		planeId_ = other.planeId_;
		kHHOPNJJABH_ = other.kHHOPNJJABH_.Clone();
		customDataList_ = other.customDataList_.Clone();
		entityList_ = other.entityList_.Clone();
		floorId_ = other.floorId_;
		sceneBuffInfoList_ = other.sceneBuffInfoList_.Clone();
		entryId_ = other.entryId_;
		leaderEntityId_ = other.leaderEntityId_;
		lightenSectionList_ = other.lightenSectionList_.Clone();
		worldId_ = other.worldId_;
		dimensionId_ = other.dimensionId_;
		gameStoryLineId_ = other.gameStoryLineId_;
		floorSavedData_ = other.floorSavedData_.Clone();
		openedChestsList_ = other.openedChestsList_.Clone();
		contentId_ = other.contentId_;
		entityGroupList_ = other.entityGroupList_.Clone();
		oCKNKCCIJAI_ = ((other.oCKNKCCIJAI_ != null) ? other.oCKNKCCIJAI_.Clone() : null);
		sceneMissionInfo_ = ((other.sceneMissionInfo_ != null) ? other.sceneMissionInfo_.Clone() : null);
		groupStateList_ = other.groupStateList_.Clone();
		interactId_ = other.interactId_;
		sceneIdentifier_ = ((other.sceneIdentifier_ != null) ? other.sceneIdentifier_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneInfo Clone()
	{
		return new SceneInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GameModeType != other.GameModeType)
		{
			return false;
		}
		if (!nHOFMHMBKGK_.Equals(other.nHOFMHMBKGK_))
		{
			return false;
		}
		if (ClientPosVersion != other.ClientPosVersion)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (!KHHOPNJJABH.Equals(other.KHHOPNJJABH))
		{
			return false;
		}
		if (!customDataList_.Equals(other.customDataList_))
		{
			return false;
		}
		if (!entityList_.Equals(other.entityList_))
		{
			return false;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (!sceneBuffInfoList_.Equals(other.sceneBuffInfoList_))
		{
			return false;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (LeaderEntityId != other.LeaderEntityId)
		{
			return false;
		}
		if (!lightenSectionList_.Equals(other.lightenSectionList_))
		{
			return false;
		}
		if (WorldId != other.WorldId)
		{
			return false;
		}
		if (DimensionId != other.DimensionId)
		{
			return false;
		}
		if (GameStoryLineId != other.GameStoryLineId)
		{
			return false;
		}
		if (!FloorSavedData.Equals(other.FloorSavedData))
		{
			return false;
		}
		if (!openedChestsList_.Equals(other.openedChestsList_))
		{
			return false;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (!entityGroupList_.Equals(other.entityGroupList_))
		{
			return false;
		}
		if (!object.Equals(OCKNKCCIJAI, other.OCKNKCCIJAI))
		{
			return false;
		}
		if (!object.Equals(SceneMissionInfo, other.SceneMissionInfo))
		{
			return false;
		}
		if (!groupStateList_.Equals(other.groupStateList_))
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (!object.Equals(SceneIdentifier, other.SceneIdentifier))
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
		if (GameModeType != 0)
		{
			num ^= GameModeType.GetHashCode();
		}
		num ^= nHOFMHMBKGK_.GetHashCode();
		if (ClientPosVersion != 0)
		{
			num ^= ClientPosVersion.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		num ^= KHHOPNJJABH.GetHashCode();
		num ^= customDataList_.GetHashCode();
		num ^= entityList_.GetHashCode();
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		num ^= sceneBuffInfoList_.GetHashCode();
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (LeaderEntityId != 0)
		{
			num ^= LeaderEntityId.GetHashCode();
		}
		num ^= lightenSectionList_.GetHashCode();
		if (WorldId != 0)
		{
			num ^= WorldId.GetHashCode();
		}
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
		}
		if (GameStoryLineId != 0)
		{
			num ^= GameStoryLineId.GetHashCode();
		}
		num ^= FloorSavedData.GetHashCode();
		num ^= openedChestsList_.GetHashCode();
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		num ^= entityGroupList_.GetHashCode();
		if (oCKNKCCIJAI_ != null)
		{
			num ^= OCKNKCCIJAI.GetHashCode();
		}
		if (sceneMissionInfo_ != null)
		{
			num ^= SceneMissionInfo.GetHashCode();
		}
		num ^= groupStateList_.GetHashCode();
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		if (sceneIdentifier_ != null)
		{
			num ^= SceneIdentifier.GetHashCode();
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
		if (GameModeType != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GameModeType);
		}
		nHOFMHMBKGK_.WriteTo(ref output, _repeated_nHOFMHMBKGK_codec);
		if (ClientPosVersion != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ClientPosVersion);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PlaneId);
		}
		kHHOPNJJABH_.WriteTo(ref output, _map_kHHOPNJJABH_codec);
		customDataList_.WriteTo(ref output, _repeated_customDataList_codec);
		entityList_.WriteTo(ref output, _repeated_entityList_codec);
		if (FloorId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FloorId);
		}
		sceneBuffInfoList_.WriteTo(ref output, _repeated_sceneBuffInfoList_codec);
		if (EntryId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EntryId);
		}
		if (LeaderEntityId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LeaderEntityId);
		}
		lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
		if (WorldId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(WorldId);
		}
		if (DimensionId != 0)
		{
			output.WriteRawTag(152, 33);
			output.WriteUInt32(DimensionId);
		}
		if (GameStoryLineId != 0)
		{
			output.WriteRawTag(208, 37);
			output.WriteUInt32(GameStoryLineId);
		}
		floorSavedData_.WriteTo(ref output, _map_floorSavedData_codec);
		openedChestsList_.WriteTo(ref output, _repeated_openedChestsList_codec);
		if (ContentId != 0)
		{
			output.WriteRawTag(208, 61);
			output.WriteUInt32(ContentId);
		}
		entityGroupList_.WriteTo(ref output, _repeated_entityGroupList_codec);
		if (oCKNKCCIJAI_ != null)
		{
			output.WriteRawTag(202, 83);
			output.WriteMessage(OCKNKCCIJAI);
		}
		if (sceneMissionInfo_ != null)
		{
			output.WriteRawTag(138, 96);
			output.WriteMessage(SceneMissionInfo);
		}
		groupStateList_.WriteTo(ref output, _repeated_groupStateList_codec);
		if (InteractId != 0L)
		{
			output.WriteRawTag(128, 109);
			output.WriteUInt64(InteractId);
		}
		if (sceneIdentifier_ != null)
		{
			output.WriteRawTag(218, 121);
			output.WriteMessage(SceneIdentifier);
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
		if (GameModeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameModeType);
		}
		num += nHOFMHMBKGK_.CalculateSize(_repeated_nHOFMHMBKGK_codec);
		if (ClientPosVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		num += kHHOPNJJABH_.CalculateSize(_map_kHHOPNJJABH_codec);
		num += customDataList_.CalculateSize(_repeated_customDataList_codec);
		num += entityList_.CalculateSize(_repeated_entityList_codec);
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		num += sceneBuffInfoList_.CalculateSize(_repeated_sceneBuffInfoList_codec);
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (LeaderEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LeaderEntityId);
		}
		num += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
		if (WorldId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldId);
		}
		if (DimensionId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DimensionId);
		}
		if (GameStoryLineId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
		}
		num += floorSavedData_.CalculateSize(_map_floorSavedData_codec);
		num += openedChestsList_.CalculateSize(_repeated_openedChestsList_codec);
		if (ContentId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		num += entityGroupList_.CalculateSize(_repeated_entityGroupList_codec);
		if (oCKNKCCIJAI_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OCKNKCCIJAI);
		}
		if (sceneMissionInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SceneMissionInfo);
		}
		num += groupStateList_.CalculateSize(_repeated_groupStateList_codec);
		if (InteractId != 0L)
		{
			num += 2 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (sceneIdentifier_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SceneIdentifier);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GameModeType != 0)
		{
			GameModeType = other.GameModeType;
		}
		nHOFMHMBKGK_.Add(other.nHOFMHMBKGK_);
		if (other.ClientPosVersion != 0)
		{
			ClientPosVersion = other.ClientPosVersion;
		}
		if (other.PlaneId != 0)
		{
			PlaneId = other.PlaneId;
		}
		kHHOPNJJABH_.MergeFrom(other.kHHOPNJJABH_);
		customDataList_.Add(other.customDataList_);
		entityList_.Add(other.entityList_);
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
		}
		sceneBuffInfoList_.Add(other.sceneBuffInfoList_);
		if (other.EntryId != 0)
		{
			EntryId = other.EntryId;
		}
		if (other.LeaderEntityId != 0)
		{
			LeaderEntityId = other.LeaderEntityId;
		}
		lightenSectionList_.Add(other.lightenSectionList_);
		if (other.WorldId != 0)
		{
			WorldId = other.WorldId;
		}
		if (other.DimensionId != 0)
		{
			DimensionId = other.DimensionId;
		}
		if (other.GameStoryLineId != 0)
		{
			GameStoryLineId = other.GameStoryLineId;
		}
		floorSavedData_.MergeFrom(other.floorSavedData_);
		openedChestsList_.Add(other.openedChestsList_);
		if (other.ContentId != 0)
		{
			ContentId = other.ContentId;
		}
		entityGroupList_.Add(other.entityGroupList_);
		if (other.oCKNKCCIJAI_ != null)
		{
			if (oCKNKCCIJAI_ == null)
			{
				OCKNKCCIJAI = new DPNDJIGACFJ();
			}
			OCKNKCCIJAI.MergeFrom(other.OCKNKCCIJAI);
		}
		if (other.sceneMissionInfo_ != null)
		{
			if (sceneMissionInfo_ == null)
			{
				SceneMissionInfo = new MissionStatusBySceneInfo();
			}
			SceneMissionInfo.MergeFrom(other.SceneMissionInfo);
		}
		groupStateList_.Add(other.groupStateList_);
		if (other.InteractId != 0L)
		{
			InteractId = other.InteractId;
		}
		if (other.sceneIdentifier_ != null)
		{
			if (sceneIdentifier_ == null)
			{
				SceneIdentifier = new SceneIdentifier();
			}
			SceneIdentifier.MergeFrom(other.SceneIdentifier);
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
				GameModeType = input.ReadUInt32();
				break;
			case 26u:
				nHOFMHMBKGK_.AddEntriesFrom(ref input, _repeated_nHOFMHMBKGK_codec);
				break;
			case 32u:
				ClientPosVersion = input.ReadUInt32();
				break;
			case 40u:
				PlaneId = input.ReadUInt32();
				break;
			case 50u:
				kHHOPNJJABH_.AddEntriesFrom(ref input, _map_kHHOPNJJABH_codec);
				break;
			case 58u:
				customDataList_.AddEntriesFrom(ref input, _repeated_customDataList_codec);
				break;
			case 74u:
				entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
				break;
			case 80u:
				FloorId = input.ReadUInt32();
				break;
			case 90u:
				sceneBuffInfoList_.AddEntriesFrom(ref input, _repeated_sceneBuffInfoList_codec);
				break;
			case 96u:
				EntryId = input.ReadUInt32();
				break;
			case 104u:
				LeaderEntityId = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
				break;
			case 120u:
				WorldId = input.ReadUInt32();
				break;
			case 4248u:
				DimensionId = input.ReadUInt32();
				break;
			case 4816u:
				GameStoryLineId = input.ReadUInt32();
				break;
			case 5442u:
				floorSavedData_.AddEntriesFrom(ref input, _map_floorSavedData_codec);
				break;
			case 5752u:
			case 5754u:
				openedChestsList_.AddEntriesFrom(ref input, _repeated_openedChestsList_codec);
				break;
			case 7888u:
				ContentId = input.ReadUInt32();
				break;
			case 9226u:
				entityGroupList_.AddEntriesFrom(ref input, _repeated_entityGroupList_codec);
				break;
			case 10698u:
				if (oCKNKCCIJAI_ == null)
				{
					OCKNKCCIJAI = new DPNDJIGACFJ();
				}
				input.ReadMessage(OCKNKCCIJAI);
				break;
			case 12298u:
				if (sceneMissionInfo_ == null)
				{
					SceneMissionInfo = new MissionStatusBySceneInfo();
				}
				input.ReadMessage(SceneMissionInfo);
				break;
			case 12426u:
				groupStateList_.AddEntriesFrom(ref input, _repeated_groupStateList_codec);
				break;
			case 13952u:
				InteractId = input.ReadUInt64();
				break;
			case 15578u:
				if (sceneIdentifier_ == null)
				{
					SceneIdentifier = new SceneIdentifier();
				}
				input.ReadMessage(SceneIdentifier);
				break;
			}
		}
	}
}
