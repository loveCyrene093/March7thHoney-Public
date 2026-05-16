using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerGetTokenCsReq : IMessage<PlayerGetTokenCsReq>, IMessage, IEquatable<PlayerGetTokenCsReq>, IDeepCloneable<PlayerGetTokenCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayerGetTokenCsReq> _parser = new MessageParser<PlayerGetTokenCsReq>(() => new PlayerGetTokenCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AccountUidFieldNumber = 2;

	private string accountUid_ = "";

	public const int AccountIpPortFieldNumber = 3;

	private uint accountIpPort_;

	public const int AccountIpFieldNumber = 4;

	private uint accountIp_;

	public const int EFKCMFIJGIJFieldNumber = 5;

	private uint eFKCMFIJGIJ_;

	public const int AccountUidErr1FieldNumber = 6;

	private string accountUidErr1_ = "";

	public const int TokenFieldNumber = 7;

	private string token_ = "";

	public const int UidFieldNumber = 8;

	private uint uid_;

	public const int PlatformFieldNumber = 10;

	private uint platform_;

	public const int SignTypeFieldNumber = 15;

	private uint signType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerGetTokenCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerGetTokenCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AccountUid
	{
		get
		{
			return accountUid_;
		}
		set
		{
			accountUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AccountIpPort
	{
		get
		{
			return accountIpPort_;
		}
		set
		{
			accountIpPort_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AccountIp
	{
		get
		{
			return accountIp_;
		}
		set
		{
			accountIp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EFKCMFIJGIJ
	{
		get
		{
			return eFKCMFIJGIJ_;
		}
		set
		{
			eFKCMFIJGIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AccountUidErr1
	{
		get
		{
			return accountUidErr1_;
		}
		set
		{
			accountUidErr1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Token
	{
		get
		{
			return token_;
		}
		set
		{
			token_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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
	public uint Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SignType
	{
		get
		{
			return signType_;
		}
		set
		{
			signType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerGetTokenCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerGetTokenCsReq(PlayerGetTokenCsReq other)
		: this()
	{
		accountUid_ = other.accountUid_;
		accountIpPort_ = other.accountIpPort_;
		accountIp_ = other.accountIp_;
		eFKCMFIJGIJ_ = other.eFKCMFIJGIJ_;
		accountUidErr1_ = other.accountUidErr1_;
		token_ = other.token_;
		uid_ = other.uid_;
		platform_ = other.platform_;
		signType_ = other.signType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerGetTokenCsReq Clone()
	{
		return new PlayerGetTokenCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerGetTokenCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerGetTokenCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AccountUid != other.AccountUid)
		{
			return false;
		}
		if (AccountIpPort != other.AccountIpPort)
		{
			return false;
		}
		if (AccountIp != other.AccountIp)
		{
			return false;
		}
		if (EFKCMFIJGIJ != other.EFKCMFIJGIJ)
		{
			return false;
		}
		if (AccountUidErr1 != other.AccountUidErr1)
		{
			return false;
		}
		if (Token != other.Token)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (SignType != other.SignType)
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
		if (AccountUid.Length != 0)
		{
			num ^= AccountUid.GetHashCode();
		}
		if (AccountIpPort != 0)
		{
			num ^= AccountIpPort.GetHashCode();
		}
		if (AccountIp != 0)
		{
			num ^= AccountIp.GetHashCode();
		}
		if (EFKCMFIJGIJ != 0)
		{
			num ^= EFKCMFIJGIJ.GetHashCode();
		}
		if (AccountUidErr1.Length != 0)
		{
			num ^= AccountUidErr1.GetHashCode();
		}
		if (Token.Length != 0)
		{
			num ^= Token.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Platform != 0)
		{
			num ^= Platform.GetHashCode();
		}
		if (SignType != 0)
		{
			num ^= SignType.GetHashCode();
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
		if (AccountUid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AccountUid);
		}
		if (AccountIpPort != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AccountIpPort);
		}
		if (AccountIp != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AccountIp);
		}
		if (EFKCMFIJGIJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EFKCMFIJGIJ);
		}
		if (AccountUidErr1.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AccountUidErr1);
		}
		if (Token.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Token);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Uid);
		}
		if (Platform != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Platform);
		}
		if (SignType != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(SignType);
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
		if (AccountUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccountUid);
		}
		if (AccountIpPort != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AccountIpPort);
		}
		if (AccountIp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AccountIp);
		}
		if (EFKCMFIJGIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFKCMFIJGIJ);
		}
		if (AccountUidErr1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccountUidErr1);
		}
		if (Token.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Token);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Platform != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Platform);
		}
		if (SignType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SignType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerGetTokenCsReq other)
	{
		if (other != null)
		{
			if (other.AccountUid.Length != 0)
			{
				AccountUid = other.AccountUid;
			}
			if (other.AccountIpPort != 0)
			{
				AccountIpPort = other.AccountIpPort;
			}
			if (other.AccountIp != 0)
			{
				AccountIp = other.AccountIp;
			}
			if (other.EFKCMFIJGIJ != 0)
			{
				EFKCMFIJGIJ = other.EFKCMFIJGIJ;
			}
			if (other.AccountUidErr1.Length != 0)
			{
				AccountUidErr1 = other.AccountUidErr1;
			}
			if (other.Token.Length != 0)
			{
				Token = other.Token;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.Platform != 0)
			{
				Platform = other.Platform;
			}
			if (other.SignType != 0)
			{
				SignType = other.SignType;
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
			case 18u:
				AccountUid = input.ReadString();
				break;
			case 24u:
				AccountIpPort = input.ReadUInt32();
				break;
			case 32u:
				AccountIp = input.ReadUInt32();
				break;
			case 40u:
				EFKCMFIJGIJ = input.ReadUInt32();
				break;
			case 50u:
				AccountUidErr1 = input.ReadString();
				break;
			case 58u:
				Token = input.ReadString();
				break;
			case 64u:
				Uid = input.ReadUInt32();
				break;
			case 80u:
				Platform = input.ReadUInt32();
				break;
			case 120u:
				SignType = input.ReadUInt32();
				break;
			}
		}
	}
}
