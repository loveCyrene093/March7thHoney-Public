using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCJAIMKNINL : IMessage<CCJAIMKNINL>, IMessage, IEquatable<CCJAIMKNINL>, IDeepCloneable<CCJAIMKNINL>, IBufferMessage
{
	private static readonly MessageParser<CCJAIMKNINL> _parser = new MessageParser<CCJAIMKNINL>(() => new CCJAIMKNINL());

	private UnknownFieldSet _unknownFields;

	public const int HEMOCMJABPAFieldNumber = 15;

	private ILLBNKFBNBP hEMOCMJABPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCJAIMKNINL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCJAIMKNINLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP HEMOCMJABPA
	{
		get
		{
			return hEMOCMJABPA_;
		}
		set
		{
			hEMOCMJABPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCJAIMKNINL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCJAIMKNINL(CCJAIMKNINL other)
		: this()
	{
		hEMOCMJABPA_ = ((other.hEMOCMJABPA_ != null) ? other.hEMOCMJABPA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCJAIMKNINL Clone()
	{
		return new CCJAIMKNINL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCJAIMKNINL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCJAIMKNINL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HEMOCMJABPA, other.HEMOCMJABPA))
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
		if (hEMOCMJABPA_ != null)
		{
			num ^= HEMOCMJABPA.GetHashCode();
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
		if (hEMOCMJABPA_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(HEMOCMJABPA);
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
		if (hEMOCMJABPA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HEMOCMJABPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCJAIMKNINL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hEMOCMJABPA_ != null)
		{
			if (hEMOCMJABPA_ == null)
			{
				HEMOCMJABPA = new ILLBNKFBNBP();
			}
			HEMOCMJABPA.MergeFrom(other.HEMOCMJABPA);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (hEMOCMJABPA_ == null)
			{
				HEMOCMJABPA = new ILLBNKFBNBP();
			}
			input.ReadMessage(HEMOCMJABPA);
		}
	}
}
