using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupSnapshot : IMessage<GroupSnapshot>, IMessage, IEquatable<GroupSnapshot>, IDeepCloneable<GroupSnapshot>, IBufferMessage
{
	private static readonly MessageParser<GroupSnapshot> _parser = new MessageParser<GroupSnapshot>(() => new GroupSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private uint groupId_;

	public const int GroupStateFieldNumber = 2;

	private uint groupState_;

	public const int EntityListFieldNumber = 3;

	private static readonly FieldCodec<EntitySnapshot> _repeated_entityList_codec = FieldCodec.ForMessage(26u, EntitySnapshot.Parser);

	private readonly RepeatedField<EntitySnapshot> entityList_ = new RepeatedField<EntitySnapshot>();

	public const int PropertyMapFieldNumber = 4;

	private static readonly MapField<string, int>.Codec _map_propertyMap_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 34u);

	private readonly MapField<string, int> propertyMap_ = new MapField<string, int>();

	public const int ActiveSubmissionListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_activeSubmissionList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> activeSubmissionList_ = new RepeatedField<uint>();

	public const int ActiveMcvKeyListFieldNumber = 6;

	private static readonly FieldCodec<ActiveMCVKeySnapshot> _repeated_activeMcvKeyList_codec = FieldCodec.ForMessage(50u, ActiveMCVKeySnapshot.Parser);

	private readonly RepeatedField<ActiveMCVKeySnapshot> activeMcvKeyList_ = new RepeatedField<ActiveMCVKeySnapshot>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GroupSnapshotReflection.Descriptor.MessageTypes[0];

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
	public uint GroupState
	{
		get
		{
			return groupState_;
		}
		set
		{
			groupState_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EntitySnapshot> EntityList => entityList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> PropertyMap => propertyMap_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ActiveSubmissionList => activeSubmissionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ActiveMCVKeySnapshot> ActiveMcvKeyList => activeMcvKeyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupSnapshot(GroupSnapshot other)
		: this()
	{
		groupId_ = other.groupId_;
		groupState_ = other.groupState_;
		entityList_ = other.entityList_.Clone();
		propertyMap_ = other.propertyMap_.Clone();
		activeSubmissionList_ = other.activeSubmissionList_.Clone();
		activeMcvKeyList_ = other.activeMcvKeyList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupSnapshot Clone()
	{
		return new GroupSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GroupSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupSnapshot other)
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
		if (GroupState != other.GroupState)
		{
			return false;
		}
		if (!entityList_.Equals(other.entityList_))
		{
			return false;
		}
		if (!PropertyMap.Equals(other.PropertyMap))
		{
			return false;
		}
		if (!activeSubmissionList_.Equals(other.activeSubmissionList_))
		{
			return false;
		}
		if (!activeMcvKeyList_.Equals(other.activeMcvKeyList_))
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
		if (GroupState != 0)
		{
			num ^= GroupState.GetHashCode();
		}
		num ^= entityList_.GetHashCode();
		num ^= PropertyMap.GetHashCode();
		num ^= activeSubmissionList_.GetHashCode();
		num ^= activeMcvKeyList_.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(GroupId);
		}
		if (GroupState != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GroupState);
		}
		entityList_.WriteTo(ref output, _repeated_entityList_codec);
		propertyMap_.WriteTo(ref output, _map_propertyMap_codec);
		activeSubmissionList_.WriteTo(ref output, _repeated_activeSubmissionList_codec);
		activeMcvKeyList_.WriteTo(ref output, _repeated_activeMcvKeyList_codec);
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
		if (GroupState != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupState);
		}
		num += entityList_.CalculateSize(_repeated_entityList_codec);
		num += propertyMap_.CalculateSize(_map_propertyMap_codec);
		num += activeSubmissionList_.CalculateSize(_repeated_activeSubmissionList_codec);
		num += activeMcvKeyList_.CalculateSize(_repeated_activeMcvKeyList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GroupSnapshot other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GroupState != 0)
			{
				GroupState = other.GroupState;
			}
			entityList_.Add(other.entityList_);
			propertyMap_.MergeFrom(other.propertyMap_);
			activeSubmissionList_.Add(other.activeSubmissionList_);
			activeMcvKeyList_.Add(other.activeMcvKeyList_);
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
				GroupId = input.ReadUInt32();
				break;
			case 16u:
				GroupState = input.ReadUInt32();
				break;
			case 26u:
				entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
				break;
			case 34u:
				propertyMap_.AddEntriesFrom(ref input, _map_propertyMap_codec);
				break;
			case 40u:
			case 42u:
				activeSubmissionList_.AddEntriesFrom(ref input, _repeated_activeSubmissionList_codec);
				break;
			case 50u:
				activeMcvKeyList_.AddEntriesFrom(ref input, _repeated_activeMcvKeyList_codec);
				break;
			}
		}
	}
}
