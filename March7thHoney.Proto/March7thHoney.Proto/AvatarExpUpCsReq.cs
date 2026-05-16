using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AvatarExpUpCsReq : IMessage<AvatarExpUpCsReq>, IMessage, IEquatable<AvatarExpUpCsReq>, IDeepCloneable<AvatarExpUpCsReq>, IBufferMessage
{
	private static readonly MessageParser<AvatarExpUpCsReq> _parser = new MessageParser<AvatarExpUpCsReq>(() => new AvatarExpUpCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BaseAvatarIdFieldNumber = 3;

	private uint baseAvatarId_;

	public const int ItemCostFieldNumber = 9;

	private ItemCostData itemCost_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AvatarExpUpCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarExpUpCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData ItemCost
	{
		get
		{
			return itemCost_;
		}
		set
		{
			itemCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarExpUpCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarExpUpCsReq(AvatarExpUpCsReq other)
		: this()
	{
		baseAvatarId_ = other.baseAvatarId_;
		itemCost_ = ((other.itemCost_ != null) ? other.itemCost_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarExpUpCsReq Clone()
	{
		return new AvatarExpUpCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AvatarExpUpCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AvatarExpUpCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (!object.Equals(ItemCost, other.ItemCost))
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
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		if (itemCost_ != null)
		{
			num ^= ItemCost.GetHashCode();
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
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BaseAvatarId);
		}
		if (itemCost_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ItemCost);
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
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (itemCost_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemCost);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AvatarExpUpCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BaseAvatarId != 0)
		{
			BaseAvatarId = other.BaseAvatarId;
		}
		if (other.itemCost_ != null)
		{
			if (itemCost_ == null)
			{
				ItemCost = new ItemCostData();
			}
			ItemCost.MergeFrom(other.ItemCost);
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
			case 24u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 74u:
				if (itemCost_ == null)
				{
					ItemCost = new ItemCostData();
				}
				input.ReadMessage(ItemCost);
				break;
			}
		}
	}
}
