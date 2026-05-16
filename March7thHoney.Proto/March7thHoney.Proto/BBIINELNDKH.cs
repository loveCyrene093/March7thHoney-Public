using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBIINELNDKH : IMessage<BBIINELNDKH>, IMessage, IEquatable<BBIINELNDKH>, IDeepCloneable<BBIINELNDKH>, IBufferMessage
{
	private static readonly MessageParser<BBIINELNDKH> _parser = new MessageParser<BBIINELNDKH>(() => new BBIINELNDKH());

	private UnknownFieldSet _unknownFields;

	public const int MonsterBattleTypeFieldNumber = 1;

	private uint monsterBattleType_;

	public const int GJOJLEOBJFJFieldNumber = 2;

	private ulong gJOJLEOBJFJ_;

	public const int LevelIdFieldNumber = 3;

	private uint levelId_;

	public const int IOJKDGCFCGGFieldNumber = 4;

	private uint iOJKDGCFCGG_;

	public const int IAHDMMGNKEPFieldNumber = 5;

	private bool iAHDMMGNKEP_;

	public const int BCJMOEMDGJKFieldNumber = 6;

	private uint bCJMOEMDGJK_;

	public const int RankFieldNumber = 7;

	private uint rank_;

	public const int BEFJLFKJFJDFieldNumber = 8;

	private ulong bEFJLFKJFJD_;

	public const int PBMLDOEBDEGFieldNumber = 9;

	private uint pBMLDOEBDEG_;

	public const int CECGKMHIJHIFieldNumber = 10;

	private uint cECGKMHIJHI_;

	public const int BuffListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

	public const int LIHCNKHGBIMFieldNumber = 12;

	private uint lIHCNKHGBIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBIINELNDKH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBIINELNDKHReflection.Descriptor.MessageTypes[0];

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
	public bool IAHDMMGNKEP
	{
		get
		{
			return iAHDMMGNKEP_;
		}
		set
		{
			iAHDMMGNKEP_ = value;
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
	public uint CECGKMHIJHI
	{
		get
		{
			return cECGKMHIJHI_;
		}
		set
		{
			cECGKMHIJHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BuffList => buffList_;

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
	public BBIINELNDKH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBIINELNDKH(BBIINELNDKH other)
		: this()
	{
		monsterBattleType_ = other.monsterBattleType_;
		gJOJLEOBJFJ_ = other.gJOJLEOBJFJ_;
		levelId_ = other.levelId_;
		iOJKDGCFCGG_ = other.iOJKDGCFCGG_;
		iAHDMMGNKEP_ = other.iAHDMMGNKEP_;
		bCJMOEMDGJK_ = other.bCJMOEMDGJK_;
		rank_ = other.rank_;
		bEFJLFKJFJD_ = other.bEFJLFKJFJD_;
		pBMLDOEBDEG_ = other.pBMLDOEBDEG_;
		cECGKMHIJHI_ = other.cECGKMHIJHI_;
		buffList_ = other.buffList_.Clone();
		lIHCNKHGBIM_ = other.lIHCNKHGBIM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBIINELNDKH Clone()
	{
		return new BBIINELNDKH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBIINELNDKH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBIINELNDKH other)
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
		if (IAHDMMGNKEP != other.IAHDMMGNKEP)
		{
			return false;
		}
		if (BCJMOEMDGJK != other.BCJMOEMDGJK)
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
		if (PBMLDOEBDEG != other.PBMLDOEBDEG)
		{
			return false;
		}
		if (CECGKMHIJHI != other.CECGKMHIJHI)
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
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
		if (IAHDMMGNKEP)
		{
			num ^= IAHDMMGNKEP.GetHashCode();
		}
		if (BCJMOEMDGJK != 0)
		{
			num ^= BCJMOEMDGJK.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (BEFJLFKJFJD != 0L)
		{
			num ^= BEFJLFKJFJD.GetHashCode();
		}
		if (PBMLDOEBDEG != 0)
		{
			num ^= PBMLDOEBDEG.GetHashCode();
		}
		if (CECGKMHIJHI != 0)
		{
			num ^= CECGKMHIJHI.GetHashCode();
		}
		num ^= buffList_.GetHashCode();
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
		if (IAHDMMGNKEP)
		{
			output.WriteRawTag(40);
			output.WriteBool(IAHDMMGNKEP);
		}
		if (BCJMOEMDGJK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BCJMOEMDGJK);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Rank);
		}
		if (BEFJLFKJFJD != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(BEFJLFKJFJD);
		}
		if (PBMLDOEBDEG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PBMLDOEBDEG);
		}
		if (CECGKMHIJHI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CECGKMHIJHI);
		}
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		if (LIHCNKHGBIM != 0)
		{
			output.WriteRawTag(96);
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
		if (IAHDMMGNKEP)
		{
			num += 2;
		}
		if (BCJMOEMDGJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCJMOEMDGJK);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (BEFJLFKJFJD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BEFJLFKJFJD);
		}
		if (PBMLDOEBDEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBMLDOEBDEG);
		}
		if (CECGKMHIJHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CECGKMHIJHI);
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (LIHCNKHGBIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LIHCNKHGBIM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBIINELNDKH other)
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
			if (other.IAHDMMGNKEP)
			{
				IAHDMMGNKEP = other.IAHDMMGNKEP;
			}
			if (other.BCJMOEMDGJK != 0)
			{
				BCJMOEMDGJK = other.BCJMOEMDGJK;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.BEFJLFKJFJD != 0L)
			{
				BEFJLFKJFJD = other.BEFJLFKJFJD;
			}
			if (other.PBMLDOEBDEG != 0)
			{
				PBMLDOEBDEG = other.PBMLDOEBDEG;
			}
			if (other.CECGKMHIJHI != 0)
			{
				CECGKMHIJHI = other.CECGKMHIJHI;
			}
			buffList_.Add(other.buffList_);
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
				IAHDMMGNKEP = input.ReadBool();
				break;
			case 48u:
				BCJMOEMDGJK = input.ReadUInt32();
				break;
			case 56u:
				Rank = input.ReadUInt32();
				break;
			case 64u:
				BEFJLFKJFJD = input.ReadUInt64();
				break;
			case 72u:
				PBMLDOEBDEG = input.ReadUInt32();
				break;
			case 80u:
				CECGKMHIJHI = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 96u:
				LIHCNKHGBIM = input.ReadUInt32();
				break;
			}
		}
	}
}
