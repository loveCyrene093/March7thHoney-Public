using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CBIJJNDGPIN : IMessage<CBIJJNDGPIN>, IMessage, IEquatable<CBIJJNDGPIN>, IDeepCloneable<CBIJJNDGPIN>, IBufferMessage
{
	private static readonly MessageParser<CBIJJNDGPIN> _parser = new MessageParser<CBIJJNDGPIN>(() => new CBIJJNDGPIN());

	private UnknownFieldSet _unknownFields;

	public const int HAKOLOCGEFBFieldNumber = 8;

	private static readonly FieldCodec<PGHPHPGIDMB> _repeated_hAKOLOCGEFB_codec = FieldCodec.ForMessage(66u, PGHPHPGIDMB.Parser);

	private readonly RepeatedField<PGHPHPGIDMB> hAKOLOCGEFB_ = new RepeatedField<PGHPHPGIDMB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CBIJJNDGPIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CBIJJNDGPINReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PGHPHPGIDMB> HAKOLOCGEFB => hAKOLOCGEFB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBIJJNDGPIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBIJJNDGPIN(CBIJJNDGPIN other)
		: this()
	{
		hAKOLOCGEFB_ = other.hAKOLOCGEFB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBIJJNDGPIN Clone()
	{
		return new CBIJJNDGPIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CBIJJNDGPIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CBIJJNDGPIN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hAKOLOCGEFB_.Equals(other.hAKOLOCGEFB_))
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
		num ^= hAKOLOCGEFB_.GetHashCode();
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
		hAKOLOCGEFB_.WriteTo(ref output, _repeated_hAKOLOCGEFB_codec);
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
		num += hAKOLOCGEFB_.CalculateSize(_repeated_hAKOLOCGEFB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CBIJJNDGPIN other)
	{
		if (other != null)
		{
			hAKOLOCGEFB_.Add(other.hAKOLOCGEFB_);
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
				hAKOLOCGEFB_.AddEntriesFrom(ref input, _repeated_hAKOLOCGEFB_codec);
			}
		}
	}
}
