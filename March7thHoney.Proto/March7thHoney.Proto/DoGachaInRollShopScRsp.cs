using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DoGachaInRollShopScRsp : IMessage<DoGachaInRollShopScRsp>, IMessage, IEquatable<DoGachaInRollShopScRsp>, IDeepCloneable<DoGachaInRollShopScRsp>, IBufferMessage
{
	private static readonly MessageParser<DoGachaInRollShopScRsp> _parser = new MessageParser<DoGachaInRollShopScRsp>(() => new DoGachaInRollShopScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int NJJKICNOFCLFieldNumber = 11;

	private uint nJJKICNOFCL_;

	public const int RewardFieldNumber = 13;

	private ItemList reward_;

	public const int RewardDisplayTypeFieldNumber = 14;

	private uint rewardDisplayType_;

	public const int RollShopIdFieldNumber = 15;

	private uint rollShopId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DoGachaInRollShopScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DoGachaInRollShopScRspReflection.Descriptor.MessageTypes[0];

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
	public uint NJJKICNOFCL
	{
		get
		{
			return nJJKICNOFCL_;
		}
		set
		{
			nJJKICNOFCL_ = value;
		}
	}

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
	public uint RewardDisplayType
	{
		get
		{
			return rewardDisplayType_;
		}
		set
		{
			rewardDisplayType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RollShopId
	{
		get
		{
			return rollShopId_;
		}
		set
		{
			rollShopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaInRollShopScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaInRollShopScRsp(DoGachaInRollShopScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		nJJKICNOFCL_ = other.nJJKICNOFCL_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		rewardDisplayType_ = other.rewardDisplayType_;
		rollShopId_ = other.rollShopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaInRollShopScRsp Clone()
	{
		return new DoGachaInRollShopScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DoGachaInRollShopScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DoGachaInRollShopScRsp other)
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
		if (NJJKICNOFCL != other.NJJKICNOFCL)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (RewardDisplayType != other.RewardDisplayType)
		{
			return false;
		}
		if (RollShopId != other.RollShopId)
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
		if (NJJKICNOFCL != 0)
		{
			num ^= NJJKICNOFCL.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (RewardDisplayType != 0)
		{
			num ^= RewardDisplayType.GetHashCode();
		}
		if (RollShopId != 0)
		{
			num ^= RollShopId.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (NJJKICNOFCL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NJJKICNOFCL);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(Reward);
		}
		if (RewardDisplayType != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(RewardDisplayType);
		}
		if (RollShopId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RollShopId);
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
		if (NJJKICNOFCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJJKICNOFCL);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (RewardDisplayType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RewardDisplayType);
		}
		if (RollShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RollShopId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DoGachaInRollShopScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.NJJKICNOFCL != 0)
		{
			NJJKICNOFCL = other.NJJKICNOFCL;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.RewardDisplayType != 0)
		{
			RewardDisplayType = other.RewardDisplayType;
		}
		if (other.RollShopId != 0)
		{
			RollShopId = other.RollShopId;
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
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				NJJKICNOFCL = input.ReadUInt32();
				break;
			case 106u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 112u:
				RewardDisplayType = input.ReadUInt32();
				break;
			case 120u:
				RollShopId = input.ReadUInt32();
				break;
			}
		}
	}
}
