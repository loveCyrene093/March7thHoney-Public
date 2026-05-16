using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveCollectIncomeCsReq : IMessage<IdleLiveCollectIncomeCsReq>, IMessage, IEquatable<IdleLiveCollectIncomeCsReq>, IDeepCloneable<IdleLiveCollectIncomeCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveCollectIncomeCsReq> _parser = new MessageParser<IdleLiveCollectIncomeCsReq>(() => new IdleLiveCollectIncomeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IHAOPPMCJLBFieldNumber = 3;

	private uint iHAOPPMCJLB_;

	public const int FIIJCFJJLOOFieldNumber = 6;

	private bool fIIJCFJJLOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveCollectIncomeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveCollectIncomeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHAOPPMCJLB
	{
		get
		{
			return iHAOPPMCJLB_;
		}
		set
		{
			iHAOPPMCJLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FIIJCFJJLOO
	{
		get
		{
			return fIIJCFJJLOO_;
		}
		set
		{
			fIIJCFJJLOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveCollectIncomeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveCollectIncomeCsReq(IdleLiveCollectIncomeCsReq other)
		: this()
	{
		iHAOPPMCJLB_ = other.iHAOPPMCJLB_;
		fIIJCFJJLOO_ = other.fIIJCFJJLOO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveCollectIncomeCsReq Clone()
	{
		return new IdleLiveCollectIncomeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveCollectIncomeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveCollectIncomeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IHAOPPMCJLB != other.IHAOPPMCJLB)
		{
			return false;
		}
		if (FIIJCFJJLOO != other.FIIJCFJJLOO)
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
		if (IHAOPPMCJLB != 0)
		{
			num ^= IHAOPPMCJLB.GetHashCode();
		}
		if (FIIJCFJJLOO)
		{
			num ^= FIIJCFJJLOO.GetHashCode();
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
		if (IHAOPPMCJLB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IHAOPPMCJLB);
		}
		if (FIIJCFJJLOO)
		{
			output.WriteRawTag(48);
			output.WriteBool(FIIJCFJJLOO);
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
		if (IHAOPPMCJLB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHAOPPMCJLB);
		}
		if (FIIJCFJJLOO)
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
	public void MergeFrom(IdleLiveCollectIncomeCsReq other)
	{
		if (other != null)
		{
			if (other.IHAOPPMCJLB != 0)
			{
				IHAOPPMCJLB = other.IHAOPPMCJLB;
			}
			if (other.FIIJCFJJLOO)
			{
				FIIJCFJJLOO = other.FIIJCFJJLOO;
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
			case 24u:
				IHAOPPMCJLB = input.ReadUInt32();
				break;
			case 48u:
				FIIJCFJJLOO = input.ReadBool();
				break;
			}
		}
	}
}
