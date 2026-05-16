using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakBuild : IMessage<ChallengePeakBuild>, IMessage, IEquatable<ChallengePeakBuild>, IDeepCloneable<ChallengePeakBuild>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakBuild> _parser = new MessageParser<ChallengePeakBuild>(() => new ChallengePeakBuild());

	private UnknownFieldSet _unknownFields;

	public const int EquipmentUniqueIdFieldNumber = 4;

	private uint equipmentUniqueId_;

	public const int RelicListFieldNumber = 5;

	private static readonly FieldCodec<EquipRelic> _repeated_relicList_codec = FieldCodec.ForMessage(42u, EquipRelic.Parser);

	private readonly RepeatedField<EquipRelic> relicList_ = new RepeatedField<EquipRelic>();

	public const int AvatarTypeFieldNumber = 6;

	private uint avatarType_;

	public const int CBHKFOEOMFFFieldNumber = 12;

	private uint cBHKFOEOMFF_;

	public const int AvatarIdFieldNumber = 13;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakBuild> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakBuildReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EquipmentUniqueId
	{
		get
		{
			return equipmentUniqueId_;
		}
		set
		{
			equipmentUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipRelic> RelicList => relicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarType
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
	public uint CBHKFOEOMFF
	{
		get
		{
			return cBHKFOEOMFF_;
		}
		set
		{
			cBHKFOEOMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBuild()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBuild(ChallengePeakBuild other)
		: this()
	{
		equipmentUniqueId_ = other.equipmentUniqueId_;
		relicList_ = other.relicList_.Clone();
		avatarType_ = other.avatarType_;
		cBHKFOEOMFF_ = other.cBHKFOEOMFF_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakBuild Clone()
	{
		return new ChallengePeakBuild(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakBuild);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakBuild other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipmentUniqueId != other.EquipmentUniqueId)
		{
			return false;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (CBHKFOEOMFF != other.CBHKFOEOMFF)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (EquipmentUniqueId != 0)
		{
			num ^= EquipmentUniqueId.GetHashCode();
		}
		num ^= relicList_.GetHashCode();
		if (AvatarType != 0)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (CBHKFOEOMFF != 0)
		{
			num ^= CBHKFOEOMFF.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		if (EquipmentUniqueId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EquipmentUniqueId);
		}
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		if (AvatarType != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AvatarType);
		}
		if (CBHKFOEOMFF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CBHKFOEOMFF);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AvatarId);
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
		if (EquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EquipmentUniqueId);
		}
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		if (AvatarType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarType);
		}
		if (CBHKFOEOMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBHKFOEOMFF);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakBuild other)
	{
		if (other != null)
		{
			if (other.EquipmentUniqueId != 0)
			{
				EquipmentUniqueId = other.EquipmentUniqueId;
			}
			relicList_.Add(other.relicList_);
			if (other.AvatarType != 0)
			{
				AvatarType = other.AvatarType;
			}
			if (other.CBHKFOEOMFF != 0)
			{
				CBHKFOEOMFF = other.CBHKFOEOMFF;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
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
			case 32u:
				EquipmentUniqueId = input.ReadUInt32();
				break;
			case 42u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 48u:
				AvatarType = input.ReadUInt32();
				break;
			case 96u:
				CBHKFOEOMFF = input.ReadUInt32();
				break;
			case 104u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
