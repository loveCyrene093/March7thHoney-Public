using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeadFrameInfo : IMessage<HeadFrameInfo>, IMessage, IEquatable<HeadFrameInfo>, IDeepCloneable<HeadFrameInfo>, IBufferMessage
{
	private static readonly MessageParser<HeadFrameInfo> _parser = new MessageParser<HeadFrameInfo>(() => new HeadFrameInfo());

	private UnknownFieldSet _unknownFields;

	public const int HeadFrameItemIdFieldNumber = 9;

	private uint headFrameItemId_;

	public const int HeadFrameExpireTimeFieldNumber = 12;

	private long headFrameExpireTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeadFrameInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeadFrameInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HeadFrameItemId
	{
		get
		{
			return headFrameItemId_;
		}
		set
		{
			headFrameItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long HeadFrameExpireTime
	{
		get
		{
			return headFrameExpireTime_;
		}
		set
		{
			headFrameExpireTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeadFrameInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeadFrameInfo(HeadFrameInfo other)
		: this()
	{
		headFrameItemId_ = other.headFrameItemId_;
		headFrameExpireTime_ = other.headFrameExpireTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeadFrameInfo Clone()
	{
		return new HeadFrameInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeadFrameInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeadFrameInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HeadFrameItemId != other.HeadFrameItemId)
		{
			return false;
		}
		if (HeadFrameExpireTime != other.HeadFrameExpireTime)
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
		if (HeadFrameItemId != 0)
		{
			num ^= HeadFrameItemId.GetHashCode();
		}
		if (HeadFrameExpireTime != 0L)
		{
			num ^= HeadFrameExpireTime.GetHashCode();
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
		if (HeadFrameItemId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HeadFrameItemId);
		}
		if (HeadFrameExpireTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(HeadFrameExpireTime);
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
		if (HeadFrameItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadFrameItemId);
		}
		if (HeadFrameExpireTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(HeadFrameExpireTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeadFrameInfo other)
	{
		if (other != null)
		{
			if (other.HeadFrameItemId != 0)
			{
				HeadFrameItemId = other.HeadFrameItemId;
			}
			if (other.HeadFrameExpireTime != 0L)
			{
				HeadFrameExpireTime = other.HeadFrameExpireTime;
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
			case 72u:
				HeadFrameItemId = input.ReadUInt32();
				break;
			case 96u:
				HeadFrameExpireTime = input.ReadInt64();
				break;
			}
		}
	}
}
