using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearUpdatePinRelicCsReq : IMessage<RelicSmartWearUpdatePinRelicCsReq>, IMessage, IEquatable<RelicSmartWearUpdatePinRelicCsReq>, IDeepCloneable<RelicSmartWearUpdatePinRelicCsReq>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearUpdatePinRelicCsReq> _parser = new MessageParser<RelicSmartWearUpdatePinRelicCsReq>(() => new RelicSmartWearUpdatePinRelicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DACMPJLJGBCFieldNumber = 1;

	private BDEKEIKAKML dACMPJLJGBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearUpdatePinRelicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearUpdatePinRelicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEKEIKAKML DACMPJLJGBC
	{
		get
		{
			return dACMPJLJGBC_;
		}
		set
		{
			dACMPJLJGBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicCsReq(RelicSmartWearUpdatePinRelicCsReq other)
		: this()
	{
		dACMPJLJGBC_ = ((other.dACMPJLJGBC_ != null) ? other.dACMPJLJGBC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicCsReq Clone()
	{
		return new RelicSmartWearUpdatePinRelicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearUpdatePinRelicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearUpdatePinRelicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DACMPJLJGBC, other.DACMPJLJGBC))
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
		if (dACMPJLJGBC_ != null)
		{
			num ^= DACMPJLJGBC.GetHashCode();
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
		if (dACMPJLJGBC_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DACMPJLJGBC);
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
		if (dACMPJLJGBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DACMPJLJGBC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearUpdatePinRelicCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dACMPJLJGBC_ != null)
		{
			if (dACMPJLJGBC_ == null)
			{
				DACMPJLJGBC = new BDEKEIKAKML();
			}
			DACMPJLJGBC.MergeFrom(other.DACMPJLJGBC);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (dACMPJLJGBC_ == null)
			{
				DACMPJLJGBC = new BDEKEIKAKML();
			}
			input.ReadMessage(DACMPJLJGBC);
		}
	}
}
