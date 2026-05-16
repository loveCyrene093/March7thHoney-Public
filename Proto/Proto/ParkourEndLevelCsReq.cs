using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ParkourEndLevelCsReq : IMessage<ParkourEndLevelCsReq>, IMessage, IEquatable<ParkourEndLevelCsReq>, IDeepCloneable<ParkourEndLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<ParkourEndLevelCsReq> _parser = new MessageParser<ParkourEndLevelCsReq>(() => new ParkourEndLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CIDMHHICBJJFieldNumber = 2;

	private uint cIDMHHICBJJ_;

	public const int JACOBCLKOODFieldNumber = 4;

	private static readonly FieldCodec<DPABAKNJAHM> _repeated_jACOBCLKOOD_codec = FieldCodec.ForMessage(34u, DPABAKNJAHM.Parser);

	private readonly RepeatedField<DPABAKNJAHM> jACOBCLKOOD_ = new RepeatedField<DPABAKNJAHM>();

	public const int HHPFNDBGIIOFieldNumber = 5;

	private uint hHPFNDBGIIO_;

	public const int LevelIdFieldNumber = 6;

	private uint levelId_;

	public const int TimeFieldNumber = 7;

	private uint time_;

	public const int JFHKACLKHHCFieldNumber = 8;

	private uint jFHKACLKHHC_;

	public const int HKCOFDINJINFieldNumber = 12;

	private GLOIKLNHBLN hKCOFDINJIN_;

	public const int RankFieldNumber = 13;

	private uint rank_;

	public const int EndReasonFieldNumber = 14;

	private NOMNEHCNGLH endReason_;

	public const int IIMGCHFFNLKFieldNumber = 15;

	private static readonly FieldCodec<CNNMMNKCIHP> _repeated_iIMGCHFFNLK_codec = FieldCodec.ForMessage(122u, CNNMMNKCIHP.Parser);

	private readonly RepeatedField<CNNMMNKCIHP> iIMGCHFFNLK_ = new RepeatedField<CNNMMNKCIHP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ParkourEndLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ParkourEndLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CIDMHHICBJJ
	{
		get
		{
			return cIDMHHICBJJ_;
		}
		set
		{
			cIDMHHICBJJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPABAKNJAHM> JACOBCLKOOD => jACOBCLKOOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HHPFNDBGIIO
	{
		get
		{
			return hHPFNDBGIIO_;
		}
		set
		{
			hHPFNDBGIIO_ = value;
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
	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFHKACLKHHC
	{
		get
		{
			return jFHKACLKHHC_;
		}
		set
		{
			jFHKACLKHHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOIKLNHBLN HKCOFDINJIN
	{
		get
		{
			return hKCOFDINJIN_;
		}
		set
		{
			hKCOFDINJIN_ = value;
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
	public NOMNEHCNGLH EndReason
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
	public RepeatedField<CNNMMNKCIHP> IIMGCHFFNLK => iIMGCHFFNLK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourEndLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourEndLevelCsReq(ParkourEndLevelCsReq other)
		: this()
	{
		cIDMHHICBJJ_ = other.cIDMHHICBJJ_;
		jACOBCLKOOD_ = other.jACOBCLKOOD_.Clone();
		hHPFNDBGIIO_ = other.hHPFNDBGIIO_;
		levelId_ = other.levelId_;
		time_ = other.time_;
		jFHKACLKHHC_ = other.jFHKACLKHHC_;
		hKCOFDINJIN_ = ((other.hKCOFDINJIN_ != null) ? other.hKCOFDINJIN_.Clone() : null);
		rank_ = other.rank_;
		endReason_ = other.endReason_;
		iIMGCHFFNLK_ = other.iIMGCHFFNLK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourEndLevelCsReq Clone()
	{
		return new ParkourEndLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ParkourEndLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ParkourEndLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CIDMHHICBJJ != other.CIDMHHICBJJ)
		{
			return false;
		}
		if (!jACOBCLKOOD_.Equals(other.jACOBCLKOOD_))
		{
			return false;
		}
		if (HHPFNDBGIIO != other.HHPFNDBGIIO)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (JFHKACLKHHC != other.JFHKACLKHHC)
		{
			return false;
		}
		if (!object.Equals(HKCOFDINJIN, other.HKCOFDINJIN))
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (EndReason != other.EndReason)
		{
			return false;
		}
		if (!iIMGCHFFNLK_.Equals(other.iIMGCHFFNLK_))
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
		if (CIDMHHICBJJ != 0)
		{
			num ^= CIDMHHICBJJ.GetHashCode();
		}
		num ^= jACOBCLKOOD_.GetHashCode();
		if (HHPFNDBGIIO != 0)
		{
			num ^= HHPFNDBGIIO.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (JFHKACLKHHC != 0)
		{
			num ^= JFHKACLKHHC.GetHashCode();
		}
		if (hKCOFDINJIN_ != null)
		{
			num ^= HKCOFDINJIN.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			num ^= EndReason.GetHashCode();
		}
		num ^= iIMGCHFFNLK_.GetHashCode();
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
		if (CIDMHHICBJJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CIDMHHICBJJ);
		}
		jACOBCLKOOD_.WriteTo(ref output, _repeated_jACOBCLKOOD_codec);
		if (HHPFNDBGIIO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HHPFNDBGIIO);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LevelId);
		}
		if (Time != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Time);
		}
		if (JFHKACLKHHC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JFHKACLKHHC);
		}
		if (hKCOFDINJIN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(HKCOFDINJIN);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Rank);
		}
		if (EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)EndReason);
		}
		iIMGCHFFNLK_.WriteTo(ref output, _repeated_iIMGCHFFNLK_codec);
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
		if (CIDMHHICBJJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CIDMHHICBJJ);
		}
		num += jACOBCLKOOD_.CalculateSize(_repeated_jACOBCLKOOD_codec);
		if (HHPFNDBGIIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HHPFNDBGIIO);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (JFHKACLKHHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFHKACLKHHC);
		}
		if (hKCOFDINJIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKCOFDINJIN);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndReason);
		}
		num += iIMGCHFFNLK_.CalculateSize(_repeated_iIMGCHFFNLK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ParkourEndLevelCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CIDMHHICBJJ != 0)
		{
			CIDMHHICBJJ = other.CIDMHHICBJJ;
		}
		jACOBCLKOOD_.Add(other.jACOBCLKOOD_);
		if (other.HHPFNDBGIIO != 0)
		{
			HHPFNDBGIIO = other.HHPFNDBGIIO;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		if (other.Time != 0)
		{
			Time = other.Time;
		}
		if (other.JFHKACLKHHC != 0)
		{
			JFHKACLKHHC = other.JFHKACLKHHC;
		}
		if (other.hKCOFDINJIN_ != null)
		{
			if (hKCOFDINJIN_ == null)
			{
				HKCOFDINJIN = new GLOIKLNHBLN();
			}
			HKCOFDINJIN.MergeFrom(other.HKCOFDINJIN);
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
		}
		if (other.EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			EndReason = other.EndReason;
		}
		iIMGCHFFNLK_.Add(other.iIMGCHFFNLK_);
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
			case 16u:
				CIDMHHICBJJ = input.ReadUInt32();
				break;
			case 34u:
				jACOBCLKOOD_.AddEntriesFrom(ref input, _repeated_jACOBCLKOOD_codec);
				break;
			case 40u:
				HHPFNDBGIIO = input.ReadUInt32();
				break;
			case 48u:
				LevelId = input.ReadUInt32();
				break;
			case 56u:
				Time = input.ReadUInt32();
				break;
			case 64u:
				JFHKACLKHHC = input.ReadUInt32();
				break;
			case 98u:
				if (hKCOFDINJIN_ == null)
				{
					HKCOFDINJIN = new GLOIKLNHBLN();
				}
				input.ReadMessage(HKCOFDINJIN);
				break;
			case 104u:
				Rank = input.ReadUInt32();
				break;
			case 112u:
				EndReason = (NOMNEHCNGLH)input.ReadEnum();
				break;
			case 122u:
				iIMGCHFFNLK_.AddEntriesFrom(ref input, _repeated_iIMGCHFFNLK_codec);
				break;
			}
		}
	}
}
