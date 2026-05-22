using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AcceptMultipleExpeditionCsReq : IMessage<AcceptMultipleExpeditionCsReq>, IMessage, IEquatable<AcceptMultipleExpeditionCsReq>, IDeepCloneable<AcceptMultipleExpeditionCsReq>, IBufferMessage
{
	private static readonly MessageParser<AcceptMultipleExpeditionCsReq> _parser = new MessageParser<AcceptMultipleExpeditionCsReq>(() => new AcceptMultipleExpeditionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ExpeditionFieldNumber = 13;

	private static readonly FieldCodec<ExpeditionInfo> _repeated_expedition_codec = FieldCodec.ForMessage(106u, ExpeditionInfo.Parser);

	private readonly RepeatedField<ExpeditionInfo> expedition_ = new RepeatedField<ExpeditionInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AcceptMultipleExpeditionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AcceptMultipleExpeditionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ExpeditionInfo> Expedition => expedition_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcceptMultipleExpeditionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcceptMultipleExpeditionCsReq(AcceptMultipleExpeditionCsReq other)
		: this()
	{
		expedition_ = other.expedition_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcceptMultipleExpeditionCsReq Clone()
	{
		return new AcceptMultipleExpeditionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AcceptMultipleExpeditionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AcceptMultipleExpeditionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!expedition_.Equals(other.expedition_))
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
		num ^= expedition_.GetHashCode();
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
		expedition_.WriteTo(ref output, _repeated_expedition_codec);
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
		num += expedition_.CalculateSize(_repeated_expedition_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AcceptMultipleExpeditionCsReq other)
	{
		if (other != null)
		{
			expedition_.Add(other.expedition_);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				expedition_.AddEntriesFrom(ref input, _repeated_expedition_codec);
			}
		}
	}
}
