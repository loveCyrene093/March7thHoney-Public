using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FOIPOCNEPLN : IMessage<FOIPOCNEPLN>, IMessage, IEquatable<FOIPOCNEPLN>, IDeepCloneable<FOIPOCNEPLN>, IBufferMessage
{
	private static readonly MessageParser<FOIPOCNEPLN> _parser = new MessageParser<FOIPOCNEPLN>(() => new FOIPOCNEPLN());

	private UnknownFieldSet _unknownFields;

	public const int BMPPBKLLPLAFieldNumber = 12;

	private static readonly FieldCodec<BLOEDJGLOBL> _repeated_bMPPBKLLPLA_codec = FieldCodec.ForMessage(98u, BLOEDJGLOBL.Parser);

	private readonly RepeatedField<BLOEDJGLOBL> bMPPBKLLPLA_ = new RepeatedField<BLOEDJGLOBL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FOIPOCNEPLN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FOIPOCNEPLNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BLOEDJGLOBL> BMPPBKLLPLA => bMPPBKLLPLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOIPOCNEPLN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOIPOCNEPLN(FOIPOCNEPLN other)
		: this()
	{
		bMPPBKLLPLA_ = other.bMPPBKLLPLA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOIPOCNEPLN Clone()
	{
		return new FOIPOCNEPLN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FOIPOCNEPLN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FOIPOCNEPLN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bMPPBKLLPLA_.Equals(other.bMPPBKLLPLA_))
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
		num ^= bMPPBKLLPLA_.GetHashCode();
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
		bMPPBKLLPLA_.WriteTo(ref output, _repeated_bMPPBKLLPLA_codec);
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
		num += bMPPBKLLPLA_.CalculateSize(_repeated_bMPPBKLLPLA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FOIPOCNEPLN other)
	{
		if (other != null)
		{
			bMPPBKLLPLA_.Add(other.bMPPBKLLPLA_);
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
				bMPPBKLLPLA_.AddEntriesFrom(ref input, _repeated_bMPPBKLLPLA_codec);
			}
		}
	}
}
