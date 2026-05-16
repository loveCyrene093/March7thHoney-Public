using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MultipleDropInfoScNotify : IMessage<MultipleDropInfoScNotify>, IMessage, IEquatable<MultipleDropInfoScNotify>, IDeepCloneable<MultipleDropInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<MultipleDropInfoScNotify> _parser = new MessageParser<MultipleDropInfoScNotify>(() => new MultipleDropInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int DFEOOEHFAACFieldNumber = 6;

	private static readonly FieldCodec<DMINLLDNNDL> _repeated_dFEOOEHFAAC_codec = FieldCodec.ForMessage(50u, DMINLLDNNDL.Parser);

	private readonly RepeatedField<DMINLLDNNDL> dFEOOEHFAAC_ = new RepeatedField<DMINLLDNNDL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MultipleDropInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MultipleDropInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DMINLLDNNDL> DFEOOEHFAAC => dFEOOEHFAAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultipleDropInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultipleDropInfoScNotify(MultipleDropInfoScNotify other)
		: this()
	{
		dFEOOEHFAAC_ = other.dFEOOEHFAAC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultipleDropInfoScNotify Clone()
	{
		return new MultipleDropInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MultipleDropInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MultipleDropInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dFEOOEHFAAC_.Equals(other.dFEOOEHFAAC_))
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
		num ^= dFEOOEHFAAC_.GetHashCode();
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
		dFEOOEHFAAC_.WriteTo(ref output, _repeated_dFEOOEHFAAC_codec);
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
		num += dFEOOEHFAAC_.CalculateSize(_repeated_dFEOOEHFAAC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MultipleDropInfoScNotify other)
	{
		if (other != null)
		{
			dFEOOEHFAAC_.Add(other.dFEOOEHFAAC_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dFEOOEHFAAC_.AddEntriesFrom(ref input, _repeated_dFEOOEHFAAC_codec);
			}
		}
	}
}
