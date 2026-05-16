using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyTakeRaffleTicketRewardScRsp : IMessage<MonopolyTakeRaffleTicketRewardScRsp>, IMessage, IEquatable<MonopolyTakeRaffleTicketRewardScRsp>, IDeepCloneable<MonopolyTakeRaffleTicketRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyTakeRaffleTicketRewardScRsp> _parser = new MessageParser<MonopolyTakeRaffleTicketRewardScRsp>(() => new MonopolyTakeRaffleTicketRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardListFieldNumber = 3;

	private ItemList rewardList_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int MBMICCJEBJBFieldNumber = 13;

	private uint mBMICCJEBJB_;

	public const int CBOMHCDNEDGFieldNumber = 14;

	private uint cBOMHCDNEDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyTakeRaffleTicketRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyTakeRaffleTicketRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList RewardList
	{
		get
		{
			return rewardList_;
		}
		set
		{
			rewardList_ = value;
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
	public uint MBMICCJEBJB
	{
		get
		{
			return mBMICCJEBJB_;
		}
		set
		{
			mBMICCJEBJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBOMHCDNEDG
	{
		get
		{
			return cBOMHCDNEDG_;
		}
		set
		{
			cBOMHCDNEDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyTakeRaffleTicketRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyTakeRaffleTicketRewardScRsp(MonopolyTakeRaffleTicketRewardScRsp other)
		: this()
	{
		rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
		retcode_ = other.retcode_;
		mBMICCJEBJB_ = other.mBMICCJEBJB_;
		cBOMHCDNEDG_ = other.cBOMHCDNEDG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyTakeRaffleTicketRewardScRsp Clone()
	{
		return new MonopolyTakeRaffleTicketRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyTakeRaffleTicketRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyTakeRaffleTicketRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RewardList, other.RewardList))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (MBMICCJEBJB != other.MBMICCJEBJB)
		{
			return false;
		}
		if (CBOMHCDNEDG != other.CBOMHCDNEDG)
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
		if (rewardList_ != null)
		{
			num ^= RewardList.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (MBMICCJEBJB != 0)
		{
			num ^= MBMICCJEBJB.GetHashCode();
		}
		if (CBOMHCDNEDG != 0)
		{
			num ^= CBOMHCDNEDG.GetHashCode();
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
		if (rewardList_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RewardList);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (MBMICCJEBJB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MBMICCJEBJB);
		}
		if (CBOMHCDNEDG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CBOMHCDNEDG);
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
		if (rewardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardList);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (MBMICCJEBJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBMICCJEBJB);
		}
		if (CBOMHCDNEDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBOMHCDNEDG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyTakeRaffleTicketRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardList_ != null)
		{
			if (rewardList_ == null)
			{
				RewardList = new ItemList();
			}
			RewardList.MergeFrom(other.RewardList);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.MBMICCJEBJB != 0)
		{
			MBMICCJEBJB = other.MBMICCJEBJB;
		}
		if (other.CBOMHCDNEDG != 0)
		{
			CBOMHCDNEDG = other.CBOMHCDNEDG;
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
			case 26u:
				if (rewardList_ == null)
				{
					RewardList = new ItemList();
				}
				input.ReadMessage(RewardList);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				MBMICCJEBJB = input.ReadUInt32();
				break;
			case 112u:
				CBOMHCDNEDG = input.ReadUInt32();
				break;
			}
		}
	}
}
