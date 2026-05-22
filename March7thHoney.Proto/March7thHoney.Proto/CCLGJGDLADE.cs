using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCLGJGDLADE : IMessage<CCLGJGDLADE>, IMessage, IEquatable<CCLGJGDLADE>, IDeepCloneable<CCLGJGDLADE>, IBufferMessage
{
	private static readonly MessageParser<CCLGJGDLADE> _parser = new MessageParser<CCLGJGDLADE>(() => new CCLGJGDLADE());

	private UnknownFieldSet _unknownFields;

	public const int LBGNHPHHJNEFieldNumber = 1;

	private int lBGNHPHHJNE_;

	public const int ValueFieldNumber = 2;

	private string value_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCLGJGDLADE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCLGJGDLADEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LBGNHPHHJNE
	{
		get
		{
			return lBGNHPHHJNE_;
		}
		set
		{
			lBGNHPHHJNE_ = value;
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
	public CCLGJGDLADE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCLGJGDLADE(CCLGJGDLADE other)
		: this()
	{
		lBGNHPHHJNE_ = other.lBGNHPHHJNE_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCLGJGDLADE Clone()
	{
		return new CCLGJGDLADE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCLGJGDLADE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCLGJGDLADE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LBGNHPHHJNE != other.LBGNHPHHJNE)
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
		if (LBGNHPHHJNE != 0)
		{
			num ^= LBGNHPHHJNE.GetHashCode();
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
		if (LBGNHPHHJNE != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LBGNHPHHJNE);
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
		if (LBGNHPHHJNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LBGNHPHHJNE);
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
	public void MergeFrom(CCLGJGDLADE other)
	{
		if (other != null)
		{
			if (other.LBGNHPHHJNE != 0)
			{
				LBGNHPHHJNE = other.LBGNHPHHJNE;
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
			case 8u:
				LBGNHPHHJNE = input.ReadInt32();
				break;
			case 18u:
				Value = input.ReadString();
				break;
			}
		}
	}
}
