using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraFinishRound : IMessage<ChimeraFinishRound>, IMessage, IEquatable<ChimeraFinishRound>, IDeepCloneable<ChimeraFinishRound>, IBufferMessage
{
	private static readonly MessageParser<ChimeraFinishRound> _parser = new MessageParser<ChimeraFinishRound>(() => new ChimeraFinishRound());

	private UnknownFieldSet _unknownFields;

	public const int ACJJCPCPFDNFieldNumber = 1;

	private uint aCJJCPCPFDN_;

	public const int EndReasonFieldNumber = 2;

	private ChimeraRoundWorkEndReason endReason_;

	public const int LEGMOJLDECHFieldNumber = 3;

	private GHJIFOHJOEM lEGMOJLDECH_;

	public const int MAMLPGPOHNEFieldNumber = 4;

	private static readonly FieldCodec<LEHNHDLEMHL> _repeated_mAMLPGPOHNE_codec = FieldCodec.ForMessage(34u, LEHNHDLEMHL.Parser);

	private readonly RepeatedField<LEHNHDLEMHL> mAMLPGPOHNE_ = new RepeatedField<LEHNHDLEMHL>();

	public const int PGEGMMBINIDFieldNumber = 5;

	private bool pGEGMMBINID_;

	public const int NFLPMLGBKDFFieldNumber = 6;

	private bool nFLPMLGBKDF_;

	public const int BMGAKKNAKFDFieldNumber = 7;

	private uint bMGAKKNAKFD_;

	public const int BCLLCBDEPEPFieldNumber = 8;

	private uint bCLLCBDEPEP_;

	public const int GCENJMPLHMCFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_gCENJMPLHMC_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> gCENJMPLHMC_ = new RepeatedField<uint>();

	public const int BBOJLIEALDBFieldNumber = 10;

	private uint bBOJLIEALDB_;

	public const int NJDBIEMAOAAFieldNumber = 11;

	private uint nJDBIEMAOAA_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int DMLLCPJFPNFFieldNumber = 13;

	private static readonly MapField<uint, BCMMLADBEAM>.Codec _map_dMLLCPJFPNF_codec = new MapField<uint, BCMMLADBEAM>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, BCMMLADBEAM.Parser), 106u);

	private readonly MapField<uint, BCMMLADBEAM> dMLLCPJFPNF_ = new MapField<uint, BCMMLADBEAM>();

	public const int HBMIGMJBCNGFieldNumber = 14;

	private static readonly MapField<uint, FMGJFLEPDBB>.Codec _map_hBMIGMJBCNG_codec = new MapField<uint, FMGJFLEPDBB>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, FMGJFLEPDBB.Parser), 114u);

	private readonly MapField<uint, FMGJFLEPDBB> hBMIGMJBCNG_ = new MapField<uint, FMGJFLEPDBB>();

	public const int HMABMKKKHNBFieldNumber = 15;

	private static readonly FieldCodec<LHEDJAIOHOE> _repeated_hMABMKKKHNB_codec = FieldCodec.ForMessage(122u, LHEDJAIOHOE.Parser);

	private readonly RepeatedField<LHEDJAIOHOE> hMABMKKKHNB_ = new RepeatedField<LHEDJAIOHOE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraFinishRound> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraFinishRoundReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ChimeraRoundWorkEndReason EndReason
	{
		get
		{
			return endReason_;
		}
		set
		{
			endReason_ = value;
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
	public RepeatedField<LEHNHDLEMHL> MAMLPGPOHNE => mAMLPGPOHNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PGEGMMBINID
	{
		get
		{
			return pGEGMMBINID_;
		}
		set
		{
			pGEGMMBINID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NFLPMLGBKDF
	{
		get
		{
			return nFLPMLGBKDF_;
		}
		set
		{
			nFLPMLGBKDF_ = value;
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
	public RepeatedField<uint> GCENJMPLHMC => gCENJMPLHMC_;

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
	public MapField<uint, BCMMLADBEAM> DMLLCPJFPNF => dMLLCPJFPNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, FMGJFLEPDBB> HBMIGMJBCNG => hBMIGMJBCNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHEDJAIOHOE> HMABMKKKHNB => hMABMKKKHNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishRound()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishRound(ChimeraFinishRound other)
		: this()
	{
		aCJJCPCPFDN_ = other.aCJJCPCPFDN_;
		endReason_ = other.endReason_;
		lEGMOJLDECH_ = other.lEGMOJLDECH_;
		mAMLPGPOHNE_ = other.mAMLPGPOHNE_.Clone();
		pGEGMMBINID_ = other.pGEGMMBINID_;
		nFLPMLGBKDF_ = other.nFLPMLGBKDF_;
		bMGAKKNAKFD_ = other.bMGAKKNAKFD_;
		bCLLCBDEPEP_ = other.bCLLCBDEPEP_;
		gCENJMPLHMC_ = other.gCENJMPLHMC_.Clone();
		bBOJLIEALDB_ = other.bBOJLIEALDB_;
		nJDBIEMAOAA_ = other.nJDBIEMAOAA_;
		retcode_ = other.retcode_;
		dMLLCPJFPNF_ = other.dMLLCPJFPNF_.Clone();
		hBMIGMJBCNG_ = other.hBMIGMJBCNG_.Clone();
		hMABMKKKHNB_ = other.hMABMKKKHNB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishRound Clone()
	{
		return new ChimeraFinishRound(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraFinishRound);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraFinishRound other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ACJJCPCPFDN != other.ACJJCPCPFDN)
		{
			return false;
		}
		if (EndReason != other.EndReason)
		{
			return false;
		}
		if (LEGMOJLDECH != other.LEGMOJLDECH)
		{
			return false;
		}
		if (!mAMLPGPOHNE_.Equals(other.mAMLPGPOHNE_))
		{
			return false;
		}
		if (PGEGMMBINID != other.PGEGMMBINID)
		{
			return false;
		}
		if (NFLPMLGBKDF != other.NFLPMLGBKDF)
		{
			return false;
		}
		if (BMGAKKNAKFD != other.BMGAKKNAKFD)
		{
			return false;
		}
		if (BCLLCBDEPEP != other.BCLLCBDEPEP)
		{
			return false;
		}
		if (!gCENJMPLHMC_.Equals(other.gCENJMPLHMC_))
		{
			return false;
		}
		if (BBOJLIEALDB != other.BBOJLIEALDB)
		{
			return false;
		}
		if (NJDBIEMAOAA != other.NJDBIEMAOAA)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!DMLLCPJFPNF.Equals(other.DMLLCPJFPNF))
		{
			return false;
		}
		if (!HBMIGMJBCNG.Equals(other.HBMIGMJBCNG))
		{
			return false;
		}
		if (!hMABMKKKHNB_.Equals(other.hMABMKKKHNB_))
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
		if (ACJJCPCPFDN != 0)
		{
			num ^= ACJJCPCPFDN.GetHashCode();
		}
		if (EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			num ^= EndReason.GetHashCode();
		}
		if (LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			num ^= LEGMOJLDECH.GetHashCode();
		}
		num ^= mAMLPGPOHNE_.GetHashCode();
		if (PGEGMMBINID)
		{
			num ^= PGEGMMBINID.GetHashCode();
		}
		if (NFLPMLGBKDF)
		{
			num ^= NFLPMLGBKDF.GetHashCode();
		}
		if (BMGAKKNAKFD != 0)
		{
			num ^= BMGAKKNAKFD.GetHashCode();
		}
		if (BCLLCBDEPEP != 0)
		{
			num ^= BCLLCBDEPEP.GetHashCode();
		}
		num ^= gCENJMPLHMC_.GetHashCode();
		if (BBOJLIEALDB != 0)
		{
			num ^= BBOJLIEALDB.GetHashCode();
		}
		if (NJDBIEMAOAA != 0)
		{
			num ^= NJDBIEMAOAA.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= DMLLCPJFPNF.GetHashCode();
		num ^= HBMIGMJBCNG.GetHashCode();
		num ^= hMABMKKKHNB_.GetHashCode();
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
		if (ACJJCPCPFDN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ACJJCPCPFDN);
		}
		if (EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EndReason);
		}
		if (LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LEGMOJLDECH);
		}
		mAMLPGPOHNE_.WriteTo(ref output, _repeated_mAMLPGPOHNE_codec);
		if (PGEGMMBINID)
		{
			output.WriteRawTag(40);
			output.WriteBool(PGEGMMBINID);
		}
		if (NFLPMLGBKDF)
		{
			output.WriteRawTag(48);
			output.WriteBool(NFLPMLGBKDF);
		}
		if (BMGAKKNAKFD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BMGAKKNAKFD);
		}
		if (BCLLCBDEPEP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BCLLCBDEPEP);
		}
		gCENJMPLHMC_.WriteTo(ref output, _repeated_gCENJMPLHMC_codec);
		if (BBOJLIEALDB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BBOJLIEALDB);
		}
		if (NJDBIEMAOAA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NJDBIEMAOAA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		dMLLCPJFPNF_.WriteTo(ref output, _map_dMLLCPJFPNF_codec);
		hBMIGMJBCNG_.WriteTo(ref output, _map_hBMIGMJBCNG_codec);
		hMABMKKKHNB_.WriteTo(ref output, _repeated_hMABMKKKHNB_codec);
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
		if (ACJJCPCPFDN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACJJCPCPFDN);
		}
		if (EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndReason);
		}
		if (LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LEGMOJLDECH);
		}
		num += mAMLPGPOHNE_.CalculateSize(_repeated_mAMLPGPOHNE_codec);
		if (PGEGMMBINID)
		{
			num += 2;
		}
		if (NFLPMLGBKDF)
		{
			num += 2;
		}
		if (BMGAKKNAKFD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMGAKKNAKFD);
		}
		if (BCLLCBDEPEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCLLCBDEPEP);
		}
		num += gCENJMPLHMC_.CalculateSize(_repeated_gCENJMPLHMC_codec);
		if (BBOJLIEALDB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BBOJLIEALDB);
		}
		if (NJDBIEMAOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJDBIEMAOAA);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dMLLCPJFPNF_.CalculateSize(_map_dMLLCPJFPNF_codec);
		num += hBMIGMJBCNG_.CalculateSize(_map_hBMIGMJBCNG_codec);
		num += hMABMKKKHNB_.CalculateSize(_repeated_hMABMKKKHNB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraFinishRound other)
	{
		if (other != null)
		{
			if (other.ACJJCPCPFDN != 0)
			{
				ACJJCPCPFDN = other.ACJJCPCPFDN;
			}
			if (other.EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
			{
				EndReason = other.EndReason;
			}
			if (other.LEGMOJLDECH != GHJIFOHJOEM.Kipcefmgpee)
			{
				LEGMOJLDECH = other.LEGMOJLDECH;
			}
			mAMLPGPOHNE_.Add(other.mAMLPGPOHNE_);
			if (other.PGEGMMBINID)
			{
				PGEGMMBINID = other.PGEGMMBINID;
			}
			if (other.NFLPMLGBKDF)
			{
				NFLPMLGBKDF = other.NFLPMLGBKDF;
			}
			if (other.BMGAKKNAKFD != 0)
			{
				BMGAKKNAKFD = other.BMGAKKNAKFD;
			}
			if (other.BCLLCBDEPEP != 0)
			{
				BCLLCBDEPEP = other.BCLLCBDEPEP;
			}
			gCENJMPLHMC_.Add(other.gCENJMPLHMC_);
			if (other.BBOJLIEALDB != 0)
			{
				BBOJLIEALDB = other.BBOJLIEALDB;
			}
			if (other.NJDBIEMAOAA != 0)
			{
				NJDBIEMAOAA = other.NJDBIEMAOAA;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			dMLLCPJFPNF_.MergeFrom(other.dMLLCPJFPNF_);
			hBMIGMJBCNG_.MergeFrom(other.hBMIGMJBCNG_);
			hMABMKKKHNB_.Add(other.hMABMKKKHNB_);
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
				ACJJCPCPFDN = input.ReadUInt32();
				break;
			case 16u:
				EndReason = (ChimeraRoundWorkEndReason)input.ReadEnum();
				break;
			case 24u:
				LEGMOJLDECH = (GHJIFOHJOEM)input.ReadEnum();
				break;
			case 34u:
				mAMLPGPOHNE_.AddEntriesFrom(ref input, _repeated_mAMLPGPOHNE_codec);
				break;
			case 40u:
				PGEGMMBINID = input.ReadBool();
				break;
			case 48u:
				NFLPMLGBKDF = input.ReadBool();
				break;
			case 56u:
				BMGAKKNAKFD = input.ReadUInt32();
				break;
			case 64u:
				BCLLCBDEPEP = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				gCENJMPLHMC_.AddEntriesFrom(ref input, _repeated_gCENJMPLHMC_codec);
				break;
			case 80u:
				BBOJLIEALDB = input.ReadUInt32();
				break;
			case 88u:
				NJDBIEMAOAA = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				dMLLCPJFPNF_.AddEntriesFrom(ref input, _map_dMLLCPJFPNF_codec);
				break;
			case 114u:
				hBMIGMJBCNG_.AddEntriesFrom(ref input, _map_hBMIGMJBCNG_codec);
				break;
			case 122u:
				hMABMKKKHNB_.AddEntriesFrom(ref input, _repeated_hMABMKKKHNB_codec);
				break;
			}
		}
	}
}
