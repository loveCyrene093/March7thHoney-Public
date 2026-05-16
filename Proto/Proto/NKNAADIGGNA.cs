using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NKNAADIGGNA : IMessage<NKNAADIGGNA>, IMessage, IEquatable<NKNAADIGGNA>, IDeepCloneable<NKNAADIGGNA>, IBufferMessage
{
	private static readonly MessageParser<NKNAADIGGNA> _parser = new MessageParser<NKNAADIGGNA>(() => new NKNAADIGGNA());

	private UnknownFieldSet _unknownFields;

	public const int HIEDKHFPPOFFieldNumber = 11;

	private uint hIEDKHFPPOF_;

	public const int PHOGLEPHGOFFieldNumber = 14;

	private uint pHOGLEPHGOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NKNAADIGGNA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NKNAADIGGNAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HIEDKHFPPOF
	{
		get
		{
			return hIEDKHFPPOF_;
		}
		set
		{
			hIEDKHFPPOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHOGLEPHGOF
	{
		get
		{
			return pHOGLEPHGOF_;
		}
		set
		{
			pHOGLEPHGOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKNAADIGGNA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKNAADIGGNA(NKNAADIGGNA other)
		: this()
	{
		hIEDKHFPPOF_ = other.hIEDKHFPPOF_;
		pHOGLEPHGOF_ = other.pHOGLEPHGOF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKNAADIGGNA Clone()
	{
		return new NKNAADIGGNA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NKNAADIGGNA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NKNAADIGGNA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HIEDKHFPPOF != other.HIEDKHFPPOF)
		{
			return false;
		}
		if (PHOGLEPHGOF != other.PHOGLEPHGOF)
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
		if (HIEDKHFPPOF != 0)
		{
			num ^= HIEDKHFPPOF.GetHashCode();
		}
		if (PHOGLEPHGOF != 0)
		{
			num ^= PHOGLEPHGOF.GetHashCode();
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
		if (HIEDKHFPPOF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HIEDKHFPPOF);
		}
		if (PHOGLEPHGOF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PHOGLEPHGOF);
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
		if (HIEDKHFPPOF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HIEDKHFPPOF);
		}
		if (PHOGLEPHGOF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHOGLEPHGOF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NKNAADIGGNA other)
	{
		if (other != null)
		{
			if (other.HIEDKHFPPOF != 0)
			{
				HIEDKHFPPOF = other.HIEDKHFPPOF;
			}
			if (other.PHOGLEPHGOF != 0)
			{
				PHOGLEPHGOF = other.PHOGLEPHGOF;
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
			case 88u:
				HIEDKHFPPOF = input.ReadUInt32();
				break;
			case 112u:
				PHOGLEPHGOF = input.ReadUInt32();
				break;
			}
		}
	}
}
