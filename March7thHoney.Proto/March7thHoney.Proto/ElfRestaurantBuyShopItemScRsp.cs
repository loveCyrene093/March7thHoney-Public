using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantBuyShopItemScRsp : IMessage<ElfRestaurantBuyShopItemScRsp>, IMessage, IEquatable<ElfRestaurantBuyShopItemScRsp>, IDeepCloneable<ElfRestaurantBuyShopItemScRsp>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantBuyShopItemScRsp> _parser = new MessageParser<ElfRestaurantBuyShopItemScRsp>(() => new ElfRestaurantBuyShopItemScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KBEFKONPKGJFieldNumber = 1;

	private ItemCostData kBEFKONPKGJ_;

	public const int NGBNIPEMHMDFieldNumber = 2;

	private uint nGBNIPEMHMD_;

	public const int PPMAFCBNAJFFieldNumber = 4;

	private ItemList pPMAFCBNAJF_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantBuyShopItemScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantBuyShopItemScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData KBEFKONPKGJ
	{
		get
		{
			return kBEFKONPKGJ_;
		}
		set
		{
			kBEFKONPKGJ_ = value;
		}
	}

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
	public ItemList PPMAFCBNAJF
	{
		get
		{
			return pPMAFCBNAJF_;
		}
		set
		{
			pPMAFCBNAJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantBuyShopItemScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantBuyShopItemScRsp(ElfRestaurantBuyShopItemScRsp other)
		: this()
	{
		kBEFKONPKGJ_ = ((other.kBEFKONPKGJ_ != null) ? other.kBEFKONPKGJ_.Clone() : null);
		nGBNIPEMHMD_ = other.nGBNIPEMHMD_;
		pPMAFCBNAJF_ = ((other.pPMAFCBNAJF_ != null) ? other.pPMAFCBNAJF_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantBuyShopItemScRsp Clone()
	{
		return new ElfRestaurantBuyShopItemScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantBuyShopItemScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantBuyShopItemScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KBEFKONPKGJ, other.KBEFKONPKGJ))
		{
			return false;
		}
		if (NGBNIPEMHMD != other.NGBNIPEMHMD)
		{
			return false;
		}
		if (!object.Equals(PPMAFCBNAJF, other.PPMAFCBNAJF))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (kBEFKONPKGJ_ != null)
		{
			num ^= KBEFKONPKGJ.GetHashCode();
		}
		if (NGBNIPEMHMD != 0)
		{
			num ^= NGBNIPEMHMD.GetHashCode();
		}
		if (pPMAFCBNAJF_ != null)
		{
			num ^= PPMAFCBNAJF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (kBEFKONPKGJ_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(KBEFKONPKGJ);
		}
		if (NGBNIPEMHMD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NGBNIPEMHMD);
		}
		if (pPMAFCBNAJF_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PPMAFCBNAJF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
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
		if (kBEFKONPKGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBEFKONPKGJ);
		}
		if (NGBNIPEMHMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGBNIPEMHMD);
		}
		if (pPMAFCBNAJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPMAFCBNAJF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantBuyShopItemScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kBEFKONPKGJ_ != null)
		{
			if (kBEFKONPKGJ_ == null)
			{
				KBEFKONPKGJ = new ItemCostData();
			}
			KBEFKONPKGJ.MergeFrom(other.KBEFKONPKGJ);
		}
		if (other.NGBNIPEMHMD != 0)
		{
			NGBNIPEMHMD = other.NGBNIPEMHMD;
		}
		if (other.pPMAFCBNAJF_ != null)
		{
			if (pPMAFCBNAJF_ == null)
			{
				PPMAFCBNAJF = new ItemList();
			}
			PPMAFCBNAJF.MergeFrom(other.PPMAFCBNAJF);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 10u:
				if (kBEFKONPKGJ_ == null)
				{
					KBEFKONPKGJ = new ItemCostData();
				}
				input.ReadMessage(KBEFKONPKGJ);
				break;
			case 16u:
				NGBNIPEMHMD = input.ReadUInt32();
				break;
			case 34u:
				if (pPMAFCBNAJF_ == null)
				{
					PPMAFCBNAJF = new ItemList();
				}
				input.ReadMessage(PPMAFCBNAJF);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
