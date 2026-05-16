using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JHAKADEKJEJ : IMessage<JHAKADEKJEJ>, IMessage, IEquatable<JHAKADEKJEJ>, IDeepCloneable<JHAKADEKJEJ>, IBufferMessage
{
	private static readonly MessageParser<JHAKADEKJEJ> _parser = new MessageParser<JHAKADEKJEJ>(() => new JHAKADEKJEJ());

	private UnknownFieldSet _unknownFields;

	public const int CGHMNCEAPPBFieldNumber = 4;

	private int cGHMNCEAPPB_;

	public const int EIPLGIIHDIDFieldNumber = 6;

	private int eIPLGIIHDID_;

	public const int AKAFHHLKFKIFieldNumber = 9;

	private int aKAFHHLKFKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JHAKADEKJEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JHAKADEKJEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CGHMNCEAPPB
	{
		get
		{
			return cGHMNCEAPPB_;
		}
		set
		{
			cGHMNCEAPPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EIPLGIIHDID
	{
		get
		{
			return eIPLGIIHDID_;
		}
		set
		{
			eIPLGIIHDID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AKAFHHLKFKI
	{
		get
		{
			return aKAFHHLKFKI_;
		}
		set
		{
			aKAFHHLKFKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHAKADEKJEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHAKADEKJEJ(JHAKADEKJEJ other)
		: this()
	{
		cGHMNCEAPPB_ = other.cGHMNCEAPPB_;
		eIPLGIIHDID_ = other.eIPLGIIHDID_;
		aKAFHHLKFKI_ = other.aKAFHHLKFKI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHAKADEKJEJ Clone()
	{
		return new JHAKADEKJEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JHAKADEKJEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JHAKADEKJEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CGHMNCEAPPB != other.CGHMNCEAPPB)
		{
			return false;
		}
		if (EIPLGIIHDID != other.EIPLGIIHDID)
		{
			return false;
		}
		if (AKAFHHLKFKI != other.AKAFHHLKFKI)
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
		if (CGHMNCEAPPB != 0)
		{
			num ^= CGHMNCEAPPB.GetHashCode();
		}
		if (EIPLGIIHDID != 0)
		{
			num ^= EIPLGIIHDID.GetHashCode();
		}
		if (AKAFHHLKFKI != 0)
		{
			num ^= AKAFHHLKFKI.GetHashCode();
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
		if (CGHMNCEAPPB != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CGHMNCEAPPB);
		}
		if (EIPLGIIHDID != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EIPLGIIHDID);
		}
		if (AKAFHHLKFKI != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AKAFHHLKFKI);
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
		if (CGHMNCEAPPB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CGHMNCEAPPB);
		}
		if (EIPLGIIHDID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EIPLGIIHDID);
		}
		if (AKAFHHLKFKI != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AKAFHHLKFKI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JHAKADEKJEJ other)
	{
		if (other != null)
		{
			if (other.CGHMNCEAPPB != 0)
			{
				CGHMNCEAPPB = other.CGHMNCEAPPB;
			}
			if (other.EIPLGIIHDID != 0)
			{
				EIPLGIIHDID = other.EIPLGIIHDID;
			}
			if (other.AKAFHHLKFKI != 0)
			{
				AKAFHHLKFKI = other.AKAFHHLKFKI;
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
				CGHMNCEAPPB = input.ReadInt32();
				break;
			case 48u:
				EIPLGIIHDID = input.ReadInt32();
				break;
			case 72u:
				AKAFHHLKFKI = input.ReadInt32();
				break;
			}
		}
	}
}
