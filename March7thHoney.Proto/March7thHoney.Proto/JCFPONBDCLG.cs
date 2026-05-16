using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCFPONBDCLG : IMessage<JCFPONBDCLG>, IMessage, IEquatable<JCFPONBDCLG>, IDeepCloneable<JCFPONBDCLG>, IBufferMessage
{
	private static readonly MessageParser<JCFPONBDCLG> _parser = new MessageParser<JCFPONBDCLG>(() => new JCFPONBDCLG());

	private UnknownFieldSet _unknownFields;

	public const int EDOIIGJJCIFFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_eDOIIGJJCIF_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> eDOIIGJJCIF_ = new RepeatedField<uint>();

	public const int PlayerLevelFieldNumber = 3;

	private uint playerLevel_;

	public const int NJMAPFMPPNAFieldNumber = 5;

	private static readonly FieldCodec<OKIBFKOOEKJ> _repeated_nJMAPFMPPNA_codec = FieldCodec.ForMessage(42u, OKIBFKOOEKJ.Parser);

	private readonly RepeatedField<OKIBFKOOEKJ> nJMAPFMPPNA_ = new RepeatedField<OKIBFKOOEKJ>();

	public const int ItemValueFieldNumber = 7;

	private uint itemValue_;

	public const int ExpFieldNumber = 9;

	private uint exp_;

	public const int HAFMANOLMEDFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_hAFMANOLMED_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> hAFMANOLMED_ = new RepeatedField<uint>();

	public const int PMCBBMKMHNIFieldNumber = 13;

	private static readonly FieldCodec<GPFMEDLLKGH> _repeated_pMCBBMKMHNI_codec = FieldCodec.ForMessage(106u, GPFMEDLLKGH.Parser);

	private readonly RepeatedField<GPFMEDLLKGH> pMCBBMKMHNI_ = new RepeatedField<GPFMEDLLKGH>();

	public const int HCEHOHDCCFEFieldNumber = 14;

	private static readonly FieldCodec<LPHJKGLLJIP> _repeated_hCEHOHDCCFE_codec = FieldCodec.ForMessage(114u, LPHJKGLLJIP.Parser);

	private readonly RepeatedField<LPHJKGLLJIP> hCEHOHDCCFE_ = new RepeatedField<LPHJKGLLJIP>();

	public const int EGLPNDHLHPAFieldNumber = 15;

	private static readonly FieldCodec<KGNLHPFOHDK> _repeated_eGLPNDHLHPA_codec = FieldCodec.ForMessage(122u, KGNLHPFOHDK.Parser);

	private readonly RepeatedField<KGNLHPFOHDK> eGLPNDHLHPA_ = new RepeatedField<KGNLHPFOHDK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCFPONBDCLG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCFPONBDCLGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EDOIIGJJCIF => eDOIIGJJCIF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlayerLevel
	{
		get
		{
			return playerLevel_;
		}
		set
		{
			playerLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OKIBFKOOEKJ> NJMAPFMPPNA => nJMAPFMPPNA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HAFMANOLMED => hAFMANOLMED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GPFMEDLLKGH> PMCBBMKMHNI => pMCBBMKMHNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LPHJKGLLJIP> HCEHOHDCCFE => hCEHOHDCCFE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KGNLHPFOHDK> EGLPNDHLHPA => eGLPNDHLHPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFPONBDCLG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFPONBDCLG(JCFPONBDCLG other)
		: this()
	{
		eDOIIGJJCIF_ = other.eDOIIGJJCIF_.Clone();
		playerLevel_ = other.playerLevel_;
		nJMAPFMPPNA_ = other.nJMAPFMPPNA_.Clone();
		itemValue_ = other.itemValue_;
		exp_ = other.exp_;
		hAFMANOLMED_ = other.hAFMANOLMED_.Clone();
		pMCBBMKMHNI_ = other.pMCBBMKMHNI_.Clone();
		hCEHOHDCCFE_ = other.hCEHOHDCCFE_.Clone();
		eGLPNDHLHPA_ = other.eGLPNDHLHPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFPONBDCLG Clone()
	{
		return new JCFPONBDCLG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCFPONBDCLG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCFPONBDCLG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eDOIIGJJCIF_.Equals(other.eDOIIGJJCIF_))
		{
			return false;
		}
		if (PlayerLevel != other.PlayerLevel)
		{
			return false;
		}
		if (!nJMAPFMPPNA_.Equals(other.nJMAPFMPPNA_))
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (!hAFMANOLMED_.Equals(other.hAFMANOLMED_))
		{
			return false;
		}
		if (!pMCBBMKMHNI_.Equals(other.pMCBBMKMHNI_))
		{
			return false;
		}
		if (!hCEHOHDCCFE_.Equals(other.hCEHOHDCCFE_))
		{
			return false;
		}
		if (!eGLPNDHLHPA_.Equals(other.eGLPNDHLHPA_))
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
		num ^= eDOIIGJJCIF_.GetHashCode();
		if (PlayerLevel != 0)
		{
			num ^= PlayerLevel.GetHashCode();
		}
		num ^= nJMAPFMPPNA_.GetHashCode();
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		num ^= hAFMANOLMED_.GetHashCode();
		num ^= pMCBBMKMHNI_.GetHashCode();
		num ^= hCEHOHDCCFE_.GetHashCode();
		num ^= eGLPNDHLHPA_.GetHashCode();
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
		eDOIIGJJCIF_.WriteTo(ref output, _repeated_eDOIIGJJCIF_codec);
		if (PlayerLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PlayerLevel);
		}
		nJMAPFMPPNA_.WriteTo(ref output, _repeated_nJMAPFMPPNA_codec);
		if (ItemValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ItemValue);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Exp);
		}
		hAFMANOLMED_.WriteTo(ref output, _repeated_hAFMANOLMED_codec);
		pMCBBMKMHNI_.WriteTo(ref output, _repeated_pMCBBMKMHNI_codec);
		hCEHOHDCCFE_.WriteTo(ref output, _repeated_hCEHOHDCCFE_codec);
		eGLPNDHLHPA_.WriteTo(ref output, _repeated_eGLPNDHLHPA_codec);
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
		num += eDOIIGJJCIF_.CalculateSize(_repeated_eDOIIGJJCIF_codec);
		if (PlayerLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlayerLevel);
		}
		num += nJMAPFMPPNA_.CalculateSize(_repeated_nJMAPFMPPNA_codec);
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		num += hAFMANOLMED_.CalculateSize(_repeated_hAFMANOLMED_codec);
		num += pMCBBMKMHNI_.CalculateSize(_repeated_pMCBBMKMHNI_codec);
		num += hCEHOHDCCFE_.CalculateSize(_repeated_hCEHOHDCCFE_codec);
		num += eGLPNDHLHPA_.CalculateSize(_repeated_eGLPNDHLHPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCFPONBDCLG other)
	{
		if (other != null)
		{
			eDOIIGJJCIF_.Add(other.eDOIIGJJCIF_);
			if (other.PlayerLevel != 0)
			{
				PlayerLevel = other.PlayerLevel;
			}
			nJMAPFMPPNA_.Add(other.nJMAPFMPPNA_);
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			hAFMANOLMED_.Add(other.hAFMANOLMED_);
			pMCBBMKMHNI_.Add(other.pMCBBMKMHNI_);
			hCEHOHDCCFE_.Add(other.hCEHOHDCCFE_);
			eGLPNDHLHPA_.Add(other.eGLPNDHLHPA_);
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
				eDOIIGJJCIF_.AddEntriesFrom(ref input, _repeated_eDOIIGJJCIF_codec);
				break;
			case 24u:
				PlayerLevel = input.ReadUInt32();
				break;
			case 42u:
				nJMAPFMPPNA_.AddEntriesFrom(ref input, _repeated_nJMAPFMPPNA_codec);
				break;
			case 56u:
				ItemValue = input.ReadUInt32();
				break;
			case 72u:
				Exp = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				hAFMANOLMED_.AddEntriesFrom(ref input, _repeated_hAFMANOLMED_codec);
				break;
			case 106u:
				pMCBBMKMHNI_.AddEntriesFrom(ref input, _repeated_pMCBBMKMHNI_codec);
				break;
			case 114u:
				hCEHOHDCCFE_.AddEntriesFrom(ref input, _repeated_hCEHOHDCCFE_codec);
				break;
			case 122u:
				eGLPNDHLHPA_.AddEntriesFrom(ref input, _repeated_eGLPNDHLHPA_codec);
				break;
			}
		}
	}
}
