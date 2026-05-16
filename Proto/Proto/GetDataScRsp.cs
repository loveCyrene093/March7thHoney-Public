using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetDataScRsp : IMessage<GetDataScRsp>, IMessage, IEquatable<GetDataScRsp>, IDeepCloneable<GetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetDataScRsp> _parser = new MessageParser<GetDataScRsp>(() => new GetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int BMGAKKNAKFDFieldNumber = 2;

	private uint bMGAKKNAKFD_;

	public const int NJDBIEMAOAAFieldNumber = 3;

	private uint nJDBIEMAOAA_;

	public const int GCENJMPLHMCFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_gCENJMPLHMC_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> gCENJMPLHMC_ = new RepeatedField<uint>();

	public const int PKHBAMILIOIFieldNumber = 5;

	private uint pKHBAMILIOI_;

	public const int LEGMOJLDECHFieldNumber = 6;

	private GHJIFOHJOEM lEGMOJLDECH_;

	public const int HMABMKKKHNBFieldNumber = 7;

	private static readonly FieldCodec<LHEDJAIOHOE> _repeated_hMABMKKKHNB_codec = FieldCodec.ForMessage(58u, LHEDJAIOHOE.Parser);

	private readonly RepeatedField<LHEDJAIOHOE> hMABMKKKHNB_ = new RepeatedField<LHEDJAIOHOE>();

	public const int BBOJLIEALDBFieldNumber = 8;

	private uint bBOJLIEALDB_;

	public const int HFJJJKEBMEPFieldNumber = 9;

	private uint hFJJJKEBMEP_;

	public const int BCLLCBDEPEPFieldNumber = 10;

	private uint bCLLCBDEPEP_;

	public const int LineupFieldNumber = 11;

	private FHCCCHJHHKL lineup_;

	public const int JIICJOKLNLGFieldNumber = 13;

	private uint jIICJOKLNLG_;

	public const int FHHMACHPMGAFieldNumber = 14;

	private uint fHHMACHPMGA_;

	public const int IJGALCOFLLAFieldNumber = 15;

	private static readonly FieldCodec<LEHNHDLEMHL> _repeated_iJGALCOFLLA_codec = FieldCodec.ForMessage(122u, LEHNHDLEMHL.Parser);

	private readonly RepeatedField<LEHNHDLEMHL> iJGALCOFLLA_ = new RepeatedField<LEHNHDLEMHL>();

	public const int ACJJCPCPFDNFieldNumber = 596;

	private uint aCJJCPCPFDN_;

	public const int NKBDDIDFPNEFieldNumber = 639;

	private uint nKBDDIDFPNE_;

	public const int NCBPOOCCCANFieldNumber = 927;

	private uint nCBPOOCCCAN_;

	public const int PBAFFLDBALEFieldNumber = 1347;

	private uint pBAFFLDBALE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMGAKKNAKFD
	{
		get
		{
			return bMGAKKNAKFD_;
		}
		set
		{
			bMGAKKNAKFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJDBIEMAOAA
	{
		get
		{
			return nJDBIEMAOAA_;
		}
		set
		{
			nJDBIEMAOAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GCENJMPLHMC => gCENJMPLHMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKHBAMILIOI
	{
		get
		{
			return pKHBAMILIOI_;
		}
		set
		{
			pKHBAMILIOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHJIFOHJOEM LEGMOJLDECH
	{
		get
		{
			return lEGMOJLDECH_;
		}
		set
		{
			lEGMOJLDECH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHEDJAIOHOE> HMABMKKKHNB => hMABMKKKHNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BBOJLIEALDB
	{
		get
		{
			return bBOJLIEALDB_;
		}
		set
		{
			bBOJLIEALDB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFJJJKEBMEP
	{
		get
		{
			return hFJJJKEBMEP_;
		}
		set
		{
			hFJJJKEBMEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCLLCBDEPEP
	{
		get
		{
			return bCLLCBDEPEP_;
		}
		set
		{
			bCLLCBDEPEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHCCCHJHHKL Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JIICJOKLNLG
	{
		get
		{
			return jIICJOKLNLG_;
		}
		set
		{
			jIICJOKLNLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHHMACHPMGA
	{
		get
		{
			return fHHMACHPMGA_;
		}
		set
		{
			fHHMACHPMGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LEHNHDLEMHL> IJGALCOFLLA => iJGALCOFLLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACJJCPCPFDN
	{
		get
		{
			return aCJJCPCPFDN_;
		}
		set
		{
			aCJJCPCPFDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKBDDIDFPNE
	{
		get
		{
			return nKBDDIDFPNE_;
		}
		set
		{
			nKBDDIDFPNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCBPOOCCCAN
	{
		get
		{
			return nCBPOOCCCAN_;
		}
		set
		{
			nCBPOOCCCAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBAFFLDBALE
	{
		get
		{
			return pBAFFLDBALE_;
		}
		set
		{
			pBAFFLDBALE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDataScRsp(GetDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		bMGAKKNAKFD_ = other.bMGAKKNAKFD_;
		nJDBIEMAOAA_ = other.nJDBIEMAOAA_;
		gCENJMPLHMC_ = other.gCENJMPLHMC_.Clone();
		pKHBAMILIOI_ = other.pKHBAMILIOI_;
		lEGMOJLDECH_ = other.lEGMOJLDECH_;
		hMABMKKKHNB_ = other.hMABMKKKHNB_.Clone();
		bBOJLIEALDB_ = other.bBOJLIEALDB_;
		hFJJJKEBMEP_ = other.hFJJJKEBMEP_;
		bCLLCBDEPEP_ = other.bCLLCBDEPEP_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		jIICJOKLNLG_ = other.jIICJOKLNLG_;
		fHHMACHPMGA_ = other.fHHMACHPMGA_;
		iJGALCOFLLA_ = other.iJGALCOFLLA_.Clone();
		aCJJCPCPFDN_ = other.aCJJCPCPFDN_;
		nKBDDIDFPNE_ = other.nKBDDIDFPNE_;
		nCBPOOCCCAN_ = other.nCBPOOCCCAN_;
		pBAFFLDBALE_ = other.pBAFFLDBALE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDataScRsp Clone()
	{
		return new GetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (BMGAKKNAKFD != other.BMGAKKNAKFD)
		{
			return false;
		}
		if (NJDBIEMAOAA != other.NJDBIEMAOAA)
		{
			return false;
		}
		if (!gCENJMPLHMC_.Equals(other.gCENJMPLHMC_))
		{
			return false;
		}
		if (PKHBAMILIOI != other.PKHBAMILIOI)
		{
			return false;
		}
		if (LEGMOJLDECH != other.LEGMOJLDECH)
		{
			return false;
		}
		if (!hMABMKKKHNB_.Equals(other.hMABMKKKHNB_))
		{
			return false;
		}
		if (BBOJLIEALDB != other.BBOJLIEALDB)
		{
			return false;
		}
		if (HFJJJKEBMEP != other.HFJJJKEBMEP)
		{
			return false;
		}
		if (BCLLCBDEPEP != other.BCLLCBDEPEP)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (JIICJOKLNLG != other.JIICJOKLNLG)
		{
			return false;
		}
		if (FHHMACHPMGA != other.FHHMACHPMGA)
		{
			return false;
		}
		if (!iJGALCOFLLA_.Equals(other.iJGALCOFLLA_))
		{
			return false;
		}
		if (ACJJCPCPFDN != other.ACJJCPCPFDN)
		{
			return false;
		}
		if (NKBDDIDFPNE != other.NKBDDIDFPNE)
		{
			return false;
		}
		if (NCBPOOCCCAN != other.NCBPOOCCCAN)
		{
			return false;
		}
		if (PBAFFLDBALE != other.PBAFFLDBALE)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (BMGAKKNAKFD != 0)
		{
			num ^= BMGAKKNAKFD.GetHashCode();
		}
		if (NJDBIEMAOAA != 0)
		{
			num ^= NJDBIEMAOAA.GetHashCode();
		}
		num ^= gCENJMPLHMC_.GetHashCode();
		if (PKHBAMILIOI != 0)
		{
			num ^= PKHBAMILIOI.GetHashCode();
		}
		if (LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			num ^= LEGMOJLDECH.GetHashCode();
		}
		num ^= hMABMKKKHNB_.GetHashCode();
		if (BBOJLIEALDB != 0)
		{
			num ^= BBOJLIEALDB.GetHashCode();
		}
		if (HFJJJKEBMEP != 0)
		{
			num ^= HFJJJKEBMEP.GetHashCode();
		}
		if (BCLLCBDEPEP != 0)
		{
			num ^= BCLLCBDEPEP.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (JIICJOKLNLG != 0)
		{
			num ^= JIICJOKLNLG.GetHashCode();
		}
		if (FHHMACHPMGA != 0)
		{
			num ^= FHHMACHPMGA.GetHashCode();
		}
		num ^= iJGALCOFLLA_.GetHashCode();
		if (ACJJCPCPFDN != 0)
		{
			num ^= ACJJCPCPFDN.GetHashCode();
		}
		if (NKBDDIDFPNE != 0)
		{
			num ^= NKBDDIDFPNE.GetHashCode();
		}
		if (NCBPOOCCCAN != 0)
		{
			num ^= NCBPOOCCCAN.GetHashCode();
		}
		if (PBAFFLDBALE != 0)
		{
			num ^= PBAFFLDBALE.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (BMGAKKNAKFD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BMGAKKNAKFD);
		}
		if (NJDBIEMAOAA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NJDBIEMAOAA);
		}
		gCENJMPLHMC_.WriteTo(ref output, _repeated_gCENJMPLHMC_codec);
		if (PKHBAMILIOI != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PKHBAMILIOI);
		}
		if (LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)LEGMOJLDECH);
		}
		hMABMKKKHNB_.WriteTo(ref output, _repeated_hMABMKKKHNB_codec);
		if (BBOJLIEALDB != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BBOJLIEALDB);
		}
		if (HFJJJKEBMEP != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HFJJJKEBMEP);
		}
		if (BCLLCBDEPEP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BCLLCBDEPEP);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Lineup);
		}
		if (JIICJOKLNLG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JIICJOKLNLG);
		}
		if (FHHMACHPMGA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FHHMACHPMGA);
		}
		iJGALCOFLLA_.WriteTo(ref output, _repeated_iJGALCOFLLA_codec);
		if (ACJJCPCPFDN != 0)
		{
			output.WriteRawTag(160, 37);
			output.WriteUInt32(ACJJCPCPFDN);
		}
		if (NKBDDIDFPNE != 0)
		{
			output.WriteRawTag(248, 39);
			output.WriteUInt32(NKBDDIDFPNE);
		}
		if (NCBPOOCCCAN != 0)
		{
			output.WriteRawTag(248, 57);
			output.WriteUInt32(NCBPOOCCCAN);
		}
		if (PBAFFLDBALE != 0)
		{
			output.WriteRawTag(152, 84);
			output.WriteUInt32(PBAFFLDBALE);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (BMGAKKNAKFD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMGAKKNAKFD);
		}
		if (NJDBIEMAOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJDBIEMAOAA);
		}
		num += gCENJMPLHMC_.CalculateSize(_repeated_gCENJMPLHMC_codec);
		if (PKHBAMILIOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKHBAMILIOI);
		}
		if (LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LEGMOJLDECH);
		}
		num += hMABMKKKHNB_.CalculateSize(_repeated_hMABMKKKHNB_codec);
		if (BBOJLIEALDB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BBOJLIEALDB);
		}
		if (HFJJJKEBMEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFJJJKEBMEP);
		}
		if (BCLLCBDEPEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCLLCBDEPEP);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (JIICJOKLNLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JIICJOKLNLG);
		}
		if (FHHMACHPMGA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHHMACHPMGA);
		}
		num += iJGALCOFLLA_.CalculateSize(_repeated_iJGALCOFLLA_codec);
		if (ACJJCPCPFDN != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ACJJCPCPFDN);
		}
		if (NKBDDIDFPNE != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NKBDDIDFPNE);
		}
		if (NCBPOOCCCAN != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NCBPOOCCCAN);
		}
		if (PBAFFLDBALE != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PBAFFLDBALE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.BMGAKKNAKFD != 0)
		{
			BMGAKKNAKFD = other.BMGAKKNAKFD;
		}
		if (other.NJDBIEMAOAA != 0)
		{
			NJDBIEMAOAA = other.NJDBIEMAOAA;
		}
		gCENJMPLHMC_.Add(other.gCENJMPLHMC_);
		if (other.PKHBAMILIOI != 0)
		{
			PKHBAMILIOI = other.PKHBAMILIOI;
		}
		if (other.LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			LEGMOJLDECH = other.LEGMOJLDECH;
		}
		hMABMKKKHNB_.Add(other.hMABMKKKHNB_);
		if (other.BBOJLIEALDB != 0)
		{
			BBOJLIEALDB = other.BBOJLIEALDB;
		}
		if (other.HFJJJKEBMEP != 0)
		{
			HFJJJKEBMEP = other.HFJJJKEBMEP;
		}
		if (other.BCLLCBDEPEP != 0)
		{
			BCLLCBDEPEP = other.BCLLCBDEPEP;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new FHCCCHJHHKL();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.JIICJOKLNLG != 0)
		{
			JIICJOKLNLG = other.JIICJOKLNLG;
		}
		if (other.FHHMACHPMGA != 0)
		{
			FHHMACHPMGA = other.FHHMACHPMGA;
		}
		iJGALCOFLLA_.Add(other.iJGALCOFLLA_);
		if (other.ACJJCPCPFDN != 0)
		{
			ACJJCPCPFDN = other.ACJJCPCPFDN;
		}
		if (other.NKBDDIDFPNE != 0)
		{
			NKBDDIDFPNE = other.NKBDDIDFPNE;
		}
		if (other.NCBPOOCCCAN != 0)
		{
			NCBPOOCCCAN = other.NCBPOOCCCAN;
		}
		if (other.PBAFFLDBALE != 0)
		{
			PBAFFLDBALE = other.PBAFFLDBALE;
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
				Retcode = input.ReadUInt32();
				break;
			case 16u:
				BMGAKKNAKFD = input.ReadUInt32();
				break;
			case 24u:
				NJDBIEMAOAA = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				gCENJMPLHMC_.AddEntriesFrom(ref input, _repeated_gCENJMPLHMC_codec);
				break;
			case 40u:
				PKHBAMILIOI = input.ReadUInt32();
				break;
			case 48u:
				LEGMOJLDECH = (GHJIFOHJOEM)input.ReadEnum();
				break;
			case 58u:
				hMABMKKKHNB_.AddEntriesFrom(ref input, _repeated_hMABMKKKHNB_codec);
				break;
			case 64u:
				BBOJLIEALDB = input.ReadUInt32();
				break;
			case 72u:
				HFJJJKEBMEP = input.ReadUInt32();
				break;
			case 80u:
				BCLLCBDEPEP = input.ReadUInt32();
				break;
			case 90u:
				if (lineup_ == null)
				{
					Lineup = new FHCCCHJHHKL();
				}
				input.ReadMessage(Lineup);
				break;
			case 104u:
				JIICJOKLNLG = input.ReadUInt32();
				break;
			case 112u:
				FHHMACHPMGA = input.ReadUInt32();
				break;
			case 122u:
				iJGALCOFLLA_.AddEntriesFrom(ref input, _repeated_iJGALCOFLLA_codec);
				break;
			case 4768u:
				ACJJCPCPFDN = input.ReadUInt32();
				break;
			case 5112u:
				NKBDDIDFPNE = input.ReadUInt32();
				break;
			case 7416u:
				NCBPOOCCCAN = input.ReadUInt32();
				break;
			case 10776u:
				PBAFFLDBALE = input.ReadUInt32();
				break;
			}
		}
	}
}
