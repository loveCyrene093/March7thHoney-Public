using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyTakeBuildLevelAwardScRsp : IMessage<TrainPartyTakeBuildLevelAwardScRsp>, IMessage, IEquatable<TrainPartyTakeBuildLevelAwardScRsp>, IDeepCloneable<TrainPartyTakeBuildLevelAwardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyTakeBuildLevelAwardScRsp> _parser = new MessageParser<TrainPartyTakeBuildLevelAwardScRsp>(() => new TrainPartyTakeBuildLevelAwardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ItemListFieldNumber = 10;

	private ItemList itemList_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int HBLOHOFKKKOFieldNumber = 15;

	private uint hBLOHOFKKKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyTakeBuildLevelAwardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyTakeBuildLevelAwardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ItemList
	{
		get
		{
			return itemList_;
		}
		set
		{
			itemList_ = value;
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
	public uint HBLOHOFKKKO
	{
		get
		{
			return hBLOHOFKKKO_;
		}
		set
		{
			hBLOHOFKKKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyTakeBuildLevelAwardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyTakeBuildLevelAwardScRsp(TrainPartyTakeBuildLevelAwardScRsp other)
		: this()
	{
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		retcode_ = other.retcode_;
		hBLOHOFKKKO_ = other.hBLOHOFKKKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyTakeBuildLevelAwardScRsp Clone()
	{
		return new TrainPartyTakeBuildLevelAwardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyTakeBuildLevelAwardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyTakeBuildLevelAwardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ItemList, other.ItemList))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HBLOHOFKKKO != other.HBLOHOFKKKO)
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
		if (itemList_ != null)
		{
			num ^= ItemList.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HBLOHOFKKKO != 0)
		{
			num ^= HBLOHOFKKKO.GetHashCode();
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
		if (itemList_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ItemList);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		if (HBLOHOFKKKO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HBLOHOFKKKO);
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
		if (itemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemList);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HBLOHOFKKKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBLOHOFKKKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyTakeBuildLevelAwardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.itemList_ != null)
		{
			if (itemList_ == null)
			{
				ItemList = new ItemList();
			}
			ItemList.MergeFrom(other.ItemList);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.HBLOHOFKKKO != 0)
		{
			HBLOHOFKKKO = other.HBLOHOFKKKO;
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
			case 82u:
				if (itemList_ == null)
				{
					ItemList = new ItemList();
				}
				input.ReadMessage(ItemList);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				HBLOHOFKKKO = input.ReadUInt32();
				break;
			}
		}
	}
}
