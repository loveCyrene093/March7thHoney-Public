using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakBossFriendLineupRecommendation : IMessage<ChallengePeakBossFriendLineupRecommendation>, IMessage, IEquatable<ChallengePeakBossFriendLineupRecommendation>, IDeepCloneable<ChallengePeakBossFriendLineupRecommendation>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakBossFriendLineupRecommendation> _parser = new MessageParser<ChallengePeakBossFriendLineupRecommendation>(() => new ChallengePeakBossFriendLineupRecommendation());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<PKJGGAPLONC> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, PKJGGAPLONC.Parser);

	private readonly RepeatedField<PKJGGAPLONC> avatarList_ = new RepeatedField<PKJGGAPLONC>();

	public const int FinishedTargetListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int IsHardModeFieldNumber = 8;

	private bool isHardMode_;

	public const int BuffIdFieldNumber = 9;

	private uint buffId_;

	public const int HardModeHasPassedFieldNumber = 14;

	private bool hardModeHasPassed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakBossFriendLineupRecommendation> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakBossFriendLineupRecommendationReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PKJGGAPLONC> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsHardMode
	{
		get
		{
			return isHardMode_;
		}
		set
		{
			isHardMode_ = value;
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
	public ChallengePeakBossFriendLineupRecommendation()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossFriendLineupRecommendation(ChallengePeakBossFriendLineupRecommendation other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		finishedTargetList_ = other.finishedTargetList_.Clone();
		isHardMode_ = other.isHardMode_;
		buffId_ = other.buffId_;
		hardModeHasPassed_ = other.hardModeHasPassed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBossFriendLineupRecommendation Clone()
	{
		return new ChallengePeakBossFriendLineupRecommendation(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakBossFriendLineupRecommendation);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakBossFriendLineupRecommendation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
		{
			return false;
		}
		if (IsHardMode != other.IsHardMode)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (HardModeHasPassed != other.HardModeHasPassed)
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
		num ^= avatarList_.GetHashCode();
		num ^= finishedTargetList_.GetHashCode();
		if (IsHardMode)
		{
			num ^= IsHardMode.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (HardModeHasPassed)
		{
			num ^= HardModeHasPassed.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (IsHardMode)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsHardMode);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BuffId);
		}
		if (HardModeHasPassed)
		{
			output.WriteRawTag(112);
			output.WriteBool(HardModeHasPassed);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (IsHardMode)
		{
			num += 2;
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (HardModeHasPassed)
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
	public void MergeFrom(ChallengePeakBossFriendLineupRecommendation other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			finishedTargetList_.Add(other.finishedTargetList_);
			if (other.IsHardMode)
			{
				IsHardMode = other.IsHardMode;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.HardModeHasPassed)
			{
				HardModeHasPassed = other.HardModeHasPassed;
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
			case 10u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 16u:
			case 18u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 64u:
				IsHardMode = input.ReadBool();
				break;
			case 72u:
				BuffId = input.ReadUInt32();
				break;
			case 112u:
				HardModeHasPassed = input.ReadBool();
				break;
			}
		}
	}
}
