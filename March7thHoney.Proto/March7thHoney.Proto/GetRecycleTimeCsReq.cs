using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRecycleTimeCsReq : IMessage<GetRecycleTimeCsReq>, IMessage, IEquatable<GetRecycleTimeCsReq>, IDeepCloneable<GetRecycleTimeCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetRecycleTimeCsReq> _parser = new MessageParser<GetRecycleTimeCsReq>(() => new GetRecycleTimeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FGLKMDNFFEGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_fGLKMDNFFEG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> fGLKMDNFFEG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRecycleTimeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRecycleTimeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FGLKMDNFFEG => fGLKMDNFFEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRecycleTimeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRecycleTimeCsReq(GetRecycleTimeCsReq other)
		: this()
	{
		fGLKMDNFFEG_ = other.fGLKMDNFFEG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRecycleTimeCsReq Clone()
	{
		return new GetRecycleTimeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRecycleTimeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRecycleTimeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fGLKMDNFFEG_.Equals(other.fGLKMDNFFEG_))
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
		num ^= fGLKMDNFFEG_.GetHashCode();
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
		fGLKMDNFFEG_.WriteTo(ref output, _repeated_fGLKMDNFFEG_codec);
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
		num += fGLKMDNFFEG_.CalculateSize(_repeated_fGLKMDNFFEG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRecycleTimeCsReq other)
	{
		if (other != null)
		{
			fGLKMDNFFEG_.Add(other.fGLKMDNFFEG_);
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
				fGLKMDNFFEG_.AddEntriesFrom(ref input, _repeated_fGLKMDNFFEG_codec);
			}
		}
	}
}
