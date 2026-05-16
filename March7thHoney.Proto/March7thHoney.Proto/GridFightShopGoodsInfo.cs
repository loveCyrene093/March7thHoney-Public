using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightShopGoodsInfo : IMessage<GridFightShopGoodsInfo>, IMessage, IEquatable<GridFightShopGoodsInfo>, IDeepCloneable<GridFightShopGoodsInfo>, IBufferMessage
{
	public enum FLBCMACPHMJOneofCase
	{
		None = 0,
		SpecialGoodsInfo = 1244,
		RoleGoodsInfo = 1427
	}

	private static readonly MessageParser<GridFightShopGoodsInfo> _parser = new MessageParser<GridFightShopGoodsInfo>(() => new GridFightShopGoodsInfo());

	private UnknownFieldSet _unknownFields;

	public const int ShopGoodsPriceFieldNumber = 1;

	private uint shopGoodsPrice_;

	public const int IsSoldOutFieldNumber = 12;

	private bool isSoldOut_;

	public const int SpecialGoodsInfoFieldNumber = 1244;

	public const int RoleGoodsInfoFieldNumber = 1427;

	private object fLBCMACPHMJ_;

	private FLBCMACPHMJOneofCase fLBCMACPHMJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightShopGoodsInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightShopGoodsInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool IsSoldOut
	{
		get
		{
			return isSoldOut_;
		}
		set
		{
			isSoldOut_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSpecialGoodsInfo SpecialGoodsInfo
	{
		get
		{
			if (fLBCMACPHMJCase_ != FLBCMACPHMJOneofCase.SpecialGoodsInfo)
			{
				return null;
			}
			return (GridFightSpecialGoodsInfo)fLBCMACPHMJ_;
		}
		set
		{
			fLBCMACPHMJ_ = value;
			fLBCMACPHMJCase_ = ((value != null) ? FLBCMACPHMJOneofCase.SpecialGoodsInfo : FLBCMACPHMJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoleGoodsInfo RoleGoodsInfo
	{
		get
		{
			if (fLBCMACPHMJCase_ != FLBCMACPHMJOneofCase.RoleGoodsInfo)
			{
				return null;
			}
			return (GridFightRoleGoodsInfo)fLBCMACPHMJ_;
		}
		set
		{
			fLBCMACPHMJ_ = value;
			fLBCMACPHMJCase_ = ((value != null) ? FLBCMACPHMJOneofCase.RoleGoodsInfo : FLBCMACPHMJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLBCMACPHMJOneofCase FLBCMACPHMJCase => fLBCMACPHMJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopGoodsInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopGoodsInfo(GridFightShopGoodsInfo other)
		: this()
	{
		shopGoodsPrice_ = other.shopGoodsPrice_;
		isSoldOut_ = other.isSoldOut_;
		switch (other.FLBCMACPHMJCase)
		{
		case FLBCMACPHMJOneofCase.SpecialGoodsInfo:
			SpecialGoodsInfo = other.SpecialGoodsInfo.Clone();
			break;
		case FLBCMACPHMJOneofCase.RoleGoodsInfo:
			RoleGoodsInfo = other.RoleGoodsInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopGoodsInfo Clone()
	{
		return new GridFightShopGoodsInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFLBCMACPHMJ()
	{
		fLBCMACPHMJCase_ = FLBCMACPHMJOneofCase.None;
		fLBCMACPHMJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightShopGoodsInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightShopGoodsInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShopGoodsPrice != other.ShopGoodsPrice)
		{
			return false;
		}
		if (IsSoldOut != other.IsSoldOut)
		{
			return false;
		}
		if (!object.Equals(SpecialGoodsInfo, other.SpecialGoodsInfo))
		{
			return false;
		}
		if (!object.Equals(RoleGoodsInfo, other.RoleGoodsInfo))
		{
			return false;
		}
		if (FLBCMACPHMJCase != other.FLBCMACPHMJCase)
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
		if (ShopGoodsPrice != 0)
		{
			num ^= ShopGoodsPrice.GetHashCode();
		}
		if (IsSoldOut)
		{
			num ^= IsSoldOut.GetHashCode();
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.SpecialGoodsInfo)
		{
			num ^= SpecialGoodsInfo.GetHashCode();
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.RoleGoodsInfo)
		{
			num ^= RoleGoodsInfo.GetHashCode();
		}
		num ^= (int)fLBCMACPHMJCase_;
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
		if (ShopGoodsPrice != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ShopGoodsPrice);
		}
		if (IsSoldOut)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsSoldOut);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.SpecialGoodsInfo)
		{
			output.WriteRawTag(226, 77);
			output.WriteMessage(SpecialGoodsInfo);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.RoleGoodsInfo)
		{
			output.WriteRawTag(154, 89);
			output.WriteMessage(RoleGoodsInfo);
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
		if (ShopGoodsPrice != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopGoodsPrice);
		}
		if (IsSoldOut)
		{
			num += 2;
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.SpecialGoodsInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SpecialGoodsInfo);
		}
		if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.RoleGoodsInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoleGoodsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightShopGoodsInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ShopGoodsPrice != 0)
		{
			ShopGoodsPrice = other.ShopGoodsPrice;
		}
		if (other.IsSoldOut)
		{
			IsSoldOut = other.IsSoldOut;
		}
		switch (other.FLBCMACPHMJCase)
		{
		case FLBCMACPHMJOneofCase.SpecialGoodsInfo:
			if (SpecialGoodsInfo == null)
			{
				SpecialGoodsInfo = new GridFightSpecialGoodsInfo();
			}
			SpecialGoodsInfo.MergeFrom(other.SpecialGoodsInfo);
			break;
		case FLBCMACPHMJOneofCase.RoleGoodsInfo:
			if (RoleGoodsInfo == null)
			{
				RoleGoodsInfo = new GridFightRoleGoodsInfo();
			}
			RoleGoodsInfo.MergeFrom(other.RoleGoodsInfo);
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
			case 8u:
				ShopGoodsPrice = input.ReadUInt32();
				break;
			case 96u:
				IsSoldOut = input.ReadBool();
				break;
			case 9954u:
			{
				GridFightSpecialGoodsInfo gridFightSpecialGoodsInfo = new GridFightSpecialGoodsInfo();
				if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.SpecialGoodsInfo)
				{
					gridFightSpecialGoodsInfo.MergeFrom(SpecialGoodsInfo);
				}
				input.ReadMessage(gridFightSpecialGoodsInfo);
				SpecialGoodsInfo = gridFightSpecialGoodsInfo;
				break;
			}
			case 11418u:
			{
				GridFightRoleGoodsInfo gridFightRoleGoodsInfo = new GridFightRoleGoodsInfo();
				if (fLBCMACPHMJCase_ == FLBCMACPHMJOneofCase.RoleGoodsInfo)
				{
					gridFightRoleGoodsInfo.MergeFrom(RoleGoodsInfo);
				}
				input.ReadMessage(gridFightRoleGoodsInfo);
				RoleGoodsInfo = gridFightRoleGoodsInfo;
				break;
			}
			}
		}
	}
}
