using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetCurChallengePeakScRsp : IMessage<GetCurChallengePeakScRsp>, IMessage, IEquatable<GetCurChallengePeakScRsp>, IDeepCloneable<GetCurChallengePeakScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetCurChallengePeakScRsp> _parser = new MessageParser<GetCurChallengePeakScRsp>(() => new GetCurChallengePeakScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BossBuffIdFieldNumber = 1;

	private uint bossBuffId_;

	public const int HasPassedFieldNumber = 3;

	private bool hasPassed_;

	public const int IsWaitConfirmFieldNumber = 6;

	private bool isWaitConfirm_;

	public const int CyclesUsedFieldNumber = 11;

	private uint cyclesUsed_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int FinishedTargetListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int PeakIdFieldNumber = 14;

	private uint peakId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetCurChallengePeakScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetCurChallengePeakScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BossBuffId
	{
		get
		{
			return bossBuffId_;
		}
		set
		{
			bossBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWaitConfirm
	{
		get
		{
			return isWaitConfirm_;
		}
		set
		{
			isWaitConfirm_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CyclesUsed
	{
		get
		{
			return cyclesUsed_;
		}
		set
		{
			cyclesUsed_ = value;
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
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakId
	{
		get
		{
			return peakId_;
		}
		set
		{
			peakId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurChallengePeakScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurChallengePeakScRsp(GetCurChallengePeakScRsp other)
		: this()
	{
		bossBuffId_ = other.bossBuffId_;
		hasPassed_ = other.hasPassed_;
		isWaitConfirm_ = other.isWaitConfirm_;
		cyclesUsed_ = other.cyclesUsed_;
		retcode_ = other.retcode_;
		finishedTargetList_ = other.finishedTargetList_.Clone();
		peakId_ = other.peakId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurChallengePeakScRsp Clone()
	{
		return new GetCurChallengePeakScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetCurChallengePeakScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetCurChallengePeakScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BossBuffId != other.BossBuffId)
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (IsWaitConfirm != other.IsWaitConfirm)
		{
			return false;
		}
		if (CyclesUsed != other.CyclesUsed)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
		{
			return false;
		}
		if (PeakId != other.PeakId)
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
		if (BossBuffId != 0)
		{
			num ^= BossBuffId.GetHashCode();
		}
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (IsWaitConfirm)
		{
			num ^= IsWaitConfirm.GetHashCode();
		}
		if (CyclesUsed != 0)
		{
			num ^= CyclesUsed.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= finishedTargetList_.GetHashCode();
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
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
		if (BossBuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BossBuffId);
		}
		if (HasPassed)
		{
			output.WriteRawTag(24);
			output.WriteBool(HasPassed);
		}
		if (IsWaitConfirm)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsWaitConfirm);
		}
		if (CyclesUsed != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CyclesUsed);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (PeakId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PeakId);
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
		if (BossBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BossBuffId);
		}
		if (HasPassed)
		{
			num += 2;
		}
		if (IsWaitConfirm)
		{
			num += 2;
		}
		if (CyclesUsed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CyclesUsed);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetCurChallengePeakScRsp other)
	{
		if (other != null)
		{
			if (other.BossBuffId != 0)
			{
				BossBuffId = other.BossBuffId;
			}
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.IsWaitConfirm)
			{
				IsWaitConfirm = other.IsWaitConfirm;
			}
			if (other.CyclesUsed != 0)
			{
				CyclesUsed = other.CyclesUsed;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			finishedTargetList_.Add(other.finishedTargetList_);
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
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
				BossBuffId = input.ReadUInt32();
				break;
			case 24u:
				HasPassed = input.ReadBool();
				break;
			case 48u:
				IsWaitConfirm = input.ReadBool();
				break;
			case 88u:
				CyclesUsed = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 112u:
				PeakId = input.ReadUInt32();
				break;
			}
		}
	}
}
