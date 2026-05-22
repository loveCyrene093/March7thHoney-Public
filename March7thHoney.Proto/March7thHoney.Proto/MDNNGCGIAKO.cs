using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MDNNGCGIAKO : IMessage<MDNNGCGIAKO>, IMessage, IEquatable<MDNNGCGIAKO>, IDeepCloneable<MDNNGCGIAKO>, IBufferMessage
{
	private static readonly MessageParser<MDNNGCGIAKO> _parser = new MessageParser<MDNNGCGIAKO>(() => new MDNNGCGIAKO());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int RankFieldNumber = 4;

	private uint rank_;

	public const int TidFieldNumber = 6;

	private uint tid_;

	public const int ExpFieldNumber = 12;

	private uint exp_;

	public const int PromotionFieldNumber = 14;

	private uint promotion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MDNNGCGIAKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MDNNGCGIAKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint Rank
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
	public uint Tid
	{
		get
		{
			return tid_;
		}
		set
		{
			tid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDNNGCGIAKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDNNGCGIAKO(MDNNGCGIAKO other)
		: this()
	{
		level_ = other.level_;
		rank_ = other.rank_;
		tid_ = other.tid_;
		exp_ = other.exp_;
		promotion_ = other.promotion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDNNGCGIAKO Clone()
	{
		return new MDNNGCGIAKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MDNNGCGIAKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MDNNGCGIAKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (Tid != other.Tid)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Promotion != other.Promotion)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Rank);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Tid);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Exp);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Promotion);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MDNNGCGIAKO other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Promotion != 0)
			{
				Promotion = other.Promotion;
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
				Level = input.ReadUInt32();
				break;
			case 32u:
				Rank = input.ReadUInt32();
				break;
			case 48u:
				Tid = input.ReadUInt32();
				break;
			case 96u:
				Exp = input.ReadUInt32();
				break;
			case 112u:
				Promotion = input.ReadUInt32();
				break;
			}
		}
	}
}
