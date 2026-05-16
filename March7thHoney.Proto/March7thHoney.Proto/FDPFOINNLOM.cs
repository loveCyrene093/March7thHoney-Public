using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FDPFOINNLOM : IMessage<FDPFOINNLOM>, IMessage, IEquatable<FDPFOINNLOM>, IDeepCloneable<FDPFOINNLOM>, IBufferMessage
{
	private static readonly MessageParser<FDPFOINNLOM> _parser = new MessageParser<FDPFOINNLOM>(() => new FDPFOINNLOM());

	private UnknownFieldSet _unknownFields;

	public const int CGOABGKCBEFFieldNumber = 7;

	private uint cGOABGKCBEF_;

	public const int DDBHACOPEGGFieldNumber = 13;

	private uint dDBHACOPEGG_;

	public const int LLEEFDGJBKAFieldNumber = 15;

	private uint lLEEFDGJBKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FDPFOINNLOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FDPFOINNLOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGOABGKCBEF
	{
		get
		{
			return cGOABGKCBEF_;
		}
		set
		{
			cGOABGKCBEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDBHACOPEGG
	{
		get
		{
			return dDBHACOPEGG_;
		}
		set
		{
			dDBHACOPEGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLEEFDGJBKA
	{
		get
		{
			return lLEEFDGJBKA_;
		}
		set
		{
			lLEEFDGJBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDPFOINNLOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDPFOINNLOM(FDPFOINNLOM other)
		: this()
	{
		cGOABGKCBEF_ = other.cGOABGKCBEF_;
		dDBHACOPEGG_ = other.dDBHACOPEGG_;
		lLEEFDGJBKA_ = other.lLEEFDGJBKA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDPFOINNLOM Clone()
	{
		return new FDPFOINNLOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FDPFOINNLOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FDPFOINNLOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CGOABGKCBEF != other.CGOABGKCBEF)
		{
			return false;
		}
		if (DDBHACOPEGG != other.DDBHACOPEGG)
		{
			return false;
		}
		if (LLEEFDGJBKA != other.LLEEFDGJBKA)
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
		if (CGOABGKCBEF != 0)
		{
			num ^= CGOABGKCBEF.GetHashCode();
		}
		if (DDBHACOPEGG != 0)
		{
			num ^= DDBHACOPEGG.GetHashCode();
		}
		if (LLEEFDGJBKA != 0)
		{
			num ^= LLEEFDGJBKA.GetHashCode();
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
		if (CGOABGKCBEF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(CGOABGKCBEF);
		}
		if (DDBHACOPEGG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DDBHACOPEGG);
		}
		if (LLEEFDGJBKA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LLEEFDGJBKA);
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
		if (CGOABGKCBEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGOABGKCBEF);
		}
		if (DDBHACOPEGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDBHACOPEGG);
		}
		if (LLEEFDGJBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLEEFDGJBKA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FDPFOINNLOM other)
	{
		if (other != null)
		{
			if (other.CGOABGKCBEF != 0)
			{
				CGOABGKCBEF = other.CGOABGKCBEF;
			}
			if (other.DDBHACOPEGG != 0)
			{
				DDBHACOPEGG = other.DDBHACOPEGG;
			}
			if (other.LLEEFDGJBKA != 0)
			{
				LLEEFDGJBKA = other.LLEEFDGJBKA;
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
				CGOABGKCBEF = input.ReadUInt32();
				break;
			case 104u:
				DDBHACOPEGG = input.ReadUInt32();
				break;
			case 120u:
				LLEEFDGJBKA = input.ReadUInt32();
				break;
			}
		}
	}
}
