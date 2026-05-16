using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EIPPGFCFJEO : IMessage<EIPPGFCFJEO>, IMessage, IEquatable<EIPPGFCFJEO>, IDeepCloneable<EIPPGFCFJEO>, IBufferMessage
{
	private static readonly MessageParser<EIPPGFCFJEO> _parser = new MessageParser<EIPPGFCFJEO>(() => new EIPPGFCFJEO());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 4;

	private uint level_;

	public const int AOKDBDGDCHBFieldNumber = 7;

	private uint aOKDBDGDCHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EIPPGFCFJEO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EIPPGFCFJEOReflection.Descriptor.MessageTypes[0];

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
	public uint AOKDBDGDCHB
	{
		get
		{
			return aOKDBDGDCHB_;
		}
		set
		{
			aOKDBDGDCHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIPPGFCFJEO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIPPGFCFJEO(EIPPGFCFJEO other)
		: this()
	{
		level_ = other.level_;
		aOKDBDGDCHB_ = other.aOKDBDGDCHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIPPGFCFJEO Clone()
	{
		return new EIPPGFCFJEO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EIPPGFCFJEO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EIPPGFCFJEO other)
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
		if (AOKDBDGDCHB != other.AOKDBDGDCHB)
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
		if (AOKDBDGDCHB != 0)
		{
			num ^= AOKDBDGDCHB.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(Level);
		}
		if (AOKDBDGDCHB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AOKDBDGDCHB);
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
		if (AOKDBDGDCHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOKDBDGDCHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EIPPGFCFJEO other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.AOKDBDGDCHB != 0)
			{
				AOKDBDGDCHB = other.AOKDBDGDCHB;
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
			case 32u:
				Level = input.ReadUInt32();
				break;
			case 56u:
				AOKDBDGDCHB = input.ReadUInt32();
				break;
			}
		}
	}
}
