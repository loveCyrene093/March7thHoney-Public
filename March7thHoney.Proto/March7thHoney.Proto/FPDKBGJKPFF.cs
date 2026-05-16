using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FPDKBGJKPFF : IMessage<FPDKBGJKPFF>, IMessage, IEquatable<FPDKBGJKPFF>, IDeepCloneable<FPDKBGJKPFF>, IBufferMessage
{
	private static readonly MessageParser<FPDKBGJKPFF> _parser = new MessageParser<FPDKBGJKPFF>(() => new FPDKBGJKPFF());

	private UnknownFieldSet _unknownFields;

	public const int LineupListFieldNumber = 1;

	private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage(10u, ChallengeLineupList.Parser);

	private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int RoundCountFieldNumber = 11;

	private uint roundCount_;

	public const int ABJGNBJMJJGFieldNumber = 14;

	private uint aBJGNBJMJJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FPDKBGJKPFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FPDKBGJKPFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FPDKBGJKPFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPDKBGJKPFF(FPDKBGJKPFF other)
		: this()
	{
		lineupList_ = other.lineupList_.Clone();
		level_ = other.level_;
		roundCount_ = other.roundCount_;
		aBJGNBJMJJG_ = other.aBJGNBJMJJG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPDKBGJKPFF Clone()
	{
		return new FPDKBGJKPFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FPDKBGJKPFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FPDKBGJKPFF other)
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
		if (Level != other.Level)
		{
			return false;
		}
		if (RoundCount != other.RoundCount)
		{
			return false;
		}
		if (ABJGNBJMJJG != other.ABJGNBJMJJG)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (RoundCount != 0)
		{
			num ^= RoundCount.GetHashCode();
		}
		if (ABJGNBJMJJG != 0)
		{
			num ^= ABJGNBJMJJG.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (RoundCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RoundCount);
		}
		if (ABJGNBJMJJG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ABJGNBJMJJG);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (RoundCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundCount);
		}
		if (ABJGNBJMJJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABJGNBJMJJG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FPDKBGJKPFF other)
	{
		if (other != null)
		{
			lineupList_.Add(other.lineupList_);
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.RoundCount != 0)
			{
				RoundCount = other.RoundCount;
			}
			if (other.ABJGNBJMJJG != 0)
			{
				ABJGNBJMJJG = other.ABJGNBJMJJG;
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
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				RoundCount = input.ReadUInt32();
				break;
			case 112u:
				ABJGNBJMJJG = input.ReadUInt32();
				break;
			}
		}
	}
}
