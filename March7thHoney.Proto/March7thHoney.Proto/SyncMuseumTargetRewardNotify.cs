using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncMuseumTargetRewardNotify : IMessage<SyncMuseumTargetRewardNotify>, IMessage, IEquatable<SyncMuseumTargetRewardNotify>, IDeepCloneable<SyncMuseumTargetRewardNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncMuseumTargetRewardNotify> _parser = new MessageParser<SyncMuseumTargetRewardNotify>(() => new SyncMuseumTargetRewardNotify());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 3;

	private uint itemId_;

	public const int ItemCountFieldNumber = 13;

	private uint itemCount_;

	public const int LPAGKHGCCFHFieldNumber = 14;

	private uint lPAGKHGCCFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncMuseumTargetRewardNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncMuseumTargetRewardNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPAGKHGCCFH
	{
		get
		{
			return lPAGKHGCCFH_;
		}
		set
		{
			lPAGKHGCCFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetRewardNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetRewardNotify(SyncMuseumTargetRewardNotify other)
		: this()
	{
		itemId_ = other.itemId_;
		itemCount_ = other.itemCount_;
		lPAGKHGCCFH_ = other.lPAGKHGCCFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetRewardNotify Clone()
	{
		return new SyncMuseumTargetRewardNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncMuseumTargetRewardNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncMuseumTargetRewardNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (ItemCount != other.ItemCount)
		{
			return false;
		}
		if (LPAGKHGCCFH != other.LPAGKHGCCFH)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (LPAGKHGCCFH != 0)
		{
			num ^= LPAGKHGCCFH.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ItemId);
		}
		if (ItemCount != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ItemCount);
		}
		if (LPAGKHGCCFH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LPAGKHGCCFH);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemCount);
		}
		if (LPAGKHGCCFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPAGKHGCCFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncMuseumTargetRewardNotify other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
			}
			if (other.LPAGKHGCCFH != 0)
			{
				LPAGKHGCCFH = other.LPAGKHGCCFH;
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
			case 24u:
				ItemId = input.ReadUInt32();
				break;
			case 104u:
				ItemCount = input.ReadUInt32();
				break;
			case 112u:
				LPAGKHGCCFH = input.ReadUInt32();
				break;
			}
		}
	}
}
