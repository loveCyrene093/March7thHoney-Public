using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeMemoryDataPb : IMessage<ChallengeMemoryDataPb>, IMessage, IEquatable<ChallengeMemoryDataPb>, IDeepCloneable<ChallengeMemoryDataPb>, IBufferMessage
{
	private static readonly MessageParser<ChallengeMemoryDataPb> _parser = new MessageParser<ChallengeMemoryDataPb>(() => new ChallengeMemoryDataPb());

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

	public const int DeadAvatarNumFieldNumber = 6;

	private uint deadAvatarNum_;

	public const int SavedMpFieldNumber = 7;

	private uint savedMp_;

	public const int CurrentExtraLineupFieldNumber = 8;

	private ChallengeLineupTypePb currentExtraLineup_;

	public const int RoundsLeftFieldNumber = 9;

	private uint roundsLeft_;

	public const int StarsFieldNumber = 10;

	private uint stars_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeMemoryDataPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeDataReflection.Descriptor.MessageTypes[1];

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
	public uint RoundsLeft
	{
		get
		{
			return roundsLeft_;
		}
		set
		{
			roundsLeft_ = value;
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
	public ChallengeMemoryDataPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeMemoryDataPb(ChallengeMemoryDataPb other)
		: this()
	{
		challengeMazeId_ = other.challengeMazeId_;
		startPos_ = ((other.startPos_ != null) ? other.startPos_.Clone() : null);
		startRot_ = ((other.startRot_ != null) ? other.startRot_.Clone() : null);
		currentStage_ = other.currentStage_;
		curStatus_ = other.curStatus_;
		deadAvatarNum_ = other.deadAvatarNum_;
		savedMp_ = other.savedMp_;
		currentExtraLineup_ = other.currentExtraLineup_;
		roundsLeft_ = other.roundsLeft_;
		stars_ = other.stars_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeMemoryDataPb Clone()
	{
		return new ChallengeMemoryDataPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeMemoryDataPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeMemoryDataPb other)
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
		if (DeadAvatarNum != other.DeadAvatarNum)
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
		if (RoundsLeft != other.RoundsLeft)
		{
			return false;
		}
		if (Stars != other.Stars)
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
		if (DeadAvatarNum != 0)
		{
			num ^= DeadAvatarNum.GetHashCode();
		}
		if (SavedMp != 0)
		{
			num ^= SavedMp.GetHashCode();
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			num ^= CurrentExtraLineup.GetHashCode();
		}
		if (RoundsLeft != 0)
		{
			num ^= RoundsLeft.GetHashCode();
		}
		if (Stars != 0)
		{
			num ^= Stars.GetHashCode();
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
		if (DeadAvatarNum != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DeadAvatarNum);
		}
		if (SavedMp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SavedMp);
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)CurrentExtraLineup);
		}
		if (RoundsLeft != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RoundsLeft);
		}
		if (Stars != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Stars);
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
		if (DeadAvatarNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DeadAvatarNum);
		}
		if (SavedMp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SavedMp);
		}
		if (CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurrentExtraLineup);
		}
		if (RoundsLeft != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundsLeft);
		}
		if (Stars != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stars);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeMemoryDataPb other)
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
		if (other.DeadAvatarNum != 0)
		{
			DeadAvatarNum = other.DeadAvatarNum;
		}
		if (other.SavedMp != 0)
		{
			SavedMp = other.SavedMp;
		}
		if (other.CurrentExtraLineup != ChallengeLineupTypePb.None)
		{
			CurrentExtraLineup = other.CurrentExtraLineup;
		}
		if (other.RoundsLeft != 0)
		{
			RoundsLeft = other.RoundsLeft;
		}
		if (other.Stars != 0)
		{
			Stars = other.Stars;
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
				DeadAvatarNum = input.ReadUInt32();
				break;
			case 56u:
				SavedMp = input.ReadUInt32();
				break;
			case 64u:
				CurrentExtraLineup = (ChallengeLineupTypePb)input.ReadEnum();
				break;
			case 72u:
				RoundsLeft = input.ReadUInt32();
				break;
			case 80u:
				Stars = input.ReadUInt32();
				break;
			}
		}
	}
}
