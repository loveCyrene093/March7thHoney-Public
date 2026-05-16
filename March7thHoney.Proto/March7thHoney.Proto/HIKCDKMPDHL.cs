using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HIKCDKMPDHL : IMessage<HIKCDKMPDHL>, IMessage, IEquatable<HIKCDKMPDHL>, IDeepCloneable<HIKCDKMPDHL>, IBufferMessage
{
	private static readonly MessageParser<HIKCDKMPDHL> _parser = new MessageParser<HIKCDKMPDHL>(() => new HIKCDKMPDHL());

	private UnknownFieldSet _unknownFields;

	public const int CDHKFDPLLGDFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_cDHKFDPLLGD_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> cDHKFDPLLGD_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HIKCDKMPDHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HIKCDKMPDHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CDHKFDPLLGD => cDHKFDPLLGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIKCDKMPDHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIKCDKMPDHL(HIKCDKMPDHL other)
		: this()
	{
		cDHKFDPLLGD_ = other.cDHKFDPLLGD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIKCDKMPDHL Clone()
	{
		return new HIKCDKMPDHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HIKCDKMPDHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HIKCDKMPDHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cDHKFDPLLGD_.Equals(other.cDHKFDPLLGD_))
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
		num ^= cDHKFDPLLGD_.GetHashCode();
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
		cDHKFDPLLGD_.WriteTo(ref output, _repeated_cDHKFDPLLGD_codec);
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
		num += cDHKFDPLLGD_.CalculateSize(_repeated_cDHKFDPLLGD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HIKCDKMPDHL other)
	{
		if (other != null)
		{
			cDHKFDPLLGD_.Add(other.cDHKFDPLLGD_);
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
				cDHKFDPLLGD_.AddEntriesFrom(ref input, _repeated_cDHKFDPLLGD_codec);
			}
		}
	}
}
