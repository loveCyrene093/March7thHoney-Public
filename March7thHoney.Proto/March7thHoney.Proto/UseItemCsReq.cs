using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UseItemCsReq : IMessage<UseItemCsReq>, IMessage, IEquatable<UseItemCsReq>, IDeepCloneable<UseItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<UseItemCsReq> _parser = new MessageParser<UseItemCsReq>(() => new UseItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OptionalRewardIdFieldNumber = 4;

	private uint optionalRewardId_;

	public const int UseAvatarTypeFieldNumber = 5;

	private AvatarType useAvatarType_;

	public const int MHOCPFDEGNFFieldNumber = 6;

	private bool mHOCPFDEGNF_;

	public const int UseItemCountFieldNumber = 7;

	private uint useItemCount_;

	public const int BaseAvatarIdFieldNumber = 9;

	private uint baseAvatarId_;

	public const int UseItemIdFieldNumber = 14;

	private uint useItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UseItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UseItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OptionalRewardId
	{
		get
		{
			return optionalRewardId_;
		}
		set
		{
			optionalRewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarType UseAvatarType
	{
		get
		{
			return useAvatarType_;
		}
		set
		{
			useAvatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MHOCPFDEGNF
	{
		get
		{
			return mHOCPFDEGNF_;
		}
		set
		{
			mHOCPFDEGNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UseItemCount
	{
		get
		{
			return useItemCount_;
		}
		set
		{
			useItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UseItemId
	{
		get
		{
			return useItemId_;
		}
		set
		{
			useItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemCsReq(UseItemCsReq other)
		: this()
	{
		optionalRewardId_ = other.optionalRewardId_;
		useAvatarType_ = other.useAvatarType_;
		mHOCPFDEGNF_ = other.mHOCPFDEGNF_;
		useItemCount_ = other.useItemCount_;
		baseAvatarId_ = other.baseAvatarId_;
		useItemId_ = other.useItemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemCsReq Clone()
	{
		return new UseItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UseItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UseItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OptionalRewardId != other.OptionalRewardId)
		{
			return false;
		}
		if (UseAvatarType != other.UseAvatarType)
		{
			return false;
		}
		if (MHOCPFDEGNF != other.MHOCPFDEGNF)
		{
			return false;
		}
		if (UseItemCount != other.UseItemCount)
		{
			return false;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (UseItemId != other.UseItemId)
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
		if (OptionalRewardId != 0)
		{
			num ^= OptionalRewardId.GetHashCode();
		}
		if (UseAvatarType != AvatarType.None)
		{
			num ^= UseAvatarType.GetHashCode();
		}
		if (MHOCPFDEGNF)
		{
			num ^= MHOCPFDEGNF.GetHashCode();
		}
		if (UseItemCount != 0)
		{
			num ^= UseItemCount.GetHashCode();
		}
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		if (UseItemId != 0)
		{
			num ^= UseItemId.GetHashCode();
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
		if (OptionalRewardId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OptionalRewardId);
		}
		if (UseAvatarType != AvatarType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)UseAvatarType);
		}
		if (MHOCPFDEGNF)
		{
			output.WriteRawTag(48);
			output.WriteBool(MHOCPFDEGNF);
		}
		if (UseItemCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(UseItemCount);
		}
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BaseAvatarId);
		}
		if (UseItemId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(UseItemId);
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
		if (OptionalRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
		}
		if (UseAvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UseAvatarType);
		}
		if (MHOCPFDEGNF)
		{
			num += 2;
		}
		if (UseItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UseItemCount);
		}
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (UseItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UseItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UseItemCsReq other)
	{
		if (other != null)
		{
			if (other.OptionalRewardId != 0)
			{
				OptionalRewardId = other.OptionalRewardId;
			}
			if (other.UseAvatarType != AvatarType.None)
			{
				UseAvatarType = other.UseAvatarType;
			}
			if (other.MHOCPFDEGNF)
			{
				MHOCPFDEGNF = other.MHOCPFDEGNF;
			}
			if (other.UseItemCount != 0)
			{
				UseItemCount = other.UseItemCount;
			}
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
			}
			if (other.UseItemId != 0)
			{
				UseItemId = other.UseItemId;
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
				OptionalRewardId = input.ReadUInt32();
				break;
			case 40u:
				UseAvatarType = (AvatarType)input.ReadEnum();
				break;
			case 48u:
				MHOCPFDEGNF = input.ReadBool();
				break;
			case 56u:
				UseItemCount = input.ReadUInt32();
				break;
			case 72u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 112u:
				UseItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
