using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookUnlockInteractionCsReq : IMessage<TarotBookUnlockInteractionCsReq>, IMessage, IEquatable<TarotBookUnlockInteractionCsReq>, IDeepCloneable<TarotBookUnlockInteractionCsReq>, IBufferMessage
{
	private static readonly MessageParser<TarotBookUnlockInteractionCsReq> _parser = new MessageParser<TarotBookUnlockInteractionCsReq>(() => new TarotBookUnlockInteractionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LEPJFHMCBGJFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_lEPJFHMCBGJ_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> lEPJFHMCBGJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookUnlockInteractionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookUnlockInteractionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LEPJFHMCBGJ => lEPJFHMCBGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockInteractionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockInteractionCsReq(TarotBookUnlockInteractionCsReq other)
		: this()
	{
		lEPJFHMCBGJ_ = other.lEPJFHMCBGJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookUnlockInteractionCsReq Clone()
	{
		return new TarotBookUnlockInteractionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookUnlockInteractionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookUnlockInteractionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lEPJFHMCBGJ_.Equals(other.lEPJFHMCBGJ_))
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
		num ^= lEPJFHMCBGJ_.GetHashCode();
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
		lEPJFHMCBGJ_.WriteTo(ref output, _repeated_lEPJFHMCBGJ_codec);
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
		num += lEPJFHMCBGJ_.CalculateSize(_repeated_lEPJFHMCBGJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookUnlockInteractionCsReq other)
	{
		if (other != null)
		{
			lEPJFHMCBGJ_.Add(other.lEPJFHMCBGJ_);
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
				lEPJFHMCBGJ_.AddEntriesFrom(ref input, _repeated_lEPJFHMCBGJ_codec);
			}
		}
	}
}
