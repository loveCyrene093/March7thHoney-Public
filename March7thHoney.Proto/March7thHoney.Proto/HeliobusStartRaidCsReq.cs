using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusStartRaidCsReq : IMessage<HeliobusStartRaidCsReq>, IMessage, IEquatable<HeliobusStartRaidCsReq>, IDeepCloneable<HeliobusStartRaidCsReq>, IBufferMessage
{
	private static readonly MessageParser<HeliobusStartRaidCsReq> _parser = new MessageParser<HeliobusStartRaidCsReq>(() => new HeliobusStartRaidCsReq());

	private UnknownFieldSet _unknownFields;

	public const int RaidIdFieldNumber = 6;

	private uint raidId_;

	public const int PropEntityIdFieldNumber = 9;

	private uint propEntityId_;

	public const int IsSaveFieldNumber = 11;

	private bool isSave_;

	public const int SkillIdFieldNumber = 13;

	private uint skillId_;

	public const int PKBAEBDHFDLFieldNumber = 14;

	private uint pKBAEBDHFDL_;

	public const int AvatarListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusStartRaidCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusStartRaidCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RaidId
	{
		get
		{
			return raidId_;
		}
		set
		{
			raidId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSave
	{
		get
		{
			return isSave_;
		}
		set
		{
			isSave_ = value;
		}
	}

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
	public uint PKBAEBDHFDL
	{
		get
		{
			return pKBAEBDHFDL_;
		}
		set
		{
			pKBAEBDHFDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusStartRaidCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusStartRaidCsReq(HeliobusStartRaidCsReq other)
		: this()
	{
		raidId_ = other.raidId_;
		propEntityId_ = other.propEntityId_;
		isSave_ = other.isSave_;
		skillId_ = other.skillId_;
		pKBAEBDHFDL_ = other.pKBAEBDHFDL_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusStartRaidCsReq Clone()
	{
		return new HeliobusStartRaidCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusStartRaidCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusStartRaidCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RaidId != other.RaidId)
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (IsSave != other.IsSave)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (PKBAEBDHFDL != other.PKBAEBDHFDL)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
		}
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (IsSave)
		{
			num ^= IsSave.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (PKBAEBDHFDL != 0)
		{
			num ^= PKBAEBDHFDL.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (RaidId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(RaidId);
		}
		if (PropEntityId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PropEntityId);
		}
		if (IsSave)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsSave);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(SkillId);
		}
		if (PKBAEBDHFDL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PKBAEBDHFDL);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (IsSave)
		{
			num += 2;
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (PKBAEBDHFDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKBAEBDHFDL);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusStartRaidCsReq other)
	{
		if (other != null)
		{
			if (other.RaidId != 0)
			{
				RaidId = other.RaidId;
			}
			if (other.PropEntityId != 0)
			{
				PropEntityId = other.PropEntityId;
			}
			if (other.IsSave)
			{
				IsSave = other.IsSave;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.PKBAEBDHFDL != 0)
			{
				PKBAEBDHFDL = other.PKBAEBDHFDL;
			}
			avatarList_.Add(other.avatarList_);
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
			case 48u:
				RaidId = input.ReadUInt32();
				break;
			case 72u:
				PropEntityId = input.ReadUInt32();
				break;
			case 88u:
				IsSave = input.ReadBool();
				break;
			case 104u:
				SkillId = input.ReadUInt32();
				break;
			case 112u:
				PKBAEBDHFDL = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
