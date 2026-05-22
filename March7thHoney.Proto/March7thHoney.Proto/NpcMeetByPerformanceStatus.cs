using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcMeetByPerformanceStatus : IMessage<NpcMeetByPerformanceStatus>, IMessage, IEquatable<NpcMeetByPerformanceStatus>, IDeepCloneable<NpcMeetByPerformanceStatus>, IBufferMessage
{
	private static readonly MessageParser<NpcMeetByPerformanceStatus> _parser = new MessageParser<NpcMeetByPerformanceStatus>(() => new NpcMeetByPerformanceStatus());

	private UnknownFieldSet _unknownFields;

	public const int PerformanceIdFieldNumber = 8;

	private uint performanceId_;

	public const int IsMeetFieldNumber = 10;

	private bool isMeet_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcMeetByPerformanceStatus> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NpcMeetByPerformanceStatusReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PerformanceId
	{
		get
		{
			return performanceId_;
		}
		set
		{
			performanceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsMeet
	{
		get
		{
			return isMeet_;
		}
		set
		{
			isMeet_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMeetByPerformanceStatus()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMeetByPerformanceStatus(NpcMeetByPerformanceStatus other)
		: this()
	{
		performanceId_ = other.performanceId_;
		isMeet_ = other.isMeet_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMeetByPerformanceStatus Clone()
	{
		return new NpcMeetByPerformanceStatus(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NpcMeetByPerformanceStatus);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcMeetByPerformanceStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformanceId != other.PerformanceId)
		{
			return false;
		}
		if (IsMeet != other.IsMeet)
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
		if (PerformanceId != 0)
		{
			num ^= PerformanceId.GetHashCode();
		}
		if (IsMeet)
		{
			num ^= IsMeet.GetHashCode();
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
		if (PerformanceId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PerformanceId);
		}
		if (IsMeet)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsMeet);
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
		if (PerformanceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PerformanceId);
		}
		if (IsMeet)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcMeetByPerformanceStatus other)
	{
		if (other != null)
		{
			if (other.PerformanceId != 0)
			{
				PerformanceId = other.PerformanceId;
			}
			if (other.IsMeet)
			{
				IsMeet = other.IsMeet;
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
			case 64u:
				PerformanceId = input.ReadUInt32();
				break;
			case 80u:
				IsMeet = input.ReadBool();
				break;
			}
		}
	}
}
