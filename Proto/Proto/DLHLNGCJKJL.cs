using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLHLNGCJKJL : IMessage<DLHLNGCJKJL>, IMessage, IEquatable<DLHLNGCJKJL>, IDeepCloneable<DLHLNGCJKJL>, IBufferMessage
{
	private static readonly MessageParser<DLHLNGCJKJL> _parser = new MessageParser<DLHLNGCJKJL>(() => new DLHLNGCJKJL());

	private UnknownFieldSet _unknownFields;

	public const int BKBKLONBPOBFieldNumber = 6;

	private static readonly FieldCodec<OLJJJBCKLDK> _repeated_bKBKLONBPOB_codec = FieldCodec.ForMessage(50u, OLJJJBCKLDK.Parser);

	private readonly RepeatedField<OLJJJBCKLDK> bKBKLONBPOB_ = new RepeatedField<OLJJJBCKLDK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLHLNGCJKJL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLHLNGCJKJLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLJJJBCKLDK> BKBKLONBPOB => bKBKLONBPOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLHLNGCJKJL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLHLNGCJKJL(DLHLNGCJKJL other)
		: this()
	{
		bKBKLONBPOB_ = other.bKBKLONBPOB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLHLNGCJKJL Clone()
	{
		return new DLHLNGCJKJL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLHLNGCJKJL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLHLNGCJKJL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bKBKLONBPOB_.Equals(other.bKBKLONBPOB_))
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
		num ^= bKBKLONBPOB_.GetHashCode();
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
		bKBKLONBPOB_.WriteTo(ref output, _repeated_bKBKLONBPOB_codec);
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
		num += bKBKLONBPOB_.CalculateSize(_repeated_bKBKLONBPOB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLHLNGCJKJL other)
	{
		if (other != null)
		{
			bKBKLONBPOB_.Add(other.bKBKLONBPOB_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bKBKLONBPOB_.AddEntriesFrom(ref input, _repeated_bKBKLONBPOB_codec);
			}
		}
	}
}
