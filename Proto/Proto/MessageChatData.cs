using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MessageChatData : IMessage<MessageChatData>, IMessage, IEquatable<MessageChatData>, IDeepCloneable<MessageChatData>, IBufferMessage
{
	private static readonly MessageParser<MessageChatData> _parser = new MessageParser<MessageChatData>(() => new MessageChatData());

	private UnknownFieldSet _unknownFields;

	public const int MessageTypeFieldNumber = 1;

	private MsgType messageType_;

	public const int ChatDataFieldNumber = 2;

	private ChatData chatData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MessageChatData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MessageChatDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MsgType MessageType
	{
		get
		{
			return messageType_;
		}
		set
		{
			messageType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatData ChatData
	{
		get
		{
			return chatData_;
		}
		set
		{
			chatData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageChatData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageChatData(MessageChatData other)
		: this()
	{
		messageType_ = other.messageType_;
		chatData_ = ((other.chatData_ != null) ? other.chatData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageChatData Clone()
	{
		return new MessageChatData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MessageChatData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MessageChatData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MessageType != other.MessageType)
		{
			return false;
		}
		if (!object.Equals(ChatData, other.ChatData))
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
		if (MessageType != MsgType.None)
		{
			num ^= MessageType.GetHashCode();
		}
		if (chatData_ != null)
		{
			num ^= ChatData.GetHashCode();
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
		if (MessageType != MsgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MessageType);
		}
		if (chatData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ChatData);
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
		if (MessageType != MsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MessageType);
		}
		if (chatData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChatData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MessageChatData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MessageType != MsgType.None)
		{
			MessageType = other.MessageType;
		}
		if (other.chatData_ != null)
		{
			if (chatData_ == null)
			{
				ChatData = new ChatData();
			}
			ChatData.MergeFrom(other.ChatData);
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
				MessageType = (MsgType)input.ReadEnum();
				break;
			case 18u:
				if (chatData_ == null)
				{
					ChatData = new ChatData();
				}
				input.ReadMessage(ChatData);
				break;
			}
		}
	}
}
