using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GEJEOCBFPMA : IMessage<GEJEOCBFPMA>, IMessage, IEquatable<GEJEOCBFPMA>, IDeepCloneable<GEJEOCBFPMA>, IBufferMessage
{
	private static readonly MessageParser<GEJEOCBFPMA> _parser = new MessageParser<GEJEOCBFPMA>(() => new GEJEOCBFPMA());

	private UnknownFieldSet _unknownFields;

	public const int FEOJILNJEMMFieldNumber = 2;

	private uint fEOJILNJEMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GEJEOCBFPMA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GEJEOCBFPMAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FEOJILNJEMM
	{
		get
		{
			return fEOJILNJEMM_;
		}
		set
		{
			fEOJILNJEMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEJEOCBFPMA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEJEOCBFPMA(GEJEOCBFPMA other)
		: this()
	{
		fEOJILNJEMM_ = other.fEOJILNJEMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEJEOCBFPMA Clone()
	{
		return new GEJEOCBFPMA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GEJEOCBFPMA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GEJEOCBFPMA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FEOJILNJEMM != other.FEOJILNJEMM)
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
		if (FEOJILNJEMM != 0)
		{
			num ^= FEOJILNJEMM.GetHashCode();
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
		if (FEOJILNJEMM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FEOJILNJEMM);
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
		if (FEOJILNJEMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FEOJILNJEMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GEJEOCBFPMA other)
	{
		if (other != null)
		{
			if (other.FEOJILNJEMM != 0)
			{
				FEOJILNJEMM = other.FEOJILNJEMM;
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
			if (num != 16)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FEOJILNJEMM = input.ReadUInt32();
			}
		}
	}
}
