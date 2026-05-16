using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BHFAFMDHKKC : IMessage<BHFAFMDHKKC>, IMessage, IEquatable<BHFAFMDHKKC>, IDeepCloneable<BHFAFMDHKKC>, IBufferMessage
{
	private static readonly MessageParser<BHFAFMDHKKC> _parser = new MessageParser<BHFAFMDHKKC>(() => new BHFAFMDHKKC());

	private UnknownFieldSet _unknownFields;

	public const int BuffTwoFieldNumber = 2;

	private uint buffTwo_;

	public const int BuffOneFieldNumber = 4;

	private uint buffOne_;

	public const int ABJGNBJMJJGFieldNumber = 9;

	private uint aBJGNBJMJJG_;

	public const int ScoreIdFieldNumber = 11;

	private uint scoreId_;

	public const int LineupListFieldNumber = 12;

	private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage(98u, ChallengeLineupList.Parser);

	private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

	public const int LevelFieldNumber = 13;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BHFAFMDHKKC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BHFAFMDHKKCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffTwo
	{
		get
		{
			return buffTwo_;
		}
		set
		{
			buffTwo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffOne
	{
		get
		{
			return buffOne_;
		}
		set
		{
			buffOne_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABJGNBJMJJG
	{
		get
		{
			return aBJGNBJMJJG_;
		}
		set
		{
			aBJGNBJMJJG_ = value;
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
	public RepeatedField<ChallengeLineupList> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHFAFMDHKKC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHFAFMDHKKC(BHFAFMDHKKC other)
		: this()
	{
		buffTwo_ = other.buffTwo_;
		buffOne_ = other.buffOne_;
		aBJGNBJMJJG_ = other.aBJGNBJMJJG_;
		scoreId_ = other.scoreId_;
		lineupList_ = other.lineupList_.Clone();
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHFAFMDHKKC Clone()
	{
		return new BHFAFMDHKKC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BHFAFMDHKKC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BHFAFMDHKKC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffTwo != other.BuffTwo)
		{
			return false;
		}
		if (BuffOne != other.BuffOne)
		{
			return false;
		}
		if (ABJGNBJMJJG != other.ABJGNBJMJJG)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!lineupList_.Equals(other.lineupList_))
		{
			return false;
		}
		if (Level != other.Level)
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
		if (BuffTwo != 0)
		{
			num ^= BuffTwo.GetHashCode();
		}
		if (BuffOne != 0)
		{
			num ^= BuffOne.GetHashCode();
		}
		if (ABJGNBJMJJG != 0)
		{
			num ^= ABJGNBJMJJG.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		num ^= lineupList_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (BuffTwo != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BuffTwo);
		}
		if (BuffOne != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BuffOne);
		}
		if (ABJGNBJMJJG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ABJGNBJMJJG);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ScoreId);
		}
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		if (Level != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Level);
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
		if (BuffTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffTwo);
		}
		if (BuffOne != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffOne);
		}
		if (ABJGNBJMJJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABJGNBJMJJG);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BHFAFMDHKKC other)
	{
		if (other != null)
		{
			if (other.BuffTwo != 0)
			{
				BuffTwo = other.BuffTwo;
			}
			if (other.BuffOne != 0)
			{
				BuffOne = other.BuffOne;
			}
			if (other.ABJGNBJMJJG != 0)
			{
				ABJGNBJMJJG = other.ABJGNBJMJJG;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			lineupList_.Add(other.lineupList_);
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 16u:
				BuffTwo = input.ReadUInt32();
				break;
			case 32u:
				BuffOne = input.ReadUInt32();
				break;
			case 72u:
				ABJGNBJMJJG = input.ReadUInt32();
				break;
			case 88u:
				ScoreId = input.ReadUInt32();
				break;
			case 98u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 104u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
