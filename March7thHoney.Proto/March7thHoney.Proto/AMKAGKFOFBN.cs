using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AMKAGKFOFBN : IMessage<AMKAGKFOFBN>, IMessage, IEquatable<AMKAGKFOFBN>, IDeepCloneable<AMKAGKFOFBN>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		MPFFNJPLDOJ = 2,
		BAAOAJIPMNI = 4,
		BKNLAFCPBHN = 5,
		LOCCAGJDJEB = 7,
		LMNKHJHOALK = 9,
		DNFINNGIJBH = 11,
		HEJKKEABLLA = 14,
		JLEOJMEAFAG = 15,
		BNHBIJBKJIP = 351,
		MLEPNLANMJI = 568,
		BKCMKIKBAEP = 1069,
		AEPLAIKAGDB = 1585
	}

	private static readonly MessageParser<AMKAGKFOFBN> _parser = new MessageParser<AMKAGKFOFBN>(() => new AMKAGKFOFBN());

	private UnknownFieldSet _unknownFields;

	public const int MPFFNJPLDOJFieldNumber = 2;

	public const int BAAOAJIPMNIFieldNumber = 4;

	public const int BKNLAFCPBHNFieldNumber = 5;

	public const int LOCCAGJDJEBFieldNumber = 7;

	public const int LMNKHJHOALKFieldNumber = 9;

	public const int DNFINNGIJBHFieldNumber = 11;

	public const int HEJKKEABLLAFieldNumber = 14;

	public const int JLEOJMEAFAGFieldNumber = 15;

	public const int BNHBIJBKJIPFieldNumber = 351;

	public const int MLEPNLANMJIFieldNumber = 568;

	public const int BKCMKIKBAEPFieldNumber = 1069;

	public const int AEPLAIKAGDBFieldNumber = 1585;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AMKAGKFOFBN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AMKAGKFOFBNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONJIOJDEECD MPFFNJPLDOJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MPFFNJPLDOJ)
			{
				return null;
			}
			return (ONJIOJDEECD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MPFFNJPLDOJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHFAFHPLJLA BAAOAJIPMNI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BAAOAJIPMNI)
			{
				return null;
			}
			return (AHFAFHPLJLA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BAAOAJIPMNI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHFAFHPLJLA BKNLAFCPBHN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BKNLAFCPBHN)
			{
				return null;
			}
			return (AHFAFHPLJLA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BKNLAFCPBHN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKIGGHACECO LOCCAGJDJEB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LOCCAGJDJEB)
			{
				return null;
			}
			return (JKIGGHACECO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LOCCAGJDJEB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAACEGAEDLI LMNKHJHOALK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LMNKHJHOALK)
			{
				return null;
			}
			return (BAACEGAEDLI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LMNKHJHOALK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPKHODIPBKA DNFINNGIJBH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.DNFINNGIJBH)
			{
				return null;
			}
			return (DPKHODIPBKA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.DNFINNGIJBH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEJKKEABLLA
	{
		get
		{
			if (!HasHEJKKEABLLA)
			{
				return 0u;
			}
			return (uint)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.HEJKKEABLLA;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHEJKKEABLLA => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HEJKKEABLLA;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGBIIDOPID JLEOJMEAFAG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JLEOJMEAFAG)
			{
				return null;
			}
			return (MMGBIIDOPID)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JLEOJMEAFAG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONCJDNJMCIN BNHBIJBKJIP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BNHBIJBKJIP)
			{
				return null;
			}
			return (ONCJDNJMCIN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BNHBIJBKJIP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDNFMEMPFHK MLEPNLANMJI
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MLEPNLANMJI)
			{
				return null;
			}
			return (BDNFMEMPFHK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MLEPNLANMJI : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKCMKIKBAEP
	{
		get
		{
			if (!HasBKCMKIKBAEP)
			{
				return 0u;
			}
			return (uint)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.BKCMKIKBAEP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBKCMKIKBAEP => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BKCMKIKBAEP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AEPLAIKAGDB
	{
		get
		{
			if (!HasAEPLAIKAGDB)
			{
				return 0u;
			}
			return (uint)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.AEPLAIKAGDB;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAEPLAIKAGDB => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AEPLAIKAGDB;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMKAGKFOFBN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMKAGKFOFBN(AMKAGKFOFBN other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.MPFFNJPLDOJ:
			MPFFNJPLDOJ = other.MPFFNJPLDOJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BAAOAJIPMNI:
			BAAOAJIPMNI = other.BAAOAJIPMNI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BKNLAFCPBHN:
			BKNLAFCPBHN = other.BKNLAFCPBHN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LOCCAGJDJEB:
			LOCCAGJDJEB = other.LOCCAGJDJEB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LMNKHJHOALK:
			LMNKHJHOALK = other.LMNKHJHOALK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.DNFINNGIJBH:
			DNFINNGIJBH = other.DNFINNGIJBH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HEJKKEABLLA:
			HEJKKEABLLA = other.HEJKKEABLLA;
			break;
		case BPIHFAJCLOCOneofCase.JLEOJMEAFAG:
			JLEOJMEAFAG = other.JLEOJMEAFAG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BNHBIJBKJIP:
			BNHBIJBKJIP = other.BNHBIJBKJIP.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MLEPNLANMJI:
			MLEPNLANMJI = other.MLEPNLANMJI.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BKCMKIKBAEP:
			BKCMKIKBAEP = other.BKCMKIKBAEP;
			break;
		case BPIHFAJCLOCOneofCase.AEPLAIKAGDB:
			AEPLAIKAGDB = other.AEPLAIKAGDB;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMKAGKFOFBN Clone()
	{
		return new AMKAGKFOFBN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHEJKKEABLLA()
	{
		if (HasHEJKKEABLLA)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBKCMKIKBAEP()
	{
		if (HasBKCMKIKBAEP)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAEPLAIKAGDB()
	{
		if (HasAEPLAIKAGDB)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AMKAGKFOFBN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AMKAGKFOFBN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MPFFNJPLDOJ, other.MPFFNJPLDOJ))
		{
			return false;
		}
		if (!object.Equals(BAAOAJIPMNI, other.BAAOAJIPMNI))
		{
			return false;
		}
		if (!object.Equals(BKNLAFCPBHN, other.BKNLAFCPBHN))
		{
			return false;
		}
		if (!object.Equals(LOCCAGJDJEB, other.LOCCAGJDJEB))
		{
			return false;
		}
		if (!object.Equals(LMNKHJHOALK, other.LMNKHJHOALK))
		{
			return false;
		}
		if (!object.Equals(DNFINNGIJBH, other.DNFINNGIJBH))
		{
			return false;
		}
		if (HEJKKEABLLA != other.HEJKKEABLLA)
		{
			return false;
		}
		if (!object.Equals(JLEOJMEAFAG, other.JLEOJMEAFAG))
		{
			return false;
		}
		if (!object.Equals(BNHBIJBKJIP, other.BNHBIJBKJIP))
		{
			return false;
		}
		if (!object.Equals(MLEPNLANMJI, other.MLEPNLANMJI))
		{
			return false;
		}
		if (BKCMKIKBAEP != other.BKCMKIKBAEP)
		{
			return false;
		}
		if (AEPLAIKAGDB != other.AEPLAIKAGDB)
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MPFFNJPLDOJ)
		{
			num ^= MPFFNJPLDOJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAOAJIPMNI)
		{
			num ^= BAAOAJIPMNI.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BKNLAFCPBHN)
		{
			num ^= BKNLAFCPBHN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LOCCAGJDJEB)
		{
			num ^= LOCCAGJDJEB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMNKHJHOALK)
		{
			num ^= LMNKHJHOALK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DNFINNGIJBH)
		{
			num ^= DNFINNGIJBH.GetHashCode();
		}
		if (HasHEJKKEABLLA)
		{
			num ^= HEJKKEABLLA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLEOJMEAFAG)
		{
			num ^= JLEOJMEAFAG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BNHBIJBKJIP)
		{
			num ^= BNHBIJBKJIP.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLEPNLANMJI)
		{
			num ^= MLEPNLANMJI.GetHashCode();
		}
		if (HasBKCMKIKBAEP)
		{
			num ^= BKCMKIKBAEP.GetHashCode();
		}
		if (HasAEPLAIKAGDB)
		{
			num ^= AEPLAIKAGDB.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MPFFNJPLDOJ)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MPFFNJPLDOJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAOAJIPMNI)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BAAOAJIPMNI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BKNLAFCPBHN)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BKNLAFCPBHN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LOCCAGJDJEB)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LOCCAGJDJEB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMNKHJHOALK)
		{
			output.WriteRawTag(74);
			output.WriteMessage(LMNKHJHOALK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DNFINNGIJBH)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DNFINNGIJBH);
		}
		if (HasHEJKKEABLLA)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HEJKKEABLLA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLEOJMEAFAG)
		{
			output.WriteRawTag(122);
			output.WriteMessage(JLEOJMEAFAG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BNHBIJBKJIP)
		{
			output.WriteRawTag(250, 21);
			output.WriteMessage(BNHBIJBKJIP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLEPNLANMJI)
		{
			output.WriteRawTag(194, 35);
			output.WriteMessage(MLEPNLANMJI);
		}
		if (HasBKCMKIKBAEP)
		{
			output.WriteRawTag(232, 66);
			output.WriteUInt32(BKCMKIKBAEP);
		}
		if (HasAEPLAIKAGDB)
		{
			output.WriteRawTag(136, 99);
			output.WriteUInt32(AEPLAIKAGDB);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MPFFNJPLDOJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MPFFNJPLDOJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAOAJIPMNI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BAAOAJIPMNI);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BKNLAFCPBHN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BKNLAFCPBHN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LOCCAGJDJEB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LOCCAGJDJEB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMNKHJHOALK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LMNKHJHOALK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DNFINNGIJBH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DNFINNGIJBH);
		}
		if (HasHEJKKEABLLA)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEJKKEABLLA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLEOJMEAFAG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JLEOJMEAFAG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BNHBIJBKJIP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BNHBIJBKJIP);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLEPNLANMJI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MLEPNLANMJI);
		}
		if (HasBKCMKIKBAEP)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BKCMKIKBAEP);
		}
		if (HasAEPLAIKAGDB)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AEPLAIKAGDB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AMKAGKFOFBN other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.MPFFNJPLDOJ:
			if (MPFFNJPLDOJ == null)
			{
				MPFFNJPLDOJ = new ONJIOJDEECD();
			}
			MPFFNJPLDOJ.MergeFrom(other.MPFFNJPLDOJ);
			break;
		case BPIHFAJCLOCOneofCase.BAAOAJIPMNI:
			if (BAAOAJIPMNI == null)
			{
				BAAOAJIPMNI = new AHFAFHPLJLA();
			}
			BAAOAJIPMNI.MergeFrom(other.BAAOAJIPMNI);
			break;
		case BPIHFAJCLOCOneofCase.BKNLAFCPBHN:
			if (BKNLAFCPBHN == null)
			{
				BKNLAFCPBHN = new AHFAFHPLJLA();
			}
			BKNLAFCPBHN.MergeFrom(other.BKNLAFCPBHN);
			break;
		case BPIHFAJCLOCOneofCase.LOCCAGJDJEB:
			if (LOCCAGJDJEB == null)
			{
				LOCCAGJDJEB = new JKIGGHACECO();
			}
			LOCCAGJDJEB.MergeFrom(other.LOCCAGJDJEB);
			break;
		case BPIHFAJCLOCOneofCase.LMNKHJHOALK:
			if (LMNKHJHOALK == null)
			{
				LMNKHJHOALK = new BAACEGAEDLI();
			}
			LMNKHJHOALK.MergeFrom(other.LMNKHJHOALK);
			break;
		case BPIHFAJCLOCOneofCase.DNFINNGIJBH:
			if (DNFINNGIJBH == null)
			{
				DNFINNGIJBH = new DPKHODIPBKA();
			}
			DNFINNGIJBH.MergeFrom(other.DNFINNGIJBH);
			break;
		case BPIHFAJCLOCOneofCase.HEJKKEABLLA:
			HEJKKEABLLA = other.HEJKKEABLLA;
			break;
		case BPIHFAJCLOCOneofCase.JLEOJMEAFAG:
			if (JLEOJMEAFAG == null)
			{
				JLEOJMEAFAG = new MMGBIIDOPID();
			}
			JLEOJMEAFAG.MergeFrom(other.JLEOJMEAFAG);
			break;
		case BPIHFAJCLOCOneofCase.BNHBIJBKJIP:
			if (BNHBIJBKJIP == null)
			{
				BNHBIJBKJIP = new ONCJDNJMCIN();
			}
			BNHBIJBKJIP.MergeFrom(other.BNHBIJBKJIP);
			break;
		case BPIHFAJCLOCOneofCase.MLEPNLANMJI:
			if (MLEPNLANMJI == null)
			{
				MLEPNLANMJI = new BDNFMEMPFHK();
			}
			MLEPNLANMJI.MergeFrom(other.MLEPNLANMJI);
			break;
		case BPIHFAJCLOCOneofCase.BKCMKIKBAEP:
			BKCMKIKBAEP = other.BKCMKIKBAEP;
			break;
		case BPIHFAJCLOCOneofCase.AEPLAIKAGDB:
			AEPLAIKAGDB = other.AEPLAIKAGDB;
			break;
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
			case 18u:
			{
				ONJIOJDEECD oNJIOJDEECD = new ONJIOJDEECD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MPFFNJPLDOJ)
				{
					oNJIOJDEECD.MergeFrom(MPFFNJPLDOJ);
				}
				input.ReadMessage(oNJIOJDEECD);
				MPFFNJPLDOJ = oNJIOJDEECD;
				break;
			}
			case 34u:
			{
				AHFAFHPLJLA aHFAFHPLJLA = new AHFAFHPLJLA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAOAJIPMNI)
				{
					aHFAFHPLJLA.MergeFrom(BAAOAJIPMNI);
				}
				input.ReadMessage(aHFAFHPLJLA);
				BAAOAJIPMNI = aHFAFHPLJLA;
				break;
			}
			case 42u:
			{
				AHFAFHPLJLA aHFAFHPLJLA2 = new AHFAFHPLJLA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BKNLAFCPBHN)
				{
					aHFAFHPLJLA2.MergeFrom(BKNLAFCPBHN);
				}
				input.ReadMessage(aHFAFHPLJLA2);
				BKNLAFCPBHN = aHFAFHPLJLA2;
				break;
			}
			case 58u:
			{
				JKIGGHACECO jKIGGHACECO = new JKIGGHACECO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LOCCAGJDJEB)
				{
					jKIGGHACECO.MergeFrom(LOCCAGJDJEB);
				}
				input.ReadMessage(jKIGGHACECO);
				LOCCAGJDJEB = jKIGGHACECO;
				break;
			}
			case 74u:
			{
				BAACEGAEDLI bAACEGAEDLI = new BAACEGAEDLI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LMNKHJHOALK)
				{
					bAACEGAEDLI.MergeFrom(LMNKHJHOALK);
				}
				input.ReadMessage(bAACEGAEDLI);
				LMNKHJHOALK = bAACEGAEDLI;
				break;
			}
			case 90u:
			{
				DPKHODIPBKA dPKHODIPBKA = new DPKHODIPBKA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DNFINNGIJBH)
				{
					dPKHODIPBKA.MergeFrom(DNFINNGIJBH);
				}
				input.ReadMessage(dPKHODIPBKA);
				DNFINNGIJBH = dPKHODIPBKA;
				break;
			}
			case 112u:
				HEJKKEABLLA = input.ReadUInt32();
				break;
			case 122u:
			{
				MMGBIIDOPID mMGBIIDOPID = new MMGBIIDOPID();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JLEOJMEAFAG)
				{
					mMGBIIDOPID.MergeFrom(JLEOJMEAFAG);
				}
				input.ReadMessage(mMGBIIDOPID);
				JLEOJMEAFAG = mMGBIIDOPID;
				break;
			}
			case 2810u:
			{
				ONCJDNJMCIN oNCJDNJMCIN = new ONCJDNJMCIN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BNHBIJBKJIP)
				{
					oNCJDNJMCIN.MergeFrom(BNHBIJBKJIP);
				}
				input.ReadMessage(oNCJDNJMCIN);
				BNHBIJBKJIP = oNCJDNJMCIN;
				break;
			}
			case 4546u:
			{
				BDNFMEMPFHK bDNFMEMPFHK = new BDNFMEMPFHK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MLEPNLANMJI)
				{
					bDNFMEMPFHK.MergeFrom(MLEPNLANMJI);
				}
				input.ReadMessage(bDNFMEMPFHK);
				MLEPNLANMJI = bDNFMEMPFHK;
				break;
			}
			case 8552u:
				BKCMKIKBAEP = input.ReadUInt32();
				break;
			case 12680u:
				AEPLAIKAGDB = input.ReadUInt32();
				break;
			}
		}
	}
}
