using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBOCLMGMNEB : IMessage<BBOCLMGMNEB>, IMessage, IEquatable<BBOCLMGMNEB>, IDeepCloneable<BBOCLMGMNEB>, IBufferMessage
{
	private static readonly MessageParser<BBOCLMGMNEB> _parser = new MessageParser<BBOCLMGMNEB>(() => new BBOCLMGMNEB());

	private UnknownFieldSet _unknownFields;

	public const int GachaRandomFieldNumber = 6;

	private uint gachaRandom_;

	public const int NAIPLDPJHIIFieldNumber = 9;

	private bool nAIPLDPJHII_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBOCLMGMNEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBOCLMGMNEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaRandom
	{
		get
		{
			return gachaRandom_;
		}
		set
		{
			gachaRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NAIPLDPJHII
	{
		get
		{
			return nAIPLDPJHII_;
		}
		set
		{
			nAIPLDPJHII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOCLMGMNEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOCLMGMNEB(BBOCLMGMNEB other)
		: this()
	{
		gachaRandom_ = other.gachaRandom_;
		nAIPLDPJHII_ = other.nAIPLDPJHII_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBOCLMGMNEB Clone()
	{
		return new BBOCLMGMNEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBOCLMGMNEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBOCLMGMNEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaRandom != other.GachaRandom)
		{
			return false;
		}
		if (NAIPLDPJHII != other.NAIPLDPJHII)
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
		if (GachaRandom != 0)
		{
			num ^= GachaRandom.GetHashCode();
		}
		if (NAIPLDPJHII)
		{
			num ^= NAIPLDPJHII.GetHashCode();
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
		if (GachaRandom != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GachaRandom);
		}
		if (NAIPLDPJHII)
		{
			output.WriteRawTag(72);
			output.WriteBool(NAIPLDPJHII);
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
		if (GachaRandom != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaRandom);
		}
		if (NAIPLDPJHII)
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
	public void MergeFrom(BBOCLMGMNEB other)
	{
		if (other != null)
		{
			if (other.GachaRandom != 0)
			{
				GachaRandom = other.GachaRandom;
			}
			if (other.NAIPLDPJHII)
			{
				NAIPLDPJHII = other.NAIPLDPJHII;
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
			case 48u:
				GachaRandom = input.ReadUInt32();
				break;
			case 72u:
				NAIPLDPJHII = input.ReadBool();
				break;
			}
		}
	}
}
