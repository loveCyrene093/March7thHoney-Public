using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LLAGEIKJBJA : IMessage<LLAGEIKJBJA>, IMessage, IEquatable<LLAGEIKJBJA>, IDeepCloneable<LLAGEIKJBJA>, IBufferMessage
{
	private static readonly MessageParser<LLAGEIKJBJA> _parser = new MessageParser<LLAGEIKJBJA>(() => new LLAGEIKJBJA());

	private UnknownFieldSet _unknownFields;

	public const int ItemValueFieldNumber = 2;

	private EFEGKDHEMFN itemValue_;

	public const int MEBDLEDCGDIFieldNumber = 13;

	private EFEGKDHEMFN mEBDLEDCGDI_;

	public const int ItemListFieldNumber = 14;

	private static readonly FieldCodec<FBBMDFDOEEF> _repeated_itemList_codec = FieldCodec.ForMessage(114u, FBBMDFDOEEF.Parser);

	private readonly RepeatedField<FBBMDFDOEEF> itemList_ = new RepeatedField<FBBMDFDOEEF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LLAGEIKJBJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LLAGEIKJBJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN MEBDLEDCGDI
	{
		get
		{
			return mEBDLEDCGDI_;
		}
		set
		{
			mEBDLEDCGDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FBBMDFDOEEF> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLAGEIKJBJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLAGEIKJBJA(LLAGEIKJBJA other)
		: this()
	{
		itemValue_ = ((other.itemValue_ != null) ? other.itemValue_.Clone() : null);
		mEBDLEDCGDI_ = ((other.mEBDLEDCGDI_ != null) ? other.mEBDLEDCGDI_.Clone() : null);
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLAGEIKJBJA Clone()
	{
		return new LLAGEIKJBJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LLAGEIKJBJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LLAGEIKJBJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ItemValue, other.ItemValue))
		{
			return false;
		}
		if (!object.Equals(MEBDLEDCGDI, other.MEBDLEDCGDI))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
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
		if (itemValue_ != null)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (mEBDLEDCGDI_ != null)
		{
			num ^= MEBDLEDCGDI.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
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
		if (itemValue_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ItemValue);
		}
		if (mEBDLEDCGDI_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(MEBDLEDCGDI);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
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
		if (itemValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemValue);
		}
		if (mEBDLEDCGDI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MEBDLEDCGDI);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LLAGEIKJBJA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.itemValue_ != null)
		{
			if (itemValue_ == null)
			{
				ItemValue = new EFEGKDHEMFN();
			}
			ItemValue.MergeFrom(other.ItemValue);
		}
		if (other.mEBDLEDCGDI_ != null)
		{
			if (mEBDLEDCGDI_ == null)
			{
				MEBDLEDCGDI = new EFEGKDHEMFN();
			}
			MEBDLEDCGDI.MergeFrom(other.MEBDLEDCGDI);
		}
		itemList_.Add(other.itemList_);
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
			case 18u:
				if (itemValue_ == null)
				{
					ItemValue = new EFEGKDHEMFN();
				}
				input.ReadMessage(ItemValue);
				break;
			case 106u:
				if (mEBDLEDCGDI_ == null)
				{
					MEBDLEDCGDI = new EFEGKDHEMFN();
				}
				input.ReadMessage(MEBDLEDCGDI);
				break;
			case 114u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
