using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCFDCEKLBFH : IMessage<JCFDCEKLBFH>, IMessage, IEquatable<JCFDCEKLBFH>, IDeepCloneable<JCFDCEKLBFH>, IBufferMessage
{
	private static readonly MessageParser<JCFDCEKLBFH> _parser = new MessageParser<JCFDCEKLBFH>(() => new JCFDCEKLBFH());

	private UnknownFieldSet _unknownFields;

	public const int CntFieldNumber = 9;

	private uint cnt_;

	public const int BuffIdFieldNumber = 12;

	private uint buffId_;

	public const int FAOIKIDDCFFFieldNumber = 13;

	private bool fAOIKIDDCFF_;

	public const int ShopGoodsPriceFieldNumber = 15;

	private uint shopGoodsPrice_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCFDCEKLBFH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCFDCEKLBFHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Cnt
	{
		get
		{
			return cnt_;
		}
		set
		{
			cnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FAOIKIDDCFF
	{
		get
		{
			return fAOIKIDDCFF_;
		}
		set
		{
			fAOIKIDDCFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShopGoodsPrice
	{
		get
		{
			return shopGoodsPrice_;
		}
		set
		{
			shopGoodsPrice_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFDCEKLBFH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFDCEKLBFH(JCFDCEKLBFH other)
		: this()
	{
		cnt_ = other.cnt_;
		buffId_ = other.buffId_;
		fAOIKIDDCFF_ = other.fAOIKIDDCFF_;
		shopGoodsPrice_ = other.shopGoodsPrice_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFDCEKLBFH Clone()
	{
		return new JCFDCEKLBFH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCFDCEKLBFH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCFDCEKLBFH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Cnt != other.Cnt)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (FAOIKIDDCFF != other.FAOIKIDDCFF)
		{
			return false;
		}
		if (ShopGoodsPrice != other.ShopGoodsPrice)
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
		if (Cnt != 0)
		{
			num ^= Cnt.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (FAOIKIDDCFF)
		{
			num ^= FAOIKIDDCFF.GetHashCode();
		}
		if (ShopGoodsPrice != 0)
		{
			num ^= ShopGoodsPrice.GetHashCode();
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
		if (Cnt != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Cnt);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BuffId);
		}
		if (FAOIKIDDCFF)
		{
			output.WriteRawTag(104);
			output.WriteBool(FAOIKIDDCFF);
		}
		if (ShopGoodsPrice != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ShopGoodsPrice);
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
		if (Cnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Cnt);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (FAOIKIDDCFF)
		{
			num += 2;
		}
		if (ShopGoodsPrice != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopGoodsPrice);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCFDCEKLBFH other)
	{
		if (other != null)
		{
			if (other.Cnt != 0)
			{
				Cnt = other.Cnt;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.FAOIKIDDCFF)
			{
				FAOIKIDDCFF = other.FAOIKIDDCFF;
			}
			if (other.ShopGoodsPrice != 0)
			{
				ShopGoodsPrice = other.ShopGoodsPrice;
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
			case 72u:
				Cnt = input.ReadUInt32();
				break;
			case 96u:
				BuffId = input.ReadUInt32();
				break;
			case 104u:
				FAOIKIDDCFF = input.ReadBool();
				break;
			case 120u:
				ShopGoodsPrice = input.ReadUInt32();
				break;
			}
		}
	}
}
