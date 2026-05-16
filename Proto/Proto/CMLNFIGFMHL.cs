using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CMLNFIGFMHL : IMessage<CMLNFIGFMHL>, IMessage, IEquatable<CMLNFIGFMHL>, IDeepCloneable<CMLNFIGFMHL>, IBufferMessage
{
	private static readonly MessageParser<CMLNFIGFMHL> _parser = new MessageParser<CMLNFIGFMHL>(() => new CMLNFIGFMHL());

	private UnknownFieldSet _unknownFields;

	public const int ClientResVersionFieldNumber = 2;

	private uint clientResVersion_;

	public const int UidFieldNumber = 3;

	private uint uid_;

	public const int AccountIpFieldNumber = 4;

	private uint accountIp_;

	public const int ODKFCCOHAFMFieldNumber = 5;

	private ulong oDKFCCOHAFM_;

	public const int PlatformFieldNumber = 7;

	private uint platform_;

	public const int AccountIpPortFieldNumber = 11;

	private uint accountIpPort_;

	public const int KFMAEGNNJDLFieldNumber = 12;

	private uint kFMAEGNNJDL_;

	public const int IHJGLGCLANMFieldNumber = 13;

	private string iHJGLGCLANM_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CMLNFIGFMHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CMLNFIGFMHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClientResVersion
	{
		get
		{
			return clientResVersion_;
		}
		set
		{
			clientResVersion_ = value;
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
	public ulong ODKFCCOHAFM
	{
		get
		{
			return oDKFCCOHAFM_;
		}
		set
		{
			oDKFCCOHAFM_ = value;
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
	public uint KFMAEGNNJDL
	{
		get
		{
			return kFMAEGNNJDL_;
		}
		set
		{
			kFMAEGNNJDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IHJGLGCLANM
	{
		get
		{
			return iHJGLGCLANM_;
		}
		set
		{
			iHJGLGCLANM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMLNFIGFMHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMLNFIGFMHL(CMLNFIGFMHL other)
		: this()
	{
		clientResVersion_ = other.clientResVersion_;
		uid_ = other.uid_;
		accountIp_ = other.accountIp_;
		oDKFCCOHAFM_ = other.oDKFCCOHAFM_;
		platform_ = other.platform_;
		accountIpPort_ = other.accountIpPort_;
		kFMAEGNNJDL_ = other.kFMAEGNNJDL_;
		iHJGLGCLANM_ = other.iHJGLGCLANM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMLNFIGFMHL Clone()
	{
		return new CMLNFIGFMHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CMLNFIGFMHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CMLNFIGFMHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ClientResVersion != other.ClientResVersion)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (AccountIp != other.AccountIp)
		{
			return false;
		}
		if (ODKFCCOHAFM != other.ODKFCCOHAFM)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (AccountIpPort != other.AccountIpPort)
		{
			return false;
		}
		if (KFMAEGNNJDL != other.KFMAEGNNJDL)
		{
			return false;
		}
		if (IHJGLGCLANM != other.IHJGLGCLANM)
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
		if (ClientResVersion != 0)
		{
			num ^= ClientResVersion.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (AccountIp != 0)
		{
			num ^= AccountIp.GetHashCode();
		}
		if (ODKFCCOHAFM != 0L)
		{
			num ^= ODKFCCOHAFM.GetHashCode();
		}
		if (Platform != 0)
		{
			num ^= Platform.GetHashCode();
		}
		if (AccountIpPort != 0)
		{
			num ^= AccountIpPort.GetHashCode();
		}
		if (KFMAEGNNJDL != 0)
		{
			num ^= KFMAEGNNJDL.GetHashCode();
		}
		if (IHJGLGCLANM.Length != 0)
		{
			num ^= IHJGLGCLANM.GetHashCode();
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
		if (ClientResVersion != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ClientResVersion);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Uid);
		}
		if (AccountIp != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AccountIp);
		}
		if (ODKFCCOHAFM != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(ODKFCCOHAFM);
		}
		if (Platform != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Platform);
		}
		if (AccountIpPort != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AccountIpPort);
		}
		if (KFMAEGNNJDL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KFMAEGNNJDL);
		}
		if (IHJGLGCLANM.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(IHJGLGCLANM);
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
		if (ClientResVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientResVersion);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (AccountIp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AccountIp);
		}
		if (ODKFCCOHAFM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ODKFCCOHAFM);
		}
		if (Platform != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Platform);
		}
		if (AccountIpPort != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AccountIpPort);
		}
		if (KFMAEGNNJDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFMAEGNNJDL);
		}
		if (IHJGLGCLANM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IHJGLGCLANM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CMLNFIGFMHL other)
	{
		if (other != null)
		{
			if (other.ClientResVersion != 0)
			{
				ClientResVersion = other.ClientResVersion;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.AccountIp != 0)
			{
				AccountIp = other.AccountIp;
			}
			if (other.ODKFCCOHAFM != 0L)
			{
				ODKFCCOHAFM = other.ODKFCCOHAFM;
			}
			if (other.Platform != 0)
			{
				Platform = other.Platform;
			}
			if (other.AccountIpPort != 0)
			{
				AccountIpPort = other.AccountIpPort;
			}
			if (other.KFMAEGNNJDL != 0)
			{
				KFMAEGNNJDL = other.KFMAEGNNJDL;
			}
			if (other.IHJGLGCLANM.Length != 0)
			{
				IHJGLGCLANM = other.IHJGLGCLANM;
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
			case 16u:
				ClientResVersion = input.ReadUInt32();
				break;
			case 24u:
				Uid = input.ReadUInt32();
				break;
			case 32u:
				AccountIp = input.ReadUInt32();
				break;
			case 40u:
				ODKFCCOHAFM = input.ReadUInt64();
				break;
			case 56u:
				Platform = input.ReadUInt32();
				break;
			case 88u:
				AccountIpPort = input.ReadUInt32();
				break;
			case 96u:
				KFMAEGNNJDL = input.ReadUInt32();
				break;
			case 106u:
				IHJGLGCLANM = input.ReadString();
				break;
			}
		}
	}
}
