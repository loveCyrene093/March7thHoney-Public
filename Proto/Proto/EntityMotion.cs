using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityMotion : IMessage<EntityMotion>, IMessage, IEquatable<EntityMotion>, IDeepCloneable<EntityMotion>, IBufferMessage
{
	private static readonly MessageParser<EntityMotion> _parser = new MessageParser<EntityMotion>(() => new EntityMotion());

	private UnknownFieldSet _unknownFields;

	public const int AGNHNAIOPDFFieldNumber = 3;

	private bool aGNHNAIOPDF_;

	public const int MotionFieldNumber = 4;

	private MotionInfo motion_;

	public const int MapLayerFieldNumber = 10;

	private uint mapLayer_;

	public const int EntityIdFieldNumber = 12;

	private uint entityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntityMotion> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EntityMotionReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AGNHNAIOPDF
	{
		get
		{
			return aGNHNAIOPDF_;
		}
		set
		{
			aGNHNAIOPDF_ = value;
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
	public uint MapLayer
	{
		get
		{
			return mapLayer_;
		}
		set
		{
			mapLayer_ = value;
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
	public EntityMotion()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityMotion(EntityMotion other)
		: this()
	{
		aGNHNAIOPDF_ = other.aGNHNAIOPDF_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		mapLayer_ = other.mapLayer_;
		entityId_ = other.entityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityMotion Clone()
	{
		return new EntityMotion(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EntityMotion);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntityMotion other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AGNHNAIOPDF != other.AGNHNAIOPDF)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
		{
			return false;
		}
		if (MapLayer != other.MapLayer)
		{
			return false;
		}
		if (EntityId != other.EntityId)
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
		if (AGNHNAIOPDF)
		{
			num ^= AGNHNAIOPDF.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
		}
		if (MapLayer != 0)
		{
			num ^= MapLayer.GetHashCode();
		}
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
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
		if (AGNHNAIOPDF)
		{
			output.WriteRawTag(24);
			output.WriteBool(AGNHNAIOPDF);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Motion);
		}
		if (MapLayer != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MapLayer);
		}
		if (EntityId != 0)
		{
			output.WriteRawTag(96);
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
		if (AGNHNAIOPDF)
		{
			num += 2;
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (MapLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapLayer);
		}
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntityMotion other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AGNHNAIOPDF)
		{
			AGNHNAIOPDF = other.AGNHNAIOPDF;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
		}
		if (other.MapLayer != 0)
		{
			MapLayer = other.MapLayer;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
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
				AGNHNAIOPDF = input.ReadBool();
				break;
			case 34u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			case 80u:
				MapLayer = input.ReadUInt32();
				break;
			case 96u:
				EntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
