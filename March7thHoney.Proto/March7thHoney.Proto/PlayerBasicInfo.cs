using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerBasicInfo : IMessage<PlayerBasicInfo>, IMessage, IEquatable<PlayerBasicInfo>, IDeepCloneable<PlayerBasicInfo>, IBufferMessage
{
	private static readonly MessageParser<PlayerBasicInfo> _parser = new MessageParser<PlayerBasicInfo>(() => new PlayerBasicInfo());

	private UnknownFieldSet _unknownFields;

	public const int NicknameFieldNumber = 1;

	private string nickname_ = "";

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int ExpFieldNumber = 3;

	private uint exp_;

	public const int StaminaFieldNumber = 4;

	private uint stamina_;

	public const int McoinFieldNumber = 5;

	private uint mcoin_;

	public const int HcoinFieldNumber = 6;

	private uint hcoin_;

	public const int ScoinFieldNumber = 7;

	private uint scoin_;

	public const int WorldLevelFieldNumber = 8;

	private uint worldLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerBasicInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerBasicInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Nickname
	{
		get
		{
			return nickname_;
		}
		set
		{
			nickname_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Stamina
	{
		get
		{
			return stamina_;
		}
		set
		{
			stamina_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Mcoin
	{
		get
		{
			return mcoin_;
		}
		set
		{
			mcoin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Hcoin
	{
		get
		{
			return hcoin_;
		}
		set
		{
			hcoin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Scoin
	{
		get
		{
			return scoin_;
		}
		set
		{
			scoin_ = value;
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
	public PlayerBasicInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBasicInfo(PlayerBasicInfo other)
		: this()
	{
		nickname_ = other.nickname_;
		level_ = other.level_;
		exp_ = other.exp_;
		stamina_ = other.stamina_;
		mcoin_ = other.mcoin_;
		hcoin_ = other.hcoin_;
		scoin_ = other.scoin_;
		worldLevel_ = other.worldLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBasicInfo Clone()
	{
		return new PlayerBasicInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerBasicInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerBasicInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Stamina != other.Stamina)
		{
			return false;
		}
		if (Mcoin != other.Mcoin)
		{
			return false;
		}
		if (Hcoin != other.Hcoin)
		{
			return false;
		}
		if (Scoin != other.Scoin)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
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
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Stamina != 0)
		{
			num ^= Stamina.GetHashCode();
		}
		if (Mcoin != 0)
		{
			num ^= Mcoin.GetHashCode();
		}
		if (Hcoin != 0)
		{
			num ^= Hcoin.GetHashCode();
		}
		if (Scoin != 0)
		{
			num ^= Scoin.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
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
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Nickname);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Exp);
		}
		if (Stamina != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Stamina);
		}
		if (Mcoin != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Mcoin);
		}
		if (Hcoin != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Hcoin);
		}
		if (Scoin != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Scoin);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(WorldLevel);
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
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Stamina != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stamina);
		}
		if (Mcoin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Mcoin);
		}
		if (Hcoin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hcoin);
		}
		if (Scoin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Scoin);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerBasicInfo other)
	{
		if (other != null)
		{
			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Stamina != 0)
			{
				Stamina = other.Stamina;
			}
			if (other.Mcoin != 0)
			{
				Mcoin = other.Mcoin;
			}
			if (other.Hcoin != 0)
			{
				Hcoin = other.Hcoin;
			}
			if (other.Scoin != 0)
			{
				Scoin = other.Scoin;
			}
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
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
			case 10u:
				Nickname = input.ReadString();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				Exp = input.ReadUInt32();
				break;
			case 32u:
				Stamina = input.ReadUInt32();
				break;
			case 40u:
				Mcoin = input.ReadUInt32();
				break;
			case 48u:
				Hcoin = input.ReadUInt32();
				break;
			case 56u:
				Scoin = input.ReadUInt32();
				break;
			case 64u:
				WorldLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
