using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HitMonsterBattleInfo : IMessage<HitMonsterBattleInfo>, IMessage, IEquatable<HitMonsterBattleInfo>, IDeepCloneable<HitMonsterBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<HitMonsterBattleInfo> _parser = new MessageParser<HitMonsterBattleInfo>(() => new HitMonsterBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int TargetMonsterEntityIdFieldNumber = 5;

	private uint targetMonsterEntityId_;

	public const int MonsterBattleTypeFieldNumber = 9;

	private MonsterBattleType monsterBattleType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HitMonsterBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HitMonsterBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetMonsterEntityId
	{
		get
		{
			return targetMonsterEntityId_;
		}
		set
		{
			targetMonsterEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterBattleType MonsterBattleType
	{
		get
		{
			return monsterBattleType_;
		}
		set
		{
			monsterBattleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HitMonsterBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HitMonsterBattleInfo(HitMonsterBattleInfo other)
		: this()
	{
		targetMonsterEntityId_ = other.targetMonsterEntityId_;
		monsterBattleType_ = other.monsterBattleType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HitMonsterBattleInfo Clone()
	{
		return new HitMonsterBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HitMonsterBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HitMonsterBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetMonsterEntityId != other.TargetMonsterEntityId)
		{
			return false;
		}
		if (MonsterBattleType != other.MonsterBattleType)
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
		if (TargetMonsterEntityId != 0)
		{
			num ^= TargetMonsterEntityId.GetHashCode();
		}
		if (MonsterBattleType != MonsterBattleType.None)
		{
			num ^= MonsterBattleType.GetHashCode();
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
		if (TargetMonsterEntityId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(TargetMonsterEntityId);
		}
		if (MonsterBattleType != MonsterBattleType.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MonsterBattleType);
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
		if (TargetMonsterEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetMonsterEntityId);
		}
		if (MonsterBattleType != MonsterBattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MonsterBattleType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HitMonsterBattleInfo other)
	{
		if (other != null)
		{
			if (other.TargetMonsterEntityId != 0)
			{
				TargetMonsterEntityId = other.TargetMonsterEntityId;
			}
			if (other.MonsterBattleType != MonsterBattleType.None)
			{
				MonsterBattleType = other.MonsterBattleType;
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
				TargetMonsterEntityId = input.ReadUInt32();
				break;
			case 72u:
				MonsterBattleType = (MonsterBattleType)input.ReadEnum();
				break;
			}
		}
	}
}
