using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HJKGBOKKNOP : IMessage<HJKGBOKKNOP>, IMessage, IEquatable<HJKGBOKKNOP>, IDeepCloneable<HJKGBOKKNOP>, IBufferMessage
{
	private static readonly MessageParser<HJKGBOKKNOP> _parser = new MessageParser<HJKGBOKKNOP>(() => new HJKGBOKKNOP());

	private UnknownFieldSet _unknownFields;

	public const int MCHAFKKFEDKFieldNumber = 2;

	private uint mCHAFKKFEDK_;

	public const int EJALOMHNGCJFieldNumber = 3;

	private uint eJALOMHNGCJ_;

	public const int KOOHHHAOBEOFieldNumber = 4;

	private uint kOOHHHAOBEO_;

	public const int OPIDHKEKPKBFieldNumber = 5;

	private uint oPIDHKEKPKB_;

	public const int GJMAPDBGEPAFieldNumber = 6;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_gJMAPDBGEPA_codec = FieldCodec.ForMessage(50u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> gJMAPDBGEPA_ = new RepeatedField<HJGFDIKDIHO>();

	public const int NICEPKDHFDEFieldNumber = 7;

	private ItemCostData nICEPKDHFDE_;

	public const int MMINJCFNADKFieldNumber = 8;

	private uint mMINJCFNADK_;

	public const int JMCGDOCIKGBFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_jMCGDOCIKGB_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> jMCGDOCIKGB_ = new RepeatedField<uint>();

	public const int CHPFCFGNCAGFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_cHPFCFGNCAG_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> cHPFCFGNCAG_ = new RepeatedField<uint>();

	public const int ALFHNEHOBJAFieldNumber = 12;

	private RogueCommonBuffSelectSourceType aLFHNEHOBJA_;

	public const int MDHOHBHBGNCFieldNumber = 13;

	private uint mDHOHBHBGNC_;

	public const int OJAPMNAPIFGFieldNumber = 14;

	private bool oJAPMNAPIFG_;

	public const int LDMEEJCCKIHFieldNumber = 15;

	private uint lDMEEJCCKIH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HJKGBOKKNOP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HJKGBOKKNOPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<HJGFDIKDIHO> GJMAPDBGEPA => gJMAPDBGEPA_;

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
	public RepeatedField<uint> JMCGDOCIKGB => jMCGDOCIKGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CHPFCFGNCAG => cHPFCFGNCAG_;

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
	public HJKGBOKKNOP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJKGBOKKNOP(HJKGBOKKNOP other)
		: this()
	{
		mCHAFKKFEDK_ = other.mCHAFKKFEDK_;
		eJALOMHNGCJ_ = other.eJALOMHNGCJ_;
		kOOHHHAOBEO_ = other.kOOHHHAOBEO_;
		oPIDHKEKPKB_ = other.oPIDHKEKPKB_;
		gJMAPDBGEPA_ = other.gJMAPDBGEPA_.Clone();
		nICEPKDHFDE_ = ((other.nICEPKDHFDE_ != null) ? other.nICEPKDHFDE_.Clone() : null);
		mMINJCFNADK_ = other.mMINJCFNADK_;
		jMCGDOCIKGB_ = other.jMCGDOCIKGB_.Clone();
		cHPFCFGNCAG_ = other.cHPFCFGNCAG_.Clone();
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		mDHOHBHBGNC_ = other.mDHOHBHBGNC_;
		oJAPMNAPIFG_ = other.oJAPMNAPIFG_;
		lDMEEJCCKIH_ = other.lDMEEJCCKIH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJKGBOKKNOP Clone()
	{
		return new HJKGBOKKNOP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HJKGBOKKNOP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HJKGBOKKNOP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MCHAFKKFEDK != other.MCHAFKKFEDK)
		{
			return false;
		}
		if (EJALOMHNGCJ != other.EJALOMHNGCJ)
		{
			return false;
		}
		if (KOOHHHAOBEO != other.KOOHHHAOBEO)
		{
			return false;
		}
		if (OPIDHKEKPKB != other.OPIDHKEKPKB)
		{
			return false;
		}
		if (!gJMAPDBGEPA_.Equals(other.gJMAPDBGEPA_))
		{
			return false;
		}
		if (!object.Equals(NICEPKDHFDE, other.NICEPKDHFDE))
		{
			return false;
		}
		if (MMINJCFNADK != other.MMINJCFNADK)
		{
			return false;
		}
		if (!jMCGDOCIKGB_.Equals(other.jMCGDOCIKGB_))
		{
			return false;
		}
		if (!cHPFCFGNCAG_.Equals(other.cHPFCFGNCAG_))
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (MDHOHBHBGNC != other.MDHOHBHBGNC)
		{
			return false;
		}
		if (OJAPMNAPIFG != other.OJAPMNAPIFG)
		{
			return false;
		}
		if (LDMEEJCCKIH != other.LDMEEJCCKIH)
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
		if (MCHAFKKFEDK != 0)
		{
			num ^= MCHAFKKFEDK.GetHashCode();
		}
		if (EJALOMHNGCJ != 0)
		{
			num ^= EJALOMHNGCJ.GetHashCode();
		}
		if (KOOHHHAOBEO != 0)
		{
			num ^= KOOHHHAOBEO.GetHashCode();
		}
		if (OPIDHKEKPKB != 0)
		{
			num ^= OPIDHKEKPKB.GetHashCode();
		}
		num ^= gJMAPDBGEPA_.GetHashCode();
		if (nICEPKDHFDE_ != null)
		{
			num ^= NICEPKDHFDE.GetHashCode();
		}
		if (MMINJCFNADK != 0)
		{
			num ^= MMINJCFNADK.GetHashCode();
		}
		num ^= jMCGDOCIKGB_.GetHashCode();
		num ^= cHPFCFGNCAG_.GetHashCode();
		if (ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		if (MDHOHBHBGNC != 0)
		{
			num ^= MDHOHBHBGNC.GetHashCode();
		}
		if (OJAPMNAPIFG)
		{
			num ^= OJAPMNAPIFG.GetHashCode();
		}
		if (LDMEEJCCKIH != 0)
		{
			num ^= LDMEEJCCKIH.GetHashCode();
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
		if (MCHAFKKFEDK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MCHAFKKFEDK);
		}
		if (EJALOMHNGCJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EJALOMHNGCJ);
		}
		if (KOOHHHAOBEO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KOOHHHAOBEO);
		}
		if (OPIDHKEKPKB != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OPIDHKEKPKB);
		}
		gJMAPDBGEPA_.WriteTo(ref output, _repeated_gJMAPDBGEPA_codec);
		if (nICEPKDHFDE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NICEPKDHFDE);
		}
		if (MMINJCFNADK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MMINJCFNADK);
		}
		jMCGDOCIKGB_.WriteTo(ref output, _repeated_jMCGDOCIKGB_codec);
		cHPFCFGNCAG_.WriteTo(ref output, _repeated_cHPFCFGNCAG_codec);
		if (ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		if (MDHOHBHBGNC != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MDHOHBHBGNC);
		}
		if (OJAPMNAPIFG)
		{
			output.WriteRawTag(112);
			output.WriteBool(OJAPMNAPIFG);
		}
		if (LDMEEJCCKIH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LDMEEJCCKIH);
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
		if (MCHAFKKFEDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCHAFKKFEDK);
		}
		if (EJALOMHNGCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJALOMHNGCJ);
		}
		if (KOOHHHAOBEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOOHHHAOBEO);
		}
		if (OPIDHKEKPKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPIDHKEKPKB);
		}
		num += gJMAPDBGEPA_.CalculateSize(_repeated_gJMAPDBGEPA_codec);
		if (nICEPKDHFDE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NICEPKDHFDE);
		}
		if (MMINJCFNADK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMINJCFNADK);
		}
		num += jMCGDOCIKGB_.CalculateSize(_repeated_jMCGDOCIKGB_codec);
		num += cHPFCFGNCAG_.CalculateSize(_repeated_cHPFCFGNCAG_codec);
		if (ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (MDHOHBHBGNC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDHOHBHBGNC);
		}
		if (OJAPMNAPIFG)
		{
			num += 2;
		}
		if (LDMEEJCCKIH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDMEEJCCKIH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HJKGBOKKNOP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MCHAFKKFEDK != 0)
		{
			MCHAFKKFEDK = other.MCHAFKKFEDK;
		}
		if (other.EJALOMHNGCJ != 0)
		{
			EJALOMHNGCJ = other.EJALOMHNGCJ;
		}
		if (other.KOOHHHAOBEO != 0)
		{
			KOOHHHAOBEO = other.KOOHHHAOBEO;
		}
		if (other.OPIDHKEKPKB != 0)
		{
			OPIDHKEKPKB = other.OPIDHKEKPKB;
		}
		gJMAPDBGEPA_.Add(other.gJMAPDBGEPA_);
		if (other.nICEPKDHFDE_ != null)
		{
			if (nICEPKDHFDE_ == null)
			{
				NICEPKDHFDE = new ItemCostData();
			}
			NICEPKDHFDE.MergeFrom(other.NICEPKDHFDE);
		}
		if (other.MMINJCFNADK != 0)
		{
			MMINJCFNADK = other.MMINJCFNADK;
		}
		jMCGDOCIKGB_.Add(other.jMCGDOCIKGB_);
		cHPFCFGNCAG_.Add(other.cHPFCFGNCAG_);
		if (other.ALFHNEHOBJA != RogueCommonBuffSelectSourceType.MafponidmldPcpdhelpkem)
		{
			ALFHNEHOBJA = other.ALFHNEHOBJA;
		}
		if (other.MDHOHBHBGNC != 0)
		{
			MDHOHBHBGNC = other.MDHOHBHBGNC;
		}
		if (other.OJAPMNAPIFG)
		{
			OJAPMNAPIFG = other.OJAPMNAPIFG;
		}
		if (other.LDMEEJCCKIH != 0)
		{
			LDMEEJCCKIH = other.LDMEEJCCKIH;
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
			case 16u:
				MCHAFKKFEDK = input.ReadUInt32();
				break;
			case 24u:
				EJALOMHNGCJ = input.ReadUInt32();
				break;
			case 32u:
				KOOHHHAOBEO = input.ReadUInt32();
				break;
			case 40u:
				OPIDHKEKPKB = input.ReadUInt32();
				break;
			case 50u:
				gJMAPDBGEPA_.AddEntriesFrom(ref input, _repeated_gJMAPDBGEPA_codec);
				break;
			case 58u:
				if (nICEPKDHFDE_ == null)
				{
					NICEPKDHFDE = new ItemCostData();
				}
				input.ReadMessage(NICEPKDHFDE);
				break;
			case 64u:
				MMINJCFNADK = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				jMCGDOCIKGB_.AddEntriesFrom(ref input, _repeated_jMCGDOCIKGB_codec);
				break;
			case 88u:
			case 90u:
				cHPFCFGNCAG_.AddEntriesFrom(ref input, _repeated_cHPFCFGNCAG_codec);
				break;
			case 96u:
				ALFHNEHOBJA = (RogueCommonBuffSelectSourceType)input.ReadEnum();
				break;
			case 104u:
				MDHOHBHBGNC = input.ReadUInt32();
				break;
			case 112u:
				OJAPMNAPIFG = input.ReadBool();
				break;
			case 120u:
				LDMEEJCCKIH = input.ReadUInt32();
				break;
			}
		}
	}
}
