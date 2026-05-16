using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FarmStageGachaInfo : IMessage<FarmStageGachaInfo>, IMessage, IEquatable<FarmStageGachaInfo>, IDeepCloneable<FarmStageGachaInfo>, IBufferMessage
{
	private static readonly MessageParser<FarmStageGachaInfo> _parser = new MessageParser<FarmStageGachaInfo>(() => new FarmStageGachaInfo());

	private UnknownFieldSet _unknownFields;

	public const int GachaIdFieldNumber = 4;

	private uint gachaId_;

	public const int BeginTimeFieldNumber = 8;

	private long beginTime_;

	public const int EndTimeFieldNumber = 11;

	private long endTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FarmStageGachaInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FarmStageGachaInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

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
	public FarmStageGachaInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FarmStageGachaInfo(FarmStageGachaInfo other)
		: this()
	{
		gachaId_ = other.gachaId_;
		beginTime_ = other.beginTime_;
		endTime_ = other.endTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FarmStageGachaInfo Clone()
	{
		return new FarmStageGachaInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FarmStageGachaInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FarmStageGachaInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (EndTime != other.EndTime)
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
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
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
		if (GachaId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GachaId);
		}
		if (BeginTime != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(BeginTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(EndTime);
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
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FarmStageGachaInfo other)
	{
		if (other != null)
		{
			if (other.GachaId != 0)
			{
				GachaId = other.GachaId;
			}
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
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
				GachaId = input.ReadUInt32();
				break;
			case 64u:
				BeginTime = input.ReadInt64();
				break;
			case 88u:
				EndTime = input.ReadInt64();
				break;
			}
		}
	}
}
