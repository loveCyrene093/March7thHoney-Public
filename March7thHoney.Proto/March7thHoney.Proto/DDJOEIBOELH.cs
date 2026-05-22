using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DDJOEIBOELH : IMessage<DDJOEIBOELH>, IMessage, IEquatable<DDJOEIBOELH>, IDeepCloneable<DDJOEIBOELH>, IBufferMessage
{
	public enum NKCBIECFIGKOneofCase
	{
		None = 0,
		BDLAMBNOGBH = 574,
		BKJNCIFKAGD = 616
	}

	private static readonly MessageParser<DDJOEIBOELH> _parser = new MessageParser<DDJOEIBOELH>(() => new DDJOEIBOELH());

	private UnknownFieldSet _unknownFields;

	public const int KLOLLDJJAOAFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_kLOLLDJJAOA_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> kLOLLDJJAOA_ = new RepeatedField<uint>();

	public const int DGBANFMAKMAFieldNumber = 2;

	private uint dGBANFMAKMA_;

	public const int GCPNCEDAMABFieldNumber = 4;

	private uint gCPNCEDAMAB_;

	public const int OFFIDMEJBGIFieldNumber = 5;

	private uint oFFIDMEJBGI_;

	public const int MNNDMPBFPJEFieldNumber = 10;

	private static readonly FieldCodec<KNCBIMAAFJG> _repeated_mNNDMPBFPJE_codec = FieldCodec.ForMessage(82u, KNCBIMAAFJG.Parser);

	private readonly RepeatedField<KNCBIMAAFJG> mNNDMPBFPJE_ = new RepeatedField<KNCBIMAAFJG>();

	public const int IJEEJNBNGOMFieldNumber = 11;

	private uint iJEEJNBNGOM_;

	public const int NNFAMOJAHCHFieldNumber = 13;

	private uint nNFAMOJAHCH_;

	public const int GNDEPOKFHPEFieldNumber = 14;

	private uint gNDEPOKFHPE_;

	public const int HpFieldNumber = 15;

	private uint hp_;

	public const int BDLAMBNOGBHFieldNumber = 574;

	public const int BKJNCIFKAGDFieldNumber = 616;

	private object nKCBIECFIGK_;

	private NKCBIECFIGKOneofCase nKCBIECFIGKCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DDJOEIBOELH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DDJOEIBOELHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KLOLLDJJAOA => kLOLLDJJAOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGBANFMAKMA
	{
		get
		{
			return dGBANFMAKMA_;
		}
		set
		{
			dGBANFMAKMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCPNCEDAMAB
	{
		get
		{
			return gCPNCEDAMAB_;
		}
		set
		{
			gCPNCEDAMAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFFIDMEJBGI
	{
		get
		{
			return oFFIDMEJBGI_;
		}
		set
		{
			oFFIDMEJBGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNCBIMAAFJG> MNNDMPBFPJE => mNNDMPBFPJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJEEJNBNGOM
	{
		get
		{
			return iJEEJNBNGOM_;
		}
		set
		{
			iJEEJNBNGOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNFAMOJAHCH
	{
		get
		{
			return nNFAMOJAHCH_;
		}
		set
		{
			nNFAMOJAHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GNDEPOKFHPE
	{
		get
		{
			return gNDEPOKFHPE_;
		}
		set
		{
			gNDEPOKFHPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGBFHNGJIM BDLAMBNOGBH
	{
		get
		{
			if (nKCBIECFIGKCase_ != NKCBIECFIGKOneofCase.BDLAMBNOGBH)
			{
				return null;
			}
			return (HAGBFHNGJIM)nKCBIECFIGK_;
		}
		set
		{
			nKCBIECFIGK_ = value;
			nKCBIECFIGKCase_ = ((value != null) ? NKCBIECFIGKOneofCase.BDLAMBNOGBH : NKCBIECFIGKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMAJILEBABM BKJNCIFKAGD
	{
		get
		{
			if (nKCBIECFIGKCase_ != NKCBIECFIGKOneofCase.BKJNCIFKAGD)
			{
				return null;
			}
			return (DMAJILEBABM)nKCBIECFIGK_;
		}
		set
		{
			nKCBIECFIGK_ = value;
			nKCBIECFIGKCase_ = ((value != null) ? NKCBIECFIGKOneofCase.BKJNCIFKAGD : NKCBIECFIGKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKCBIECFIGKOneofCase NKCBIECFIGKCase => nKCBIECFIGKCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJOEIBOELH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJOEIBOELH(DDJOEIBOELH other)
		: this()
	{
		kLOLLDJJAOA_ = other.kLOLLDJJAOA_.Clone();
		dGBANFMAKMA_ = other.dGBANFMAKMA_;
		gCPNCEDAMAB_ = other.gCPNCEDAMAB_;
		oFFIDMEJBGI_ = other.oFFIDMEJBGI_;
		mNNDMPBFPJE_ = other.mNNDMPBFPJE_.Clone();
		iJEEJNBNGOM_ = other.iJEEJNBNGOM_;
		nNFAMOJAHCH_ = other.nNFAMOJAHCH_;
		gNDEPOKFHPE_ = other.gNDEPOKFHPE_;
		hp_ = other.hp_;
		switch (other.NKCBIECFIGKCase)
		{
		case NKCBIECFIGKOneofCase.BDLAMBNOGBH:
			BDLAMBNOGBH = other.BDLAMBNOGBH.Clone();
			break;
		case NKCBIECFIGKOneofCase.BKJNCIFKAGD:
			BKJNCIFKAGD = other.BKJNCIFKAGD.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJOEIBOELH Clone()
	{
		return new DDJOEIBOELH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNKCBIECFIGK()
	{
		nKCBIECFIGKCase_ = NKCBIECFIGKOneofCase.None;
		nKCBIECFIGK_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DDJOEIBOELH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DDJOEIBOELH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kLOLLDJJAOA_.Equals(other.kLOLLDJJAOA_))
		{
			return false;
		}
		if (DGBANFMAKMA != other.DGBANFMAKMA)
		{
			return false;
		}
		if (GCPNCEDAMAB != other.GCPNCEDAMAB)
		{
			return false;
		}
		if (OFFIDMEJBGI != other.OFFIDMEJBGI)
		{
			return false;
		}
		if (!mNNDMPBFPJE_.Equals(other.mNNDMPBFPJE_))
		{
			return false;
		}
		if (IJEEJNBNGOM != other.IJEEJNBNGOM)
		{
			return false;
		}
		if (NNFAMOJAHCH != other.NNFAMOJAHCH)
		{
			return false;
		}
		if (GNDEPOKFHPE != other.GNDEPOKFHPE)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (!object.Equals(BDLAMBNOGBH, other.BDLAMBNOGBH))
		{
			return false;
		}
		if (!object.Equals(BKJNCIFKAGD, other.BKJNCIFKAGD))
		{
			return false;
		}
		if (NKCBIECFIGKCase != other.NKCBIECFIGKCase)
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
		num ^= kLOLLDJJAOA_.GetHashCode();
		if (DGBANFMAKMA != 0)
		{
			num ^= DGBANFMAKMA.GetHashCode();
		}
		if (GCPNCEDAMAB != 0)
		{
			num ^= GCPNCEDAMAB.GetHashCode();
		}
		if (OFFIDMEJBGI != 0)
		{
			num ^= OFFIDMEJBGI.GetHashCode();
		}
		num ^= mNNDMPBFPJE_.GetHashCode();
		if (IJEEJNBNGOM != 0)
		{
			num ^= IJEEJNBNGOM.GetHashCode();
		}
		if (NNFAMOJAHCH != 0)
		{
			num ^= NNFAMOJAHCH.GetHashCode();
		}
		if (GNDEPOKFHPE != 0)
		{
			num ^= GNDEPOKFHPE.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BDLAMBNOGBH)
		{
			num ^= BDLAMBNOGBH.GetHashCode();
		}
		if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BKJNCIFKAGD)
		{
			num ^= BKJNCIFKAGD.GetHashCode();
		}
		num ^= (int)nKCBIECFIGKCase_;
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
		kLOLLDJJAOA_.WriteTo(ref output, _repeated_kLOLLDJJAOA_codec);
		if (DGBANFMAKMA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DGBANFMAKMA);
		}
		if (GCPNCEDAMAB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GCPNCEDAMAB);
		}
		if (OFFIDMEJBGI != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OFFIDMEJBGI);
		}
		mNNDMPBFPJE_.WriteTo(ref output, _repeated_mNNDMPBFPJE_codec);
		if (IJEEJNBNGOM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IJEEJNBNGOM);
		}
		if (NNFAMOJAHCH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NNFAMOJAHCH);
		}
		if (GNDEPOKFHPE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GNDEPOKFHPE);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Hp);
		}
		if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BDLAMBNOGBH)
		{
			output.WriteRawTag(242, 35);
			output.WriteMessage(BDLAMBNOGBH);
		}
		if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BKJNCIFKAGD)
		{
			output.WriteRawTag(194, 38);
			output.WriteMessage(BKJNCIFKAGD);
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
		num += kLOLLDJJAOA_.CalculateSize(_repeated_kLOLLDJJAOA_codec);
		if (DGBANFMAKMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGBANFMAKMA);
		}
		if (GCPNCEDAMAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCPNCEDAMAB);
		}
		if (OFFIDMEJBGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFFIDMEJBGI);
		}
		num += mNNDMPBFPJE_.CalculateSize(_repeated_mNNDMPBFPJE_codec);
		if (IJEEJNBNGOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJEEJNBNGOM);
		}
		if (NNFAMOJAHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNFAMOJAHCH);
		}
		if (GNDEPOKFHPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GNDEPOKFHPE);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BDLAMBNOGBH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BDLAMBNOGBH);
		}
		if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BKJNCIFKAGD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BKJNCIFKAGD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DDJOEIBOELH other)
	{
		if (other == null)
		{
			return;
		}
		kLOLLDJJAOA_.Add(other.kLOLLDJJAOA_);
		if (other.DGBANFMAKMA != 0)
		{
			DGBANFMAKMA = other.DGBANFMAKMA;
		}
		if (other.GCPNCEDAMAB != 0)
		{
			GCPNCEDAMAB = other.GCPNCEDAMAB;
		}
		if (other.OFFIDMEJBGI != 0)
		{
			OFFIDMEJBGI = other.OFFIDMEJBGI;
		}
		mNNDMPBFPJE_.Add(other.mNNDMPBFPJE_);
		if (other.IJEEJNBNGOM != 0)
		{
			IJEEJNBNGOM = other.IJEEJNBNGOM;
		}
		if (other.NNFAMOJAHCH != 0)
		{
			NNFAMOJAHCH = other.NNFAMOJAHCH;
		}
		if (other.GNDEPOKFHPE != 0)
		{
			GNDEPOKFHPE = other.GNDEPOKFHPE;
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		switch (other.NKCBIECFIGKCase)
		{
		case NKCBIECFIGKOneofCase.BDLAMBNOGBH:
			if (BDLAMBNOGBH == null)
			{
				BDLAMBNOGBH = new HAGBFHNGJIM();
			}
			BDLAMBNOGBH.MergeFrom(other.BDLAMBNOGBH);
			break;
		case NKCBIECFIGKOneofCase.BKJNCIFKAGD:
			if (BKJNCIFKAGD == null)
			{
				BKJNCIFKAGD = new DMAJILEBABM();
			}
			BKJNCIFKAGD.MergeFrom(other.BKJNCIFKAGD);
			break;
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
				kLOLLDJJAOA_.AddEntriesFrom(ref input, _repeated_kLOLLDJJAOA_codec);
				break;
			case 16u:
				DGBANFMAKMA = input.ReadUInt32();
				break;
			case 32u:
				GCPNCEDAMAB = input.ReadUInt32();
				break;
			case 40u:
				OFFIDMEJBGI = input.ReadUInt32();
				break;
			case 82u:
				mNNDMPBFPJE_.AddEntriesFrom(ref input, _repeated_mNNDMPBFPJE_codec);
				break;
			case 88u:
				IJEEJNBNGOM = input.ReadUInt32();
				break;
			case 104u:
				NNFAMOJAHCH = input.ReadUInt32();
				break;
			case 112u:
				GNDEPOKFHPE = input.ReadUInt32();
				break;
			case 120u:
				Hp = input.ReadUInt32();
				break;
			case 4594u:
			{
				HAGBFHNGJIM hAGBFHNGJIM = new HAGBFHNGJIM();
				if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BDLAMBNOGBH)
				{
					hAGBFHNGJIM.MergeFrom(BDLAMBNOGBH);
				}
				input.ReadMessage(hAGBFHNGJIM);
				BDLAMBNOGBH = hAGBFHNGJIM;
				break;
			}
			case 4930u:
			{
				DMAJILEBABM dMAJILEBABM = new DMAJILEBABM();
				if (nKCBIECFIGKCase_ == NKCBIECFIGKOneofCase.BKJNCIFKAGD)
				{
					dMAJILEBABM.MergeFrom(BKJNCIFKAGD);
				}
				input.ReadMessage(dMAJILEBABM);
				BKJNCIFKAGD = dMAJILEBABM;
				break;
			}
			}
		}
	}
}
