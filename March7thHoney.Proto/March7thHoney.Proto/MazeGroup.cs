using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MazeGroup : IMessage<MazeGroup>, IMessage, IEquatable<MazeGroup>, IDeepCloneable<MazeGroup>, IBufferMessage
{
	private static readonly MessageParser<MazeGroup> _parser = new MessageParser<MazeGroup>(() => new MazeGroup());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 4;

	private uint groupId_;

	public const int IsNeedRefreshFieldNumber = 6;

	private bool isNeedRefresh_;

	public const int DestoryMonsterConfigIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_destoryMonsterConfigIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> destoryMonsterConfigIdList_ = new RepeatedField<uint>();

	public const int PropertyMapFieldNumber = 12;

	private static readonly MapField<string, int>.Codec _map_propertyMap_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 98u);

	private readonly MapField<string, int> propertyMap_ = new MapField<string, int>();

	public const int ModifyTimeFieldNumber = 15;

	private long modifyTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MazeGroup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MazeGroupReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNeedRefresh
	{
		get
		{
			return isNeedRefresh_;
		}
		set
		{
			isNeedRefresh_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DestoryMonsterConfigIdList => destoryMonsterConfigIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> PropertyMap => propertyMap_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ModifyTime
	{
		get
		{
			return modifyTime_;
		}
		set
		{
			modifyTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeGroup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeGroup(MazeGroup other)
		: this()
	{
		groupId_ = other.groupId_;
		isNeedRefresh_ = other.isNeedRefresh_;
		destoryMonsterConfigIdList_ = other.destoryMonsterConfigIdList_.Clone();
		propertyMap_ = other.propertyMap_.Clone();
		modifyTime_ = other.modifyTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeGroup Clone()
	{
		return new MazeGroup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MazeGroup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MazeGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (IsNeedRefresh != other.IsNeedRefresh)
		{
			return false;
		}
		if (!destoryMonsterConfigIdList_.Equals(other.destoryMonsterConfigIdList_))
		{
			return false;
		}
		if (!PropertyMap.Equals(other.PropertyMap))
		{
			return false;
		}
		if (ModifyTime != other.ModifyTime)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (IsNeedRefresh)
		{
			num ^= IsNeedRefresh.GetHashCode();
		}
		num ^= destoryMonsterConfigIdList_.GetHashCode();
		num ^= PropertyMap.GetHashCode();
		if (ModifyTime != 0L)
		{
			num ^= ModifyTime.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GroupId);
		}
		if (IsNeedRefresh)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsNeedRefresh);
		}
		destoryMonsterConfigIdList_.WriteTo(ref output, _repeated_destoryMonsterConfigIdList_codec);
		propertyMap_.WriteTo(ref output, _map_propertyMap_codec);
		if (ModifyTime != 0L)
		{
			output.WriteRawTag(120);
			output.WriteInt64(ModifyTime);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (IsNeedRefresh)
		{
			num += 2;
		}
		num += destoryMonsterConfigIdList_.CalculateSize(_repeated_destoryMonsterConfigIdList_codec);
		num += propertyMap_.CalculateSize(_map_propertyMap_codec);
		if (ModifyTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ModifyTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MazeGroup other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.IsNeedRefresh)
			{
				IsNeedRefresh = other.IsNeedRefresh;
			}
			destoryMonsterConfigIdList_.Add(other.destoryMonsterConfigIdList_);
			propertyMap_.MergeFrom(other.propertyMap_);
			if (other.ModifyTime != 0L)
			{
				ModifyTime = other.ModifyTime;
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
			case 32u:
				GroupId = input.ReadUInt32();
				break;
			case 48u:
				IsNeedRefresh = input.ReadBool();
				break;
			case 88u:
			case 90u:
				destoryMonsterConfigIdList_.AddEntriesFrom(ref input, _repeated_destoryMonsterConfigIdList_codec);
				break;
			case 98u:
				propertyMap_.AddEntriesFrom(ref input, _map_propertyMap_codec);
				break;
			case 120u:
				ModifyTime = input.ReadInt64();
				break;
			}
		}
	}
}
