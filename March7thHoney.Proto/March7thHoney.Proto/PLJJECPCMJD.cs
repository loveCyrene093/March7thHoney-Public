using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLJJECPCMJD : IMessage<PLJJECPCMJD>, IMessage, IEquatable<PLJJECPCMJD>, IDeepCloneable<PLJJECPCMJD>, IBufferMessage
{
	private static readonly MessageParser<PLJJECPCMJD> _parser = new MessageParser<PLJJECPCMJD>(() => new PLJJECPCMJD());

	private UnknownFieldSet _unknownFields;

	public const int LineupListFieldNumber = 1;

	private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage(10u, ChallengeLineupList.Parser);

	private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

	public const int BuffOneFieldNumber = 2;

	private uint buffOne_;

	public const int ScoreIdFieldNumber = 7;

	private uint scoreId_;

	public const int ABJGNBJMJJGFieldNumber = 9;

	private uint aBJGNBJMJJG_;

	public const int LevelFieldNumber = 10;

	private uint level_;

	public const int BuffTwoFieldNumber = 13;

	private uint buffTwo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLJJECPCMJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLJJECPCMJDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChallengeLineupList> LineupList => lineupList_;

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
	public PLJJECPCMJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLJJECPCMJD(PLJJECPCMJD other)
		: this()
	{
		lineupList_ = other.lineupList_.Clone();
		buffOne_ = other.buffOne_;
		scoreId_ = other.scoreId_;
		aBJGNBJMJJG_ = other.aBJGNBJMJJG_;
		level_ = other.level_;
		buffTwo_ = other.buffTwo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLJJECPCMJD Clone()
	{
		return new PLJJECPCMJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLJJECPCMJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLJJECPCMJD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lineupList_.Equals(other.lineupList_))
		{
			return false;
		}
		if (BuffOne != other.BuffOne)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (ABJGNBJMJJG != other.ABJGNBJMJJG)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (BuffTwo != other.BuffTwo)
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
		num ^= lineupList_.GetHashCode();
		if (BuffOne != 0)
		{
			num ^= BuffOne.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (ABJGNBJMJJG != 0)
		{
			num ^= ABJGNBJMJJG.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (BuffTwo != 0)
		{
			num ^= BuffTwo.GetHashCode();
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
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		if (BuffOne != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BuffOne);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ScoreId);
		}
		if (ABJGNBJMJJG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ABJGNBJMJJG);
		}
		if (Level != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Level);
		}
		if (BuffTwo != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BuffTwo);
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
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (BuffOne != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffOne);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (ABJGNBJMJJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABJGNBJMJJG);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (BuffTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffTwo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLJJECPCMJD other)
	{
		if (other != null)
		{
			lineupList_.Add(other.lineupList_);
			if (other.BuffOne != 0)
			{
				BuffOne = other.BuffOne;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.ABJGNBJMJJG != 0)
			{
				ABJGNBJMJJG = other.ABJGNBJMJJG;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.BuffTwo != 0)
			{
				BuffTwo = other.BuffTwo;
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
			case 10u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 16u:
				BuffOne = input.ReadUInt32();
				break;
			case 56u:
				ScoreId = input.ReadUInt32();
				break;
			case 72u:
				ABJGNBJMJJG = input.ReadUInt32();
				break;
			case 80u:
				Level = input.ReadUInt32();
				break;
			case 104u:
				BuffTwo = input.ReadUInt32();
				break;
			}
		}
	}
}
