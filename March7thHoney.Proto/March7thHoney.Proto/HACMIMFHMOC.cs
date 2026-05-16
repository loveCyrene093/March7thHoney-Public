using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HACMIMFHMOC : IMessage<HACMIMFHMOC>, IMessage, IEquatable<HACMIMFHMOC>, IDeepCloneable<HACMIMFHMOC>, IBufferMessage
{
	private static readonly MessageParser<HACMIMFHMOC> _parser = new MessageParser<HACMIMFHMOC>(() => new HACMIMFHMOC());

	private UnknownFieldSet _unknownFields;

	public const int HFMLMJALLPCFieldNumber = 10;

	private uint hFMLMJALLPC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HACMIMFHMOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HACMIMFHMOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFMLMJALLPC
	{
		get
		{
			return hFMLMJALLPC_;
		}
		set
		{
			hFMLMJALLPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HACMIMFHMOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HACMIMFHMOC(HACMIMFHMOC other)
		: this()
	{
		hFMLMJALLPC_ = other.hFMLMJALLPC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HACMIMFHMOC Clone()
	{
		return new HACMIMFHMOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HACMIMFHMOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HACMIMFHMOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HFMLMJALLPC != other.HFMLMJALLPC)
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
		if (HFMLMJALLPC != 0)
		{
			num ^= HFMLMJALLPC.GetHashCode();
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
		if (HFMLMJALLPC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(HFMLMJALLPC);
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
		if (HFMLMJALLPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFMLMJALLPC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HACMIMFHMOC other)
	{
		if (other != null)
		{
			if (other.HFMLMJALLPC != 0)
			{
				HFMLMJALLPC = other.HFMLMJALLPC;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HFMLMJALLPC = input.ReadUInt32();
			}
		}
	}
}
