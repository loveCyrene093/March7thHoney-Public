using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPAKFGLHOPM : IMessage<DPAKFGLHOPM>, IMessage, IEquatable<DPAKFGLHOPM>, IDeepCloneable<DPAKFGLHOPM>, IBufferMessage
{
	private static readonly MessageParser<DPAKFGLHOPM> _parser = new MessageParser<DPAKFGLHOPM>(() => new DPAKFGLHOPM());

	private UnknownFieldSet _unknownFields;

	public const int NFINJDMOMMHFieldNumber = 4;

	private uint nFINJDMOMMH_;

	public const int JJPHLLEGFPJFieldNumber = 12;

	private uint jJPHLLEGFPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPAKFGLHOPM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPAKFGLHOPMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFINJDMOMMH
	{
		get
		{
			return nFINJDMOMMH_;
		}
		set
		{
			nFINJDMOMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJPHLLEGFPJ
	{
		get
		{
			return jJPHLLEGFPJ_;
		}
		set
		{
			jJPHLLEGFPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPAKFGLHOPM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPAKFGLHOPM(DPAKFGLHOPM other)
		: this()
	{
		nFINJDMOMMH_ = other.nFINJDMOMMH_;
		jJPHLLEGFPJ_ = other.jJPHLLEGFPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPAKFGLHOPM Clone()
	{
		return new DPAKFGLHOPM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPAKFGLHOPM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPAKFGLHOPM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NFINJDMOMMH != other.NFINJDMOMMH)
		{
			return false;
		}
		if (JJPHLLEGFPJ != other.JJPHLLEGFPJ)
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
		if (NFINJDMOMMH != 0)
		{
			num ^= NFINJDMOMMH.GetHashCode();
		}
		if (JJPHLLEGFPJ != 0)
		{
			num ^= JJPHLLEGFPJ.GetHashCode();
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
		if (NFINJDMOMMH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NFINJDMOMMH);
		}
		if (JJPHLLEGFPJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JJPHLLEGFPJ);
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
		if (NFINJDMOMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFINJDMOMMH);
		}
		if (JJPHLLEGFPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJPHLLEGFPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPAKFGLHOPM other)
	{
		if (other != null)
		{
			if (other.NFINJDMOMMH != 0)
			{
				NFINJDMOMMH = other.NFINJDMOMMH;
			}
			if (other.JJPHLLEGFPJ != 0)
			{
				JJPHLLEGFPJ = other.JJPHLLEGFPJ;
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
				NFINJDMOMMH = input.ReadUInt32();
				break;
			case 96u:
				JJPHLLEGFPJ = input.ReadUInt32();
				break;
			}
		}
	}
}
