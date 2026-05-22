using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NNHPDNACICF : IMessage<NNHPDNACICF>, IMessage, IEquatable<NNHPDNACICF>, IDeepCloneable<NNHPDNACICF>, IBufferMessage
{
	private static readonly MessageParser<NNHPDNACICF> _parser = new MessageParser<NNHPDNACICF>(() => new NNHPDNACICF());

	private UnknownFieldSet _unknownFields;

	public const int AICHBBIODJCFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_aICHBBIODJC_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> aICHBBIODJC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NNHPDNACICF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NNHPDNACICFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AICHBBIODJC => aICHBBIODJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHPDNACICF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHPDNACICF(NNHPDNACICF other)
		: this()
	{
		aICHBBIODJC_ = other.aICHBBIODJC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHPDNACICF Clone()
	{
		return new NNHPDNACICF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NNHPDNACICF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NNHPDNACICF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aICHBBIODJC_.Equals(other.aICHBBIODJC_))
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
		num ^= aICHBBIODJC_.GetHashCode();
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
		aICHBBIODJC_.WriteTo(ref output, _repeated_aICHBBIODJC_codec);
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
		num += aICHBBIODJC_.CalculateSize(_repeated_aICHBBIODJC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NNHPDNACICF other)
	{
		if (other != null)
		{
			aICHBBIODJC_.Add(other.aICHBBIODJC_);
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
			if (num != 64 && num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aICHBBIODJC_.AddEntriesFrom(ref input, _repeated_aICHBBIODJC_codec);
			}
		}
	}
}
