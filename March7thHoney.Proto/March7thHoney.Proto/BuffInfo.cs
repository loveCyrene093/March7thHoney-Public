using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BuffInfo : IMessage<BuffInfo>, IMessage, IEquatable<BuffInfo>, IDeepCloneable<BuffInfo>, IBufferMessage
{
	private static readonly MessageParser<BuffInfo> _parser = new MessageParser<BuffInfo>(() => new BuffInfo());

	private UnknownFieldSet _unknownFields;

	public const int CountFieldNumber = 2;

	private uint count_;

	public const int BuffIdFieldNumber = 4;

	private uint buffId_;

	public const int AddTimeMsFieldNumber = 6;

	private ulong addTimeMs_;

	public const int LevelFieldNumber = 9;

	private uint level_;

	public const int DynamicValuesFieldNumber = 10;

	private static readonly MapField<string, float>.Codec _map_dynamicValues_codec = new MapField<string, float>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForFloat(21u, 0f), 82u);

	private readonly MapField<string, float> dynamicValues_ = new MapField<string, float>();

	public const int BuffSummonEntityIdFieldNumber = 13;

	private uint buffSummonEntityId_;

	public const int LifeTimeFieldNumber = 14;

	private float lifeTime_;

	public const int BaseAvatarIdFieldNumber = 15;

	private uint baseAvatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuffInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
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
	public ulong AddTimeMs
	{
		get
		{
			return addTimeMs_;
		}
		set
		{
			addTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, float> DynamicValues => dynamicValues_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffSummonEntityId
	{
		get
		{
			return buffSummonEntityId_;
		}
		set
		{
			buffSummonEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float LifeTime
	{
		get
		{
			return lifeTime_;
		}
		set
		{
			lifeTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffInfo(BuffInfo other)
		: this()
	{
		count_ = other.count_;
		buffId_ = other.buffId_;
		addTimeMs_ = other.addTimeMs_;
		level_ = other.level_;
		dynamicValues_ = other.dynamicValues_.Clone();
		buffSummonEntityId_ = other.buffSummonEntityId_;
		lifeTime_ = other.lifeTime_;
		baseAvatarId_ = other.baseAvatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffInfo Clone()
	{
		return new BuffInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuffInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuffInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (AddTimeMs != other.AddTimeMs)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!DynamicValues.Equals(other.DynamicValues))
		{
			return false;
		}
		if (BuffSummonEntityId != other.BuffSummonEntityId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LifeTime, other.LifeTime))
		{
			return false;
		}
		if (BaseAvatarId != other.BaseAvatarId)
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (AddTimeMs != 0L)
		{
			num ^= AddTimeMs.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= DynamicValues.GetHashCode();
		if (BuffSummonEntityId != 0)
		{
			num ^= BuffSummonEntityId.GetHashCode();
		}
		if (LifeTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LifeTime);
		}
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BuffId);
		}
		if (AddTimeMs != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(AddTimeMs);
		}
		if (Level != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Level);
		}
		dynamicValues_.WriteTo(ref output, _map_dynamicValues_codec);
		if (BuffSummonEntityId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BuffSummonEntityId);
		}
		if (LifeTime != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(LifeTime);
		}
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BaseAvatarId);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (AddTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(AddTimeMs);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		num += dynamicValues_.CalculateSize(_map_dynamicValues_codec);
		if (BuffSummonEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffSummonEntityId);
		}
		if (LifeTime != 0f)
		{
			num += 5;
		}
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuffInfo other)
	{
		if (other != null)
		{
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.AddTimeMs != 0L)
			{
				AddTimeMs = other.AddTimeMs;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			dynamicValues_.MergeFrom(other.dynamicValues_);
			if (other.BuffSummonEntityId != 0)
			{
				BuffSummonEntityId = other.BuffSummonEntityId;
			}
			if (other.LifeTime != 0f)
			{
				LifeTime = other.LifeTime;
			}
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
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
			case 16u:
				Count = input.ReadUInt32();
				break;
			case 32u:
				BuffId = input.ReadUInt32();
				break;
			case 48u:
				AddTimeMs = input.ReadUInt64();
				break;
			case 72u:
				Level = input.ReadUInt32();
				break;
			case 82u:
				dynamicValues_.AddEntriesFrom(ref input, _map_dynamicValues_codec);
				break;
			case 104u:
				BuffSummonEntityId = input.ReadUInt32();
				break;
			case 117u:
				LifeTime = input.ReadFloat();
				break;
			case 120u:
				BaseAvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
