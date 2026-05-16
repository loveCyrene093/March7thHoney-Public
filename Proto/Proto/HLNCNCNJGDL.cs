using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLNCNCNJGDL : IMessage<HLNCNCNJGDL>, IMessage, IEquatable<HLNCNCNJGDL>, IDeepCloneable<HLNCNCNJGDL>, IBufferMessage
{
	private static readonly MessageParser<HLNCNCNJGDL> _parser = new MessageParser<HLNCNCNJGDL>(() => new HLNCNCNJGDL());

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLNCNCNJGDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLNCNCNJGDLReflection.Descriptor.MessageTypes[0];

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
	public HLNCNCNJGDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLNCNCNJGDL(HLNCNCNJGDL other)
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
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLNCNCNJGDL Clone()
	{
		return new HLNCNCNJGDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLNCNCNJGDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLNCNCNJGDL other)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLNCNCNJGDL other)
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
			}
		}
	}
}
