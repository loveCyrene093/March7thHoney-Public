using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IGJJFOKAHAP : IMessage<IGJJFOKAHAP>, IMessage, IEquatable<IGJJFOKAHAP>, IDeepCloneable<IGJJFOKAHAP>, IBufferMessage
{
	private static readonly MessageParser<IGJJFOKAHAP> _parser = new MessageParser<IGJJFOKAHAP>(() => new IGJJFOKAHAP());

	private UnknownFieldSet _unknownFields;

	public const int DPFCIHJIAEFFieldNumber = 3;

	private uint dPFCIHJIAEF_;

	public const int DKJFDLKJLBEFieldNumber = 13;

	private bool dKJFDLKJLBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IGJJFOKAHAP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IGJJFOKAHAPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DPFCIHJIAEF
	{
		get
		{
			return dPFCIHJIAEF_;
		}
		set
		{
			dPFCIHJIAEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DKJFDLKJLBE
	{
		get
		{
			return dKJFDLKJLBE_;
		}
		set
		{
			dKJFDLKJLBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGJJFOKAHAP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGJJFOKAHAP(IGJJFOKAHAP other)
		: this()
	{
		dPFCIHJIAEF_ = other.dPFCIHJIAEF_;
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGJJFOKAHAP Clone()
	{
		return new IGJJFOKAHAP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IGJJFOKAHAP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IGJJFOKAHAP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DPFCIHJIAEF != other.DPFCIHJIAEF)
		{
			return false;
		}
		if (DKJFDLKJLBE != other.DKJFDLKJLBE)
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
		if (DPFCIHJIAEF != 0)
		{
			num ^= DPFCIHJIAEF.GetHashCode();
		}
		if (DKJFDLKJLBE)
		{
			num ^= DKJFDLKJLBE.GetHashCode();
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
		if (DPFCIHJIAEF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DPFCIHJIAEF);
		}
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(104);
			output.WriteBool(DKJFDLKJLBE);
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
		if (DPFCIHJIAEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DPFCIHJIAEF);
		}
		if (DKJFDLKJLBE)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IGJJFOKAHAP other)
	{
		if (other != null)
		{
			if (other.DPFCIHJIAEF != 0)
			{
				DPFCIHJIAEF = other.DPFCIHJIAEF;
			}
			if (other.DKJFDLKJLBE)
			{
				DKJFDLKJLBE = other.DKJFDLKJLBE;
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
				DPFCIHJIAEF = input.ReadUInt32();
				break;
			case 104u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			}
		}
	}
}
