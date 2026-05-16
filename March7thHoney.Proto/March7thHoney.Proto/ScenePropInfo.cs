using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ScenePropInfo : IMessage<ScenePropInfo>, IMessage, IEquatable<ScenePropInfo>, IDeepCloneable<ScenePropInfo>, IBufferMessage
{
	private static readonly MessageParser<ScenePropInfo> _parser = new MessageParser<ScenePropInfo>(() => new ScenePropInfo());

	private UnknownFieldSet _unknownFields;

	public const int LifeTimeMsFieldNumber = 1;

	private uint lifeTimeMs_;

	public const int PropStateFieldNumber = 2;

	private uint propState_;

	public const int TriggerNameListFieldNumber = 6;

	private static readonly FieldCodec<string> _repeated_triggerNameList_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> triggerNameList_ = new RepeatedField<string>();

	public const int ExtraInfoFieldNumber = 9;

	private PropExtraInfo extraInfo_;

	public const int CreateTimeMsFieldNumber = 12;

	private ulong createTimeMs_;

	public const int PropIdFieldNumber = 15;

	private uint propId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ScenePropInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ScenePropInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LifeTimeMs
	{
		get
		{
			return lifeTimeMs_;
		}
		set
		{
			lifeTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropState
	{
		get
		{
			return propState_;
		}
		set
		{
			propState_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> TriggerNameList => triggerNameList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropExtraInfo ExtraInfo
	{
		get
		{
			return extraInfo_;
		}
		set
		{
			extraInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong CreateTimeMs
	{
		get
		{
			return createTimeMs_;
		}
		set
		{
			createTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropId
	{
		get
		{
			return propId_;
		}
		set
		{
			propId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePropInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePropInfo(ScenePropInfo other)
		: this()
	{
		lifeTimeMs_ = other.lifeTimeMs_;
		propState_ = other.propState_;
		triggerNameList_ = other.triggerNameList_.Clone();
		extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
		createTimeMs_ = other.createTimeMs_;
		propId_ = other.propId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePropInfo Clone()
	{
		return new ScenePropInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ScenePropInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ScenePropInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LifeTimeMs != other.LifeTimeMs)
		{
			return false;
		}
		if (PropState != other.PropState)
		{
			return false;
		}
		if (!triggerNameList_.Equals(other.triggerNameList_))
		{
			return false;
		}
		if (!object.Equals(ExtraInfo, other.ExtraInfo))
		{
			return false;
		}
		if (CreateTimeMs != other.CreateTimeMs)
		{
			return false;
		}
		if (PropId != other.PropId)
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
		if (LifeTimeMs != 0)
		{
			num ^= LifeTimeMs.GetHashCode();
		}
		if (PropState != 0)
		{
			num ^= PropState.GetHashCode();
		}
		num ^= triggerNameList_.GetHashCode();
		if (extraInfo_ != null)
		{
			num ^= ExtraInfo.GetHashCode();
		}
		if (CreateTimeMs != 0L)
		{
			num ^= CreateTimeMs.GetHashCode();
		}
		if (PropId != 0)
		{
			num ^= PropId.GetHashCode();
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
		if (LifeTimeMs != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LifeTimeMs);
		}
		if (PropState != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PropState);
		}
		triggerNameList_.WriteTo(ref output, _repeated_triggerNameList_codec);
		if (extraInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ExtraInfo);
		}
		if (CreateTimeMs != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(CreateTimeMs);
		}
		if (PropId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PropId);
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
		if (LifeTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LifeTimeMs);
		}
		if (PropState != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropState);
		}
		num += triggerNameList_.CalculateSize(_repeated_triggerNameList_codec);
		if (extraInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraInfo);
		}
		if (CreateTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CreateTimeMs);
		}
		if (PropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ScenePropInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LifeTimeMs != 0)
		{
			LifeTimeMs = other.LifeTimeMs;
		}
		if (other.PropState != 0)
		{
			PropState = other.PropState;
		}
		triggerNameList_.Add(other.triggerNameList_);
		if (other.extraInfo_ != null)
		{
			if (extraInfo_ == null)
			{
				ExtraInfo = new PropExtraInfo();
			}
			ExtraInfo.MergeFrom(other.ExtraInfo);
		}
		if (other.CreateTimeMs != 0L)
		{
			CreateTimeMs = other.CreateTimeMs;
		}
		if (other.PropId != 0)
		{
			PropId = other.PropId;
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
			case 8u:
				LifeTimeMs = input.ReadUInt32();
				break;
			case 16u:
				PropState = input.ReadUInt32();
				break;
			case 50u:
				triggerNameList_.AddEntriesFrom(ref input, _repeated_triggerNameList_codec);
				break;
			case 74u:
				if (extraInfo_ == null)
				{
					ExtraInfo = new PropExtraInfo();
				}
				input.ReadMessage(ExtraInfo);
				break;
			case 96u:
				CreateTimeMs = input.ReadUInt64();
				break;
			case 120u:
				PropId = input.ReadUInt32();
				break;
			}
		}
	}
}
