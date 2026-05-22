using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleBuff : IMessage<BattleBuff>, IMessage, IEquatable<BattleBuff>, IDeepCloneable<BattleBuff>, IBufferMessage
{
	private static readonly MessageParser<BattleBuff> _parser = new MessageParser<BattleBuff>(() => new BattleBuff());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int OwnerIndexFieldNumber = 3;

	private uint ownerIndex_;

	public const int WaveFlagFieldNumber = 4;

	private uint waveFlag_;

	public const int TargetIndexListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_targetIndexList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> targetIndexList_ = new RepeatedField<uint>();

	public const int DynamicValuesFieldNumber = 6;

	private static readonly MapField<string, float>.Codec _map_dynamicValues_codec = new MapField<string, float>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForFloat(21u, 0f), 50u);

	private readonly MapField<string, float> dynamicValues_ = new MapField<string, float>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleBuff> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleBuffReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
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
	public uint OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WaveFlag
	{
		get
		{
			return waveFlag_;
		}
		set
		{
			waveFlag_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TargetIndexList => targetIndexList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, float> DynamicValues => dynamicValues_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleBuff()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleBuff(BattleBuff other)
		: this()
	{
		id_ = other.id_;
		level_ = other.level_;
		ownerIndex_ = other.ownerIndex_;
		waveFlag_ = other.waveFlag_;
		targetIndexList_ = other.targetIndexList_.Clone();
		dynamicValues_ = other.dynamicValues_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleBuff Clone()
	{
		return new BattleBuff(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleBuff);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleBuff other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (OwnerIndex != other.OwnerIndex)
		{
			return false;
		}
		if (WaveFlag != other.WaveFlag)
		{
			return false;
		}
		if (!targetIndexList_.Equals(other.targetIndexList_))
		{
			return false;
		}
		if (!DynamicValues.Equals(other.DynamicValues))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (OwnerIndex != 0)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (WaveFlag != 0)
		{
			num ^= WaveFlag.GetHashCode();
		}
		num ^= targetIndexList_.GetHashCode();
		num ^= DynamicValues.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (OwnerIndex != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OwnerIndex);
		}
		if (WaveFlag != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(WaveFlag);
		}
		targetIndexList_.WriteTo(ref output, _repeated_targetIndexList_codec);
		dynamicValues_.WriteTo(ref output, _map_dynamicValues_codec);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (OwnerIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OwnerIndex);
		}
		if (WaveFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WaveFlag);
		}
		num += targetIndexList_.CalculateSize(_repeated_targetIndexList_codec);
		num += dynamicValues_.CalculateSize(_map_dynamicValues_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleBuff other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.OwnerIndex != 0)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.WaveFlag != 0)
			{
				WaveFlag = other.WaveFlag;
			}
			targetIndexList_.Add(other.targetIndexList_);
			dynamicValues_.MergeFrom(other.dynamicValues_);
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
				Id = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				OwnerIndex = input.ReadUInt32();
				break;
			case 32u:
				WaveFlag = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				targetIndexList_.AddEntriesFrom(ref input, _repeated_targetIndexList_codec);
				break;
			case 50u:
				dynamicValues_.AddEntriesFrom(ref input, _map_dynamicValues_codec);
				break;
			}
		}
	}
}
