using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AHMMECMMPBL : IMessage<AHMMECMMPBL>, IMessage, IEquatable<AHMMECMMPBL>, IDeepCloneable<AHMMECMMPBL>, IBufferMessage
{
	public enum OGJDIOHNFDEOneofCase
	{
		None = 0,
		OECLGKBMBAM = 205,
		MALIIHMMDFP = 331,
		PBPACLDNJJL = 447,
		FEIIHHBDHAC = 458,
		KGNDHGKKOMM = 536,
		ACHNDMMADHM = 785,
		LJMLIKAIBDC = 788,
		PJFINGIOFHJ = 1039,
		HMNHNAJJCKE = 1094,
		JNMGNEAKHCG = 1220,
		NPNBNNNINOH = 1792,
		DNDGJJIINDN = 1794,
		KGKOHNAACEN = 1818,
		LFLNIFFANDM = 1873
	}

	private static readonly MessageParser<AHMMECMMPBL> _parser = new MessageParser<AHMMECMMPBL>(() => new AHMMECMMPBL());

	private UnknownFieldSet _unknownFields;

	public const int KHAJDKDHPGDFieldNumber = 1;

	private ulong kHAJDKDHPGD_;

	public const int PFCMBDCFFMGFieldNumber = 11;

	private uint pFCMBDCFFMG_;

	public const int OECLGKBMBAMFieldNumber = 205;

	public const int MALIIHMMDFPFieldNumber = 331;

	public const int PBPACLDNJJLFieldNumber = 447;

	public const int FEIIHHBDHACFieldNumber = 458;

	public const int KGNDHGKKOMMFieldNumber = 536;

	public const int ACHNDMMADHMFieldNumber = 785;

	public const int LJMLIKAIBDCFieldNumber = 788;

	public const int PJFINGIOFHJFieldNumber = 1039;

	public const int HMNHNAJJCKEFieldNumber = 1094;

	public const int JNMGNEAKHCGFieldNumber = 1220;

	public const int NPNBNNNINOHFieldNumber = 1792;

	public const int DNDGJJIINDNFieldNumber = 1794;

	public const int KGKOHNAACENFieldNumber = 1818;

	public const int LFLNIFFANDMFieldNumber = 1873;

	private object oGJDIOHNFDE_;

	private OGJDIOHNFDEOneofCase oGJDIOHNFDECase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AHMMECMMPBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AHMMECMMPBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KHAJDKDHPGD
	{
		get
		{
			return kHAJDKDHPGD_;
		}
		set
		{
			kHAJDKDHPGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PFCMBDCFFMG
	{
		get
		{
			return pFCMBDCFFMG_;
		}
		set
		{
			pFCMBDCFFMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGLMKEJBAB OECLGKBMBAM
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.OECLGKBMBAM)
			{
				return null;
			}
			return (KNGLMKEJBAB)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.OECLGKBMBAM : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBIPKDKDNP MALIIHMMDFP
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.MALIIHMMDFP)
			{
				return null;
			}
			return (LKBIPKDKDNP)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.MALIIHMMDFP : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBCDGFJADM PBPACLDNJJL
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.PBPACLDNJJL)
			{
				return null;
			}
			return (DKBCDGFJADM)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.PBPACLDNJJL : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODDGGMAABBD FEIIHHBDHAC
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.FEIIHHBDHAC)
			{
				return null;
			}
			return (ODDGGMAABBD)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.FEIIHHBDHAC : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APEJMBBBLGF KGNDHGKKOMM
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.KGNDHGKKOMM)
			{
				return null;
			}
			return (APEJMBBBLGF)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.KGNDHGKKOMM : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCLIFPOFFLI ACHNDMMADHM
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.ACHNDMMADHM)
			{
				return null;
			}
			return (DCLIFPOFFLI)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.ACHNDMMADHM : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCDCGEIELJI LJMLIKAIBDC
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.LJMLIKAIBDC)
			{
				return null;
			}
			return (DCDCGEIELJI)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.LJMLIKAIBDC : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGIDNOCFEOH PJFINGIOFHJ
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.PJFINGIOFHJ)
			{
				return null;
			}
			return (CGIDNOCFEOH)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.PJFINGIOFHJ : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKHPOBDGK HMNHNAJJCKE
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.HMNHNAJJCKE)
			{
				return null;
			}
			return (AOIKHPOBDGK)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.HMNHNAJJCKE : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMCJBDELOKJ JNMGNEAKHCG
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.JNMGNEAKHCG)
			{
				return null;
			}
			return (JMCJBDELOKJ)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.JNMGNEAKHCG : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLCEEEJIGO NPNBNNNINOH
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.NPNBNNNINOH)
			{
				return null;
			}
			return (HKLCEEEJIGO)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.NPNBNNNINOH : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPLDPPPMMGH DNDGJJIINDN
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.DNDGJJIINDN)
			{
				return null;
			}
			return (DPLDPPPMMGH)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.DNDGJJIINDN : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJHFGPANMFH KGKOHNAACEN
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.KGKOHNAACEN)
			{
				return null;
			}
			return (KJHFGPANMFH)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.KGKOHNAACEN : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLPJODDJCCD LFLNIFFANDM
	{
		get
		{
			if (oGJDIOHNFDECase_ != OGJDIOHNFDEOneofCase.LFLNIFFANDM)
			{
				return null;
			}
			return (GLPJODDJCCD)oGJDIOHNFDE_;
		}
		set
		{
			oGJDIOHNFDE_ = value;
			oGJDIOHNFDECase_ = ((value != null) ? OGJDIOHNFDEOneofCase.LFLNIFFANDM : OGJDIOHNFDEOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGJDIOHNFDEOneofCase OGJDIOHNFDECase => oGJDIOHNFDECase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHMMECMMPBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHMMECMMPBL(AHMMECMMPBL other)
		: this()
	{
		kHAJDKDHPGD_ = other.kHAJDKDHPGD_;
		pFCMBDCFFMG_ = other.pFCMBDCFFMG_;
		switch (other.OGJDIOHNFDECase)
		{
		case OGJDIOHNFDEOneofCase.OECLGKBMBAM:
			OECLGKBMBAM = other.OECLGKBMBAM.Clone();
			break;
		case OGJDIOHNFDEOneofCase.MALIIHMMDFP:
			MALIIHMMDFP = other.MALIIHMMDFP.Clone();
			break;
		case OGJDIOHNFDEOneofCase.PBPACLDNJJL:
			PBPACLDNJJL = other.PBPACLDNJJL.Clone();
			break;
		case OGJDIOHNFDEOneofCase.FEIIHHBDHAC:
			FEIIHHBDHAC = other.FEIIHHBDHAC.Clone();
			break;
		case OGJDIOHNFDEOneofCase.KGNDHGKKOMM:
			KGNDHGKKOMM = other.KGNDHGKKOMM.Clone();
			break;
		case OGJDIOHNFDEOneofCase.ACHNDMMADHM:
			ACHNDMMADHM = other.ACHNDMMADHM.Clone();
			break;
		case OGJDIOHNFDEOneofCase.LJMLIKAIBDC:
			LJMLIKAIBDC = other.LJMLIKAIBDC.Clone();
			break;
		case OGJDIOHNFDEOneofCase.PJFINGIOFHJ:
			PJFINGIOFHJ = other.PJFINGIOFHJ.Clone();
			break;
		case OGJDIOHNFDEOneofCase.HMNHNAJJCKE:
			HMNHNAJJCKE = other.HMNHNAJJCKE.Clone();
			break;
		case OGJDIOHNFDEOneofCase.JNMGNEAKHCG:
			JNMGNEAKHCG = other.JNMGNEAKHCG.Clone();
			break;
		case OGJDIOHNFDEOneofCase.NPNBNNNINOH:
			NPNBNNNINOH = other.NPNBNNNINOH.Clone();
			break;
		case OGJDIOHNFDEOneofCase.DNDGJJIINDN:
			DNDGJJIINDN = other.DNDGJJIINDN.Clone();
			break;
		case OGJDIOHNFDEOneofCase.KGKOHNAACEN:
			KGKOHNAACEN = other.KGKOHNAACEN.Clone();
			break;
		case OGJDIOHNFDEOneofCase.LFLNIFFANDM:
			LFLNIFFANDM = other.LFLNIFFANDM.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHMMECMMPBL Clone()
	{
		return new AHMMECMMPBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOGJDIOHNFDE()
	{
		oGJDIOHNFDECase_ = OGJDIOHNFDEOneofCase.None;
		oGJDIOHNFDE_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AHMMECMMPBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AHMMECMMPBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHAJDKDHPGD != other.KHAJDKDHPGD)
		{
			return false;
		}
		if (PFCMBDCFFMG != other.PFCMBDCFFMG)
		{
			return false;
		}
		if (!object.Equals(OECLGKBMBAM, other.OECLGKBMBAM))
		{
			return false;
		}
		if (!object.Equals(MALIIHMMDFP, other.MALIIHMMDFP))
		{
			return false;
		}
		if (!object.Equals(PBPACLDNJJL, other.PBPACLDNJJL))
		{
			return false;
		}
		if (!object.Equals(FEIIHHBDHAC, other.FEIIHHBDHAC))
		{
			return false;
		}
		if (!object.Equals(KGNDHGKKOMM, other.KGNDHGKKOMM))
		{
			return false;
		}
		if (!object.Equals(ACHNDMMADHM, other.ACHNDMMADHM))
		{
			return false;
		}
		if (!object.Equals(LJMLIKAIBDC, other.LJMLIKAIBDC))
		{
			return false;
		}
		if (!object.Equals(PJFINGIOFHJ, other.PJFINGIOFHJ))
		{
			return false;
		}
		if (!object.Equals(HMNHNAJJCKE, other.HMNHNAJJCKE))
		{
			return false;
		}
		if (!object.Equals(JNMGNEAKHCG, other.JNMGNEAKHCG))
		{
			return false;
		}
		if (!object.Equals(NPNBNNNINOH, other.NPNBNNNINOH))
		{
			return false;
		}
		if (!object.Equals(DNDGJJIINDN, other.DNDGJJIINDN))
		{
			return false;
		}
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
		{
			return false;
		}
		if (!object.Equals(LFLNIFFANDM, other.LFLNIFFANDM))
		{
			return false;
		}
		if (OGJDIOHNFDECase != other.OGJDIOHNFDECase)
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
		if (KHAJDKDHPGD != 0L)
		{
			num ^= KHAJDKDHPGD.GetHashCode();
		}
		if (PFCMBDCFFMG != 0)
		{
			num ^= PFCMBDCFFMG.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.OECLGKBMBAM)
		{
			num ^= OECLGKBMBAM.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.MALIIHMMDFP)
		{
			num ^= MALIIHMMDFP.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PBPACLDNJJL)
		{
			num ^= PBPACLDNJJL.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FEIIHHBDHAC)
		{
			num ^= FEIIHHBDHAC.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGNDHGKKOMM)
		{
			num ^= KGNDHGKKOMM.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.ACHNDMMADHM)
		{
			num ^= ACHNDMMADHM.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LJMLIKAIBDC)
		{
			num ^= LJMLIKAIBDC.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PJFINGIOFHJ)
		{
			num ^= PJFINGIOFHJ.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.HMNHNAJJCKE)
		{
			num ^= HMNHNAJJCKE.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.JNMGNEAKHCG)
		{
			num ^= JNMGNEAKHCG.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.NPNBNNNINOH)
		{
			num ^= NPNBNNNINOH.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.DNDGJJIINDN)
		{
			num ^= DNDGJJIINDN.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
		{
			num ^= KGKOHNAACEN.GetHashCode();
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LFLNIFFANDM)
		{
			num ^= LFLNIFFANDM.GetHashCode();
		}
		num ^= (int)oGJDIOHNFDECase_;
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
		if (KHAJDKDHPGD != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(KHAJDKDHPGD);
		}
		if (PFCMBDCFFMG != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PFCMBDCFFMG);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.OECLGKBMBAM)
		{
			output.WriteRawTag(234, 12);
			output.WriteMessage(OECLGKBMBAM);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.MALIIHMMDFP)
		{
			output.WriteRawTag(218, 20);
			output.WriteMessage(MALIIHMMDFP);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PBPACLDNJJL)
		{
			output.WriteRawTag(250, 27);
			output.WriteMessage(PBPACLDNJJL);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FEIIHHBDHAC)
		{
			output.WriteRawTag(210, 28);
			output.WriteMessage(FEIIHHBDHAC);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGNDHGKKOMM)
		{
			output.WriteRawTag(194, 33);
			output.WriteMessage(KGNDHGKKOMM);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.ACHNDMMADHM)
		{
			output.WriteRawTag(138, 49);
			output.WriteMessage(ACHNDMMADHM);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LJMLIKAIBDC)
		{
			output.WriteRawTag(162, 49);
			output.WriteMessage(LJMLIKAIBDC);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PJFINGIOFHJ)
		{
			output.WriteRawTag(250, 64);
			output.WriteMessage(PJFINGIOFHJ);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.HMNHNAJJCKE)
		{
			output.WriteRawTag(178, 68);
			output.WriteMessage(HMNHNAJJCKE);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.JNMGNEAKHCG)
		{
			output.WriteRawTag(162, 76);
			output.WriteMessage(JNMGNEAKHCG);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.NPNBNNNINOH)
		{
			output.WriteRawTag(130, 112);
			output.WriteMessage(NPNBNNNINOH);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.DNDGJJIINDN)
		{
			output.WriteRawTag(146, 112);
			output.WriteMessage(DNDGJJIINDN);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
		{
			output.WriteRawTag(210, 113);
			output.WriteMessage(KGKOHNAACEN);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LFLNIFFANDM)
		{
			output.WriteRawTag(138, 117);
			output.WriteMessage(LFLNIFFANDM);
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
		if (KHAJDKDHPGD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(KHAJDKDHPGD);
		}
		if (PFCMBDCFFMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PFCMBDCFFMG);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.OECLGKBMBAM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OECLGKBMBAM);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.MALIIHMMDFP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MALIIHMMDFP);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PBPACLDNJJL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PBPACLDNJJL);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FEIIHHBDHAC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FEIIHHBDHAC);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGNDHGKKOMM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KGNDHGKKOMM);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.ACHNDMMADHM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ACHNDMMADHM);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LJMLIKAIBDC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LJMLIKAIBDC);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PJFINGIOFHJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PJFINGIOFHJ);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.HMNHNAJJCKE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HMNHNAJJCKE);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.JNMGNEAKHCG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JNMGNEAKHCG);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.NPNBNNNINOH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NPNBNNNINOH);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.DNDGJJIINDN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DNDGJJIINDN);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LFLNIFFANDM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LFLNIFFANDM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AHMMECMMPBL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KHAJDKDHPGD != 0L)
		{
			KHAJDKDHPGD = other.KHAJDKDHPGD;
		}
		if (other.PFCMBDCFFMG != 0)
		{
			PFCMBDCFFMG = other.PFCMBDCFFMG;
		}
		switch (other.OGJDIOHNFDECase)
		{
		case OGJDIOHNFDEOneofCase.OECLGKBMBAM:
			if (OECLGKBMBAM == null)
			{
				OECLGKBMBAM = new KNGLMKEJBAB();
			}
			OECLGKBMBAM.MergeFrom(other.OECLGKBMBAM);
			break;
		case OGJDIOHNFDEOneofCase.MALIIHMMDFP:
			if (MALIIHMMDFP == null)
			{
				MALIIHMMDFP = new LKBIPKDKDNP();
			}
			MALIIHMMDFP.MergeFrom(other.MALIIHMMDFP);
			break;
		case OGJDIOHNFDEOneofCase.PBPACLDNJJL:
			if (PBPACLDNJJL == null)
			{
				PBPACLDNJJL = new DKBCDGFJADM();
			}
			PBPACLDNJJL.MergeFrom(other.PBPACLDNJJL);
			break;
		case OGJDIOHNFDEOneofCase.FEIIHHBDHAC:
			if (FEIIHHBDHAC == null)
			{
				FEIIHHBDHAC = new ODDGGMAABBD();
			}
			FEIIHHBDHAC.MergeFrom(other.FEIIHHBDHAC);
			break;
		case OGJDIOHNFDEOneofCase.KGNDHGKKOMM:
			if (KGNDHGKKOMM == null)
			{
				KGNDHGKKOMM = new APEJMBBBLGF();
			}
			KGNDHGKKOMM.MergeFrom(other.KGNDHGKKOMM);
			break;
		case OGJDIOHNFDEOneofCase.ACHNDMMADHM:
			if (ACHNDMMADHM == null)
			{
				ACHNDMMADHM = new DCLIFPOFFLI();
			}
			ACHNDMMADHM.MergeFrom(other.ACHNDMMADHM);
			break;
		case OGJDIOHNFDEOneofCase.LJMLIKAIBDC:
			if (LJMLIKAIBDC == null)
			{
				LJMLIKAIBDC = new DCDCGEIELJI();
			}
			LJMLIKAIBDC.MergeFrom(other.LJMLIKAIBDC);
			break;
		case OGJDIOHNFDEOneofCase.PJFINGIOFHJ:
			if (PJFINGIOFHJ == null)
			{
				PJFINGIOFHJ = new CGIDNOCFEOH();
			}
			PJFINGIOFHJ.MergeFrom(other.PJFINGIOFHJ);
			break;
		case OGJDIOHNFDEOneofCase.HMNHNAJJCKE:
			if (HMNHNAJJCKE == null)
			{
				HMNHNAJJCKE = new AOIKHPOBDGK();
			}
			HMNHNAJJCKE.MergeFrom(other.HMNHNAJJCKE);
			break;
		case OGJDIOHNFDEOneofCase.JNMGNEAKHCG:
			if (JNMGNEAKHCG == null)
			{
				JNMGNEAKHCG = new JMCJBDELOKJ();
			}
			JNMGNEAKHCG.MergeFrom(other.JNMGNEAKHCG);
			break;
		case OGJDIOHNFDEOneofCase.NPNBNNNINOH:
			if (NPNBNNNINOH == null)
			{
				NPNBNNNINOH = new HKLCEEEJIGO();
			}
			NPNBNNNINOH.MergeFrom(other.NPNBNNNINOH);
			break;
		case OGJDIOHNFDEOneofCase.DNDGJJIINDN:
			if (DNDGJJIINDN == null)
			{
				DNDGJJIINDN = new DPLDPPPMMGH();
			}
			DNDGJJIINDN.MergeFrom(other.DNDGJJIINDN);
			break;
		case OGJDIOHNFDEOneofCase.KGKOHNAACEN:
			if (KGKOHNAACEN == null)
			{
				KGKOHNAACEN = new KJHFGPANMFH();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
			break;
		case OGJDIOHNFDEOneofCase.LFLNIFFANDM:
			if (LFLNIFFANDM == null)
			{
				LFLNIFFANDM = new GLPJODDJCCD();
			}
			LFLNIFFANDM.MergeFrom(other.LFLNIFFANDM);
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
			case 8u:
				KHAJDKDHPGD = input.ReadUInt64();
				break;
			case 88u:
				PFCMBDCFFMG = input.ReadUInt32();
				break;
			case 1642u:
			{
				KNGLMKEJBAB kNGLMKEJBAB = new KNGLMKEJBAB();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.OECLGKBMBAM)
				{
					kNGLMKEJBAB.MergeFrom(OECLGKBMBAM);
				}
				input.ReadMessage(kNGLMKEJBAB);
				OECLGKBMBAM = kNGLMKEJBAB;
				break;
			}
			case 2650u:
			{
				LKBIPKDKDNP lKBIPKDKDNP = new LKBIPKDKDNP();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.MALIIHMMDFP)
				{
					lKBIPKDKDNP.MergeFrom(MALIIHMMDFP);
				}
				input.ReadMessage(lKBIPKDKDNP);
				MALIIHMMDFP = lKBIPKDKDNP;
				break;
			}
			case 3578u:
			{
				DKBCDGFJADM dKBCDGFJADM = new DKBCDGFJADM();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PBPACLDNJJL)
				{
					dKBCDGFJADM.MergeFrom(PBPACLDNJJL);
				}
				input.ReadMessage(dKBCDGFJADM);
				PBPACLDNJJL = dKBCDGFJADM;
				break;
			}
			case 3666u:
			{
				ODDGGMAABBD oDDGGMAABBD = new ODDGGMAABBD();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.FEIIHHBDHAC)
				{
					oDDGGMAABBD.MergeFrom(FEIIHHBDHAC);
				}
				input.ReadMessage(oDDGGMAABBD);
				FEIIHHBDHAC = oDDGGMAABBD;
				break;
			}
			case 4290u:
			{
				APEJMBBBLGF aPEJMBBBLGF = new APEJMBBBLGF();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGNDHGKKOMM)
				{
					aPEJMBBBLGF.MergeFrom(KGNDHGKKOMM);
				}
				input.ReadMessage(aPEJMBBBLGF);
				KGNDHGKKOMM = aPEJMBBBLGF;
				break;
			}
			case 6282u:
			{
				DCLIFPOFFLI dCLIFPOFFLI = new DCLIFPOFFLI();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.ACHNDMMADHM)
				{
					dCLIFPOFFLI.MergeFrom(ACHNDMMADHM);
				}
				input.ReadMessage(dCLIFPOFFLI);
				ACHNDMMADHM = dCLIFPOFFLI;
				break;
			}
			case 6306u:
			{
				DCDCGEIELJI dCDCGEIELJI = new DCDCGEIELJI();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LJMLIKAIBDC)
				{
					dCDCGEIELJI.MergeFrom(LJMLIKAIBDC);
				}
				input.ReadMessage(dCDCGEIELJI);
				LJMLIKAIBDC = dCDCGEIELJI;
				break;
			}
			case 8314u:
			{
				CGIDNOCFEOH cGIDNOCFEOH = new CGIDNOCFEOH();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.PJFINGIOFHJ)
				{
					cGIDNOCFEOH.MergeFrom(PJFINGIOFHJ);
				}
				input.ReadMessage(cGIDNOCFEOH);
				PJFINGIOFHJ = cGIDNOCFEOH;
				break;
			}
			case 8754u:
			{
				AOIKHPOBDGK aOIKHPOBDGK = new AOIKHPOBDGK();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.HMNHNAJJCKE)
				{
					aOIKHPOBDGK.MergeFrom(HMNHNAJJCKE);
				}
				input.ReadMessage(aOIKHPOBDGK);
				HMNHNAJJCKE = aOIKHPOBDGK;
				break;
			}
			case 9762u:
			{
				JMCJBDELOKJ jMCJBDELOKJ = new JMCJBDELOKJ();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.JNMGNEAKHCG)
				{
					jMCJBDELOKJ.MergeFrom(JNMGNEAKHCG);
				}
				input.ReadMessage(jMCJBDELOKJ);
				JNMGNEAKHCG = jMCJBDELOKJ;
				break;
			}
			case 14338u:
			{
				HKLCEEEJIGO hKLCEEEJIGO = new HKLCEEEJIGO();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.NPNBNNNINOH)
				{
					hKLCEEEJIGO.MergeFrom(NPNBNNNINOH);
				}
				input.ReadMessage(hKLCEEEJIGO);
				NPNBNNNINOH = hKLCEEEJIGO;
				break;
			}
			case 14354u:
			{
				DPLDPPPMMGH dPLDPPPMMGH = new DPLDPPPMMGH();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.DNDGJJIINDN)
				{
					dPLDPPPMMGH.MergeFrom(DNDGJJIINDN);
				}
				input.ReadMessage(dPLDPPPMMGH);
				DNDGJJIINDN = dPLDPPPMMGH;
				break;
			}
			case 14546u:
			{
				KJHFGPANMFH kJHFGPANMFH = new KJHFGPANMFH();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.KGKOHNAACEN)
				{
					kJHFGPANMFH.MergeFrom(KGKOHNAACEN);
				}
				input.ReadMessage(kJHFGPANMFH);
				KGKOHNAACEN = kJHFGPANMFH;
				break;
			}
			case 14986u:
			{
				GLPJODDJCCD gLPJODDJCCD = new GLPJODDJCCD();
				if (oGJDIOHNFDECase_ == OGJDIOHNFDEOneofCase.LFLNIFFANDM)
				{
					gLPJODDJCCD.MergeFrom(LFLNIFFANDM);
				}
				input.ReadMessage(gLPJODDJCCD);
				LFLNIFFANDM = gLPJODDJCCD;
				break;
			}
			}
		}
	}
}
