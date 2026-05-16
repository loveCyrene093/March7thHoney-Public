using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossDataPb : IMessage<ChallengeBossDataPb>, IMessage, IEquatable<ChallengeBossDataPb>, IDeepCloneable<ChallengeBossDataPb>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossDataPb> _parser = new MessageParser<ChallengeBossDataPb>(() => new ChallengeBossDataPb());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeMazeIdFieldNumber = 1;

	private uint challengeMazeId_;

	public const int StartPosFieldNumber = 2;

	private Vector3Pb startPos_;

	public const int StartRotFieldNumber = 3;

	private Vector3Pb startRot_;

	public const int CurrentStageFieldNumber = 4;

	private uint currentStage_;

	public const int CurStatusFieldNumber = 5;

	private uint curStatus_;

	public const int SavedMpFieldNumber = 6;

	private uint savedMp_;

	public const int CurrentExtraLineupFieldNumber = 7;

	private ChallengeLineupTypePb currentExtraLineup_;

	public const int StarsFieldNumber = 8;

	private uint stars_;

	public const int ScoreStage1FieldNumber = 9;

	private uint scoreStage1_;

	public const int ScoreStage2FieldNumber = 10;

	private uint scoreStage2_;

	public const int BuffsFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_buffs_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> buffs_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossDataPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeDataReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeMazeId
	{
		get
		{
			return challengeMazeId_;
		}
		set
		{
			challengeMazeId_ = value;
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
	public uint CurrentStage
	{
		get
		{
			return currentStage_;
		}
		set
		{
			currentStage_ = value;
		}
	}

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
	public uint ScoreStage1
	{
		get
		{
			return scoreStage1_;
		}
		set
		{
			scoreStage1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreStage2
	{
		get
		{
			return scoreStage2_;
		}
		set
		{
			scoreStage2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> Buffs => buffs_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossDataPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossDataPb(ChallengeBossDataPb other)
		: this()
	{
		challengeMazeId_ = other.challengeMazeId_;
		startPos_ = ((other.startPos_ != null) ? other.startPos_.Clone() : null);
		startRot_ = ((other.startRot_ != null) ? other.startRot_.Clone() : null);
		currentStage_ = other.currentStage_;
		curStatus_ = other.curStatus_;
		savedMp_ = other.savedMp_;
		currentExtraLineup_ = other.currentExtraLineup_;
		stars_ = other.stars_;
		scoreStage1_ = other.scoreStage1_;
		scoreStage2_ = other.scoreStage2_;
		buffs_ = other.buffs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossDataPb Clone()
	{
		return new ChallengeBossDataPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossDataPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossDataPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChallengeMazeId != other.ChallengeMazeId)
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
		if (CurrentStage != other.CurrentStage)
		{
			return false;
		}
		if (CurStatus != other.CurStatus)
		{
			return false;
		}
		if (SavedMp != other.SavedMp)
		{
			return false;
		}
		if (CurrentExtraLineup != other.CurrentExtraLineup)
		{
			return false;
		}
		if (Stars != other.Stars)
		{
			return false;
		}
		if (ScoreStage1 != other.ScoreStage1)
		{
			return false;
		}
		if (ScoreStage2 != other.ScoreStage2)
		{
			return false;
		}
		if (!buffs_.Equals(other.buffs_))
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
		if (ChallengeMazeId != 0)
		{
			num ^= ChallengeMazeId.GetHashCode();
		}
		if (startPos_ != null)
		{
			num ^= StartPos.GetHashCode();
		}
		if (startRot_ != null)
		{
			num ^= StartRot.GetHashCode();
		}
		if (CurrentStage != 0)
		{
			num ^= CurrentStage.GetHashCode();
		}
		if (CurStatus != 0)
		{
			num ^= CurStatus.GetHashCode();
		}
		if (SavedMp != 0)
		{
			num ^= SavedMp.GetHashCode();
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			num ^= CurrentExtraLineup.GetHashCode();
		}
		if (Stars != 0)
		{
			num ^= Stars.GetHashCode();
		}
		if (ScoreStage1 != 0)
		{
			num ^= ScoreStage1.GetHashCode();
		}
		if (ScoreStage2 != 0)
		{
			num ^= ScoreStage2.GetHashCode();
		}
		num ^= buffs_.GetHashCode();
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
		if (ChallengeMazeId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ChallengeMazeId);
		}
		if (startPos_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(StartPos);
		}
		if (startRot_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(StartRot);
		}
		if (CurrentStage != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CurrentStage);
		}
		if (CurStatus != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CurStatus);
		}
		if (SavedMp != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(SavedMp);
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)CurrentExtraLineup);
		}
		if (Stars != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Stars);
		}
		if (ScoreStage1 != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ScoreStage1);
		}
		if (ScoreStage2 != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ScoreStage2);
		}
		buffs_.WriteTo(ref output, _repeated_buffs_codec);
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
		if (ChallengeMazeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeMazeId);
		}
		if (startPos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StartPos);
		}
		if (startRot_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StartRot);
		}
		if (CurrentStage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurrentStage);
		}
		if (CurStatus != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurStatus);
		}
		if (SavedMp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SavedMp);
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurrentExtraLineup);
		}
		if (Stars != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stars);
		}
		if (ScoreStage1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreStage1);
		}
		if (ScoreStage2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreStage2);
		}
		num += buffs_.CalculateSize(_repeated_buffs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossDataPb other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ChallengeMazeId != 0)
		{
			ChallengeMazeId = other.ChallengeMazeId;
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
		if (other.CurrentStage != 0)
		{
			CurrentStage = other.CurrentStage;
		}
		if (other.CurStatus != 0)
		{
			CurStatus = other.CurStatus;
		}
		if (other.SavedMp != 0)
		{
			SavedMp = other.SavedMp;
		}
		if (other.CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			CurrentExtraLineup = other.CurrentExtraLineup;
		}
		if (other.Stars != 0)
		{
			Stars = other.Stars;
		}
		if (other.ScoreStage1 != 0)
		{
			ScoreStage1 = other.ScoreStage1;
		}
		if (other.ScoreStage2 != 0)
		{
			ScoreStage2 = other.ScoreStage2;
		}
		buffs_.Add(other.buffs_);
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
				ChallengeMazeId = input.ReadUInt32();
				break;
			case 18u:
				if (startPos_ == null)
				{
					StartPos = new Vector3Pb();
				}
				input.ReadMessage(StartPos);
				break;
			case 26u:
				if (startRot_ == null)
				{
					StartRot = new Vector3Pb();
				}
				input.ReadMessage(StartRot);
				break;
			case 32u:
				CurrentStage = input.ReadUInt32();
				break;
			case 40u:
				CurStatus = input.ReadUInt32();
				break;
			case 48u:
				SavedMp = input.ReadUInt32();
				break;
			case 56u:
				CurrentExtraLineup = (ChallengeLineupTypePb)input.ReadEnum();
				break;
			case 64u:
				Stars = input.ReadUInt32();
				break;
			case 72u:
				ScoreStage1 = input.ReadUInt32();
				break;
			case 80u:
				ScoreStage2 = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				buffs_.AddEntriesFrom(ref input, _repeated_buffs_codec);
				break;
			}
		}
	}
}
