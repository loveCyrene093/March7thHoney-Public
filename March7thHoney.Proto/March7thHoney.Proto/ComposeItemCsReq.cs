using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ComposeItemCsReq : IMessage<ComposeItemCsReq>, IMessage, IEquatable<ComposeItemCsReq>, IDeepCloneable<ComposeItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<ComposeItemCsReq> _parser = new MessageParser<ComposeItemCsReq>(() => new ComposeItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ComposeIdFieldNumber = 6;

	private uint composeId_;

	public const int ComposeItemListFieldNumber = 10;

	private ItemCostData composeItemList_;

	public const int CountFieldNumber = 12;

	private uint count_;

	public const int ConvertItemListFieldNumber = 13;

	private ItemCostData convertItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ComposeItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ComposeItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ComposeId
	{
		get
		{
			return composeId_;
		}
		set
		{
			composeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData ComposeItemList
	{
		get
		{
			return composeItemList_;
		}
		set
		{
			composeItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData ConvertItemList
	{
		get
		{
			return convertItemList_;
		}
		set
		{
			convertItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeItemCsReq(ComposeItemCsReq other)
		: this()
	{
		composeId_ = other.composeId_;
		composeItemList_ = ((other.composeItemList_ != null) ? other.composeItemList_.Clone() : null);
		count_ = other.count_;
		convertItemList_ = ((other.convertItemList_ != null) ? other.convertItemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeItemCsReq Clone()
	{
		return new ComposeItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ComposeItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ComposeItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComposeId != other.ComposeId)
		{
			return false;
		}
		if (!object.Equals(ComposeItemList, other.ComposeItemList))
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (!object.Equals(ConvertItemList, other.ConvertItemList))
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
		if (ComposeId != 0)
		{
			num ^= ComposeId.GetHashCode();
		}
		if (composeItemList_ != null)
		{
			num ^= ComposeItemList.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (convertItemList_ != null)
		{
			num ^= ConvertItemList.GetHashCode();
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
		if (ComposeId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ComposeId);
		}
		if (composeItemList_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ComposeItemList);
		}
		if (Count != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Count);
		}
		if (convertItemList_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ConvertItemList);
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
		if (ComposeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComposeId);
		}
		if (composeItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ComposeItemList);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (convertItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ConvertItemList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ComposeItemCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ComposeId != 0)
		{
			ComposeId = other.ComposeId;
		}
		if (other.composeItemList_ != null)
		{
			if (composeItemList_ == null)
			{
				ComposeItemList = new ItemCostData();
			}
			ComposeItemList.MergeFrom(other.ComposeItemList);
		}
		if (other.Count != 0)
		{
			Count = other.Count;
		}
		if (other.convertItemList_ != null)
		{
			if (convertItemList_ == null)
			{
				ConvertItemList = new ItemCostData();
			}
			ConvertItemList.MergeFrom(other.ConvertItemList);
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
			case 48u:
				ComposeId = input.ReadUInt32();
				break;
			case 82u:
				if (composeItemList_ == null)
				{
					ComposeItemList = new ItemCostData();
				}
				input.ReadMessage(ComposeItemList);
				break;
			case 96u:
				Count = input.ReadUInt32();
				break;
			case 106u:
				if (convertItemList_ == null)
				{
					ConvertItemList = new ItemCostData();
				}
				input.ReadMessage(ConvertItemList);
				break;
			}
		}
	}
}
