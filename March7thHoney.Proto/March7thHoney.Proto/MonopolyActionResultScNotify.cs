using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyActionResultScNotify : IMessage<MonopolyActionResultScNotify>, IMessage, IEquatable<MonopolyActionResultScNotify>, IDeepCloneable<MonopolyActionResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyActionResultScNotify> _parser = new MessageParser<MonopolyActionResultScNotify>(() => new MonopolyActionResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MMAAHMECGOEFieldNumber = 5;

	private static readonly FieldCodec<MonopolyActionResult> _repeated_mMAAHMECGOE_codec = FieldCodec.ForMessage(42u, MonopolyActionResult.Parser);

	private readonly RepeatedField<MonopolyActionResult> mMAAHMECGOE_ = new RepeatedField<MonopolyActionResult>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyActionResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyActionResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonopolyActionResult> MMAAHMECGOE => mMAAHMECGOE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyActionResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyActionResultScNotify(MonopolyActionResultScNotify other)
		: this()
	{
		mMAAHMECGOE_ = other.mMAAHMECGOE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyActionResultScNotify Clone()
	{
		return new MonopolyActionResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyActionResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyActionResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mMAAHMECGOE_.Equals(other.mMAAHMECGOE_))
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
		num ^= mMAAHMECGOE_.GetHashCode();
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
		mMAAHMECGOE_.WriteTo(ref output, _repeated_mMAAHMECGOE_codec);
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
		num += mMAAHMECGOE_.CalculateSize(_repeated_mMAAHMECGOE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyActionResultScNotify other)
	{
		if (other != null)
		{
			mMAAHMECGOE_.Add(other.mMAAHMECGOE_);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mMAAHMECGOE_.AddEntriesFrom(ref input, _repeated_mMAAHMECGOE_codec);
			}
		}
	}
}
