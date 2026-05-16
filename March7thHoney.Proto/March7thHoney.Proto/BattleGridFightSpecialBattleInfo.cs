using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleGridFightSpecialBattleInfo : IMessage<BattleGridFightSpecialBattleInfo>, IMessage, IEquatable<BattleGridFightSpecialBattleInfo>, IDeepCloneable<BattleGridFightSpecialBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleGridFightSpecialBattleInfo> _parser = new MessageParser<BattleGridFightSpecialBattleInfo>(() => new BattleGridFightSpecialBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int CurLevelIdFieldNumber = 1;

	private uint curLevelId_;

	public const int LLLLJOFNNNKFieldNumber = 2;

	private uint lLLLJOFNNNK_;

	public const int RogueMoneyFieldNumber = 3;

	private uint rogueMoney_;

	public const int CMMLDCIACAMFieldNumber = 4;

	private static readonly FieldCodec<MHANIEBKGHH> _repeated_cMMLDCIACAM_codec = FieldCodec.ForMessage(34u, MHANIEBKGHH.Parser);

	private readonly RepeatedField<MHANIEBKGHH> cMMLDCIACAM_ = new RepeatedField<MHANIEBKGHH>();

	public const int HLFLGAKIGMHFieldNumber = 5;

	private static readonly FieldCodec<MHANIEBKGHH> _repeated_hLFLGAKIGMH_codec = FieldCodec.ForMessage(42u, MHANIEBKGHH.Parser);

	private readonly RepeatedField<MHANIEBKGHH> hLFLGAKIGMH_ = new RepeatedField<MHANIEBKGHH>();

	public const int EOODMDLONBDFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_eOODMDLONBD_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> eOODMDLONBD_ = new RepeatedField<uint>();

	public const int DKLKIABDCCEFieldNumber = 7;

	private FIGHICNEPFI dKLKIABDCCE_;

	public const int ADJKHCOIJNKFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_aDJKHCOIJNK_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> aDJKHCOIJNK_ = new RepeatedField<uint>();

	public const int GridFightCurLevelExpFieldNumber = 9;

	private uint gridFightCurLevelExp_;

	public const int PNICGJBAJIJFieldNumber = 10;

	private uint pNICGJBAJIJ_;

	public const int FIPIEBKDODAFieldNumber = 11;

	private uint fIPIEBKDODA_;

	public const int IEPGKLIDHEKFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_iEPGKLIDHEK_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> iEPGKLIDHEK_ = new RepeatedField<uint>();

	public const int JKHPFKDOKLGFieldNumber = 13;

	private uint jKHPFKDOKLG_;

	public const int JGOEPADOKEMFieldNumber = 14;

	private uint jGOEPADOKEM_;

	public const int ILIIFCFHPBCFieldNumber = 15;

	private bool iLIIFCFHPBC_;

	public const int HKEJDHAHIBJFieldNumber = 16;

	private bool hKEJDHAHIBJ_;

	public const int IMKOJKJAHMMFieldNumber = 17;

	private static readonly FieldCodec<KOILNOLKDEJ> _repeated_iMKOJKJAHMM_codec = FieldCodec.ForMessage(138u, KOILNOLKDEJ.Parser);

	private readonly RepeatedField<KOILNOLKDEJ> iMKOJKJAHMM_ = new RepeatedField<KOILNOLKDEJ>();

	public const int BPEOFFPJKAEFieldNumber = 18;

	private static readonly FieldCodec<INMOMCDOPHF> _repeated_bPEOFFPJKAE_codec = FieldCodec.ForMessage(146u, INMOMCDOPHF.Parser);

	private readonly RepeatedField<INMOMCDOPHF> bPEOFFPJKAE_ = new RepeatedField<INMOMCDOPHF>();

	public const int LGMNJNHIAKAFieldNumber = 19;

	private static readonly FieldCodec<uint> _repeated_lGMNJNHIAKA_codec = FieldCodec.ForUInt32(154u);

	private readonly RepeatedField<uint> lGMNJNHIAKA_ = new RepeatedField<uint>();

	public const int KFLIOPGFPEJFieldNumber = 20;

	private bool kFLIOPGFPEJ_;

	public const int LKLCFINGNIOFieldNumber = 21;

	private uint lKLCFINGNIO_;

	public const int KKFPPONDKHHFieldNumber = 22;

	private KFOLIJCNDBK kKFPPONDKHH_;

	public const int GBBKKPCGNLAFieldNumber = 23;

	private uint gBBKKPCGNLA_;

	public const int MOIGAECNEIAFieldNumber = 24;

	private uint mOIGAECNEIA_;

	public const int POEMNNCCJHIFieldNumber = 25;

	private static readonly FieldCodec<uint> _repeated_pOEMNNCCJHI_codec = FieldCodec.ForUInt32(202u);

	private readonly RepeatedField<uint> pOEMNNCCJHI_ = new RepeatedField<uint>();

	public const int NBAODFGCEBFFieldNumber = 26;

	private static readonly FieldCodec<FIMOHHPINNB> _repeated_nBAODFGCEBF_codec = FieldCodec.ForMessage(210u, FIMOHHPINNB.Parser);

	private readonly RepeatedField<FIMOHHPINNB> nBAODFGCEBF_ = new RepeatedField<FIMOHHPINNB>();

	public const int NPKIJFGKNNJFieldNumber = 27;

	private uint nPKIJFGKNNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleGridFightSpecialBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleGridFightSpecialBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurLevelId
	{
		get
		{
			return curLevelId_;
		}
		set
		{
			curLevelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLLLJOFNNNK
	{
		get
		{
			return lLLLJOFNNNK_;
		}
		set
		{
			lLLLJOFNNNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RogueMoney
	{
		get
		{
			return rogueMoney_;
		}
		set
		{
			rogueMoney_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MHANIEBKGHH> CMMLDCIACAM => cMMLDCIACAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MHANIEBKGHH> HLFLGAKIGMH => hLFLGAKIGMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EOODMDLONBD => eOODMDLONBD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGHICNEPFI DKLKIABDCCE
	{
		get
		{
			return dKLKIABDCCE_;
		}
		set
		{
			dKLKIABDCCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ADJKHCOIJNK => aDJKHCOIJNK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightCurLevelExp
	{
		get
		{
			return gridFightCurLevelExp_;
		}
		set
		{
			gridFightCurLevelExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNICGJBAJIJ
	{
		get
		{
			return pNICGJBAJIJ_;
		}
		set
		{
			pNICGJBAJIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIPIEBKDODA
	{
		get
		{
			return fIPIEBKDODA_;
		}
		set
		{
			fIPIEBKDODA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IEPGKLIDHEK => iEPGKLIDHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKHPFKDOKLG
	{
		get
		{
			return jKHPFKDOKLG_;
		}
		set
		{
			jKHPFKDOKLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGOEPADOKEM
	{
		get
		{
			return jGOEPADOKEM_;
		}
		set
		{
			jGOEPADOKEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ILIIFCFHPBC
	{
		get
		{
			return iLIIFCFHPBC_;
		}
		set
		{
			iLIIFCFHPBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HKEJDHAHIBJ
	{
		get
		{
			return hKEJDHAHIBJ_;
		}
		set
		{
			hKEJDHAHIBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KOILNOLKDEJ> IMKOJKJAHMM => iMKOJKJAHMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<INMOMCDOPHF> BPEOFFPJKAE => bPEOFFPJKAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LGMNJNHIAKA => lGMNJNHIAKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KFLIOPGFPEJ
	{
		get
		{
			return kFLIOPGFPEJ_;
		}
		set
		{
			kFLIOPGFPEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LKLCFINGNIO
	{
		get
		{
			return lKLCFINGNIO_;
		}
		set
		{
			lKLCFINGNIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFOLIJCNDBK KKFPPONDKHH
	{
		get
		{
			return kKFPPONDKHH_;
		}
		set
		{
			kKFPPONDKHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBBKKPCGNLA
	{
		get
		{
			return gBBKKPCGNLA_;
		}
		set
		{
			gBBKKPCGNLA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOIGAECNEIA
	{
		get
		{
			return mOIGAECNEIA_;
		}
		set
		{
			mOIGAECNEIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> POEMNNCCJHI => pOEMNNCCJHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FIMOHHPINNB> NBAODFGCEBF => nBAODFGCEBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPKIJFGKNNJ
	{
		get
		{
			return nPKIJFGKNNJ_;
		}
		set
		{
			nPKIJFGKNNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightSpecialBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightSpecialBattleInfo(BattleGridFightSpecialBattleInfo other)
		: this()
	{
		curLevelId_ = other.curLevelId_;
		lLLLJOFNNNK_ = other.lLLLJOFNNNK_;
		rogueMoney_ = other.rogueMoney_;
		cMMLDCIACAM_ = other.cMMLDCIACAM_.Clone();
		hLFLGAKIGMH_ = other.hLFLGAKIGMH_.Clone();
		eOODMDLONBD_ = other.eOODMDLONBD_.Clone();
		dKLKIABDCCE_ = ((other.dKLKIABDCCE_ != null) ? other.dKLKIABDCCE_.Clone() : null);
		aDJKHCOIJNK_ = other.aDJKHCOIJNK_.Clone();
		gridFightCurLevelExp_ = other.gridFightCurLevelExp_;
		pNICGJBAJIJ_ = other.pNICGJBAJIJ_;
		fIPIEBKDODA_ = other.fIPIEBKDODA_;
		iEPGKLIDHEK_ = other.iEPGKLIDHEK_.Clone();
		jKHPFKDOKLG_ = other.jKHPFKDOKLG_;
		jGOEPADOKEM_ = other.jGOEPADOKEM_;
		iLIIFCFHPBC_ = other.iLIIFCFHPBC_;
		hKEJDHAHIBJ_ = other.hKEJDHAHIBJ_;
		iMKOJKJAHMM_ = other.iMKOJKJAHMM_.Clone();
		bPEOFFPJKAE_ = other.bPEOFFPJKAE_.Clone();
		lGMNJNHIAKA_ = other.lGMNJNHIAKA_.Clone();
		kFLIOPGFPEJ_ = other.kFLIOPGFPEJ_;
		lKLCFINGNIO_ = other.lKLCFINGNIO_;
		kKFPPONDKHH_ = ((other.kKFPPONDKHH_ != null) ? other.kKFPPONDKHH_.Clone() : null);
		gBBKKPCGNLA_ = other.gBBKKPCGNLA_;
		mOIGAECNEIA_ = other.mOIGAECNEIA_;
		pOEMNNCCJHI_ = other.pOEMNNCCJHI_.Clone();
		nBAODFGCEBF_ = other.nBAODFGCEBF_.Clone();
		nPKIJFGKNNJ_ = other.nPKIJFGKNNJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightSpecialBattleInfo Clone()
	{
		return new BattleGridFightSpecialBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleGridFightSpecialBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleGridFightSpecialBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurLevelId != other.CurLevelId)
		{
			return false;
		}
		if (LLLLJOFNNNK != other.LLLLJOFNNNK)
		{
			return false;
		}
		if (RogueMoney != other.RogueMoney)
		{
			return false;
		}
		if (!cMMLDCIACAM_.Equals(other.cMMLDCIACAM_))
		{
			return false;
		}
		if (!hLFLGAKIGMH_.Equals(other.hLFLGAKIGMH_))
		{
			return false;
		}
		if (!eOODMDLONBD_.Equals(other.eOODMDLONBD_))
		{
			return false;
		}
		if (!object.Equals(DKLKIABDCCE, other.DKLKIABDCCE))
		{
			return false;
		}
		if (!aDJKHCOIJNK_.Equals(other.aDJKHCOIJNK_))
		{
			return false;
		}
		if (GridFightCurLevelExp != other.GridFightCurLevelExp)
		{
			return false;
		}
		if (PNICGJBAJIJ != other.PNICGJBAJIJ)
		{
			return false;
		}
		if (FIPIEBKDODA != other.FIPIEBKDODA)
		{
			return false;
		}
		if (!iEPGKLIDHEK_.Equals(other.iEPGKLIDHEK_))
		{
			return false;
		}
		if (JKHPFKDOKLG != other.JKHPFKDOKLG)
		{
			return false;
		}
		if (JGOEPADOKEM != other.JGOEPADOKEM)
		{
			return false;
		}
		if (ILIIFCFHPBC != other.ILIIFCFHPBC)
		{
			return false;
		}
		if (HKEJDHAHIBJ != other.HKEJDHAHIBJ)
		{
			return false;
		}
		if (!iMKOJKJAHMM_.Equals(other.iMKOJKJAHMM_))
		{
			return false;
		}
		if (!bPEOFFPJKAE_.Equals(other.bPEOFFPJKAE_))
		{
			return false;
		}
		if (!lGMNJNHIAKA_.Equals(other.lGMNJNHIAKA_))
		{
			return false;
		}
		if (KFLIOPGFPEJ != other.KFLIOPGFPEJ)
		{
			return false;
		}
		if (LKLCFINGNIO != other.LKLCFINGNIO)
		{
			return false;
		}
		if (!object.Equals(KKFPPONDKHH, other.KKFPPONDKHH))
		{
			return false;
		}
		if (GBBKKPCGNLA != other.GBBKKPCGNLA)
		{
			return false;
		}
		if (MOIGAECNEIA != other.MOIGAECNEIA)
		{
			return false;
		}
		if (!pOEMNNCCJHI_.Equals(other.pOEMNNCCJHI_))
		{
			return false;
		}
		if (!nBAODFGCEBF_.Equals(other.nBAODFGCEBF_))
		{
			return false;
		}
		if (NPKIJFGKNNJ != other.NPKIJFGKNNJ)
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
		if (CurLevelId != 0)
		{
			num ^= CurLevelId.GetHashCode();
		}
		if (LLLLJOFNNNK != 0)
		{
			num ^= LLLLJOFNNNK.GetHashCode();
		}
		if (RogueMoney != 0)
		{
			num ^= RogueMoney.GetHashCode();
		}
		num ^= cMMLDCIACAM_.GetHashCode();
		num ^= hLFLGAKIGMH_.GetHashCode();
		num ^= eOODMDLONBD_.GetHashCode();
		if (dKLKIABDCCE_ != null)
		{
			num ^= DKLKIABDCCE.GetHashCode();
		}
		num ^= aDJKHCOIJNK_.GetHashCode();
		if (GridFightCurLevelExp != 0)
		{
			num ^= GridFightCurLevelExp.GetHashCode();
		}
		if (PNICGJBAJIJ != 0)
		{
			num ^= PNICGJBAJIJ.GetHashCode();
		}
		if (FIPIEBKDODA != 0)
		{
			num ^= FIPIEBKDODA.GetHashCode();
		}
		num ^= iEPGKLIDHEK_.GetHashCode();
		if (JKHPFKDOKLG != 0)
		{
			num ^= JKHPFKDOKLG.GetHashCode();
		}
		if (JGOEPADOKEM != 0)
		{
			num ^= JGOEPADOKEM.GetHashCode();
		}
		if (ILIIFCFHPBC)
		{
			num ^= ILIIFCFHPBC.GetHashCode();
		}
		if (HKEJDHAHIBJ)
		{
			num ^= HKEJDHAHIBJ.GetHashCode();
		}
		num ^= iMKOJKJAHMM_.GetHashCode();
		num ^= bPEOFFPJKAE_.GetHashCode();
		num ^= lGMNJNHIAKA_.GetHashCode();
		if (KFLIOPGFPEJ)
		{
			num ^= KFLIOPGFPEJ.GetHashCode();
		}
		if (LKLCFINGNIO != 0)
		{
			num ^= LKLCFINGNIO.GetHashCode();
		}
		if (kKFPPONDKHH_ != null)
		{
			num ^= KKFPPONDKHH.GetHashCode();
		}
		if (GBBKKPCGNLA != 0)
		{
			num ^= GBBKKPCGNLA.GetHashCode();
		}
		if (MOIGAECNEIA != 0)
		{
			num ^= MOIGAECNEIA.GetHashCode();
		}
		num ^= pOEMNNCCJHI_.GetHashCode();
		num ^= nBAODFGCEBF_.GetHashCode();
		if (NPKIJFGKNNJ != 0)
		{
			num ^= NPKIJFGKNNJ.GetHashCode();
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
		if (CurLevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CurLevelId);
		}
		if (LLLLJOFNNNK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LLLLJOFNNNK);
		}
		if (RogueMoney != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(RogueMoney);
		}
		cMMLDCIACAM_.WriteTo(ref output, _repeated_cMMLDCIACAM_codec);
		hLFLGAKIGMH_.WriteTo(ref output, _repeated_hLFLGAKIGMH_codec);
		eOODMDLONBD_.WriteTo(ref output, _repeated_eOODMDLONBD_codec);
		if (dKLKIABDCCE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(DKLKIABDCCE);
		}
		aDJKHCOIJNK_.WriteTo(ref output, _repeated_aDJKHCOIJNK_codec);
		if (GridFightCurLevelExp != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GridFightCurLevelExp);
		}
		if (PNICGJBAJIJ != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PNICGJBAJIJ);
		}
		if (FIPIEBKDODA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FIPIEBKDODA);
		}
		iEPGKLIDHEK_.WriteTo(ref output, _repeated_iEPGKLIDHEK_codec);
		if (JKHPFKDOKLG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JKHPFKDOKLG);
		}
		if (JGOEPADOKEM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JGOEPADOKEM);
		}
		if (ILIIFCFHPBC)
		{
			output.WriteRawTag(120);
			output.WriteBool(ILIIFCFHPBC);
		}
		if (HKEJDHAHIBJ)
		{
			output.WriteRawTag(128, 1);
			output.WriteBool(HKEJDHAHIBJ);
		}
		iMKOJKJAHMM_.WriteTo(ref output, _repeated_iMKOJKJAHMM_codec);
		bPEOFFPJKAE_.WriteTo(ref output, _repeated_bPEOFFPJKAE_codec);
		lGMNJNHIAKA_.WriteTo(ref output, _repeated_lGMNJNHIAKA_codec);
		if (KFLIOPGFPEJ)
		{
			output.WriteRawTag(160, 1);
			output.WriteBool(KFLIOPGFPEJ);
		}
		if (LKLCFINGNIO != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteUInt32(LKLCFINGNIO);
		}
		if (kKFPPONDKHH_ != null)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(KKFPPONDKHH);
		}
		if (GBBKKPCGNLA != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteUInt32(GBBKKPCGNLA);
		}
		if (MOIGAECNEIA != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteUInt32(MOIGAECNEIA);
		}
		pOEMNNCCJHI_.WriteTo(ref output, _repeated_pOEMNNCCJHI_codec);
		nBAODFGCEBF_.WriteTo(ref output, _repeated_nBAODFGCEBF_codec);
		if (NPKIJFGKNNJ != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteUInt32(NPKIJFGKNNJ);
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
		if (CurLevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurLevelId);
		}
		if (LLLLJOFNNNK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLLLJOFNNNK);
		}
		if (RogueMoney != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueMoney);
		}
		num += cMMLDCIACAM_.CalculateSize(_repeated_cMMLDCIACAM_codec);
		num += hLFLGAKIGMH_.CalculateSize(_repeated_hLFLGAKIGMH_codec);
		num += eOODMDLONBD_.CalculateSize(_repeated_eOODMDLONBD_codec);
		if (dKLKIABDCCE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DKLKIABDCCE);
		}
		num += aDJKHCOIJNK_.CalculateSize(_repeated_aDJKHCOIJNK_codec);
		if (GridFightCurLevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightCurLevelExp);
		}
		if (PNICGJBAJIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNICGJBAJIJ);
		}
		if (FIPIEBKDODA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIPIEBKDODA);
		}
		num += iEPGKLIDHEK_.CalculateSize(_repeated_iEPGKLIDHEK_codec);
		if (JKHPFKDOKLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKHPFKDOKLG);
		}
		if (JGOEPADOKEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGOEPADOKEM);
		}
		if (ILIIFCFHPBC)
		{
			num += 2;
		}
		if (HKEJDHAHIBJ)
		{
			num += 3;
		}
		num += iMKOJKJAHMM_.CalculateSize(_repeated_iMKOJKJAHMM_codec);
		num += bPEOFFPJKAE_.CalculateSize(_repeated_bPEOFFPJKAE_codec);
		num += lGMNJNHIAKA_.CalculateSize(_repeated_lGMNJNHIAKA_codec);
		if (KFLIOPGFPEJ)
		{
			num += 3;
		}
		if (LKLCFINGNIO != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LKLCFINGNIO);
		}
		if (kKFPPONDKHH_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KKFPPONDKHH);
		}
		if (GBBKKPCGNLA != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GBBKKPCGNLA);
		}
		if (MOIGAECNEIA != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MOIGAECNEIA);
		}
		num += pOEMNNCCJHI_.CalculateSize(_repeated_pOEMNNCCJHI_codec);
		num += nBAODFGCEBF_.CalculateSize(_repeated_nBAODFGCEBF_codec);
		if (NPKIJFGKNNJ != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NPKIJFGKNNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleGridFightSpecialBattleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CurLevelId != 0)
		{
			CurLevelId = other.CurLevelId;
		}
		if (other.LLLLJOFNNNK != 0)
		{
			LLLLJOFNNNK = other.LLLLJOFNNNK;
		}
		if (other.RogueMoney != 0)
		{
			RogueMoney = other.RogueMoney;
		}
		cMMLDCIACAM_.Add(other.cMMLDCIACAM_);
		hLFLGAKIGMH_.Add(other.hLFLGAKIGMH_);
		eOODMDLONBD_.Add(other.eOODMDLONBD_);
		if (other.dKLKIABDCCE_ != null)
		{
			if (dKLKIABDCCE_ == null)
			{
				DKLKIABDCCE = new FIGHICNEPFI();
			}
			DKLKIABDCCE.MergeFrom(other.DKLKIABDCCE);
		}
		aDJKHCOIJNK_.Add(other.aDJKHCOIJNK_);
		if (other.GridFightCurLevelExp != 0)
		{
			GridFightCurLevelExp = other.GridFightCurLevelExp;
		}
		if (other.PNICGJBAJIJ != 0)
		{
			PNICGJBAJIJ = other.PNICGJBAJIJ;
		}
		if (other.FIPIEBKDODA != 0)
		{
			FIPIEBKDODA = other.FIPIEBKDODA;
		}
		iEPGKLIDHEK_.Add(other.iEPGKLIDHEK_);
		if (other.JKHPFKDOKLG != 0)
		{
			JKHPFKDOKLG = other.JKHPFKDOKLG;
		}
		if (other.JGOEPADOKEM != 0)
		{
			JGOEPADOKEM = other.JGOEPADOKEM;
		}
		if (other.ILIIFCFHPBC)
		{
			ILIIFCFHPBC = other.ILIIFCFHPBC;
		}
		if (other.HKEJDHAHIBJ)
		{
			HKEJDHAHIBJ = other.HKEJDHAHIBJ;
		}
		iMKOJKJAHMM_.Add(other.iMKOJKJAHMM_);
		bPEOFFPJKAE_.Add(other.bPEOFFPJKAE_);
		lGMNJNHIAKA_.Add(other.lGMNJNHIAKA_);
		if (other.KFLIOPGFPEJ)
		{
			KFLIOPGFPEJ = other.KFLIOPGFPEJ;
		}
		if (other.LKLCFINGNIO != 0)
		{
			LKLCFINGNIO = other.LKLCFINGNIO;
		}
		if (other.kKFPPONDKHH_ != null)
		{
			if (kKFPPONDKHH_ == null)
			{
				KKFPPONDKHH = new KFOLIJCNDBK();
			}
			KKFPPONDKHH.MergeFrom(other.KKFPPONDKHH);
		}
		if (other.GBBKKPCGNLA != 0)
		{
			GBBKKPCGNLA = other.GBBKKPCGNLA;
		}
		if (other.MOIGAECNEIA != 0)
		{
			MOIGAECNEIA = other.MOIGAECNEIA;
		}
		pOEMNNCCJHI_.Add(other.pOEMNNCCJHI_);
		nBAODFGCEBF_.Add(other.nBAODFGCEBF_);
		if (other.NPKIJFGKNNJ != 0)
		{
			NPKIJFGKNNJ = other.NPKIJFGKNNJ;
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
				CurLevelId = input.ReadUInt32();
				break;
			case 16u:
				LLLLJOFNNNK = input.ReadUInt32();
				break;
			case 24u:
				RogueMoney = input.ReadUInt32();
				break;
			case 34u:
				cMMLDCIACAM_.AddEntriesFrom(ref input, _repeated_cMMLDCIACAM_codec);
				break;
			case 42u:
				hLFLGAKIGMH_.AddEntriesFrom(ref input, _repeated_hLFLGAKIGMH_codec);
				break;
			case 48u:
			case 50u:
				eOODMDLONBD_.AddEntriesFrom(ref input, _repeated_eOODMDLONBD_codec);
				break;
			case 58u:
				if (dKLKIABDCCE_ == null)
				{
					DKLKIABDCCE = new FIGHICNEPFI();
				}
				input.ReadMessage(DKLKIABDCCE);
				break;
			case 64u:
			case 66u:
				aDJKHCOIJNK_.AddEntriesFrom(ref input, _repeated_aDJKHCOIJNK_codec);
				break;
			case 72u:
				GridFightCurLevelExp = input.ReadUInt32();
				break;
			case 80u:
				PNICGJBAJIJ = input.ReadUInt32();
				break;
			case 88u:
				FIPIEBKDODA = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				iEPGKLIDHEK_.AddEntriesFrom(ref input, _repeated_iEPGKLIDHEK_codec);
				break;
			case 104u:
				JKHPFKDOKLG = input.ReadUInt32();
				break;
			case 112u:
				JGOEPADOKEM = input.ReadUInt32();
				break;
			case 120u:
				ILIIFCFHPBC = input.ReadBool();
				break;
			case 128u:
				HKEJDHAHIBJ = input.ReadBool();
				break;
			case 138u:
				iMKOJKJAHMM_.AddEntriesFrom(ref input, _repeated_iMKOJKJAHMM_codec);
				break;
			case 146u:
				bPEOFFPJKAE_.AddEntriesFrom(ref input, _repeated_bPEOFFPJKAE_codec);
				break;
			case 152u:
			case 154u:
				lGMNJNHIAKA_.AddEntriesFrom(ref input, _repeated_lGMNJNHIAKA_codec);
				break;
			case 160u:
				KFLIOPGFPEJ = input.ReadBool();
				break;
			case 168u:
				LKLCFINGNIO = input.ReadUInt32();
				break;
			case 178u:
				if (kKFPPONDKHH_ == null)
				{
					KKFPPONDKHH = new KFOLIJCNDBK();
				}
				input.ReadMessage(KKFPPONDKHH);
				break;
			case 184u:
				GBBKKPCGNLA = input.ReadUInt32();
				break;
			case 192u:
				MOIGAECNEIA = input.ReadUInt32();
				break;
			case 200u:
			case 202u:
				pOEMNNCCJHI_.AddEntriesFrom(ref input, _repeated_pOEMNNCCJHI_codec);
				break;
			case 210u:
				nBAODFGCEBF_.AddEntriesFrom(ref input, _repeated_nBAODFGCEBF_codec);
				break;
			case 216u:
				NPKIJFGKNNJ = input.ReadUInt32();
				break;
			}
		}
	}
}
