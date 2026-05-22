using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityBuffChangeInfo : IMessage<EntityBuffChangeInfo>, IMessage, IEquatable<EntityBuffChangeInfo>, IDeepCloneable<EntityBuffChangeInfo>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		BuffChangeInfo = 11,
		RemoveBuffId = 14
	}

	private static readonly MessageParser<EntityBuffChangeInfo> _parser = new MessageParser<EntityBuffChangeInfo>(() => new EntityBuffChangeInfo());

	private UnknownFieldSet _unknownFields;

	public const int EntityIdFieldNumber = 3;

	private uint entityId_;

	public const int CastEntityIdFieldNumber = 4;

	private uint castEntityId_;

	public const int ReasonFieldNumber = 12;

	private SceneEntityBuffChangeType reason_;

	public const int BuffChangeInfoFieldNumber = 11;

	public const int RemoveBuffIdFieldNumber = 14;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntityBuffChangeInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EntityBuffChangeInfoReflection.Descriptor.MessageTypes[0];

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
	public SceneEntityBuffChangeType Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffInfo BuffChangeInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BuffChangeInfo)
			{
				return null;
			}
			return (BuffInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BuffChangeInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RemoveBuffId
	{
		get
		{
			if (!HasRemoveBuffId)
			{
				return 0u;
			}
			return (uint)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.RemoveBuffId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRemoveBuffId => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RemoveBuffId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityBuffChangeInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityBuffChangeInfo(EntityBuffChangeInfo other)
		: this()
	{
		entityId_ = other.entityId_;
		castEntityId_ = other.castEntityId_;
		reason_ = other.reason_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.BuffChangeInfo:
			BuffChangeInfo = other.BuffChangeInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.RemoveBuffId:
			RemoveBuffId = other.RemoveBuffId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityBuffChangeInfo Clone()
	{
		return new EntityBuffChangeInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemoveBuffId()
	{
		if (HasRemoveBuffId)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EntityBuffChangeInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntityBuffChangeInfo other)
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
		if (CastEntityId != other.CastEntityId)
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (!object.Equals(BuffChangeInfo, other.BuffChangeInfo))
		{
			return false;
		}
		if (RemoveBuffId != other.RemoveBuffId)
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (CastEntityId != 0)
		{
			num ^= CastEntityId.GetHashCode();
		}
		if (Reason != SceneEntityBuffChangeType.Default)
		{
			num ^= Reason.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BuffChangeInfo)
		{
			num ^= BuffChangeInfo.GetHashCode();
		}
		if (HasRemoveBuffId)
		{
			num ^= RemoveBuffId.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
			output.WriteRawTag(24);
			output.WriteUInt32(EntityId);
		}
		if (CastEntityId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CastEntityId);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BuffChangeInfo)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BuffChangeInfo);
		}
		if (Reason != SceneEntityBuffChangeType.Default)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Reason);
		}
		if (HasRemoveBuffId)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(RemoveBuffId);
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
		if (CastEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CastEntityId);
		}
		if (Reason != SceneEntityBuffChangeType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BuffChangeInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BuffChangeInfo);
		}
		if (HasRemoveBuffId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RemoveBuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntityBuffChangeInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
		}
		if (other.CastEntityId != 0)
		{
			CastEntityId = other.CastEntityId;
		}
		if (other.Reason != SceneEntityBuffChangeType.Default)
		{
			Reason = other.Reason;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.BuffChangeInfo:
			if (BuffChangeInfo == null)
			{
				BuffChangeInfo = new BuffInfo();
			}
			BuffChangeInfo.MergeFrom(other.BuffChangeInfo);
			break;
		case BPIHFAJCLOCOneofCase.RemoveBuffId:
			RemoveBuffId = other.RemoveBuffId;
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
			case 24u:
				EntityId = input.ReadUInt32();
				break;
			case 32u:
				CastEntityId = input.ReadUInt32();
				break;
			case 90u:
			{
				BuffInfo buffInfo = new BuffInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BuffChangeInfo)
				{
					buffInfo.MergeFrom(BuffChangeInfo);
				}
				input.ReadMessage(buffInfo);
				BuffChangeInfo = buffInfo;
				break;
			}
			case 96u:
				Reason = (SceneEntityBuffChangeType)input.ReadEnum();
				break;
			case 112u:
				RemoveBuffId = input.ReadUInt32();
				break;
			}
		}
	}
}
