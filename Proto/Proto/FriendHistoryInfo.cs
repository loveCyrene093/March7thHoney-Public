using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendHistoryInfo : IMessage<FriendHistoryInfo>, IMessage, IEquatable<FriendHistoryInfo>, IDeepCloneable<FriendHistoryInfo>, IBufferMessage
{
	private static readonly MessageParser<FriendHistoryInfo> _parser = new MessageParser<FriendHistoryInfo>(() => new FriendHistoryInfo());

	private UnknownFieldSet _unknownFields;

	public const int ContactSideFieldNumber = 10;

	private uint contactSide_;

	public const int LastSendTimeFieldNumber = 13;

	private long lastSendTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendHistoryInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FriendHistoryInfoReflection.Descriptor.MessageTypes[0];

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
	public long LastSendTime
	{
		get
		{
			return lastSendTime_;
		}
		set
		{
			lastSendTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendHistoryInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendHistoryInfo(FriendHistoryInfo other)
		: this()
	{
		contactSide_ = other.contactSide_;
		lastSendTime_ = other.lastSendTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendHistoryInfo Clone()
	{
		return new FriendHistoryInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendHistoryInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendHistoryInfo other)
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
		if (LastSendTime != other.LastSendTime)
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
		if (LastSendTime != 0L)
		{
			num ^= LastSendTime.GetHashCode();
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
		if (ContactSide != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ContactSide);
		}
		if (LastSendTime != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(LastSendTime);
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
		if (ContactSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContactSide);
		}
		if (LastSendTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LastSendTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendHistoryInfo other)
	{
		if (other != null)
		{
			if (other.ContactSide != 0)
			{
				ContactSide = other.ContactSide;
			}
			if (other.LastSendTime != 0L)
			{
				LastSendTime = other.LastSendTime;
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
			case 80u:
				ContactSide = input.ReadUInt32();
				break;
			case 104u:
				LastSendTime = input.ReadInt64();
				break;
			}
		}
	}
}
