using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DHNFGJBHMAA : IMessage<DHNFGJBHMAA>, IMessage, IEquatable<DHNFGJBHMAA>, IDeepCloneable<DHNFGJBHMAA>, IBufferMessage
{
	private static readonly MessageParser<DHNFGJBHMAA> _parser = new MessageParser<DHNFGJBHMAA>(() => new DHNFGJBHMAA());

	private UnknownFieldSet _unknownFields;

	public const int JPJGFJDHJDDFieldNumber = 1;

	private int jPJGFJDHJDD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DHNFGJBHMAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DHNFGJBHMAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JPJGFJDHJDD
	{
		get
		{
			return jPJGFJDHJDD_;
		}
		set
		{
			jPJGFJDHJDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHNFGJBHMAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHNFGJBHMAA(DHNFGJBHMAA other)
		: this()
	{
		jPJGFJDHJDD_ = other.jPJGFJDHJDD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHNFGJBHMAA Clone()
	{
		return new DHNFGJBHMAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DHNFGJBHMAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DHNFGJBHMAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JPJGFJDHJDD != other.JPJGFJDHJDD)
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
		if (JPJGFJDHJDD != 0)
		{
			num ^= JPJGFJDHJDD.GetHashCode();
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
		if (JPJGFJDHJDD != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(JPJGFJDHJDD);
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
		if (JPJGFJDHJDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JPJGFJDHJDD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DHNFGJBHMAA other)
	{
		if (other != null)
		{
			if (other.JPJGFJDHJDD != 0)
			{
				JPJGFJDHJDD = other.JPJGFJDHJDD;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JPJGFJDHJDD = input.ReadInt32();
			}
		}
	}
}
