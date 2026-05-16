using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GOKDLLADELB : IMessage<GOKDLLADELB>, IMessage, IEquatable<GOKDLLADELB>, IDeepCloneable<GOKDLLADELB>, IBufferMessage
{
	private static readonly MessageParser<GOKDLLADELB> _parser = new MessageParser<GOKDLLADELB>(() => new GOKDLLADELB());

	private UnknownFieldSet _unknownFields;

	public const int DJHDDOFHMCFFieldNumber = 5;

	private static readonly FieldCodec<RotaterData> _repeated_dJHDDOFHMCF_codec = FieldCodec.ForMessage(42u, RotaterData.Parser);

	private readonly RepeatedField<RotaterData> dJHDDOFHMCF_ = new RepeatedField<RotaterData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GOKDLLADELB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GOKDLLADELBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RotaterData> DJHDDOFHMCF => dJHDDOFHMCF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOKDLLADELB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOKDLLADELB(GOKDLLADELB other)
		: this()
	{
		dJHDDOFHMCF_ = other.dJHDDOFHMCF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOKDLLADELB Clone()
	{
		return new GOKDLLADELB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GOKDLLADELB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GOKDLLADELB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dJHDDOFHMCF_.Equals(other.dJHDDOFHMCF_))
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
		num ^= dJHDDOFHMCF_.GetHashCode();
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
		dJHDDOFHMCF_.WriteTo(ref output, _repeated_dJHDDOFHMCF_codec);
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
		num += dJHDDOFHMCF_.CalculateSize(_repeated_dJHDDOFHMCF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GOKDLLADELB other)
	{
		if (other != null)
		{
			dJHDDOFHMCF_.Add(other.dJHDDOFHMCF_);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dJHDDOFHMCF_.AddEntriesFrom(ref input, _repeated_dJHDDOFHMCF_codec);
			}
		}
	}
}
