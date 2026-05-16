using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchDiyScRsp : IMessage<TrainCakeCatchDiyScRsp>, IMessage, IEquatable<TrainCakeCatchDiyScRsp>, IDeepCloneable<TrainCakeCatchDiyScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchDiyScRsp> _parser = new MessageParser<TrainCakeCatchDiyScRsp>(() => new TrainCakeCatchDiyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PEOECDDANNPFieldNumber = 6;

	private FOFNOBHLKGO pEOECDDANNP_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchDiyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchDiyScRspReflection.Descriptor.MessageTypes[0];

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyScRsp(TrainCakeCatchDiyScRsp other)
		: this()
	{
		pEOECDDANNP_ = ((other.pEOECDDANNP_ != null) ? other.pEOECDDANNP_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchDiyScRsp Clone()
	{
		return new TrainCakeCatchDiyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchDiyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchDiyScRsp other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
			output.WriteRawTag(50);
			output.WriteMessage(PEOECDDANNP);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainCakeCatchDiyScRsp other)
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
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 50u:
				if (pEOECDDANNP_ == null)
				{
					PEOECDDANNP = new FOFNOBHLKGO();
				}
				input.ReadMessage(PEOECDDANNP);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
