using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ENEHKONPJNA : IMessage<ENEHKONPJNA>, IMessage, IEquatable<ENEHKONPJNA>, IDeepCloneable<ENEHKONPJNA>, IBufferMessage
{
	private static readonly MessageParser<ENEHKONPJNA> _parser = new MessageParser<ENEHKONPJNA>(() => new ENEHKONPJNA());

	private UnknownFieldSet _unknownFields;

	public const int CBCHIPFAHMGFieldNumber = 2;

	private uint cBCHIPFAHMG_;

	public const int DKJFDLKJLBEFieldNumber = 6;

	private bool dKJFDLKJLBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ENEHKONPJNA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ENEHKONPJNAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBCHIPFAHMG
	{
		get
		{
			return cBCHIPFAHMG_;
		}
		set
		{
			cBCHIPFAHMG_ = value;
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
	public ENEHKONPJNA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEHKONPJNA(ENEHKONPJNA other)
		: this()
	{
		cBCHIPFAHMG_ = other.cBCHIPFAHMG_;
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEHKONPJNA Clone()
	{
		return new ENEHKONPJNA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ENEHKONPJNA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ENEHKONPJNA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CBCHIPFAHMG != other.CBCHIPFAHMG)
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
		if (CBCHIPFAHMG != 0)
		{
			num ^= CBCHIPFAHMG.GetHashCode();
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
		if (CBCHIPFAHMG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CBCHIPFAHMG);
		}
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(48);
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
		if (CBCHIPFAHMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBCHIPFAHMG);
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
	public void MergeFrom(ENEHKONPJNA other)
	{
		if (other != null)
		{
			if (other.CBCHIPFAHMG != 0)
			{
				CBCHIPFAHMG = other.CBCHIPFAHMG;
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
			case 16u:
				CBCHIPFAHMG = input.ReadUInt32();
				break;
			case 48u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			}
		}
	}
}
