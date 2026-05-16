using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FMEMPPNNKJH : IMessage<FMEMPPNNKJH>, IMessage, IEquatable<FMEMPPNNKJH>, IDeepCloneable<FMEMPPNNKJH>, IBufferMessage
{
	private static readonly MessageParser<FMEMPPNNKJH> _parser = new MessageParser<FMEMPPNNKJH>(() => new FMEMPPNNKJH());

	private UnknownFieldSet _unknownFields;

	public const int CCBIEBICDMEFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_cCBIEBICDME_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> cCBIEBICDME_ = new RepeatedField<uint>();

	public const int PendingActionFieldNumber = 2;

	private PNDIINAHJAF pendingAction_;

	public const int AEFMENCFDMBFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aEFMENCFDMB_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aEFMENCFDMB_ = new RepeatedField<uint>();

	public const int KDIDNELEDJDFieldNumber = 4;

	private static readonly FieldCodec<DIMKCEBGKKN> _repeated_kDIDNELEDJD_codec = FieldCodec.ForMessage(34u, DIMKCEBGKKN.Parser);

	private readonly RepeatedField<DIMKCEBGKKN> kDIDNELEDJD_ = new RepeatedField<DIMKCEBGKKN>();

	public const int StageIdFieldNumber = 5;

	private uint stageId_;

	public const int MHIFFAMMAGIFieldNumber = 6;

	private uint mHIFFAMMAGI_;

	public const int HJFBAAHDHBHFieldNumber = 7;

	private static readonly FieldCodec<EPJMDNCPJME> _repeated_hJFBAAHDHBH_codec = FieldCodec.ForMessage(58u, EPJMDNCPJME.Parser);

	private readonly RepeatedField<EPJMDNCPJME> hJFBAAHDHBH_ = new RepeatedField<EPJMDNCPJME>();

	public const int DJIDCABJNLAFieldNumber = 8;

	private IFGDFHLNPGD dJIDCABJNLA_;

	public const int HpFieldNumber = 9;

	private uint hp_;

	public const int EntityListFieldNumber = 10;

	private static readonly FieldCodec<CIDLPPKAJPO> _repeated_entityList_codec = FieldCodec.ForMessage(82u, CIDLPPKAJPO.Parser);

	private readonly RepeatedField<CIDLPPKAJPO> entityList_ = new RepeatedField<CIDLPPKAJPO>();

	public const int EPGAPCCAEMPFieldNumber = 11;

	private static readonly FieldCodec<GMFCNNFHMGE> _repeated_ePGAPCCAEMP_codec = FieldCodec.ForMessage(90u, GMFCNNFHMGE.Parser);

	private readonly RepeatedField<GMFCNNFHMGE> ePGAPCCAEMP_ = new RepeatedField<GMFCNNFHMGE>();

	public const int ItemValueFieldNumber = 12;

	private uint itemValue_;

	public const int JGOEPADOKEMFieldNumber = 13;

	private uint jGOEPADOKEM_;

	public const int HFOEGNAMFFKFieldNumber = 14;

	private uint hFOEGNAMFFK_;

	public const int JBOCOPNEJLBFieldNumber = 15;

	private static readonly FieldCodec<LKDFOOJMHIE> _repeated_jBOCOPNEJLB_codec = FieldCodec.ForMessage(122u, LKDFOOJMHIE.Parser);

	private readonly RepeatedField<LKDFOOJMHIE> jBOCOPNEJLB_ = new RepeatedField<LKDFOOJMHIE>();

	public const int MNIMOJDOIOKFieldNumber = 837;

	private static readonly FieldCodec<ulong> _repeated_mNIMOJDOIOK_codec = FieldCodec.ForUInt64(6698u);

	private readonly RepeatedField<ulong> mNIMOJDOIOK_ = new RepeatedField<ulong>();

	public const int KGLLCMIMEMFFieldNumber = 921;

	private OPDMGOACIEP kGLLCMIMEMF_;

	public const int MaxHpFieldNumber = 1240;

	private uint maxHp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FMEMPPNNKJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FMEMPPNNKJHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CCBIEBICDME => cCBIEBICDME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDIINAHJAF PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AEFMENCFDMB => aEFMENCFDMB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DIMKCEBGKKN> KDIDNELEDJD => kDIDNELEDJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHIFFAMMAGI
	{
		get
		{
			return mHIFFAMMAGI_;
		}
		set
		{
			mHIFFAMMAGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPJMDNCPJME> HJFBAAHDHBH => hJFBAAHDHBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFGDFHLNPGD DJIDCABJNLA
	{
		get
		{
			return dJIDCABJNLA_;
		}
		set
		{
			dJIDCABJNLA_ = value;
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
	public RepeatedField<CIDLPPKAJPO> EntityList => entityList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GMFCNNFHMGE> EPGAPCCAEMP => ePGAPCCAEMP_;

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
	public uint JGOEPADOKEM
	{
		get
		{
			return jGOEPADOKEM_;
		}
		set
		{
			jGOEPADOKEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFOEGNAMFFK
	{
		get
		{
			return hFOEGNAMFFK_;
		}
		set
		{
			hFOEGNAMFFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKDFOOJMHIE> JBOCOPNEJLB => jBOCOPNEJLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ulong> MNIMOJDOIOK => mNIMOJDOIOK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPDMGOACIEP KGLLCMIMEMF
	{
		get
		{
			return kGLLCMIMEMF_;
		}
		set
		{
			kGLLCMIMEMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMEMPPNNKJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMEMPPNNKJH(FMEMPPNNKJH other)
		: this()
	{
		cCBIEBICDME_ = other.cCBIEBICDME_.Clone();
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		aEFMENCFDMB_ = other.aEFMENCFDMB_.Clone();
		kDIDNELEDJD_ = other.kDIDNELEDJD_.Clone();
		stageId_ = other.stageId_;
		mHIFFAMMAGI_ = other.mHIFFAMMAGI_;
		hJFBAAHDHBH_ = other.hJFBAAHDHBH_.Clone();
		dJIDCABJNLA_ = ((other.dJIDCABJNLA_ != null) ? other.dJIDCABJNLA_.Clone() : null);
		hp_ = other.hp_;
		entityList_ = other.entityList_.Clone();
		ePGAPCCAEMP_ = other.ePGAPCCAEMP_.Clone();
		itemValue_ = other.itemValue_;
		jGOEPADOKEM_ = other.jGOEPADOKEM_;
		hFOEGNAMFFK_ = other.hFOEGNAMFFK_;
		jBOCOPNEJLB_ = other.jBOCOPNEJLB_.Clone();
		mNIMOJDOIOK_ = other.mNIMOJDOIOK_.Clone();
		kGLLCMIMEMF_ = ((other.kGLLCMIMEMF_ != null) ? other.kGLLCMIMEMF_.Clone() : null);
		maxHp_ = other.maxHp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMEMPPNNKJH Clone()
	{
		return new FMEMPPNNKJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FMEMPPNNKJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FMEMPPNNKJH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cCBIEBICDME_.Equals(other.cCBIEBICDME_))
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!aEFMENCFDMB_.Equals(other.aEFMENCFDMB_))
		{
			return false;
		}
		if (!kDIDNELEDJD_.Equals(other.kDIDNELEDJD_))
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (MHIFFAMMAGI != other.MHIFFAMMAGI)
		{
			return false;
		}
		if (!hJFBAAHDHBH_.Equals(other.hJFBAAHDHBH_))
		{
			return false;
		}
		if (!object.Equals(DJIDCABJNLA, other.DJIDCABJNLA))
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (!entityList_.Equals(other.entityList_))
		{
			return false;
		}
		if (!ePGAPCCAEMP_.Equals(other.ePGAPCCAEMP_))
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (JGOEPADOKEM != other.JGOEPADOKEM)
		{
			return false;
		}
		if (HFOEGNAMFFK != other.HFOEGNAMFFK)
		{
			return false;
		}
		if (!jBOCOPNEJLB_.Equals(other.jBOCOPNEJLB_))
		{
			return false;
		}
		if (!mNIMOJDOIOK_.Equals(other.mNIMOJDOIOK_))
		{
			return false;
		}
		if (!object.Equals(KGLLCMIMEMF, other.KGLLCMIMEMF))
		{
			return false;
		}
		if (MaxHp != other.MaxHp)
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
		num ^= cCBIEBICDME_.GetHashCode();
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		num ^= aEFMENCFDMB_.GetHashCode();
		num ^= kDIDNELEDJD_.GetHashCode();
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (MHIFFAMMAGI != 0)
		{
			num ^= MHIFFAMMAGI.GetHashCode();
		}
		num ^= hJFBAAHDHBH_.GetHashCode();
		if (dJIDCABJNLA_ != null)
		{
			num ^= DJIDCABJNLA.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		num ^= entityList_.GetHashCode();
		num ^= ePGAPCCAEMP_.GetHashCode();
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (JGOEPADOKEM != 0)
		{
			num ^= JGOEPADOKEM.GetHashCode();
		}
		if (HFOEGNAMFFK != 0)
		{
			num ^= HFOEGNAMFFK.GetHashCode();
		}
		num ^= jBOCOPNEJLB_.GetHashCode();
		num ^= mNIMOJDOIOK_.GetHashCode();
		if (kGLLCMIMEMF_ != null)
		{
			num ^= KGLLCMIMEMF.GetHashCode();
		}
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
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
		cCBIEBICDME_.WriteTo(ref output, _repeated_cCBIEBICDME_codec);
		if (pendingAction_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PendingAction);
		}
		aEFMENCFDMB_.WriteTo(ref output, _repeated_aEFMENCFDMB_codec);
		kDIDNELEDJD_.WriteTo(ref output, _repeated_kDIDNELEDJD_codec);
		if (StageId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(StageId);
		}
		if (MHIFFAMMAGI != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MHIFFAMMAGI);
		}
		hJFBAAHDHBH_.WriteTo(ref output, _repeated_hJFBAAHDHBH_codec);
		if (dJIDCABJNLA_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DJIDCABJNLA);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Hp);
		}
		entityList_.WriteTo(ref output, _repeated_entityList_codec);
		ePGAPCCAEMP_.WriteTo(ref output, _repeated_ePGAPCCAEMP_codec);
		if (ItemValue != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ItemValue);
		}
		if (JGOEPADOKEM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JGOEPADOKEM);
		}
		if (HFOEGNAMFFK != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HFOEGNAMFFK);
		}
		jBOCOPNEJLB_.WriteTo(ref output, _repeated_jBOCOPNEJLB_codec);
		mNIMOJDOIOK_.WriteTo(ref output, _repeated_mNIMOJDOIOK_codec);
		if (kGLLCMIMEMF_ != null)
		{
			output.WriteRawTag(202, 57);
			output.WriteMessage(KGLLCMIMEMF);
		}
		if (MaxHp != 0)
		{
			output.WriteRawTag(192, 77);
			output.WriteUInt32(MaxHp);
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
		num += cCBIEBICDME_.CalculateSize(_repeated_cCBIEBICDME_codec);
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		num += aEFMENCFDMB_.CalculateSize(_repeated_aEFMENCFDMB_codec);
		num += kDIDNELEDJD_.CalculateSize(_repeated_kDIDNELEDJD_codec);
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (MHIFFAMMAGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHIFFAMMAGI);
		}
		num += hJFBAAHDHBH_.CalculateSize(_repeated_hJFBAAHDHBH_codec);
		if (dJIDCABJNLA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DJIDCABJNLA);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		num += entityList_.CalculateSize(_repeated_entityList_codec);
		num += ePGAPCCAEMP_.CalculateSize(_repeated_ePGAPCCAEMP_codec);
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (JGOEPADOKEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGOEPADOKEM);
		}
		if (HFOEGNAMFFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFOEGNAMFFK);
		}
		num += jBOCOPNEJLB_.CalculateSize(_repeated_jBOCOPNEJLB_codec);
		num += mNIMOJDOIOK_.CalculateSize(_repeated_mNIMOJDOIOK_codec);
		if (kGLLCMIMEMF_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KGLLCMIMEMF);
		}
		if (MaxHp != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MaxHp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FMEMPPNNKJH other)
	{
		if (other == null)
		{
			return;
		}
		cCBIEBICDME_.Add(other.cCBIEBICDME_);
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new PNDIINAHJAF();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		aEFMENCFDMB_.Add(other.aEFMENCFDMB_);
		kDIDNELEDJD_.Add(other.kDIDNELEDJD_);
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.MHIFFAMMAGI != 0)
		{
			MHIFFAMMAGI = other.MHIFFAMMAGI;
		}
		hJFBAAHDHBH_.Add(other.hJFBAAHDHBH_);
		if (other.dJIDCABJNLA_ != null)
		{
			if (dJIDCABJNLA_ == null)
			{
				DJIDCABJNLA = new IFGDFHLNPGD();
			}
			DJIDCABJNLA.MergeFrom(other.DJIDCABJNLA);
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		entityList_.Add(other.entityList_);
		ePGAPCCAEMP_.Add(other.ePGAPCCAEMP_);
		if (other.ItemValue != 0)
		{
			ItemValue = other.ItemValue;
		}
		if (other.JGOEPADOKEM != 0)
		{
			JGOEPADOKEM = other.JGOEPADOKEM;
		}
		if (other.HFOEGNAMFFK != 0)
		{
			HFOEGNAMFFK = other.HFOEGNAMFFK;
		}
		jBOCOPNEJLB_.Add(other.jBOCOPNEJLB_);
		mNIMOJDOIOK_.Add(other.mNIMOJDOIOK_);
		if (other.kGLLCMIMEMF_ != null)
		{
			if (kGLLCMIMEMF_ == null)
			{
				KGLLCMIMEMF = new OPDMGOACIEP();
			}
			KGLLCMIMEMF.MergeFrom(other.KGLLCMIMEMF);
		}
		if (other.MaxHp != 0)
		{
			MaxHp = other.MaxHp;
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
				cCBIEBICDME_.AddEntriesFrom(ref input, _repeated_cCBIEBICDME_codec);
				break;
			case 18u:
				if (pendingAction_ == null)
				{
					PendingAction = new PNDIINAHJAF();
				}
				input.ReadMessage(PendingAction);
				break;
			case 24u:
			case 26u:
				aEFMENCFDMB_.AddEntriesFrom(ref input, _repeated_aEFMENCFDMB_codec);
				break;
			case 34u:
				kDIDNELEDJD_.AddEntriesFrom(ref input, _repeated_kDIDNELEDJD_codec);
				break;
			case 40u:
				StageId = input.ReadUInt32();
				break;
			case 48u:
				MHIFFAMMAGI = input.ReadUInt32();
				break;
			case 58u:
				hJFBAAHDHBH_.AddEntriesFrom(ref input, _repeated_hJFBAAHDHBH_codec);
				break;
			case 66u:
				if (dJIDCABJNLA_ == null)
				{
					DJIDCABJNLA = new IFGDFHLNPGD();
				}
				input.ReadMessage(DJIDCABJNLA);
				break;
			case 72u:
				Hp = input.ReadUInt32();
				break;
			case 82u:
				entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
				break;
			case 90u:
				ePGAPCCAEMP_.AddEntriesFrom(ref input, _repeated_ePGAPCCAEMP_codec);
				break;
			case 96u:
				ItemValue = input.ReadUInt32();
				break;
			case 104u:
				JGOEPADOKEM = input.ReadUInt32();
				break;
			case 112u:
				HFOEGNAMFFK = input.ReadUInt32();
				break;
			case 122u:
				jBOCOPNEJLB_.AddEntriesFrom(ref input, _repeated_jBOCOPNEJLB_codec);
				break;
			case 6696u:
			case 6698u:
				mNIMOJDOIOK_.AddEntriesFrom(ref input, _repeated_mNIMOJDOIOK_codec);
				break;
			case 7370u:
				if (kGLLCMIMEMF_ == null)
				{
					KGLLCMIMEMF = new OPDMGOACIEP();
				}
				input.ReadMessage(KGLLCMIMEMF);
				break;
			case 9920u:
				MaxHp = input.ReadUInt32();
				break;
			}
		}
	}
}
