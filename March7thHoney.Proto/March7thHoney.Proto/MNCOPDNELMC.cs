using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MNCOPDNELMC : IMessage<MNCOPDNELMC>, IMessage, IEquatable<MNCOPDNELMC>, IDeepCloneable<MNCOPDNELMC>, IBufferMessage
{
	private static readonly MessageParser<MNCOPDNELMC> _parser = new MessageParser<MNCOPDNELMC>(() => new MNCOPDNELMC());

	private UnknownFieldSet _unknownFields;

	public const int PHPOLHLJGFMFieldNumber = 3;

	private static readonly FieldCodec<DOIJNCLJGKO> _repeated_pHPOLHLJGFM_codec = FieldCodec.ForMessage(26u, DOIJNCLJGKO.Parser);

	private readonly RepeatedField<DOIJNCLJGKO> pHPOLHLJGFM_ = new RepeatedField<DOIJNCLJGKO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MNCOPDNELMC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MNCOPDNELMCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOIJNCLJGKO> PHPOLHLJGFM => pHPOLHLJGFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNCOPDNELMC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNCOPDNELMC(MNCOPDNELMC other)
		: this()
	{
		pHPOLHLJGFM_ = other.pHPOLHLJGFM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNCOPDNELMC Clone()
	{
		return new MNCOPDNELMC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MNCOPDNELMC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MNCOPDNELMC other)
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
	public void MergeFrom(MNCOPDNELMC other)
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
			if (num != 26)
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
