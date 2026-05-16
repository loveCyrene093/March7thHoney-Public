using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DisplayAvatarDetailInfo : IMessage<DisplayAvatarDetailInfo>, IMessage, IEquatable<DisplayAvatarDetailInfo>, IDeepCloneable<DisplayAvatarDetailInfo>, IBufferMessage
{
	private static readonly MessageParser<DisplayAvatarDetailInfo> _parser = new MessageParser<DisplayAvatarDetailInfo>(() => new DisplayAvatarDetailInfo());

	private UnknownFieldSet _unknownFields;

	public const int DressedSkinIdFieldNumber = 1;

	private uint dressedSkinId_;

	public const int RankFieldNumber = 2;

	private uint rank_;

	public const int PosFieldNumber = 5;

	private uint pos_;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int ExpFieldNumber = 8;

	private uint exp_;

	public const int EnhancedIdFieldNumber = 9;

	private uint enhancedId_;

	public const int SkilltreeListFieldNumber = 11;

	private static readonly FieldCodec<AvatarSkillTree> _repeated_skilltreeList_codec = FieldCodec.ForMessage(90u, AvatarSkillTree.Parser);

	private readonly RepeatedField<AvatarSkillTree> skilltreeList_ = new RepeatedField<AvatarSkillTree>();

	public const int EquipmentFieldNumber = 12;

	private DisplayEquipmentInfo equipment_;

	public const int RelicListFieldNumber = 13;

	private static readonly FieldCodec<DisplayRelicInfo> _repeated_relicList_codec = FieldCodec.ForMessage(106u, DisplayRelicInfo.Parser);

	private readonly RepeatedField<DisplayRelicInfo> relicList_ = new RepeatedField<DisplayRelicInfo>();

	public const int AvatarIdFieldNumber = 14;

	private uint avatarId_;

	public const int PromotionFieldNumber = 15;

	private uint promotion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DisplayAvatarDetailInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DisplayAvatarDetailInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
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
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
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
	public RepeatedField<AvatarSkillTree> SkilltreeList => skilltreeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayEquipmentInfo Equipment
	{
		get
		{
			return equipment_;
		}
		set
		{
			equipment_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayRelicInfo> RelicList => relicList_;

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
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarDetailInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarDetailInfo(DisplayAvatarDetailInfo other)
		: this()
	{
		dressedSkinId_ = other.dressedSkinId_;
		rank_ = other.rank_;
		pos_ = other.pos_;
		level_ = other.level_;
		exp_ = other.exp_;
		enhancedId_ = other.enhancedId_;
		skilltreeList_ = other.skilltreeList_.Clone();
		equipment_ = ((other.equipment_ != null) ? other.equipment_.Clone() : null);
		relicList_ = other.relicList_.Clone();
		avatarId_ = other.avatarId_;
		promotion_ = other.promotion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarDetailInfo Clone()
	{
		return new DisplayAvatarDetailInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DisplayAvatarDetailInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DisplayAvatarDetailInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DressedSkinId != other.DressedSkinId)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (EnhancedId != other.EnhancedId)
		{
			return false;
		}
		if (!skilltreeList_.Equals(other.skilltreeList_))
		{
			return false;
		}
		if (!object.Equals(Equipment, other.Equipment))
		{
			return false;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Promotion != other.Promotion)
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
		if (DressedSkinId != 0)
		{
			num ^= DressedSkinId.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (EnhancedId != 0)
		{
			num ^= EnhancedId.GetHashCode();
		}
		num ^= skilltreeList_.GetHashCode();
		if (equipment_ != null)
		{
			num ^= Equipment.GetHashCode();
		}
		num ^= relicList_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
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
		if (DressedSkinId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DressedSkinId);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Rank);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Pos);
		}
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Exp);
		}
		if (EnhancedId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EnhancedId);
		}
		skilltreeList_.WriteTo(ref output, _repeated_skilltreeList_codec);
		if (equipment_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Equipment);
		}
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AvatarId);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Promotion);
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
		if (DressedSkinId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressedSkinId);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (EnhancedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnhancedId);
		}
		num += skilltreeList_.CalculateSize(_repeated_skilltreeList_codec);
		if (equipment_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Equipment);
		}
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DisplayAvatarDetailInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DressedSkinId != 0)
		{
			DressedSkinId = other.DressedSkinId;
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
		}
		if (other.Pos != 0)
		{
			Pos = other.Pos;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		if (other.EnhancedId != 0)
		{
			EnhancedId = other.EnhancedId;
		}
		skilltreeList_.Add(other.skilltreeList_);
		if (other.equipment_ != null)
		{
			if (equipment_ == null)
			{
				Equipment = new DisplayEquipmentInfo();
			}
			Equipment.MergeFrom(other.Equipment);
		}
		relicList_.Add(other.relicList_);
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
		}
		if (other.Promotion != 0)
		{
			Promotion = other.Promotion;
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
				DressedSkinId = input.ReadUInt32();
				break;
			case 16u:
				Rank = input.ReadUInt32();
				break;
			case 40u:
				Pos = input.ReadUInt32();
				break;
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 64u:
				Exp = input.ReadUInt32();
				break;
			case 72u:
				EnhancedId = input.ReadUInt32();
				break;
			case 90u:
				skilltreeList_.AddEntriesFrom(ref input, _repeated_skilltreeList_codec);
				break;
			case 98u:
				if (equipment_ == null)
				{
					Equipment = new DisplayEquipmentInfo();
				}
				input.ReadMessage(Equipment);
				break;
			case 106u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 112u:
				AvatarId = input.ReadUInt32();
				break;
			case 120u:
				Promotion = input.ReadUInt32();
				break;
			}
		}
	}
}
