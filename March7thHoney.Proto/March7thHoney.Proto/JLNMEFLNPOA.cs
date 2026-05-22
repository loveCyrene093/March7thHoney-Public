using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLNMEFLNPOA : IMessage<JLNMEFLNPOA>, IMessage, IEquatable<JLNMEFLNPOA>, IDeepCloneable<JLNMEFLNPOA>, IBufferMessage
{
	private static readonly MessageParser<JLNMEFLNPOA> _parser = new MessageParser<JLNMEFLNPOA>(() => new JLNMEFLNPOA());

	private UnknownFieldSet _unknownFields;

	public const int JEMEBLFANLMFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_jEMEBLFANLM_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> jEMEBLFANLM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLNMEFLNPOA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLNMEFLNPOAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JEMEBLFANLM => jEMEBLFANLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLNMEFLNPOA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLNMEFLNPOA(JLNMEFLNPOA other)
		: this()
	{
		jEMEBLFANLM_ = other.jEMEBLFANLM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLNMEFLNPOA Clone()
	{
		return new JLNMEFLNPOA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLNMEFLNPOA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLNMEFLNPOA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jEMEBLFANLM_.Equals(other.jEMEBLFANLM_))
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
		num ^= jEMEBLFANLM_.GetHashCode();
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
		jEMEBLFANLM_.WriteTo(ref output, _repeated_jEMEBLFANLM_codec);
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
		num += jEMEBLFANLM_.CalculateSize(_repeated_jEMEBLFANLM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLNMEFLNPOA other)
	{
		if (other != null)
		{
			jEMEBLFANLM_.Add(other.jEMEBLFANLM_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jEMEBLFANLM_.AddEntriesFrom(ref input, _repeated_jEMEBLFANLM_codec);
			}
		}
	}
}
