using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFAOIALEBOH : IMessage<DFAOIALEBOH>, IMessage, IEquatable<DFAOIALEBOH>, IDeepCloneable<DFAOIALEBOH>, IBufferMessage
{
	private static readonly MessageParser<DFAOIALEBOH> _parser = new MessageParser<DFAOIALEBOH>(() => new DFAOIALEBOH());

	private UnknownFieldSet _unknownFields;

	public const int FBMDOIAKCNBFieldNumber = 1;

	private uint fBMDOIAKCNB_;

	public const int GMMPLIHPJPAFieldNumber = 3;

	private uint gMMPLIHPJPA_;

	public const int GKPCGNCGDBEFieldNumber = 4;

	private uint gKPCGNCGDBE_;

	public const int FGALCHFOOIIFieldNumber = 5;

	private uint fGALCHFOOII_;

	public const int ECPPHFHJEPPFieldNumber = 6;

	private ChessRogueDiceType eCPPHFHJEPP_;

	public const int FKICFPCIGKBFieldNumber = 7;

	private uint fKICFPCIGKB_;

	public const int EFIPBLFLMGBFieldNumber = 9;

	private uint eFIPBLFLMGB_;

	public const int FKFMIDEMIOKFieldNumber = 11;

	private uint fKFMIDEMIOK_;

	public const int IEBCKHKLGNJFieldNumber = 13;

	private ChessRogueDiceStatus iEBCKHKLGNJ_;

	public const int KGMGFALDOJEFieldNumber = 14;

	private bool kGMGFALDOJE_;

	public const int OEMMBPPKHMHFieldNumber = 15;

	private uint oEMMBPPKHMH_;

	public const int LIJJFOCMNCFFieldNumber = 206;

	private DOIJNCLJGKO lIJJFOCMNCF_;

	public const int IMKMCKPBNIHFieldNumber = 214;

	private int iMKMCKPBNIH_;

	public const int MKKBCNHIJANFieldNumber = 1143;

	private static readonly FieldCodec<uint> _repeated_mKKBCNHIJAN_codec = FieldCodec.ForUInt32(9146u);

	private readonly RepeatedField<uint> mKKBCNHIJAN_ = new RepeatedField<uint>();

	public const int IDAGJPPLNLPFieldNumber = 1469;

	private MNCOPDNELMC iDAGJPPLNLP_;

	public const int BNFJPDOPIOAFieldNumber = 1866;

	private bool bNFJPDOPIOA_;

	public const int NDGFCDHENKOFieldNumber = 1906;

	private GLENEKHDKLJ nDGFCDHENKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFAOIALEBOH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFAOIALEBOHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBMDOIAKCNB
	{
		get
		{
			return fBMDOIAKCNB_;
		}
		set
		{
			fBMDOIAKCNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GMMPLIHPJPA
	{
		get
		{
			return gMMPLIHPJPA_;
		}
		set
		{
			gMMPLIHPJPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKPCGNCGDBE
	{
		get
		{
			return gKPCGNCGDBE_;
		}
		set
		{
			gKPCGNCGDBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FGALCHFOOII
	{
		get
		{
			return fGALCHFOOII_;
		}
		set
		{
			fGALCHFOOII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueDiceType ECPPHFHJEPP
	{
		get
		{
			return eCPPHFHJEPP_;
		}
		set
		{
			eCPPHFHJEPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKICFPCIGKB
	{
		get
		{
			return fKICFPCIGKB_;
		}
		set
		{
			fKICFPCIGKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EFIPBLFLMGB
	{
		get
		{
			return eFIPBLFLMGB_;
		}
		set
		{
			eFIPBLFLMGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKFMIDEMIOK
	{
		get
		{
			return fKFMIDEMIOK_;
		}
		set
		{
			fKFMIDEMIOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueDiceStatus IEBCKHKLGNJ
	{
		get
		{
			return iEBCKHKLGNJ_;
		}
		set
		{
			iEBCKHKLGNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KGMGFALDOJE
	{
		get
		{
			return kGMGFALDOJE_;
		}
		set
		{
			kGMGFALDOJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEMMBPPKHMH
	{
		get
		{
			return oEMMBPPKHMH_;
		}
		set
		{
			oEMMBPPKHMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOIJNCLJGKO LIJJFOCMNCF
	{
		get
		{
			return lIJJFOCMNCF_;
		}
		set
		{
			lIJJFOCMNCF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IMKMCKPBNIH
	{
		get
		{
			return iMKMCKPBNIH_;
		}
		set
		{
			iMKMCKPBNIH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MKKBCNHIJAN => mKKBCNHIJAN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNCOPDNELMC IDAGJPPLNLP
	{
		get
		{
			return iDAGJPPLNLP_;
		}
		set
		{
			iDAGJPPLNLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BNFJPDOPIOA
	{
		get
		{
			return bNFJPDOPIOA_;
		}
		set
		{
			bNFJPDOPIOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLENEKHDKLJ NDGFCDHENKO
	{
		get
		{
			return nDGFCDHENKO_;
		}
		set
		{
			nDGFCDHENKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAOIALEBOH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAOIALEBOH(DFAOIALEBOH other)
		: this()
	{
		fBMDOIAKCNB_ = other.fBMDOIAKCNB_;
		gMMPLIHPJPA_ = other.gMMPLIHPJPA_;
		gKPCGNCGDBE_ = other.gKPCGNCGDBE_;
		fGALCHFOOII_ = other.fGALCHFOOII_;
		eCPPHFHJEPP_ = other.eCPPHFHJEPP_;
		fKICFPCIGKB_ = other.fKICFPCIGKB_;
		eFIPBLFLMGB_ = other.eFIPBLFLMGB_;
		fKFMIDEMIOK_ = other.fKFMIDEMIOK_;
		iEBCKHKLGNJ_ = other.iEBCKHKLGNJ_;
		kGMGFALDOJE_ = other.kGMGFALDOJE_;
		oEMMBPPKHMH_ = other.oEMMBPPKHMH_;
		lIJJFOCMNCF_ = ((other.lIJJFOCMNCF_ != null) ? other.lIJJFOCMNCF_.Clone() : null);
		iMKMCKPBNIH_ = other.iMKMCKPBNIH_;
		mKKBCNHIJAN_ = other.mKKBCNHIJAN_.Clone();
		iDAGJPPLNLP_ = ((other.iDAGJPPLNLP_ != null) ? other.iDAGJPPLNLP_.Clone() : null);
		bNFJPDOPIOA_ = other.bNFJPDOPIOA_;
		nDGFCDHENKO_ = ((other.nDGFCDHENKO_ != null) ? other.nDGFCDHENKO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAOIALEBOH Clone()
	{
		return new DFAOIALEBOH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DFAOIALEBOH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFAOIALEBOH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FBMDOIAKCNB != other.FBMDOIAKCNB)
		{
			return false;
		}
		if (GMMPLIHPJPA != other.GMMPLIHPJPA)
		{
			return false;
		}
		if (GKPCGNCGDBE != other.GKPCGNCGDBE)
		{
			return false;
		}
		if (FGALCHFOOII != other.FGALCHFOOII)
		{
			return false;
		}
		if (ECPPHFHJEPP != other.ECPPHFHJEPP)
		{
			return false;
		}
		if (FKICFPCIGKB != other.FKICFPCIGKB)
		{
			return false;
		}
		if (EFIPBLFLMGB != other.EFIPBLFLMGB)
		{
			return false;
		}
		if (FKFMIDEMIOK != other.FKFMIDEMIOK)
		{
			return false;
		}
		if (IEBCKHKLGNJ != other.IEBCKHKLGNJ)
		{
			return false;
		}
		if (KGMGFALDOJE != other.KGMGFALDOJE)
		{
			return false;
		}
		if (OEMMBPPKHMH != other.OEMMBPPKHMH)
		{
			return false;
		}
		if (!object.Equals(LIJJFOCMNCF, other.LIJJFOCMNCF))
		{
			return false;
		}
		if (IMKMCKPBNIH != other.IMKMCKPBNIH)
		{
			return false;
		}
		if (!mKKBCNHIJAN_.Equals(other.mKKBCNHIJAN_))
		{
			return false;
		}
		if (!object.Equals(IDAGJPPLNLP, other.IDAGJPPLNLP))
		{
			return false;
		}
		if (BNFJPDOPIOA != other.BNFJPDOPIOA)
		{
			return false;
		}
		if (!object.Equals(NDGFCDHENKO, other.NDGFCDHENKO))
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
		if (FBMDOIAKCNB != 0)
		{
			num ^= FBMDOIAKCNB.GetHashCode();
		}
		if (GMMPLIHPJPA != 0)
		{
			num ^= GMMPLIHPJPA.GetHashCode();
		}
		if (GKPCGNCGDBE != 0)
		{
			num ^= GKPCGNCGDBE.GetHashCode();
		}
		if (FGALCHFOOII != 0)
		{
			num ^= FGALCHFOOII.GetHashCode();
		}
		if (ECPPHFHJEPP != ChessRogueDiceType.HbcokdijmbkIcjlghlokfg)
		{
			num ^= ECPPHFHJEPP.GetHashCode();
		}
		if (FKICFPCIGKB != 0)
		{
			num ^= FKICFPCIGKB.GetHashCode();
		}
		if (EFIPBLFLMGB != 0)
		{
			num ^= EFIPBLFLMGB.GetHashCode();
		}
		if (FKFMIDEMIOK != 0)
		{
			num ^= FKFMIDEMIOK.GetHashCode();
		}
		if (IEBCKHKLGNJ != ChessRogueDiceStatus.HphbegjdiidEobbbbehnnh)
		{
			num ^= IEBCKHKLGNJ.GetHashCode();
		}
		if (KGMGFALDOJE)
		{
			num ^= KGMGFALDOJE.GetHashCode();
		}
		if (OEMMBPPKHMH != 0)
		{
			num ^= OEMMBPPKHMH.GetHashCode();
		}
		if (lIJJFOCMNCF_ != null)
		{
			num ^= LIJJFOCMNCF.GetHashCode();
		}
		if (IMKMCKPBNIH != 0)
		{
			num ^= IMKMCKPBNIH.GetHashCode();
		}
		num ^= mKKBCNHIJAN_.GetHashCode();
		if (iDAGJPPLNLP_ != null)
		{
			num ^= IDAGJPPLNLP.GetHashCode();
		}
		if (BNFJPDOPIOA)
		{
			num ^= BNFJPDOPIOA.GetHashCode();
		}
		if (nDGFCDHENKO_ != null)
		{
			num ^= NDGFCDHENKO.GetHashCode();
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
		if (FBMDOIAKCNB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FBMDOIAKCNB);
		}
		if (GMMPLIHPJPA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GMMPLIHPJPA);
		}
		if (GKPCGNCGDBE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GKPCGNCGDBE);
		}
		if (FGALCHFOOII != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FGALCHFOOII);
		}
		if (ECPPHFHJEPP != ChessRogueDiceType.HbcokdijmbkIcjlghlokfg)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)ECPPHFHJEPP);
		}
		if (FKICFPCIGKB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FKICFPCIGKB);
		}
		if (EFIPBLFLMGB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EFIPBLFLMGB);
		}
		if (FKFMIDEMIOK != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FKFMIDEMIOK);
		}
		if (IEBCKHKLGNJ != ChessRogueDiceStatus.HphbegjdiidEobbbbehnnh)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)IEBCKHKLGNJ);
		}
		if (KGMGFALDOJE)
		{
			output.WriteRawTag(112);
			output.WriteBool(KGMGFALDOJE);
		}
		if (OEMMBPPKHMH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OEMMBPPKHMH);
		}
		if (lIJJFOCMNCF_ != null)
		{
			output.WriteRawTag(242, 12);
			output.WriteMessage(LIJJFOCMNCF);
		}
		if (IMKMCKPBNIH != 0)
		{
			output.WriteRawTag(176, 13);
			output.WriteInt32(IMKMCKPBNIH);
		}
		mKKBCNHIJAN_.WriteTo(ref output, _repeated_mKKBCNHIJAN_codec);
		if (iDAGJPPLNLP_ != null)
		{
			output.WriteRawTag(234, 91);
			output.WriteMessage(IDAGJPPLNLP);
		}
		if (BNFJPDOPIOA)
		{
			output.WriteRawTag(208, 116);
			output.WriteBool(BNFJPDOPIOA);
		}
		if (nDGFCDHENKO_ != null)
		{
			output.WriteRawTag(146, 119);
			output.WriteMessage(NDGFCDHENKO);
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
		if (FBMDOIAKCNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBMDOIAKCNB);
		}
		if (GMMPLIHPJPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GMMPLIHPJPA);
		}
		if (GKPCGNCGDBE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKPCGNCGDBE);
		}
		if (FGALCHFOOII != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FGALCHFOOII);
		}
		if (ECPPHFHJEPP != ChessRogueDiceType.HbcokdijmbkIcjlghlokfg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ECPPHFHJEPP);
		}
		if (FKICFPCIGKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKICFPCIGKB);
		}
		if (EFIPBLFLMGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFIPBLFLMGB);
		}
		if (FKFMIDEMIOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKFMIDEMIOK);
		}
		if (IEBCKHKLGNJ != ChessRogueDiceStatus.HphbegjdiidEobbbbehnnh)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IEBCKHKLGNJ);
		}
		if (KGMGFALDOJE)
		{
			num += 2;
		}
		if (OEMMBPPKHMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEMMBPPKHMH);
		}
		if (lIJJFOCMNCF_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LIJJFOCMNCF);
		}
		if (IMKMCKPBNIH != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IMKMCKPBNIH);
		}
		num += mKKBCNHIJAN_.CalculateSize(_repeated_mKKBCNHIJAN_codec);
		if (iDAGJPPLNLP_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IDAGJPPLNLP);
		}
		if (BNFJPDOPIOA)
		{
			num += 3;
		}
		if (nDGFCDHENKO_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NDGFCDHENKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DFAOIALEBOH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FBMDOIAKCNB != 0)
		{
			FBMDOIAKCNB = other.FBMDOIAKCNB;
		}
		if (other.GMMPLIHPJPA != 0)
		{
			GMMPLIHPJPA = other.GMMPLIHPJPA;
		}
		if (other.GKPCGNCGDBE != 0)
		{
			GKPCGNCGDBE = other.GKPCGNCGDBE;
		}
		if (other.FGALCHFOOII != 0)
		{
			FGALCHFOOII = other.FGALCHFOOII;
		}
		if (other.ECPPHFHJEPP != ChessRogueDiceType.HbcokdijmbkIcjlghlokfg)
		{
			ECPPHFHJEPP = other.ECPPHFHJEPP;
		}
		if (other.FKICFPCIGKB != 0)
		{
			FKICFPCIGKB = other.FKICFPCIGKB;
		}
		if (other.EFIPBLFLMGB != 0)
		{
			EFIPBLFLMGB = other.EFIPBLFLMGB;
		}
		if (other.FKFMIDEMIOK != 0)
		{
			FKFMIDEMIOK = other.FKFMIDEMIOK;
		}
		if (other.IEBCKHKLGNJ != ChessRogueDiceStatus.HphbegjdiidEobbbbehnnh)
		{
			IEBCKHKLGNJ = other.IEBCKHKLGNJ;
		}
		if (other.KGMGFALDOJE)
		{
			KGMGFALDOJE = other.KGMGFALDOJE;
		}
		if (other.OEMMBPPKHMH != 0)
		{
			OEMMBPPKHMH = other.OEMMBPPKHMH;
		}
		if (other.lIJJFOCMNCF_ != null)
		{
			if (lIJJFOCMNCF_ == null)
			{
				LIJJFOCMNCF = new DOIJNCLJGKO();
			}
			LIJJFOCMNCF.MergeFrom(other.LIJJFOCMNCF);
		}
		if (other.IMKMCKPBNIH != 0)
		{
			IMKMCKPBNIH = other.IMKMCKPBNIH;
		}
		mKKBCNHIJAN_.Add(other.mKKBCNHIJAN_);
		if (other.iDAGJPPLNLP_ != null)
		{
			if (iDAGJPPLNLP_ == null)
			{
				IDAGJPPLNLP = new MNCOPDNELMC();
			}
			IDAGJPPLNLP.MergeFrom(other.IDAGJPPLNLP);
		}
		if (other.BNFJPDOPIOA)
		{
			BNFJPDOPIOA = other.BNFJPDOPIOA;
		}
		if (other.nDGFCDHENKO_ != null)
		{
			if (nDGFCDHENKO_ == null)
			{
				NDGFCDHENKO = new GLENEKHDKLJ();
			}
			NDGFCDHENKO.MergeFrom(other.NDGFCDHENKO);
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
				FBMDOIAKCNB = input.ReadUInt32();
				break;
			case 24u:
				GMMPLIHPJPA = input.ReadUInt32();
				break;
			case 32u:
				GKPCGNCGDBE = input.ReadUInt32();
				break;
			case 40u:
				FGALCHFOOII = input.ReadUInt32();
				break;
			case 48u:
				ECPPHFHJEPP = (ChessRogueDiceType)input.ReadEnum();
				break;
			case 56u:
				FKICFPCIGKB = input.ReadUInt32();
				break;
			case 72u:
				EFIPBLFLMGB = input.ReadUInt32();
				break;
			case 88u:
				FKFMIDEMIOK = input.ReadUInt32();
				break;
			case 104u:
				IEBCKHKLGNJ = (ChessRogueDiceStatus)input.ReadEnum();
				break;
			case 112u:
				KGMGFALDOJE = input.ReadBool();
				break;
			case 120u:
				OEMMBPPKHMH = input.ReadUInt32();
				break;
			case 1650u:
				if (lIJJFOCMNCF_ == null)
				{
					LIJJFOCMNCF = new DOIJNCLJGKO();
				}
				input.ReadMessage(LIJJFOCMNCF);
				break;
			case 1712u:
				IMKMCKPBNIH = input.ReadInt32();
				break;
			case 9144u:
			case 9146u:
				mKKBCNHIJAN_.AddEntriesFrom(ref input, _repeated_mKKBCNHIJAN_codec);
				break;
			case 11754u:
				if (iDAGJPPLNLP_ == null)
				{
					IDAGJPPLNLP = new MNCOPDNELMC();
				}
				input.ReadMessage(IDAGJPPLNLP);
				break;
			case 14928u:
				BNFJPDOPIOA = input.ReadBool();
				break;
			case 15250u:
				if (nDGFCDHENKO_ == null)
				{
					NDGFCDHENKO = new GLENEKHDKLJ();
				}
				input.ReadMessage(NDGFCDHENKO);
				break;
			}
		}
	}
}
