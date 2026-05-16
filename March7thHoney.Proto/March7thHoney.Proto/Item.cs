using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Item : IMessage<Item>, IMessage, IEquatable<Item>, IDeepCloneable<Item>, IBufferMessage
{
	private static readonly MessageParser<Item> _parser = new MessageParser<Item>(() => new Item());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private uint rank_;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int UniqueIdFieldNumber = 5;

	private uint uniqueId_;

	public const int ItemIdFieldNumber = 9;

	private uint itemId_;

	public const int PromotionFieldNumber = 12;

	private uint promotion_;

	public const int NumFieldNumber = 13;

	private uint num_;

	public const int MainAffixIdFieldNumber = 14;

	private uint mainAffixId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Item> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ItemReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
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
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainAffixId
	{
		get
		{
			return mainAffixId_;
		}
		set
		{
			mainAffixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Item()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Item(Item other)
		: this()
	{
		rank_ = other.rank_;
		level_ = other.level_;
		uniqueId_ = other.uniqueId_;
		itemId_ = other.itemId_;
		promotion_ = other.promotion_;
		num_ = other.num_;
		mainAffixId_ = other.mainAffixId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Item Clone()
	{
		return new Item(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Item);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Item other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (Promotion != other.Promotion)
		{
			return false;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (MainAffixId != other.MainAffixId)
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
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (MainAffixId != 0)
		{
			num ^= MainAffixId.GetHashCode();
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
		if (Rank != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Rank);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UniqueId);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ItemId);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Promotion);
		}
		if (Num != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Num);
		}
		if (MainAffixId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MainAffixId);
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
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (MainAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainAffixId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Item other)
	{
		if (other != null)
		{
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.Promotion != 0)
			{
				Promotion = other.Promotion;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.MainAffixId != 0)
			{
				MainAffixId = other.MainAffixId;
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
				Rank = input.ReadUInt32();
				break;
			case 24u:
				Level = input.ReadUInt32();
				break;
			case 40u:
				UniqueId = input.ReadUInt32();
				break;
			case 72u:
				ItemId = input.ReadUInt32();
				break;
			case 96u:
				Promotion = input.ReadUInt32();
				break;
			case 104u:
				Num = input.ReadUInt32();
				break;
			case 112u:
				MainAffixId = input.ReadUInt32();
				break;
			}
		}
	}
}
