using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSyncCurrentTaskInfo : IMessage<GridFightSyncCurrentTaskInfo>, IMessage, IEquatable<GridFightSyncCurrentTaskInfo>, IDeepCloneable<GridFightSyncCurrentTaskInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightSyncCurrentTaskInfo> _parser = new MessageParser<GridFightSyncCurrentTaskInfo>(() => new GridFightSyncCurrentTaskInfo());

	private UnknownFieldSet _unknownFields;

	public const int FinishTaskListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_finishTaskList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> finishTaskList_ = new RepeatedField<uint>();

	public const int CurTaskFieldNumber = 7;

	private GridFightCurrentTask curTask_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSyncCurrentTaskInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSyncCurrentTaskInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishTaskList => finishTaskList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCurrentTask CurTask
	{
		get
		{
			return curTask_;
		}
		set
		{
			curTask_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncCurrentTaskInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncCurrentTaskInfo(GridFightSyncCurrentTaskInfo other)
		: this()
	{
		finishTaskList_ = other.finishTaskList_.Clone();
		curTask_ = ((other.curTask_ != null) ? other.curTask_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncCurrentTaskInfo Clone()
	{
		return new GridFightSyncCurrentTaskInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSyncCurrentTaskInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSyncCurrentTaskInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!finishTaskList_.Equals(other.finishTaskList_))
		{
			return false;
		}
		if (!object.Equals(CurTask, other.CurTask))
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
		num ^= finishTaskList_.GetHashCode();
		if (curTask_ != null)
		{
			num ^= CurTask.GetHashCode();
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
		finishTaskList_.WriteTo(ref output, _repeated_finishTaskList_codec);
		if (curTask_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CurTask);
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
		num += finishTaskList_.CalculateSize(_repeated_finishTaskList_codec);
		if (curTask_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurTask);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSyncCurrentTaskInfo other)
	{
		if (other == null)
		{
			return;
		}
		finishTaskList_.Add(other.finishTaskList_);
		if (other.curTask_ != null)
		{
			if (curTask_ == null)
			{
				CurTask = new GridFightCurrentTask();
			}
			CurTask.MergeFrom(other.CurTask);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 40u:
			case 42u:
				finishTaskList_.AddEntriesFrom(ref input, _repeated_finishTaskList_codec);
				break;
			case 58u:
				if (curTask_ == null)
				{
					CurTask = new GridFightCurrentTask();
				}
				input.ReadMessage(CurTask);
				break;
			}
		}
	}
}
