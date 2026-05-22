using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DODELEAICGI : IMessage<DODELEAICGI>, IMessage, IEquatable<DODELEAICGI>, IDeepCloneable<DODELEAICGI>, IBufferMessage
{
	private static readonly MessageParser<DODELEAICGI> _parser = new MessageParser<DODELEAICGI>(() => new DODELEAICGI());

	private UnknownFieldSet _unknownFields;

	public const int HELJKFMIFFEFieldNumber = 1;

	private string hELJKFMIFFE_ = "";

	public const int ValueFieldNumber = 2;

	private string value_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DODELEAICGI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DODELEAICGIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HELJKFMIFFE
	{
		get
		{
			return hELJKFMIFFE_;
		}
		set
		{
			hELJKFMIFFE_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODELEAICGI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODELEAICGI(DODELEAICGI other)
		: this()
	{
		hELJKFMIFFE_ = other.hELJKFMIFFE_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODELEAICGI Clone()
	{
		return new DODELEAICGI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DODELEAICGI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DODELEAICGI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HELJKFMIFFE != other.HELJKFMIFFE)
		{
			return false;
		}
		if (Value != other.Value)
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
		if (HELJKFMIFFE.Length != 0)
		{
			num ^= HELJKFMIFFE.GetHashCode();
		}
		if (Value.Length != 0)
		{
			num ^= Value.GetHashCode();
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
		if (HELJKFMIFFE.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(HELJKFMIFFE);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Value);
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
		if (HELJKFMIFFE.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HELJKFMIFFE);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DODELEAICGI other)
	{
		if (other != null)
		{
			if (other.HELJKFMIFFE.Length != 0)
			{
				HELJKFMIFFE = other.HELJKFMIFFE;
			}
			if (other.Value.Length != 0)
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
			case 10u:
				HELJKFMIFFE = input.ReadString();
				break;
			case 18u:
				Value = input.ReadString();
				break;
			}
		}
	}
}
