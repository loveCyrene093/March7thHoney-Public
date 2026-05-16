using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCIEAIDBBCI : IMessage<DCIEAIDBBCI>, IMessage, IEquatable<DCIEAIDBBCI>, IDeepCloneable<DCIEAIDBBCI>, IBufferMessage
{
	public enum KCOCCGEOECOOneofCase
	{
		None = 0,
		PPGIMDLHKGA = 17,
		JFGJAFIPCDI = 93,
		OMLCPNMMCIM = 112,
		DPHCJKEFBLN = 593,
		ODGNAJKBGDN = 594,
		OMPGFADBGKH = 672,
		FAPBPGMPNIN = 962,
		LJOHDODEEIL = 1390,
		OAGMAELMDAE = 1425,
		GFNPAFHMOBM = 1726
	}

	private static readonly MessageParser<DCIEAIDBBCI> _parser = new MessageParser<DCIEAIDBBCI>(() => new DCIEAIDBBCI());

	private UnknownFieldSet _unknownFields;

	public const int SrcFieldNumber = 3;

	private APAEPNCJDIE src_;

	public const int PPGIMDLHKGAFieldNumber = 17;

	public const int JFGJAFIPCDIFieldNumber = 93;

	public const int OMLCPNMMCIMFieldNumber = 112;

	public const int DPHCJKEFBLNFieldNumber = 593;

	public const int ODGNAJKBGDNFieldNumber = 594;

	public const int OMPGFADBGKHFieldNumber = 672;

	public const int FAPBPGMPNINFieldNumber = 962;

	public const int LJOHDODEEILFieldNumber = 1390;

	public const int OAGMAELMDAEFieldNumber = 1425;

	public const int GFNPAFHMOBMFieldNumber = 1726;

	private object kCOCCGEOECO_;

	private KCOCCGEOECOOneofCase kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCIEAIDBBCI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCIEAIDBBCIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APAEPNCJDIE Src
	{
		get
		{
			return src_;
		}
		set
		{
			src_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMPIDGCJHLI PPGIMDLHKGA
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.PPGIMDLHKGA)
			{
				return null;
			}
			return (CMPIDGCJHLI)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.PPGIMDLHKGA : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLGALLEAEIC JFGJAFIPCDI
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.JFGJAFIPCDI)
			{
				return null;
			}
			return (MLGALLEAEIC)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.JFGJAFIPCDI : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPCNGNIFDK OMLCPNMMCIM
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.OMLCPNMMCIM)
			{
				return null;
			}
			return (MKPCNGNIFDK)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.OMLCPNMMCIM : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOIPOCNEPLN DPHCJKEFBLN
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.DPHCJKEFBLN)
			{
				return null;
			}
			return (FOIPOCNEPLN)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.DPHCJKEFBLN : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APPEFBLLPGK ODGNAJKBGDN
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.ODGNAJKBGDN)
			{
				return null;
			}
			return (APPEFBLLPGK)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.ODGNAJKBGDN : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLGMCDHAFM OMPGFADBGKH
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.OMPGFADBGKH)
			{
				return null;
			}
			return (GFLGMCDHAFM)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.OMPGFADBGKH : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NACCDDFCIKA FAPBPGMPNIN
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.FAPBPGMPNIN)
			{
				return null;
			}
			return (NACCDDFCIKA)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.FAPBPGMPNIN : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AILGGIDDLCO LJOHDODEEIL
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.LJOHDODEEIL)
			{
				return null;
			}
			return (AILGGIDDLCO)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.LJOHDODEEIL : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBNIJFEMBPJ OAGMAELMDAE
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.OAGMAELMDAE)
			{
				return null;
			}
			return (KBNIJFEMBPJ)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.OAGMAELMDAE : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHFDBCJDHEJ GFNPAFHMOBM
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GFNPAFHMOBM)
			{
				return null;
			}
			return (IHFDBCJDHEJ)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GFNPAFHMOBM : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCOCCGEOECOOneofCase KCOCCGEOECOCase => kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCIEAIDBBCI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCIEAIDBBCI(DCIEAIDBBCI other)
		: this()
	{
		src_ = other.src_;
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.PPGIMDLHKGA:
			PPGIMDLHKGA = other.PPGIMDLHKGA.Clone();
			break;
		case KCOCCGEOECOOneofCase.JFGJAFIPCDI:
			JFGJAFIPCDI = other.JFGJAFIPCDI.Clone();
			break;
		case KCOCCGEOECOOneofCase.OMLCPNMMCIM:
			OMLCPNMMCIM = other.OMLCPNMMCIM.Clone();
			break;
		case KCOCCGEOECOOneofCase.DPHCJKEFBLN:
			DPHCJKEFBLN = other.DPHCJKEFBLN.Clone();
			break;
		case KCOCCGEOECOOneofCase.ODGNAJKBGDN:
			ODGNAJKBGDN = other.ODGNAJKBGDN.Clone();
			break;
		case KCOCCGEOECOOneofCase.OMPGFADBGKH:
			OMPGFADBGKH = other.OMPGFADBGKH.Clone();
			break;
		case KCOCCGEOECOOneofCase.FAPBPGMPNIN:
			FAPBPGMPNIN = other.FAPBPGMPNIN.Clone();
			break;
		case KCOCCGEOECOOneofCase.LJOHDODEEIL:
			LJOHDODEEIL = other.LJOHDODEEIL.Clone();
			break;
		case KCOCCGEOECOOneofCase.OAGMAELMDAE:
			OAGMAELMDAE = other.OAGMAELMDAE.Clone();
			break;
		case KCOCCGEOECOOneofCase.GFNPAFHMOBM:
			GFNPAFHMOBM = other.GFNPAFHMOBM.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCIEAIDBBCI Clone()
	{
		return new DCIEAIDBBCI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKCOCCGEOECO()
	{
		kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.None;
		kCOCCGEOECO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCIEAIDBBCI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCIEAIDBBCI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Src != other.Src)
		{
			return false;
		}
		if (!object.Equals(PPGIMDLHKGA, other.PPGIMDLHKGA))
		{
			return false;
		}
		if (!object.Equals(JFGJAFIPCDI, other.JFGJAFIPCDI))
		{
			return false;
		}
		if (!object.Equals(OMLCPNMMCIM, other.OMLCPNMMCIM))
		{
			return false;
		}
		if (!object.Equals(DPHCJKEFBLN, other.DPHCJKEFBLN))
		{
			return false;
		}
		if (!object.Equals(ODGNAJKBGDN, other.ODGNAJKBGDN))
		{
			return false;
		}
		if (!object.Equals(OMPGFADBGKH, other.OMPGFADBGKH))
		{
			return false;
		}
		if (!object.Equals(FAPBPGMPNIN, other.FAPBPGMPNIN))
		{
			return false;
		}
		if (!object.Equals(LJOHDODEEIL, other.LJOHDODEEIL))
		{
			return false;
		}
		if (!object.Equals(OAGMAELMDAE, other.OAGMAELMDAE))
		{
			return false;
		}
		if (!object.Equals(GFNPAFHMOBM, other.GFNPAFHMOBM))
		{
			return false;
		}
		if (KCOCCGEOECOCase != other.KCOCCGEOECOCase)
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
		if (Src != APAEPNCJDIE.Kpmlnpjfhnl)
		{
			num ^= Src.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PPGIMDLHKGA)
		{
			num ^= PPGIMDLHKGA.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JFGJAFIPCDI)
		{
			num ^= JFGJAFIPCDI.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMLCPNMMCIM)
		{
			num ^= OMLCPNMMCIM.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.DPHCJKEFBLN)
		{
			num ^= DPHCJKEFBLN.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ODGNAJKBGDN)
		{
			num ^= ODGNAJKBGDN.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMPGFADBGKH)
		{
			num ^= OMPGFADBGKH.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FAPBPGMPNIN)
		{
			num ^= FAPBPGMPNIN.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LJOHDODEEIL)
		{
			num ^= LJOHDODEEIL.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OAGMAELMDAE)
		{
			num ^= OAGMAELMDAE.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GFNPAFHMOBM)
		{
			num ^= GFNPAFHMOBM.GetHashCode();
		}
		num ^= (int)kCOCCGEOECOCase_;
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
		if (Src != APAEPNCJDIE.Kpmlnpjfhnl)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Src);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PPGIMDLHKGA)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(PPGIMDLHKGA);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JFGJAFIPCDI)
		{
			output.WriteRawTag(234, 5);
			output.WriteMessage(JFGJAFIPCDI);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMLCPNMMCIM)
		{
			output.WriteRawTag(130, 7);
			output.WriteMessage(OMLCPNMMCIM);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.DPHCJKEFBLN)
		{
			output.WriteRawTag(138, 37);
			output.WriteMessage(DPHCJKEFBLN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ODGNAJKBGDN)
		{
			output.WriteRawTag(146, 37);
			output.WriteMessage(ODGNAJKBGDN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMPGFADBGKH)
		{
			output.WriteRawTag(130, 42);
			output.WriteMessage(OMPGFADBGKH);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FAPBPGMPNIN)
		{
			output.WriteRawTag(146, 60);
			output.WriteMessage(FAPBPGMPNIN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LJOHDODEEIL)
		{
			output.WriteRawTag(242, 86);
			output.WriteMessage(LJOHDODEEIL);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OAGMAELMDAE)
		{
			output.WriteRawTag(138, 89);
			output.WriteMessage(OAGMAELMDAE);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GFNPAFHMOBM)
		{
			output.WriteRawTag(242, 107);
			output.WriteMessage(GFNPAFHMOBM);
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
		if (Src != APAEPNCJDIE.Kpmlnpjfhnl)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Src);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PPGIMDLHKGA)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PPGIMDLHKGA);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JFGJAFIPCDI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JFGJAFIPCDI);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMLCPNMMCIM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OMLCPNMMCIM);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.DPHCJKEFBLN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DPHCJKEFBLN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ODGNAJKBGDN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ODGNAJKBGDN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMPGFADBGKH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OMPGFADBGKH);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FAPBPGMPNIN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FAPBPGMPNIN);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LJOHDODEEIL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LJOHDODEEIL);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OAGMAELMDAE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OAGMAELMDAE);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GFNPAFHMOBM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GFNPAFHMOBM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DCIEAIDBBCI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Src != APAEPNCJDIE.Kpmlnpjfhnl)
		{
			Src = other.Src;
		}
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.PPGIMDLHKGA:
			if (PPGIMDLHKGA == null)
			{
				PPGIMDLHKGA = new CMPIDGCJHLI();
			}
			PPGIMDLHKGA.MergeFrom(other.PPGIMDLHKGA);
			break;
		case KCOCCGEOECOOneofCase.JFGJAFIPCDI:
			if (JFGJAFIPCDI == null)
			{
				JFGJAFIPCDI = new MLGALLEAEIC();
			}
			JFGJAFIPCDI.MergeFrom(other.JFGJAFIPCDI);
			break;
		case KCOCCGEOECOOneofCase.OMLCPNMMCIM:
			if (OMLCPNMMCIM == null)
			{
				OMLCPNMMCIM = new MKPCNGNIFDK();
			}
			OMLCPNMMCIM.MergeFrom(other.OMLCPNMMCIM);
			break;
		case KCOCCGEOECOOneofCase.DPHCJKEFBLN:
			if (DPHCJKEFBLN == null)
			{
				DPHCJKEFBLN = new FOIPOCNEPLN();
			}
			DPHCJKEFBLN.MergeFrom(other.DPHCJKEFBLN);
			break;
		case KCOCCGEOECOOneofCase.ODGNAJKBGDN:
			if (ODGNAJKBGDN == null)
			{
				ODGNAJKBGDN = new APPEFBLLPGK();
			}
			ODGNAJKBGDN.MergeFrom(other.ODGNAJKBGDN);
			break;
		case KCOCCGEOECOOneofCase.OMPGFADBGKH:
			if (OMPGFADBGKH == null)
			{
				OMPGFADBGKH = new GFLGMCDHAFM();
			}
			OMPGFADBGKH.MergeFrom(other.OMPGFADBGKH);
			break;
		case KCOCCGEOECOOneofCase.FAPBPGMPNIN:
			if (FAPBPGMPNIN == null)
			{
				FAPBPGMPNIN = new NACCDDFCIKA();
			}
			FAPBPGMPNIN.MergeFrom(other.FAPBPGMPNIN);
			break;
		case KCOCCGEOECOOneofCase.LJOHDODEEIL:
			if (LJOHDODEEIL == null)
			{
				LJOHDODEEIL = new AILGGIDDLCO();
			}
			LJOHDODEEIL.MergeFrom(other.LJOHDODEEIL);
			break;
		case KCOCCGEOECOOneofCase.OAGMAELMDAE:
			if (OAGMAELMDAE == null)
			{
				OAGMAELMDAE = new KBNIJFEMBPJ();
			}
			OAGMAELMDAE.MergeFrom(other.OAGMAELMDAE);
			break;
		case KCOCCGEOECOOneofCase.GFNPAFHMOBM:
			if (GFNPAFHMOBM == null)
			{
				GFNPAFHMOBM = new IHFDBCJDHEJ();
			}
			GFNPAFHMOBM.MergeFrom(other.GFNPAFHMOBM);
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
			case 24u:
				Src = (APAEPNCJDIE)input.ReadEnum();
				break;
			case 138u:
			{
				CMPIDGCJHLI cMPIDGCJHLI = new CMPIDGCJHLI();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PPGIMDLHKGA)
				{
					cMPIDGCJHLI.MergeFrom(PPGIMDLHKGA);
				}
				input.ReadMessage(cMPIDGCJHLI);
				PPGIMDLHKGA = cMPIDGCJHLI;
				break;
			}
			case 746u:
			{
				MLGALLEAEIC mLGALLEAEIC = new MLGALLEAEIC();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JFGJAFIPCDI)
				{
					mLGALLEAEIC.MergeFrom(JFGJAFIPCDI);
				}
				input.ReadMessage(mLGALLEAEIC);
				JFGJAFIPCDI = mLGALLEAEIC;
				break;
			}
			case 898u:
			{
				MKPCNGNIFDK mKPCNGNIFDK = new MKPCNGNIFDK();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMLCPNMMCIM)
				{
					mKPCNGNIFDK.MergeFrom(OMLCPNMMCIM);
				}
				input.ReadMessage(mKPCNGNIFDK);
				OMLCPNMMCIM = mKPCNGNIFDK;
				break;
			}
			case 4746u:
			{
				FOIPOCNEPLN fOIPOCNEPLN = new FOIPOCNEPLN();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.DPHCJKEFBLN)
				{
					fOIPOCNEPLN.MergeFrom(DPHCJKEFBLN);
				}
				input.ReadMessage(fOIPOCNEPLN);
				DPHCJKEFBLN = fOIPOCNEPLN;
				break;
			}
			case 4754u:
			{
				APPEFBLLPGK aPPEFBLLPGK = new APPEFBLLPGK();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.ODGNAJKBGDN)
				{
					aPPEFBLLPGK.MergeFrom(ODGNAJKBGDN);
				}
				input.ReadMessage(aPPEFBLLPGK);
				ODGNAJKBGDN = aPPEFBLLPGK;
				break;
			}
			case 5378u:
			{
				GFLGMCDHAFM gFLGMCDHAFM = new GFLGMCDHAFM();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OMPGFADBGKH)
				{
					gFLGMCDHAFM.MergeFrom(OMPGFADBGKH);
				}
				input.ReadMessage(gFLGMCDHAFM);
				OMPGFADBGKH = gFLGMCDHAFM;
				break;
			}
			case 7698u:
			{
				NACCDDFCIKA nACCDDFCIKA = new NACCDDFCIKA();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FAPBPGMPNIN)
				{
					nACCDDFCIKA.MergeFrom(FAPBPGMPNIN);
				}
				input.ReadMessage(nACCDDFCIKA);
				FAPBPGMPNIN = nACCDDFCIKA;
				break;
			}
			case 11122u:
			{
				AILGGIDDLCO aILGGIDDLCO = new AILGGIDDLCO();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.LJOHDODEEIL)
				{
					aILGGIDDLCO.MergeFrom(LJOHDODEEIL);
				}
				input.ReadMessage(aILGGIDDLCO);
				LJOHDODEEIL = aILGGIDDLCO;
				break;
			}
			case 11402u:
			{
				KBNIJFEMBPJ kBNIJFEMBPJ = new KBNIJFEMBPJ();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.OAGMAELMDAE)
				{
					kBNIJFEMBPJ.MergeFrom(OAGMAELMDAE);
				}
				input.ReadMessage(kBNIJFEMBPJ);
				OAGMAELMDAE = kBNIJFEMBPJ;
				break;
			}
			case 13810u:
			{
				IHFDBCJDHEJ iHFDBCJDHEJ = new IHFDBCJDHEJ();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GFNPAFHMOBM)
				{
					iHFDBCJDHEJ.MergeFrom(GFNPAFHMOBM);
				}
				input.ReadMessage(iHFDBCJDHEJ);
				GFNPAFHMOBM = iHFDBCJDHEJ;
				break;
			}
			}
		}
	}
}
