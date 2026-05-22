using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KEGJMEJBNCJ : IMessage<KEGJMEJBNCJ>, IMessage, IEquatable<KEGJMEJBNCJ>, IDeepCloneable<KEGJMEJBNCJ>, IBufferMessage
{
	private static readonly MessageParser<KEGJMEJBNCJ> _parser = new MessageParser<KEGJMEJBNCJ>(() => new KEGJMEJBNCJ());

	private UnknownFieldSet _unknownFields;

	public const int NALLICMEEDIFieldNumber = 1;

	private uint nALLICMEEDI_;

	public const int OEPPLIKECODFieldNumber = 7;

	private uint oEPPLIKECOD_;

	public const int EPLBCNFMLILFieldNumber = 8;

	private uint ePLBCNFMLIL_;

	public const int KFEDJDCELPKFieldNumber = 9;

	private uint kFEDJDCELPK_;

	public const int DEPLLJPKKGDFieldNumber = 10;

	private static readonly FieldCodec<CKHDNJGMEJC> _repeated_dEPLLJPKKGD_codec = FieldCodec.ForMessage(82u, CKHDNJGMEJC.Parser);

	private readonly RepeatedField<CKHDNJGMEJC> dEPLLJPKKGD_ = new RepeatedField<CKHDNJGMEJC>();

	public const int BHABGAPJAHFFieldNumber = 12;

	private static readonly FieldCodec<CIPBBPHGEKJ> _repeated_bHABGAPJAHF_codec = FieldCodec.ForMessage(98u, CIPBBPHGEKJ.Parser);

	private readonly RepeatedField<CIPBBPHGEKJ> bHABGAPJAHF_ = new RepeatedField<CIPBBPHGEKJ>();

	public const int LJFLPNPJHLMFieldNumber = 14;

	private static readonly FieldCodec<MJDBHCKMLIL> _repeated_lJFLPNPJHLM_codec = FieldCodec.ForMessage(114u, MJDBHCKMLIL.Parser);

	private readonly RepeatedField<MJDBHCKMLIL> lJFLPNPJHLM_ = new RepeatedField<MJDBHCKMLIL>();

	public const int FIHLNOJAKCHFieldNumber = 15;

	private uint fIHLNOJAKCH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KEGJMEJBNCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KEGJMEJBNCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NALLICMEEDI
	{
		get
		{
			return nALLICMEEDI_;
		}
		set
		{
			nALLICMEEDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEPPLIKECOD
	{
		get
		{
			return oEPPLIKECOD_;
		}
		set
		{
			oEPPLIKECOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPLBCNFMLIL
	{
		get
		{
			return ePLBCNFMLIL_;
		}
		set
		{
			ePLBCNFMLIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFEDJDCELPK
	{
		get
		{
			return kFEDJDCELPK_;
		}
		set
		{
			kFEDJDCELPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKHDNJGMEJC> DEPLLJPKKGD => dEPLLJPKKGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CIPBBPHGEKJ> BHABGAPJAHF => bHABGAPJAHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MJDBHCKMLIL> LJFLPNPJHLM => lJFLPNPJHLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIHLNOJAKCH
	{
		get
		{
			return fIHLNOJAKCH_;
		}
		set
		{
			fIHLNOJAKCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEGJMEJBNCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEGJMEJBNCJ(KEGJMEJBNCJ other)
		: this()
	{
		nALLICMEEDI_ = other.nALLICMEEDI_;
		oEPPLIKECOD_ = other.oEPPLIKECOD_;
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		kFEDJDCELPK_ = other.kFEDJDCELPK_;
		dEPLLJPKKGD_ = other.dEPLLJPKKGD_.Clone();
		bHABGAPJAHF_ = other.bHABGAPJAHF_.Clone();
		lJFLPNPJHLM_ = other.lJFLPNPJHLM_.Clone();
		fIHLNOJAKCH_ = other.fIHLNOJAKCH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEGJMEJBNCJ Clone()
	{
		return new KEGJMEJBNCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KEGJMEJBNCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KEGJMEJBNCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NALLICMEEDI != other.NALLICMEEDI)
		{
			return false;
		}
		if (OEPPLIKECOD != other.OEPPLIKECOD)
		{
			return false;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
		{
			return false;
		}
		if (KFEDJDCELPK != other.KFEDJDCELPK)
		{
			return false;
		}
		if (!dEPLLJPKKGD_.Equals(other.dEPLLJPKKGD_))
		{
			return false;
		}
		if (!bHABGAPJAHF_.Equals(other.bHABGAPJAHF_))
		{
			return false;
		}
		if (!lJFLPNPJHLM_.Equals(other.lJFLPNPJHLM_))
		{
			return false;
		}
		if (FIHLNOJAKCH != other.FIHLNOJAKCH)
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
		if (NALLICMEEDI != 0)
		{
			num ^= NALLICMEEDI.GetHashCode();
		}
		if (OEPPLIKECOD != 0)
		{
			num ^= OEPPLIKECOD.GetHashCode();
		}
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
		}
		if (KFEDJDCELPK != 0)
		{
			num ^= KFEDJDCELPK.GetHashCode();
		}
		num ^= dEPLLJPKKGD_.GetHashCode();
		num ^= bHABGAPJAHF_.GetHashCode();
		num ^= lJFLPNPJHLM_.GetHashCode();
		if (FIHLNOJAKCH != 0)
		{
			num ^= FIHLNOJAKCH.GetHashCode();
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
		if (NALLICMEEDI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NALLICMEEDI);
		}
		if (OEPPLIKECOD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OEPPLIKECOD);
		}
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EPLBCNFMLIL);
		}
		if (KFEDJDCELPK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KFEDJDCELPK);
		}
		dEPLLJPKKGD_.WriteTo(ref output, _repeated_dEPLLJPKKGD_codec);
		bHABGAPJAHF_.WriteTo(ref output, _repeated_bHABGAPJAHF_codec);
		lJFLPNPJHLM_.WriteTo(ref output, _repeated_lJFLPNPJHLM_codec);
		if (FIHLNOJAKCH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FIHLNOJAKCH);
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
		if (NALLICMEEDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NALLICMEEDI);
		}
		if (OEPPLIKECOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEPPLIKECOD);
		}
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPLBCNFMLIL);
		}
		if (KFEDJDCELPK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFEDJDCELPK);
		}
		num += dEPLLJPKKGD_.CalculateSize(_repeated_dEPLLJPKKGD_codec);
		num += bHABGAPJAHF_.CalculateSize(_repeated_bHABGAPJAHF_codec);
		num += lJFLPNPJHLM_.CalculateSize(_repeated_lJFLPNPJHLM_codec);
		if (FIHLNOJAKCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIHLNOJAKCH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KEGJMEJBNCJ other)
	{
		if (other != null)
		{
			if (other.NALLICMEEDI != 0)
			{
				NALLICMEEDI = other.NALLICMEEDI;
			}
			if (other.OEPPLIKECOD != 0)
			{
				OEPPLIKECOD = other.OEPPLIKECOD;
			}
			if (other.EPLBCNFMLIL != 0)
			{
				EPLBCNFMLIL = other.EPLBCNFMLIL;
			}
			if (other.KFEDJDCELPK != 0)
			{
				KFEDJDCELPK = other.KFEDJDCELPK;
			}
			dEPLLJPKKGD_.Add(other.dEPLLJPKKGD_);
			bHABGAPJAHF_.Add(other.bHABGAPJAHF_);
			lJFLPNPJHLM_.Add(other.lJFLPNPJHLM_);
			if (other.FIHLNOJAKCH != 0)
			{
				FIHLNOJAKCH = other.FIHLNOJAKCH;
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
			case 8u:
				NALLICMEEDI = input.ReadUInt32();
				break;
			case 56u:
				OEPPLIKECOD = input.ReadUInt32();
				break;
			case 64u:
				EPLBCNFMLIL = input.ReadUInt32();
				break;
			case 72u:
				KFEDJDCELPK = input.ReadUInt32();
				break;
			case 82u:
				dEPLLJPKKGD_.AddEntriesFrom(ref input, _repeated_dEPLLJPKKGD_codec);
				break;
			case 98u:
				bHABGAPJAHF_.AddEntriesFrom(ref input, _repeated_bHABGAPJAHF_codec);
				break;
			case 114u:
				lJFLPNPJHLM_.AddEntriesFrom(ref input, _repeated_lJFLPNPJHLM_codec);
				break;
			case 120u:
				FIHLNOJAKCH = input.ReadUInt32();
				break;
			}
		}
	}
}
