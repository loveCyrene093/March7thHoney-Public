using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJOLPAEPBDN : IMessage<OJOLPAEPBDN>, IMessage, IEquatable<OJOLPAEPBDN>, IDeepCloneable<OJOLPAEPBDN>, IBufferMessage
{
	private static readonly MessageParser<OJOLPAEPBDN> _parser = new MessageParser<OJOLPAEPBDN>(() => new OJOLPAEPBDN());

	private UnknownFieldSet _unknownFields;

	public const int NMHIAFGCNBNFieldNumber = 7;

	private static readonly FieldCodec<OBCJLDDEBHL> _repeated_nMHIAFGCNBN_codec = FieldCodec.ForMessage(58u, OBCJLDDEBHL.Parser);

	private readonly RepeatedField<OBCJLDDEBHL> nMHIAFGCNBN_ = new RepeatedField<OBCJLDDEBHL>();

	public const int JBLINAEKGLJFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_jBLINAEKGLJ_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> jBLINAEKGLJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJOLPAEPBDN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJOLPAEPBDNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBCJLDDEBHL> NMHIAFGCNBN => nMHIAFGCNBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JBLINAEKGLJ => jBLINAEKGLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJOLPAEPBDN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJOLPAEPBDN(OJOLPAEPBDN other)
		: this()
	{
		nMHIAFGCNBN_ = other.nMHIAFGCNBN_.Clone();
		jBLINAEKGLJ_ = other.jBLINAEKGLJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJOLPAEPBDN Clone()
	{
		return new OJOLPAEPBDN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJOLPAEPBDN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJOLPAEPBDN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nMHIAFGCNBN_.Equals(other.nMHIAFGCNBN_))
		{
			return false;
		}
		if (!jBLINAEKGLJ_.Equals(other.jBLINAEKGLJ_))
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
		num ^= nMHIAFGCNBN_.GetHashCode();
		num ^= jBLINAEKGLJ_.GetHashCode();
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
		nMHIAFGCNBN_.WriteTo(ref output, _repeated_nMHIAFGCNBN_codec);
		jBLINAEKGLJ_.WriteTo(ref output, _repeated_jBLINAEKGLJ_codec);
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
		num += nMHIAFGCNBN_.CalculateSize(_repeated_nMHIAFGCNBN_codec);
		num += jBLINAEKGLJ_.CalculateSize(_repeated_jBLINAEKGLJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJOLPAEPBDN other)
	{
		if (other != null)
		{
			nMHIAFGCNBN_.Add(other.nMHIAFGCNBN_);
			jBLINAEKGLJ_.Add(other.jBLINAEKGLJ_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 58u:
				nMHIAFGCNBN_.AddEntriesFrom(ref input, _repeated_nMHIAFGCNBN_codec);
				break;
			case 104u:
			case 106u:
				jBLINAEKGLJ_.AddEntriesFrom(ref input, _repeated_jBLINAEKGLJ_codec);
				break;
			}
		}
	}
}
