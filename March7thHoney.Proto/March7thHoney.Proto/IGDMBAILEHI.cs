using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IGDMBAILEHI : IMessage<IGDMBAILEHI>, IMessage, IEquatable<IGDMBAILEHI>, IDeepCloneable<IGDMBAILEHI>, IBufferMessage
{
	private static readonly MessageParser<IGDMBAILEHI> _parser = new MessageParser<IGDMBAILEHI>(() => new IGDMBAILEHI());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int IdFieldNumber = 11;

	private uint id_;

	public const int SlotFieldNumber = 13;

	private uint slot_;

	public const int AvatarTypeFieldNumber = 15;

	private AvatarType avatarType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IGDMBAILEHI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IGDMBAILEHIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
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
	public IGDMBAILEHI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGDMBAILEHI(IGDMBAILEHI other)
		: this()
	{
		level_ = other.level_;
		id_ = other.id_;
		slot_ = other.slot_;
		avatarType_ = other.avatarType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGDMBAILEHI Clone()
	{
		return new IGDMBAILEHI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IGDMBAILEHI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IGDMBAILEHI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Slot != other.Slot)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Id);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Slot);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)AvatarType);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IGDMBAILEHI other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
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
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				Id = input.ReadUInt32();
				break;
			case 104u:
				Slot = input.ReadUInt32();
				break;
			case 120u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			}
		}
	}
}
