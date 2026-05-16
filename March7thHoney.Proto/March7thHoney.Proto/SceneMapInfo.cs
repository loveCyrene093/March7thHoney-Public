using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneMapInfo : IMessage<SceneMapInfo>, IMessage, IEquatable<SceneMapInfo>, IDeepCloneable<SceneMapInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneMapInfo> _parser = new MessageParser<SceneMapInfo>(() => new SceneMapInfo());

	private UnknownFieldSet _unknownFields;

	public const int EntryIdFieldNumber = 1;

	private uint entryId_;

	public const int FloorSavedDataFieldNumber = 2;

	private static readonly MapField<string, int>.Codec _map_floorSavedData_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 18u);

	private readonly MapField<string, int> floorSavedData_ = new MapField<string, int>();

	public const int CurMapEntryIdFieldNumber = 3;

	private uint curMapEntryId_;

	public const int MazeGroupListFieldNumber = 5;

	private static readonly FieldCodec<MazeGroup> _repeated_mazeGroupList_codec = FieldCodec.ForMessage(42u, MazeGroup.Parser);

	private readonly RepeatedField<MazeGroup> mazeGroupList_ = new RepeatedField<MazeGroup>();

	public const int MazePropListFieldNumber = 6;

	private static readonly FieldCodec<MazePropState> _repeated_mazePropList_codec = FieldCodec.ForMessage(50u, MazePropState.Parser);

	private readonly RepeatedField<MazePropState> mazePropList_ = new RepeatedField<MazePropState>();

	public const int FloorIdFieldNumber = 7;

	private uint floorId_;

	public const int DimensionIdFieldNumber = 9;

	private uint dimensionId_;

	public const int LightenSectionListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_lightenSectionList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> lightenSectionList_ = new RepeatedField<uint>();

	public const int ChestListFieldNumber = 12;

	private static readonly FieldCodec<ChestInfo> _repeated_chestList_codec = FieldCodec.ForMessage(98u, ChestInfo.Parser);

	private readonly RepeatedField<ChestInfo> chestList_ = new RepeatedField<ChestInfo>();

	public const int UnlockTeleportListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_unlockTeleportList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> unlockTeleportList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int ChestMonsterListFieldNumber = 15;

	private static readonly FieldCodec<PLDHJGAEEAE> _repeated_chestMonsterList_codec = FieldCodec.ForMessage(122u, PLDHJGAEEAE.Parser);

	private readonly RepeatedField<PLDHJGAEEAE> chestMonsterList_ = new RepeatedField<PLDHJGAEEAE>();

	public const int SceneIdentifierFieldNumber = 383;

	private SceneIdentifier sceneIdentifier_;

	public const int OpenedChestIdListFieldNumber = 828;

	private static readonly FieldCodec<uint> _repeated_openedChestIdList_codec = FieldCodec.ForUInt32(6626u);

	private readonly RepeatedField<uint> openedChestIdList_ = new RepeatedField<uint>();

	public const int ClientGroupMissionInfoFieldNumber = 893;

	private MissionStatusBySceneInfo clientGroupMissionInfo_;

	public const int FinishedChestMonsterIdListFieldNumber = 1717;

	private static readonly FieldCodec<uint> _repeated_finishedChestMonsterIdList_codec = FieldCodec.ForUInt32(13738u);

	private readonly RepeatedField<uint> finishedChestMonsterIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneMapInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneMapInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public MapField<string, int> FloorSavedData => floorSavedData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurMapEntryId
	{
		get
		{
			return curMapEntryId_;
		}
		set
		{
			curMapEntryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MazeGroup> MazeGroupList => mazeGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MazePropState> MazePropList => mazePropList_;

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
	public RepeatedField<uint> LightenSectionList => lightenSectionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChestInfo> ChestList => chestList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockTeleportList => unlockTeleportList_;

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
	public RepeatedField<PLDHJGAEEAE> ChestMonsterList => chestMonsterList_;

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
	public RepeatedField<uint> OpenedChestIdList => openedChestIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionStatusBySceneInfo ClientGroupMissionInfo
	{
		get
		{
			return clientGroupMissionInfo_;
		}
		set
		{
			clientGroupMissionInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedChestMonsterIdList => finishedChestMonsterIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMapInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMapInfo(SceneMapInfo other)
		: this()
	{
		entryId_ = other.entryId_;
		floorSavedData_ = other.floorSavedData_.Clone();
		curMapEntryId_ = other.curMapEntryId_;
		mazeGroupList_ = other.mazeGroupList_.Clone();
		mazePropList_ = other.mazePropList_.Clone();
		floorId_ = other.floorId_;
		dimensionId_ = other.dimensionId_;
		lightenSectionList_ = other.lightenSectionList_.Clone();
		chestList_ = other.chestList_.Clone();
		unlockTeleportList_ = other.unlockTeleportList_.Clone();
		retcode_ = other.retcode_;
		chestMonsterList_ = other.chestMonsterList_.Clone();
		sceneIdentifier_ = ((other.sceneIdentifier_ != null) ? other.sceneIdentifier_.Clone() : null);
		openedChestIdList_ = other.openedChestIdList_.Clone();
		clientGroupMissionInfo_ = ((other.clientGroupMissionInfo_ != null) ? other.clientGroupMissionInfo_.Clone() : null);
		finishedChestMonsterIdList_ = other.finishedChestMonsterIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMapInfo Clone()
	{
		return new SceneMapInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneMapInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneMapInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (!FloorSavedData.Equals(other.FloorSavedData))
		{
			return false;
		}
		if (CurMapEntryId != other.CurMapEntryId)
		{
			return false;
		}
		if (!mazeGroupList_.Equals(other.mazeGroupList_))
		{
			return false;
		}
		if (!mazePropList_.Equals(other.mazePropList_))
		{
			return false;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (DimensionId != other.DimensionId)
		{
			return false;
		}
		if (!lightenSectionList_.Equals(other.lightenSectionList_))
		{
			return false;
		}
		if (!chestList_.Equals(other.chestList_))
		{
			return false;
		}
		if (!unlockTeleportList_.Equals(other.unlockTeleportList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!chestMonsterList_.Equals(other.chestMonsterList_))
		{
			return false;
		}
		if (!object.Equals(SceneIdentifier, other.SceneIdentifier))
		{
			return false;
		}
		if (!openedChestIdList_.Equals(other.openedChestIdList_))
		{
			return false;
		}
		if (!object.Equals(ClientGroupMissionInfo, other.ClientGroupMissionInfo))
		{
			return false;
		}
		if (!finishedChestMonsterIdList_.Equals(other.finishedChestMonsterIdList_))
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
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		num ^= FloorSavedData.GetHashCode();
		if (CurMapEntryId != 0)
		{
			num ^= CurMapEntryId.GetHashCode();
		}
		num ^= mazeGroupList_.GetHashCode();
		num ^= mazePropList_.GetHashCode();
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
		}
		num ^= lightenSectionList_.GetHashCode();
		num ^= chestList_.GetHashCode();
		num ^= unlockTeleportList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= chestMonsterList_.GetHashCode();
		if (sceneIdentifier_ != null)
		{
			num ^= SceneIdentifier.GetHashCode();
		}
		num ^= openedChestIdList_.GetHashCode();
		if (clientGroupMissionInfo_ != null)
		{
			num ^= ClientGroupMissionInfo.GetHashCode();
		}
		num ^= finishedChestMonsterIdList_.GetHashCode();
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
		if (EntryId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EntryId);
		}
		floorSavedData_.WriteTo(ref output, _map_floorSavedData_codec);
		if (CurMapEntryId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CurMapEntryId);
		}
		mazeGroupList_.WriteTo(ref output, _repeated_mazeGroupList_codec);
		mazePropList_.WriteTo(ref output, _repeated_mazePropList_codec);
		if (FloorId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FloorId);
		}
		if (DimensionId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DimensionId);
		}
		lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
		chestList_.WriteTo(ref output, _repeated_chestList_codec);
		unlockTeleportList_.WriteTo(ref output, _repeated_unlockTeleportList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		chestMonsterList_.WriteTo(ref output, _repeated_chestMonsterList_codec);
		if (sceneIdentifier_ != null)
		{
			output.WriteRawTag(250, 23);
			output.WriteMessage(SceneIdentifier);
		}
		openedChestIdList_.WriteTo(ref output, _repeated_openedChestIdList_codec);
		if (clientGroupMissionInfo_ != null)
		{
			output.WriteRawTag(234, 55);
			output.WriteMessage(ClientGroupMissionInfo);
		}
		finishedChestMonsterIdList_.WriteTo(ref output, _repeated_finishedChestMonsterIdList_codec);
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
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		num += floorSavedData_.CalculateSize(_map_floorSavedData_codec);
		if (CurMapEntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurMapEntryId);
		}
		num += mazeGroupList_.CalculateSize(_repeated_mazeGroupList_codec);
		num += mazePropList_.CalculateSize(_repeated_mazePropList_codec);
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (DimensionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DimensionId);
		}
		num += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
		num += chestList_.CalculateSize(_repeated_chestList_codec);
		num += unlockTeleportList_.CalculateSize(_repeated_unlockTeleportList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += chestMonsterList_.CalculateSize(_repeated_chestMonsterList_codec);
		if (sceneIdentifier_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SceneIdentifier);
		}
		num += openedChestIdList_.CalculateSize(_repeated_openedChestIdList_codec);
		if (clientGroupMissionInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ClientGroupMissionInfo);
		}
		num += finishedChestMonsterIdList_.CalculateSize(_repeated_finishedChestMonsterIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneMapInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EntryId != 0)
		{
			EntryId = other.EntryId;
		}
		floorSavedData_.MergeFrom(other.floorSavedData_);
		if (other.CurMapEntryId != 0)
		{
			CurMapEntryId = other.CurMapEntryId;
		}
		mazeGroupList_.Add(other.mazeGroupList_);
		mazePropList_.Add(other.mazePropList_);
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
		}
		if (other.DimensionId != 0)
		{
			DimensionId = other.DimensionId;
		}
		lightenSectionList_.Add(other.lightenSectionList_);
		chestList_.Add(other.chestList_);
		unlockTeleportList_.Add(other.unlockTeleportList_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		chestMonsterList_.Add(other.chestMonsterList_);
		if (other.sceneIdentifier_ != null)
		{
			if (sceneIdentifier_ == null)
			{
				SceneIdentifier = new SceneIdentifier();
			}
			SceneIdentifier.MergeFrom(other.SceneIdentifier);
		}
		openedChestIdList_.Add(other.openedChestIdList_);
		if (other.clientGroupMissionInfo_ != null)
		{
			if (clientGroupMissionInfo_ == null)
			{
				ClientGroupMissionInfo = new MissionStatusBySceneInfo();
			}
			ClientGroupMissionInfo.MergeFrom(other.ClientGroupMissionInfo);
		}
		finishedChestMonsterIdList_.Add(other.finishedChestMonsterIdList_);
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
				EntryId = input.ReadUInt32();
				break;
			case 18u:
				floorSavedData_.AddEntriesFrom(ref input, _map_floorSavedData_codec);
				break;
			case 24u:
				CurMapEntryId = input.ReadUInt32();
				break;
			case 42u:
				mazeGroupList_.AddEntriesFrom(ref input, _repeated_mazeGroupList_codec);
				break;
			case 50u:
				mazePropList_.AddEntriesFrom(ref input, _repeated_mazePropList_codec);
				break;
			case 56u:
				FloorId = input.ReadUInt32();
				break;
			case 72u:
				DimensionId = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
				break;
			case 98u:
				chestList_.AddEntriesFrom(ref input, _repeated_chestList_codec);
				break;
			case 104u:
			case 106u:
				unlockTeleportList_.AddEntriesFrom(ref input, _repeated_unlockTeleportList_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				chestMonsterList_.AddEntriesFrom(ref input, _repeated_chestMonsterList_codec);
				break;
			case 3066u:
				if (sceneIdentifier_ == null)
				{
					SceneIdentifier = new SceneIdentifier();
				}
				input.ReadMessage(SceneIdentifier);
				break;
			case 6624u:
			case 6626u:
				openedChestIdList_.AddEntriesFrom(ref input, _repeated_openedChestIdList_codec);
				break;
			case 7146u:
				if (clientGroupMissionInfo_ == null)
				{
					ClientGroupMissionInfo = new MissionStatusBySceneInfo();
				}
				input.ReadMessage(ClientGroupMissionInfo);
				break;
			case 13736u:
			case 13738u:
				finishedChestMonsterIdList_.AddEntriesFrom(ref input, _repeated_finishedChestMonsterIdList_codec);
				break;
			}
		}
	}
}
