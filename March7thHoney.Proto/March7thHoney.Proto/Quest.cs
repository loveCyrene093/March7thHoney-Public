using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Quest : IMessage<Quest>, IMessage, IEquatable<Quest>, IDeepCloneable<Quest>, IBufferMessage
{
	private static readonly MessageParser<Quest> _parser = new MessageParser<Quest>(() => new Quest());

	private UnknownFieldSet _unknownFields;

	public const int LFBADOCHCDNFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_lFBADOCHCDN_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> lFBADOCHCDN_ = new RepeatedField<uint>();

	public const int ProgressFieldNumber = 2;

	private uint progress_;

	public const int FinishTimeFieldNumber = 3;

	private long finishTime_;

	public const int StatusFieldNumber = 8;

	private QuestStatus status_;

	public const int IdFieldNumber = 13;

	private uint id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Quest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LFBADOCHCDN => lFBADOCHCDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FinishTime
	{
		get
		{
			return finishTime_;
		}
		set
		{
			finishTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStatus Status
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
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Quest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Quest(Quest other)
		: this()
	{
		lFBADOCHCDN_ = other.lFBADOCHCDN_.Clone();
		progress_ = other.progress_;
		finishTime_ = other.finishTime_;
		status_ = other.status_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Quest Clone()
	{
		return new Quest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Quest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Quest other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lFBADOCHCDN_.Equals(other.lFBADOCHCDN_))
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (FinishTime != other.FinishTime)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (Id != other.Id)
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
		num ^= lFBADOCHCDN_.GetHashCode();
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (FinishTime != 0L)
		{
			num ^= FinishTime.GetHashCode();
		}
		if (Status != QuestStatus.QuestNone)
		{
			num ^= Status.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		lFBADOCHCDN_.WriteTo(ref output, _repeated_lFBADOCHCDN_codec);
		if (Progress != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Progress);
		}
		if (FinishTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(FinishTime);
		}
		if (Status != QuestStatus.QuestNone)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Status);
		}
		if (Id != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Id);
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
		num += lFBADOCHCDN_.CalculateSize(_repeated_lFBADOCHCDN_codec);
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (FinishTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(FinishTime);
		}
		if (Status != QuestStatus.QuestNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Quest other)
	{
		if (other != null)
		{
			lFBADOCHCDN_.Add(other.lFBADOCHCDN_);
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.FinishTime != 0L)
			{
				FinishTime = other.FinishTime;
			}
			if (other.Status != QuestStatus.QuestNone)
			{
				Status = other.Status;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 8u:
			case 10u:
				lFBADOCHCDN_.AddEntriesFrom(ref input, _repeated_lFBADOCHCDN_codec);
				break;
			case 16u:
				Progress = input.ReadUInt32();
				break;
			case 24u:
				FinishTime = input.ReadInt64();
				break;
			case 64u:
				Status = (QuestStatus)input.ReadEnum();
				break;
			case 104u:
				Id = input.ReadUInt32();
				break;
			}
		}
	}
}
