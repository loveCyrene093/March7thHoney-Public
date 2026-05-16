using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartChallengePeakCsReq : IMessage<StartChallengePeakCsReq>, IMessage, IEquatable<StartChallengePeakCsReq>, IDeepCloneable<StartChallengePeakCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartChallengePeakCsReq> _parser = new MessageParser<StartChallengePeakCsReq>(() => new StartChallengePeakCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PeakIdFieldNumber = 3;

	private uint peakId_;

	public const int FMFGOJHCCNLFieldNumber = 4;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_fMFGOJHCCNL_codec = FieldCodec.ForMessage(34u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> fMFGOJHCCNL_ = new RepeatedField<EEBPHJCNBFO>();

	public const int BossBuffIdFieldNumber = 6;

	private uint bossBuffId_;

	public const int PeakAvatarIdListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_peakAvatarIdList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> peakAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartChallengePeakCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartChallengePeakCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<EEBPHJCNBFO> FMFGOJHCCNL => fMFGOJHCCNL_;

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
	public RepeatedField<uint> PeakAvatarIdList => peakAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengePeakCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengePeakCsReq(StartChallengePeakCsReq other)
		: this()
	{
		peakId_ = other.peakId_;
		fMFGOJHCCNL_ = other.fMFGOJHCCNL_.Clone();
		bossBuffId_ = other.bossBuffId_;
		peakAvatarIdList_ = other.peakAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengePeakCsReq Clone()
	{
		return new StartChallengePeakCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartChallengePeakCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartChallengePeakCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (!fMFGOJHCCNL_.Equals(other.fMFGOJHCCNL_))
		{
			return false;
		}
		if (BossBuffId != other.BossBuffId)
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
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		num ^= fMFGOJHCCNL_.GetHashCode();
		if (BossBuffId != 0)
		{
			num ^= BossBuffId.GetHashCode();
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
		if (PeakId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PeakId);
		}
		fMFGOJHCCNL_.WriteTo(ref output, _repeated_fMFGOJHCCNL_codec);
		if (BossBuffId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BossBuffId);
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
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		num += fMFGOJHCCNL_.CalculateSize(_repeated_fMFGOJHCCNL_codec);
		if (BossBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BossBuffId);
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
	public void MergeFrom(StartChallengePeakCsReq other)
	{
		if (other != null)
		{
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			fMFGOJHCCNL_.Add(other.fMFGOJHCCNL_);
			if (other.BossBuffId != 0)
			{
				BossBuffId = other.BossBuffId;
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
			case 24u:
				PeakId = input.ReadUInt32();
				break;
			case 34u:
				fMFGOJHCCNL_.AddEntriesFrom(ref input, _repeated_fMFGOJHCCNL_codec);
				break;
			case 48u:
				BossBuffId = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				peakAvatarIdList_.AddEntriesFrom(ref input, _repeated_peakAvatarIdList_codec);
				break;
			}
		}
	}
}
