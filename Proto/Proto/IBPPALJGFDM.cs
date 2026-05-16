using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IBPPALJGFDM : IMessage<IBPPALJGFDM>, IMessage, IEquatable<IBPPALJGFDM>, IDeepCloneable<IBPPALJGFDM>, IBufferMessage
{
	private static readonly MessageParser<IBPPALJGFDM> _parser = new MessageParser<IBPPALJGFDM>(() => new IBPPALJGFDM());

	private UnknownFieldSet _unknownFields;

	public const int JOOJPMHEPJEFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_jOOJPMHEPJE_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> jOOJPMHEPJE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IBPPALJGFDM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IBPPALJGFDMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JOOJPMHEPJE => jOOJPMHEPJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBPPALJGFDM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBPPALJGFDM(IBPPALJGFDM other)
		: this()
	{
		jOOJPMHEPJE_ = other.jOOJPMHEPJE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBPPALJGFDM Clone()
	{
		return new IBPPALJGFDM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IBPPALJGFDM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IBPPALJGFDM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jOOJPMHEPJE_.Equals(other.jOOJPMHEPJE_))
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
		num ^= jOOJPMHEPJE_.GetHashCode();
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
		jOOJPMHEPJE_.WriteTo(ref output, _repeated_jOOJPMHEPJE_codec);
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
		num += jOOJPMHEPJE_.CalculateSize(_repeated_jOOJPMHEPJE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IBPPALJGFDM other)
	{
		if (other != null)
		{
			jOOJPMHEPJE_.Add(other.jOOJPMHEPJE_);
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
			if (num != 32 && num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jOOJPMHEPJE_.AddEntriesFrom(ref input, _repeated_jOOJPMHEPJE_codec);
			}
		}
	}
}
