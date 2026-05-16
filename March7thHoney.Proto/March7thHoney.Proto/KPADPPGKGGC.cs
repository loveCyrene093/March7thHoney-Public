using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KPADPPGKGGC : IMessage<KPADPPGKGGC>, IMessage, IEquatable<KPADPPGKGGC>, IDeepCloneable<KPADPPGKGGC>, IBufferMessage
{
	private static readonly MessageParser<KPADPPGKGGC> _parser = new MessageParser<KPADPPGKGGC>(() => new KPADPPGKGGC());

	private UnknownFieldSet _unknownFields;

	public const int LJEECOOPMLMFieldNumber = 1;

	private uint lJEECOOPMLM_;

	public const int MCHAFKKFEDKFieldNumber = 2;

	private uint mCHAFKKFEDK_;

	public const int OJAPMNAPIFGFieldNumber = 3;

	private bool oJAPMNAPIFG_;

	public const int OPIDHKEKPKBFieldNumber = 4;

	private uint oPIDHKEKPKB_;

	public const int NICEPKDHFDEFieldNumber = 5;

	private ItemCostData nICEPKDHFDE_;

	public const int BKBKLONBPOBFieldNumber = 7;

	private static readonly FieldCodec<OLJJJBCKLDK> _repeated_bKBKLONBPOB_codec = FieldCodec.ForMessage(58u, OLJJJBCKLDK.Parser);

	private readonly RepeatedField<OLJJJBCKLDK> bKBKLONBPOB_ = new RepeatedField<OLJJJBCKLDK>();

	public const int MMINJCFNADKFieldNumber = 8;

	private uint mMINJCFNADK_;

	public const int CHPFCFGNCAGFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_cHPFCFGNCAG_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> cHPFCFGNCAG_ = new RepeatedField<uint>();

	public const int KOOHHHAOBEOFieldNumber = 10;

	private uint kOOHHHAOBEO_;

	public const int ALFHNEHOBJAFieldNumber = 11;

	private RogueCommonBuffSelectSourceType aLFHNEHOBJA_;

	public const int EJALOMHNGCJFieldNumber = 12;

	private uint eJALOMHNGCJ_;

	public const int LDMEEJCCKIHFieldNumber = 13;

	private uint lDMEEJCCKIH_;

	public const int MDHOHBHBGNCFieldNumber = 14;

	private uint mDHOHBHBGNC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KPADPPGKGGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KPADPPGKGGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MCHAFKKFEDK
	{
		get
		{
			return mCHAFKKFEDK_;
		}
		set
		{
			mCHAFKKFEDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OJAPMNAPIFG
	{
		get
		{
			return oJAPMNAPIFG_;
		}
		set
		{
			oJAPMNAPIFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPIDHKEKPKB
	{
		get
		{
			return oPIDHKEKPKB_;
		}
		set
		{
			oPIDHKEKPKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData NICEPKDHFDE
	{
		get
		{
			return nICEPKDHFDE_;
		}
		set
		{
			nICEPKDHFDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLJJJBCKLDK> BKBKLONBPOB => bKBKLONBPOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMINJCFNADK
	{
		get
		{
			return mMINJCFNADK_;
		}
		set
		{
			mMINJCFNADK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CHPFCFGNCAG => cHPFCFGNCAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KOOHHHAOBEO
	{
		get
		{
			return kOOHHHAOBEO_;
		}
		set
		{
			kOOHHHAOBEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueCommonBuffSelectSourceType ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJALOMHNGCJ
	{
		get
		{
			return eJALOMHNGCJ_;
		}
		set
		{
			eJALOMHNGCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDMEEJCCKIH
	{
		get
		{
			return lDMEEJCCKIH_;
		}
		set
		{
			lDMEEJCCKIH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MDHOHBHBGNC
	{
		get
		{
			return mDHOHBHBGNC_;
		}
		set
		{
			mDHOHBHBGNC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPADPPGKGGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPADPPGKGGC(KPADPPGKGGC other)
		: this()
	{
		lJEECOOPMLM_ = other.lJEECOOPMLM_;
		mCHAFKKFEDK_ = other.mCHAFKKFEDK_;
		oJAPMNAPIFG_ = other.oJAPMNAPIFG_;
		oPIDHKEKPKB_ = other.oPIDHKEKPKB_;
		nICEPKDHFDE_ = ((other.nICEPKDHFDE_ != null) ? other.nICEPKDHFDE_.Clone() : null);
		bKBKLONBPOB_ = other.bKBKLONBPOB_.Clone();
		mMINJCFNADK_ = other.mMINJCFNADK_;
		cHPFCFGNCAG_ = other.cHPFCFGNCAG_.Clone();
		kOOHHHAOBEO_ = other.kOOHHHAOBEO_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		eJALOMHNGCJ_ = other.eJALOMHNGCJ_;
		lDMEEJCCKIH_ = other.lDMEEJCCKIH_;
		mDHOHBHBGNC_ = other.mDHOHBHBGNC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPADPPGKGGC Clone()
	{
		return new KPADPPGKGGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KPADPPGKGGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KPADPPGKGGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LJEECOOPMLM != other.LJEECOOPMLM)
		{
			return false;
		}
		if (MCHAFKKFEDK != other.MCHAFKKFEDK)
		{
			return false;
		}
		if (OJAPMNAPIFG != other.OJAPMNAPIFG)
		{
			return false;
		}
		if (OPIDHKEKPKB != other.OPIDHKEKPKB)
		{
			return false;
		}
		if (!object.Equals(NICEPKDHFDE, other.NICEPKDHFDE))
		{
			return false;
		}
		if (!bKBKLONBPOB_.Equals(other.bKBKLONBPOB_))
		{
			return false;
		}
		if (MMINJCFNADK != other.MMINJCFNADK)
		{
			return false;
		}
		if (!cHPFCFGNCAG_.Equals(other.cHPFCFGNCAG_))
		{
			return false;
		}
		if (KOOHHHAOBEO != other.KOOHHHAOBEO)
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (EJALOMHNGCJ != other.EJALOMHNGCJ)
		{
			return false;
		}
		if (LDMEEJCCKIH != other.LDMEEJCCKIH)
		{
			return false;
		}
		if (MDHOHBHBGNC != other.MDHOHBHBGNC)
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
		if (LJEECOOPMLM != 0)
		{
			num ^= LJEECOOPMLM.GetHashCode();
		}
		if (MCHAFKKFEDK != 0)
		{
			num ^= MCHAFKKFEDK.GetHashCode();
		}
		if (OJAPMNAPIFG)
		{
			num ^= OJAPMNAPIFG.GetHashCode();
		}
		if (OPIDHKEKPKB != 0)
		{
			num ^= OPIDHKEKPKB.GetHashCode();
		}
		if (nICEPKDHFDE_ != null)
		{
			num ^= NICEPKDHFDE.GetHashCode();
		}
		num ^= bKBKLONBPOB_.GetHashCode();
		if (MMINJCFNADK != 0)
		{
			num ^= MMINJCFNADK.GetHashCode();
		}
		num ^= cHPFCFGNCAG_.GetHashCode();
		if (KOOHHHAOBEO != 0)
		{
			num ^= KOOHHHAOBEO.GetHashCode();
		}
		if (ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		if (EJALOMHNGCJ != 0)
		{
			num ^= EJALOMHNGCJ.GetHashCode();
		}
		if (LDMEEJCCKIH != 0)
		{
			num ^= LDMEEJCCKIH.GetHashCode();
		}
		if (MDHOHBHBGNC != 0)
		{
			num ^= MDHOHBHBGNC.GetHashCode();
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
		if (LJEECOOPMLM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LJEECOOPMLM);
		}
		if (MCHAFKKFEDK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MCHAFKKFEDK);
		}
		if (OJAPMNAPIFG)
		{
			output.WriteRawTag(24);
			output.WriteBool(OJAPMNAPIFG);
		}
		if (OPIDHKEKPKB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OPIDHKEKPKB);
		}
		if (nICEPKDHFDE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NICEPKDHFDE);
		}
		bKBKLONBPOB_.WriteTo(ref output, _repeated_bKBKLONBPOB_codec);
		if (MMINJCFNADK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MMINJCFNADK);
		}
		cHPFCFGNCAG_.WriteTo(ref output, _repeated_cHPFCFGNCAG_codec);
		if (KOOHHHAOBEO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KOOHHHAOBEO);
		}
		if (ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		if (EJALOMHNGCJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EJALOMHNGCJ);
		}
		if (LDMEEJCCKIH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LDMEEJCCKIH);
		}
		if (MDHOHBHBGNC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MDHOHBHBGNC);
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
		if (LJEECOOPMLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJEECOOPMLM);
		}
		if (MCHAFKKFEDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCHAFKKFEDK);
		}
		if (OJAPMNAPIFG)
		{
			num += 2;
		}
		if (OPIDHKEKPKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPIDHKEKPKB);
		}
		if (nICEPKDHFDE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NICEPKDHFDE);
		}
		num += bKBKLONBPOB_.CalculateSize(_repeated_bKBKLONBPOB_codec);
		if (MMINJCFNADK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMINJCFNADK);
		}
		num += cHPFCFGNCAG_.CalculateSize(_repeated_cHPFCFGNCAG_codec);
		if (KOOHHHAOBEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOOHHHAOBEO);
		}
		if (ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (EJALOMHNGCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJALOMHNGCJ);
		}
		if (LDMEEJCCKIH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDMEEJCCKIH);
		}
		if (MDHOHBHBGNC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDHOHBHBGNC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KPADPPGKGGC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LJEECOOPMLM != 0)
		{
			LJEECOOPMLM = other.LJEECOOPMLM;
		}
		if (other.MCHAFKKFEDK != 0)
		{
			MCHAFKKFEDK = other.MCHAFKKFEDK;
		}
		if (other.OJAPMNAPIFG)
		{
			OJAPMNAPIFG = other.OJAPMNAPIFG;
		}
		if (other.OPIDHKEKPKB != 0)
		{
			OPIDHKEKPKB = other.OPIDHKEKPKB;
		}
		if (other.nICEPKDHFDE_ != null)
		{
			if (nICEPKDHFDE_ == null)
			{
				NICEPKDHFDE = new ItemCostData();
			}
			NICEPKDHFDE.MergeFrom(other.NICEPKDHFDE);
		}
		bKBKLONBPOB_.Add(other.bKBKLONBPOB_);
		if (other.MMINJCFNADK != 0)
		{
			MMINJCFNADK = other.MMINJCFNADK;
		}
		cHPFCFGNCAG_.Add(other.cHPFCFGNCAG_);
		if (other.KOOHHHAOBEO != 0)
		{
			KOOHHHAOBEO = other.KOOHHHAOBEO;
		}
		if (other.ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			ALFHNEHOBJA = other.ALFHNEHOBJA;
		}
		if (other.EJALOMHNGCJ != 0)
		{
			EJALOMHNGCJ = other.EJALOMHNGCJ;
		}
		if (other.LDMEEJCCKIH != 0)
		{
			LDMEEJCCKIH = other.LDMEEJCCKIH;
		}
		if (other.MDHOHBHBGNC != 0)
		{
			MDHOHBHBGNC = other.MDHOHBHBGNC;
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
				LJEECOOPMLM = input.ReadUInt32();
				break;
			case 16u:
				MCHAFKKFEDK = input.ReadUInt32();
				break;
			case 24u:
				OJAPMNAPIFG = input.ReadBool();
				break;
			case 32u:
				OPIDHKEKPKB = input.ReadUInt32();
				break;
			case 42u:
				if (nICEPKDHFDE_ == null)
				{
					NICEPKDHFDE = new ItemCostData();
				}
				input.ReadMessage(NICEPKDHFDE);
				break;
			case 58u:
				bKBKLONBPOB_.AddEntriesFrom(ref input, _repeated_bKBKLONBPOB_codec);
				break;
			case 64u:
				MMINJCFNADK = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				cHPFCFGNCAG_.AddEntriesFrom(ref input, _repeated_cHPFCFGNCAG_codec);
				break;
			case 80u:
				KOOHHHAOBEO = input.ReadUInt32();
				break;
			case 88u:
				ALFHNEHOBJA = (RogueCommonBuffSelectSourceType)input.ReadEnum();
				break;
			case 96u:
				EJALOMHNGCJ = input.ReadUInt32();
				break;
			case 104u:
				LDMEEJCCKIH = input.ReadUInt32();
				break;
			case 112u:
				MDHOHBHBGNC = input.ReadUInt32();
				break;
			}
		}
	}
}
