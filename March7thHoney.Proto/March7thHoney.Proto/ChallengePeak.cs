using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeak : IMessage<ChallengePeak>, IMessage, IEquatable<ChallengePeak>, IDeepCloneable<ChallengePeak>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeak> _parser = new MessageParser<ChallengePeak>(() => new ChallengePeak());

	private UnknownFieldSet _unknownFields;

	public const int FMFGOJHCCNLFieldNumber = 1;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_fMFGOJHCCNL_codec = FieldCodec.ForMessage(10u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> fMFGOJHCCNL_ = new RepeatedField<EEBPHJCNBFO>();

	public const int PeakIdFieldNumber = 3;

	private uint peakId_;

	public const int PeakBuildListFieldNumber = 5;

	private static readonly FieldCodec<ChallengePeakBuild> _repeated_peakBuildList_codec = FieldCodec.ForMessage(42u, ChallengePeakBuild.Parser);

	private readonly RepeatedField<ChallengePeakBuild> peakBuildList_ = new RepeatedField<ChallengePeakBuild>();

	public const int FinishedTargetListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int HasPassedFieldNumber = 7;

	private bool hasPassed_;

	public const int CyclesUsedFieldNumber = 11;

	private uint cyclesUsed_;

	public const int PeakAvatarIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_peakAvatarIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> peakAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeak> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> FMFGOJHCCNL => fMFGOJHCCNL_;

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
	public RepeatedField<ChallengePeakBuild> PeakBuildList => peakBuildList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

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
	public RepeatedField<uint> PeakAvatarIdList => peakAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeak()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeak(ChallengePeak other)
		: this()
	{
		fMFGOJHCCNL_ = other.fMFGOJHCCNL_.Clone();
		peakId_ = other.peakId_;
		peakBuildList_ = other.peakBuildList_.Clone();
		finishedTargetList_ = other.finishedTargetList_.Clone();
		hasPassed_ = other.hasPassed_;
		cyclesUsed_ = other.cyclesUsed_;
		peakAvatarIdList_ = other.peakAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeak Clone()
	{
		return new ChallengePeak(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeak);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeak other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fMFGOJHCCNL_.Equals(other.fMFGOJHCCNL_))
		{
			return false;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (!peakBuildList_.Equals(other.peakBuildList_))
		{
			return false;
		}
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (CyclesUsed != other.CyclesUsed)
		{
			return false;
		}
		if (!peakAvatarIdList_.Equals(other.peakAvatarIdList_))
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
		num ^= fMFGOJHCCNL_.GetHashCode();
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		num ^= peakBuildList_.GetHashCode();
		num ^= finishedTargetList_.GetHashCode();
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (CyclesUsed != 0)
		{
			num ^= CyclesUsed.GetHashCode();
		}
		num ^= peakAvatarIdList_.GetHashCode();
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
		fMFGOJHCCNL_.WriteTo(ref output, _repeated_fMFGOJHCCNL_codec);
		if (PeakId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PeakId);
		}
		peakBuildList_.WriteTo(ref output, _repeated_peakBuildList_codec);
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (HasPassed)
		{
			output.WriteRawTag(56);
			output.WriteBool(HasPassed);
		}
		if (CyclesUsed != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CyclesUsed);
		}
		peakAvatarIdList_.WriteTo(ref output, _repeated_peakAvatarIdList_codec);
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
		num += fMFGOJHCCNL_.CalculateSize(_repeated_fMFGOJHCCNL_codec);
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		num += peakBuildList_.CalculateSize(_repeated_peakBuildList_codec);
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (HasPassed)
		{
			num += 2;
		}
		if (CyclesUsed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CyclesUsed);
		}
		num += peakAvatarIdList_.CalculateSize(_repeated_peakAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeak other)
	{
		if (other != null)
		{
			fMFGOJHCCNL_.Add(other.fMFGOJHCCNL_);
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			peakBuildList_.Add(other.peakBuildList_);
			finishedTargetList_.Add(other.finishedTargetList_);
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.CyclesUsed != 0)
			{
				CyclesUsed = other.CyclesUsed;
			}
			peakAvatarIdList_.Add(other.peakAvatarIdList_);
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
				fMFGOJHCCNL_.AddEntriesFrom(ref input, _repeated_fMFGOJHCCNL_codec);
				break;
			case 24u:
				PeakId = input.ReadUInt32();
				break;
			case 42u:
				peakBuildList_.AddEntriesFrom(ref input, _repeated_peakBuildList_codec);
				break;
			case 48u:
			case 50u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 56u:
				HasPassed = input.ReadBool();
				break;
			case 88u:
				CyclesUsed = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				peakAvatarIdList_.AddEntriesFrom(ref input, _repeated_peakAvatarIdList_codec);
				break;
			}
		}
	}
}
