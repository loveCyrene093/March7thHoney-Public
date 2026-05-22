using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BLKAIEHOCBC : IMessage<BLKAIEHOCBC>, IMessage, IEquatable<BLKAIEHOCBC>, IDeepCloneable<BLKAIEHOCBC>, IBufferMessage
{
	private static readonly MessageParser<BLKAIEHOCBC> _parser = new MessageParser<BLKAIEHOCBC>(() => new BLKAIEHOCBC());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 6;

	private uint level_;

	public const int DKHKEJIAJBNFieldNumber = 12;

	private uint dKHKEJIAJBN_;

	public const int ExpFieldNumber = 15;

	private uint exp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BLKAIEHOCBC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BLKAIEHOCBCReflection.Descriptor.MessageTypes[0];

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
	public uint DKHKEJIAJBN
	{
		get
		{
			return dKHKEJIAJBN_;
		}
		set
		{
			dKHKEJIAJBN_ = value;
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
	public BLKAIEHOCBC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLKAIEHOCBC(BLKAIEHOCBC other)
		: this()
	{
		level_ = other.level_;
		dKHKEJIAJBN_ = other.dKHKEJIAJBN_;
		exp_ = other.exp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLKAIEHOCBC Clone()
	{
		return new BLKAIEHOCBC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BLKAIEHOCBC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BLKAIEHOCBC other)
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
		if (DKHKEJIAJBN != other.DKHKEJIAJBN)
		{
			return false;
		}
		if (Exp != other.Exp)
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
		if (DKHKEJIAJBN != 0)
		{
			num ^= DKHKEJIAJBN.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Level);
		}
		if (DKHKEJIAJBN != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DKHKEJIAJBN);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Exp);
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
		if (DKHKEJIAJBN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKHKEJIAJBN);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BLKAIEHOCBC other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.DKHKEJIAJBN != 0)
			{
				DKHKEJIAJBN = other.DKHKEJIAJBN;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
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
			case 48u:
				Level = input.ReadUInt32();
				break;
			case 96u:
				DKHKEJIAJBN = input.ReadUInt32();
				break;
			case 120u:
				Exp = input.ReadUInt32();
				break;
			}
		}
	}
}
