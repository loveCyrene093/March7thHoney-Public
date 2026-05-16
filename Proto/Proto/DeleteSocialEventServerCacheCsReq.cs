using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DeleteSocialEventServerCacheCsReq : IMessage<DeleteSocialEventServerCacheCsReq>, IMessage, IEquatable<DeleteSocialEventServerCacheCsReq>, IDeepCloneable<DeleteSocialEventServerCacheCsReq>, IBufferMessage
{
	private static readonly MessageParser<DeleteSocialEventServerCacheCsReq> _parser = new MessageParser<DeleteSocialEventServerCacheCsReq>(() => new DeleteSocialEventServerCacheCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NHAHNGEPKMJFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_nHAHNGEPKMJ_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> nHAHNGEPKMJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DeleteSocialEventServerCacheCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DeleteSocialEventServerCacheCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NHAHNGEPKMJ => nHAHNGEPKMJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteSocialEventServerCacheCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteSocialEventServerCacheCsReq(DeleteSocialEventServerCacheCsReq other)
		: this()
	{
		nHAHNGEPKMJ_ = other.nHAHNGEPKMJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteSocialEventServerCacheCsReq Clone()
	{
		return new DeleteSocialEventServerCacheCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeleteSocialEventServerCacheCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DeleteSocialEventServerCacheCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nHAHNGEPKMJ_.Equals(other.nHAHNGEPKMJ_))
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
		num ^= nHAHNGEPKMJ_.GetHashCode();
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
		nHAHNGEPKMJ_.WriteTo(ref output, _repeated_nHAHNGEPKMJ_codec);
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
		num += nHAHNGEPKMJ_.CalculateSize(_repeated_nHAHNGEPKMJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DeleteSocialEventServerCacheCsReq other)
	{
		if (other != null)
		{
			nHAHNGEPKMJ_.Add(other.nHAHNGEPKMJ_);
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
				nHAHNGEPKMJ_.AddEntriesFrom(ref input, _repeated_nHAHNGEPKMJ_codec);
			}
		}
	}
}
