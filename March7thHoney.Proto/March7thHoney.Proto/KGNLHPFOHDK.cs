using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KGNLHPFOHDK : IMessage<KGNLHPFOHDK>, IMessage, IEquatable<KGNLHPFOHDK>, IDeepCloneable<KGNLHPFOHDK>, IBufferMessage
{
	private static readonly MessageParser<KGNLHPFOHDK> _parser = new MessageParser<KGNLHPFOHDK>(() => new KGNLHPFOHDK());

	private UnknownFieldSet _unknownFields;

	public const int LANHJOMCKNJFieldNumber = 5;

	private uint lANHJOMCKNJ_;

	public const int MaxScoreFieldNumber = 8;

	private uint maxScore_;

	public const int LevelIdFieldNumber = 9;

	private uint levelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KGNLHPFOHDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KGNLHPFOHDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LANHJOMCKNJ
	{
		get
		{
			return lANHJOMCKNJ_;
		}
		set
		{
			lANHJOMCKNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxScore
	{
		get
		{
			return maxScore_;
		}
		set
		{
			maxScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGNLHPFOHDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGNLHPFOHDK(KGNLHPFOHDK other)
		: this()
	{
		lANHJOMCKNJ_ = other.lANHJOMCKNJ_;
		maxScore_ = other.maxScore_;
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGNLHPFOHDK Clone()
	{
		return new KGNLHPFOHDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KGNLHPFOHDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KGNLHPFOHDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LANHJOMCKNJ != other.LANHJOMCKNJ)
		{
			return false;
		}
		if (MaxScore != other.MaxScore)
		{
			return false;
		}
		if (LevelId != other.LevelId)
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
		if (LANHJOMCKNJ != 0)
		{
			num ^= LANHJOMCKNJ.GetHashCode();
		}
		if (MaxScore != 0)
		{
			num ^= MaxScore.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
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
		if (LANHJOMCKNJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LANHJOMCKNJ);
		}
		if (MaxScore != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MaxScore);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LevelId);
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
		if (LANHJOMCKNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LANHJOMCKNJ);
		}
		if (MaxScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxScore);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KGNLHPFOHDK other)
	{
		if (other != null)
		{
			if (other.LANHJOMCKNJ != 0)
			{
				LANHJOMCKNJ = other.LANHJOMCKNJ;
			}
			if (other.MaxScore != 0)
			{
				MaxScore = other.MaxScore;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
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
			case 40u:
				LANHJOMCKNJ = input.ReadUInt32();
				break;
			case 64u:
				MaxScore = input.ReadUInt32();
				break;
			case 72u:
				LevelId = input.ReadUInt32();
				break;
			}
		}
	}
}
