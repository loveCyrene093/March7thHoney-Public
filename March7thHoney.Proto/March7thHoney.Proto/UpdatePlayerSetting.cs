using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdatePlayerSetting : IMessage<UpdatePlayerSetting>, IMessage, IEquatable<UpdatePlayerSetting>, IDeepCloneable<UpdatePlayerSetting>, IBufferMessage
{
	public enum MONPGNBOHFCOneofCase
	{
		None = 0,
		CCNGHBADHBL = 2,
		CHCNEDNCIDJ = 4,
		COIGOCJHBOP = 5,
		PFJMEECGJMM = 8,
		NHLKFBOBDOM = 9,
		FIJNAPNICJF = 10,
		EHKLNPCMMHE = 11,
		CPOGDKALGOM = 13,
		MFCPDJGGCMO = 14,
		LPEPIDNJDEM = 15,
		BMEHFMDNKLE = 268,
		BKDCFBDMNIJ = 458,
		KFBLHCCGEPO = 602,
		LENKIEBIIHP = 622,
		HGHFECOMJNA = 1017,
		EJDGNLEOBCN = 1360
	}

	private static readonly MessageParser<UpdatePlayerSetting> _parser = new MessageParser<UpdatePlayerSetting>(() => new UpdatePlayerSetting());

	private UnknownFieldSet _unknownFields;

	public const int CCNGHBADHBLFieldNumber = 2;

	public const int CHCNEDNCIDJFieldNumber = 4;

	public const int COIGOCJHBOPFieldNumber = 5;

	public const int PFJMEECGJMMFieldNumber = 8;

	public const int NHLKFBOBDOMFieldNumber = 9;

	public const int FIJNAPNICJFFieldNumber = 10;

	public const int EHKLNPCMMHEFieldNumber = 11;

	public const int CPOGDKALGOMFieldNumber = 13;

	public const int MFCPDJGGCMOFieldNumber = 14;

	public const int LPEPIDNJDEMFieldNumber = 15;

	public const int BMEHFMDNKLEFieldNumber = 268;

	public const int BKDCFBDMNIJFieldNumber = 458;

	public const int KFBLHCCGEPOFieldNumber = 602;

	public const int LENKIEBIIHPFieldNumber = 622;

	public const int HGHFECOMJNAFieldNumber = 1017;

	public const int EJDGNLEOBCNFieldNumber = 1360;

	private object mONPGNBOHFC_;

	private MONPGNBOHFCOneofCase mONPGNBOHFCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdatePlayerSetting> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdatePlayerSettingReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CCNGHBADHBL
	{
		get
		{
			if (!HasCCNGHBADHBL)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.CCNGHBADHBL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCCNGHBADHBL => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.CCNGHBADHBL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCNEDNCIDJ
	{
		get
		{
			if (!HasCHCNEDNCIDJ)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.CHCNEDNCIDJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCHCNEDNCIDJ => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.CHCNEDNCIDJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool COIGOCJHBOP
	{
		get
		{
			if (!HasCOIGOCJHBOP)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.COIGOCJHBOP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCOIGOCJHBOP => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.COIGOCJHBOP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PFJMEECGJMM
	{
		get
		{
			if (!HasPFJMEECGJMM)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.PFJMEECGJMM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPFJMEECGJMM => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.PFJMEECGJMM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NHLKFBOBDOM
	{
		get
		{
			if (!HasNHLKFBOBDOM)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.NHLKFBOBDOM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNHLKFBOBDOM => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.NHLKFBOBDOM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FIJNAPNICJF
	{
		get
		{
			if (!HasFIJNAPNICJF)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.FIJNAPNICJF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFIJNAPNICJF => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.FIJNAPNICJF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEEEAEJBENB EHKLNPCMMHE
	{
		get
		{
			if (mONPGNBOHFCCase_ != MONPGNBOHFCOneofCase.EHKLNPCMMHE)
			{
				return null;
			}
			return (OEEEAEJBENB)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = ((value != null) ? MONPGNBOHFCOneofCase.EHKLNPCMMHE : MONPGNBOHFCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CPOGDKALGOM
	{
		get
		{
			if (!HasCPOGDKALGOM)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.CPOGDKALGOM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCPOGDKALGOM => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.CPOGDKALGOM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MFCPDJGGCMO
	{
		get
		{
			if (!HasMFCPDJGGCMO)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.MFCPDJGGCMO;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMFCPDJGGCMO => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.MFCPDJGGCMO;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LPEPIDNJDEM
	{
		get
		{
			if (!HasLPEPIDNJDEM)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.LPEPIDNJDEM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLPEPIDNJDEM => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.LPEPIDNJDEM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BMEHFMDNKLE
	{
		get
		{
			if (!HasBMEHFMDNKLE)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.BMEHFMDNKLE;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBMEHFMDNKLE => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.BMEHFMDNKLE;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BKDCFBDMNIJ
	{
		get
		{
			if (!HasBKDCFBDMNIJ)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.BKDCFBDMNIJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBKDCFBDMNIJ => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.BKDCFBDMNIJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KFBLHCCGEPO
	{
		get
		{
			if (!HasKFBLHCCGEPO)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.KFBLHCCGEPO;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKFBLHCCGEPO => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.KFBLHCCGEPO;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LENKIEBIIHP
	{
		get
		{
			if (!HasLENKIEBIIHP)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.LENKIEBIIHP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLENKIEBIIHP => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.LENKIEBIIHP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NECGMCGFANN HGHFECOMJNA
	{
		get
		{
			if (mONPGNBOHFCCase_ != MONPGNBOHFCOneofCase.HGHFECOMJNA)
			{
				return null;
			}
			return (NECGMCGFANN)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = ((value != null) ? MONPGNBOHFCOneofCase.HGHFECOMJNA : MONPGNBOHFCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EJDGNLEOBCN
	{
		get
		{
			if (!HasEJDGNLEOBCN)
			{
				return false;
			}
			return (bool)mONPGNBOHFC_;
		}
		set
		{
			mONPGNBOHFC_ = value;
			mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.EJDGNLEOBCN;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEJDGNLEOBCN => mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.EJDGNLEOBCN;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MONPGNBOHFCOneofCase MONPGNBOHFCCase => mONPGNBOHFCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSetting()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSetting(UpdatePlayerSetting other)
		: this()
	{
		switch (other.MONPGNBOHFCCase)
		{
		case MONPGNBOHFCOneofCase.CCNGHBADHBL:
			CCNGHBADHBL = other.CCNGHBADHBL;
			break;
		case MONPGNBOHFCOneofCase.CHCNEDNCIDJ:
			CHCNEDNCIDJ = other.CHCNEDNCIDJ;
			break;
		case MONPGNBOHFCOneofCase.COIGOCJHBOP:
			COIGOCJHBOP = other.COIGOCJHBOP;
			break;
		case MONPGNBOHFCOneofCase.PFJMEECGJMM:
			PFJMEECGJMM = other.PFJMEECGJMM;
			break;
		case MONPGNBOHFCOneofCase.NHLKFBOBDOM:
			NHLKFBOBDOM = other.NHLKFBOBDOM;
			break;
		case MONPGNBOHFCOneofCase.FIJNAPNICJF:
			FIJNAPNICJF = other.FIJNAPNICJF;
			break;
		case MONPGNBOHFCOneofCase.EHKLNPCMMHE:
			EHKLNPCMMHE = other.EHKLNPCMMHE.Clone();
			break;
		case MONPGNBOHFCOneofCase.CPOGDKALGOM:
			CPOGDKALGOM = other.CPOGDKALGOM;
			break;
		case MONPGNBOHFCOneofCase.MFCPDJGGCMO:
			MFCPDJGGCMO = other.MFCPDJGGCMO;
			break;
		case MONPGNBOHFCOneofCase.LPEPIDNJDEM:
			LPEPIDNJDEM = other.LPEPIDNJDEM;
			break;
		case MONPGNBOHFCOneofCase.BMEHFMDNKLE:
			BMEHFMDNKLE = other.BMEHFMDNKLE;
			break;
		case MONPGNBOHFCOneofCase.BKDCFBDMNIJ:
			BKDCFBDMNIJ = other.BKDCFBDMNIJ;
			break;
		case MONPGNBOHFCOneofCase.KFBLHCCGEPO:
			KFBLHCCGEPO = other.KFBLHCCGEPO;
			break;
		case MONPGNBOHFCOneofCase.LENKIEBIIHP:
			LENKIEBIIHP = other.LENKIEBIIHP;
			break;
		case MONPGNBOHFCOneofCase.HGHFECOMJNA:
			HGHFECOMJNA = other.HGHFECOMJNA.Clone();
			break;
		case MONPGNBOHFCOneofCase.EJDGNLEOBCN:
			EJDGNLEOBCN = other.EJDGNLEOBCN;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSetting Clone()
	{
		return new UpdatePlayerSetting(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCCNGHBADHBL()
	{
		if (HasCCNGHBADHBL)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCHCNEDNCIDJ()
	{
		if (HasCHCNEDNCIDJ)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCOIGOCJHBOP()
	{
		if (HasCOIGOCJHBOP)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPFJMEECGJMM()
	{
		if (HasPFJMEECGJMM)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNHLKFBOBDOM()
	{
		if (HasNHLKFBOBDOM)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFIJNAPNICJF()
	{
		if (HasFIJNAPNICJF)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCPOGDKALGOM()
	{
		if (HasCPOGDKALGOM)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMFCPDJGGCMO()
	{
		if (HasMFCPDJGGCMO)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLPEPIDNJDEM()
	{
		if (HasLPEPIDNJDEM)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBMEHFMDNKLE()
	{
		if (HasBMEHFMDNKLE)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBKDCFBDMNIJ()
	{
		if (HasBKDCFBDMNIJ)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKFBLHCCGEPO()
	{
		if (HasKFBLHCCGEPO)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLENKIEBIIHP()
	{
		if (HasLENKIEBIIHP)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEJDGNLEOBCN()
	{
		if (HasEJDGNLEOBCN)
		{
			ClearMONPGNBOHFC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMONPGNBOHFC()
	{
		mONPGNBOHFCCase_ = MONPGNBOHFCOneofCase.None;
		mONPGNBOHFC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdatePlayerSetting);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdatePlayerSetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CCNGHBADHBL != other.CCNGHBADHBL)
		{
			return false;
		}
		if (CHCNEDNCIDJ != other.CHCNEDNCIDJ)
		{
			return false;
		}
		if (COIGOCJHBOP != other.COIGOCJHBOP)
		{
			return false;
		}
		if (PFJMEECGJMM != other.PFJMEECGJMM)
		{
			return false;
		}
		if (NHLKFBOBDOM != other.NHLKFBOBDOM)
		{
			return false;
		}
		if (FIJNAPNICJF != other.FIJNAPNICJF)
		{
			return false;
		}
		if (!object.Equals(EHKLNPCMMHE, other.EHKLNPCMMHE))
		{
			return false;
		}
		if (CPOGDKALGOM != other.CPOGDKALGOM)
		{
			return false;
		}
		if (MFCPDJGGCMO != other.MFCPDJGGCMO)
		{
			return false;
		}
		if (LPEPIDNJDEM != other.LPEPIDNJDEM)
		{
			return false;
		}
		if (BMEHFMDNKLE != other.BMEHFMDNKLE)
		{
			return false;
		}
		if (BKDCFBDMNIJ != other.BKDCFBDMNIJ)
		{
			return false;
		}
		if (KFBLHCCGEPO != other.KFBLHCCGEPO)
		{
			return false;
		}
		if (LENKIEBIIHP != other.LENKIEBIIHP)
		{
			return false;
		}
		if (!object.Equals(HGHFECOMJNA, other.HGHFECOMJNA))
		{
			return false;
		}
		if (EJDGNLEOBCN != other.EJDGNLEOBCN)
		{
			return false;
		}
		if (MONPGNBOHFCCase != other.MONPGNBOHFCCase)
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
		if (HasCCNGHBADHBL)
		{
			num ^= CCNGHBADHBL.GetHashCode();
		}
		if (HasCHCNEDNCIDJ)
		{
			num ^= CHCNEDNCIDJ.GetHashCode();
		}
		if (HasCOIGOCJHBOP)
		{
			num ^= COIGOCJHBOP.GetHashCode();
		}
		if (HasPFJMEECGJMM)
		{
			num ^= PFJMEECGJMM.GetHashCode();
		}
		if (HasNHLKFBOBDOM)
		{
			num ^= NHLKFBOBDOM.GetHashCode();
		}
		if (HasFIJNAPNICJF)
		{
			num ^= FIJNAPNICJF.GetHashCode();
		}
		if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.EHKLNPCMMHE)
		{
			num ^= EHKLNPCMMHE.GetHashCode();
		}
		if (HasCPOGDKALGOM)
		{
			num ^= CPOGDKALGOM.GetHashCode();
		}
		if (HasMFCPDJGGCMO)
		{
			num ^= MFCPDJGGCMO.GetHashCode();
		}
		if (HasLPEPIDNJDEM)
		{
			num ^= LPEPIDNJDEM.GetHashCode();
		}
		if (HasBMEHFMDNKLE)
		{
			num ^= BMEHFMDNKLE.GetHashCode();
		}
		if (HasBKDCFBDMNIJ)
		{
			num ^= BKDCFBDMNIJ.GetHashCode();
		}
		if (HasKFBLHCCGEPO)
		{
			num ^= KFBLHCCGEPO.GetHashCode();
		}
		if (HasLENKIEBIIHP)
		{
			num ^= LENKIEBIIHP.GetHashCode();
		}
		if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.HGHFECOMJNA)
		{
			num ^= HGHFECOMJNA.GetHashCode();
		}
		if (HasEJDGNLEOBCN)
		{
			num ^= EJDGNLEOBCN.GetHashCode();
		}
		num ^= (int)mONPGNBOHFCCase_;
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
		if (HasCCNGHBADHBL)
		{
			output.WriteRawTag(16);
			output.WriteBool(CCNGHBADHBL);
		}
		if (HasCHCNEDNCIDJ)
		{
			output.WriteRawTag(32);
			output.WriteBool(CHCNEDNCIDJ);
		}
		if (HasCOIGOCJHBOP)
		{
			output.WriteRawTag(40);
			output.WriteBool(COIGOCJHBOP);
		}
		if (HasPFJMEECGJMM)
		{
			output.WriteRawTag(64);
			output.WriteBool(PFJMEECGJMM);
		}
		if (HasNHLKFBOBDOM)
		{
			output.WriteRawTag(72);
			output.WriteBool(NHLKFBOBDOM);
		}
		if (HasFIJNAPNICJF)
		{
			output.WriteRawTag(80);
			output.WriteBool(FIJNAPNICJF);
		}
		if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.EHKLNPCMMHE)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EHKLNPCMMHE);
		}
		if (HasCPOGDKALGOM)
		{
			output.WriteRawTag(104);
			output.WriteBool(CPOGDKALGOM);
		}
		if (HasMFCPDJGGCMO)
		{
			output.WriteRawTag(112);
			output.WriteBool(MFCPDJGGCMO);
		}
		if (HasLPEPIDNJDEM)
		{
			output.WriteRawTag(120);
			output.WriteBool(LPEPIDNJDEM);
		}
		if (HasBMEHFMDNKLE)
		{
			output.WriteRawTag(224, 16);
			output.WriteBool(BMEHFMDNKLE);
		}
		if (HasBKDCFBDMNIJ)
		{
			output.WriteRawTag(208, 28);
			output.WriteBool(BKDCFBDMNIJ);
		}
		if (HasKFBLHCCGEPO)
		{
			output.WriteRawTag(208, 37);
			output.WriteBool(KFBLHCCGEPO);
		}
		if (HasLENKIEBIIHP)
		{
			output.WriteRawTag(240, 38);
			output.WriteBool(LENKIEBIIHP);
		}
		if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.HGHFECOMJNA)
		{
			output.WriteRawTag(202, 63);
			output.WriteMessage(HGHFECOMJNA);
		}
		if (HasEJDGNLEOBCN)
		{
			output.WriteRawTag(128, 85);
			output.WriteBool(EJDGNLEOBCN);
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
		if (HasCCNGHBADHBL)
		{
			num += 2;
		}
		if (HasCHCNEDNCIDJ)
		{
			num += 2;
		}
		if (HasCOIGOCJHBOP)
		{
			num += 2;
		}
		if (HasPFJMEECGJMM)
		{
			num += 2;
		}
		if (HasNHLKFBOBDOM)
		{
			num += 2;
		}
		if (HasFIJNAPNICJF)
		{
			num += 2;
		}
		if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.EHKLNPCMMHE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EHKLNPCMMHE);
		}
		if (HasCPOGDKALGOM)
		{
			num += 2;
		}
		if (HasMFCPDJGGCMO)
		{
			num += 2;
		}
		if (HasLPEPIDNJDEM)
		{
			num += 2;
		}
		if (HasBMEHFMDNKLE)
		{
			num += 3;
		}
		if (HasBKDCFBDMNIJ)
		{
			num += 3;
		}
		if (HasKFBLHCCGEPO)
		{
			num += 3;
		}
		if (HasLENKIEBIIHP)
		{
			num += 3;
		}
		if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.HGHFECOMJNA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HGHFECOMJNA);
		}
		if (HasEJDGNLEOBCN)
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
	public void MergeFrom(UpdatePlayerSetting other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.MONPGNBOHFCCase)
		{
		case MONPGNBOHFCOneofCase.CCNGHBADHBL:
			CCNGHBADHBL = other.CCNGHBADHBL;
			break;
		case MONPGNBOHFCOneofCase.CHCNEDNCIDJ:
			CHCNEDNCIDJ = other.CHCNEDNCIDJ;
			break;
		case MONPGNBOHFCOneofCase.COIGOCJHBOP:
			COIGOCJHBOP = other.COIGOCJHBOP;
			break;
		case MONPGNBOHFCOneofCase.PFJMEECGJMM:
			PFJMEECGJMM = other.PFJMEECGJMM;
			break;
		case MONPGNBOHFCOneofCase.NHLKFBOBDOM:
			NHLKFBOBDOM = other.NHLKFBOBDOM;
			break;
		case MONPGNBOHFCOneofCase.FIJNAPNICJF:
			FIJNAPNICJF = other.FIJNAPNICJF;
			break;
		case MONPGNBOHFCOneofCase.EHKLNPCMMHE:
			if (EHKLNPCMMHE == null)
			{
				EHKLNPCMMHE = new OEEEAEJBENB();
			}
			EHKLNPCMMHE.MergeFrom(other.EHKLNPCMMHE);
			break;
		case MONPGNBOHFCOneofCase.CPOGDKALGOM:
			CPOGDKALGOM = other.CPOGDKALGOM;
			break;
		case MONPGNBOHFCOneofCase.MFCPDJGGCMO:
			MFCPDJGGCMO = other.MFCPDJGGCMO;
			break;
		case MONPGNBOHFCOneofCase.LPEPIDNJDEM:
			LPEPIDNJDEM = other.LPEPIDNJDEM;
			break;
		case MONPGNBOHFCOneofCase.BMEHFMDNKLE:
			BMEHFMDNKLE = other.BMEHFMDNKLE;
			break;
		case MONPGNBOHFCOneofCase.BKDCFBDMNIJ:
			BKDCFBDMNIJ = other.BKDCFBDMNIJ;
			break;
		case MONPGNBOHFCOneofCase.KFBLHCCGEPO:
			KFBLHCCGEPO = other.KFBLHCCGEPO;
			break;
		case MONPGNBOHFCOneofCase.LENKIEBIIHP:
			LENKIEBIIHP = other.LENKIEBIIHP;
			break;
		case MONPGNBOHFCOneofCase.HGHFECOMJNA:
			if (HGHFECOMJNA == null)
			{
				HGHFECOMJNA = new NECGMCGFANN();
			}
			HGHFECOMJNA.MergeFrom(other.HGHFECOMJNA);
			break;
		case MONPGNBOHFCOneofCase.EJDGNLEOBCN:
			EJDGNLEOBCN = other.EJDGNLEOBCN;
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
			case 16u:
				CCNGHBADHBL = input.ReadBool();
				break;
			case 32u:
				CHCNEDNCIDJ = input.ReadBool();
				break;
			case 40u:
				COIGOCJHBOP = input.ReadBool();
				break;
			case 64u:
				PFJMEECGJMM = input.ReadBool();
				break;
			case 72u:
				NHLKFBOBDOM = input.ReadBool();
				break;
			case 80u:
				FIJNAPNICJF = input.ReadBool();
				break;
			case 90u:
			{
				OEEEAEJBENB oEEEAEJBENB = new OEEEAEJBENB();
				if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.EHKLNPCMMHE)
				{
					oEEEAEJBENB.MergeFrom(EHKLNPCMMHE);
				}
				input.ReadMessage(oEEEAEJBENB);
				EHKLNPCMMHE = oEEEAEJBENB;
				break;
			}
			case 104u:
				CPOGDKALGOM = input.ReadBool();
				break;
			case 112u:
				MFCPDJGGCMO = input.ReadBool();
				break;
			case 120u:
				LPEPIDNJDEM = input.ReadBool();
				break;
			case 2144u:
				BMEHFMDNKLE = input.ReadBool();
				break;
			case 3664u:
				BKDCFBDMNIJ = input.ReadBool();
				break;
			case 4816u:
				KFBLHCCGEPO = input.ReadBool();
				break;
			case 4976u:
				LENKIEBIIHP = input.ReadBool();
				break;
			case 8138u:
			{
				NECGMCGFANN nECGMCGFANN = new NECGMCGFANN();
				if (mONPGNBOHFCCase_ == MONPGNBOHFCOneofCase.HGHFECOMJNA)
				{
					nECGMCGFANN.MergeFrom(HGHFECOMJNA);
				}
				input.ReadMessage(nECGMCGFANN);
				HGHFECOMJNA = nECGMCGFANN;
				break;
			}
			case 10880u:
				EJDGNLEOBCN = input.ReadBool();
				break;
			}
		}
	}
}
