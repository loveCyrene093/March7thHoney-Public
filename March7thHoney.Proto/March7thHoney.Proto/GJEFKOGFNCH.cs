using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GJEFKOGFNCH : IMessage<GJEFKOGFNCH>, IMessage, IEquatable<GJEFKOGFNCH>, IDeepCloneable<GJEFKOGFNCH>, IBufferMessage
{
	private static readonly MessageParser<GJEFKOGFNCH> _parser = new MessageParser<GJEFKOGFNCH>(() => new GJEFKOGFNCH());

	private UnknownFieldSet _unknownFields;

	public const int CHNEKIJMELKFieldNumber = 9;

	private uint cHNEKIJMELK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GJEFKOGFNCH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GJEFKOGFNCHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHNEKIJMELK
	{
		get
		{
			return cHNEKIJMELK_;
		}
		set
		{
			cHNEKIJMELK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJEFKOGFNCH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJEFKOGFNCH(GJEFKOGFNCH other)
		: this()
	{
		cHNEKIJMELK_ = other.cHNEKIJMELK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJEFKOGFNCH Clone()
	{
		return new GJEFKOGFNCH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GJEFKOGFNCH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GJEFKOGFNCH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHNEKIJMELK != other.CHNEKIJMELK)
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
		if (CHNEKIJMELK != 0)
		{
			num ^= CHNEKIJMELK.GetHashCode();
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
		if (CHNEKIJMELK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CHNEKIJMELK);
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
		if (CHNEKIJMELK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHNEKIJMELK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GJEFKOGFNCH other)
	{
		if (other != null)
		{
			if (other.CHNEKIJMELK != 0)
			{
				CHNEKIJMELK = other.CHNEKIJMELK;
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
			if (num != 72)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CHNEKIJMELK = input.ReadUInt32();
			}
		}
	}
}
