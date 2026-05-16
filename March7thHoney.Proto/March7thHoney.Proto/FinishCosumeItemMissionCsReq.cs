using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishCosumeItemMissionCsReq : IMessage<FinishCosumeItemMissionCsReq>, IMessage, IEquatable<FinishCosumeItemMissionCsReq>, IDeepCloneable<FinishCosumeItemMissionCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishCosumeItemMissionCsReq> _parser = new MessageParser<FinishCosumeItemMissionCsReq>(() => new FinishCosumeItemMissionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SubMissionIdFieldNumber = 4;

	private uint subMissionId_;

	public const int ItemListFieldNumber = 13;

	private ItemList itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishCosumeItemMissionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishCosumeItemMissionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SubMissionId
	{
		get
		{
			return subMissionId_;
		}
		set
		{
			subMissionId_ = value;
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
	public FinishCosumeItemMissionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishCosumeItemMissionCsReq(FinishCosumeItemMissionCsReq other)
		: this()
	{
		subMissionId_ = other.subMissionId_;
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishCosumeItemMissionCsReq Clone()
	{
		return new FinishCosumeItemMissionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishCosumeItemMissionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishCosumeItemMissionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SubMissionId != other.SubMissionId)
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
		if (SubMissionId != 0)
		{
			num ^= SubMissionId.GetHashCode();
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
		if (SubMissionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(SubMissionId);
		}
		if (itemList_ != null)
		{
			output.WriteRawTag(106);
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
		if (SubMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SubMissionId);
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
	public void MergeFrom(FinishCosumeItemMissionCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SubMissionId != 0)
		{
			SubMissionId = other.SubMissionId;
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
			case 32u:
				SubMissionId = input.ReadUInt32();
				break;
			case 106u:
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
