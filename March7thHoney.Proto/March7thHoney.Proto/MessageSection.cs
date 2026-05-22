using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MessageSection : IMessage<MessageSection>, IMessage, IEquatable<MessageSection>, IDeepCloneable<MessageSection>, IBufferMessage
{
	private static readonly MessageParser<MessageSection> _parser = new MessageParser<MessageSection>(() => new MessageSection());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 2;

	private MessageSectionStatus status_;

	public const int MessageItemListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_messageItemList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> messageItemList_ = new RepeatedField<uint>();

	public const int FrozenItemIdFieldNumber = 7;

	private uint frozenItemId_;

	public const int ItemListFieldNumber = 12;

	private static readonly FieldCodec<MessageItem> _repeated_itemList_codec = FieldCodec.ForMessage(98u, MessageItem.Parser);

	private readonly RepeatedField<MessageItem> itemList_ = new RepeatedField<MessageItem>();

	public const int IdFieldNumber = 13;

	private uint id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MessageSection> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MessageSectionReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageSectionStatus Status
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
	public RepeatedField<uint> MessageItemList => messageItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FrozenItemId
	{
		get
		{
			return frozenItemId_;
		}
		set
		{
			frozenItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MessageItem> ItemList => itemList_;

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
	public MessageSection()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageSection(MessageSection other)
		: this()
	{
		status_ = other.status_;
		messageItemList_ = other.messageItemList_.Clone();
		frozenItemId_ = other.frozenItemId_;
		itemList_ = other.itemList_.Clone();
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageSection Clone()
	{
		return new MessageSection(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MessageSection);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MessageSection other)
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
		if (!messageItemList_.Equals(other.messageItemList_))
		{
			return false;
		}
		if (FrozenItemId != other.FrozenItemId)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (Id != other.Id)
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
		if (Status != MessageSectionStatus.MessageSectionNone)
		{
			num ^= Status.GetHashCode();
		}
		num ^= messageItemList_.GetHashCode();
		if (FrozenItemId != 0)
		{
			num ^= FrozenItemId.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (Status != MessageSectionStatus.MessageSectionNone)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Status);
		}
		messageItemList_.WriteTo(ref output, _repeated_messageItemList_codec);
		if (FrozenItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FrozenItemId);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (Id != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Id);
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
		if (Status != MessageSectionStatus.MessageSectionNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		num += messageItemList_.CalculateSize(_repeated_messageItemList_codec);
		if (FrozenItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FrozenItemId);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MessageSection other)
	{
		if (other != null)
		{
			if (other.Status != MessageSectionStatus.MessageSectionNone)
			{
				Status = other.Status;
			}
			messageItemList_.Add(other.messageItemList_);
			if (other.FrozenItemId != 0)
			{
				FrozenItemId = other.FrozenItemId;
			}
			itemList_.Add(other.itemList_);
			if (other.Id != 0)
			{
				Id = other.Id;
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
				Status = (MessageSectionStatus)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				messageItemList_.AddEntriesFrom(ref input, _repeated_messageItemList_codec);
				break;
			case 56u:
				FrozenItemId = input.ReadUInt32();
				break;
			case 98u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 104u:
				Id = input.ReadUInt32();
				break;
			}
		}
	}
}
