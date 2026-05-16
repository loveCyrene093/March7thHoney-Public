using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NOJLPMLALPI : IMessage<NOJLPMLALPI>, IMessage, IEquatable<NOJLPMLALPI>, IDeepCloneable<NOJLPMLALPI>, IBufferMessage
{
	private static readonly MessageParser<NOJLPMLALPI> _parser = new MessageParser<NOJLPMLALPI>(() => new NOJLPMLALPI());

	private UnknownFieldSet _unknownFields;

	public const int FOOLMIADMMHFieldNumber = 1;

	private uint fOOLMIADMMH_;

	public const int KLKOMLPALEBFieldNumber = 3;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_kLKOMLPALEB_codec = FieldCodec.ForMessage(26u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> kLKOMLPALEB_ = new RepeatedField<GKDEKJKOIJN>();

	public const int AMGMADNBFIFFieldNumber = 9;

	private uint aMGMADNBFIF_;

	public const int EPMFDGPKPHJFieldNumber = 10;

	private static readonly FieldCodec<BEOPDMLKGLP> _repeated_ePMFDGPKPHJ_codec = FieldCodec.ForMessage(82u, BEOPDMLKGLP.Parser);

	private readonly RepeatedField<BEOPDMLKGLP> ePMFDGPKPHJ_ = new RepeatedField<BEOPDMLKGLP>();

	public const int DEDNHLDNKAGFieldNumber = 11;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_dEDNHLDNKAG_codec = FieldCodec.ForMessage(90u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> dEDNHLDNKAG_ = new RepeatedField<GKDEKJKOIJN>();

	public const int LCEHDGBBDJLFieldNumber = 14;

	private static readonly FieldCodec<DAPDOHOADDB> _repeated_lCEHDGBBDJL_codec = FieldCodec.ForMessage(114u, DAPDOHOADDB.Parser);

	private readonly RepeatedField<DAPDOHOADDB> lCEHDGBBDJL_ = new RepeatedField<DAPDOHOADDB>();

	public const int DEDFHELFAKFFieldNumber = 15;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_dEDFHELFAKF_codec = FieldCodec.ForMessage(122u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> dEDFHELFAKF_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NOJLPMLALPI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NOJLPMLALPIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> KLKOMLPALEB => kLKOMLPALEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMGMADNBFIF
	{
		get
		{
			return aMGMADNBFIF_;
		}
		set
		{
			aMGMADNBFIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BEOPDMLKGLP> EPMFDGPKPHJ => ePMFDGPKPHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> DEDNHLDNKAG => dEDNHLDNKAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DAPDOHOADDB> LCEHDGBBDJL => lCEHDGBBDJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> DEDFHELFAKF => dEDFHELFAKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJLPMLALPI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJLPMLALPI(NOJLPMLALPI other)
		: this()
	{
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		kLKOMLPALEB_ = other.kLKOMLPALEB_.Clone();
		aMGMADNBFIF_ = other.aMGMADNBFIF_;
		ePMFDGPKPHJ_ = other.ePMFDGPKPHJ_.Clone();
		dEDNHLDNKAG_ = other.dEDNHLDNKAG_.Clone();
		lCEHDGBBDJL_ = other.lCEHDGBBDJL_.Clone();
		dEDFHELFAKF_ = other.dEDFHELFAKF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJLPMLALPI Clone()
	{
		return new NOJLPMLALPI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NOJLPMLALPI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NOJLPMLALPI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
		{
			return false;
		}
		if (!kLKOMLPALEB_.Equals(other.kLKOMLPALEB_))
		{
			return false;
		}
		if (AMGMADNBFIF != other.AMGMADNBFIF)
		{
			return false;
		}
		if (!ePMFDGPKPHJ_.Equals(other.ePMFDGPKPHJ_))
		{
			return false;
		}
		if (!dEDNHLDNKAG_.Equals(other.dEDNHLDNKAG_))
		{
			return false;
		}
		if (!lCEHDGBBDJL_.Equals(other.lCEHDGBBDJL_))
		{
			return false;
		}
		if (!dEDFHELFAKF_.Equals(other.dEDFHELFAKF_))
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
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
		}
		num ^= kLKOMLPALEB_.GetHashCode();
		if (AMGMADNBFIF != 0)
		{
			num ^= AMGMADNBFIF.GetHashCode();
		}
		num ^= ePMFDGPKPHJ_.GetHashCode();
		num ^= dEDNHLDNKAG_.GetHashCode();
		num ^= lCEHDGBBDJL_.GetHashCode();
		num ^= dEDFHELFAKF_.GetHashCode();
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
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FOOLMIADMMH);
		}
		kLKOMLPALEB_.WriteTo(ref output, _repeated_kLKOMLPALEB_codec);
		if (AMGMADNBFIF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AMGMADNBFIF);
		}
		ePMFDGPKPHJ_.WriteTo(ref output, _repeated_ePMFDGPKPHJ_codec);
		dEDNHLDNKAG_.WriteTo(ref output, _repeated_dEDNHLDNKAG_codec);
		lCEHDGBBDJL_.WriteTo(ref output, _repeated_lCEHDGBBDJL_codec);
		dEDFHELFAKF_.WriteTo(ref output, _repeated_dEDFHELFAKF_codec);
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
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		num += kLKOMLPALEB_.CalculateSize(_repeated_kLKOMLPALEB_codec);
		if (AMGMADNBFIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMGMADNBFIF);
		}
		num += ePMFDGPKPHJ_.CalculateSize(_repeated_ePMFDGPKPHJ_codec);
		num += dEDNHLDNKAG_.CalculateSize(_repeated_dEDNHLDNKAG_codec);
		num += lCEHDGBBDJL_.CalculateSize(_repeated_lCEHDGBBDJL_codec);
		num += dEDFHELFAKF_.CalculateSize(_repeated_dEDFHELFAKF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NOJLPMLALPI other)
	{
		if (other != null)
		{
			if (other.FOOLMIADMMH != 0)
			{
				FOOLMIADMMH = other.FOOLMIADMMH;
			}
			kLKOMLPALEB_.Add(other.kLKOMLPALEB_);
			if (other.AMGMADNBFIF != 0)
			{
				AMGMADNBFIF = other.AMGMADNBFIF;
			}
			ePMFDGPKPHJ_.Add(other.ePMFDGPKPHJ_);
			dEDNHLDNKAG_.Add(other.dEDNHLDNKAG_);
			lCEHDGBBDJL_.Add(other.lCEHDGBBDJL_);
			dEDFHELFAKF_.Add(other.dEDFHELFAKF_);
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
				FOOLMIADMMH = input.ReadUInt32();
				break;
			case 26u:
				kLKOMLPALEB_.AddEntriesFrom(ref input, _repeated_kLKOMLPALEB_codec);
				break;
			case 72u:
				AMGMADNBFIF = input.ReadUInt32();
				break;
			case 82u:
				ePMFDGPKPHJ_.AddEntriesFrom(ref input, _repeated_ePMFDGPKPHJ_codec);
				break;
			case 90u:
				dEDNHLDNKAG_.AddEntriesFrom(ref input, _repeated_dEDNHLDNKAG_codec);
				break;
			case 114u:
				lCEHDGBBDJL_.AddEntriesFrom(ref input, _repeated_lCEHDGBBDJL_codec);
				break;
			case 122u:
				dEDFHELFAKF_.AddEntriesFrom(ref input, _repeated_dEDFHELFAKF_codec);
				break;
			}
		}
	}
}
