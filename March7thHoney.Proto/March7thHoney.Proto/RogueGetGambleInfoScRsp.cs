using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueGetGambleInfoScRsp : IMessage<RogueGetGambleInfoScRsp>, IMessage, IEquatable<RogueGetGambleInfoScRsp>, IDeepCloneable<RogueGetGambleInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueGetGambleInfoScRsp> _parser = new MessageParser<RogueGetGambleInfoScRsp>(() => new RogueGetGambleInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CFADFLLLOPCFieldNumber = 3;

	private DKFAEKPKADH cFADFLLLOPC_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueGetGambleInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueGetGambleInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public RogueGetGambleInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueGetGambleInfoScRsp(RogueGetGambleInfoScRsp other)
		: this()
	{
		cFADFLLLOPC_ = ((other.cFADFLLLOPC_ != null) ? other.cFADFLLLOPC_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueGetGambleInfoScRsp Clone()
	{
		return new RogueGetGambleInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueGetGambleInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueGetGambleInfoScRsp other)
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
			output.WriteRawTag(26);
			output.WriteMessage(CFADFLLLOPC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
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
		if (cFADFLLLOPC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CFADFLLLOPC);
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
	public void MergeFrom(RogueGetGambleInfoScRsp other)
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
			case 26u:
				if (cFADFLLLOPC_ == null)
				{
					CFADFLLLOPC = new DKFAEKPKADH();
				}
				input.ReadMessage(CFADFLLLOPC);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
