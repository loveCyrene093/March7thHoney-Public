using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityTeleportCsReq : IMessage<SceneEntityTeleportCsReq>, IMessage, IEquatable<SceneEntityTeleportCsReq>, IDeepCloneable<SceneEntityTeleportCsReq>, IBufferMessage
{
	private static readonly MessageParser<SceneEntityTeleportCsReq> _parser = new MessageParser<SceneEntityTeleportCsReq>(() => new SceneEntityTeleportCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EntityMotionFieldNumber = 6;

	private EntityMotion entityMotion_;

	public const int InteractIdFieldNumber = 9;

	private ulong interactId_;

	public const int EntryIdFieldNumber = 14;

	private uint entryId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityTeleportCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityTeleportCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityMotion EntityMotion
	{
		get
		{
			return entityMotion_;
		}
		set
		{
			entityMotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
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
	public SceneEntityTeleportCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityTeleportCsReq(SceneEntityTeleportCsReq other)
		: this()
	{
		entityMotion_ = ((other.entityMotion_ != null) ? other.entityMotion_.Clone() : null);
		interactId_ = other.interactId_;
		entryId_ = other.entryId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityTeleportCsReq Clone()
	{
		return new SceneEntityTeleportCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityTeleportCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityTeleportCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EntityMotion, other.EntityMotion))
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (EntryId != other.EntryId)
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
		if (entityMotion_ != null)
		{
			num ^= EntityMotion.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
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
		if (entityMotion_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EntityMotion);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(InteractId);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EntryId);
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
		if (entityMotion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EntityMotion);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityTeleportCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.entityMotion_ != null)
		{
			if (entityMotion_ == null)
			{
				EntityMotion = new EntityMotion();
			}
			EntityMotion.MergeFrom(other.EntityMotion);
		}
		if (other.InteractId != 0L)
		{
			InteractId = other.InteractId;
		}
		if (other.EntryId != 0)
		{
			EntryId = other.EntryId;
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
			case 50u:
				if (entityMotion_ == null)
				{
					EntityMotion = new EntityMotion();
				}
				input.ReadMessage(EntityMotion);
				break;
			case 72u:
				InteractId = input.ReadUInt64();
				break;
			case 112u:
				EntryId = input.ReadUInt32();
				break;
			}
		}
	}
}
