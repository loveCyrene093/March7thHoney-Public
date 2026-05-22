using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HGOILCGHKNM : IMessage<HGOILCGHKNM>, IMessage, IEquatable<HGOILCGHKNM>, IDeepCloneable<HGOILCGHKNM>, IBufferMessage
{
	private static readonly MessageParser<HGOILCGHKNM> _parser = new MessageParser<HGOILCGHKNM>(() => new HGOILCGHKNM());

	private UnknownFieldSet _unknownFields;

	public const int HKLJFLHPJCEFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_hKLJFLHPJCE_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> hKLJFLHPJCE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HGOILCGHKNM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HGOILCGHKNMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HKLJFLHPJCE => hKLJFLHPJCE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HGOILCGHKNM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HGOILCGHKNM(HGOILCGHKNM other)
		: this()
	{
		hKLJFLHPJCE_ = other.hKLJFLHPJCE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HGOILCGHKNM Clone()
	{
		return new HGOILCGHKNM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HGOILCGHKNM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HGOILCGHKNM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hKLJFLHPJCE_.Equals(other.hKLJFLHPJCE_))
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
		num ^= hKLJFLHPJCE_.GetHashCode();
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
		hKLJFLHPJCE_.WriteTo(ref output, _repeated_hKLJFLHPJCE_codec);
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
		num += hKLJFLHPJCE_.CalculateSize(_repeated_hKLJFLHPJCE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HGOILCGHKNM other)
	{
		if (other != null)
		{
			hKLJFLHPJCE_.Add(other.hKLJFLHPJCE_);
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
			if (num != 40 && num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hKLJFLHPJCE_.AddEntriesFrom(ref input, _repeated_hKLJFLHPJCE_codec);
			}
		}
	}
}
