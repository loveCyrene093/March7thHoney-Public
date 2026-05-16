using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightFestScoreUpdateNotify : IMessage<FightFestScoreUpdateNotify>, IMessage, IEquatable<FightFestScoreUpdateNotify>, IDeepCloneable<FightFestScoreUpdateNotify>, IBufferMessage
{
	private static readonly MessageParser<FightFestScoreUpdateNotify> _parser = new MessageParser<FightFestScoreUpdateNotify>(() => new FightFestScoreUpdateNotify());

	private UnknownFieldSet _unknownFields;

	public const int LLIAPBILLLMFieldNumber = 13;

	private uint lLIAPBILLLM_;

	public const int ScoreIdFieldNumber = 14;

	private uint scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightFestScoreUpdateNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightFestScoreUpdateNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLIAPBILLLM
	{
		get
		{
			return lLIAPBILLLM_;
		}
		set
		{
			lLIAPBILLLM_ = value;
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
	public FightFestScoreUpdateNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestScoreUpdateNotify(FightFestScoreUpdateNotify other)
		: this()
	{
		lLIAPBILLLM_ = other.lLIAPBILLLM_;
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestScoreUpdateNotify Clone()
	{
		return new FightFestScoreUpdateNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightFestScoreUpdateNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightFestScoreUpdateNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLIAPBILLLM != other.LLIAPBILLLM)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
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
		if (LLIAPBILLLM != 0)
		{
			num ^= LLIAPBILLLM.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
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
		if (LLIAPBILLLM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LLIAPBILLLM);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ScoreId);
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
		if (LLIAPBILLLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLIAPBILLLM);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightFestScoreUpdateNotify other)
	{
		if (other != null)
		{
			if (other.LLIAPBILLLM != 0)
			{
				LLIAPBILLLM = other.LLIAPBILLLM;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
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
			case 104u:
				LLIAPBILLLM = input.ReadUInt32();
				break;
			case 112u:
				ScoreId = input.ReadUInt32();
				break;
			}
		}
	}
}
