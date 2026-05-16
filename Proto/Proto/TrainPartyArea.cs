using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyArea : IMessage<TrainPartyArea>, IMessage, IEquatable<TrainPartyArea>, IDeepCloneable<TrainPartyArea>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyArea> _parser = new MessageParser<TrainPartyArea>(() => new TrainPartyArea());

	private UnknownFieldSet _unknownFields;

	public const int StepIdListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_stepIdList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> stepIdList_ = new RepeatedField<uint>();

	public const int DynamicInfoFieldNumber = 8;

	private static readonly FieldCodec<AreaDynamicInfo> _repeated_dynamicInfo_codec = FieldCodec.ForMessage(66u, AreaDynamicInfo.Parser);

	private readonly RepeatedField<AreaDynamicInfo> dynamicInfo_ = new RepeatedField<AreaDynamicInfo>();

	public const int AreaStepInfoFieldNumber = 10;

	private AreaStepInfo areaStepInfo_;

	public const int AreaIdFieldNumber = 11;

	private uint areaId_;

	public const int StaticPropIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_staticPropIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> staticPropIdList_ = new RepeatedField<uint>();

	public const int VerifyStepIdListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_verifyStepIdList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> verifyStepIdList_ = new RepeatedField<uint>();

	public const int ProgressFieldNumber = 15;

	private uint progress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyArea> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyAreaReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> StepIdList => stepIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AreaDynamicInfo> DynamicInfo => dynamicInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaStepInfo AreaStepInfo
	{
		get
		{
			return areaStepInfo_;
		}
		set
		{
			areaStepInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> StaticPropIdList => staticPropIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> VerifyStepIdList => verifyStepIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyArea()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyArea(TrainPartyArea other)
		: this()
	{
		stepIdList_ = other.stepIdList_.Clone();
		dynamicInfo_ = other.dynamicInfo_.Clone();
		areaStepInfo_ = ((other.areaStepInfo_ != null) ? other.areaStepInfo_.Clone() : null);
		areaId_ = other.areaId_;
		staticPropIdList_ = other.staticPropIdList_.Clone();
		verifyStepIdList_ = other.verifyStepIdList_.Clone();
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyArea Clone()
	{
		return new TrainPartyArea(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyArea);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyArea other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!stepIdList_.Equals(other.stepIdList_))
		{
			return false;
		}
		if (!dynamicInfo_.Equals(other.dynamicInfo_))
		{
			return false;
		}
		if (!object.Equals(AreaStepInfo, other.AreaStepInfo))
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!staticPropIdList_.Equals(other.staticPropIdList_))
		{
			return false;
		}
		if (!verifyStepIdList_.Equals(other.verifyStepIdList_))
		{
			return false;
		}
		if (Progress != other.Progress)
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
		num ^= stepIdList_.GetHashCode();
		num ^= dynamicInfo_.GetHashCode();
		if (areaStepInfo_ != null)
		{
			num ^= AreaStepInfo.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= staticPropIdList_.GetHashCode();
		num ^= verifyStepIdList_.GetHashCode();
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
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
		stepIdList_.WriteTo(ref output, _repeated_stepIdList_codec);
		dynamicInfo_.WriteTo(ref output, _repeated_dynamicInfo_codec);
		if (areaStepInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(AreaStepInfo);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AreaId);
		}
		staticPropIdList_.WriteTo(ref output, _repeated_staticPropIdList_codec);
		verifyStepIdList_.WriteTo(ref output, _repeated_verifyStepIdList_codec);
		if (Progress != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Progress);
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
		num += stepIdList_.CalculateSize(_repeated_stepIdList_codec);
		num += dynamicInfo_.CalculateSize(_repeated_dynamicInfo_codec);
		if (areaStepInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AreaStepInfo);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += staticPropIdList_.CalculateSize(_repeated_staticPropIdList_codec);
		num += verifyStepIdList_.CalculateSize(_repeated_verifyStepIdList_codec);
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyArea other)
	{
		if (other == null)
		{
			return;
		}
		stepIdList_.Add(other.stepIdList_);
		dynamicInfo_.Add(other.dynamicInfo_);
		if (other.areaStepInfo_ != null)
		{
			if (areaStepInfo_ == null)
			{
				AreaStepInfo = new AreaStepInfo();
			}
			AreaStepInfo.MergeFrom(other.AreaStepInfo);
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
		}
		staticPropIdList_.Add(other.staticPropIdList_);
		verifyStepIdList_.Add(other.verifyStepIdList_);
		if (other.Progress != 0)
		{
			Progress = other.Progress;
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
			case 56u:
			case 58u:
				stepIdList_.AddEntriesFrom(ref input, _repeated_stepIdList_codec);
				break;
			case 66u:
				dynamicInfo_.AddEntriesFrom(ref input, _repeated_dynamicInfo_codec);
				break;
			case 82u:
				if (areaStepInfo_ == null)
				{
					AreaStepInfo = new AreaStepInfo();
				}
				input.ReadMessage(AreaStepInfo);
				break;
			case 88u:
				AreaId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				staticPropIdList_.AddEntriesFrom(ref input, _repeated_staticPropIdList_codec);
				break;
			case 104u:
			case 106u:
				verifyStepIdList_.AddEntriesFrom(ref input, _repeated_verifyStepIdList_codec);
				break;
			case 120u:
				Progress = input.ReadUInt32();
				break;
			}
		}
	}
}
