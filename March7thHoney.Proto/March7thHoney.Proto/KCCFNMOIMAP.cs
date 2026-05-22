using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KCCFNMOIMAP : IMessage<KCCFNMOIMAP>, IMessage, IEquatable<KCCFNMOIMAP>, IDeepCloneable<KCCFNMOIMAP>, IBufferMessage
{
	private static readonly MessageParser<KCCFNMOIMAP> _parser = new MessageParser<KCCFNMOIMAP>(() => new KCCFNMOIMAP());

	private UnknownFieldSet _unknownFields;

	public const int CostDataFieldNumber = 6;

	private ItemCostData costData_;

	public const int EquipmentUniqueIdFieldNumber = 10;

	private uint equipmentUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KCCFNMOIMAP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KCCFNMOIMAPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public KCCFNMOIMAP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCCFNMOIMAP(KCCFNMOIMAP other)
		: this()
	{
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		equipmentUniqueId_ = other.equipmentUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCCFNMOIMAP Clone()
	{
		return new KCCFNMOIMAP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KCCFNMOIMAP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KCCFNMOIMAP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (EquipmentUniqueId != other.EquipmentUniqueId)
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
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (EquipmentUniqueId != 0)
		{
			num ^= EquipmentUniqueId.GetHashCode();
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
		if (costData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CostData);
		}
		if (EquipmentUniqueId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EquipmentUniqueId);
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
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (EquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EquipmentUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KCCFNMOIMAP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.EquipmentUniqueId != 0)
		{
			EquipmentUniqueId = other.EquipmentUniqueId;
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
			case 50u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 80u:
				EquipmentUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
