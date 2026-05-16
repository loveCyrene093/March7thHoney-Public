using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MGLMEMPJELD : IMessage<MGLMEMPJELD>, IMessage, IEquatable<MGLMEMPJELD>, IDeepCloneable<MGLMEMPJELD>, IBufferMessage
{
	private static readonly MessageParser<MGLMEMPJELD> _parser = new MessageParser<MGLMEMPJELD>(() => new MGLMEMPJELD());

	private UnknownFieldSet _unknownFields;

	public const int DEKJHABPJDAFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dEKJHABPJDA_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dEKJHABPJDA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MGLMEMPJELD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MGLMEMPJELDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DEKJHABPJDA => dEKJHABPJDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGLMEMPJELD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGLMEMPJELD(MGLMEMPJELD other)
		: this()
	{
		dEKJHABPJDA_ = other.dEKJHABPJDA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGLMEMPJELD Clone()
	{
		return new MGLMEMPJELD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MGLMEMPJELD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MGLMEMPJELD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEKJHABPJDA_.Equals(other.dEKJHABPJDA_))
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
		num ^= dEKJHABPJDA_.GetHashCode();
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
		dEKJHABPJDA_.WriteTo(ref output, _repeated_dEKJHABPJDA_codec);
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
		num += dEKJHABPJDA_.CalculateSize(_repeated_dEKJHABPJDA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MGLMEMPJELD other)
	{
		if (other != null)
		{
			dEKJHABPJDA_.Add(other.dEKJHABPJDA_);
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
			if (num != 24 && num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dEKJHABPJDA_.AddEntriesFrom(ref input, _repeated_dEKJHABPJDA_codec);
			}
		}
	}
}
