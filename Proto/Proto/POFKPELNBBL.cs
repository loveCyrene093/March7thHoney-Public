using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class POFKPELNBBL : IMessage<POFKPELNBBL>, IMessage, IEquatable<POFKPELNBBL>, IDeepCloneable<POFKPELNBBL>, IBufferMessage
{
	private static readonly MessageParser<POFKPELNBBL> _parser = new MessageParser<POFKPELNBBL>(() => new POFKPELNBBL());

	private UnknownFieldSet _unknownFields;

	public const int ABIHHACBPPFFieldNumber = 15;

	private static readonly FieldCodec<JELDAKKHANC> _repeated_aBIHHACBPPF_codec = FieldCodec.ForMessage(122u, JELDAKKHANC.Parser);

	private readonly RepeatedField<JELDAKKHANC> aBIHHACBPPF_ = new RepeatedField<JELDAKKHANC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<POFKPELNBBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => POFKPELNBBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JELDAKKHANC> ABIHHACBPPF => aBIHHACBPPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POFKPELNBBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POFKPELNBBL(POFKPELNBBL other)
		: this()
	{
		aBIHHACBPPF_ = other.aBIHHACBPPF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POFKPELNBBL Clone()
	{
		return new POFKPELNBBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as POFKPELNBBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(POFKPELNBBL other)
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
	public void MergeFrom(POFKPELNBBL other)
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
			if (num != 122)
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
