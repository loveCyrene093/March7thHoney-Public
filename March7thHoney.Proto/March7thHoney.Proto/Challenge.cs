using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Challenge : IMessage<Challenge>, IMessage, IEquatable<Challenge>, IDeepCloneable<Challenge>, IBufferMessage
{
	private static readonly MessageParser<Challenge> _parser = new MessageParser<Challenge>(() => new Challenge());

	private UnknownFieldSet _unknownFields;

	public const int ScoreTwoFieldNumber = 1;

	private uint scoreTwo_;

	public const int DIOHKMPPKHAFieldNumber = 2;

	private bool dIOHKMPPKHA_;

	public const int RecordIdFieldNumber = 5;

	private uint recordId_;

	public const int TakenRewardFieldNumber = 6;

	private uint takenReward_;

	public const int ScoreIdFieldNumber = 8;

	private uint scoreId_;

	public const int ChallengeIdFieldNumber = 9;

	private uint challengeId_;

	public const int StageInfoFieldNumber = 10;

	private ChallengeStageInfo stageInfo_;

	public const int StarFieldNumber = 14;

	private uint star_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Challenge> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool DIOHKMPPKHA
	{
		get
		{
			return dIOHKMPPKHA_;
		}
		set
		{
			dIOHKMPPKHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RecordId
	{
		get
		{
			return recordId_;
		}
		set
		{
			recordId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TakenReward
	{
		get
		{
			return takenReward_;
		}
		set
		{
			takenReward_ = value;
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
	public ChallengeStageInfo StageInfo
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
	public Challenge()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Challenge(Challenge other)
		: this()
	{
		scoreTwo_ = other.scoreTwo_;
		dIOHKMPPKHA_ = other.dIOHKMPPKHA_;
		recordId_ = other.recordId_;
		takenReward_ = other.takenReward_;
		scoreId_ = other.scoreId_;
		challengeId_ = other.challengeId_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		star_ = other.star_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Challenge Clone()
	{
		return new Challenge(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Challenge);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Challenge other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreTwo != other.ScoreTwo)
		{
			return false;
		}
		if (DIOHKMPPKHA != other.DIOHKMPPKHA)
		{
			return false;
		}
		if (RecordId != other.RecordId)
		{
			return false;
		}
		if (TakenReward != other.TakenReward)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (Star != other.Star)
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
		if (ScoreTwo != 0)
		{
			num ^= ScoreTwo.GetHashCode();
		}
		if (DIOHKMPPKHA)
		{
			num ^= DIOHKMPPKHA.GetHashCode();
		}
		if (RecordId != 0)
		{
			num ^= RecordId.GetHashCode();
		}
		if (TakenReward != 0)
		{
			num ^= TakenReward.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (Star != 0)
		{
			num ^= Star.GetHashCode();
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
		if (ScoreTwo != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ScoreTwo);
		}
		if (DIOHKMPPKHA)
		{
			output.WriteRawTag(16);
			output.WriteBool(DIOHKMPPKHA);
		}
		if (RecordId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(RecordId);
		}
		if (TakenReward != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(TakenReward);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ScoreId);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ChallengeId);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(StageInfo);
		}
		if (Star != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Star);
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
		if (ScoreTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreTwo);
		}
		if (DIOHKMPPKHA)
		{
			num += 2;
		}
		if (RecordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecordId);
		}
		if (TakenReward != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TakenReward);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (Star != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Star);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Challenge other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ScoreTwo != 0)
		{
			ScoreTwo = other.ScoreTwo;
		}
		if (other.DIOHKMPPKHA)
		{
			DIOHKMPPKHA = other.DIOHKMPPKHA;
		}
		if (other.RecordId != 0)
		{
			RecordId = other.RecordId;
		}
		if (other.TakenReward != 0)
		{
			TakenReward = other.TakenReward;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.ChallengeId != 0)
		{
			ChallengeId = other.ChallengeId;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new ChallengeStageInfo();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		if (other.Star != 0)
		{
			Star = other.Star;
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
				ScoreTwo = input.ReadUInt32();
				break;
			case 16u:
				DIOHKMPPKHA = input.ReadBool();
				break;
			case 40u:
				RecordId = input.ReadUInt32();
				break;
			case 48u:
				TakenReward = input.ReadUInt32();
				break;
			case 64u:
				ScoreId = input.ReadUInt32();
				break;
			case 72u:
				ChallengeId = input.ReadUInt32();
				break;
			case 82u:
				if (stageInfo_ == null)
				{
					StageInfo = new ChallengeStageInfo();
				}
				input.ReadMessage(StageInfo);
				break;
			case 112u:
				Star = input.ReadUInt32();
				break;
			}
		}
	}
}
