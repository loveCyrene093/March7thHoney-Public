using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerChallengePeakRecordBossData : IMessage<PlayerChallengePeakRecordBossData>, IMessage, IEquatable<PlayerChallengePeakRecordBossData>, IDeepCloneable<PlayerChallengePeakRecordBossData>, IBufferMessage
{
	private static readonly MessageParser<PlayerChallengePeakRecordBossData> _parser = new MessageParser<PlayerChallengePeakRecordBossData>(() => new PlayerChallengePeakRecordBossData());

	private UnknownFieldSet _unknownFields;

	public const int LineupFieldNumber = 1;

	private ChallengeLineupList lineup_;

	public const int OBPDENLMNIIFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_oBPDENLMNII_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> oBPDENLMNII_ = new RepeatedField<uint>();

	public const int BestCycleCountFieldNumber = 6;

	private uint bestCycleCount_;

	public const int EPCMADFOACAFieldNumber = 7;

	private bool ePCMADFOACA_;

	public const int BuffIdFieldNumber = 8;

	private uint buffId_;

	public const int HEILKBJCAGBFieldNumber = 9;

	private uint hEILKBJCAGB_;

	public const int AFFIKAAMEJEFieldNumber = 10;

	private bool aFFIKAAMEJE_;

	public const int PeakIdFieldNumber = 11;

	private uint peakId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerChallengePeakRecordBossData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerChallengePeakRecordBossDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool EPCMADFOACA
	{
		get
		{
			return ePCMADFOACA_;
		}
		set
		{
			ePCMADFOACA_ = value;
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
	public bool AFFIKAAMEJE
	{
		get
		{
			return aFFIKAAMEJE_;
		}
		set
		{
			aFFIKAAMEJE_ = value;
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
	public PlayerChallengePeakRecordBossData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerChallengePeakRecordBossData(PlayerChallengePeakRecordBossData other)
		: this()
	{
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		oBPDENLMNII_ = other.oBPDENLMNII_.Clone();
		bestCycleCount_ = other.bestCycleCount_;
		ePCMADFOACA_ = other.ePCMADFOACA_;
		buffId_ = other.buffId_;
		hEILKBJCAGB_ = other.hEILKBJCAGB_;
		aFFIKAAMEJE_ = other.aFFIKAAMEJE_;
		peakId_ = other.peakId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerChallengePeakRecordBossData Clone()
	{
		return new PlayerChallengePeakRecordBossData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerChallengePeakRecordBossData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerChallengePeakRecordBossData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!oBPDENLMNII_.Equals(other.oBPDENLMNII_))
		{
			return false;
		}
		if (BestCycleCount != other.BestCycleCount)
		{
			return false;
		}
		if (EPCMADFOACA != other.EPCMADFOACA)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (HEILKBJCAGB != other.HEILKBJCAGB)
		{
			return false;
		}
		if (AFFIKAAMEJE != other.AFFIKAAMEJE)
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
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		num ^= oBPDENLMNII_.GetHashCode();
		if (BestCycleCount != 0)
		{
			num ^= BestCycleCount.GetHashCode();
		}
		if (EPCMADFOACA)
		{
			num ^= EPCMADFOACA.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (HEILKBJCAGB != 0)
		{
			num ^= HEILKBJCAGB.GetHashCode();
		}
		if (AFFIKAAMEJE)
		{
			num ^= AFFIKAAMEJE.GetHashCode();
		}
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
		if (lineup_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Lineup);
		}
		oBPDENLMNII_.WriteTo(ref output, _repeated_oBPDENLMNII_codec);
		if (BestCycleCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BestCycleCount);
		}
		if (EPCMADFOACA)
		{
			output.WriteRawTag(56);
			output.WriteBool(EPCMADFOACA);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BuffId);
		}
		if (HEILKBJCAGB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HEILKBJCAGB);
		}
		if (AFFIKAAMEJE)
		{
			output.WriteRawTag(80);
			output.WriteBool(AFFIKAAMEJE);
		}
		if (PeakId != 0)
		{
			output.WriteRawTag(88);
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
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		num += oBPDENLMNII_.CalculateSize(_repeated_oBPDENLMNII_codec);
		if (BestCycleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BestCycleCount);
		}
		if (EPCMADFOACA)
		{
			num += 2;
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (HEILKBJCAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEILKBJCAGB);
		}
		if (AFFIKAAMEJE)
		{
			num += 2;
		}
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
	public void MergeFrom(PlayerChallengePeakRecordBossData other)
	{
		if (other == null)
		{
			return;
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
		if (other.BestCycleCount != 0)
		{
			BestCycleCount = other.BestCycleCount;
		}
		if (other.EPCMADFOACA)
		{
			EPCMADFOACA = other.EPCMADFOACA;
		}
		if (other.BuffId != 0)
		{
			BuffId = other.BuffId;
		}
		if (other.HEILKBJCAGB != 0)
		{
			HEILKBJCAGB = other.HEILKBJCAGB;
		}
		if (other.AFFIKAAMEJE)
		{
			AFFIKAAMEJE = other.AFFIKAAMEJE;
		}
		if (other.PeakId != 0)
		{
			PeakId = other.PeakId;
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
			case 10u:
				if (lineup_ == null)
				{
					Lineup = new ChallengeLineupList();
				}
				input.ReadMessage(Lineup);
				break;
			case 24u:
			case 26u:
				oBPDENLMNII_.AddEntriesFrom(ref input, _repeated_oBPDENLMNII_codec);
				break;
			case 48u:
				BestCycleCount = input.ReadUInt32();
				break;
			case 56u:
				EPCMADFOACA = input.ReadBool();
				break;
			case 64u:
				BuffId = input.ReadUInt32();
				break;
			case 72u:
				HEILKBJCAGB = input.ReadUInt32();
				break;
			case 80u:
				AFFIKAAMEJE = input.ReadBool();
				break;
			case 88u:
				PeakId = input.ReadUInt32();
				break;
			}
		}
	}
}
