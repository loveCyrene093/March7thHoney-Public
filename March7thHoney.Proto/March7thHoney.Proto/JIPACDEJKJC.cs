using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIPACDEJKJC : IMessage<JIPACDEJKJC>, IMessage, IEquatable<JIPACDEJKJC>, IDeepCloneable<JIPACDEJKJC>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		CCNFDLHKJFM = 1,
		CDNENMBMOKH = 3,
		FFFDHGGPNPM = 6,
		FMJMNFIBCAH = 7,
		NAEJHJIEOBD = 12,
		ADECNJPKJFI = 13
	}

	private static readonly MessageParser<JIPACDEJKJC> _parser = new MessageParser<JIPACDEJKJC>(() => new JIPACDEJKJC());

	private UnknownFieldSet _unknownFields;

	public const int PHKAHAHLDAEFieldNumber = 2;

	private uint pHKAHAHLDAE_;

	public const int GAFPECGGICCFieldNumber = 5;

	private uint gAFPECGGICC_;

	public const int EMFHLBBOCFKFieldNumber = 9;

	private uint eMFHLBBOCFK_;

	public const int JPBDNCHHKGCFieldNumber = 10;

	private long jPBDNCHHKGC_;

	public const int AOJCDACKPCPFieldNumber = 11;

	private bool aOJCDACKPCP_;

	public const int MBDGKAEHCFBFieldNumber = 14;

	private bool mBDGKAEHCFB_;

	public const int BIHHIPMLBONFieldNumber = 15;

	private bool bIHHIPMLBON_;

	public const int CCNFDLHKJFMFieldNumber = 1;

	public const int CDNENMBMOKHFieldNumber = 3;

	public const int FFFDHGGPNPMFieldNumber = 6;

	public const int FMJMNFIBCAHFieldNumber = 7;

	public const int NAEJHJIEOBDFieldNumber = 12;

	public const int ADECNJPKJFIFieldNumber = 13;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIPACDEJKJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIPACDEJKJCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAFPECGGICC
	{
		get
		{
			return gAFPECGGICC_;
		}
		set
		{
			gAFPECGGICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMFHLBBOCFK
	{
		get
		{
			return eMFHLBBOCFK_;
		}
		set
		{
			eMFHLBBOCFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long JPBDNCHHKGC
	{
		get
		{
			return jPBDNCHHKGC_;
		}
		set
		{
			jPBDNCHHKGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AOJCDACKPCP
	{
		get
		{
			return aOJCDACKPCP_;
		}
		set
		{
			aOJCDACKPCP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MBDGKAEHCFB
	{
		get
		{
			return mBDGKAEHCFB_;
		}
		set
		{
			mBDGKAEHCFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BIHHIPMLBON
	{
		get
		{
			return bIHHIPMLBON_;
		}
		set
		{
			bIHHIPMLBON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJGHKGMGOAP CCNFDLHKJFM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CCNFDLHKJFM)
			{
				return null;
			}
			return (MJGHKGMGOAP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CCNFDLHKJFM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNBPAHCIMJ CDNENMBMOKH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CDNENMBMOKH)
			{
				return null;
			}
			return (PKNBPAHCIMJ)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CDNENMBMOKH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBLADGCPMM FFFDHGGPNPM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FFFDHGGPNPM)
			{
				return null;
			}
			return (PMBLADGCPMM)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FFFDHGGPNPM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAMCAPPFDBH FMJMNFIBCAH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FMJMNFIBCAH)
			{
				return null;
			}
			return (IAMCAPPFDBH)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FMJMNFIBCAH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDIGEJHHPDL NAEJHJIEOBD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NAEJHJIEOBD)
			{
				return null;
			}
			return (IDIGEJHHPDL)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NAEJHJIEOBD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCJIBPMPIBA ADECNJPKJFI
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.ADECNJPKJFI)
			{
				return null;
			}
			return (BCJIBPMPIBA)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.ADECNJPKJFI : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPACDEJKJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPACDEJKJC(JIPACDEJKJC other)
		: this()
	{
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		gAFPECGGICC_ = other.gAFPECGGICC_;
		eMFHLBBOCFK_ = other.eMFHLBBOCFK_;
		jPBDNCHHKGC_ = other.jPBDNCHHKGC_;
		aOJCDACKPCP_ = other.aOJCDACKPCP_;
		mBDGKAEHCFB_ = other.mBDGKAEHCFB_;
		bIHHIPMLBON_ = other.bIHHIPMLBON_;
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.CCNFDLHKJFM:
			CCNFDLHKJFM = other.CCNFDLHKJFM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.CDNENMBMOKH:
			CDNENMBMOKH = other.CDNENMBMOKH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FFFDHGGPNPM:
			FFFDHGGPNPM = other.FFFDHGGPNPM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FMJMNFIBCAH:
			FMJMNFIBCAH = other.FMJMNFIBCAH.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NAEJHJIEOBD:
			NAEJHJIEOBD = other.NAEJHJIEOBD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.ADECNJPKJFI:
			ADECNJPKJFI = other.ADECNJPKJFI.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPACDEJKJC Clone()
	{
		return new JIPACDEJKJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIPACDEJKJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIPACDEJKJC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
		{
			return false;
		}
		if (GAFPECGGICC != other.GAFPECGGICC)
		{
			return false;
		}
		if (EMFHLBBOCFK != other.EMFHLBBOCFK)
		{
			return false;
		}
		if (JPBDNCHHKGC != other.JPBDNCHHKGC)
		{
			return false;
		}
		if (AOJCDACKPCP != other.AOJCDACKPCP)
		{
			return false;
		}
		if (MBDGKAEHCFB != other.MBDGKAEHCFB)
		{
			return false;
		}
		if (BIHHIPMLBON != other.BIHHIPMLBON)
		{
			return false;
		}
		if (!object.Equals(CCNFDLHKJFM, other.CCNFDLHKJFM))
		{
			return false;
		}
		if (!object.Equals(CDNENMBMOKH, other.CDNENMBMOKH))
		{
			return false;
		}
		if (!object.Equals(FFFDHGGPNPM, other.FFFDHGGPNPM))
		{
			return false;
		}
		if (!object.Equals(FMJMNFIBCAH, other.FMJMNFIBCAH))
		{
			return false;
		}
		if (!object.Equals(NAEJHJIEOBD, other.NAEJHJIEOBD))
		{
			return false;
		}
		if (!object.Equals(ADECNJPKJFI, other.ADECNJPKJFI))
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (PHKAHAHLDAE != 0)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
		}
		if (GAFPECGGICC != 0)
		{
			num ^= GAFPECGGICC.GetHashCode();
		}
		if (EMFHLBBOCFK != 0)
		{
			num ^= EMFHLBBOCFK.GetHashCode();
		}
		if (JPBDNCHHKGC != 0L)
		{
			num ^= JPBDNCHHKGC.GetHashCode();
		}
		if (AOJCDACKPCP)
		{
			num ^= AOJCDACKPCP.GetHashCode();
		}
		if (MBDGKAEHCFB)
		{
			num ^= MBDGKAEHCFB.GetHashCode();
		}
		if (BIHHIPMLBON)
		{
			num ^= BIHHIPMLBON.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CCNFDLHKJFM)
		{
			num ^= CCNFDLHKJFM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CDNENMBMOKH)
		{
			num ^= CDNENMBMOKH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FFFDHGGPNPM)
		{
			num ^= FFFDHGGPNPM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FMJMNFIBCAH)
		{
			num ^= FMJMNFIBCAH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NAEJHJIEOBD)
		{
			num ^= NAEJHJIEOBD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADECNJPKJFI)
		{
			num ^= ADECNJPKJFI.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CCNFDLHKJFM)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CCNFDLHKJFM);
		}
		if (PHKAHAHLDAE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PHKAHAHLDAE);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CDNENMBMOKH)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CDNENMBMOKH);
		}
		if (GAFPECGGICC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GAFPECGGICC);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FFFDHGGPNPM)
		{
			output.WriteRawTag(50);
			output.WriteMessage(FFFDHGGPNPM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FMJMNFIBCAH)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FMJMNFIBCAH);
		}
		if (EMFHLBBOCFK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EMFHLBBOCFK);
		}
		if (JPBDNCHHKGC != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(JPBDNCHHKGC);
		}
		if (AOJCDACKPCP)
		{
			output.WriteRawTag(88);
			output.WriteBool(AOJCDACKPCP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NAEJHJIEOBD)
		{
			output.WriteRawTag(98);
			output.WriteMessage(NAEJHJIEOBD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADECNJPKJFI)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ADECNJPKJFI);
		}
		if (MBDGKAEHCFB)
		{
			output.WriteRawTag(112);
			output.WriteBool(MBDGKAEHCFB);
		}
		if (BIHHIPMLBON)
		{
			output.WriteRawTag(120);
			output.WriteBool(BIHHIPMLBON);
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
		if (PHKAHAHLDAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHKAHAHLDAE);
		}
		if (GAFPECGGICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAFPECGGICC);
		}
		if (EMFHLBBOCFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMFHLBBOCFK);
		}
		if (JPBDNCHHKGC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(JPBDNCHHKGC);
		}
		if (AOJCDACKPCP)
		{
			num += 2;
		}
		if (MBDGKAEHCFB)
		{
			num += 2;
		}
		if (BIHHIPMLBON)
		{
			num += 2;
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CCNFDLHKJFM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CCNFDLHKJFM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CDNENMBMOKH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CDNENMBMOKH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FFFDHGGPNPM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFFDHGGPNPM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FMJMNFIBCAH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMJMNFIBCAH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NAEJHJIEOBD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NAEJHJIEOBD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADECNJPKJFI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ADECNJPKJFI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JIPACDEJKJC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PHKAHAHLDAE != 0)
		{
			PHKAHAHLDAE = other.PHKAHAHLDAE;
		}
		if (other.GAFPECGGICC != 0)
		{
			GAFPECGGICC = other.GAFPECGGICC;
		}
		if (other.EMFHLBBOCFK != 0)
		{
			EMFHLBBOCFK = other.EMFHLBBOCFK;
		}
		if (other.JPBDNCHHKGC != 0L)
		{
			JPBDNCHHKGC = other.JPBDNCHHKGC;
		}
		if (other.AOJCDACKPCP)
		{
			AOJCDACKPCP = other.AOJCDACKPCP;
		}
		if (other.MBDGKAEHCFB)
		{
			MBDGKAEHCFB = other.MBDGKAEHCFB;
		}
		if (other.BIHHIPMLBON)
		{
			BIHHIPMLBON = other.BIHHIPMLBON;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.CCNFDLHKJFM:
			if (CCNFDLHKJFM == null)
			{
				CCNFDLHKJFM = new MJGHKGMGOAP();
			}
			CCNFDLHKJFM.MergeFrom(other.CCNFDLHKJFM);
			break;
		case NLPPPCHGGPFOneofCase.CDNENMBMOKH:
			if (CDNENMBMOKH == null)
			{
				CDNENMBMOKH = new PKNBPAHCIMJ();
			}
			CDNENMBMOKH.MergeFrom(other.CDNENMBMOKH);
			break;
		case NLPPPCHGGPFOneofCase.FFFDHGGPNPM:
			if (FFFDHGGPNPM == null)
			{
				FFFDHGGPNPM = new PMBLADGCPMM();
			}
			FFFDHGGPNPM.MergeFrom(other.FFFDHGGPNPM);
			break;
		case NLPPPCHGGPFOneofCase.FMJMNFIBCAH:
			if (FMJMNFIBCAH == null)
			{
				FMJMNFIBCAH = new IAMCAPPFDBH();
			}
			FMJMNFIBCAH.MergeFrom(other.FMJMNFIBCAH);
			break;
		case NLPPPCHGGPFOneofCase.NAEJHJIEOBD:
			if (NAEJHJIEOBD == null)
			{
				NAEJHJIEOBD = new IDIGEJHHPDL();
			}
			NAEJHJIEOBD.MergeFrom(other.NAEJHJIEOBD);
			break;
		case NLPPPCHGGPFOneofCase.ADECNJPKJFI:
			if (ADECNJPKJFI == null)
			{
				ADECNJPKJFI = new BCJIBPMPIBA();
			}
			ADECNJPKJFI.MergeFrom(other.ADECNJPKJFI);
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
			case 10u:
			{
				MJGHKGMGOAP mJGHKGMGOAP = new MJGHKGMGOAP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CCNFDLHKJFM)
				{
					mJGHKGMGOAP.MergeFrom(CCNFDLHKJFM);
				}
				input.ReadMessage(mJGHKGMGOAP);
				CCNFDLHKJFM = mJGHKGMGOAP;
				break;
			}
			case 16u:
				PHKAHAHLDAE = input.ReadUInt32();
				break;
			case 26u:
			{
				PKNBPAHCIMJ pKNBPAHCIMJ = new PKNBPAHCIMJ();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CDNENMBMOKH)
				{
					pKNBPAHCIMJ.MergeFrom(CDNENMBMOKH);
				}
				input.ReadMessage(pKNBPAHCIMJ);
				CDNENMBMOKH = pKNBPAHCIMJ;
				break;
			}
			case 40u:
				GAFPECGGICC = input.ReadUInt32();
				break;
			case 50u:
			{
				PMBLADGCPMM pMBLADGCPMM = new PMBLADGCPMM();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FFFDHGGPNPM)
				{
					pMBLADGCPMM.MergeFrom(FFFDHGGPNPM);
				}
				input.ReadMessage(pMBLADGCPMM);
				FFFDHGGPNPM = pMBLADGCPMM;
				break;
			}
			case 58u:
			{
				IAMCAPPFDBH iAMCAPPFDBH = new IAMCAPPFDBH();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FMJMNFIBCAH)
				{
					iAMCAPPFDBH.MergeFrom(FMJMNFIBCAH);
				}
				input.ReadMessage(iAMCAPPFDBH);
				FMJMNFIBCAH = iAMCAPPFDBH;
				break;
			}
			case 72u:
				EMFHLBBOCFK = input.ReadUInt32();
				break;
			case 80u:
				JPBDNCHHKGC = input.ReadInt64();
				break;
			case 88u:
				AOJCDACKPCP = input.ReadBool();
				break;
			case 98u:
			{
				IDIGEJHHPDL iDIGEJHHPDL = new IDIGEJHHPDL();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NAEJHJIEOBD)
				{
					iDIGEJHHPDL.MergeFrom(NAEJHJIEOBD);
				}
				input.ReadMessage(iDIGEJHHPDL);
				NAEJHJIEOBD = iDIGEJHHPDL;
				break;
			}
			case 106u:
			{
				BCJIBPMPIBA bCJIBPMPIBA = new BCJIBPMPIBA();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADECNJPKJFI)
				{
					bCJIBPMPIBA.MergeFrom(ADECNJPKJFI);
				}
				input.ReadMessage(bCJIBPMPIBA);
				ADECNJPKJFI = bCJIBPMPIBA;
				break;
			}
			case 112u:
				MBDGKAEHCFB = input.ReadBool();
				break;
			case 120u:
				BIHHIPMLBON = input.ReadBool();
				break;
			}
		}
	}
}
