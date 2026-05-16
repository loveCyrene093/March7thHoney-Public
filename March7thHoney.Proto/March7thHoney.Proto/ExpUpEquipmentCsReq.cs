using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExpUpEquipmentCsReq : IMessage<ExpUpEquipmentCsReq>, IMessage, IEquatable<ExpUpEquipmentCsReq>, IDeepCloneable<ExpUpEquipmentCsReq>, IBufferMessage
{
	private static readonly MessageParser<ExpUpEquipmentCsReq> _parser = new MessageParser<ExpUpEquipmentCsReq>(() => new ExpUpEquipmentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EquipmentUniqueIdFieldNumber = 9;

	private uint equipmentUniqueId_;

	public const int CostDataFieldNumber = 10;

	private ItemCostData costData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExpUpEquipmentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ExpUpEquipmentCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EquipmentUniqueId
	{
		get
		{
			return equipmentUniqueId_;
		}
		set
		{
			equipmentUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData CostData
	{
		get
		{
			return costData_;
		}
		set
		{
			costData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExpUpEquipmentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExpUpEquipmentCsReq(ExpUpEquipmentCsReq other)
		: this()
	{
		equipmentUniqueId_ = other.equipmentUniqueId_;
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExpUpEquipmentCsReq Clone()
	{
		return new ExpUpEquipmentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ExpUpEquipmentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExpUpEquipmentCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipmentUniqueId != other.EquipmentUniqueId)
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
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
		if (EquipmentUniqueId != 0)
		{
			num ^= EquipmentUniqueId.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
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
		if (EquipmentUniqueId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EquipmentUniqueId);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(CostData);
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
		if (EquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EquipmentUniqueId);
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExpUpEquipmentCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EquipmentUniqueId != 0)
		{
			EquipmentUniqueId = other.EquipmentUniqueId;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
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
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 72u:
				EquipmentUniqueId = input.ReadUInt32();
				break;
			case 82u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			}
		}
	}
}
