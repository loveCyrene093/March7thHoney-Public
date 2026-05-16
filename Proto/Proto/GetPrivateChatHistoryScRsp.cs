using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPrivateChatHistoryScRsp : IMessage<GetPrivateChatHistoryScRsp>, IMessage, IEquatable<GetPrivateChatHistoryScRsp>, IDeepCloneable<GetPrivateChatHistoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPrivateChatHistoryScRsp> _parser = new MessageParser<GetPrivateChatHistoryScRsp>(() => new GetPrivateChatHistoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ContactSideFieldNumber = 2;

	private uint contactSide_;

	public const int TargetSideFieldNumber = 4;

	private uint targetSide_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int ChatMessageListFieldNumber = 13;

	private static readonly FieldCodec<ChatMessageData> _repeated_chatMessageList_codec = FieldCodec.ForMessage(106u, ChatMessageData.Parser);

	private readonly RepeatedField<ChatMessageData> chatMessageList_ = new RepeatedField<ChatMessageData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPrivateChatHistoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPrivateChatHistoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContactSide
	{
		get
		{
			return contactSide_;
		}
		set
		{
			contactSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChatMessageData> ChatMessageList => chatMessageList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPrivateChatHistoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPrivateChatHistoryScRsp(GetPrivateChatHistoryScRsp other)
		: this()
	{
		contactSide_ = other.contactSide_;
		targetSide_ = other.targetSide_;
		retcode_ = other.retcode_;
		chatMessageList_ = other.chatMessageList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPrivateChatHistoryScRsp Clone()
	{
		return new GetPrivateChatHistoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPrivateChatHistoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPrivateChatHistoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ContactSide != other.ContactSide)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!chatMessageList_.Equals(other.chatMessageList_))
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
		if (ContactSide != 0)
		{
			num ^= ContactSide.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= chatMessageList_.GetHashCode();
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
		if (ContactSide != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ContactSide);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(TargetSide);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		chatMessageList_.WriteTo(ref output, _repeated_chatMessageList_codec);
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
		if (ContactSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContactSide);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += chatMessageList_.CalculateSize(_repeated_chatMessageList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPrivateChatHistoryScRsp other)
	{
		if (other != null)
		{
			if (other.ContactSide != 0)
			{
				ContactSide = other.ContactSide;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			chatMessageList_.Add(other.chatMessageList_);
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
				ContactSide = input.ReadUInt32();
				break;
			case 32u:
				TargetSide = input.ReadUInt32();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				chatMessageList_.AddEntriesFrom(ref input, _repeated_chatMessageList_codec);
				break;
			}
		}
	}
}
