using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IAMCAPPFDBH : IMessage<IAMCAPPFDBH>, IMessage, IEquatable<IAMCAPPFDBH>, IDeepCloneable<IAMCAPPFDBH>, IBufferMessage
{
	private static readonly MessageParser<IAMCAPPFDBH> _parser = new MessageParser<IAMCAPPFDBH>(() => new IAMCAPPFDBH());

	private UnknownFieldSet _unknownFields;

	public const int PIBHJCMEOEAFieldNumber = 12;

	private static readonly FieldCodec<EFBIMNFGMBM> _repeated_pIBHJCMEOEA_codec = FieldCodec.ForMessage(98u, EFBIMNFGMBM.Parser);

	private readonly RepeatedField<EFBIMNFGMBM> pIBHJCMEOEA_ = new RepeatedField<EFBIMNFGMBM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IAMCAPPFDBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IAMCAPPFDBHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EFBIMNFGMBM> PIBHJCMEOEA => pIBHJCMEOEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMCAPPFDBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMCAPPFDBH(IAMCAPPFDBH other)
		: this()
	{
		pIBHJCMEOEA_ = other.pIBHJCMEOEA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMCAPPFDBH Clone()
	{
		return new IAMCAPPFDBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IAMCAPPFDBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IAMCAPPFDBH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pIBHJCMEOEA_.Equals(other.pIBHJCMEOEA_))
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
		num ^= pIBHJCMEOEA_.GetHashCode();
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
		pIBHJCMEOEA_.WriteTo(ref output, _repeated_pIBHJCMEOEA_codec);
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
		num += pIBHJCMEOEA_.CalculateSize(_repeated_pIBHJCMEOEA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IAMCAPPFDBH other)
	{
		if (other != null)
		{
			pIBHJCMEOEA_.Add(other.pIBHJCMEOEA_);
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
				pIBHJCMEOEA_.AddEntriesFrom(ref input, _repeated_pIBHJCMEOEA_codec);
			}
		}
	}
}
