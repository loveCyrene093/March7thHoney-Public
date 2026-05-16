using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DELKBEHMMNG : IMessage<DELKBEHMMNG>, IMessage, IEquatable<DELKBEHMMNG>, IDeepCloneable<DELKBEHMMNG>, IBufferMessage
{
	private static readonly MessageParser<DELKBEHMMNG> _parser = new MessageParser<DELKBEHMMNG>(() => new DELKBEHMMNG());

	private UnknownFieldSet _unknownFields;

	public const int FEOBEPGGMEFFieldNumber = 10;

	private uint fEOBEPGGMEF_;

	public const int TypeFieldNumber = 11;

	private HEKPNLEJADB type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DELKBEHMMNG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DELKBEHMMNGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FEOBEPGGMEF
	{
		get
		{
			return fEOBEPGGMEF_;
		}
		set
		{
			fEOBEPGGMEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEKPNLEJADB Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DELKBEHMMNG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DELKBEHMMNG(DELKBEHMMNG other)
		: this()
	{
		fEOBEPGGMEF_ = other.fEOBEPGGMEF_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DELKBEHMMNG Clone()
	{
		return new DELKBEHMMNG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DELKBEHMMNG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DELKBEHMMNG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FEOBEPGGMEF != other.FEOBEPGGMEF)
		{
			return false;
		}
		if (Type != other.Type)
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
		if (FEOBEPGGMEF != 0)
		{
			num ^= FEOBEPGGMEF.GetHashCode();
		}
		if (Type != HEKPNLEJADB.Gmincmkdpne)
		{
			num ^= Type.GetHashCode();
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
		if (FEOBEPGGMEF != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FEOBEPGGMEF);
		}
		if (Type != HEKPNLEJADB.Gmincmkdpne)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Type);
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
		if (FEOBEPGGMEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FEOBEPGGMEF);
		}
		if (Type != HEKPNLEJADB.Gmincmkdpne)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DELKBEHMMNG other)
	{
		if (other != null)
		{
			if (other.FEOBEPGGMEF != 0)
			{
				FEOBEPGGMEF = other.FEOBEPGGMEF;
			}
			if (other.Type != HEKPNLEJADB.Gmincmkdpne)
			{
				Type = other.Type;
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
			case 80u:
				FEOBEPGGMEF = input.ReadUInt32();
				break;
			case 88u:
				Type = (HEKPNLEJADB)input.ReadEnum();
				break;
			}
		}
	}
}
