using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKJECENOHBI : IMessage<HKJECENOHBI>, IMessage, IEquatable<HKJECENOHBI>, IDeepCloneable<HKJECENOHBI>, IBufferMessage
{
	private static readonly MessageParser<HKJECENOHBI> _parser = new MessageParser<HKJECENOHBI>(() => new HKJECENOHBI());

	private UnknownFieldSet _unknownFields;

	public const int LBPHPPNPKDCFieldNumber = 2;

	private static readonly FieldCodec<NBKBCNGAINE> _repeated_lBPHPPNPKDC_codec = FieldCodec.ForMessage(18u, NBKBCNGAINE.Parser);

	private readonly RepeatedField<NBKBCNGAINE> lBPHPPNPKDC_ = new RepeatedField<NBKBCNGAINE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKJECENOHBI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKJECENOHBIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBKBCNGAINE> LBPHPPNPKDC => lBPHPPNPKDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJECENOHBI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJECENOHBI(HKJECENOHBI other)
		: this()
	{
		lBPHPPNPKDC_ = other.lBPHPPNPKDC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJECENOHBI Clone()
	{
		return new HKJECENOHBI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKJECENOHBI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKJECENOHBI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lBPHPPNPKDC_.Equals(other.lBPHPPNPKDC_))
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
		num ^= lBPHPPNPKDC_.GetHashCode();
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
		lBPHPPNPKDC_.WriteTo(ref output, _repeated_lBPHPPNPKDC_codec);
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
		num += lBPHPPNPKDC_.CalculateSize(_repeated_lBPHPPNPKDC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKJECENOHBI other)
	{
		if (other != null)
		{
			lBPHPPNPKDC_.Add(other.lBPHPPNPKDC_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lBPHPPNPKDC_.AddEntriesFrom(ref input, _repeated_lBPHPPNPKDC_codec);
			}
		}
	}
}
