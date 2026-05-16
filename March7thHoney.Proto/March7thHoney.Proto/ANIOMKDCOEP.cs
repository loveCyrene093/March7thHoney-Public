using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ANIOMKDCOEP : IMessage<ANIOMKDCOEP>, IMessage, IEquatable<ANIOMKDCOEP>, IDeepCloneable<ANIOMKDCOEP>, IBufferMessage
{
	private static readonly MessageParser<ANIOMKDCOEP> _parser = new MessageParser<ANIOMKDCOEP>(() => new ANIOMKDCOEP());

	private UnknownFieldSet _unknownFields;

	public const int BDMNHFNKMDAFieldNumber = 6;

	private static readonly FieldCodec<GLAAJKHKMHB> _repeated_bDMNHFNKMDA_codec = FieldCodec.ForMessage(50u, GLAAJKHKMHB.Parser);

	private readonly RepeatedField<GLAAJKHKMHB> bDMNHFNKMDA_ = new RepeatedField<GLAAJKHKMHB>();

	public const int ShopGoodsListFieldNumber = 7;

	private static readonly FieldCodec<JCFDCEKLBFH> _repeated_shopGoodsList_codec = FieldCodec.ForMessage(58u, JCFDCEKLBFH.Parser);

	private readonly RepeatedField<JCFDCEKLBFH> shopGoodsList_ = new RepeatedField<JCFDCEKLBFH>();

	public const int EBKLPKNANLNFieldNumber = 8;

	private bool eBKLPKNANLN_;

	public const int ItemValueFieldNumber = 9;

	private uint itemValue_;

	public const int FDMEFIIJLCKFieldNumber = 11;

	private uint fDMEFIIJLCK_;

	public const int AAABOOFAFLJFieldNumber = 14;

	private uint aAABOOFAFLJ_;

	public const int GOCGFMALEOPFieldNumber = 15;

	private bool gOCGFMALEOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ANIOMKDCOEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ANIOMKDCOEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GLAAJKHKMHB> BDMNHFNKMDA => bDMNHFNKMDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCFDCEKLBFH> ShopGoodsList => shopGoodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EBKLPKNANLN
	{
		get
		{
			return eBKLPKNANLN_;
		}
		set
		{
			eBKLPKNANLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FDMEFIIJLCK
	{
		get
		{
			return fDMEFIIJLCK_;
		}
		set
		{
			fDMEFIIJLCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAABOOFAFLJ
	{
		get
		{
			return aAABOOFAFLJ_;
		}
		set
		{
			aAABOOFAFLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GOCGFMALEOP
	{
		get
		{
			return gOCGFMALEOP_;
		}
		set
		{
			gOCGFMALEOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANIOMKDCOEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANIOMKDCOEP(ANIOMKDCOEP other)
		: this()
	{
		bDMNHFNKMDA_ = other.bDMNHFNKMDA_.Clone();
		shopGoodsList_ = other.shopGoodsList_.Clone();
		eBKLPKNANLN_ = other.eBKLPKNANLN_;
		itemValue_ = other.itemValue_;
		fDMEFIIJLCK_ = other.fDMEFIIJLCK_;
		aAABOOFAFLJ_ = other.aAABOOFAFLJ_;
		gOCGFMALEOP_ = other.gOCGFMALEOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANIOMKDCOEP Clone()
	{
		return new ANIOMKDCOEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ANIOMKDCOEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ANIOMKDCOEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bDMNHFNKMDA_.Equals(other.bDMNHFNKMDA_))
		{
			return false;
		}
		if (!shopGoodsList_.Equals(other.shopGoodsList_))
		{
			return false;
		}
		if (EBKLPKNANLN != other.EBKLPKNANLN)
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (FDMEFIIJLCK != other.FDMEFIIJLCK)
		{
			return false;
		}
		if (AAABOOFAFLJ != other.AAABOOFAFLJ)
		{
			return false;
		}
		if (GOCGFMALEOP != other.GOCGFMALEOP)
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
		num ^= bDMNHFNKMDA_.GetHashCode();
		num ^= shopGoodsList_.GetHashCode();
		if (EBKLPKNANLN)
		{
			num ^= EBKLPKNANLN.GetHashCode();
		}
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (FDMEFIIJLCK != 0)
		{
			num ^= FDMEFIIJLCK.GetHashCode();
		}
		if (AAABOOFAFLJ != 0)
		{
			num ^= AAABOOFAFLJ.GetHashCode();
		}
		if (GOCGFMALEOP)
		{
			num ^= GOCGFMALEOP.GetHashCode();
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
		bDMNHFNKMDA_.WriteTo(ref output, _repeated_bDMNHFNKMDA_codec);
		shopGoodsList_.WriteTo(ref output, _repeated_shopGoodsList_codec);
		if (EBKLPKNANLN)
		{
			output.WriteRawTag(64);
			output.WriteBool(EBKLPKNANLN);
		}
		if (ItemValue != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ItemValue);
		}
		if (FDMEFIIJLCK != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FDMEFIIJLCK);
		}
		if (AAABOOFAFLJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AAABOOFAFLJ);
		}
		if (GOCGFMALEOP)
		{
			output.WriteRawTag(120);
			output.WriteBool(GOCGFMALEOP);
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
		num += bDMNHFNKMDA_.CalculateSize(_repeated_bDMNHFNKMDA_codec);
		num += shopGoodsList_.CalculateSize(_repeated_shopGoodsList_codec);
		if (EBKLPKNANLN)
		{
			num += 2;
		}
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (FDMEFIIJLCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FDMEFIIJLCK);
		}
		if (AAABOOFAFLJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAABOOFAFLJ);
		}
		if (GOCGFMALEOP)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ANIOMKDCOEP other)
	{
		if (other != null)
		{
			bDMNHFNKMDA_.Add(other.bDMNHFNKMDA_);
			shopGoodsList_.Add(other.shopGoodsList_);
			if (other.EBKLPKNANLN)
			{
				EBKLPKNANLN = other.EBKLPKNANLN;
			}
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			if (other.FDMEFIIJLCK != 0)
			{
				FDMEFIIJLCK = other.FDMEFIIJLCK;
			}
			if (other.AAABOOFAFLJ != 0)
			{
				AAABOOFAFLJ = other.AAABOOFAFLJ;
			}
			if (other.GOCGFMALEOP)
			{
				GOCGFMALEOP = other.GOCGFMALEOP;
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
			case 50u:
				bDMNHFNKMDA_.AddEntriesFrom(ref input, _repeated_bDMNHFNKMDA_codec);
				break;
			case 58u:
				shopGoodsList_.AddEntriesFrom(ref input, _repeated_shopGoodsList_codec);
				break;
			case 64u:
				EBKLPKNANLN = input.ReadBool();
				break;
			case 72u:
				ItemValue = input.ReadUInt32();
				break;
			case 88u:
				FDMEFIIJLCK = input.ReadUInt32();
				break;
			case 112u:
				AAABOOFAFLJ = input.ReadUInt32();
				break;
			case 120u:
				GOCGFMALEOP = input.ReadBool();
				break;
			}
		}
	}
}
