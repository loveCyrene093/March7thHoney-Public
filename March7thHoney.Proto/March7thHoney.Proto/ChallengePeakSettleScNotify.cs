using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakSettleScNotify : IMessage<ChallengePeakSettleScNotify>, IMessage, IEquatable<ChallengePeakSettleScNotify>, IDeepCloneable<ChallengePeakSettleScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakSettleScNotify> _parser = new MessageParser<ChallengePeakSettleScNotify>(() => new ChallengePeakSettleScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HardModeHasPassedFieldNumber = 2;

	private bool hardModeHasPassed_;

	public const int IsUnlockEasyBossFieldNumber = 3;

	private bool isUnlockEasyBoss_;

	public const int FinishedTargetListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int PeakIdFieldNumber = 6;

	private uint peakId_;

	public const int TurnLeftFieldNumber = 7;

	private uint turnLeft_;

	public const int IsBossTargetBetterFieldNumber = 8;

	private bool isBossTargetBetter_;

	public const int CyclesUsedFieldNumber = 10;

	private uint cyclesUsed_;

	public const int IsWaitConfirmFieldNumber = 11;

	private bool isWaitConfirm_;

	public const int IsWinFieldNumber = 13;

	private bool isWin_;

	public const int PeakRewardGroupListFieldNumber = 14;

	private static readonly FieldCodec<ChallengePeakRewardGroup> _repeated_peakRewardGroupList_codec = FieldCodec.ForMessage(114u, ChallengePeakRewardGroup.Parser);

	private readonly RepeatedField<ChallengePeakRewardGroup> peakRewardGroupList_ = new RepeatedField<ChallengePeakRewardGroup>();

	public const int IsFirstPassFieldNumber = 15;

	private bool isFirstPass_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakSettleScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakSettleScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HardModeHasPassed
	{
		get
		{
			return hardModeHasPassed_;
		}
		set
		{
			hardModeHasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsUnlockEasyBoss
	{
		get
		{
			return isUnlockEasyBoss_;
		}
		set
		{
			isUnlockEasyBoss_ = value;
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
	public uint TurnLeft
	{
		get
		{
			return turnLeft_;
		}
		set
		{
			turnLeft_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsBossTargetBetter
	{
		get
		{
			return isBossTargetBetter_;
		}
		set
		{
			isBossTargetBetter_ = value;
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
	public RepeatedField<ChallengePeakRewardGroup> PeakRewardGroupList => peakRewardGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFirstPass
	{
		get
		{
			return isFirstPass_;
		}
		set
		{
			isFirstPass_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakSettleScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakSettleScNotify(ChallengePeakSettleScNotify other)
		: this()
	{
		hardModeHasPassed_ = other.hardModeHasPassed_;
		isUnlockEasyBoss_ = other.isUnlockEasyBoss_;
		finishedTargetList_ = other.finishedTargetList_.Clone();
		peakId_ = other.peakId_;
		turnLeft_ = other.turnLeft_;
		isBossTargetBetter_ = other.isBossTargetBetter_;
		cyclesUsed_ = other.cyclesUsed_;
		isWaitConfirm_ = other.isWaitConfirm_;
		isWin_ = other.isWin_;
		peakRewardGroupList_ = other.peakRewardGroupList_.Clone();
		isFirstPass_ = other.isFirstPass_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakSettleScNotify Clone()
	{
		return new ChallengePeakSettleScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakSettleScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakSettleScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HardModeHasPassed != other.HardModeHasPassed)
		{
			return false;
		}
		if (IsUnlockEasyBoss != other.IsUnlockEasyBoss)
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
		if (TurnLeft != other.TurnLeft)
		{
			return false;
		}
		if (IsBossTargetBetter != other.IsBossTargetBetter)
		{
			return false;
		}
		if (CyclesUsed != other.CyclesUsed)
		{
			return false;
		}
		if (IsWaitConfirm != other.IsWaitConfirm)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (!peakRewardGroupList_.Equals(other.peakRewardGroupList_))
		{
			return false;
		}
		if (IsFirstPass != other.IsFirstPass)
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
		if (HardModeHasPassed)
		{
			num ^= HardModeHasPassed.GetHashCode();
		}
		if (IsUnlockEasyBoss)
		{
			num ^= IsUnlockEasyBoss.GetHashCode();
		}
		num ^= finishedTargetList_.GetHashCode();
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		if (TurnLeft != 0)
		{
			num ^= TurnLeft.GetHashCode();
		}
		if (IsBossTargetBetter)
		{
			num ^= IsBossTargetBetter.GetHashCode();
		}
		if (CyclesUsed != 0)
		{
			num ^= CyclesUsed.GetHashCode();
		}
		if (IsWaitConfirm)
		{
			num ^= IsWaitConfirm.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		num ^= peakRewardGroupList_.GetHashCode();
		if (IsFirstPass)
		{
			num ^= IsFirstPass.GetHashCode();
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
		if (HardModeHasPassed)
		{
			output.WriteRawTag(16);
			output.WriteBool(HardModeHasPassed);
		}
		if (IsUnlockEasyBoss)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsUnlockEasyBoss);
		}
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (PeakId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PeakId);
		}
		if (TurnLeft != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(TurnLeft);
		}
		if (IsBossTargetBetter)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsBossTargetBetter);
		}
		if (CyclesUsed != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CyclesUsed);
		}
		if (IsWaitConfirm)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsWaitConfirm);
		}
		if (IsWin)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsWin);
		}
		peakRewardGroupList_.WriteTo(ref output, _repeated_peakRewardGroupList_codec);
		if (IsFirstPass)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsFirstPass);
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
		if (HardModeHasPassed)
		{
			num += 2;
		}
		if (IsUnlockEasyBoss)
		{
			num += 2;
		}
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (TurnLeft != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TurnLeft);
		}
		if (IsBossTargetBetter)
		{
			num += 2;
		}
		if (CyclesUsed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CyclesUsed);
		}
		if (IsWaitConfirm)
		{
			num += 2;
		}
		if (IsWin)
		{
			num += 2;
		}
		num += peakRewardGroupList_.CalculateSize(_repeated_peakRewardGroupList_codec);
		if (IsFirstPass)
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
	public void MergeFrom(ChallengePeakSettleScNotify other)
	{
		if (other != null)
		{
			if (other.HardModeHasPassed)
			{
				HardModeHasPassed = other.HardModeHasPassed;
			}
			if (other.IsUnlockEasyBoss)
			{
				IsUnlockEasyBoss = other.IsUnlockEasyBoss;
			}
			finishedTargetList_.Add(other.finishedTargetList_);
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			if (other.TurnLeft != 0)
			{
				TurnLeft = other.TurnLeft;
			}
			if (other.IsBossTargetBetter)
			{
				IsBossTargetBetter = other.IsBossTargetBetter;
			}
			if (other.CyclesUsed != 0)
			{
				CyclesUsed = other.CyclesUsed;
			}
			if (other.IsWaitConfirm)
			{
				IsWaitConfirm = other.IsWaitConfirm;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			peakRewardGroupList_.Add(other.peakRewardGroupList_);
			if (other.IsFirstPass)
			{
				IsFirstPass = other.IsFirstPass;
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
			case 16u:
				HardModeHasPassed = input.ReadBool();
				break;
			case 24u:
				IsUnlockEasyBoss = input.ReadBool();
				break;
			case 40u:
			case 42u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 48u:
				PeakId = input.ReadUInt32();
				break;
			case 56u:
				TurnLeft = input.ReadUInt32();
				break;
			case 64u:
				IsBossTargetBetter = input.ReadBool();
				break;
			case 80u:
				CyclesUsed = input.ReadUInt32();
				break;
			case 88u:
				IsWaitConfirm = input.ReadBool();
				break;
			case 104u:
				IsWin = input.ReadBool();
				break;
			case 114u:
				peakRewardGroupList_.AddEntriesFrom(ref input, _repeated_peakRewardGroupList_codec);
				break;
			case 120u:
				IsFirstPass = input.ReadBool();
				break;
			}
		}
	}
}
