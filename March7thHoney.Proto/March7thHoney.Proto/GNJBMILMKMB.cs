using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GNJBMILMKMB : IMessage<GNJBMILMKMB>, IMessage, IEquatable<GNJBMILMKMB>, IDeepCloneable<GNJBMILMKMB>, IBufferMessage
{
	private static readonly MessageParser<GNJBMILMKMB> _parser = new MessageParser<GNJBMILMKMB>(() => new GNJBMILMKMB());

	private UnknownFieldSet _unknownFields;

	public const int MonsterBattleTypeFieldNumber = 1;

	private uint monsterBattleType_;

	public const int GJOJLEOBJFJFieldNumber = 2;

	private ulong gJOJLEOBJFJ_;

	public const int LevelIdFieldNumber = 3;

	private uint levelId_;

	public const int IOJKDGCFCGGFieldNumber = 4;

	private uint iOJKDGCFCGG_;

	public const int HGCFFBNCBGGFieldNumber = 5;

	private static readonly FieldCodec<LDAAPHCJENL> _repeated_hGCFFBNCBGG_codec = FieldCodec.ForMessage(42u, LDAAPHCJENL.Parser);

	private readonly RepeatedField<LDAAPHCJENL> hGCFFBNCBGG_ = new RepeatedField<LDAAPHCJENL>();

	public const int RankFieldNumber = 6;

	private uint rank_;

	public const int BEFJLFKJFJDFieldNumber = 7;

	private ulong bEFJLFKJFJD_;

	public const int HDFHPKEPKAFFieldNumber = 8;

	private static readonly FieldCodec<LDAAPHCJENL> _repeated_hDFHPKEPKAF_codec = FieldCodec.ForMessage(66u, LDAAPHCJENL.Parser);

	private readonly RepeatedField<LDAAPHCJENL> hDFHPKEPKAF_ = new RepeatedField<LDAAPHCJENL>();

	public const int PBMLDOEBDEGFieldNumber = 9;

	private uint pBMLDOEBDEG_;

	public const int PHFMJGBJFPHFieldNumber = 10;

	private uint pHFMJGBJFPH_;

	public const int ScoreIdFieldNumber = 11;

	private int scoreId_;

	public const int EPLBCNFMLILFieldNumber = 12;

	private int ePLBCNFMLIL_;

	public const int EKJKLCJKLPEFieldNumber = 13;

	private static readonly FieldCodec<FHBHKMFHLLO> _repeated_eKJKLCJKLPE_codec = FieldCodec.ForMessage(106u, FHBHKMFHLLO.Parser);

	private readonly RepeatedField<FHBHKMFHLLO> eKJKLCJKLPE_ = new RepeatedField<FHBHKMFHLLO>();

	public const int LDKGJBALGKCFieldNumber = 14;

	private uint lDKGJBALGKC_;

	public const int LHIMAFCIFAPFieldNumber = 15;

	private uint lHIMAFCIFAP_;

	public const int GAFCPIPKIKLFieldNumber = 16;

	private uint gAFCPIPKIKL_;

	public const int LPALGNILCGMFieldNumber = 17;

	private uint lPALGNILCGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GNJBMILMKMB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GNJBMILMKMBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterBattleType
	{
		get
		{
			return monsterBattleType_;
		}
		set
		{
			monsterBattleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong GJOJLEOBJFJ
	{
		get
		{
			return gJOJLEOBJFJ_;
		}
		set
		{
			gJOJLEOBJFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IOJKDGCFCGG
	{
		get
		{
			return iOJKDGCFCGG_;
		}
		set
		{
			iOJKDGCFCGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDAAPHCJENL> HGCFFBNCBGG => hGCFFBNCBGG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong BEFJLFKJFJD
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
	public RepeatedField<LDAAPHCJENL> HDFHPKEPKAF => hDFHPKEPKAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBMLDOEBDEG
	{
		get
		{
			return pBMLDOEBDEG_;
		}
		set
		{
			pBMLDOEBDEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHFMJGBJFPH
	{
		get
		{
			return pHFMJGBJFPH_;
		}
		set
		{
			pHFMJGBJFPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ScoreId
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
	public int EPLBCNFMLIL
	{
		get
		{
			return ePLBCNFMLIL_;
		}
		set
		{
			ePLBCNFMLIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FHBHKMFHLLO> EKJKLCJKLPE => eKJKLCJKLPE_;

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
	public uint LHIMAFCIFAP
	{
		get
		{
			return lHIMAFCIFAP_;
		}
		set
		{
			lHIMAFCIFAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAFCPIPKIKL
	{
		get
		{
			return gAFCPIPKIKL_;
		}
		set
		{
			gAFCPIPKIKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPALGNILCGM
	{
		get
		{
			return lPALGNILCGM_;
		}
		set
		{
			lPALGNILCGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNJBMILMKMB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNJBMILMKMB(GNJBMILMKMB other)
		: this()
	{
		monsterBattleType_ = other.monsterBattleType_;
		gJOJLEOBJFJ_ = other.gJOJLEOBJFJ_;
		levelId_ = other.levelId_;
		iOJKDGCFCGG_ = other.iOJKDGCFCGG_;
		hGCFFBNCBGG_ = other.hGCFFBNCBGG_.Clone();
		rank_ = other.rank_;
		bEFJLFKJFJD_ = other.bEFJLFKJFJD_;
		hDFHPKEPKAF_ = other.hDFHPKEPKAF_.Clone();
		pBMLDOEBDEG_ = other.pBMLDOEBDEG_;
		pHFMJGBJFPH_ = other.pHFMJGBJFPH_;
		scoreId_ = other.scoreId_;
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		eKJKLCJKLPE_ = other.eKJKLCJKLPE_.Clone();
		lDKGJBALGKC_ = other.lDKGJBALGKC_;
		lHIMAFCIFAP_ = other.lHIMAFCIFAP_;
		gAFCPIPKIKL_ = other.gAFCPIPKIKL_;
		lPALGNILCGM_ = other.lPALGNILCGM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNJBMILMKMB Clone()
	{
		return new GNJBMILMKMB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GNJBMILMKMB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GNJBMILMKMB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonsterBattleType != other.MonsterBattleType)
		{
			return false;
		}
		if (GJOJLEOBJFJ != other.GJOJLEOBJFJ)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (IOJKDGCFCGG != other.IOJKDGCFCGG)
		{
			return false;
		}
		if (!hGCFFBNCBGG_.Equals(other.hGCFFBNCBGG_))
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (BEFJLFKJFJD != other.BEFJLFKJFJD)
		{
			return false;
		}
		if (!hDFHPKEPKAF_.Equals(other.hDFHPKEPKAF_))
		{
			return false;
		}
		if (PBMLDOEBDEG != other.PBMLDOEBDEG)
		{
			return false;
		}
		if (PHFMJGBJFPH != other.PHFMJGBJFPH)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
		{
			return false;
		}
		if (!eKJKLCJKLPE_.Equals(other.eKJKLCJKLPE_))
		{
			return false;
		}
		if (LDKGJBALGKC != other.LDKGJBALGKC)
		{
			return false;
		}
		if (LHIMAFCIFAP != other.LHIMAFCIFAP)
		{
			return false;
		}
		if (GAFCPIPKIKL != other.GAFCPIPKIKL)
		{
			return false;
		}
		if (LPALGNILCGM != other.LPALGNILCGM)
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
		if (MonsterBattleType != 0)
		{
			num ^= MonsterBattleType.GetHashCode();
		}
		if (GJOJLEOBJFJ != 0L)
		{
			num ^= GJOJLEOBJFJ.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (IOJKDGCFCGG != 0)
		{
			num ^= IOJKDGCFCGG.GetHashCode();
		}
		num ^= hGCFFBNCBGG_.GetHashCode();
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (BEFJLFKJFJD != 0L)
		{
			num ^= BEFJLFKJFJD.GetHashCode();
		}
		num ^= hDFHPKEPKAF_.GetHashCode();
		if (PBMLDOEBDEG != 0)
		{
			num ^= PBMLDOEBDEG.GetHashCode();
		}
		if (PHFMJGBJFPH != 0)
		{
			num ^= PHFMJGBJFPH.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
		}
		num ^= eKJKLCJKLPE_.GetHashCode();
		if (LDKGJBALGKC != 0)
		{
			num ^= LDKGJBALGKC.GetHashCode();
		}
		if (LHIMAFCIFAP != 0)
		{
			num ^= LHIMAFCIFAP.GetHashCode();
		}
		if (GAFCPIPKIKL != 0)
		{
			num ^= GAFCPIPKIKL.GetHashCode();
		}
		if (LPALGNILCGM != 0)
		{
			num ^= LPALGNILCGM.GetHashCode();
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
		if (MonsterBattleType != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MonsterBattleType);
		}
		if (GJOJLEOBJFJ != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(GJOJLEOBJFJ);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LevelId);
		}
		if (IOJKDGCFCGG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IOJKDGCFCGG);
		}
		hGCFFBNCBGG_.WriteTo(ref output, _repeated_hGCFFBNCBGG_codec);
		if (Rank != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Rank);
		}
		if (BEFJLFKJFJD != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(BEFJLFKJFJD);
		}
		hDFHPKEPKAF_.WriteTo(ref output, _repeated_hDFHPKEPKAF_codec);
		if (PBMLDOEBDEG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PBMLDOEBDEG);
		}
		if (PHFMJGBJFPH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PHFMJGBJFPH);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ScoreId);
		}
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(EPLBCNFMLIL);
		}
		eKJKLCJKLPE_.WriteTo(ref output, _repeated_eKJKLCJKLPE_codec);
		if (LDKGJBALGKC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LDKGJBALGKC);
		}
		if (LHIMAFCIFAP != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LHIMAFCIFAP);
		}
		if (GAFCPIPKIKL != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(GAFCPIPKIKL);
		}
		if (LPALGNILCGM != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(LPALGNILCGM);
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
		if (MonsterBattleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterBattleType);
		}
		if (GJOJLEOBJFJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GJOJLEOBJFJ);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (IOJKDGCFCGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IOJKDGCFCGG);
		}
		num += hGCFFBNCBGG_.CalculateSize(_repeated_hGCFFBNCBGG_codec);
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (BEFJLFKJFJD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BEFJLFKJFJD);
		}
		num += hDFHPKEPKAF_.CalculateSize(_repeated_hDFHPKEPKAF_codec);
		if (PBMLDOEBDEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBMLDOEBDEG);
		}
		if (PHFMJGBJFPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHFMJGBJFPH);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreId);
		}
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EPLBCNFMLIL);
		}
		num += eKJKLCJKLPE_.CalculateSize(_repeated_eKJKLCJKLPE_codec);
		if (LDKGJBALGKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDKGJBALGKC);
		}
		if (LHIMAFCIFAP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LHIMAFCIFAP);
		}
		if (GAFCPIPKIKL != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GAFCPIPKIKL);
		}
		if (LPALGNILCGM != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LPALGNILCGM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GNJBMILMKMB other)
	{
		if (other != null)
		{
			if (other.MonsterBattleType != 0)
			{
				MonsterBattleType = other.MonsterBattleType;
			}
			if (other.GJOJLEOBJFJ != 0L)
			{
				GJOJLEOBJFJ = other.GJOJLEOBJFJ;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.IOJKDGCFCGG != 0)
			{
				IOJKDGCFCGG = other.IOJKDGCFCGG;
			}
			hGCFFBNCBGG_.Add(other.hGCFFBNCBGG_);
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.BEFJLFKJFJD != 0L)
			{
				BEFJLFKJFJD = other.BEFJLFKJFJD;
			}
			hDFHPKEPKAF_.Add(other.hDFHPKEPKAF_);
			if (other.PBMLDOEBDEG != 0)
			{
				PBMLDOEBDEG = other.PBMLDOEBDEG;
			}
			if (other.PHFMJGBJFPH != 0)
			{
				PHFMJGBJFPH = other.PHFMJGBJFPH;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.EPLBCNFMLIL != 0)
			{
				EPLBCNFMLIL = other.EPLBCNFMLIL;
			}
			eKJKLCJKLPE_.Add(other.eKJKLCJKLPE_);
			if (other.LDKGJBALGKC != 0)
			{
				LDKGJBALGKC = other.LDKGJBALGKC;
			}
			if (other.LHIMAFCIFAP != 0)
			{
				LHIMAFCIFAP = other.LHIMAFCIFAP;
			}
			if (other.GAFCPIPKIKL != 0)
			{
				GAFCPIPKIKL = other.GAFCPIPKIKL;
			}
			if (other.LPALGNILCGM != 0)
			{
				LPALGNILCGM = other.LPALGNILCGM;
			}
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
				MonsterBattleType = input.ReadUInt32();
				break;
			case 16u:
				GJOJLEOBJFJ = input.ReadUInt64();
				break;
			case 24u:
				LevelId = input.ReadUInt32();
				break;
			case 32u:
				IOJKDGCFCGG = input.ReadUInt32();
				break;
			case 42u:
				hGCFFBNCBGG_.AddEntriesFrom(ref input, _repeated_hGCFFBNCBGG_codec);
				break;
			case 48u:
				Rank = input.ReadUInt32();
				break;
			case 56u:
				BEFJLFKJFJD = input.ReadUInt64();
				break;
			case 66u:
				hDFHPKEPKAF_.AddEntriesFrom(ref input, _repeated_hDFHPKEPKAF_codec);
				break;
			case 72u:
				PBMLDOEBDEG = input.ReadUInt32();
				break;
			case 80u:
				PHFMJGBJFPH = input.ReadUInt32();
				break;
			case 88u:
				ScoreId = input.ReadInt32();
				break;
			case 96u:
				EPLBCNFMLIL = input.ReadInt32();
				break;
			case 106u:
				eKJKLCJKLPE_.AddEntriesFrom(ref input, _repeated_eKJKLCJKLPE_codec);
				break;
			case 112u:
				LDKGJBALGKC = input.ReadUInt32();
				break;
			case 120u:
				LHIMAFCIFAP = input.ReadUInt32();
				break;
			case 128u:
				GAFCPIPKIKL = input.ReadUInt32();
				break;
			case 136u:
				LPALGNILCGM = input.ReadUInt32();
				break;
			}
		}
	}
}
