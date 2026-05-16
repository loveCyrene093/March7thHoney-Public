using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADMKICHLGBP : IMessage<ADMKICHLGBP>, IMessage, IEquatable<ADMKICHLGBP>, IDeepCloneable<ADMKICHLGBP>, IBufferMessage
{
	private static readonly MessageParser<ADMKICHLGBP> _parser = new MessageParser<ADMKICHLGBP>(() => new ADMKICHLGBP());

	private UnknownFieldSet _unknownFields;

	public const int DDIFEFOGGMLFieldNumber = 4;

	private uint dDIFEFOGGML_;

	public const int FOMNFHJCDOCFieldNumber = 9;

	private uint fOMNFHJCDOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADMKICHLGBP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADMKICHLGBPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDIFEFOGGML
	{
		get
		{
			return dDIFEFOGGML_;
		}
		set
		{
			dDIFEFOGGML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOMNFHJCDOC
	{
		get
		{
			return fOMNFHJCDOC_;
		}
		set
		{
			fOMNFHJCDOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMKICHLGBP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMKICHLGBP(ADMKICHLGBP other)
		: this()
	{
		dDIFEFOGGML_ = other.dDIFEFOGGML_;
		fOMNFHJCDOC_ = other.fOMNFHJCDOC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMKICHLGBP Clone()
	{
		return new ADMKICHLGBP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADMKICHLGBP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADMKICHLGBP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DDIFEFOGGML != other.DDIFEFOGGML)
		{
			return false;
		}
		if (FOMNFHJCDOC != other.FOMNFHJCDOC)
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
		if (DDIFEFOGGML != 0)
		{
			num ^= DDIFEFOGGML.GetHashCode();
		}
		if (FOMNFHJCDOC != 0)
		{
			num ^= FOMNFHJCDOC.GetHashCode();
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
		if (DDIFEFOGGML != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DDIFEFOGGML);
		}
		if (FOMNFHJCDOC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FOMNFHJCDOC);
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
		if (DDIFEFOGGML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDIFEFOGGML);
		}
		if (FOMNFHJCDOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOMNFHJCDOC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADMKICHLGBP other)
	{
		if (other != null)
		{
			if (other.DDIFEFOGGML != 0)
			{
				DDIFEFOGGML = other.DDIFEFOGGML;
			}
			if (other.FOMNFHJCDOC != 0)
			{
				FOMNFHJCDOC = other.FOMNFHJCDOC;
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
			case 32u:
				DDIFEFOGGML = input.ReadUInt32();
				break;
			case 72u:
				FOMNFHJCDOC = input.ReadUInt32();
				break;
			}
		}
	}
}
