using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FHCCCHJHHKL : IMessage<FHCCCHJHHKL>, IMessage, IEquatable<FHCCCHJHHKL>, IDeepCloneable<FHCCCHJHHKL>, IBufferMessage
{
	private static readonly MessageParser<FHCCCHJHHKL> _parser = new MessageParser<FHCCCHJHHKL>(() => new FHCCCHJHHKL());

	private UnknownFieldSet _unknownFields;

	public const int OKHAMBMNIDIFieldNumber = 8;

	private uint oKHAMBMNIDI_;

	public const int DPKACNDALDIFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_dPKACNDALDI_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> dPKACNDALDI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FHCCCHJHHKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FHCCCHJHHKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKHAMBMNIDI
	{
		get
		{
			return oKHAMBMNIDI_;
		}
		set
		{
			oKHAMBMNIDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DPKACNDALDI => dPKACNDALDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHCCCHJHHKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHCCCHJHHKL(FHCCCHJHHKL other)
		: this()
	{
		oKHAMBMNIDI_ = other.oKHAMBMNIDI_;
		dPKACNDALDI_ = other.dPKACNDALDI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHCCCHJHHKL Clone()
	{
		return new FHCCCHJHHKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FHCCCHJHHKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FHCCCHJHHKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OKHAMBMNIDI != other.OKHAMBMNIDI)
		{
			return false;
		}
		if (!dPKACNDALDI_.Equals(other.dPKACNDALDI_))
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
		if (OKHAMBMNIDI != 0)
		{
			num ^= OKHAMBMNIDI.GetHashCode();
		}
		num ^= dPKACNDALDI_.GetHashCode();
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
		if (OKHAMBMNIDI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(OKHAMBMNIDI);
		}
		dPKACNDALDI_.WriteTo(ref output, _repeated_dPKACNDALDI_codec);
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
		if (OKHAMBMNIDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKHAMBMNIDI);
		}
		num += dPKACNDALDI_.CalculateSize(_repeated_dPKACNDALDI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FHCCCHJHHKL other)
	{
		if (other != null)
		{
			if (other.OKHAMBMNIDI != 0)
			{
				OKHAMBMNIDI = other.OKHAMBMNIDI;
			}
			dPKACNDALDI_.Add(other.dPKACNDALDI_);
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
			case 64u:
				OKHAMBMNIDI = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				dPKACNDALDI_.AddEntriesFrom(ref input, _repeated_dPKACNDALDI_codec);
				break;
			}
		}
	}
}
