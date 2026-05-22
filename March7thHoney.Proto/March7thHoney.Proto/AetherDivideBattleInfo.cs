using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherDivideBattleInfo : IMessage<AetherDivideBattleInfo>, IMessage, IEquatable<AetherDivideBattleInfo>, IDeepCloneable<AetherDivideBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<AetherDivideBattleInfo> _parser = new MessageParser<AetherDivideBattleInfo>(() => new AetherDivideBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int StageIdFieldNumber = 1;

	private uint stageId_;

	public const int BuffListFieldNumber = 2;

	private static readonly FieldCodec<BattleBuff> _repeated_buffList_codec = FieldCodec.ForMessage(18u, BattleBuff.Parser);

	private readonly RepeatedField<BattleBuff> buffList_ = new RepeatedField<BattleBuff>();

	public const int BattleAvatarListFieldNumber = 5;

	private static readonly FieldCodec<AetherAvatarInfo> _repeated_battleAvatarList_codec = FieldCodec.ForMessage(42u, AetherAvatarInfo.Parser);

	private readonly RepeatedField<AetherAvatarInfo> battleAvatarList_ = new RepeatedField<AetherAvatarInfo>();

	public const int EODHMOBOENGFieldNumber = 6;

	private bool eODHMOBOENG_;

	public const int LogicRandomSeedFieldNumber = 7;

	private uint logicRandomSeed_;

	public const int MonsterWaveListFieldNumber = 11;

	private static readonly FieldCodec<SceneMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage(90u, SceneMonsterWave.Parser);

	private readonly RepeatedField<SceneMonsterWave> monsterWaveList_ = new RepeatedField<SceneMonsterWave>();

	public const int BattleIdFieldNumber = 15;

	private uint battleId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherDivideBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherDivideBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleBuff> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AetherAvatarInfo> BattleAvatarList => battleAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EODHMOBOENG
	{
		get
		{
			return eODHMOBOENG_;
		}
		set
		{
			eODHMOBOENG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LogicRandomSeed
	{
		get
		{
			return logicRandomSeed_;
		}
		set
		{
			logicRandomSeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneMonsterWave> MonsterWaveList => monsterWaveList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideBattleInfo(AetherDivideBattleInfo other)
		: this()
	{
		stageId_ = other.stageId_;
		buffList_ = other.buffList_.Clone();
		battleAvatarList_ = other.battleAvatarList_.Clone();
		eODHMOBOENG_ = other.eODHMOBOENG_;
		logicRandomSeed_ = other.logicRandomSeed_;
		monsterWaveList_ = other.monsterWaveList_.Clone();
		battleId_ = other.battleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideBattleInfo Clone()
	{
		return new AetherDivideBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherDivideBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherDivideBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!battleAvatarList_.Equals(other.battleAvatarList_))
		{
			return false;
		}
		if (EODHMOBOENG != other.EODHMOBOENG)
		{
			return false;
		}
		if (LogicRandomSeed != other.LogicRandomSeed)
		{
			return false;
		}
		if (!monsterWaveList_.Equals(other.monsterWaveList_))
		{
			return false;
		}
		if (BattleId != other.BattleId)
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
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		num ^= buffList_.GetHashCode();
		num ^= battleAvatarList_.GetHashCode();
		if (EODHMOBOENG)
		{
			num ^= EODHMOBOENG.GetHashCode();
		}
		if (LogicRandomSeed != 0)
		{
			num ^= LogicRandomSeed.GetHashCode();
		}
		num ^= monsterWaveList_.GetHashCode();
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
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
		if (StageId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(StageId);
		}
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
		if (EODHMOBOENG)
		{
			output.WriteRawTag(48);
			output.WriteBool(EODHMOBOENG);
		}
		if (LogicRandomSeed != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LogicRandomSeed);
		}
		monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
		if (BattleId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BattleId);
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
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
		if (EODHMOBOENG)
		{
			num += 2;
		}
		if (LogicRandomSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LogicRandomSeed);
		}
		num += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AetherDivideBattleInfo other)
	{
		if (other != null)
		{
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			buffList_.Add(other.buffList_);
			battleAvatarList_.Add(other.battleAvatarList_);
			if (other.EODHMOBOENG)
			{
				EODHMOBOENG = other.EODHMOBOENG;
			}
			if (other.LogicRandomSeed != 0)
			{
				LogicRandomSeed = other.LogicRandomSeed;
			}
			monsterWaveList_.Add(other.monsterWaveList_);
			if (other.BattleId != 0)
			{
				BattleId = other.BattleId;
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
				StageId = input.ReadUInt32();
				break;
			case 18u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 42u:
				battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
				break;
			case 48u:
				EODHMOBOENG = input.ReadBool();
				break;
			case 56u:
				LogicRandomSeed = input.ReadUInt32();
				break;
			case 90u:
				monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
				break;
			case 120u:
				BattleId = input.ReadUInt32();
				break;
			}
		}
	}
}
