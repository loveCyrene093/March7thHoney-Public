using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LineupSlotData : IMessage<LineupSlotData>, IMessage, IEquatable<LineupSlotData>, IDeepCloneable<LineupSlotData>, IBufferMessage
{
	private static readonly MessageParser<LineupSlotData> _parser = new MessageParser<LineupSlotData>(() => new LineupSlotData());

	private UnknownFieldSet _unknownFields;

	public const int SlotFieldNumber = 3;

	private uint slot_;

	public const int AvatarTypeFieldNumber = 4;

	private AvatarType avatarType_;

	public const int IdFieldNumber = 7;

	private uint id_;

	public const int AssistUidFieldNumber = 13;

	private uint assistUid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LineupSlotData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LineupSlotDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarType AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AssistUid
	{
		get
		{
			return assistUid_;
		}
		set
		{
			assistUid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupSlotData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupSlotData(LineupSlotData other)
		: this()
	{
		slot_ = other.slot_;
		avatarType_ = other.avatarType_;
		id_ = other.id_;
		assistUid_ = other.assistUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupSlotData Clone()
	{
		return new LineupSlotData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LineupSlotData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LineupSlotData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Slot != other.Slot)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (AssistUid != other.AssistUid)
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (AssistUid != 0)
		{
			num ^= AssistUid.GetHashCode();
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
		if (Slot != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Slot);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)AvatarType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Id);
		}
		if (AssistUid != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AssistUid);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (AssistUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AssistUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LineupSlotData other)
	{
		if (other != null)
		{
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.AssistUid != 0)
			{
				AssistUid = other.AssistUid;
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
			case 24u:
				Slot = input.ReadUInt32();
				break;
			case 32u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 56u:
				Id = input.ReadUInt32();
				break;
			case 104u:
				AssistUid = input.ReadUInt32();
				break;
			}
		}
	}
}
