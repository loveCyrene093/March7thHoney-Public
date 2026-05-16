using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetActivityRewardCountDataCsReq : IMessage<GetActivityRewardCountDataCsReq>, IMessage, IEquatable<GetActivityRewardCountDataCsReq>, IDeepCloneable<GetActivityRewardCountDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetActivityRewardCountDataCsReq> _parser = new MessageParser<GetActivityRewardCountDataCsReq>(() => new GetActivityRewardCountDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FMKJKGAJKKJFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_fMKJKGAJKKJ_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> fMKJKGAJKKJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetActivityRewardCountDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetActivityRewardCountDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FMKJKGAJKKJ => fMKJKGAJKKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetActivityRewardCountDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetActivityRewardCountDataCsReq(GetActivityRewardCountDataCsReq other)
		: this()
	{
		fMKJKGAJKKJ_ = other.fMKJKGAJKKJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetActivityRewardCountDataCsReq Clone()
	{
		return new GetActivityRewardCountDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetActivityRewardCountDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetActivityRewardCountDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fMKJKGAJKKJ_.Equals(other.fMKJKGAJKKJ_))
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
		num ^= fMKJKGAJKKJ_.GetHashCode();
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
		fMKJKGAJKKJ_.WriteTo(ref output, _repeated_fMKJKGAJKKJ_codec);
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
		num += fMKJKGAJKKJ_.CalculateSize(_repeated_fMKJKGAJKKJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetActivityRewardCountDataCsReq other)
	{
		if (other != null)
		{
			fMKJKGAJKKJ_.Add(other.fMKJKGAJKKJ_);
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
			if (num != 112 && num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fMKJKGAJKKJ_.AddEntriesFrom(ref input, _repeated_fMKJKGAJKKJ_codec);
			}
		}
	}
}
