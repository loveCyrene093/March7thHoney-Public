using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishFirstTalkByPerformanceNpcCsReq : IMessage<FinishFirstTalkByPerformanceNpcCsReq>, IMessage, IEquatable<FinishFirstTalkByPerformanceNpcCsReq>, IDeepCloneable<FinishFirstTalkByPerformanceNpcCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishFirstTalkByPerformanceNpcCsReq> _parser = new MessageParser<FinishFirstTalkByPerformanceNpcCsReq>(() => new FinishFirstTalkByPerformanceNpcCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PerformanceIdFieldNumber = 8;

	private uint performanceId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishFirstTalkByPerformanceNpcCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishFirstTalkByPerformanceNpcCsReqReflection.Descriptor.MessageTypes[0];

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
	public FinishFirstTalkByPerformanceNpcCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFirstTalkByPerformanceNpcCsReq(FinishFirstTalkByPerformanceNpcCsReq other)
		: this()
	{
		performanceId_ = other.performanceId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFirstTalkByPerformanceNpcCsReq Clone()
	{
		return new FinishFirstTalkByPerformanceNpcCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishFirstTalkByPerformanceNpcCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishFirstTalkByPerformanceNpcCsReq other)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishFirstTalkByPerformanceNpcCsReq other)
	{
		if (other != null)
		{
			if (other.PerformanceId != 0)
			{
				PerformanceId = other.PerformanceId;
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
			if (num != 64)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PerformanceId = input.ReadUInt32();
			}
		}
	}
}
