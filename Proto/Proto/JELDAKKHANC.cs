using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JELDAKKHANC : IMessage<JELDAKKHANC>, IMessage, IEquatable<JELDAKKHANC>, IDeepCloneable<JELDAKKHANC>, IBufferMessage
{
	private static readonly MessageParser<JELDAKKHANC> _parser = new MessageParser<JELDAKKHANC>(() => new JELDAKKHANC());

	private UnknownFieldSet _unknownFields;

	public const int JDOMCFFACALFieldNumber = 6;

	private NANODNMFFFH jDOMCFFACAL_;

	public const int AOPAKLIFBALFieldNumber = 15;

	private NANODNMFFFH aOPAKLIFBAL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JELDAKKHANC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JELDAKKHANCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NANODNMFFFH JDOMCFFACAL
	{
		get
		{
			return jDOMCFFACAL_;
		}
		set
		{
			jDOMCFFACAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NANODNMFFFH AOPAKLIFBAL
	{
		get
		{
			return aOPAKLIFBAL_;
		}
		set
		{
			aOPAKLIFBAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JELDAKKHANC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JELDAKKHANC(JELDAKKHANC other)
		: this()
	{
		jDOMCFFACAL_ = ((other.jDOMCFFACAL_ != null) ? other.jDOMCFFACAL_.Clone() : null);
		aOPAKLIFBAL_ = ((other.aOPAKLIFBAL_ != null) ? other.aOPAKLIFBAL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JELDAKKHANC Clone()
	{
		return new JELDAKKHANC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JELDAKKHANC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JELDAKKHANC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JDOMCFFACAL, other.JDOMCFFACAL))
		{
			return false;
		}
		if (!object.Equals(AOPAKLIFBAL, other.AOPAKLIFBAL))
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
		if (jDOMCFFACAL_ != null)
		{
			num ^= JDOMCFFACAL.GetHashCode();
		}
		if (aOPAKLIFBAL_ != null)
		{
			num ^= AOPAKLIFBAL.GetHashCode();
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
		if (jDOMCFFACAL_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JDOMCFFACAL);
		}
		if (aOPAKLIFBAL_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(AOPAKLIFBAL);
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
		if (jDOMCFFACAL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JDOMCFFACAL);
		}
		if (aOPAKLIFBAL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AOPAKLIFBAL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JELDAKKHANC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jDOMCFFACAL_ != null)
		{
			if (jDOMCFFACAL_ == null)
			{
				JDOMCFFACAL = new NANODNMFFFH();
			}
			JDOMCFFACAL.MergeFrom(other.JDOMCFFACAL);
		}
		if (other.aOPAKLIFBAL_ != null)
		{
			if (aOPAKLIFBAL_ == null)
			{
				AOPAKLIFBAL = new NANODNMFFFH();
			}
			AOPAKLIFBAL.MergeFrom(other.AOPAKLIFBAL);
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
				if (jDOMCFFACAL_ == null)
				{
					JDOMCFFACAL = new NANODNMFFFH();
				}
				input.ReadMessage(JDOMCFFACAL);
				break;
			case 122u:
				if (aOPAKLIFBAL_ == null)
				{
					AOPAKLIFBAL = new NANODNMFFFH();
				}
				input.ReadMessage(AOPAKLIFBAL);
				break;
			}
		}
	}
}
