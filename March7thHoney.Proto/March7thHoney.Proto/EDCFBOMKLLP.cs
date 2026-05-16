using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EDCFBOMKLLP : IMessage<EDCFBOMKLLP>, IMessage, IEquatable<EDCFBOMKLLP>, IDeepCloneable<EDCFBOMKLLP>, IBufferMessage
{
	private static readonly MessageParser<EDCFBOMKLLP> _parser = new MessageParser<EDCFBOMKLLP>(() => new EDCFBOMKLLP());

	private UnknownFieldSet _unknownFields;

	public const int AEHNNNAIDALFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_aEHNNNAIDAL_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> aEHNNNAIDAL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EDCFBOMKLLP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EDCFBOMKLLPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AEHNNNAIDAL => aEHNNNAIDAL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDCFBOMKLLP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDCFBOMKLLP(EDCFBOMKLLP other)
		: this()
	{
		aEHNNNAIDAL_ = other.aEHNNNAIDAL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDCFBOMKLLP Clone()
	{
		return new EDCFBOMKLLP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EDCFBOMKLLP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EDCFBOMKLLP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aEHNNNAIDAL_.Equals(other.aEHNNNAIDAL_))
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
		num ^= aEHNNNAIDAL_.GetHashCode();
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
		aEHNNNAIDAL_.WriteTo(ref output, _repeated_aEHNNNAIDAL_codec);
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
		num += aEHNNNAIDAL_.CalculateSize(_repeated_aEHNNNAIDAL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EDCFBOMKLLP other)
	{
		if (other != null)
		{
			aEHNNNAIDAL_.Add(other.aEHNNNAIDAL_);
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
			if (num != 72 && num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aEHNNNAIDAL_.AddEntriesFrom(ref input, _repeated_aEHNNNAIDAL_codec);
			}
		}
	}
}
