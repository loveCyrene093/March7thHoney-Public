using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NJINCNAGALP : IMessage<NJINCNAGALP>, IMessage, IEquatable<NJINCNAGALP>, IDeepCloneable<NJINCNAGALP>, IBufferMessage
{
	private static readonly MessageParser<NJINCNAGALP> _parser = new MessageParser<NJINCNAGALP>(() => new NJINCNAGALP());

	private UnknownFieldSet _unknownFields;

	public const int AOKDBDGDCHBFieldNumber = 9;

	private uint aOKDBDGDCHB_;

	public const int CEHOPHJHDEFFieldNumber = 11;

	private uint cEHOPHJHDEF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NJINCNAGALP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NJINCNAGALPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOKDBDGDCHB
	{
		get
		{
			return aOKDBDGDCHB_;
		}
		set
		{
			aOKDBDGDCHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEHOPHJHDEF
	{
		get
		{
			return cEHOPHJHDEF_;
		}
		set
		{
			cEHOPHJHDEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJINCNAGALP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJINCNAGALP(NJINCNAGALP other)
		: this()
	{
		aOKDBDGDCHB_ = other.aOKDBDGDCHB_;
		cEHOPHJHDEF_ = other.cEHOPHJHDEF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJINCNAGALP Clone()
	{
		return new NJINCNAGALP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NJINCNAGALP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NJINCNAGALP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOKDBDGDCHB != other.AOKDBDGDCHB)
		{
			return false;
		}
		if (CEHOPHJHDEF != other.CEHOPHJHDEF)
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
		if (AOKDBDGDCHB != 0)
		{
			num ^= AOKDBDGDCHB.GetHashCode();
		}
		if (CEHOPHJHDEF != 0)
		{
			num ^= CEHOPHJHDEF.GetHashCode();
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
		if (AOKDBDGDCHB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AOKDBDGDCHB);
		}
		if (CEHOPHJHDEF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CEHOPHJHDEF);
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
		if (AOKDBDGDCHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOKDBDGDCHB);
		}
		if (CEHOPHJHDEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEHOPHJHDEF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NJINCNAGALP other)
	{
		if (other != null)
		{
			if (other.AOKDBDGDCHB != 0)
			{
				AOKDBDGDCHB = other.AOKDBDGDCHB;
			}
			if (other.CEHOPHJHDEF != 0)
			{
				CEHOPHJHDEF = other.CEHOPHJHDEF;
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
			case 72u:
				AOKDBDGDCHB = input.ReadUInt32();
				break;
			case 88u:
				CEHOPHJHDEF = input.ReadUInt32();
				break;
			}
		}
	}
}
