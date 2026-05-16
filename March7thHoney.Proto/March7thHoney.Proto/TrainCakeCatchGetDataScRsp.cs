using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchGetDataScRsp : IMessage<TrainCakeCatchGetDataScRsp>, IMessage, IEquatable<TrainCakeCatchGetDataScRsp>, IDeepCloneable<TrainCakeCatchGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchGetDataScRsp> _parser = new MessageParser<TrainCakeCatchGetDataScRsp>(() => new TrainCakeCatchGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PerformanceIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_performanceIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> performanceIdList_ = new RepeatedField<uint>();

	public const int DHLGCEGONIBFieldNumber = 3;

	private long dHLGCEGONIB_;

	public const int PEOECDDANNPFieldNumber = 4;

	private FOFNOBHLKGO pEOECDDANNP_;

	public const int AFEJACMLOLHFieldNumber = 6;

	private static readonly FieldCodec<NPLEDHFMFDM> _repeated_aFEJACMLOLH_codec = FieldCodec.ForMessage(50u, NPLEDHFMFDM.Parser);

	private readonly RepeatedField<NPLEDHFMFDM> aFEJACMLOLH_ = new RepeatedField<NPLEDHFMFDM>();

	public const int BLEDIOOJPNLFieldNumber = 7;

	private static readonly FieldCodec<PKILNDNCAMI> _repeated_bLEDIOOJPNL_codec = FieldCodec.ForMessage(58u, PKILNDNCAMI.Parser);

	private readonly RepeatedField<PKILNDNCAMI> bLEDIOOJPNL_ = new RepeatedField<PKILNDNCAMI>();

	public const int KALIBGCODNFFieldNumber = 8;

	private static readonly FieldCodec<LGGABHPGPDD> _repeated_kALIBGCODNF_codec = FieldCodec.ForMessage(66u, LGGABHPGPDD.Parser);

	private readonly RepeatedField<LGGABHPGPDD> kALIBGCODNF_ = new RepeatedField<LGGABHPGPDD>();

	public const int FMECAHALPKGFieldNumber = 10;

	private MKHIPFHEKCK fMECAHALPKG_;

	public const int PEPMFGLDGOHFieldNumber = 13;

	private FAOPPAFAJLO pEPMFGLDGOH_;

	public const int HJOFGOINOAKFieldNumber = 14;

	private LLKEMMMEPOB hJOFGOINOAK_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PerformanceIdList => performanceIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DHLGCEGONIB
	{
		get
		{
			return dHLGCEGONIB_;
		}
		set
		{
			dHLGCEGONIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO PEOECDDANNP
	{
		get
		{
			return pEOECDDANNP_;
		}
		set
		{
			pEOECDDANNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NPLEDHFMFDM> AFEJACMLOLH => aFEJACMLOLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PKILNDNCAMI> BLEDIOOJPNL => bLEDIOOJPNL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LGGABHPGPDD> KALIBGCODNF => kALIBGCODNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKHIPFHEKCK FMECAHALPKG
	{
		get
		{
			return fMECAHALPKG_;
		}
		set
		{
			fMECAHALPKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAOPPAFAJLO PEPMFGLDGOH
	{
		get
		{
			return pEPMFGLDGOH_;
		}
		set
		{
			pEPMFGLDGOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLKEMMMEPOB HJOFGOINOAK
	{
		get
		{
			return hJOFGOINOAK_;
		}
		set
		{
			hJOFGOINOAK_ = value;
		}
	}

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
	public TrainCakeCatchGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchGetDataScRsp(TrainCakeCatchGetDataScRsp other)
		: this()
	{
		performanceIdList_ = other.performanceIdList_.Clone();
		dHLGCEGONIB_ = other.dHLGCEGONIB_;
		pEOECDDANNP_ = ((other.pEOECDDANNP_ != null) ? other.pEOECDDANNP_.Clone() : null);
		aFEJACMLOLH_ = other.aFEJACMLOLH_.Clone();
		bLEDIOOJPNL_ = other.bLEDIOOJPNL_.Clone();
		kALIBGCODNF_ = other.kALIBGCODNF_.Clone();
		fMECAHALPKG_ = ((other.fMECAHALPKG_ != null) ? other.fMECAHALPKG_.Clone() : null);
		pEPMFGLDGOH_ = ((other.pEPMFGLDGOH_ != null) ? other.pEPMFGLDGOH_.Clone() : null);
		hJOFGOINOAK_ = ((other.hJOFGOINOAK_ != null) ? other.hJOFGOINOAK_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchGetDataScRsp Clone()
	{
		return new TrainCakeCatchGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!performanceIdList_.Equals(other.performanceIdList_))
		{
			return false;
		}
		if (DHLGCEGONIB != other.DHLGCEGONIB)
		{
			return false;
		}
		if (!object.Equals(PEOECDDANNP, other.PEOECDDANNP))
		{
			return false;
		}
		if (!aFEJACMLOLH_.Equals(other.aFEJACMLOLH_))
		{
			return false;
		}
		if (!bLEDIOOJPNL_.Equals(other.bLEDIOOJPNL_))
		{
			return false;
		}
		if (!kALIBGCODNF_.Equals(other.kALIBGCODNF_))
		{
			return false;
		}
		if (!object.Equals(FMECAHALPKG, other.FMECAHALPKG))
		{
			return false;
		}
		if (!object.Equals(PEPMFGLDGOH, other.PEPMFGLDGOH))
		{
			return false;
		}
		if (!object.Equals(HJOFGOINOAK, other.HJOFGOINOAK))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= performanceIdList_.GetHashCode();
		if (DHLGCEGONIB != 0L)
		{
			num ^= DHLGCEGONIB.GetHashCode();
		}
		if (pEOECDDANNP_ != null)
		{
			num ^= PEOECDDANNP.GetHashCode();
		}
		num ^= aFEJACMLOLH_.GetHashCode();
		num ^= bLEDIOOJPNL_.GetHashCode();
		num ^= kALIBGCODNF_.GetHashCode();
		if (fMECAHALPKG_ != null)
		{
			num ^= FMECAHALPKG.GetHashCode();
		}
		if (pEPMFGLDGOH_ != null)
		{
			num ^= PEPMFGLDGOH.GetHashCode();
		}
		if (hJOFGOINOAK_ != null)
		{
			num ^= HJOFGOINOAK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		performanceIdList_.WriteTo(ref output, _repeated_performanceIdList_codec);
		if (DHLGCEGONIB != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(DHLGCEGONIB);
		}
		if (pEOECDDANNP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PEOECDDANNP);
		}
		aFEJACMLOLH_.WriteTo(ref output, _repeated_aFEJACMLOLH_codec);
		bLEDIOOJPNL_.WriteTo(ref output, _repeated_bLEDIOOJPNL_codec);
		kALIBGCODNF_.WriteTo(ref output, _repeated_kALIBGCODNF_codec);
		if (fMECAHALPKG_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(FMECAHALPKG);
		}
		if (pEPMFGLDGOH_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(PEPMFGLDGOH);
		}
		if (hJOFGOINOAK_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HJOFGOINOAK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		num += performanceIdList_.CalculateSize(_repeated_performanceIdList_codec);
		if (DHLGCEGONIB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DHLGCEGONIB);
		}
		if (pEOECDDANNP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEOECDDANNP);
		}
		num += aFEJACMLOLH_.CalculateSize(_repeated_aFEJACMLOLH_codec);
		num += bLEDIOOJPNL_.CalculateSize(_repeated_bLEDIOOJPNL_codec);
		num += kALIBGCODNF_.CalculateSize(_repeated_kALIBGCODNF_codec);
		if (fMECAHALPKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMECAHALPKG);
		}
		if (pEPMFGLDGOH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEPMFGLDGOH);
		}
		if (hJOFGOINOAK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HJOFGOINOAK);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainCakeCatchGetDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		performanceIdList_.Add(other.performanceIdList_);
		if (other.DHLGCEGONIB != 0L)
		{
			DHLGCEGONIB = other.DHLGCEGONIB;
		}
		if (other.pEOECDDANNP_ != null)
		{
			if (pEOECDDANNP_ == null)
			{
				PEOECDDANNP = new FOFNOBHLKGO();
			}
			PEOECDDANNP.MergeFrom(other.PEOECDDANNP);
		}
		aFEJACMLOLH_.Add(other.aFEJACMLOLH_);
		bLEDIOOJPNL_.Add(other.bLEDIOOJPNL_);
		kALIBGCODNF_.Add(other.kALIBGCODNF_);
		if (other.fMECAHALPKG_ != null)
		{
			if (fMECAHALPKG_ == null)
			{
				FMECAHALPKG = new MKHIPFHEKCK();
			}
			FMECAHALPKG.MergeFrom(other.FMECAHALPKG);
		}
		if (other.pEPMFGLDGOH_ != null)
		{
			if (pEPMFGLDGOH_ == null)
			{
				PEPMFGLDGOH = new FAOPPAFAJLO();
			}
			PEPMFGLDGOH.MergeFrom(other.PEPMFGLDGOH);
		}
		if (other.hJOFGOINOAK_ != null)
		{
			if (hJOFGOINOAK_ == null)
			{
				HJOFGOINOAK = new LLKEMMMEPOB();
			}
			HJOFGOINOAK.MergeFrom(other.HJOFGOINOAK);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
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
			case 8u:
			case 10u:
				performanceIdList_.AddEntriesFrom(ref input, _repeated_performanceIdList_codec);
				break;
			case 24u:
				DHLGCEGONIB = input.ReadInt64();
				break;
			case 34u:
				if (pEOECDDANNP_ == null)
				{
					PEOECDDANNP = new FOFNOBHLKGO();
				}
				input.ReadMessage(PEOECDDANNP);
				break;
			case 50u:
				aFEJACMLOLH_.AddEntriesFrom(ref input, _repeated_aFEJACMLOLH_codec);
				break;
			case 58u:
				bLEDIOOJPNL_.AddEntriesFrom(ref input, _repeated_bLEDIOOJPNL_codec);
				break;
			case 66u:
				kALIBGCODNF_.AddEntriesFrom(ref input, _repeated_kALIBGCODNF_codec);
				break;
			case 82u:
				if (fMECAHALPKG_ == null)
				{
					FMECAHALPKG = new MKHIPFHEKCK();
				}
				input.ReadMessage(FMECAHALPKG);
				break;
			case 106u:
				if (pEPMFGLDGOH_ == null)
				{
					PEPMFGLDGOH = new FAOPPAFAJLO();
				}
				input.ReadMessage(PEPMFGLDGOH);
				break;
			case 114u:
				if (hJOFGOINOAK_ == null)
				{
					HJOFGOINOAK = new LLKEMMMEPOB();
				}
				input.ReadMessage(HJOFGOINOAK);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
