using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CDAILEHLPEJ : IMessage<CDAILEHLPEJ>, IMessage, IEquatable<CDAILEHLPEJ>, IDeepCloneable<CDAILEHLPEJ>, IBufferMessage
{
	private static readonly MessageParser<CDAILEHLPEJ> _parser = new MessageParser<CDAILEHLPEJ>(() => new CDAILEHLPEJ());

	private UnknownFieldSet _unknownFields;

	public const int MNBNEKIHPPPFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_mNBNEKIHPPP_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> mNBNEKIHPPP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CDAILEHLPEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CDAILEHLPEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MNBNEKIHPPP => mNBNEKIHPPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDAILEHLPEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDAILEHLPEJ(CDAILEHLPEJ other)
		: this()
	{
		mNBNEKIHPPP_ = other.mNBNEKIHPPP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDAILEHLPEJ Clone()
	{
		return new CDAILEHLPEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CDAILEHLPEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CDAILEHLPEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mNBNEKIHPPP_.Equals(other.mNBNEKIHPPP_))
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
		num ^= mNBNEKIHPPP_.GetHashCode();
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
		mNBNEKIHPPP_.WriteTo(ref output, _repeated_mNBNEKIHPPP_codec);
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
		num += mNBNEKIHPPP_.CalculateSize(_repeated_mNBNEKIHPPP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CDAILEHLPEJ other)
	{
		if (other != null)
		{
			mNBNEKIHPPP_.Add(other.mNBNEKIHPPP_);
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
			if (num != 88 && num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mNBNEKIHPPP_.AddEntriesFrom(ref input, _repeated_mNBNEKIHPPP_codec);
			}
		}
	}
}
