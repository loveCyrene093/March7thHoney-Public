using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiceCombatAvatar : IMessage<DiceCombatAvatar>, IMessage, IEquatable<DiceCombatAvatar>, IDeepCloneable<DiceCombatAvatar>, IBufferMessage
{
	private static readonly MessageParser<DiceCombatAvatar> _parser = new MessageParser<DiceCombatAvatar>(() => new DiceCombatAvatar());

	private UnknownFieldSet _unknownFields;

	public const int DiceAvatarIdFieldNumber = 1;

	private uint diceAvatarId_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int DiceIdListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_diceIdList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> diceIdList_ = new RepeatedField<uint>();

	public const int UnlockTimeFieldNumber = 4;

	private long unlockTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiceCombatAvatar> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DiceCombatAvatarReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiceAvatarId
	{
		get
		{
			return diceAvatarId_;
		}
		set
		{
			diceAvatarId_ = value;
		}
	}

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
	public RepeatedField<uint> DiceIdList => diceIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UnlockTime
	{
		get
		{
			return unlockTime_;
		}
		set
		{
			unlockTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatAvatar()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatAvatar(DiceCombatAvatar other)
		: this()
	{
		diceAvatarId_ = other.diceAvatarId_;
		level_ = other.level_;
		diceIdList_ = other.diceIdList_.Clone();
		unlockTime_ = other.unlockTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatAvatar Clone()
	{
		return new DiceCombatAvatar(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DiceCombatAvatar);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiceCombatAvatar other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DiceAvatarId != other.DiceAvatarId)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!diceIdList_.Equals(other.diceIdList_))
		{
			return false;
		}
		if (UnlockTime != other.UnlockTime)
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
		if (DiceAvatarId != 0)
		{
			num ^= DiceAvatarId.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= diceIdList_.GetHashCode();
		if (UnlockTime != 0L)
		{
			num ^= UnlockTime.GetHashCode();
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
		if (DiceAvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DiceAvatarId);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		diceIdList_.WriteTo(ref output, _repeated_diceIdList_codec);
		if (UnlockTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(UnlockTime);
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
		if (DiceAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceAvatarId);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		num += diceIdList_.CalculateSize(_repeated_diceIdList_codec);
		if (UnlockTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UnlockTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DiceCombatAvatar other)
	{
		if (other != null)
		{
			if (other.DiceAvatarId != 0)
			{
				DiceAvatarId = other.DiceAvatarId;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			diceIdList_.Add(other.diceIdList_);
			if (other.UnlockTime != 0L)
			{
				UnlockTime = other.UnlockTime;
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
			case 8u:
				DiceAvatarId = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				diceIdList_.AddEntriesFrom(ref input, _repeated_diceIdList_codec);
				break;
			case 32u:
				UnlockTime = input.ReadInt64();
				break;
			}
		}
	}
}
