using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EquipAetherDividePassiveSkillCsReq : IMessage<EquipAetherDividePassiveSkillCsReq>, IMessage, IEquatable<EquipAetherDividePassiveSkillCsReq>, IDeepCloneable<EquipAetherDividePassiveSkillCsReq>, IBufferMessage
{
	private static readonly MessageParser<EquipAetherDividePassiveSkillCsReq> _parser = new MessageParser<EquipAetherDividePassiveSkillCsReq>(() => new EquipAetherDividePassiveSkillCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 1;

	private uint itemId_;

	public const int SlotFieldNumber = 2;

	private uint slot_;

	public const int IMMHJMDHDGCFieldNumber = 3;

	private uint iMMHJMDHDGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipAetherDividePassiveSkillCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipAetherDividePassiveSkillCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMMHJMDHDGC
	{
		get
		{
			return iMMHJMDHDGC_;
		}
		set
		{
			iMMHJMDHDGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipAetherDividePassiveSkillCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipAetherDividePassiveSkillCsReq(EquipAetherDividePassiveSkillCsReq other)
		: this()
	{
		itemId_ = other.itemId_;
		slot_ = other.slot_;
		iMMHJMDHDGC_ = other.iMMHJMDHDGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipAetherDividePassiveSkillCsReq Clone()
	{
		return new EquipAetherDividePassiveSkillCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipAetherDividePassiveSkillCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipAetherDividePassiveSkillCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (Slot != other.Slot)
		{
			return false;
		}
		if (IMMHJMDHDGC != other.IMMHJMDHDGC)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (IMMHJMDHDGC != 0)
		{
			num ^= IMMHJMDHDGC.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ItemId);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Slot);
		}
		if (IMMHJMDHDGC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IMMHJMDHDGC);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (IMMHJMDHDGC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMMHJMDHDGC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipAetherDividePassiveSkillCsReq other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.IMMHJMDHDGC != 0)
			{
				IMMHJMDHDGC = other.IMMHJMDHDGC;
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
				ItemId = input.ReadUInt32();
				break;
			case 16u:
				Slot = input.ReadUInt32();
				break;
			case 24u:
				IMMHJMDHDGC = input.ReadUInt32();
				break;
			}
		}
	}
}
