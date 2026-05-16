using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MAGPKAPHFMJ : IMessage<MAGPKAPHFMJ>, IMessage, IEquatable<MAGPKAPHFMJ>, IDeepCloneable<MAGPKAPHFMJ>, IBufferMessage
{
	private static readonly MessageParser<MAGPKAPHFMJ> _parser = new MessageParser<MAGPKAPHFMJ>(() => new MAGPKAPHFMJ());

	private UnknownFieldSet _unknownFields;

	public const int JDJCJCABFMLFieldNumber = 8;

	private static readonly FieldCodec<CKFHOLKJAGC> _repeated_jDJCJCABFML_codec = FieldCodec.ForMessage(66u, CKFHOLKJAGC.Parser);

	private readonly RepeatedField<CKFHOLKJAGC> jDJCJCABFML_ = new RepeatedField<CKFHOLKJAGC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MAGPKAPHFMJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MAGPKAPHFMJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKFHOLKJAGC> JDJCJCABFML => jDJCJCABFML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGPKAPHFMJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGPKAPHFMJ(MAGPKAPHFMJ other)
		: this()
	{
		jDJCJCABFML_ = other.jDJCJCABFML_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGPKAPHFMJ Clone()
	{
		return new MAGPKAPHFMJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MAGPKAPHFMJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MAGPKAPHFMJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jDJCJCABFML_.Equals(other.jDJCJCABFML_))
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
		num ^= jDJCJCABFML_.GetHashCode();
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
		jDJCJCABFML_.WriteTo(ref output, _repeated_jDJCJCABFML_codec);
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
		num += jDJCJCABFML_.CalculateSize(_repeated_jDJCJCABFML_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MAGPKAPHFMJ other)
	{
		if (other != null)
		{
			jDJCJCABFML_.Add(other.jDJCJCABFML_);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jDJCJCABFML_.AddEntriesFrom(ref input, _repeated_jDJCJCABFML_codec);
			}
		}
	}
}
