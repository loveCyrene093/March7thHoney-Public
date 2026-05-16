using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityMoveScNotify : IMessage<SceneEntityMoveScNotify>, IMessage, IEquatable<SceneEntityMoveScNotify>, IDeepCloneable<SceneEntityMoveScNotify>, IBufferMessage
{
	private static readonly MessageParser<SceneEntityMoveScNotify> _parser = new MessageParser<SceneEntityMoveScNotify>(() => new SceneEntityMoveScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MotionFieldNumber = 4;

	private MotionInfo motion_;

	public const int EntryIdFieldNumber = 5;

	private uint entryId_;

	public const int EntityIdFieldNumber = 13;

	private uint entityId_;

	public const int ClientPosVersionFieldNumber = 15;

	private uint clientPosVersion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityMoveScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityMoveScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
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
	public uint ClientPosVersion
	{
		get
		{
			return clientPosVersion_;
		}
		set
		{
			clientPosVersion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveScNotify(SceneEntityMoveScNotify other)
		: this()
	{
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		entryId_ = other.entryId_;
		entityId_ = other.entityId_;
		clientPosVersion_ = other.clientPosVersion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityMoveScNotify Clone()
	{
		return new SceneEntityMoveScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityMoveScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityMoveScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Motion, other.Motion))
		{
			return false;
		}
		if (EntryId != other.EntryId)
		{
			return false;
		}
		if (EntityId != other.EntityId)
		{
			return false;
		}
		if (ClientPosVersion != other.ClientPosVersion)
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
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
		}
		if (ClientPosVersion != 0)
		{
			num ^= ClientPosVersion.GetHashCode();
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
		if (motion_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Motion);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EntryId);
		}
		if (EntityId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EntityId);
		}
		if (ClientPosVersion != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ClientPosVersion);
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
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (ClientPosVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityMoveScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
		}
		if (other.EntryId != 0)
		{
			EntryId = other.EntryId;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
		}
		if (other.ClientPosVersion != 0)
		{
			ClientPosVersion = other.ClientPosVersion;
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
			case 34u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			case 40u:
				EntryId = input.ReadUInt32();
				break;
			case 104u:
				EntityId = input.ReadUInt32();
				break;
			case 120u:
				ClientPosVersion = input.ReadUInt32();
				break;
			}
		}
	}
}
