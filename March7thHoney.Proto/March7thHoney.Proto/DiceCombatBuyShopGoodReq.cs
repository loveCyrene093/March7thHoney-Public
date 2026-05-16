using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiceCombatBuyShopGoodReq : IMessage<DiceCombatBuyShopGoodReq>, IMessage, IEquatable<DiceCombatBuyShopGoodReq>, IDeepCloneable<DiceCombatBuyShopGoodReq>, IBufferMessage
{
	private static readonly MessageParser<DiceCombatBuyShopGoodReq> _parser = new MessageParser<DiceCombatBuyShopGoodReq>(() => new DiceCombatBuyShopGoodReq());

	private UnknownFieldSet _unknownFields;

	public const int ShopIdFieldNumber = 7;

	private uint shopId_;

	public const int PIMJEDELOHNFieldNumber = 8;

	private uint pIMJEDELOHN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiceCombatBuyShopGoodReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DiceCombatBuyShopGoodReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint PIMJEDELOHN
	{
		get
		{
			return pIMJEDELOHN_;
		}
		set
		{
			pIMJEDELOHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatBuyShopGoodReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatBuyShopGoodReq(DiceCombatBuyShopGoodReq other)
		: this()
	{
		shopId_ = other.shopId_;
		pIMJEDELOHN_ = other.pIMJEDELOHN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatBuyShopGoodReq Clone()
	{
		return new DiceCombatBuyShopGoodReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DiceCombatBuyShopGoodReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiceCombatBuyShopGoodReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShopId != other.ShopId)
		{
			return false;
		}
		if (PIMJEDELOHN != other.PIMJEDELOHN)
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
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		if (PIMJEDELOHN != 0)
		{
			num ^= PIMJEDELOHN.GetHashCode();
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
		if (ShopId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ShopId);
		}
		if (PIMJEDELOHN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PIMJEDELOHN);
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
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopId);
		}
		if (PIMJEDELOHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PIMJEDELOHN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DiceCombatBuyShopGoodReq other)
	{
		if (other != null)
		{
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			if (other.PIMJEDELOHN != 0)
			{
				PIMJEDELOHN = other.PIMJEDELOHN;
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
			case 56u:
				ShopId = input.ReadUInt32();
				break;
			case 64u:
				PIMJEDELOHN = input.ReadUInt32();
				break;
			}
		}
	}
}
