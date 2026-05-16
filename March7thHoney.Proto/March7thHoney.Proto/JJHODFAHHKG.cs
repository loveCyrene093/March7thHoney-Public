using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JJHODFAHHKG : IMessage<JJHODFAHHKG>, IMessage, IEquatable<JJHODFAHHKG>, IDeepCloneable<JJHODFAHHKG>, IBufferMessage
{
	private static readonly MessageParser<JJHODFAHHKG> _parser = new MessageParser<JJHODFAHHKG>(() => new JJHODFAHHKG());

	private UnknownFieldSet _unknownFields;

	public const int HCAEJFMKMNDFieldNumber = 3;

	private uint hCAEJFMKMND_;

	public const int StatusFieldNumber = 6;

	private LKBGOMGHGLG status_;

	public const int NOFLNIMBDOFFieldNumber = 12;

	private uint nOFLNIMBDOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JJHODFAHHKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JJHODFAHHKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCAEJFMKMND
	{
		get
		{
			return hCAEJFMKMND_;
		}
		set
		{
			hCAEJFMKMND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBGOMGHGLG Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOFLNIMBDOF
	{
		get
		{
			return nOFLNIMBDOF_;
		}
		set
		{
			nOFLNIMBDOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JJHODFAHHKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JJHODFAHHKG(JJHODFAHHKG other)
		: this()
	{
		hCAEJFMKMND_ = other.hCAEJFMKMND_;
		status_ = other.status_;
		nOFLNIMBDOF_ = other.nOFLNIMBDOF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JJHODFAHHKG Clone()
	{
		return new JJHODFAHHKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JJHODFAHHKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JJHODFAHHKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCAEJFMKMND != other.HCAEJFMKMND)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (NOFLNIMBDOF != other.NOFLNIMBDOF)
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
		if (HCAEJFMKMND != 0)
		{
			num ^= HCAEJFMKMND.GetHashCode();
		}
		if (Status != LKBGOMGHGLG.Jdinpiohiei)
		{
			num ^= Status.GetHashCode();
		}
		if (NOFLNIMBDOF != 0)
		{
			num ^= NOFLNIMBDOF.GetHashCode();
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
		if (HCAEJFMKMND != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HCAEJFMKMND);
		}
		if (Status != LKBGOMGHGLG.Jdinpiohiei)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Status);
		}
		if (NOFLNIMBDOF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NOFLNIMBDOF);
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
		if (HCAEJFMKMND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCAEJFMKMND);
		}
		if (Status != LKBGOMGHGLG.Jdinpiohiei)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (NOFLNIMBDOF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOFLNIMBDOF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JJHODFAHHKG other)
	{
		if (other != null)
		{
			if (other.HCAEJFMKMND != 0)
			{
				HCAEJFMKMND = other.HCAEJFMKMND;
			}
			if (other.Status != LKBGOMGHGLG.Jdinpiohiei)
			{
				Status = other.Status;
			}
			if (other.NOFLNIMBDOF != 0)
			{
				NOFLNIMBDOF = other.NOFLNIMBDOF;
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
			case 24u:
				HCAEJFMKMND = input.ReadUInt32();
				break;
			case 48u:
				Status = (LKBGOMGHGLG)input.ReadEnum();
				break;
			case 96u:
				NOFLNIMBDOF = input.ReadUInt32();
				break;
			}
		}
	}
}
