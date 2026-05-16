using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BADCGBPEANI : IMessage<BADCGBPEANI>, IMessage, IEquatable<BADCGBPEANI>, IDeepCloneable<BADCGBPEANI>, IBufferMessage
{
	private static readonly MessageParser<BADCGBPEANI> _parser = new MessageParser<BADCGBPEANI>(() => new BADCGBPEANI());

	private UnknownFieldSet _unknownFields;

	public const int JNOAKECCIILFieldNumber = 6;

	private static readonly FieldCodec<NEILIAPHAMN> _repeated_jNOAKECCIIL_codec = FieldCodec.ForMessage(50u, NEILIAPHAMN.Parser);

	private readonly RepeatedField<NEILIAPHAMN> jNOAKECCIIL_ = new RepeatedField<NEILIAPHAMN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BADCGBPEANI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BADCGBPEANIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NEILIAPHAMN> JNOAKECCIIL => jNOAKECCIIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BADCGBPEANI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BADCGBPEANI(BADCGBPEANI other)
		: this()
	{
		jNOAKECCIIL_ = other.jNOAKECCIIL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BADCGBPEANI Clone()
	{
		return new BADCGBPEANI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BADCGBPEANI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BADCGBPEANI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jNOAKECCIIL_.Equals(other.jNOAKECCIIL_))
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
		num ^= jNOAKECCIIL_.GetHashCode();
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
		jNOAKECCIIL_.WriteTo(ref output, _repeated_jNOAKECCIIL_codec);
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
		num += jNOAKECCIIL_.CalculateSize(_repeated_jNOAKECCIIL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BADCGBPEANI other)
	{
		if (other != null)
		{
			jNOAKECCIIL_.Add(other.jNOAKECCIIL_);
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
				jNOAKECCIIL_.AddEntriesFrom(ref input, _repeated_jNOAKECCIIL_codec);
			}
		}
	}
}
