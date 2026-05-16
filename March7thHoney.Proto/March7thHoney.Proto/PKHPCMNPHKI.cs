using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKHPCMNPHKI : IMessage<PKHPCMNPHKI>, IMessage, IEquatable<PKHPCMNPHKI>, IDeepCloneable<PKHPCMNPHKI>, IBufferMessage
{
	private static readonly MessageParser<PKHPCMNPHKI> _parser = new MessageParser<PKHPCMNPHKI>(() => new PKHPCMNPHKI());

	private UnknownFieldSet _unknownFields;

	public const int IAIOHLPJIAAFieldNumber = 1;

	private static readonly FieldCodec<NDCJAAOLEBA> _repeated_iAIOHLPJIAA_codec = FieldCodec.ForMessage(10u, NDCJAAOLEBA.Parser);

	private readonly RepeatedField<NDCJAAOLEBA> iAIOHLPJIAA_ = new RepeatedField<NDCJAAOLEBA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKHPCMNPHKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKHPCMNPHKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NDCJAAOLEBA> IAIOHLPJIAA => iAIOHLPJIAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKHPCMNPHKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKHPCMNPHKI(PKHPCMNPHKI other)
		: this()
	{
		iAIOHLPJIAA_ = other.iAIOHLPJIAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKHPCMNPHKI Clone()
	{
		return new PKHPCMNPHKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKHPCMNPHKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKHPCMNPHKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iAIOHLPJIAA_.Equals(other.iAIOHLPJIAA_))
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
		num ^= iAIOHLPJIAA_.GetHashCode();
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
		iAIOHLPJIAA_.WriteTo(ref output, _repeated_iAIOHLPJIAA_codec);
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
		num += iAIOHLPJIAA_.CalculateSize(_repeated_iAIOHLPJIAA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKHPCMNPHKI other)
	{
		if (other != null)
		{
			iAIOHLPJIAA_.Add(other.iAIOHLPJIAA_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iAIOHLPJIAA_.AddEntriesFrom(ref input, _repeated_iAIOHLPJIAA_codec);
			}
		}
	}
}
