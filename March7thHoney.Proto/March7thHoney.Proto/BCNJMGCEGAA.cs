using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCNJMGCEGAA : IMessage<BCNJMGCEGAA>, IMessage, IEquatable<BCNJMGCEGAA>, IDeepCloneable<BCNJMGCEGAA>, IBufferMessage
{
	private static readonly MessageParser<BCNJMGCEGAA> _parser = new MessageParser<BCNJMGCEGAA>(() => new BCNJMGCEGAA());

	private UnknownFieldSet _unknownFields;

	public const int FMIMEIEEOKBFieldNumber = 2;

	private static readonly FieldCodec<FINPEANNNKB> _repeated_fMIMEIEEOKB_codec = FieldCodec.ForMessage(18u, FINPEANNNKB.Parser);

	private readonly RepeatedField<FINPEANNNKB> fMIMEIEEOKB_ = new RepeatedField<FINPEANNNKB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCNJMGCEGAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCNJMGCEGAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FINPEANNNKB> FMIMEIEEOKB => fMIMEIEEOKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCNJMGCEGAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCNJMGCEGAA(BCNJMGCEGAA other)
		: this()
	{
		fMIMEIEEOKB_ = other.fMIMEIEEOKB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCNJMGCEGAA Clone()
	{
		return new BCNJMGCEGAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCNJMGCEGAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCNJMGCEGAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fMIMEIEEOKB_.Equals(other.fMIMEIEEOKB_))
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
		num ^= fMIMEIEEOKB_.GetHashCode();
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
		fMIMEIEEOKB_.WriteTo(ref output, _repeated_fMIMEIEEOKB_codec);
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
		num += fMIMEIEEOKB_.CalculateSize(_repeated_fMIMEIEEOKB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCNJMGCEGAA other)
	{
		if (other != null)
		{
			fMIMEIEEOKB_.Add(other.fMIMEIEEOKB_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fMIMEIEEOKB_.AddEntriesFrom(ref input, _repeated_fMIMEIEEOKB_codec);
			}
		}
	}
}
