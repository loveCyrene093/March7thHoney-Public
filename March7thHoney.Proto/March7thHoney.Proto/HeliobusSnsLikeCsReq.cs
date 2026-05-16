using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusSnsLikeCsReq : IMessage<HeliobusSnsLikeCsReq>, IMessage, IEquatable<HeliobusSnsLikeCsReq>, IDeepCloneable<HeliobusSnsLikeCsReq>, IBufferMessage
{
	private static readonly MessageParser<HeliobusSnsLikeCsReq> _parser = new MessageParser<HeliobusSnsLikeCsReq>(() => new HeliobusSnsLikeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CDKEDFPEFIJFieldNumber = 11;

	private uint cDKEDFPEFIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusSnsLikeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusSnsLikeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDKEDFPEFIJ
	{
		get
		{
			return cDKEDFPEFIJ_;
		}
		set
		{
			cDKEDFPEFIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsLikeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsLikeCsReq(HeliobusSnsLikeCsReq other)
		: this()
	{
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsLikeCsReq Clone()
	{
		return new HeliobusSnsLikeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusSnsLikeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusSnsLikeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
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
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
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
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CDKEDFPEFIJ);
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
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusSnsLikeCsReq other)
	{
		if (other != null)
		{
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CDKEDFPEFIJ = input.ReadUInt32();
			}
		}
	}
}
