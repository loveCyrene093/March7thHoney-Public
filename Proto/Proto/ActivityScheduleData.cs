using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivityScheduleData : IMessage<ActivityScheduleData>, IMessage, IEquatable<ActivityScheduleData>, IDeepCloneable<ActivityScheduleData>, IBufferMessage
{
	private static readonly MessageParser<ActivityScheduleData> _parser = new MessageParser<ActivityScheduleData>(() => new ActivityScheduleData());

	private UnknownFieldSet _unknownFields;

	public const int BeginTimeFieldNumber = 6;

	private long beginTime_;

	public const int PanelIdFieldNumber = 11;

	private uint panelId_;

	public const int EndTimeFieldNumber = 12;

	private long endTime_;

	public const int ActivityIdFieldNumber = 15;

	private uint activityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActivityScheduleData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ActivityScheduleDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ActivityId
	{
		get
		{
			return activityId_;
		}
		set
		{
			activityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityScheduleData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityScheduleData(ActivityScheduleData other)
		: this()
	{
		beginTime_ = other.beginTime_;
		panelId_ = other.panelId_;
		endTime_ = other.endTime_;
		activityId_ = other.activityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityScheduleData Clone()
	{
		return new ActivityScheduleData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ActivityScheduleData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActivityScheduleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (ActivityId != other.ActivityId)
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
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (ActivityId != 0)
		{
			num ^= ActivityId.GetHashCode();
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
		if (BeginTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(BeginTime);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PanelId);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(EndTime);
		}
		if (ActivityId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ActivityId);
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
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (ActivityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ActivityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActivityScheduleData other)
	{
		if (other != null)
		{
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.ActivityId != 0)
			{
				ActivityId = other.ActivityId;
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
				BeginTime = input.ReadInt64();
				break;
			case 88u:
				PanelId = input.ReadUInt32();
				break;
			case 96u:
				EndTime = input.ReadInt64();
				break;
			case 120u:
				ActivityId = input.ReadUInt32();
				break;
			}
		}
	}
}
