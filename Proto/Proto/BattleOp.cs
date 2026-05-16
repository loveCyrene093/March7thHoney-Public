using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleOp : IMessage<BattleOp>, IMessage, IEquatable<BattleOp>, IDeepCloneable<BattleOp>, IBufferMessage
{
	private static readonly MessageParser<BattleOp> _parser = new MessageParser<BattleOp>(() => new BattleOp());

	private UnknownFieldSet _unknownFields;

	public const int TurnCounterFieldNumber = 1;

	private uint turnCounter_;

	public const int StateFieldNumber = 2;

	private uint state_;

	public const int ActionEntityIdFieldNumber = 3;

	private uint actionEntityId_;

	public const int TargetEntityIdFieldNumber = 4;

	private uint targetEntityId_;

	public const int OpTypeFieldNumber = 5;

	private uint opType_;

	public const int SkillIndexFieldNumber = 6;

	private uint skillIndex_;

	public const int OperationCounterFieldNumber = 7;

	private uint operationCounter_;

	public const int NOPKFBLLAJPFieldNumber = 8;

	private string nOPKFBLLAJP_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleOp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleOpReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TurnCounter
	{
		get
		{
			return turnCounter_;
		}
		set
		{
			turnCounter_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ActionEntityId
	{
		get
		{
			return actionEntityId_;
		}
		set
		{
			actionEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetEntityId
	{
		get
		{
			return targetEntityId_;
		}
		set
		{
			targetEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OpType
	{
		get
		{
			return opType_;
		}
		set
		{
			opType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillIndex
	{
		get
		{
			return skillIndex_;
		}
		set
		{
			skillIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OperationCounter
	{
		get
		{
			return operationCounter_;
		}
		set
		{
			operationCounter_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NOPKFBLLAJP
	{
		get
		{
			return nOPKFBLLAJP_;
		}
		set
		{
			nOPKFBLLAJP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleOp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleOp(BattleOp other)
		: this()
	{
		turnCounter_ = other.turnCounter_;
		state_ = other.state_;
		actionEntityId_ = other.actionEntityId_;
		targetEntityId_ = other.targetEntityId_;
		opType_ = other.opType_;
		skillIndex_ = other.skillIndex_;
		operationCounter_ = other.operationCounter_;
		nOPKFBLLAJP_ = other.nOPKFBLLAJP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleOp Clone()
	{
		return new BattleOp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleOp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleOp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TurnCounter != other.TurnCounter)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (ActionEntityId != other.ActionEntityId)
		{
			return false;
		}
		if (TargetEntityId != other.TargetEntityId)
		{
			return false;
		}
		if (OpType != other.OpType)
		{
			return false;
		}
		if (SkillIndex != other.SkillIndex)
		{
			return false;
		}
		if (OperationCounter != other.OperationCounter)
		{
			return false;
		}
		if (NOPKFBLLAJP != other.NOPKFBLLAJP)
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
		if (TurnCounter != 0)
		{
			num ^= TurnCounter.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		if (ActionEntityId != 0)
		{
			num ^= ActionEntityId.GetHashCode();
		}
		if (TargetEntityId != 0)
		{
			num ^= TargetEntityId.GetHashCode();
		}
		if (OpType != 0)
		{
			num ^= OpType.GetHashCode();
		}
		if (SkillIndex != 0)
		{
			num ^= SkillIndex.GetHashCode();
		}
		if (OperationCounter != 0)
		{
			num ^= OperationCounter.GetHashCode();
		}
		if (NOPKFBLLAJP.Length != 0)
		{
			num ^= NOPKFBLLAJP.GetHashCode();
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
		if (TurnCounter != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TurnCounter);
		}
		if (State != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(State);
		}
		if (ActionEntityId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ActionEntityId);
		}
		if (TargetEntityId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(TargetEntityId);
		}
		if (OpType != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OpType);
		}
		if (SkillIndex != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(SkillIndex);
		}
		if (OperationCounter != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OperationCounter);
		}
		if (NOPKFBLLAJP.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(NOPKFBLLAJP);
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
		if (TurnCounter != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TurnCounter);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(State);
		}
		if (ActionEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ActionEntityId);
		}
		if (TargetEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetEntityId);
		}
		if (OpType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OpType);
		}
		if (SkillIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillIndex);
		}
		if (OperationCounter != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OperationCounter);
		}
		if (NOPKFBLLAJP.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NOPKFBLLAJP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleOp other)
	{
		if (other != null)
		{
			if (other.TurnCounter != 0)
			{
				TurnCounter = other.TurnCounter;
			}
			if (other.State != 0)
			{
				State = other.State;
			}
			if (other.ActionEntityId != 0)
			{
				ActionEntityId = other.ActionEntityId;
			}
			if (other.TargetEntityId != 0)
			{
				TargetEntityId = other.TargetEntityId;
			}
			if (other.OpType != 0)
			{
				OpType = other.OpType;
			}
			if (other.SkillIndex != 0)
			{
				SkillIndex = other.SkillIndex;
			}
			if (other.OperationCounter != 0)
			{
				OperationCounter = other.OperationCounter;
			}
			if (other.NOPKFBLLAJP.Length != 0)
			{
				NOPKFBLLAJP = other.NOPKFBLLAJP;
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
				TurnCounter = input.ReadUInt32();
				break;
			case 16u:
				State = input.ReadUInt32();
				break;
			case 24u:
				ActionEntityId = input.ReadUInt32();
				break;
			case 32u:
				TargetEntityId = input.ReadUInt32();
				break;
			case 40u:
				OpType = input.ReadUInt32();
				break;
			case 48u:
				SkillIndex = input.ReadUInt32();
				break;
			case 56u:
				OperationCounter = input.ReadUInt32();
				break;
			case 66u:
				NOPKFBLLAJP = input.ReadString();
				break;
			}
		}
	}
}
