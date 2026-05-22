using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneCastSkillCsReq : IMessage<SceneCastSkillCsReq>, IMessage, IEquatable<SceneCastSkillCsReq>, IDeepCloneable<SceneCastSkillCsReq>, IBufferMessage
{
	private static readonly MessageParser<SceneCastSkillCsReq> _parser = new MessageParser<SceneCastSkillCsReq>(() => new SceneCastSkillCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HitTargetEntityIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_hitTargetEntityIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> hitTargetEntityIdList_ = new RepeatedField<uint>();

	public const int AttackedByEntityIdFieldNumber = 2;

	private uint attackedByEntityId_;

	public const int AssistMonsterEntityInfoFieldNumber = 3;

	private static readonly FieldCodec<AssistMonsterEntityInfo> _repeated_assistMonsterEntityInfo_codec = FieldCodec.ForMessage(26u, March7thHoney.Proto.AssistMonsterEntityInfo.Parser);

	private readonly RepeatedField<AssistMonsterEntityInfo> assistMonsterEntityInfo_ = new RepeatedField<AssistMonsterEntityInfo>();

	public const int MazeAbilityStrFieldNumber = 4;

	private string mazeAbilityStr_ = "";

	public const int CastEntityIdFieldNumber = 5;

	private uint castEntityId_;

	public const int JJABNMFLKKIFieldNumber = 6;

	private uint jJABNMFLKKI_;

	public const int TargetMotionFieldNumber = 7;

	private MotionInfo targetMotion_;

	public const int SkillIndexFieldNumber = 8;

	private uint skillIndex_;

	public const int AssistMonsterEntityIdListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();

	public const int DynamicValuesFieldNumber = 13;

	private static readonly FieldCodec<DynamicValues> _repeated_dynamicValues_codec = FieldCodec.ForMessage(106u, March7thHoney.Proto.DynamicValues.Parser);

	private readonly RepeatedField<DynamicValues> dynamicValues_ = new RepeatedField<DynamicValues>();

	public const int SkillExtraTagsFieldNumber = 14;

	private static readonly FieldCodec<SkillExtraTag> _repeated_skillExtraTags_codec = FieldCodec.ForEnum(114u, (SkillExtraTag x) => (int)x, (int x) => (SkillExtraTag)x);

	private readonly RepeatedField<SkillExtraTag> skillExtraTags_ = new RepeatedField<SkillExtraTag>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneCastSkillCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneCastSkillCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HitTargetEntityIdList => hitTargetEntityIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AttackedByEntityId
	{
		get
		{
			return attackedByEntityId_;
		}
		set
		{
			attackedByEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AssistMonsterEntityInfo> AssistMonsterEntityInfo => assistMonsterEntityInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MazeAbilityStr
	{
		get
		{
			return mazeAbilityStr_;
		}
		set
		{
			mazeAbilityStr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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
	public uint JJABNMFLKKI
	{
		get
		{
			return jJABNMFLKKI_;
		}
		set
		{
			jJABNMFLKKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo TargetMotion
	{
		get
		{
			return targetMotion_;
		}
		set
		{
			targetMotion_ = value;
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
	public RepeatedField<uint> AssistMonsterEntityIdList => assistMonsterEntityIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DynamicValues> DynamicValues => dynamicValues_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SkillExtraTag> SkillExtraTags => skillExtraTags_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillCsReq(SceneCastSkillCsReq other)
		: this()
	{
		hitTargetEntityIdList_ = other.hitTargetEntityIdList_.Clone();
		attackedByEntityId_ = other.attackedByEntityId_;
		assistMonsterEntityInfo_ = other.assistMonsterEntityInfo_.Clone();
		mazeAbilityStr_ = other.mazeAbilityStr_;
		castEntityId_ = other.castEntityId_;
		jJABNMFLKKI_ = other.jJABNMFLKKI_;
		targetMotion_ = ((other.targetMotion_ != null) ? other.targetMotion_.Clone() : null);
		skillIndex_ = other.skillIndex_;
		assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
		dynamicValues_ = other.dynamicValues_.Clone();
		skillExtraTags_ = other.skillExtraTags_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillCsReq Clone()
	{
		return new SceneCastSkillCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneCastSkillCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneCastSkillCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hitTargetEntityIdList_.Equals(other.hitTargetEntityIdList_))
		{
			return false;
		}
		if (AttackedByEntityId != other.AttackedByEntityId)
		{
			return false;
		}
		if (!assistMonsterEntityInfo_.Equals(other.assistMonsterEntityInfo_))
		{
			return false;
		}
		if (MazeAbilityStr != other.MazeAbilityStr)
		{
			return false;
		}
		if (CastEntityId != other.CastEntityId)
		{
			return false;
		}
		if (JJABNMFLKKI != other.JJABNMFLKKI)
		{
			return false;
		}
		if (!object.Equals(TargetMotion, other.TargetMotion))
		{
			return false;
		}
		if (SkillIndex != other.SkillIndex)
		{
			return false;
		}
		if (!assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_))
		{
			return false;
		}
		if (!dynamicValues_.Equals(other.dynamicValues_))
		{
			return false;
		}
		if (!skillExtraTags_.Equals(other.skillExtraTags_))
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
		num ^= hitTargetEntityIdList_.GetHashCode();
		if (AttackedByEntityId != 0)
		{
			num ^= AttackedByEntityId.GetHashCode();
		}
		num ^= assistMonsterEntityInfo_.GetHashCode();
		if (MazeAbilityStr.Length != 0)
		{
			num ^= MazeAbilityStr.GetHashCode();
		}
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
		}
		if (JJABNMFLKKI != 0)
		{
			num ^= JJABNMFLKKI.GetHashCode();
		}
		if (targetMotion_ != null)
		{
			num ^= TargetMotion.GetHashCode();
		}
		if (SkillIndex != 0)
		{
			num ^= SkillIndex.GetHashCode();
		}
		num ^= assistMonsterEntityIdList_.GetHashCode();
		num ^= dynamicValues_.GetHashCode();
		num ^= skillExtraTags_.GetHashCode();
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
		hitTargetEntityIdList_.WriteTo(ref output, _repeated_hitTargetEntityIdList_codec);
		if (AttackedByEntityId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AttackedByEntityId);
		}
		assistMonsterEntityInfo_.WriteTo(ref output, _repeated_assistMonsterEntityInfo_codec);
		if (MazeAbilityStr.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MazeAbilityStr);
		}
		if (CastEntityId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CastEntityId);
		}
		if (JJABNMFLKKI != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JJABNMFLKKI);
		}
		if (targetMotion_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(TargetMotion);
		}
		if (SkillIndex != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(SkillIndex);
		}
		assistMonsterEntityIdList_.WriteTo(ref output, _repeated_assistMonsterEntityIdList_codec);
		dynamicValues_.WriteTo(ref output, _repeated_dynamicValues_codec);
		skillExtraTags_.WriteTo(ref output, _repeated_skillExtraTags_codec);
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
		num += hitTargetEntityIdList_.CalculateSize(_repeated_hitTargetEntityIdList_codec);
		if (AttackedByEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
		}
		num += assistMonsterEntityInfo_.CalculateSize(_repeated_assistMonsterEntityInfo_codec);
		if (MazeAbilityStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MazeAbilityStr);
		}
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		if (JJABNMFLKKI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJABNMFLKKI);
		}
		if (targetMotion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetMotion);
		}
		if (SkillIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillIndex);
		}
		num += assistMonsterEntityIdList_.CalculateSize(_repeated_assistMonsterEntityIdList_codec);
		num += dynamicValues_.CalculateSize(_repeated_dynamicValues_codec);
		num += skillExtraTags_.CalculateSize(_repeated_skillExtraTags_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneCastSkillCsReq other)
	{
		if (other == null)
		{
			return;
		}
		hitTargetEntityIdList_.Add(other.hitTargetEntityIdList_);
		if (other.AttackedByEntityId != 0)
		{
			AttackedByEntityId = other.AttackedByEntityId;
		}
		assistMonsterEntityInfo_.Add(other.assistMonsterEntityInfo_);
		if (other.MazeAbilityStr.Length != 0)
		{
			MazeAbilityStr = other.MazeAbilityStr;
		}
		if (other.CastEntityId != 0)
		{
			CastEntityId = other.CastEntityId;
		}
		if (other.JJABNMFLKKI != 0)
		{
			JJABNMFLKKI = other.JJABNMFLKKI;
		}
		if (other.targetMotion_ != null)
		{
			if (targetMotion_ == null)
			{
				TargetMotion = new MotionInfo();
			}
			TargetMotion.MergeFrom(other.TargetMotion);
		}
		if (other.SkillIndex != 0)
		{
			SkillIndex = other.SkillIndex;
		}
		assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
		dynamicValues_.Add(other.dynamicValues_);
		skillExtraTags_.Add(other.skillExtraTags_);
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
			case 10u:
				hitTargetEntityIdList_.AddEntriesFrom(ref input, _repeated_hitTargetEntityIdList_codec);
				break;
			case 16u:
				AttackedByEntityId = input.ReadUInt32();
				break;
			case 26u:
				assistMonsterEntityInfo_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityInfo_codec);
				break;
			case 34u:
				MazeAbilityStr = input.ReadString();
				break;
			case 40u:
				CastEntityId = input.ReadUInt32();
				break;
			case 48u:
				JJABNMFLKKI = input.ReadUInt32();
				break;
			case 58u:
				if (targetMotion_ == null)
				{
					TargetMotion = new MotionInfo();
				}
				input.ReadMessage(TargetMotion);
				break;
			case 64u:
				SkillIndex = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				assistMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityIdList_codec);
				break;
			case 106u:
				dynamicValues_.AddEntriesFrom(ref input, _repeated_dynamicValues_codec);
				break;
			case 112u:
			case 114u:
				skillExtraTags_.AddEntriesFrom(ref input, _repeated_skillExtraTags_codec);
				break;
			}
		}
	}
}
