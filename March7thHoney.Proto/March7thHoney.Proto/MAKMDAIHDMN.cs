using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MAKMDAIHDMN : IMessage<MAKMDAIHDMN>, IMessage, IEquatable<MAKMDAIHDMN>, IDeepCloneable<MAKMDAIHDMN>, IBufferMessage
{
	private static readonly MessageParser<MAKMDAIHDMN> _parser = new MessageParser<MAKMDAIHDMN>(() => new MAKMDAIHDMN());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 5;

	private uint oFHCNGHJFHI_;

	public const int ACPBOHCHHKGFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_aCPBOHCHHKG_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> aCPBOHCHHKG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MAKMDAIHDMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MAKMDAIHDMNReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> ACPBOHCHHKG => aCPBOHCHHKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAKMDAIHDMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAKMDAIHDMN(MAKMDAIHDMN other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		aCPBOHCHHKG_ = other.aCPBOHCHHKG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAKMDAIHDMN Clone()
	{
		return new MAKMDAIHDMN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MAKMDAIHDMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MAKMDAIHDMN other)
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
		if (!aCPBOHCHHKG_.Equals(other.aCPBOHCHHKG_))
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
		num ^= aCPBOHCHHKG_.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		aCPBOHCHHKG_.WriteTo(ref output, _repeated_aCPBOHCHHKG_codec);
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
		num += aCPBOHCHHKG_.CalculateSize(_repeated_aCPBOHCHHKG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MAKMDAIHDMN other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			aCPBOHCHHKG_.Add(other.aCPBOHCHHKG_);
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
			case 40u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				aCPBOHCHHKG_.AddEntriesFrom(ref input, _repeated_aCPBOHCHHKG_codec);
				break;
			}
		}
	}
}
