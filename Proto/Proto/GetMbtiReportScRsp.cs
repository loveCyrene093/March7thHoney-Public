using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMbtiReportScRsp : IMessage<GetMbtiReportScRsp>, IMessage, IEquatable<GetMbtiReportScRsp>, IDeepCloneable<GetMbtiReportScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMbtiReportScRsp> _parser = new MessageParser<GetMbtiReportScRsp>(() => new GetMbtiReportScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JBLLICOOCAKFieldNumber = 3;

	private static readonly FieldCodec<NPLALEFPIEE> _repeated_jBLLICOOCAK_codec = FieldCodec.ForMessage(26u, NPLALEFPIEE.Parser);

	private readonly RepeatedField<NPLALEFPIEE> jBLLICOOCAK_ = new RepeatedField<NPLALEFPIEE>();

	public const int EHMEFABLODDFieldNumber = 4;

	private int eHMEFABLODD_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int ProgressFieldNumber = 6;

	private uint progress_;

	public const int HNLDLOOAPMIFieldNumber = 7;

	private static readonly FieldCodec<FCJOLMLMKBA> _repeated_hNLDLOOAPMI_codec = FieldCodec.ForMessage(58u, FCJOLMLMKBA.Parser);

	private readonly RepeatedField<FCJOLMLMKBA> hNLDLOOAPMI_ = new RepeatedField<FCJOLMLMKBA>();

	public const int HHPALHMBLFKFieldNumber = 8;

	private bool hHPALHMBLFK_;

	public const int PMAGOBNHJJDFieldNumber = 12;

	private int pMAGOBNHJJD_;

	public const int IsTakenRewardFieldNumber = 13;

	private bool isTakenReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMbtiReportScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMbtiReportScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NPLALEFPIEE> JBLLICOOCAK => jBLLICOOCAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EHMEFABLODD
	{
		get
		{
			return eHMEFABLODD_;
		}
		set
		{
			eHMEFABLODD_ = value;
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
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FCJOLMLMKBA> HNLDLOOAPMI => hNLDLOOAPMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HHPALHMBLFK
	{
		get
		{
			return hHPALHMBLFK_;
		}
		set
		{
			hHPALHMBLFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PMAGOBNHJJD
	{
		get
		{
			return pMAGOBNHJJD_;
		}
		set
		{
			pMAGOBNHJJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMbtiReportScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMbtiReportScRsp(GetMbtiReportScRsp other)
		: this()
	{
		jBLLICOOCAK_ = other.jBLLICOOCAK_.Clone();
		eHMEFABLODD_ = other.eHMEFABLODD_;
		retcode_ = other.retcode_;
		progress_ = other.progress_;
		hNLDLOOAPMI_ = other.hNLDLOOAPMI_.Clone();
		hHPALHMBLFK_ = other.hHPALHMBLFK_;
		pMAGOBNHJJD_ = other.pMAGOBNHJJD_;
		isTakenReward_ = other.isTakenReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMbtiReportScRsp Clone()
	{
		return new GetMbtiReportScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMbtiReportScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMbtiReportScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jBLLICOOCAK_.Equals(other.jBLLICOOCAK_))
		{
			return false;
		}
		if (EHMEFABLODD != other.EHMEFABLODD)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (!hNLDLOOAPMI_.Equals(other.hNLDLOOAPMI_))
		{
			return false;
		}
		if (HHPALHMBLFK != other.HHPALHMBLFK)
		{
			return false;
		}
		if (PMAGOBNHJJD != other.PMAGOBNHJJD)
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
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
		num ^= jBLLICOOCAK_.GetHashCode();
		if (EHMEFABLODD != 0)
		{
			num ^= EHMEFABLODD.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		num ^= hNLDLOOAPMI_.GetHashCode();
		if (HHPALHMBLFK)
		{
			num ^= HHPALHMBLFK.GetHashCode();
		}
		if (PMAGOBNHJJD != 0)
		{
			num ^= PMAGOBNHJJD.GetHashCode();
		}
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
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
		jBLLICOOCAK_.WriteTo(ref output, _repeated_jBLLICOOCAK_codec);
		if (EHMEFABLODD != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EHMEFABLODD);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Progress);
		}
		hNLDLOOAPMI_.WriteTo(ref output, _repeated_hNLDLOOAPMI_codec);
		if (HHPALHMBLFK)
		{
			output.WriteRawTag(64);
			output.WriteBool(HHPALHMBLFK);
		}
		if (PMAGOBNHJJD != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PMAGOBNHJJD);
		}
		if (IsTakenReward)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsTakenReward);
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
		num += jBLLICOOCAK_.CalculateSize(_repeated_jBLLICOOCAK_codec);
		if (EHMEFABLODD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EHMEFABLODD);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		num += hNLDLOOAPMI_.CalculateSize(_repeated_hNLDLOOAPMI_codec);
		if (HHPALHMBLFK)
		{
			num += 2;
		}
		if (PMAGOBNHJJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PMAGOBNHJJD);
		}
		if (IsTakenReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMbtiReportScRsp other)
	{
		if (other != null)
		{
			jBLLICOOCAK_.Add(other.jBLLICOOCAK_);
			if (other.EHMEFABLODD != 0)
			{
				EHMEFABLODD = other.EHMEFABLODD;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			hNLDLOOAPMI_.Add(other.hNLDLOOAPMI_);
			if (other.HHPALHMBLFK)
			{
				HHPALHMBLFK = other.HHPALHMBLFK;
			}
			if (other.PMAGOBNHJJD != 0)
			{
				PMAGOBNHJJD = other.PMAGOBNHJJD;
			}
			if (other.IsTakenReward)
			{
				IsTakenReward = other.IsTakenReward;
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
			case 26u:
				jBLLICOOCAK_.AddEntriesFrom(ref input, _repeated_jBLLICOOCAK_codec);
				break;
			case 32u:
				EHMEFABLODD = input.ReadInt32();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 48u:
				Progress = input.ReadUInt32();
				break;
			case 58u:
				hNLDLOOAPMI_.AddEntriesFrom(ref input, _repeated_hNLDLOOAPMI_codec);
				break;
			case 64u:
				HHPALHMBLFK = input.ReadBool();
				break;
			case 96u:
				PMAGOBNHJJD = input.ReadInt32();
				break;
			case 104u:
				IsTakenReward = input.ReadBool();
				break;
			}
		}
	}
}
