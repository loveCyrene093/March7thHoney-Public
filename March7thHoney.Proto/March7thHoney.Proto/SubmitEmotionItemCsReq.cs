using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubmitEmotionItemCsReq : IMessage<SubmitEmotionItemCsReq>, IMessage, IEquatable<SubmitEmotionItemCsReq>, IDeepCloneable<SubmitEmotionItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<SubmitEmotionItemCsReq> _parser = new MessageParser<SubmitEmotionItemCsReq>(() => new SubmitEmotionItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AILOMBIMICBFieldNumber = 12;

	private uint aILOMBIMICB_;

	public const int ItemListFieldNumber = 14;

	private ItemList itemList_;

	public const int ScriptIdFieldNumber = 15;

	private uint scriptId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SubmitEmotionItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SubmitEmotionItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AILOMBIMICB
	{
		get
		{
			return aILOMBIMICB_;
		}
		set
		{
			aILOMBIMICB_ = value;
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
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitEmotionItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitEmotionItemCsReq(SubmitEmotionItemCsReq other)
		: this()
	{
		aILOMBIMICB_ = other.aILOMBIMICB_;
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		scriptId_ = other.scriptId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitEmotionItemCsReq Clone()
	{
		return new SubmitEmotionItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SubmitEmotionItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubmitEmotionItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AILOMBIMICB != other.AILOMBIMICB)
		{
			return false;
		}
		if (!object.Equals(ItemList, other.ItemList))
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
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
		if (AILOMBIMICB != 0)
		{
			num ^= AILOMBIMICB.GetHashCode();
		}
		if (itemList_ != null)
		{
			num ^= ItemList.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
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
		if (AILOMBIMICB != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AILOMBIMICB);
		}
		if (itemList_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ItemList);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ScriptId);
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
		if (AILOMBIMICB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AILOMBIMICB);
		}
		if (itemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemList);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubmitEmotionItemCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AILOMBIMICB != 0)
		{
			AILOMBIMICB = other.AILOMBIMICB;
		}
		if (other.itemList_ != null)
		{
			if (itemList_ == null)
			{
				ItemList = new ItemList();
			}
			ItemList.MergeFrom(other.ItemList);
		}
		if (other.ScriptId != 0)
		{
			ScriptId = other.ScriptId;
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
			case 96u:
				AILOMBIMICB = input.ReadUInt32();
				break;
			case 114u:
				if (itemList_ == null)
				{
					ItemList = new ItemList();
				}
				input.ReadMessage(ItemList);
				break;
			case 120u:
				ScriptId = input.ReadUInt32();
				break;
			}
		}
	}
}
