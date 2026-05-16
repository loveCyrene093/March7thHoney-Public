using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightRollTypeTargetInfo : IMessage<GridFightRollTypeTargetInfo>, IMessage, IEquatable<GridFightRollTypeTargetInfo>, IDeepCloneable<GridFightRollTypeTargetInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightRollTypeTargetInfo> _parser = new MessageParser<GridFightRollTypeTargetInfo>(() => new GridFightRollTypeTargetInfo());

	private UnknownFieldSet _unknownFields;

	public const int DressEquipmentUniqueIdFieldNumber = 4;

	private uint dressEquipmentUniqueId_;

	public const int DressRoleUniqueIdFieldNumber = 7;

	private uint dressRoleUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightRollTypeTargetInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightRollTypeTargetInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressEquipmentUniqueId
	{
		get
		{
			return dressEquipmentUniqueId_;
		}
		set
		{
			dressEquipmentUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressRoleUniqueId
	{
		get
		{
			return dressRoleUniqueId_;
		}
		set
		{
			dressRoleUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRollTypeTargetInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRollTypeTargetInfo(GridFightRollTypeTargetInfo other)
		: this()
	{
		dressEquipmentUniqueId_ = other.dressEquipmentUniqueId_;
		dressRoleUniqueId_ = other.dressRoleUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRollTypeTargetInfo Clone()
	{
		return new GridFightRollTypeTargetInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightRollTypeTargetInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightRollTypeTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DressEquipmentUniqueId != other.DressEquipmentUniqueId)
		{
			return false;
		}
		if (DressRoleUniqueId != other.DressRoleUniqueId)
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
		if (DressEquipmentUniqueId != 0)
		{
			num ^= DressEquipmentUniqueId.GetHashCode();
		}
		if (DressRoleUniqueId != 0)
		{
			num ^= DressRoleUniqueId.GetHashCode();
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
		if (DressEquipmentUniqueId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DressEquipmentUniqueId);
		}
		if (DressRoleUniqueId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DressRoleUniqueId);
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
		if (DressEquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressEquipmentUniqueId);
		}
		if (DressRoleUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressRoleUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightRollTypeTargetInfo other)
	{
		if (other != null)
		{
			if (other.DressEquipmentUniqueId != 0)
			{
				DressEquipmentUniqueId = other.DressEquipmentUniqueId;
			}
			if (other.DressRoleUniqueId != 0)
			{
				DressRoleUniqueId = other.DressRoleUniqueId;
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
			case 32u:
				DressEquipmentUniqueId = input.ReadUInt32();
				break;
			case 56u:
				DressRoleUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
