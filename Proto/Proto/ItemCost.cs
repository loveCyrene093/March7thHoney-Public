using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ItemCost : IMessage<ItemCost>, IMessage, IEquatable<ItemCost>, IDeepCloneable<ItemCost>, IBufferMessage
{
	public enum ItemOneofCase
	{
		None = 0,
		EquipmentUniqueId = 8,
		PileItem = 11,
		RelicUniqueId = 13
	}

	private static readonly MessageParser<ItemCost> _parser = new MessageParser<ItemCost>(() => new ItemCost());

	private UnknownFieldSet _unknownFields;

	public const int EquipmentUniqueIdFieldNumber = 8;

	public const int PileItemFieldNumber = 11;

	public const int RelicUniqueIdFieldNumber = 13;

	private object item_;

	private ItemOneofCase itemCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ItemCost> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ItemCostReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EquipmentUniqueId
	{
		get
		{
			if (!HasEquipmentUniqueId)
			{
				return 0u;
			}
			return (uint)item_;
		}
		set
		{
			item_ = value;
			itemCase_ = ItemOneofCase.EquipmentUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEquipmentUniqueId => itemCase_ == ItemOneofCase.EquipmentUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PileItem PileItem
	{
		get
		{
			if (itemCase_ != ItemOneofCase.PileItem)
			{
				return null;
			}
			return (PileItem)item_;
		}
		set
		{
			item_ = value;
			itemCase_ = ((value != null) ? ItemOneofCase.PileItem : ItemOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicUniqueId
	{
		get
		{
			if (!HasRelicUniqueId)
			{
				return 0u;
			}
			return (uint)item_;
		}
		set
		{
			item_ = value;
			itemCase_ = ItemOneofCase.RelicUniqueId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRelicUniqueId => itemCase_ == ItemOneofCase.RelicUniqueId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemOneofCase ItemCase => itemCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCost()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCost(ItemCost other)
		: this()
	{
		switch (other.ItemCase)
		{
		case ItemOneofCase.EquipmentUniqueId:
			EquipmentUniqueId = other.EquipmentUniqueId;
			break;
		case ItemOneofCase.PileItem:
			PileItem = other.PileItem.Clone();
			break;
		case ItemOneofCase.RelicUniqueId:
			RelicUniqueId = other.RelicUniqueId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCost Clone()
	{
		return new ItemCost(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEquipmentUniqueId()
	{
		if (HasEquipmentUniqueId)
		{
			ClearItem();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRelicUniqueId()
	{
		if (HasRelicUniqueId)
		{
			ClearItem();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearItem()
	{
		itemCase_ = ItemOneofCase.None;
		item_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ItemCost);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ItemCost other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipmentUniqueId != other.EquipmentUniqueId)
		{
			return false;
		}
		if (!object.Equals(PileItem, other.PileItem))
		{
			return false;
		}
		if (RelicUniqueId != other.RelicUniqueId)
		{
			return false;
		}
		if (ItemCase != other.ItemCase)
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
		if (HasEquipmentUniqueId)
		{
			num ^= EquipmentUniqueId.GetHashCode();
		}
		if (itemCase_ == ItemOneofCase.PileItem)
		{
			num ^= PileItem.GetHashCode();
		}
		if (HasRelicUniqueId)
		{
			num ^= RelicUniqueId.GetHashCode();
		}
		num ^= (int)itemCase_;
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
		if (HasEquipmentUniqueId)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EquipmentUniqueId);
		}
		if (itemCase_ == ItemOneofCase.PileItem)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PileItem);
		}
		if (HasRelicUniqueId)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(RelicUniqueId);
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
		if (HasEquipmentUniqueId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EquipmentUniqueId);
		}
		if (itemCase_ == ItemOneofCase.PileItem)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PileItem);
		}
		if (HasRelicUniqueId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ItemCost other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.ItemCase)
		{
		case ItemOneofCase.EquipmentUniqueId:
			EquipmentUniqueId = other.EquipmentUniqueId;
			break;
		case ItemOneofCase.PileItem:
			if (PileItem == null)
			{
				PileItem = new PileItem();
			}
			PileItem.MergeFrom(other.PileItem);
			break;
		case ItemOneofCase.RelicUniqueId:
			RelicUniqueId = other.RelicUniqueId;
			break;
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
			case 64u:
				EquipmentUniqueId = input.ReadUInt32();
				break;
			case 90u:
			{
				PileItem pileItem = new PileItem();
				if (itemCase_ == ItemOneofCase.PileItem)
				{
					pileItem.MergeFrom(PileItem);
				}
				input.ReadMessage(pileItem);
				PileItem = pileItem;
				break;
			}
			case 104u:
				RelicUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
