using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSecretKeyInfoScRsp : IMessage<GetSecretKeyInfoScRsp>, IMessage, IEquatable<GetSecretKeyInfoScRsp>, IDeepCloneable<GetSecretKeyInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSecretKeyInfoScRsp> _parser = new MessageParser<GetSecretKeyInfoScRsp>(() => new GetSecretKeyInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SecretInfoFieldNumber = 2;

	private static readonly FieldCodec<SecretKeyInfo> _repeated_secretInfo_codec = FieldCodec.ForMessage(18u, SecretKeyInfo.Parser);

	private readonly RepeatedField<SecretKeyInfo> secretInfo_ = new RepeatedField<SecretKeyInfo>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int SecretRspFieldNumber = 14;

	private ByteString secretRsp_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSecretKeyInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSecretKeyInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SecretKeyInfo> SecretInfo => secretInfo_;

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
	public ByteString SecretRsp
	{
		get
		{
			return secretRsp_;
		}
		set
		{
			secretRsp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSecretKeyInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSecretKeyInfoScRsp(GetSecretKeyInfoScRsp other)
		: this()
	{
		secretInfo_ = other.secretInfo_.Clone();
		retcode_ = other.retcode_;
		secretRsp_ = other.secretRsp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSecretKeyInfoScRsp Clone()
	{
		return new GetSecretKeyInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSecretKeyInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSecretKeyInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!secretInfo_.Equals(other.secretInfo_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (SecretRsp != other.SecretRsp)
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
		num ^= secretInfo_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (SecretRsp.Length != 0)
		{
			num ^= SecretRsp.GetHashCode();
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
		secretInfo_.WriteTo(ref output, _repeated_secretInfo_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (SecretRsp.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteBytes(SecretRsp);
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
		num += secretInfo_.CalculateSize(_repeated_secretInfo_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (SecretRsp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(SecretRsp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSecretKeyInfoScRsp other)
	{
		if (other != null)
		{
			secretInfo_.Add(other.secretInfo_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.SecretRsp.Length != 0)
			{
				SecretRsp = other.SecretRsp;
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
				secretInfo_.AddEntriesFrom(ref input, _repeated_secretInfo_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				SecretRsp = input.ReadBytes();
				break;
			}
		}
	}
}
