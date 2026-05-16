using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCFEENNNCBL : IMessage<JCFEENNNCBL>, IMessage, IEquatable<JCFEENNNCBL>, IDeepCloneable<JCFEENNNCBL>, IBufferMessage
{
	private static readonly MessageParser<JCFEENNNCBL> _parser = new MessageParser<JCFEENNNCBL>(() => new JCFEENNNCBL());

	private UnknownFieldSet _unknownFields;

	public const int FNABANJOJMOFieldNumber = 2;

	private uint fNABANJOJMO_;

	public const int GDFKOHMNFAAFieldNumber = 15;

	private uint gDFKOHMNFAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCFEENNNCBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCFEENNNCBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FNABANJOJMO
	{
		get
		{
			return fNABANJOJMO_;
		}
		set
		{
			fNABANJOJMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDFKOHMNFAA
	{
		get
		{
			return gDFKOHMNFAA_;
		}
		set
		{
			gDFKOHMNFAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFEENNNCBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFEENNNCBL(JCFEENNNCBL other)
		: this()
	{
		fNABANJOJMO_ = other.fNABANJOJMO_;
		gDFKOHMNFAA_ = other.gDFKOHMNFAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFEENNNCBL Clone()
	{
		return new JCFEENNNCBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCFEENNNCBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCFEENNNCBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FNABANJOJMO != other.FNABANJOJMO)
		{
			return false;
		}
		if (GDFKOHMNFAA != other.GDFKOHMNFAA)
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
		if (FNABANJOJMO != 0)
		{
			num ^= FNABANJOJMO.GetHashCode();
		}
		if (GDFKOHMNFAA != 0)
		{
			num ^= GDFKOHMNFAA.GetHashCode();
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
		if (FNABANJOJMO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FNABANJOJMO);
		}
		if (GDFKOHMNFAA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GDFKOHMNFAA);
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
		if (FNABANJOJMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNABANJOJMO);
		}
		if (GDFKOHMNFAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDFKOHMNFAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCFEENNNCBL other)
	{
		if (other != null)
		{
			if (other.FNABANJOJMO != 0)
			{
				FNABANJOJMO = other.FNABANJOJMO;
			}
			if (other.GDFKOHMNFAA != 0)
			{
				GDFKOHMNFAA = other.GDFKOHMNFAA;
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
			case 16u:
				FNABANJOJMO = input.ReadUInt32();
				break;
			case 120u:
				GDFKOHMNFAA = input.ReadUInt32();
				break;
			}
		}
	}
}
