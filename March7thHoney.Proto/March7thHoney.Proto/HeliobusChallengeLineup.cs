using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusChallengeLineup : IMessage<HeliobusChallengeLineup>, IMessage, IEquatable<HeliobusChallengeLineup>, IDeepCloneable<HeliobusChallengeLineup>, IBufferMessage
{
	private static readonly MessageParser<HeliobusChallengeLineup> _parser = new MessageParser<HeliobusChallengeLineup>(() => new HeliobusChallengeLineup());

	private UnknownFieldSet _unknownFields;

	public const int SkillIdFieldNumber = 1;

	private uint skillId_;

	public const int GroupIdFieldNumber = 2;

	private uint groupId_;

	public const int AvatarIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusChallengeLineup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusChallengeLineupReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeLineup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeLineup(HeliobusChallengeLineup other)
		: this()
	{
		skillId_ = other.skillId_;
		groupId_ = other.groupId_;
		avatarIdList_ = other.avatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeLineup Clone()
	{
		return new HeliobusChallengeLineup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusChallengeLineup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusChallengeLineup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
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
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= avatarIdList_.GetHashCode();
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
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(SkillId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GroupId);
		}
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
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
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusChallengeLineup other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			avatarIdList_.Add(other.avatarIdList_);
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
				SkillId = input.ReadUInt32();
				break;
			case 16u:
				GroupId = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			}
		}
	}
}
