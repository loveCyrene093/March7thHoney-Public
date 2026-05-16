using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantFinishTradeOrderScRsp : IMessage<ElfRestaurantFinishTradeOrderScRsp>, IMessage, IEquatable<ElfRestaurantFinishTradeOrderScRsp>, IDeepCloneable<ElfRestaurantFinishTradeOrderScRsp>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantFinishTradeOrderScRsp> _parser = new MessageParser<ElfRestaurantFinishTradeOrderScRsp>(() => new ElfRestaurantFinishTradeOrderScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IIMKIFDKJHOFieldNumber = 2;

	private uint iIMKIFDKJHO_;

	public const int PPMAFCBNAJFFieldNumber = 5;

	private ItemList pPMAFCBNAJF_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int KBEFKONPKGJFieldNumber = 15;

	private ItemCostData kBEFKONPKGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantFinishTradeOrderScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantFinishTradeOrderScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIMKIFDKJHO
	{
		get
		{
			return iIMKIFDKJHO_;
		}
		set
		{
			iIMKIFDKJHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList PPMAFCBNAJF
	{
		get
		{
			return pPMAFCBNAJF_;
		}
		set
		{
			pPMAFCBNAJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData KBEFKONPKGJ
	{
		get
		{
			return kBEFKONPKGJ_;
		}
		set
		{
			kBEFKONPKGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantFinishTradeOrderScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantFinishTradeOrderScRsp(ElfRestaurantFinishTradeOrderScRsp other)
		: this()
	{
		iIMKIFDKJHO_ = other.iIMKIFDKJHO_;
		pPMAFCBNAJF_ = ((other.pPMAFCBNAJF_ != null) ? other.pPMAFCBNAJF_.Clone() : null);
		retcode_ = other.retcode_;
		kBEFKONPKGJ_ = ((other.kBEFKONPKGJ_ != null) ? other.kBEFKONPKGJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantFinishTradeOrderScRsp Clone()
	{
		return new ElfRestaurantFinishTradeOrderScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantFinishTradeOrderScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantFinishTradeOrderScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IIMKIFDKJHO != other.IIMKIFDKJHO)
		{
			return false;
		}
		if (!object.Equals(PPMAFCBNAJF, other.PPMAFCBNAJF))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(KBEFKONPKGJ, other.KBEFKONPKGJ))
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
		if (IIMKIFDKJHO != 0)
		{
			num ^= IIMKIFDKJHO.GetHashCode();
		}
		if (pPMAFCBNAJF_ != null)
		{
			num ^= PPMAFCBNAJF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (kBEFKONPKGJ_ != null)
		{
			num ^= KBEFKONPKGJ.GetHashCode();
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
		if (IIMKIFDKJHO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IIMKIFDKJHO);
		}
		if (pPMAFCBNAJF_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PPMAFCBNAJF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (kBEFKONPKGJ_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(KBEFKONPKGJ);
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
		if (IIMKIFDKJHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIMKIFDKJHO);
		}
		if (pPMAFCBNAJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPMAFCBNAJF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (kBEFKONPKGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBEFKONPKGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantFinishTradeOrderScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IIMKIFDKJHO != 0)
		{
			IIMKIFDKJHO = other.IIMKIFDKJHO;
		}
		if (other.pPMAFCBNAJF_ != null)
		{
			if (pPMAFCBNAJF_ == null)
			{
				PPMAFCBNAJF = new ItemList();
			}
			PPMAFCBNAJF.MergeFrom(other.PPMAFCBNAJF);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.kBEFKONPKGJ_ != null)
		{
			if (kBEFKONPKGJ_ == null)
			{
				KBEFKONPKGJ = new ItemCostData();
			}
			KBEFKONPKGJ.MergeFrom(other.KBEFKONPKGJ);
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
			case 16u:
				IIMKIFDKJHO = input.ReadUInt32();
				break;
			case 42u:
				if (pPMAFCBNAJF_ == null)
				{
					PPMAFCBNAJF = new ItemList();
				}
				input.ReadMessage(PPMAFCBNAJF);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (kBEFKONPKGJ_ == null)
				{
					KBEFKONPKGJ = new ItemCostData();
				}
				input.ReadMessage(KBEFKONPKGJ);
				break;
			}
		}
	}
}
