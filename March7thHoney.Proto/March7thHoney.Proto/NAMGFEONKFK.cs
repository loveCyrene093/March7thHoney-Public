using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NAMGFEONKFK : IMessage<NAMGFEONKFK>, IMessage, IEquatable<NAMGFEONKFK>, IDeepCloneable<NAMGFEONKFK>, IBufferMessage
{
	private static readonly MessageParser<NAMGFEONKFK> _parser = new MessageParser<NAMGFEONKFK>(() => new NAMGFEONKFK());

	private UnknownFieldSet _unknownFields;

	public const int CCIEIAADLMEFieldNumber = 7;

	private int cCIEIAADLME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NAMGFEONKFK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NAMGFEONKFKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CCIEIAADLME
	{
		get
		{
			return cCIEIAADLME_;
		}
		set
		{
			cCIEIAADLME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAMGFEONKFK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAMGFEONKFK(NAMGFEONKFK other)
		: this()
	{
		cCIEIAADLME_ = other.cCIEIAADLME_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAMGFEONKFK Clone()
	{
		return new NAMGFEONKFK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NAMGFEONKFK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NAMGFEONKFK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CCIEIAADLME != other.CCIEIAADLME)
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
		if (CCIEIAADLME != 0)
		{
			num ^= CCIEIAADLME.GetHashCode();
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
		if (CCIEIAADLME != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CCIEIAADLME);
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
		if (CCIEIAADLME != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CCIEIAADLME);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NAMGFEONKFK other)
	{
		if (other != null)
		{
			if (other.CCIEIAADLME != 0)
			{
				CCIEIAADLME = other.CCIEIAADLME;
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
			if (num != 56)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CCIEIAADLME = input.ReadInt32();
			}
		}
	}
}
