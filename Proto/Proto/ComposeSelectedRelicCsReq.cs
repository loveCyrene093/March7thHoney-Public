using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ComposeSelectedRelicCsReq : IMessage<ComposeSelectedRelicCsReq>, IMessage, IEquatable<ComposeSelectedRelicCsReq>, IDeepCloneable<ComposeSelectedRelicCsReq>, IBufferMessage
{
	private static readonly MessageParser<ComposeSelectedRelicCsReq> _parser = new MessageParser<ComposeSelectedRelicCsReq>(() => new ComposeSelectedRelicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ComposeRelicIdFieldNumber = 1;

	private uint composeRelicId_;

	public const int CountFieldNumber = 2;

	private uint count_;

	public const int ComposeIdFieldNumber = 3;

	private uint composeId_;

	public const int ComposeItemListFieldNumber = 7;

	private ItemCostData composeItemList_;

	public const int MainAffixIdFieldNumber = 11;

	private uint mainAffixId_;

	public const int SubAffixIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_subAffixIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> subAffixIdList_ = new RepeatedField<uint>();

	public const int WrItemListFieldNumber = 14;

	private ItemCostData wrItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ComposeSelectedRelicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ComposeSelectedRelicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ComposeRelicId
	{
		get
		{
			return composeRelicId_;
		}
		set
		{
			composeRelicId_ = value;
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
	public uint MainAffixId
	{
		get
		{
			return mainAffixId_;
		}
		set
		{
			mainAffixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SubAffixIdList => subAffixIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData WrItemList
	{
		get
		{
			return wrItemList_;
		}
		set
		{
			wrItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeSelectedRelicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeSelectedRelicCsReq(ComposeSelectedRelicCsReq other)
		: this()
	{
		composeRelicId_ = other.composeRelicId_;
		count_ = other.count_;
		composeId_ = other.composeId_;
		composeItemList_ = ((other.composeItemList_ != null) ? other.composeItemList_.Clone() : null);
		mainAffixId_ = other.mainAffixId_;
		subAffixIdList_ = other.subAffixIdList_.Clone();
		wrItemList_ = ((other.wrItemList_ != null) ? other.wrItemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeSelectedRelicCsReq Clone()
	{
		return new ComposeSelectedRelicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ComposeSelectedRelicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ComposeSelectedRelicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComposeRelicId != other.ComposeRelicId)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (ComposeId != other.ComposeId)
		{
			return false;
		}
		if (!object.Equals(ComposeItemList, other.ComposeItemList))
		{
			return false;
		}
		if (MainAffixId != other.MainAffixId)
		{
			return false;
		}
		if (!subAffixIdList_.Equals(other.subAffixIdList_))
		{
			return false;
		}
		if (!object.Equals(WrItemList, other.WrItemList))
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
		if (ComposeRelicId != 0)
		{
			num ^= ComposeRelicId.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (ComposeId != 0)
		{
			num ^= ComposeId.GetHashCode();
		}
		if (composeItemList_ != null)
		{
			num ^= ComposeItemList.GetHashCode();
		}
		if (MainAffixId != 0)
		{
			num ^= MainAffixId.GetHashCode();
		}
		num ^= subAffixIdList_.GetHashCode();
		if (wrItemList_ != null)
		{
			num ^= WrItemList.GetHashCode();
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
		if (ComposeRelicId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ComposeRelicId);
		}
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
		}
		if (ComposeId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ComposeId);
		}
		if (composeItemList_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ComposeItemList);
		}
		if (MainAffixId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MainAffixId);
		}
		subAffixIdList_.WriteTo(ref output, _repeated_subAffixIdList_codec);
		if (wrItemList_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(WrItemList);
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
		if (ComposeRelicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComposeRelicId);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (ComposeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComposeId);
		}
		if (composeItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ComposeItemList);
		}
		if (MainAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainAffixId);
		}
		num += subAffixIdList_.CalculateSize(_repeated_subAffixIdList_codec);
		if (wrItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WrItemList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ComposeSelectedRelicCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ComposeRelicId != 0)
		{
			ComposeRelicId = other.ComposeRelicId;
		}
		if (other.Count != 0)
		{
			Count = other.Count;
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
		if (other.MainAffixId != 0)
		{
			MainAffixId = other.MainAffixId;
		}
		subAffixIdList_.Add(other.subAffixIdList_);
		if (other.wrItemList_ != null)
		{
			if (wrItemList_ == null)
			{
				WrItemList = new ItemCostData();
			}
			WrItemList.MergeFrom(other.WrItemList);
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
			case 8u:
				ComposeRelicId = input.ReadUInt32();
				break;
			case 16u:
				Count = input.ReadUInt32();
				break;
			case 24u:
				ComposeId = input.ReadUInt32();
				break;
			case 58u:
				if (composeItemList_ == null)
				{
					ComposeItemList = new ItemCostData();
				}
				input.ReadMessage(ComposeItemList);
				break;
			case 88u:
				MainAffixId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				subAffixIdList_.AddEntriesFrom(ref input, _repeated_subAffixIdList_codec);
				break;
			case 114u:
				if (wrItemList_ == null)
				{
					WrItemList = new ItemCostData();
				}
				input.ReadMessage(WrItemList);
				break;
			}
		}
	}
}
