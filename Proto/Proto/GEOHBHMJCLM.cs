using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GEOHBHMJCLM : IMessage<GEOHBHMJCLM>, IMessage, IEquatable<GEOHBHMJCLM>, IDeepCloneable<GEOHBHMJCLM>, IBufferMessage
{
	private static readonly MessageParser<GEOHBHMJCLM> _parser = new MessageParser<GEOHBHMJCLM>(() => new GEOHBHMJCLM());

	private UnknownFieldSet _unknownFields;

	public const int EPDCGJBJOJMFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_ePDCGJBJOJM_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> ePDCGJBJOJM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GEOHBHMJCLM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GEOHBHMJCLMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EPDCGJBJOJM => ePDCGJBJOJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOHBHMJCLM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOHBHMJCLM(GEOHBHMJCLM other)
		: this()
	{
		ePDCGJBJOJM_ = other.ePDCGJBJOJM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOHBHMJCLM Clone()
	{
		return new GEOHBHMJCLM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GEOHBHMJCLM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GEOHBHMJCLM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ePDCGJBJOJM_.Equals(other.ePDCGJBJOJM_))
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
		num ^= ePDCGJBJOJM_.GetHashCode();
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
		ePDCGJBJOJM_.WriteTo(ref output, _repeated_ePDCGJBJOJM_codec);
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
		num += ePDCGJBJOJM_.CalculateSize(_repeated_ePDCGJBJOJM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GEOHBHMJCLM other)
	{
		if (other != null)
		{
			ePDCGJBJOJM_.Add(other.ePDCGJBJOJM_);
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
			if (num != 120 && num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				ePDCGJBJOJM_.AddEntriesFrom(ref input, _repeated_ePDCGJBJOJM_codec);
			}
		}
	}
}
