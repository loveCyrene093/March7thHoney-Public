using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMEJHILMKAH : IMessage<DMEJHILMKAH>, IMessage, IEquatable<DMEJHILMKAH>, IDeepCloneable<DMEJHILMKAH>, IBufferMessage
{
	private static readonly MessageParser<DMEJHILMKAH> _parser = new MessageParser<DMEJHILMKAH>(() => new DMEJHILMKAH());

	private UnknownFieldSet _unknownFields;

	public const int MPMCJPMMDMCFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_mPMCJPMMDMC_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> mPMCJPMMDMC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMEJHILMKAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMEJHILMKAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPMCJPMMDMC => mPMCJPMMDMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMEJHILMKAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMEJHILMKAH(DMEJHILMKAH other)
		: this()
	{
		mPMCJPMMDMC_ = other.mPMCJPMMDMC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMEJHILMKAH Clone()
	{
		return new DMEJHILMKAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMEJHILMKAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMEJHILMKAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPMCJPMMDMC_.Equals(other.mPMCJPMMDMC_))
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
		num ^= mPMCJPMMDMC_.GetHashCode();
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
		mPMCJPMMDMC_.WriteTo(ref output, _repeated_mPMCJPMMDMC_codec);
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
		num += mPMCJPMMDMC_.CalculateSize(_repeated_mPMCJPMMDMC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMEJHILMKAH other)
	{
		if (other != null)
		{
			mPMCJPMMDMC_.Add(other.mPMCJPMMDMC_);
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
				mPMCJPMMDMC_.AddEntriesFrom(ref input, _repeated_mPMCJPMMDMC_codec);
			}
		}
	}
}
