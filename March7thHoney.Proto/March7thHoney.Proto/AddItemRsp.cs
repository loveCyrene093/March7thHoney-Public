using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddItemRsp : IMessage<AddItemRsp>, IMessage, IEquatable<AddItemRsp>, IDeepCloneable<AddItemRsp>, IBufferMessage
{
	public enum PANAJBHKAKOOneofCase
	{
		None = 0,
		AvatarId = 8,
		FLEOCMEFANH = 11
	}

	private static readonly MessageParser<AddItemRsp> _parser = new MessageParser<AddItemRsp>(() => new AddItemRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 6;

	private ItemList reward_;

	public const int UnlockTimestampFieldNumber = 13;

	private long unlockTimestamp_;

	public const int AvatarIdFieldNumber = 8;

	public const int FLEOCMEFANHFieldNumber = 11;

	private object pANAJBHKAKO_;

	private PANAJBHKAKOOneofCase pANAJBHKAKOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddItemRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AddItemRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UnlockTimestamp
	{
		get
		{
			return unlockTimestamp_;
		}
		set
		{
			unlockTimestamp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			if (!HasAvatarId)
			{
				return 0u;
			}
			return (uint)pANAJBHKAKO_;
		}
		set
		{
			pANAJBHKAKO_ = value;
			pANAJBHKAKOCase_ = PANAJBHKAKOOneofCase.AvatarId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAvatarId => pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.AvatarId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLEOCMEFANH
	{
		get
		{
			if (!HasFLEOCMEFANH)
			{
				return 0u;
			}
			return (uint)pANAJBHKAKO_;
		}
		set
		{
			pANAJBHKAKO_ = value;
			pANAJBHKAKOCase_ = PANAJBHKAKOOneofCase.FLEOCMEFANH;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFLEOCMEFANH => pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.FLEOCMEFANH;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PANAJBHKAKOOneofCase PANAJBHKAKOCase => pANAJBHKAKOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddItemRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddItemRsp(AddItemRsp other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		unlockTimestamp_ = other.unlockTimestamp_;
		switch (other.PANAJBHKAKOCase)
		{
		case PANAJBHKAKOOneofCase.AvatarId:
			AvatarId = other.AvatarId;
			break;
		case PANAJBHKAKOOneofCase.FLEOCMEFANH:
			FLEOCMEFANH = other.FLEOCMEFANH;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddItemRsp Clone()
	{
		return new AddItemRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAvatarId()
	{
		if (HasAvatarId)
		{
			ClearPANAJBHKAKO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFLEOCMEFANH()
	{
		if (HasFLEOCMEFANH)
		{
			ClearPANAJBHKAKO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPANAJBHKAKO()
	{
		pANAJBHKAKOCase_ = PANAJBHKAKOOneofCase.None;
		pANAJBHKAKO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AddItemRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AddItemRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (UnlockTimestamp != other.UnlockTimestamp)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (FLEOCMEFANH != other.FLEOCMEFANH)
		{
			return false;
		}
		if (PANAJBHKAKOCase != other.PANAJBHKAKOCase)
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (UnlockTimestamp != 0L)
		{
			num ^= UnlockTimestamp.GetHashCode();
		}
		if (HasAvatarId)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (HasFLEOCMEFANH)
		{
			num ^= FLEOCMEFANH.GetHashCode();
		}
		num ^= (int)pANAJBHKAKOCase_;
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
		if (reward_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Reward);
		}
		if (HasAvatarId)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AvatarId);
		}
		if (HasFLEOCMEFANH)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FLEOCMEFANH);
		}
		if (UnlockTimestamp != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(UnlockTimestamp);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (UnlockTimestamp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UnlockTimestamp);
		}
		if (HasAvatarId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (HasFLEOCMEFANH)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLEOCMEFANH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AddItemRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.UnlockTimestamp != 0L)
		{
			UnlockTimestamp = other.UnlockTimestamp;
		}
		switch (other.PANAJBHKAKOCase)
		{
		case PANAJBHKAKOOneofCase.AvatarId:
			AvatarId = other.AvatarId;
			break;
		case PANAJBHKAKOOneofCase.FLEOCMEFANH:
			FLEOCMEFANH = other.FLEOCMEFANH;
			break;
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
			case 50u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 64u:
				AvatarId = input.ReadUInt32();
				break;
			case 88u:
				FLEOCMEFANH = input.ReadUInt32();
				break;
			case 104u:
				UnlockTimestamp = input.ReadInt64();
				break;
			}
		}
	}
}
