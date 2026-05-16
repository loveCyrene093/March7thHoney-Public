using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HOPKIOKGEBP : IMessage<HOPKIOKGEBP>, IMessage, IEquatable<HOPKIOKGEBP>, IDeepCloneable<HOPKIOKGEBP>, IBufferMessage
{
	private static readonly MessageParser<HOPKIOKGEBP> _parser = new MessageParser<HOPKIOKGEBP>(() => new HOPKIOKGEBP());

	private UnknownFieldSet _unknownFields;

	public const int JKPADPHCOJJFieldNumber = 1;

	private static readonly FieldCodec<KMCOCFNCDEK> _repeated_jKPADPHCOJJ_codec = FieldCodec.ForMessage(10u, KMCOCFNCDEK.Parser);

	private readonly RepeatedField<KMCOCFNCDEK> jKPADPHCOJJ_ = new RepeatedField<KMCOCFNCDEK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HOPKIOKGEBP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HOPKIOKGEBPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KMCOCFNCDEK> JKPADPHCOJJ => jKPADPHCOJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOPKIOKGEBP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOPKIOKGEBP(HOPKIOKGEBP other)
		: this()
	{
		jKPADPHCOJJ_ = other.jKPADPHCOJJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOPKIOKGEBP Clone()
	{
		return new HOPKIOKGEBP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HOPKIOKGEBP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HOPKIOKGEBP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jKPADPHCOJJ_.Equals(other.jKPADPHCOJJ_))
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
		num ^= jKPADPHCOJJ_.GetHashCode();
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
		jKPADPHCOJJ_.WriteTo(ref output, _repeated_jKPADPHCOJJ_codec);
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
		num += jKPADPHCOJJ_.CalculateSize(_repeated_jKPADPHCOJJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HOPKIOKGEBP other)
	{
		if (other != null)
		{
			jKPADPHCOJJ_.Add(other.jKPADPHCOJJ_);
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
				jKPADPHCOJJ_.AddEntriesFrom(ref input, _repeated_jKPADPHCOJJ_codec);
			}
		}
	}
}
