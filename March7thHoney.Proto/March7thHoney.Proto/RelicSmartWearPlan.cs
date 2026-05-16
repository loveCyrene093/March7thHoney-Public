using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearPlan : IMessage<RelicSmartWearPlan>, IMessage, IEquatable<RelicSmartWearPlan>, IDeepCloneable<RelicSmartWearPlan>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearPlan> _parser = new MessageParser<RelicSmartWearPlan>(() => new RelicSmartWearPlan());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 7;

	private uint avatarId_;

	public const int OutsideRelicListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_outsideRelicList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> outsideRelicList_ = new RepeatedField<uint>();

	public const int InsideRelicListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_insideRelicList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> insideRelicList_ = new RepeatedField<uint>();

	public const int UniqueIdFieldNumber = 14;

	private uint uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearPlan> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearPlanReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OutsideRelicList => outsideRelicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> InsideRelicList => insideRelicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearPlan()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearPlan(RelicSmartWearPlan other)
		: this()
	{
		avatarId_ = other.avatarId_;
		outsideRelicList_ = other.outsideRelicList_.Clone();
		insideRelicList_ = other.insideRelicList_.Clone();
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearPlan Clone()
	{
		return new RelicSmartWearPlan(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearPlan);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearPlan other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!outsideRelicList_.Equals(other.outsideRelicList_))
		{
			return false;
		}
		if (!insideRelicList_.Equals(other.insideRelicList_))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= outsideRelicList_.GetHashCode();
		num ^= insideRelicList_.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AvatarId);
		}
		outsideRelicList_.WriteTo(ref output, _repeated_outsideRelicList_codec);
		insideRelicList_.WriteTo(ref output, _repeated_insideRelicList_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(UniqueId);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += outsideRelicList_.CalculateSize(_repeated_outsideRelicList_codec);
		num += insideRelicList_.CalculateSize(_repeated_insideRelicList_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearPlan other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			outsideRelicList_.Add(other.outsideRelicList_);
			insideRelicList_.Add(other.insideRelicList_);
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
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
			case 56u:
				AvatarId = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				outsideRelicList_.AddEntriesFrom(ref input, _repeated_outsideRelicList_codec);
				break;
			case 104u:
			case 106u:
				insideRelicList_.AddEntriesFrom(ref input, _repeated_insideRelicList_codec);
				break;
			case 112u:
				UniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
