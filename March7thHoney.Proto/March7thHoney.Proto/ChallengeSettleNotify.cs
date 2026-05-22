using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeSettleNotify : IMessage<ChallengeSettleNotify>, IMessage, IEquatable<ChallengeSettleNotify>, IDeepCloneable<ChallengeSettleNotify>, IBufferMessage
{
	private static readonly MessageParser<ChallengeSettleNotify> _parser = new MessageParser<ChallengeSettleNotify>(() => new ChallengeSettleNotify());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeIdFieldNumber = 1;

	private uint challengeId_;

	public const int MHAPIHCJPJMFieldNumber = 2;

	private uint mHAPIHCJPJM_;

	public const int StarFieldNumber = 4;

	private uint star_;

	public const int EACKNOAFICFFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_eACKNOAFICF_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> eACKNOAFICF_ = new RepeatedField<uint>();

	public const int RewardFieldNumber = 10;

	private ItemList reward_;

	public const int CurChallengeFieldNumber = 11;

	private CurChallenge curChallenge_;

	public const int IsWinFieldNumber = 12;

	private bool isWin_;

	public const int MaxLevelFieldNumber = 13;

	private ChallengeHistoryMaxLevel maxLevel_;

	public const int ChallengeScoreFieldNumber = 14;

	private uint challengeScore_;

	public const int ScoreTwoFieldNumber = 15;

	private uint scoreTwo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeSettleNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeSettleNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MHAPIHCJPJM
	{
		get
		{
			return mHAPIHCJPJM_;
		}
		set
		{
			mHAPIHCJPJM_ = value;
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
	public RepeatedField<uint> EACKNOAFICF => eACKNOAFICF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurChallenge CurChallenge
	{
		get
		{
			return curChallenge_;
		}
		set
		{
			curChallenge_ = value;
		}
	}

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
	public ChallengeHistoryMaxLevel MaxLevel
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
	public ChallengeSettleNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeSettleNotify(ChallengeSettleNotify other)
		: this()
	{
		challengeId_ = other.challengeId_;
		mHAPIHCJPJM_ = other.mHAPIHCJPJM_;
		star_ = other.star_;
		eACKNOAFICF_ = other.eACKNOAFICF_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
		isWin_ = other.isWin_;
		maxLevel_ = ((other.maxLevel_ != null) ? other.maxLevel_.Clone() : null);
		challengeScore_ = other.challengeScore_;
		scoreTwo_ = other.scoreTwo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeSettleNotify Clone()
	{
		return new ChallengeSettleNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeSettleNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeSettleNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (MHAPIHCJPJM != other.MHAPIHCJPJM)
		{
			return false;
		}
		if (Star != other.Star)
		{
			return false;
		}
		if (!eACKNOAFICF_.Equals(other.eACKNOAFICF_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!object.Equals(CurChallenge, other.CurChallenge))
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (!object.Equals(MaxLevel, other.MaxLevel))
		{
			return false;
		}
		if (ChallengeScore != other.ChallengeScore)
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
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (MHAPIHCJPJM != 0)
		{
			num ^= MHAPIHCJPJM.GetHashCode();
		}
		if (Star != 0)
		{
			num ^= Star.GetHashCode();
		}
		num ^= eACKNOAFICF_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (curChallenge_ != null)
		{
			num ^= CurChallenge.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (maxLevel_ != null)
		{
			num ^= MaxLevel.GetHashCode();
		}
		if (ChallengeScore != 0)
		{
			num ^= ChallengeScore.GetHashCode();
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
		if (ChallengeId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ChallengeId);
		}
		if (MHAPIHCJPJM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MHAPIHCJPJM);
		}
		if (Star != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Star);
		}
		eACKNOAFICF_.WriteTo(ref output, _repeated_eACKNOAFICF_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Reward);
		}
		if (curChallenge_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CurChallenge);
		}
		if (IsWin)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsWin);
		}
		if (maxLevel_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(MaxLevel);
		}
		if (ChallengeScore != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ChallengeScore);
		}
		if (ScoreTwo != 0)
		{
			output.WriteRawTag(120);
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
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (MHAPIHCJPJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHAPIHCJPJM);
		}
		if (Star != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Star);
		}
		num += eACKNOAFICF_.CalculateSize(_repeated_eACKNOAFICF_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (curChallenge_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurChallenge);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (maxLevel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MaxLevel);
		}
		if (ChallengeScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeScore);
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
	public void MergeFrom(ChallengeSettleNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ChallengeId != 0)
		{
			ChallengeId = other.ChallengeId;
		}
		if (other.MHAPIHCJPJM != 0)
		{
			MHAPIHCJPJM = other.MHAPIHCJPJM;
		}
		if (other.Star != 0)
		{
			Star = other.Star;
		}
		eACKNOAFICF_.Add(other.eACKNOAFICF_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.curChallenge_ != null)
		{
			if (curChallenge_ == null)
			{
				CurChallenge = new CurChallenge();
			}
			CurChallenge.MergeFrom(other.CurChallenge);
		}
		if (other.IsWin)
		{
			IsWin = other.IsWin;
		}
		if (other.maxLevel_ != null)
		{
			if (maxLevel_ == null)
			{
				MaxLevel = new ChallengeHistoryMaxLevel();
			}
			MaxLevel.MergeFrom(other.MaxLevel);
		}
		if (other.ChallengeScore != 0)
		{
			ChallengeScore = other.ChallengeScore;
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
				ChallengeId = input.ReadUInt32();
				break;
			case 16u:
				MHAPIHCJPJM = input.ReadUInt32();
				break;
			case 32u:
				Star = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				eACKNOAFICF_.AddEntriesFrom(ref input, _repeated_eACKNOAFICF_codec);
				break;
			case 82u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 90u:
				if (curChallenge_ == null)
				{
					CurChallenge = new CurChallenge();
				}
				input.ReadMessage(CurChallenge);
				break;
			case 96u:
				IsWin = input.ReadBool();
				break;
			case 106u:
				if (maxLevel_ == null)
				{
					MaxLevel = new ChallengeHistoryMaxLevel();
				}
				input.ReadMessage(MaxLevel);
				break;
			case 112u:
				ChallengeScore = input.ReadUInt32();
				break;
			case 120u:
				ScoreTwo = input.ReadUInt32();
				break;
			}
		}
	}
}
