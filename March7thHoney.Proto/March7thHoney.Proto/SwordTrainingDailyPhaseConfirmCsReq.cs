using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingDailyPhaseConfirmCsReq : IMessage<SwordTrainingDailyPhaseConfirmCsReq>, IMessage, IEquatable<SwordTrainingDailyPhaseConfirmCsReq>, IDeepCloneable<SwordTrainingDailyPhaseConfirmCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingDailyPhaseConfirmCsReq> _parser = new MessageParser<SwordTrainingDailyPhaseConfirmCsReq>(() => new SwordTrainingDailyPhaseConfirmCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BFPFDMGMCAIFieldNumber = 4;

	private SwordTrainingDailyPhaseType bFPFDMGMCAI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingDailyPhaseConfirmCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingDailyPhaseConfirmCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingDailyPhaseType BFPFDMGMCAI
	{
		get
		{
			return bFPFDMGMCAI_;
		}
		set
		{
			bFPFDMGMCAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingDailyPhaseConfirmCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingDailyPhaseConfirmCsReq(SwordTrainingDailyPhaseConfirmCsReq other)
		: this()
	{
		bFPFDMGMCAI_ = other.bFPFDMGMCAI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingDailyPhaseConfirmCsReq Clone()
	{
		return new SwordTrainingDailyPhaseConfirmCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingDailyPhaseConfirmCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingDailyPhaseConfirmCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BFPFDMGMCAI != other.BFPFDMGMCAI)
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
		if (BFPFDMGMCAI != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
		{
			num ^= BFPFDMGMCAI.GetHashCode();
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
		if (BFPFDMGMCAI != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)BFPFDMGMCAI);
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
		if (BFPFDMGMCAI != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BFPFDMGMCAI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwordTrainingDailyPhaseConfirmCsReq other)
	{
		if (other != null)
		{
			if (other.BFPFDMGMCAI != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
			{
				BFPFDMGMCAI = other.BFPFDMGMCAI;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BFPFDMGMCAI = (SwordTrainingDailyPhaseType)input.ReadEnum();
			}
		}
	}
}
