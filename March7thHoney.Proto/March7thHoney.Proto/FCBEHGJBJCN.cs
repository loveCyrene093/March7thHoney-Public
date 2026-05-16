using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FCBEHGJBJCN : IMessage<FCBEHGJBJCN>, IMessage, IEquatable<FCBEHGJBJCN>, IDeepCloneable<FCBEHGJBJCN>, IBufferMessage
{
	private static readonly MessageParser<FCBEHGJBJCN> _parser = new MessageParser<FCBEHGJBJCN>(() => new FCBEHGJBJCN());

	private UnknownFieldSet _unknownFields;

	public const int AMNJHJJMPJFFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_aMNJHJJMPJF_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> aMNJHJJMPJF_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FCBEHGJBJCN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FCBEHGJBJCNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AMNJHJJMPJF => aMNJHJJMPJF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCBEHGJBJCN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCBEHGJBJCN(FCBEHGJBJCN other)
		: this()
	{
		aMNJHJJMPJF_ = other.aMNJHJJMPJF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCBEHGJBJCN Clone()
	{
		return new FCBEHGJBJCN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FCBEHGJBJCN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FCBEHGJBJCN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aMNJHJJMPJF_.Equals(other.aMNJHJJMPJF_))
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
		num ^= aMNJHJJMPJF_.GetHashCode();
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
		aMNJHJJMPJF_.WriteTo(ref output, _repeated_aMNJHJJMPJF_codec);
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
		num += aMNJHJJMPJF_.CalculateSize(_repeated_aMNJHJJMPJF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FCBEHGJBJCN other)
	{
		if (other != null)
		{
			aMNJHJJMPJF_.Add(other.aMNJHJJMPJF_);
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
			if (num != 64 && num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aMNJHJJMPJF_.AddEntriesFrom(ref input, _repeated_aMNJHJJMPJF_codec);
			}
		}
	}
}
