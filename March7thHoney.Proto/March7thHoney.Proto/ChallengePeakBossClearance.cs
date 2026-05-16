using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakBossClearance : IMessage<ChallengePeakBossClearance>, IMessage, IEquatable<ChallengePeakBossClearance>, IDeepCloneable<ChallengePeakBossClearance>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakBossClearance> _parser = new MessageParser<ChallengePeakBossClearance>(() => new ChallengePeakBossClearance());

	private UnknownFieldSet _unknownFields;

	public const int MALOCIMPJPMFieldNumber = 3;

	private uint mALOCIMPJPM_;

	public const int FMFGOJHCCNLFieldNumber = 4;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_fMFGOJHCCNL_codec = FieldCodec.ForMessage(34u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> fMFGOJHCCNL_ = new RepeatedField<EEBPHJCNBFO>();

	public const int PeakAvatarIdListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_peakAvatarIdList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> peakAvatarIdList_ = new RepeatedField<uint>();

	public const int HasPassedFieldNumber = 9;

	private bool hasPassed_;

	public const int BuffIdFieldNumber = 10;

	private uint buffId_;

	public const int BestCycleCountFieldNumber = 11;

	private uint bestCycleCount_;

	public const int HEILKBJCAGBFieldNumber = 13;

	private uint hEILKBJCAGB_;

	public const int DisplayAvatarFieldNumber = 14;

	private static readonly FieldCodec<DisplayAvatarInfo> _repeated_displayAvatar_codec = FieldCodec.ForMessage(114u, DisplayAvatarInfo.Parser);

	private readonly RepeatedField<DisplayAvatarInfo> displayAvatar_ = new RepeatedField<DisplayAvatarInfo>();

	public const int OHOMDMEJLFKFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_oHOMDMEJLFK_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> oHOMDMEJLFK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakBossClearance> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakBossClearanceReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MALOCIMPJPM
	{
		get
		{
			return mALOCIMPJPM_;
		}
		set
		{
			mALOCIMPJPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> FMFGOJHCCNL => fMFGOJHCCNL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PeakAvatarIdList => peakAvatarIdList_;

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
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BestCycleCount
	{
		get
		{
			return bestCycleCount_;
		}
		set
		{
			bestCycleCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEILKBJCAGB
	{
		get
		{
			return hEILKBJCAGB_;
		}
		set
		{
			hEILKBJCAGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarInfo> DisplayAvatar => displayAvatar_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OHOMDMEJLFK => oHOMDMEJLFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossClearance()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossClearance(ChallengePeakBossClearance other)
		: this()
	{
		mALOCIMPJPM_ = other.mALOCIMPJPM_;
		fMFGOJHCCNL_ = other.fMFGOJHCCNL_.Clone();
		peakAvatarIdList_ = other.peakAvatarIdList_.Clone();
		hasPassed_ = other.hasPassed_;
		buffId_ = other.buffId_;
		bestCycleCount_ = other.bestCycleCount_;
		hEILKBJCAGB_ = other.hEILKBJCAGB_;
		displayAvatar_ = other.displayAvatar_.Clone();
		oHOMDMEJLFK_ = other.oHOMDMEJLFK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossClearance Clone()
	{
		return new ChallengePeakBossClearance(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakBossClearance);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakBossClearance other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MALOCIMPJPM != other.MALOCIMPJPM)
		{
			return false;
		}
		if (!fMFGOJHCCNL_.Equals(other.fMFGOJHCCNL_))
		{
			return false;
		}
		if (!peakAvatarIdList_.Equals(other.peakAvatarIdList_))
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BestCycleCount != other.BestCycleCount)
		{
			return false;
		}
		if (HEILKBJCAGB != other.HEILKBJCAGB)
		{
			return false;
		}
		if (!displayAvatar_.Equals(other.displayAvatar_))
		{
			return false;
		}
		if (!oHOMDMEJLFK_.Equals(other.oHOMDMEJLFK_))
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
		if (MALOCIMPJPM != 0)
		{
			num ^= MALOCIMPJPM.GetHashCode();
		}
		num ^= fMFGOJHCCNL_.GetHashCode();
		num ^= peakAvatarIdList_.GetHashCode();
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (BestCycleCount != 0)
		{
			num ^= BestCycleCount.GetHashCode();
		}
		if (HEILKBJCAGB != 0)
		{
			num ^= HEILKBJCAGB.GetHashCode();
		}
		num ^= displayAvatar_.GetHashCode();
		num ^= oHOMDMEJLFK_.GetHashCode();
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
		if (MALOCIMPJPM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MALOCIMPJPM);
		}
		fMFGOJHCCNL_.WriteTo(ref output, _repeated_fMFGOJHCCNL_codec);
		peakAvatarIdList_.WriteTo(ref output, _repeated_peakAvatarIdList_codec);
		if (HasPassed)
		{
			output.WriteRawTag(72);
			output.WriteBool(HasPassed);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BuffId);
		}
		if (BestCycleCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BestCycleCount);
		}
		if (HEILKBJCAGB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HEILKBJCAGB);
		}
		displayAvatar_.WriteTo(ref output, _repeated_displayAvatar_codec);
		oHOMDMEJLFK_.WriteTo(ref output, _repeated_oHOMDMEJLFK_codec);
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
		if (MALOCIMPJPM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MALOCIMPJPM);
		}
		num += fMFGOJHCCNL_.CalculateSize(_repeated_fMFGOJHCCNL_codec);
		num += peakAvatarIdList_.CalculateSize(_repeated_peakAvatarIdList_codec);
		if (HasPassed)
		{
			num += 2;
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (BestCycleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BestCycleCount);
		}
		if (HEILKBJCAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEILKBJCAGB);
		}
		num += displayAvatar_.CalculateSize(_repeated_displayAvatar_codec);
		num += oHOMDMEJLFK_.CalculateSize(_repeated_oHOMDMEJLFK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakBossClearance other)
	{
		if (other != null)
		{
			if (other.MALOCIMPJPM != 0)
			{
				MALOCIMPJPM = other.MALOCIMPJPM;
			}
			fMFGOJHCCNL_.Add(other.fMFGOJHCCNL_);
			peakAvatarIdList_.Add(other.peakAvatarIdList_);
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.BestCycleCount != 0)
			{
				BestCycleCount = other.BestCycleCount;
			}
			if (other.HEILKBJCAGB != 0)
			{
				HEILKBJCAGB = other.HEILKBJCAGB;
			}
			displayAvatar_.Add(other.displayAvatar_);
			oHOMDMEJLFK_.Add(other.oHOMDMEJLFK_);
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
			case 24u:
				MALOCIMPJPM = input.ReadUInt32();
				break;
			case 34u:
				fMFGOJHCCNL_.AddEntriesFrom(ref input, _repeated_fMFGOJHCCNL_codec);
				break;
			case 40u:
			case 42u:
				peakAvatarIdList_.AddEntriesFrom(ref input, _repeated_peakAvatarIdList_codec);
				break;
			case 72u:
				HasPassed = input.ReadBool();
				break;
			case 80u:
				BuffId = input.ReadUInt32();
				break;
			case 88u:
				BestCycleCount = input.ReadUInt32();
				break;
			case 104u:
				HEILKBJCAGB = input.ReadUInt32();
				break;
			case 114u:
				displayAvatar_.AddEntriesFrom(ref input, _repeated_displayAvatar_codec);
				break;
			case 120u:
			case 122u:
				oHOMDMEJLFK_.AddEntriesFrom(ref input, _repeated_oHOMDMEJLFK_codec);
				break;
			}
		}
	}
}
