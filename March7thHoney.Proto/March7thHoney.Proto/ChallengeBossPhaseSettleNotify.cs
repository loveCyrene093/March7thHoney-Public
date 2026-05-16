using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossPhaseSettleNotify : IMessage<ChallengeBossPhaseSettleNotify>, IMessage, IEquatable<ChallengeBossPhaseSettleNotify>, IDeepCloneable<ChallengeBossPhaseSettleNotify>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossPhaseSettleNotify> _parser = new MessageParser<ChallengeBossPhaseSettleNotify>(() => new ChallengeBossPhaseSettleNotify());

	private UnknownFieldSet _unknownFields;

	public const int IsRewardFieldNumber = 1;

	private bool isReward_;

	public const int StarFieldNumber = 3;

	private uint star_;

	public const int IsSecondHalfFieldNumber = 4;

	private bool isSecondHalf_;

	public const int PhaseFieldNumber = 6;

	private uint phase_;

	public const int ChallengeIdFieldNumber = 7;

	private uint challengeId_;

	public const int PageTypeFieldNumber = 8;

	private uint pageType_;

	public const int ScoreTwoFieldNumber = 10;

	private uint scoreTwo_;

	public const int BattleTargetListFieldNumber = 11;

	private static readonly FieldCodec<BattleTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage(90u, BattleTarget.Parser);

	private readonly RepeatedField<BattleTarget> battleTargetList_ = new RepeatedField<BattleTarget>();

	public const int IsWinFieldNumber = 13;

	private bool isWin_;

	public const int ChallengeScoreFieldNumber = 15;

	private uint challengeScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossPhaseSettleNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossPhaseSettleNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsReward
	{
		get
		{
			return isReward_;
		}
		set
		{
			isReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Star
	{
		get
		{
			return star_;
		}
		set
		{
			star_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSecondHalf
	{
		get
		{
			return isSecondHalf_;
		}
		set
		{
			isSecondHalf_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Phase
	{
		get
		{
			return phase_;
		}
		set
		{
			phase_ = value;
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
	public uint PageType
	{
		get
		{
			return pageType_;
		}
		set
		{
			pageType_ = value;
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
	public RepeatedField<BattleTarget> BattleTargetList => battleTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeScore
	{
		get
		{
			return challengeScore_;
		}
		set
		{
			challengeScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossPhaseSettleNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossPhaseSettleNotify(ChallengeBossPhaseSettleNotify other)
		: this()
	{
		isReward_ = other.isReward_;
		star_ = other.star_;
		isSecondHalf_ = other.isSecondHalf_;
		phase_ = other.phase_;
		challengeId_ = other.challengeId_;
		pageType_ = other.pageType_;
		scoreTwo_ = other.scoreTwo_;
		battleTargetList_ = other.battleTargetList_.Clone();
		isWin_ = other.isWin_;
		challengeScore_ = other.challengeScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossPhaseSettleNotify Clone()
	{
		return new ChallengeBossPhaseSettleNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossPhaseSettleNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossPhaseSettleNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsReward != other.IsReward)
		{
			return false;
		}
		if (Star != other.Star)
		{
			return false;
		}
		if (IsSecondHalf != other.IsSecondHalf)
		{
			return false;
		}
		if (Phase != other.Phase)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (PageType != other.PageType)
		{
			return false;
		}
		if (ScoreTwo != other.ScoreTwo)
		{
			return false;
		}
		if (!battleTargetList_.Equals(other.battleTargetList_))
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (ChallengeScore != other.ChallengeScore)
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
		if (IsReward)
		{
			num ^= IsReward.GetHashCode();
		}
		if (Star != 0)
		{
			num ^= Star.GetHashCode();
		}
		if (IsSecondHalf)
		{
			num ^= IsSecondHalf.GetHashCode();
		}
		if (Phase != 0)
		{
			num ^= Phase.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (PageType != 0)
		{
			num ^= PageType.GetHashCode();
		}
		if (ScoreTwo != 0)
		{
			num ^= ScoreTwo.GetHashCode();
		}
		num ^= battleTargetList_.GetHashCode();
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (ChallengeScore != 0)
		{
			num ^= ChallengeScore.GetHashCode();
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
		if (IsReward)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsReward);
		}
		if (Star != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Star);
		}
		if (IsSecondHalf)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsSecondHalf);
		}
		if (Phase != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Phase);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ChallengeId);
		}
		if (PageType != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PageType);
		}
		if (ScoreTwo != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ScoreTwo);
		}
		battleTargetList_.WriteTo(ref output, _repeated_battleTargetList_codec);
		if (IsWin)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsWin);
		}
		if (ChallengeScore != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ChallengeScore);
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
		if (IsReward)
		{
			num += 2;
		}
		if (Star != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Star);
		}
		if (IsSecondHalf)
		{
			num += 2;
		}
		if (Phase != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Phase);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (PageType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PageType);
		}
		if (ScoreTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreTwo);
		}
		num += battleTargetList_.CalculateSize(_repeated_battleTargetList_codec);
		if (IsWin)
		{
			num += 2;
		}
		if (ChallengeScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossPhaseSettleNotify other)
	{
		if (other != null)
		{
			if (other.IsReward)
			{
				IsReward = other.IsReward;
			}
			if (other.Star != 0)
			{
				Star = other.Star;
			}
			if (other.IsSecondHalf)
			{
				IsSecondHalf = other.IsSecondHalf;
			}
			if (other.Phase != 0)
			{
				Phase = other.Phase;
			}
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.PageType != 0)
			{
				PageType = other.PageType;
			}
			if (other.ScoreTwo != 0)
			{
				ScoreTwo = other.ScoreTwo;
			}
			battleTargetList_.Add(other.battleTargetList_);
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.ChallengeScore != 0)
			{
				ChallengeScore = other.ChallengeScore;
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
				IsReward = input.ReadBool();
				break;
			case 24u:
				Star = input.ReadUInt32();
				break;
			case 32u:
				IsSecondHalf = input.ReadBool();
				break;
			case 48u:
				Phase = input.ReadUInt32();
				break;
			case 56u:
				ChallengeId = input.ReadUInt32();
				break;
			case 64u:
				PageType = input.ReadUInt32();
				break;
			case 80u:
				ScoreTwo = input.ReadUInt32();
				break;
			case 90u:
				battleTargetList_.AddEntriesFrom(ref input, _repeated_battleTargetList_codec);
				break;
			case 104u:
				IsWin = input.ReadBool();
				break;
			case 120u:
				ChallengeScore = input.ReadUInt32();
				break;
			}
		}
	}
}
