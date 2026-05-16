using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMultipleDropInfoScRsp : IMessage<GetMultipleDropInfoScRsp>, IMessage, IEquatable<GetMultipleDropInfoScRsp>, IDeepCloneable<GetMultipleDropInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMultipleDropInfoScRsp> _parser = new MessageParser<GetMultipleDropInfoScRsp>(() => new GetMultipleDropInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JNGHGLMBPOHFieldNumber = 2;

	private static readonly FieldCodec<AEOEFOILEBP> _repeated_jNGHGLMBPOH_codec = FieldCodec.ForMessage(18u, AEOEFOILEBP.Parser);

	private readonly RepeatedField<AEOEFOILEBP> jNGHGLMBPOH_ = new RepeatedField<AEOEFOILEBP>();

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int DFEOOEHFAACFieldNumber = 4;

	private static readonly FieldCodec<DMINLLDNNDL> _repeated_dFEOOEHFAAC_codec = FieldCodec.ForMessage(34u, DMINLLDNNDL.Parser);

	private readonly RepeatedField<DMINLLDNNDL> dFEOOEHFAAC_ = new RepeatedField<DMINLLDNNDL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMultipleDropInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMultipleDropInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AEOEFOILEBP> JNGHGLMBPOH => jNGHGLMBPOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DMINLLDNNDL> DFEOOEHFAAC => dFEOOEHFAAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMultipleDropInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMultipleDropInfoScRsp(GetMultipleDropInfoScRsp other)
		: this()
	{
		jNGHGLMBPOH_ = other.jNGHGLMBPOH_.Clone();
		retcode_ = other.retcode_;
		dFEOOEHFAAC_ = other.dFEOOEHFAAC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMultipleDropInfoScRsp Clone()
	{
		return new GetMultipleDropInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMultipleDropInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMultipleDropInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jNGHGLMBPOH_.Equals(other.jNGHGLMBPOH_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!dFEOOEHFAAC_.Equals(other.dFEOOEHFAAC_))
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
		num ^= jNGHGLMBPOH_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= dFEOOEHFAAC_.GetHashCode();
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
		jNGHGLMBPOH_.WriteTo(ref output, _repeated_jNGHGLMBPOH_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		dFEOOEHFAAC_.WriteTo(ref output, _repeated_dFEOOEHFAAC_codec);
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
		num += jNGHGLMBPOH_.CalculateSize(_repeated_jNGHGLMBPOH_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dFEOOEHFAAC_.CalculateSize(_repeated_dFEOOEHFAAC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMultipleDropInfoScRsp other)
	{
		if (other != null)
		{
			jNGHGLMBPOH_.Add(other.jNGHGLMBPOH_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			dFEOOEHFAAC_.Add(other.dFEOOEHFAAC_);
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
			case 18u:
				jNGHGLMBPOH_.AddEntriesFrom(ref input, _repeated_jNGHGLMBPOH_codec);
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 34u:
				dFEOOEHFAAC_.AddEntriesFrom(ref input, _repeated_dFEOOEHFAAC_codec);
				break;
			}
		}
	}
}
