using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneMonsterWave : IMessage<SceneMonsterWave>, IMessage, IEquatable<SceneMonsterWave>, IDeepCloneable<SceneMonsterWave>, IBufferMessage
{
	private static readonly MessageParser<SceneMonsterWave> _parser = new MessageParser<SceneMonsterWave>(() => new SceneMonsterWave());

	private UnknownFieldSet _unknownFields;

	public const int BattleStageIdFieldNumber = 3;

	private uint battleStageId_;

	public const int MonsterListFieldNumber = 6;

	private static readonly FieldCodec<SceneMonster> _repeated_monsterList_codec = FieldCodec.ForMessage(50u, SceneMonster.Parser);

	private readonly RepeatedField<SceneMonster> monsterList_ = new RepeatedField<SceneMonster>();

	public const int PIBLJLBCKJLFieldNumber = 9;

	private static readonly FieldCodec<ItemList> _repeated_pIBLJLBCKJL_codec = FieldCodec.ForMessage(74u, ItemList.Parser);

	private readonly RepeatedField<ItemList> pIBLJLBCKJL_ = new RepeatedField<ItemList>();

	public const int MonsterParamFieldNumber = 12;

	private SceneMonsterWaveParam monsterParam_;

	public const int BattleWaveIdFieldNumber = 14;

	private uint battleWaveId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneMonsterWave> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneMonsterWaveReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleStageId
	{
		get
		{
			return battleStageId_;
		}
		set
		{
			battleStageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneMonster> MonsterList => monsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemList> PIBLJLBCKJL => pIBLJLBCKJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWaveParam MonsterParam
	{
		get
		{
			return monsterParam_;
		}
		set
		{
			monsterParam_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleWaveId
	{
		get
		{
			return battleWaveId_;
		}
		set
		{
			battleWaveId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWave()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWave(SceneMonsterWave other)
		: this()
	{
		battleStageId_ = other.battleStageId_;
		monsterList_ = other.monsterList_.Clone();
		pIBLJLBCKJL_ = other.pIBLJLBCKJL_.Clone();
		monsterParam_ = ((other.monsterParam_ != null) ? other.monsterParam_.Clone() : null);
		battleWaveId_ = other.battleWaveId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonsterWave Clone()
	{
		return new SceneMonsterWave(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneMonsterWave);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneMonsterWave other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BattleStageId != other.BattleStageId)
		{
			return false;
		}
		if (!monsterList_.Equals(other.monsterList_))
		{
			return false;
		}
		if (!pIBLJLBCKJL_.Equals(other.pIBLJLBCKJL_))
		{
			return false;
		}
		if (!object.Equals(MonsterParam, other.MonsterParam))
		{
			return false;
		}
		if (BattleWaveId != other.BattleWaveId)
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
		if (BattleStageId != 0)
		{
			num ^= BattleStageId.GetHashCode();
		}
		num ^= monsterList_.GetHashCode();
		num ^= pIBLJLBCKJL_.GetHashCode();
		if (monsterParam_ != null)
		{
			num ^= MonsterParam.GetHashCode();
		}
		if (BattleWaveId != 0)
		{
			num ^= BattleWaveId.GetHashCode();
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
		if (BattleStageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BattleStageId);
		}
		monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
		pIBLJLBCKJL_.WriteTo(ref output, _repeated_pIBLJLBCKJL_codec);
		if (monsterParam_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(MonsterParam);
		}
		if (BattleWaveId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BattleWaveId);
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
		if (BattleStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleStageId);
		}
		num += monsterList_.CalculateSize(_repeated_monsterList_codec);
		num += pIBLJLBCKJL_.CalculateSize(_repeated_pIBLJLBCKJL_codec);
		if (monsterParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterParam);
		}
		if (BattleWaveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleWaveId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneMonsterWave other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleStageId != 0)
		{
			BattleStageId = other.BattleStageId;
		}
		monsterList_.Add(other.monsterList_);
		pIBLJLBCKJL_.Add(other.pIBLJLBCKJL_);
		if (other.monsterParam_ != null)
		{
			if (monsterParam_ == null)
			{
				MonsterParam = new SceneMonsterWaveParam();
			}
			MonsterParam.MergeFrom(other.MonsterParam);
		}
		if (other.BattleWaveId != 0)
		{
			BattleWaveId = other.BattleWaveId;
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
			case 24u:
				BattleStageId = input.ReadUInt32();
				break;
			case 50u:
				monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
				break;
			case 74u:
				pIBLJLBCKJL_.AddEntriesFrom(ref input, _repeated_pIBLJLBCKJL_codec);
				break;
			case 98u:
				if (monsterParam_ == null)
				{
					MonsterParam = new SceneMonsterWaveParam();
				}
				input.ReadMessage(MonsterParam);
				break;
			case 112u:
				BattleWaveId = input.ReadUInt32();
				break;
			}
		}
	}
}
