using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RaidInfoNotify : IMessage<RaidInfoNotify>, IMessage, IEquatable<RaidInfoNotify>, IDeepCloneable<RaidInfoNotify>, IBufferMessage
{
	private static readonly MessageParser<RaidInfoNotify> _parser = new MessageParser<RaidInfoNotify>(() => new RaidInfoNotify());

	private UnknownFieldSet _unknownFields;

	public const int RaidTargetInfoFieldNumber = 1;

	private static readonly FieldCodec<RaidTargetInfo> _repeated_raidTargetInfo_codec = FieldCodec.ForMessage(10u, March7thHoney.Proto.RaidTargetInfo.Parser);

	private readonly RepeatedField<RaidTargetInfo> raidTargetInfo_ = new RepeatedField<RaidTargetInfo>();

	public const int StatusFieldNumber = 3;

	private RaidStatus status_;

	public const int RaidFinishTimeFieldNumber = 5;

	private ulong raidFinishTime_;

	public const int WorldLevelFieldNumber = 8;

	private uint worldLevel_;

	public const int RaidIdFieldNumber = 11;

	private uint raidId_;

	public const int ItemListFieldNumber = 12;

	private ItemList itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RaidInfoNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RaidInfoNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RaidTargetInfo> RaidTargetInfo => raidTargetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RaidFinishTime
	{
		get
		{
			return raidFinishTime_;
		}
		set
		{
			raidFinishTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RaidId
	{
		get
		{
			return raidId_;
		}
		set
		{
			raidId_ = value;
		}
	}

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
	public RaidInfoNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidInfoNotify(RaidInfoNotify other)
		: this()
	{
		raidTargetInfo_ = other.raidTargetInfo_.Clone();
		status_ = other.status_;
		raidFinishTime_ = other.raidFinishTime_;
		worldLevel_ = other.worldLevel_;
		raidId_ = other.raidId_;
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RaidInfoNotify Clone()
	{
		return new RaidInfoNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RaidInfoNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RaidInfoNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!raidTargetInfo_.Equals(other.raidTargetInfo_))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (RaidFinishTime != other.RaidFinishTime)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (RaidId != other.RaidId)
		{
			return false;
		}
		if (!object.Equals(ItemList, other.ItemList))
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
		num ^= raidTargetInfo_.GetHashCode();
		if (Status != RaidStatus.None)
		{
			num ^= Status.GetHashCode();
		}
		if (RaidFinishTime != 0L)
		{
			num ^= RaidFinishTime.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
		}
		if (itemList_ != null)
		{
			num ^= ItemList.GetHashCode();
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
		raidTargetInfo_.WriteTo(ref output, _repeated_raidTargetInfo_codec);
		if (Status != RaidStatus.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Status);
		}
		if (RaidFinishTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(RaidFinishTime);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(WorldLevel);
		}
		if (RaidId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RaidId);
		}
		if (itemList_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ItemList);
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
		num += raidTargetInfo_.CalculateSize(_repeated_raidTargetInfo_codec);
		if (Status != RaidStatus.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (RaidFinishTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RaidFinishTime);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (itemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RaidInfoNotify other)
	{
		if (other == null)
		{
			return;
		}
		raidTargetInfo_.Add(other.raidTargetInfo_);
		if (other.Status != RaidStatus.None)
		{
			Status = other.Status;
		}
		if (other.RaidFinishTime != 0L)
		{
			RaidFinishTime = other.RaidFinishTime;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.RaidId != 0)
		{
			RaidId = other.RaidId;
		}
		if (other.itemList_ != null)
		{
			if (itemList_ == null)
			{
				ItemList = new ItemList();
			}
			ItemList.MergeFrom(other.ItemList);
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
			case 10u:
				raidTargetInfo_.AddEntriesFrom(ref input, _repeated_raidTargetInfo_codec);
				break;
			case 24u:
				Status = (RaidStatus)input.ReadEnum();
				break;
			case 40u:
				RaidFinishTime = input.ReadUInt64();
				break;
			case 64u:
				WorldLevel = input.ReadUInt32();
				break;
			case 88u:
				RaidId = input.ReadUInt32();
				break;
			case 98u:
				if (itemList_ == null)
				{
					ItemList = new ItemList();
				}
				input.ReadMessage(ItemList);
				break;
			}
		}
	}
}
