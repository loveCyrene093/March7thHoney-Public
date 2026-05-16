using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeChallengePeakRewardCsReq : IMessage<TakeChallengePeakRewardCsReq>, IMessage, IEquatable<TakeChallengePeakRewardCsReq>, IDeepCloneable<TakeChallengePeakRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeChallengePeakRewardCsReq> _parser = new MessageParser<TakeChallengePeakRewardCsReq>(() => new TakeChallengePeakRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PeakGroupIdFieldNumber = 4;

	private uint peakGroupId_;

	public const int NormalRewardIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_normalRewardIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> normalRewardIdList_ = new RepeatedField<uint>();

	public const int RewardIdFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_rewardId_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> rewardId_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeChallengePeakRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeChallengePeakRewardCsReqReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> NormalRewardIdList => normalRewardIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengePeakRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengePeakRewardCsReq(TakeChallengePeakRewardCsReq other)
		: this()
	{
		peakGroupId_ = other.peakGroupId_;
		normalRewardIdList_ = other.normalRewardIdList_.Clone();
		rewardId_ = other.rewardId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengePeakRewardCsReq Clone()
	{
		return new TakeChallengePeakRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeChallengePeakRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeChallengePeakRewardCsReq other)
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
		if (!normalRewardIdList_.Equals(other.normalRewardIdList_))
		{
			return false;
		}
		if (!rewardId_.Equals(other.rewardId_))
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
		num ^= normalRewardIdList_.GetHashCode();
		num ^= rewardId_.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(PeakGroupId);
		}
		normalRewardIdList_.WriteTo(ref output, _repeated_normalRewardIdList_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
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
		num += normalRewardIdList_.CalculateSize(_repeated_normalRewardIdList_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeChallengePeakRewardCsReq other)
	{
		if (other != null)
		{
			if (other.PeakGroupId != 0)
			{
				PeakGroupId = other.PeakGroupId;
			}
			normalRewardIdList_.Add(other.normalRewardIdList_);
			rewardId_.Add(other.rewardId_);
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
			case 32u:
				PeakGroupId = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				normalRewardIdList_.AddEntriesFrom(ref input, _repeated_normalRewardIdList_codec);
				break;
			case 72u:
			case 74u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			}
		}
	}
}
