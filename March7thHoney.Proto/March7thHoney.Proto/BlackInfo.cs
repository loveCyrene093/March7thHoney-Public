using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BlackInfo : IMessage<BlackInfo>, IMessage, IEquatable<BlackInfo>, IDeepCloneable<BlackInfo>, IBufferMessage
{
	private static readonly MessageParser<BlackInfo> _parser = new MessageParser<BlackInfo>(() => new BlackInfo());

	private UnknownFieldSet _unknownFields;

	public const int BeginTimeFieldNumber = 1;

	private long beginTime_;

	public const int EndTimeFieldNumber = 2;

	private long endTime_;

	public const int LimitLevelFieldNumber = 3;

	private uint limitLevel_;

	public const int BanTypeFieldNumber = 4;

	private uint banType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BlackInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BlackInfoReflection.Descriptor.MessageTypes[0];

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
	public uint LimitLevel
	{
		get
		{
			return limitLevel_;
		}
		set
		{
			limitLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BanType
	{
		get
		{
			return banType_;
		}
		set
		{
			banType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlackInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlackInfo(BlackInfo other)
		: this()
	{
		beginTime_ = other.beginTime_;
		endTime_ = other.endTime_;
		limitLevel_ = other.limitLevel_;
		banType_ = other.banType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlackInfo Clone()
	{
		return new BlackInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BlackInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BlackInfo other)
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
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (LimitLevel != other.LimitLevel)
		{
			return false;
		}
		if (BanType != other.BanType)
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
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (LimitLevel != 0)
		{
			num ^= LimitLevel.GetHashCode();
		}
		if (BanType != 0)
		{
			num ^= BanType.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteInt64(BeginTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(EndTime);
		}
		if (LimitLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LimitLevel);
		}
		if (BanType != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BanType);
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
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (LimitLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LimitLevel);
		}
		if (BanType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BanType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BlackInfo other)
	{
		if (other != null)
		{
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.LimitLevel != 0)
			{
				LimitLevel = other.LimitLevel;
			}
			if (other.BanType != 0)
			{
				BanType = other.BanType;
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
				BeginTime = input.ReadInt64();
				break;
			case 16u:
				EndTime = input.ReadInt64();
				break;
			case 24u:
				LimitLevel = input.ReadUInt32();
				break;
			case 32u:
				BanType = input.ReadUInt32();
				break;
			}
		}
	}
}
