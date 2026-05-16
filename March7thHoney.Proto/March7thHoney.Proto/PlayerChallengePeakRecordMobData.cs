using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerChallengePeakRecordMobData : IMessage<PlayerChallengePeakRecordMobData>, IMessage, IEquatable<PlayerChallengePeakRecordMobData>, IDeepCloneable<PlayerChallengePeakRecordMobData>, IBufferMessage
{
	private static readonly MessageParser<PlayerChallengePeakRecordMobData> _parser = new MessageParser<PlayerChallengePeakRecordMobData>(() => new PlayerChallengePeakRecordMobData());

	private UnknownFieldSet _unknownFields;

	public const int CyclesUsedFieldNumber = 1;

	private uint cyclesUsed_;

	public const int PeakIdFieldNumber = 3;

	private uint peakId_;

	public const int LineupFieldNumber = 4;

	private ChallengeLineupList lineup_;

	public const int OBPDENLMNIIFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_oBPDENLMNII_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> oBPDENLMNII_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerChallengePeakRecordMobData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerChallengePeakRecordMobDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ChallengeLineupList Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OBPDENLMNII => oBPDENLMNII_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerChallengePeakRecordMobData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerChallengePeakRecordMobData(PlayerChallengePeakRecordMobData other)
		: this()
	{
		cyclesUsed_ = other.cyclesUsed_;
		peakId_ = other.peakId_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		oBPDENLMNII_ = other.oBPDENLMNII_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerChallengePeakRecordMobData Clone()
	{
		return new PlayerChallengePeakRecordMobData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerChallengePeakRecordMobData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerChallengePeakRecordMobData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CyclesUsed != other.CyclesUsed)
		{
			return false;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!oBPDENLMNII_.Equals(other.oBPDENLMNII_))
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
		if (CyclesUsed != 0)
		{
			num ^= CyclesUsed.GetHashCode();
		}
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		num ^= oBPDENLMNII_.GetHashCode();
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
		if (CyclesUsed != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CyclesUsed);
		}
		if (PeakId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PeakId);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Lineup);
		}
		oBPDENLMNII_.WriteTo(ref output, _repeated_oBPDENLMNII_codec);
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
		if (CyclesUsed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CyclesUsed);
		}
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		num += oBPDENLMNII_.CalculateSize(_repeated_oBPDENLMNII_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerChallengePeakRecordMobData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CyclesUsed != 0)
		{
			CyclesUsed = other.CyclesUsed;
		}
		if (other.PeakId != 0)
		{
			PeakId = other.PeakId;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new ChallengeLineupList();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		oBPDENLMNII_.Add(other.oBPDENLMNII_);
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
				CyclesUsed = input.ReadUInt32();
				break;
			case 24u:
				PeakId = input.ReadUInt32();
				break;
			case 34u:
				if (lineup_ == null)
				{
					Lineup = new ChallengeLineupList();
				}
				input.ReadMessage(Lineup);
				break;
			case 64u:
			case 66u:
				oBPDENLMNII_.AddEntriesFrom(ref input, _repeated_oBPDENLMNII_codec);
				break;
			}
		}
	}
}
