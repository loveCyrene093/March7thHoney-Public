using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFBDADKFPBF : IMessage<FFBDADKFPBF>, IMessage, IEquatable<FFBDADKFPBF>, IDeepCloneable<FFBDADKFPBF>, IBufferMessage
{
	private static readonly MessageParser<FFBDADKFPBF> _parser = new MessageParser<FFBDADKFPBF>(() => new FFBDADKFPBF());

	private UnknownFieldSet _unknownFields;

	public const int KPOPECKCDMGFieldNumber = 3;

	private EFEGKDHEMFN kPOPECKCDMG_;

	public const int CBEJMMDDBJLFieldNumber = 5;

	private static readonly FieldCodec<CPIOCHHPICD> _repeated_cBEJMMDDBJL_codec = FieldCodec.ForMessage(42u, CPIOCHHPICD.Parser);

	private readonly RepeatedField<CPIOCHHPICD> cBEJMMDDBJL_ = new RepeatedField<CPIOCHHPICD>();

	public const int JOJDJAECHKAFieldNumber = 8;

	private static readonly FieldCodec<LLLAPNDDDKM> _repeated_jOJDJAECHKA_codec = FieldCodec.ForMessage(66u, LLLAPNDDDKM.Parser);

	private readonly RepeatedField<LLLAPNDDDKM> jOJDJAECHKA_ = new RepeatedField<LLLAPNDDDKM>();

	public const int NHCAGPFDLEPFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_nHCAGPFDLEP_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> nHCAGPFDLEP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFBDADKFPBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFBDADKFPBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN KPOPECKCDMG
	{
		get
		{
			return kPOPECKCDMG_;
		}
		set
		{
			kPOPECKCDMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CPIOCHHPICD> CBEJMMDDBJL => cBEJMMDDBJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LLLAPNDDDKM> JOJDJAECHKA => jOJDJAECHKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NHCAGPFDLEP => nHCAGPFDLEP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFBDADKFPBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFBDADKFPBF(FFBDADKFPBF other)
		: this()
	{
		kPOPECKCDMG_ = ((other.kPOPECKCDMG_ != null) ? other.kPOPECKCDMG_.Clone() : null);
		cBEJMMDDBJL_ = other.cBEJMMDDBJL_.Clone();
		jOJDJAECHKA_ = other.jOJDJAECHKA_.Clone();
		nHCAGPFDLEP_ = other.nHCAGPFDLEP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFBDADKFPBF Clone()
	{
		return new FFBDADKFPBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFBDADKFPBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFBDADKFPBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KPOPECKCDMG, other.KPOPECKCDMG))
		{
			return false;
		}
		if (!cBEJMMDDBJL_.Equals(other.cBEJMMDDBJL_))
		{
			return false;
		}
		if (!jOJDJAECHKA_.Equals(other.jOJDJAECHKA_))
		{
			return false;
		}
		if (!nHCAGPFDLEP_.Equals(other.nHCAGPFDLEP_))
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
		if (kPOPECKCDMG_ != null)
		{
			num ^= KPOPECKCDMG.GetHashCode();
		}
		num ^= cBEJMMDDBJL_.GetHashCode();
		num ^= jOJDJAECHKA_.GetHashCode();
		num ^= nHCAGPFDLEP_.GetHashCode();
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
		if (kPOPECKCDMG_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KPOPECKCDMG);
		}
		cBEJMMDDBJL_.WriteTo(ref output, _repeated_cBEJMMDDBJL_codec);
		jOJDJAECHKA_.WriteTo(ref output, _repeated_jOJDJAECHKA_codec);
		nHCAGPFDLEP_.WriteTo(ref output, _repeated_nHCAGPFDLEP_codec);
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
		if (kPOPECKCDMG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KPOPECKCDMG);
		}
		num += cBEJMMDDBJL_.CalculateSize(_repeated_cBEJMMDDBJL_codec);
		num += jOJDJAECHKA_.CalculateSize(_repeated_jOJDJAECHKA_codec);
		num += nHCAGPFDLEP_.CalculateSize(_repeated_nHCAGPFDLEP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FFBDADKFPBF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kPOPECKCDMG_ != null)
		{
			if (kPOPECKCDMG_ == null)
			{
				KPOPECKCDMG = new EFEGKDHEMFN();
			}
			KPOPECKCDMG.MergeFrom(other.KPOPECKCDMG);
		}
		cBEJMMDDBJL_.Add(other.cBEJMMDDBJL_);
		jOJDJAECHKA_.Add(other.jOJDJAECHKA_);
		nHCAGPFDLEP_.Add(other.nHCAGPFDLEP_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 26u:
				if (kPOPECKCDMG_ == null)
				{
					KPOPECKCDMG = new EFEGKDHEMFN();
				}
				input.ReadMessage(KPOPECKCDMG);
				break;
			case 42u:
				cBEJMMDDBJL_.AddEntriesFrom(ref input, _repeated_cBEJMMDDBJL_codec);
				break;
			case 66u:
				jOJDJAECHKA_.AddEntriesFrom(ref input, _repeated_jOJDJAECHKA_codec);
				break;
			case 120u:
			case 122u:
				nHCAGPFDLEP_.AddEntriesFrom(ref input, _repeated_nHCAGPFDLEP_codec);
				break;
			}
		}
	}
}
