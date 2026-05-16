using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNABGOPKNJD : IMessage<CNABGOPKNJD>, IMessage, IEquatable<CNABGOPKNJD>, IDeepCloneable<CNABGOPKNJD>, IBufferMessage
{
	private static readonly MessageParser<CNABGOPKNJD> _parser = new MessageParser<CNABGOPKNJD>(() => new CNABGOPKNJD());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 5;

	private uint itemId_;

	public const int AEHKNGBKPBEFieldNumber = 10;

	private uint aEHKNGBKPBE_;

	public const int CFIDMMFFBOEFieldNumber = 11;

	private int cFIDMMFFBOE_;

	public const int KPGMBKKOGJGFieldNumber = 12;

	private uint kPGMBKKOGJG_;

	public const int HKIOMCOCDNFFieldNumber = 14;

	private int hKIOMCOCDNF_;

	public const int UniqueIdFieldNumber = 15;

	private ulong uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNABGOPKNJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNABGOPKNJDReflection.Descriptor.MessageTypes[0];

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
	public CNABGOPKNJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNABGOPKNJD(CNABGOPKNJD other)
		: this()
	{
		itemId_ = other.itemId_;
		aEHKNGBKPBE_ = other.aEHKNGBKPBE_;
		cFIDMMFFBOE_ = other.cFIDMMFFBOE_;
		kPGMBKKOGJG_ = other.kPGMBKKOGJG_;
		hKIOMCOCDNF_ = other.hKIOMCOCDNF_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNABGOPKNJD Clone()
	{
		return new CNABGOPKNJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNABGOPKNJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNABGOPKNJD other)
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
		if (AEHKNGBKPBE != other.AEHKNGBKPBE)
		{
			return false;
		}
		if (CFIDMMFFBOE != other.CFIDMMFFBOE)
		{
			return false;
		}
		if (KPGMBKKOGJG != other.KPGMBKKOGJG)
		{
			return false;
		}
		if (HKIOMCOCDNF != other.HKIOMCOCDNF)
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
		if (AEHKNGBKPBE != 0)
		{
			num ^= AEHKNGBKPBE.GetHashCode();
		}
		if (CFIDMMFFBOE != 0)
		{
			num ^= CFIDMMFFBOE.GetHashCode();
		}
		if (KPGMBKKOGJG != 0)
		{
			num ^= KPGMBKKOGJG.GetHashCode();
		}
		if (HKIOMCOCDNF != 0)
		{
			num ^= HKIOMCOCDNF.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(ItemId);
		}
		if (AEHKNGBKPBE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AEHKNGBKPBE);
		}
		if (CFIDMMFFBOE != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CFIDMMFFBOE);
		}
		if (KPGMBKKOGJG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KPGMBKKOGJG);
		}
		if (HKIOMCOCDNF != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(HKIOMCOCDNF);
		}
		if (UniqueId != 0L)
		{
			output.WriteRawTag(120);
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
		if (AEHKNGBKPBE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AEHKNGBKPBE);
		}
		if (CFIDMMFFBOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CFIDMMFFBOE);
		}
		if (KPGMBKKOGJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPGMBKKOGJG);
		}
		if (HKIOMCOCDNF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HKIOMCOCDNF);
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
	public void MergeFrom(CNABGOPKNJD other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.AEHKNGBKPBE != 0)
			{
				AEHKNGBKPBE = other.AEHKNGBKPBE;
			}
			if (other.CFIDMMFFBOE != 0)
			{
				CFIDMMFFBOE = other.CFIDMMFFBOE;
			}
			if (other.KPGMBKKOGJG != 0)
			{
				KPGMBKKOGJG = other.KPGMBKKOGJG;
			}
			if (other.HKIOMCOCDNF != 0)
			{
				HKIOMCOCDNF = other.HKIOMCOCDNF;
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
			case 40u:
				ItemId = input.ReadUInt32();
				break;
			case 80u:
				AEHKNGBKPBE = input.ReadUInt32();
				break;
			case 88u:
				CFIDMMFFBOE = input.ReadInt32();
				break;
			case 96u:
				KPGMBKKOGJG = input.ReadUInt32();
				break;
			case 112u:
				HKIOMCOCDNF = input.ReadInt32();
				break;
			case 120u:
				UniqueId = input.ReadUInt64();
				break;
			}
		}
	}
}
