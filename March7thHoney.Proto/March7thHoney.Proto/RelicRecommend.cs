using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicRecommend : IMessage<RelicRecommend>, IMessage, IEquatable<RelicRecommend>, IDeepCloneable<RelicRecommend>, IBufferMessage
{
	private static readonly MessageParser<RelicRecommend> _parser = new MessageParser<RelicRecommend>(() => new RelicRecommend());

	private UnknownFieldSet _unknownFields;

	public const int PEDFGEMEONKFieldNumber = 7;

	private static readonly FieldCodec<MNGIIJPMJBE> _repeated_pEDFGEMEONK_codec = FieldCodec.ForMessage(58u, MNGIIJPMJBE.Parser);

	private readonly RepeatedField<MNGIIJPMJBE> pEDFGEMEONK_ = new RepeatedField<MNGIIJPMJBE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicRecommend> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicRecommendReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MNGIIJPMJBE> PEDFGEMEONK => pEDFGEMEONK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicRecommend()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicRecommend(RelicRecommend other)
		: this()
	{
		pEDFGEMEONK_ = other.pEDFGEMEONK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicRecommend Clone()
	{
		return new RelicRecommend(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicRecommend);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicRecommend other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pEDFGEMEONK_.Equals(other.pEDFGEMEONK_))
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
		num ^= pEDFGEMEONK_.GetHashCode();
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
		pEDFGEMEONK_.WriteTo(ref output, _repeated_pEDFGEMEONK_codec);
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
		num += pEDFGEMEONK_.CalculateSize(_repeated_pEDFGEMEONK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicRecommend other)
	{
		if (other != null)
		{
			pEDFGEMEONK_.Add(other.pEDFGEMEONK_);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pEDFGEMEONK_.AddEntriesFrom(ref input, _repeated_pEDFGEMEONK_codec);
			}
		}
	}
}
