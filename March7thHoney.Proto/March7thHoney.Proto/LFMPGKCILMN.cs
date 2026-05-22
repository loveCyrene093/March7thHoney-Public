using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LFMPGKCILMN : IMessage<LFMPGKCILMN>, IMessage, IEquatable<LFMPGKCILMN>, IDeepCloneable<LFMPGKCILMN>, IBufferMessage
{
	private static readonly MessageParser<LFMPGKCILMN> _parser = new MessageParser<LFMPGKCILMN>(() => new LFMPGKCILMN());

	private UnknownFieldSet _unknownFields;

	public const int BEGMPEOFDLCFieldNumber = 1;

	private static readonly FieldCodec<MALLAGHCFFL> _repeated_bEGMPEOFDLC_codec = FieldCodec.ForMessage(10u, MALLAGHCFFL.Parser);

	private readonly RepeatedField<MALLAGHCFFL> bEGMPEOFDLC_ = new RepeatedField<MALLAGHCFFL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LFMPGKCILMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LFMPGKCILMNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MALLAGHCFFL> BEGMPEOFDLC => bEGMPEOFDLC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFMPGKCILMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFMPGKCILMN(LFMPGKCILMN other)
		: this()
	{
		bEGMPEOFDLC_ = other.bEGMPEOFDLC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFMPGKCILMN Clone()
	{
		return new LFMPGKCILMN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LFMPGKCILMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LFMPGKCILMN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bEGMPEOFDLC_.Equals(other.bEGMPEOFDLC_))
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
		num ^= bEGMPEOFDLC_.GetHashCode();
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
		bEGMPEOFDLC_.WriteTo(ref output, _repeated_bEGMPEOFDLC_codec);
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
		num += bEGMPEOFDLC_.CalculateSize(_repeated_bEGMPEOFDLC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LFMPGKCILMN other)
	{
		if (other != null)
		{
			bEGMPEOFDLC_.Add(other.bEGMPEOFDLC_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bEGMPEOFDLC_.AddEntriesFrom(ref input, _repeated_bEGMPEOFDLC_codec);
			}
		}
	}
}
