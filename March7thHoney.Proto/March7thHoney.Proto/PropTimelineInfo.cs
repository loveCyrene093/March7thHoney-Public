using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PropTimelineInfo : IMessage<PropTimelineInfo>, IMessage, IEquatable<PropTimelineInfo>, IDeepCloneable<PropTimelineInfo>, IBufferMessage
{
	private static readonly MessageParser<PropTimelineInfo> _parser = new MessageParser<PropTimelineInfo>(() => new PropTimelineInfo());

	private UnknownFieldSet _unknownFields;

	public const int TimelineBoolValueFieldNumber = 3;

	private bool timelineBoolValue_;

	public const int TimelineByteValueFieldNumber = 12;

	private ByteString timelineByteValue_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PropTimelineInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PropTimelineInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool TimelineBoolValue
	{
		get
		{
			return timelineBoolValue_;
		}
		set
		{
			timelineBoolValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString TimelineByteValue
	{
		get
		{
			return timelineByteValue_;
		}
		set
		{
			timelineByteValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropTimelineInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropTimelineInfo(PropTimelineInfo other)
		: this()
	{
		timelineBoolValue_ = other.timelineBoolValue_;
		timelineByteValue_ = other.timelineByteValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropTimelineInfo Clone()
	{
		return new PropTimelineInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PropTimelineInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PropTimelineInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TimelineBoolValue != other.TimelineBoolValue)
		{
			return false;
		}
		if (TimelineByteValue != other.TimelineByteValue)
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
		if (TimelineBoolValue)
		{
			num ^= TimelineBoolValue.GetHashCode();
		}
		if (TimelineByteValue.Length != 0)
		{
			num ^= TimelineByteValue.GetHashCode();
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
		if (TimelineBoolValue)
		{
			output.WriteRawTag(24);
			output.WriteBool(TimelineBoolValue);
		}
		if (TimelineByteValue.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteBytes(TimelineByteValue);
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
		if (TimelineBoolValue)
		{
			num += 2;
		}
		if (TimelineByteValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(TimelineByteValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PropTimelineInfo other)
	{
		if (other != null)
		{
			if (other.TimelineBoolValue)
			{
				TimelineBoolValue = other.TimelineBoolValue;
			}
			if (other.TimelineByteValue.Length != 0)
			{
				TimelineByteValue = other.TimelineByteValue;
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
				TimelineBoolValue = input.ReadBool();
				break;
			case 98u:
				TimelineByteValue = input.ReadBytes();
				break;
			}
		}
	}
}
