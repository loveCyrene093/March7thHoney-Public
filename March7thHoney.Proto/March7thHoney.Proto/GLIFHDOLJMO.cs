using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLIFHDOLJMO : IMessage<GLIFHDOLJMO>, IMessage, IEquatable<GLIFHDOLJMO>, IDeepCloneable<GLIFHDOLJMO>, IBufferMessage
{
	private static readonly MessageParser<GLIFHDOLJMO> _parser = new MessageParser<GLIFHDOLJMO>(() => new GLIFHDOLJMO());

	private UnknownFieldSet _unknownFields;

	public const int EDBKOPFOBNFFieldNumber = 6;

	private EFEGKDHEMFN eDBKOPFOBNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLIFHDOLJMO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLIFHDOLJMOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN EDBKOPFOBNF
	{
		get
		{
			return eDBKOPFOBNF_;
		}
		set
		{
			eDBKOPFOBNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLIFHDOLJMO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLIFHDOLJMO(GLIFHDOLJMO other)
		: this()
	{
		eDBKOPFOBNF_ = ((other.eDBKOPFOBNF_ != null) ? other.eDBKOPFOBNF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLIFHDOLJMO Clone()
	{
		return new GLIFHDOLJMO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLIFHDOLJMO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLIFHDOLJMO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EDBKOPFOBNF, other.EDBKOPFOBNF))
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
		if (eDBKOPFOBNF_ != null)
		{
			num ^= EDBKOPFOBNF.GetHashCode();
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
		if (eDBKOPFOBNF_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EDBKOPFOBNF);
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
		if (eDBKOPFOBNF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDBKOPFOBNF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GLIFHDOLJMO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eDBKOPFOBNF_ != null)
		{
			if (eDBKOPFOBNF_ == null)
			{
				EDBKOPFOBNF = new EFEGKDHEMFN();
			}
			EDBKOPFOBNF.MergeFrom(other.EDBKOPFOBNF);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eDBKOPFOBNF_ == null)
			{
				EDBKOPFOBNF = new EFEGKDHEMFN();
			}
			input.ReadMessage(EDBKOPFOBNF);
		}
	}
}
