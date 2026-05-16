using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightFestUpdateChallengeRecordNotify : IMessage<FightFestUpdateChallengeRecordNotify>, IMessage, IEquatable<FightFestUpdateChallengeRecordNotify>, IDeepCloneable<FightFestUpdateChallengeRecordNotify>, IBufferMessage
{
	private static readonly MessageParser<FightFestUpdateChallengeRecordNotify> _parser = new MessageParser<FightFestUpdateChallengeRecordNotify>(() => new FightFestUpdateChallengeRecordNotify());

	private UnknownFieldSet _unknownFields;

	public const int HEILKBJCAGBFieldNumber = 3;

	private uint hEILKBJCAGB_;

	public const int LJMLNINDHEFFieldNumber = 4;

	private PBOFIBLBPGJ lJMLNINDHEF_;

	public const int RankFieldNumber = 5;

	private PBOFIBLBPGJ rank_;

	public const int ChallengeIdFieldNumber = 6;

	private uint challengeId_;

	public const int TurnLeftFieldNumber = 12;

	private uint turnLeft_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightFestUpdateChallengeRecordNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightFestUpdateChallengeRecordNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEILKBJCAGB
	{
		get
		{
			return hEILKBJCAGB_;
		}
		set
		{
			hEILKBJCAGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBOFIBLBPGJ LJMLNINDHEF
	{
		get
		{
			return lJMLNINDHEF_;
		}
		set
		{
			lJMLNINDHEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBOFIBLBPGJ Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
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
	public uint TurnLeft
	{
		get
		{
			return turnLeft_;
		}
		set
		{
			turnLeft_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestUpdateChallengeRecordNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestUpdateChallengeRecordNotify(FightFestUpdateChallengeRecordNotify other)
		: this()
	{
		hEILKBJCAGB_ = other.hEILKBJCAGB_;
		lJMLNINDHEF_ = other.lJMLNINDHEF_;
		rank_ = other.rank_;
		challengeId_ = other.challengeId_;
		turnLeft_ = other.turnLeft_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestUpdateChallengeRecordNotify Clone()
	{
		return new FightFestUpdateChallengeRecordNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightFestUpdateChallengeRecordNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightFestUpdateChallengeRecordNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HEILKBJCAGB != other.HEILKBJCAGB)
		{
			return false;
		}
		if (LJMLNINDHEF != other.LJMLNINDHEF)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (TurnLeft != other.TurnLeft)
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
		if (HEILKBJCAGB != 0)
		{
			num ^= HEILKBJCAGB.GetHashCode();
		}
		if (LJMLNINDHEF != PBOFIBLBPGJ.Ijljfpkieop)
		{
			num ^= LJMLNINDHEF.GetHashCode();
		}
		if (Rank != PBOFIBLBPGJ.Ijljfpkieop)
		{
			num ^= Rank.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (TurnLeft != 0)
		{
			num ^= TurnLeft.GetHashCode();
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
		if (HEILKBJCAGB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HEILKBJCAGB);
		}
		if (LJMLNINDHEF != PBOFIBLBPGJ.Ijljfpkieop)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)LJMLNINDHEF);
		}
		if (Rank != PBOFIBLBPGJ.Ijljfpkieop)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Rank);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ChallengeId);
		}
		if (TurnLeft != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(TurnLeft);
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
		if (HEILKBJCAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEILKBJCAGB);
		}
		if (LJMLNINDHEF != PBOFIBLBPGJ.Ijljfpkieop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LJMLNINDHEF);
		}
		if (Rank != PBOFIBLBPGJ.Ijljfpkieop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Rank);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (TurnLeft != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TurnLeft);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightFestUpdateChallengeRecordNotify other)
	{
		if (other != null)
		{
			if (other.HEILKBJCAGB != 0)
			{
				HEILKBJCAGB = other.HEILKBJCAGB;
			}
			if (other.LJMLNINDHEF != PBOFIBLBPGJ.Ijljfpkieop)
			{
				LJMLNINDHEF = other.LJMLNINDHEF;
			}
			if (other.Rank != PBOFIBLBPGJ.Ijljfpkieop)
			{
				Rank = other.Rank;
			}
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.TurnLeft != 0)
			{
				TurnLeft = other.TurnLeft;
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
			case 24u:
				HEILKBJCAGB = input.ReadUInt32();
				break;
			case 32u:
				LJMLNINDHEF = (PBOFIBLBPGJ)input.ReadEnum();
				break;
			case 40u:
				Rank = (PBOFIBLBPGJ)input.ReadEnum();
				break;
			case 48u:
				ChallengeId = input.ReadUInt32();
				break;
			case 96u:
				TurnLeft = input.ReadUInt32();
				break;
			}
		}
	}
}
