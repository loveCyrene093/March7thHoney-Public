using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MultipleDropInfoNotify : IMessage<MultipleDropInfoNotify>, IMessage, IEquatable<MultipleDropInfoNotify>, IDeepCloneable<MultipleDropInfoNotify>, IBufferMessage
{
	private static readonly MessageParser<MultipleDropInfoNotify> _parser = new MessageParser<MultipleDropInfoNotify>(() => new MultipleDropInfoNotify());

	private UnknownFieldSet _unknownFields;

	public const int DFEOOEHFAACFieldNumber = 1;

	private static readonly FieldCodec<DMINLLDNNDL> _repeated_dFEOOEHFAAC_codec = FieldCodec.ForMessage(10u, DMINLLDNNDL.Parser);

	private readonly RepeatedField<DMINLLDNNDL> dFEOOEHFAAC_ = new RepeatedField<DMINLLDNNDL>();

	public const int ALDKLKHLGGPFieldNumber = 5;

	private static readonly FieldCodec<ENALOKIFDFH> _repeated_aLDKLKHLGGP_codec = FieldCodec.ForMessage(42u, ENALOKIFDFH.Parser);

	private readonly RepeatedField<ENALOKIFDFH> aLDKLKHLGGP_ = new RepeatedField<ENALOKIFDFH>();

	public const int JNGHGLMBPOHFieldNumber = 14;

	private static readonly FieldCodec<AEOEFOILEBP> _repeated_jNGHGLMBPOH_codec = FieldCodec.ForMessage(114u, AEOEFOILEBP.Parser);

	private readonly RepeatedField<AEOEFOILEBP> jNGHGLMBPOH_ = new RepeatedField<AEOEFOILEBP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MultipleDropInfoNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MultipleDropInfoNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DMINLLDNNDL> DFEOOEHFAAC => dFEOOEHFAAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ENALOKIFDFH> ALDKLKHLGGP => aLDKLKHLGGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AEOEFOILEBP> JNGHGLMBPOH => jNGHGLMBPOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultipleDropInfoNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultipleDropInfoNotify(MultipleDropInfoNotify other)
		: this()
	{
		dFEOOEHFAAC_ = other.dFEOOEHFAAC_.Clone();
		aLDKLKHLGGP_ = other.aLDKLKHLGGP_.Clone();
		jNGHGLMBPOH_ = other.jNGHGLMBPOH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultipleDropInfoNotify Clone()
	{
		return new MultipleDropInfoNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MultipleDropInfoNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MultipleDropInfoNotify other)
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
		if (!aLDKLKHLGGP_.Equals(other.aLDKLKHLGGP_))
		{
			return false;
		}
		if (!jNGHGLMBPOH_.Equals(other.jNGHGLMBPOH_))
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
		num ^= aLDKLKHLGGP_.GetHashCode();
		num ^= jNGHGLMBPOH_.GetHashCode();
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
		aLDKLKHLGGP_.WriteTo(ref output, _repeated_aLDKLKHLGGP_codec);
		jNGHGLMBPOH_.WriteTo(ref output, _repeated_jNGHGLMBPOH_codec);
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
		num += aLDKLKHLGGP_.CalculateSize(_repeated_aLDKLKHLGGP_codec);
		num += jNGHGLMBPOH_.CalculateSize(_repeated_jNGHGLMBPOH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MultipleDropInfoNotify other)
	{
		if (other != null)
		{
			dFEOOEHFAAC_.Add(other.dFEOOEHFAAC_);
			aLDKLKHLGGP_.Add(other.aLDKLKHLGGP_);
			jNGHGLMBPOH_.Add(other.jNGHGLMBPOH_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				dFEOOEHFAAC_.AddEntriesFrom(ref input, _repeated_dFEOOEHFAAC_codec);
				break;
			case 42u:
				aLDKLKHLGGP_.AddEntriesFrom(ref input, _repeated_aLDKLKHLGGP_codec);
				break;
			case 114u:
				jNGHGLMBPOH_.AddEntriesFrom(ref input, _repeated_jNGHGLMBPOH_codec);
				break;
			}
		}
	}
}
