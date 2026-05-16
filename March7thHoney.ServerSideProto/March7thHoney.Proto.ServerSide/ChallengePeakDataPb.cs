using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakDataPb : IMessage<ChallengePeakDataPb>, IMessage, IEquatable<ChallengePeakDataPb>, IDeepCloneable<ChallengePeakDataPb>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakDataPb> _parser = new MessageParser<ChallengePeakDataPb>(() => new ChallengePeakDataPb());

	private UnknownFieldSet _unknownFields;

	public const int CurrentPeakGroupIdFieldNumber = 1;

	private uint currentPeakGroupId_;

	public const int CurrentPeakLevelIdFieldNumber = 2;

	private uint currentPeakLevelId_;

	public const int BuffsFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_buffs_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> buffs_ = new RepeatedField<uint>();

	public const int CurStatusFieldNumber = 4;

	private uint curStatus_;

	public const int StartPosFieldNumber = 5;

	private Vector3Pb startPos_;

	public const int StartRotFieldNumber = 6;

	private Vector3Pb startRot_;

	public const int SavedMpFieldNumber = 7;

	private uint savedMp_;

	public const int StarsFieldNumber = 8;

	private uint stars_;

	public const int CurrentExtraLineupFieldNumber = 9;

	private ChallengeLineupTypePb currentExtraLineup_;

	public const int IsHardFieldNumber = 10;

	private bool isHard_;

	public const int RoundCntFieldNumber = 11;

	private uint roundCnt_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakDataPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeDataReflection.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurrentPeakGroupId
	{
		get
		{
			return currentPeakGroupId_;
		}
		set
		{
			currentPeakGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurrentPeakLevelId
	{
		get
		{
			return currentPeakLevelId_;
		}
		set
		{
			currentPeakLevelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> Buffs => buffs_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurStatus
	{
		get
		{
			return curStatus_;
		}
		set
		{
			curStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector3Pb StartPos
	{
		get
		{
			return startPos_;
		}
		set
		{
			startPos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector3Pb StartRot
	{
		get
		{
			return startRot_;
		}
		set
		{
			startRot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SavedMp
	{
		get
		{
			return savedMp_;
		}
		set
		{
			savedMp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Stars
	{
		get
		{
			return stars_;
		}
		set
		{
			stars_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeLineupTypePb CurrentExtraLineup
	{
		get
		{
			return currentExtraLineup_;
		}
		set
		{
			currentExtraLineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsHard
	{
		get
		{
			return isHard_;
		}
		set
		{
			isHard_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoundCnt
	{
		get
		{
			return roundCnt_;
		}
		set
		{
			roundCnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakDataPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakDataPb(ChallengePeakDataPb other)
		: this()
	{
		currentPeakGroupId_ = other.currentPeakGroupId_;
		currentPeakLevelId_ = other.currentPeakLevelId_;
		buffs_ = other.buffs_.Clone();
		curStatus_ = other.curStatus_;
		startPos_ = ((other.startPos_ != null) ? other.startPos_.Clone() : null);
		startRot_ = ((other.startRot_ != null) ? other.startRot_.Clone() : null);
		savedMp_ = other.savedMp_;
		stars_ = other.stars_;
		currentExtraLineup_ = other.currentExtraLineup_;
		isHard_ = other.isHard_;
		roundCnt_ = other.roundCnt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakDataPb Clone()
	{
		return new ChallengePeakDataPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakDataPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakDataPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurrentPeakGroupId != other.CurrentPeakGroupId)
		{
			return false;
		}
		if (CurrentPeakLevelId != other.CurrentPeakLevelId)
		{
			return false;
		}
		if (!buffs_.Equals(other.buffs_))
		{
			return false;
		}
		if (CurStatus != other.CurStatus)
		{
			return false;
		}
		if (!object.Equals(StartPos, other.StartPos))
		{
			return false;
		}
		if (!object.Equals(StartRot, other.StartRot))
		{
			return false;
		}
		if (SavedMp != other.SavedMp)
		{
			return false;
		}
		if (Stars != other.Stars)
		{
			return false;
		}
		if (CurrentExtraLineup != other.CurrentExtraLineup)
		{
			return false;
		}
		if (IsHard != other.IsHard)
		{
			return false;
		}
		if (RoundCnt != other.RoundCnt)
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
		if (CurrentPeakGroupId != 0)
		{
			num ^= CurrentPeakGroupId.GetHashCode();
		}
		if (CurrentPeakLevelId != 0)
		{
			num ^= CurrentPeakLevelId.GetHashCode();
		}
		num ^= buffs_.GetHashCode();
		if (CurStatus != 0)
		{
			num ^= CurStatus.GetHashCode();
		}
		if (startPos_ != null)
		{
			num ^= StartPos.GetHashCode();
		}
		if (startRot_ != null)
		{
			num ^= StartRot.GetHashCode();
		}
		if (SavedMp != 0)
		{
			num ^= SavedMp.GetHashCode();
		}
		if (Stars != 0)
		{
			num ^= Stars.GetHashCode();
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			num ^= CurrentExtraLineup.GetHashCode();
		}
		if (IsHard)
		{
			num ^= IsHard.GetHashCode();
		}
		if (RoundCnt != 0)
		{
			num ^= RoundCnt.GetHashCode();
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
		if (CurrentPeakGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CurrentPeakGroupId);
		}
		if (CurrentPeakLevelId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CurrentPeakLevelId);
		}
		buffs_.WriteTo(ref output, _repeated_buffs_codec);
		if (CurStatus != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CurStatus);
		}
		if (startPos_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(StartPos);
		}
		if (startRot_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(StartRot);
		}
		if (SavedMp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SavedMp);
		}
		if (Stars != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Stars);
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)CurrentExtraLineup);
		}
		if (IsHard)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsHard);
		}
		if (RoundCnt != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RoundCnt);
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
		if (CurrentPeakGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurrentPeakGroupId);
		}
		if (CurrentPeakLevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurrentPeakLevelId);
		}
		num += buffs_.CalculateSize(_repeated_buffs_codec);
		if (CurStatus != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurStatus);
		}
		if (startPos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StartPos);
		}
		if (startRot_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StartRot);
		}
		if (SavedMp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SavedMp);
		}
		if (Stars != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stars);
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurrentExtraLineup);
		}
		if (IsHard)
		{
			num += 2;
		}
		if (RoundCnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundCnt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakDataPb other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CurrentPeakGroupId != 0)
		{
			CurrentPeakGroupId = other.CurrentPeakGroupId;
		}
		if (other.CurrentPeakLevelId != 0)
		{
			CurrentPeakLevelId = other.CurrentPeakLevelId;
		}
		buffs_.Add(other.buffs_);
		if (other.CurStatus != 0)
		{
			CurStatus = other.CurStatus;
		}
		if (other.startPos_ != null)
		{
			if (startPos_ == null)
			{
				StartPos = new Vector3Pb();
			}
			StartPos.MergeFrom(other.StartPos);
		}
		if (other.startRot_ != null)
		{
			if (startRot_ == null)
			{
				StartRot = new Vector3Pb();
			}
			StartRot.MergeFrom(other.StartRot);
		}
		if (other.SavedMp != 0)
		{
			SavedMp = other.SavedMp;
		}
		if (other.Stars != 0)
		{
			Stars = other.Stars;
		}
		if (other.CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			CurrentExtraLineup = other.CurrentExtraLineup;
		}
		if (other.IsHard)
		{
			IsHard = other.IsHard;
		}
		if (other.RoundCnt != 0)
		{
			RoundCnt = other.RoundCnt;
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				CurrentPeakGroupId = input.ReadUInt32();
				break;
			case 16u:
				CurrentPeakLevelId = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				buffs_.AddEntriesFrom(ref input, _repeated_buffs_codec);
				break;
			case 32u:
				CurStatus = input.ReadUInt32();
				break;
			case 42u:
				if (startPos_ == null)
				{
					StartPos = new Vector3Pb();
				}
				input.ReadMessage(StartPos);
				break;
			case 50u:
				if (startRot_ == null)
				{
					StartRot = new Vector3Pb();
				}
				input.ReadMessage(StartRot);
				break;
			case 56u:
				SavedMp = input.ReadUInt32();
				break;
			case 64u:
				Stars = input.ReadUInt32();
				break;
			case 72u:
				CurrentExtraLineup = (ChallengeLineupTypePb)input.ReadEnum();
				break;
			case 80u:
				IsHard = input.ReadBool();
				break;
			case 88u:
				RoundCnt = input.ReadUInt32();
				break;
			}
		}
	}
}
