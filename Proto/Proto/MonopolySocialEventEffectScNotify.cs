using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolySocialEventEffectScNotify : IMessage<MonopolySocialEventEffectScNotify>, IMessage, IEquatable<MonopolySocialEventEffectScNotify>, IDeepCloneable<MonopolySocialEventEffectScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolySocialEventEffectScNotify> _parser = new MessageParser<MonopolySocialEventEffectScNotify>(() => new MonopolySocialEventEffectScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HMEODJMENEGFieldNumber = 15;

	private static readonly FieldCodec<FKGGCHGFLAD> _repeated_hMEODJMENEG_codec = FieldCodec.ForMessage(122u, FKGGCHGFLAD.Parser);

	private readonly RepeatedField<FKGGCHGFLAD> hMEODJMENEG_ = new RepeatedField<FKGGCHGFLAD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolySocialEventEffectScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolySocialEventEffectScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FKGGCHGFLAD> HMEODJMENEG => hMEODJMENEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolySocialEventEffectScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolySocialEventEffectScNotify(MonopolySocialEventEffectScNotify other)
		: this()
	{
		hMEODJMENEG_ = other.hMEODJMENEG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolySocialEventEffectScNotify Clone()
	{
		return new MonopolySocialEventEffectScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolySocialEventEffectScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolySocialEventEffectScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hMEODJMENEG_.Equals(other.hMEODJMENEG_))
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
		num ^= hMEODJMENEG_.GetHashCode();
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
		hMEODJMENEG_.WriteTo(ref output, _repeated_hMEODJMENEG_codec);
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
		num += hMEODJMENEG_.CalculateSize(_repeated_hMEODJMENEG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolySocialEventEffectScNotify other)
	{
		if (other != null)
		{
			hMEODJMENEG_.Add(other.hMEODJMENEG_);
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
				hMEODJMENEG_.AddEntriesFrom(ref input, _repeated_hMEODJMENEG_codec);
			}
		}
	}
}
