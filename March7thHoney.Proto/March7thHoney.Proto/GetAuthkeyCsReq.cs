using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAuthkeyCsReq : IMessage<GetAuthkeyCsReq>, IMessage, IEquatable<GetAuthkeyCsReq>, IDeepCloneable<GetAuthkeyCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetAuthkeyCsReq> _parser = new MessageParser<GetAuthkeyCsReq>(() => new GetAuthkeyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AuthkeyVerFieldNumber = 3;

	private uint authkeyVer_;

	public const int SignTypeFieldNumber = 7;

	private uint signType_;

	public const int AuthAppidFieldNumber = 15;

	private string authAppid_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAuthkeyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAuthkeyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GetAuthkeyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAuthkeyCsReq(GetAuthkeyCsReq other)
		: this()
	{
		authkeyVer_ = other.authkeyVer_;
		signType_ = other.signType_;
		authAppid_ = other.authAppid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAuthkeyCsReq Clone()
	{
		return new GetAuthkeyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAuthkeyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAuthkeyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AuthkeyVer != other.AuthkeyVer)
		{
			return false;
		}
		if (SignType != other.SignType)
		{
			return false;
		}
		if (AuthAppid != other.AuthAppid)
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
		if (AuthkeyVer != 0)
		{
			num ^= AuthkeyVer.GetHashCode();
		}
		if (SignType != 0)
		{
			num ^= SignType.GetHashCode();
		}
		if (AuthAppid.Length != 0)
		{
			num ^= AuthAppid.GetHashCode();
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
		if (AuthkeyVer != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AuthkeyVer);
		}
		if (SignType != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SignType);
		}
		if (AuthAppid.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(AuthAppid);
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
		if (AuthkeyVer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AuthkeyVer);
		}
		if (SignType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SignType);
		}
		if (AuthAppid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AuthAppid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAuthkeyCsReq other)
	{
		if (other != null)
		{
			if (other.AuthkeyVer != 0)
			{
				AuthkeyVer = other.AuthkeyVer;
			}
			if (other.SignType != 0)
			{
				SignType = other.SignType;
			}
			if (other.AuthAppid.Length != 0)
			{
				AuthAppid = other.AuthAppid;
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
			case 24u:
				AuthkeyVer = input.ReadUInt32();
				break;
			case 56u:
				SignType = input.ReadUInt32();
				break;
			case 122u:
				AuthAppid = input.ReadString();
				break;
			}
		}
	}
}
