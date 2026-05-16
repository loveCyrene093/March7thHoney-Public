using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BPNPHGLDIMI : IMessage<BPNPHGLDIMI>, IMessage, IEquatable<BPNPHGLDIMI>, IDeepCloneable<BPNPHGLDIMI>, IBufferMessage
{
	public enum HPJKLCALLBIOneofCase
	{
		None = 0,
		FFDMHIKJGJO = 4,
		ABEAGHKIGGI = 6,
		ELIBDJODAHC = 7,
		PCOMAKHDOGM = 8,
		JMGCGFFNKBL = 9,
		JNFBDHFLKFE = 10,
		DNCMKIJENIH = 12,
		IEPPEEGMNNA = 14
	}

	private static readonly MessageParser<BPNPHGLDIMI> _parser = new MessageParser<BPNPHGLDIMI>(() => new BPNPHGLDIMI());

	private UnknownFieldSet _unknownFields;

	public const int NNFAMOJAHCHFieldNumber = 5;

	private uint nNFAMOJAHCH_;

	public const int FFDMHIKJGJOFieldNumber = 4;

	public const int ABEAGHKIGGIFieldNumber = 6;

	public const int ELIBDJODAHCFieldNumber = 7;

	public const int PCOMAKHDOGMFieldNumber = 8;

	public const int JMGCGFFNKBLFieldNumber = 9;

	public const int JNFBDHFLKFEFieldNumber = 10;

	public const int DNCMKIJENIHFieldNumber = 12;

	public const int IEPPEEGMNNAFieldNumber = 14;

	private object hPJKLCALLBI_;

	private HPJKLCALLBIOneofCase hPJKLCALLBICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BPNPHGLDIMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BPNPHGLDIMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNFAMOJAHCH
	{
		get
		{
			return nNFAMOJAHCH_;
		}
		set
		{
			nNFAMOJAHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFGFKJMIAIH FFDMHIKJGJO
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.FFDMHIKJGJO)
			{
				return null;
			}
			return (IFGFKJMIAIH)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.FFDMHIKJGJO : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKHNMPALBLD ABEAGHKIGGI
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.ABEAGHKIGGI)
			{
				return null;
			}
			return (EKHNMPALBLD)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.ABEAGHKIGGI : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGJHPEOPBJB ELIBDJODAHC
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.ELIBDJODAHC)
			{
				return null;
			}
			return (LGJHPEOPBJB)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.ELIBDJODAHC : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKHLIKPKAOI PCOMAKHDOGM
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.PCOMAKHDOGM)
			{
				return null;
			}
			return (EKHLIKPKAOI)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.PCOMAKHDOGM : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCILKEGOBAA JMGCGFFNKBL
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.JMGCGFFNKBL)
			{
				return null;
			}
			return (BCILKEGOBAA)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.JMGCGFFNKBL : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNAHGMJFBK JNFBDHFLKFE
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.JNFBDHFLKFE)
			{
				return null;
			}
			return (LKNAHGMJFBK)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.JNFBDHFLKFE : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DNCMKIJENIH
	{
		get
		{
			if (!HasDNCMKIJENIH)
			{
				return false;
			}
			return (bool)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = HPJKLCALLBIOneofCase.DNCMKIJENIH;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDNCMKIJENIH => hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.DNCMKIJENIH;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBPNGCPECON IEPPEEGMNNA
	{
		get
		{
			if (hPJKLCALLBICase_ != HPJKLCALLBIOneofCase.IEPPEEGMNNA)
			{
				return null;
			}
			return (OBPNGCPECON)hPJKLCALLBI_;
		}
		set
		{
			hPJKLCALLBI_ = value;
			hPJKLCALLBICase_ = ((value != null) ? HPJKLCALLBIOneofCase.IEPPEEGMNNA : HPJKLCALLBIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPJKLCALLBIOneofCase HPJKLCALLBICase => hPJKLCALLBICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPNPHGLDIMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPNPHGLDIMI(BPNPHGLDIMI other)
		: this()
	{
		nNFAMOJAHCH_ = other.nNFAMOJAHCH_;
		switch (other.HPJKLCALLBICase)
		{
		case HPJKLCALLBIOneofCase.FFDMHIKJGJO:
			FFDMHIKJGJO = other.FFDMHIKJGJO.Clone();
			break;
		case HPJKLCALLBIOneofCase.ABEAGHKIGGI:
			ABEAGHKIGGI = other.ABEAGHKIGGI.Clone();
			break;
		case HPJKLCALLBIOneofCase.ELIBDJODAHC:
			ELIBDJODAHC = other.ELIBDJODAHC.Clone();
			break;
		case HPJKLCALLBIOneofCase.PCOMAKHDOGM:
			PCOMAKHDOGM = other.PCOMAKHDOGM.Clone();
			break;
		case HPJKLCALLBIOneofCase.JMGCGFFNKBL:
			JMGCGFFNKBL = other.JMGCGFFNKBL.Clone();
			break;
		case HPJKLCALLBIOneofCase.JNFBDHFLKFE:
			JNFBDHFLKFE = other.JNFBDHFLKFE.Clone();
			break;
		case HPJKLCALLBIOneofCase.DNCMKIJENIH:
			DNCMKIJENIH = other.DNCMKIJENIH;
			break;
		case HPJKLCALLBIOneofCase.IEPPEEGMNNA:
			IEPPEEGMNNA = other.IEPPEEGMNNA.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPNPHGLDIMI Clone()
	{
		return new BPNPHGLDIMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDNCMKIJENIH()
	{
		if (HasDNCMKIJENIH)
		{
			ClearHPJKLCALLBI();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHPJKLCALLBI()
	{
		hPJKLCALLBICase_ = HPJKLCALLBIOneofCase.None;
		hPJKLCALLBI_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BPNPHGLDIMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BPNPHGLDIMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NNFAMOJAHCH != other.NNFAMOJAHCH)
		{
			return false;
		}
		if (!object.Equals(FFDMHIKJGJO, other.FFDMHIKJGJO))
		{
			return false;
		}
		if (!object.Equals(ABEAGHKIGGI, other.ABEAGHKIGGI))
		{
			return false;
		}
		if (!object.Equals(ELIBDJODAHC, other.ELIBDJODAHC))
		{
			return false;
		}
		if (!object.Equals(PCOMAKHDOGM, other.PCOMAKHDOGM))
		{
			return false;
		}
		if (!object.Equals(JMGCGFFNKBL, other.JMGCGFFNKBL))
		{
			return false;
		}
		if (!object.Equals(JNFBDHFLKFE, other.JNFBDHFLKFE))
		{
			return false;
		}
		if (DNCMKIJENIH != other.DNCMKIJENIH)
		{
			return false;
		}
		if (!object.Equals(IEPPEEGMNNA, other.IEPPEEGMNNA))
		{
			return false;
		}
		if (HPJKLCALLBICase != other.HPJKLCALLBICase)
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
		if (NNFAMOJAHCH != 0)
		{
			num ^= NNFAMOJAHCH.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.FFDMHIKJGJO)
		{
			num ^= FFDMHIKJGJO.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ABEAGHKIGGI)
		{
			num ^= ABEAGHKIGGI.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ELIBDJODAHC)
		{
			num ^= ELIBDJODAHC.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.PCOMAKHDOGM)
		{
			num ^= PCOMAKHDOGM.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JMGCGFFNKBL)
		{
			num ^= JMGCGFFNKBL.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JNFBDHFLKFE)
		{
			num ^= JNFBDHFLKFE.GetHashCode();
		}
		if (HasDNCMKIJENIH)
		{
			num ^= DNCMKIJENIH.GetHashCode();
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.IEPPEEGMNNA)
		{
			num ^= IEPPEEGMNNA.GetHashCode();
		}
		num ^= (int)hPJKLCALLBICase_;
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
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.FFDMHIKJGJO)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FFDMHIKJGJO);
		}
		if (NNFAMOJAHCH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NNFAMOJAHCH);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ABEAGHKIGGI)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ABEAGHKIGGI);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ELIBDJODAHC)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ELIBDJODAHC);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.PCOMAKHDOGM)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PCOMAKHDOGM);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JMGCGFFNKBL)
		{
			output.WriteRawTag(74);
			output.WriteMessage(JMGCGFFNKBL);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JNFBDHFLKFE)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JNFBDHFLKFE);
		}
		if (HasDNCMKIJENIH)
		{
			output.WriteRawTag(96);
			output.WriteBool(DNCMKIJENIH);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.IEPPEEGMNNA)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IEPPEEGMNNA);
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
		if (NNFAMOJAHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNFAMOJAHCH);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.FFDMHIKJGJO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFDMHIKJGJO);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ABEAGHKIGGI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABEAGHKIGGI);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ELIBDJODAHC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ELIBDJODAHC);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.PCOMAKHDOGM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PCOMAKHDOGM);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JMGCGFFNKBL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JMGCGFFNKBL);
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JNFBDHFLKFE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNFBDHFLKFE);
		}
		if (HasDNCMKIJENIH)
		{
			num += 2;
		}
		if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.IEPPEEGMNNA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IEPPEEGMNNA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BPNPHGLDIMI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NNFAMOJAHCH != 0)
		{
			NNFAMOJAHCH = other.NNFAMOJAHCH;
		}
		switch (other.HPJKLCALLBICase)
		{
		case HPJKLCALLBIOneofCase.FFDMHIKJGJO:
			if (FFDMHIKJGJO == null)
			{
				FFDMHIKJGJO = new IFGFKJMIAIH();
			}
			FFDMHIKJGJO.MergeFrom(other.FFDMHIKJGJO);
			break;
		case HPJKLCALLBIOneofCase.ABEAGHKIGGI:
			if (ABEAGHKIGGI == null)
			{
				ABEAGHKIGGI = new EKHNMPALBLD();
			}
			ABEAGHKIGGI.MergeFrom(other.ABEAGHKIGGI);
			break;
		case HPJKLCALLBIOneofCase.ELIBDJODAHC:
			if (ELIBDJODAHC == null)
			{
				ELIBDJODAHC = new LGJHPEOPBJB();
			}
			ELIBDJODAHC.MergeFrom(other.ELIBDJODAHC);
			break;
		case HPJKLCALLBIOneofCase.PCOMAKHDOGM:
			if (PCOMAKHDOGM == null)
			{
				PCOMAKHDOGM = new EKHLIKPKAOI();
			}
			PCOMAKHDOGM.MergeFrom(other.PCOMAKHDOGM);
			break;
		case HPJKLCALLBIOneofCase.JMGCGFFNKBL:
			if (JMGCGFFNKBL == null)
			{
				JMGCGFFNKBL = new BCILKEGOBAA();
			}
			JMGCGFFNKBL.MergeFrom(other.JMGCGFFNKBL);
			break;
		case HPJKLCALLBIOneofCase.JNFBDHFLKFE:
			if (JNFBDHFLKFE == null)
			{
				JNFBDHFLKFE = new LKNAHGMJFBK();
			}
			JNFBDHFLKFE.MergeFrom(other.JNFBDHFLKFE);
			break;
		case HPJKLCALLBIOneofCase.DNCMKIJENIH:
			DNCMKIJENIH = other.DNCMKIJENIH;
			break;
		case HPJKLCALLBIOneofCase.IEPPEEGMNNA:
			if (IEPPEEGMNNA == null)
			{
				IEPPEEGMNNA = new OBPNGCPECON();
			}
			IEPPEEGMNNA.MergeFrom(other.IEPPEEGMNNA);
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
			case 34u:
			{
				IFGFKJMIAIH iFGFKJMIAIH = new IFGFKJMIAIH();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.FFDMHIKJGJO)
				{
					iFGFKJMIAIH.MergeFrom(FFDMHIKJGJO);
				}
				input.ReadMessage(iFGFKJMIAIH);
				FFDMHIKJGJO = iFGFKJMIAIH;
				break;
			}
			case 40u:
				NNFAMOJAHCH = input.ReadUInt32();
				break;
			case 50u:
			{
				EKHNMPALBLD eKHNMPALBLD = new EKHNMPALBLD();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ABEAGHKIGGI)
				{
					eKHNMPALBLD.MergeFrom(ABEAGHKIGGI);
				}
				input.ReadMessage(eKHNMPALBLD);
				ABEAGHKIGGI = eKHNMPALBLD;
				break;
			}
			case 58u:
			{
				LGJHPEOPBJB lGJHPEOPBJB = new LGJHPEOPBJB();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.ELIBDJODAHC)
				{
					lGJHPEOPBJB.MergeFrom(ELIBDJODAHC);
				}
				input.ReadMessage(lGJHPEOPBJB);
				ELIBDJODAHC = lGJHPEOPBJB;
				break;
			}
			case 66u:
			{
				EKHLIKPKAOI eKHLIKPKAOI = new EKHLIKPKAOI();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.PCOMAKHDOGM)
				{
					eKHLIKPKAOI.MergeFrom(PCOMAKHDOGM);
				}
				input.ReadMessage(eKHLIKPKAOI);
				PCOMAKHDOGM = eKHLIKPKAOI;
				break;
			}
			case 74u:
			{
				BCILKEGOBAA bCILKEGOBAA = new BCILKEGOBAA();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JMGCGFFNKBL)
				{
					bCILKEGOBAA.MergeFrom(JMGCGFFNKBL);
				}
				input.ReadMessage(bCILKEGOBAA);
				JMGCGFFNKBL = bCILKEGOBAA;
				break;
			}
			case 82u:
			{
				LKNAHGMJFBK lKNAHGMJFBK = new LKNAHGMJFBK();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.JNFBDHFLKFE)
				{
					lKNAHGMJFBK.MergeFrom(JNFBDHFLKFE);
				}
				input.ReadMessage(lKNAHGMJFBK);
				JNFBDHFLKFE = lKNAHGMJFBK;
				break;
			}
			case 96u:
				DNCMKIJENIH = input.ReadBool();
				break;
			case 114u:
			{
				OBPNGCPECON oBPNGCPECON = new OBPNGCPECON();
				if (hPJKLCALLBICase_ == HPJKLCALLBIOneofCase.IEPPEEGMNNA)
				{
					oBPNGCPECON.MergeFrom(IEPPEEGMNNA);
				}
				input.ReadMessage(oBPNGCPECON);
				IEPPEEGMNNA = oBPNGCPECON;
				break;
			}
			}
		}
	}
}
