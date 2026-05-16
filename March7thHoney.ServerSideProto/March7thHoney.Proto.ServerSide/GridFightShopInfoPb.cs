using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightShopInfoPb : IMessage<GridFightShopInfoPb>, IMessage, IEquatable<GridFightShopInfoPb>, IDeepCloneable<GridFightShopInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightShopInfoPb> _parser = new MessageParser<GridFightShopInfoPb>(() => new GridFightShopInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int ShopLockedFieldNumber = 1;

	private bool shopLocked_;

	public const int FreeRefreshCountFieldNumber = 2;

	private uint freeRefreshCount_;

	public const int RefreshCostFieldNumber = 3;

	private uint refreshCost_;

	public const int ShopItemsFieldNumber = 4;

	private static readonly FieldCodec<GridFightShopItemPb> _repeated_shopItems_codec = FieldCodec.ForMessage(34u, GridFightShopItemPb.Parser);

	private readonly RepeatedField<GridFightShopItemPb> shopItems_ = new RepeatedField<GridFightShopItemPb>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightShopInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ShopLocked
	{
		get
		{
			return shopLocked_;
		}
		set
		{
			shopLocked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FreeRefreshCount
	{
		get
		{
			return freeRefreshCount_;
		}
		set
		{
			freeRefreshCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RefreshCost
	{
		get
		{
			return refreshCost_;
		}
		set
		{
			refreshCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightShopItemPb> ShopItems => shopItems_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopInfoPb(GridFightShopInfoPb other)
		: this()
	{
		shopLocked_ = other.shopLocked_;
		freeRefreshCount_ = other.freeRefreshCount_;
		refreshCost_ = other.refreshCost_;
		shopItems_ = other.shopItems_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopInfoPb Clone()
	{
		return new GridFightShopInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightShopInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightShopInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShopLocked != other.ShopLocked)
		{
			return false;
		}
		if (FreeRefreshCount != other.FreeRefreshCount)
		{
			return false;
		}
		if (RefreshCost != other.RefreshCost)
		{
			return false;
		}
		if (!shopItems_.Equals(other.shopItems_))
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
		if (ShopLocked)
		{
			num ^= ShopLocked.GetHashCode();
		}
		if (FreeRefreshCount != 0)
		{
			num ^= FreeRefreshCount.GetHashCode();
		}
		if (RefreshCost != 0)
		{
			num ^= RefreshCost.GetHashCode();
		}
		num ^= shopItems_.GetHashCode();
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
		if (ShopLocked)
		{
			output.WriteRawTag(8);
			output.WriteBool(ShopLocked);
		}
		if (FreeRefreshCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FreeRefreshCount);
		}
		if (RefreshCost != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(RefreshCost);
		}
		shopItems_.WriteTo(ref output, _repeated_shopItems_codec);
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
		if (ShopLocked)
		{
			num += 2;
		}
		if (FreeRefreshCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FreeRefreshCount);
		}
		if (RefreshCost != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RefreshCost);
		}
		num += shopItems_.CalculateSize(_repeated_shopItems_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightShopInfoPb other)
	{
		if (other != null)
		{
			if (other.ShopLocked)
			{
				ShopLocked = other.ShopLocked;
			}
			if (other.FreeRefreshCount != 0)
			{
				FreeRefreshCount = other.FreeRefreshCount;
			}
			if (other.RefreshCost != 0)
			{
				RefreshCost = other.RefreshCost;
			}
			shopItems_.Add(other.shopItems_);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				ShopLocked = input.ReadBool();
				break;
			case 16u:
				FreeRefreshCount = input.ReadUInt32();
				break;
			case 24u:
				RefreshCost = input.ReadUInt32();
				break;
			case 34u:
				shopItems_.AddEntriesFrom(ref input, _repeated_shopItems_codec);
				break;
			}
		}
	}
}
