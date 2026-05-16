using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LMIINHHKLNL : IMessage<LMIINHHKLNL>, IMessage, IEquatable<LMIINHHKLNL>, IDeepCloneable<LMIINHHKLNL>, IBufferMessage
{
	private static readonly MessageParser<LMIINHHKLNL> _parser = new MessageParser<LMIINHHKLNL>(() => new LMIINHHKLNL());

	private UnknownFieldSet _unknownFields;

	public const int OKHELIELNMEFieldNumber = 1;

	private bool oKHELIELNME_;

	public const int MonsterIdFieldNumber = 3;

	private uint monsterId_;

	public const int WorldLevelFieldNumber = 7;

	private uint worldLevel_;

	public const int JLGKLIDELBIFieldNumber = 10;

	private uint jLGKLIDELBI_;

	public const int ConfigIdFieldNumber = 12;

	private uint configId_;

	public const int CreateTimeFieldNumber = 13;

	private long createTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LMIINHHKLNL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LMIINHHKLNLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint JLGKLIDELBI
	{
		get
		{
			return jLGKLIDELBI_;
		}
		set
		{
			jLGKLIDELBI_ = value;
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
	public LMIINHHKLNL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMIINHHKLNL(LMIINHHKLNL other)
		: this()
	{
		oKHELIELNME_ = other.oKHELIELNME_;
		monsterId_ = other.monsterId_;
		worldLevel_ = other.worldLevel_;
		jLGKLIDELBI_ = other.jLGKLIDELBI_;
		configId_ = other.configId_;
		createTime_ = other.createTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMIINHHKLNL Clone()
	{
		return new LMIINHHKLNL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LMIINHHKLNL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LMIINHHKLNL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OKHELIELNME != other.OKHELIELNME)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (JLGKLIDELBI != other.JLGKLIDELBI)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
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
		if (OKHELIELNME)
		{
			num ^= OKHELIELNME.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (JLGKLIDELBI != 0)
		{
			num ^= JLGKLIDELBI.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
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
		if (OKHELIELNME)
		{
			output.WriteRawTag(8);
			output.WriteBool(OKHELIELNME);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MonsterId);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(WorldLevel);
		}
		if (JLGKLIDELBI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JLGKLIDELBI);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ConfigId);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(CreateTime);
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
		if (OKHELIELNME)
		{
			num += 2;
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (JLGKLIDELBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLGKLIDELBI);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreateTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LMIINHHKLNL other)
	{
		if (other != null)
		{
			if (other.OKHELIELNME)
			{
				OKHELIELNME = other.OKHELIELNME;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.WorldLevel != 0)
			{
				WorldLevel = other.WorldLevel;
			}
			if (other.JLGKLIDELBI != 0)
			{
				JLGKLIDELBI = other.JLGKLIDELBI;
			}
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.CreateTime != 0L)
			{
				CreateTime = other.CreateTime;
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
				OKHELIELNME = input.ReadBool();
				break;
			case 24u:
				MonsterId = input.ReadUInt32();
				break;
			case 56u:
				WorldLevel = input.ReadUInt32();
				break;
			case 80u:
				JLGKLIDELBI = input.ReadUInt32();
				break;
			case 96u:
				ConfigId = input.ReadUInt32();
				break;
			case 104u:
				CreateTime = input.ReadInt64();
				break;
			}
		}
	}
}
