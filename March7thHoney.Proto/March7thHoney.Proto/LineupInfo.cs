using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LineupInfo : IMessage<LineupInfo>, IMessage, IEquatable<LineupInfo>, IDeepCloneable<LineupInfo>, IBufferMessage
{
	private static readonly MessageParser<LineupInfo> _parser = new MessageParser<LineupInfo>(() => new LineupInfo());

	private UnknownFieldSet _unknownFields;

	public const int OBMEFOMFGFDFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_oBMEFOMFGFD_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> oBMEFOMFGFD_ = new RepeatedField<uint>();

	public const int AvatarListFieldNumber = 2;

	private static readonly FieldCodec<LineupAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage(18u, LineupAvatar.Parser);

	private readonly RepeatedField<LineupAvatar> avatarList_ = new RepeatedField<LineupAvatar>();

	public const int StoryLineAvatarIdListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_storyLineAvatarIdList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> storyLineAvatarIdList_ = new RepeatedField<uint>();

	public const int MaxMpFieldNumber = 4;

	private uint maxMp_;

	public const int MpFieldNumber = 6;

	private uint mp_;

	public const int IsVirtualFieldNumber = 7;

	private bool isVirtual_;

	public const int IndexFieldNumber = 8;

	private uint index_;

	public const int ExtraLineupTypeFieldNumber = 9;

	private ExtraLineupType extraLineupType_;

	public const int GameStoryLineIdFieldNumber = 10;

	private uint gameStoryLineId_;

	public const int NameFieldNumber = 11;

	private string name_ = "";

	public const int GLLDELDFDEEFieldNumber = 12;

	private bool gLLDELDFDEE_;

	public const int AGOPFIFDJFNFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_aGOPFIFDJFN_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> aGOPFIFDJFN_ = new RepeatedField<uint>();

	public const int LeaderSlotFieldNumber = 14;

	private uint leaderSlot_;

	public const int PlaneIdFieldNumber = 15;

	private uint planeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LineupInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LineupInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OBMEFOMFGFD => oBMEFOMFGFD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LineupAvatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> StoryLineAvatarIdList => storyLineAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxMp
	{
		get
		{
			return maxMp_;
		}
		set
		{
			maxMp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Mp
	{
		get
		{
			return mp_;
		}
		set
		{
			mp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsVirtual
	{
		get
		{
			return isVirtual_;
		}
		set
		{
			isVirtual_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupType ExtraLineupType
	{
		get
		{
			return extraLineupType_;
		}
		set
		{
			extraLineupType_ = value;
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
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GLLDELDFDEE
	{
		get
		{
			return gLLDELDFDEE_;
		}
		set
		{
			gLLDELDFDEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AGOPFIFDJFN => aGOPFIFDJFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LeaderSlot
	{
		get
		{
			return leaderSlot_;
		}
		set
		{
			leaderSlot_ = value;
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
	public LineupInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo(LineupInfo other)
		: this()
	{
		oBMEFOMFGFD_ = other.oBMEFOMFGFD_.Clone();
		avatarList_ = other.avatarList_.Clone();
		storyLineAvatarIdList_ = other.storyLineAvatarIdList_.Clone();
		maxMp_ = other.maxMp_;
		mp_ = other.mp_;
		isVirtual_ = other.isVirtual_;
		index_ = other.index_;
		extraLineupType_ = other.extraLineupType_;
		gameStoryLineId_ = other.gameStoryLineId_;
		name_ = other.name_;
		gLLDELDFDEE_ = other.gLLDELDFDEE_;
		aGOPFIFDJFN_ = other.aGOPFIFDJFN_.Clone();
		leaderSlot_ = other.leaderSlot_;
		planeId_ = other.planeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo Clone()
	{
		return new LineupInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LineupInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LineupInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oBMEFOMFGFD_.Equals(other.oBMEFOMFGFD_))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!storyLineAvatarIdList_.Equals(other.storyLineAvatarIdList_))
		{
			return false;
		}
		if (MaxMp != other.MaxMp)
		{
			return false;
		}
		if (Mp != other.Mp)
		{
			return false;
		}
		if (IsVirtual != other.IsVirtual)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (ExtraLineupType != other.ExtraLineupType)
		{
			return false;
		}
		if (GameStoryLineId != other.GameStoryLineId)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (GLLDELDFDEE != other.GLLDELDFDEE)
		{
			return false;
		}
		if (!aGOPFIFDJFN_.Equals(other.aGOPFIFDJFN_))
		{
			return false;
		}
		if (LeaderSlot != other.LeaderSlot)
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
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
		num ^= oBMEFOMFGFD_.GetHashCode();
		num ^= avatarList_.GetHashCode();
		num ^= storyLineAvatarIdList_.GetHashCode();
		if (MaxMp != 0)
		{
			num ^= MaxMp.GetHashCode();
		}
		if (Mp != 0)
		{
			num ^= Mp.GetHashCode();
		}
		if (IsVirtual)
		{
			num ^= IsVirtual.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num ^= ExtraLineupType.GetHashCode();
		}
		if (GameStoryLineId != 0)
		{
			num ^= GameStoryLineId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (GLLDELDFDEE)
		{
			num ^= GLLDELDFDEE.GetHashCode();
		}
		num ^= aGOPFIFDJFN_.GetHashCode();
		if (LeaderSlot != 0)
		{
			num ^= LeaderSlot.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
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
		oBMEFOMFGFD_.WriteTo(ref output, _repeated_oBMEFOMFGFD_codec);
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		storyLineAvatarIdList_.WriteTo(ref output, _repeated_storyLineAvatarIdList_codec);
		if (MaxMp != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MaxMp);
		}
		if (Mp != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Mp);
		}
		if (IsVirtual)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsVirtual);
		}
		if (Index != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Index);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)ExtraLineupType);
		}
		if (GameStoryLineId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GameStoryLineId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Name);
		}
		if (GLLDELDFDEE)
		{
			output.WriteRawTag(96);
			output.WriteBool(GLLDELDFDEE);
		}
		aGOPFIFDJFN_.WriteTo(ref output, _repeated_aGOPFIFDJFN_codec);
		if (LeaderSlot != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LeaderSlot);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PlaneId);
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
		num += oBMEFOMFGFD_.CalculateSize(_repeated_oBMEFOMFGFD_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += storyLineAvatarIdList_.CalculateSize(_repeated_storyLineAvatarIdList_codec);
		if (MaxMp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxMp);
		}
		if (Mp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Mp);
		}
		if (IsVirtual)
		{
			num += 2;
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExtraLineupType);
		}
		if (GameStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (GLLDELDFDEE)
		{
			num += 2;
		}
		num += aGOPFIFDJFN_.CalculateSize(_repeated_aGOPFIFDJFN_codec);
		if (LeaderSlot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LeaderSlot);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LineupInfo other)
	{
		if (other != null)
		{
			oBMEFOMFGFD_.Add(other.oBMEFOMFGFD_);
			avatarList_.Add(other.avatarList_);
			storyLineAvatarIdList_.Add(other.storyLineAvatarIdList_);
			if (other.MaxMp != 0)
			{
				MaxMp = other.MaxMp;
			}
			if (other.Mp != 0)
			{
				Mp = other.Mp;
			}
			if (other.IsVirtual)
			{
				IsVirtual = other.IsVirtual;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				ExtraLineupType = other.ExtraLineupType;
			}
			if (other.GameStoryLineId != 0)
			{
				GameStoryLineId = other.GameStoryLineId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.GLLDELDFDEE)
			{
				GLLDELDFDEE = other.GLLDELDFDEE;
			}
			aGOPFIFDJFN_.Add(other.aGOPFIFDJFN_);
			if (other.LeaderSlot != 0)
			{
				LeaderSlot = other.LeaderSlot;
			}
			if (other.PlaneId != 0)
			{
				PlaneId = other.PlaneId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 10u:
				oBMEFOMFGFD_.AddEntriesFrom(ref input, _repeated_oBMEFOMFGFD_codec);
				break;
			case 18u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 24u:
			case 26u:
				storyLineAvatarIdList_.AddEntriesFrom(ref input, _repeated_storyLineAvatarIdList_codec);
				break;
			case 32u:
				MaxMp = input.ReadUInt32();
				break;
			case 48u:
				Mp = input.ReadUInt32();
				break;
			case 56u:
				IsVirtual = input.ReadBool();
				break;
			case 64u:
				Index = input.ReadUInt32();
				break;
			case 72u:
				ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				break;
			case 80u:
				GameStoryLineId = input.ReadUInt32();
				break;
			case 90u:
				Name = input.ReadString();
				break;
			case 96u:
				GLLDELDFDEE = input.ReadBool();
				break;
			case 104u:
			case 106u:
				aGOPFIFDJFN_.AddEntriesFrom(ref input, _repeated_aGOPFIFDJFN_codec);
				break;
			case 112u:
				LeaderSlot = input.ReadUInt32();
				break;
			case 120u:
				PlaneId = input.ReadUInt32();
				break;
			}
		}
	}
}
