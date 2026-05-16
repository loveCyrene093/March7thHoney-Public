using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LLFAFBJBCOL : IMessage<LLFAFBJBCOL>, IMessage, IEquatable<LLFAFBJBCOL>, IDeepCloneable<LLFAFBJBCOL>, IBufferMessage
{
	private static readonly MessageParser<LLFAFBJBCOL> _parser = new MessageParser<LLFAFBJBCOL>(() => new LLFAFBJBCOL());

	private UnknownFieldSet _unknownFields;

	public const int DJMPLDKGADGFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_dJMPLDKGADG_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> dJMPLDKGADG_ = new RepeatedField<uint>();

	public const int OFHCNGHJFHIFieldNumber = 7;

	private uint oFHCNGHJFHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LLFAFBJBCOL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LLFAFBJBCOLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DJMPLDKGADG => dJMPLDKGADG_;

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
	public LLFAFBJBCOL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLFAFBJBCOL(LLFAFBJBCOL other)
		: this()
	{
		dJMPLDKGADG_ = other.dJMPLDKGADG_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLFAFBJBCOL Clone()
	{
		return new LLFAFBJBCOL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LLFAFBJBCOL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LLFAFBJBCOL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dJMPLDKGADG_.Equals(other.dJMPLDKGADG_))
		{
			return false;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
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
		num ^= dJMPLDKGADG_.GetHashCode();
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
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
		dJMPLDKGADG_.WriteTo(ref output, _repeated_dJMPLDKGADG_codec);
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OFHCNGHJFHI);
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
		num += dJMPLDKGADG_.CalculateSize(_repeated_dJMPLDKGADG_codec);
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LLFAFBJBCOL other)
	{
		if (other != null)
		{
			dJMPLDKGADG_.Add(other.dJMPLDKGADG_);
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
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
			case 40u:
			case 42u:
				dJMPLDKGADG_.AddEntriesFrom(ref input, _repeated_dJMPLDKGADG_codec);
				break;
			case 56u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			}
		}
	}
}
