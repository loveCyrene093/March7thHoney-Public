using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchDiyCsReq : IMessage<TrainCakeCatchDiyCsReq>, IMessage, IEquatable<TrainCakeCatchDiyCsReq>, IDeepCloneable<TrainCakeCatchDiyCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchDiyCsReq> _parser = new MessageParser<TrainCakeCatchDiyCsReq>(() => new TrainCakeCatchDiyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PEOECDDANNPFieldNumber = 3;

	private FOFNOBHLKGO pEOECDDANNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchDiyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchDiyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO PEOECDDANNP
	{
		get
		{
			return pEOECDDANNP_;
		}
		set
		{
			pEOECDDANNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyCsReq(TrainCakeCatchDiyCsReq other)
		: this()
	{
		pEOECDDANNP_ = ((other.pEOECDDANNP_ != null) ? other.pEOECDDANNP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyCsReq Clone()
	{
		return new TrainCakeCatchDiyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchDiyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchDiyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PEOECDDANNP, other.PEOECDDANNP))
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
		if (pEOECDDANNP_ != null)
		{
			num ^= PEOECDDANNP.GetHashCode();
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
		if (pEOECDDANNP_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PEOECDDANNP);
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
		if (pEOECDDANNP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEOECDDANNP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainCakeCatchDiyCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pEOECDDANNP_ != null)
		{
			if (pEOECDDANNP_ == null)
			{
				PEOECDDANNP = new FOFNOBHLKGO();
			}
			PEOECDDANNP.MergeFrom(other.PEOECDDANNP);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pEOECDDANNP_ == null)
			{
				PEOECDDANNP = new FOFNOBHLKGO();
			}
			input.ReadMessage(PEOECDDANNP);
		}
	}
}
