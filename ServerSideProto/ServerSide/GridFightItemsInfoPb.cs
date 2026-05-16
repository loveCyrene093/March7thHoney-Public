using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightItemsInfoPb : IMessage<GridFightItemsInfoPb>, IMessage, IEquatable<GridFightItemsInfoPb>, IDeepCloneable<GridFightItemsInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightItemsInfoPb> _parser = new MessageParser<GridFightItemsInfoPb>(() => new GridFightItemsInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int EquipmentItemsFieldNumber = 1;

	private static readonly FieldCodec<GridFightEquipmentItemPb> _repeated_equipmentItems_codec = FieldCodec.ForMessage(10u, GridFightEquipmentItemPb.Parser);

	private readonly RepeatedField<GridFightEquipmentItemPb> equipmentItems_ = new RepeatedField<GridFightEquipmentItemPb>();

	public const int ConsumableItemsFieldNumber = 2;

	private static readonly FieldCodec<GridFightConsumableItemPb> _repeated_consumableItems_codec = FieldCodec.ForMessage(18u, GridFightConsumableItemPb.Parser);

	private readonly RepeatedField<GridFightConsumableItemPb> consumableItems_ = new RepeatedField<GridFightConsumableItemPb>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightItemsInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[21];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightEquipmentItemPb> EquipmentItems => equipmentItems_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightConsumableItemPb> ConsumableItems => consumableItems_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightItemsInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightItemsInfoPb(GridFightItemsInfoPb other)
		: this()
	{
		equipmentItems_ = other.equipmentItems_.Clone();
		consumableItems_ = other.consumableItems_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightItemsInfoPb Clone()
	{
		return new GridFightItemsInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightItemsInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightItemsInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!equipmentItems_.Equals(other.equipmentItems_))
		{
			return false;
		}
		if (!consumableItems_.Equals(other.consumableItems_))
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
		num ^= equipmentItems_.GetHashCode();
		num ^= consumableItems_.GetHashCode();
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
		equipmentItems_.WriteTo(ref output, _repeated_equipmentItems_codec);
		consumableItems_.WriteTo(ref output, _repeated_consumableItems_codec);
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
		num += equipmentItems_.CalculateSize(_repeated_equipmentItems_codec);
		num += consumableItems_.CalculateSize(_repeated_consumableItems_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightItemsInfoPb other)
	{
		if (other != null)
		{
			equipmentItems_.Add(other.equipmentItems_);
			consumableItems_.Add(other.consumableItems_);
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
			case 10u:
				equipmentItems_.AddEntriesFrom(ref input, _repeated_equipmentItems_codec);
				break;
			case 18u:
				consumableItems_.AddEntriesFrom(ref input, _repeated_consumableItems_codec);
				break;
			}
		}
	}
}
