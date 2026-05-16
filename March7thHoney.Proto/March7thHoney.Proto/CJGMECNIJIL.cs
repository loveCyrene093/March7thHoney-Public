using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CJGMECNIJIL : IMessage<CJGMECNIJIL>, IMessage, IEquatable<CJGMECNIJIL>, IDeepCloneable<CJGMECNIJIL>, IBufferMessage
{
	private static readonly MessageParser<CJGMECNIJIL> _parser = new MessageParser<CJGMECNIJIL>(() => new CJGMECNIJIL());

	private UnknownFieldSet _unknownFields;

	public const int TraitIdFieldNumber = 1;

	private uint traitId_;

	public const int KBMBFJOLBBNFieldNumber = 2;

	private static readonly FieldCodec<DMLKEKFKNPL> _repeated_kBMBFJOLBBN_codec = FieldCodec.ForMessage(18u, DMLKEKFKNPL.Parser);

	private readonly RepeatedField<DMLKEKFKNPL> kBMBFJOLBBN_ = new RepeatedField<DMLKEKFKNPL>();

	public const int DamageFieldNumber = 3;

	private double damage_;

	public const int BOIEGPAPHOPFieldNumber = 4;

	private double bOIEGPAPHOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CJGMECNIJIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CJGMECNIJILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DMLKEKFKNPL> KBMBFJOLBBN => kBMBFJOLBBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BOIEGPAPHOP
	{
		get
		{
			return bOIEGPAPHOP_;
		}
		set
		{
			bOIEGPAPHOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJGMECNIJIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJGMECNIJIL(CJGMECNIJIL other)
		: this()
	{
		traitId_ = other.traitId_;
		kBMBFJOLBBN_ = other.kBMBFJOLBBN_.Clone();
		damage_ = other.damage_;
		bOIEGPAPHOP_ = other.bOIEGPAPHOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJGMECNIJIL Clone()
	{
		return new CJGMECNIJIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CJGMECNIJIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CJGMECNIJIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (!kBMBFJOLBBN_.Equals(other.kBMBFJOLBBN_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BOIEGPAPHOP, other.BOIEGPAPHOP))
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
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		num ^= kBMBFJOLBBN_.GetHashCode();
		if (Damage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
		}
		if (BOIEGPAPHOP != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BOIEGPAPHOP);
		}
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
		if (TraitId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TraitId);
		}
		kBMBFJOLBBN_.WriteTo(ref output, _repeated_kBMBFJOLBBN_codec);
		if (Damage != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(Damage);
		}
		if (BOIEGPAPHOP != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(BOIEGPAPHOP);
		}
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
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		num += kBMBFJOLBBN_.CalculateSize(_repeated_kBMBFJOLBBN_codec);
		if (Damage != 0.0)
		{
			num += 9;
		}
		if (BOIEGPAPHOP != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CJGMECNIJIL other)
	{
		if (other != null)
		{
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			kBMBFJOLBBN_.Add(other.kBMBFJOLBBN_);
			if (other.Damage != 0.0)
			{
				Damage = other.Damage;
			}
			if (other.BOIEGPAPHOP != 0.0)
			{
				BOIEGPAPHOP = other.BOIEGPAPHOP;
			}
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
			case 8u:
				TraitId = input.ReadUInt32();
				break;
			case 18u:
				kBMBFJOLBBN_.AddEntriesFrom(ref input, _repeated_kBMBFJOLBBN_codec);
				break;
			case 25u:
				Damage = input.ReadDouble();
				break;
			case 33u:
				BOIEGPAPHOP = input.ReadDouble();
				break;
			}
		}
	}
}
