using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueWorkbenchReforgeBuffReq : IMessage<RogueWorkbenchReforgeBuffReq>, IMessage, IEquatable<RogueWorkbenchReforgeBuffReq>, IDeepCloneable<RogueWorkbenchReforgeBuffReq>, IBufferMessage
{
	private static readonly MessageParser<RogueWorkbenchReforgeBuffReq> _parser = new MessageParser<RogueWorkbenchReforgeBuffReq>(() => new RogueWorkbenchReforgeBuffReq());

	private UnknownFieldSet _unknownFields;

	public const int JBGFPJLMFHHFieldNumber = 7;

	private PNAMCJPNCNB jBGFPJLMFHH_;

	public const int PropEntityIdFieldNumber = 11;

	private uint propEntityId_;

	public const int FuncIdFieldNumber = 14;

	private uint funcId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueWorkbenchReforgeBuffReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueWorkbenchReforgeBuffReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNAMCJPNCNB JBGFPJLMFHH
	{
		get
		{
			return jBGFPJLMFHH_;
		}
		set
		{
			jBGFPJLMFHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FuncId
	{
		get
		{
			return funcId_;
		}
		set
		{
			funcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchReforgeBuffReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchReforgeBuffReq(RogueWorkbenchReforgeBuffReq other)
		: this()
	{
		jBGFPJLMFHH_ = ((other.jBGFPJLMFHH_ != null) ? other.jBGFPJLMFHH_.Clone() : null);
		propEntityId_ = other.propEntityId_;
		funcId_ = other.funcId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchReforgeBuffReq Clone()
	{
		return new RogueWorkbenchReforgeBuffReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueWorkbenchReforgeBuffReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueWorkbenchReforgeBuffReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JBGFPJLMFHH, other.JBGFPJLMFHH))
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (FuncId != other.FuncId)
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
		if (jBGFPJLMFHH_ != null)
		{
			num ^= JBGFPJLMFHH.GetHashCode();
		}
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (FuncId != 0)
		{
			num ^= FuncId.GetHashCode();
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
		if (jBGFPJLMFHH_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(JBGFPJLMFHH);
		}
		if (PropEntityId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PropEntityId);
		}
		if (FuncId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FuncId);
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
		if (jBGFPJLMFHH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JBGFPJLMFHH);
		}
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (FuncId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FuncId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueWorkbenchReforgeBuffReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jBGFPJLMFHH_ != null)
		{
			if (jBGFPJLMFHH_ == null)
			{
				JBGFPJLMFHH = new PNAMCJPNCNB();
			}
			JBGFPJLMFHH.MergeFrom(other.JBGFPJLMFHH);
		}
		if (other.PropEntityId != 0)
		{
			PropEntityId = other.PropEntityId;
		}
		if (other.FuncId != 0)
		{
			FuncId = other.FuncId;
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
			case 58u:
				if (jBGFPJLMFHH_ == null)
				{
					JBGFPJLMFHH = new PNAMCJPNCNB();
				}
				input.ReadMessage(JBGFPJLMFHH);
				break;
			case 88u:
				PropEntityId = input.ReadUInt32();
				break;
			case 112u:
				FuncId = input.ReadUInt32();
				break;
			}
		}
	}
}
