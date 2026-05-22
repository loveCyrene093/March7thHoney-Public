using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCAIPEBCIMH : IMessage<CCAIPEBCIMH>, IMessage, IEquatable<CCAIPEBCIMH>, IDeepCloneable<CCAIPEBCIMH>, IBufferMessage
{
	private static readonly MessageParser<CCAIPEBCIMH> _parser = new MessageParser<CCAIPEBCIMH>(() => new CCAIPEBCIMH());

	private UnknownFieldSet _unknownFields;

	public const int PropIdFieldNumber = 3;

	private uint propId_;

	public const int TimeFieldNumber = 10;

	private long time_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCAIPEBCIMH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCAIPEBCIMHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropId
	{
		get
		{
			return propId_;
		}
		set
		{
			propId_ = value;
		}
	}

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
	public CCAIPEBCIMH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCAIPEBCIMH(CCAIPEBCIMH other)
		: this()
	{
		propId_ = other.propId_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCAIPEBCIMH Clone()
	{
		return new CCAIPEBCIMH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCAIPEBCIMH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCAIPEBCIMH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PropId != other.PropId)
		{
			return false;
		}
		if (Time != other.Time)
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
		if (PropId != 0)
		{
			num ^= PropId.GetHashCode();
		}
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
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
		if (PropId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PropId);
		}
		if (Time != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(Time);
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
		if (PropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropId);
		}
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCAIPEBCIMH other)
	{
		if (other != null)
		{
			if (other.PropId != 0)
			{
				PropId = other.PropId;
			}
			if (other.Time != 0L)
			{
				Time = other.Time;
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
			case 24u:
				PropId = input.ReadUInt32();
				break;
			case 80u:
				Time = input.ReadInt64();
				break;
			}
		}
	}
}
