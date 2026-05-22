using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearUpdatePlanCsReq : IMessage<RelicSmartWearUpdatePlanCsReq>, IMessage, IEquatable<RelicSmartWearUpdatePlanCsReq>, IDeepCloneable<RelicSmartWearUpdatePlanCsReq>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearUpdatePlanCsReq> _parser = new MessageParser<RelicSmartWearUpdatePlanCsReq>(() => new RelicSmartWearUpdatePlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int RelicPlanFieldNumber = 8;

	private RelicSmartWearPlan relicPlan_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearUpdatePlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearUpdatePlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearPlan RelicPlan
	{
		get
		{
			return relicPlan_;
		}
		set
		{
			relicPlan_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePlanCsReq(RelicSmartWearUpdatePlanCsReq other)
		: this()
	{
		relicPlan_ = ((other.relicPlan_ != null) ? other.relicPlan_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePlanCsReq Clone()
	{
		return new RelicSmartWearUpdatePlanCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearUpdatePlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearUpdatePlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RelicPlan, other.RelicPlan))
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
		if (relicPlan_ != null)
		{
			num ^= RelicPlan.GetHashCode();
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
		if (relicPlan_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(RelicPlan);
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
		if (relicPlan_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicPlan);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearUpdatePlanCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.relicPlan_ != null)
		{
			if (relicPlan_ == null)
			{
				RelicPlan = new RelicSmartWearPlan();
			}
			RelicPlan.MergeFrom(other.RelicPlan);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (relicPlan_ == null)
			{
				RelicPlan = new RelicSmartWearPlan();
			}
			input.ReadMessage(RelicPlan);
		}
	}
}
