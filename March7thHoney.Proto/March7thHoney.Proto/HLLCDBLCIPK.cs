using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLLCDBLCIPK : IMessage<HLLCDBLCIPK>, IMessage, IEquatable<HLLCDBLCIPK>, IDeepCloneable<HLLCDBLCIPK>, IBufferMessage
{
	private static readonly MessageParser<HLLCDBLCIPK> _parser = new MessageParser<HLLCDBLCIPK>(() => new HLLCDBLCIPK());

	private UnknownFieldSet _unknownFields;

	public const int ItemValueFieldNumber = 6;

	private EFEGKDHEMFN itemValue_;

	public const int JONDOIHPNEAFieldNumber = 8;

	private static readonly MapField<uint, uint>.Codec _map_jONDOIHPNEA_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 66u);

	private readonly MapField<uint, uint> jONDOIHPNEA_ = new MapField<uint, uint>();

	public const int ItemListFieldNumber = 13;

	private static readonly FieldCodec<FBBMDFDOEEF> _repeated_itemList_codec = FieldCodec.ForMessage(106u, FBBMDFDOEEF.Parser);

	private readonly RepeatedField<FBBMDFDOEEF> itemList_ = new RepeatedField<FBBMDFDOEEF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLLCDBLCIPK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLLCDBLCIPKReflection.Descriptor.MessageTypes[0];

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
	public MapField<uint, uint> JONDOIHPNEA => jONDOIHPNEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FBBMDFDOEEF> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK(HLLCDBLCIPK other)
		: this()
	{
		itemValue_ = ((other.itemValue_ != null) ? other.itemValue_.Clone() : null);
		jONDOIHPNEA_ = other.jONDOIHPNEA_.Clone();
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK Clone()
	{
		return new HLLCDBLCIPK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLLCDBLCIPK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLLCDBLCIPK other)
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
		if (!JONDOIHPNEA.Equals(other.JONDOIHPNEA))
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
		num ^= JONDOIHPNEA.GetHashCode();
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
			output.WriteRawTag(50);
			output.WriteMessage(ItemValue);
		}
		jONDOIHPNEA_.WriteTo(ref output, _map_jONDOIHPNEA_codec);
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
		num += jONDOIHPNEA_.CalculateSize(_map_jONDOIHPNEA_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLLCDBLCIPK other)
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
		jONDOIHPNEA_.MergeFrom(other.jONDOIHPNEA_);
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
			case 50u:
				if (itemValue_ == null)
				{
					ItemValue = new EFEGKDHEMFN();
				}
				input.ReadMessage(ItemValue);
				break;
			case 66u:
				jONDOIHPNEA_.AddEntriesFrom(ref input, _map_jONDOIHPNEA_codec);
				break;
			case 106u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
