using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CurChallenge : IMessage<CurChallenge>, IMessage, IEquatable<CurChallenge>, IDeepCloneable<CurChallenge>, IBufferMessage
{
	private static readonly MessageParser<CurChallenge> _parser = new MessageParser<CurChallenge>(() => new CurChallenge());

	private UnknownFieldSet _unknownFields;

	public const int RoundCountFieldNumber = 1;

	private uint roundCount_;

	public const int StageInfoFieldNumber = 2;

	private ChallengeCurBuffInfo stageInfo_;

	public const int ExtraLineupTypeFieldNumber = 4;

	private ExtraLineupType extraLineupType_;

	public const int ScoreIdFieldNumber = 5;

	private uint scoreId_;

	public const int KillMonsterListFieldNumber = 7;

	private static readonly FieldCodec<KillMonster> _repeated_killMonsterList_codec = FieldCodec.ForMessage(58u, KillMonster.Parser);

	private readonly RepeatedField<KillMonster> killMonsterList_ = new RepeatedField<KillMonster>();

	public const int StatusFieldNumber = 8;

	private ChallengeStatus status_;

	public const int ChallengeIdFieldNumber = 9;

	private uint challengeId_;

	public const int DeadAvatarNumFieldNumber = 10;

	private uint deadAvatarNum_;

	public const int ScoreTwoFieldNumber = 13;

	private uint scoreTwo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CurChallenge> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CurChallengeReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoundCount
	{
		get
		{
			return roundCount_;
		}
		set
		{
			roundCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeCurBuffInfo StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
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
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KillMonster> KillMonsterList => killMonsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeId
	{
		get
		{
			return challengeId_;
		}
		set
		{
			challengeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DeadAvatarNum
	{
		get
		{
			return deadAvatarNum_;
		}
		set
		{
			deadAvatarNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreTwo
	{
		get
		{
			return scoreTwo_;
		}
		set
		{
			scoreTwo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurChallenge()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurChallenge(CurChallenge other)
		: this()
	{
		roundCount_ = other.roundCount_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		extraLineupType_ = other.extraLineupType_;
		scoreId_ = other.scoreId_;
		killMonsterList_ = other.killMonsterList_.Clone();
		status_ = other.status_;
		challengeId_ = other.challengeId_;
		deadAvatarNum_ = other.deadAvatarNum_;
		scoreTwo_ = other.scoreTwo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurChallenge Clone()
	{
		return new CurChallenge(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CurChallenge);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CurChallenge other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoundCount != other.RoundCount)
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (ExtraLineupType != other.ExtraLineupType)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!killMonsterList_.Equals(other.killMonsterList_))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (DeadAvatarNum != other.DeadAvatarNum)
		{
			return false;
		}
		if (ScoreTwo != other.ScoreTwo)
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
		if (RoundCount != 0)
		{
			num ^= RoundCount.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num ^= ExtraLineupType.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		num ^= killMonsterList_.GetHashCode();
		if (Status != ChallengeStatus.ChallengeUnknown)
		{
			num ^= Status.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (DeadAvatarNum != 0)
		{
			num ^= DeadAvatarNum.GetHashCode();
		}
		if (ScoreTwo != 0)
		{
			num ^= ScoreTwo.GetHashCode();
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
		if (RoundCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(RoundCount);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(StageInfo);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ExtraLineupType);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ScoreId);
		}
		killMonsterList_.WriteTo(ref output, _repeated_killMonsterList_codec);
		if (Status != ChallengeStatus.ChallengeUnknown)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Status);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ChallengeId);
		}
		if (DeadAvatarNum != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DeadAvatarNum);
		}
		if (ScoreTwo != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ScoreTwo);
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
		if (RoundCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundCount);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExtraLineupType);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		num += killMonsterList_.CalculateSize(_repeated_killMonsterList_codec);
		if (Status != ChallengeStatus.ChallengeUnknown)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (DeadAvatarNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DeadAvatarNum);
		}
		if (ScoreTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreTwo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CurChallenge other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoundCount != 0)
		{
			RoundCount = other.RoundCount;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new ChallengeCurBuffInfo();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		if (other.ExtraLineupType != ExtraLineupType.LineupNone)
		{
			ExtraLineupType = other.ExtraLineupType;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		killMonsterList_.Add(other.killMonsterList_);
		if (other.Status != ChallengeStatus.ChallengeUnknown)
		{
			Status = other.Status;
		}
		if (other.ChallengeId != 0)
		{
			ChallengeId = other.ChallengeId;
		}
		if (other.DeadAvatarNum != 0)
		{
			DeadAvatarNum = other.DeadAvatarNum;
		}
		if (other.ScoreTwo != 0)
		{
			ScoreTwo = other.ScoreTwo;
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
				RoundCount = input.ReadUInt32();
				break;
			case 18u:
				if (stageInfo_ == null)
				{
					StageInfo = new ChallengeCurBuffInfo();
				}
				input.ReadMessage(StageInfo);
				break;
			case 32u:
				ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				break;
			case 40u:
				ScoreId = input.ReadUInt32();
				break;
			case 58u:
				killMonsterList_.AddEntriesFrom(ref input, _repeated_killMonsterList_codec);
				break;
			case 64u:
				Status = (ChallengeStatus)input.ReadEnum();
				break;
			case 72u:
				ChallengeId = input.ReadUInt32();
				break;
			case 80u:
				DeadAvatarNum = input.ReadUInt32();
				break;
			case 104u:
				ScoreTwo = input.ReadUInt32();
				break;
			}
		}
	}
}
