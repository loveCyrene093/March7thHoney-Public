using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CancelDirectDeliveryNoticeCsReq : IMessage<CancelDirectDeliveryNoticeCsReq>, IMessage, IEquatable<CancelDirectDeliveryNoticeCsReq>, IDeepCloneable<CancelDirectDeliveryNoticeCsReq>, IBufferMessage
{
	private static readonly MessageParser<CancelDirectDeliveryNoticeCsReq> _parser = new MessageParser<CancelDirectDeliveryNoticeCsReq>(() => new CancelDirectDeliveryNoticeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OECCPKANHMNFieldNumber = 14;

	private uint oECCPKANHMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CancelDirectDeliveryNoticeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CancelDirectDeliveryNoticeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OECCPKANHMN
	{
		get
		{
			return oECCPKANHMN_;
		}
		set
		{
			oECCPKANHMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelDirectDeliveryNoticeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelDirectDeliveryNoticeCsReq(CancelDirectDeliveryNoticeCsReq other)
		: this()
	{
		oECCPKANHMN_ = other.oECCPKANHMN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelDirectDeliveryNoticeCsReq Clone()
	{
		return new CancelDirectDeliveryNoticeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CancelDirectDeliveryNoticeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CancelDirectDeliveryNoticeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OECCPKANHMN != other.OECCPKANHMN)
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
		if (OECCPKANHMN != 0)
		{
			num ^= OECCPKANHMN.GetHashCode();
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
		if (OECCPKANHMN != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OECCPKANHMN);
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
		if (OECCPKANHMN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OECCPKANHMN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CancelDirectDeliveryNoticeCsReq other)
	{
		if (other != null)
		{
			if (other.OECCPKANHMN != 0)
			{
				OECCPKANHMN = other.OECCPKANHMN;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				OECCPKANHMN = input.ReadUInt32();
			}
		}
	}
}
