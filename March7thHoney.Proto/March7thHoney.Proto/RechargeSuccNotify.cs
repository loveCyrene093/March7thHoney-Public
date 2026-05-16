using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RechargeSuccNotify : IMessage<RechargeSuccNotify>, IMessage, IEquatable<RechargeSuccNotify>, IDeepCloneable<RechargeSuccNotify>, IBufferMessage
{
	private static readonly MessageParser<RechargeSuccNotify> _parser = new MessageParser<RechargeSuccNotify>(() => new RechargeSuccNotify());

	private UnknownFieldSet _unknownFields;

	public const int PriceTierFieldNumber = 3;

	private string priceTier_ = "";

	public const int MonthCardOutDateTimeFieldNumber = 4;

	private ulong monthCardOutDateTime_;

	public const int ProductIdFieldNumber = 8;

	private string productId_ = "";

	public const int ItemListFieldNumber = 12;

	private ItemList itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RechargeSuccNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RechargeSuccNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PriceTier
	{
		get
		{
			return priceTier_;
		}
		set
		{
			priceTier_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong MonthCardOutDateTime
	{
		get
		{
			return monthCardOutDateTime_;
		}
		set
		{
			monthCardOutDateTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ProductId
	{
		get
		{
			return productId_;
		}
		set
		{
			productId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ItemList
	{
		get
		{
			return itemList_;
		}
		set
		{
			itemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RechargeSuccNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RechargeSuccNotify(RechargeSuccNotify other)
		: this()
	{
		priceTier_ = other.priceTier_;
		monthCardOutDateTime_ = other.monthCardOutDateTime_;
		productId_ = other.productId_;
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RechargeSuccNotify Clone()
	{
		return new RechargeSuccNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RechargeSuccNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RechargeSuccNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PriceTier != other.PriceTier)
		{
			return false;
		}
		if (MonthCardOutDateTime != other.MonthCardOutDateTime)
		{
			return false;
		}
		if (ProductId != other.ProductId)
		{
			return false;
		}
		if (!object.Equals(ItemList, other.ItemList))
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
		if (PriceTier.Length != 0)
		{
			num ^= PriceTier.GetHashCode();
		}
		if (MonthCardOutDateTime != 0L)
		{
			num ^= MonthCardOutDateTime.GetHashCode();
		}
		if (ProductId.Length != 0)
		{
			num ^= ProductId.GetHashCode();
		}
		if (itemList_ != null)
		{
			num ^= ItemList.GetHashCode();
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
		if (PriceTier.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PriceTier);
		}
		if (MonthCardOutDateTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(MonthCardOutDateTime);
		}
		if (ProductId.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ProductId);
		}
		if (itemList_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ItemList);
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
		if (PriceTier.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PriceTier);
		}
		if (MonthCardOutDateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MonthCardOutDateTime);
		}
		if (ProductId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProductId);
		}
		if (itemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RechargeSuccNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PriceTier.Length != 0)
		{
			PriceTier = other.PriceTier;
		}
		if (other.MonthCardOutDateTime != 0L)
		{
			MonthCardOutDateTime = other.MonthCardOutDateTime;
		}
		if (other.ProductId.Length != 0)
		{
			ProductId = other.ProductId;
		}
		if (other.itemList_ != null)
		{
			if (itemList_ == null)
			{
				ItemList = new ItemList();
			}
			ItemList.MergeFrom(other.ItemList);
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
			case 26u:
				PriceTier = input.ReadString();
				break;
			case 32u:
				MonthCardOutDateTime = input.ReadUInt64();
				break;
			case 66u:
				ProductId = input.ReadString();
				break;
			case 98u:
				if (itemList_ == null)
				{
					ItemList = new ItemList();
				}
				input.ReadMessage(ItemList);
				break;
			}
		}
	}
}
