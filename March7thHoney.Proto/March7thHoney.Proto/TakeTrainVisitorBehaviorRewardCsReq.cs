using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeTrainVisitorBehaviorRewardCsReq : IMessage<TakeTrainVisitorBehaviorRewardCsReq>, IMessage, IEquatable<TakeTrainVisitorBehaviorRewardCsReq>, IDeepCloneable<TakeTrainVisitorBehaviorRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeTrainVisitorBehaviorRewardCsReq> _parser = new MessageParser<TakeTrainVisitorBehaviorRewardCsReq>(() => new TakeTrainVisitorBehaviorRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 7;

	private uint visitorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeTrainVisitorBehaviorRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeTrainVisitorBehaviorRewardCsReqReflection.Descriptor.MessageTypes[0];

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
	public TakeTrainVisitorBehaviorRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeTrainVisitorBehaviorRewardCsReq(TakeTrainVisitorBehaviorRewardCsReq other)
		: this()
	{
		visitorId_ = other.visitorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeTrainVisitorBehaviorRewardCsReq Clone()
	{
		return new TakeTrainVisitorBehaviorRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeTrainVisitorBehaviorRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeTrainVisitorBehaviorRewardCsReq other)
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
			output.WriteRawTag(56);
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
	public void MergeFrom(TakeTrainVisitorBehaviorRewardCsReq other)
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
			if (num != 56)
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
