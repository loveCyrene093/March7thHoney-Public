using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainVisitorBehaviorFinishCsReq : IMessage<TrainVisitorBehaviorFinishCsReq>, IMessage, IEquatable<TrainVisitorBehaviorFinishCsReq>, IDeepCloneable<TrainVisitorBehaviorFinishCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainVisitorBehaviorFinishCsReq> _parser = new MessageParser<TrainVisitorBehaviorFinishCsReq>(() => new TrainVisitorBehaviorFinishCsReq());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 13;

	private uint visitorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainVisitorBehaviorFinishCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainVisitorBehaviorFinishCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint VisitorId
	{
		get
		{
			return visitorId_;
		}
		set
		{
			visitorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorBehaviorFinishCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorBehaviorFinishCsReq(TrainVisitorBehaviorFinishCsReq other)
		: this()
	{
		visitorId_ = other.visitorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorBehaviorFinishCsReq Clone()
	{
		return new TrainVisitorBehaviorFinishCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainVisitorBehaviorFinishCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainVisitorBehaviorFinishCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VisitorId != other.VisitorId)
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
		if (VisitorId != 0)
		{
			num ^= VisitorId.GetHashCode();
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
		if (VisitorId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(VisitorId);
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
		if (VisitorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VisitorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainVisitorBehaviorFinishCsReq other)
	{
		if (other != null)
		{
			if (other.VisitorId != 0)
			{
				VisitorId = other.VisitorId;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				VisitorId = input.ReadUInt32();
			}
		}
	}
}
