using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LAJDNEMABIO : IMessage<LAJDNEMABIO>, IMessage, IEquatable<LAJDNEMABIO>, IDeepCloneable<LAJDNEMABIO>, IBufferMessage
{
	private static readonly MessageParser<LAJDNEMABIO> _parser = new MessageParser<LAJDNEMABIO>(() => new LAJDNEMABIO());

	private UnknownFieldSet _unknownFields;

	public const int EEIBHMPCAPKFieldNumber = 3;

	private uint eEIBHMPCAPK_;

	public const int LPJDEMOMDIEFieldNumber = 15;

	private static readonly FieldCodec<IDHNJFPAEGP> _repeated_lPJDEMOMDIE_codec = FieldCodec.ForMessage(122u, IDHNJFPAEGP.Parser);

	private readonly RepeatedField<IDHNJFPAEGP> lPJDEMOMDIE_ = new RepeatedField<IDHNJFPAEGP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LAJDNEMABIO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LAJDNEMABIOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEIBHMPCAPK
	{
		get
		{
			return eEIBHMPCAPK_;
		}
		set
		{
			eEIBHMPCAPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IDHNJFPAEGP> LPJDEMOMDIE => lPJDEMOMDIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAJDNEMABIO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAJDNEMABIO(LAJDNEMABIO other)
		: this()
	{
		eEIBHMPCAPK_ = other.eEIBHMPCAPK_;
		lPJDEMOMDIE_ = other.lPJDEMOMDIE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAJDNEMABIO Clone()
	{
		return new LAJDNEMABIO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LAJDNEMABIO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LAJDNEMABIO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EEIBHMPCAPK != other.EEIBHMPCAPK)
		{
			return false;
		}
		if (!lPJDEMOMDIE_.Equals(other.lPJDEMOMDIE_))
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
		if (EEIBHMPCAPK != 0)
		{
			num ^= EEIBHMPCAPK.GetHashCode();
		}
		num ^= lPJDEMOMDIE_.GetHashCode();
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
		if (EEIBHMPCAPK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EEIBHMPCAPK);
		}
		lPJDEMOMDIE_.WriteTo(ref output, _repeated_lPJDEMOMDIE_codec);
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
		if (EEIBHMPCAPK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEIBHMPCAPK);
		}
		num += lPJDEMOMDIE_.CalculateSize(_repeated_lPJDEMOMDIE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LAJDNEMABIO other)
	{
		if (other != null)
		{
			if (other.EEIBHMPCAPK != 0)
			{
				EEIBHMPCAPK = other.EEIBHMPCAPK;
			}
			lPJDEMOMDIE_.Add(other.lPJDEMOMDIE_);
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
			case 24u:
				EEIBHMPCAPK = input.ReadUInt32();
				break;
			case 122u:
				lPJDEMOMDIE_.AddEntriesFrom(ref input, _repeated_lPJDEMOMDIE_codec);
				break;
			}
		}
	}
}
