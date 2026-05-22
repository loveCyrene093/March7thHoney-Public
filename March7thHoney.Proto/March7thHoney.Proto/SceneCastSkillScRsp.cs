using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneCastSkillScRsp : IMessage<SceneCastSkillScRsp>, IMessage, IEquatable<SceneCastSkillScRsp>, IDeepCloneable<SceneCastSkillScRsp>, IBufferMessage
{
	private static readonly MessageParser<SceneCastSkillScRsp> _parser = new MessageParser<SceneCastSkillScRsp>(() => new SceneCastSkillScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BattleInfoFieldNumber = 1;

	private SceneBattleInfo battleInfo_;

	public const int MonsterBattleInfoFieldNumber = 2;

	private static readonly FieldCodec<HitMonsterBattleInfo> _repeated_monsterBattleInfo_codec = FieldCodec.ForMessage(18u, HitMonsterBattleInfo.Parser);

	private readonly RepeatedField<HitMonsterBattleInfo> monsterBattleInfo_ = new RepeatedField<HitMonsterBattleInfo>();

	public const int CastEntityIdFieldNumber = 4;

	private uint castEntityId_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneCastSkillScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneCastSkillScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo BattleInfo
	{
		get
		{
			return battleInfo_;
		}
		set
		{
			battleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HitMonsterBattleInfo> MonsterBattleInfo => monsterBattleInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CastEntityId
	{
		get
		{
			return castEntityId_;
		}
		set
		{
			castEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillScRsp(SceneCastSkillScRsp other)
		: this()
	{
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		monsterBattleInfo_ = other.monsterBattleInfo_.Clone();
		castEntityId_ = other.castEntityId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillScRsp Clone()
	{
		return new SceneCastSkillScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneCastSkillScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneCastSkillScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (!monsterBattleInfo_.Equals(other.monsterBattleInfo_))
		{
			return false;
		}
		if (CastEntityId != other.CastEntityId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		num ^= monsterBattleInfo_.GetHashCode();
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (battleInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BattleInfo);
		}
		monsterBattleInfo_.WriteTo(ref output, _repeated_monsterBattleInfo_codec);
		if (CastEntityId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CastEntityId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
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
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		num += monsterBattleInfo_.CalculateSize(_repeated_monsterBattleInfo_codec);
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneCastSkillScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		monsterBattleInfo_.Add(other.monsterBattleInfo_);
		if (other.CastEntityId != 0)
		{
			CastEntityId = other.CastEntityId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 18u:
				monsterBattleInfo_.AddEntriesFrom(ref input, _repeated_monsterBattleInfo_codec);
				break;
			case 32u:
				CastEntityId = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
