using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyInfo : IMessage<TrainPartyInfo>, IMessage, IEquatable<TrainPartyInfo>, IDeepCloneable<TrainPartyInfo>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyInfo> _parser = new MessageParser<TrainPartyInfo>(() => new TrainPartyInfo());

	private UnknownFieldSet _unknownFields;

	public const int HNFNKLHLJLGFieldNumber = 1;

	private static readonly FieldCodec<GHLDNDDFEIE> _repeated_hNFNKLHLJLG_codec = FieldCodec.ForMessage(10u, GHLDNDDFEIE.Parser);

	private readonly RepeatedField<GHLDNDDFEIE> hNFNKLHLJLG_ = new RepeatedField<GHLDNDDFEIE>();

	public const int EKLIAOBCHPIFieldNumber = 2;

	private bool eKLIAOBCHPI_;

	public const int FCLJEACKGLEFieldNumber = 3;

	private KJGMAEGNBKL fCLJEACKGLE_;

	public const int MPDONIKHIOBFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_mPDONIKHIOB_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> mPDONIKHIOB_ = new RepeatedField<uint>();

	public const int NMBFMHLNPLMFieldNumber = 5;

	private uint nMBFMHLNPLM_;

	public const int DynamicIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_dynamicIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> dynamicIdList_ = new RepeatedField<uint>();

	public const int GBDEGDGGKOLFieldNumber = 7;

	private static readonly FieldCodec<CCAIPEBCIMH> _repeated_gBDEGDGGKOL_codec = FieldCodec.ForMessage(58u, CCAIPEBCIMH.Parser);

	private readonly RepeatedField<CCAIPEBCIMH> gBDEGDGGKOL_ = new RepeatedField<CCAIPEBCIMH>();

	public const int CurFundFieldNumber = 9;

	private uint curFund_;

	public const int OBAMHCIFFOCFieldNumber = 10;

	private uint oBAMHCIFFOC_;

	public const int ALODJFPDKAMFieldNumber = 11;

	private uint aLODJFPDKAM_;

	public const int OLHGMPCDDKAFieldNumber = 12;

	private uint oLHGMPCDDKA_;

	public const int MMFEPEBGAFCFieldNumber = 13;

	private static readonly FieldCodec<CBGAODCKAGB> _repeated_mMFEPEBGAFC_codec = FieldCodec.ForMessage(106u, CBGAODCKAGB.Parser);

	private readonly RepeatedField<CBGAODCKAGB> mMFEPEBGAFC_ = new RepeatedField<CBGAODCKAGB>();

	public const int HIHKGPJCDPKFieldNumber = 14;

	private uint hIHKGPJCDPK_;

	public const int AreaListFieldNumber = 15;

	private static readonly FieldCodec<TrainPartyArea> _repeated_areaList_codec = FieldCodec.ForMessage(122u, TrainPartyArea.Parser);

	private readonly RepeatedField<TrainPartyArea> areaList_ = new RepeatedField<TrainPartyArea>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GHLDNDDFEIE> HNFNKLHLJLG => hNFNKLHLJLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EKLIAOBCHPI
	{
		get
		{
			return eKLIAOBCHPI_;
		}
		set
		{
			eKLIAOBCHPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJGMAEGNBKL FCLJEACKGLE
	{
		get
		{
			return fCLJEACKGLE_;
		}
		set
		{
			fCLJEACKGLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPDONIKHIOB => mPDONIKHIOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMBFMHLNPLM
	{
		get
		{
			return nMBFMHLNPLM_;
		}
		set
		{
			nMBFMHLNPLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DynamicIdList => dynamicIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCAIPEBCIMH> GBDEGDGGKOL => gBDEGDGGKOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurFund
	{
		get
		{
			return curFund_;
		}
		set
		{
			curFund_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OBAMHCIFFOC
	{
		get
		{
			return oBAMHCIFFOC_;
		}
		set
		{
			oBAMHCIFFOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ALODJFPDKAM
	{
		get
		{
			return aLODJFPDKAM_;
		}
		set
		{
			aLODJFPDKAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OLHGMPCDDKA
	{
		get
		{
			return oLHGMPCDDKA_;
		}
		set
		{
			oLHGMPCDDKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CBGAODCKAGB> MMFEPEBGAFC => mMFEPEBGAFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HIHKGPJCDPK
	{
		get
		{
			return hIHKGPJCDPK_;
		}
		set
		{
			hIHKGPJCDPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TrainPartyArea> AreaList => areaList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyInfo(TrainPartyInfo other)
		: this()
	{
		hNFNKLHLJLG_ = other.hNFNKLHLJLG_.Clone();
		eKLIAOBCHPI_ = other.eKLIAOBCHPI_;
		fCLJEACKGLE_ = ((other.fCLJEACKGLE_ != null) ? other.fCLJEACKGLE_.Clone() : null);
		mPDONIKHIOB_ = other.mPDONIKHIOB_.Clone();
		nMBFMHLNPLM_ = other.nMBFMHLNPLM_;
		dynamicIdList_ = other.dynamicIdList_.Clone();
		gBDEGDGGKOL_ = other.gBDEGDGGKOL_.Clone();
		curFund_ = other.curFund_;
		oBAMHCIFFOC_ = other.oBAMHCIFFOC_;
		aLODJFPDKAM_ = other.aLODJFPDKAM_;
		oLHGMPCDDKA_ = other.oLHGMPCDDKA_;
		mMFEPEBGAFC_ = other.mMFEPEBGAFC_.Clone();
		hIHKGPJCDPK_ = other.hIHKGPJCDPK_;
		areaList_ = other.areaList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyInfo Clone()
	{
		return new TrainPartyInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hNFNKLHLJLG_.Equals(other.hNFNKLHLJLG_))
		{
			return false;
		}
		if (EKLIAOBCHPI != other.EKLIAOBCHPI)
		{
			return false;
		}
		if (!object.Equals(FCLJEACKGLE, other.FCLJEACKGLE))
		{
			return false;
		}
		if (!mPDONIKHIOB_.Equals(other.mPDONIKHIOB_))
		{
			return false;
		}
		if (NMBFMHLNPLM != other.NMBFMHLNPLM)
		{
			return false;
		}
		if (!dynamicIdList_.Equals(other.dynamicIdList_))
		{
			return false;
		}
		if (!gBDEGDGGKOL_.Equals(other.gBDEGDGGKOL_))
		{
			return false;
		}
		if (CurFund != other.CurFund)
		{
			return false;
		}
		if (OBAMHCIFFOC != other.OBAMHCIFFOC)
		{
			return false;
		}
		if (ALODJFPDKAM != other.ALODJFPDKAM)
		{
			return false;
		}
		if (OLHGMPCDDKA != other.OLHGMPCDDKA)
		{
			return false;
		}
		if (!mMFEPEBGAFC_.Equals(other.mMFEPEBGAFC_))
		{
			return false;
		}
		if (HIHKGPJCDPK != other.HIHKGPJCDPK)
		{
			return false;
		}
		if (!areaList_.Equals(other.areaList_))
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
		num ^= hNFNKLHLJLG_.GetHashCode();
		if (EKLIAOBCHPI)
		{
			num ^= EKLIAOBCHPI.GetHashCode();
		}
		if (fCLJEACKGLE_ != null)
		{
			num ^= FCLJEACKGLE.GetHashCode();
		}
		num ^= mPDONIKHIOB_.GetHashCode();
		if (NMBFMHLNPLM != 0)
		{
			num ^= NMBFMHLNPLM.GetHashCode();
		}
		num ^= dynamicIdList_.GetHashCode();
		num ^= gBDEGDGGKOL_.GetHashCode();
		if (CurFund != 0)
		{
			num ^= CurFund.GetHashCode();
		}
		if (OBAMHCIFFOC != 0)
		{
			num ^= OBAMHCIFFOC.GetHashCode();
		}
		if (ALODJFPDKAM != 0)
		{
			num ^= ALODJFPDKAM.GetHashCode();
		}
		if (OLHGMPCDDKA != 0)
		{
			num ^= OLHGMPCDDKA.GetHashCode();
		}
		num ^= mMFEPEBGAFC_.GetHashCode();
		if (HIHKGPJCDPK != 0)
		{
			num ^= HIHKGPJCDPK.GetHashCode();
		}
		num ^= areaList_.GetHashCode();
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
		hNFNKLHLJLG_.WriteTo(ref output, _repeated_hNFNKLHLJLG_codec);
		if (EKLIAOBCHPI)
		{
			output.WriteRawTag(16);
			output.WriteBool(EKLIAOBCHPI);
		}
		if (fCLJEACKGLE_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(FCLJEACKGLE);
		}
		mPDONIKHIOB_.WriteTo(ref output, _repeated_mPDONIKHIOB_codec);
		if (NMBFMHLNPLM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NMBFMHLNPLM);
		}
		dynamicIdList_.WriteTo(ref output, _repeated_dynamicIdList_codec);
		gBDEGDGGKOL_.WriteTo(ref output, _repeated_gBDEGDGGKOL_codec);
		if (CurFund != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CurFund);
		}
		if (OBAMHCIFFOC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OBAMHCIFFOC);
		}
		if (ALODJFPDKAM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ALODJFPDKAM);
		}
		if (OLHGMPCDDKA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OLHGMPCDDKA);
		}
		mMFEPEBGAFC_.WriteTo(ref output, _repeated_mMFEPEBGAFC_codec);
		if (HIHKGPJCDPK != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HIHKGPJCDPK);
		}
		areaList_.WriteTo(ref output, _repeated_areaList_codec);
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
		num += hNFNKLHLJLG_.CalculateSize(_repeated_hNFNKLHLJLG_codec);
		if (EKLIAOBCHPI)
		{
			num += 2;
		}
		if (fCLJEACKGLE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCLJEACKGLE);
		}
		num += mPDONIKHIOB_.CalculateSize(_repeated_mPDONIKHIOB_codec);
		if (NMBFMHLNPLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMBFMHLNPLM);
		}
		num += dynamicIdList_.CalculateSize(_repeated_dynamicIdList_codec);
		num += gBDEGDGGKOL_.CalculateSize(_repeated_gBDEGDGGKOL_codec);
		if (CurFund != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurFund);
		}
		if (OBAMHCIFFOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBAMHCIFFOC);
		}
		if (ALODJFPDKAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ALODJFPDKAM);
		}
		if (OLHGMPCDDKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OLHGMPCDDKA);
		}
		num += mMFEPEBGAFC_.CalculateSize(_repeated_mMFEPEBGAFC_codec);
		if (HIHKGPJCDPK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HIHKGPJCDPK);
		}
		num += areaList_.CalculateSize(_repeated_areaList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyInfo other)
	{
		if (other == null)
		{
			return;
		}
		hNFNKLHLJLG_.Add(other.hNFNKLHLJLG_);
		if (other.EKLIAOBCHPI)
		{
			EKLIAOBCHPI = other.EKLIAOBCHPI;
		}
		if (other.fCLJEACKGLE_ != null)
		{
			if (fCLJEACKGLE_ == null)
			{
				FCLJEACKGLE = new KJGMAEGNBKL();
			}
			FCLJEACKGLE.MergeFrom(other.FCLJEACKGLE);
		}
		mPDONIKHIOB_.Add(other.mPDONIKHIOB_);
		if (other.NMBFMHLNPLM != 0)
		{
			NMBFMHLNPLM = other.NMBFMHLNPLM;
		}
		dynamicIdList_.Add(other.dynamicIdList_);
		gBDEGDGGKOL_.Add(other.gBDEGDGGKOL_);
		if (other.CurFund != 0)
		{
			CurFund = other.CurFund;
		}
		if (other.OBAMHCIFFOC != 0)
		{
			OBAMHCIFFOC = other.OBAMHCIFFOC;
		}
		if (other.ALODJFPDKAM != 0)
		{
			ALODJFPDKAM = other.ALODJFPDKAM;
		}
		if (other.OLHGMPCDDKA != 0)
		{
			OLHGMPCDDKA = other.OLHGMPCDDKA;
		}
		mMFEPEBGAFC_.Add(other.mMFEPEBGAFC_);
		if (other.HIHKGPJCDPK != 0)
		{
			HIHKGPJCDPK = other.HIHKGPJCDPK;
		}
		areaList_.Add(other.areaList_);
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
			case 10u:
				hNFNKLHLJLG_.AddEntriesFrom(ref input, _repeated_hNFNKLHLJLG_codec);
				break;
			case 16u:
				EKLIAOBCHPI = input.ReadBool();
				break;
			case 26u:
				if (fCLJEACKGLE_ == null)
				{
					FCLJEACKGLE = new KJGMAEGNBKL();
				}
				input.ReadMessage(FCLJEACKGLE);
				break;
			case 32u:
			case 34u:
				mPDONIKHIOB_.AddEntriesFrom(ref input, _repeated_mPDONIKHIOB_codec);
				break;
			case 40u:
				NMBFMHLNPLM = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				dynamicIdList_.AddEntriesFrom(ref input, _repeated_dynamicIdList_codec);
				break;
			case 58u:
				gBDEGDGGKOL_.AddEntriesFrom(ref input, _repeated_gBDEGDGGKOL_codec);
				break;
			case 72u:
				CurFund = input.ReadUInt32();
				break;
			case 80u:
				OBAMHCIFFOC = input.ReadUInt32();
				break;
			case 88u:
				ALODJFPDKAM = input.ReadUInt32();
				break;
			case 96u:
				OLHGMPCDDKA = input.ReadUInt32();
				break;
			case 106u:
				mMFEPEBGAFC_.AddEntriesFrom(ref input, _repeated_mMFEPEBGAFC_codec);
				break;
			case 112u:
				HIHKGPJCDPK = input.ReadUInt32();
				break;
			case 122u:
				areaList_.AddEntriesFrom(ref input, _repeated_areaList_codec);
				break;
			}
		}
	}
}
