using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightShopItemPb : IMessage<GridFightShopItemPb>, IMessage, IEquatable<GridFightShopItemPb>, IDeepCloneable<GridFightShopItemPb>, IBufferMessage
{
	public enum ItemTypeOneofCase
	{
		None,
		RoleItem
	}

	private static readonly MessageParser<GridFightShopItemPb> _parser = new MessageParser<GridFightShopItemPb>(() => new GridFightShopItemPb());

	private UnknownFieldSet _unknownFields;

	public const int RoleItemFieldNumber = 1;

	public const int CostFieldNumber = 2;

	private uint cost_;

	public const int SoldOutFieldNumber = 3;

	private bool soldOut_;

	private object itemType_;

	private ItemTypeOneofCase itemTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightShopItemPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopRoleItemPb RoleItem
	{
		get
		{
			if (itemTypeCase_ != ItemTypeOneofCase.RoleItem)
			{
				return null;
			}
			return (GridFightShopRoleItemPb)itemType_;
		}
		set
		{
			itemType_ = value;
			itemTypeCase_ = ((value != null) ? ItemTypeOneofCase.RoleItem : ItemTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Cost
	{
		get
		{
			return cost_;
		}
		set
		{
			cost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool SoldOut
	{
		get
		{
			return soldOut_;
		}
		set
		{
			soldOut_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemTypeOneofCase ItemTypeCase => itemTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopItemPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopItemPb(GridFightShopItemPb other)
		: this()
	{
		cost_ = other.cost_;
		soldOut_ = other.soldOut_;
		if (other.ItemTypeCase == ItemTypeOneofCase.RoleItem)
		{
			RoleItem = other.RoleItem.Clone();
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopItemPb Clone()
	{
		return new GridFightShopItemPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearItemType()
	{
		itemTypeCase_ = ItemTypeOneofCase.None;
		itemType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightShopItemPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightShopItemPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RoleItem, other.RoleItem))
		{
			return false;
		}
		if (Cost != other.Cost)
		{
			return false;
		}
		if (SoldOut != other.SoldOut)
		{
			return false;
		}
		if (ItemTypeCase != other.ItemTypeCase)
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
		if (itemTypeCase_ == ItemTypeOneofCase.RoleItem)
		{
			num ^= RoleItem.GetHashCode();
		}
		if (Cost != 0)
		{
			num ^= Cost.GetHashCode();
		}
		if (SoldOut)
		{
			num ^= SoldOut.GetHashCode();
		}
		num ^= (int)itemTypeCase_;
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
		if (itemTypeCase_ == ItemTypeOneofCase.RoleItem)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RoleItem);
		}
		if (Cost != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Cost);
		}
		if (SoldOut)
		{
			output.WriteRawTag(24);
			output.WriteBool(SoldOut);
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
		if (itemTypeCase_ == ItemTypeOneofCase.RoleItem)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleItem);
		}
		if (Cost != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Cost);
		}
		if (SoldOut)
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
	public void MergeFrom(GridFightShopItemPb other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Cost != 0)
		{
			Cost = other.Cost;
		}
		if (other.SoldOut)
		{
			SoldOut = other.SoldOut;
		}
		if (other.ItemTypeCase == ItemTypeOneofCase.RoleItem)
		{
			if (RoleItem == null)
			{
				RoleItem = new GridFightShopRoleItemPb();
			}
			RoleItem.MergeFrom(other.RoleItem);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
			{
				GridFightShopRoleItemPb gridFightShopRoleItemPb = new GridFightShopRoleItemPb();
				if (itemTypeCase_ == ItemTypeOneofCase.RoleItem)
				{
					gridFightShopRoleItemPb.MergeFrom(RoleItem);
				}
				input.ReadMessage(gridFightShopRoleItemPb);
				RoleItem = gridFightShopRoleItemPb;
				break;
			}
			case 16u:
				Cost = input.ReadUInt32();
				break;
			case 24u:
				SoldOut = input.ReadBool();
				break;
			}
		}
	}
}
