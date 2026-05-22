using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameItemsInfo : IMessage<GridFightGameItemsInfo>, IMessage, IEquatable<GridFightGameItemsInfo>, IDeepCloneable<GridFightGameItemsInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameItemsInfo> _parser = new MessageParser<GridFightGameItemsInfo>(() => new GridFightGameItemsInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightEquipmentListFieldNumber = 2;

	private static readonly FieldCodec<GridFightEquipmentInfo> _repeated_gridFightEquipmentList_codec = FieldCodec.ForMessage(18u, GridFightEquipmentInfo.Parser);

	private readonly RepeatedField<GridFightEquipmentInfo> gridFightEquipmentList_ = new RepeatedField<GridFightEquipmentInfo>();

	public const int GridGameForgeItemListFieldNumber = 7;

	private static readonly FieldCodec<GridGameForgeItemInfo> _repeated_gridGameForgeItemList_codec = FieldCodec.ForMessage(58u, GridGameForgeItemInfo.Parser);

	private readonly RepeatedField<GridGameForgeItemInfo> gridGameForgeItemList_ = new RepeatedField<GridGameForgeItemInfo>();

	public const int GridFightConsumableListFieldNumber = 9;

	private static readonly FieldCodec<GridFightConsumableInfo> _repeated_gridFightConsumableList_codec = FieldCodec.ForMessage(74u, GridFightConsumableInfo.Parser);

	private readonly RepeatedField<GridFightConsumableInfo> gridFightConsumableList_ = new RepeatedField<GridFightConsumableInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameItemsInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameItemsInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightEquipmentInfo> GridFightEquipmentList => gridFightEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameForgeItemInfo> GridGameForgeItemList => gridGameForgeItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightConsumableInfo> GridFightConsumableList => gridFightConsumableList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemsInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemsInfo(GridFightGameItemsInfo other)
		: this()
	{
		gridFightEquipmentList_ = other.gridFightEquipmentList_.Clone();
		gridGameForgeItemList_ = other.gridGameForgeItemList_.Clone();
		gridFightConsumableList_ = other.gridFightConsumableList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemsInfo Clone()
	{
		return new GridFightGameItemsInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameItemsInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameItemsInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightEquipmentList_.Equals(other.gridFightEquipmentList_))
		{
			return false;
		}
		if (!gridGameForgeItemList_.Equals(other.gridGameForgeItemList_))
		{
			return false;
		}
		if (!gridFightConsumableList_.Equals(other.gridFightConsumableList_))
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
		num ^= gridFightEquipmentList_.GetHashCode();
		num ^= gridGameForgeItemList_.GetHashCode();
		num ^= gridFightConsumableList_.GetHashCode();
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
		gridFightEquipmentList_.WriteTo(ref output, _repeated_gridFightEquipmentList_codec);
		gridGameForgeItemList_.WriteTo(ref output, _repeated_gridGameForgeItemList_codec);
		gridFightConsumableList_.WriteTo(ref output, _repeated_gridFightConsumableList_codec);
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
		num += gridFightEquipmentList_.CalculateSize(_repeated_gridFightEquipmentList_codec);
		num += gridGameForgeItemList_.CalculateSize(_repeated_gridGameForgeItemList_codec);
		num += gridFightConsumableList_.CalculateSize(_repeated_gridFightConsumableList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameItemsInfo other)
	{
		if (other != null)
		{
			gridFightEquipmentList_.Add(other.gridFightEquipmentList_);
			gridGameForgeItemList_.Add(other.gridGameForgeItemList_);
			gridFightConsumableList_.Add(other.gridFightConsumableList_);
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
			case 18u:
				gridFightEquipmentList_.AddEntriesFrom(ref input, _repeated_gridFightEquipmentList_codec);
				break;
			case 58u:
				gridGameForgeItemList_.AddEntriesFrom(ref input, _repeated_gridGameForgeItemList_codec);
				break;
			case 74u:
				gridFightConsumableList_.AddEntriesFrom(ref input, _repeated_gridFightConsumableList_codec);
				break;
			}
		}
	}
}
