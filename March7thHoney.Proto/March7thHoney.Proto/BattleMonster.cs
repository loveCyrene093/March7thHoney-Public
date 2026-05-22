using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleMonster : IMessage<BattleMonster>, IMessage, IEquatable<BattleMonster>, IDeepCloneable<BattleMonster>, IBufferMessage
{
	private static readonly MessageParser<BattleMonster> _parser = new MessageParser<BattleMonster>(() => new BattleMonster());

	private UnknownFieldSet _unknownFields;

	public const int MonsterIdFieldNumber = 1;

	private uint monsterId_;

	public const int CurHpFieldNumber = 2;

	private uint curHp_;

	public const int MaxHpFieldNumber = 3;

	private uint maxHp_;

	public const int ExtraInfoFieldNumber = 4;

	private CBCBJCPPOMP extraInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleMonster> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleMonsterReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBCBJCPPOMP ExtraInfo
	{
		get
		{
			return extraInfo_;
		}
		set
		{
			extraInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonster()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonster(BattleMonster other)
		: this()
	{
		monsterId_ = other.monsterId_;
		curHp_ = other.curHp_;
		maxHp_ = other.maxHp_;
		extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonster Clone()
	{
		return new BattleMonster(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleMonster);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleMonster other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (!object.Equals(ExtraInfo, other.ExtraInfo))
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
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (extraInfo_ != null)
		{
			num ^= ExtraInfo.GetHashCode();
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
		if (MonsterId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MonsterId);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CurHp);
		}
		if (MaxHp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MaxHp);
		}
		if (extraInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ExtraInfo);
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
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxHp);
		}
		if (extraInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleMonster other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MonsterId != 0)
		{
			MonsterId = other.MonsterId;
		}
		if (other.CurHp != 0)
		{
			CurHp = other.CurHp;
		}
		if (other.MaxHp != 0)
		{
			MaxHp = other.MaxHp;
		}
		if (other.extraInfo_ != null)
		{
			if (extraInfo_ == null)
			{
				ExtraInfo = new CBCBJCPPOMP();
			}
			ExtraInfo.MergeFrom(other.ExtraInfo);
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
			case 8u:
				MonsterId = input.ReadUInt32();
				break;
			case 16u:
				CurHp = input.ReadUInt32();
				break;
			case 24u:
				MaxHp = input.ReadUInt32();
				break;
			case 34u:
				if (extraInfo_ == null)
				{
					ExtraInfo = new CBCBJCPPOMP();
				}
				input.ReadMessage(ExtraInfo);
				break;
			}
		}
	}
}
