using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOMOEOOHLJA : IMessage<DOMOEOOHLJA>, IMessage, IEquatable<DOMOEOOHLJA>, IDeepCloneable<DOMOEOOHLJA>, IBufferMessage
{
	private static readonly MessageParser<DOMOEOOHLJA> _parser = new MessageParser<DOMOEOOHLJA>(() => new DOMOEOOHLJA());

	private UnknownFieldSet _unknownFields;

	public const int FDDHIBCEOKEFieldNumber = 1;

	private bool fDDHIBCEOKE_;

	public const int COOOFFKIDMCFieldNumber = 11;

	private uint cOOOFFKIDMC_;

	public const int ItemListFieldNumber = 13;

	private ItemList itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOMOEOOHLJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOMOEOOHLJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FDDHIBCEOKE
	{
		get
		{
			return fDDHIBCEOKE_;
		}
		set
		{
			fDDHIBCEOKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COOOFFKIDMC
	{
		get
		{
			return cOOOFFKIDMC_;
		}
		set
		{
			cOOOFFKIDMC_ = value;
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
	public DOMOEOOHLJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOMOEOOHLJA(DOMOEOOHLJA other)
		: this()
	{
		fDDHIBCEOKE_ = other.fDDHIBCEOKE_;
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOMOEOOHLJA Clone()
	{
		return new DOMOEOOHLJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOMOEOOHLJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOMOEOOHLJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FDDHIBCEOKE != other.FDDHIBCEOKE)
		{
			return false;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
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
		if (FDDHIBCEOKE)
		{
			num ^= FDDHIBCEOKE.GetHashCode();
		}
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
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
		if (FDDHIBCEOKE)
		{
			output.WriteRawTag(8);
			output.WriteBool(FDDHIBCEOKE);
		}
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(COOOFFKIDMC);
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
		if (FDDHIBCEOKE)
		{
			num += 2;
		}
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
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
	public void MergeFrom(DOMOEOOHLJA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FDDHIBCEOKE)
		{
			FDDHIBCEOKE = other.FDDHIBCEOKE;
		}
		if (other.COOOFFKIDMC != 0)
		{
			COOOFFKIDMC = other.COOOFFKIDMC;
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
			case 8u:
				FDDHIBCEOKE = input.ReadBool();
				break;
			case 88u:
				COOOFFKIDMC = input.ReadUInt32();
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
