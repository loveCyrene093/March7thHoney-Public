using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MNGIIJPMJBE : IMessage<MNGIIJPMJBE>, IMessage, IEquatable<MNGIIJPMJBE>, IDeepCloneable<MNGIIJPMJBE>, IBufferMessage
{
	private static readonly MessageParser<MNGIIJPMJBE> _parser = new MessageParser<MNGIIJPMJBE>(() => new MNGIIJPMJBE());

	private UnknownFieldSet _unknownFields;

	public const int JAAMMNLMJCGFieldNumber = 7;

	private uint jAAMMNLMJCG_;

	public const int EAKBDLKIEFCFieldNumber = 9;

	private uint eAKBDLKIEFC_;

	public const int FFIOFGADINMFieldNumber = 10;

	private uint fFIOFGADINM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MNGIIJPMJBE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MNGIIJPMJBEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAAMMNLMJCG
	{
		get
		{
			return jAAMMNLMJCG_;
		}
		set
		{
			jAAMMNLMJCG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EAKBDLKIEFC
	{
		get
		{
			return eAKBDLKIEFC_;
		}
		set
		{
			eAKBDLKIEFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FFIOFGADINM
	{
		get
		{
			return fFIOFGADINM_;
		}
		set
		{
			fFIOFGADINM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNGIIJPMJBE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNGIIJPMJBE(MNGIIJPMJBE other)
		: this()
	{
		jAAMMNLMJCG_ = other.jAAMMNLMJCG_;
		eAKBDLKIEFC_ = other.eAKBDLKIEFC_;
		fFIOFGADINM_ = other.fFIOFGADINM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNGIIJPMJBE Clone()
	{
		return new MNGIIJPMJBE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MNGIIJPMJBE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MNGIIJPMJBE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JAAMMNLMJCG != other.JAAMMNLMJCG)
		{
			return false;
		}
		if (EAKBDLKIEFC != other.EAKBDLKIEFC)
		{
			return false;
		}
		if (FFIOFGADINM != other.FFIOFGADINM)
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
		if (JAAMMNLMJCG != 0)
		{
			num ^= JAAMMNLMJCG.GetHashCode();
		}
		if (EAKBDLKIEFC != 0)
		{
			num ^= EAKBDLKIEFC.GetHashCode();
		}
		if (FFIOFGADINM != 0)
		{
			num ^= FFIOFGADINM.GetHashCode();
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
		if (JAAMMNLMJCG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JAAMMNLMJCG);
		}
		if (EAKBDLKIEFC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EAKBDLKIEFC);
		}
		if (FFIOFGADINM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FFIOFGADINM);
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
		if (JAAMMNLMJCG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAAMMNLMJCG);
		}
		if (EAKBDLKIEFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EAKBDLKIEFC);
		}
		if (FFIOFGADINM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FFIOFGADINM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MNGIIJPMJBE other)
	{
		if (other != null)
		{
			if (other.JAAMMNLMJCG != 0)
			{
				JAAMMNLMJCG = other.JAAMMNLMJCG;
			}
			if (other.EAKBDLKIEFC != 0)
			{
				EAKBDLKIEFC = other.EAKBDLKIEFC;
			}
			if (other.FFIOFGADINM != 0)
			{
				FFIOFGADINM = other.FFIOFGADINM;
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
			case 56u:
				JAAMMNLMJCG = input.ReadUInt32();
				break;
			case 72u:
				EAKBDLKIEFC = input.ReadUInt32();
				break;
			case 80u:
				FFIOFGADINM = input.ReadUInt32();
				break;
			}
		}
	}
}
