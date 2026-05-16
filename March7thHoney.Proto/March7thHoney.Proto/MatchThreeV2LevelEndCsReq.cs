using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2LevelEndCsReq : IMessage<MatchThreeV2LevelEndCsReq>, IMessage, IEquatable<MatchThreeV2LevelEndCsReq>, IDeepCloneable<MatchThreeV2LevelEndCsReq>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2LevelEndCsReq> _parser = new MessageParser<MatchThreeV2LevelEndCsReq>(() => new MatchThreeV2LevelEndCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BIBGHICIDKPFieldNumber = 1;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_bIBGHICIDKP_codec = FieldCodec.ForMessage(10u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> bIBGHICIDKP_ = new RepeatedField<GKDEKJKOIJN>();

	public const int BCMPFJKHDBGFieldNumber = 4;

	private uint bCMPFJKHDBG_;

	public const int LevelIdFieldNumber = 7;

	private uint levelId_;

	public const int PMJDNONMKIBFieldNumber = 9;

	private uint pMJDNONMKIB_;

	public const int UuidFieldNumber = 10;

	private string uuid_ = "";

	public const int NLOCDHMLGJHFieldNumber = 11;

	private uint nLOCDHMLGJH_;

	public const int AFMGJOLFKHJFieldNumber = 13;

	private uint aFMGJOLFKHJ_;

	public const int CONJDDKAFKOFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_cONJDDKAFKO_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> cONJDDKAFKO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2LevelEndCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2LevelEndCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> BIBGHICIDKP => bIBGHICIDKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCMPFJKHDBG
	{
		get
		{
			return bCMPFJKHDBG_;
		}
		set
		{
			bCMPFJKHDBG_ = value;
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
	public uint PMJDNONMKIB
	{
		get
		{
			return pMJDNONMKIB_;
		}
		set
		{
			pMJDNONMKIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		get
		{
			return uuid_;
		}
		set
		{
			uuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLOCDHMLGJH
	{
		get
		{
			return nLOCDHMLGJH_;
		}
		set
		{
			nLOCDHMLGJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFMGJOLFKHJ
	{
		get
		{
			return aFMGJOLFKHJ_;
		}
		set
		{
			aFMGJOLFKHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CONJDDKAFKO => cONJDDKAFKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2LevelEndCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2LevelEndCsReq(MatchThreeV2LevelEndCsReq other)
		: this()
	{
		bIBGHICIDKP_ = other.bIBGHICIDKP_.Clone();
		bCMPFJKHDBG_ = other.bCMPFJKHDBG_;
		levelId_ = other.levelId_;
		pMJDNONMKIB_ = other.pMJDNONMKIB_;
		uuid_ = other.uuid_;
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		aFMGJOLFKHJ_ = other.aFMGJOLFKHJ_;
		cONJDDKAFKO_ = other.cONJDDKAFKO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2LevelEndCsReq Clone()
	{
		return new MatchThreeV2LevelEndCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2LevelEndCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2LevelEndCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bIBGHICIDKP_.Equals(other.bIBGHICIDKP_))
		{
			return false;
		}
		if (BCMPFJKHDBG != other.BCMPFJKHDBG)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (PMJDNONMKIB != other.PMJDNONMKIB)
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		if (NLOCDHMLGJH != other.NLOCDHMLGJH)
		{
			return false;
		}
		if (AFMGJOLFKHJ != other.AFMGJOLFKHJ)
		{
			return false;
		}
		if (!cONJDDKAFKO_.Equals(other.cONJDDKAFKO_))
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
		num ^= bIBGHICIDKP_.GetHashCode();
		if (BCMPFJKHDBG != 0)
		{
			num ^= BCMPFJKHDBG.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (PMJDNONMKIB != 0)
		{
			num ^= PMJDNONMKIB.GetHashCode();
		}
		if (Uuid.Length != 0)
		{
			num ^= Uuid.GetHashCode();
		}
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
		}
		if (AFMGJOLFKHJ != 0)
		{
			num ^= AFMGJOLFKHJ.GetHashCode();
		}
		num ^= cONJDDKAFKO_.GetHashCode();
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
		bIBGHICIDKP_.WriteTo(ref output, _repeated_bIBGHICIDKP_codec);
		if (BCMPFJKHDBG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BCMPFJKHDBG);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LevelId);
		}
		if (PMJDNONMKIB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PMJDNONMKIB);
		}
		if (Uuid.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Uuid);
		}
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NLOCDHMLGJH);
		}
		if (AFMGJOLFKHJ != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AFMGJOLFKHJ);
		}
		cONJDDKAFKO_.WriteTo(ref output, _repeated_cONJDDKAFKO_codec);
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
		num += bIBGHICIDKP_.CalculateSize(_repeated_bIBGHICIDKP_codec);
		if (BCMPFJKHDBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCMPFJKHDBG);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (PMJDNONMKIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMJDNONMKIB);
		}
		if (Uuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uuid);
		}
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		if (AFMGJOLFKHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFMGJOLFKHJ);
		}
		num += cONJDDKAFKO_.CalculateSize(_repeated_cONJDDKAFKO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeV2LevelEndCsReq other)
	{
		if (other != null)
		{
			bIBGHICIDKP_.Add(other.bIBGHICIDKP_);
			if (other.BCMPFJKHDBG != 0)
			{
				BCMPFJKHDBG = other.BCMPFJKHDBG;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.PMJDNONMKIB != 0)
			{
				PMJDNONMKIB = other.PMJDNONMKIB;
			}
			if (other.Uuid.Length != 0)
			{
				Uuid = other.Uuid;
			}
			if (other.NLOCDHMLGJH != 0)
			{
				NLOCDHMLGJH = other.NLOCDHMLGJH;
			}
			if (other.AFMGJOLFKHJ != 0)
			{
				AFMGJOLFKHJ = other.AFMGJOLFKHJ;
			}
			cONJDDKAFKO_.Add(other.cONJDDKAFKO_);
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
			case 10u:
				bIBGHICIDKP_.AddEntriesFrom(ref input, _repeated_bIBGHICIDKP_codec);
				break;
			case 32u:
				BCMPFJKHDBG = input.ReadUInt32();
				break;
			case 56u:
				LevelId = input.ReadUInt32();
				break;
			case 72u:
				PMJDNONMKIB = input.ReadUInt32();
				break;
			case 82u:
				Uuid = input.ReadString();
				break;
			case 88u:
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			case 104u:
				AFMGJOLFKHJ = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				cONJDDKAFKO_.AddEntriesFrom(ref input, _repeated_cONJDDKAFKO_codec);
				break;
			}
		}
	}
}
