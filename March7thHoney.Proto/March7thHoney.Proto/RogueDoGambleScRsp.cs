using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueDoGambleScRsp : IMessage<RogueDoGambleScRsp>, IMessage, IEquatable<RogueDoGambleScRsp>, IDeepCloneable<RogueDoGambleScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueDoGambleScRsp> _parser = new MessageParser<RogueDoGambleScRsp>(() => new RogueDoGambleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CFADFLLLOPCFieldNumber = 5;

	private DKFAEKPKADH cFADFLLLOPC_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int OHAHCBOLDIAFieldNumber = 13;

	private uint oHAHCBOLDIA_;

	public const int LKHPMPEGJEEFieldNumber = 14;

	private uint lKHPMPEGJEE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueDoGambleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueDoGambleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKFAEKPKADH CFADFLLLOPC
	{
		get
		{
			return cFADFLLLOPC_;
		}
		set
		{
			cFADFLLLOPC_ = value;
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
	public uint OHAHCBOLDIA
	{
		get
		{
			return oHAHCBOLDIA_;
		}
		set
		{
			oHAHCBOLDIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LKHPMPEGJEE
	{
		get
		{
			return lKHPMPEGJEE_;
		}
		set
		{
			lKHPMPEGJEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueDoGambleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueDoGambleScRsp(RogueDoGambleScRsp other)
		: this()
	{
		cFADFLLLOPC_ = ((other.cFADFLLLOPC_ != null) ? other.cFADFLLLOPC_.Clone() : null);
		retcode_ = other.retcode_;
		oHAHCBOLDIA_ = other.oHAHCBOLDIA_;
		lKHPMPEGJEE_ = other.lKHPMPEGJEE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueDoGambleScRsp Clone()
	{
		return new RogueDoGambleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueDoGambleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueDoGambleScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CFADFLLLOPC, other.CFADFLLLOPC))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OHAHCBOLDIA != other.OHAHCBOLDIA)
		{
			return false;
		}
		if (LKHPMPEGJEE != other.LKHPMPEGJEE)
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
		if (cFADFLLLOPC_ != null)
		{
			num ^= CFADFLLLOPC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OHAHCBOLDIA != 0)
		{
			num ^= OHAHCBOLDIA.GetHashCode();
		}
		if (LKHPMPEGJEE != 0)
		{
			num ^= LKHPMPEGJEE.GetHashCode();
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
		if (cFADFLLLOPC_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CFADFLLLOPC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (OHAHCBOLDIA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OHAHCBOLDIA);
		}
		if (LKHPMPEGJEE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LKHPMPEGJEE);
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
		if (cFADFLLLOPC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CFADFLLLOPC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OHAHCBOLDIA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OHAHCBOLDIA);
		}
		if (LKHPMPEGJEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LKHPMPEGJEE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueDoGambleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cFADFLLLOPC_ != null)
		{
			if (cFADFLLLOPC_ == null)
			{
				CFADFLLLOPC = new DKFAEKPKADH();
			}
			CFADFLLLOPC.MergeFrom(other.CFADFLLLOPC);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.OHAHCBOLDIA != 0)
		{
			OHAHCBOLDIA = other.OHAHCBOLDIA;
		}
		if (other.LKHPMPEGJEE != 0)
		{
			LKHPMPEGJEE = other.LKHPMPEGJEE;
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
			case 42u:
				if (cFADFLLLOPC_ == null)
				{
					CFADFLLLOPC = new DKFAEKPKADH();
				}
				input.ReadMessage(CFADFLLLOPC);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				OHAHCBOLDIA = input.ReadUInt32();
				break;
			case 112u:
				LKHPMPEGJEE = input.ReadUInt32();
				break;
			}
		}
	}
}
