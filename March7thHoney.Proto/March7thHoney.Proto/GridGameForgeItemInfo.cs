using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridGameForgeItemInfo : IMessage<GridGameForgeItemInfo>, IMessage, IEquatable<GridGameForgeItemInfo>, IDeepCloneable<GridGameForgeItemInfo>, IBufferMessage
{
	private static readonly MessageParser<GridGameForgeItemInfo> _parser = new MessageParser<GridGameForgeItemInfo>(() => new GridGameForgeItemInfo());

	private UnknownFieldSet _unknownFields;

	public const int ForgeItemIdFieldNumber = 1;

	private uint forgeItemId_;

	public const int ForgeGoodsListFieldNumber = 4;

	private static readonly FieldCodec<GridFightForgeGoodsInfo> _repeated_forgeGoodsList_codec = FieldCodec.ForMessage(34u, GridFightForgeGoodsInfo.Parser);

	private readonly RepeatedField<GridFightForgeGoodsInfo> forgeGoodsList_ = new RepeatedField<GridFightForgeGoodsInfo>();

	public const int PosFieldNumber = 5;

	private uint pos_;

	public const int UniqueIdFieldNumber = 11;

	private uint uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridGameForgeItemInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridGameForgeItemInfoReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<GridFightForgeGoodsInfo> ForgeGoodsList => forgeGoodsList_;

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
	public GridGameForgeItemInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameForgeItemInfo(GridGameForgeItemInfo other)
		: this()
	{
		forgeItemId_ = other.forgeItemId_;
		forgeGoodsList_ = other.forgeGoodsList_.Clone();
		pos_ = other.pos_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameForgeItemInfo Clone()
	{
		return new GridGameForgeItemInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridGameForgeItemInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridGameForgeItemInfo other)
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
		if (!forgeGoodsList_.Equals(other.forgeGoodsList_))
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
		num ^= forgeGoodsList_.GetHashCode();
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
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
		if (ForgeItemId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ForgeItemId);
		}
		forgeGoodsList_.WriteTo(ref output, _repeated_forgeGoodsList_codec);
		if (Pos != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Pos);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(UniqueId);
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
		if (ForgeItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ForgeItemId);
		}
		num += forgeGoodsList_.CalculateSize(_repeated_forgeGoodsList_codec);
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridGameForgeItemInfo other)
	{
		if (other != null)
		{
			if (other.ForgeItemId != 0)
			{
				ForgeItemId = other.ForgeItemId;
			}
			forgeGoodsList_.Add(other.forgeGoodsList_);
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
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
				ForgeItemId = input.ReadUInt32();
				break;
			case 34u:
				forgeGoodsList_.AddEntriesFrom(ref input, _repeated_forgeGoodsList_codec);
				break;
			case 40u:
				Pos = input.ReadUInt32();
				break;
			case 88u:
				UniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
