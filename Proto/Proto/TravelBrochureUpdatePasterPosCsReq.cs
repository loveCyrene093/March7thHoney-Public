using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TravelBrochureUpdatePasterPosCsReq : IMessage<TravelBrochureUpdatePasterPosCsReq>, IMessage, IEquatable<TravelBrochureUpdatePasterPosCsReq>, IDeepCloneable<TravelBrochureUpdatePasterPosCsReq>, IBufferMessage
{
	private static readonly MessageParser<TravelBrochureUpdatePasterPosCsReq> _parser = new MessageParser<TravelBrochureUpdatePasterPosCsReq>(() => new TravelBrochureUpdatePasterPosCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 3;

	private uint itemId_;

	public const int HKIOMCOCDNFFieldNumber = 5;

	private int hKIOMCOCDNF_;

	public const int KPGMBKKOGJGFieldNumber = 6;

	private uint kPGMBKKOGJG_;

	public const int HBCJPCMJPHEFieldNumber = 7;

	private uint hBCJPCMJPHE_;

	public const int AEHKNGBKPBEFieldNumber = 11;

	private uint aEHKNGBKPBE_;

	public const int CFIDMMFFBOEFieldNumber = 13;

	private int cFIDMMFFBOE_;

	public const int UniqueIdFieldNumber = 14;

	private ulong uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TravelBrochureUpdatePasterPosCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TravelBrochureUpdatePasterPosCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint HBCJPCMJPHE
	{
		get
		{
			return hBCJPCMJPHE_;
		}
		set
		{
			hBCJPCMJPHE_ = value;
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
	public ulong UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureUpdatePasterPosCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureUpdatePasterPosCsReq(TravelBrochureUpdatePasterPosCsReq other)
		: this()
	{
		itemId_ = other.itemId_;
		hKIOMCOCDNF_ = other.hKIOMCOCDNF_;
		kPGMBKKOGJG_ = other.kPGMBKKOGJG_;
		hBCJPCMJPHE_ = other.hBCJPCMJPHE_;
		aEHKNGBKPBE_ = other.aEHKNGBKPBE_;
		cFIDMMFFBOE_ = other.cFIDMMFFBOE_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureUpdatePasterPosCsReq Clone()
	{
		return new TravelBrochureUpdatePasterPosCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TravelBrochureUpdatePasterPosCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TravelBrochureUpdatePasterPosCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (HKIOMCOCDNF != other.HKIOMCOCDNF)
		{
			return false;
		}
		if (KPGMBKKOGJG != other.KPGMBKKOGJG)
		{
			return false;
		}
		if (HBCJPCMJPHE != other.HBCJPCMJPHE)
		{
			return false;
		}
		if (AEHKNGBKPBE != other.AEHKNGBKPBE)
		{
			return false;
		}
		if (CFIDMMFFBOE != other.CFIDMMFFBOE)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (HKIOMCOCDNF != 0)
		{
			num ^= HKIOMCOCDNF.GetHashCode();
		}
		if (KPGMBKKOGJG != 0)
		{
			num ^= KPGMBKKOGJG.GetHashCode();
		}
		if (HBCJPCMJPHE != 0)
		{
			num ^= HBCJPCMJPHE.GetHashCode();
		}
		if (AEHKNGBKPBE != 0)
		{
			num ^= AEHKNGBKPBE.GetHashCode();
		}
		if (CFIDMMFFBOE != 0)
		{
			num ^= CFIDMMFFBOE.GetHashCode();
		}
		if (UniqueId != 0L)
		{
			num ^= UniqueId.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ItemId);
		}
		if (HKIOMCOCDNF != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(HKIOMCOCDNF);
		}
		if (KPGMBKKOGJG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KPGMBKKOGJG);
		}
		if (HBCJPCMJPHE != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HBCJPCMJPHE);
		}
		if (AEHKNGBKPBE != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AEHKNGBKPBE);
		}
		if (CFIDMMFFBOE != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CFIDMMFFBOE);
		}
		if (UniqueId != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(UniqueId);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (HKIOMCOCDNF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HKIOMCOCDNF);
		}
		if (KPGMBKKOGJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPGMBKKOGJG);
		}
		if (HBCJPCMJPHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBCJPCMJPHE);
		}
		if (AEHKNGBKPBE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AEHKNGBKPBE);
		}
		if (CFIDMMFFBOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CFIDMMFFBOE);
		}
		if (UniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TravelBrochureUpdatePasterPosCsReq other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.HKIOMCOCDNF != 0)
			{
				HKIOMCOCDNF = other.HKIOMCOCDNF;
			}
			if (other.KPGMBKKOGJG != 0)
			{
				KPGMBKKOGJG = other.KPGMBKKOGJG;
			}
			if (other.HBCJPCMJPHE != 0)
			{
				HBCJPCMJPHE = other.HBCJPCMJPHE;
			}
			if (other.AEHKNGBKPBE != 0)
			{
				AEHKNGBKPBE = other.AEHKNGBKPBE;
			}
			if (other.CFIDMMFFBOE != 0)
			{
				CFIDMMFFBOE = other.CFIDMMFFBOE;
			}
			if (other.UniqueId != 0L)
			{
				UniqueId = other.UniqueId;
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
			case 24u:
				ItemId = input.ReadUInt32();
				break;
			case 40u:
				HKIOMCOCDNF = input.ReadInt32();
				break;
			case 48u:
				KPGMBKKOGJG = input.ReadUInt32();
				break;
			case 56u:
				HBCJPCMJPHE = input.ReadUInt32();
				break;
			case 88u:
				AEHKNGBKPBE = input.ReadUInt32();
				break;
			case 104u:
				CFIDMMFFBOE = input.ReadInt32();
				break;
			case 112u:
				UniqueId = input.ReadUInt64();
				break;
			}
		}
	}
}
