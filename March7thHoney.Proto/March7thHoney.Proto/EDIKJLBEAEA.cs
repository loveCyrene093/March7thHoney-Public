using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EDIKJLBEAEA : IMessage<EDIKJLBEAEA>, IMessage, IEquatable<EDIKJLBEAEA>, IDeepCloneable<EDIKJLBEAEA>, IBufferMessage
{
	private static readonly MessageParser<EDIKJLBEAEA> _parser = new MessageParser<EDIKJLBEAEA>(() => new EDIKJLBEAEA());

	private UnknownFieldSet _unknownFields;

	public const int PHPOLHLJGFMFieldNumber = 9;

	private static readonly FieldCodec<DOIJNCLJGKO> _repeated_pHPOLHLJGFM_codec = FieldCodec.ForMessage(74u, DOIJNCLJGKO.Parser);

	private readonly RepeatedField<DOIJNCLJGKO> pHPOLHLJGFM_ = new RepeatedField<DOIJNCLJGKO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EDIKJLBEAEA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EDIKJLBEAEAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOIJNCLJGKO> PHPOLHLJGFM => pHPOLHLJGFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDIKJLBEAEA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDIKJLBEAEA(EDIKJLBEAEA other)
		: this()
	{
		pHPOLHLJGFM_ = other.pHPOLHLJGFM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDIKJLBEAEA Clone()
	{
		return new EDIKJLBEAEA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EDIKJLBEAEA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EDIKJLBEAEA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pHPOLHLJGFM_.Equals(other.pHPOLHLJGFM_))
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
		num ^= pHPOLHLJGFM_.GetHashCode();
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
		pHPOLHLJGFM_.WriteTo(ref output, _repeated_pHPOLHLJGFM_codec);
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
		num += pHPOLHLJGFM_.CalculateSize(_repeated_pHPOLHLJGFM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EDIKJLBEAEA other)
	{
		if (other != null)
		{
			pHPOLHLJGFM_.Add(other.pHPOLHLJGFM_);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pHPOLHLJGFM_.AddEntriesFrom(ref input, _repeated_pHPOLHLJGFM_codec);
			}
		}
	}
}
