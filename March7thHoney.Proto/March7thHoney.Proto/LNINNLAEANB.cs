using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LNINNLAEANB : IMessage<LNINNLAEANB>, IMessage, IEquatable<LNINNLAEANB>, IDeepCloneable<LNINNLAEANB>, IBufferMessage
{
	private static readonly MessageParser<LNINNLAEANB> _parser = new MessageParser<LNINNLAEANB>(() => new LNINNLAEANB());

	private UnknownFieldSet _unknownFields;

	public const int ItemListFieldNumber = 4;

	private ItemList itemList_;

	public const int ICDFDOKFLAKFieldNumber = 5;

	private uint iCDFDOKFLAK_;

	public const int JFNNPEODINOFieldNumber = 13;

	private uint jFNNPEODINO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LNINNLAEANB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LNINNLAEANBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint ICDFDOKFLAK
	{
		get
		{
			return iCDFDOKFLAK_;
		}
		set
		{
			iCDFDOKFLAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFNNPEODINO
	{
		get
		{
			return jFNNPEODINO_;
		}
		set
		{
			jFNNPEODINO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNINNLAEANB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNINNLAEANB(LNINNLAEANB other)
		: this()
	{
		itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
		iCDFDOKFLAK_ = other.iCDFDOKFLAK_;
		jFNNPEODINO_ = other.jFNNPEODINO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNINNLAEANB Clone()
	{
		return new LNINNLAEANB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LNINNLAEANB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LNINNLAEANB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ItemList, other.ItemList))
		{
			return false;
		}
		if (ICDFDOKFLAK != other.ICDFDOKFLAK)
		{
			return false;
		}
		if (JFNNPEODINO != other.JFNNPEODINO)
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
		if (itemList_ != null)
		{
			num ^= ItemList.GetHashCode();
		}
		if (ICDFDOKFLAK != 0)
		{
			num ^= ICDFDOKFLAK.GetHashCode();
		}
		if (JFNNPEODINO != 0)
		{
			num ^= JFNNPEODINO.GetHashCode();
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
		if (itemList_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ItemList);
		}
		if (ICDFDOKFLAK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ICDFDOKFLAK);
		}
		if (JFNNPEODINO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JFNNPEODINO);
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
		if (itemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemList);
		}
		if (ICDFDOKFLAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ICDFDOKFLAK);
		}
		if (JFNNPEODINO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFNNPEODINO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LNINNLAEANB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.itemList_ != null)
		{
			if (itemList_ == null)
			{
				ItemList = new ItemList();
			}
			ItemList.MergeFrom(other.ItemList);
		}
		if (other.ICDFDOKFLAK != 0)
		{
			ICDFDOKFLAK = other.ICDFDOKFLAK;
		}
		if (other.JFNNPEODINO != 0)
		{
			JFNNPEODINO = other.JFNNPEODINO;
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
			case 34u:
				if (itemList_ == null)
				{
					ItemList = new ItemList();
				}
				input.ReadMessage(ItemList);
				break;
			case 40u:
				ICDFDOKFLAK = input.ReadUInt32();
				break;
			case 104u:
				JFNNPEODINO = input.ReadUInt32();
				break;
			}
		}
	}
}
