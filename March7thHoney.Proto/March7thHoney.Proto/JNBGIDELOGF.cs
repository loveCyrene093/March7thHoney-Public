using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JNBGIDELOGF : IMessage<JNBGIDELOGF>, IMessage, IEquatable<JNBGIDELOGF>, IDeepCloneable<JNBGIDELOGF>, IBufferMessage
{
	private static readonly MessageParser<JNBGIDELOGF> _parser = new MessageParser<JNBGIDELOGF>(() => new JNBGIDELOGF());

	private UnknownFieldSet _unknownFields;

	public const int TransferItemListFieldNumber = 1;

	private static readonly FieldCodec<FIGFDNBIHCF> _repeated_transferItemList_codec = FieldCodec.ForMessage(10u, FIGFDNBIHCF.Parser);

	private readonly RepeatedField<FIGFDNBIHCF> transferItemList_ = new RepeatedField<FIGFDNBIHCF>();

	public const int ItemListFieldNumber = 15;

	private static readonly FieldCodec<FBBMDFDOEEF> _repeated_itemList_codec = FieldCodec.ForMessage(122u, FBBMDFDOEEF.Parser);

	private readonly RepeatedField<FBBMDFDOEEF> itemList_ = new RepeatedField<FBBMDFDOEEF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JNBGIDELOGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JNBGIDELOGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FIGFDNBIHCF> TransferItemList => transferItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FBBMDFDOEEF> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNBGIDELOGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNBGIDELOGF(JNBGIDELOGF other)
		: this()
	{
		transferItemList_ = other.transferItemList_.Clone();
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNBGIDELOGF Clone()
	{
		return new JNBGIDELOGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JNBGIDELOGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JNBGIDELOGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!transferItemList_.Equals(other.transferItemList_))
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
		num ^= transferItemList_.GetHashCode();
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
		transferItemList_.WriteTo(ref output, _repeated_transferItemList_codec);
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
		num += transferItemList_.CalculateSize(_repeated_transferItemList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JNBGIDELOGF other)
	{
		if (other != null)
		{
			transferItemList_.Add(other.transferItemList_);
			itemList_.Add(other.itemList_);
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
			case 10u:
				transferItemList_.AddEntriesFrom(ref input, _repeated_transferItemList_codec);
				break;
			case 122u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
