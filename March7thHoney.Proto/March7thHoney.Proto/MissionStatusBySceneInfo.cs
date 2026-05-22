using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionStatusBySceneInfo : IMessage<MissionStatusBySceneInfo>, IMessage, IEquatable<MissionStatusBySceneInfo>, IDeepCloneable<MissionStatusBySceneInfo>, IBufferMessage
{
	private static readonly MessageParser<MissionStatusBySceneInfo> _parser = new MessageParser<MissionStatusBySceneInfo>(() => new MissionStatusBySceneInfo());

	private UnknownFieldSet _unknownFields;

	public const int DisabledMainMissionIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_disabledMainMissionIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> disabledMainMissionIdList_ = new RepeatedField<uint>();

	public const int SubMissionStatusListFieldNumber = 2;

	private static readonly FieldCodec<Mission> _repeated_subMissionStatusList_codec = FieldCodec.ForMessage(18u, Mission.Parser);

	private readonly RepeatedField<Mission> subMissionStatusList_ = new RepeatedField<Mission>();

	public const int NEDJGJNLIPFFieldNumber = 4;

	private static readonly FieldCodec<MainMissionCustomValue> _repeated_nEDJGJNLIPF_codec = FieldCodec.ForMessage(34u, MainMissionCustomValue.Parser);

	private readonly RepeatedField<MainMissionCustomValue> nEDJGJNLIPF_ = new RepeatedField<MainMissionCustomValue>();

	public const int UnfinishedMainMissionIdListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_unfinishedMainMissionIdList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> unfinishedMainMissionIdList_ = new RepeatedField<uint>();

	public const int FinishedMainMissionIdListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_finishedMainMissionIdList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> finishedMainMissionIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionStatusBySceneInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionStatusBySceneInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DisabledMainMissionIdList => disabledMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Mission> SubMissionStatusList => subMissionStatusList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MainMissionCustomValue> NEDJGJNLIPF => nEDJGJNLIPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedMainMissionIdList => unfinishedMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedMainMissionIdList => finishedMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionStatusBySceneInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionStatusBySceneInfo(MissionStatusBySceneInfo other)
		: this()
	{
		disabledMainMissionIdList_ = other.disabledMainMissionIdList_.Clone();
		subMissionStatusList_ = other.subMissionStatusList_.Clone();
		nEDJGJNLIPF_ = other.nEDJGJNLIPF_.Clone();
		unfinishedMainMissionIdList_ = other.unfinishedMainMissionIdList_.Clone();
		finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionStatusBySceneInfo Clone()
	{
		return new MissionStatusBySceneInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionStatusBySceneInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionStatusBySceneInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!disabledMainMissionIdList_.Equals(other.disabledMainMissionIdList_))
		{
			return false;
		}
		if (!subMissionStatusList_.Equals(other.subMissionStatusList_))
		{
			return false;
		}
		if (!nEDJGJNLIPF_.Equals(other.nEDJGJNLIPF_))
		{
			return false;
		}
		if (!unfinishedMainMissionIdList_.Equals(other.unfinishedMainMissionIdList_))
		{
			return false;
		}
		if (!finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_))
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
		num ^= disabledMainMissionIdList_.GetHashCode();
		num ^= subMissionStatusList_.GetHashCode();
		num ^= nEDJGJNLIPF_.GetHashCode();
		num ^= unfinishedMainMissionIdList_.GetHashCode();
		num ^= finishedMainMissionIdList_.GetHashCode();
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
		disabledMainMissionIdList_.WriteTo(ref output, _repeated_disabledMainMissionIdList_codec);
		subMissionStatusList_.WriteTo(ref output, _repeated_subMissionStatusList_codec);
		nEDJGJNLIPF_.WriteTo(ref output, _repeated_nEDJGJNLIPF_codec);
		unfinishedMainMissionIdList_.WriteTo(ref output, _repeated_unfinishedMainMissionIdList_codec);
		finishedMainMissionIdList_.WriteTo(ref output, _repeated_finishedMainMissionIdList_codec);
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
		num += disabledMainMissionIdList_.CalculateSize(_repeated_disabledMainMissionIdList_codec);
		num += subMissionStatusList_.CalculateSize(_repeated_subMissionStatusList_codec);
		num += nEDJGJNLIPF_.CalculateSize(_repeated_nEDJGJNLIPF_codec);
		num += unfinishedMainMissionIdList_.CalculateSize(_repeated_unfinishedMainMissionIdList_codec);
		num += finishedMainMissionIdList_.CalculateSize(_repeated_finishedMainMissionIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionStatusBySceneInfo other)
	{
		if (other != null)
		{
			disabledMainMissionIdList_.Add(other.disabledMainMissionIdList_);
			subMissionStatusList_.Add(other.subMissionStatusList_);
			nEDJGJNLIPF_.Add(other.nEDJGJNLIPF_);
			unfinishedMainMissionIdList_.Add(other.unfinishedMainMissionIdList_);
			finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
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
			case 10u:
				disabledMainMissionIdList_.AddEntriesFrom(ref input, _repeated_disabledMainMissionIdList_codec);
				break;
			case 18u:
				subMissionStatusList_.AddEntriesFrom(ref input, _repeated_subMissionStatusList_codec);
				break;
			case 34u:
				nEDJGJNLIPF_.AddEntriesFrom(ref input, _repeated_nEDJGJNLIPF_codec);
				break;
			case 72u:
			case 74u:
				unfinishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_unfinishedMainMissionIdList_codec);
				break;
			case 104u:
			case 106u:
				finishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_finishedMainMissionIdList_codec);
				break;
			}
		}
	}
}
