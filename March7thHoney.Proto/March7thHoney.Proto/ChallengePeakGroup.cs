using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakGroup : IMessage<ChallengePeakGroup>, IMessage, IEquatable<ChallengePeakGroup>, IDeepCloneable<ChallengePeakGroup>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakGroup> _parser = new MessageParser<ChallengePeakGroup>(() => new ChallengePeakGroup());

	private UnknownFieldSet _unknownFields;

	public const int PeakGroupIdFieldNumber = 2;

	private uint peakGroupId_;

	public const int CountOfPeaksFieldNumber = 3;

	private uint countOfPeaks_;

	public const int WaitConfirmDataFieldNumber = 4;

	private WaitConfirmData waitConfirmData_;

	public const int PeakBossFieldNumber = 5;

	private ChallengePeakBoss peakBoss_;

	public const int PeaksFieldNumber = 6;

	private static readonly FieldCodec<ChallengePeak> _repeated_peaks_codec = FieldCodec.ForMessage(50u, ChallengePeak.Parser);

	private readonly RepeatedField<ChallengePeak> peaks_ = new RepeatedField<ChallengePeak>();

	public const int DisableHardModeFieldNumber = 10;

	private bool disableHardMode_;

	public const int PLJLPOHJHEEFieldNumber = 11;

	private FCPEKKEEKFI pLJLPOHJHEE_;

	public const int TakenStarRewardsFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_takenStarRewards_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> takenStarRewards_ = new RepeatedField<uint>();

	public const int ObtainedStarsFieldNumber = 14;

	private uint obtainedStars_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakGroup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakGroupReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakGroupId
	{
		get
		{
			return peakGroupId_;
		}
		set
		{
			peakGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CountOfPeaks
	{
		get
		{
			return countOfPeaks_;
		}
		set
		{
			countOfPeaks_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitConfirmData WaitConfirmData
	{
		get
		{
			return waitConfirmData_;
		}
		set
		{
			waitConfirmData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBoss PeakBoss
	{
		get
		{
			return peakBoss_;
		}
		set
		{
			peakBoss_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChallengePeak> Peaks => peaks_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DisableHardMode
	{
		get
		{
			return disableHardMode_;
		}
		set
		{
			disableHardMode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCPEKKEEKFI PLJLPOHJHEE
	{
		get
		{
			return pLJLPOHJHEE_;
		}
		set
		{
			pLJLPOHJHEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TakenStarRewards => takenStarRewards_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ObtainedStars
	{
		get
		{
			return obtainedStars_;
		}
		set
		{
			obtainedStars_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroup(ChallengePeakGroup other)
		: this()
	{
		peakGroupId_ = other.peakGroupId_;
		countOfPeaks_ = other.countOfPeaks_;
		waitConfirmData_ = ((other.waitConfirmData_ != null) ? other.waitConfirmData_.Clone() : null);
		peakBoss_ = ((other.peakBoss_ != null) ? other.peakBoss_.Clone() : null);
		peaks_ = other.peaks_.Clone();
		disableHardMode_ = other.disableHardMode_;
		pLJLPOHJHEE_ = ((other.pLJLPOHJHEE_ != null) ? other.pLJLPOHJHEE_.Clone() : null);
		takenStarRewards_ = other.takenStarRewards_.Clone();
		obtainedStars_ = other.obtainedStars_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroup Clone()
	{
		return new ChallengePeakGroup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakGroup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PeakGroupId != other.PeakGroupId)
		{
			return false;
		}
		if (CountOfPeaks != other.CountOfPeaks)
		{
			return false;
		}
		if (!object.Equals(WaitConfirmData, other.WaitConfirmData))
		{
			return false;
		}
		if (!object.Equals(PeakBoss, other.PeakBoss))
		{
			return false;
		}
		if (!peaks_.Equals(other.peaks_))
		{
			return false;
		}
		if (DisableHardMode != other.DisableHardMode)
		{
			return false;
		}
		if (!object.Equals(PLJLPOHJHEE, other.PLJLPOHJHEE))
		{
			return false;
		}
		if (!takenStarRewards_.Equals(other.takenStarRewards_))
		{
			return false;
		}
		if (ObtainedStars != other.ObtainedStars)
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
		if (PeakGroupId != 0)
		{
			num ^= PeakGroupId.GetHashCode();
		}
		if (CountOfPeaks != 0)
		{
			num ^= CountOfPeaks.GetHashCode();
		}
		if (waitConfirmData_ != null)
		{
			num ^= WaitConfirmData.GetHashCode();
		}
		if (peakBoss_ != null)
		{
			num ^= PeakBoss.GetHashCode();
		}
		num ^= peaks_.GetHashCode();
		if (DisableHardMode)
		{
			num ^= DisableHardMode.GetHashCode();
		}
		if (pLJLPOHJHEE_ != null)
		{
			num ^= PLJLPOHJHEE.GetHashCode();
		}
		num ^= takenStarRewards_.GetHashCode();
		if (ObtainedStars != 0)
		{
			num ^= ObtainedStars.GetHashCode();
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
		if (PeakGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PeakGroupId);
		}
		if (CountOfPeaks != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CountOfPeaks);
		}
		if (waitConfirmData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(WaitConfirmData);
		}
		if (peakBoss_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PeakBoss);
		}
		peaks_.WriteTo(ref output, _repeated_peaks_codec);
		if (DisableHardMode)
		{
			output.WriteRawTag(80);
			output.WriteBool(DisableHardMode);
		}
		if (pLJLPOHJHEE_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PLJLPOHJHEE);
		}
		takenStarRewards_.WriteTo(ref output, _repeated_takenStarRewards_codec);
		if (ObtainedStars != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ObtainedStars);
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
		if (PeakGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakGroupId);
		}
		if (CountOfPeaks != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CountOfPeaks);
		}
		if (waitConfirmData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WaitConfirmData);
		}
		if (peakBoss_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PeakBoss);
		}
		num += peaks_.CalculateSize(_repeated_peaks_codec);
		if (DisableHardMode)
		{
			num += 2;
		}
		if (pLJLPOHJHEE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLJLPOHJHEE);
		}
		num += takenStarRewards_.CalculateSize(_repeated_takenStarRewards_codec);
		if (ObtainedStars != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ObtainedStars);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakGroup other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PeakGroupId != 0)
		{
			PeakGroupId = other.PeakGroupId;
		}
		if (other.CountOfPeaks != 0)
		{
			CountOfPeaks = other.CountOfPeaks;
		}
		if (other.waitConfirmData_ != null)
		{
			if (waitConfirmData_ == null)
			{
				WaitConfirmData = new WaitConfirmData();
			}
			WaitConfirmData.MergeFrom(other.WaitConfirmData);
		}
		if (other.peakBoss_ != null)
		{
			if (peakBoss_ == null)
			{
				PeakBoss = new ChallengePeakBoss();
			}
			PeakBoss.MergeFrom(other.PeakBoss);
		}
		peaks_.Add(other.peaks_);
		if (other.DisableHardMode)
		{
			DisableHardMode = other.DisableHardMode;
		}
		if (other.pLJLPOHJHEE_ != null)
		{
			if (pLJLPOHJHEE_ == null)
			{
				PLJLPOHJHEE = new FCPEKKEEKFI();
			}
			PLJLPOHJHEE.MergeFrom(other.PLJLPOHJHEE);
		}
		takenStarRewards_.Add(other.takenStarRewards_);
		if (other.ObtainedStars != 0)
		{
			ObtainedStars = other.ObtainedStars;
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
			case 16u:
				PeakGroupId = input.ReadUInt32();
				break;
			case 24u:
				CountOfPeaks = input.ReadUInt32();
				break;
			case 34u:
				if (waitConfirmData_ == null)
				{
					WaitConfirmData = new WaitConfirmData();
				}
				input.ReadMessage(WaitConfirmData);
				break;
			case 42u:
				if (peakBoss_ == null)
				{
					PeakBoss = new ChallengePeakBoss();
				}
				input.ReadMessage(PeakBoss);
				break;
			case 50u:
				peaks_.AddEntriesFrom(ref input, _repeated_peaks_codec);
				break;
			case 80u:
				DisableHardMode = input.ReadBool();
				break;
			case 90u:
				if (pLJLPOHJHEE_ == null)
				{
					PLJLPOHJHEE = new FCPEKKEEKFI();
				}
				input.ReadMessage(PLJLPOHJHEE);
				break;
			case 104u:
			case 106u:
				takenStarRewards_.AddEntriesFrom(ref input, _repeated_takenStarRewards_codec);
				break;
			case 112u:
				ObtainedStars = input.ReadUInt32();
				break;
			}
		}
	}
}
