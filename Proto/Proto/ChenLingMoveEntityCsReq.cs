using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingMoveEntityCsReq : IMessage<ChenLingMoveEntityCsReq>, IMessage, IEquatable<ChenLingMoveEntityCsReq>, IDeepCloneable<ChenLingMoveEntityCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingMoveEntityCsReq> _parser = new MessageParser<ChenLingMoveEntityCsReq>(() => new ChenLingMoveEntityCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 10;

	private uint pENLMEIJIFK_;

	public const int JDPHGEJLPPHFieldNumber = 14;

	private FDOEMKPGHFL jDPHGEJLPPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingMoveEntityCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingMoveEntityCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL JDPHGEJLPPH
	{
		get
		{
			return jDPHGEJLPPH_;
		}
		set
		{
			jDPHGEJLPPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingMoveEntityCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingMoveEntityCsReq(ChenLingMoveEntityCsReq other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		jDPHGEJLPPH_ = ((other.jDPHGEJLPPH_ != null) ? other.jDPHGEJLPPH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingMoveEntityCsReq Clone()
	{
		return new ChenLingMoveEntityCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingMoveEntityCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingMoveEntityCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (!object.Equals(JDPHGEJLPPH, other.JDPHGEJLPPH))
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
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (jDPHGEJLPPH_ != null)
		{
			num ^= JDPHGEJLPPH.GetHashCode();
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
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (jDPHGEJLPPH_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JDPHGEJLPPH);
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
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (jDPHGEJLPPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JDPHGEJLPPH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingMoveEntityCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PENLMEIJIFK != 0)
		{
			PENLMEIJIFK = other.PENLMEIJIFK;
		}
		if (other.jDPHGEJLPPH_ != null)
		{
			if (jDPHGEJLPPH_ == null)
			{
				JDPHGEJLPPH = new FDOEMKPGHFL();
			}
			JDPHGEJLPPH.MergeFrom(other.JDPHGEJLPPH);
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
			case 80u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 114u:
				if (jDPHGEJLPPH_ == null)
				{
					JDPHGEJLPPH = new FDOEMKPGHFL();
				}
				input.ReadMessage(JDPHGEJLPPH);
				break;
			}
		}
	}
}
