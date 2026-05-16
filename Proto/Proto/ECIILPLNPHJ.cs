using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ECIILPLNPHJ : IMessage<ECIILPLNPHJ>, IMessage, IEquatable<ECIILPLNPHJ>, IDeepCloneable<ECIILPLNPHJ>, IBufferMessage
{
	private static readonly MessageParser<ECIILPLNPHJ> _parser = new MessageParser<ECIILPLNPHJ>(() => new ECIILPLNPHJ());

	private UnknownFieldSet _unknownFields;

	public const int HOPLDJJMGLMFieldNumber = 12;

	private static readonly FieldCodec<ADIPAKCFMOF> _repeated_hOPLDJJMGLM_codec = FieldCodec.ForMessage(98u, ADIPAKCFMOF.Parser);

	private readonly RepeatedField<ADIPAKCFMOF> hOPLDJJMGLM_ = new RepeatedField<ADIPAKCFMOF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ECIILPLNPHJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ECIILPLNPHJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADIPAKCFMOF> HOPLDJJMGLM => hOPLDJJMGLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECIILPLNPHJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECIILPLNPHJ(ECIILPLNPHJ other)
		: this()
	{
		hOPLDJJMGLM_ = other.hOPLDJJMGLM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECIILPLNPHJ Clone()
	{
		return new ECIILPLNPHJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ECIILPLNPHJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ECIILPLNPHJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hOPLDJJMGLM_.Equals(other.hOPLDJJMGLM_))
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
		num ^= hOPLDJJMGLM_.GetHashCode();
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
		hOPLDJJMGLM_.WriteTo(ref output, _repeated_hOPLDJJMGLM_codec);
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
		num += hOPLDJJMGLM_.CalculateSize(_repeated_hOPLDJJMGLM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ECIILPLNPHJ other)
	{
		if (other != null)
		{
			hOPLDJJMGLM_.Add(other.hOPLDJJMGLM_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hOPLDJJMGLM_.AddEntriesFrom(ref input, _repeated_hOPLDJJMGLM_codec);
			}
		}
	}
}
