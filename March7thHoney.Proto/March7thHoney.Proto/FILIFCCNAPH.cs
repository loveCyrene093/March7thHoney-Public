using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FILIFCCNAPH : IMessage<FILIFCCNAPH>, IMessage, IEquatable<FILIFCCNAPH>, IDeepCloneable<FILIFCCNAPH>, IBufferMessage
{
	private static readonly MessageParser<FILIFCCNAPH> _parser = new MessageParser<FILIFCCNAPH>(() => new FILIFCCNAPH());

	private UnknownFieldSet _unknownFields;

	public const int AACDKGKECAHFieldNumber = 3;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_aACDKGKECAH_codec = FieldCodec.ForMessage(26u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> aACDKGKECAH_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FILIFCCNAPH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FILIFCCNAPHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> AACDKGKECAH => aACDKGKECAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILIFCCNAPH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILIFCCNAPH(FILIFCCNAPH other)
		: this()
	{
		aACDKGKECAH_ = other.aACDKGKECAH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FILIFCCNAPH Clone()
	{
		return new FILIFCCNAPH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FILIFCCNAPH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FILIFCCNAPH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aACDKGKECAH_.Equals(other.aACDKGKECAH_))
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
		num ^= aACDKGKECAH_.GetHashCode();
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
		aACDKGKECAH_.WriteTo(ref output, _repeated_aACDKGKECAH_codec);
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
		num += aACDKGKECAH_.CalculateSize(_repeated_aACDKGKECAH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FILIFCCNAPH other)
	{
		if (other != null)
		{
			aACDKGKECAH_.Add(other.aACDKGKECAH_);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aACDKGKECAH_.AddEntriesFrom(ref input, _repeated_aACDKGKECAH_codec);
			}
		}
	}
}
