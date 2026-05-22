using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightUpgradeEquipActionInfo : IMessage<GridFightUpgradeEquipActionInfo>, IMessage, IEquatable<GridFightUpgradeEquipActionInfo>, IDeepCloneable<GridFightUpgradeEquipActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightUpgradeEquipActionInfo> _parser = new MessageParser<GridFightUpgradeEquipActionInfo>(() => new GridFightUpgradeEquipActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int AvailableEquipmentListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_availableEquipmentList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> availableEquipmentList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightUpgradeEquipActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightUpgradeEquipActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvailableEquipmentList => availableEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpgradeEquipActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpgradeEquipActionInfo(GridFightUpgradeEquipActionInfo other)
		: this()
	{
		availableEquipmentList_ = other.availableEquipmentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpgradeEquipActionInfo Clone()
	{
		return new GridFightUpgradeEquipActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightUpgradeEquipActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightUpgradeEquipActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!availableEquipmentList_.Equals(other.availableEquipmentList_))
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
		num ^= availableEquipmentList_.GetHashCode();
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
		availableEquipmentList_.WriteTo(ref output, _repeated_availableEquipmentList_codec);
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
		num += availableEquipmentList_.CalculateSize(_repeated_availableEquipmentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightUpgradeEquipActionInfo other)
	{
		if (other != null)
		{
			availableEquipmentList_.Add(other.availableEquipmentList_);
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
			if (num != 120 && num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				availableEquipmentList_.AddEntriesFrom(ref input, _repeated_availableEquipmentList_codec);
			}
		}
	}
}
