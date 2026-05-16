using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeStaminaScRsp : IMessage<ExchangeStaminaScRsp>, IMessage, IEquatable<ExchangeStaminaScRsp>, IDeepCloneable<ExchangeStaminaScRsp>, IBufferMessage
{
	private static readonly MessageParser<ExchangeStaminaScRsp> _parser = new MessageParser<ExchangeStaminaScRsp>(() => new ExchangeStaminaScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ItemCostListFieldNumber = 6;

	private static readonly FieldCodec<ItemCost> _repeated_itemCostList_codec = FieldCodec.ForMessage(50u, ItemCost.Parser);

	private readonly RepeatedField<ItemCost> itemCostList_ = new RepeatedField<ItemCost>();

	public const int ExchangeTimesFieldNumber = 8;

	private uint exchangeTimes_;

	public const int LastRecoverTimeFieldNumber = 9;

	private long lastRecoverTime_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int StaminaAddFieldNumber = 15;

	private uint staminaAdd_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeStaminaScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ExchangeStaminaScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemCost> ItemCostList => itemCostList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExchangeTimes
	{
		get
		{
			return exchangeTimes_;
		}
		set
		{
			exchangeTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LastRecoverTime
	{
		get
		{
			return lastRecoverTime_;
		}
		set
		{
			lastRecoverTime_ = value;
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
	public uint StaminaAdd
	{
		get
		{
			return staminaAdd_;
		}
		set
		{
			staminaAdd_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStaminaScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStaminaScRsp(ExchangeStaminaScRsp other)
		: this()
	{
		itemCostList_ = other.itemCostList_.Clone();
		exchangeTimes_ = other.exchangeTimes_;
		lastRecoverTime_ = other.lastRecoverTime_;
		retcode_ = other.retcode_;
		staminaAdd_ = other.staminaAdd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStaminaScRsp Clone()
	{
		return new ExchangeStaminaScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ExchangeStaminaScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeStaminaScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!itemCostList_.Equals(other.itemCostList_))
		{
			return false;
		}
		if (ExchangeTimes != other.ExchangeTimes)
		{
			return false;
		}
		if (LastRecoverTime != other.LastRecoverTime)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (StaminaAdd != other.StaminaAdd)
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
		num ^= itemCostList_.GetHashCode();
		if (ExchangeTimes != 0)
		{
			num ^= ExchangeTimes.GetHashCode();
		}
		if (LastRecoverTime != 0L)
		{
			num ^= LastRecoverTime.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (StaminaAdd != 0)
		{
			num ^= StaminaAdd.GetHashCode();
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
		itemCostList_.WriteTo(ref output, _repeated_itemCostList_codec);
		if (ExchangeTimes != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ExchangeTimes);
		}
		if (LastRecoverTime != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(LastRecoverTime);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (StaminaAdd != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(StaminaAdd);
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
		num += itemCostList_.CalculateSize(_repeated_itemCostList_codec);
		if (ExchangeTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExchangeTimes);
		}
		if (LastRecoverTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LastRecoverTime);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (StaminaAdd != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StaminaAdd);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeStaminaScRsp other)
	{
		if (other != null)
		{
			itemCostList_.Add(other.itemCostList_);
			if (other.ExchangeTimes != 0)
			{
				ExchangeTimes = other.ExchangeTimes;
			}
			if (other.LastRecoverTime != 0L)
			{
				LastRecoverTime = other.LastRecoverTime;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.StaminaAdd != 0)
			{
				StaminaAdd = other.StaminaAdd;
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
			case 50u:
				itemCostList_.AddEntriesFrom(ref input, _repeated_itemCostList_codec);
				break;
			case 64u:
				ExchangeTimes = input.ReadUInt32();
				break;
			case 72u:
				LastRecoverTime = input.ReadInt64();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				StaminaAdd = input.ReadUInt32();
				break;
			}
		}
	}
}
