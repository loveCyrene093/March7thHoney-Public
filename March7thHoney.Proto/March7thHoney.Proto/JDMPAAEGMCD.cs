using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JDMPAAEGMCD : IMessage<JDMPAAEGMCD>, IMessage, IEquatable<JDMPAAEGMCD>, IDeepCloneable<JDMPAAEGMCD>, IBufferMessage
{
	public enum GGKFDJKHBDJOneofCase
	{
		None = 0,
		AOGMPAJBFBH = 1,
		KJOJJLGCDMK = 2,
		BGFMFKPADKI = 3,
		HNLAEIBDFJM = 5,
		BIDIMLDNAIO = 7,
		EJCHIMJMCJA = 8,
		PACDGKNBKHD = 9,
		JFOINNNBMKD = 10,
		JBAGGHGAPGP = 11,
		LNEBKCHGPFA = 12,
		KIPOBLKHEKP = 13,
		JNAHOOEADEK = 14,
		GDAHHPIJNHF = 15
	}

	private static readonly MessageParser<JDMPAAEGMCD> _parser = new MessageParser<JDMPAAEGMCD>(() => new JDMPAAEGMCD());

	private UnknownFieldSet _unknownFields;

	public const int AOGMPAJBFBHFieldNumber = 1;

	public const int KJOJJLGCDMKFieldNumber = 2;

	public const int BGFMFKPADKIFieldNumber = 3;

	public const int HNLAEIBDFJMFieldNumber = 5;

	public const int BIDIMLDNAIOFieldNumber = 7;

	public const int EJCHIMJMCJAFieldNumber = 8;

	public const int PACDGKNBKHDFieldNumber = 9;

	public const int JFOINNNBMKDFieldNumber = 10;

	public const int JBAGGHGAPGPFieldNumber = 11;

	public const int LNEBKCHGPFAFieldNumber = 12;

	public const int KIPOBLKHEKPFieldNumber = 13;

	public const int JNAHOOEADEKFieldNumber = 14;

	public const int GDAHHPIJNHFFieldNumber = 15;

	private object gGKFDJKHBDJ_;

	private GGKFDJKHBDJOneofCase gGKFDJKHBDJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JDMPAAEGMCD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JDMPAAEGMCDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDLCFFPCHBN AOGMPAJBFBH
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.AOGMPAJBFBH)
			{
				return null;
			}
			return (FDLCFFPCHBN)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.AOGMPAJBFBH : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKECFDCFJOH KJOJJLGCDMK
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.KJOJJLGCDMK)
			{
				return null;
			}
			return (CKECFDCFJOH)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.KJOJJLGCDMK : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJLOOCHLBCL BGFMFKPADKI
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.BGFMFKPADKI)
			{
				return null;
			}
			return (HJLOOCHLBCL)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.BGFMFKPADKI : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDLCFFPCHBN HNLAEIBDFJM
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.HNLAEIBDFJM)
			{
				return null;
			}
			return (FDLCFFPCHBN)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.HNLAEIBDFJM : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMHNOOMEMIF BIDIMLDNAIO
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.BIDIMLDNAIO)
			{
				return null;
			}
			return (KMHNOOMEMIF)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.BIDIMLDNAIO : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLPMDJEKDCN EJCHIMJMCJA
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.EJCHIMJMCJA)
			{
				return null;
			}
			return (HLPMDJEKDCN)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.EJCHIMJMCJA : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKECFDCFJOH PACDGKNBKHD
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.PACDGKNBKHD)
			{
				return null;
			}
			return (CKECFDCFJOH)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.PACDGKNBKHD : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDLCFFPCHBN JFOINNNBMKD
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.JFOINNNBMKD)
			{
				return null;
			}
			return (FDLCFFPCHBN)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.JFOINNNBMKD : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAFPNCPHNFF JBAGGHGAPGP
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.JBAGGHGAPGP)
			{
				return null;
			}
			return (BAFPNCPHNFF)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.JBAGGHGAPGP : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJLOOCHLBCL LNEBKCHGPFA
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.LNEBKCHGPFA)
			{
				return null;
			}
			return (HJLOOCHLBCL)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.LNEBKCHGPFA : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPLEKCNLEMG KIPOBLKHEKP
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.KIPOBLKHEKP)
			{
				return null;
			}
			return (IPLEKCNLEMG)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.KIPOBLKHEKP : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKECFDCFJOH JNAHOOEADEK
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.JNAHOOEADEK)
			{
				return null;
			}
			return (CKECFDCFJOH)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.JNAHOOEADEK : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLPMDJEKDCN GDAHHPIJNHF
	{
		get
		{
			if (gGKFDJKHBDJCase_ != GGKFDJKHBDJOneofCase.GDAHHPIJNHF)
			{
				return null;
			}
			return (HLPMDJEKDCN)gGKFDJKHBDJ_;
		}
		set
		{
			gGKFDJKHBDJ_ = value;
			gGKFDJKHBDJCase_ = ((value != null) ? GGKFDJKHBDJOneofCase.GDAHHPIJNHF : GGKFDJKHBDJOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGKFDJKHBDJOneofCase GGKFDJKHBDJCase => gGKFDJKHBDJCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDMPAAEGMCD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDMPAAEGMCD(JDMPAAEGMCD other)
		: this()
	{
		switch (other.GGKFDJKHBDJCase)
		{
		case GGKFDJKHBDJOneofCase.AOGMPAJBFBH:
			AOGMPAJBFBH = other.AOGMPAJBFBH.Clone();
			break;
		case GGKFDJKHBDJOneofCase.KJOJJLGCDMK:
			KJOJJLGCDMK = other.KJOJJLGCDMK.Clone();
			break;
		case GGKFDJKHBDJOneofCase.BGFMFKPADKI:
			BGFMFKPADKI = other.BGFMFKPADKI.Clone();
			break;
		case GGKFDJKHBDJOneofCase.HNLAEIBDFJM:
			HNLAEIBDFJM = other.HNLAEIBDFJM.Clone();
			break;
		case GGKFDJKHBDJOneofCase.BIDIMLDNAIO:
			BIDIMLDNAIO = other.BIDIMLDNAIO.Clone();
			break;
		case GGKFDJKHBDJOneofCase.EJCHIMJMCJA:
			EJCHIMJMCJA = other.EJCHIMJMCJA.Clone();
			break;
		case GGKFDJKHBDJOneofCase.PACDGKNBKHD:
			PACDGKNBKHD = other.PACDGKNBKHD.Clone();
			break;
		case GGKFDJKHBDJOneofCase.JFOINNNBMKD:
			JFOINNNBMKD = other.JFOINNNBMKD.Clone();
			break;
		case GGKFDJKHBDJOneofCase.JBAGGHGAPGP:
			JBAGGHGAPGP = other.JBAGGHGAPGP.Clone();
			break;
		case GGKFDJKHBDJOneofCase.LNEBKCHGPFA:
			LNEBKCHGPFA = other.LNEBKCHGPFA.Clone();
			break;
		case GGKFDJKHBDJOneofCase.KIPOBLKHEKP:
			KIPOBLKHEKP = other.KIPOBLKHEKP.Clone();
			break;
		case GGKFDJKHBDJOneofCase.JNAHOOEADEK:
			JNAHOOEADEK = other.JNAHOOEADEK.Clone();
			break;
		case GGKFDJKHBDJOneofCase.GDAHHPIJNHF:
			GDAHHPIJNHF = other.GDAHHPIJNHF.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDMPAAEGMCD Clone()
	{
		return new JDMPAAEGMCD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGGKFDJKHBDJ()
	{
		gGKFDJKHBDJCase_ = GGKFDJKHBDJOneofCase.None;
		gGKFDJKHBDJ_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JDMPAAEGMCD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JDMPAAEGMCD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AOGMPAJBFBH, other.AOGMPAJBFBH))
		{
			return false;
		}
		if (!object.Equals(KJOJJLGCDMK, other.KJOJJLGCDMK))
		{
			return false;
		}
		if (!object.Equals(BGFMFKPADKI, other.BGFMFKPADKI))
		{
			return false;
		}
		if (!object.Equals(HNLAEIBDFJM, other.HNLAEIBDFJM))
		{
			return false;
		}
		if (!object.Equals(BIDIMLDNAIO, other.BIDIMLDNAIO))
		{
			return false;
		}
		if (!object.Equals(EJCHIMJMCJA, other.EJCHIMJMCJA))
		{
			return false;
		}
		if (!object.Equals(PACDGKNBKHD, other.PACDGKNBKHD))
		{
			return false;
		}
		if (!object.Equals(JFOINNNBMKD, other.JFOINNNBMKD))
		{
			return false;
		}
		if (!object.Equals(JBAGGHGAPGP, other.JBAGGHGAPGP))
		{
			return false;
		}
		if (!object.Equals(LNEBKCHGPFA, other.LNEBKCHGPFA))
		{
			return false;
		}
		if (!object.Equals(KIPOBLKHEKP, other.KIPOBLKHEKP))
		{
			return false;
		}
		if (!object.Equals(JNAHOOEADEK, other.JNAHOOEADEK))
		{
			return false;
		}
		if (!object.Equals(GDAHHPIJNHF, other.GDAHHPIJNHF))
		{
			return false;
		}
		if (GGKFDJKHBDJCase != other.GGKFDJKHBDJCase)
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
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.AOGMPAJBFBH)
		{
			num ^= AOGMPAJBFBH.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KJOJJLGCDMK)
		{
			num ^= KJOJJLGCDMK.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BGFMFKPADKI)
		{
			num ^= BGFMFKPADKI.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.HNLAEIBDFJM)
		{
			num ^= HNLAEIBDFJM.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BIDIMLDNAIO)
		{
			num ^= BIDIMLDNAIO.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.EJCHIMJMCJA)
		{
			num ^= EJCHIMJMCJA.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.PACDGKNBKHD)
		{
			num ^= PACDGKNBKHD.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JFOINNNBMKD)
		{
			num ^= JFOINNNBMKD.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JBAGGHGAPGP)
		{
			num ^= JBAGGHGAPGP.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.LNEBKCHGPFA)
		{
			num ^= LNEBKCHGPFA.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KIPOBLKHEKP)
		{
			num ^= KIPOBLKHEKP.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JNAHOOEADEK)
		{
			num ^= JNAHOOEADEK.GetHashCode();
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.GDAHHPIJNHF)
		{
			num ^= GDAHHPIJNHF.GetHashCode();
		}
		num ^= (int)gGKFDJKHBDJCase_;
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
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.AOGMPAJBFBH)
		{
			output.WriteRawTag(10);
			output.WriteMessage(AOGMPAJBFBH);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KJOJJLGCDMK)
		{
			output.WriteRawTag(18);
			output.WriteMessage(KJOJJLGCDMK);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BGFMFKPADKI)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BGFMFKPADKI);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.HNLAEIBDFJM)
		{
			output.WriteRawTag(42);
			output.WriteMessage(HNLAEIBDFJM);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BIDIMLDNAIO)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BIDIMLDNAIO);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.EJCHIMJMCJA)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EJCHIMJMCJA);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.PACDGKNBKHD)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PACDGKNBKHD);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JFOINNNBMKD)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JFOINNNBMKD);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JBAGGHGAPGP)
		{
			output.WriteRawTag(90);
			output.WriteMessage(JBAGGHGAPGP);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.LNEBKCHGPFA)
		{
			output.WriteRawTag(98);
			output.WriteMessage(LNEBKCHGPFA);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KIPOBLKHEKP)
		{
			output.WriteRawTag(106);
			output.WriteMessage(KIPOBLKHEKP);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JNAHOOEADEK)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JNAHOOEADEK);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.GDAHHPIJNHF)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GDAHHPIJNHF);
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
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.AOGMPAJBFBH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AOGMPAJBFBH);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KJOJJLGCDMK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJOJJLGCDMK);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BGFMFKPADKI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGFMFKPADKI);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.HNLAEIBDFJM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HNLAEIBDFJM);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BIDIMLDNAIO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BIDIMLDNAIO);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.EJCHIMJMCJA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJCHIMJMCJA);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.PACDGKNBKHD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PACDGKNBKHD);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JFOINNNBMKD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JFOINNNBMKD);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JBAGGHGAPGP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JBAGGHGAPGP);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.LNEBKCHGPFA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LNEBKCHGPFA);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KIPOBLKHEKP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KIPOBLKHEKP);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JNAHOOEADEK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNAHOOEADEK);
		}
		if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.GDAHHPIJNHF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GDAHHPIJNHF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JDMPAAEGMCD other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.GGKFDJKHBDJCase)
		{
		case GGKFDJKHBDJOneofCase.AOGMPAJBFBH:
			if (AOGMPAJBFBH == null)
			{
				AOGMPAJBFBH = new FDLCFFPCHBN();
			}
			AOGMPAJBFBH.MergeFrom(other.AOGMPAJBFBH);
			break;
		case GGKFDJKHBDJOneofCase.KJOJJLGCDMK:
			if (KJOJJLGCDMK == null)
			{
				KJOJJLGCDMK = new CKECFDCFJOH();
			}
			KJOJJLGCDMK.MergeFrom(other.KJOJJLGCDMK);
			break;
		case GGKFDJKHBDJOneofCase.BGFMFKPADKI:
			if (BGFMFKPADKI == null)
			{
				BGFMFKPADKI = new HJLOOCHLBCL();
			}
			BGFMFKPADKI.MergeFrom(other.BGFMFKPADKI);
			break;
		case GGKFDJKHBDJOneofCase.HNLAEIBDFJM:
			if (HNLAEIBDFJM == null)
			{
				HNLAEIBDFJM = new FDLCFFPCHBN();
			}
			HNLAEIBDFJM.MergeFrom(other.HNLAEIBDFJM);
			break;
		case GGKFDJKHBDJOneofCase.BIDIMLDNAIO:
			if (BIDIMLDNAIO == null)
			{
				BIDIMLDNAIO = new KMHNOOMEMIF();
			}
			BIDIMLDNAIO.MergeFrom(other.BIDIMLDNAIO);
			break;
		case GGKFDJKHBDJOneofCase.EJCHIMJMCJA:
			if (EJCHIMJMCJA == null)
			{
				EJCHIMJMCJA = new HLPMDJEKDCN();
			}
			EJCHIMJMCJA.MergeFrom(other.EJCHIMJMCJA);
			break;
		case GGKFDJKHBDJOneofCase.PACDGKNBKHD:
			if (PACDGKNBKHD == null)
			{
				PACDGKNBKHD = new CKECFDCFJOH();
			}
			PACDGKNBKHD.MergeFrom(other.PACDGKNBKHD);
			break;
		case GGKFDJKHBDJOneofCase.JFOINNNBMKD:
			if (JFOINNNBMKD == null)
			{
				JFOINNNBMKD = new FDLCFFPCHBN();
			}
			JFOINNNBMKD.MergeFrom(other.JFOINNNBMKD);
			break;
		case GGKFDJKHBDJOneofCase.JBAGGHGAPGP:
			if (JBAGGHGAPGP == null)
			{
				JBAGGHGAPGP = new BAFPNCPHNFF();
			}
			JBAGGHGAPGP.MergeFrom(other.JBAGGHGAPGP);
			break;
		case GGKFDJKHBDJOneofCase.LNEBKCHGPFA:
			if (LNEBKCHGPFA == null)
			{
				LNEBKCHGPFA = new HJLOOCHLBCL();
			}
			LNEBKCHGPFA.MergeFrom(other.LNEBKCHGPFA);
			break;
		case GGKFDJKHBDJOneofCase.KIPOBLKHEKP:
			if (KIPOBLKHEKP == null)
			{
				KIPOBLKHEKP = new IPLEKCNLEMG();
			}
			KIPOBLKHEKP.MergeFrom(other.KIPOBLKHEKP);
			break;
		case GGKFDJKHBDJOneofCase.JNAHOOEADEK:
			if (JNAHOOEADEK == null)
			{
				JNAHOOEADEK = new CKECFDCFJOH();
			}
			JNAHOOEADEK.MergeFrom(other.JNAHOOEADEK);
			break;
		case GGKFDJKHBDJOneofCase.GDAHHPIJNHF:
			if (GDAHHPIJNHF == null)
			{
				GDAHHPIJNHF = new HLPMDJEKDCN();
			}
			GDAHHPIJNHF.MergeFrom(other.GDAHHPIJNHF);
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
				FDLCFFPCHBN fDLCFFPCHBN2 = new FDLCFFPCHBN();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.AOGMPAJBFBH)
				{
					fDLCFFPCHBN2.MergeFrom(AOGMPAJBFBH);
				}
				input.ReadMessage(fDLCFFPCHBN2);
				AOGMPAJBFBH = fDLCFFPCHBN2;
				break;
			}
			case 18u:
			{
				CKECFDCFJOH cKECFDCFJOH3 = new CKECFDCFJOH();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KJOJJLGCDMK)
				{
					cKECFDCFJOH3.MergeFrom(KJOJJLGCDMK);
				}
				input.ReadMessage(cKECFDCFJOH3);
				KJOJJLGCDMK = cKECFDCFJOH3;
				break;
			}
			case 26u:
			{
				HJLOOCHLBCL hJLOOCHLBCL2 = new HJLOOCHLBCL();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BGFMFKPADKI)
				{
					hJLOOCHLBCL2.MergeFrom(BGFMFKPADKI);
				}
				input.ReadMessage(hJLOOCHLBCL2);
				BGFMFKPADKI = hJLOOCHLBCL2;
				break;
			}
			case 42u:
			{
				FDLCFFPCHBN fDLCFFPCHBN3 = new FDLCFFPCHBN();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.HNLAEIBDFJM)
				{
					fDLCFFPCHBN3.MergeFrom(HNLAEIBDFJM);
				}
				input.ReadMessage(fDLCFFPCHBN3);
				HNLAEIBDFJM = fDLCFFPCHBN3;
				break;
			}
			case 58u:
			{
				KMHNOOMEMIF kMHNOOMEMIF = new KMHNOOMEMIF();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.BIDIMLDNAIO)
				{
					kMHNOOMEMIF.MergeFrom(BIDIMLDNAIO);
				}
				input.ReadMessage(kMHNOOMEMIF);
				BIDIMLDNAIO = kMHNOOMEMIF;
				break;
			}
			case 66u:
			{
				HLPMDJEKDCN hLPMDJEKDCN2 = new HLPMDJEKDCN();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.EJCHIMJMCJA)
				{
					hLPMDJEKDCN2.MergeFrom(EJCHIMJMCJA);
				}
				input.ReadMessage(hLPMDJEKDCN2);
				EJCHIMJMCJA = hLPMDJEKDCN2;
				break;
			}
			case 74u:
			{
				CKECFDCFJOH cKECFDCFJOH2 = new CKECFDCFJOH();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.PACDGKNBKHD)
				{
					cKECFDCFJOH2.MergeFrom(PACDGKNBKHD);
				}
				input.ReadMessage(cKECFDCFJOH2);
				PACDGKNBKHD = cKECFDCFJOH2;
				break;
			}
			case 82u:
			{
				FDLCFFPCHBN fDLCFFPCHBN = new FDLCFFPCHBN();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JFOINNNBMKD)
				{
					fDLCFFPCHBN.MergeFrom(JFOINNNBMKD);
				}
				input.ReadMessage(fDLCFFPCHBN);
				JFOINNNBMKD = fDLCFFPCHBN;
				break;
			}
			case 90u:
			{
				BAFPNCPHNFF bAFPNCPHNFF = new BAFPNCPHNFF();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JBAGGHGAPGP)
				{
					bAFPNCPHNFF.MergeFrom(JBAGGHGAPGP);
				}
				input.ReadMessage(bAFPNCPHNFF);
				JBAGGHGAPGP = bAFPNCPHNFF;
				break;
			}
			case 98u:
			{
				HJLOOCHLBCL hJLOOCHLBCL = new HJLOOCHLBCL();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.LNEBKCHGPFA)
				{
					hJLOOCHLBCL.MergeFrom(LNEBKCHGPFA);
				}
				input.ReadMessage(hJLOOCHLBCL);
				LNEBKCHGPFA = hJLOOCHLBCL;
				break;
			}
			case 106u:
			{
				IPLEKCNLEMG iPLEKCNLEMG = new IPLEKCNLEMG();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.KIPOBLKHEKP)
				{
					iPLEKCNLEMG.MergeFrom(KIPOBLKHEKP);
				}
				input.ReadMessage(iPLEKCNLEMG);
				KIPOBLKHEKP = iPLEKCNLEMG;
				break;
			}
			case 114u:
			{
				CKECFDCFJOH cKECFDCFJOH = new CKECFDCFJOH();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.JNAHOOEADEK)
				{
					cKECFDCFJOH.MergeFrom(JNAHOOEADEK);
				}
				input.ReadMessage(cKECFDCFJOH);
				JNAHOOEADEK = cKECFDCFJOH;
				break;
			}
			case 122u:
			{
				HLPMDJEKDCN hLPMDJEKDCN = new HLPMDJEKDCN();
				if (gGKFDJKHBDJCase_ == GGKFDJKHBDJOneofCase.GDAHHPIJNHF)
				{
					hLPMDJEKDCN.MergeFrom(GDAHHPIJNHF);
				}
				input.ReadMessage(hLPMDJEKDCN);
				GDAHHPIJNHF = hLPMDJEKDCN;
				break;
			}
			}
		}
	}
}
