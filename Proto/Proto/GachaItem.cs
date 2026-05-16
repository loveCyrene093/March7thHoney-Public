using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GachaItem : IMessage<GachaItem>, IMessage, IEquatable<GachaItem>, IDeepCloneable<GachaItem>, IBufferMessage
{
	private static readonly MessageParser<GachaItem> _parser = new MessageParser<GachaItem>(() => new GachaItem());

	private UnknownFieldSet _unknownFields;

	public const int IsNewFieldNumber = 6;

	private bool isNew_;

	public const int TokenItemFieldNumber = 7;

	private ItemList tokenItem_;

	public const int TransferItemListFieldNumber = 12;

	private ItemList transferItemList_;

	public const int GachaItem_FieldNumber = 13;

	private Item gachaItem_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaItem> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaItemReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNew
	{
		get
		{
			return isNew_;
		}
		set
		{
			isNew_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList TokenItem
	{
		get
		{
			return tokenItem_;
		}
		set
		{
			tokenItem_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList TransferItemList
	{
		get
		{
			return transferItemList_;
		}
		set
		{
			transferItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Item GachaItem_
	{
		get
		{
			return gachaItem_;
		}
		set
		{
			gachaItem_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaItem()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaItem(GachaItem other)
		: this()
	{
		isNew_ = other.isNew_;
		tokenItem_ = ((other.tokenItem_ != null) ? other.tokenItem_.Clone() : null);
		transferItemList_ = ((other.transferItemList_ != null) ? other.transferItemList_.Clone() : null);
		gachaItem_ = ((other.gachaItem_ != null) ? other.gachaItem_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaItem Clone()
	{
		return new GachaItem(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaItem);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsNew != other.IsNew)
		{
			return false;
		}
		if (!object.Equals(TokenItem, other.TokenItem))
		{
			return false;
		}
		if (!object.Equals(TransferItemList, other.TransferItemList))
		{
			return false;
		}
		if (!object.Equals(GachaItem_, other.GachaItem_))
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
		if (IsNew)
		{
			num ^= IsNew.GetHashCode();
		}
		if (tokenItem_ != null)
		{
			num ^= TokenItem.GetHashCode();
		}
		if (transferItemList_ != null)
		{
			num ^= TransferItemList.GetHashCode();
		}
		if (gachaItem_ != null)
		{
			num ^= GachaItem_.GetHashCode();
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
		if (IsNew)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsNew);
		}
		if (tokenItem_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(TokenItem);
		}
		if (transferItemList_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(TransferItemList);
		}
		if (gachaItem_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GachaItem_);
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
		if (IsNew)
		{
			num += 2;
		}
		if (tokenItem_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TokenItem);
		}
		if (transferItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TransferItemList);
		}
		if (gachaItem_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GachaItem_);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaItem other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsNew)
		{
			IsNew = other.IsNew;
		}
		if (other.tokenItem_ != null)
		{
			if (tokenItem_ == null)
			{
				TokenItem = new ItemList();
			}
			TokenItem.MergeFrom(other.TokenItem);
		}
		if (other.transferItemList_ != null)
		{
			if (transferItemList_ == null)
			{
				TransferItemList = new ItemList();
			}
			TransferItemList.MergeFrom(other.TransferItemList);
		}
		if (other.gachaItem_ != null)
		{
			if (gachaItem_ == null)
			{
				GachaItem_ = new Item();
			}
			GachaItem_.MergeFrom(other.GachaItem_);
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
			case 48u:
				IsNew = input.ReadBool();
				break;
			case 58u:
				if (tokenItem_ == null)
				{
					TokenItem = new ItemList();
				}
				input.ReadMessage(TokenItem);
				break;
			case 98u:
				if (transferItemList_ == null)
				{
					TransferItemList = new ItemList();
				}
				input.ReadMessage(TransferItemList);
				break;
			case 106u:
				if (gachaItem_ == null)
				{
					GachaItem_ = new Item();
				}
				input.ReadMessage(GachaItem_);
				break;
			}
		}
	}
}
