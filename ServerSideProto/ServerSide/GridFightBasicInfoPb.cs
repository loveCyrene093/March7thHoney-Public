using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightBasicInfoPb : IMessage<GridFightBasicInfoPb>, IMessage, IEquatable<GridFightBasicInfoPb>, IDeepCloneable<GridFightBasicInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightBasicInfoPb> _parser = new MessageParser<GridFightBasicInfoPb>(() => new GridFightBasicInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int CurGoldFieldNumber = 1;

	private uint curGold_;

	public const int CurLevelFieldNumber = 2;

	private uint curLevel_;

	public const int LevelExpFieldNumber = 3;

	private uint levelExp_;

	public const int BuyLevelCostFieldNumber = 4;

	private uint buyLevelCost_;

	public const int CurHpFieldNumber = 5;

	private uint curHp_;

	public const int MaxAvatarNumFieldNumber = 6;

	private uint maxAvatarNum_;

	public const int ComboNumFieldNumber = 7;

	private uint comboNum_;

	public const int LockTypeFieldNumber = 8;

	private uint lockType_;

	public const int LockReasonFieldNumber = 9;

	private uint lockReason_;

	public const int MaxInterestFieldNumber = 10;

	private uint maxInterest_;

	public const int TrackingTraitsFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_trackingTraits_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> trackingTraits_ = new RepeatedField<uint>();

	public const int TrackingEquipmentsFieldNumber = 12;

	private static readonly FieldCodec<GridFightEquipmentTrackInfoPb> _repeated_trackingEquipments_codec = FieldCodec.ForMessage(98u, GridFightEquipmentTrackInfoPb.Parser);

	private readonly RepeatedField<GridFightEquipmentTrackInfoPb> trackingEquipments_ = new RepeatedField<GridFightEquipmentTrackInfoPb>();

	public const int GuideCodeFieldNumber = 13;

	private string guideCode_ = "";

	public const int MaxLevelFieldNumber = 14;

	private uint maxLevel_;

	public const int OffFieldAvatarNumFieldNumber = 15;

	private uint offFieldAvatarNum_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightBasicInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurGold
	{
		get
		{
			return curGold_;
		}
		set
		{
			curGold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurLevel
	{
		get
		{
			return curLevel_;
		}
		set
		{
			curLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelExp
	{
		get
		{
			return levelExp_;
		}
		set
		{
			levelExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuyLevelCost
	{
		get
		{
			return buyLevelCost_;
		}
		set
		{
			buyLevelCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxAvatarNum
	{
		get
		{
			return maxAvatarNum_;
		}
		set
		{
			maxAvatarNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ComboNum
	{
		get
		{
			return comboNum_;
		}
		set
		{
			comboNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LockType
	{
		get
		{
			return lockType_;
		}
		set
		{
			lockType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LockReason
	{
		get
		{
			return lockReason_;
		}
		set
		{
			lockReason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxInterest
	{
		get
		{
			return maxInterest_;
		}
		set
		{
			maxInterest_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TrackingTraits => trackingTraits_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightEquipmentTrackInfoPb> TrackingEquipments => trackingEquipments_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GuideCode
	{
		get
		{
			return guideCode_;
		}
		set
		{
			guideCode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxLevel
	{
		get
		{
			return maxLevel_;
		}
		set
		{
			maxLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OffFieldAvatarNum
	{
		get
		{
			return offFieldAvatarNum_;
		}
		set
		{
			offFieldAvatarNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBasicInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBasicInfoPb(GridFightBasicInfoPb other)
		: this()
	{
		curGold_ = other.curGold_;
		curLevel_ = other.curLevel_;
		levelExp_ = other.levelExp_;
		buyLevelCost_ = other.buyLevelCost_;
		curHp_ = other.curHp_;
		maxAvatarNum_ = other.maxAvatarNum_;
		comboNum_ = other.comboNum_;
		lockType_ = other.lockType_;
		lockReason_ = other.lockReason_;
		maxInterest_ = other.maxInterest_;
		trackingTraits_ = other.trackingTraits_.Clone();
		trackingEquipments_ = other.trackingEquipments_.Clone();
		guideCode_ = other.guideCode_;
		maxLevel_ = other.maxLevel_;
		offFieldAvatarNum_ = other.offFieldAvatarNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBasicInfoPb Clone()
	{
		return new GridFightBasicInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightBasicInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightBasicInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurGold != other.CurGold)
		{
			return false;
		}
		if (CurLevel != other.CurLevel)
		{
			return false;
		}
		if (LevelExp != other.LevelExp)
		{
			return false;
		}
		if (BuyLevelCost != other.BuyLevelCost)
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (MaxAvatarNum != other.MaxAvatarNum)
		{
			return false;
		}
		if (ComboNum != other.ComboNum)
		{
			return false;
		}
		if (LockType != other.LockType)
		{
			return false;
		}
		if (LockReason != other.LockReason)
		{
			return false;
		}
		if (MaxInterest != other.MaxInterest)
		{
			return false;
		}
		if (!trackingTraits_.Equals(other.trackingTraits_))
		{
			return false;
		}
		if (!trackingEquipments_.Equals(other.trackingEquipments_))
		{
			return false;
		}
		if (GuideCode != other.GuideCode)
		{
			return false;
		}
		if (MaxLevel != other.MaxLevel)
		{
			return false;
		}
		if (OffFieldAvatarNum != other.OffFieldAvatarNum)
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
		if (CurGold != 0)
		{
			num ^= CurGold.GetHashCode();
		}
		if (CurLevel != 0)
		{
			num ^= CurLevel.GetHashCode();
		}
		if (LevelExp != 0)
		{
			num ^= LevelExp.GetHashCode();
		}
		if (BuyLevelCost != 0)
		{
			num ^= BuyLevelCost.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		if (MaxAvatarNum != 0)
		{
			num ^= MaxAvatarNum.GetHashCode();
		}
		if (ComboNum != 0)
		{
			num ^= ComboNum.GetHashCode();
		}
		if (LockType != 0)
		{
			num ^= LockType.GetHashCode();
		}
		if (LockReason != 0)
		{
			num ^= LockReason.GetHashCode();
		}
		if (MaxInterest != 0)
		{
			num ^= MaxInterest.GetHashCode();
		}
		num ^= trackingTraits_.GetHashCode();
		num ^= trackingEquipments_.GetHashCode();
		if (GuideCode.Length != 0)
		{
			num ^= GuideCode.GetHashCode();
		}
		if (MaxLevel != 0)
		{
			num ^= MaxLevel.GetHashCode();
		}
		if (OffFieldAvatarNum != 0)
		{
			num ^= OffFieldAvatarNum.GetHashCode();
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
		if (CurGold != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CurGold);
		}
		if (CurLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CurLevel);
		}
		if (LevelExp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LevelExp);
		}
		if (BuyLevelCost != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BuyLevelCost);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CurHp);
		}
		if (MaxAvatarNum != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MaxAvatarNum);
		}
		if (ComboNum != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ComboNum);
		}
		if (LockType != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LockType);
		}
		if (LockReason != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LockReason);
		}
		if (MaxInterest != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MaxInterest);
		}
		trackingTraits_.WriteTo(ref output, _repeated_trackingTraits_codec);
		trackingEquipments_.WriteTo(ref output, _repeated_trackingEquipments_codec);
		if (GuideCode.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(GuideCode);
		}
		if (MaxLevel != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MaxLevel);
		}
		if (OffFieldAvatarNum != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OffFieldAvatarNum);
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
		if (CurGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurGold);
		}
		if (CurLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurLevel);
		}
		if (LevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelExp);
		}
		if (BuyLevelCost != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuyLevelCost);
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		if (MaxAvatarNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxAvatarNum);
		}
		if (ComboNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComboNum);
		}
		if (LockType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LockType);
		}
		if (LockReason != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LockReason);
		}
		if (MaxInterest != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxInterest);
		}
		num += trackingTraits_.CalculateSize(_repeated_trackingTraits_codec);
		num += trackingEquipments_.CalculateSize(_repeated_trackingEquipments_codec);
		if (GuideCode.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GuideCode);
		}
		if (MaxLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxLevel);
		}
		if (OffFieldAvatarNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OffFieldAvatarNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightBasicInfoPb other)
	{
		if (other != null)
		{
			if (other.CurGold != 0)
			{
				CurGold = other.CurGold;
			}
			if (other.CurLevel != 0)
			{
				CurLevel = other.CurLevel;
			}
			if (other.LevelExp != 0)
			{
				LevelExp = other.LevelExp;
			}
			if (other.BuyLevelCost != 0)
			{
				BuyLevelCost = other.BuyLevelCost;
			}
			if (other.CurHp != 0)
			{
				CurHp = other.CurHp;
			}
			if (other.MaxAvatarNum != 0)
			{
				MaxAvatarNum = other.MaxAvatarNum;
			}
			if (other.ComboNum != 0)
			{
				ComboNum = other.ComboNum;
			}
			if (other.LockType != 0)
			{
				LockType = other.LockType;
			}
			if (other.LockReason != 0)
			{
				LockReason = other.LockReason;
			}
			if (other.MaxInterest != 0)
			{
				MaxInterest = other.MaxInterest;
			}
			trackingTraits_.Add(other.trackingTraits_);
			trackingEquipments_.Add(other.trackingEquipments_);
			if (other.GuideCode.Length != 0)
			{
				GuideCode = other.GuideCode;
			}
			if (other.MaxLevel != 0)
			{
				MaxLevel = other.MaxLevel;
			}
			if (other.OffFieldAvatarNum != 0)
			{
				OffFieldAvatarNum = other.OffFieldAvatarNum;
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				CurGold = input.ReadUInt32();
				break;
			case 16u:
				CurLevel = input.ReadUInt32();
				break;
			case 24u:
				LevelExp = input.ReadUInt32();
				break;
			case 32u:
				BuyLevelCost = input.ReadUInt32();
				break;
			case 40u:
				CurHp = input.ReadUInt32();
				break;
			case 48u:
				MaxAvatarNum = input.ReadUInt32();
				break;
			case 56u:
				ComboNum = input.ReadUInt32();
				break;
			case 64u:
				LockType = input.ReadUInt32();
				break;
			case 72u:
				LockReason = input.ReadUInt32();
				break;
			case 80u:
				MaxInterest = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				trackingTraits_.AddEntriesFrom(ref input, _repeated_trackingTraits_codec);
				break;
			case 98u:
				trackingEquipments_.AddEntriesFrom(ref input, _repeated_trackingEquipments_codec);
				break;
			case 106u:
				GuideCode = input.ReadString();
				break;
			case 112u:
				MaxLevel = input.ReadUInt32();
				break;
			case 120u:
				OffFieldAvatarNum = input.ReadUInt32();
				break;
			}
		}
	}
}
