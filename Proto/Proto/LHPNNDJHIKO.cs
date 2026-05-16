using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHPNNDJHIKO : IMessage<LHPNNDJHIKO>, IMessage, IEquatable<LHPNNDJHIKO>, IDeepCloneable<LHPNNDJHIKO>, IBufferMessage
{
	private static readonly MessageParser<LHPNNDJHIKO> _parser = new MessageParser<LHPNNDJHIKO>(() => new LHPNNDJHIKO());

	private UnknownFieldSet _unknownFields;

	public const int TimeFieldNumber = 6;

	private long time_;

	public const int DiyDynamicIdFieldNumber = 14;

	private uint diyDynamicId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHPNNDJHIKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHPNNDJHIKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiyDynamicId
	{
		get
		{
			return diyDynamicId_;
		}
		set
		{
			diyDynamicId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPNNDJHIKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPNNDJHIKO(LHPNNDJHIKO other)
		: this()
	{
		time_ = other.time_;
		diyDynamicId_ = other.diyDynamicId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPNNDJHIKO Clone()
	{
		return new LHPNNDJHIKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHPNNDJHIKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHPNNDJHIKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (DiyDynamicId != other.DiyDynamicId)
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
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
		}
		if (DiyDynamicId != 0)
		{
			num ^= DiyDynamicId.GetHashCode();
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
		if (Time != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(Time);
		}
		if (DiyDynamicId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DiyDynamicId);
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
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (DiyDynamicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiyDynamicId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHPNNDJHIKO other)
	{
		if (other != null)
		{
			if (other.Time != 0L)
			{
				Time = other.Time;
			}
			if (other.DiyDynamicId != 0)
			{
				DiyDynamicId = other.DiyDynamicId;
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
			case 48u:
				Time = input.ReadInt64();
				break;
			case 112u:
				DiyDynamicId = input.ReadUInt32();
				break;
			}
		}
	}
}
