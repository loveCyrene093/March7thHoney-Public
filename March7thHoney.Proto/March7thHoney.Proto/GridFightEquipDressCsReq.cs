using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEquipDressCsReq : IMessage<GridFightEquipDressCsReq>, IMessage, IEquatable<GridFightEquipDressCsReq>, IDeepCloneable<GridFightEquipDressCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightEquipDressCsReq> _parser = new MessageParser<GridFightEquipDressCsReq>(() => new GridFightEquipDressCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DressRoleUniqueIdFieldNumber = 2;

	private uint dressRoleUniqueId_;

	public const int DressSourceFieldNumber = 5;

	private GridFightEquipDressSource dressSource_;

	public const int DressEquipmentUniqueIdFieldNumber = 9;

	private uint dressEquipmentUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEquipDressCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightEquipDressCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GridFightEquipDressSource DressSource
	{
		get
		{
			return dressSource_;
		}
		set
		{
			dressSource_ = value;
		}
	}

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
	public GridFightEquipDressCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipDressCsReq(GridFightEquipDressCsReq other)
		: this()
	{
		dressRoleUniqueId_ = other.dressRoleUniqueId_;
		dressSource_ = other.dressSource_;
		dressEquipmentUniqueId_ = other.dressEquipmentUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipDressCsReq Clone()
	{
		return new GridFightEquipDressCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEquipDressCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEquipDressCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DressRoleUniqueId != other.DressRoleUniqueId)
		{
			return false;
		}
		if (DressSource != other.DressSource)
		{
			return false;
		}
		if (DressEquipmentUniqueId != other.DressEquipmentUniqueId)
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
		if (DressRoleUniqueId != 0)
		{
			num ^= DressRoleUniqueId.GetHashCode();
		}
		if (DressSource != GridFightEquipDressSource.BljjdjodahhFllipkcmfhh)
		{
			num ^= DressSource.GetHashCode();
		}
		if (DressEquipmentUniqueId != 0)
		{
			num ^= DressEquipmentUniqueId.GetHashCode();
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
		if (DressRoleUniqueId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DressRoleUniqueId);
		}
		if (DressSource != GridFightEquipDressSource.BljjdjodahhFllipkcmfhh)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)DressSource);
		}
		if (DressEquipmentUniqueId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DressEquipmentUniqueId);
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
		if (DressRoleUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressRoleUniqueId);
		}
		if (DressSource != GridFightEquipDressSource.BljjdjodahhFllipkcmfhh)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DressSource);
		}
		if (DressEquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressEquipmentUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEquipDressCsReq other)
	{
		if (other != null)
		{
			if (other.DressRoleUniqueId != 0)
			{
				DressRoleUniqueId = other.DressRoleUniqueId;
			}
			if (other.DressSource != GridFightEquipDressSource.BljjdjodahhFllipkcmfhh)
			{
				DressSource = other.DressSource;
			}
			if (other.DressEquipmentUniqueId != 0)
			{
				DressEquipmentUniqueId = other.DressEquipmentUniqueId;
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
			case 16u:
				DressRoleUniqueId = input.ReadUInt32();
				break;
			case 40u:
				DressSource = (GridFightEquipDressSource)input.ReadEnum();
				break;
			case 72u:
				DressEquipmentUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
