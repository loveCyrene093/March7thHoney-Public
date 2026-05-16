using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RevcMsgScNotify : IMessage<RevcMsgScNotify>, IMessage, IEquatable<RevcMsgScNotify>, IDeepCloneable<RevcMsgScNotify>, IBufferMessage
{
	private static readonly MessageParser<RevcMsgScNotify> _parser = new MessageParser<RevcMsgScNotify>(() => new RevcMsgScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ChatTypeFieldNumber = 5;

	private ChatType chatType_;

	public const int SourceUidFieldNumber = 9;

	private uint sourceUid_;

	public const int RecvMessageDataFieldNumber = 15;

	private ChatMessageData recvMessageData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RevcMsgScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RevcMsgScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint SourceUid
	{
		get
		{
			return sourceUid_;
		}
		set
		{
			sourceUid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageData RecvMessageData
	{
		get
		{
			return recvMessageData_;
		}
		set
		{
			recvMessageData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RevcMsgScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RevcMsgScNotify(RevcMsgScNotify other)
		: this()
	{
		chatType_ = other.chatType_;
		sourceUid_ = other.sourceUid_;
		recvMessageData_ = ((other.recvMessageData_ != null) ? other.recvMessageData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RevcMsgScNotify Clone()
	{
		return new RevcMsgScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RevcMsgScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RevcMsgScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChatType != other.ChatType)
		{
			return false;
		}
		if (SourceUid != other.SourceUid)
		{
			return false;
		}
		if (!object.Equals(RecvMessageData, other.RecvMessageData))
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
		if (ChatType != ChatType.None)
		{
			num ^= ChatType.GetHashCode();
		}
		if (SourceUid != 0)
		{
			num ^= SourceUid.GetHashCode();
		}
		if (recvMessageData_ != null)
		{
			num ^= RecvMessageData.GetHashCode();
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
		if (ChatType != ChatType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ChatType);
		}
		if (SourceUid != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(SourceUid);
		}
		if (recvMessageData_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(RecvMessageData);
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
		if (ChatType != ChatType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ChatType);
		}
		if (SourceUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SourceUid);
		}
		if (recvMessageData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RecvMessageData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RevcMsgScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ChatType != ChatType.None)
		{
			ChatType = other.ChatType;
		}
		if (other.SourceUid != 0)
		{
			SourceUid = other.SourceUid;
		}
		if (other.recvMessageData_ != null)
		{
			if (recvMessageData_ == null)
			{
				RecvMessageData = new ChatMessageData();
			}
			RecvMessageData.MergeFrom(other.RecvMessageData);
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
			case 40u:
				ChatType = (ChatType)input.ReadEnum();
				break;
			case 72u:
				SourceUid = input.ReadUInt32();
				break;
			case 122u:
				if (recvMessageData_ == null)
				{
					RecvMessageData = new ChatMessageData();
				}
				input.ReadMessage(RecvMessageData);
				break;
			}
		}
	}
}
