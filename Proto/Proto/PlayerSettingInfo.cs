using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerSettingInfo : IMessage<PlayerSettingInfo>, IMessage, IEquatable<PlayerSettingInfo>, IDeepCloneable<PlayerSettingInfo>, IBufferMessage
{
	private static readonly MessageParser<PlayerSettingInfo> _parser = new MessageParser<PlayerSettingInfo>(() => new PlayerSettingInfo());

	private UnknownFieldSet _unknownFields;

	public const int COIGOCJHBOPFieldNumber = 2;

	private bool cOIGOCJHBOP_;

	public const int CHCNEDNCIDJFieldNumber = 4;

	private bool cHCNEDNCIDJ_;

	public const int EHKLNPCMMHEFieldNumber = 5;

	private OEEEAEJBENB eHKLNPCMMHE_;

	public const int LPEPIDNJDEMFieldNumber = 7;

	private bool lPEPIDNJDEM_;

	public const int BKDCFBDMNIJFieldNumber = 8;

	private bool bKDCFBDMNIJ_;

	public const int PFJMEECGJMMFieldNumber = 9;

	private bool pFJMEECGJMM_;

	public const int MFCPDJGGCMOFieldNumber = 10;

	private bool mFCPDJGGCMO_;

	public const int CCNGHBADHBLFieldNumber = 11;

	private bool cCNGHBADHBL_;

	public const int FIJNAPNICJFFieldNumber = 12;

	private bool fIJNAPNICJF_;

	public const int NHLKFBOBDOMFieldNumber = 13;

	private bool nHLKFBOBDOM_;

	public const int CPOGDKALGOMFieldNumber = 14;

	private bool cPOGDKALGOM_;

	public const int LENKIEBIIHPFieldNumber = 151;

	private bool lENKIEBIIHP_;

	public const int EJDGNLEOBCNFieldNumber = 197;

	private bool eJDGNLEOBCN_;

	public const int HGHFECOMJNAFieldNumber = 524;

	private NECGMCGFANN hGHFECOMJNA_;

	public const int KFBLHCCGEPOFieldNumber = 1219;

	private bool kFBLHCCGEPO_;

	public const int BMEHFMDNKLEFieldNumber = 1557;

	private bool bMEHFMDNKLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerSettingInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerSettingInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool COIGOCJHBOP
	{
		get
		{
			return cOIGOCJHBOP_;
		}
		set
		{
			cOIGOCJHBOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCNEDNCIDJ
	{
		get
		{
			return cHCNEDNCIDJ_;
		}
		set
		{
			cHCNEDNCIDJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEEEAEJBENB EHKLNPCMMHE
	{
		get
		{
			return eHKLNPCMMHE_;
		}
		set
		{
			eHKLNPCMMHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LPEPIDNJDEM
	{
		get
		{
			return lPEPIDNJDEM_;
		}
		set
		{
			lPEPIDNJDEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BKDCFBDMNIJ
	{
		get
		{
			return bKDCFBDMNIJ_;
		}
		set
		{
			bKDCFBDMNIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PFJMEECGJMM
	{
		get
		{
			return pFJMEECGJMM_;
		}
		set
		{
			pFJMEECGJMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MFCPDJGGCMO
	{
		get
		{
			return mFCPDJGGCMO_;
		}
		set
		{
			mFCPDJGGCMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CCNGHBADHBL
	{
		get
		{
			return cCNGHBADHBL_;
		}
		set
		{
			cCNGHBADHBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FIJNAPNICJF
	{
		get
		{
			return fIJNAPNICJF_;
		}
		set
		{
			fIJNAPNICJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NHLKFBOBDOM
	{
		get
		{
			return nHLKFBOBDOM_;
		}
		set
		{
			nHLKFBOBDOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CPOGDKALGOM
	{
		get
		{
			return cPOGDKALGOM_;
		}
		set
		{
			cPOGDKALGOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LENKIEBIIHP
	{
		get
		{
			return lENKIEBIIHP_;
		}
		set
		{
			lENKIEBIIHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EJDGNLEOBCN
	{
		get
		{
			return eJDGNLEOBCN_;
		}
		set
		{
			eJDGNLEOBCN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NECGMCGFANN HGHFECOMJNA
	{
		get
		{
			return hGHFECOMJNA_;
		}
		set
		{
			hGHFECOMJNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KFBLHCCGEPO
	{
		get
		{
			return kFBLHCCGEPO_;
		}
		set
		{
			kFBLHCCGEPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BMEHFMDNKLE
	{
		get
		{
			return bMEHFMDNKLE_;
		}
		set
		{
			bMEHFMDNKLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSettingInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSettingInfo(PlayerSettingInfo other)
		: this()
	{
		cOIGOCJHBOP_ = other.cOIGOCJHBOP_;
		cHCNEDNCIDJ_ = other.cHCNEDNCIDJ_;
		eHKLNPCMMHE_ = ((other.eHKLNPCMMHE_ != null) ? other.eHKLNPCMMHE_.Clone() : null);
		lPEPIDNJDEM_ = other.lPEPIDNJDEM_;
		bKDCFBDMNIJ_ = other.bKDCFBDMNIJ_;
		pFJMEECGJMM_ = other.pFJMEECGJMM_;
		mFCPDJGGCMO_ = other.mFCPDJGGCMO_;
		cCNGHBADHBL_ = other.cCNGHBADHBL_;
		fIJNAPNICJF_ = other.fIJNAPNICJF_;
		nHLKFBOBDOM_ = other.nHLKFBOBDOM_;
		cPOGDKALGOM_ = other.cPOGDKALGOM_;
		lENKIEBIIHP_ = other.lENKIEBIIHP_;
		eJDGNLEOBCN_ = other.eJDGNLEOBCN_;
		hGHFECOMJNA_ = ((other.hGHFECOMJNA_ != null) ? other.hGHFECOMJNA_.Clone() : null);
		kFBLHCCGEPO_ = other.kFBLHCCGEPO_;
		bMEHFMDNKLE_ = other.bMEHFMDNKLE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSettingInfo Clone()
	{
		return new PlayerSettingInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerSettingInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerSettingInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COIGOCJHBOP != other.COIGOCJHBOP)
		{
			return false;
		}
		if (CHCNEDNCIDJ != other.CHCNEDNCIDJ)
		{
			return false;
		}
		if (!object.Equals(EHKLNPCMMHE, other.EHKLNPCMMHE))
		{
			return false;
		}
		if (LPEPIDNJDEM != other.LPEPIDNJDEM)
		{
			return false;
		}
		if (BKDCFBDMNIJ != other.BKDCFBDMNIJ)
		{
			return false;
		}
		if (PFJMEECGJMM != other.PFJMEECGJMM)
		{
			return false;
		}
		if (MFCPDJGGCMO != other.MFCPDJGGCMO)
		{
			return false;
		}
		if (CCNGHBADHBL != other.CCNGHBADHBL)
		{
			return false;
		}
		if (FIJNAPNICJF != other.FIJNAPNICJF)
		{
			return false;
		}
		if (NHLKFBOBDOM != other.NHLKFBOBDOM)
		{
			return false;
		}
		if (CPOGDKALGOM != other.CPOGDKALGOM)
		{
			return false;
		}
		if (LENKIEBIIHP != other.LENKIEBIIHP)
		{
			return false;
		}
		if (EJDGNLEOBCN != other.EJDGNLEOBCN)
		{
			return false;
		}
		if (!object.Equals(HGHFECOMJNA, other.HGHFECOMJNA))
		{
			return false;
		}
		if (KFBLHCCGEPO != other.KFBLHCCGEPO)
		{
			return false;
		}
		if (BMEHFMDNKLE != other.BMEHFMDNKLE)
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
		if (COIGOCJHBOP)
		{
			num ^= COIGOCJHBOP.GetHashCode();
		}
		if (CHCNEDNCIDJ)
		{
			num ^= CHCNEDNCIDJ.GetHashCode();
		}
		if (eHKLNPCMMHE_ != null)
		{
			num ^= EHKLNPCMMHE.GetHashCode();
		}
		if (LPEPIDNJDEM)
		{
			num ^= LPEPIDNJDEM.GetHashCode();
		}
		if (BKDCFBDMNIJ)
		{
			num ^= BKDCFBDMNIJ.GetHashCode();
		}
		if (PFJMEECGJMM)
		{
			num ^= PFJMEECGJMM.GetHashCode();
		}
		if (MFCPDJGGCMO)
		{
			num ^= MFCPDJGGCMO.GetHashCode();
		}
		if (CCNGHBADHBL)
		{
			num ^= CCNGHBADHBL.GetHashCode();
		}
		if (FIJNAPNICJF)
		{
			num ^= FIJNAPNICJF.GetHashCode();
		}
		if (NHLKFBOBDOM)
		{
			num ^= NHLKFBOBDOM.GetHashCode();
		}
		if (CPOGDKALGOM)
		{
			num ^= CPOGDKALGOM.GetHashCode();
		}
		if (LENKIEBIIHP)
		{
			num ^= LENKIEBIIHP.GetHashCode();
		}
		if (EJDGNLEOBCN)
		{
			num ^= EJDGNLEOBCN.GetHashCode();
		}
		if (hGHFECOMJNA_ != null)
		{
			num ^= HGHFECOMJNA.GetHashCode();
		}
		if (KFBLHCCGEPO)
		{
			num ^= KFBLHCCGEPO.GetHashCode();
		}
		if (BMEHFMDNKLE)
		{
			num ^= BMEHFMDNKLE.GetHashCode();
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
		if (COIGOCJHBOP)
		{
			output.WriteRawTag(16);
			output.WriteBool(COIGOCJHBOP);
		}
		if (CHCNEDNCIDJ)
		{
			output.WriteRawTag(32);
			output.WriteBool(CHCNEDNCIDJ);
		}
		if (eHKLNPCMMHE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(EHKLNPCMMHE);
		}
		if (LPEPIDNJDEM)
		{
			output.WriteRawTag(56);
			output.WriteBool(LPEPIDNJDEM);
		}
		if (BKDCFBDMNIJ)
		{
			output.WriteRawTag(64);
			output.WriteBool(BKDCFBDMNIJ);
		}
		if (PFJMEECGJMM)
		{
			output.WriteRawTag(72);
			output.WriteBool(PFJMEECGJMM);
		}
		if (MFCPDJGGCMO)
		{
			output.WriteRawTag(80);
			output.WriteBool(MFCPDJGGCMO);
		}
		if (CCNGHBADHBL)
		{
			output.WriteRawTag(88);
			output.WriteBool(CCNGHBADHBL);
		}
		if (FIJNAPNICJF)
		{
			output.WriteRawTag(96);
			output.WriteBool(FIJNAPNICJF);
		}
		if (NHLKFBOBDOM)
		{
			output.WriteRawTag(104);
			output.WriteBool(NHLKFBOBDOM);
		}
		if (CPOGDKALGOM)
		{
			output.WriteRawTag(112);
			output.WriteBool(CPOGDKALGOM);
		}
		if (LENKIEBIIHP)
		{
			output.WriteRawTag(184, 9);
			output.WriteBool(LENKIEBIIHP);
		}
		if (EJDGNLEOBCN)
		{
			output.WriteRawTag(168, 12);
			output.WriteBool(EJDGNLEOBCN);
		}
		if (hGHFECOMJNA_ != null)
		{
			output.WriteRawTag(226, 32);
			output.WriteMessage(HGHFECOMJNA);
		}
		if (KFBLHCCGEPO)
		{
			output.WriteRawTag(152, 76);
			output.WriteBool(KFBLHCCGEPO);
		}
		if (BMEHFMDNKLE)
		{
			output.WriteRawTag(168, 97);
			output.WriteBool(BMEHFMDNKLE);
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
		if (COIGOCJHBOP)
		{
			num += 2;
		}
		if (CHCNEDNCIDJ)
		{
			num += 2;
		}
		if (eHKLNPCMMHE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EHKLNPCMMHE);
		}
		if (LPEPIDNJDEM)
		{
			num += 2;
		}
		if (BKDCFBDMNIJ)
		{
			num += 2;
		}
		if (PFJMEECGJMM)
		{
			num += 2;
		}
		if (MFCPDJGGCMO)
		{
			num += 2;
		}
		if (CCNGHBADHBL)
		{
			num += 2;
		}
		if (FIJNAPNICJF)
		{
			num += 2;
		}
		if (NHLKFBOBDOM)
		{
			num += 2;
		}
		if (CPOGDKALGOM)
		{
			num += 2;
		}
		if (LENKIEBIIHP)
		{
			num += 3;
		}
		if (EJDGNLEOBCN)
		{
			num += 3;
		}
		if (hGHFECOMJNA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HGHFECOMJNA);
		}
		if (KFBLHCCGEPO)
		{
			num += 3;
		}
		if (BMEHFMDNKLE)
		{
			num += 3;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerSettingInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.COIGOCJHBOP)
		{
			COIGOCJHBOP = other.COIGOCJHBOP;
		}
		if (other.CHCNEDNCIDJ)
		{
			CHCNEDNCIDJ = other.CHCNEDNCIDJ;
		}
		if (other.eHKLNPCMMHE_ != null)
		{
			if (eHKLNPCMMHE_ == null)
			{
				EHKLNPCMMHE = new OEEEAEJBENB();
			}
			EHKLNPCMMHE.MergeFrom(other.EHKLNPCMMHE);
		}
		if (other.LPEPIDNJDEM)
		{
			LPEPIDNJDEM = other.LPEPIDNJDEM;
		}
		if (other.BKDCFBDMNIJ)
		{
			BKDCFBDMNIJ = other.BKDCFBDMNIJ;
		}
		if (other.PFJMEECGJMM)
		{
			PFJMEECGJMM = other.PFJMEECGJMM;
		}
		if (other.MFCPDJGGCMO)
		{
			MFCPDJGGCMO = other.MFCPDJGGCMO;
		}
		if (other.CCNGHBADHBL)
		{
			CCNGHBADHBL = other.CCNGHBADHBL;
		}
		if (other.FIJNAPNICJF)
		{
			FIJNAPNICJF = other.FIJNAPNICJF;
		}
		if (other.NHLKFBOBDOM)
		{
			NHLKFBOBDOM = other.NHLKFBOBDOM;
		}
		if (other.CPOGDKALGOM)
		{
			CPOGDKALGOM = other.CPOGDKALGOM;
		}
		if (other.LENKIEBIIHP)
		{
			LENKIEBIIHP = other.LENKIEBIIHP;
		}
		if (other.EJDGNLEOBCN)
		{
			EJDGNLEOBCN = other.EJDGNLEOBCN;
		}
		if (other.hGHFECOMJNA_ != null)
		{
			if (hGHFECOMJNA_ == null)
			{
				HGHFECOMJNA = new NECGMCGFANN();
			}
			HGHFECOMJNA.MergeFrom(other.HGHFECOMJNA);
		}
		if (other.KFBLHCCGEPO)
		{
			KFBLHCCGEPO = other.KFBLHCCGEPO;
		}
		if (other.BMEHFMDNKLE)
		{
			BMEHFMDNKLE = other.BMEHFMDNKLE;
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
				COIGOCJHBOP = input.ReadBool();
				break;
			case 32u:
				CHCNEDNCIDJ = input.ReadBool();
				break;
			case 42u:
				if (eHKLNPCMMHE_ == null)
				{
					EHKLNPCMMHE = new OEEEAEJBENB();
				}
				input.ReadMessage(EHKLNPCMMHE);
				break;
			case 56u:
				LPEPIDNJDEM = input.ReadBool();
				break;
			case 64u:
				BKDCFBDMNIJ = input.ReadBool();
				break;
			case 72u:
				PFJMEECGJMM = input.ReadBool();
				break;
			case 80u:
				MFCPDJGGCMO = input.ReadBool();
				break;
			case 88u:
				CCNGHBADHBL = input.ReadBool();
				break;
			case 96u:
				FIJNAPNICJF = input.ReadBool();
				break;
			case 104u:
				NHLKFBOBDOM = input.ReadBool();
				break;
			case 112u:
				CPOGDKALGOM = input.ReadBool();
				break;
			case 1208u:
				LENKIEBIIHP = input.ReadBool();
				break;
			case 1576u:
				EJDGNLEOBCN = input.ReadBool();
				break;
			case 4194u:
				if (hGHFECOMJNA_ == null)
				{
					HGHFECOMJNA = new NECGMCGFANN();
				}
				input.ReadMessage(HGHFECOMJNA);
				break;
			case 9752u:
				KFBLHCCGEPO = input.ReadBool();
				break;
			case 12456u:
				BMEHFMDNKLE = input.ReadBool();
				break;
			}
		}
	}
}
