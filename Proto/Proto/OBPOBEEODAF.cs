using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBPOBEEODAF : IMessage<OBPOBEEODAF>, IMessage, IEquatable<OBPOBEEODAF>, IDeepCloneable<OBPOBEEODAF>, IBufferMessage
{
	private static readonly MessageParser<OBPOBEEODAF> _parser = new MessageParser<OBPOBEEODAF>(() => new OBPOBEEODAF());

	private UnknownFieldSet _unknownFields;

	public const int NIILLMJNGECFieldNumber = 4;

	private LNMBJPJONPE nIILLMJNGEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBPOBEEODAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBPOBEEODAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNMBJPJONPE NIILLMJNGEC
	{
		get
		{
			return nIILLMJNGEC_;
		}
		set
		{
			nIILLMJNGEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBPOBEEODAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBPOBEEODAF(OBPOBEEODAF other)
		: this()
	{
		nIILLMJNGEC_ = ((other.nIILLMJNGEC_ != null) ? other.nIILLMJNGEC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBPOBEEODAF Clone()
	{
		return new OBPOBEEODAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBPOBEEODAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBPOBEEODAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NIILLMJNGEC, other.NIILLMJNGEC))
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
		if (nIILLMJNGEC_ != null)
		{
			num ^= NIILLMJNGEC.GetHashCode();
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
		if (nIILLMJNGEC_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(NIILLMJNGEC);
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
		if (nIILLMJNGEC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NIILLMJNGEC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OBPOBEEODAF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nIILLMJNGEC_ != null)
		{
			if (nIILLMJNGEC_ == null)
			{
				NIILLMJNGEC = new LNMBJPJONPE();
			}
			NIILLMJNGEC.MergeFrom(other.NIILLMJNGEC);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nIILLMJNGEC_ == null)
			{
				NIILLMJNGEC = new LNMBJPJONPE();
			}
			input.ReadMessage(NIILLMJNGEC);
		}
	}
}
