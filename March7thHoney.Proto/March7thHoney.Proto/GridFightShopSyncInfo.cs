using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightShopSyncInfo : IMessage<GridFightShopSyncInfo>, IMessage, IEquatable<GridFightShopSyncInfo>, IDeepCloneable<GridFightShopSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightShopSyncInfo> _parser = new MessageParser<GridFightShopSyncInfo>(() => new GridFightShopSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int GLIFNMBMMBLFieldNumber = 2;

	private uint gLIFNMBMMBL_;

	public const int ShopGoodsListFieldNumber = 5;

	private static readonly FieldCodec<GridFightShopGoodsInfo> _repeated_shopGoodsList_codec = FieldCodec.ForMessage(42u, GridFightShopGoodsInfo.Parser);

	private readonly RepeatedField<GridFightShopGoodsInfo> shopGoodsList_ = new RepeatedField<GridFightShopGoodsInfo>();

	public const int LDEDGOOKHFLFieldNumber = 10;

	private FJPONJFLOOH lDEDGOOKHFL_;

	public const int NDGMCJHKNINFieldNumber = 11;

	private uint nDGMCJHKNIN_;

	public const int ShopIsLockedFieldNumber = 15;

	private bool shopIsLocked_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightShopSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightShopSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<GridFightShopGoodsInfo> ShopGoodsList => shopGoodsList_;

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
	public GridFightShopSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopSyncInfo(GridFightShopSyncInfo other)
		: this()
	{
		gLIFNMBMMBL_ = other.gLIFNMBMMBL_;
		shopGoodsList_ = other.shopGoodsList_.Clone();
		lDEDGOOKHFL_ = ((other.lDEDGOOKHFL_ != null) ? other.lDEDGOOKHFL_.Clone() : null);
		nDGMCJHKNIN_ = other.nDGMCJHKNIN_;
		shopIsLocked_ = other.shopIsLocked_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightShopSyncInfo Clone()
	{
		return new GridFightShopSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightShopSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightShopSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GLIFNMBMMBL != other.GLIFNMBMMBL)
		{
			return false;
		}
		if (!shopGoodsList_.Equals(other.shopGoodsList_))
		{
			return false;
		}
		if (!object.Equals(LDEDGOOKHFL, other.LDEDGOOKHFL))
		{
			return false;
		}
		if (NDGMCJHKNIN != other.NDGMCJHKNIN)
		{
			return false;
		}
		if (ShopIsLocked != other.ShopIsLocked)
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
		if (GLIFNMBMMBL != 0)
		{
			num ^= GLIFNMBMMBL.GetHashCode();
		}
		num ^= shopGoodsList_.GetHashCode();
		if (lDEDGOOKHFL_ != null)
		{
			num ^= LDEDGOOKHFL.GetHashCode();
		}
		if (NDGMCJHKNIN != 0)
		{
			num ^= NDGMCJHKNIN.GetHashCode();
		}
		if (ShopIsLocked)
		{
			num ^= ShopIsLocked.GetHashCode();
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
		if (GLIFNMBMMBL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GLIFNMBMMBL);
		}
		shopGoodsList_.WriteTo(ref output, _repeated_shopGoodsList_codec);
		if (lDEDGOOKHFL_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LDEDGOOKHFL);
		}
		if (NDGMCJHKNIN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NDGMCJHKNIN);
		}
		if (ShopIsLocked)
		{
			output.WriteRawTag(120);
			output.WriteBool(ShopIsLocked);
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
		if (GLIFNMBMMBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLIFNMBMMBL);
		}
		num += shopGoodsList_.CalculateSize(_repeated_shopGoodsList_codec);
		if (lDEDGOOKHFL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LDEDGOOKHFL);
		}
		if (NDGMCJHKNIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDGMCJHKNIN);
		}
		if (ShopIsLocked)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightShopSyncInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GLIFNMBMMBL != 0)
		{
			GLIFNMBMMBL = other.GLIFNMBMMBL;
		}
		shopGoodsList_.Add(other.shopGoodsList_);
		if (other.lDEDGOOKHFL_ != null)
		{
			if (lDEDGOOKHFL_ == null)
			{
				LDEDGOOKHFL = new FJPONJFLOOH();
			}
			LDEDGOOKHFL.MergeFrom(other.LDEDGOOKHFL);
		}
		if (other.NDGMCJHKNIN != 0)
		{
			NDGMCJHKNIN = other.NDGMCJHKNIN;
		}
		if (other.ShopIsLocked)
		{
			ShopIsLocked = other.ShopIsLocked;
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
			case 16u:
				GLIFNMBMMBL = input.ReadUInt32();
				break;
			case 42u:
				shopGoodsList_.AddEntriesFrom(ref input, _repeated_shopGoodsList_codec);
				break;
			case 82u:
				if (lDEDGOOKHFL_ == null)
				{
					LDEDGOOKHFL = new FJPONJFLOOH();
				}
				input.ReadMessage(LDEDGOOKHFL);
				break;
			case 88u:
				NDGMCJHKNIN = input.ReadUInt32();
				break;
			case 120u:
				ShopIsLocked = input.ReadBool();
				break;
			}
		}
	}
}
