using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHIBGDFEFEE : IMessage<PHIBGDFEFEE>, IMessage, IEquatable<PHIBGDFEFEE>, IDeepCloneable<PHIBGDFEFEE>, IBufferMessage
{
	private static readonly MessageParser<PHIBGDFEFEE> _parser = new MessageParser<PHIBGDFEFEE>(() => new PHIBGDFEFEE());

	private UnknownFieldSet _unknownFields;

	public const int StopEndTimeFieldNumber = 2;

	private long stopEndTime_;

	public const int StopBeginTimeFieldNumber = 10;

	private long stopBeginTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHIBGDFEFEE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHIBGDFEFEEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StopEndTime
	{
		get
		{
			return stopEndTime_;
		}
		set
		{
			stopEndTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StopBeginTime
	{
		get
		{
			return stopBeginTime_;
		}
		set
		{
			stopBeginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIBGDFEFEE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIBGDFEFEE(PHIBGDFEFEE other)
		: this()
	{
		stopEndTime_ = other.stopEndTime_;
		stopBeginTime_ = other.stopBeginTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIBGDFEFEE Clone()
	{
		return new PHIBGDFEFEE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHIBGDFEFEE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHIBGDFEFEE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StopEndTime != other.StopEndTime)
		{
			return false;
		}
		if (StopBeginTime != other.StopBeginTime)
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
		if (StopEndTime != 0L)
		{
			num ^= StopEndTime.GetHashCode();
		}
		if (StopBeginTime != 0L)
		{
			num ^= StopBeginTime.GetHashCode();
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
		if (StopEndTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(StopEndTime);
		}
		if (StopBeginTime != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(StopBeginTime);
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
		if (StopEndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StopEndTime);
		}
		if (StopBeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StopBeginTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHIBGDFEFEE other)
	{
		if (other != null)
		{
			if (other.StopEndTime != 0L)
			{
				StopEndTime = other.StopEndTime;
			}
			if (other.StopBeginTime != 0L)
			{
				StopBeginTime = other.StopBeginTime;
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
			case 16u:
				StopEndTime = input.ReadInt64();
				break;
			case 80u:
				StopBeginTime = input.ReadInt64();
				break;
			}
		}
	}
}
