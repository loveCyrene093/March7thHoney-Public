using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupStatus : IMessage<GroupStatus>, IMessage, IEquatable<GroupStatus>, IDeepCloneable<GroupStatus>, IBufferMessage
{
	private static readonly MessageParser<GroupStatus> _parser = new MessageParser<GroupStatus>(() => new GroupStatus());

	private UnknownFieldSet _unknownFields;

	public const int GroupStatus_FieldNumber = 3;

	private MessageGroupStatus groupStatus_;

	public const int GroupIdFieldNumber = 5;

	private uint groupId_;

	public const int RefreshTimeFieldNumber = 9;

	private long refreshTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupStatus> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GroupStatusReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageGroupStatus GroupStatus_
	{
		get
		{
			return groupStatus_;
		}
		set
		{
			groupStatus_ = value;
		}
	}

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
	public long RefreshTime
	{
		get
		{
			return refreshTime_;
		}
		set
		{
			refreshTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStatus()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStatus(GroupStatus other)
		: this()
	{
		groupStatus_ = other.groupStatus_;
		groupId_ = other.groupId_;
		refreshTime_ = other.refreshTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupStatus Clone()
	{
		return new GroupStatus(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GroupStatus);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupStatus_ != other.GroupStatus_)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (RefreshTime != other.RefreshTime)
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
		if (GroupStatus_ != MessageGroupStatus.MessageGroupNone)
		{
			num ^= GroupStatus_.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (RefreshTime != 0L)
		{
			num ^= RefreshTime.GetHashCode();
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
		if (GroupStatus_ != MessageGroupStatus.MessageGroupNone)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)GroupStatus_);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GroupId);
		}
		if (RefreshTime != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(RefreshTime);
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
		if (GroupStatus_ != MessageGroupStatus.MessageGroupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GroupStatus_);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (RefreshTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RefreshTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GroupStatus other)
	{
		if (other != null)
		{
			if (other.GroupStatus_ != MessageGroupStatus.MessageGroupNone)
			{
				GroupStatus_ = other.GroupStatus_;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.RefreshTime != 0L)
			{
				RefreshTime = other.RefreshTime;
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
			case 24u:
				GroupStatus_ = (MessageGroupStatus)input.ReadEnum();
				break;
			case 40u:
				GroupId = input.ReadUInt32();
				break;
			case 72u:
				RefreshTime = input.ReadInt64();
				break;
			}
		}
	}
}
