using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KDGCGDGDLAK : IMessage<KDGCGDGDLAK>, IMessage, IEquatable<KDGCGDGDLAK>, IDeepCloneable<KDGCGDGDLAK>, IBufferMessage
{
	private static readonly MessageParser<KDGCGDGDLAK> _parser = new MessageParser<KDGCGDGDLAK>(() => new KDGCGDGDLAK());

	private UnknownFieldSet _unknownFields;

	public const int CHFDEPBJEACFieldNumber = 2;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_cHFDEPBJEAC_codec = FieldCodec.ForMessage(18u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> cHFDEPBJEAC_ = new RepeatedField<HJGFDIKDIHO>();

	public const int OFHCNGHJFHIFieldNumber = 8;

	private uint oFHCNGHJFHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KDGCGDGDLAK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KDGCGDGDLAKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HJGFDIKDIHO> CHFDEPBJEAC => cHFDEPBJEAC_;

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
	public KDGCGDGDLAK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDGCGDGDLAK(KDGCGDGDLAK other)
		: this()
	{
		cHFDEPBJEAC_ = other.cHFDEPBJEAC_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDGCGDGDLAK Clone()
	{
		return new KDGCGDGDLAK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KDGCGDGDLAK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KDGCGDGDLAK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cHFDEPBJEAC_.Equals(other.cHFDEPBJEAC_))
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
		num ^= cHFDEPBJEAC_.GetHashCode();
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
		cHFDEPBJEAC_.WriteTo(ref output, _repeated_cHFDEPBJEAC_codec);
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(64);
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
		num += cHFDEPBJEAC_.CalculateSize(_repeated_cHFDEPBJEAC_codec);
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
	public void MergeFrom(KDGCGDGDLAK other)
	{
		if (other != null)
		{
			cHFDEPBJEAC_.Add(other.cHFDEPBJEAC_);
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
			case 18u:
				cHFDEPBJEAC_.AddEntriesFrom(ref input, _repeated_cHFDEPBJEAC_codec);
				break;
			case 64u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			}
		}
	}
}
