using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusEnterBattleCsReq : IMessage<HeliobusEnterBattleCsReq>, IMessage, IEquatable<HeliobusEnterBattleCsReq>, IDeepCloneable<HeliobusEnterBattleCsReq>, IBufferMessage
{
	private static readonly MessageParser<HeliobusEnterBattleCsReq> _parser = new MessageParser<HeliobusEnterBattleCsReq>(() => new HeliobusEnterBattleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 8;

	private uint eventId_;

	public const int AvatarIdListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int SkillIdFieldNumber = 11;

	private uint skillId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusEnterBattleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusEnterBattleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

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
	public HeliobusEnterBattleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusEnterBattleCsReq(HeliobusEnterBattleCsReq other)
		: this()
	{
		eventId_ = other.eventId_;
		avatarIdList_ = other.avatarIdList_.Clone();
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusEnterBattleCsReq Clone()
	{
		return new HeliobusEnterBattleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusEnterBattleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusEnterBattleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (SkillId != other.SkillId)
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
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		num ^= avatarIdList_.GetHashCode();
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
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
		if (EventId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EventId);
		}
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		if (SkillId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(SkillId);
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
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusEnterBattleCsReq other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			avatarIdList_.Add(other.avatarIdList_);
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
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
			case 64u:
				EventId = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 88u:
				SkillId = input.ReadUInt32();
				break;
			}
		}
	}
}
