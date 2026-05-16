using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IAHHLIOLCDB : IMessage<IAHHLIOLCDB>, IMessage, IEquatable<IAHHLIOLCDB>, IDeepCloneable<IAHHLIOLCDB>, IBufferMessage
{
	private static readonly MessageParser<IAHHLIOLCDB> _parser = new MessageParser<IAHHLIOLCDB>(() => new IAHHLIOLCDB());

	private UnknownFieldSet _unknownFields;

	public const int NNBKPDKPIGIFieldNumber = 6;

	private uint nNBKPDKPIGI_;

	public const int BHAPDDJEHPJFieldNumber = 13;

	private uint bHAPDDJEHPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IAHHLIOLCDB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IAHHLIOLCDBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNBKPDKPIGI
	{
		get
		{
			return nNBKPDKPIGI_;
		}
		set
		{
			nNBKPDKPIGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHAPDDJEHPJ
	{
		get
		{
			return bHAPDDJEHPJ_;
		}
		set
		{
			bHAPDDJEHPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAHHLIOLCDB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAHHLIOLCDB(IAHHLIOLCDB other)
		: this()
	{
		nNBKPDKPIGI_ = other.nNBKPDKPIGI_;
		bHAPDDJEHPJ_ = other.bHAPDDJEHPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAHHLIOLCDB Clone()
	{
		return new IAHHLIOLCDB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IAHHLIOLCDB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IAHHLIOLCDB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NNBKPDKPIGI != other.NNBKPDKPIGI)
		{
			return false;
		}
		if (BHAPDDJEHPJ != other.BHAPDDJEHPJ)
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
		if (NNBKPDKPIGI != 0)
		{
			num ^= NNBKPDKPIGI.GetHashCode();
		}
		if (BHAPDDJEHPJ != 0)
		{
			num ^= BHAPDDJEHPJ.GetHashCode();
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
		if (NNBKPDKPIGI != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NNBKPDKPIGI);
		}
		if (BHAPDDJEHPJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BHAPDDJEHPJ);
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
		if (NNBKPDKPIGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNBKPDKPIGI);
		}
		if (BHAPDDJEHPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHAPDDJEHPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IAHHLIOLCDB other)
	{
		if (other != null)
		{
			if (other.NNBKPDKPIGI != 0)
			{
				NNBKPDKPIGI = other.NNBKPDKPIGI;
			}
			if (other.BHAPDDJEHPJ != 0)
			{
				BHAPDDJEHPJ = other.BHAPDDJEHPJ;
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
			case 48u:
				NNBKPDKPIGI = input.ReadUInt32();
				break;
			case 104u:
				BHAPDDJEHPJ = input.ReadUInt32();
				break;
			}
		}
	}
}
