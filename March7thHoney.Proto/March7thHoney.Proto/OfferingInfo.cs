using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OfferingInfo : IMessage<OfferingInfo>, IMessage, IEquatable<OfferingInfo>, IDeepCloneable<OfferingInfo>, IBufferMessage
{
	private static readonly MessageParser<OfferingInfo> _parser = new MessageParser<OfferingInfo>(() => new OfferingInfo());

	private UnknownFieldSet _unknownFields;

	public const int TotalExpFieldNumber = 1;

	private uint totalExp_;

	public const int OfferingLevelFieldNumber = 4;

	private uint offeringLevel_;

	public const int HasTakenRewardIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_hasTakenRewardIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> hasTakenRewardIdList_ = new RepeatedField<uint>();

	public const int OfferingIdFieldNumber = 7;

	private uint offeringId_;

	public const int LevelExpFieldNumber = 12;

	private uint levelExp_;

	public const int OfferingStateFieldNumber = 14;

	private OfferingState offeringState_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OfferingInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OfferingInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalExp
	{
		get
		{
			return totalExp_;
		}
		set
		{
			totalExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OfferingLevel
	{
		get
		{
			return offeringLevel_;
		}
		set
		{
			offeringLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HasTakenRewardIdList => hasTakenRewardIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OfferingId
	{
		get
		{
			return offeringId_;
		}
		set
		{
			offeringId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelExp
	{
		get
		{
			return levelExp_;
		}
		set
		{
			levelExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OfferingState OfferingState
	{
		get
		{
			return offeringState_;
		}
		set
		{
			offeringState_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OfferingInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OfferingInfo(OfferingInfo other)
		: this()
	{
		totalExp_ = other.totalExp_;
		offeringLevel_ = other.offeringLevel_;
		hasTakenRewardIdList_ = other.hasTakenRewardIdList_.Clone();
		offeringId_ = other.offeringId_;
		levelExp_ = other.levelExp_;
		offeringState_ = other.offeringState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OfferingInfo Clone()
	{
		return new OfferingInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OfferingInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OfferingInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TotalExp != other.TotalExp)
		{
			return false;
		}
		if (OfferingLevel != other.OfferingLevel)
		{
			return false;
		}
		if (!hasTakenRewardIdList_.Equals(other.hasTakenRewardIdList_))
		{
			return false;
		}
		if (OfferingId != other.OfferingId)
		{
			return false;
		}
		if (LevelExp != other.LevelExp)
		{
			return false;
		}
		if (OfferingState != other.OfferingState)
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
		if (TotalExp != 0)
		{
			num ^= TotalExp.GetHashCode();
		}
		if (OfferingLevel != 0)
		{
			num ^= OfferingLevel.GetHashCode();
		}
		num ^= hasTakenRewardIdList_.GetHashCode();
		if (OfferingId != 0)
		{
			num ^= OfferingId.GetHashCode();
		}
		if (LevelExp != 0)
		{
			num ^= LevelExp.GetHashCode();
		}
		if (OfferingState != OfferingState.None)
		{
			num ^= OfferingState.GetHashCode();
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
		if (TotalExp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TotalExp);
		}
		if (OfferingLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OfferingLevel);
		}
		hasTakenRewardIdList_.WriteTo(ref output, _repeated_hasTakenRewardIdList_codec);
		if (OfferingId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OfferingId);
		}
		if (LevelExp != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LevelExp);
		}
		if (OfferingState != OfferingState.None)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)OfferingState);
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
		if (TotalExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalExp);
		}
		if (OfferingLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OfferingLevel);
		}
		num += hasTakenRewardIdList_.CalculateSize(_repeated_hasTakenRewardIdList_codec);
		if (OfferingId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OfferingId);
		}
		if (LevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelExp);
		}
		if (OfferingState != OfferingState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OfferingState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OfferingInfo other)
	{
		if (other != null)
		{
			if (other.TotalExp != 0)
			{
				TotalExp = other.TotalExp;
			}
			if (other.OfferingLevel != 0)
			{
				OfferingLevel = other.OfferingLevel;
			}
			hasTakenRewardIdList_.Add(other.hasTakenRewardIdList_);
			if (other.OfferingId != 0)
			{
				OfferingId = other.OfferingId;
			}
			if (other.LevelExp != 0)
			{
				LevelExp = other.LevelExp;
			}
			if (other.OfferingState != OfferingState.None)
			{
				OfferingState = other.OfferingState;
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
			case 8u:
				TotalExp = input.ReadUInt32();
				break;
			case 32u:
				OfferingLevel = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				hasTakenRewardIdList_.AddEntriesFrom(ref input, _repeated_hasTakenRewardIdList_codec);
				break;
			case 56u:
				OfferingId = input.ReadUInt32();
				break;
			case 96u:
				LevelExp = input.ReadUInt32();
				break;
			case 112u:
				OfferingState = (OfferingState)input.ReadEnum();
				break;
			}
		}
	}
}
