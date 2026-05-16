using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCICEMDDGEM : IMessage<BCICEMDDGEM>, IMessage, IEquatable<BCICEMDDGEM>, IDeepCloneable<BCICEMDDGEM>, IBufferMessage
{
	private static readonly MessageParser<BCICEMDDGEM> _parser = new MessageParser<BCICEMDDGEM>(() => new BCICEMDDGEM());

	private UnknownFieldSet _unknownFields;

	public const int MJDMLOIHLPAFieldNumber = 10;

	private DDKHEFEBFAJ mJDMLOIHLPA_;

	public const int ValueFieldNumber = 13;

	private uint value_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCICEMDDGEM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCICEMDDGEMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDKHEFEBFAJ MJDMLOIHLPA
	{
		get
		{
			return mJDMLOIHLPA_;
		}
		set
		{
			mJDMLOIHLPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Value
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
	public BCICEMDDGEM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCICEMDDGEM(BCICEMDDGEM other)
		: this()
	{
		mJDMLOIHLPA_ = other.mJDMLOIHLPA_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCICEMDDGEM Clone()
	{
		return new BCICEMDDGEM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCICEMDDGEM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCICEMDDGEM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MJDMLOIHLPA != other.MJDMLOIHLPA)
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
		if (MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
		{
			num ^= MJDMLOIHLPA.GetHashCode();
		}
		if (Value != 0)
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
		if (MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)MJDMLOIHLPA);
		}
		if (Value != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Value);
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
		if (MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MJDMLOIHLPA);
		}
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCICEMDDGEM other)
	{
		if (other != null)
		{
			if (other.MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
			{
				MJDMLOIHLPA = other.MJDMLOIHLPA;
			}
			if (other.Value != 0)
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
			case 80u:
				MJDMLOIHLPA = (DDKHEFEBFAJ)input.ReadEnum();
				break;
			case 104u:
				Value = input.ReadUInt32();
				break;
			}
		}
	}
}
