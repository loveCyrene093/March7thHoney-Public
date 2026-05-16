using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LineupAvatar : IMessage<LineupAvatar>, IMessage, IEquatable<LineupAvatar>, IDeepCloneable<LineupAvatar>, IBufferMessage
{
	private static readonly MessageParser<LineupAvatar> _parser = new MessageParser<LineupAvatar>(() => new LineupAvatar());

	private UnknownFieldSet _unknownFields;

	public const int SlotFieldNumber = 4;

	private uint slot_;

	public const int IdFieldNumber = 6;

	private uint id_;

	public const int HpFieldNumber = 9;

	private uint hp_;

	public const int SatietyFieldNumber = 11;

	private uint satiety_;

	public const int AvatarTypeFieldNumber = 12;

	private AvatarType avatarType_;

	public const int SpBarFieldNumber = 15;

	private SpBarInfo spBar_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LineupAvatar> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LineupAvatarReflection.Descriptor.MessageTypes[0];

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
	public uint Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Satiety
	{
		get
		{
			return satiety_;
		}
		set
		{
			satiety_ = value;
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
	public SpBarInfo SpBar
	{
		get
		{
			return spBar_;
		}
		set
		{
			spBar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupAvatar()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupAvatar(LineupAvatar other)
		: this()
	{
		slot_ = other.slot_;
		id_ = other.id_;
		hp_ = other.hp_;
		satiety_ = other.satiety_;
		avatarType_ = other.avatarType_;
		spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupAvatar Clone()
	{
		return new LineupAvatar(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LineupAvatar);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LineupAvatar other)
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
		if (Id != other.Id)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (Satiety != other.Satiety)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (!object.Equals(SpBar, other.SpBar))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (Satiety != 0)
		{
			num ^= Satiety.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (spBar_ != null)
		{
			num ^= SpBar.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(Slot);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Id);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Hp);
		}
		if (Satiety != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Satiety);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)AvatarType);
		}
		if (spBar_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(SpBar);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		if (Satiety != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Satiety);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (spBar_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpBar);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LineupAvatar other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Slot != 0)
		{
			Slot = other.Slot;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		if (other.Satiety != 0)
		{
			Satiety = other.Satiety;
		}
		if (other.AvatarType != AvatarType.None)
		{
			AvatarType = other.AvatarType;
		}
		if (other.spBar_ != null)
		{
			if (spBar_ == null)
			{
				SpBar = new SpBarInfo();
			}
			SpBar.MergeFrom(other.SpBar);
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
			case 32u:
				Slot = input.ReadUInt32();
				break;
			case 48u:
				Id = input.ReadUInt32();
				break;
			case 72u:
				Hp = input.ReadUInt32();
				break;
			case 88u:
				Satiety = input.ReadUInt32();
				break;
			case 96u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 122u:
				if (spBar_ == null)
				{
					SpBar = new SpBarInfo();
				}
				input.ReadMessage(SpBar);
				break;
			}
		}
	}
}
