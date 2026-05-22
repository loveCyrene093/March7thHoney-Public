using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneCastSkillCostMpCsReq : IMessage<SceneCastSkillCostMpCsReq>, IMessage, IEquatable<SceneCastSkillCostMpCsReq>, IDeepCloneable<SceneCastSkillCostMpCsReq>, IBufferMessage
{
	private static readonly MessageParser<SceneCastSkillCostMpCsReq> _parser = new MessageParser<SceneCastSkillCostMpCsReq>(() => new SceneCastSkillCostMpCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AttackedByEntityIdFieldNumber = 8;

	private uint attackedByEntityId_;

	public const int SkillIndexFieldNumber = 9;

	private uint skillIndex_;

	public const int CastEntityIdFieldNumber = 15;

	private uint castEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneCastSkillCostMpCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneCastSkillCostMpCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public SceneCastSkillCostMpCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillCostMpCsReq(SceneCastSkillCostMpCsReq other)
		: this()
	{
		attackedByEntityId_ = other.attackedByEntityId_;
		skillIndex_ = other.skillIndex_;
		castEntityId_ = other.castEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneCastSkillCostMpCsReq Clone()
	{
		return new SceneCastSkillCostMpCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneCastSkillCostMpCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneCastSkillCostMpCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AttackedByEntityId != other.AttackedByEntityId)
		{
			return false;
		}
		if (SkillIndex != other.SkillIndex)
		{
			return false;
		}
		if (CastEntityId != other.CastEntityId)
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
		if (AttackedByEntityId != 0)
		{
			num ^= AttackedByEntityId.GetHashCode();
		}
		if (SkillIndex != 0)
		{
			num ^= SkillIndex.GetHashCode();
		}
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
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
		if (AttackedByEntityId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AttackedByEntityId);
		}
		if (SkillIndex != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(SkillIndex);
		}
		if (CastEntityId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CastEntityId);
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
		if (AttackedByEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
		}
		if (SkillIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillIndex);
		}
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneCastSkillCostMpCsReq other)
	{
		if (other != null)
		{
			if (other.AttackedByEntityId != 0)
			{
				AttackedByEntityId = other.AttackedByEntityId;
			}
			if (other.SkillIndex != 0)
			{
				SkillIndex = other.SkillIndex;
			}
			if (other.CastEntityId != 0)
			{
				CastEntityId = other.CastEntityId;
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
			case 64u:
				AttackedByEntityId = input.ReadUInt32();
				break;
			case 72u:
				SkillIndex = input.ReadUInt32();
				break;
			case 120u:
				CastEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
