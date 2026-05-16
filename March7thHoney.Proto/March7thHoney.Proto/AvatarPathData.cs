using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AvatarPathData : IMessage<AvatarPathData>, IMessage, IEquatable<AvatarPathData>, IDeepCloneable<AvatarPathData>, IBufferMessage
{
	private static readonly MessageParser<AvatarPathData> _parser = new MessageParser<AvatarPathData>(() => new AvatarPathData());

	private UnknownFieldSet _unknownFields;

	public const int AvatarPathSkillTreeFieldNumber = 1;

	private static readonly FieldCodec<AvatarPathSkillTree> _repeated_avatarPathSkillTree_codec = FieldCodec.ForMessage(10u, March7thHoney.Proto.AvatarPathSkillTree.Parser);

	private readonly RepeatedField<AvatarPathSkillTree> avatarPathSkillTree_ = new RepeatedField<AvatarPathSkillTree>();

	public const int DressedSkinIdFieldNumber = 8;

	private uint dressedSkinId_;

	public const int EquipRelicListFieldNumber = 9;

	private static readonly FieldCodec<EquipRelic> _repeated_equipRelicList_codec = FieldCodec.ForMessage(74u, EquipRelic.Parser);

	private readonly RepeatedField<EquipRelic> equipRelicList_ = new RepeatedField<EquipRelic>();

	public const int AvatarIdFieldNumber = 10;

	private uint avatarId_;

	public const int RankFieldNumber = 11;

	private uint rank_;

	public const int UnlockTimestampFieldNumber = 12;

	private ulong unlockTimestamp_;

	public const int PathEquipmentIdFieldNumber = 13;

	private uint pathEquipmentId_;

	public const int UnkEnhancedIdFieldNumber = 14;

	private uint unkEnhancedId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AvatarPathData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarPathDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarPathSkillTree> AvatarPathSkillTree => avatarPathSkillTree_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressedSkinId
	{
		get
		{
			return dressedSkinId_;
		}
		set
		{
			dressedSkinId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipRelic> EquipRelicList => equipRelicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong UnlockTimestamp
	{
		get
		{
			return unlockTimestamp_;
		}
		set
		{
			unlockTimestamp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PathEquipmentId
	{
		get
		{
			return pathEquipmentId_;
		}
		set
		{
			pathEquipmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UnkEnhancedId
	{
		get
		{
			return unkEnhancedId_;
		}
		set
		{
			unkEnhancedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarPathData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarPathData(AvatarPathData other)
		: this()
	{
		avatarPathSkillTree_ = other.avatarPathSkillTree_.Clone();
		dressedSkinId_ = other.dressedSkinId_;
		equipRelicList_ = other.equipRelicList_.Clone();
		avatarId_ = other.avatarId_;
		rank_ = other.rank_;
		unlockTimestamp_ = other.unlockTimestamp_;
		pathEquipmentId_ = other.pathEquipmentId_;
		unkEnhancedId_ = other.unkEnhancedId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarPathData Clone()
	{
		return new AvatarPathData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AvatarPathData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AvatarPathData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarPathSkillTree_.Equals(other.avatarPathSkillTree_))
		{
			return false;
		}
		if (DressedSkinId != other.DressedSkinId)
		{
			return false;
		}
		if (!equipRelicList_.Equals(other.equipRelicList_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (UnlockTimestamp != other.UnlockTimestamp)
		{
			return false;
		}
		if (PathEquipmentId != other.PathEquipmentId)
		{
			return false;
		}
		if (UnkEnhancedId != other.UnkEnhancedId)
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
		num ^= avatarPathSkillTree_.GetHashCode();
		if (DressedSkinId != 0)
		{
			num ^= DressedSkinId.GetHashCode();
		}
		num ^= equipRelicList_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (UnlockTimestamp != 0L)
		{
			num ^= UnlockTimestamp.GetHashCode();
		}
		if (PathEquipmentId != 0)
		{
			num ^= PathEquipmentId.GetHashCode();
		}
		if (UnkEnhancedId != 0)
		{
			num ^= UnkEnhancedId.GetHashCode();
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
		avatarPathSkillTree_.WriteTo(ref output, _repeated_avatarPathSkillTree_codec);
		if (DressedSkinId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DressedSkinId);
		}
		equipRelicList_.WriteTo(ref output, _repeated_equipRelicList_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AvatarId);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Rank);
		}
		if (UnlockTimestamp != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(UnlockTimestamp);
		}
		if (PathEquipmentId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PathEquipmentId);
		}
		if (UnkEnhancedId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(UnkEnhancedId);
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
		num += avatarPathSkillTree_.CalculateSize(_repeated_avatarPathSkillTree_codec);
		if (DressedSkinId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressedSkinId);
		}
		num += equipRelicList_.CalculateSize(_repeated_equipRelicList_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (UnlockTimestamp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UnlockTimestamp);
		}
		if (PathEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PathEquipmentId);
		}
		if (UnkEnhancedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UnkEnhancedId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AvatarPathData other)
	{
		if (other != null)
		{
			avatarPathSkillTree_.Add(other.avatarPathSkillTree_);
			if (other.DressedSkinId != 0)
			{
				DressedSkinId = other.DressedSkinId;
			}
			equipRelicList_.Add(other.equipRelicList_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.UnlockTimestamp != 0L)
			{
				UnlockTimestamp = other.UnlockTimestamp;
			}
			if (other.PathEquipmentId != 0)
			{
				PathEquipmentId = other.PathEquipmentId;
			}
			if (other.UnkEnhancedId != 0)
			{
				UnkEnhancedId = other.UnkEnhancedId;
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
			case 10u:
				avatarPathSkillTree_.AddEntriesFrom(ref input, _repeated_avatarPathSkillTree_codec);
				break;
			case 64u:
				DressedSkinId = input.ReadUInt32();
				break;
			case 74u:
				equipRelicList_.AddEntriesFrom(ref input, _repeated_equipRelicList_codec);
				break;
			case 80u:
				AvatarId = input.ReadUInt32();
				break;
			case 88u:
				Rank = input.ReadUInt32();
				break;
			case 96u:
				UnlockTimestamp = input.ReadUInt64();
				break;
			case 104u:
				PathEquipmentId = input.ReadUInt32();
				break;
			case 112u:
				UnkEnhancedId = input.ReadUInt32();
				break;
			}
		}
	}
}
