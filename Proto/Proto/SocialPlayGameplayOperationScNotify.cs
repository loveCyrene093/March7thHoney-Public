using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialPlayGameplayOperationScNotify : IMessage<SocialPlayGameplayOperationScNotify>, IMessage, IEquatable<SocialPlayGameplayOperationScNotify>, IDeepCloneable<SocialPlayGameplayOperationScNotify>, IBufferMessage
{
	public enum DCINAIHIPOCOneofCase
	{
		None = 0,
		KBPJEKKBBNO = 25,
		JKMNPPEOIJP = 294,
		FIHMHJHGHOG = 380,
		AFCCFJOEIOH = 565,
		IACKOCPGIAK = 684,
		NGPGKFELCED = 826,
		KANBEFELFFE = 1176,
		FHJFKLICFBE = 1322,
		INPEGNFEPAP = 1396,
		BLEDIOOJPNL = 1686,
		IHNNEJKHBHL = 1754,
		PAIBKOMPFOE = 1763,
		NEAIFLAADFE = 1780,
		PEFPFCINABN = 1841
	}

	private static readonly MessageParser<SocialPlayGameplayOperationScNotify> _parser = new MessageParser<SocialPlayGameplayOperationScNotify>(() => new SocialPlayGameplayOperationScNotify());

	private UnknownFieldSet _unknownFields;

	public const int NCFHGIBCEBGFieldNumber = 5;

	private uint nCFHGIBCEBG_;

	public const int MFBDMLPDEOEFieldNumber = 6;

	private uint mFBDMLPDEOE_;

	public const int KBPJEKKBBNOFieldNumber = 25;

	public const int JKMNPPEOIJPFieldNumber = 294;

	public const int FIHMHJHGHOGFieldNumber = 380;

	public const int AFCCFJOEIOHFieldNumber = 565;

	public const int IACKOCPGIAKFieldNumber = 684;

	public const int NGPGKFELCEDFieldNumber = 826;

	public const int KANBEFELFFEFieldNumber = 1176;

	public const int FHJFKLICFBEFieldNumber = 1322;

	public const int INPEGNFEPAPFieldNumber = 1396;

	public const int BLEDIOOJPNLFieldNumber = 1686;

	public const int IHNNEJKHBHLFieldNumber = 1754;

	public const int PAIBKOMPFOEFieldNumber = 1763;

	public const int NEAIFLAADFEFieldNumber = 1780;

	public const int PEFPFCINABNFieldNumber = 1841;

	private object dCINAIHIPOC_;

	private DCINAIHIPOCOneofCase dCINAIHIPOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialPlayGameplayOperationScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SocialPlayGameplayOperationScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCFHGIBCEBG
	{
		get
		{
			return nCFHGIBCEBG_;
		}
		set
		{
			nCFHGIBCEBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFBDMLPDEOE
	{
		get
		{
			return mFBDMLPDEOE_;
		}
		set
		{
			mFBDMLPDEOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBPJEKKBBNO
	{
		get
		{
			if (!HasKBPJEKKBBNO)
			{
				return 0u;
			}
			return (uint)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = DCINAIHIPOCOneofCase.KBPJEKKBBNO;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKBPJEKKBBNO => dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.KBPJEKKBBNO;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKMNPPEOIJP
	{
		get
		{
			if (!HasJKMNPPEOIJP)
			{
				return 0u;
			}
			return (uint)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = DCINAIHIPOCOneofCase.JKMNPPEOIJP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJKMNPPEOIJP => dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.JKMNPPEOIJP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FIHMHJHGHOG
	{
		get
		{
			if (!HasFIHMHJHGHOG)
			{
				return 0L;
			}
			return (long)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = DCINAIHIPOCOneofCase.FIHMHJHGHOG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFIHMHJHGHOG => dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.FIHMHJHGHOG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDJNPFBOMM AFCCFJOEIOH
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.AFCCFJOEIOH)
			{
				return null;
			}
			return (HMDJNPFBOMM)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.AFCCFJOEIOH : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKCCKHEFFB IACKOCPGIAK
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.IACKOCPGIAK)
			{
				return null;
			}
			return (CCKCCKHEFFB)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.IACKOCPGIAK : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLKDHPBAMJ NGPGKFELCED
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.NGPGKFELCED)
			{
				return null;
			}
			return (GFLKDHPBAMJ)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.NGPGKFELCED : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO KANBEFELFFE
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.KANBEFELFFE)
			{
				return null;
			}
			return (FOFNOBHLKGO)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.KANBEFELFFE : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKHIPFHEKCK FHJFKLICFBE
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.FHJFKLICFBE)
			{
				return null;
			}
			return (MKHIPFHEKCK)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.FHJFKLICFBE : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKHIPFHEKCK INPEGNFEPAP
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.INPEGNFEPAP)
			{
				return null;
			}
			return (MKHIPFHEKCK)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.INPEGNFEPAP : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCINCLHIOJ BLEDIOOJPNL
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.BLEDIOOJPNL)
			{
				return null;
			}
			return (KHCINCLHIOJ)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.BLEDIOOJPNL : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHNLLCNBCC IHNNEJKHBHL
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.IHNNEJKHBHL)
			{
				return null;
			}
			return (ICHNLLCNBCC)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.IHNNEJKHBHL : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PAIBKOMPFOE
	{
		get
		{
			if (!HasPAIBKOMPFOE)
			{
				return 0u;
			}
			return (uint)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = DCINAIHIPOCOneofCase.PAIBKOMPFOE;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPAIBKOMPFOE => dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.PAIBKOMPFOE;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NEAIFLAADFE
	{
		get
		{
			if (!HasNEAIFLAADFE)
			{
				return 0u;
			}
			return (uint)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = DCINAIHIPOCOneofCase.NEAIFLAADFE;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNEAIFLAADFE => dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.NEAIFLAADFE;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBJBPNNOKO PEFPFCINABN
	{
		get
		{
			if (dCINAIHIPOCCase_ != DCINAIHIPOCOneofCase.PEFPFCINABN)
			{
				return null;
			}
			return (OEBJBPNNOKO)dCINAIHIPOC_;
		}
		set
		{
			dCINAIHIPOC_ = value;
			dCINAIHIPOCCase_ = ((value != null) ? DCINAIHIPOCOneofCase.PEFPFCINABN : DCINAIHIPOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCINAIHIPOCOneofCase DCINAIHIPOCCase => dCINAIHIPOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayGameplayOperationScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayGameplayOperationScNotify(SocialPlayGameplayOperationScNotify other)
		: this()
	{
		nCFHGIBCEBG_ = other.nCFHGIBCEBG_;
		mFBDMLPDEOE_ = other.mFBDMLPDEOE_;
		switch (other.DCINAIHIPOCCase)
		{
		case DCINAIHIPOCOneofCase.KBPJEKKBBNO:
			KBPJEKKBBNO = other.KBPJEKKBBNO;
			break;
		case DCINAIHIPOCOneofCase.JKMNPPEOIJP:
			JKMNPPEOIJP = other.JKMNPPEOIJP;
			break;
		case DCINAIHIPOCOneofCase.FIHMHJHGHOG:
			FIHMHJHGHOG = other.FIHMHJHGHOG;
			break;
		case DCINAIHIPOCOneofCase.AFCCFJOEIOH:
			AFCCFJOEIOH = other.AFCCFJOEIOH.Clone();
			break;
		case DCINAIHIPOCOneofCase.IACKOCPGIAK:
			IACKOCPGIAK = other.IACKOCPGIAK.Clone();
			break;
		case DCINAIHIPOCOneofCase.NGPGKFELCED:
			NGPGKFELCED = other.NGPGKFELCED.Clone();
			break;
		case DCINAIHIPOCOneofCase.KANBEFELFFE:
			KANBEFELFFE = other.KANBEFELFFE.Clone();
			break;
		case DCINAIHIPOCOneofCase.FHJFKLICFBE:
			FHJFKLICFBE = other.FHJFKLICFBE.Clone();
			break;
		case DCINAIHIPOCOneofCase.INPEGNFEPAP:
			INPEGNFEPAP = other.INPEGNFEPAP.Clone();
			break;
		case DCINAIHIPOCOneofCase.BLEDIOOJPNL:
			BLEDIOOJPNL = other.BLEDIOOJPNL.Clone();
			break;
		case DCINAIHIPOCOneofCase.IHNNEJKHBHL:
			IHNNEJKHBHL = other.IHNNEJKHBHL.Clone();
			break;
		case DCINAIHIPOCOneofCase.PAIBKOMPFOE:
			PAIBKOMPFOE = other.PAIBKOMPFOE;
			break;
		case DCINAIHIPOCOneofCase.NEAIFLAADFE:
			NEAIFLAADFE = other.NEAIFLAADFE;
			break;
		case DCINAIHIPOCOneofCase.PEFPFCINABN:
			PEFPFCINABN = other.PEFPFCINABN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayGameplayOperationScNotify Clone()
	{
		return new SocialPlayGameplayOperationScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKBPJEKKBBNO()
	{
		if (HasKBPJEKKBBNO)
		{
			ClearDCINAIHIPOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJKMNPPEOIJP()
	{
		if (HasJKMNPPEOIJP)
		{
			ClearDCINAIHIPOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFIHMHJHGHOG()
	{
		if (HasFIHMHJHGHOG)
		{
			ClearDCINAIHIPOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPAIBKOMPFOE()
	{
		if (HasPAIBKOMPFOE)
		{
			ClearDCINAIHIPOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNEAIFLAADFE()
	{
		if (HasNEAIFLAADFE)
		{
			ClearDCINAIHIPOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDCINAIHIPOC()
	{
		dCINAIHIPOCCase_ = DCINAIHIPOCOneofCase.None;
		dCINAIHIPOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SocialPlayGameplayOperationScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialPlayGameplayOperationScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NCFHGIBCEBG != other.NCFHGIBCEBG)
		{
			return false;
		}
		if (MFBDMLPDEOE != other.MFBDMLPDEOE)
		{
			return false;
		}
		if (KBPJEKKBBNO != other.KBPJEKKBBNO)
		{
			return false;
		}
		if (JKMNPPEOIJP != other.JKMNPPEOIJP)
		{
			return false;
		}
		if (FIHMHJHGHOG != other.FIHMHJHGHOG)
		{
			return false;
		}
		if (!object.Equals(AFCCFJOEIOH, other.AFCCFJOEIOH))
		{
			return false;
		}
		if (!object.Equals(IACKOCPGIAK, other.IACKOCPGIAK))
		{
			return false;
		}
		if (!object.Equals(NGPGKFELCED, other.NGPGKFELCED))
		{
			return false;
		}
		if (!object.Equals(KANBEFELFFE, other.KANBEFELFFE))
		{
			return false;
		}
		if (!object.Equals(FHJFKLICFBE, other.FHJFKLICFBE))
		{
			return false;
		}
		if (!object.Equals(INPEGNFEPAP, other.INPEGNFEPAP))
		{
			return false;
		}
		if (!object.Equals(BLEDIOOJPNL, other.BLEDIOOJPNL))
		{
			return false;
		}
		if (!object.Equals(IHNNEJKHBHL, other.IHNNEJKHBHL))
		{
			return false;
		}
		if (PAIBKOMPFOE != other.PAIBKOMPFOE)
		{
			return false;
		}
		if (NEAIFLAADFE != other.NEAIFLAADFE)
		{
			return false;
		}
		if (!object.Equals(PEFPFCINABN, other.PEFPFCINABN))
		{
			return false;
		}
		if (DCINAIHIPOCCase != other.DCINAIHIPOCCase)
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
		if (NCFHGIBCEBG != 0)
		{
			num ^= NCFHGIBCEBG.GetHashCode();
		}
		if (MFBDMLPDEOE != 0)
		{
			num ^= MFBDMLPDEOE.GetHashCode();
		}
		if (HasKBPJEKKBBNO)
		{
			num ^= KBPJEKKBBNO.GetHashCode();
		}
		if (HasJKMNPPEOIJP)
		{
			num ^= JKMNPPEOIJP.GetHashCode();
		}
		if (HasFIHMHJHGHOG)
		{
			num ^= FIHMHJHGHOG.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.AFCCFJOEIOH)
		{
			num ^= AFCCFJOEIOH.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IACKOCPGIAK)
		{
			num ^= IACKOCPGIAK.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.NGPGKFELCED)
		{
			num ^= NGPGKFELCED.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.KANBEFELFFE)
		{
			num ^= KANBEFELFFE.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.FHJFKLICFBE)
		{
			num ^= FHJFKLICFBE.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.INPEGNFEPAP)
		{
			num ^= INPEGNFEPAP.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.BLEDIOOJPNL)
		{
			num ^= BLEDIOOJPNL.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IHNNEJKHBHL)
		{
			num ^= IHNNEJKHBHL.GetHashCode();
		}
		if (HasPAIBKOMPFOE)
		{
			num ^= PAIBKOMPFOE.GetHashCode();
		}
		if (HasNEAIFLAADFE)
		{
			num ^= NEAIFLAADFE.GetHashCode();
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.PEFPFCINABN)
		{
			num ^= PEFPFCINABN.GetHashCode();
		}
		num ^= (int)dCINAIHIPOCCase_;
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
		if (NCFHGIBCEBG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NCFHGIBCEBG);
		}
		if (MFBDMLPDEOE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MFBDMLPDEOE);
		}
		if (HasKBPJEKKBBNO)
		{
			output.WriteRawTag(200, 1);
			output.WriteUInt32(KBPJEKKBBNO);
		}
		if (HasJKMNPPEOIJP)
		{
			output.WriteRawTag(176, 18);
			output.WriteUInt32(JKMNPPEOIJP);
		}
		if (HasFIHMHJHGHOG)
		{
			output.WriteRawTag(224, 23);
			output.WriteInt64(FIHMHJHGHOG);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.AFCCFJOEIOH)
		{
			output.WriteRawTag(170, 35);
			output.WriteMessage(AFCCFJOEIOH);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IACKOCPGIAK)
		{
			output.WriteRawTag(226, 42);
			output.WriteMessage(IACKOCPGIAK);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.NGPGKFELCED)
		{
			output.WriteRawTag(210, 51);
			output.WriteMessage(NGPGKFELCED);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.KANBEFELFFE)
		{
			output.WriteRawTag(194, 73);
			output.WriteMessage(KANBEFELFFE);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.FHJFKLICFBE)
		{
			output.WriteRawTag(210, 82);
			output.WriteMessage(FHJFKLICFBE);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.INPEGNFEPAP)
		{
			output.WriteRawTag(162, 87);
			output.WriteMessage(INPEGNFEPAP);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.BLEDIOOJPNL)
		{
			output.WriteRawTag(178, 105);
			output.WriteMessage(BLEDIOOJPNL);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IHNNEJKHBHL)
		{
			output.WriteRawTag(210, 109);
			output.WriteMessage(IHNNEJKHBHL);
		}
		if (HasPAIBKOMPFOE)
		{
			output.WriteRawTag(152, 110);
			output.WriteUInt32(PAIBKOMPFOE);
		}
		if (HasNEAIFLAADFE)
		{
			output.WriteRawTag(160, 111);
			output.WriteUInt32(NEAIFLAADFE);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.PEFPFCINABN)
		{
			output.WriteRawTag(138, 115);
			output.WriteMessage(PEFPFCINABN);
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
		if (NCFHGIBCEBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCFHGIBCEBG);
		}
		if (MFBDMLPDEOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFBDMLPDEOE);
		}
		if (HasKBPJEKKBBNO)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KBPJEKKBBNO);
		}
		if (HasJKMNPPEOIJP)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(JKMNPPEOIJP);
		}
		if (HasFIHMHJHGHOG)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(FIHMHJHGHOG);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.AFCCFJOEIOH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AFCCFJOEIOH);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IACKOCPGIAK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IACKOCPGIAK);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.NGPGKFELCED)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NGPGKFELCED);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.KANBEFELFFE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KANBEFELFFE);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.FHJFKLICFBE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FHJFKLICFBE);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.INPEGNFEPAP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(INPEGNFEPAP);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.BLEDIOOJPNL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BLEDIOOJPNL);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IHNNEJKHBHL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IHNNEJKHBHL);
		}
		if (HasPAIBKOMPFOE)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PAIBKOMPFOE);
		}
		if (HasNEAIFLAADFE)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NEAIFLAADFE);
		}
		if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.PEFPFCINABN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PEFPFCINABN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialPlayGameplayOperationScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NCFHGIBCEBG != 0)
		{
			NCFHGIBCEBG = other.NCFHGIBCEBG;
		}
		if (other.MFBDMLPDEOE != 0)
		{
			MFBDMLPDEOE = other.MFBDMLPDEOE;
		}
		switch (other.DCINAIHIPOCCase)
		{
		case DCINAIHIPOCOneofCase.KBPJEKKBBNO:
			KBPJEKKBBNO = other.KBPJEKKBBNO;
			break;
		case DCINAIHIPOCOneofCase.JKMNPPEOIJP:
			JKMNPPEOIJP = other.JKMNPPEOIJP;
			break;
		case DCINAIHIPOCOneofCase.FIHMHJHGHOG:
			FIHMHJHGHOG = other.FIHMHJHGHOG;
			break;
		case DCINAIHIPOCOneofCase.AFCCFJOEIOH:
			if (AFCCFJOEIOH == null)
			{
				AFCCFJOEIOH = new HMDJNPFBOMM();
			}
			AFCCFJOEIOH.MergeFrom(other.AFCCFJOEIOH);
			break;
		case DCINAIHIPOCOneofCase.IACKOCPGIAK:
			if (IACKOCPGIAK == null)
			{
				IACKOCPGIAK = new CCKCCKHEFFB();
			}
			IACKOCPGIAK.MergeFrom(other.IACKOCPGIAK);
			break;
		case DCINAIHIPOCOneofCase.NGPGKFELCED:
			if (NGPGKFELCED == null)
			{
				NGPGKFELCED = new GFLKDHPBAMJ();
			}
			NGPGKFELCED.MergeFrom(other.NGPGKFELCED);
			break;
		case DCINAIHIPOCOneofCase.KANBEFELFFE:
			if (KANBEFELFFE == null)
			{
				KANBEFELFFE = new FOFNOBHLKGO();
			}
			KANBEFELFFE.MergeFrom(other.KANBEFELFFE);
			break;
		case DCINAIHIPOCOneofCase.FHJFKLICFBE:
			if (FHJFKLICFBE == null)
			{
				FHJFKLICFBE = new MKHIPFHEKCK();
			}
			FHJFKLICFBE.MergeFrom(other.FHJFKLICFBE);
			break;
		case DCINAIHIPOCOneofCase.INPEGNFEPAP:
			if (INPEGNFEPAP == null)
			{
				INPEGNFEPAP = new MKHIPFHEKCK();
			}
			INPEGNFEPAP.MergeFrom(other.INPEGNFEPAP);
			break;
		case DCINAIHIPOCOneofCase.BLEDIOOJPNL:
			if (BLEDIOOJPNL == null)
			{
				BLEDIOOJPNL = new KHCINCLHIOJ();
			}
			BLEDIOOJPNL.MergeFrom(other.BLEDIOOJPNL);
			break;
		case DCINAIHIPOCOneofCase.IHNNEJKHBHL:
			if (IHNNEJKHBHL == null)
			{
				IHNNEJKHBHL = new ICHNLLCNBCC();
			}
			IHNNEJKHBHL.MergeFrom(other.IHNNEJKHBHL);
			break;
		case DCINAIHIPOCOneofCase.PAIBKOMPFOE:
			PAIBKOMPFOE = other.PAIBKOMPFOE;
			break;
		case DCINAIHIPOCOneofCase.NEAIFLAADFE:
			NEAIFLAADFE = other.NEAIFLAADFE;
			break;
		case DCINAIHIPOCOneofCase.PEFPFCINABN:
			if (PEFPFCINABN == null)
			{
				PEFPFCINABN = new OEBJBPNNOKO();
			}
			PEFPFCINABN.MergeFrom(other.PEFPFCINABN);
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
			case 40u:
				NCFHGIBCEBG = input.ReadUInt32();
				break;
			case 48u:
				MFBDMLPDEOE = input.ReadUInt32();
				break;
			case 200u:
				KBPJEKKBBNO = input.ReadUInt32();
				break;
			case 2352u:
				JKMNPPEOIJP = input.ReadUInt32();
				break;
			case 3040u:
				FIHMHJHGHOG = input.ReadInt64();
				break;
			case 4522u:
			{
				HMDJNPFBOMM hMDJNPFBOMM = new HMDJNPFBOMM();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.AFCCFJOEIOH)
				{
					hMDJNPFBOMM.MergeFrom(AFCCFJOEIOH);
				}
				input.ReadMessage(hMDJNPFBOMM);
				AFCCFJOEIOH = hMDJNPFBOMM;
				break;
			}
			case 5474u:
			{
				CCKCCKHEFFB cCKCCKHEFFB = new CCKCCKHEFFB();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IACKOCPGIAK)
				{
					cCKCCKHEFFB.MergeFrom(IACKOCPGIAK);
				}
				input.ReadMessage(cCKCCKHEFFB);
				IACKOCPGIAK = cCKCCKHEFFB;
				break;
			}
			case 6610u:
			{
				GFLKDHPBAMJ gFLKDHPBAMJ = new GFLKDHPBAMJ();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.NGPGKFELCED)
				{
					gFLKDHPBAMJ.MergeFrom(NGPGKFELCED);
				}
				input.ReadMessage(gFLKDHPBAMJ);
				NGPGKFELCED = gFLKDHPBAMJ;
				break;
			}
			case 9410u:
			{
				FOFNOBHLKGO fOFNOBHLKGO = new FOFNOBHLKGO();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.KANBEFELFFE)
				{
					fOFNOBHLKGO.MergeFrom(KANBEFELFFE);
				}
				input.ReadMessage(fOFNOBHLKGO);
				KANBEFELFFE = fOFNOBHLKGO;
				break;
			}
			case 10578u:
			{
				MKHIPFHEKCK mKHIPFHEKCK2 = new MKHIPFHEKCK();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.FHJFKLICFBE)
				{
					mKHIPFHEKCK2.MergeFrom(FHJFKLICFBE);
				}
				input.ReadMessage(mKHIPFHEKCK2);
				FHJFKLICFBE = mKHIPFHEKCK2;
				break;
			}
			case 11170u:
			{
				MKHIPFHEKCK mKHIPFHEKCK = new MKHIPFHEKCK();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.INPEGNFEPAP)
				{
					mKHIPFHEKCK.MergeFrom(INPEGNFEPAP);
				}
				input.ReadMessage(mKHIPFHEKCK);
				INPEGNFEPAP = mKHIPFHEKCK;
				break;
			}
			case 13490u:
			{
				KHCINCLHIOJ kHCINCLHIOJ = new KHCINCLHIOJ();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.BLEDIOOJPNL)
				{
					kHCINCLHIOJ.MergeFrom(BLEDIOOJPNL);
				}
				input.ReadMessage(kHCINCLHIOJ);
				BLEDIOOJPNL = kHCINCLHIOJ;
				break;
			}
			case 14034u:
			{
				ICHNLLCNBCC iCHNLLCNBCC = new ICHNLLCNBCC();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.IHNNEJKHBHL)
				{
					iCHNLLCNBCC.MergeFrom(IHNNEJKHBHL);
				}
				input.ReadMessage(iCHNLLCNBCC);
				IHNNEJKHBHL = iCHNLLCNBCC;
				break;
			}
			case 14104u:
				PAIBKOMPFOE = input.ReadUInt32();
				break;
			case 14240u:
				NEAIFLAADFE = input.ReadUInt32();
				break;
			case 14730u:
			{
				OEBJBPNNOKO oEBJBPNNOKO = new OEBJBPNNOKO();
				if (dCINAIHIPOCCase_ == DCINAIHIPOCOneofCase.PEFPFCINABN)
				{
					oEBJBPNNOKO.MergeFrom(PEFPFCINABN);
				}
				input.ReadMessage(oEBJBPNNOKO);
				PEFPFCINABN = oEBJBPNNOKO;
				break;
			}
			}
		}
	}
}
