using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameBasicInfo : IMessage<GridFightGameBasicInfo>, IMessage, IEquatable<GridFightGameBasicInfo>, IDeepCloneable<GridFightGameBasicInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameBasicInfo> _parser = new MessageParser<GridFightGameBasicInfo>(() => new GridFightGameBasicInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightLineupMaxHpFieldNumber = 1;

	private uint gridFightLineupMaxHp_;

	public const int LockTypeFieldNumber = 2;

	private GridFightLockType lockType_;

	public const int FLEJPPKLJICFieldNumber = 3;

	private uint fLEJPPKLJIC_;

	public const int GoldFieldNumber = 4;

	private uint gold_;

	public const int HAEOPKELNEOFieldNumber = 5;

	private uint hAEOPKELNEO_;

	public const int GridFightMaxAvatarCountFieldNumber = 6;

	private uint gridFightMaxAvatarCount_;

	public const int GridFightCurLevelExpFieldNumber = 7;

	private uint gridFightCurLevelExp_;

	public const int TrackTraitIdListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_trackTraitIdList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> trackTraitIdList_ = new RepeatedField<uint>();

	public const int GridFightBuyExpCostFieldNumber = 9;

	private uint gridFightBuyExpCost_;

	public const int RoleTrackEquipmentListFieldNumber = 10;

	private static readonly FieldCodec<RoleTrackEquipmentInfo> _repeated_roleTrackEquipmentList_codec = FieldCodec.ForMessage(82u, RoleTrackEquipmentInfo.Parser);

	private readonly RepeatedField<RoleTrackEquipmentInfo> roleTrackEquipmentList_ = new RepeatedField<RoleTrackEquipmentInfo>();

	public const int GridFightMaxInterestGoldFieldNumber = 11;

	private uint gridFightMaxInterestGold_;

	public const int GridFightLineupHpFieldNumber = 12;

	private uint gridFightLineupHp_;

	public const int ANBBPPHBCJHFieldNumber = 13;

	private uint aNBBPPHBCJH_;

	public const int GridFightComboWinNumFieldNumber = 14;

	private uint gridFightComboWinNum_;

	public const int GridFightOffFieldMaxCountFieldNumber = 15;

	private uint gridFightOffFieldMaxCount_;

	public const int GameLockInfoFieldNumber = 292;

	private GridFightLockInfo gameLockInfo_;

	public const int GridFightTargetGuideCodeFieldNumber = 334;

	private string gridFightTargetGuideCode_ = "";

	public const int GridFightSyncCurtaskInfoFieldNumber = 542;

	private GridFightSyncCurrentTaskInfo gridFightSyncCurtaskInfo_;

	public const int TutorialUnlockIdListFieldNumber = 1741;

	private static readonly FieldCodec<uint> _repeated_tutorialUnlockIdList_codec = FieldCodec.ForUInt32(13930u);

	private readonly RepeatedField<uint> tutorialUnlockIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameBasicInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameBasicInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightLineupMaxHp
	{
		get
		{
			return gridFightLineupMaxHp_;
		}
		set
		{
			gridFightLineupMaxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockType LockType
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
	public uint FLEJPPKLJIC
	{
		get
		{
			return fLEJPPKLJIC_;
		}
		set
		{
			fLEJPPKLJIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAEOPKELNEO
	{
		get
		{
			return hAEOPKELNEO_;
		}
		set
		{
			hAEOPKELNEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightMaxAvatarCount
	{
		get
		{
			return gridFightMaxAvatarCount_;
		}
		set
		{
			gridFightMaxAvatarCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightCurLevelExp
	{
		get
		{
			return gridFightCurLevelExp_;
		}
		set
		{
			gridFightCurLevelExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TrackTraitIdList => trackTraitIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightBuyExpCost
	{
		get
		{
			return gridFightBuyExpCost_;
		}
		set
		{
			gridFightBuyExpCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RoleTrackEquipmentInfo> RoleTrackEquipmentList => roleTrackEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightMaxInterestGold
	{
		get
		{
			return gridFightMaxInterestGold_;
		}
		set
		{
			gridFightMaxInterestGold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightLineupHp
	{
		get
		{
			return gridFightLineupHp_;
		}
		set
		{
			gridFightLineupHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANBBPPHBCJH
	{
		get
		{
			return aNBBPPHBCJH_;
		}
		set
		{
			aNBBPPHBCJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightComboWinNum
	{
		get
		{
			return gridFightComboWinNum_;
		}
		set
		{
			gridFightComboWinNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightOffFieldMaxCount
	{
		get
		{
			return gridFightOffFieldMaxCount_;
		}
		set
		{
			gridFightOffFieldMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLockInfo GameLockInfo
	{
		get
		{
			return gameLockInfo_;
		}
		set
		{
			gameLockInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GridFightTargetGuideCode
	{
		get
		{
			return gridFightTargetGuideCode_;
		}
		set
		{
			gridFightTargetGuideCode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncCurrentTaskInfo GridFightSyncCurtaskInfo
	{
		get
		{
			return gridFightSyncCurtaskInfo_;
		}
		set
		{
			gridFightSyncCurtaskInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TutorialUnlockIdList => tutorialUnlockIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameBasicInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameBasicInfo(GridFightGameBasicInfo other)
		: this()
	{
		gridFightLineupMaxHp_ = other.gridFightLineupMaxHp_;
		lockType_ = other.lockType_;
		fLEJPPKLJIC_ = other.fLEJPPKLJIC_;
		gold_ = other.gold_;
		hAEOPKELNEO_ = other.hAEOPKELNEO_;
		gridFightMaxAvatarCount_ = other.gridFightMaxAvatarCount_;
		gridFightCurLevelExp_ = other.gridFightCurLevelExp_;
		trackTraitIdList_ = other.trackTraitIdList_.Clone();
		gridFightBuyExpCost_ = other.gridFightBuyExpCost_;
		roleTrackEquipmentList_ = other.roleTrackEquipmentList_.Clone();
		gridFightMaxInterestGold_ = other.gridFightMaxInterestGold_;
		gridFightLineupHp_ = other.gridFightLineupHp_;
		aNBBPPHBCJH_ = other.aNBBPPHBCJH_;
		gridFightComboWinNum_ = other.gridFightComboWinNum_;
		gridFightOffFieldMaxCount_ = other.gridFightOffFieldMaxCount_;
		gameLockInfo_ = ((other.gameLockInfo_ != null) ? other.gameLockInfo_.Clone() : null);
		gridFightTargetGuideCode_ = other.gridFightTargetGuideCode_;
		gridFightSyncCurtaskInfo_ = ((other.gridFightSyncCurtaskInfo_ != null) ? other.gridFightSyncCurtaskInfo_.Clone() : null);
		tutorialUnlockIdList_ = other.tutorialUnlockIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameBasicInfo Clone()
	{
		return new GridFightGameBasicInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameBasicInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameBasicInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GridFightLineupMaxHp != other.GridFightLineupMaxHp)
		{
			return false;
		}
		if (LockType != other.LockType)
		{
			return false;
		}
		if (FLEJPPKLJIC != other.FLEJPPKLJIC)
		{
			return false;
		}
		if (Gold != other.Gold)
		{
			return false;
		}
		if (HAEOPKELNEO != other.HAEOPKELNEO)
		{
			return false;
		}
		if (GridFightMaxAvatarCount != other.GridFightMaxAvatarCount)
		{
			return false;
		}
		if (GridFightCurLevelExp != other.GridFightCurLevelExp)
		{
			return false;
		}
		if (!trackTraitIdList_.Equals(other.trackTraitIdList_))
		{
			return false;
		}
		if (GridFightBuyExpCost != other.GridFightBuyExpCost)
		{
			return false;
		}
		if (!roleTrackEquipmentList_.Equals(other.roleTrackEquipmentList_))
		{
			return false;
		}
		if (GridFightMaxInterestGold != other.GridFightMaxInterestGold)
		{
			return false;
		}
		if (GridFightLineupHp != other.GridFightLineupHp)
		{
			return false;
		}
		if (ANBBPPHBCJH != other.ANBBPPHBCJH)
		{
			return false;
		}
		if (GridFightComboWinNum != other.GridFightComboWinNum)
		{
			return false;
		}
		if (GridFightOffFieldMaxCount != other.GridFightOffFieldMaxCount)
		{
			return false;
		}
		if (!object.Equals(GameLockInfo, other.GameLockInfo))
		{
			return false;
		}
		if (GridFightTargetGuideCode != other.GridFightTargetGuideCode)
		{
			return false;
		}
		if (!object.Equals(GridFightSyncCurtaskInfo, other.GridFightSyncCurtaskInfo))
		{
			return false;
		}
		if (!tutorialUnlockIdList_.Equals(other.tutorialUnlockIdList_))
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
		if (GridFightLineupMaxHp != 0)
		{
			num ^= GridFightLineupMaxHp.GetHashCode();
		}
		if (LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			num ^= LockType.GetHashCode();
		}
		if (FLEJPPKLJIC != 0)
		{
			num ^= FLEJPPKLJIC.GetHashCode();
		}
		if (Gold != 0)
		{
			num ^= Gold.GetHashCode();
		}
		if (HAEOPKELNEO != 0)
		{
			num ^= HAEOPKELNEO.GetHashCode();
		}
		if (GridFightMaxAvatarCount != 0)
		{
			num ^= GridFightMaxAvatarCount.GetHashCode();
		}
		if (GridFightCurLevelExp != 0)
		{
			num ^= GridFightCurLevelExp.GetHashCode();
		}
		num ^= trackTraitIdList_.GetHashCode();
		if (GridFightBuyExpCost != 0)
		{
			num ^= GridFightBuyExpCost.GetHashCode();
		}
		num ^= roleTrackEquipmentList_.GetHashCode();
		if (GridFightMaxInterestGold != 0)
		{
			num ^= GridFightMaxInterestGold.GetHashCode();
		}
		if (GridFightLineupHp != 0)
		{
			num ^= GridFightLineupHp.GetHashCode();
		}
		if (ANBBPPHBCJH != 0)
		{
			num ^= ANBBPPHBCJH.GetHashCode();
		}
		if (GridFightComboWinNum != 0)
		{
			num ^= GridFightComboWinNum.GetHashCode();
		}
		if (GridFightOffFieldMaxCount != 0)
		{
			num ^= GridFightOffFieldMaxCount.GetHashCode();
		}
		if (gameLockInfo_ != null)
		{
			num ^= GameLockInfo.GetHashCode();
		}
		if (GridFightTargetGuideCode.Length != 0)
		{
			num ^= GridFightTargetGuideCode.GetHashCode();
		}
		if (gridFightSyncCurtaskInfo_ != null)
		{
			num ^= GridFightSyncCurtaskInfo.GetHashCode();
		}
		num ^= tutorialUnlockIdList_.GetHashCode();
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
		if (GridFightLineupMaxHp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GridFightLineupMaxHp);
		}
		if (LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)LockType);
		}
		if (FLEJPPKLJIC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FLEJPPKLJIC);
		}
		if (Gold != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Gold);
		}
		if (HAEOPKELNEO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HAEOPKELNEO);
		}
		if (GridFightMaxAvatarCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GridFightMaxAvatarCount);
		}
		if (GridFightCurLevelExp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GridFightCurLevelExp);
		}
		trackTraitIdList_.WriteTo(ref output, _repeated_trackTraitIdList_codec);
		if (GridFightBuyExpCost != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GridFightBuyExpCost);
		}
		roleTrackEquipmentList_.WriteTo(ref output, _repeated_roleTrackEquipmentList_codec);
		if (GridFightMaxInterestGold != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GridFightMaxInterestGold);
		}
		if (GridFightLineupHp != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GridFightLineupHp);
		}
		if (ANBBPPHBCJH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ANBBPPHBCJH);
		}
		if (GridFightComboWinNum != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GridFightComboWinNum);
		}
		if (GridFightOffFieldMaxCount != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GridFightOffFieldMaxCount);
		}
		if (gameLockInfo_ != null)
		{
			output.WriteRawTag(162, 18);
			output.WriteMessage(GameLockInfo);
		}
		if (GridFightTargetGuideCode.Length != 0)
		{
			output.WriteRawTag(242, 20);
			output.WriteString(GridFightTargetGuideCode);
		}
		if (gridFightSyncCurtaskInfo_ != null)
		{
			output.WriteRawTag(242, 33);
			output.WriteMessage(GridFightSyncCurtaskInfo);
		}
		tutorialUnlockIdList_.WriteTo(ref output, _repeated_tutorialUnlockIdList_codec);
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
		if (GridFightLineupMaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightLineupMaxHp);
		}
		if (LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockType);
		}
		if (FLEJPPKLJIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLEJPPKLJIC);
		}
		if (Gold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gold);
		}
		if (HAEOPKELNEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAEOPKELNEO);
		}
		if (GridFightMaxAvatarCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightMaxAvatarCount);
		}
		if (GridFightCurLevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightCurLevelExp);
		}
		num += trackTraitIdList_.CalculateSize(_repeated_trackTraitIdList_codec);
		if (GridFightBuyExpCost != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightBuyExpCost);
		}
		num += roleTrackEquipmentList_.CalculateSize(_repeated_roleTrackEquipmentList_codec);
		if (GridFightMaxInterestGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightMaxInterestGold);
		}
		if (GridFightLineupHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightLineupHp);
		}
		if (ANBBPPHBCJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANBBPPHBCJH);
		}
		if (GridFightComboWinNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightComboWinNum);
		}
		if (GridFightOffFieldMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightOffFieldMaxCount);
		}
		if (gameLockInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GameLockInfo);
		}
		if (GridFightTargetGuideCode.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(GridFightTargetGuideCode);
		}
		if (gridFightSyncCurtaskInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GridFightSyncCurtaskInfo);
		}
		num += tutorialUnlockIdList_.CalculateSize(_repeated_tutorialUnlockIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameBasicInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GridFightLineupMaxHp != 0)
		{
			GridFightLineupMaxHp = other.GridFightLineupMaxHp;
		}
		if (other.LockType != GridFightLockType.PjbmhhnlclbLnloohdeaeo)
		{
			LockType = other.LockType;
		}
		if (other.FLEJPPKLJIC != 0)
		{
			FLEJPPKLJIC = other.FLEJPPKLJIC;
		}
		if (other.Gold != 0)
		{
			Gold = other.Gold;
		}
		if (other.HAEOPKELNEO != 0)
		{
			HAEOPKELNEO = other.HAEOPKELNEO;
		}
		if (other.GridFightMaxAvatarCount != 0)
		{
			GridFightMaxAvatarCount = other.GridFightMaxAvatarCount;
		}
		if (other.GridFightCurLevelExp != 0)
		{
			GridFightCurLevelExp = other.GridFightCurLevelExp;
		}
		trackTraitIdList_.Add(other.trackTraitIdList_);
		if (other.GridFightBuyExpCost != 0)
		{
			GridFightBuyExpCost = other.GridFightBuyExpCost;
		}
		roleTrackEquipmentList_.Add(other.roleTrackEquipmentList_);
		if (other.GridFightMaxInterestGold != 0)
		{
			GridFightMaxInterestGold = other.GridFightMaxInterestGold;
		}
		if (other.GridFightLineupHp != 0)
		{
			GridFightLineupHp = other.GridFightLineupHp;
		}
		if (other.ANBBPPHBCJH != 0)
		{
			ANBBPPHBCJH = other.ANBBPPHBCJH;
		}
		if (other.GridFightComboWinNum != 0)
		{
			GridFightComboWinNum = other.GridFightComboWinNum;
		}
		if (other.GridFightOffFieldMaxCount != 0)
		{
			GridFightOffFieldMaxCount = other.GridFightOffFieldMaxCount;
		}
		if (other.gameLockInfo_ != null)
		{
			if (gameLockInfo_ == null)
			{
				GameLockInfo = new GridFightLockInfo();
			}
			GameLockInfo.MergeFrom(other.GameLockInfo);
		}
		if (other.GridFightTargetGuideCode.Length != 0)
		{
			GridFightTargetGuideCode = other.GridFightTargetGuideCode;
		}
		if (other.gridFightSyncCurtaskInfo_ != null)
		{
			if (gridFightSyncCurtaskInfo_ == null)
			{
				GridFightSyncCurtaskInfo = new GridFightSyncCurrentTaskInfo();
			}
			GridFightSyncCurtaskInfo.MergeFrom(other.GridFightSyncCurtaskInfo);
		}
		tutorialUnlockIdList_.Add(other.tutorialUnlockIdList_);
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
				GridFightLineupMaxHp = input.ReadUInt32();
				break;
			case 16u:
				LockType = (GridFightLockType)input.ReadEnum();
				break;
			case 24u:
				FLEJPPKLJIC = input.ReadUInt32();
				break;
			case 32u:
				Gold = input.ReadUInt32();
				break;
			case 40u:
				HAEOPKELNEO = input.ReadUInt32();
				break;
			case 48u:
				GridFightMaxAvatarCount = input.ReadUInt32();
				break;
			case 56u:
				GridFightCurLevelExp = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				trackTraitIdList_.AddEntriesFrom(ref input, _repeated_trackTraitIdList_codec);
				break;
			case 72u:
				GridFightBuyExpCost = input.ReadUInt32();
				break;
			case 82u:
				roleTrackEquipmentList_.AddEntriesFrom(ref input, _repeated_roleTrackEquipmentList_codec);
				break;
			case 88u:
				GridFightMaxInterestGold = input.ReadUInt32();
				break;
			case 96u:
				GridFightLineupHp = input.ReadUInt32();
				break;
			case 104u:
				ANBBPPHBCJH = input.ReadUInt32();
				break;
			case 112u:
				GridFightComboWinNum = input.ReadUInt32();
				break;
			case 120u:
				GridFightOffFieldMaxCount = input.ReadUInt32();
				break;
			case 2338u:
				if (gameLockInfo_ == null)
				{
					GameLockInfo = new GridFightLockInfo();
				}
				input.ReadMessage(GameLockInfo);
				break;
			case 2674u:
				GridFightTargetGuideCode = input.ReadString();
				break;
			case 4338u:
				if (gridFightSyncCurtaskInfo_ == null)
				{
					GridFightSyncCurtaskInfo = new GridFightSyncCurrentTaskInfo();
				}
				input.ReadMessage(GridFightSyncCurtaskInfo);
				break;
			case 13928u:
			case 13930u:
				tutorialUnlockIdList_.AddEntriesFrom(ref input, _repeated_tutorialUnlockIdList_codec);
				break;
			}
		}
	}
}
