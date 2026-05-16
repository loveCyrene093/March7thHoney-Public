using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PerformanceStartSnapshot : IMessage<PerformanceStartSnapshot>, IMessage, IEquatable<PerformanceStartSnapshot>, IDeepCloneable<PerformanceStartSnapshot>, IBufferMessage
{
	private static readonly MessageParser<PerformanceStartSnapshot> _parser = new MessageParser<PerformanceStartSnapshot>(() => new PerformanceStartSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int PerformanceIdFieldNumber = 1;

	private uint performanceId_;

	public const int PerformanceTypeFieldNumber = 2;

	private uint performanceType_;

	public const int PlaneIdFieldNumber = 3;

	private uint planeId_;

	public const int FloorIdFieldNumber = 4;

	private uint floorId_;

	public const int DimensionIdFieldNumber = 5;

	private uint dimensionId_;

	public const int StoryLineIdFieldNumber = 6;

	private uint storyLineId_;

	public const int ContentIdFieldNumber = 7;

	private uint contentId_;

	public const int EntryIdFieldNumber = 8;

	private uint entryId_;

	public const int VersionFieldNumber = 9;

	private uint version_;

	public const int PlayerFieldNumber = 10;

	private PlayerSnapshot player_;

	public const int MissionFieldNumber = 11;

	private MissionSnapshot mission_;

	public const int EraFlipperFieldNumber = 12;

	private EraFlipperSnapshot eraFlipper_;

	public const int ServerGroupListFieldNumber = 13;

	private static readonly FieldCodec<GroupSnapshot> _repeated_serverGroupList_codec = FieldCodec.ForMessage(106u, GroupSnapshot.Parser);

	private readonly RepeatedField<GroupSnapshot> serverGroupList_ = new RepeatedField<GroupSnapshot>();

	public const int ClientGroupListFieldNumber = 14;

	private static readonly FieldCodec<GroupSnapshot> _repeated_clientGroupList_codec = FieldCodec.ForMessage(114u, GroupSnapshot.Parser);

	private readonly RepeatedField<GroupSnapshot> clientGroupList_ = new RepeatedField<GroupSnapshot>();

	public const int ServerLegacyGroupListFieldNumber = 15;

	private static readonly FieldCodec<GroupSnapshot> _repeated_serverLegacyGroupList_codec = FieldCodec.ForMessage(122u, GroupSnapshot.Parser);

	private readonly RepeatedField<GroupSnapshot> serverLegacyGroupList_ = new RepeatedField<GroupSnapshot>();

	public const int ClientLegacyGroupListFieldNumber = 16;

	private static readonly FieldCodec<GroupSnapshot> _repeated_clientLegacyGroupList_codec = FieldCodec.ForMessage(130u, GroupSnapshot.Parser);

	private readonly RepeatedField<GroupSnapshot> clientLegacyGroupList_ = new RepeatedField<GroupSnapshot>();

	public const int FloorSavedValueListFieldNumber = 17;

	private static readonly MapField<string, int>.Codec _map_floorSavedValueList_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 138u);

	private readonly MapField<string, int> floorSavedValueList_ = new MapField<string, int>();

	public const int FloorCustomValueListFieldNumber = 18;

	private static readonly MapField<string, FloorCustomValueSnapshot>.Codec _map_floorCustomValueList_codec = new MapField<string, FloorCustomValueSnapshot>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForMessage(18u, FloorCustomValueSnapshot.Parser), 146u);

	private readonly MapField<string, FloorCustomValueSnapshot> floorCustomValueList_ = new MapField<string, FloorCustomValueSnapshot>();

	public const int MapRotationFieldNumber = 19;

	private MapRotationSnapshot mapRotation_;

	public const int WorldIdFieldNumber = 20;

	private uint worldId_;

	public const int DialogFieldNumber = 21;

	private DialogSnapshot dialog_;

	public const int OwnerGroupIdFieldNumber = 22;

	private uint ownerGroupId_;

	public const int SwitchHandFieldNumber = 23;

	private SwitchHandSnapshot switchHand_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PerformanceStartSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PerformanceStartSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PerformanceId
	{
		get
		{
			return performanceId_;
		}
		set
		{
			performanceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PerformanceType
	{
		get
		{
			return performanceType_;
		}
		set
		{
			performanceType_ = value;
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
	public uint StoryLineId
	{
		get
		{
			return storyLineId_;
		}
		set
		{
			storyLineId_ = value;
		}
	}

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
	public uint Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSnapshot Player
	{
		get
		{
			return player_;
		}
		set
		{
			player_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSnapshot Mission
	{
		get
		{
			return mission_;
		}
		set
		{
			mission_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperSnapshot EraFlipper
	{
		get
		{
			return eraFlipper_;
		}
		set
		{
			eraFlipper_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GroupSnapshot> ServerGroupList => serverGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GroupSnapshot> ClientGroupList => clientGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GroupSnapshot> ServerLegacyGroupList => serverLegacyGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GroupSnapshot> ClientLegacyGroupList => clientLegacyGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> FloorSavedValueList => floorSavedValueList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, FloorCustomValueSnapshot> FloorCustomValueList => floorCustomValueList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRotationSnapshot MapRotation
	{
		get
		{
			return mapRotation_;
		}
		set
		{
			mapRotation_ = value;
		}
	}

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
	public DialogSnapshot Dialog
	{
		get
		{
			return dialog_;
		}
		set
		{
			dialog_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OwnerGroupId
	{
		get
		{
			return ownerGroupId_;
		}
		set
		{
			ownerGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandSnapshot SwitchHand
	{
		get
		{
			return switchHand_;
		}
		set
		{
			switchHand_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PerformanceStartSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PerformanceStartSnapshot(PerformanceStartSnapshot other)
		: this()
	{
		performanceId_ = other.performanceId_;
		performanceType_ = other.performanceType_;
		planeId_ = other.planeId_;
		floorId_ = other.floorId_;
		dimensionId_ = other.dimensionId_;
		storyLineId_ = other.storyLineId_;
		contentId_ = other.contentId_;
		entryId_ = other.entryId_;
		version_ = other.version_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		mission_ = ((other.mission_ != null) ? other.mission_.Clone() : null);
		eraFlipper_ = ((other.eraFlipper_ != null) ? other.eraFlipper_.Clone() : null);
		serverGroupList_ = other.serverGroupList_.Clone();
		clientGroupList_ = other.clientGroupList_.Clone();
		serverLegacyGroupList_ = other.serverLegacyGroupList_.Clone();
		clientLegacyGroupList_ = other.clientLegacyGroupList_.Clone();
		floorSavedValueList_ = other.floorSavedValueList_.Clone();
		floorCustomValueList_ = other.floorCustomValueList_.Clone();
		mapRotation_ = ((other.mapRotation_ != null) ? other.mapRotation_.Clone() : null);
		worldId_ = other.worldId_;
		dialog_ = ((other.dialog_ != null) ? other.dialog_.Clone() : null);
		ownerGroupId_ = other.ownerGroupId_;
		switchHand_ = ((other.switchHand_ != null) ? other.switchHand_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PerformanceStartSnapshot Clone()
	{
		return new PerformanceStartSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PerformanceStartSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PerformanceStartSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformanceId != other.PerformanceId)
		{
			return false;
		}
		if (PerformanceType != other.PerformanceType)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
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
		if (StoryLineId != other.StoryLineId)
		{
			return false;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (!object.Equals(Player, other.Player))
		{
			return false;
		}
		if (!object.Equals(Mission, other.Mission))
		{
			return false;
		}
		if (!object.Equals(EraFlipper, other.EraFlipper))
		{
			return false;
		}
		if (!serverGroupList_.Equals(other.serverGroupList_))
		{
			return false;
		}
		if (!clientGroupList_.Equals(other.clientGroupList_))
		{
			return false;
		}
		if (!serverLegacyGroupList_.Equals(other.serverLegacyGroupList_))
		{
			return false;
		}
		if (!clientLegacyGroupList_.Equals(other.clientLegacyGroupList_))
		{
			return false;
		}
		if (!FloorSavedValueList.Equals(other.FloorSavedValueList))
		{
			return false;
		}
		if (!FloorCustomValueList.Equals(other.FloorCustomValueList))
		{
			return false;
		}
		if (!object.Equals(MapRotation, other.MapRotation))
		{
			return false;
		}
		if (WorldId != other.WorldId)
		{
			return false;
		}
		if (!object.Equals(Dialog, other.Dialog))
		{
			return false;
		}
		if (OwnerGroupId != other.OwnerGroupId)
		{
			return false;
		}
		if (!object.Equals(SwitchHand, other.SwitchHand))
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
		if (PerformanceId != 0)
		{
			num ^= PerformanceId.GetHashCode();
		}
		if (PerformanceType != 0)
		{
			num ^= PerformanceType.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (DimensionId != 0)
		{
			num ^= DimensionId.GetHashCode();
		}
		if (StoryLineId != 0)
		{
			num ^= StoryLineId.GetHashCode();
		}
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (Version != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		if (mission_ != null)
		{
			num ^= Mission.GetHashCode();
		}
		if (eraFlipper_ != null)
		{
			num ^= EraFlipper.GetHashCode();
		}
		num ^= serverGroupList_.GetHashCode();
		num ^= clientGroupList_.GetHashCode();
		num ^= serverLegacyGroupList_.GetHashCode();
		num ^= clientLegacyGroupList_.GetHashCode();
		num ^= FloorSavedValueList.GetHashCode();
		num ^= FloorCustomValueList.GetHashCode();
		if (mapRotation_ != null)
		{
			num ^= MapRotation.GetHashCode();
		}
		if (WorldId != 0)
		{
			num ^= WorldId.GetHashCode();
		}
		if (dialog_ != null)
		{
			num ^= Dialog.GetHashCode();
		}
		if (OwnerGroupId != 0)
		{
			num ^= OwnerGroupId.GetHashCode();
		}
		if (switchHand_ != null)
		{
			num ^= SwitchHand.GetHashCode();
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
		if (PerformanceId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PerformanceId);
		}
		if (PerformanceType != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PerformanceType);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PlaneId);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FloorId);
		}
		if (DimensionId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DimensionId);
		}
		if (StoryLineId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(StoryLineId);
		}
		if (ContentId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ContentId);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EntryId);
		}
		if (Version != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Version);
		}
		if (player_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Player);
		}
		if (mission_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Mission);
		}
		if (eraFlipper_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EraFlipper);
		}
		serverGroupList_.WriteTo(ref output, _repeated_serverGroupList_codec);
		clientGroupList_.WriteTo(ref output, _repeated_clientGroupList_codec);
		serverLegacyGroupList_.WriteTo(ref output, _repeated_serverLegacyGroupList_codec);
		clientLegacyGroupList_.WriteTo(ref output, _repeated_clientLegacyGroupList_codec);
		floorSavedValueList_.WriteTo(ref output, _map_floorSavedValueList_codec);
		floorCustomValueList_.WriteTo(ref output, _map_floorCustomValueList_codec);
		if (mapRotation_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(MapRotation);
		}
		if (WorldId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteUInt32(WorldId);
		}
		if (dialog_ != null)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(Dialog);
		}
		if (OwnerGroupId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteUInt32(OwnerGroupId);
		}
		if (switchHand_ != null)
		{
			output.WriteRawTag(186, 1);
			output.WriteMessage(SwitchHand);
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
		if (PerformanceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PerformanceId);
		}
		if (PerformanceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PerformanceType);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (DimensionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DimensionId);
		}
		if (StoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StoryLineId);
		}
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		if (mission_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Mission);
		}
		if (eraFlipper_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EraFlipper);
		}
		num += serverGroupList_.CalculateSize(_repeated_serverGroupList_codec);
		num += clientGroupList_.CalculateSize(_repeated_clientGroupList_codec);
		num += serverLegacyGroupList_.CalculateSize(_repeated_serverLegacyGroupList_codec);
		num += clientLegacyGroupList_.CalculateSize(_repeated_clientLegacyGroupList_codec);
		num += floorSavedValueList_.CalculateSize(_map_floorSavedValueList_codec);
		num += floorCustomValueList_.CalculateSize(_map_floorCustomValueList_codec);
		if (mapRotation_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MapRotation);
		}
		if (WorldId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(WorldId);
		}
		if (dialog_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Dialog);
		}
		if (OwnerGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(OwnerGroupId);
		}
		if (switchHand_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SwitchHand);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PerformanceStartSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PerformanceId != 0)
		{
			PerformanceId = other.PerformanceId;
		}
		if (other.PerformanceType != 0)
		{
			PerformanceType = other.PerformanceType;
		}
		if (other.PlaneId != 0)
		{
			PlaneId = other.PlaneId;
		}
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
		}
		if (other.DimensionId != 0)
		{
			DimensionId = other.DimensionId;
		}
		if (other.StoryLineId != 0)
		{
			StoryLineId = other.StoryLineId;
		}
		if (other.ContentId != 0)
		{
			ContentId = other.ContentId;
		}
		if (other.EntryId != 0)
		{
			EntryId = other.EntryId;
		}
		if (other.Version != 0)
		{
			Version = other.Version;
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerSnapshot();
			}
			Player.MergeFrom(other.Player);
		}
		if (other.mission_ != null)
		{
			if (mission_ == null)
			{
				Mission = new MissionSnapshot();
			}
			Mission.MergeFrom(other.Mission);
		}
		if (other.eraFlipper_ != null)
		{
			if (eraFlipper_ == null)
			{
				EraFlipper = new EraFlipperSnapshot();
			}
			EraFlipper.MergeFrom(other.EraFlipper);
		}
		serverGroupList_.Add(other.serverGroupList_);
		clientGroupList_.Add(other.clientGroupList_);
		serverLegacyGroupList_.Add(other.serverLegacyGroupList_);
		clientLegacyGroupList_.Add(other.clientLegacyGroupList_);
		floorSavedValueList_.MergeFrom(other.floorSavedValueList_);
		floorCustomValueList_.MergeFrom(other.floorCustomValueList_);
		if (other.mapRotation_ != null)
		{
			if (mapRotation_ == null)
			{
				MapRotation = new MapRotationSnapshot();
			}
			MapRotation.MergeFrom(other.MapRotation);
		}
		if (other.WorldId != 0)
		{
			WorldId = other.WorldId;
		}
		if (other.dialog_ != null)
		{
			if (dialog_ == null)
			{
				Dialog = new DialogSnapshot();
			}
			Dialog.MergeFrom(other.Dialog);
		}
		if (other.OwnerGroupId != 0)
		{
			OwnerGroupId = other.OwnerGroupId;
		}
		if (other.switchHand_ != null)
		{
			if (switchHand_ == null)
			{
				SwitchHand = new SwitchHandSnapshot();
			}
			SwitchHand.MergeFrom(other.SwitchHand);
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
				PerformanceId = input.ReadUInt32();
				break;
			case 16u:
				PerformanceType = input.ReadUInt32();
				break;
			case 24u:
				PlaneId = input.ReadUInt32();
				break;
			case 32u:
				FloorId = input.ReadUInt32();
				break;
			case 40u:
				DimensionId = input.ReadUInt32();
				break;
			case 48u:
				StoryLineId = input.ReadUInt32();
				break;
			case 56u:
				ContentId = input.ReadUInt32();
				break;
			case 64u:
				EntryId = input.ReadUInt32();
				break;
			case 72u:
				Version = input.ReadUInt32();
				break;
			case 82u:
				if (player_ == null)
				{
					Player = new PlayerSnapshot();
				}
				input.ReadMessage(Player);
				break;
			case 90u:
				if (mission_ == null)
				{
					Mission = new MissionSnapshot();
				}
				input.ReadMessage(Mission);
				break;
			case 98u:
				if (eraFlipper_ == null)
				{
					EraFlipper = new EraFlipperSnapshot();
				}
				input.ReadMessage(EraFlipper);
				break;
			case 106u:
				serverGroupList_.AddEntriesFrom(ref input, _repeated_serverGroupList_codec);
				break;
			case 114u:
				clientGroupList_.AddEntriesFrom(ref input, _repeated_clientGroupList_codec);
				break;
			case 122u:
				serverLegacyGroupList_.AddEntriesFrom(ref input, _repeated_serverLegacyGroupList_codec);
				break;
			case 130u:
				clientLegacyGroupList_.AddEntriesFrom(ref input, _repeated_clientLegacyGroupList_codec);
				break;
			case 138u:
				floorSavedValueList_.AddEntriesFrom(ref input, _map_floorSavedValueList_codec);
				break;
			case 146u:
				floorCustomValueList_.AddEntriesFrom(ref input, _map_floorCustomValueList_codec);
				break;
			case 154u:
				if (mapRotation_ == null)
				{
					MapRotation = new MapRotationSnapshot();
				}
				input.ReadMessage(MapRotation);
				break;
			case 160u:
				WorldId = input.ReadUInt32();
				break;
			case 170u:
				if (dialog_ == null)
				{
					Dialog = new DialogSnapshot();
				}
				input.ReadMessage(Dialog);
				break;
			case 176u:
				OwnerGroupId = input.ReadUInt32();
				break;
			case 186u:
				if (switchHand_ == null)
				{
					SwitchHand = new SwitchHandSnapshot();
				}
				input.ReadMessage(SwitchHand);
				break;
			}
		}
	}
}
