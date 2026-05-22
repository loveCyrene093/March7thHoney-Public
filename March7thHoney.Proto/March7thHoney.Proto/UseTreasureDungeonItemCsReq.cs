using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UseTreasureDungeonItemCsReq : IMessage<UseTreasureDungeonItemCsReq>, IMessage, IEquatable<UseTreasureDungeonItemCsReq>, IDeepCloneable<UseTreasureDungeonItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<UseTreasureDungeonItemCsReq> _parser = new MessageParser<UseTreasureDungeonItemCsReq>(() => new UseTreasureDungeonItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CJOPNFDBJHDFieldNumber = 5;

	private uint cJOPNFDBJHD_;

	public const int ItemIdFieldNumber = 6;

	private uint itemId_;

	public const int TargetSideFieldNumber = 14;

	private uint targetSide_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UseTreasureDungeonItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UseTreasureDungeonItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJOPNFDBJHD
	{
		get
		{
			return cJOPNFDBJHD_;
		}
		set
		{
			cJOPNFDBJHD_ = value;
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
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseTreasureDungeonItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseTreasureDungeonItemCsReq(UseTreasureDungeonItemCsReq other)
		: this()
	{
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		itemId_ = other.itemId_;
		targetSide_ = other.targetSide_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseTreasureDungeonItemCsReq Clone()
	{
		return new UseTreasureDungeonItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UseTreasureDungeonItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UseTreasureDungeonItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
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
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
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
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CJOPNFDBJHD);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ItemId);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TargetSide);
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
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UseTreasureDungeonItemCsReq other)
	{
		if (other != null)
		{
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
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
			case 40u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			case 48u:
				ItemId = input.ReadUInt32();
				break;
			case 112u:
				TargetSide = input.ReadUInt32();
				break;
			}
		}
	}
}
