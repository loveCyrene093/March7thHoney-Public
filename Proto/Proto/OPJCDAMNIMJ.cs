using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPJCDAMNIMJ : IMessage<OPJCDAMNIMJ>, IMessage, IEquatable<OPJCDAMNIMJ>, IDeepCloneable<OPJCDAMNIMJ>, IBufferMessage
{
	private static readonly MessageParser<OPJCDAMNIMJ> _parser = new MessageParser<OPJCDAMNIMJ>(() => new OPJCDAMNIMJ());

	private UnknownFieldSet _unknownFields;

	public const int PAPGFHBDFKPFieldNumber = 11;

	private static readonly FieldCodec<EDKFJKKCIID> _repeated_pAPGFHBDFKP_codec = FieldCodec.ForMessage(90u, EDKFJKKCIID.Parser);

	private readonly RepeatedField<EDKFJKKCIID> pAPGFHBDFKP_ = new RepeatedField<EDKFJKKCIID>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPJCDAMNIMJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPJCDAMNIMJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EDKFJKKCIID> PAPGFHBDFKP => pAPGFHBDFKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPJCDAMNIMJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPJCDAMNIMJ(OPJCDAMNIMJ other)
		: this()
	{
		pAPGFHBDFKP_ = other.pAPGFHBDFKP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPJCDAMNIMJ Clone()
	{
		return new OPJCDAMNIMJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPJCDAMNIMJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPJCDAMNIMJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pAPGFHBDFKP_.Equals(other.pAPGFHBDFKP_))
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
		num ^= pAPGFHBDFKP_.GetHashCode();
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
		pAPGFHBDFKP_.WriteTo(ref output, _repeated_pAPGFHBDFKP_codec);
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
		num += pAPGFHBDFKP_.CalculateSize(_repeated_pAPGFHBDFKP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPJCDAMNIMJ other)
	{
		if (other != null)
		{
			pAPGFHBDFKP_.Add(other.pAPGFHBDFKP_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pAPGFHBDFKP_.AddEntriesFrom(ref input, _repeated_pAPGFHBDFKP_codec);
			}
		}
	}
}
