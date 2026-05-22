using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarkChatEmojiCsReq : IMessage<MarkChatEmojiCsReq>, IMessage, IEquatable<MarkChatEmojiCsReq>, IDeepCloneable<MarkChatEmojiCsReq>, IBufferMessage
{
	private static readonly MessageParser<MarkChatEmojiCsReq> _parser = new MessageParser<MarkChatEmojiCsReq>(() => new MarkChatEmojiCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ExtraIdFieldNumber = 12;

	private uint extraId_;

	public const int IsRemoveIdFieldNumber = 14;

	private bool isRemoveId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarkChatEmojiCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarkChatEmojiCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExtraId
	{
		get
		{
			return extraId_;
		}
		set
		{
			extraId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsRemoveId
	{
		get
		{
			return isRemoveId_;
		}
		set
		{
			isRemoveId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChatEmojiCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChatEmojiCsReq(MarkChatEmojiCsReq other)
		: this()
	{
		extraId_ = other.extraId_;
		isRemoveId_ = other.isRemoveId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkChatEmojiCsReq Clone()
	{
		return new MarkChatEmojiCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarkChatEmojiCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarkChatEmojiCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExtraId != other.ExtraId)
		{
			return false;
		}
		if (IsRemoveId != other.IsRemoveId)
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
		if (ExtraId != 0)
		{
			num ^= ExtraId.GetHashCode();
		}
		if (IsRemoveId)
		{
			num ^= IsRemoveId.GetHashCode();
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
		if (ExtraId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ExtraId);
		}
		if (IsRemoveId)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsRemoveId);
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
		if (ExtraId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExtraId);
		}
		if (IsRemoveId)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarkChatEmojiCsReq other)
	{
		if (other != null)
		{
			if (other.ExtraId != 0)
			{
				ExtraId = other.ExtraId;
			}
			if (other.IsRemoveId)
			{
				IsRemoveId = other.IsRemoveId;
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
			case 96u:
				ExtraId = input.ReadUInt32();
				break;
			case 112u:
				IsRemoveId = input.ReadBool();
				break;
			}
		}
	}
}
