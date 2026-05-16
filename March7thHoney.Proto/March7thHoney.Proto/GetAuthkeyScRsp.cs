using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAuthkeyScRsp : IMessage<GetAuthkeyScRsp>, IMessage, IEquatable<GetAuthkeyScRsp>, IDeepCloneable<GetAuthkeyScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAuthkeyScRsp> _parser = new MessageParser<GetAuthkeyScRsp>(() => new GetAuthkeyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int AuthAppidFieldNumber = 4;

	private string authAppid_ = "";

	public const int SignTypeFieldNumber = 7;

	private uint signType_;

	public const int AuthkeyFieldNumber = 10;

	private string authkey_ = "";

	public const int AuthkeyVerFieldNumber = 14;

	private uint authkeyVer_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAuthkeyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAuthkeyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public string AuthAppid
	{
		get
		{
			return authAppid_;
		}
		set
		{
			authAppid_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint AuthkeyVer
	{
		get
		{
			return authkeyVer_;
		}
		set
		{
			authkeyVer_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAuthkeyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAuthkeyScRsp(GetAuthkeyScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		authAppid_ = other.authAppid_;
		signType_ = other.signType_;
		authkey_ = other.authkey_;
		authkeyVer_ = other.authkeyVer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAuthkeyScRsp Clone()
	{
		return new GetAuthkeyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAuthkeyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAuthkeyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (AuthAppid != other.AuthAppid)
		{
			return false;
		}
		if (SignType != other.SignType)
		{
			return false;
		}
		if (Authkey != other.Authkey)
		{
			return false;
		}
		if (AuthkeyVer != other.AuthkeyVer)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (AuthAppid.Length != 0)
		{
			num ^= AuthAppid.GetHashCode();
		}
		if (SignType != 0)
		{
			num ^= SignType.GetHashCode();
		}
		if (Authkey.Length != 0)
		{
			num ^= Authkey.GetHashCode();
		}
		if (AuthkeyVer != 0)
		{
			num ^= AuthkeyVer.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (AuthAppid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AuthAppid);
		}
		if (SignType != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SignType);
		}
		if (Authkey.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Authkey);
		}
		if (AuthkeyVer != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AuthkeyVer);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (AuthAppid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AuthAppid);
		}
		if (SignType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SignType);
		}
		if (Authkey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Authkey);
		}
		if (AuthkeyVer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AuthkeyVer);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAuthkeyScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.AuthAppid.Length != 0)
			{
				AuthAppid = other.AuthAppid;
			}
			if (other.SignType != 0)
			{
				SignType = other.SignType;
			}
			if (other.Authkey.Length != 0)
			{
				Authkey = other.Authkey;
			}
			if (other.AuthkeyVer != 0)
			{
				AuthkeyVer = other.AuthkeyVer;
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
				Retcode = input.ReadUInt32();
				break;
			case 34u:
				AuthAppid = input.ReadString();
				break;
			case 56u:
				SignType = input.ReadUInt32();
				break;
			case 82u:
				Authkey = input.ReadString();
				break;
			case 112u:
				AuthkeyVer = input.ReadUInt32();
				break;
			}
		}
	}
}
