using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SettleElfRestaurantPlayCsReq : IMessage<SettleElfRestaurantPlayCsReq>, IMessage, IEquatable<SettleElfRestaurantPlayCsReq>, IDeepCloneable<SettleElfRestaurantPlayCsReq>, IBufferMessage
{
	private static readonly MessageParser<SettleElfRestaurantPlayCsReq> _parser = new MessageParser<SettleElfRestaurantPlayCsReq>(() => new SettleElfRestaurantPlayCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BEOAPNBFOCIFieldNumber = 1;

	private uint bEOAPNBFOCI_;

	public const int PIGFMOMEPHEFieldNumber = 2;

	private static readonly FieldCodec<OAHNIFMDLCJ> _repeated_pIGFMOMEPHE_codec = FieldCodec.ForMessage(18u, OAHNIFMDLCJ.Parser);

	private readonly RepeatedField<OAHNIFMDLCJ> pIGFMOMEPHE_ = new RepeatedField<OAHNIFMDLCJ>();

	public const int CostTimeFieldNumber = 5;

	private uint costTime_;

	public const int CNGEJMNPJPMFieldNumber = 6;

	private static readonly FieldCodec<KPNDMCHCBPI> _repeated_cNGEJMNPJPM_codec = FieldCodec.ForMessage(50u, KPNDMCHCBPI.Parser);

	private readonly RepeatedField<KPNDMCHCBPI> cNGEJMNPJPM_ = new RepeatedField<KPNDMCHCBPI>();

	public const int ALHGBBFBKJGFieldNumber = 7;

	private static readonly FieldCodec<BJMHMKBBJGH> _repeated_aLHGBBFBKJG_codec = FieldCodec.ForMessage(58u, BJMHMKBBJGH.Parser);

	private readonly RepeatedField<BJMHMKBBJGH> aLHGBBFBKJG_ = new RepeatedField<BJMHMKBBJGH>();

	public const int ONGHHAPHCEMFieldNumber = 8;

	private static readonly FieldCodec<KILNLEDAHOC> _repeated_oNGHHAPHCEM_codec = FieldCodec.ForMessage(66u, KILNLEDAHOC.Parser);

	private readonly RepeatedField<KILNLEDAHOC> oNGHHAPHCEM_ = new RepeatedField<KILNLEDAHOC>();

	public const int HLKMMJLCJECFieldNumber = 9;

	private static readonly FieldCodec<FLIPDLFKMLB> _repeated_hLKMMJLCJEC_codec = FieldCodec.ForMessage(74u, FLIPDLFKMLB.Parser);

	private readonly RepeatedField<FLIPDLFKMLB> hLKMMJLCJEC_ = new RepeatedField<FLIPDLFKMLB>();

	public const int DNDGPEPOLNMFieldNumber = 10;

	private uint dNDGPEPOLNM_;

	public const int IOIBCNHAOKGFieldNumber = 11;

	private uint iOIBCNHAOKG_;

	public const int AOAEKPAPHOKFieldNumber = 12;

	private uint aOAEKPAPHOK_;

	public const int NGJKIIIJBIBFieldNumber = 14;

	private uint nGJKIIIJBIB_;

	public const int DNJEEOENMAAFieldNumber = 15;

	private uint dNJEEOENMAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SettleElfRestaurantPlayCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SettleElfRestaurantPlayCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEOAPNBFOCI
	{
		get
		{
			return bEOAPNBFOCI_;
		}
		set
		{
			bEOAPNBFOCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OAHNIFMDLCJ> PIGFMOMEPHE => pIGFMOMEPHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KPNDMCHCBPI> CNGEJMNPJPM => cNGEJMNPJPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BJMHMKBBJGH> ALHGBBFBKJG => aLHGBBFBKJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KILNLEDAHOC> ONGHHAPHCEM => oNGHHAPHCEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FLIPDLFKMLB> HLKMMJLCJEC => hLKMMJLCJEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DNDGPEPOLNM
	{
		get
		{
			return dNDGPEPOLNM_;
		}
		set
		{
			dNDGPEPOLNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IOIBCNHAOKG
	{
		get
		{
			return iOIBCNHAOKG_;
		}
		set
		{
			iOIBCNHAOKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOAEKPAPHOK
	{
		get
		{
			return aOAEKPAPHOK_;
		}
		set
		{
			aOAEKPAPHOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGJKIIIJBIB
	{
		get
		{
			return nGJKIIIJBIB_;
		}
		set
		{
			nGJKIIIJBIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DNJEEOENMAA
	{
		get
		{
			return dNJEEOENMAA_;
		}
		set
		{
			dNJEEOENMAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleElfRestaurantPlayCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleElfRestaurantPlayCsReq(SettleElfRestaurantPlayCsReq other)
		: this()
	{
		bEOAPNBFOCI_ = other.bEOAPNBFOCI_;
		pIGFMOMEPHE_ = other.pIGFMOMEPHE_.Clone();
		costTime_ = other.costTime_;
		cNGEJMNPJPM_ = other.cNGEJMNPJPM_.Clone();
		aLHGBBFBKJG_ = other.aLHGBBFBKJG_.Clone();
		oNGHHAPHCEM_ = other.oNGHHAPHCEM_.Clone();
		hLKMMJLCJEC_ = other.hLKMMJLCJEC_.Clone();
		dNDGPEPOLNM_ = other.dNDGPEPOLNM_;
		iOIBCNHAOKG_ = other.iOIBCNHAOKG_;
		aOAEKPAPHOK_ = other.aOAEKPAPHOK_;
		nGJKIIIJBIB_ = other.nGJKIIIJBIB_;
		dNJEEOENMAA_ = other.dNJEEOENMAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleElfRestaurantPlayCsReq Clone()
	{
		return new SettleElfRestaurantPlayCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SettleElfRestaurantPlayCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SettleElfRestaurantPlayCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BEOAPNBFOCI != other.BEOAPNBFOCI)
		{
			return false;
		}
		if (!pIGFMOMEPHE_.Equals(other.pIGFMOMEPHE_))
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (!cNGEJMNPJPM_.Equals(other.cNGEJMNPJPM_))
		{
			return false;
		}
		if (!aLHGBBFBKJG_.Equals(other.aLHGBBFBKJG_))
		{
			return false;
		}
		if (!oNGHHAPHCEM_.Equals(other.oNGHHAPHCEM_))
		{
			return false;
		}
		if (!hLKMMJLCJEC_.Equals(other.hLKMMJLCJEC_))
		{
			return false;
		}
		if (DNDGPEPOLNM != other.DNDGPEPOLNM)
		{
			return false;
		}
		if (IOIBCNHAOKG != other.IOIBCNHAOKG)
		{
			return false;
		}
		if (AOAEKPAPHOK != other.AOAEKPAPHOK)
		{
			return false;
		}
		if (NGJKIIIJBIB != other.NGJKIIIJBIB)
		{
			return false;
		}
		if (DNJEEOENMAA != other.DNJEEOENMAA)
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
		if (BEOAPNBFOCI != 0)
		{
			num ^= BEOAPNBFOCI.GetHashCode();
		}
		num ^= pIGFMOMEPHE_.GetHashCode();
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		num ^= cNGEJMNPJPM_.GetHashCode();
		num ^= aLHGBBFBKJG_.GetHashCode();
		num ^= oNGHHAPHCEM_.GetHashCode();
		num ^= hLKMMJLCJEC_.GetHashCode();
		if (DNDGPEPOLNM != 0)
		{
			num ^= DNDGPEPOLNM.GetHashCode();
		}
		if (IOIBCNHAOKG != 0)
		{
			num ^= IOIBCNHAOKG.GetHashCode();
		}
		if (AOAEKPAPHOK != 0)
		{
			num ^= AOAEKPAPHOK.GetHashCode();
		}
		if (NGJKIIIJBIB != 0)
		{
			num ^= NGJKIIIJBIB.GetHashCode();
		}
		if (DNJEEOENMAA != 0)
		{
			num ^= DNJEEOENMAA.GetHashCode();
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
		if (BEOAPNBFOCI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BEOAPNBFOCI);
		}
		pIGFMOMEPHE_.WriteTo(ref output, _repeated_pIGFMOMEPHE_codec);
		if (CostTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CostTime);
		}
		cNGEJMNPJPM_.WriteTo(ref output, _repeated_cNGEJMNPJPM_codec);
		aLHGBBFBKJG_.WriteTo(ref output, _repeated_aLHGBBFBKJG_codec);
		oNGHHAPHCEM_.WriteTo(ref output, _repeated_oNGHHAPHCEM_codec);
		hLKMMJLCJEC_.WriteTo(ref output, _repeated_hLKMMJLCJEC_codec);
		if (DNDGPEPOLNM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DNDGPEPOLNM);
		}
		if (IOIBCNHAOKG != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IOIBCNHAOKG);
		}
		if (AOAEKPAPHOK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AOAEKPAPHOK);
		}
		if (NGJKIIIJBIB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NGJKIIIJBIB);
		}
		if (DNJEEOENMAA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DNJEEOENMAA);
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
		if (BEOAPNBFOCI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEOAPNBFOCI);
		}
		num += pIGFMOMEPHE_.CalculateSize(_repeated_pIGFMOMEPHE_codec);
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		num += cNGEJMNPJPM_.CalculateSize(_repeated_cNGEJMNPJPM_codec);
		num += aLHGBBFBKJG_.CalculateSize(_repeated_aLHGBBFBKJG_codec);
		num += oNGHHAPHCEM_.CalculateSize(_repeated_oNGHHAPHCEM_codec);
		num += hLKMMJLCJEC_.CalculateSize(_repeated_hLKMMJLCJEC_codec);
		if (DNDGPEPOLNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DNDGPEPOLNM);
		}
		if (IOIBCNHAOKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IOIBCNHAOKG);
		}
		if (AOAEKPAPHOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOAEKPAPHOK);
		}
		if (NGJKIIIJBIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGJKIIIJBIB);
		}
		if (DNJEEOENMAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DNJEEOENMAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SettleElfRestaurantPlayCsReq other)
	{
		if (other != null)
		{
			if (other.BEOAPNBFOCI != 0)
			{
				BEOAPNBFOCI = other.BEOAPNBFOCI;
			}
			pIGFMOMEPHE_.Add(other.pIGFMOMEPHE_);
			if (other.CostTime != 0)
			{
				CostTime = other.CostTime;
			}
			cNGEJMNPJPM_.Add(other.cNGEJMNPJPM_);
			aLHGBBFBKJG_.Add(other.aLHGBBFBKJG_);
			oNGHHAPHCEM_.Add(other.oNGHHAPHCEM_);
			hLKMMJLCJEC_.Add(other.hLKMMJLCJEC_);
			if (other.DNDGPEPOLNM != 0)
			{
				DNDGPEPOLNM = other.DNDGPEPOLNM;
			}
			if (other.IOIBCNHAOKG != 0)
			{
				IOIBCNHAOKG = other.IOIBCNHAOKG;
			}
			if (other.AOAEKPAPHOK != 0)
			{
				AOAEKPAPHOK = other.AOAEKPAPHOK;
			}
			if (other.NGJKIIIJBIB != 0)
			{
				NGJKIIIJBIB = other.NGJKIIIJBIB;
			}
			if (other.DNJEEOENMAA != 0)
			{
				DNJEEOENMAA = other.DNJEEOENMAA;
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
				BEOAPNBFOCI = input.ReadUInt32();
				break;
			case 18u:
				pIGFMOMEPHE_.AddEntriesFrom(ref input, _repeated_pIGFMOMEPHE_codec);
				break;
			case 40u:
				CostTime = input.ReadUInt32();
				break;
			case 50u:
				cNGEJMNPJPM_.AddEntriesFrom(ref input, _repeated_cNGEJMNPJPM_codec);
				break;
			case 58u:
				aLHGBBFBKJG_.AddEntriesFrom(ref input, _repeated_aLHGBBFBKJG_codec);
				break;
			case 66u:
				oNGHHAPHCEM_.AddEntriesFrom(ref input, _repeated_oNGHHAPHCEM_codec);
				break;
			case 74u:
				hLKMMJLCJEC_.AddEntriesFrom(ref input, _repeated_hLKMMJLCJEC_codec);
				break;
			case 80u:
				DNDGPEPOLNM = input.ReadUInt32();
				break;
			case 88u:
				IOIBCNHAOKG = input.ReadUInt32();
				break;
			case 96u:
				AOAEKPAPHOK = input.ReadUInt32();
				break;
			case 112u:
				NGJKIIIJBIB = input.ReadUInt32();
				break;
			case 120u:
				DNJEEOENMAA = input.ReadUInt32();
				break;
			}
		}
	}
}
