using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AAGGKGMEKKO : IMessage<AAGGKGMEKKO>, IMessage, IEquatable<AAGGKGMEKKO>, IDeepCloneable<AAGGKGMEKKO>, IBufferMessage
{
	private static readonly MessageParser<AAGGKGMEKKO> _parser = new MessageParser<AAGGKGMEKKO>(() => new AAGGKGMEKKO());

	private UnknownFieldSet _unknownFields;

	public const int APHJIAFODHJFieldNumber = 2;

	private static readonly FieldCodec<OBPMPPCFNLJ> _repeated_aPHJIAFODHJ_codec = FieldCodec.ForMessage(18u, OBPMPPCFNLJ.Parser);

	private readonly RepeatedField<OBPMPPCFNLJ> aPHJIAFODHJ_ = new RepeatedField<OBPMPPCFNLJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AAGGKGMEKKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AAGGKGMEKKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBPMPPCFNLJ> APHJIAFODHJ => aPHJIAFODHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAGGKGMEKKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAGGKGMEKKO(AAGGKGMEKKO other)
		: this()
	{
		aPHJIAFODHJ_ = other.aPHJIAFODHJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAGGKGMEKKO Clone()
	{
		return new AAGGKGMEKKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AAGGKGMEKKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AAGGKGMEKKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aPHJIAFODHJ_.Equals(other.aPHJIAFODHJ_))
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
		num ^= aPHJIAFODHJ_.GetHashCode();
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
		aPHJIAFODHJ_.WriteTo(ref output, _repeated_aPHJIAFODHJ_codec);
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
		num += aPHJIAFODHJ_.CalculateSize(_repeated_aPHJIAFODHJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AAGGKGMEKKO other)
	{
		if (other != null)
		{
			aPHJIAFODHJ_.Add(other.aPHJIAFODHJ_);
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
				aPHJIAFODHJ_.AddEntriesFrom(ref input, _repeated_aPHJIAFODHJ_codec);
			}
		}
	}
}
