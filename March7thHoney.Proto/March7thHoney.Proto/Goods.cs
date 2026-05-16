using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Goods : IMessage<Goods>, IMessage, IEquatable<Goods>, IDeepCloneable<Goods>, IBufferMessage
{
	private static readonly MessageParser<Goods> _parser = new MessageParser<Goods>(() => new Goods());

	private UnknownFieldSet _unknownFields;

	public const int EndTimeFieldNumber = 1;

	private long endTime_;

	public const int BeginTimeFieldNumber = 9;

	private long beginTime_;

	public const int BuyTimesFieldNumber = 10;

	private uint buyTimes_;

	public const int GoodsIdFieldNumber = 13;

	private uint goodsId_;

	public const int ItemIdFieldNumber = 14;

	private uint itemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Goods> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GoodsReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint BuyTimes
	{
		get
		{
			return buyTimes_;
		}
		set
		{
			buyTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GoodsId
	{
		get
		{
			return goodsId_;
		}
		set
		{
			goodsId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Goods()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Goods(Goods other)
		: this()
	{
		endTime_ = other.endTime_;
		beginTime_ = other.beginTime_;
		buyTimes_ = other.buyTimes_;
		goodsId_ = other.goodsId_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Goods Clone()
	{
		return new Goods(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Goods);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Goods other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (BuyTimes != other.BuyTimes)
		{
			return false;
		}
		if (GoodsId != other.GoodsId)
		{
			return false;
		}
		if (ItemId != other.ItemId)
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
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (BuyTimes != 0)
		{
			num ^= BuyTimes.GetHashCode();
		}
		if (GoodsId != 0)
		{
			num ^= GoodsId.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
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
		if (EndTime != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(EndTime);
		}
		if (BeginTime != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(BeginTime);
		}
		if (BuyTimes != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BuyTimes);
		}
		if (GoodsId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GoodsId);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ItemId);
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
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		if (BuyTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuyTimes);
		}
		if (GoodsId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GoodsId);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Goods other)
	{
		if (other != null)
		{
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.BuyTimes != 0)
			{
				BuyTimes = other.BuyTimes;
			}
			if (other.GoodsId != 0)
			{
				GoodsId = other.GoodsId;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
			case 8u:
				EndTime = input.ReadInt64();
				break;
			case 72u:
				BeginTime = input.ReadInt64();
				break;
			case 80u:
				BuyTimes = input.ReadUInt32();
				break;
			case 104u:
				GoodsId = input.ReadUInt32();
				break;
			case 112u:
				ItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
