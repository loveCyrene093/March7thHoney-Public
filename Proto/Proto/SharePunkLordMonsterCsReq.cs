using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SharePunkLordMonsterCsReq : IMessage<SharePunkLordMonsterCsReq>, IMessage, IEquatable<SharePunkLordMonsterCsReq>, IDeepCloneable<SharePunkLordMonsterCsReq>, IBufferMessage
{
	private static readonly MessageParser<SharePunkLordMonsterCsReq> _parser = new MessageParser<SharePunkLordMonsterCsReq>(() => new SharePunkLordMonsterCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MonsterIdFieldNumber = 3;

	private uint monsterId_;

	public const int ShareTypeFieldNumber = 12;

	private PunkLordShareType shareType_;

	public const int UidFieldNumber = 13;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SharePunkLordMonsterCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SharePunkLordMonsterCsReqReflection.Descriptor.MessageTypes[0];

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
	public SharePunkLordMonsterCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SharePunkLordMonsterCsReq(SharePunkLordMonsterCsReq other)
		: this()
	{
		monsterId_ = other.monsterId_;
		shareType_ = other.shareType_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SharePunkLordMonsterCsReq Clone()
	{
		return new SharePunkLordMonsterCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SharePunkLordMonsterCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SharePunkLordMonsterCsReq other)
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
			output.WriteRawTag(24);
			output.WriteUInt32(MonsterId);
		}
		if (ShareType != PunkLordShareType.FoodopdndlkPcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)ShareType);
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
	public void MergeFrom(SharePunkLordMonsterCsReq other)
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
			case 24u:
				MonsterId = input.ReadUInt32();
				break;
			case 96u:
				ShareType = (PunkLordShareType)input.ReadEnum();
				break;
			case 104u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
