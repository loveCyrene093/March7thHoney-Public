using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KBNIJFEMBPJ : IMessage<KBNIJFEMBPJ>, IMessage, IEquatable<KBNIJFEMBPJ>, IDeepCloneable<KBNIJFEMBPJ>, IBufferMessage
{
	private static readonly MessageParser<KBNIJFEMBPJ> _parser = new MessageParser<KBNIJFEMBPJ>(() => new KBNIJFEMBPJ());

	private UnknownFieldSet _unknownFields;

	public const int IMKOJKJAHMMFieldNumber = 5;

	private static readonly FieldCodec<DKBJKODADGM> _repeated_iMKOJKJAHMM_codec = FieldCodec.ForMessage(42u, DKBJKODADGM.Parser);

	private readonly RepeatedField<DKBJKODADGM> iMKOJKJAHMM_ = new RepeatedField<DKBJKODADGM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KBNIJFEMBPJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KBNIJFEMBPJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DKBJKODADGM> IMKOJKJAHMM => iMKOJKJAHMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBNIJFEMBPJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBNIJFEMBPJ(KBNIJFEMBPJ other)
		: this()
	{
		iMKOJKJAHMM_ = other.iMKOJKJAHMM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBNIJFEMBPJ Clone()
	{
		return new KBNIJFEMBPJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KBNIJFEMBPJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KBNIJFEMBPJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iMKOJKJAHMM_.Equals(other.iMKOJKJAHMM_))
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
		num ^= iMKOJKJAHMM_.GetHashCode();
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
		iMKOJKJAHMM_.WriteTo(ref output, _repeated_iMKOJKJAHMM_codec);
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
		num += iMKOJKJAHMM_.CalculateSize(_repeated_iMKOJKJAHMM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KBNIJFEMBPJ other)
	{
		if (other != null)
		{
			iMKOJKJAHMM_.Add(other.iMKOJKJAHMM_);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iMKOJKJAHMM_.AddEntriesFrom(ref input, _repeated_iMKOJKJAHMM_codec);
			}
		}
	}
}
