using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityInfo : IMessage<SceneEntityInfo>, IMessage, IEquatable<SceneEntityInfo>, IDeepCloneable<SceneEntityInfo>, IBufferMessage
{
	public enum EntityOneofCase
	{
		None = 0,
		Actor = 1,
		Prop = 3,
		Npc = 8,
		NpcMonster = 9,
		SummonUnit = 11
	}

	private static readonly MessageParser<SceneEntityInfo> _parser = new MessageParser<SceneEntityInfo>(() => new SceneEntityInfo());

	private UnknownFieldSet _unknownFields;

	public const int InstIdFieldNumber = 4;

	private uint instId_;

	public const int MotionFieldNumber = 12;

	private MotionInfo motion_;

	public const int GroupIdFieldNumber = 13;

	private uint groupId_;

	public const int EntityIdFieldNumber = 14;

	private uint entityId_;

	public const int ActorFieldNumber = 1;

	public const int PropFieldNumber = 3;

	public const int NpcFieldNumber = 8;

	public const int NpcMonsterFieldNumber = 9;

	public const int SummonUnitFieldNumber = 11;

	private object entity_;

	private EntityOneofCase entityCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InstId
	{
		get
		{
			return instId_;
		}
		set
		{
			instId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntityId
	{
		get
		{
			return entityId_;
		}
		set
		{
			entityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneActorInfo Actor
	{
		get
		{
			if (entityCase_ != EntityOneofCase.Actor)
			{
				return null;
			}
			return (SceneActorInfo)entity_;
		}
		set
		{
			entity_ = value;
			entityCase_ = ((value != null) ? EntityOneofCase.Actor : EntityOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScenePropInfo Prop
	{
		get
		{
			if (entityCase_ != EntityOneofCase.Prop)
			{
				return null;
			}
			return (ScenePropInfo)entity_;
		}
		set
		{
			entity_ = value;
			entityCase_ = ((value != null) ? EntityOneofCase.Prop : EntityOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcInfo Npc
	{
		get
		{
			if (entityCase_ != EntityOneofCase.Npc)
			{
				return null;
			}
			return (SceneNpcInfo)entity_;
		}
		set
		{
			entity_ = value;
			entityCase_ = ((value != null) ? EntityOneofCase.Npc : EntityOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcMonsterInfo NpcMonster
	{
		get
		{
			if (entityCase_ != EntityOneofCase.NpcMonster)
			{
				return null;
			}
			return (SceneNpcMonsterInfo)entity_;
		}
		set
		{
			entity_ = value;
			entityCase_ = ((value != null) ? EntityOneofCase.NpcMonster : EntityOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneSummonUnitInfo SummonUnit
	{
		get
		{
			if (entityCase_ != EntityOneofCase.SummonUnit)
			{
				return null;
			}
			return (SceneSummonUnitInfo)entity_;
		}
		set
		{
			entity_ = value;
			entityCase_ = ((value != null) ? EntityOneofCase.SummonUnit : EntityOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityOneofCase EntityCase => entityCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityInfo(SceneEntityInfo other)
		: this()
	{
		instId_ = other.instId_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		groupId_ = other.groupId_;
		entityId_ = other.entityId_;
		switch (other.EntityCase)
		{
		case EntityOneofCase.Actor:
			Actor = other.Actor.Clone();
			break;
		case EntityOneofCase.Prop:
			Prop = other.Prop.Clone();
			break;
		case EntityOneofCase.Npc:
			Npc = other.Npc.Clone();
			break;
		case EntityOneofCase.NpcMonster:
			NpcMonster = other.NpcMonster.Clone();
			break;
		case EntityOneofCase.SummonUnit:
			SummonUnit = other.SummonUnit.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityInfo Clone()
	{
		return new SceneEntityInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEntity()
	{
		entityCase_ = EntityOneofCase.None;
		entity_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InstId != other.InstId)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (EntityId != other.EntityId)
		{
			return false;
		}
		if (!object.Equals(Actor, other.Actor))
		{
			return false;
		}
		if (!object.Equals(Prop, other.Prop))
		{
			return false;
		}
		if (!object.Equals(Npc, other.Npc))
		{
			return false;
		}
		if (!object.Equals(NpcMonster, other.NpcMonster))
		{
			return false;
		}
		if (!object.Equals(SummonUnit, other.SummonUnit))
		{
			return false;
		}
		if (EntityCase != other.EntityCase)
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
		if (InstId != 0)
		{
			num ^= InstId.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
		}
		if (entityCase_ == EntityOneofCase.Actor)
		{
			num ^= Actor.GetHashCode();
		}
		if (entityCase_ == EntityOneofCase.Prop)
		{
			num ^= Prop.GetHashCode();
		}
		if (entityCase_ == EntityOneofCase.Npc)
		{
			num ^= Npc.GetHashCode();
		}
		if (entityCase_ == EntityOneofCase.NpcMonster)
		{
			num ^= NpcMonster.GetHashCode();
		}
		if (entityCase_ == EntityOneofCase.SummonUnit)
		{
			num ^= SummonUnit.GetHashCode();
		}
		num ^= (int)entityCase_;
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
		if (entityCase_ == EntityOneofCase.Actor)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Actor);
		}
		if (entityCase_ == EntityOneofCase.Prop)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Prop);
		}
		if (InstId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(InstId);
		}
		if (entityCase_ == EntityOneofCase.Npc)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Npc);
		}
		if (entityCase_ == EntityOneofCase.NpcMonster)
		{
			output.WriteRawTag(74);
			output.WriteMessage(NpcMonster);
		}
		if (entityCase_ == EntityOneofCase.SummonUnit)
		{
			output.WriteRawTag(90);
			output.WriteMessage(SummonUnit);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Motion);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GroupId);
		}
		if (EntityId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EntityId);
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
		if (InstId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InstId);
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (entityCase_ == EntityOneofCase.Actor)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Actor);
		}
		if (entityCase_ == EntityOneofCase.Prop)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Prop);
		}
		if (entityCase_ == EntityOneofCase.Npc)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Npc);
		}
		if (entityCase_ == EntityOneofCase.NpcMonster)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NpcMonster);
		}
		if (entityCase_ == EntityOneofCase.SummonUnit)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SummonUnit);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.InstId != 0)
		{
			InstId = other.InstId;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
		}
		switch (other.EntityCase)
		{
		case EntityOneofCase.Actor:
			if (Actor == null)
			{
				Actor = new SceneActorInfo();
			}
			Actor.MergeFrom(other.Actor);
			break;
		case EntityOneofCase.Prop:
			if (Prop == null)
			{
				Prop = new ScenePropInfo();
			}
			Prop.MergeFrom(other.Prop);
			break;
		case EntityOneofCase.Npc:
			if (Npc == null)
			{
				Npc = new SceneNpcInfo();
			}
			Npc.MergeFrom(other.Npc);
			break;
		case EntityOneofCase.NpcMonster:
			if (NpcMonster == null)
			{
				NpcMonster = new SceneNpcMonsterInfo();
			}
			NpcMonster.MergeFrom(other.NpcMonster);
			break;
		case EntityOneofCase.SummonUnit:
			if (SummonUnit == null)
			{
				SummonUnit = new SceneSummonUnitInfo();
			}
			SummonUnit.MergeFrom(other.SummonUnit);
			break;
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
			{
				SceneActorInfo sceneActorInfo = new SceneActorInfo();
				if (entityCase_ == EntityOneofCase.Actor)
				{
					sceneActorInfo.MergeFrom(Actor);
				}
				input.ReadMessage(sceneActorInfo);
				Actor = sceneActorInfo;
				break;
			}
			case 26u:
			{
				ScenePropInfo scenePropInfo = new ScenePropInfo();
				if (entityCase_ == EntityOneofCase.Prop)
				{
					scenePropInfo.MergeFrom(Prop);
				}
				input.ReadMessage(scenePropInfo);
				Prop = scenePropInfo;
				break;
			}
			case 32u:
				InstId = input.ReadUInt32();
				break;
			case 66u:
			{
				SceneNpcInfo sceneNpcInfo = new SceneNpcInfo();
				if (entityCase_ == EntityOneofCase.Npc)
				{
					sceneNpcInfo.MergeFrom(Npc);
				}
				input.ReadMessage(sceneNpcInfo);
				Npc = sceneNpcInfo;
				break;
			}
			case 74u:
			{
				SceneNpcMonsterInfo sceneNpcMonsterInfo = new SceneNpcMonsterInfo();
				if (entityCase_ == EntityOneofCase.NpcMonster)
				{
					sceneNpcMonsterInfo.MergeFrom(NpcMonster);
				}
				input.ReadMessage(sceneNpcMonsterInfo);
				NpcMonster = sceneNpcMonsterInfo;
				break;
			}
			case 90u:
			{
				SceneSummonUnitInfo sceneSummonUnitInfo = new SceneSummonUnitInfo();
				if (entityCase_ == EntityOneofCase.SummonUnit)
				{
					sceneSummonUnitInfo.MergeFrom(SummonUnit);
				}
				input.ReadMessage(sceneSummonUnitInfo);
				SummonUnit = sceneSummonUnitInfo;
				break;
			}
			case 98u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			case 104u:
				GroupId = input.ReadUInt32();
				break;
			case 112u:
				EntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
