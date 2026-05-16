using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BPDFEOGCAIJ : IMessage<BPDFEOGCAIJ>, IMessage, IEquatable<BPDFEOGCAIJ>, IDeepCloneable<BPDFEOGCAIJ>, IBufferMessage
{
	private static readonly MessageParser<BPDFEOGCAIJ> _parser = new MessageParser<BPDFEOGCAIJ>(() => new BPDFEOGCAIJ());

	private UnknownFieldSet _unknownFields;

	public const int AOKEIEHKKKLFieldNumber = 1;

	private uint aOKEIEHKKKL_;

	public const int ValueFieldNumber = 2;

	private float value_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BPDFEOGCAIJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BPDFEOGCAIJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOKEIEHKKKL
	{
		get
		{
			return aOKEIEHKKKL_;
		}
		set
		{
			aOKEIEHKKKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPDFEOGCAIJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPDFEOGCAIJ(BPDFEOGCAIJ other)
		: this()
	{
		aOKEIEHKKKL_ = other.aOKEIEHKKKL_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPDFEOGCAIJ Clone()
	{
		return new BPDFEOGCAIJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BPDFEOGCAIJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BPDFEOGCAIJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOKEIEHKKKL != other.AOKEIEHKKKL)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Value, other.Value))
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
		if (AOKEIEHKKKL != 0)
		{
			num ^= AOKEIEHKKKL.GetHashCode();
		}
		if (Value != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Value);
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
		if (AOKEIEHKKKL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AOKEIEHKKKL);
		}
		if (Value != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Value);
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
		if (AOKEIEHKKKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOKEIEHKKKL);
		}
		if (Value != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BPDFEOGCAIJ other)
	{
		if (other != null)
		{
			if (other.AOKEIEHKKKL != 0)
			{
				AOKEIEHKKKL = other.AOKEIEHKKKL;
			}
			if (other.Value != 0f)
			{
				Value = other.Value;
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
			case 8u:
				AOKEIEHKKKL = input.ReadUInt32();
				break;
			case 21u:
				Value = input.ReadFloat();
				break;
			}
		}
	}
}
