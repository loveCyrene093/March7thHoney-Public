using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HJGFDIKDIHO : IMessage<HJGFDIKDIHO>, IMessage, IEquatable<HJGFDIKDIHO>, IDeepCloneable<HJGFDIKDIHO>, IBufferMessage
{
	private static readonly MessageParser<HJGFDIKDIHO> _parser = new MessageParser<HJGFDIKDIHO>(() => new HJGFDIKDIHO());

	private UnknownFieldSet _unknownFields;

	public const int EBMHDHJKBKCFieldNumber = 4;

	private uint eBMHDHJKBKC_;

	public const int BuffIdFieldNumber = 6;

	private uint buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HJGFDIKDIHO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HJGFDIKDIHOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EBMHDHJKBKC
	{
		get
		{
			return eBMHDHJKBKC_;
		}
		set
		{
			eBMHDHJKBKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJGFDIKDIHO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJGFDIKDIHO(HJGFDIKDIHO other)
		: this()
	{
		eBMHDHJKBKC_ = other.eBMHDHJKBKC_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJGFDIKDIHO Clone()
	{
		return new HJGFDIKDIHO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HJGFDIKDIHO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HJGFDIKDIHO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EBMHDHJKBKC != other.EBMHDHJKBKC)
		{
			return false;
		}
		if (BuffId != other.BuffId)
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
		if (EBMHDHJKBKC != 0)
		{
			num ^= EBMHDHJKBKC.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
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
		if (EBMHDHJKBKC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EBMHDHJKBKC);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BuffId);
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
		if (EBMHDHJKBKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EBMHDHJKBKC);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HJGFDIKDIHO other)
	{
		if (other != null)
		{
			if (other.EBMHDHJKBKC != 0)
			{
				EBMHDHJKBKC = other.EBMHDHJKBKC;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
			case 32u:
				EBMHDHJKBKC = input.ReadUInt32();
				break;
			case 48u:
				BuffId = input.ReadUInt32();
				break;
			}
		}
	}
}
