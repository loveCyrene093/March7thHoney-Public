using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEBEKIEALFH : IMessage<OEBEKIEALFH>, IMessage, IEquatable<OEBEKIEALFH>, IDeepCloneable<OEBEKIEALFH>, IBufferMessage
{
	private static readonly MessageParser<OEBEKIEALFH> _parser = new MessageParser<OEBEKIEALFH>(() => new OEBEKIEALFH());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 1;

	private uint oFHCNGHJFHI_;

	public const int COLDNELLIIEFieldNumber = 4;

	private static readonly FieldCodec<KHHHFHEODED> _repeated_cOLDNELLIIE_codec = FieldCodec.ForMessage(34u, KHHHFHEODED.Parser);

	private readonly RepeatedField<KHHHFHEODED> cOLDNELLIIE_ = new RepeatedField<KHHHFHEODED>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEBEKIEALFH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEBEKIEALFHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KHHHFHEODED> COLDNELLIIE => cOLDNELLIIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBEKIEALFH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBEKIEALFH(OEBEKIEALFH other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		cOLDNELLIIE_ = other.cOLDNELLIIE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBEKIEALFH Clone()
	{
		return new OEBEKIEALFH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEBEKIEALFH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEBEKIEALFH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (!cOLDNELLIIE_.Equals(other.cOLDNELLIIE_))
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
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		num ^= cOLDNELLIIE_.GetHashCode();
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
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		cOLDNELLIIE_.WriteTo(ref output, _repeated_cOLDNELLIIE_codec);
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
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		num += cOLDNELLIIE_.CalculateSize(_repeated_cOLDNELLIIE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEBEKIEALFH other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			cOLDNELLIIE_.Add(other.cOLDNELLIIE_);
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
			case 8u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 34u:
				cOLDNELLIIE_.AddEntriesFrom(ref input, _repeated_cOLDNELLIIE_codec);
				break;
			}
		}
	}
}
