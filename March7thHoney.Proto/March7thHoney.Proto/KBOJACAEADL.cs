using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KBOJACAEADL : IMessage<KBOJACAEADL>, IMessage, IEquatable<KBOJACAEADL>, IDeepCloneable<KBOJACAEADL>, IBufferMessage
{
	private static readonly MessageParser<KBOJACAEADL> _parser = new MessageParser<KBOJACAEADL>(() => new KBOJACAEADL());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private uint type_;

	public const int AOONGKJPKOBFieldNumber = 8;

	private AGBLLFGOBKE aOONGKJPKOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KBOJACAEADL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KBOJACAEADLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE AOONGKJPKOB
	{
		get
		{
			return aOONGKJPKOB_;
		}
		set
		{
			aOONGKJPKOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBOJACAEADL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBOJACAEADL(KBOJACAEADL other)
		: this()
	{
		type_ = other.type_;
		aOONGKJPKOB_ = ((other.aOONGKJPKOB_ != null) ? other.aOONGKJPKOB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBOJACAEADL Clone()
	{
		return new KBOJACAEADL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KBOJACAEADL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KBOJACAEADL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!object.Equals(AOONGKJPKOB, other.AOONGKJPKOB))
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
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (aOONGKJPKOB_ != null)
		{
			num ^= AOONGKJPKOB.GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Type);
		}
		if (aOONGKJPKOB_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(AOONGKJPKOB);
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
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (aOONGKJPKOB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AOONGKJPKOB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KBOJACAEADL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		if (other.aOONGKJPKOB_ != null)
		{
			if (aOONGKJPKOB_ == null)
			{
				AOONGKJPKOB = new AGBLLFGOBKE();
			}
			AOONGKJPKOB.MergeFrom(other.AOONGKJPKOB);
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
			case 8u:
				Type = input.ReadUInt32();
				break;
			case 66u:
				if (aOONGKJPKOB_ == null)
				{
					AOONGKJPKOB = new AGBLLFGOBKE();
				}
				input.ReadMessage(AOONGKJPKOB);
				break;
			}
		}
	}
}
