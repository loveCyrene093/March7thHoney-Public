using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DailyActivityInfo : IMessage<DailyActivityInfo>, IMessage, IEquatable<DailyActivityInfo>, IDeepCloneable<DailyActivityInfo>, IBufferMessage
{
	private static readonly MessageParser<DailyActivityInfo> _parser = new MessageParser<DailyActivityInfo>(() => new DailyActivityInfo());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 5;

	private uint level_;

	public const int IsHasTakenFieldNumber = 6;

	private bool isHasTaken_;

	public const int WorldLevelFieldNumber = 7;

	private uint worldLevel_;

	public const int DailyActivePointFieldNumber = 10;

	private uint dailyActivePoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DailyActivityInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DailyActivityInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsHasTaken
	{
		get
		{
			return isHasTaken_;
		}
		set
		{
			isHasTaken_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DailyActivePoint
	{
		get
		{
			return dailyActivePoint_;
		}
		set
		{
			dailyActivePoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyActivityInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyActivityInfo(DailyActivityInfo other)
		: this()
	{
		level_ = other.level_;
		isHasTaken_ = other.isHasTaken_;
		worldLevel_ = other.worldLevel_;
		dailyActivePoint_ = other.dailyActivePoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyActivityInfo Clone()
	{
		return new DailyActivityInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DailyActivityInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DailyActivityInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (IsHasTaken != other.IsHasTaken)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (DailyActivePoint != other.DailyActivePoint)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (IsHasTaken)
		{
			num ^= IsHasTaken.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (DailyActivePoint != 0)
		{
			num ^= DailyActivePoint.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Level);
		}
		if (IsHasTaken)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsHasTaken);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(WorldLevel);
		}
		if (DailyActivePoint != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DailyActivePoint);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (IsHasTaken)
		{
			num += 2;
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (DailyActivePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DailyActivePoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DailyActivityInfo other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.IsHasTaken)
			{
				IsHasTaken = other.IsHasTaken;
			}
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
			}
			if (other.DailyActivePoint != 0)
			{
				DailyActivePoint = other.DailyActivePoint;
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
			case 40u:
				Level = input.ReadUInt32();
				break;
			case 48u:
				IsHasTaken = input.ReadBool();
				break;
			case 56u:
				WorldLevel = input.ReadUInt32();
				break;
			case 80u:
				DailyActivePoint = input.ReadUInt32();
				break;
			}
		}
	}
}
