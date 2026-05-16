using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CEDGNIIEIMC : IMessage<CEDGNIIEIMC>, IMessage, IEquatable<CEDGNIIEIMC>, IDeepCloneable<CEDGNIIEIMC>, IBufferMessage
{
	private static readonly MessageParser<CEDGNIIEIMC> _parser = new MessageParser<CEDGNIIEIMC>(() => new CEDGNIIEIMC());

	private UnknownFieldSet _unknownFields;

	public const int PCGJFIFLKOOFieldNumber = 1;

	private uint pCGJFIFLKOO_;

	public const int JNKBKOCJCKJFieldNumber = 6;

	private string jNKBKOCJCKJ_ = "";

	public const int FFEACPDFAJHFieldNumber = 7;

	private string fFEACPDFAJH_ = "";

	public const int GBMBMFFNKEHFieldNumber = 8;

	private uint gBMBMFFNKEH_;

	public const int CEOFDMCJAPJFieldNumber = 9;

	private uint cEOFDMCJAPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CEDGNIIEIMC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CEDGNIIEIMCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PCGJFIFLKOO
	{
		get
		{
			return pCGJFIFLKOO_;
		}
		set
		{
			pCGJFIFLKOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string JNKBKOCJCKJ
	{
		get
		{
			return jNKBKOCJCKJ_;
		}
		set
		{
			jNKBKOCJCKJ_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FFEACPDFAJH
	{
		get
		{
			return fFEACPDFAJH_;
		}
		set
		{
			fFEACPDFAJH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBMBMFFNKEH
	{
		get
		{
			return gBMBMFFNKEH_;
		}
		set
		{
			gBMBMFFNKEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEOFDMCJAPJ
	{
		get
		{
			return cEOFDMCJAPJ_;
		}
		set
		{
			cEOFDMCJAPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEDGNIIEIMC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEDGNIIEIMC(CEDGNIIEIMC other)
		: this()
	{
		pCGJFIFLKOO_ = other.pCGJFIFLKOO_;
		jNKBKOCJCKJ_ = other.jNKBKOCJCKJ_;
		fFEACPDFAJH_ = other.fFEACPDFAJH_;
		gBMBMFFNKEH_ = other.gBMBMFFNKEH_;
		cEOFDMCJAPJ_ = other.cEOFDMCJAPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEDGNIIEIMC Clone()
	{
		return new CEDGNIIEIMC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CEDGNIIEIMC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CEDGNIIEIMC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PCGJFIFLKOO != other.PCGJFIFLKOO)
		{
			return false;
		}
		if (JNKBKOCJCKJ != other.JNKBKOCJCKJ)
		{
			return false;
		}
		if (FFEACPDFAJH != other.FFEACPDFAJH)
		{
			return false;
		}
		if (GBMBMFFNKEH != other.GBMBMFFNKEH)
		{
			return false;
		}
		if (CEOFDMCJAPJ != other.CEOFDMCJAPJ)
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
		if (PCGJFIFLKOO != 0)
		{
			num ^= PCGJFIFLKOO.GetHashCode();
		}
		if (JNKBKOCJCKJ.Length != 0)
		{
			num ^= JNKBKOCJCKJ.GetHashCode();
		}
		if (FFEACPDFAJH.Length != 0)
		{
			num ^= FFEACPDFAJH.GetHashCode();
		}
		if (GBMBMFFNKEH != 0)
		{
			num ^= GBMBMFFNKEH.GetHashCode();
		}
		if (CEOFDMCJAPJ != 0)
		{
			num ^= CEOFDMCJAPJ.GetHashCode();
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
		if (PCGJFIFLKOO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PCGJFIFLKOO);
		}
		if (JNKBKOCJCKJ.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(JNKBKOCJCKJ);
		}
		if (FFEACPDFAJH.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(FFEACPDFAJH);
		}
		if (GBMBMFFNKEH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GBMBMFFNKEH);
		}
		if (CEOFDMCJAPJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CEOFDMCJAPJ);
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
		if (PCGJFIFLKOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PCGJFIFLKOO);
		}
		if (JNKBKOCJCKJ.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JNKBKOCJCKJ);
		}
		if (FFEACPDFAJH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FFEACPDFAJH);
		}
		if (GBMBMFFNKEH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBMBMFFNKEH);
		}
		if (CEOFDMCJAPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEOFDMCJAPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CEDGNIIEIMC other)
	{
		if (other != null)
		{
			if (other.PCGJFIFLKOO != 0)
			{
				PCGJFIFLKOO = other.PCGJFIFLKOO;
			}
			if (other.JNKBKOCJCKJ.Length != 0)
			{
				JNKBKOCJCKJ = other.JNKBKOCJCKJ;
			}
			if (other.FFEACPDFAJH.Length != 0)
			{
				FFEACPDFAJH = other.FFEACPDFAJH;
			}
			if (other.GBMBMFFNKEH != 0)
			{
				GBMBMFFNKEH = other.GBMBMFFNKEH;
			}
			if (other.CEOFDMCJAPJ != 0)
			{
				CEOFDMCJAPJ = other.CEOFDMCJAPJ;
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
				PCGJFIFLKOO = input.ReadUInt32();
				break;
			case 50u:
				JNKBKOCJCKJ = input.ReadString();
				break;
			case 58u:
				FFEACPDFAJH = input.ReadString();
				break;
			case 64u:
				GBMBMFFNKEH = input.ReadUInt32();
				break;
			case 72u:
				CEOFDMCJAPJ = input.ReadUInt32();
				break;
			}
		}
	}
}
