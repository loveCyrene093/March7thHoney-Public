using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KOILNOLKDEJ : IMessage<KOILNOLKDEJ>, IMessage, IEquatable<KOILNOLKDEJ>, IDeepCloneable<KOILNOLKDEJ>, IBufferMessage
{
	private static readonly MessageParser<KOILNOLKDEJ> _parser = new MessageParser<KOILNOLKDEJ>(() => new KOILNOLKDEJ());

	private UnknownFieldSet _unknownFields;

	public const int CardIdFieldNumber = 1;

	private uint cardId_;

	public const int DisplayValueFieldNumber = 2;

	private double displayValue_;

	public const int PMDFFJCICOIFieldNumber = 3;

	private bool pMDFFJCICOI_;

	public const int SwitchListFieldNumber = 4;

	private static readonly FieldCodec<double> _repeated_switchList_codec = FieldCodec.ForDouble(34u);

	private readonly RepeatedField<double> switchList_ = new RepeatedField<double>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KOILNOLKDEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KOILNOLKDEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CardId
	{
		get
		{
			return cardId_;
		}
		set
		{
			cardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PMDFFJCICOI
	{
		get
		{
			return pMDFFJCICOI_;
		}
		set
		{
			pMDFFJCICOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<double> SwitchList => switchList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOILNOLKDEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOILNOLKDEJ(KOILNOLKDEJ other)
		: this()
	{
		cardId_ = other.cardId_;
		displayValue_ = other.displayValue_;
		pMDFFJCICOI_ = other.pMDFFJCICOI_;
		switchList_ = other.switchList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOILNOLKDEJ Clone()
	{
		return new KOILNOLKDEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KOILNOLKDEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KOILNOLKDEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CardId != other.CardId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DisplayValue, other.DisplayValue))
		{
			return false;
		}
		if (PMDFFJCICOI != other.PMDFFJCICOI)
		{
			return false;
		}
		if (!switchList_.Equals(other.switchList_))
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
		if (CardId != 0)
		{
			num ^= CardId.GetHashCode();
		}
		if (DisplayValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DisplayValue);
		}
		if (PMDFFJCICOI)
		{
			num ^= PMDFFJCICOI.GetHashCode();
		}
		num ^= switchList_.GetHashCode();
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
		if (CardId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CardId);
		}
		if (DisplayValue != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(DisplayValue);
		}
		if (PMDFFJCICOI)
		{
			output.WriteRawTag(24);
			output.WriteBool(PMDFFJCICOI);
		}
		switchList_.WriteTo(ref output, _repeated_switchList_codec);
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
		if (CardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CardId);
		}
		if (DisplayValue != 0.0)
		{
			num += 9;
		}
		if (PMDFFJCICOI)
		{
			num += 2;
		}
		num += switchList_.CalculateSize(_repeated_switchList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KOILNOLKDEJ other)
	{
		if (other != null)
		{
			if (other.CardId != 0)
			{
				CardId = other.CardId;
			}
			if (other.DisplayValue != 0.0)
			{
				DisplayValue = other.DisplayValue;
			}
			if (other.PMDFFJCICOI)
			{
				PMDFFJCICOI = other.PMDFFJCICOI;
			}
			switchList_.Add(other.switchList_);
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
				CardId = input.ReadUInt32();
				break;
			case 17u:
				DisplayValue = input.ReadDouble();
				break;
			case 24u:
				PMDFFJCICOI = input.ReadBool();
				break;
			case 33u:
			case 34u:
				switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
				break;
			}
		}
	}
}
