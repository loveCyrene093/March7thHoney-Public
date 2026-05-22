using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EKJGLIIJIBD : IMessage<EKJGLIIJIBD>, IMessage, IEquatable<EKJGLIIJIBD>, IDeepCloneable<EKJGLIIJIBD>, IBufferMessage
{
	private static readonly MessageParser<EKJGLIIJIBD> _parser = new MessageParser<EKJGLIIJIBD>(() => new EKJGLIIJIBD());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int PJMIEMAONINFieldNumber = 6;

	private uint pJMIEMAONIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EKJGLIIJIBD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EKJGLIIJIBDReflection.Descriptor.MessageTypes[0];

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
	public uint PJMIEMAONIN
	{
		get
		{
			return pJMIEMAONIN_;
		}
		set
		{
			pJMIEMAONIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKJGLIIJIBD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKJGLIIJIBD(EKJGLIIJIBD other)
		: this()
	{
		level_ = other.level_;
		pJMIEMAONIN_ = other.pJMIEMAONIN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKJGLIIJIBD Clone()
	{
		return new EKJGLIIJIBD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EKJGLIIJIBD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EKJGLIIJIBD other)
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
		if (PJMIEMAONIN != other.PJMIEMAONIN)
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
		if (PJMIEMAONIN != 0)
		{
			num ^= PJMIEMAONIN.GetHashCode();
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
		if (PJMIEMAONIN != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PJMIEMAONIN);
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
		if (PJMIEMAONIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJMIEMAONIN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EKJGLIIJIBD other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.PJMIEMAONIN != 0)
			{
				PJMIEMAONIN = other.PJMIEMAONIN;
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
			case 48u:
				PJMIEMAONIN = input.ReadUInt32();
				break;
			}
		}
	}
}
