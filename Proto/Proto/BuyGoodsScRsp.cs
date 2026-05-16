using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BuyGoodsScRsp : IMessage<BuyGoodsScRsp>, IMessage, IEquatable<BuyGoodsScRsp>, IDeepCloneable<BuyGoodsScRsp>, IBufferMessage
{
	private static readonly MessageParser<BuyGoodsScRsp> _parser = new MessageParser<BuyGoodsScRsp>(() => new BuyGoodsScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GoodsIdFieldNumber = 3;

	private uint goodsId_;

	public const int GoodsBuyTimesFieldNumber = 4;

	private uint goodsBuyTimes_;

	public const int ReturnItemListFieldNumber = 6;

	private ItemList returnItemList_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int ShopIdFieldNumber = 11;

	private uint shopId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuyGoodsScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuyGoodsScRspReflection.Descriptor.MessageTypes[0];

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
	public uint GoodsBuyTimes
	{
		get
		{
			return goodsBuyTimes_;
		}
		set
		{
			goodsBuyTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ReturnItemList
	{
		get
		{
			return returnItemList_;
		}
		set
		{
			returnItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

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
	public BuyGoodsScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyGoodsScRsp(BuyGoodsScRsp other)
		: this()
	{
		goodsId_ = other.goodsId_;
		goodsBuyTimes_ = other.goodsBuyTimes_;
		returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
		retcode_ = other.retcode_;
		shopId_ = other.shopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyGoodsScRsp Clone()
	{
		return new BuyGoodsScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuyGoodsScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuyGoodsScRsp other)
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
		if (GoodsBuyTimes != other.GoodsBuyTimes)
		{
			return false;
		}
		if (!object.Equals(ReturnItemList, other.ReturnItemList))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (GoodsBuyTimes != 0)
		{
			num ^= GoodsBuyTimes.GetHashCode();
		}
		if (returnItemList_ != null)
		{
			num ^= ReturnItemList.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
			output.WriteRawTag(24);
			output.WriteUInt32(GoodsId);
		}
		if (GoodsBuyTimes != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GoodsBuyTimes);
		}
		if (returnItemList_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ReturnItemList);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (ShopId != 0)
		{
			output.WriteRawTag(88);
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
		if (GoodsBuyTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GoodsBuyTimes);
		}
		if (returnItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReturnItemList);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
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
	public void MergeFrom(BuyGoodsScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GoodsId != 0)
		{
			GoodsId = other.GoodsId;
		}
		if (other.GoodsBuyTimes != 0)
		{
			GoodsBuyTimes = other.GoodsBuyTimes;
		}
		if (other.returnItemList_ != null)
		{
			if (returnItemList_ == null)
			{
				ReturnItemList = new ItemList();
			}
			ReturnItemList.MergeFrom(other.ReturnItemList);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.ShopId != 0)
		{
			ShopId = other.ShopId;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 24u:
				GoodsId = input.ReadUInt32();
				break;
			case 32u:
				GoodsBuyTimes = input.ReadUInt32();
				break;
			case 50u:
				if (returnItemList_ == null)
				{
					ReturnItemList = new ItemList();
				}
				input.ReadMessage(ReturnItemList);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				ShopId = input.ReadUInt32();
				break;
			}
		}
	}
}
