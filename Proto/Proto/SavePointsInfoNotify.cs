using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SavePointsInfoNotify : IMessage<SavePointsInfoNotify>, IMessage, IEquatable<SavePointsInfoNotify>, IDeepCloneable<SavePointsInfoNotify>, IBufferMessage
{
	private static readonly MessageParser<SavePointsInfoNotify> _parser = new MessageParser<SavePointsInfoNotify>(() => new SavePointsInfoNotify());

	private UnknownFieldSet _unknownFields;

	public const int RefreshTimeFieldNumber = 4;

	private long refreshTime_;

	public const int ValidTimesFieldNumber = 14;

	private uint validTimes_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SavePointsInfoNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SavePointsInfoNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RefreshTime
	{
		get
		{
			return refreshTime_;
		}
		set
		{
			refreshTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ValidTimes
	{
		get
		{
			return validTimes_;
		}
		set
		{
			validTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SavePointsInfoNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SavePointsInfoNotify(SavePointsInfoNotify other)
		: this()
	{
		refreshTime_ = other.refreshTime_;
		validTimes_ = other.validTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SavePointsInfoNotify Clone()
	{
		return new SavePointsInfoNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SavePointsInfoNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SavePointsInfoNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RefreshTime != other.RefreshTime)
		{
			return false;
		}
		if (ValidTimes != other.ValidTimes)
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
		if (RefreshTime != 0L)
		{
			num ^= RefreshTime.GetHashCode();
		}
		if (ValidTimes != 0)
		{
			num ^= ValidTimes.GetHashCode();
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
		if (RefreshTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(RefreshTime);
		}
		if (ValidTimes != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ValidTimes);
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
		if (RefreshTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RefreshTime);
		}
		if (ValidTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ValidTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SavePointsInfoNotify other)
	{
		if (other != null)
		{
			if (other.RefreshTime != 0L)
			{
				RefreshTime = other.RefreshTime;
			}
			if (other.ValidTimes != 0)
			{
				ValidTimes = other.ValidTimes;
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
				RefreshTime = input.ReadInt64();
				break;
			case 112u:
				ValidTimes = input.ReadUInt32();
				break;
			}
		}
	}
}
