using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameItemSyncInfo : IMessage<GridFightGameItemSyncInfo>, IMessage, IEquatable<GridFightGameItemSyncInfo>, IDeepCloneable<GridFightGameItemSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameItemSyncInfo> _parser = new MessageParser<GridFightGameItemSyncInfo>(() => new GridFightGameItemSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridGameForgeItemListFieldNumber = 4;

	private static readonly FieldCodec<GridGameForgeItemInfo> _repeated_gridGameForgeItemList_codec = FieldCodec.ForMessage(34u, GridGameForgeItemInfo.Parser);

	private readonly RepeatedField<GridGameForgeItemInfo> gridGameForgeItemList_ = new RepeatedField<GridGameForgeItemInfo>();

	public const int GridFightEquipmentListFieldNumber = 9;

	private static readonly FieldCodec<GridFightEquipmentInfo> _repeated_gridFightEquipmentList_codec = FieldCodec.ForMessage(74u, GridFightEquipmentInfo.Parser);

	private readonly RepeatedField<GridFightEquipmentInfo> gridFightEquipmentList_ = new RepeatedField<GridFightEquipmentInfo>();

	public const int GridFightConsumableListFieldNumber = 10;

	private static readonly FieldCodec<GridFightConsumableInfo> _repeated_gridFightConsumableList_codec = FieldCodec.ForMessage(82u, GridFightConsumableInfo.Parser);

	private readonly RepeatedField<GridFightConsumableInfo> gridFightConsumableList_ = new RepeatedField<GridFightConsumableInfo>();

	public const int UpdateGridFightConsumableListFieldNumber = 12;

	private static readonly FieldCodec<GridFightConsumableUpdateInfo> _repeated_updateGridFightConsumableList_codec = FieldCodec.ForMessage(98u, GridFightConsumableUpdateInfo.Parser);

	private readonly RepeatedField<GridFightConsumableUpdateInfo> updateGridFightConsumableList_ = new RepeatedField<GridFightConsumableUpdateInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameItemSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameItemSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameForgeItemInfo> GridGameForgeItemList => gridGameForgeItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightEquipmentInfo> GridFightEquipmentList => gridFightEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightConsumableInfo> GridFightConsumableList => gridFightConsumableList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightConsumableUpdateInfo> UpdateGridFightConsumableList => updateGridFightConsumableList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemSyncInfo(GridFightGameItemSyncInfo other)
		: this()
	{
		gridGameForgeItemList_ = other.gridGameForgeItemList_.Clone();
		gridFightEquipmentList_ = other.gridFightEquipmentList_.Clone();
		gridFightConsumableList_ = other.gridFightConsumableList_.Clone();
		updateGridFightConsumableList_ = other.updateGridFightConsumableList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameItemSyncInfo Clone()
	{
		return new GridFightGameItemSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameItemSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameItemSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridGameForgeItemList_.Equals(other.gridGameForgeItemList_))
		{
			return false;
		}
		if (!gridFightEquipmentList_.Equals(other.gridFightEquipmentList_))
		{
			return false;
		}
		if (!gridFightConsumableList_.Equals(other.gridFightConsumableList_))
		{
			return false;
		}
		if (!updateGridFightConsumableList_.Equals(other.updateGridFightConsumableList_))
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
		num ^= gridGameForgeItemList_.GetHashCode();
		num ^= gridFightEquipmentList_.GetHashCode();
		num ^= gridFightConsumableList_.GetHashCode();
		num ^= updateGridFightConsumableList_.GetHashCode();
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
		gridGameForgeItemList_.WriteTo(ref output, _repeated_gridGameForgeItemList_codec);
		gridFightEquipmentList_.WriteTo(ref output, _repeated_gridFightEquipmentList_codec);
		gridFightConsumableList_.WriteTo(ref output, _repeated_gridFightConsumableList_codec);
		updateGridFightConsumableList_.WriteTo(ref output, _repeated_updateGridFightConsumableList_codec);
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
		num += gridGameForgeItemList_.CalculateSize(_repeated_gridGameForgeItemList_codec);
		num += gridFightEquipmentList_.CalculateSize(_repeated_gridFightEquipmentList_codec);
		num += gridFightConsumableList_.CalculateSize(_repeated_gridFightConsumableList_codec);
		num += updateGridFightConsumableList_.CalculateSize(_repeated_updateGridFightConsumableList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameItemSyncInfo other)
	{
		if (other != null)
		{
			gridGameForgeItemList_.Add(other.gridGameForgeItemList_);
			gridFightEquipmentList_.Add(other.gridFightEquipmentList_);
			gridFightConsumableList_.Add(other.gridFightConsumableList_);
			updateGridFightConsumableList_.Add(other.updateGridFightConsumableList_);
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
			case 34u:
				gridGameForgeItemList_.AddEntriesFrom(ref input, _repeated_gridGameForgeItemList_codec);
				break;
			case 74u:
				gridFightEquipmentList_.AddEntriesFrom(ref input, _repeated_gridFightEquipmentList_codec);
				break;
			case 82u:
				gridFightConsumableList_.AddEntriesFrom(ref input, _repeated_gridFightConsumableList_codec);
				break;
			case 98u:
				updateGridFightConsumableList_.AddEntriesFrom(ref input, _repeated_updateGridFightConsumableList_codec);
				break;
			}
		}
	}
}
