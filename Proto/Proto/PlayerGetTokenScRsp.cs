using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerGetTokenScRsp : IMessage<PlayerGetTokenScRsp>, IMessage, IEquatable<PlayerGetTokenScRsp>, IDeepCloneable<PlayerGetTokenScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerGetTokenScRsp> _parser = new MessageParser<PlayerGetTokenScRsp>(() => new PlayerGetTokenScRsp());

	private UnknownFieldSet _unknownFields;

	public const int StopDescFieldNumber = 1;

	private string stopDesc_ = "";

	public const int AuthkeyFieldNumber = 2;

	private string authkey_ = "";

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int SecretKeySeedFieldNumber = 8;

	private ulong secretKeySeed_;

	public const int UidFieldNumber = 11;

	private uint uid_;

	public const int BlackInfoFieldNumber = 14;

	private BlackInfo blackInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerGetTokenScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerGetTokenScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StopDesc
	{
		get
		{
			return stopDesc_;
		}
		set
		{
			stopDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Authkey
	{
		get
		{
			return authkey_;
		}
		set
		{
			authkey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong SecretKeySeed
	{
		get
		{
			return secretKeySeed_;
		}
		set
		{
			secretKeySeed_ = value;
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
	public BlackInfo BlackInfo
	{
		get
		{
			return blackInfo_;
		}
		set
		{
			blackInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerGetTokenScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerGetTokenScRsp(PlayerGetTokenScRsp other)
		: this()
	{
		stopDesc_ = other.stopDesc_;
		authkey_ = other.authkey_;
		retcode_ = other.retcode_;
		secretKeySeed_ = other.secretKeySeed_;
		uid_ = other.uid_;
		blackInfo_ = ((other.blackInfo_ != null) ? other.blackInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerGetTokenScRsp Clone()
	{
		return new PlayerGetTokenScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerGetTokenScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerGetTokenScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StopDesc != other.StopDesc)
		{
			return false;
		}
		if (Authkey != other.Authkey)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (SecretKeySeed != other.SecretKeySeed)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (!object.Equals(BlackInfo, other.BlackInfo))
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
		if (StopDesc.Length != 0)
		{
			num ^= StopDesc.GetHashCode();
		}
		if (Authkey.Length != 0)
		{
			num ^= Authkey.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (SecretKeySeed != 0L)
		{
			num ^= SecretKeySeed.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (blackInfo_ != null)
		{
			num ^= BlackInfo.GetHashCode();
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
		if (StopDesc.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StopDesc);
		}
		if (Authkey.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Authkey);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (SecretKeySeed != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(SecretKeySeed);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Uid);
		}
		if (blackInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BlackInfo);
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
		if (StopDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StopDesc);
		}
		if (Authkey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Authkey);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (SecretKeySeed != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SecretKeySeed);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (blackInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BlackInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerGetTokenScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.StopDesc.Length != 0)
		{
			StopDesc = other.StopDesc;
		}
		if (other.Authkey.Length != 0)
		{
			Authkey = other.Authkey;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.SecretKeySeed != 0L)
		{
			SecretKeySeed = other.SecretKeySeed;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.blackInfo_ != null)
		{
			if (blackInfo_ == null)
			{
				BlackInfo = new BlackInfo();
			}
			BlackInfo.MergeFrom(other.BlackInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				StopDesc = input.ReadString();
				break;
			case 18u:
				Authkey = input.ReadString();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				SecretKeySeed = input.ReadUInt64();
				break;
			case 88u:
				Uid = input.ReadUInt32();
				break;
			case 114u:
				if (blackInfo_ == null)
				{
					BlackInfo = new BlackInfo();
				}
				input.ReadMessage(BlackInfo);
				break;
			}
		}
	}
}
