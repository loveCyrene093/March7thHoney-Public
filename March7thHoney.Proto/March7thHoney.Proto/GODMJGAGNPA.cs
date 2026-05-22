using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GODMJGAGNPA : IMessage<GODMJGAGNPA>, IMessage, IEquatable<GODMJGAGNPA>, IDeepCloneable<GODMJGAGNPA>, IBufferMessage
{
	private static readonly MessageParser<GODMJGAGNPA> _parser = new MessageParser<GODMJGAGNPA>(() => new GODMJGAGNPA());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int MMLKFJIAKKHFieldNumber = 2;

	private uint mMLKFJIAKKH_;

	public const int NDKAIAFPNBJFieldNumber = 3;

	private uint nDKAIAFPNBJ_;

	public const int GLNMEPNKHLNFieldNumber = 4;

	private uint gLNMEPNKHLN_;

	public const int PKJAIJOKJLEFieldNumber = 5;

	private bool pKJAIJOKJLE_;

	public const int LDKGJBALGKCFieldNumber = 6;

	private uint lDKGJBALGKC_;

	public const int LFIGIPDKBAPFieldNumber = 7;

	private uint lFIGIPDKBAP_;

	public const int FKEHOGMGLJFFieldNumber = 8;

	private CIMCDCBNNKJ fKEHOGMGLJF_;

	public const int HMDBAGELEIEFieldNumber = 9;

	private CIMCDCBNNKJ hMDBAGELEIE_;

	public const int DCJBFCPGNAJFieldNumber = 10;

	private CIMCDCBNNKJ dCJBFCPGNAJ_;

	public const int AttackTypeFieldNumber = 11;

	private uint attackType_;

	public const int CIGAPFKFNOPFieldNumber = 12;

	private HMNAPNOMPME cIGAPFKFNOP_;

	public const int JDOPCGBDDDCFieldNumber = 13;

	private HMNAPNOMPME jDOPCGBDDDC_;

	public const int ELGDHJFKDIOFieldNumber = 14;

	private HMNAPNOMPME eLGDHJFKDIO_;

	public const int LCAPODJAJDLFieldNumber = 15;

	private uint lCAPODJAJDL_;

	public const int HCBGLJHAGAEFieldNumber = 16;

	private uint hCBGLJHAGAE_;

	public const int CostTimeFieldNumber = 17;

	private uint costTime_;

	public const int JDJECFHLOEDFieldNumber = 18;

	private uint jDJECFHLOED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GODMJGAGNPA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GODMJGAGNPAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDKAIAFPNBJ
	{
		get
		{
			return nDKAIAFPNBJ_;
		}
		set
		{
			nDKAIAFPNBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLNMEPNKHLN
	{
		get
		{
			return gLNMEPNKHLN_;
		}
		set
		{
			gLNMEPNKHLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PKJAIJOKJLE
	{
		get
		{
			return pKJAIJOKJLE_;
		}
		set
		{
			pKJAIJOKJLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDKGJBALGKC
	{
		get
		{
			return lDKGJBALGKC_;
		}
		set
		{
			lDKGJBALGKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFIGIPDKBAP
	{
		get
		{
			return lFIGIPDKBAP_;
		}
		set
		{
			lFIGIPDKBAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ FKEHOGMGLJF
	{
		get
		{
			return fKEHOGMGLJF_;
		}
		set
		{
			fKEHOGMGLJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ HMDBAGELEIE
	{
		get
		{
			return hMDBAGELEIE_;
		}
		set
		{
			hMDBAGELEIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ DCJBFCPGNAJ
	{
		get
		{
			return dCJBFCPGNAJ_;
		}
		set
		{
			dCJBFCPGNAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AttackType
	{
		get
		{
			return attackType_;
		}
		set
		{
			attackType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMNAPNOMPME CIGAPFKFNOP
	{
		get
		{
			return cIGAPFKFNOP_;
		}
		set
		{
			cIGAPFKFNOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMNAPNOMPME JDOPCGBDDDC
	{
		get
		{
			return jDOPCGBDDDC_;
		}
		set
		{
			jDOPCGBDDDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMNAPNOMPME ELGDHJFKDIO
	{
		get
		{
			return eLGDHJFKDIO_;
		}
		set
		{
			eLGDHJFKDIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCAPODJAJDL
	{
		get
		{
			return lCAPODJAJDL_;
		}
		set
		{
			lCAPODJAJDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCBGLJHAGAE
	{
		get
		{
			return hCBGLJHAGAE_;
		}
		set
		{
			hCBGLJHAGAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDJECFHLOED
	{
		get
		{
			return jDJECFHLOED_;
		}
		set
		{
			jDJECFHLOED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODMJGAGNPA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODMJGAGNPA(GODMJGAGNPA other)
		: this()
	{
		roomId_ = other.roomId_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		nDKAIAFPNBJ_ = other.nDKAIAFPNBJ_;
		gLNMEPNKHLN_ = other.gLNMEPNKHLN_;
		pKJAIJOKJLE_ = other.pKJAIJOKJLE_;
		lDKGJBALGKC_ = other.lDKGJBALGKC_;
		lFIGIPDKBAP_ = other.lFIGIPDKBAP_;
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		hMDBAGELEIE_ = ((other.hMDBAGELEIE_ != null) ? other.hMDBAGELEIE_.Clone() : null);
		dCJBFCPGNAJ_ = ((other.dCJBFCPGNAJ_ != null) ? other.dCJBFCPGNAJ_.Clone() : null);
		attackType_ = other.attackType_;
		cIGAPFKFNOP_ = ((other.cIGAPFKFNOP_ != null) ? other.cIGAPFKFNOP_.Clone() : null);
		jDOPCGBDDDC_ = ((other.jDOPCGBDDDC_ != null) ? other.jDOPCGBDDDC_.Clone() : null);
		eLGDHJFKDIO_ = ((other.eLGDHJFKDIO_ != null) ? other.eLGDHJFKDIO_.Clone() : null);
		lCAPODJAJDL_ = other.lCAPODJAJDL_;
		hCBGLJHAGAE_ = other.hCBGLJHAGAE_;
		costTime_ = other.costTime_;
		jDJECFHLOED_ = other.jDJECFHLOED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODMJGAGNPA Clone()
	{
		return new GODMJGAGNPA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GODMJGAGNPA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GODMJGAGNPA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (NDKAIAFPNBJ != other.NDKAIAFPNBJ)
		{
			return false;
		}
		if (GLNMEPNKHLN != other.GLNMEPNKHLN)
		{
			return false;
		}
		if (PKJAIJOKJLE != other.PKJAIJOKJLE)
		{
			return false;
		}
		if (LDKGJBALGKC != other.LDKGJBALGKC)
		{
			return false;
		}
		if (LFIGIPDKBAP != other.LFIGIPDKBAP)
		{
			return false;
		}
		if (!object.Equals(FKEHOGMGLJF, other.FKEHOGMGLJF))
		{
			return false;
		}
		if (!object.Equals(HMDBAGELEIE, other.HMDBAGELEIE))
		{
			return false;
		}
		if (!object.Equals(DCJBFCPGNAJ, other.DCJBFCPGNAJ))
		{
			return false;
		}
		if (AttackType != other.AttackType)
		{
			return false;
		}
		if (!object.Equals(CIGAPFKFNOP, other.CIGAPFKFNOP))
		{
			return false;
		}
		if (!object.Equals(JDOPCGBDDDC, other.JDOPCGBDDDC))
		{
			return false;
		}
		if (!object.Equals(ELGDHJFKDIO, other.ELGDHJFKDIO))
		{
			return false;
		}
		if (LCAPODJAJDL != other.LCAPODJAJDL)
		{
			return false;
		}
		if (HCBGLJHAGAE != other.HCBGLJHAGAE)
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (JDJECFHLOED != other.JDJECFHLOED)
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
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (NDKAIAFPNBJ != 0)
		{
			num ^= NDKAIAFPNBJ.GetHashCode();
		}
		if (GLNMEPNKHLN != 0)
		{
			num ^= GLNMEPNKHLN.GetHashCode();
		}
		if (PKJAIJOKJLE)
		{
			num ^= PKJAIJOKJLE.GetHashCode();
		}
		if (LDKGJBALGKC != 0)
		{
			num ^= LDKGJBALGKC.GetHashCode();
		}
		if (LFIGIPDKBAP != 0)
		{
			num ^= LFIGIPDKBAP.GetHashCode();
		}
		if (fKEHOGMGLJF_ != null)
		{
			num ^= FKEHOGMGLJF.GetHashCode();
		}
		if (hMDBAGELEIE_ != null)
		{
			num ^= HMDBAGELEIE.GetHashCode();
		}
		if (dCJBFCPGNAJ_ != null)
		{
			num ^= DCJBFCPGNAJ.GetHashCode();
		}
		if (AttackType != 0)
		{
			num ^= AttackType.GetHashCode();
		}
		if (cIGAPFKFNOP_ != null)
		{
			num ^= CIGAPFKFNOP.GetHashCode();
		}
		if (jDOPCGBDDDC_ != null)
		{
			num ^= JDOPCGBDDDC.GetHashCode();
		}
		if (eLGDHJFKDIO_ != null)
		{
			num ^= ELGDHJFKDIO.GetHashCode();
		}
		if (LCAPODJAJDL != 0)
		{
			num ^= LCAPODJAJDL.GetHashCode();
		}
		if (HCBGLJHAGAE != 0)
		{
			num ^= HCBGLJHAGAE.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		if (JDJECFHLOED != 0)
		{
			num ^= JDJECFHLOED.GetHashCode();
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
		if (RoomId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NDKAIAFPNBJ);
		}
		if (GLNMEPNKHLN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GLNMEPNKHLN);
		}
		if (PKJAIJOKJLE)
		{
			output.WriteRawTag(40);
			output.WriteBool(PKJAIJOKJLE);
		}
		if (LDKGJBALGKC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LDKGJBALGKC);
		}
		if (LFIGIPDKBAP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LFIGIPDKBAP);
		}
		if (fKEHOGMGLJF_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FKEHOGMGLJF);
		}
		if (hMDBAGELEIE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HMDBAGELEIE);
		}
		if (dCJBFCPGNAJ_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DCJBFCPGNAJ);
		}
		if (AttackType != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AttackType);
		}
		if (cIGAPFKFNOP_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(CIGAPFKFNOP);
		}
		if (jDOPCGBDDDC_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(JDOPCGBDDDC);
		}
		if (eLGDHJFKDIO_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ELGDHJFKDIO);
		}
		if (LCAPODJAJDL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LCAPODJAJDL);
		}
		if (HCBGLJHAGAE != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(HCBGLJHAGAE);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(CostTime);
		}
		if (JDJECFHLOED != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteUInt32(JDJECFHLOED);
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
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDKAIAFPNBJ);
		}
		if (GLNMEPNKHLN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLNMEPNKHLN);
		}
		if (PKJAIJOKJLE)
		{
			num += 2;
		}
		if (LDKGJBALGKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDKGJBALGKC);
		}
		if (LFIGIPDKBAP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFIGIPDKBAP);
		}
		if (fKEHOGMGLJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKEHOGMGLJF);
		}
		if (hMDBAGELEIE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMDBAGELEIE);
		}
		if (dCJBFCPGNAJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCJBFCPGNAJ);
		}
		if (AttackType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AttackType);
		}
		if (cIGAPFKFNOP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CIGAPFKFNOP);
		}
		if (jDOPCGBDDDC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JDOPCGBDDDC);
		}
		if (eLGDHJFKDIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ELGDHJFKDIO);
		}
		if (LCAPODJAJDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCAPODJAJDL);
		}
		if (HCBGLJHAGAE != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HCBGLJHAGAE);
		}
		if (CostTime != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (JDJECFHLOED != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(JDJECFHLOED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GODMJGAGNPA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
		}
		if (other.MMLKFJIAKKH != 0)
		{
			MMLKFJIAKKH = other.MMLKFJIAKKH;
		}
		if (other.NDKAIAFPNBJ != 0)
		{
			NDKAIAFPNBJ = other.NDKAIAFPNBJ;
		}
		if (other.GLNMEPNKHLN != 0)
		{
			GLNMEPNKHLN = other.GLNMEPNKHLN;
		}
		if (other.PKJAIJOKJLE)
		{
			PKJAIJOKJLE = other.PKJAIJOKJLE;
		}
		if (other.LDKGJBALGKC != 0)
		{
			LDKGJBALGKC = other.LDKGJBALGKC;
		}
		if (other.LFIGIPDKBAP != 0)
		{
			LFIGIPDKBAP = other.LFIGIPDKBAP;
		}
		if (other.fKEHOGMGLJF_ != null)
		{
			if (fKEHOGMGLJF_ == null)
			{
				FKEHOGMGLJF = new CIMCDCBNNKJ();
			}
			FKEHOGMGLJF.MergeFrom(other.FKEHOGMGLJF);
		}
		if (other.hMDBAGELEIE_ != null)
		{
			if (hMDBAGELEIE_ == null)
			{
				HMDBAGELEIE = new CIMCDCBNNKJ();
			}
			HMDBAGELEIE.MergeFrom(other.HMDBAGELEIE);
		}
		if (other.dCJBFCPGNAJ_ != null)
		{
			if (dCJBFCPGNAJ_ == null)
			{
				DCJBFCPGNAJ = new CIMCDCBNNKJ();
			}
			DCJBFCPGNAJ.MergeFrom(other.DCJBFCPGNAJ);
		}
		if (other.AttackType != 0)
		{
			AttackType = other.AttackType;
		}
		if (other.cIGAPFKFNOP_ != null)
		{
			if (cIGAPFKFNOP_ == null)
			{
				CIGAPFKFNOP = new HMNAPNOMPME();
			}
			CIGAPFKFNOP.MergeFrom(other.CIGAPFKFNOP);
		}
		if (other.jDOPCGBDDDC_ != null)
		{
			if (jDOPCGBDDDC_ == null)
			{
				JDOPCGBDDDC = new HMNAPNOMPME();
			}
			JDOPCGBDDDC.MergeFrom(other.JDOPCGBDDDC);
		}
		if (other.eLGDHJFKDIO_ != null)
		{
			if (eLGDHJFKDIO_ == null)
			{
				ELGDHJFKDIO = new HMNAPNOMPME();
			}
			ELGDHJFKDIO.MergeFrom(other.ELGDHJFKDIO);
		}
		if (other.LCAPODJAJDL != 0)
		{
			LCAPODJAJDL = other.LCAPODJAJDL;
		}
		if (other.HCBGLJHAGAE != 0)
		{
			HCBGLJHAGAE = other.HCBGLJHAGAE;
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
		}
		if (other.JDJECFHLOED != 0)
		{
			JDJECFHLOED = other.JDJECFHLOED;
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
				RoomId = input.ReadUInt64();
				break;
			case 16u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 24u:
				NDKAIAFPNBJ = input.ReadUInt32();
				break;
			case 32u:
				GLNMEPNKHLN = input.ReadUInt32();
				break;
			case 40u:
				PKJAIJOKJLE = input.ReadBool();
				break;
			case 48u:
				LDKGJBALGKC = input.ReadUInt32();
				break;
			case 56u:
				LFIGIPDKBAP = input.ReadUInt32();
				break;
			case 66u:
				if (fKEHOGMGLJF_ == null)
				{
					FKEHOGMGLJF = new CIMCDCBNNKJ();
				}
				input.ReadMessage(FKEHOGMGLJF);
				break;
			case 74u:
				if (hMDBAGELEIE_ == null)
				{
					HMDBAGELEIE = new CIMCDCBNNKJ();
				}
				input.ReadMessage(HMDBAGELEIE);
				break;
			case 82u:
				if (dCJBFCPGNAJ_ == null)
				{
					DCJBFCPGNAJ = new CIMCDCBNNKJ();
				}
				input.ReadMessage(DCJBFCPGNAJ);
				break;
			case 88u:
				AttackType = input.ReadUInt32();
				break;
			case 98u:
				if (cIGAPFKFNOP_ == null)
				{
					CIGAPFKFNOP = new HMNAPNOMPME();
				}
				input.ReadMessage(CIGAPFKFNOP);
				break;
			case 106u:
				if (jDOPCGBDDDC_ == null)
				{
					JDOPCGBDDDC = new HMNAPNOMPME();
				}
				input.ReadMessage(JDOPCGBDDDC);
				break;
			case 114u:
				if (eLGDHJFKDIO_ == null)
				{
					ELGDHJFKDIO = new HMNAPNOMPME();
				}
				input.ReadMessage(ELGDHJFKDIO);
				break;
			case 120u:
				LCAPODJAJDL = input.ReadUInt32();
				break;
			case 128u:
				HCBGLJHAGAE = input.ReadUInt32();
				break;
			case 136u:
				CostTime = input.ReadUInt32();
				break;
			case 144u:
				JDJECFHLOED = input.ReadUInt32();
				break;
			}
		}
	}
}
