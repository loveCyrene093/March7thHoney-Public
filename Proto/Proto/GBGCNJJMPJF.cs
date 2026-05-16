using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GBGCNJJMPJF : IMessage<GBGCNJJMPJF>, IMessage, IEquatable<GBGCNJJMPJF>, IDeepCloneable<GBGCNJJMPJF>, IBufferMessage
{
	private static readonly MessageParser<GBGCNJJMPJF> _parser = new MessageParser<GBGCNJJMPJF>(() => new GBGCNJJMPJF());

	private UnknownFieldSet _unknownFields;

	public const int LMHBOGJHKHBFieldNumber = 1;

	private uint lMHBOGJHKHB_;

	public const int OJIAAGJBJAFFieldNumber = 2;

	private uint oJIAAGJBJAF_;

	public const int GCPNCEDAMABFieldNumber = 3;

	private uint gCPNCEDAMAB_;

	public const int LOCOHHFMADJFieldNumber = 4;

	private uint lOCOHHFMADJ_;

	public const int ScoreIdFieldNumber = 6;

	private uint scoreId_;

	public const int GoldFieldNumber = 9;

	private uint gold_;

	public const int PBDBJOHCJFOFieldNumber = 10;

	private float pBDBJOHCJFO_;

	public const int BICBJMPAAANFieldNumber = 11;

	private uint bICBJMPAAAN_;

	public const int NCODIMPANCCFieldNumber = 12;

	private uint nCODIMPANCC_;

	public const int UuidFieldNumber = 14;

	private string uuid_ = "";

	public const int KEABPBONOKMFieldNumber = 15;

	private uint kEABPBONOKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GBGCNJJMPJF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GBGCNJJMPJFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMHBOGJHKHB
	{
		get
		{
			return lMHBOGJHKHB_;
		}
		set
		{
			lMHBOGJHKHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OJIAAGJBJAF
	{
		get
		{
			return oJIAAGJBJAF_;
		}
		set
		{
			oJIAAGJBJAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCPNCEDAMAB
	{
		get
		{
			return gCPNCEDAMAB_;
		}
		set
		{
			gCPNCEDAMAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOCOHHFMADJ
	{
		get
		{
			return lOCOHHFMADJ_;
		}
		set
		{
			lOCOHHFMADJ_ = value;
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
	public uint Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float PBDBJOHCJFO
	{
		get
		{
			return pBDBJOHCJFO_;
		}
		set
		{
			pBDBJOHCJFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BICBJMPAAAN
	{
		get
		{
			return bICBJMPAAAN_;
		}
		set
		{
			bICBJMPAAAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCODIMPANCC
	{
		get
		{
			return nCODIMPANCC_;
		}
		set
		{
			nCODIMPANCC_ = value;
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
	public uint KEABPBONOKM
	{
		get
		{
			return kEABPBONOKM_;
		}
		set
		{
			kEABPBONOKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBGCNJJMPJF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBGCNJJMPJF(GBGCNJJMPJF other)
		: this()
	{
		lMHBOGJHKHB_ = other.lMHBOGJHKHB_;
		oJIAAGJBJAF_ = other.oJIAAGJBJAF_;
		gCPNCEDAMAB_ = other.gCPNCEDAMAB_;
		lOCOHHFMADJ_ = other.lOCOHHFMADJ_;
		scoreId_ = other.scoreId_;
		gold_ = other.gold_;
		pBDBJOHCJFO_ = other.pBDBJOHCJFO_;
		bICBJMPAAAN_ = other.bICBJMPAAAN_;
		nCODIMPANCC_ = other.nCODIMPANCC_;
		uuid_ = other.uuid_;
		kEABPBONOKM_ = other.kEABPBONOKM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBGCNJJMPJF Clone()
	{
		return new GBGCNJJMPJF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GBGCNJJMPJF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GBGCNJJMPJF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LMHBOGJHKHB != other.LMHBOGJHKHB)
		{
			return false;
		}
		if (OJIAAGJBJAF != other.OJIAAGJBJAF)
		{
			return false;
		}
		if (GCPNCEDAMAB != other.GCPNCEDAMAB)
		{
			return false;
		}
		if (LOCOHHFMADJ != other.LOCOHHFMADJ)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (Gold != other.Gold)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PBDBJOHCJFO, other.PBDBJOHCJFO))
		{
			return false;
		}
		if (BICBJMPAAAN != other.BICBJMPAAAN)
		{
			return false;
		}
		if (NCODIMPANCC != other.NCODIMPANCC)
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		if (KEABPBONOKM != other.KEABPBONOKM)
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
		if (LMHBOGJHKHB != 0)
		{
			num ^= LMHBOGJHKHB.GetHashCode();
		}
		if (OJIAAGJBJAF != 0)
		{
			num ^= OJIAAGJBJAF.GetHashCode();
		}
		if (GCPNCEDAMAB != 0)
		{
			num ^= GCPNCEDAMAB.GetHashCode();
		}
		if (LOCOHHFMADJ != 0)
		{
			num ^= LOCOHHFMADJ.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (Gold != 0)
		{
			num ^= Gold.GetHashCode();
		}
		if (PBDBJOHCJFO != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PBDBJOHCJFO);
		}
		if (BICBJMPAAAN != 0)
		{
			num ^= BICBJMPAAAN.GetHashCode();
		}
		if (NCODIMPANCC != 0)
		{
			num ^= NCODIMPANCC.GetHashCode();
		}
		if (Uuid.Length != 0)
		{
			num ^= Uuid.GetHashCode();
		}
		if (KEABPBONOKM != 0)
		{
			num ^= KEABPBONOKM.GetHashCode();
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
		if (LMHBOGJHKHB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LMHBOGJHKHB);
		}
		if (OJIAAGJBJAF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OJIAAGJBJAF);
		}
		if (GCPNCEDAMAB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GCPNCEDAMAB);
		}
		if (LOCOHHFMADJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LOCOHHFMADJ);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ScoreId);
		}
		if (Gold != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Gold);
		}
		if (PBDBJOHCJFO != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(PBDBJOHCJFO);
		}
		if (BICBJMPAAAN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BICBJMPAAAN);
		}
		if (NCODIMPANCC != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NCODIMPANCC);
		}
		if (Uuid.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(Uuid);
		}
		if (KEABPBONOKM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(KEABPBONOKM);
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
		if (LMHBOGJHKHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMHBOGJHKHB);
		}
		if (OJIAAGJBJAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OJIAAGJBJAF);
		}
		if (GCPNCEDAMAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCPNCEDAMAB);
		}
		if (LOCOHHFMADJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOCOHHFMADJ);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (Gold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gold);
		}
		if (PBDBJOHCJFO != 0f)
		{
			num += 5;
		}
		if (BICBJMPAAAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BICBJMPAAAN);
		}
		if (NCODIMPANCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCODIMPANCC);
		}
		if (Uuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uuid);
		}
		if (KEABPBONOKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEABPBONOKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GBGCNJJMPJF other)
	{
		if (other != null)
		{
			if (other.LMHBOGJHKHB != 0)
			{
				LMHBOGJHKHB = other.LMHBOGJHKHB;
			}
			if (other.OJIAAGJBJAF != 0)
			{
				OJIAAGJBJAF = other.OJIAAGJBJAF;
			}
			if (other.GCPNCEDAMAB != 0)
			{
				GCPNCEDAMAB = other.GCPNCEDAMAB;
			}
			if (other.LOCOHHFMADJ != 0)
			{
				LOCOHHFMADJ = other.LOCOHHFMADJ;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.Gold != 0)
			{
				Gold = other.Gold;
			}
			if (other.PBDBJOHCJFO != 0f)
			{
				PBDBJOHCJFO = other.PBDBJOHCJFO;
			}
			if (other.BICBJMPAAAN != 0)
			{
				BICBJMPAAAN = other.BICBJMPAAAN;
			}
			if (other.NCODIMPANCC != 0)
			{
				NCODIMPANCC = other.NCODIMPANCC;
			}
			if (other.Uuid.Length != 0)
			{
				Uuid = other.Uuid;
			}
			if (other.KEABPBONOKM != 0)
			{
				KEABPBONOKM = other.KEABPBONOKM;
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
				LMHBOGJHKHB = input.ReadUInt32();
				break;
			case 16u:
				OJIAAGJBJAF = input.ReadUInt32();
				break;
			case 24u:
				GCPNCEDAMAB = input.ReadUInt32();
				break;
			case 32u:
				LOCOHHFMADJ = input.ReadUInt32();
				break;
			case 48u:
				ScoreId = input.ReadUInt32();
				break;
			case 72u:
				Gold = input.ReadUInt32();
				break;
			case 85u:
				PBDBJOHCJFO = input.ReadFloat();
				break;
			case 88u:
				BICBJMPAAAN = input.ReadUInt32();
				break;
			case 96u:
				NCODIMPANCC = input.ReadUInt32();
				break;
			case 114u:
				Uuid = input.ReadString();
				break;
			case 120u:
				KEABPBONOKM = input.ReadUInt32();
				break;
			}
		}
	}
}
