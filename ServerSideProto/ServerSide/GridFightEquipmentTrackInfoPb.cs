using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEquipmentTrackInfoPb : IMessage<GridFightEquipmentTrackInfoPb>, IMessage, IEquatable<GridFightEquipmentTrackInfoPb>, IDeepCloneable<GridFightEquipmentTrackInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightEquipmentTrackInfoPb> _parser = new MessageParser<GridFightEquipmentTrackInfoPb>(() => new GridFightEquipmentTrackInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int PriorityFieldNumber = 1;

	private uint priority_;

	public const int RoleIdFieldNumber = 2;

	private uint roleId_;

	public const int EquipmentIdsFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_equipmentIds_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> equipmentIds_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEquipmentTrackInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[5];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EquipmentIds => equipmentIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipmentTrackInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipmentTrackInfoPb(GridFightEquipmentTrackInfoPb other)
		: this()
	{
		priority_ = other.priority_;
		roleId_ = other.roleId_;
		equipmentIds_ = other.equipmentIds_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipmentTrackInfoPb Clone()
	{
		return new GridFightEquipmentTrackInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEquipmentTrackInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEquipmentTrackInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Priority != other.Priority)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!equipmentIds_.Equals(other.equipmentIds_))
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
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		num ^= equipmentIds_.GetHashCode();
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
		if (Priority != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Priority);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(RoleId);
		}
		equipmentIds_.WriteTo(ref output, _repeated_equipmentIds_codec);
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
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Priority);
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		num += equipmentIds_.CalculateSize(_repeated_equipmentIds_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEquipmentTrackInfoPb other)
	{
		if (other != null)
		{
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			equipmentIds_.Add(other.equipmentIds_);
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
				Priority = input.ReadUInt32();
				break;
			case 16u:
				RoleId = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				equipmentIds_.AddEntriesFrom(ref input, _repeated_equipmentIds_codec);
				break;
			}
		}
	}
}
