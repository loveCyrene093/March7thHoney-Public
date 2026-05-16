using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantRecycleSeedCsReq : IMessage<ElfRestaurantRecycleSeedCsReq>, IMessage, IEquatable<ElfRestaurantRecycleSeedCsReq>, IDeepCloneable<ElfRestaurantRecycleSeedCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantRecycleSeedCsReq> _parser = new MessageParser<ElfRestaurantRecycleSeedCsReq>(() => new ElfRestaurantRecycleSeedCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FOPHPJNGPDEFieldNumber = 6;

	private static readonly FieldCodec<BHHNMHDDIDD> _repeated_fOPHPJNGPDE_codec = FieldCodec.ForMessage(50u, BHHNMHDDIDD.Parser);

	private readonly RepeatedField<BHHNMHDDIDD> fOPHPJNGPDE_ = new RepeatedField<BHHNMHDDIDD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantRecycleSeedCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantRecycleSeedCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BHHNMHDDIDD> FOPHPJNGPDE => fOPHPJNGPDE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantRecycleSeedCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantRecycleSeedCsReq(ElfRestaurantRecycleSeedCsReq other)
		: this()
	{
		fOPHPJNGPDE_ = other.fOPHPJNGPDE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantRecycleSeedCsReq Clone()
	{
		return new ElfRestaurantRecycleSeedCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantRecycleSeedCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantRecycleSeedCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fOPHPJNGPDE_.Equals(other.fOPHPJNGPDE_))
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
		num ^= fOPHPJNGPDE_.GetHashCode();
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
		fOPHPJNGPDE_.WriteTo(ref output, _repeated_fOPHPJNGPDE_codec);
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
		num += fOPHPJNGPDE_.CalculateSize(_repeated_fOPHPJNGPDE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantRecycleSeedCsReq other)
	{
		if (other != null)
		{
			fOPHPJNGPDE_.Add(other.fOPHPJNGPDE_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fOPHPJNGPDE_.AddEntriesFrom(ref input, _repeated_fOPHPJNGPDE_codec);
			}
		}
	}
}
