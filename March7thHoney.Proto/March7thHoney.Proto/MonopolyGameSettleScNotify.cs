using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGameSettleScNotify : IMessage<MonopolyGameSettleScNotify>, IMessage, IEquatable<MonopolyGameSettleScNotify>, IDeepCloneable<MonopolyGameSettleScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGameSettleScNotify> _parser = new MessageParser<MonopolyGameSettleScNotify>(() => new MonopolyGameSettleScNotify());

	private UnknownFieldSet _unknownFields;

	public const int JEILIIABKLGFieldNumber = 10;

	private ItemList jEILIIABKLG_;

	public const int BMKAEFAKNFJFieldNumber = 14;

	private KHCHPPLOFJN bMKAEFAKNFJ_;

	public const int ItemListFieldNumber = 15;

	private ItemList itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGameSettleScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGameSettleScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList JEILIIABKLG
	{
		get
		{
			return jEILIIABKLG_;
		}
		set
		{
			jEILIIABKLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCHPPLOFJN BMKAEFAKNFJ
	{
		get
		{
			return bMKAEFAKNFJ_;
		}
		set
		{
			bMKAEFAKNFJ_ = value;
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
	public MonopolyGameSettleScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameSettleScNotify(MonopolyGameSettleScNotify other)
		: this()
	{
		jEILIIABKLG_ = ((other.jEILIIABKLG_ != null) ? other.jEILIIABKLG_.Clone() : null);
		bMKAEFAKNFJ_ = ((other.bMKAEFAKNFJ_ != null) ? other.bMKAEFAKNFJ_.Clone() : null);
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameSettleScNotify Clone()
	{
		return new MonopolyGameSettleScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGameSettleScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGameSettleScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JEILIIABKLG, other.JEILIIABKLG))
		{
			return false;
		}
		if (!object.Equals(BMKAEFAKNFJ, other.BMKAEFAKNFJ))
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
		if (jEILIIABKLG_ != null)
		{
			num ^= JEILIIABKLG.GetHashCode();
		}
		if (bMKAEFAKNFJ_ != null)
		{
			num ^= BMKAEFAKNFJ.GetHashCode();
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
		if (jEILIIABKLG_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JEILIIABKLG);
		}
		if (bMKAEFAKNFJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BMKAEFAKNFJ);
		}
		if (itemList_ != null)
		{
			output.WriteRawTag(122);
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
		if (jEILIIABKLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JEILIIABKLG);
		}
		if (bMKAEFAKNFJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMKAEFAKNFJ);
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
	public void MergeFrom(MonopolyGameSettleScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jEILIIABKLG_ != null)
		{
			if (jEILIIABKLG_ == null)
			{
				JEILIIABKLG = new ItemList();
			}
			JEILIIABKLG.MergeFrom(other.JEILIIABKLG);
		}
		if (other.bMKAEFAKNFJ_ != null)
		{
			if (bMKAEFAKNFJ_ == null)
			{
				BMKAEFAKNFJ = new KHCHPPLOFJN();
			}
			BMKAEFAKNFJ.MergeFrom(other.BMKAEFAKNFJ);
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
			case 82u:
				if (jEILIIABKLG_ == null)
				{
					JEILIIABKLG = new ItemList();
				}
				input.ReadMessage(JEILIIABKLG);
				break;
			case 114u:
				if (bMKAEFAKNFJ_ == null)
				{
					BMKAEFAKNFJ = new KHCHPPLOFJN();
				}
				input.ReadMessage(BMKAEFAKNFJ);
				break;
			case 122u:
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
