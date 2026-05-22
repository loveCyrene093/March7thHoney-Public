using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class WaitConfirmData : IMessage<WaitConfirmData>, IMessage, IEquatable<WaitConfirmData>, IDeepCloneable<WaitConfirmData>, IBufferMessage
{
	private static readonly MessageParser<WaitConfirmData> _parser = new MessageParser<WaitConfirmData>(() => new WaitConfirmData());

	private UnknownFieldSet _unknownFields;

	public const int PeakIdFieldNumber = 1;

	private uint peakId_;

	public const int IsWaitConfirmFieldNumber = 5;

	private bool isWaitConfirm_;

	public const int FinishedTargetListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int CyclesUsedFieldNumber = 12;

	private uint cyclesUsed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WaitConfirmData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => WaitConfirmDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakId
	{
		get
		{
			return peakId_;
		}
		set
		{
			peakId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWaitConfirm
	{
		get
		{
			return isWaitConfirm_;
		}
		set
		{
			isWaitConfirm_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CyclesUsed
	{
		get
		{
			return cyclesUsed_;
		}
		set
		{
			cyclesUsed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitConfirmData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitConfirmData(WaitConfirmData other)
		: this()
	{
		peakId_ = other.peakId_;
		isWaitConfirm_ = other.isWaitConfirm_;
		finishedTargetList_ = other.finishedTargetList_.Clone();
		cyclesUsed_ = other.cyclesUsed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaitConfirmData Clone()
	{
		return new WaitConfirmData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as WaitConfirmData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WaitConfirmData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (IsWaitConfirm != other.IsWaitConfirm)
		{
			return false;
		}
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
		{
			return false;
		}
		if (CyclesUsed != other.CyclesUsed)
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
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		if (IsWaitConfirm)
		{
			num ^= IsWaitConfirm.GetHashCode();
		}
		num ^= finishedTargetList_.GetHashCode();
		if (CyclesUsed != 0)
		{
			num ^= CyclesUsed.GetHashCode();
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
		if (PeakId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PeakId);
		}
		if (IsWaitConfirm)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsWaitConfirm);
		}
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (CyclesUsed != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CyclesUsed);
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
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (IsWaitConfirm)
		{
			num += 2;
		}
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (CyclesUsed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CyclesUsed);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WaitConfirmData other)
	{
		if (other != null)
		{
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			if (other.IsWaitConfirm)
			{
				IsWaitConfirm = other.IsWaitConfirm;
			}
			finishedTargetList_.Add(other.finishedTargetList_);
			if (other.CyclesUsed != 0)
			{
				CyclesUsed = other.CyclesUsed;
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
				PeakId = input.ReadUInt32();
				break;
			case 40u:
				IsWaitConfirm = input.ReadBool();
				break;
			case 72u:
			case 74u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 96u:
				CyclesUsed = input.ReadUInt32();
				break;
			}
		}
	}
}
