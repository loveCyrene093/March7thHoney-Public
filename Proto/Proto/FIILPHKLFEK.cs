using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIILPHKLFEK : IMessage<FIILPHKLFEK>, IMessage, IEquatable<FIILPHKLFEK>, IDeepCloneable<FIILPHKLFEK>, IBufferMessage
{
	private static readonly MessageParser<FIILPHKLFEK> _parser = new MessageParser<FIILPHKLFEK>(() => new FIILPHKLFEK());

	private UnknownFieldSet _unknownFields;

	public const int DJMGKNPLBOIFieldNumber = 1;

	private uint dJMGKNPLBOI_;

	public const int DifficultyLevelFieldNumber = 2;

	private uint difficultyLevel_;

	public const int IDPBLDHNHKBFieldNumber = 3;

	private GCDMHAMCDHI iDPBLDHNHKB_;

	public const int BMLDPGFFIIBFieldNumber = 5;

	private uint bMLDPGFFIIB_;

	public const int HBFHJOIEBIEFieldNumber = 6;

	private uint hBFHJOIEBIE_;

	public const int AIEHGFOCPBGFieldNumber = 7;

	private uint aIEHGFOCPBG_;

	public const int DJDPILOKDKOFieldNumber = 8;

	private LineupInfo dJDPILOKDKO_;

	public const int IsFinishFieldNumber = 10;

	private bool isFinish_;

	public const int HKGKNEKKJHBFieldNumber = 11;

	private CADKBOKEJMD hKGKNEKKJHB_;

	public const int HEEAPOIPJMPFieldNumber = 12;

	private ItemList hEEAPOIPJMP_;

	public const int CKPKAPEIKIHFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_cKPKAPEIKIH_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> cKPKAPEIKIH_ = new RepeatedField<uint>();

	public const int FEILNIKNPCBFieldNumber = 14;

	private DECAOHONNJG fEILNIKNPCB_;

	public const int FAPFKFJIELEFieldNumber = 15;

	private uint fAPFKFJIELE_;

	public const int ScoreIdFieldNumber = 401;

	private uint scoreId_;

	public const int LOIDOGEENOBFieldNumber = 709;

	private uint lOIDOGEENOB_;

	public const int OINIDCCNAOMFieldNumber = 751;

	private uint oINIDCCNAOM_;

	public const int NNLEHIMNDBEFieldNumber = 988;

	private uint nNLEHIMNDBE_;

	public const int PJINJJGOMMFFieldNumber = 1505;

	private uint pJINJJGOMMF_;

	public const int JGHIBCLBLAGFieldNumber = 1592;

	private JBEENGDECOH jGHIBCLBLAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIILPHKLFEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIILPHKLFEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DJMGKNPLBOI
	{
		get
		{
			return dJMGKNPLBOI_;
		}
		set
		{
			dJMGKNPLBOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCDMHAMCDHI IDPBLDHNHKB
	{
		get
		{
			return iDPBLDHNHKB_;
		}
		set
		{
			iDPBLDHNHKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMLDPGFFIIB
	{
		get
		{
			return bMLDPGFFIIB_;
		}
		set
		{
			bMLDPGFFIIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBFHJOIEBIE
	{
		get
		{
			return hBFHJOIEBIE_;
		}
		set
		{
			hBFHJOIEBIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AIEHGFOCPBG
	{
		get
		{
			return aIEHGFOCPBG_;
		}
		set
		{
			aIEHGFOCPBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo DJDPILOKDKO
	{
		get
		{
			return dJDPILOKDKO_;
		}
		set
		{
			dJDPILOKDKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFinish
	{
		get
		{
			return isFinish_;
		}
		set
		{
			isFinish_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CADKBOKEJMD HKGKNEKKJHB
	{
		get
		{
			return hKGKNEKKJHB_;
		}
		set
		{
			hKGKNEKKJHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList HEEAPOIPJMP
	{
		get
		{
			return hEEAPOIPJMP_;
		}
		set
		{
			hEEAPOIPJMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CKPKAPEIKIH => cKPKAPEIKIH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DECAOHONNJG FEILNIKNPCB
	{
		get
		{
			return fEILNIKNPCB_;
		}
		set
		{
			fEILNIKNPCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAPFKFJIELE
	{
		get
		{
			return fAPFKFJIELE_;
		}
		set
		{
			fAPFKFJIELE_ = value;
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
	public uint LOIDOGEENOB
	{
		get
		{
			return lOIDOGEENOB_;
		}
		set
		{
			lOIDOGEENOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OINIDCCNAOM
	{
		get
		{
			return oINIDCCNAOM_;
		}
		set
		{
			oINIDCCNAOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNLEHIMNDBE
	{
		get
		{
			return nNLEHIMNDBE_;
		}
		set
		{
			nNLEHIMNDBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJINJJGOMMF
	{
		get
		{
			return pJINJJGOMMF_;
		}
		set
		{
			pJINJJGOMMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBEENGDECOH JGHIBCLBLAG
	{
		get
		{
			return jGHIBCLBLAG_;
		}
		set
		{
			jGHIBCLBLAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIILPHKLFEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIILPHKLFEK(FIILPHKLFEK other)
		: this()
	{
		dJMGKNPLBOI_ = other.dJMGKNPLBOI_;
		difficultyLevel_ = other.difficultyLevel_;
		iDPBLDHNHKB_ = other.iDPBLDHNHKB_;
		bMLDPGFFIIB_ = other.bMLDPGFFIIB_;
		hBFHJOIEBIE_ = other.hBFHJOIEBIE_;
		aIEHGFOCPBG_ = other.aIEHGFOCPBG_;
		dJDPILOKDKO_ = ((other.dJDPILOKDKO_ != null) ? other.dJDPILOKDKO_.Clone() : null);
		isFinish_ = other.isFinish_;
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		hEEAPOIPJMP_ = ((other.hEEAPOIPJMP_ != null) ? other.hEEAPOIPJMP_.Clone() : null);
		cKPKAPEIKIH_ = other.cKPKAPEIKIH_.Clone();
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		fAPFKFJIELE_ = other.fAPFKFJIELE_;
		scoreId_ = other.scoreId_;
		lOIDOGEENOB_ = other.lOIDOGEENOB_;
		oINIDCCNAOM_ = other.oINIDCCNAOM_;
		nNLEHIMNDBE_ = other.nNLEHIMNDBE_;
		pJINJJGOMMF_ = other.pJINJJGOMMF_;
		jGHIBCLBLAG_ = ((other.jGHIBCLBLAG_ != null) ? other.jGHIBCLBLAG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIILPHKLFEK Clone()
	{
		return new FIILPHKLFEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIILPHKLFEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIILPHKLFEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DJMGKNPLBOI != other.DJMGKNPLBOI)
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (IDPBLDHNHKB != other.IDPBLDHNHKB)
		{
			return false;
		}
		if (BMLDPGFFIIB != other.BMLDPGFFIIB)
		{
			return false;
		}
		if (HBFHJOIEBIE != other.HBFHJOIEBIE)
		{
			return false;
		}
		if (AIEHGFOCPBG != other.AIEHGFOCPBG)
		{
			return false;
		}
		if (!object.Equals(DJDPILOKDKO, other.DJDPILOKDKO))
		{
			return false;
		}
		if (IsFinish != other.IsFinish)
		{
			return false;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
		{
			return false;
		}
		if (!object.Equals(HEEAPOIPJMP, other.HEEAPOIPJMP))
		{
			return false;
		}
		if (!cKPKAPEIKIH_.Equals(other.cKPKAPEIKIH_))
		{
			return false;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
		{
			return false;
		}
		if (FAPFKFJIELE != other.FAPFKFJIELE)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (LOIDOGEENOB != other.LOIDOGEENOB)
		{
			return false;
		}
		if (OINIDCCNAOM != other.OINIDCCNAOM)
		{
			return false;
		}
		if (NNLEHIMNDBE != other.NNLEHIMNDBE)
		{
			return false;
		}
		if (PJINJJGOMMF != other.PJINJJGOMMF)
		{
			return false;
		}
		if (!object.Equals(JGHIBCLBLAG, other.JGHIBCLBLAG))
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
		if (DJMGKNPLBOI != 0)
		{
			num ^= DJMGKNPLBOI.GetHashCode();
		}
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (IDPBLDHNHKB != GCDMHAMCDHI.Gcgmcpmpjhd)
		{
			num ^= IDPBLDHNHKB.GetHashCode();
		}
		if (BMLDPGFFIIB != 0)
		{
			num ^= BMLDPGFFIIB.GetHashCode();
		}
		if (HBFHJOIEBIE != 0)
		{
			num ^= HBFHJOIEBIE.GetHashCode();
		}
		if (AIEHGFOCPBG != 0)
		{
			num ^= AIEHGFOCPBG.GetHashCode();
		}
		if (dJDPILOKDKO_ != null)
		{
			num ^= DJDPILOKDKO.GetHashCode();
		}
		if (IsFinish)
		{
			num ^= IsFinish.GetHashCode();
		}
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (hEEAPOIPJMP_ != null)
		{
			num ^= HEEAPOIPJMP.GetHashCode();
		}
		num ^= cKPKAPEIKIH_.GetHashCode();
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
		}
		if (FAPFKFJIELE != 0)
		{
			num ^= FAPFKFJIELE.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (LOIDOGEENOB != 0)
		{
			num ^= LOIDOGEENOB.GetHashCode();
		}
		if (OINIDCCNAOM != 0)
		{
			num ^= OINIDCCNAOM.GetHashCode();
		}
		if (NNLEHIMNDBE != 0)
		{
			num ^= NNLEHIMNDBE.GetHashCode();
		}
		if (PJINJJGOMMF != 0)
		{
			num ^= PJINJJGOMMF.GetHashCode();
		}
		if (jGHIBCLBLAG_ != null)
		{
			num ^= JGHIBCLBLAG.GetHashCode();
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
		if (DJMGKNPLBOI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DJMGKNPLBOI);
		}
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DifficultyLevel);
		}
		if (IDPBLDHNHKB != GCDMHAMCDHI.Gcgmcpmpjhd)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IDPBLDHNHKB);
		}
		if (BMLDPGFFIIB != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BMLDPGFFIIB);
		}
		if (HBFHJOIEBIE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HBFHJOIEBIE);
		}
		if (AIEHGFOCPBG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AIEHGFOCPBG);
		}
		if (dJDPILOKDKO_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DJDPILOKDKO);
		}
		if (IsFinish)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsFinish);
		}
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (hEEAPOIPJMP_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(HEEAPOIPJMP);
		}
		cKPKAPEIKIH_.WriteTo(ref output, _repeated_cKPKAPEIKIH_codec);
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(FEILNIKNPCB);
		}
		if (FAPFKFJIELE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FAPFKFJIELE);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(136, 25);
			output.WriteUInt32(ScoreId);
		}
		if (LOIDOGEENOB != 0)
		{
			output.WriteRawTag(168, 44);
			output.WriteUInt32(LOIDOGEENOB);
		}
		if (OINIDCCNAOM != 0)
		{
			output.WriteRawTag(248, 46);
			output.WriteUInt32(OINIDCCNAOM);
		}
		if (NNLEHIMNDBE != 0)
		{
			output.WriteRawTag(224, 61);
			output.WriteUInt32(NNLEHIMNDBE);
		}
		if (PJINJJGOMMF != 0)
		{
			output.WriteRawTag(136, 94);
			output.WriteUInt32(PJINJJGOMMF);
		}
		if (jGHIBCLBLAG_ != null)
		{
			output.WriteRawTag(194, 99);
			output.WriteMessage(JGHIBCLBLAG);
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
		if (DJMGKNPLBOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DJMGKNPLBOI);
		}
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (IDPBLDHNHKB != GCDMHAMCDHI.Gcgmcpmpjhd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IDPBLDHNHKB);
		}
		if (BMLDPGFFIIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMLDPGFFIIB);
		}
		if (HBFHJOIEBIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBFHJOIEBIE);
		}
		if (AIEHGFOCPBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AIEHGFOCPBG);
		}
		if (dJDPILOKDKO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DJDPILOKDKO);
		}
		if (IsFinish)
		{
			num += 2;
		}
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (hEEAPOIPJMP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HEEAPOIPJMP);
		}
		num += cKPKAPEIKIH_.CalculateSize(_repeated_cKPKAPEIKIH_codec);
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (FAPFKFJIELE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAPFKFJIELE);
		}
		if (ScoreId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (LOIDOGEENOB != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LOIDOGEENOB);
		}
		if (OINIDCCNAOM != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(OINIDCCNAOM);
		}
		if (NNLEHIMNDBE != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NNLEHIMNDBE);
		}
		if (PJINJJGOMMF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PJINJJGOMMF);
		}
		if (jGHIBCLBLAG_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JGHIBCLBLAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIILPHKLFEK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DJMGKNPLBOI != 0)
		{
			DJMGKNPLBOI = other.DJMGKNPLBOI;
		}
		if (other.DifficultyLevel != 0)
		{
			DifficultyLevel = other.DifficultyLevel;
		}
		if (other.IDPBLDHNHKB != GCDMHAMCDHI.Gcgmcpmpjhd)
		{
			IDPBLDHNHKB = other.IDPBLDHNHKB;
		}
		if (other.BMLDPGFFIIB != 0)
		{
			BMLDPGFFIIB = other.BMLDPGFFIIB;
		}
		if (other.HBFHJOIEBIE != 0)
		{
			HBFHJOIEBIE = other.HBFHJOIEBIE;
		}
		if (other.AIEHGFOCPBG != 0)
		{
			AIEHGFOCPBG = other.AIEHGFOCPBG;
		}
		if (other.dJDPILOKDKO_ != null)
		{
			if (dJDPILOKDKO_ == null)
			{
				DJDPILOKDKO = new LineupInfo();
			}
			DJDPILOKDKO.MergeFrom(other.DJDPILOKDKO);
		}
		if (other.IsFinish)
		{
			IsFinish = other.IsFinish;
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new CADKBOKEJMD();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
		}
		if (other.hEEAPOIPJMP_ != null)
		{
			if (hEEAPOIPJMP_ == null)
			{
				HEEAPOIPJMP = new ItemList();
			}
			HEEAPOIPJMP.MergeFrom(other.HEEAPOIPJMP);
		}
		cKPKAPEIKIH_.Add(other.cKPKAPEIKIH_);
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new DECAOHONNJG();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
		}
		if (other.FAPFKFJIELE != 0)
		{
			FAPFKFJIELE = other.FAPFKFJIELE;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.LOIDOGEENOB != 0)
		{
			LOIDOGEENOB = other.LOIDOGEENOB;
		}
		if (other.OINIDCCNAOM != 0)
		{
			OINIDCCNAOM = other.OINIDCCNAOM;
		}
		if (other.NNLEHIMNDBE != 0)
		{
			NNLEHIMNDBE = other.NNLEHIMNDBE;
		}
		if (other.PJINJJGOMMF != 0)
		{
			PJINJJGOMMF = other.PJINJJGOMMF;
		}
		if (other.jGHIBCLBLAG_ != null)
		{
			if (jGHIBCLBLAG_ == null)
			{
				JGHIBCLBLAG = new JBEENGDECOH();
			}
			JGHIBCLBLAG.MergeFrom(other.JGHIBCLBLAG);
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
				DJMGKNPLBOI = input.ReadUInt32();
				break;
			case 16u:
				DifficultyLevel = input.ReadUInt32();
				break;
			case 24u:
				IDPBLDHNHKB = (GCDMHAMCDHI)input.ReadEnum();
				break;
			case 40u:
				BMLDPGFFIIB = input.ReadUInt32();
				break;
			case 48u:
				HBFHJOIEBIE = input.ReadUInt32();
				break;
			case 56u:
				AIEHGFOCPBG = input.ReadUInt32();
				break;
			case 66u:
				if (dJDPILOKDKO_ == null)
				{
					DJDPILOKDKO = new LineupInfo();
				}
				input.ReadMessage(DJDPILOKDKO);
				break;
			case 80u:
				IsFinish = input.ReadBool();
				break;
			case 90u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new CADKBOKEJMD();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			case 98u:
				if (hEEAPOIPJMP_ == null)
				{
					HEEAPOIPJMP = new ItemList();
				}
				input.ReadMessage(HEEAPOIPJMP);
				break;
			case 104u:
			case 106u:
				cKPKAPEIKIH_.AddEntriesFrom(ref input, _repeated_cKPKAPEIKIH_codec);
				break;
			case 114u:
				if (fEILNIKNPCB_ == null)
				{
					FEILNIKNPCB = new DECAOHONNJG();
				}
				input.ReadMessage(FEILNIKNPCB);
				break;
			case 120u:
				FAPFKFJIELE = input.ReadUInt32();
				break;
			case 3208u:
				ScoreId = input.ReadUInt32();
				break;
			case 5672u:
				LOIDOGEENOB = input.ReadUInt32();
				break;
			case 6008u:
				OINIDCCNAOM = input.ReadUInt32();
				break;
			case 7904u:
				NNLEHIMNDBE = input.ReadUInt32();
				break;
			case 12040u:
				PJINJJGOMMF = input.ReadUInt32();
				break;
			case 12738u:
				if (jGHIBCLBLAG_ == null)
				{
					JGHIBCLBLAG = new JBEENGDECOH();
				}
				input.ReadMessage(JGHIBCLBLAG);
				break;
			}
		}
	}
}
