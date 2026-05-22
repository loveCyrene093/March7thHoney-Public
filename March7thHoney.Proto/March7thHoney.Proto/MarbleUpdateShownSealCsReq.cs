using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarbleUpdateShownSealCsReq : IMessage<MarbleUpdateShownSealCsReq>, IMessage, IEquatable<MarbleUpdateShownSealCsReq>, IDeepCloneable<MarbleUpdateShownSealCsReq>, IBufferMessage
{
	private static readonly MessageParser<MarbleUpdateShownSealCsReq> _parser = new MessageParser<MarbleUpdateShownSealCsReq>(() => new MarbleUpdateShownSealCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LAINAEAMHJBFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_lAINAEAMHJB_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> lAINAEAMHJB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarbleUpdateShownSealCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarbleUpdateShownSealCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LAINAEAMHJB => lAINAEAMHJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleUpdateShownSealCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleUpdateShownSealCsReq(MarbleUpdateShownSealCsReq other)
		: this()
	{
		lAINAEAMHJB_ = other.lAINAEAMHJB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleUpdateShownSealCsReq Clone()
	{
		return new MarbleUpdateShownSealCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarbleUpdateShownSealCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarbleUpdateShownSealCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lAINAEAMHJB_.Equals(other.lAINAEAMHJB_))
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
		num ^= lAINAEAMHJB_.GetHashCode();
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
		lAINAEAMHJB_.WriteTo(ref output, _repeated_lAINAEAMHJB_codec);
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
		num += lAINAEAMHJB_.CalculateSize(_repeated_lAINAEAMHJB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarbleUpdateShownSealCsReq other)
	{
		if (other != null)
		{
			lAINAEAMHJB_.Add(other.lAINAEAMHJB_);
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
			if (num != 104 && num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lAINAEAMHJB_.AddEntriesFrom(ref input, _repeated_lAINAEAMHJB_codec);
			}
		}
	}
}
