using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatMessageData : IMessage<ChatMessageData>, IMessage, IEquatable<ChatMessageData>, IDeepCloneable<ChatMessageData>, IBufferMessage
{
	private static readonly MessageParser<ChatMessageData> _parser = new MessageParser<ChatMessageData>(() => new ChatMessageData());

	private UnknownFieldSet _unknownFields;

	public const int CreateTimeFieldNumber = 4;

	private ulong createTime_;

	public const int SourceDataFieldNumber = 8;

	private SourceData sourceData_;

	public const int MessageDatasFieldNumber = 9;

	private static readonly FieldCodec<MessageChatData> _repeated_messageDatas_codec = FieldCodec.ForMessage(74u, MessageChatData.Parser);

	private readonly RepeatedField<MessageChatData> messageDatas_ = new RepeatedField<MessageChatData>();

	public const int ExtraAFieldNumber = 10;

	private ChatMessageExtra extraA_;

	public const int ExtraBFieldNumber = 11;

	private ChatMessageExtra extraB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChatMessageData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChatMessageDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceData SourceData
	{
		get
		{
			return sourceData_;
		}
		set
		{
			sourceData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MessageChatData> MessageDatas => messageDatas_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageExtra ExtraA
	{
		get
		{
			return extraA_;
		}
		set
		{
			extraA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageExtra ExtraB
	{
		get
		{
			return extraB_;
		}
		set
		{
			extraB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageData(ChatMessageData other)
		: this()
	{
		createTime_ = other.createTime_;
		sourceData_ = ((other.sourceData_ != null) ? other.sourceData_.Clone() : null);
		messageDatas_ = other.messageDatas_.Clone();
		extraA_ = ((other.extraA_ != null) ? other.extraA_.Clone() : null);
		extraB_ = ((other.extraB_ != null) ? other.extraB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageData Clone()
	{
		return new ChatMessageData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChatMessageData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChatMessageData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (!object.Equals(SourceData, other.SourceData))
		{
			return false;
		}
		if (!messageDatas_.Equals(other.messageDatas_))
		{
			return false;
		}
		if (!object.Equals(ExtraA, other.ExtraA))
		{
			return false;
		}
		if (!object.Equals(ExtraB, other.ExtraB))
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
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (sourceData_ != null)
		{
			num ^= SourceData.GetHashCode();
		}
		num ^= messageDatas_.GetHashCode();
		if (extraA_ != null)
		{
			num ^= ExtraA.GetHashCode();
		}
		if (extraB_ != null)
		{
			num ^= ExtraB.GetHashCode();
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
		if (CreateTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(CreateTime);
		}
		if (sourceData_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(SourceData);
		}
		messageDatas_.WriteTo(ref output, _repeated_messageDatas_codec);
		if (extraA_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ExtraA);
		}
		if (extraB_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(ExtraB);
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
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CreateTime);
		}
		if (sourceData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SourceData);
		}
		num += messageDatas_.CalculateSize(_repeated_messageDatas_codec);
		if (extraA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraA);
		}
		if (extraB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChatMessageData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CreateTime != 0L)
		{
			CreateTime = other.CreateTime;
		}
		if (other.sourceData_ != null)
		{
			if (sourceData_ == null)
			{
				SourceData = new SourceData();
			}
			SourceData.MergeFrom(other.SourceData);
		}
		messageDatas_.Add(other.messageDatas_);
		if (other.extraA_ != null)
		{
			if (extraA_ == null)
			{
				ExtraA = new ChatMessageExtra();
			}
			ExtraA.MergeFrom(other.ExtraA);
		}
		if (other.extraB_ != null)
		{
			if (extraB_ == null)
			{
				ExtraB = new ChatMessageExtra();
			}
			ExtraB.MergeFrom(other.ExtraB);
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
			case 32u:
				CreateTime = input.ReadUInt64();
				break;
			case 66u:
				if (sourceData_ == null)
				{
					SourceData = new SourceData();
				}
				input.ReadMessage(SourceData);
				break;
			case 74u:
				messageDatas_.AddEntriesFrom(ref input, _repeated_messageDatas_codec);
				break;
			case 82u:
				if (extraA_ == null)
				{
					ExtraA = new ChatMessageExtra();
				}
				input.ReadMessage(ExtraA);
				break;
			case 90u:
				if (extraB_ == null)
				{
					ExtraB = new ChatMessageExtra();
				}
				input.ReadMessage(ExtraB);
				break;
			}
		}
	}
}
