using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MessageGroup : IMessage<MessageGroup>, IMessage, IEquatable<MessageGroup>, IDeepCloneable<MessageGroup>, IBufferMessage
{
	private static readonly MessageParser<MessageGroup> _parser = new MessageParser<MessageGroup>(() => new MessageGroup());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 5;

	private MessageGroupStatus status_;

	public const int IdFieldNumber = 11;

	private uint id_;

	public const int RefreshTimeFieldNumber = 12;

	private long refreshTime_;

	public const int MessageSectionListFieldNumber = 14;

	private static readonly FieldCodec<MessageSection> _repeated_messageSectionList_codec = FieldCodec.ForMessage(114u, MessageSection.Parser);

	private readonly RepeatedField<MessageSection> messageSectionList_ = new RepeatedField<MessageSection>();

	public const int MessageSectionIdFieldNumber = 15;

	private uint messageSectionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MessageGroup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MessageGroupReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageGroupStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

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
	public RepeatedField<MessageSection> MessageSectionList => messageSectionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MessageSectionId
	{
		get
		{
			return messageSectionId_;
		}
		set
		{
			messageSectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageGroup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageGroup(MessageGroup other)
		: this()
	{
		status_ = other.status_;
		id_ = other.id_;
		refreshTime_ = other.refreshTime_;
		messageSectionList_ = other.messageSectionList_.Clone();
		messageSectionId_ = other.messageSectionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageGroup Clone()
	{
		return new MessageGroup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MessageGroup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MessageGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (RefreshTime != other.RefreshTime)
		{
			return false;
		}
		if (!messageSectionList_.Equals(other.messageSectionList_))
		{
			return false;
		}
		if (MessageSectionId != other.MessageSectionId)
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
		if (Status != MessageGroupStatus.MessageGroupNone)
		{
			num ^= Status.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RefreshTime != 0L)
		{
			num ^= RefreshTime.GetHashCode();
		}
		num ^= messageSectionList_.GetHashCode();
		if (MessageSectionId != 0)
		{
			num ^= MessageSectionId.GetHashCode();
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
		if (Status != MessageGroupStatus.MessageGroupNone)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Status);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Id);
		}
		if (RefreshTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(RefreshTime);
		}
		messageSectionList_.WriteTo(ref output, _repeated_messageSectionList_codec);
		if (MessageSectionId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MessageSectionId);
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
		if (Status != MessageGroupStatus.MessageGroupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (RefreshTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RefreshTime);
		}
		num += messageSectionList_.CalculateSize(_repeated_messageSectionList_codec);
		if (MessageSectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MessageSectionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MessageGroup other)
	{
		if (other != null)
		{
			if (other.Status != MessageGroupStatus.MessageGroupNone)
			{
				Status = other.Status;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RefreshTime != 0L)
			{
				RefreshTime = other.RefreshTime;
			}
			messageSectionList_.Add(other.messageSectionList_);
			if (other.MessageSectionId != 0)
			{
				MessageSectionId = other.MessageSectionId;
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
			case 40u:
				Status = (MessageGroupStatus)input.ReadEnum();
				break;
			case 88u:
				Id = input.ReadUInt32();
				break;
			case 96u:
				RefreshTime = input.ReadInt64();
				break;
			case 114u:
				messageSectionList_.AddEntriesFrom(ref input, _repeated_messageSectionList_codec);
				break;
			case 120u:
				MessageSectionId = input.ReadUInt32();
				break;
			}
		}
	}
}
