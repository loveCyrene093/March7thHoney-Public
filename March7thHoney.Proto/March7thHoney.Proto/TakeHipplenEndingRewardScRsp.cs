using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeHipplenEndingRewardScRsp : IMessage<TakeHipplenEndingRewardScRsp>, IMessage, IEquatable<TakeHipplenEndingRewardScRsp>, IDeepCloneable<TakeHipplenEndingRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeHipplenEndingRewardScRsp> _parser = new MessageParser<TakeHipplenEndingRewardScRsp>(() => new TakeHipplenEndingRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardListFieldNumber = 2;

	private ItemList rewardList_;

	public const int DKPCDLDDONGFieldNumber = 13;

	private uint dKPCDLDDONG_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeHipplenEndingRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeHipplenEndingRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public uint DKPCDLDDONG
	{
		get
		{
			return dKPCDLDDONG_;
		}
		set
		{
			dKPCDLDDONG_ = value;
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
	public TakeHipplenEndingRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeHipplenEndingRewardScRsp(TakeHipplenEndingRewardScRsp other)
		: this()
	{
		rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
		dKPCDLDDONG_ = other.dKPCDLDDONG_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeHipplenEndingRewardScRsp Clone()
	{
		return new TakeHipplenEndingRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeHipplenEndingRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeHipplenEndingRewardScRsp other)
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
		if (DKPCDLDDONG != other.DKPCDLDDONG)
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
		if (rewardList_ != null)
		{
			num ^= RewardList.GetHashCode();
		}
		if (DKPCDLDDONG != 0)
		{
			num ^= DKPCDLDDONG.GetHashCode();
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
		if (rewardList_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RewardList);
		}
		if (DKPCDLDDONG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DKPCDLDDONG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (rewardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardList);
		}
		if (DKPCDLDDONG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKPCDLDDONG);
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
	public void MergeFrom(TakeHipplenEndingRewardScRsp other)
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
		if (other.DKPCDLDDONG != 0)
		{
			DKPCDLDDONG = other.DKPCDLDDONG;
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
			case 18u:
				if (rewardList_ == null)
				{
					RewardList = new ItemList();
				}
				input.ReadMessage(RewardList);
				break;
			case 104u:
				DKPCDLDDONG = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
