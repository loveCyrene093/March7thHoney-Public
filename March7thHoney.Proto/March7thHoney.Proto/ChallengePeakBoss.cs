using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakBoss : IMessage<ChallengePeakBoss>, IMessage, IEquatable<ChallengePeakBoss>, IDeepCloneable<ChallengePeakBoss>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakBoss> _parser = new MessageParser<ChallengePeakBoss>(() => new ChallengePeakBoss());

	private UnknownFieldSet _unknownFields;

	public const int LJGDCGBFNKNFieldNumber = 1;

	private uint lJGDCGBFNKN_;

	public const int FinishedTargetListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int HardModeFieldNumber = 6;

	private ChallengePeakBossClearance hardMode_;

	public const int HardModeHasPassedFieldNumber = 7;

	private bool hardModeHasPassed_;

	public const int EasyModeFieldNumber = 14;

	private ChallengePeakBossClearance easyMode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakBoss> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakBossReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJGDCGBFNKN
	{
		get
		{
			return lJGDCGBFNKN_;
		}
		set
		{
			lJGDCGBFNKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossClearance HardMode
	{
		get
		{
			return hardMode_;
		}
		set
		{
			hardMode_ = value;
		}
	}

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
	public ChallengePeakBossClearance EasyMode
	{
		get
		{
			return easyMode_;
		}
		set
		{
			easyMode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBoss()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBoss(ChallengePeakBoss other)
		: this()
	{
		lJGDCGBFNKN_ = other.lJGDCGBFNKN_;
		finishedTargetList_ = other.finishedTargetList_.Clone();
		hardMode_ = ((other.hardMode_ != null) ? other.hardMode_.Clone() : null);
		hardModeHasPassed_ = other.hardModeHasPassed_;
		easyMode_ = ((other.easyMode_ != null) ? other.easyMode_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBoss Clone()
	{
		return new ChallengePeakBoss(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakBoss);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakBoss other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LJGDCGBFNKN != other.LJGDCGBFNKN)
		{
			return false;
		}
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
		{
			return false;
		}
		if (!object.Equals(HardMode, other.HardMode))
		{
			return false;
		}
		if (HardModeHasPassed != other.HardModeHasPassed)
		{
			return false;
		}
		if (!object.Equals(EasyMode, other.EasyMode))
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
		if (LJGDCGBFNKN != 0)
		{
			num ^= LJGDCGBFNKN.GetHashCode();
		}
		num ^= finishedTargetList_.GetHashCode();
		if (hardMode_ != null)
		{
			num ^= HardMode.GetHashCode();
		}
		if (HardModeHasPassed)
		{
			num ^= HardModeHasPassed.GetHashCode();
		}
		if (easyMode_ != null)
		{
			num ^= EasyMode.GetHashCode();
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
		if (LJGDCGBFNKN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LJGDCGBFNKN);
		}
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (hardMode_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HardMode);
		}
		if (HardModeHasPassed)
		{
			output.WriteRawTag(56);
			output.WriteBool(HardModeHasPassed);
		}
		if (easyMode_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EasyMode);
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
		if (LJGDCGBFNKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJGDCGBFNKN);
		}
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (hardMode_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HardMode);
		}
		if (HardModeHasPassed)
		{
			num += 2;
		}
		if (easyMode_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EasyMode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakBoss other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LJGDCGBFNKN != 0)
		{
			LJGDCGBFNKN = other.LJGDCGBFNKN;
		}
		finishedTargetList_.Add(other.finishedTargetList_);
		if (other.hardMode_ != null)
		{
			if (hardMode_ == null)
			{
				HardMode = new ChallengePeakBossClearance();
			}
			HardMode.MergeFrom(other.HardMode);
		}
		if (other.HardModeHasPassed)
		{
			HardModeHasPassed = other.HardModeHasPassed;
		}
		if (other.easyMode_ != null)
		{
			if (easyMode_ == null)
			{
				EasyMode = new ChallengePeakBossClearance();
			}
			EasyMode.MergeFrom(other.EasyMode);
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
				LJGDCGBFNKN = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 50u:
				if (hardMode_ == null)
				{
					HardMode = new ChallengePeakBossClearance();
				}
				input.ReadMessage(HardMode);
				break;
			case 56u:
				HardModeHasPassed = input.ReadBool();
				break;
			case 114u:
				if (easyMode_ == null)
				{
					EasyMode = new ChallengePeakBossClearance();
				}
				input.ReadMessage(EasyMode);
				break;
			}
		}
	}
}
