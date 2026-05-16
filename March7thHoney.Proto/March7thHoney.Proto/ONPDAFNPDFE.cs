using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ONPDAFNPDFE : IMessage<ONPDAFNPDFE>, IMessage, IEquatable<ONPDAFNPDFE>, IDeepCloneable<ONPDAFNPDFE>, IBufferMessage
{
	private static readonly MessageParser<ONPDAFNPDFE> _parser = new MessageParser<ONPDAFNPDFE>(() => new ONPDAFNPDFE());

	private UnknownFieldSet _unknownFields;

	public const int JKAHDDMJMGIFieldNumber = 11;

	private uint jKAHDDMJMGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ONPDAFNPDFE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ONPDAFNPDFEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKAHDDMJMGI
	{
		get
		{
			return jKAHDDMJMGI_;
		}
		set
		{
			jKAHDDMJMGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONPDAFNPDFE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONPDAFNPDFE(ONPDAFNPDFE other)
		: this()
	{
		jKAHDDMJMGI_ = other.jKAHDDMJMGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONPDAFNPDFE Clone()
	{
		return new ONPDAFNPDFE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ONPDAFNPDFE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ONPDAFNPDFE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKAHDDMJMGI != other.JKAHDDMJMGI)
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
		if (JKAHDDMJMGI != 0)
		{
			num ^= JKAHDDMJMGI.GetHashCode();
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
		if (JKAHDDMJMGI != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JKAHDDMJMGI);
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
		if (JKAHDDMJMGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKAHDDMJMGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ONPDAFNPDFE other)
	{
		if (other != null)
		{
			if (other.JKAHDDMJMGI != 0)
			{
				JKAHDDMJMGI = other.JKAHDDMJMGI;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JKAHDDMJMGI = input.ReadUInt32();
			}
		}
	}
}
