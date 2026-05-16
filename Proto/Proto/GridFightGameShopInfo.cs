using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameShopInfo : IMessage<GridFightGameShopInfo>, IMessage, IEquatable<GridFightGameShopInfo>, IDeepCloneable<GridFightGameShopInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameShopInfo> _parser = new MessageParser<GridFightGameShopInfo>(() => new GridFightGameShopInfo());

	private UnknownFieldSet _unknownFields;

	public const int NDGMCJHKNINFieldNumber = 1;

	private uint nDGMCJHKNIN_;

	public const int DNOIFMMLJDNFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_dNOIFMMLJDN_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> dNOIFMMLJDN_ = new RepeatedField<uint>();

	public const int GLIFNMBMMBLFieldNumber = 3;

	private uint gLIFNMBMMBL_;

	public const int LDEDGOOKHFLFieldNumber = 4;

	private FJPONJFLOOH lDEDGOOKHFL_;

	public const int ShopIsLockedFieldNumber = 8;

	private bool shopIsLocked_;

	public const int ShopGoodsListFieldNumber = 10;

	private static readonly FieldCodec<GridFightShopGoodsInfo> _repeated_shopGoodsList_codec = FieldCodec.ForMessage(82u, GridFightShopGoodsInfo.Parser);

	private readonly RepeatedField<GridFightShopGoodsInfo> shopGoodsList_ = new RepeatedField<GridFightShopGoodsInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameShopInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameShopInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDGMCJHKNIN
	{
		get
		{
			return nDGMCJHKNIN_;
		}
		set
		{
			nDGMCJHKNIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DNOIFMMLJDN => dNOIFMMLJDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLIFNMBMMBL
	{
		get
		{
			return gLIFNMBMMBL_;
		}
		set
		{
			gLIFNMBMMBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJPONJFLOOH LDEDGOOKHFL
	{
		get
		{
			return lDEDGOOKHFL_;
		}
		set
		{
			lDEDGOOKHFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ShopIsLocked
	{
		get
		{
			return shopIsLocked_;
		}
		set
		{
			shopIsLocked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightShopGoodsInfo> ShopGoodsList => shopGoodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameShopInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameShopInfo(GridFightGameShopInfo other)
		: this()
	{
		nDGMCJHKNIN_ = other.nDGMCJHKNIN_;
		dNOIFMMLJDN_ = other.dNOIFMMLJDN_.Clone();
		gLIFNMBMMBL_ = other.gLIFNMBMMBL_;
		lDEDGOOKHFL_ = ((other.lDEDGOOKHFL_ != null) ? other.lDEDGOOKHFL_.Clone() : null);
		shopIsLocked_ = other.shopIsLocked_;
		shopGoodsList_ = other.shopGoodsList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameShopInfo Clone()
	{
		return new GridFightGameShopInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameShopInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameShopInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NDGMCJHKNIN != other.NDGMCJHKNIN)
		{
			return false;
		}
		if (!dNOIFMMLJDN_.Equals(other.dNOIFMMLJDN_))
		{
			return false;
		}
		if (GLIFNMBMMBL != other.GLIFNMBMMBL)
		{
			return false;
		}
		if (!object.Equals(LDEDGOOKHFL, other.LDEDGOOKHFL))
		{
			return false;
		}
		if (ShopIsLocked != other.ShopIsLocked)
		{
			return false;
		}
		if (!shopGoodsList_.Equals(other.shopGoodsList_))
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
		if (NDGMCJHKNIN != 0)
		{
			num ^= NDGMCJHKNIN.GetHashCode();
		}
		num ^= dNOIFMMLJDN_.GetHashCode();
		if (GLIFNMBMMBL != 0)
		{
			num ^= GLIFNMBMMBL.GetHashCode();
		}
		if (lDEDGOOKHFL_ != null)
		{
			num ^= LDEDGOOKHFL.GetHashCode();
		}
		if (ShopIsLocked)
		{
			num ^= ShopIsLocked.GetHashCode();
		}
		num ^= shopGoodsList_.GetHashCode();
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
		if (NDGMCJHKNIN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NDGMCJHKNIN);
		}
		dNOIFMMLJDN_.WriteTo(ref output, _repeated_dNOIFMMLJDN_codec);
		if (GLIFNMBMMBL != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GLIFNMBMMBL);
		}
		if (lDEDGOOKHFL_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(LDEDGOOKHFL);
		}
		if (ShopIsLocked)
		{
			output.WriteRawTag(64);
			output.WriteBool(ShopIsLocked);
		}
		shopGoodsList_.WriteTo(ref output, _repeated_shopGoodsList_codec);
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
		if (NDGMCJHKNIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDGMCJHKNIN);
		}
		num += dNOIFMMLJDN_.CalculateSize(_repeated_dNOIFMMLJDN_codec);
		if (GLIFNMBMMBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLIFNMBMMBL);
		}
		if (lDEDGOOKHFL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LDEDGOOKHFL);
		}
		if (ShopIsLocked)
		{
			num += 2;
		}
		num += shopGoodsList_.CalculateSize(_repeated_shopGoodsList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameShopInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NDGMCJHKNIN != 0)
		{
			NDGMCJHKNIN = other.NDGMCJHKNIN;
		}
		dNOIFMMLJDN_.Add(other.dNOIFMMLJDN_);
		if (other.GLIFNMBMMBL != 0)
		{
			GLIFNMBMMBL = other.GLIFNMBMMBL;
		}
		if (other.lDEDGOOKHFL_ != null)
		{
			if (lDEDGOOKHFL_ == null)
			{
				LDEDGOOKHFL = new FJPONJFLOOH();
			}
			LDEDGOOKHFL.MergeFrom(other.LDEDGOOKHFL);
		}
		if (other.ShopIsLocked)
		{
			ShopIsLocked = other.ShopIsLocked;
		}
		shopGoodsList_.Add(other.shopGoodsList_);
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
				NDGMCJHKNIN = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				dNOIFMMLJDN_.AddEntriesFrom(ref input, _repeated_dNOIFMMLJDN_codec);
				break;
			case 24u:
				GLIFNMBMMBL = input.ReadUInt32();
				break;
			case 34u:
				if (lDEDGOOKHFL_ == null)
				{
					LDEDGOOKHFL = new FJPONJFLOOH();
				}
				input.ReadMessage(LDEDGOOKHFL);
				break;
			case 64u:
				ShopIsLocked = input.ReadBool();
				break;
			case 82u:
				shopGoodsList_.AddEntriesFrom(ref input, _repeated_shopGoodsList_codec);
				break;
			}
		}
	}
}
