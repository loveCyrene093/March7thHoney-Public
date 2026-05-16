using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantBuyShopItemCsReq : IMessage<ElfRestaurantBuyShopItemCsReq>, IMessage, IEquatable<ElfRestaurantBuyShopItemCsReq>, IDeepCloneable<ElfRestaurantBuyShopItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantBuyShopItemCsReq> _parser = new MessageParser<ElfRestaurantBuyShopItemCsReq>(() => new ElfRestaurantBuyShopItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NGBNIPEMHMDFieldNumber = 1;

	private uint nGBNIPEMHMD_;

	public const int MOKBJPGBGABFieldNumber = 15;

	private uint mOKBJPGBGAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantBuyShopItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantBuyShopItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGBNIPEMHMD
	{
		get
		{
			return nGBNIPEMHMD_;
		}
		set
		{
			nGBNIPEMHMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOKBJPGBGAB
	{
		get
		{
			return mOKBJPGBGAB_;
		}
		set
		{
			mOKBJPGBGAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantBuyShopItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantBuyShopItemCsReq(ElfRestaurantBuyShopItemCsReq other)
		: this()
	{
		nGBNIPEMHMD_ = other.nGBNIPEMHMD_;
		mOKBJPGBGAB_ = other.mOKBJPGBGAB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantBuyShopItemCsReq Clone()
	{
		return new ElfRestaurantBuyShopItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantBuyShopItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantBuyShopItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NGBNIPEMHMD != other.NGBNIPEMHMD)
		{
			return false;
		}
		if (MOKBJPGBGAB != other.MOKBJPGBGAB)
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
		if (NGBNIPEMHMD != 0)
		{
			num ^= NGBNIPEMHMD.GetHashCode();
		}
		if (MOKBJPGBGAB != 0)
		{
			num ^= MOKBJPGBGAB.GetHashCode();
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
		if (NGBNIPEMHMD != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NGBNIPEMHMD);
		}
		if (MOKBJPGBGAB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MOKBJPGBGAB);
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
		if (NGBNIPEMHMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGBNIPEMHMD);
		}
		if (MOKBJPGBGAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOKBJPGBGAB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantBuyShopItemCsReq other)
	{
		if (other != null)
		{
			if (other.NGBNIPEMHMD != 0)
			{
				NGBNIPEMHMD = other.NGBNIPEMHMD;
			}
			if (other.MOKBJPGBGAB != 0)
			{
				MOKBJPGBGAB = other.MOKBJPGBGAB;
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
				NGBNIPEMHMD = input.ReadUInt32();
				break;
			case 120u:
				MOKBJPGBGAB = input.ReadUInt32();
				break;
			}
		}
	}
}
