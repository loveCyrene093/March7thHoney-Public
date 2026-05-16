using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JMIIFOMFOGO : IMessage<JMIIFOMFOGO>, IMessage, IEquatable<JMIIFOMFOGO>, IDeepCloneable<JMIIFOMFOGO>, IBufferMessage
{
	private static readonly MessageParser<JMIIFOMFOGO> _parser = new MessageParser<JMIIFOMFOGO>(() => new JMIIFOMFOGO());

	private UnknownFieldSet _unknownFields;

	public const int EDIGFNFPBKAFieldNumber = 1;

	private uint eDIGFNFPBKA_;

	public const int IsWinFieldNumber = 2;

	private bool isWin_;

	public const int GGLOCPJMEHIFieldNumber = 3;

	private uint gGLOCPJMEHI_;

	public const int ICOALGKANLBFieldNumber = 4;

	private BGKINCFGKGI iCOALGKANLB_;

	public const int AEFEMMIPOAFFieldNumber = 8;

	private ItemList aEFEMMIPOAF_;

	public const int RecordInfoFieldNumber = 10;

	private PHCCDDKGBHC recordInfo_;

	public const int ScoreIdFieldNumber = 11;

	private uint scoreId_;

	public const int AMKFKDCFMIMFieldNumber = 13;

	private uint aMKFKDCFMIM_;

	public const int GLEENOKNGCIFieldNumber = 15;

	private uint gLEENOKNGCI_;

	public const int DCBKJOCEFNFFieldNumber = 234;

	private uint dCBKJOCEFNF_;

	public const int AreaIdFieldNumber = 763;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JMIIFOMFOGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JMIIFOMFOGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDIGFNFPBKA
	{
		get
		{
			return eDIGFNFPBKA_;
		}
		set
		{
			eDIGFNFPBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGLOCPJMEHI
	{
		get
		{
			return gGLOCPJMEHI_;
		}
		set
		{
			gGLOCPJMEHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI ICOALGKANLB
	{
		get
		{
			return iCOALGKANLB_;
		}
		set
		{
			iCOALGKANLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList AEFEMMIPOAF
	{
		get
		{
			return aEFEMMIPOAF_;
		}
		set
		{
			aEFEMMIPOAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHCCDDKGBHC RecordInfo
	{
		get
		{
			return recordInfo_;
		}
		set
		{
			recordInfo_ = value;
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
	public uint AMKFKDCFMIM
	{
		get
		{
			return aMKFKDCFMIM_;
		}
		set
		{
			aMKFKDCFMIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLEENOKNGCI
	{
		get
		{
			return gLEENOKNGCI_;
		}
		set
		{
			gLEENOKNGCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCBKJOCEFNF
	{
		get
		{
			return dCBKJOCEFNF_;
		}
		set
		{
			dCBKJOCEFNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMIIFOMFOGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMIIFOMFOGO(JMIIFOMFOGO other)
		: this()
	{
		eDIGFNFPBKA_ = other.eDIGFNFPBKA_;
		isWin_ = other.isWin_;
		gGLOCPJMEHI_ = other.gGLOCPJMEHI_;
		iCOALGKANLB_ = ((other.iCOALGKANLB_ != null) ? other.iCOALGKANLB_.Clone() : null);
		aEFEMMIPOAF_ = ((other.aEFEMMIPOAF_ != null) ? other.aEFEMMIPOAF_.Clone() : null);
		recordInfo_ = ((other.recordInfo_ != null) ? other.recordInfo_.Clone() : null);
		scoreId_ = other.scoreId_;
		aMKFKDCFMIM_ = other.aMKFKDCFMIM_;
		gLEENOKNGCI_ = other.gLEENOKNGCI_;
		dCBKJOCEFNF_ = other.dCBKJOCEFNF_;
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMIIFOMFOGO Clone()
	{
		return new JMIIFOMFOGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JMIIFOMFOGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JMIIFOMFOGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDIGFNFPBKA != other.EDIGFNFPBKA)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (GGLOCPJMEHI != other.GGLOCPJMEHI)
		{
			return false;
		}
		if (!object.Equals(ICOALGKANLB, other.ICOALGKANLB))
		{
			return false;
		}
		if (!object.Equals(AEFEMMIPOAF, other.AEFEMMIPOAF))
		{
			return false;
		}
		if (!object.Equals(RecordInfo, other.RecordInfo))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (AMKFKDCFMIM != other.AMKFKDCFMIM)
		{
			return false;
		}
		if (GLEENOKNGCI != other.GLEENOKNGCI)
		{
			return false;
		}
		if (DCBKJOCEFNF != other.DCBKJOCEFNF)
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		if (EDIGFNFPBKA != 0)
		{
			num ^= EDIGFNFPBKA.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (GGLOCPJMEHI != 0)
		{
			num ^= GGLOCPJMEHI.GetHashCode();
		}
		if (iCOALGKANLB_ != null)
		{
			num ^= ICOALGKANLB.GetHashCode();
		}
		if (aEFEMMIPOAF_ != null)
		{
			num ^= AEFEMMIPOAF.GetHashCode();
		}
		if (recordInfo_ != null)
		{
			num ^= RecordInfo.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (AMKFKDCFMIM != 0)
		{
			num ^= AMKFKDCFMIM.GetHashCode();
		}
		if (GLEENOKNGCI != 0)
		{
			num ^= GLEENOKNGCI.GetHashCode();
		}
		if (DCBKJOCEFNF != 0)
		{
			num ^= DCBKJOCEFNF.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		if (EDIGFNFPBKA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EDIGFNFPBKA);
		}
		if (IsWin)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsWin);
		}
		if (GGLOCPJMEHI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GGLOCPJMEHI);
		}
		if (iCOALGKANLB_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ICOALGKANLB);
		}
		if (aEFEMMIPOAF_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(AEFEMMIPOAF);
		}
		if (recordInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(RecordInfo);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ScoreId);
		}
		if (AMKFKDCFMIM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AMKFKDCFMIM);
		}
		if (GLEENOKNGCI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GLEENOKNGCI);
		}
		if (DCBKJOCEFNF != 0)
		{
			output.WriteRawTag(208, 14);
			output.WriteUInt32(DCBKJOCEFNF);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(216, 47);
			output.WriteUInt32(AreaId);
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
		if (EDIGFNFPBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGFNFPBKA);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (GGLOCPJMEHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGLOCPJMEHI);
		}
		if (iCOALGKANLB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ICOALGKANLB);
		}
		if (aEFEMMIPOAF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AEFEMMIPOAF);
		}
		if (recordInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RecordInfo);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (AMKFKDCFMIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMKFKDCFMIM);
		}
		if (GLEENOKNGCI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLEENOKNGCI);
		}
		if (DCBKJOCEFNF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DCBKJOCEFNF);
		}
		if (AreaId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JMIIFOMFOGO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EDIGFNFPBKA != 0)
		{
			EDIGFNFPBKA = other.EDIGFNFPBKA;
		}
		if (other.IsWin)
		{
			IsWin = other.IsWin;
		}
		if (other.GGLOCPJMEHI != 0)
		{
			GGLOCPJMEHI = other.GGLOCPJMEHI;
		}
		if (other.iCOALGKANLB_ != null)
		{
			if (iCOALGKANLB_ == null)
			{
				ICOALGKANLB = new BGKINCFGKGI();
			}
			ICOALGKANLB.MergeFrom(other.ICOALGKANLB);
		}
		if (other.aEFEMMIPOAF_ != null)
		{
			if (aEFEMMIPOAF_ == null)
			{
				AEFEMMIPOAF = new ItemList();
			}
			AEFEMMIPOAF.MergeFrom(other.AEFEMMIPOAF);
		}
		if (other.recordInfo_ != null)
		{
			if (recordInfo_ == null)
			{
				RecordInfo = new PHCCDDKGBHC();
			}
			RecordInfo.MergeFrom(other.RecordInfo);
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.AMKFKDCFMIM != 0)
		{
			AMKFKDCFMIM = other.AMKFKDCFMIM;
		}
		if (other.GLEENOKNGCI != 0)
		{
			GLEENOKNGCI = other.GLEENOKNGCI;
		}
		if (other.DCBKJOCEFNF != 0)
		{
			DCBKJOCEFNF = other.DCBKJOCEFNF;
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
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
				EDIGFNFPBKA = input.ReadUInt32();
				break;
			case 16u:
				IsWin = input.ReadBool();
				break;
			case 24u:
				GGLOCPJMEHI = input.ReadUInt32();
				break;
			case 34u:
				if (iCOALGKANLB_ == null)
				{
					ICOALGKANLB = new BGKINCFGKGI();
				}
				input.ReadMessage(ICOALGKANLB);
				break;
			case 66u:
				if (aEFEMMIPOAF_ == null)
				{
					AEFEMMIPOAF = new ItemList();
				}
				input.ReadMessage(AEFEMMIPOAF);
				break;
			case 82u:
				if (recordInfo_ == null)
				{
					RecordInfo = new PHCCDDKGBHC();
				}
				input.ReadMessage(RecordInfo);
				break;
			case 88u:
				ScoreId = input.ReadUInt32();
				break;
			case 104u:
				AMKFKDCFMIM = input.ReadUInt32();
				break;
			case 120u:
				GLEENOKNGCI = input.ReadUInt32();
				break;
			case 1872u:
				DCBKJOCEFNF = input.ReadUInt32();
				break;
			case 6104u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
