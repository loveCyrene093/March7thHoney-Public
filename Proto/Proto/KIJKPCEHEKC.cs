using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KIJKPCEHEKC : IMessage<KIJKPCEHEKC>, IMessage, IEquatable<KIJKPCEHEKC>, IDeepCloneable<KIJKPCEHEKC>, IBufferMessage
{
	private static readonly MessageParser<KIJKPCEHEKC> _parser = new MessageParser<KIJKPCEHEKC>(() => new KIJKPCEHEKC());

	private UnknownFieldSet _unknownFields;

	public const int ABIHHACBPPFFieldNumber = 13;

	private static readonly FieldCodec<JELDAKKHANC> _repeated_aBIHHACBPPF_codec = FieldCodec.ForMessage(106u, JELDAKKHANC.Parser);

	private readonly RepeatedField<JELDAKKHANC> aBIHHACBPPF_ = new RepeatedField<JELDAKKHANC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KIJKPCEHEKC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KIJKPCEHEKCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JELDAKKHANC> ABIHHACBPPF => aBIHHACBPPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIJKPCEHEKC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIJKPCEHEKC(KIJKPCEHEKC other)
		: this()
	{
		aBIHHACBPPF_ = other.aBIHHACBPPF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIJKPCEHEKC Clone()
	{
		return new KIJKPCEHEKC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KIJKPCEHEKC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KIJKPCEHEKC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aBIHHACBPPF_.Equals(other.aBIHHACBPPF_))
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
		num ^= aBIHHACBPPF_.GetHashCode();
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
		aBIHHACBPPF_.WriteTo(ref output, _repeated_aBIHHACBPPF_codec);
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
		num += aBIHHACBPPF_.CalculateSize(_repeated_aBIHHACBPPF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KIJKPCEHEKC other)
	{
		if (other != null)
		{
			aBIHHACBPPF_.Add(other.aBIHHACBPPF_);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aBIHHACBPPF_.AddEntriesFrom(ref input, _repeated_aBIHHACBPPF_codec);
			}
		}
	}
}
