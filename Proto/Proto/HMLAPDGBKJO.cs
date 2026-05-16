using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMLAPDGBKJO : IMessage<HMLAPDGBKJO>, IMessage, IEquatable<HMLAPDGBKJO>, IDeepCloneable<HMLAPDGBKJO>, IBufferMessage
{
	private static readonly MessageParser<HMLAPDGBKJO> _parser = new MessageParser<HMLAPDGBKJO>(() => new HMLAPDGBKJO());

	private UnknownFieldSet _unknownFields;

	public const int MPLHNFMFCPPFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_mPLHNFMFCPP_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> mPLHNFMFCPP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMLAPDGBKJO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMLAPDGBKJOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPLHNFMFCPP => mPLHNFMFCPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMLAPDGBKJO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMLAPDGBKJO(HMLAPDGBKJO other)
		: this()
	{
		mPLHNFMFCPP_ = other.mPLHNFMFCPP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMLAPDGBKJO Clone()
	{
		return new HMLAPDGBKJO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMLAPDGBKJO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMLAPDGBKJO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPLHNFMFCPP_.Equals(other.mPLHNFMFCPP_))
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
		num ^= mPLHNFMFCPP_.GetHashCode();
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
		mPLHNFMFCPP_.WriteTo(ref output, _repeated_mPLHNFMFCPP_codec);
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
		num += mPLHNFMFCPP_.CalculateSize(_repeated_mPLHNFMFCPP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMLAPDGBKJO other)
	{
		if (other != null)
		{
			mPLHNFMFCPP_.Add(other.mPLHNFMFCPP_);
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
			if (num != 96 && num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mPLHNFMFCPP_.AddEntriesFrom(ref input, _repeated_mPLHNFMFCPP_codec);
			}
		}
	}
}
