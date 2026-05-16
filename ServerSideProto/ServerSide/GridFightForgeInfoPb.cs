using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightForgeInfoPb : IMessage<GridFightForgeInfoPb>, IMessage, IEquatable<GridFightForgeInfoPb>, IDeepCloneable<GridFightForgeInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightForgeInfoPb> _parser = new MessageParser<GridFightForgeInfoPb>(() => new GridFightForgeInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int ForgeItemIdFieldNumber = 1;

	private uint forgeItemId_;

	public const int PosFieldNumber = 2;

	private uint pos_;

	public const int UniqueIdFieldNumber = 3;

	private uint uniqueId_;

	public const int GoodsFieldNumber = 4;

	private static readonly FieldCodec<GridFightForgeGoodsInfoPb> _repeated_goods_codec = FieldCodec.ForMessage(34u, GridFightForgeGoodsInfoPb.Parser);

	private readonly RepeatedField<GridFightForgeGoodsInfoPb> goods_ = new RepeatedField<GridFightForgeGoodsInfoPb>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightForgeInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[8];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ForgeItemId
	{
		get
		{
			return forgeItemId_;
		}
		set
		{
			forgeItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightForgeGoodsInfoPb> Goods => goods_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeInfoPb(GridFightForgeInfoPb other)
		: this()
	{
		forgeItemId_ = other.forgeItemId_;
		pos_ = other.pos_;
		uniqueId_ = other.uniqueId_;
		goods_ = other.goods_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeInfoPb Clone()
	{
		return new GridFightForgeInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightForgeInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightForgeInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ForgeItemId != other.ForgeItemId)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!goods_.Equals(other.goods_))
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
		if (ForgeItemId != 0)
		{
			num ^= ForgeItemId.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= goods_.GetHashCode();
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
		if (ForgeItemId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ForgeItemId);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Pos);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(UniqueId);
		}
		goods_.WriteTo(ref output, _repeated_goods_codec);
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
		if (ForgeItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ForgeItemId);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += goods_.CalculateSize(_repeated_goods_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightForgeInfoPb other)
	{
		if (other != null)
		{
			if (other.ForgeItemId != 0)
			{
				ForgeItemId = other.ForgeItemId;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			goods_.Add(other.goods_);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				ForgeItemId = input.ReadUInt32();
				break;
			case 16u:
				Pos = input.ReadUInt32();
				break;
			case 24u:
				UniqueId = input.ReadUInt32();
				break;
			case 34u:
				goods_.AddEntriesFrom(ref input, _repeated_goods_codec);
				break;
			}
		}
	}
}
