using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IHLLBHLEGMD : IMessage<IHLLBHLEGMD>, IMessage, IEquatable<IHLLBHLEGMD>, IDeepCloneable<IHLLBHLEGMD>, IBufferMessage
{
	private static readonly MessageParser<IHLLBHLEGMD> _parser = new MessageParser<IHLLBHLEGMD>(() => new IHLLBHLEGMD());

	private UnknownFieldSet _unknownFields;

	public const int CFIDMMFFBOEFieldNumber = 2;

	private int cFIDMMFFBOE_;

	public const int ItemIdFieldNumber = 4;

	private uint itemId_;

	public const int KPGMBKKOGJGFieldNumber = 7;

	private uint kPGMBKKOGJG_;

	public const int AEHKNGBKPBEFieldNumber = 10;

	private uint aEHKNGBKPBE_;

	public const int HKIOMCOCDNFFieldNumber = 12;

	private int hKIOMCOCDNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IHLLBHLEGMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IHLLBHLEGMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CFIDMMFFBOE
	{
		get
		{
			return cFIDMMFFBOE_;
		}
		set
		{
			cFIDMMFFBOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPGMBKKOGJG
	{
		get
		{
			return kPGMBKKOGJG_;
		}
		set
		{
			kPGMBKKOGJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AEHKNGBKPBE
	{
		get
		{
			return aEHKNGBKPBE_;
		}
		set
		{
			aEHKNGBKPBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HKIOMCOCDNF
	{
		get
		{
			return hKIOMCOCDNF_;
		}
		set
		{
			hKIOMCOCDNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHLLBHLEGMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHLLBHLEGMD(IHLLBHLEGMD other)
		: this()
	{
		cFIDMMFFBOE_ = other.cFIDMMFFBOE_;
		itemId_ = other.itemId_;
		kPGMBKKOGJG_ = other.kPGMBKKOGJG_;
		aEHKNGBKPBE_ = other.aEHKNGBKPBE_;
		hKIOMCOCDNF_ = other.hKIOMCOCDNF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHLLBHLEGMD Clone()
	{
		return new IHLLBHLEGMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IHLLBHLEGMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IHLLBHLEGMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CFIDMMFFBOE != other.CFIDMMFFBOE)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (KPGMBKKOGJG != other.KPGMBKKOGJG)
		{
			return false;
		}
		if (AEHKNGBKPBE != other.AEHKNGBKPBE)
		{
			return false;
		}
		if (HKIOMCOCDNF != other.HKIOMCOCDNF)
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
		if (CFIDMMFFBOE != 0)
		{
			num ^= CFIDMMFFBOE.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (KPGMBKKOGJG != 0)
		{
			num ^= KPGMBKKOGJG.GetHashCode();
		}
		if (AEHKNGBKPBE != 0)
		{
			num ^= AEHKNGBKPBE.GetHashCode();
		}
		if (HKIOMCOCDNF != 0)
		{
			num ^= HKIOMCOCDNF.GetHashCode();
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
		if (CFIDMMFFBOE != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CFIDMMFFBOE);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ItemId);
		}
		if (KPGMBKKOGJG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KPGMBKKOGJG);
		}
		if (AEHKNGBKPBE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AEHKNGBKPBE);
		}
		if (HKIOMCOCDNF != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(HKIOMCOCDNF);
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
		if (CFIDMMFFBOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CFIDMMFFBOE);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (KPGMBKKOGJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPGMBKKOGJG);
		}
		if (AEHKNGBKPBE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AEHKNGBKPBE);
		}
		if (HKIOMCOCDNF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HKIOMCOCDNF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IHLLBHLEGMD other)
	{
		if (other != null)
		{
			if (other.CFIDMMFFBOE != 0)
			{
				CFIDMMFFBOE = other.CFIDMMFFBOE;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.KPGMBKKOGJG != 0)
			{
				KPGMBKKOGJG = other.KPGMBKKOGJG;
			}
			if (other.AEHKNGBKPBE != 0)
			{
				AEHKNGBKPBE = other.AEHKNGBKPBE;
			}
			if (other.HKIOMCOCDNF != 0)
			{
				HKIOMCOCDNF = other.HKIOMCOCDNF;
			}
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
			case 16u:
				CFIDMMFFBOE = input.ReadInt32();
				break;
			case 32u:
				ItemId = input.ReadUInt32();
				break;
			case 56u:
				KPGMBKKOGJG = input.ReadUInt32();
				break;
			case 80u:
				AEHKNGBKPBE = input.ReadUInt32();
				break;
			case 96u:
				HKIOMCOCDNF = input.ReadInt32();
				break;
			}
		}
	}
}
