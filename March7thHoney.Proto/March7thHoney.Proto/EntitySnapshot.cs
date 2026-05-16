using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntitySnapshot : IMessage<EntitySnapshot>, IMessage, IEquatable<EntitySnapshot>, IDeepCloneable<EntitySnapshot>, IBufferMessage
{
	private static readonly MessageParser<EntitySnapshot> _parser = new MessageParser<EntitySnapshot>(() => new EntitySnapshot());

	private UnknownFieldSet _unknownFields;

	public const int EntityIdFieldNumber = 1;

	private uint entityId_;

	public const int InstanceIdFieldNumber = 2;

	private uint instanceId_;

	public const int MotionInfoFieldNumber = 3;

	private MotionInfoSnapshot motionInfo_;

	public const int MapObjectTypeFieldNumber = 4;

	private JHNKDJMLBJD mapObjectType_;

	public const int PropFieldNumber = 5;

	private PropInfoSnapshot prop_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntitySnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EntitySnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint InstanceId
	{
		get
		{
			return instanceId_;
		}
		set
		{
			instanceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfoSnapshot MotionInfo
	{
		get
		{
			return motionInfo_;
		}
		set
		{
			motionInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHNKDJMLBJD MapObjectType
	{
		get
		{
			return mapObjectType_;
		}
		set
		{
			mapObjectType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropInfoSnapshot Prop
	{
		get
		{
			return prop_;
		}
		set
		{
			prop_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitySnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitySnapshot(EntitySnapshot other)
		: this()
	{
		entityId_ = other.entityId_;
		instanceId_ = other.instanceId_;
		motionInfo_ = ((other.motionInfo_ != null) ? other.motionInfo_.Clone() : null);
		mapObjectType_ = other.mapObjectType_;
		prop_ = ((other.prop_ != null) ? other.prop_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitySnapshot Clone()
	{
		return new EntitySnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EntitySnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntitySnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EntityId != other.EntityId)
		{
			return false;
		}
		if (InstanceId != other.InstanceId)
		{
			return false;
		}
		if (!object.Equals(MotionInfo, other.MotionInfo))
		{
			return false;
		}
		if (MapObjectType != other.MapObjectType)
		{
			return false;
		}
		if (!object.Equals(Prop, other.Prop))
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
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
		}
		if (InstanceId != 0)
		{
			num ^= InstanceId.GetHashCode();
		}
		if (motionInfo_ != null)
		{
			num ^= MotionInfo.GetHashCode();
		}
		if (MapObjectType != JHNKDJMLBJD.Ibddkljdmkg)
		{
			num ^= MapObjectType.GetHashCode();
		}
		if (prop_ != null)
		{
			num ^= Prop.GetHashCode();
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
		if (EntityId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EntityId);
		}
		if (InstanceId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(InstanceId);
		}
		if (motionInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MotionInfo);
		}
		if (MapObjectType != JHNKDJMLBJD.Ibddkljdmkg)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)MapObjectType);
		}
		if (prop_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Prop);
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
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (InstanceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InstanceId);
		}
		if (motionInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MotionInfo);
		}
		if (MapObjectType != JHNKDJMLBJD.Ibddkljdmkg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MapObjectType);
		}
		if (prop_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Prop);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntitySnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
		}
		if (other.InstanceId != 0)
		{
			InstanceId = other.InstanceId;
		}
		if (other.motionInfo_ != null)
		{
			if (motionInfo_ == null)
			{
				MotionInfo = new MotionInfoSnapshot();
			}
			MotionInfo.MergeFrom(other.MotionInfo);
		}
		if (other.MapObjectType != JHNKDJMLBJD.Ibddkljdmkg)
		{
			MapObjectType = other.MapObjectType;
		}
		if (other.prop_ != null)
		{
			if (prop_ == null)
			{
				Prop = new PropInfoSnapshot();
			}
			Prop.MergeFrom(other.Prop);
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
				EntityId = input.ReadUInt32();
				break;
			case 16u:
				InstanceId = input.ReadUInt32();
				break;
			case 26u:
				if (motionInfo_ == null)
				{
					MotionInfo = new MotionInfoSnapshot();
				}
				input.ReadMessage(MotionInfo);
				break;
			case 32u:
				MapObjectType = (JHNKDJMLBJD)input.ReadEnum();
				break;
			case 42u:
				if (prop_ == null)
				{
					Prop = new PropInfoSnapshot();
				}
				input.ReadMessage(Prop);
				break;
			}
		}
	}
}
