using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JEBLAAGCNHN : IMessage<JEBLAAGCNHN>, IMessage, IEquatable<JEBLAAGCNHN>, IDeepCloneable<JEBLAAGCNHN>, IBufferMessage
{
	private static readonly MessageParser<JEBLAAGCNHN> _parser = new MessageParser<JEBLAAGCNHN>(() => new JEBLAAGCNHN());

	private UnknownFieldSet _unknownFields;

	public const int AHHJLMPKFHNFieldNumber = 3;

	private uint aHHJLMPKFHN_;

	public const int LOLCBFCJPAMFieldNumber = 4;

	private uint lOLCBFCJPAM_;

	public const int DNEKFLCJDKHFieldNumber = 5;

	private uint dNEKFLCJDKH_;

	public const int EMKOIOIFDKGFieldNumber = 8;

	private uint eMKOIOIFDKG_;

	public const int NLMMFJOPBFCFieldNumber = 10;

	private uint nLMMFJOPBFC_;

	public const int HLCIKBIFKIKFieldNumber = 11;

	private uint hLCIKBIFKIK_;

	public const int LJEECOOPMLMFieldNumber = 12;

	private uint lJEECOOPMLM_;

	public const int JFGEBNBAEGJFieldNumber = 13;

	private uint jFGEBNBAEGJ_;

	public const int MNKNAEECKPMFieldNumber = 15;

	private uint mNKNAEECKPM_;

	public const int EBKDJHLFOGNFieldNumber = 28;

	private static readonly FieldCodec<DOGGIDNINJP> _repeated_eBKDJHLFOGN_codec = FieldCodec.ForMessage(226u, DOGGIDNINJP.Parser);

	private readonly RepeatedField<DOGGIDNINJP> eBKDJHLFOGN_ = new RepeatedField<DOGGIDNINJP>();

	public const int BICPNKOCHGNFieldNumber = 91;

	private static readonly FieldCodec<KHHHFHEODED> _repeated_bICPNKOCHGN_codec = FieldCodec.ForMessage(730u, KHHHFHEODED.Parser);

	private readonly RepeatedField<KHHHFHEODED> bICPNKOCHGN_ = new RepeatedField<KHHHFHEODED>();

	public const int AvatarIdListFieldNumber = 796;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(6370u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int ACPBOHCHHKGFieldNumber = 1983;

	private static readonly FieldCodec<uint> _repeated_aCPBOHCHHKG_codec = FieldCodec.ForUInt32(15866u);

	private readonly RepeatedField<uint> aCPBOHCHHKG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JEBLAAGCNHN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JEBLAAGCNHNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHHJLMPKFHN
	{
		get
		{
			return aHHJLMPKFHN_;
		}
		set
		{
			aHHJLMPKFHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOLCBFCJPAM
	{
		get
		{
			return lOLCBFCJPAM_;
		}
		set
		{
			lOLCBFCJPAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DNEKFLCJDKH
	{
		get
		{
			return dNEKFLCJDKH_;
		}
		set
		{
			dNEKFLCJDKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMKOIOIFDKG
	{
		get
		{
			return eMKOIOIFDKG_;
		}
		set
		{
			eMKOIOIFDKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLMMFJOPBFC
	{
		get
		{
			return nLMMFJOPBFC_;
		}
		set
		{
			nLMMFJOPBFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HLCIKBIFKIK
	{
		get
		{
			return hLCIKBIFKIK_;
		}
		set
		{
			hLCIKBIFKIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJEECOOPMLM
	{
		get
		{
			return lJEECOOPMLM_;
		}
		set
		{
			lJEECOOPMLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFGEBNBAEGJ
	{
		get
		{
			return jFGEBNBAEGJ_;
		}
		set
		{
			jFGEBNBAEGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNKNAEECKPM
	{
		get
		{
			return mNKNAEECKPM_;
		}
		set
		{
			mNKNAEECKPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOGGIDNINJP> EBKDJHLFOGN => eBKDJHLFOGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KHHHFHEODED> BICPNKOCHGN => bICPNKOCHGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ACPBOHCHHKG => aCPBOHCHHKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEBLAAGCNHN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEBLAAGCNHN(JEBLAAGCNHN other)
		: this()
	{
		aHHJLMPKFHN_ = other.aHHJLMPKFHN_;
		lOLCBFCJPAM_ = other.lOLCBFCJPAM_;
		dNEKFLCJDKH_ = other.dNEKFLCJDKH_;
		eMKOIOIFDKG_ = other.eMKOIOIFDKG_;
		nLMMFJOPBFC_ = other.nLMMFJOPBFC_;
		hLCIKBIFKIK_ = other.hLCIKBIFKIK_;
		lJEECOOPMLM_ = other.lJEECOOPMLM_;
		jFGEBNBAEGJ_ = other.jFGEBNBAEGJ_;
		mNKNAEECKPM_ = other.mNKNAEECKPM_;
		eBKDJHLFOGN_ = other.eBKDJHLFOGN_.Clone();
		bICPNKOCHGN_ = other.bICPNKOCHGN_.Clone();
		avatarIdList_ = other.avatarIdList_.Clone();
		aCPBOHCHHKG_ = other.aCPBOHCHHKG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEBLAAGCNHN Clone()
	{
		return new JEBLAAGCNHN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JEBLAAGCNHN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JEBLAAGCNHN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AHHJLMPKFHN != other.AHHJLMPKFHN)
		{
			return false;
		}
		if (LOLCBFCJPAM != other.LOLCBFCJPAM)
		{
			return false;
		}
		if (DNEKFLCJDKH != other.DNEKFLCJDKH)
		{
			return false;
		}
		if (EMKOIOIFDKG != other.EMKOIOIFDKG)
		{
			return false;
		}
		if (NLMMFJOPBFC != other.NLMMFJOPBFC)
		{
			return false;
		}
		if (HLCIKBIFKIK != other.HLCIKBIFKIK)
		{
			return false;
		}
		if (LJEECOOPMLM != other.LJEECOOPMLM)
		{
			return false;
		}
		if (JFGEBNBAEGJ != other.JFGEBNBAEGJ)
		{
			return false;
		}
		if (MNKNAEECKPM != other.MNKNAEECKPM)
		{
			return false;
		}
		if (!eBKDJHLFOGN_.Equals(other.eBKDJHLFOGN_))
		{
			return false;
		}
		if (!bICPNKOCHGN_.Equals(other.bICPNKOCHGN_))
		{
			return false;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (!aCPBOHCHHKG_.Equals(other.aCPBOHCHHKG_))
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
		if (AHHJLMPKFHN != 0)
		{
			num ^= AHHJLMPKFHN.GetHashCode();
		}
		if (LOLCBFCJPAM != 0)
		{
			num ^= LOLCBFCJPAM.GetHashCode();
		}
		if (DNEKFLCJDKH != 0)
		{
			num ^= DNEKFLCJDKH.GetHashCode();
		}
		if (EMKOIOIFDKG != 0)
		{
			num ^= EMKOIOIFDKG.GetHashCode();
		}
		if (NLMMFJOPBFC != 0)
		{
			num ^= NLMMFJOPBFC.GetHashCode();
		}
		if (HLCIKBIFKIK != 0)
		{
			num ^= HLCIKBIFKIK.GetHashCode();
		}
		if (LJEECOOPMLM != 0)
		{
			num ^= LJEECOOPMLM.GetHashCode();
		}
		if (JFGEBNBAEGJ != 0)
		{
			num ^= JFGEBNBAEGJ.GetHashCode();
		}
		if (MNKNAEECKPM != 0)
		{
			num ^= MNKNAEECKPM.GetHashCode();
		}
		num ^= eBKDJHLFOGN_.GetHashCode();
		num ^= bICPNKOCHGN_.GetHashCode();
		num ^= avatarIdList_.GetHashCode();
		num ^= aCPBOHCHHKG_.GetHashCode();
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
		if (AHHJLMPKFHN != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AHHJLMPKFHN);
		}
		if (LOLCBFCJPAM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LOLCBFCJPAM);
		}
		if (DNEKFLCJDKH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DNEKFLCJDKH);
		}
		if (EMKOIOIFDKG != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EMKOIOIFDKG);
		}
		if (NLMMFJOPBFC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NLMMFJOPBFC);
		}
		if (HLCIKBIFKIK != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HLCIKBIFKIK);
		}
		if (LJEECOOPMLM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LJEECOOPMLM);
		}
		if (JFGEBNBAEGJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JFGEBNBAEGJ);
		}
		if (MNKNAEECKPM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MNKNAEECKPM);
		}
		eBKDJHLFOGN_.WriteTo(ref output, _repeated_eBKDJHLFOGN_codec);
		bICPNKOCHGN_.WriteTo(ref output, _repeated_bICPNKOCHGN_codec);
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		aCPBOHCHHKG_.WriteTo(ref output, _repeated_aCPBOHCHHKG_codec);
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
		if (AHHJLMPKFHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHHJLMPKFHN);
		}
		if (LOLCBFCJPAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOLCBFCJPAM);
		}
		if (DNEKFLCJDKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DNEKFLCJDKH);
		}
		if (EMKOIOIFDKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMKOIOIFDKG);
		}
		if (NLMMFJOPBFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLMMFJOPBFC);
		}
		if (HLCIKBIFKIK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HLCIKBIFKIK);
		}
		if (LJEECOOPMLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJEECOOPMLM);
		}
		if (JFGEBNBAEGJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFGEBNBAEGJ);
		}
		if (MNKNAEECKPM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNKNAEECKPM);
		}
		num += eBKDJHLFOGN_.CalculateSize(_repeated_eBKDJHLFOGN_codec);
		num += bICPNKOCHGN_.CalculateSize(_repeated_bICPNKOCHGN_codec);
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		num += aCPBOHCHHKG_.CalculateSize(_repeated_aCPBOHCHHKG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JEBLAAGCNHN other)
	{
		if (other != null)
		{
			if (other.AHHJLMPKFHN != 0)
			{
				AHHJLMPKFHN = other.AHHJLMPKFHN;
			}
			if (other.LOLCBFCJPAM != 0)
			{
				LOLCBFCJPAM = other.LOLCBFCJPAM;
			}
			if (other.DNEKFLCJDKH != 0)
			{
				DNEKFLCJDKH = other.DNEKFLCJDKH;
			}
			if (other.EMKOIOIFDKG != 0)
			{
				EMKOIOIFDKG = other.EMKOIOIFDKG;
			}
			if (other.NLMMFJOPBFC != 0)
			{
				NLMMFJOPBFC = other.NLMMFJOPBFC;
			}
			if (other.HLCIKBIFKIK != 0)
			{
				HLCIKBIFKIK = other.HLCIKBIFKIK;
			}
			if (other.LJEECOOPMLM != 0)
			{
				LJEECOOPMLM = other.LJEECOOPMLM;
			}
			if (other.JFGEBNBAEGJ != 0)
			{
				JFGEBNBAEGJ = other.JFGEBNBAEGJ;
			}
			if (other.MNKNAEECKPM != 0)
			{
				MNKNAEECKPM = other.MNKNAEECKPM;
			}
			eBKDJHLFOGN_.Add(other.eBKDJHLFOGN_);
			bICPNKOCHGN_.Add(other.bICPNKOCHGN_);
			avatarIdList_.Add(other.avatarIdList_);
			aCPBOHCHHKG_.Add(other.aCPBOHCHHKG_);
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
				AHHJLMPKFHN = input.ReadUInt32();
				break;
			case 32u:
				LOLCBFCJPAM = input.ReadUInt32();
				break;
			case 40u:
				DNEKFLCJDKH = input.ReadUInt32();
				break;
			case 64u:
				EMKOIOIFDKG = input.ReadUInt32();
				break;
			case 80u:
				NLMMFJOPBFC = input.ReadUInt32();
				break;
			case 88u:
				HLCIKBIFKIK = input.ReadUInt32();
				break;
			case 96u:
				LJEECOOPMLM = input.ReadUInt32();
				break;
			case 104u:
				JFGEBNBAEGJ = input.ReadUInt32();
				break;
			case 120u:
				MNKNAEECKPM = input.ReadUInt32();
				break;
			case 226u:
				eBKDJHLFOGN_.AddEntriesFrom(ref input, _repeated_eBKDJHLFOGN_codec);
				break;
			case 730u:
				bICPNKOCHGN_.AddEntriesFrom(ref input, _repeated_bICPNKOCHGN_codec);
				break;
			case 6368u:
			case 6370u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 15864u:
			case 15866u:
				aCPBOHCHHKG_.AddEntriesFrom(ref input, _repeated_aCPBOHCHHKG_codec);
				break;
			}
		}
	}
}
