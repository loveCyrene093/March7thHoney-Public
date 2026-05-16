using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJFDEKIPPJF : IMessage<OJFDEKIPPJF>, IMessage, IEquatable<OJFDEKIPPJF>, IDeepCloneable<OJFDEKIPPJF>, IBufferMessage
{
	private static readonly MessageParser<OJFDEKIPPJF> _parser = new MessageParser<OJFDEKIPPJF>(() => new OJFDEKIPPJF());

	private UnknownFieldSet _unknownFields;

	public const int FKKLHIHEEFMFieldNumber = 1;

	private static readonly FieldCodec<ILLBNKFBNBP> _repeated_fKKLHIHEEFM_codec = FieldCodec.ForMessage(10u, ILLBNKFBNBP.Parser);

	private readonly RepeatedField<ILLBNKFBNBP> fKKLHIHEEFM_ = new RepeatedField<ILLBNKFBNBP>();

	public const int AIFKKCDBHJGFieldNumber = 5;

	private static readonly FieldCodec<EIPPGFCFJEO> _repeated_aIFKKCDBHJG_codec = FieldCodec.ForMessage(42u, EIPPGFCFJEO.Parser);

	private readonly RepeatedField<EIPPGFCFJEO> aIFKKCDBHJG_ = new RepeatedField<EIPPGFCFJEO>();

	public const int HKBFAINCKHIFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_hKBFAINCKHI_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> hKBFAINCKHI_ = new RepeatedField<uint>();

	public const int EEEJLCLGAGCFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_eEEJLCLGAGC_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> eEEJLCLGAGC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJFDEKIPPJF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJFDEKIPPJFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ILLBNKFBNBP> FKKLHIHEEFM => fKKLHIHEEFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EIPPGFCFJEO> AIFKKCDBHJG => aIFKKCDBHJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HKBFAINCKHI => hKBFAINCKHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EEEJLCLGAGC => eEEJLCLGAGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJFDEKIPPJF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJFDEKIPPJF(OJFDEKIPPJF other)
		: this()
	{
		fKKLHIHEEFM_ = other.fKKLHIHEEFM_.Clone();
		aIFKKCDBHJG_ = other.aIFKKCDBHJG_.Clone();
		hKBFAINCKHI_ = other.hKBFAINCKHI_.Clone();
		eEEJLCLGAGC_ = other.eEEJLCLGAGC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJFDEKIPPJF Clone()
	{
		return new OJFDEKIPPJF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJFDEKIPPJF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJFDEKIPPJF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fKKLHIHEEFM_.Equals(other.fKKLHIHEEFM_))
		{
			return false;
		}
		if (!aIFKKCDBHJG_.Equals(other.aIFKKCDBHJG_))
		{
			return false;
		}
		if (!hKBFAINCKHI_.Equals(other.hKBFAINCKHI_))
		{
			return false;
		}
		if (!eEEJLCLGAGC_.Equals(other.eEEJLCLGAGC_))
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
		num ^= fKKLHIHEEFM_.GetHashCode();
		num ^= aIFKKCDBHJG_.GetHashCode();
		num ^= hKBFAINCKHI_.GetHashCode();
		num ^= eEEJLCLGAGC_.GetHashCode();
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
		fKKLHIHEEFM_.WriteTo(ref output, _repeated_fKKLHIHEEFM_codec);
		aIFKKCDBHJG_.WriteTo(ref output, _repeated_aIFKKCDBHJG_codec);
		hKBFAINCKHI_.WriteTo(ref output, _repeated_hKBFAINCKHI_codec);
		eEEJLCLGAGC_.WriteTo(ref output, _repeated_eEEJLCLGAGC_codec);
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
		num += fKKLHIHEEFM_.CalculateSize(_repeated_fKKLHIHEEFM_codec);
		num += aIFKKCDBHJG_.CalculateSize(_repeated_aIFKKCDBHJG_codec);
		num += hKBFAINCKHI_.CalculateSize(_repeated_hKBFAINCKHI_codec);
		num += eEEJLCLGAGC_.CalculateSize(_repeated_eEEJLCLGAGC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJFDEKIPPJF other)
	{
		if (other != null)
		{
			fKKLHIHEEFM_.Add(other.fKKLHIHEEFM_);
			aIFKKCDBHJG_.Add(other.aIFKKCDBHJG_);
			hKBFAINCKHI_.Add(other.hKBFAINCKHI_);
			eEEJLCLGAGC_.Add(other.eEEJLCLGAGC_);
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
			case 10u:
				fKKLHIHEEFM_.AddEntriesFrom(ref input, _repeated_fKKLHIHEEFM_codec);
				break;
			case 42u:
				aIFKKCDBHJG_.AddEntriesFrom(ref input, _repeated_aIFKKCDBHJG_codec);
				break;
			case 80u:
			case 82u:
				hKBFAINCKHI_.AddEntriesFrom(ref input, _repeated_hKBFAINCKHI_codec);
				break;
			case 112u:
			case 114u:
				eEEJLCLGAGC_.AddEntriesFrom(ref input, _repeated_eEEJLCLGAGC_codec);
				break;
			}
		}
	}
}
