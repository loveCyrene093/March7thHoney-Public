using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHAANBNCLHI : IMessage<HHAANBNCLHI>, IMessage, IEquatable<HHAANBNCLHI>, IDeepCloneable<HHAANBNCLHI>, IBufferMessage
{
	private static readonly MessageParser<HHAANBNCLHI> _parser = new MessageParser<HHAANBNCLHI>(() => new HHAANBNCLHI());

	private UnknownFieldSet _unknownFields;

	public const int DKJFDLKJLBEFieldNumber = 9;

	private bool dKJFDLKJLBE_;

	public const int IDKOBMMDBHFFieldNumber = 10;

	private uint iDKOBMMDBHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHAANBNCLHI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHAANBNCLHIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint IDKOBMMDBHF
	{
		get
		{
			return iDKOBMMDBHF_;
		}
		set
		{
			iDKOBMMDBHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAANBNCLHI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAANBNCLHI(HHAANBNCLHI other)
		: this()
	{
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		iDKOBMMDBHF_ = other.iDKOBMMDBHF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAANBNCLHI Clone()
	{
		return new HHAANBNCLHI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHAANBNCLHI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHAANBNCLHI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DKJFDLKJLBE != other.DKJFDLKJLBE)
		{
			return false;
		}
		if (IDKOBMMDBHF != other.IDKOBMMDBHF)
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
		if (DKJFDLKJLBE)
		{
			num ^= DKJFDLKJLBE.GetHashCode();
		}
		if (IDKOBMMDBHF != 0)
		{
			num ^= IDKOBMMDBHF.GetHashCode();
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
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(72);
			output.WriteBool(DKJFDLKJLBE);
		}
		if (IDKOBMMDBHF != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IDKOBMMDBHF);
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
		if (DKJFDLKJLBE)
		{
			num += 2;
		}
		if (IDKOBMMDBHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IDKOBMMDBHF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHAANBNCLHI other)
	{
		if (other != null)
		{
			if (other.DKJFDLKJLBE)
			{
				DKJFDLKJLBE = other.DKJFDLKJLBE;
			}
			if (other.IDKOBMMDBHF != 0)
			{
				IDKOBMMDBHF = other.IDKOBMMDBHF;
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
			case 72u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			case 80u:
				IDKOBMMDBHF = input.ReadUInt32();
				break;
			}
		}
	}
}
