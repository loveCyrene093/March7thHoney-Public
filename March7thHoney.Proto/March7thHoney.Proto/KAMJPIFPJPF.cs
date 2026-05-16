using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KAMJPIFPJPF : IMessage<KAMJPIFPJPF>, IMessage, IEquatable<KAMJPIFPJPF>, IDeepCloneable<KAMJPIFPJPF>, IBufferMessage
{
	private static readonly MessageParser<KAMJPIFPJPF> _parser = new MessageParser<KAMJPIFPJPF>(() => new KAMJPIFPJPF());

	private UnknownFieldSet _unknownFields;

	public const int NNADKEJHMDEFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_nNADKEJHMDE_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> nNADKEJHMDE_ = new RepeatedField<uint>();

	public const int EEBLLIAAALNFieldNumber = 2;

	private static readonly FieldCodec<CCHBNJEGJGH> _repeated_eEBLLIAAALN_codec = FieldCodec.ForMessage(18u, CCHBNJEGJGH.Parser);

	private readonly RepeatedField<CCHBNJEGJGH> eEBLLIAAALN_ = new RepeatedField<CCHBNJEGJGH>();

	public const int MEKMMCEBKPOFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_mEKMMCEBKPO_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> mEKMMCEBKPO_ = new RepeatedField<uint>();

	public const int COFPMFHEOGPFieldNumber = 4;

	private static readonly FieldCodec<OLMHJIHCMBB> _repeated_cOFPMFHEOGP_codec = FieldCodec.ForMessage(34u, OLMHJIHCMBB.Parser);

	private readonly RepeatedField<OLMHJIHCMBB> cOFPMFHEOGP_ = new RepeatedField<OLMHJIHCMBB>();

	public const int KDOGBDNPIMPFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_kDOGBDNPIMP_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> kDOGBDNPIMP_ = new RepeatedField<uint>();

	public const int LNCLLBEIOOFFieldNumber = 7;

	private static readonly FieldCodec<EDKFJKKCIID> _repeated_lNCLLBEIOOF_codec = FieldCodec.ForMessage(58u, EDKFJKKCIID.Parser);

	private readonly RepeatedField<EDKFJKKCIID> lNCLLBEIOOF_ = new RepeatedField<EDKFJKKCIID>();

	public const int OGGPKPPHAOOFieldNumber = 8;

	private static readonly FieldCodec<KPJFOBOKKNO> _repeated_oGGPKPPHAOO_codec = FieldCodec.ForMessage(66u, KPJFOBOKKNO.Parser);

	private readonly RepeatedField<KPJFOBOKKNO> oGGPKPPHAOO_ = new RepeatedField<KPJFOBOKKNO>();

	public const int PGOODEGCBFOFieldNumber = 9;

	private uint pGOODEGCBFO_;

	public const int BOLIJIEFGGDFieldNumber = 10;

	private static readonly FieldCodec<MPDHIFKGDCL> _repeated_bOLIJIEFGGD_codec = FieldCodec.ForMessage(82u, MPDHIFKGDCL.Parser);

	private readonly RepeatedField<MPDHIFKGDCL> bOLIJIEFGGD_ = new RepeatedField<MPDHIFKGDCL>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int BAMKONBOAEIFieldNumber = 14;

	private bool bAMKONBOAEI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KAMJPIFPJPF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KAMJPIFPJPFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NNADKEJHMDE => nNADKEJHMDE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCHBNJEGJGH> EEBLLIAAALN => eEBLLIAAALN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MEKMMCEBKPO => mEKMMCEBKPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLMHJIHCMBB> COFPMFHEOGP => cOFPMFHEOGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KDOGBDNPIMP => kDOGBDNPIMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EDKFJKKCIID> LNCLLBEIOOF => lNCLLBEIOOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KPJFOBOKKNO> OGGPKPPHAOO => oGGPKPPHAOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGOODEGCBFO
	{
		get
		{
			return pGOODEGCBFO_;
		}
		set
		{
			pGOODEGCBFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MPDHIFKGDCL> BOLIJIEFGGD => bOLIJIEFGGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BAMKONBOAEI
	{
		get
		{
			return bAMKONBOAEI_;
		}
		set
		{
			bAMKONBOAEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAMJPIFPJPF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAMJPIFPJPF(KAMJPIFPJPF other)
		: this()
	{
		nNADKEJHMDE_ = other.nNADKEJHMDE_.Clone();
		eEBLLIAAALN_ = other.eEBLLIAAALN_.Clone();
		mEKMMCEBKPO_ = other.mEKMMCEBKPO_.Clone();
		cOFPMFHEOGP_ = other.cOFPMFHEOGP_.Clone();
		kDOGBDNPIMP_ = other.kDOGBDNPIMP_.Clone();
		lNCLLBEIOOF_ = other.lNCLLBEIOOF_.Clone();
		oGGPKPPHAOO_ = other.oGGPKPPHAOO_.Clone();
		pGOODEGCBFO_ = other.pGOODEGCBFO_;
		bOLIJIEFGGD_ = other.bOLIJIEFGGD_.Clone();
		retcode_ = other.retcode_;
		bAMKONBOAEI_ = other.bAMKONBOAEI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAMJPIFPJPF Clone()
	{
		return new KAMJPIFPJPF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KAMJPIFPJPF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KAMJPIFPJPF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nNADKEJHMDE_.Equals(other.nNADKEJHMDE_))
		{
			return false;
		}
		if (!eEBLLIAAALN_.Equals(other.eEBLLIAAALN_))
		{
			return false;
		}
		if (!mEKMMCEBKPO_.Equals(other.mEKMMCEBKPO_))
		{
			return false;
		}
		if (!cOFPMFHEOGP_.Equals(other.cOFPMFHEOGP_))
		{
			return false;
		}
		if (!kDOGBDNPIMP_.Equals(other.kDOGBDNPIMP_))
		{
			return false;
		}
		if (!lNCLLBEIOOF_.Equals(other.lNCLLBEIOOF_))
		{
			return false;
		}
		if (!oGGPKPPHAOO_.Equals(other.oGGPKPPHAOO_))
		{
			return false;
		}
		if (PGOODEGCBFO != other.PGOODEGCBFO)
		{
			return false;
		}
		if (!bOLIJIEFGGD_.Equals(other.bOLIJIEFGGD_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (BAMKONBOAEI != other.BAMKONBOAEI)
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
		num ^= nNADKEJHMDE_.GetHashCode();
		num ^= eEBLLIAAALN_.GetHashCode();
		num ^= mEKMMCEBKPO_.GetHashCode();
		num ^= cOFPMFHEOGP_.GetHashCode();
		num ^= kDOGBDNPIMP_.GetHashCode();
		num ^= lNCLLBEIOOF_.GetHashCode();
		num ^= oGGPKPPHAOO_.GetHashCode();
		if (PGOODEGCBFO != 0)
		{
			num ^= PGOODEGCBFO.GetHashCode();
		}
		num ^= bOLIJIEFGGD_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (BAMKONBOAEI)
		{
			num ^= BAMKONBOAEI.GetHashCode();
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
		nNADKEJHMDE_.WriteTo(ref output, _repeated_nNADKEJHMDE_codec);
		eEBLLIAAALN_.WriteTo(ref output, _repeated_eEBLLIAAALN_codec);
		mEKMMCEBKPO_.WriteTo(ref output, _repeated_mEKMMCEBKPO_codec);
		cOFPMFHEOGP_.WriteTo(ref output, _repeated_cOFPMFHEOGP_codec);
		kDOGBDNPIMP_.WriteTo(ref output, _repeated_kDOGBDNPIMP_codec);
		lNCLLBEIOOF_.WriteTo(ref output, _repeated_lNCLLBEIOOF_codec);
		oGGPKPPHAOO_.WriteTo(ref output, _repeated_oGGPKPPHAOO_codec);
		if (PGOODEGCBFO != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PGOODEGCBFO);
		}
		bOLIJIEFGGD_.WriteTo(ref output, _repeated_bOLIJIEFGGD_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (BAMKONBOAEI)
		{
			output.WriteRawTag(112);
			output.WriteBool(BAMKONBOAEI);
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
		num += nNADKEJHMDE_.CalculateSize(_repeated_nNADKEJHMDE_codec);
		num += eEBLLIAAALN_.CalculateSize(_repeated_eEBLLIAAALN_codec);
		num += mEKMMCEBKPO_.CalculateSize(_repeated_mEKMMCEBKPO_codec);
		num += cOFPMFHEOGP_.CalculateSize(_repeated_cOFPMFHEOGP_codec);
		num += kDOGBDNPIMP_.CalculateSize(_repeated_kDOGBDNPIMP_codec);
		num += lNCLLBEIOOF_.CalculateSize(_repeated_lNCLLBEIOOF_codec);
		num += oGGPKPPHAOO_.CalculateSize(_repeated_oGGPKPPHAOO_codec);
		if (PGOODEGCBFO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGOODEGCBFO);
		}
		num += bOLIJIEFGGD_.CalculateSize(_repeated_bOLIJIEFGGD_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (BAMKONBOAEI)
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
	public void MergeFrom(KAMJPIFPJPF other)
	{
		if (other != null)
		{
			nNADKEJHMDE_.Add(other.nNADKEJHMDE_);
			eEBLLIAAALN_.Add(other.eEBLLIAAALN_);
			mEKMMCEBKPO_.Add(other.mEKMMCEBKPO_);
			cOFPMFHEOGP_.Add(other.cOFPMFHEOGP_);
			kDOGBDNPIMP_.Add(other.kDOGBDNPIMP_);
			lNCLLBEIOOF_.Add(other.lNCLLBEIOOF_);
			oGGPKPPHAOO_.Add(other.oGGPKPPHAOO_);
			if (other.PGOODEGCBFO != 0)
			{
				PGOODEGCBFO = other.PGOODEGCBFO;
			}
			bOLIJIEFGGD_.Add(other.bOLIJIEFGGD_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.BAMKONBOAEI)
			{
				BAMKONBOAEI = other.BAMKONBOAEI;
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
			case 10u:
				nNADKEJHMDE_.AddEntriesFrom(ref input, _repeated_nNADKEJHMDE_codec);
				break;
			case 18u:
				eEBLLIAAALN_.AddEntriesFrom(ref input, _repeated_eEBLLIAAALN_codec);
				break;
			case 24u:
			case 26u:
				mEKMMCEBKPO_.AddEntriesFrom(ref input, _repeated_mEKMMCEBKPO_codec);
				break;
			case 34u:
				cOFPMFHEOGP_.AddEntriesFrom(ref input, _repeated_cOFPMFHEOGP_codec);
				break;
			case 40u:
			case 42u:
				kDOGBDNPIMP_.AddEntriesFrom(ref input, _repeated_kDOGBDNPIMP_codec);
				break;
			case 58u:
				lNCLLBEIOOF_.AddEntriesFrom(ref input, _repeated_lNCLLBEIOOF_codec);
				break;
			case 66u:
				oGGPKPPHAOO_.AddEntriesFrom(ref input, _repeated_oGGPKPPHAOO_codec);
				break;
			case 72u:
				PGOODEGCBFO = input.ReadUInt32();
				break;
			case 82u:
				bOLIJIEFGGD_.AddEntriesFrom(ref input, _repeated_bOLIJIEFGGD_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				BAMKONBOAEI = input.ReadBool();
				break;
			}
		}
	}
}
