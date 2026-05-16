using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightForgeGoodsInfoPb : IMessage<GridFightForgeGoodsInfoPb>, IMessage, IEquatable<GridFightForgeGoodsInfoPb>, IDeepCloneable<GridFightForgeGoodsInfoPb>, IBufferMessage
{
	public enum GoodsTypeOneofCase
	{
		None,
		ItemId,
		RoleInfo
	}

	private static readonly MessageParser<GridFightForgeGoodsInfoPb> _parser = new MessageParser<GridFightForgeGoodsInfoPb>(() => new GridFightForgeGoodsInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 1;

	public const int RoleInfoFieldNumber = 2;

	private object goodsType_;

	private GoodsTypeOneofCase goodsTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightForgeGoodsInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[9];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			if (!HasItemId)
			{
				return 0u;
			}
			return (uint)goodsType_;
		}
		set
		{
			goodsType_ = value;
			goodsTypeCase_ = GoodsTypeOneofCase.ItemId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasItemId => goodsTypeCase_ == GoodsTypeOneofCase.ItemId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleGoodsInfoPb RoleInfo
	{
		get
		{
			if (goodsTypeCase_ != GoodsTypeOneofCase.RoleInfo)
			{
				return null;
			}
			return (GridFightForgeRoleGoodsInfoPb)goodsType_;
		}
		set
		{
			goodsType_ = value;
			goodsTypeCase_ = ((value != null) ? GoodsTypeOneofCase.RoleInfo : GoodsTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GoodsTypeOneofCase GoodsTypeCase => goodsTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeGoodsInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeGoodsInfoPb(GridFightForgeGoodsInfoPb other)
		: this()
	{
		switch (other.GoodsTypeCase)
		{
		case GoodsTypeOneofCase.ItemId:
			ItemId = other.ItemId;
			break;
		case GoodsTypeOneofCase.RoleInfo:
			RoleInfo = other.RoleInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeGoodsInfoPb Clone()
	{
		return new GridFightForgeGoodsInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearItemId()
	{
		if (HasItemId)
		{
			ClearGoodsType();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGoodsType()
	{
		goodsTypeCase_ = GoodsTypeOneofCase.None;
		goodsType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightForgeGoodsInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightForgeGoodsInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (!object.Equals(RoleInfo, other.RoleInfo))
		{
			return false;
		}
		if (GoodsTypeCase != other.GoodsTypeCase)
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
		if (HasItemId)
		{
			num ^= ItemId.GetHashCode();
		}
		if (goodsTypeCase_ == GoodsTypeOneofCase.RoleInfo)
		{
			num ^= RoleInfo.GetHashCode();
		}
		num ^= (int)goodsTypeCase_;
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
		if (HasItemId)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ItemId);
		}
		if (goodsTypeCase_ == GoodsTypeOneofCase.RoleInfo)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RoleInfo);
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
		if (HasItemId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (goodsTypeCase_ == GoodsTypeOneofCase.RoleInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightForgeGoodsInfoPb other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.GoodsTypeCase)
		{
		case GoodsTypeOneofCase.ItemId:
			ItemId = other.ItemId;
			break;
		case GoodsTypeOneofCase.RoleInfo:
			if (RoleInfo == null)
			{
				RoleInfo = new GridFightForgeRoleGoodsInfoPb();
			}
			RoleInfo.MergeFrom(other.RoleInfo);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				ItemId = input.ReadUInt32();
				break;
			case 18u:
			{
				GridFightForgeRoleGoodsInfoPb gridFightForgeRoleGoodsInfoPb = new GridFightForgeRoleGoodsInfoPb();
				if (goodsTypeCase_ == GoodsTypeOneofCase.RoleInfo)
				{
					gridFightForgeRoleGoodsInfoPb.MergeFrom(RoleInfo);
				}
				input.ReadMessage(gridFightForgeRoleGoodsInfoPb);
				RoleInfo = gridFightForgeRoleGoodsInfoPb;
				break;
			}
			}
		}
	}
}
