using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Shop : IMessage<Shop>, IMessage, IEquatable<Shop>, IDeepCloneable<Shop>, IBufferMessage
{
	private static readonly MessageParser<Shop> _parser = new MessageParser<Shop>(() => new Shop());

	private UnknownFieldSet _unknownFields;

	public const int GoodsListFieldNumber = 1;

	private static readonly FieldCodec<Goods> _repeated_goodsList_codec = FieldCodec.ForMessage(10u, Goods.Parser);

	private readonly RepeatedField<Goods> goodsList_ = new RepeatedField<Goods>();

	public const int CityExpFieldNumber = 2;

	private uint cityExp_;

	public const int EndTimeFieldNumber = 4;

	private long endTime_;

	public const int CityTakenLevelRewardFieldNumber = 7;

	private ulong cityTakenLevelReward_;

	public const int ShopIdFieldNumber = 8;

	private uint shopId_;

	public const int BeginTimeFieldNumber = 13;

	private long beginTime_;

	public const int CityLevelFieldNumber = 14;

	private uint cityLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Shop> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ShopReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Goods> GoodsList => goodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CityExp
	{
		get
		{
			return cityExp_;
		}
		set
		{
			cityExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong CityTakenLevelReward
	{
		get
		{
			return cityTakenLevelReward_;
		}
		set
		{
			cityTakenLevelReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CityLevel
	{
		get
		{
			return cityLevel_;
		}
		set
		{
			cityLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shop()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shop(Shop other)
		: this()
	{
		goodsList_ = other.goodsList_.Clone();
		cityExp_ = other.cityExp_;
		endTime_ = other.endTime_;
		cityTakenLevelReward_ = other.cityTakenLevelReward_;
		shopId_ = other.shopId_;
		beginTime_ = other.beginTime_;
		cityLevel_ = other.cityLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shop Clone()
	{
		return new Shop(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Shop);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Shop other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!goodsList_.Equals(other.goodsList_))
		{
			return false;
		}
		if (CityExp != other.CityExp)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (CityTakenLevelReward != other.CityTakenLevelReward)
		{
			return false;
		}
		if (ShopId != other.ShopId)
		{
			return false;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (CityLevel != other.CityLevel)
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
		num ^= goodsList_.GetHashCode();
		if (CityExp != 0)
		{
			num ^= CityExp.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (CityTakenLevelReward != 0L)
		{
			num ^= CityTakenLevelReward.GetHashCode();
		}
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (CityLevel != 0)
		{
			num ^= CityLevel.GetHashCode();
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
		goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
		if (CityExp != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CityExp);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(EndTime);
		}
		if (CityTakenLevelReward != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(CityTakenLevelReward);
		}
		if (ShopId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ShopId);
		}
		if (BeginTime != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(BeginTime);
		}
		if (CityLevel != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CityLevel);
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
		num += goodsList_.CalculateSize(_repeated_goodsList_codec);
		if (CityExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CityExp);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (CityTakenLevelReward != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CityTakenLevelReward);
		}
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopId);
		}
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		if (CityLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CityLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Shop other)
	{
		if (other != null)
		{
			goodsList_.Add(other.goodsList_);
			if (other.CityExp != 0)
			{
				CityExp = other.CityExp;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.CityTakenLevelReward != 0L)
			{
				CityTakenLevelReward = other.CityTakenLevelReward;
			}
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.CityLevel != 0)
			{
				CityLevel = other.CityLevel;
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
			case 10u:
				goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
				break;
			case 16u:
				CityExp = input.ReadUInt32();
				break;
			case 32u:
				EndTime = input.ReadInt64();
				break;
			case 56u:
				CityTakenLevelReward = input.ReadUInt64();
				break;
			case 64u:
				ShopId = input.ReadUInt32();
				break;
			case 104u:
				BeginTime = input.ReadInt64();
				break;
			case 112u:
				CityLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
