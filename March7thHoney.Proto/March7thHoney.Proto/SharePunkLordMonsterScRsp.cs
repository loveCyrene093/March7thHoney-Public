using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SharePunkLordMonsterScRsp : IMessage<SharePunkLordMonsterScRsp>, IMessage, IEquatable<SharePunkLordMonsterScRsp>, IDeepCloneable<SharePunkLordMonsterScRsp>, IBufferMessage
{
	private static readonly MessageParser<SharePunkLordMonsterScRsp> _parser = new MessageParser<SharePunkLordMonsterScRsp>(() => new SharePunkLordMonsterScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MonsterIdFieldNumber = 4;

	private uint monsterId_;

	public const int ShareTypeFieldNumber = 6;

	private PunkLordShareType shareType_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int UidFieldNumber = 13;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SharePunkLordMonsterScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SharePunkLordMonsterScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public SharePunkLordMonsterScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SharePunkLordMonsterScRsp(SharePunkLordMonsterScRsp other)
		: this()
	{
		monsterId_ = other.monsterId_;
		shareType_ = other.shareType_;
		retcode_ = other.retcode_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SharePunkLordMonsterScRsp Clone()
	{
		return new SharePunkLordMonsterScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SharePunkLordMonsterScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SharePunkLordMonsterScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (ShareType != other.ShareType)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			num ^= ShareType.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (MonsterId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MonsterId);
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)ShareType);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Uid);
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
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ShareType);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SharePunkLordMonsterScRsp other)
	{
		if (other != null)
		{
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
			{
				ShareType = other.ShareType;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 32u:
				MonsterId = input.ReadUInt32();
				break;
			case 48u:
				ShareType = (PunkLordShareType)input.ReadEnum();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
