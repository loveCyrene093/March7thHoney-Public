using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SendMsgCsReq : IMessage<SendMsgCsReq>, IMessage, IEquatable<SendMsgCsReq>, IDeepCloneable<SendMsgCsReq>, IBufferMessage
{
	private static readonly MessageParser<SendMsgCsReq> _parser = new MessageParser<SendMsgCsReq>(() => new SendMsgCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MessageDatasFieldNumber = 8;

	private MessageChatData messageDatas_;

	public const int TargetListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_targetList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> targetList_ = new RepeatedField<uint>();

	public const int ChatTypeFieldNumber = 13;

	private ChatType chatType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SendMsgCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SendMsgCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageChatData MessageDatas
	{
		get
		{
			return messageDatas_;
		}
		set
		{
			messageDatas_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TargetList => targetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatType ChatType
	{
		get
		{
			return chatType_;
		}
		set
		{
			chatType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SendMsgCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SendMsgCsReq(SendMsgCsReq other)
		: this()
	{
		messageDatas_ = ((other.messageDatas_ != null) ? other.messageDatas_.Clone() : null);
		targetList_ = other.targetList_.Clone();
		chatType_ = other.chatType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SendMsgCsReq Clone()
	{
		return new SendMsgCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SendMsgCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SendMsgCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MessageDatas, other.MessageDatas))
		{
			return false;
		}
		if (!targetList_.Equals(other.targetList_))
		{
			return false;
		}
		if (ChatType != other.ChatType)
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
		if (messageDatas_ != null)
		{
			num ^= MessageDatas.GetHashCode();
		}
		num ^= targetList_.GetHashCode();
		if (ChatType != ChatType.None)
		{
			num ^= ChatType.GetHashCode();
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
		if (messageDatas_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(MessageDatas);
		}
		targetList_.WriteTo(ref output, _repeated_targetList_codec);
		if (ChatType != ChatType.None)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)ChatType);
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
		if (messageDatas_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MessageDatas);
		}
		num += targetList_.CalculateSize(_repeated_targetList_codec);
		if (ChatType != ChatType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ChatType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SendMsgCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.messageDatas_ != null)
		{
			if (messageDatas_ == null)
			{
				MessageDatas = new MessageChatData();
			}
			MessageDatas.MergeFrom(other.MessageDatas);
		}
		targetList_.Add(other.targetList_);
		if (other.ChatType != ChatType.None)
		{
			ChatType = other.ChatType;
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
			case 66u:
				if (messageDatas_ == null)
				{
					MessageDatas = new MessageChatData();
				}
				input.ReadMessage(MessageDatas);
				break;
			case 72u:
			case 74u:
				targetList_.AddEntriesFrom(ref input, _repeated_targetList_codec);
				break;
			case 104u:
				ChatType = (ChatType)input.ReadEnum();
				break;
			}
		}
	}
}
