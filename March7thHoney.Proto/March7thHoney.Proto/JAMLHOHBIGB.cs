using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JAMLHOHBIGB : IMessage<JAMLHOHBIGB>, IMessage, IEquatable<JAMLHOHBIGB>, IDeepCloneable<JAMLHOHBIGB>, IBufferMessage
{
	private static readonly MessageParser<JAMLHOHBIGB> _parser = new MessageParser<JAMLHOHBIGB>(() => new JAMLHOHBIGB());

	private UnknownFieldSet _unknownFields;

	public const int BuffListFieldNumber = 1;

	private static readonly FieldCodec<HMJJLADLOHH> _repeated_buffList_codec = FieldCodec.ForMessage(10u, HMJJLADLOHH.Parser);

	private readonly RepeatedField<HMJJLADLOHH> buffList_ = new RepeatedField<HMJJLADLOHH>();

	public const int OpListFieldNumber = 2;

	private static readonly FieldCodec<ENENNMNEOGK> _repeated_opList_codec = FieldCodec.ForMessage(18u, ENENNMNEOGK.Parser);

	private readonly RepeatedField<ENENNMNEOGK> opList_ = new RepeatedField<ENENNMNEOGK>();

	public const int PFJAJKBEPDCFieldNumber = 3;

	private uint pFJAJKBEPDC_;

	public const int EnergyInfoFieldNumber = 4;

	private uint energyInfo_;

	public const int IIPDAIEBIHAFieldNumber = 5;

	private uint iIPDAIEBIHA_;

	public const int ScoreIdFieldNumber = 6;

	private uint scoreId_;

	public const int CurHpFieldNumber = 7;

	private uint curHp_;

	public const int ItemListFieldNumber = 8;

	private static readonly FieldCodec<MPGIOHDMFCG> _repeated_itemList_codec = FieldCodec.ForMessage(66u, MPGIOHDMFCG.Parser);

	private readonly RepeatedField<MPGIOHDMFCG> itemList_ = new RepeatedField<MPGIOHDMFCG>();

	public const int DEMGBJCJGNOFieldNumber = 9;

	private PBKPPEAPBOM dEMGBJCJGNO_;

	public const int BAEPNAABADNFieldNumber = 10;

	private uint bAEPNAABADN_;

	public const int MHFHODDBOPMFieldNumber = 11;

	private ECKIDLIFAFG mHFHODDBOPM_;

	public const int KPCKLNCPPAJFieldNumber = 12;

	private uint kPCKLNCPPAJ_;

	public const int INFEPNIEPNDFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_iNFEPNIEPND_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> iNFEPNIEPND_ = new RepeatedField<uint>();

	public const int BMAJMLOFCKHFieldNumber = 14;

	private uint bMAJMLOFCKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JAMLHOHBIGB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JAMLHOHBIGBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HMJJLADLOHH> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ENENNMNEOGK> OpList => opList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PFJAJKBEPDC
	{
		get
		{
			return pFJAJKBEPDC_;
		}
		set
		{
			pFJAJKBEPDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIPDAIEBIHA
	{
		get
		{
			return iIPDAIEBIHA_;
		}
		set
		{
			iIPDAIEBIHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MPGIOHDMFCG> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBKPPEAPBOM DEMGBJCJGNO
	{
		get
		{
			return dEMGBJCJGNO_;
		}
		set
		{
			dEMGBJCJGNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BAEPNAABADN
	{
		get
		{
			return bAEPNAABADN_;
		}
		set
		{
			bAEPNAABADN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG MHFHODDBOPM
	{
		get
		{
			return mHFHODDBOPM_;
		}
		set
		{
			mHFHODDBOPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPCKLNCPPAJ
	{
		get
		{
			return kPCKLNCPPAJ_;
		}
		set
		{
			kPCKLNCPPAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> INFEPNIEPND => iNFEPNIEPND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMAJMLOFCKH
	{
		get
		{
			return bMAJMLOFCKH_;
		}
		set
		{
			bMAJMLOFCKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB(JAMLHOHBIGB other)
		: this()
	{
		buffList_ = other.buffList_.Clone();
		opList_ = other.opList_.Clone();
		pFJAJKBEPDC_ = other.pFJAJKBEPDC_;
		energyInfo_ = other.energyInfo_;
		iIPDAIEBIHA_ = other.iIPDAIEBIHA_;
		scoreId_ = other.scoreId_;
		curHp_ = other.curHp_;
		itemList_ = other.itemList_.Clone();
		dEMGBJCJGNO_ = other.dEMGBJCJGNO_;
		bAEPNAABADN_ = other.bAEPNAABADN_;
		mHFHODDBOPM_ = ((other.mHFHODDBOPM_ != null) ? other.mHFHODDBOPM_.Clone() : null);
		kPCKLNCPPAJ_ = other.kPCKLNCPPAJ_;
		iNFEPNIEPND_ = other.iNFEPNIEPND_.Clone();
		bMAJMLOFCKH_ = other.bMAJMLOFCKH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB Clone()
	{
		return new JAMLHOHBIGB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JAMLHOHBIGB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JAMLHOHBIGB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!opList_.Equals(other.opList_))
		{
			return false;
		}
		if (PFJAJKBEPDC != other.PFJAJKBEPDC)
		{
			return false;
		}
		if (EnergyInfo != other.EnergyInfo)
		{
			return false;
		}
		if (IIPDAIEBIHA != other.IIPDAIEBIHA)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (DEMGBJCJGNO != other.DEMGBJCJGNO)
		{
			return false;
		}
		if (BAEPNAABADN != other.BAEPNAABADN)
		{
			return false;
		}
		if (!object.Equals(MHFHODDBOPM, other.MHFHODDBOPM))
		{
			return false;
		}
		if (KPCKLNCPPAJ != other.KPCKLNCPPAJ)
		{
			return false;
		}
		if (!iNFEPNIEPND_.Equals(other.iNFEPNIEPND_))
		{
			return false;
		}
		if (BMAJMLOFCKH != other.BMAJMLOFCKH)
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
		num ^= buffList_.GetHashCode();
		num ^= opList_.GetHashCode();
		if (PFJAJKBEPDC != 0)
		{
			num ^= PFJAJKBEPDC.GetHashCode();
		}
		if (EnergyInfo != 0)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		if (IIPDAIEBIHA != 0)
		{
			num ^= IIPDAIEBIHA.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			num ^= DEMGBJCJGNO.GetHashCode();
		}
		if (BAEPNAABADN != 0)
		{
			num ^= BAEPNAABADN.GetHashCode();
		}
		if (mHFHODDBOPM_ != null)
		{
			num ^= MHFHODDBOPM.GetHashCode();
		}
		if (KPCKLNCPPAJ != 0)
		{
			num ^= KPCKLNCPPAJ.GetHashCode();
		}
		num ^= iNFEPNIEPND_.GetHashCode();
		if (BMAJMLOFCKH != 0)
		{
			num ^= BMAJMLOFCKH.GetHashCode();
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
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		opList_.WriteTo(ref output, _repeated_opList_codec);
		if (PFJAJKBEPDC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PFJAJKBEPDC);
		}
		if (EnergyInfo != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EnergyInfo);
		}
		if (IIPDAIEBIHA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IIPDAIEBIHA);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ScoreId);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(CurHp);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)DEMGBJCJGNO);
		}
		if (BAEPNAABADN != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BAEPNAABADN);
		}
		if (mHFHODDBOPM_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(MHFHODDBOPM);
		}
		if (KPCKLNCPPAJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KPCKLNCPPAJ);
		}
		iNFEPNIEPND_.WriteTo(ref output, _repeated_iNFEPNIEPND_codec);
		if (BMAJMLOFCKH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BMAJMLOFCKH);
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
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += opList_.CalculateSize(_repeated_opList_codec);
		if (PFJAJKBEPDC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PFJAJKBEPDC);
		}
		if (EnergyInfo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnergyInfo);
		}
		if (IIPDAIEBIHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIPDAIEBIHA);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DEMGBJCJGNO);
		}
		if (BAEPNAABADN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BAEPNAABADN);
		}
		if (mHFHODDBOPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHFHODDBOPM);
		}
		if (KPCKLNCPPAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPCKLNCPPAJ);
		}
		num += iNFEPNIEPND_.CalculateSize(_repeated_iNFEPNIEPND_codec);
		if (BMAJMLOFCKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMAJMLOFCKH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JAMLHOHBIGB other)
	{
		if (other == null)
		{
			return;
		}
		buffList_.Add(other.buffList_);
		opList_.Add(other.opList_);
		if (other.PFJAJKBEPDC != 0)
		{
			PFJAJKBEPDC = other.PFJAJKBEPDC;
		}
		if (other.EnergyInfo != 0)
		{
			EnergyInfo = other.EnergyInfo;
		}
		if (other.IIPDAIEBIHA != 0)
		{
			IIPDAIEBIHA = other.IIPDAIEBIHA;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.CurHp != 0)
		{
			CurHp = other.CurHp;
		}
		itemList_.Add(other.itemList_);
		if (other.DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			DEMGBJCJGNO = other.DEMGBJCJGNO;
		}
		if (other.BAEPNAABADN != 0)
		{
			BAEPNAABADN = other.BAEPNAABADN;
		}
		if (other.mHFHODDBOPM_ != null)
		{
			if (mHFHODDBOPM_ == null)
			{
				MHFHODDBOPM = new ECKIDLIFAFG();
			}
			MHFHODDBOPM.MergeFrom(other.MHFHODDBOPM);
		}
		if (other.KPCKLNCPPAJ != 0)
		{
			KPCKLNCPPAJ = other.KPCKLNCPPAJ;
		}
		iNFEPNIEPND_.Add(other.iNFEPNIEPND_);
		if (other.BMAJMLOFCKH != 0)
		{
			BMAJMLOFCKH = other.BMAJMLOFCKH;
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
			case 10u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 18u:
				opList_.AddEntriesFrom(ref input, _repeated_opList_codec);
				break;
			case 24u:
				PFJAJKBEPDC = input.ReadUInt32();
				break;
			case 32u:
				EnergyInfo = input.ReadUInt32();
				break;
			case 40u:
				IIPDAIEBIHA = input.ReadUInt32();
				break;
			case 48u:
				ScoreId = input.ReadUInt32();
				break;
			case 56u:
				CurHp = input.ReadUInt32();
				break;
			case 66u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 72u:
				DEMGBJCJGNO = (PBKPPEAPBOM)input.ReadEnum();
				break;
			case 80u:
				BAEPNAABADN = input.ReadUInt32();
				break;
			case 90u:
				if (mHFHODDBOPM_ == null)
				{
					MHFHODDBOPM = new ECKIDLIFAFG();
				}
				input.ReadMessage(MHFHODDBOPM);
				break;
			case 96u:
				KPCKLNCPPAJ = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				iNFEPNIEPND_.AddEntriesFrom(ref input, _repeated_iNFEPNIEPND_codec);
				break;
			case 112u:
				BMAJMLOFCKH = input.ReadUInt32();
				break;
			}
		}
	}
}
