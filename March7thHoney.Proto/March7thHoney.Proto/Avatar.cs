using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Avatar : IMessage<Avatar>, IMessage, IEquatable<Avatar>, IDeepCloneable<Avatar>, IBufferMessage
{
	private static readonly MessageParser<Avatar> _parser = new MessageParser<Avatar>(() => new Avatar());

	private UnknownFieldSet _unknownFields;

	public const int FirstMetTimeStampFieldNumber = 2;

	private ulong firstMetTimeStamp_;

	public const int PromotionFieldNumber = 3;

	private uint promotion_;

	public const int IsMarkedFieldNumber = 5;

	private bool isMarked_;

	public const int LevelFieldNumber = 8;

	private uint level_;

	public const int BaseAvatarIdFieldNumber = 9;

	private uint baseAvatarId_;

	public const int HasTakenPromotionRewardListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_hasTakenPromotionRewardList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> hasTakenPromotionRewardList_ = new RepeatedField<uint>();

	public const int CurMultiPathAvatarTypeFieldNumber = 13;

	private uint curMultiPathAvatarType_;

	public const int ExpFieldNumber = 14;

	private uint exp_;

	public const int EquipmentUniqueIdFieldNumber = 15;

	private uint equipmentUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Avatar> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong FirstMetTimeStamp
	{
		get
		{
			return firstMetTimeStamp_;
		}
		set
		{
			firstMetTimeStamp_ = value;
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
	public bool IsMarked
	{
		get
		{
			return isMarked_;
		}
		set
		{
			isMarked_ = value;
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
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HasTakenPromotionRewardList => hasTakenPromotionRewardList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurMultiPathAvatarType
	{
		get
		{
			return curMultiPathAvatarType_;
		}
		set
		{
			curMultiPathAvatarType_ = value;
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
	public uint EquipmentUniqueId
	{
		get
		{
			return equipmentUniqueId_;
		}
		set
		{
			equipmentUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Avatar()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Avatar(Avatar other)
		: this()
	{
		firstMetTimeStamp_ = other.firstMetTimeStamp_;
		promotion_ = other.promotion_;
		isMarked_ = other.isMarked_;
		level_ = other.level_;
		baseAvatarId_ = other.baseAvatarId_;
		hasTakenPromotionRewardList_ = other.hasTakenPromotionRewardList_.Clone();
		curMultiPathAvatarType_ = other.curMultiPathAvatarType_;
		exp_ = other.exp_;
		equipmentUniqueId_ = other.equipmentUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Avatar Clone()
	{
		return new Avatar(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Avatar);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Avatar other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FirstMetTimeStamp != other.FirstMetTimeStamp)
		{
			return false;
		}
		if (Promotion != other.Promotion)
		{
			return false;
		}
		if (IsMarked != other.IsMarked)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (!hasTakenPromotionRewardList_.Equals(other.hasTakenPromotionRewardList_))
		{
			return false;
		}
		if (CurMultiPathAvatarType != other.CurMultiPathAvatarType)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (EquipmentUniqueId != other.EquipmentUniqueId)
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
		if (FirstMetTimeStamp != 0L)
		{
			num ^= FirstMetTimeStamp.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
		}
		if (IsMarked)
		{
			num ^= IsMarked.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		num ^= hasTakenPromotionRewardList_.GetHashCode();
		if (CurMultiPathAvatarType != 0)
		{
			num ^= CurMultiPathAvatarType.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (EquipmentUniqueId != 0)
		{
			num ^= EquipmentUniqueId.GetHashCode();
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
		if (FirstMetTimeStamp != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(FirstMetTimeStamp);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Promotion);
		}
		if (IsMarked)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsMarked);
		}
		if (Level != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Level);
		}
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BaseAvatarId);
		}
		hasTakenPromotionRewardList_.WriteTo(ref output, _repeated_hasTakenPromotionRewardList_codec);
		if (CurMultiPathAvatarType != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CurMultiPathAvatarType);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Exp);
		}
		if (EquipmentUniqueId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(EquipmentUniqueId);
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
		if (FirstMetTimeStamp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(FirstMetTimeStamp);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (IsMarked)
		{
			num += 2;
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		num += hasTakenPromotionRewardList_.CalculateSize(_repeated_hasTakenPromotionRewardList_codec);
		if (CurMultiPathAvatarType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurMultiPathAvatarType);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (EquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EquipmentUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Avatar other)
	{
		if (other != null)
		{
			if (other.FirstMetTimeStamp != 0L)
			{
				FirstMetTimeStamp = other.FirstMetTimeStamp;
			}
			if (other.Promotion != 0)
			{
				Promotion = other.Promotion;
			}
			if (other.IsMarked)
			{
				IsMarked = other.IsMarked;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
			}
			hasTakenPromotionRewardList_.Add(other.hasTakenPromotionRewardList_);
			if (other.CurMultiPathAvatarType != 0)
			{
				CurMultiPathAvatarType = other.CurMultiPathAvatarType;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.EquipmentUniqueId != 0)
			{
				EquipmentUniqueId = other.EquipmentUniqueId;
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
			case 16u:
				FirstMetTimeStamp = input.ReadUInt64();
				break;
			case 24u:
				Promotion = input.ReadUInt32();
				break;
			case 40u:
				IsMarked = input.ReadBool();
				break;
			case 64u:
				Level = input.ReadUInt32();
				break;
			case 72u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				hasTakenPromotionRewardList_.AddEntriesFrom(ref input, _repeated_hasTakenPromotionRewardList_codec);
				break;
			case 104u:
				CurMultiPathAvatarType = input.ReadUInt32();
				break;
			case 112u:
				Exp = input.ReadUInt32();
				break;
			case 120u:
				EquipmentUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
