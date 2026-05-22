using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnlockAvatarPathScRsp : IMessage<UnlockAvatarPathScRsp>, IMessage, IEquatable<UnlockAvatarPathScRsp>, IDeepCloneable<UnlockAvatarPathScRsp>, IBufferMessage
{
	private static readonly MessageParser<UnlockAvatarPathScRsp> _parser = new MessageParser<UnlockAvatarPathScRsp>(() => new UnlockAvatarPathScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 2;

	private MultiPathAvatarType avatarId_;

	public const int BasicTypeIdListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_basicTypeIdList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> basicTypeIdList_ = new RepeatedField<uint>();

	public const int RewardFieldNumber = 9;

	private ItemList reward_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UnlockAvatarPathScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UnlockAvatarPathScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultiPathAvatarType AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BasicTypeIdList => basicTypeIdList_;

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
	public UnlockAvatarPathScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockAvatarPathScRsp(UnlockAvatarPathScRsp other)
		: this()
	{
		avatarId_ = other.avatarId_;
		basicTypeIdList_ = other.basicTypeIdList_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockAvatarPathScRsp Clone()
	{
		return new UnlockAvatarPathScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UnlockAvatarPathScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnlockAvatarPathScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!basicTypeIdList_.Equals(other.basicTypeIdList_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (AvatarId != MultiPathAvatarType.None)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= basicTypeIdList_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (AvatarId != MultiPathAvatarType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)AvatarId);
		}
		basicTypeIdList_.WriteTo(ref output, _repeated_basicTypeIdList_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		if (AvatarId != MultiPathAvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarId);
		}
		num += basicTypeIdList_.CalculateSize(_repeated_basicTypeIdList_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UnlockAvatarPathScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AvatarId != MultiPathAvatarType.None)
		{
			AvatarId = other.AvatarId;
		}
		basicTypeIdList_.Add(other.basicTypeIdList_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 16u:
				AvatarId = (MultiPathAvatarType)input.ReadEnum();
				break;
			case 64u:
			case 66u:
				basicTypeIdList_.AddEntriesFrom(ref input, _repeated_basicTypeIdList_codec);
				break;
			case 74u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
