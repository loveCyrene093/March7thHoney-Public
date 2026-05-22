using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BuyGoodsCsReq : IMessage<BuyGoodsCsReq>, IMessage, IEquatable<BuyGoodsCsReq>, IDeepCloneable<BuyGoodsCsReq>, IBufferMessage
{
	private static readonly MessageParser<BuyGoodsCsReq> _parser = new MessageParser<BuyGoodsCsReq>(() => new BuyGoodsCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GoodsIdFieldNumber = 5;

	private uint goodsId_;

	public const int InteractedPropEntityIdFieldNumber = 6;

	private uint interactedPropEntityId_;

	public const int GoodsNumFieldNumber = 8;

	private uint goodsNum_;

	public const int ItemIdFieldNumber = 13;

	private uint itemId_;

	public const int LIIBAEMAHOBFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_lIIBAEMAHOB_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> lIIBAEMAHOB_ = new RepeatedField<uint>();

	public const int ShopIdFieldNumber = 15;

	private uint shopId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuyGoodsCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuyGoodsCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GoodsId
	{
		get
		{
			return goodsId_;
		}
		set
		{
			goodsId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractedPropEntityId
	{
		get
		{
			return interactedPropEntityId_;
		}
		set
		{
			interactedPropEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GoodsNum
	{
		get
		{
			return goodsNum_;
		}
		set
		{
			goodsNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LIIBAEMAHOB => lIIBAEMAHOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyGoodsCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyGoodsCsReq(BuyGoodsCsReq other)
		: this()
	{
		goodsId_ = other.goodsId_;
		interactedPropEntityId_ = other.interactedPropEntityId_;
		goodsNum_ = other.goodsNum_;
		itemId_ = other.itemId_;
		lIIBAEMAHOB_ = other.lIIBAEMAHOB_.Clone();
		shopId_ = other.shopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyGoodsCsReq Clone()
	{
		return new BuyGoodsCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuyGoodsCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuyGoodsCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GoodsId != other.GoodsId)
		{
			return false;
		}
		if (InteractedPropEntityId != other.InteractedPropEntityId)
		{
			return false;
		}
		if (GoodsNum != other.GoodsNum)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (!lIIBAEMAHOB_.Equals(other.lIIBAEMAHOB_))
		{
			return false;
		}
		if (ShopId != other.ShopId)
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
		if (GoodsId != 0)
		{
			num ^= GoodsId.GetHashCode();
		}
		if (InteractedPropEntityId != 0)
		{
			num ^= InteractedPropEntityId.GetHashCode();
		}
		if (GoodsNum != 0)
		{
			num ^= GoodsNum.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		num ^= lIIBAEMAHOB_.GetHashCode();
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
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
		if (GoodsId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GoodsId);
		}
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(InteractedPropEntityId);
		}
		if (GoodsNum != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GoodsNum);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ItemId);
		}
		lIIBAEMAHOB_.WriteTo(ref output, _repeated_lIIBAEMAHOB_codec);
		if (ShopId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ShopId);
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
		if (GoodsId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GoodsId);
		}
		if (InteractedPropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractedPropEntityId);
		}
		if (GoodsNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GoodsNum);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		num += lIIBAEMAHOB_.CalculateSize(_repeated_lIIBAEMAHOB_codec);
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuyGoodsCsReq other)
	{
		if (other != null)
		{
			if (other.GoodsId != 0)
			{
				GoodsId = other.GoodsId;
			}
			if (other.InteractedPropEntityId != 0)
			{
				InteractedPropEntityId = other.InteractedPropEntityId;
			}
			if (other.GoodsNum != 0)
			{
				GoodsNum = other.GoodsNum;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			lIIBAEMAHOB_.Add(other.lIIBAEMAHOB_);
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
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
			case 40u:
				GoodsId = input.ReadUInt32();
				break;
			case 48u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			case 64u:
				GoodsNum = input.ReadUInt32();
				break;
			case 104u:
				ItemId = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				lIIBAEMAHOB_.AddEntriesFrom(ref input, _repeated_lIIBAEMAHOB_codec);
				break;
			case 120u:
				ShopId = input.ReadUInt32();
				break;
			}
		}
	}
}
