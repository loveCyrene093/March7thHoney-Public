using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNEMCBJHACK : IMessage<CNEMCBJHACK>, IMessage, IEquatable<CNEMCBJHACK>, IDeepCloneable<CNEMCBJHACK>, IBufferMessage
{
	private static readonly MessageParser<CNEMCBJHACK> _parser = new MessageParser<CNEMCBJHACK>(() => new CNEMCBJHACK());

	private UnknownFieldSet _unknownFields;

	public const int MonsterBattleTypeFieldNumber = 1;

	private uint monsterBattleType_;

	public const int GJOJLEOBJFJFieldNumber = 2;

	private ulong gJOJLEOBJFJ_;

	public const int LevelIdFieldNumber = 3;

	private uint levelId_;

	public const int IOJKDGCFCGGFieldNumber = 4;

	private uint iOJKDGCFCGG_;

	public const int BCJMOEMDGJKFieldNumber = 5;

	private uint bCJMOEMDGJK_;

	public const int LDGJLDANJJLFieldNumber = 6;

	private uint lDGJLDANJJL_;

	public const int MJCEDFJAGEOFieldNumber = 7;

	private bool mJCEDFJAGEO_;

	public const int IILDNPILICMFieldNumber = 8;

	private static readonly FieldCodec<LDAAPHCJENL> _repeated_iILDNPILICM_codec = FieldCodec.ForMessage(66u, LDAAPHCJENL.Parser);

	private readonly RepeatedField<LDAAPHCJENL> iILDNPILICM_ = new RepeatedField<LDAAPHCJENL>();

	public const int RankFieldNumber = 9;

	private uint rank_;

	public const int LJLDALDPNFMFieldNumber = 10;

	private static readonly FieldCodec<LDAAPHCJENL> _repeated_lJLDALDPNFM_codec = FieldCodec.ForMessage(82u, LDAAPHCJENL.Parser);

	private readonly RepeatedField<LDAAPHCJENL> lJLDALDPNFM_ = new RepeatedField<LDAAPHCJENL>();

	public const int PBMLDOEBDEGFieldNumber = 11;

	private uint pBMLDOEBDEG_;

	public const int SkillInfoFieldNumber = 12;

	private static readonly FieldCodec<AEKIPJMMGDE> _repeated_skillInfo_codec = FieldCodec.ForMessage(98u, AEKIPJMMGDE.Parser);

	private readonly RepeatedField<AEKIPJMMGDE> skillInfo_ = new RepeatedField<AEKIPJMMGDE>();

	public const int OJFNAGEPIMEFieldNumber = 13;

	private static readonly FieldCodec<HHNFCCCHHDD> _repeated_oJFNAGEPIME_codec = FieldCodec.ForMessage(106u, HHNFCCCHHDD.Parser);

	private readonly RepeatedField<HHNFCCCHHDD> oJFNAGEPIME_ = new RepeatedField<HHNFCCCHHDD>();

	public const int EMGFPOIGELFFieldNumber = 14;

	private static readonly FieldCodec<LDAAPHCJENL> _repeated_eMGFPOIGELF_codec = FieldCodec.ForMessage(114u, LDAAPHCJENL.Parser);

	private readonly RepeatedField<LDAAPHCJENL> eMGFPOIGELF_ = new RepeatedField<LDAAPHCJENL>();

	public const int IDAAMDNAOJLFieldNumber = 15;

	private static readonly FieldCodec<LDAAPHCJENL> _repeated_iDAAMDNAOJL_codec = FieldCodec.ForMessage(122u, LDAAPHCJENL.Parser);

	private readonly RepeatedField<LDAAPHCJENL> iDAAMDNAOJL_ = new RepeatedField<LDAAPHCJENL>();

	public const int LIHCNKHGBIMFieldNumber = 16;

	private uint lIHCNKHGBIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNEMCBJHACK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNEMCBJHACKReflection.Descriptor.MessageTypes[0];

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
	public uint BCJMOEMDGJK
	{
		get
		{
			return bCJMOEMDGJK_;
		}
		set
		{
			bCJMOEMDGJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDGJLDANJJL
	{
		get
		{
			return lDGJLDANJJL_;
		}
		set
		{
			lDGJLDANJJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MJCEDFJAGEO
	{
		get
		{
			return mJCEDFJAGEO_;
		}
		set
		{
			mJCEDFJAGEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDAAPHCJENL> IILDNPILICM => iILDNPILICM_;

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
	public RepeatedField<LDAAPHCJENL> LJLDALDPNFM => lJLDALDPNFM_;

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
	public RepeatedField<AEKIPJMMGDE> SkillInfo => skillInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HHNFCCCHHDD> OJFNAGEPIME => oJFNAGEPIME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDAAPHCJENL> EMGFPOIGELF => eMGFPOIGELF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDAAPHCJENL> IDAAMDNAOJL => iDAAMDNAOJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LIHCNKHGBIM
	{
		get
		{
			return lIHCNKHGBIM_;
		}
		set
		{
			lIHCNKHGBIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNEMCBJHACK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNEMCBJHACK(CNEMCBJHACK other)
		: this()
	{
		monsterBattleType_ = other.monsterBattleType_;
		gJOJLEOBJFJ_ = other.gJOJLEOBJFJ_;
		levelId_ = other.levelId_;
		iOJKDGCFCGG_ = other.iOJKDGCFCGG_;
		bCJMOEMDGJK_ = other.bCJMOEMDGJK_;
		lDGJLDANJJL_ = other.lDGJLDANJJL_;
		mJCEDFJAGEO_ = other.mJCEDFJAGEO_;
		iILDNPILICM_ = other.iILDNPILICM_.Clone();
		rank_ = other.rank_;
		lJLDALDPNFM_ = other.lJLDALDPNFM_.Clone();
		pBMLDOEBDEG_ = other.pBMLDOEBDEG_;
		skillInfo_ = other.skillInfo_.Clone();
		oJFNAGEPIME_ = other.oJFNAGEPIME_.Clone();
		eMGFPOIGELF_ = other.eMGFPOIGELF_.Clone();
		iDAAMDNAOJL_ = other.iDAAMDNAOJL_.Clone();
		lIHCNKHGBIM_ = other.lIHCNKHGBIM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNEMCBJHACK Clone()
	{
		return new CNEMCBJHACK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNEMCBJHACK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNEMCBJHACK other)
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
		if (BCJMOEMDGJK != other.BCJMOEMDGJK)
		{
			return false;
		}
		if (LDGJLDANJJL != other.LDGJLDANJJL)
		{
			return false;
		}
		if (MJCEDFJAGEO != other.MJCEDFJAGEO)
		{
			return false;
		}
		if (!iILDNPILICM_.Equals(other.iILDNPILICM_))
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (!lJLDALDPNFM_.Equals(other.lJLDALDPNFM_))
		{
			return false;
		}
		if (PBMLDOEBDEG != other.PBMLDOEBDEG)
		{
			return false;
		}
		if (!skillInfo_.Equals(other.skillInfo_))
		{
			return false;
		}
		if (!oJFNAGEPIME_.Equals(other.oJFNAGEPIME_))
		{
			return false;
		}
		if (!eMGFPOIGELF_.Equals(other.eMGFPOIGELF_))
		{
			return false;
		}
		if (!iDAAMDNAOJL_.Equals(other.iDAAMDNAOJL_))
		{
			return false;
		}
		if (LIHCNKHGBIM != other.LIHCNKHGBIM)
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
		if (BCJMOEMDGJK != 0)
		{
			num ^= BCJMOEMDGJK.GetHashCode();
		}
		if (LDGJLDANJJL != 0)
		{
			num ^= LDGJLDANJJL.GetHashCode();
		}
		if (MJCEDFJAGEO)
		{
			num ^= MJCEDFJAGEO.GetHashCode();
		}
		num ^= iILDNPILICM_.GetHashCode();
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		num ^= lJLDALDPNFM_.GetHashCode();
		if (PBMLDOEBDEG != 0)
		{
			num ^= PBMLDOEBDEG.GetHashCode();
		}
		num ^= skillInfo_.GetHashCode();
		num ^= oJFNAGEPIME_.GetHashCode();
		num ^= eMGFPOIGELF_.GetHashCode();
		num ^= iDAAMDNAOJL_.GetHashCode();
		if (LIHCNKHGBIM != 0)
		{
			num ^= LIHCNKHGBIM.GetHashCode();
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
		if (BCJMOEMDGJK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BCJMOEMDGJK);
		}
		if (LDGJLDANJJL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LDGJLDANJJL);
		}
		if (MJCEDFJAGEO)
		{
			output.WriteRawTag(56);
			output.WriteBool(MJCEDFJAGEO);
		}
		iILDNPILICM_.WriteTo(ref output, _repeated_iILDNPILICM_codec);
		if (Rank != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Rank);
		}
		lJLDALDPNFM_.WriteTo(ref output, _repeated_lJLDALDPNFM_codec);
		if (PBMLDOEBDEG != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PBMLDOEBDEG);
		}
		skillInfo_.WriteTo(ref output, _repeated_skillInfo_codec);
		oJFNAGEPIME_.WriteTo(ref output, _repeated_oJFNAGEPIME_codec);
		eMGFPOIGELF_.WriteTo(ref output, _repeated_eMGFPOIGELF_codec);
		iDAAMDNAOJL_.WriteTo(ref output, _repeated_iDAAMDNAOJL_codec);
		if (LIHCNKHGBIM != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(LIHCNKHGBIM);
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
		if (BCJMOEMDGJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCJMOEMDGJK);
		}
		if (LDGJLDANJJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDGJLDANJJL);
		}
		if (MJCEDFJAGEO)
		{
			num += 2;
		}
		num += iILDNPILICM_.CalculateSize(_repeated_iILDNPILICM_codec);
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		num += lJLDALDPNFM_.CalculateSize(_repeated_lJLDALDPNFM_codec);
		if (PBMLDOEBDEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBMLDOEBDEG);
		}
		num += skillInfo_.CalculateSize(_repeated_skillInfo_codec);
		num += oJFNAGEPIME_.CalculateSize(_repeated_oJFNAGEPIME_codec);
		num += eMGFPOIGELF_.CalculateSize(_repeated_eMGFPOIGELF_codec);
		num += iDAAMDNAOJL_.CalculateSize(_repeated_iDAAMDNAOJL_codec);
		if (LIHCNKHGBIM != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LIHCNKHGBIM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNEMCBJHACK other)
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
			if (other.BCJMOEMDGJK != 0)
			{
				BCJMOEMDGJK = other.BCJMOEMDGJK;
			}
			if (other.LDGJLDANJJL != 0)
			{
				LDGJLDANJJL = other.LDGJLDANJJL;
			}
			if (other.MJCEDFJAGEO)
			{
				MJCEDFJAGEO = other.MJCEDFJAGEO;
			}
			iILDNPILICM_.Add(other.iILDNPILICM_);
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			lJLDALDPNFM_.Add(other.lJLDALDPNFM_);
			if (other.PBMLDOEBDEG != 0)
			{
				PBMLDOEBDEG = other.PBMLDOEBDEG;
			}
			skillInfo_.Add(other.skillInfo_);
			oJFNAGEPIME_.Add(other.oJFNAGEPIME_);
			eMGFPOIGELF_.Add(other.eMGFPOIGELF_);
			iDAAMDNAOJL_.Add(other.iDAAMDNAOJL_);
			if (other.LIHCNKHGBIM != 0)
			{
				LIHCNKHGBIM = other.LIHCNKHGBIM;
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
			case 40u:
				BCJMOEMDGJK = input.ReadUInt32();
				break;
			case 48u:
				LDGJLDANJJL = input.ReadUInt32();
				break;
			case 56u:
				MJCEDFJAGEO = input.ReadBool();
				break;
			case 66u:
				iILDNPILICM_.AddEntriesFrom(ref input, _repeated_iILDNPILICM_codec);
				break;
			case 72u:
				Rank = input.ReadUInt32();
				break;
			case 82u:
				lJLDALDPNFM_.AddEntriesFrom(ref input, _repeated_lJLDALDPNFM_codec);
				break;
			case 88u:
				PBMLDOEBDEG = input.ReadUInt32();
				break;
			case 98u:
				skillInfo_.AddEntriesFrom(ref input, _repeated_skillInfo_codec);
				break;
			case 106u:
				oJFNAGEPIME_.AddEntriesFrom(ref input, _repeated_oJFNAGEPIME_codec);
				break;
			case 114u:
				eMGFPOIGELF_.AddEntriesFrom(ref input, _repeated_eMGFPOIGELF_codec);
				break;
			case 122u:
				iDAAMDNAOJL_.AddEntriesFrom(ref input, _repeated_iDAAMDNAOJL_codec);
				break;
			case 128u:
				LIHCNKHGBIM = input.ReadUInt32();
				break;
			}
		}
	}
}
