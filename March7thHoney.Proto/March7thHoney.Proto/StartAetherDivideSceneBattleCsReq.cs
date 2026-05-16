using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartAetherDivideSceneBattleCsReq : IMessage<StartAetherDivideSceneBattleCsReq>, IMessage, IEquatable<StartAetherDivideSceneBattleCsReq>, IDeepCloneable<StartAetherDivideSceneBattleCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartAetherDivideSceneBattleCsReq> _parser = new MessageParser<StartAetherDivideSceneBattleCsReq>(() => new StartAetherDivideSceneBattleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SkillIndexFieldNumber = 2;

	private uint skillIndex_;

	public const int AttackedByEntityIdFieldNumber = 8;

	private uint attackedByEntityId_;

	public const int CastEntityIdFieldNumber = 9;

	private uint castEntityId_;

	public const int AssistMonsterEntityIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();

	public const int AssistMonsterEntityInfoFieldNumber = 12;

	private static readonly FieldCodec<AssistMonsterEntityInfo> _repeated_assistMonsterEntityInfo_codec = FieldCodec.ForMessage(98u, March7thHoney.Proto.AssistMonsterEntityInfo.Parser);

	private readonly RepeatedField<AssistMonsterEntityInfo> assistMonsterEntityInfo_ = new RepeatedField<AssistMonsterEntityInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartAetherDivideSceneBattleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartAetherDivideSceneBattleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> AssistMonsterEntityIdList => assistMonsterEntityIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AssistMonsterEntityInfo> AssistMonsterEntityInfo => assistMonsterEntityInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideSceneBattleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideSceneBattleCsReq(StartAetherDivideSceneBattleCsReq other)
		: this()
	{
		skillIndex_ = other.skillIndex_;
		attackedByEntityId_ = other.attackedByEntityId_;
		castEntityId_ = other.castEntityId_;
		assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
		assistMonsterEntityInfo_ = other.assistMonsterEntityInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartAetherDivideSceneBattleCsReq Clone()
	{
		return new StartAetherDivideSceneBattleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartAetherDivideSceneBattleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartAetherDivideSceneBattleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillIndex != other.SkillIndex)
		{
			return false;
		}
		if (AttackedByEntityId != other.AttackedByEntityId)
		{
			return false;
		}
		if (CastEntityId != other.CastEntityId)
		{
			return false;
		}
		if (!assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_))
		{
			return false;
		}
		if (!assistMonsterEntityInfo_.Equals(other.assistMonsterEntityInfo_))
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
		if (SkillIndex != 0)
		{
			num ^= SkillIndex.GetHashCode();
		}
		if (AttackedByEntityId != 0)
		{
			num ^= AttackedByEntityId.GetHashCode();
		}
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
		}
		num ^= assistMonsterEntityIdList_.GetHashCode();
		num ^= assistMonsterEntityInfo_.GetHashCode();
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
		if (SkillIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SkillIndex);
		}
		if (AttackedByEntityId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AttackedByEntityId);
		}
		if (CastEntityId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CastEntityId);
		}
		assistMonsterEntityIdList_.WriteTo(ref output, _repeated_assistMonsterEntityIdList_codec);
		assistMonsterEntityInfo_.WriteTo(ref output, _repeated_assistMonsterEntityInfo_codec);
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
		if (SkillIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillIndex);
		}
		if (AttackedByEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
		}
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		num += assistMonsterEntityIdList_.CalculateSize(_repeated_assistMonsterEntityIdList_codec);
		num += assistMonsterEntityInfo_.CalculateSize(_repeated_assistMonsterEntityInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartAetherDivideSceneBattleCsReq other)
	{
		if (other != null)
		{
			if (other.SkillIndex != 0)
			{
				SkillIndex = other.SkillIndex;
			}
			if (other.AttackedByEntityId != 0)
			{
				AttackedByEntityId = other.AttackedByEntityId;
			}
			if (other.CastEntityId != 0)
			{
				CastEntityId = other.CastEntityId;
			}
			assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
			assistMonsterEntityInfo_.Add(other.assistMonsterEntityInfo_);
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
				SkillIndex = input.ReadUInt32();
				break;
			case 64u:
				AttackedByEntityId = input.ReadUInt32();
				break;
			case 72u:
				CastEntityId = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				assistMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityIdList_codec);
				break;
			case 98u:
				assistMonsterEntityInfo_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityInfo_codec);
				break;
			}
		}
	}
}
