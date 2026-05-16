using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MAGFKFCMLJM : IMessage<MAGFKFCMLJM>, IMessage, IEquatable<MAGFKFCMLJM>, IDeepCloneable<MAGFKFCMLJM>, IBufferMessage
{
	private static readonly MessageParser<MAGFKFCMLJM> _parser = new MessageParser<MAGFKFCMLJM>(() => new MAGFKFCMLJM());

	private UnknownFieldSet _unknownFields;

	public const int HBKJKEEIHKEFieldNumber = 5;

	private static readonly FieldCodec<BNIBEBILFLF> _repeated_hBKJKEEIHKE_codec = FieldCodec.ForMessage(42u, BNIBEBILFLF.Parser);

	private readonly RepeatedField<BNIBEBILFLF> hBKJKEEIHKE_ = new RepeatedField<BNIBEBILFLF>();

	public const int DMMNCNGGPHLFieldNumber = 6;

	private static readonly FieldCodec<DOBIOOHLGAA> _repeated_dMMNCNGGPHL_codec = FieldCodec.ForMessage(50u, DOBIOOHLGAA.Parser);

	private readonly RepeatedField<DOBIOOHLGAA> dMMNCNGGPHL_ = new RepeatedField<DOBIOOHLGAA>();

	public const int FCLIKOAJCFNFieldNumber = 15;

	private uint fCLIKOAJCFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MAGFKFCMLJM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MAGFKFCMLJMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BNIBEBILFLF> HBKJKEEIHKE => hBKJKEEIHKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOBIOOHLGAA> DMMNCNGGPHL => dMMNCNGGPHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCLIKOAJCFN
	{
		get
		{
			return fCLIKOAJCFN_;
		}
		set
		{
			fCLIKOAJCFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGFKFCMLJM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGFKFCMLJM(MAGFKFCMLJM other)
		: this()
	{
		hBKJKEEIHKE_ = other.hBKJKEEIHKE_.Clone();
		dMMNCNGGPHL_ = other.dMMNCNGGPHL_.Clone();
		fCLIKOAJCFN_ = other.fCLIKOAJCFN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGFKFCMLJM Clone()
	{
		return new MAGFKFCMLJM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MAGFKFCMLJM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MAGFKFCMLJM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hBKJKEEIHKE_.Equals(other.hBKJKEEIHKE_))
		{
			return false;
		}
		if (!dMMNCNGGPHL_.Equals(other.dMMNCNGGPHL_))
		{
			return false;
		}
		if (FCLIKOAJCFN != other.FCLIKOAJCFN)
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
		num ^= hBKJKEEIHKE_.GetHashCode();
		num ^= dMMNCNGGPHL_.GetHashCode();
		if (FCLIKOAJCFN != 0)
		{
			num ^= FCLIKOAJCFN.GetHashCode();
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
		hBKJKEEIHKE_.WriteTo(ref output, _repeated_hBKJKEEIHKE_codec);
		dMMNCNGGPHL_.WriteTo(ref output, _repeated_dMMNCNGGPHL_codec);
		if (FCLIKOAJCFN != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FCLIKOAJCFN);
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
		num += hBKJKEEIHKE_.CalculateSize(_repeated_hBKJKEEIHKE_codec);
		num += dMMNCNGGPHL_.CalculateSize(_repeated_dMMNCNGGPHL_codec);
		if (FCLIKOAJCFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCLIKOAJCFN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MAGFKFCMLJM other)
	{
		if (other != null)
		{
			hBKJKEEIHKE_.Add(other.hBKJKEEIHKE_);
			dMMNCNGGPHL_.Add(other.dMMNCNGGPHL_);
			if (other.FCLIKOAJCFN != 0)
			{
				FCLIKOAJCFN = other.FCLIKOAJCFN;
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
			case 42u:
				hBKJKEEIHKE_.AddEntriesFrom(ref input, _repeated_hBKJKEEIHKE_codec);
				break;
			case 50u:
				dMMNCNGGPHL_.AddEntriesFrom(ref input, _repeated_dMMNCNGGPHL_codec);
				break;
			case 120u:
				FCLIKOAJCFN = input.ReadUInt32();
				break;
			}
		}
	}
}
