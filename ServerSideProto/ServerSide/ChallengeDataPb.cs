using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeDataPb : IMessage<ChallengeDataPb>, IMessage, IEquatable<ChallengeDataPb>, IDeepCloneable<ChallengeDataPb>, IBufferMessage
{
	public enum ChallengeTypeOneofCase
	{
		None,
		Memory,
		Story,
		Boss,
		Peak
	}

	private static readonly MessageParser<ChallengeDataPb> _parser = new MessageParser<ChallengeDataPb>(() => new ChallengeDataPb());

	private UnknownFieldSet _unknownFields;

	public const int MemoryFieldNumber = 1;

	public const int StoryFieldNumber = 2;

	public const int BossFieldNumber = 3;

	public const int PeakFieldNumber = 4;

	private object challengeType_;

	private ChallengeTypeOneofCase challengeTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeDataPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeDataReflection.Descriptor.MessageTypes[5];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeMemoryDataPb Memory
	{
		get
		{
			if (challengeTypeCase_ != ChallengeTypeOneofCase.Memory)
			{
				return null;
			}
			return (ChallengeMemoryDataPb)challengeType_;
		}
		set
		{
			challengeType_ = value;
			challengeTypeCase_ = ((value != null) ? ChallengeTypeOneofCase.Memory : ChallengeTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStoryDataPb Story
	{
		get
		{
			if (challengeTypeCase_ != ChallengeTypeOneofCase.Story)
			{
				return null;
			}
			return (ChallengeStoryDataPb)challengeType_;
		}
		set
		{
			challengeType_ = value;
			challengeTypeCase_ = ((value != null) ? ChallengeTypeOneofCase.Story : ChallengeTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossDataPb Boss
	{
		get
		{
			if (challengeTypeCase_ != ChallengeTypeOneofCase.Boss)
			{
				return null;
			}
			return (ChallengeBossDataPb)challengeType_;
		}
		set
		{
			challengeType_ = value;
			challengeTypeCase_ = ((value != null) ? ChallengeTypeOneofCase.Boss : ChallengeTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakDataPb Peak
	{
		get
		{
			if (challengeTypeCase_ != ChallengeTypeOneofCase.Peak)
			{
				return null;
			}
			return (ChallengePeakDataPb)challengeType_;
		}
		set
		{
			challengeType_ = value;
			challengeTypeCase_ = ((value != null) ? ChallengeTypeOneofCase.Peak : ChallengeTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTypeOneofCase ChallengeTypeCase => challengeTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeDataPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeDataPb(ChallengeDataPb other)
		: this()
	{
		switch (other.ChallengeTypeCase)
		{
		case ChallengeTypeOneofCase.Memory:
			Memory = other.Memory.Clone();
			break;
		case ChallengeTypeOneofCase.Story:
			Story = other.Story.Clone();
			break;
		case ChallengeTypeOneofCase.Boss:
			Boss = other.Boss.Clone();
			break;
		case ChallengeTypeOneofCase.Peak:
			Peak = other.Peak.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeDataPb Clone()
	{
		return new ChallengeDataPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearChallengeType()
	{
		challengeTypeCase_ = ChallengeTypeOneofCase.None;
		challengeType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeDataPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeDataPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Memory, other.Memory))
		{
			return false;
		}
		if (!object.Equals(Story, other.Story))
		{
			return false;
		}
		if (!object.Equals(Boss, other.Boss))
		{
			return false;
		}
		if (!object.Equals(Peak, other.Peak))
		{
			return false;
		}
		if (ChallengeTypeCase != other.ChallengeTypeCase)
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
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Memory)
		{
			num ^= Memory.GetHashCode();
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Story)
		{
			num ^= Story.GetHashCode();
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Boss)
		{
			num ^= Boss.GetHashCode();
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Peak)
		{
			num ^= Peak.GetHashCode();
		}
		num ^= (int)challengeTypeCase_;
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
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Memory)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Memory);
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Story)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Story);
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Boss)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Boss);
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Peak)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Peak);
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
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Memory)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Memory);
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Story)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Story);
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Boss)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Boss);
		}
		if (challengeTypeCase_ == ChallengeTypeOneofCase.Peak)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Peak);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeDataPb other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.ChallengeTypeCase)
		{
		case ChallengeTypeOneofCase.Memory:
			if (Memory == null)
			{
				Memory = new ChallengeMemoryDataPb();
			}
			Memory.MergeFrom(other.Memory);
			break;
		case ChallengeTypeOneofCase.Story:
			if (Story == null)
			{
				Story = new ChallengeStoryDataPb();
			}
			Story.MergeFrom(other.Story);
			break;
		case ChallengeTypeOneofCase.Boss:
			if (Boss == null)
			{
				Boss = new ChallengeBossDataPb();
			}
			Boss.MergeFrom(other.Boss);
			break;
		case ChallengeTypeOneofCase.Peak:
			if (Peak == null)
			{
				Peak = new ChallengePeakDataPb();
			}
			Peak.MergeFrom(other.Peak);
			break;
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
			case 10u:
			{
				ChallengeMemoryDataPb challengeMemoryDataPb = new ChallengeMemoryDataPb();
				if (challengeTypeCase_ == ChallengeTypeOneofCase.Memory)
				{
					challengeMemoryDataPb.MergeFrom(Memory);
				}
				input.ReadMessage(challengeMemoryDataPb);
				Memory = challengeMemoryDataPb;
				break;
			}
			case 18u:
			{
				ChallengeStoryDataPb challengeStoryDataPb = new ChallengeStoryDataPb();
				if (challengeTypeCase_ == ChallengeTypeOneofCase.Story)
				{
					challengeStoryDataPb.MergeFrom(Story);
				}
				input.ReadMessage(challengeStoryDataPb);
				Story = challengeStoryDataPb;
				break;
			}
			case 26u:
			{
				ChallengeBossDataPb challengeBossDataPb = new ChallengeBossDataPb();
				if (challengeTypeCase_ == ChallengeTypeOneofCase.Boss)
				{
					challengeBossDataPb.MergeFrom(Boss);
				}
				input.ReadMessage(challengeBossDataPb);
				Boss = challengeBossDataPb;
				break;
			}
			case 34u:
			{
				ChallengePeakDataPb challengePeakDataPb = new ChallengePeakDataPb();
				if (challengeTypeCase_ == ChallengeTypeOneofCase.Peak)
				{
					challengePeakDataPb.MergeFrom(Peak);
				}
				input.ReadMessage(challengePeakDataPb);
				Peak = challengePeakDataPb;
				break;
			}
			}
		}
	}
}
