using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPunkLordBattleRecordCsReq : IMessage<GetPunkLordBattleRecordCsReq>, IMessage, IEquatable<GetPunkLordBattleRecordCsReq>, IDeepCloneable<GetPunkLordBattleRecordCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetPunkLordBattleRecordCsReq> _parser = new MessageParser<GetPunkLordBattleRecordCsReq>(() => new GetPunkLordBattleRecordCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JIPALBLOPFIFieldNumber = 12;

	private JLLIDDIBOHI jIPALBLOPFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPunkLordBattleRecordCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPunkLordBattleRecordCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLIDDIBOHI JIPALBLOPFI
	{
		get
		{
			return jIPALBLOPFI_;
		}
		set
		{
			jIPALBLOPFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordBattleRecordCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordBattleRecordCsReq(GetPunkLordBattleRecordCsReq other)
		: this()
	{
		jIPALBLOPFI_ = ((other.jIPALBLOPFI_ != null) ? other.jIPALBLOPFI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPunkLordBattleRecordCsReq Clone()
	{
		return new GetPunkLordBattleRecordCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPunkLordBattleRecordCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPunkLordBattleRecordCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JIPALBLOPFI, other.JIPALBLOPFI))
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
		if (jIPALBLOPFI_ != null)
		{
			num ^= JIPALBLOPFI.GetHashCode();
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
		if (jIPALBLOPFI_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(JIPALBLOPFI);
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
		if (jIPALBLOPFI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JIPALBLOPFI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPunkLordBattleRecordCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jIPALBLOPFI_ != null)
		{
			if (jIPALBLOPFI_ == null)
			{
				JIPALBLOPFI = new JLLIDDIBOHI();
			}
			JIPALBLOPFI.MergeFrom(other.JIPALBLOPFI);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (jIPALBLOPFI_ == null)
			{
				JIPALBLOPFI = new JLLIDDIBOHI();
			}
			input.ReadMessage(JIPALBLOPFI);
		}
	}
}
