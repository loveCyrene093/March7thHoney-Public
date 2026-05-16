using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleMonsterWave : IMessage<BattleMonsterWave>, IMessage, IEquatable<BattleMonsterWave>, IDeepCloneable<BattleMonsterWave>, IBufferMessage
{
	private static readonly MessageParser<BattleMonsterWave> _parser = new MessageParser<BattleMonsterWave>(() => new BattleMonsterWave());

	private UnknownFieldSet _unknownFields;

	public const int MonsterListFieldNumber = 1;

	private static readonly FieldCodec<BattleMonster> _repeated_monsterList_codec = FieldCodec.ForMessage(10u, BattleMonster.Parser);

	private readonly RepeatedField<BattleMonster> monsterList_ = new RepeatedField<BattleMonster>();

	public const int MonsterParamFieldNumber = 2;

	private BattleMonsterParam monsterParam_;

	public const int BattleStageIdFieldNumber = 3;

	private uint battleStageId_;

	public const int BattleWaveIdFieldNumber = 4;

	private uint battleWaveId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleMonsterWave> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleMonsterWaveReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleMonster> MonsterList => monsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonsterParam MonsterParam
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
	public BattleMonsterWave()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonsterWave(BattleMonsterWave other)
		: this()
	{
		monsterList_ = other.monsterList_.Clone();
		monsterParam_ = ((other.monsterParam_ != null) ? other.monsterParam_.Clone() : null);
		battleStageId_ = other.battleStageId_;
		battleWaveId_ = other.battleWaveId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleMonsterWave Clone()
	{
		return new BattleMonsterWave(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleMonsterWave);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleMonsterWave other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!monsterList_.Equals(other.monsterList_))
		{
			return false;
		}
		if (!object.Equals(MonsterParam, other.MonsterParam))
		{
			return false;
		}
		if (BattleStageId != other.BattleStageId)
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
		num ^= monsterList_.GetHashCode();
		if (monsterParam_ != null)
		{
			num ^= MonsterParam.GetHashCode();
		}
		if (BattleStageId != 0)
		{
			num ^= BattleStageId.GetHashCode();
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
		monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
		if (monsterParam_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MonsterParam);
		}
		if (BattleStageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BattleStageId);
		}
		if (BattleWaveId != 0)
		{
			output.WriteRawTag(32);
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
		num += monsterList_.CalculateSize(_repeated_monsterList_codec);
		if (monsterParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterParam);
		}
		if (BattleStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleStageId);
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
	public void MergeFrom(BattleMonsterWave other)
	{
		if (other == null)
		{
			return;
		}
		monsterList_.Add(other.monsterList_);
		if (other.monsterParam_ != null)
		{
			if (monsterParam_ == null)
			{
				MonsterParam = new BattleMonsterParam();
			}
			MonsterParam.MergeFrom(other.MonsterParam);
		}
		if (other.BattleStageId != 0)
		{
			BattleStageId = other.BattleStageId;
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
			case 10u:
				monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
				break;
			case 18u:
				if (monsterParam_ == null)
				{
					MonsterParam = new BattleMonsterParam();
				}
				input.ReadMessage(MonsterParam);
				break;
			case 24u:
				BattleStageId = input.ReadUInt32();
				break;
			case 32u:
				BattleWaveId = input.ReadUInt32();
				break;
			}
		}
	}
}
