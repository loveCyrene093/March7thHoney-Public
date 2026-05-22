using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBFAMLLHFAF : IMessage<HBFAMLLHFAF>, IMessage, IEquatable<HBFAMLLHFAF>, IDeepCloneable<HBFAMLLHFAF>, IBufferMessage
{
	private static readonly MessageParser<HBFAMLLHFAF> _parser = new MessageParser<HBFAMLLHFAF>(() => new HBFAMLLHFAF());

	private UnknownFieldSet _unknownFields;

	public const int KPKBELAHNHIFieldNumber = 1;

	private double kPKBELAHNHI_;

	public const int ABBHKEEELKLFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_aBBHKEEELKL_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> aBBHKEEELKL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBFAMLLHFAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBFAMLLHFAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double KPKBELAHNHI
	{
		get
		{
			return kPKBELAHNHI_;
		}
		set
		{
			kPKBELAHNHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ABBHKEEELKL => aBBHKEEELKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBFAMLLHFAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBFAMLLHFAF(HBFAMLLHFAF other)
		: this()
	{
		kPKBELAHNHI_ = other.kPKBELAHNHI_;
		aBBHKEEELKL_ = other.aBBHKEEELKL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBFAMLLHFAF Clone()
	{
		return new HBFAMLLHFAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBFAMLLHFAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBFAMLLHFAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(KPKBELAHNHI, other.KPKBELAHNHI))
		{
			return false;
		}
		if (!aBBHKEEELKL_.Equals(other.aBBHKEEELKL_))
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
		if (KPKBELAHNHI != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(KPKBELAHNHI);
		}
		num ^= aBBHKEEELKL_.GetHashCode();
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
		if (KPKBELAHNHI != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(KPKBELAHNHI);
		}
		aBBHKEEELKL_.WriteTo(ref output, _repeated_aBBHKEEELKL_codec);
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
		if (KPKBELAHNHI != 0.0)
		{
			num += 9;
		}
		num += aBBHKEEELKL_.CalculateSize(_repeated_aBBHKEEELKL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HBFAMLLHFAF other)
	{
		if (other != null)
		{
			if (other.KPKBELAHNHI != 0.0)
			{
				KPKBELAHNHI = other.KPKBELAHNHI;
			}
			aBBHKEEELKL_.Add(other.aBBHKEEELKL_);
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
			case 9u:
				KPKBELAHNHI = input.ReadDouble();
				break;
			case 16u:
			case 18u:
				aBBHKEEELKL_.AddEntriesFrom(ref input, _repeated_aBBHKEEELKL_codec);
				break;
			}
		}
	}
}
