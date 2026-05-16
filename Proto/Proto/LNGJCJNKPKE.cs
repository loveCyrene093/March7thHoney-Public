using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LNGJCJNKPKE : IMessage<LNGJCJNKPKE>, IMessage, IEquatable<LNGJCJNKPKE>, IDeepCloneable<LNGJCJNKPKE>, IBufferMessage
{
	private static readonly MessageParser<LNGJCJNKPKE> _parser = new MessageParser<LNGJCJNKPKE>(() => new LNGJCJNKPKE());

	private UnknownFieldSet _unknownFields;

	public const int LevelIdFieldNumber = 2;

	private uint levelId_;

	public const int IDOPNCKAADOFieldNumber = 9;

	private bool iDOPNCKAADO_;

	public const int TimeFieldNumber = 11;

	private uint time_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LNGJCJNKPKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LNGJCJNKPKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool IDOPNCKAADO
	{
		get
		{
			return iDOPNCKAADO_;
		}
		set
		{
			iDOPNCKAADO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJCJNKPKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJCJNKPKE(LNGJCJNKPKE other)
		: this()
	{
		levelId_ = other.levelId_;
		iDOPNCKAADO_ = other.iDOPNCKAADO_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJCJNKPKE Clone()
	{
		return new LNGJCJNKPKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LNGJCJNKPKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LNGJCJNKPKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (IDOPNCKAADO != other.IDOPNCKAADO)
		{
			return false;
		}
		if (Time != other.Time)
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
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (IDOPNCKAADO)
		{
			num ^= IDOPNCKAADO.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
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
		if (LevelId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LevelId);
		}
		if (IDOPNCKAADO)
		{
			output.WriteRawTag(72);
			output.WriteBool(IDOPNCKAADO);
		}
		if (Time != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Time);
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
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (IDOPNCKAADO)
		{
			num += 2;
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LNGJCJNKPKE other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.IDOPNCKAADO)
			{
				IDOPNCKAADO = other.IDOPNCKAADO;
			}
			if (other.Time != 0)
			{
				Time = other.Time;
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
				LevelId = input.ReadUInt32();
				break;
			case 72u:
				IDOPNCKAADO = input.ReadBool();
				break;
			case 88u:
				Time = input.ReadUInt32();
				break;
			}
		}
	}
}
