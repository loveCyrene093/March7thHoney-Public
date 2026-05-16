using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetChallengePeakMobLineupAvatarCsReq : IMessage<SetChallengePeakMobLineupAvatarCsReq>, IMessage, IEquatable<SetChallengePeakMobLineupAvatarCsReq>, IDeepCloneable<SetChallengePeakMobLineupAvatarCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetChallengePeakMobLineupAvatarCsReq> _parser = new MessageParser<SetChallengePeakMobLineupAvatarCsReq>(() => new SetChallengePeakMobLineupAvatarCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LineupListFieldNumber = 2;

	private static readonly FieldCodec<ChallengePeakLineup> _repeated_lineupList_codec = FieldCodec.ForMessage(18u, ChallengePeakLineup.Parser);

	private readonly RepeatedField<ChallengePeakLineup> lineupList_ = new RepeatedField<ChallengePeakLineup>();

	public const int HNGPPFPOOCDFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_hNGPPFPOOCD_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> hNGPPFPOOCD_ = new RepeatedField<uint>();

	public const int PeakGroupIdFieldNumber = 8;

	private uint peakGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetChallengePeakMobLineupAvatarCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetChallengePeakMobLineupAvatarCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChallengePeakLineup> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HNGPPFPOOCD => hNGPPFPOOCD_;

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
	public SetChallengePeakMobLineupAvatarCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakMobLineupAvatarCsReq(SetChallengePeakMobLineupAvatarCsReq other)
		: this()
	{
		lineupList_ = other.lineupList_.Clone();
		hNGPPFPOOCD_ = other.hNGPPFPOOCD_.Clone();
		peakGroupId_ = other.peakGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetChallengePeakMobLineupAvatarCsReq Clone()
	{
		return new SetChallengePeakMobLineupAvatarCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetChallengePeakMobLineupAvatarCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetChallengePeakMobLineupAvatarCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lineupList_.Equals(other.lineupList_))
		{
			return false;
		}
		if (!hNGPPFPOOCD_.Equals(other.hNGPPFPOOCD_))
		{
			return false;
		}
		if (PeakGroupId != other.PeakGroupId)
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
		num ^= lineupList_.GetHashCode();
		num ^= hNGPPFPOOCD_.GetHashCode();
		if (PeakGroupId != 0)
		{
			num ^= PeakGroupId.GetHashCode();
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
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		hNGPPFPOOCD_.WriteTo(ref output, _repeated_hNGPPFPOOCD_codec);
		if (PeakGroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PeakGroupId);
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
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		num += hNGPPFPOOCD_.CalculateSize(_repeated_hNGPPFPOOCD_codec);
		if (PeakGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetChallengePeakMobLineupAvatarCsReq other)
	{
		if (other != null)
		{
			lineupList_.Add(other.lineupList_);
			hNGPPFPOOCD_.Add(other.hNGPPFPOOCD_);
			if (other.PeakGroupId != 0)
			{
				PeakGroupId = other.PeakGroupId;
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
			case 18u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 40u:
			case 42u:
				hNGPPFPOOCD_.AddEntriesFrom(ref input, _repeated_hNGPPFPOOCD_codec);
				break;
			case 64u:
				PeakGroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
