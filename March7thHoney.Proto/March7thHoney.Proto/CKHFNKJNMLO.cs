using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CKHFNKJNMLO : IMessage<CKHFNKJNMLO>, IMessage, IEquatable<CKHFNKJNMLO>, IDeepCloneable<CKHFNKJNMLO>, IBufferMessage
{
	private static readonly MessageParser<CKHFNKJNMLO> _parser = new MessageParser<CKHFNKJNMLO>(() => new CKHFNKJNMLO());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int HCPBKALKGGLFieldNumber = 2;

	private uint hCPBKALKGGL_;

	public const int BEFJLFKJFJDFieldNumber = 3;

	private uint bEFJLFKJFJD_;

	public const int CELNCPCPMHAFieldNumber = 4;

	private uint cELNCPCPMHA_;

	public const int BJBABGBGGINFieldNumber = 5;

	private bool bJBABGBGGIN_;

	public const int LDKGJBALGKCFieldNumber = 6;

	private uint lDKGJBALGKC_;

	public const int LFIGIPDKBAPFieldNumber = 7;

	private uint lFIGIPDKBAP_;

	public const int FKEHOGMGLJFFieldNumber = 8;

	private CIMCDCBNNKJ fKEHOGMGLJF_;

	public const int DCJBFCPGNAJFieldNumber = 9;

	private CIMCDCBNNKJ dCJBFCPGNAJ_;

	public const int AttackTypeFieldNumber = 10;

	private uint attackType_;

	public const int CIGAPFKFNOPFieldNumber = 11;

	private HMNAPNOMPME cIGAPFKFNOP_;

	public const int ELGDHJFKDIOFieldNumber = 12;

	private HMNAPNOMPME eLGDHJFKDIO_;

	public const int GELDILBFGBMFieldNumber = 13;

	private uint gELDILBFGBM_;

	public const int CostTimeFieldNumber = 14;

	private uint costTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CKHFNKJNMLO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CKHFNKJNMLOReflection.Descriptor.MessageTypes[0];

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
	public uint HCPBKALKGGL
	{
		get
		{
			return hCPBKALKGGL_;
		}
		set
		{
			hCPBKALKGGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEFJLFKJFJD
	{
		get
		{
			return bEFJLFKJFJD_;
		}
		set
		{
			bEFJLFKJFJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CELNCPCPMHA
	{
		get
		{
			return cELNCPCPMHA_;
		}
		set
		{
			cELNCPCPMHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BJBABGBGGIN
	{
		get
		{
			return bJBABGBGGIN_;
		}
		set
		{
			bJBABGBGGIN_ = value;
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
	public uint GELDILBFGBM
	{
		get
		{
			return gELDILBFGBM_;
		}
		set
		{
			gELDILBFGBM_ = value;
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
	public CKHFNKJNMLO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKHFNKJNMLO(CKHFNKJNMLO other)
		: this()
	{
		roomId_ = other.roomId_;
		hCPBKALKGGL_ = other.hCPBKALKGGL_;
		bEFJLFKJFJD_ = other.bEFJLFKJFJD_;
		cELNCPCPMHA_ = other.cELNCPCPMHA_;
		bJBABGBGGIN_ = other.bJBABGBGGIN_;
		lDKGJBALGKC_ = other.lDKGJBALGKC_;
		lFIGIPDKBAP_ = other.lFIGIPDKBAP_;
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		dCJBFCPGNAJ_ = ((other.dCJBFCPGNAJ_ != null) ? other.dCJBFCPGNAJ_.Clone() : null);
		attackType_ = other.attackType_;
		cIGAPFKFNOP_ = ((other.cIGAPFKFNOP_ != null) ? other.cIGAPFKFNOP_.Clone() : null);
		eLGDHJFKDIO_ = ((other.eLGDHJFKDIO_ != null) ? other.eLGDHJFKDIO_.Clone() : null);
		gELDILBFGBM_ = other.gELDILBFGBM_;
		costTime_ = other.costTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKHFNKJNMLO Clone()
	{
		return new CKHFNKJNMLO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CKHFNKJNMLO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CKHFNKJNMLO other)
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
		if (HCPBKALKGGL != other.HCPBKALKGGL)
		{
			return false;
		}
		if (BEFJLFKJFJD != other.BEFJLFKJFJD)
		{
			return false;
		}
		if (CELNCPCPMHA != other.CELNCPCPMHA)
		{
			return false;
		}
		if (BJBABGBGGIN != other.BJBABGBGGIN)
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
		if (!object.Equals(ELGDHJFKDIO, other.ELGDHJFKDIO))
		{
			return false;
		}
		if (GELDILBFGBM != other.GELDILBFGBM)
		{
			return false;
		}
		if (CostTime != other.CostTime)
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
		if (HCPBKALKGGL != 0)
		{
			num ^= HCPBKALKGGL.GetHashCode();
		}
		if (BEFJLFKJFJD != 0)
		{
			num ^= BEFJLFKJFJD.GetHashCode();
		}
		if (CELNCPCPMHA != 0)
		{
			num ^= CELNCPCPMHA.GetHashCode();
		}
		if (BJBABGBGGIN)
		{
			num ^= BJBABGBGGIN.GetHashCode();
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
		if (eLGDHJFKDIO_ != null)
		{
			num ^= ELGDHJFKDIO.GetHashCode();
		}
		if (GELDILBFGBM != 0)
		{
			num ^= GELDILBFGBM.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
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
		if (HCPBKALKGGL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HCPBKALKGGL);
		}
		if (BEFJLFKJFJD != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BEFJLFKJFJD);
		}
		if (CELNCPCPMHA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CELNCPCPMHA);
		}
		if (BJBABGBGGIN)
		{
			output.WriteRawTag(40);
			output.WriteBool(BJBABGBGGIN);
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
		if (dCJBFCPGNAJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(DCJBFCPGNAJ);
		}
		if (AttackType != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AttackType);
		}
		if (cIGAPFKFNOP_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CIGAPFKFNOP);
		}
		if (eLGDHJFKDIO_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ELGDHJFKDIO);
		}
		if (GELDILBFGBM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GELDILBFGBM);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CostTime);
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
		if (HCPBKALKGGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCPBKALKGGL);
		}
		if (BEFJLFKJFJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEFJLFKJFJD);
		}
		if (CELNCPCPMHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CELNCPCPMHA);
		}
		if (BJBABGBGGIN)
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
		if (eLGDHJFKDIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ELGDHJFKDIO);
		}
		if (GELDILBFGBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GELDILBFGBM);
		}
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CKHFNKJNMLO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
		}
		if (other.HCPBKALKGGL != 0)
		{
			HCPBKALKGGL = other.HCPBKALKGGL;
		}
		if (other.BEFJLFKJFJD != 0)
		{
			BEFJLFKJFJD = other.BEFJLFKJFJD;
		}
		if (other.CELNCPCPMHA != 0)
		{
			CELNCPCPMHA = other.CELNCPCPMHA;
		}
		if (other.BJBABGBGGIN)
		{
			BJBABGBGGIN = other.BJBABGBGGIN;
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
		if (other.eLGDHJFKDIO_ != null)
		{
			if (eLGDHJFKDIO_ == null)
			{
				ELGDHJFKDIO = new HMNAPNOMPME();
			}
			ELGDHJFKDIO.MergeFrom(other.ELGDHJFKDIO);
		}
		if (other.GELDILBFGBM != 0)
		{
			GELDILBFGBM = other.GELDILBFGBM;
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
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
				HCPBKALKGGL = input.ReadUInt32();
				break;
			case 24u:
				BEFJLFKJFJD = input.ReadUInt32();
				break;
			case 32u:
				CELNCPCPMHA = input.ReadUInt32();
				break;
			case 40u:
				BJBABGBGGIN = input.ReadBool();
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
				if (dCJBFCPGNAJ_ == null)
				{
					DCJBFCPGNAJ = new CIMCDCBNNKJ();
				}
				input.ReadMessage(DCJBFCPGNAJ);
				break;
			case 80u:
				AttackType = input.ReadUInt32();
				break;
			case 90u:
				if (cIGAPFKFNOP_ == null)
				{
					CIGAPFKFNOP = new HMNAPNOMPME();
				}
				input.ReadMessage(CIGAPFKFNOP);
				break;
			case 98u:
				if (eLGDHJFKDIO_ == null)
				{
					ELGDHJFKDIO = new HMNAPNOMPME();
				}
				input.ReadMessage(ELGDHJFKDIO);
				break;
			case 104u:
				GELDILBFGBM = input.ReadUInt32();
				break;
			case 112u:
				CostTime = input.ReadUInt32();
				break;
			}
		}
	}
}
