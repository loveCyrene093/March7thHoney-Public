using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AKEKHLAEKBC : IMessage<AKEKHLAEKBC>, IMessage, IEquatable<AKEKHLAEKBC>, IDeepCloneable<AKEKHLAEKBC>, IBufferMessage
{
	private static readonly MessageParser<AKEKHLAEKBC> _parser = new MessageParser<AKEKHLAEKBC>(() => new AKEKHLAEKBC());

	private UnknownFieldSet _unknownFields;

	public const int ICDNIPHLFFCFieldNumber = 4;

	private uint iCDNIPHLFFC_;

	public const int CNDKAPOIEOJFieldNumber = 10;

	private bool cNDKAPOIEOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AKEKHLAEKBC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AKEKHLAEKBCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ICDNIPHLFFC
	{
		get
		{
			return iCDNIPHLFFC_;
		}
		set
		{
			iCDNIPHLFFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CNDKAPOIEOJ
	{
		get
		{
			return cNDKAPOIEOJ_;
		}
		set
		{
			cNDKAPOIEOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKEKHLAEKBC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKEKHLAEKBC(AKEKHLAEKBC other)
		: this()
	{
		iCDNIPHLFFC_ = other.iCDNIPHLFFC_;
		cNDKAPOIEOJ_ = other.cNDKAPOIEOJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKEKHLAEKBC Clone()
	{
		return new AKEKHLAEKBC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AKEKHLAEKBC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AKEKHLAEKBC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ICDNIPHLFFC != other.ICDNIPHLFFC)
		{
			return false;
		}
		if (CNDKAPOIEOJ != other.CNDKAPOIEOJ)
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
		if (ICDNIPHLFFC != 0)
		{
			num ^= ICDNIPHLFFC.GetHashCode();
		}
		if (CNDKAPOIEOJ)
		{
			num ^= CNDKAPOIEOJ.GetHashCode();
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
		if (ICDNIPHLFFC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ICDNIPHLFFC);
		}
		if (CNDKAPOIEOJ)
		{
			output.WriteRawTag(80);
			output.WriteBool(CNDKAPOIEOJ);
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
		if (ICDNIPHLFFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ICDNIPHLFFC);
		}
		if (CNDKAPOIEOJ)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AKEKHLAEKBC other)
	{
		if (other != null)
		{
			if (other.ICDNIPHLFFC != 0)
			{
				ICDNIPHLFFC = other.ICDNIPHLFFC;
			}
			if (other.CNDKAPOIEOJ)
			{
				CNDKAPOIEOJ = other.CNDKAPOIEOJ;
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
				ICDNIPHLFFC = input.ReadUInt32();
				break;
			case 80u:
				CNDKAPOIEOJ = input.ReadBool();
				break;
			}
		}
	}
}
