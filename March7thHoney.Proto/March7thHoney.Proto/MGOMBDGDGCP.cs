using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MGOMBDGDGCP : IMessage<MGOMBDGDGCP>, IMessage, IEquatable<MGOMBDGDGCP>, IDeepCloneable<MGOMBDGDGCP>, IBufferMessage
{
	private static readonly MessageParser<MGOMBDGDGCP> _parser = new MessageParser<MGOMBDGDGCP>(() => new MGOMBDGDGCP());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 1;

	private uint scoreId_;

	public const int TotalDamageFieldNumber = 4;

	private uint totalDamage_;

	public const int PDBNGNABDJIFieldNumber = 5;

	private uint pDBNGNABDJI_;

	public const int ACKKACCMMIMFieldNumber = 7;

	private uint aCKKACCMMIM_;

	public const int EndStatusFieldNumber = 10;

	private BattleEndStatus endStatus_;

	public const int AGJGLGBCMGFFieldNumber = 11;

	private uint aGJGLGBCMGF_;

	public const int StageIdFieldNumber = 12;

	private uint stageId_;

	public const int MaxScoreFieldNumber = 13;

	private uint maxScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MGOMBDGDGCP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MGOMBDGDGCPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDBNGNABDJI
	{
		get
		{
			return pDBNGNABDJI_;
		}
		set
		{
			pDBNGNABDJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACKKACCMMIM
	{
		get
		{
			return aCKKACCMMIM_;
		}
		set
		{
			aCKKACCMMIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndStatus EndStatus
	{
		get
		{
			return endStatus_;
		}
		set
		{
			endStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AGJGLGBCMGF
	{
		get
		{
			return aGJGLGBCMGF_;
		}
		set
		{
			aGJGLGBCMGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxScore
	{
		get
		{
			return maxScore_;
		}
		set
		{
			maxScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGOMBDGDGCP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGOMBDGDGCP(MGOMBDGDGCP other)
		: this()
	{
		scoreId_ = other.scoreId_;
		totalDamage_ = other.totalDamage_;
		pDBNGNABDJI_ = other.pDBNGNABDJI_;
		aCKKACCMMIM_ = other.aCKKACCMMIM_;
		endStatus_ = other.endStatus_;
		aGJGLGBCMGF_ = other.aGJGLGBCMGF_;
		stageId_ = other.stageId_;
		maxScore_ = other.maxScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGOMBDGDGCP Clone()
	{
		return new MGOMBDGDGCP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MGOMBDGDGCP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MGOMBDGDGCP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (TotalDamage != other.TotalDamage)
		{
			return false;
		}
		if (PDBNGNABDJI != other.PDBNGNABDJI)
		{
			return false;
		}
		if (ACKKACCMMIM != other.ACKKACCMMIM)
		{
			return false;
		}
		if (EndStatus != other.EndStatus)
		{
			return false;
		}
		if (AGJGLGBCMGF != other.AGJGLGBCMGF)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (MaxScore != other.MaxScore)
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
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (TotalDamage != 0)
		{
			num ^= TotalDamage.GetHashCode();
		}
		if (PDBNGNABDJI != 0)
		{
			num ^= PDBNGNABDJI.GetHashCode();
		}
		if (ACKKACCMMIM != 0)
		{
			num ^= ACKKACCMMIM.GetHashCode();
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num ^= EndStatus.GetHashCode();
		}
		if (AGJGLGBCMGF != 0)
		{
			num ^= AGJGLGBCMGF.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (MaxScore != 0)
		{
			num ^= MaxScore.GetHashCode();
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
		if (ScoreId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ScoreId);
		}
		if (TotalDamage != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(TotalDamage);
		}
		if (PDBNGNABDJI != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PDBNGNABDJI);
		}
		if (ACKKACCMMIM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ACKKACCMMIM);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)EndStatus);
		}
		if (AGJGLGBCMGF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AGJGLGBCMGF);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(StageId);
		}
		if (MaxScore != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MaxScore);
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
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (TotalDamage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalDamage);
		}
		if (PDBNGNABDJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDBNGNABDJI);
		}
		if (ACKKACCMMIM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACKKACCMMIM);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndStatus);
		}
		if (AGJGLGBCMGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AGJGLGBCMGF);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (MaxScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MGOMBDGDGCP other)
	{
		if (other != null)
		{
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.TotalDamage != 0)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.PDBNGNABDJI != 0)
			{
				PDBNGNABDJI = other.PDBNGNABDJI;
			}
			if (other.ACKKACCMMIM != 0)
			{
				ACKKACCMMIM = other.ACKKACCMMIM;
			}
			if (other.EndStatus != BattleEndStatus.BattleEndNone)
			{
				EndStatus = other.EndStatus;
			}
			if (other.AGJGLGBCMGF != 0)
			{
				AGJGLGBCMGF = other.AGJGLGBCMGF;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.MaxScore != 0)
			{
				MaxScore = other.MaxScore;
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
				ScoreId = input.ReadUInt32();
				break;
			case 32u:
				TotalDamage = input.ReadUInt32();
				break;
			case 40u:
				PDBNGNABDJI = input.ReadUInt32();
				break;
			case 56u:
				ACKKACCMMIM = input.ReadUInt32();
				break;
			case 80u:
				EndStatus = (BattleEndStatus)input.ReadEnum();
				break;
			case 88u:
				AGJGLGBCMGF = input.ReadUInt32();
				break;
			case 96u:
				StageId = input.ReadUInt32();
				break;
			case 104u:
				MaxScore = input.ReadUInt32();
				break;
			}
		}
	}
}
