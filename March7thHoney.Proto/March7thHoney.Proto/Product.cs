using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Product : IMessage<Product>, IMessage, IEquatable<Product>, IDeepCloneable<Product>, IBufferMessage
{
	private static readonly MessageParser<Product> _parser = new MessageParser<Product>(() => new Product());

	private UnknownFieldSet _unknownFields;

	public const int BeginTimeFieldNumber = 1;

	private long beginTime_;

	public const int PriceTierFieldNumber = 3;

	private string priceTier_ = "";

	public const int MEMNCJLKAEEFieldNumber = 5;

	private uint mEMNCJLKAEE_;

	public const int GiftTypeFieldNumber = 7;

	private ProductGiftType giftType_;

	public const int ProductIdFieldNumber = 8;

	private string productId_ = "";

	public const int EndTimeFieldNumber = 9;

	private long endTime_;

	public const int DoubleRewardFieldNumber = 12;

	private bool doubleReward_;

	public const int EEFHEBKHKABFieldNumber = 14;

	private uint eEFHEBKHKAB_;

	public const int JCJGHCOEOOJFieldNumber = 15;

	private uint jCJGHCOEOOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Product> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ProductReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = value;
		}
	}

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
	public uint MEMNCJLKAEE
	{
		get
		{
			return mEMNCJLKAEE_;
		}
		set
		{
			mEMNCJLKAEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ProductGiftType GiftType
	{
		get
		{
			return giftType_;
		}
		set
		{
			giftType_ = value;
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
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DoubleReward
	{
		get
		{
			return doubleReward_;
		}
		set
		{
			doubleReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEFHEBKHKAB
	{
		get
		{
			return eEFHEBKHKAB_;
		}
		set
		{
			eEFHEBKHKAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCJGHCOEOOJ
	{
		get
		{
			return jCJGHCOEOOJ_;
		}
		set
		{
			jCJGHCOEOOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Product()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Product(Product other)
		: this()
	{
		beginTime_ = other.beginTime_;
		priceTier_ = other.priceTier_;
		mEMNCJLKAEE_ = other.mEMNCJLKAEE_;
		giftType_ = other.giftType_;
		productId_ = other.productId_;
		endTime_ = other.endTime_;
		doubleReward_ = other.doubleReward_;
		eEFHEBKHKAB_ = other.eEFHEBKHKAB_;
		jCJGHCOEOOJ_ = other.jCJGHCOEOOJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Product Clone()
	{
		return new Product(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Product);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Product other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (PriceTier != other.PriceTier)
		{
			return false;
		}
		if (MEMNCJLKAEE != other.MEMNCJLKAEE)
		{
			return false;
		}
		if (GiftType != other.GiftType)
		{
			return false;
		}
		if (ProductId != other.ProductId)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (DoubleReward != other.DoubleReward)
		{
			return false;
		}
		if (EEFHEBKHKAB != other.EEFHEBKHKAB)
		{
			return false;
		}
		if (JCJGHCOEOOJ != other.JCJGHCOEOOJ)
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
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (PriceTier.Length != 0)
		{
			num ^= PriceTier.GetHashCode();
		}
		if (MEMNCJLKAEE != 0)
		{
			num ^= MEMNCJLKAEE.GetHashCode();
		}
		if (GiftType != ProductGiftType.ProductGiftNone)
		{
			num ^= GiftType.GetHashCode();
		}
		if (ProductId.Length != 0)
		{
			num ^= ProductId.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (DoubleReward)
		{
			num ^= DoubleReward.GetHashCode();
		}
		if (EEFHEBKHKAB != 0)
		{
			num ^= EEFHEBKHKAB.GetHashCode();
		}
		if (JCJGHCOEOOJ != 0)
		{
			num ^= JCJGHCOEOOJ.GetHashCode();
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
		if (BeginTime != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(BeginTime);
		}
		if (PriceTier.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PriceTier);
		}
		if (MEMNCJLKAEE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MEMNCJLKAEE);
		}
		if (GiftType != ProductGiftType.ProductGiftNone)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)GiftType);
		}
		if (ProductId.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ProductId);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(EndTime);
		}
		if (DoubleReward)
		{
			output.WriteRawTag(96);
			output.WriteBool(DoubleReward);
		}
		if (EEFHEBKHKAB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EEFHEBKHKAB);
		}
		if (JCJGHCOEOOJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JCJGHCOEOOJ);
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
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		if (PriceTier.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PriceTier);
		}
		if (MEMNCJLKAEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEMNCJLKAEE);
		}
		if (GiftType != ProductGiftType.ProductGiftNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GiftType);
		}
		if (ProductId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProductId);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (DoubleReward)
		{
			num += 2;
		}
		if (EEFHEBKHKAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEFHEBKHKAB);
		}
		if (JCJGHCOEOOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCJGHCOEOOJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Product other)
	{
		if (other != null)
		{
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.PriceTier.Length != 0)
			{
				PriceTier = other.PriceTier;
			}
			if (other.MEMNCJLKAEE != 0)
			{
				MEMNCJLKAEE = other.MEMNCJLKAEE;
			}
			if (other.GiftType != ProductGiftType.ProductGiftNone)
			{
				GiftType = other.GiftType;
			}
			if (other.ProductId.Length != 0)
			{
				ProductId = other.ProductId;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.DoubleReward)
			{
				DoubleReward = other.DoubleReward;
			}
			if (other.EEFHEBKHKAB != 0)
			{
				EEFHEBKHKAB = other.EEFHEBKHKAB;
			}
			if (other.JCJGHCOEOOJ != 0)
			{
				JCJGHCOEOOJ = other.JCJGHCOEOOJ;
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
				BeginTime = input.ReadInt64();
				break;
			case 26u:
				PriceTier = input.ReadString();
				break;
			case 40u:
				MEMNCJLKAEE = input.ReadUInt32();
				break;
			case 56u:
				GiftType = (ProductGiftType)input.ReadEnum();
				break;
			case 66u:
				ProductId = input.ReadString();
				break;
			case 72u:
				EndTime = input.ReadInt64();
				break;
			case 96u:
				DoubleReward = input.ReadBool();
				break;
			case 112u:
				EEFHEBKHKAB = input.ReadUInt32();
				break;
			case 120u:
				JCJGHCOEOOJ = input.ReadUInt32();
				break;
			}
		}
	}
}
