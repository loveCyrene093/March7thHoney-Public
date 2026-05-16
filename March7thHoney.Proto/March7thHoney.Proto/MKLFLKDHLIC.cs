using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MKLFLKDHLIC : IMessage<MKLFLKDHLIC>, IMessage, IEquatable<MKLFLKDHLIC>, IDeepCloneable<MKLFLKDHLIC>, IBufferMessage
{
	private static readonly MessageParser<MKLFLKDHLIC> _parser = new MessageParser<MKLFLKDHLIC>(() => new MKLFLKDHLIC());

	private UnknownFieldSet _unknownFields;

	public const int IACKOCPGIAKFieldNumber = 12;

	private MACJBIAFNOI iACKOCPGIAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MKLFLKDHLIC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MKLFLKDHLICReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MACJBIAFNOI IACKOCPGIAK
	{
		get
		{
			return iACKOCPGIAK_;
		}
		set
		{
			iACKOCPGIAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKLFLKDHLIC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKLFLKDHLIC(MKLFLKDHLIC other)
		: this()
	{
		iACKOCPGIAK_ = ((other.iACKOCPGIAK_ != null) ? other.iACKOCPGIAK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKLFLKDHLIC Clone()
	{
		return new MKLFLKDHLIC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MKLFLKDHLIC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MKLFLKDHLIC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IACKOCPGIAK, other.IACKOCPGIAK))
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
		if (iACKOCPGIAK_ != null)
		{
			num ^= IACKOCPGIAK.GetHashCode();
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
		if (iACKOCPGIAK_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(IACKOCPGIAK);
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
		if (iACKOCPGIAK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IACKOCPGIAK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MKLFLKDHLIC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iACKOCPGIAK_ != null)
		{
			if (iACKOCPGIAK_ == null)
			{
				IACKOCPGIAK = new MACJBIAFNOI();
			}
			IACKOCPGIAK.MergeFrom(other.IACKOCPGIAK);
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
			if (iACKOCPGIAK_ == null)
			{
				IACKOCPGIAK = new MACJBIAFNOI();
			}
			input.ReadMessage(IACKOCPGIAK);
		}
	}
}
