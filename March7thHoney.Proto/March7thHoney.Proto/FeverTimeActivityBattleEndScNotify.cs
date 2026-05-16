using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FeverTimeActivityBattleEndScNotify : IMessage<FeverTimeActivityBattleEndScNotify>, IMessage, IEquatable<FeverTimeActivityBattleEndScNotify>, IDeepCloneable<FeverTimeActivityBattleEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<FeverTimeActivityBattleEndScNotify> _parser = new MessageParser<FeverTimeActivityBattleEndScNotify>(() => new FeverTimeActivityBattleEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KIKCDKLKCPCFieldNumber = 5;

	private FeverTimeBattleRank kIKCDKLKCPC_;

	public const int IdFieldNumber = 11;

	private uint id_;

	public const int PKPIOIJPPBLFieldNumber = 12;

	private uint pKPIOIJPPBL_;

	public const int TurnLeftFieldNumber = 13;

	private uint turnLeft_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FeverTimeActivityBattleEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FeverTimeActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeverTimeBattleRank KIKCDKLKCPC
	{
		get
		{
			return kIKCDKLKCPC_;
		}
		set
		{
			kIKCDKLKCPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKPIOIJPPBL
	{
		get
		{
			return pKPIOIJPPBL_;
		}
		set
		{
			pKPIOIJPPBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TurnLeft
	{
		get
		{
			return turnLeft_;
		}
		set
		{
			turnLeft_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeverTimeActivityBattleEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeverTimeActivityBattleEndScNotify(FeverTimeActivityBattleEndScNotify other)
		: this()
	{
		kIKCDKLKCPC_ = other.kIKCDKLKCPC_;
		id_ = other.id_;
		pKPIOIJPPBL_ = other.pKPIOIJPPBL_;
		turnLeft_ = other.turnLeft_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeverTimeActivityBattleEndScNotify Clone()
	{
		return new FeverTimeActivityBattleEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FeverTimeActivityBattleEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FeverTimeActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KIKCDKLKCPC != other.KIKCDKLKCPC)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (PKPIOIJPPBL != other.PKPIOIJPPBL)
		{
			return false;
		}
		if (TurnLeft != other.TurnLeft)
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
		if (KIKCDKLKCPC != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
		{
			num ^= KIKCDKLKCPC.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PKPIOIJPPBL != 0)
		{
			num ^= PKPIOIJPPBL.GetHashCode();
		}
		if (TurnLeft != 0)
		{
			num ^= TurnLeft.GetHashCode();
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
		if (KIKCDKLKCPC != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)KIKCDKLKCPC);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Id);
		}
		if (PKPIOIJPPBL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PKPIOIJPPBL);
		}
		if (TurnLeft != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(TurnLeft);
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
		if (KIKCDKLKCPC != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KIKCDKLKCPC);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (PKPIOIJPPBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKPIOIJPPBL);
		}
		if (TurnLeft != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TurnLeft);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FeverTimeActivityBattleEndScNotify other)
	{
		if (other != null)
		{
			if (other.KIKCDKLKCPC != FeverTimeBattleRank.GknlgibclcnIjljfpkieop)
			{
				KIKCDKLKCPC = other.KIKCDKLKCPC;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PKPIOIJPPBL != 0)
			{
				PKPIOIJPPBL = other.PKPIOIJPPBL;
			}
			if (other.TurnLeft != 0)
			{
				TurnLeft = other.TurnLeft;
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
			case 40u:
				KIKCDKLKCPC = (FeverTimeBattleRank)input.ReadEnum();
				break;
			case 88u:
				Id = input.ReadUInt32();
				break;
			case 96u:
				PKPIOIJPPBL = input.ReadUInt32();
				break;
			case 104u:
				TurnLeft = input.ReadUInt32();
				break;
			}
		}
	}
}
