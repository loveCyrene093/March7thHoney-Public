using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicScepterDressInUnitCsReq : IMessage<RogueMagicScepterDressInUnitCsReq>, IMessage, IEquatable<RogueMagicScepterDressInUnitCsReq>, IDeepCloneable<RogueMagicScepterDressInUnitCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicScepterDressInUnitCsReq> _parser = new MessageParser<RogueMagicScepterDressInUnitCsReq>(() => new RogueMagicScepterDressInUnitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DiceSlotIdFieldNumber = 2;

	private uint diceSlotId_;

	public const int NCHHOPJJDCEFieldNumber = 12;

	private uint nCHHOPJJDCE_;

	public const int DOAOPBBIGPOFieldNumber = 13;

	private uint dOAOPBBIGPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicScepterDressInUnitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicScepterDressInUnitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiceSlotId
	{
		get
		{
			return diceSlotId_;
		}
		set
		{
			diceSlotId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCHHOPJJDCE
	{
		get
		{
			return nCHHOPJJDCE_;
		}
		set
		{
			nCHHOPJJDCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAOPBBIGPO
	{
		get
		{
			return dOAOPBBIGPO_;
		}
		set
		{
			dOAOPBBIGPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicScepterDressInUnitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicScepterDressInUnitCsReq(RogueMagicScepterDressInUnitCsReq other)
		: this()
	{
		diceSlotId_ = other.diceSlotId_;
		nCHHOPJJDCE_ = other.nCHHOPJJDCE_;
		dOAOPBBIGPO_ = other.dOAOPBBIGPO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicScepterDressInUnitCsReq Clone()
	{
		return new RogueMagicScepterDressInUnitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicScepterDressInUnitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicScepterDressInUnitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (NCHHOPJJDCE != other.NCHHOPJJDCE)
		{
			return false;
		}
		if (DOAOPBBIGPO != other.DOAOPBBIGPO)
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
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (NCHHOPJJDCE != 0)
		{
			num ^= NCHHOPJJDCE.GetHashCode();
		}
		if (DOAOPBBIGPO != 0)
		{
			num ^= DOAOPBBIGPO.GetHashCode();
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
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DiceSlotId);
		}
		if (NCHHOPJJDCE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NCHHOPJJDCE);
		}
		if (DOAOPBBIGPO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DOAOPBBIGPO);
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
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (NCHHOPJJDCE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCHHOPJJDCE);
		}
		if (DOAOPBBIGPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOAOPBBIGPO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicScepterDressInUnitCsReq other)
	{
		if (other != null)
		{
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.NCHHOPJJDCE != 0)
			{
				NCHHOPJJDCE = other.NCHHOPJJDCE;
			}
			if (other.DOAOPBBIGPO != 0)
			{
				DOAOPBBIGPO = other.DOAOPBBIGPO;
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
				DiceSlotId = input.ReadUInt32();
				break;
			case 96u:
				NCHHOPJJDCE = input.ReadUInt32();
				break;
			case 104u:
				DOAOPBBIGPO = input.ReadUInt32();
				break;
			}
		}
	}
}
