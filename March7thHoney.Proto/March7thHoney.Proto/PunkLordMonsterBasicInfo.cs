using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PunkLordMonsterBasicInfo : IMessage<PunkLordMonsterBasicInfo>, IMessage, IEquatable<PunkLordMonsterBasicInfo>, IDeepCloneable<PunkLordMonsterBasicInfo>, IBufferMessage
{
	private static readonly MessageParser<PunkLordMonsterBasicInfo> _parser = new MessageParser<PunkLordMonsterBasicInfo>(() => new PunkLordMonsterBasicInfo());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 1;

	private uint uid_;

	public const int MonsterIdFieldNumber = 2;

	private uint monsterId_;

	public const int ConfigIdFieldNumber = 3;

	private uint configId_;

	public const int WorldLevelFieldNumber = 4;

	private uint worldLevel_;

	public const int CreateTimeFieldNumber = 5;

	private long createTime_;

	public const int LeftHpFieldNumber = 6;

	private uint leftHp_;

	public const int AttackerNumFieldNumber = 7;

	private uint attackerNum_;

	public const int ShareTypeFieldNumber = 8;

	private PunkLordShareType shareType_;

	public const int OKHELIELNMEFieldNumber = 9;

	private bool oKHELIELNME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PunkLordMonsterBasicInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PunkLordMonsterBasicInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LeftHp
	{
		get
		{
			return leftHp_;
		}
		set
		{
			leftHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AttackerNum
	{
		get
		{
			return attackerNum_;
		}
		set
		{
			attackerNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordShareType ShareType
	{
		get
		{
			return shareType_;
		}
		set
		{
			shareType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OKHELIELNME
	{
		get
		{
			return oKHELIELNME_;
		}
		set
		{
			oKHELIELNME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo(PunkLordMonsterBasicInfo other)
		: this()
	{
		uid_ = other.uid_;
		monsterId_ = other.monsterId_;
		configId_ = other.configId_;
		worldLevel_ = other.worldLevel_;
		createTime_ = other.createTime_;
		leftHp_ = other.leftHp_;
		attackerNum_ = other.attackerNum_;
		shareType_ = other.shareType_;
		oKHELIELNME_ = other.oKHELIELNME_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo Clone()
	{
		return new PunkLordMonsterBasicInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PunkLordMonsterBasicInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PunkLordMonsterBasicInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (LeftHp != other.LeftHp)
		{
			return false;
		}
		if (AttackerNum != other.AttackerNum)
		{
			return false;
		}
		if (ShareType != other.ShareType)
		{
			return false;
		}
		if (OKHELIELNME != other.OKHELIELNME)
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (LeftHp != 0)
		{
			num ^= LeftHp.GetHashCode();
		}
		if (AttackerNum != 0)
		{
			num ^= AttackerNum.GetHashCode();
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			num ^= ShareType.GetHashCode();
		}
		if (OKHELIELNME)
		{
			num ^= OKHELIELNME.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Uid);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MonsterId);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ConfigId);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(WorldLevel);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(CreateTime);
		}
		if (LeftHp != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LeftHp);
		}
		if (AttackerNum != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AttackerNum);
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)ShareType);
		}
		if (OKHELIELNME)
		{
			output.WriteRawTag(72);
			output.WriteBool(OKHELIELNME);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreateTime);
		}
		if (LeftHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LeftHp);
		}
		if (AttackerNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AttackerNum);
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ShareType);
		}
		if (OKHELIELNME)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PunkLordMonsterBasicInfo other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
			}
			if (other.CreateTime != 0L)
			{
				CreateTime = other.CreateTime;
			}
			if (other.LeftHp != 0)
			{
				LeftHp = other.LeftHp;
			}
			if (other.AttackerNum != 0)
			{
				AttackerNum = other.AttackerNum;
			}
			if (other.ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
			{
				ShareType = other.ShareType;
			}
			if (other.OKHELIELNME)
			{
				OKHELIELNME = other.OKHELIELNME;
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
				Uid = input.ReadUInt32();
				break;
			case 16u:
				MonsterId = input.ReadUInt32();
				break;
			case 24u:
				ConfigId = input.ReadUInt32();
				break;
			case 32u:
				WorldLevel = input.ReadUInt32();
				break;
			case 40u:
				CreateTime = input.ReadInt64();
				break;
			case 48u:
				LeftHp = input.ReadUInt32();
				break;
			case 56u:
				AttackerNum = input.ReadUInt32();
				break;
			case 64u:
				ShareType = (PunkLordShareType)input.ReadEnum();
				break;
			case 72u:
				OKHELIELNME = input.ReadBool();
				break;
			}
		}
	}
}
