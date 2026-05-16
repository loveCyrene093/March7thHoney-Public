using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MCAFGBPLFEH : IMessage<MCAFGBPLFEH>, IMessage, IEquatable<MCAFGBPLFEH>, IDeepCloneable<MCAFGBPLFEH>, IBufferMessage
{
	public enum PBCDMDDGMJCOneofCase
	{
		None = 0,
		PENLMEIJIFK = 2,
		DLBOLOIGPLI = 6,
		JADHGFAJEOD = 7,
		FFGCNFHIPKC = 11,
		MBBFGFBEJCP = 14,
		MHIFFAMMAGI = 239,
		AAKGEPKJHAG = 987,
		PLFJBHOGCAF = 1275,
		EFOFLGIDKKK = 1810,
		ODIDLNLGJIC = 2025
	}

	private static readonly MessageParser<MCAFGBPLFEH> _parser = new MessageParser<MCAFGBPLFEH>(() => new MCAFGBPLFEH());

	private UnknownFieldSet _unknownFields;

	public const int PNJHMGNEJJIFieldNumber = 5;

	private ulong pNJHMGNEJJI_;

	public const int ALFHNEHOBJAFieldNumber = 15;

	private OLNBHJGBHIL aLFHNEHOBJA_;

	public const int PENLMEIJIFKFieldNumber = 2;

	public const int DLBOLOIGPLIFieldNumber = 6;

	public const int JADHGFAJEODFieldNumber = 7;

	public const int FFGCNFHIPKCFieldNumber = 11;

	public const int MBBFGFBEJCPFieldNumber = 14;

	public const int MHIFFAMMAGIFieldNumber = 239;

	public const int AAKGEPKJHAGFieldNumber = 987;

	public const int PLFJBHOGCAFFieldNumber = 1275;

	public const int EFOFLGIDKKKFieldNumber = 1810;

	public const int ODIDLNLGJICFieldNumber = 2025;

	private object pBCDMDDGMJC_;

	private PBCDMDDGMJCOneofCase pBCDMDDGMJCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MCAFGBPLFEH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MCAFGBPLFEHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PNJHMGNEJJI
	{
		get
		{
			return pNJHMGNEJJI_;
		}
		set
		{
			pNJHMGNEJJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLNBHJGBHIL ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			if (!HasPENLMEIJIFK)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.PENLMEIJIFK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPENLMEIJIFK => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.PENLMEIJIFK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DLBOLOIGPLI
	{
		get
		{
			if (!HasDLBOLOIGPLI)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.DLBOLOIGPLI;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDLBOLOIGPLI => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.DLBOLOIGPLI;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JADHGFAJEOD
	{
		get
		{
			if (!HasJADHGFAJEOD)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.JADHGFAJEOD;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJADHGFAJEOD => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.JADHGFAJEOD;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FFGCNFHIPKC
	{
		get
		{
			if (!HasFFGCNFHIPKC)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.FFGCNFHIPKC;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFFGCNFHIPKC => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.FFGCNFHIPKC;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBBFGFBEJCP
	{
		get
		{
			if (!HasMBBFGFBEJCP)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.MBBFGFBEJCP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMBBFGFBEJCP => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.MBBFGFBEJCP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHIFFAMMAGI
	{
		get
		{
			if (!HasMHIFFAMMAGI)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.MHIFFAMMAGI;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMHIFFAMMAGI => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.MHIFFAMMAGI;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAKGEPKJHAG
	{
		get
		{
			if (!HasAAKGEPKJHAG)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.AAKGEPKJHAG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAAKGEPKJHAG => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.AAKGEPKJHAG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PLFJBHOGCAF
	{
		get
		{
			if (!HasPLFJBHOGCAF)
			{
				return 0uL;
			}
			return (ulong)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.PLFJBHOGCAF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPLFJBHOGCAF => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.PLFJBHOGCAF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL EFOFLGIDKKK
	{
		get
		{
			if (pBCDMDDGMJCCase_ != PBCDMDDGMJCOneofCase.EFOFLGIDKKK)
			{
				return null;
			}
			return (FDOEMKPGHFL)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = ((value != null) ? PBCDMDDGMJCOneofCase.EFOFLGIDKKK : PBCDMDDGMJCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODIDLNLGJIC
	{
		get
		{
			if (!HasODIDLNLGJIC)
			{
				return 0u;
			}
			return (uint)pBCDMDDGMJC_;
		}
		set
		{
			pBCDMDDGMJC_ = value;
			pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.ODIDLNLGJIC;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasODIDLNLGJIC => pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.ODIDLNLGJIC;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBCDMDDGMJCOneofCase PBCDMDDGMJCCase => pBCDMDDGMJCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH(MCAFGBPLFEH other)
		: this()
	{
		pNJHMGNEJJI_ = other.pNJHMGNEJJI_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		switch (other.PBCDMDDGMJCCase)
		{
		case PBCDMDDGMJCOneofCase.PENLMEIJIFK:
			PENLMEIJIFK = other.PENLMEIJIFK;
			break;
		case PBCDMDDGMJCOneofCase.DLBOLOIGPLI:
			DLBOLOIGPLI = other.DLBOLOIGPLI;
			break;
		case PBCDMDDGMJCOneofCase.JADHGFAJEOD:
			JADHGFAJEOD = other.JADHGFAJEOD;
			break;
		case PBCDMDDGMJCOneofCase.FFGCNFHIPKC:
			FFGCNFHIPKC = other.FFGCNFHIPKC;
			break;
		case PBCDMDDGMJCOneofCase.MBBFGFBEJCP:
			MBBFGFBEJCP = other.MBBFGFBEJCP;
			break;
		case PBCDMDDGMJCOneofCase.MHIFFAMMAGI:
			MHIFFAMMAGI = other.MHIFFAMMAGI;
			break;
		case PBCDMDDGMJCOneofCase.AAKGEPKJHAG:
			AAKGEPKJHAG = other.AAKGEPKJHAG;
			break;
		case PBCDMDDGMJCOneofCase.PLFJBHOGCAF:
			PLFJBHOGCAF = other.PLFJBHOGCAF;
			break;
		case PBCDMDDGMJCOneofCase.EFOFLGIDKKK:
			EFOFLGIDKKK = other.EFOFLGIDKKK.Clone();
			break;
		case PBCDMDDGMJCOneofCase.ODIDLNLGJIC:
			ODIDLNLGJIC = other.ODIDLNLGJIC;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH Clone()
	{
		return new MCAFGBPLFEH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPENLMEIJIFK()
	{
		if (HasPENLMEIJIFK)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDLBOLOIGPLI()
	{
		if (HasDLBOLOIGPLI)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJADHGFAJEOD()
	{
		if (HasJADHGFAJEOD)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFFGCNFHIPKC()
	{
		if (HasFFGCNFHIPKC)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMBBFGFBEJCP()
	{
		if (HasMBBFGFBEJCP)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMHIFFAMMAGI()
	{
		if (HasMHIFFAMMAGI)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAAKGEPKJHAG()
	{
		if (HasAAKGEPKJHAG)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPLFJBHOGCAF()
	{
		if (HasPLFJBHOGCAF)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearODIDLNLGJIC()
	{
		if (HasODIDLNLGJIC)
		{
			ClearPBCDMDDGMJC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPBCDMDDGMJC()
	{
		pBCDMDDGMJCCase_ = PBCDMDDGMJCOneofCase.None;
		pBCDMDDGMJC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MCAFGBPLFEH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MCAFGBPLFEH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNJHMGNEJJI != other.PNJHMGNEJJI)
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (DLBOLOIGPLI != other.DLBOLOIGPLI)
		{
			return false;
		}
		if (JADHGFAJEOD != other.JADHGFAJEOD)
		{
			return false;
		}
		if (FFGCNFHIPKC != other.FFGCNFHIPKC)
		{
			return false;
		}
		if (MBBFGFBEJCP != other.MBBFGFBEJCP)
		{
			return false;
		}
		if (MHIFFAMMAGI != other.MHIFFAMMAGI)
		{
			return false;
		}
		if (AAKGEPKJHAG != other.AAKGEPKJHAG)
		{
			return false;
		}
		if (PLFJBHOGCAF != other.PLFJBHOGCAF)
		{
			return false;
		}
		if (!object.Equals(EFOFLGIDKKK, other.EFOFLGIDKKK))
		{
			return false;
		}
		if (ODIDLNLGJIC != other.ODIDLNLGJIC)
		{
			return false;
		}
		if (PBCDMDDGMJCCase != other.PBCDMDDGMJCCase)
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
		if (PNJHMGNEJJI != 0L)
		{
			num ^= PNJHMGNEJJI.GetHashCode();
		}
		if (ALFHNEHOBJA != OLNBHJGBHIL.Pcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		if (HasPENLMEIJIFK)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (HasDLBOLOIGPLI)
		{
			num ^= DLBOLOIGPLI.GetHashCode();
		}
		if (HasJADHGFAJEOD)
		{
			num ^= JADHGFAJEOD.GetHashCode();
		}
		if (HasFFGCNFHIPKC)
		{
			num ^= FFGCNFHIPKC.GetHashCode();
		}
		if (HasMBBFGFBEJCP)
		{
			num ^= MBBFGFBEJCP.GetHashCode();
		}
		if (HasMHIFFAMMAGI)
		{
			num ^= MHIFFAMMAGI.GetHashCode();
		}
		if (HasAAKGEPKJHAG)
		{
			num ^= AAKGEPKJHAG.GetHashCode();
		}
		if (HasPLFJBHOGCAF)
		{
			num ^= PLFJBHOGCAF.GetHashCode();
		}
		if (pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.EFOFLGIDKKK)
		{
			num ^= EFOFLGIDKKK.GetHashCode();
		}
		if (HasODIDLNLGJIC)
		{
			num ^= ODIDLNLGJIC.GetHashCode();
		}
		num ^= (int)pBCDMDDGMJCCase_;
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
		if (HasPENLMEIJIFK)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (PNJHMGNEJJI != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(PNJHMGNEJJI);
		}
		if (HasDLBOLOIGPLI)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DLBOLOIGPLI);
		}
		if (HasJADHGFAJEOD)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JADHGFAJEOD);
		}
		if (HasFFGCNFHIPKC)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FFGCNFHIPKC);
		}
		if (HasMBBFGFBEJCP)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MBBFGFBEJCP);
		}
		if (ALFHNEHOBJA != OLNBHJGBHIL.Pcpdhelpkem)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		if (HasMHIFFAMMAGI)
		{
			output.WriteRawTag(248, 14);
			output.WriteUInt32(MHIFFAMMAGI);
		}
		if (HasAAKGEPKJHAG)
		{
			output.WriteRawTag(216, 61);
			output.WriteUInt32(AAKGEPKJHAG);
		}
		if (HasPLFJBHOGCAF)
		{
			output.WriteRawTag(216, 79);
			output.WriteUInt64(PLFJBHOGCAF);
		}
		if (pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.EFOFLGIDKKK)
		{
			output.WriteRawTag(146, 113);
			output.WriteMessage(EFOFLGIDKKK);
		}
		if (HasODIDLNLGJIC)
		{
			output.WriteRawTag(200, 126);
			output.WriteUInt32(ODIDLNLGJIC);
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
		if (PNJHMGNEJJI != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PNJHMGNEJJI);
		}
		if (ALFHNEHOBJA != OLNBHJGBHIL.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (HasPENLMEIJIFK)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (HasDLBOLOIGPLI)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DLBOLOIGPLI);
		}
		if (HasJADHGFAJEOD)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JADHGFAJEOD);
		}
		if (HasFFGCNFHIPKC)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FFGCNFHIPKC);
		}
		if (HasMBBFGFBEJCP)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBBFGFBEJCP);
		}
		if (HasMHIFFAMMAGI)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MHIFFAMMAGI);
		}
		if (HasAAKGEPKJHAG)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AAKGEPKJHAG);
		}
		if (HasPLFJBHOGCAF)
		{
			num += 2 + CodedOutputStream.ComputeUInt64Size(PLFJBHOGCAF);
		}
		if (pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.EFOFLGIDKKK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EFOFLGIDKKK);
		}
		if (HasODIDLNLGJIC)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ODIDLNLGJIC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MCAFGBPLFEH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PNJHMGNEJJI != 0L)
		{
			PNJHMGNEJJI = other.PNJHMGNEJJI;
		}
		if (other.ALFHNEHOBJA != OLNBHJGBHIL.Pcpdhelpkem)
		{
			ALFHNEHOBJA = other.ALFHNEHOBJA;
		}
		switch (other.PBCDMDDGMJCCase)
		{
		case PBCDMDDGMJCOneofCase.PENLMEIJIFK:
			PENLMEIJIFK = other.PENLMEIJIFK;
			break;
		case PBCDMDDGMJCOneofCase.DLBOLOIGPLI:
			DLBOLOIGPLI = other.DLBOLOIGPLI;
			break;
		case PBCDMDDGMJCOneofCase.JADHGFAJEOD:
			JADHGFAJEOD = other.JADHGFAJEOD;
			break;
		case PBCDMDDGMJCOneofCase.FFGCNFHIPKC:
			FFGCNFHIPKC = other.FFGCNFHIPKC;
			break;
		case PBCDMDDGMJCOneofCase.MBBFGFBEJCP:
			MBBFGFBEJCP = other.MBBFGFBEJCP;
			break;
		case PBCDMDDGMJCOneofCase.MHIFFAMMAGI:
			MHIFFAMMAGI = other.MHIFFAMMAGI;
			break;
		case PBCDMDDGMJCOneofCase.AAKGEPKJHAG:
			AAKGEPKJHAG = other.AAKGEPKJHAG;
			break;
		case PBCDMDDGMJCOneofCase.PLFJBHOGCAF:
			PLFJBHOGCAF = other.PLFJBHOGCAF;
			break;
		case PBCDMDDGMJCOneofCase.EFOFLGIDKKK:
			if (EFOFLGIDKKK == null)
			{
				EFOFLGIDKKK = new FDOEMKPGHFL();
			}
			EFOFLGIDKKK.MergeFrom(other.EFOFLGIDKKK);
			break;
		case PBCDMDDGMJCOneofCase.ODIDLNLGJIC:
			ODIDLNLGJIC = other.ODIDLNLGJIC;
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
			case 16u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 40u:
				PNJHMGNEJJI = input.ReadUInt64();
				break;
			case 48u:
				DLBOLOIGPLI = input.ReadUInt32();
				break;
			case 56u:
				JADHGFAJEOD = input.ReadUInt32();
				break;
			case 88u:
				FFGCNFHIPKC = input.ReadUInt32();
				break;
			case 112u:
				MBBFGFBEJCP = input.ReadUInt32();
				break;
			case 120u:
				ALFHNEHOBJA = (OLNBHJGBHIL)input.ReadEnum();
				break;
			case 1912u:
				MHIFFAMMAGI = input.ReadUInt32();
				break;
			case 7896u:
				AAKGEPKJHAG = input.ReadUInt32();
				break;
			case 10200u:
				PLFJBHOGCAF = input.ReadUInt64();
				break;
			case 14482u:
			{
				FDOEMKPGHFL fDOEMKPGHFL = new FDOEMKPGHFL();
				if (pBCDMDDGMJCCase_ == PBCDMDDGMJCOneofCase.EFOFLGIDKKK)
				{
					fDOEMKPGHFL.MergeFrom(EFOFLGIDKKK);
				}
				input.ReadMessage(fDOEMKPGHFL);
				EFOFLGIDKKK = fDOEMKPGHFL;
				break;
			}
			case 16200u:
				ODIDLNLGJIC = input.ReadUInt32();
				break;
			}
		}
	}
}
