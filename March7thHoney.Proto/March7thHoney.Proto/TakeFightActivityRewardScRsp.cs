using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeFightActivityRewardScRsp : IMessage<TakeFightActivityRewardScRsp>, IMessage, IEquatable<TakeFightActivityRewardScRsp>, IDeepCloneable<TakeFightActivityRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeFightActivityRewardScRsp> _parser = new MessageParser<TakeFightActivityRewardScRsp>(() => new TakeFightActivityRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 4;

	private ItemList reward_;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int INOMFFAIEOAFieldNumber = 15;

	private uint iNOMFFAIEOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeFightActivityRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeFightActivityRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
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
	public uint INOMFFAIEOA
	{
		get
		{
			return iNOMFFAIEOA_;
		}
		set
		{
			iNOMFFAIEOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeFightActivityRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeFightActivityRewardScRsp(TakeFightActivityRewardScRsp other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		groupId_ = other.groupId_;
		retcode_ = other.retcode_;
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeFightActivityRewardScRsp Clone()
	{
		return new TakeFightActivityRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeFightActivityRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeFightActivityRewardScRsp other)
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
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (INOMFFAIEOA != other.INOMFFAIEOA)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (INOMFFAIEOA != 0)
		{
			num ^= INOMFFAIEOA.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Reward);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (INOMFFAIEOA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(INOMFFAIEOA);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (INOMFFAIEOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INOMFFAIEOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeFightActivityRewardScRsp other)
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
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.INOMFFAIEOA != 0)
		{
			INOMFFAIEOA = other.INOMFFAIEOA;
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
			case 34u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			}
		}
	}
}
