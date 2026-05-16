using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildDiyCsReq : IMessage<TrainPartyBuildDiyCsReq>, IMessage, IEquatable<TrainPartyBuildDiyCsReq>, IDeepCloneable<TrainPartyBuildDiyCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildDiyCsReq> _parser = new MessageParser<TrainPartyBuildDiyCsReq>(() => new TrainPartyBuildDiyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DiceSlotIdFieldNumber = 2;

	private uint diceSlotId_;

	public const int AreaIdFieldNumber = 10;

	private uint areaId_;

	public const int DiyDynamicIdFieldNumber = 11;

	private uint diyDynamicId_;

	public const int AFGNLDIMBGBFieldNumber = 12;

	private bool aFGNLDIMBGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildDiyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildDiyCsReqReflection.Descriptor.MessageTypes[0];

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
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiyDynamicId
	{
		get
		{
			return diyDynamicId_;
		}
		set
		{
			diyDynamicId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AFGNLDIMBGB
	{
		get
		{
			return aFGNLDIMBGB_;
		}
		set
		{
			aFGNLDIMBGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildDiyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildDiyCsReq(TrainPartyBuildDiyCsReq other)
		: this()
	{
		diceSlotId_ = other.diceSlotId_;
		areaId_ = other.areaId_;
		diyDynamicId_ = other.diyDynamicId_;
		aFGNLDIMBGB_ = other.aFGNLDIMBGB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildDiyCsReq Clone()
	{
		return new TrainPartyBuildDiyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildDiyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildDiyCsReq other)
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
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (DiyDynamicId != other.DiyDynamicId)
		{
			return false;
		}
		if (AFGNLDIMBGB != other.AFGNLDIMBGB)
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (DiyDynamicId != 0)
		{
			num ^= DiyDynamicId.GetHashCode();
		}
		if (AFGNLDIMBGB)
		{
			num ^= AFGNLDIMBGB.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AreaId);
		}
		if (DiyDynamicId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DiyDynamicId);
		}
		if (AFGNLDIMBGB)
		{
			output.WriteRawTag(96);
			output.WriteBool(AFGNLDIMBGB);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (DiyDynamicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiyDynamicId);
		}
		if (AFGNLDIMBGB)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildDiyCsReq other)
	{
		if (other != null)
		{
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.DiyDynamicId != 0)
			{
				DiyDynamicId = other.DiyDynamicId;
			}
			if (other.AFGNLDIMBGB)
			{
				AFGNLDIMBGB = other.AFGNLDIMBGB;
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
			case 80u:
				AreaId = input.ReadUInt32();
				break;
			case 88u:
				DiyDynamicId = input.ReadUInt32();
				break;
			case 96u:
				AFGNLDIMBGB = input.ReadBool();
				break;
			}
		}
	}
}
