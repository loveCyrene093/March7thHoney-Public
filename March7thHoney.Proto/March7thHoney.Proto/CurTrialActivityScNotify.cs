using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CurTrialActivityScNotify : IMessage<CurTrialActivityScNotify>, IMessage, IEquatable<CurTrialActivityScNotify>, IDeepCloneable<CurTrialActivityScNotify>, IBufferMessage
{
	private static readonly MessageParser<CurTrialActivityScNotify> _parser = new MessageParser<CurTrialActivityScNotify>(() => new CurTrialActivityScNotify());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 4;

	private TrialActivityStatus status_;

	public const int ActivityStageIdFieldNumber = 5;

	private uint activityStageId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CurTrialActivityScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CurTrialActivityScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrialActivityStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ActivityStageId
	{
		get
		{
			return activityStageId_;
		}
		set
		{
			activityStageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurTrialActivityScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurTrialActivityScNotify(CurTrialActivityScNotify other)
		: this()
	{
		status_ = other.status_;
		activityStageId_ = other.activityStageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurTrialActivityScNotify Clone()
	{
		return new CurTrialActivityScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CurTrialActivityScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CurTrialActivityScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (ActivityStageId != other.ActivityStageId)
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
		if (Status != TrialActivityStatus.None)
		{
			num ^= Status.GetHashCode();
		}
		if (ActivityStageId != 0)
		{
			num ^= ActivityStageId.GetHashCode();
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
		if (Status != TrialActivityStatus.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Status);
		}
		if (ActivityStageId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ActivityStageId);
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
		if (Status != TrialActivityStatus.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (ActivityStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ActivityStageId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CurTrialActivityScNotify other)
	{
		if (other != null)
		{
			if (other.Status != TrialActivityStatus.None)
			{
				Status = other.Status;
			}
			if (other.ActivityStageId != 0)
			{
				ActivityStageId = other.ActivityStageId;
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
				Status = (TrialActivityStatus)input.ReadEnum();
				break;
			case 40u:
				ActivityStageId = input.ReadUInt32();
				break;
			}
		}
	}
}
