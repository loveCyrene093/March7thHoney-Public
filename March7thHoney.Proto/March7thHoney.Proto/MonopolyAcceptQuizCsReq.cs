using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyAcceptQuizCsReq : IMessage<MonopolyAcceptQuizCsReq>, IMessage, IEquatable<MonopolyAcceptQuizCsReq>, IDeepCloneable<MonopolyAcceptQuizCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyAcceptQuizCsReq> _parser = new MessageParser<MonopolyAcceptQuizCsReq>(() => new MonopolyAcceptQuizCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NNKHMIEJPOIFieldNumber = 15;

	private static readonly FieldCodec<NOKKAPGBNHP> _repeated_nNKHMIEJPOI_codec = FieldCodec.ForMessage(122u, NOKKAPGBNHP.Parser);

	private readonly RepeatedField<NOKKAPGBNHP> nNKHMIEJPOI_ = new RepeatedField<NOKKAPGBNHP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyAcceptQuizCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyAcceptQuizCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NOKKAPGBNHP> NNKHMIEJPOI => nNKHMIEJPOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyAcceptQuizCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyAcceptQuizCsReq(MonopolyAcceptQuizCsReq other)
		: this()
	{
		nNKHMIEJPOI_ = other.nNKHMIEJPOI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyAcceptQuizCsReq Clone()
	{
		return new MonopolyAcceptQuizCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyAcceptQuizCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyAcceptQuizCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nNKHMIEJPOI_.Equals(other.nNKHMIEJPOI_))
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
		num ^= nNKHMIEJPOI_.GetHashCode();
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
		nNKHMIEJPOI_.WriteTo(ref output, _repeated_nNKHMIEJPOI_codec);
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
		num += nNKHMIEJPOI_.CalculateSize(_repeated_nNKHMIEJPOI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyAcceptQuizCsReq other)
	{
		if (other != null)
		{
			nNKHMIEJPOI_.Add(other.nNKHMIEJPOI_);
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
				nNKHMIEJPOI_.AddEntriesFrom(ref input, _repeated_nNKHMIEJPOI_codec);
			}
		}
	}
}
