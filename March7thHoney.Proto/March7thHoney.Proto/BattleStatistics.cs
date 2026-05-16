using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleStatistics : IMessage<BattleStatistics>, IMessage, IEquatable<BattleStatistics>, IDeepCloneable<BattleStatistics>, IBufferMessage
{
	private static readonly MessageParser<BattleStatistics> _parser = new MessageParser<BattleStatistics>(() => new BattleStatistics());

	private UnknownFieldSet _unknownFields;

	public const int TotalBattleTurnsFieldNumber = 1;

	private uint totalBattleTurns_;

	public const int TotalAutoTurnsFieldNumber = 2;

	private uint totalAutoTurns_;

	public const int AvatarIdListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int UltraCntFieldNumber = 4;

	private uint ultraCnt_;

	public const int TotalDelayCumulateFieldNumber = 5;

	private double totalDelayCumulate_;

	public const int CostTimeFieldNumber = 6;

	private double costTime_;

	public const int BattleAvatarListFieldNumber = 7;

	private static readonly FieldCodec<AvatarBattleInfo> _repeated_battleAvatarList_codec = FieldCodec.ForMessage(58u, AvatarBattleInfo.Parser);

	private readonly RepeatedField<AvatarBattleInfo> battleAvatarList_ = new RepeatedField<AvatarBattleInfo>();

	public const int MonsterListFieldNumber = 8;

	private static readonly FieldCodec<MonsterBattleInfo> _repeated_monsterList_codec = FieldCodec.ForMessage(66u, MonsterBattleInfo.Parser);

	private readonly RepeatedField<MonsterBattleInfo> monsterList_ = new RepeatedField<MonsterBattleInfo>();

	public const int RoundCntFieldNumber = 9;

	private uint roundCnt_;

	public const int CocoonDeadWaveFieldNumber = 10;

	private uint cocoonDeadWave_;

	public const int AvatarBattleTurnsFieldNumber = 11;

	private uint avatarBattleTurns_;

	public const int MonsterBattleTurnsFieldNumber = 12;

	private uint monsterBattleTurns_;

	public const int CustomValuesFieldNumber = 13;

	private static readonly MapField<string, float>.Codec _map_customValues_codec = new MapField<string, float>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForFloat(21u, 0f), 106u);

	private readonly MapField<string, float> customValues_ = new MapField<string, float>();

	public const int ChallengeScoreFieldNumber = 14;

	private uint challengeScore_;

	public const int PNHEDOLHBJLFieldNumber = 16;

	private static readonly FieldCodec<BattleEventBattleInfo> _repeated_pNHEDOLHBJL_codec = FieldCodec.ForMessage(130u, BattleEventBattleInfo.Parser);

	private readonly RepeatedField<BattleEventBattleInfo> pNHEDOLHBJL_ = new RepeatedField<BattleEventBattleInfo>();

	public const int EndReasonFieldNumber = 19;

	private BattleEndReason endReason_;

	public const int OMDMJICGKBBFieldNumber = 21;

	private static readonly FieldCodec<MIGJFGJMCGO> _repeated_oMDMJICGKBB_codec = FieldCodec.ForMessage(170u, MIGJFGJMCGO.Parser);

	private readonly RepeatedField<MIGJFGJMCGO> oMDMJICGKBB_ = new RepeatedField<MIGJFGJMCGO>();

	public const int KAIDFMEJIFIFieldNumber = 22;

	private static readonly FieldCodec<int> _repeated_kAIDFMEJIFI_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> kAIDFMEJIFI_ = new RepeatedField<int>();

	public const int MOAJOPEJOPJFieldNumber = 23;

	private static readonly FieldCodec<CMJBMFHCOFI> _repeated_mOAJOPEJOPJ_codec = FieldCodec.ForMessage(186u, CMJBMFHCOFI.Parser);

	private readonly RepeatedField<CMJBMFHCOFI> mOAJOPEJOPJ_ = new RepeatedField<CMJBMFHCOFI>();

	public const int JKOBHNPGMHCFieldNumber = 26;

	private static readonly FieldCodec<StatisticEvent> _repeated_jKOBHNPGMHC_codec = FieldCodec.ForMessage(210u, StatisticEvent.Parser);

	private readonly RepeatedField<StatisticEvent> jKOBHNPGMHC_ = new RepeatedField<StatisticEvent>();

	public const int NHDDFCAIEGDFieldNumber = 27;

	private static readonly FieldCodec<DLFPFFOOHKP> _repeated_nHDDFCAIEGD_codec = FieldCodec.ForMessage(218u, DLFPFFOOHKP.Parser);

	private readonly RepeatedField<DLFPFFOOHKP> nHDDFCAIEGD_ = new RepeatedField<DLFPFFOOHKP>();

	public const int BattleTargetInfoFieldNumber = 28;

	private static readonly MapField<uint, BattleTargetList>.Codec _map_battleTargetInfo_codec = new MapField<uint, BattleTargetList>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, BattleTargetList.Parser), 226u);

	private readonly MapField<uint, BattleTargetList> battleTargetInfo_ = new MapField<uint, BattleTargetList>();

	public const int DDDCFCAAJHCFieldNumber = 29;

	private static readonly FieldCodec<NJCOFDJNMML> _repeated_dDDCFCAAJHC_codec = FieldCodec.ForMessage(234u, NJCOFDJNMML.Parser);

	private readonly RepeatedField<NJCOFDJNMML> dDDCFCAAJHC_ = new RepeatedField<NJCOFDJNMML>();

	public const int FMCJPPILPLLFieldNumber = 30;

	private BattleGridFightSpecialBattleInfo fMCJPPILPLL_;

	public const int COIGGPCPLHGFieldNumber = 31;

	private FAGCFBEBKEO cOIGGPCPLHG_;

	public const int NAJPMGFJKEOFieldNumber = 32;

	private bool nAJPMGFJKEO_;

	public const int HOBNHBCJIDMFieldNumber = 33;

	private static readonly FieldCodec<LOCPKDNGLKM> _repeated_hOBNHBCJIDM_codec = FieldCodec.ForMessage(266u, LOCPKDNGLKM.Parser);

	private readonly RepeatedField<LOCPKDNGLKM> hOBNHBCJIDM_ = new RepeatedField<LOCPKDNGLKM>();

	public const int KKJHGIAADKOFieldNumber = 34;

	private static readonly FieldCodec<BEGMHEEKGIF> _repeated_kKJHGIAADKO_codec = FieldCodec.ForMessage(274u, BEGMHEEKGIF.Parser);

	private readonly RepeatedField<BEGMHEEKGIF> kKJHGIAADKO_ = new RepeatedField<BEGMHEEKGIF>();

	public const int JFGLNIOEEHLFieldNumber = 35;

	private uint jFGLNIOEEHL_;

	public const int BKGBAEGPLMMFieldNumber = 36;

	private DCFMPNBKKPF bKGBAEGPLMM_;

	public const int MEFGDGFLFMDFieldNumber = 37;

	private LFPNDKKDEKN mEFGDGFLFMD_;

	public const int NLAJOMBNHNAFieldNumber = 38;

	private JNADLLIIIFP nLAJOMBNHNA_;

	public const int CEAIJOPGBAMFieldNumber = 39;

	private FPFFHGOKBNK cEAIJOPGBAM_;

	public const int JPEOCICGPDOFieldNumber = 40;

	private KFKHGLEFDKK jPEOCICGPDO_;

	public const int KGKFADDEGNJFieldNumber = 41;

	private uint kGKFADDEGNJ_;

	public const int IKEIDHHMFOOFieldNumber = 42;

	private static readonly FieldCodec<BattleAvatarGlobalBuffInfo> _repeated_iKEIDHHMFOO_codec = FieldCodec.ForMessage(338u, BattleAvatarGlobalBuffInfo.Parser);

	private readonly RepeatedField<BattleAvatarGlobalBuffInfo> iKEIDHHMFOO_ = new RepeatedField<BattleAvatarGlobalBuffInfo>();

	public const int OGPOFMOGPIPFieldNumber = 43;

	private LEHCCNGFKGM oGPOFMOGPIP_;

	public const int LFHEJDDHFNDFieldNumber = 44;

	private static readonly FieldCodec<uint> _repeated_lFHEJDDHFND_codec = FieldCodec.ForUInt32(354u);

	private readonly RepeatedField<uint> lFHEJDDHFND_ = new RepeatedField<uint>();

	public const int ANMBAIFOBJPFieldNumber = 45;

	private static readonly FieldCodec<uint> _repeated_aNMBAIFOBJP_codec = FieldCodec.ForUInt32(362u);

	private readonly RepeatedField<uint> aNMBAIFOBJP_ = new RepeatedField<uint>();

	public const int IPKFMFDOPGNFieldNumber = 46;

	private PPNEGMCIECE iPKFMFDOPGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleStatistics> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleStatisticsReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalBattleTurns
	{
		get
		{
			return totalBattleTurns_;
		}
		set
		{
			totalBattleTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalAutoTurns
	{
		get
		{
			return totalAutoTurns_;
		}
		set
		{
			totalAutoTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UltraCnt
	{
		get
		{
			return ultraCnt_;
		}
		set
		{
			ultraCnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDelayCumulate
	{
		get
		{
			return totalDelayCumulate_;
		}
		set
		{
			totalDelayCumulate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarBattleInfo> BattleAvatarList => battleAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterBattleInfo> MonsterList => monsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoundCnt
	{
		get
		{
			return roundCnt_;
		}
		set
		{
			roundCnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CocoonDeadWave
	{
		get
		{
			return cocoonDeadWave_;
		}
		set
		{
			cocoonDeadWave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarBattleTurns
	{
		get
		{
			return avatarBattleTurns_;
		}
		set
		{
			avatarBattleTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterBattleTurns
	{
		get
		{
			return monsterBattleTurns_;
		}
		set
		{
			monsterBattleTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, float> CustomValues => customValues_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeScore
	{
		get
		{
			return challengeScore_;
		}
		set
		{
			challengeScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleEventBattleInfo> PNHEDOLHBJL => pNHEDOLHBJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndReason EndReason
	{
		get
		{
			return endReason_;
		}
		set
		{
			endReason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MIGJFGJMCGO> OMDMJICGKBB => oMDMJICGKBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> KAIDFMEJIFI => kAIDFMEJIFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CMJBMFHCOFI> MOAJOPEJOPJ => mOAJOPEJOPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<StatisticEvent> JKOBHNPGMHC => jKOBHNPGMHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DLFPFFOOHKP> NHDDFCAIEGD => nHDDFCAIEGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, BattleTargetList> BattleTargetInfo => battleTargetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NJCOFDJNMML> DDDCFCAAJHC => dDDCFCAAJHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightSpecialBattleInfo FMCJPPILPLL
	{
		get
		{
			return fMCJPPILPLL_;
		}
		set
		{
			fMCJPPILPLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAGCFBEBKEO COIGGPCPLHG
	{
		get
		{
			return cOIGGPCPLHG_;
		}
		set
		{
			cOIGGPCPLHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NAJPMGFJKEO
	{
		get
		{
			return nAJPMGFJKEO_;
		}
		set
		{
			nAJPMGFJKEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LOCPKDNGLKM> HOBNHBCJIDM => hOBNHBCJIDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BEGMHEEKGIF> KKJHGIAADKO => kKJHGIAADKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFGLNIOEEHL
	{
		get
		{
			return jFGLNIOEEHL_;
		}
		set
		{
			jFGLNIOEEHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCFMPNBKKPF BKGBAEGPLMM
	{
		get
		{
			return bKGBAEGPLMM_;
		}
		set
		{
			bKGBAEGPLMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFPNDKKDEKN MEFGDGFLFMD
	{
		get
		{
			return mEFGDGFLFMD_;
		}
		set
		{
			mEFGDGFLFMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNADLLIIIFP NLAJOMBNHNA
	{
		get
		{
			return nLAJOMBNHNA_;
		}
		set
		{
			nLAJOMBNHNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFFHGOKBNK CEAIJOPGBAM
	{
		get
		{
			return cEAIJOPGBAM_;
		}
		set
		{
			cEAIJOPGBAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKHGLEFDKK JPEOCICGPDO
	{
		get
		{
			return jPEOCICGPDO_;
		}
		set
		{
			jPEOCICGPDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGKFADDEGNJ
	{
		get
		{
			return kGKFADDEGNJ_;
		}
		set
		{
			kGKFADDEGNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleAvatarGlobalBuffInfo> IKEIDHHMFOO => iKEIDHHMFOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHCCNGFKGM OGPOFMOGPIP
	{
		get
		{
			return oGPOFMOGPIP_;
		}
		set
		{
			oGPOFMOGPIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LFHEJDDHFND => lFHEJDDHFND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ANMBAIFOBJP => aNMBAIFOBJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPNEGMCIECE IPKFMFDOPGN
	{
		get
		{
			return iPKFMFDOPGN_;
		}
		set
		{
			iPKFMFDOPGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics(BattleStatistics other)
		: this()
	{
		totalBattleTurns_ = other.totalBattleTurns_;
		totalAutoTurns_ = other.totalAutoTurns_;
		avatarIdList_ = other.avatarIdList_.Clone();
		ultraCnt_ = other.ultraCnt_;
		totalDelayCumulate_ = other.totalDelayCumulate_;
		costTime_ = other.costTime_;
		battleAvatarList_ = other.battleAvatarList_.Clone();
		monsterList_ = other.monsterList_.Clone();
		roundCnt_ = other.roundCnt_;
		cocoonDeadWave_ = other.cocoonDeadWave_;
		avatarBattleTurns_ = other.avatarBattleTurns_;
		monsterBattleTurns_ = other.monsterBattleTurns_;
		customValues_ = other.customValues_.Clone();
		challengeScore_ = other.challengeScore_;
		pNHEDOLHBJL_ = other.pNHEDOLHBJL_.Clone();
		endReason_ = other.endReason_;
		oMDMJICGKBB_ = other.oMDMJICGKBB_.Clone();
		kAIDFMEJIFI_ = other.kAIDFMEJIFI_.Clone();
		mOAJOPEJOPJ_ = other.mOAJOPEJOPJ_.Clone();
		jKOBHNPGMHC_ = other.jKOBHNPGMHC_.Clone();
		nHDDFCAIEGD_ = other.nHDDFCAIEGD_.Clone();
		battleTargetInfo_ = other.battleTargetInfo_.Clone();
		dDDCFCAAJHC_ = other.dDDCFCAAJHC_.Clone();
		fMCJPPILPLL_ = ((other.fMCJPPILPLL_ != null) ? other.fMCJPPILPLL_.Clone() : null);
		cOIGGPCPLHG_ = ((other.cOIGGPCPLHG_ != null) ? other.cOIGGPCPLHG_.Clone() : null);
		nAJPMGFJKEO_ = other.nAJPMGFJKEO_;
		hOBNHBCJIDM_ = other.hOBNHBCJIDM_.Clone();
		kKJHGIAADKO_ = other.kKJHGIAADKO_.Clone();
		jFGLNIOEEHL_ = other.jFGLNIOEEHL_;
		bKGBAEGPLMM_ = ((other.bKGBAEGPLMM_ != null) ? other.bKGBAEGPLMM_.Clone() : null);
		mEFGDGFLFMD_ = ((other.mEFGDGFLFMD_ != null) ? other.mEFGDGFLFMD_.Clone() : null);
		nLAJOMBNHNA_ = ((other.nLAJOMBNHNA_ != null) ? other.nLAJOMBNHNA_.Clone() : null);
		cEAIJOPGBAM_ = ((other.cEAIJOPGBAM_ != null) ? other.cEAIJOPGBAM_.Clone() : null);
		jPEOCICGPDO_ = ((other.jPEOCICGPDO_ != null) ? other.jPEOCICGPDO_.Clone() : null);
		kGKFADDEGNJ_ = other.kGKFADDEGNJ_;
		iKEIDHHMFOO_ = other.iKEIDHHMFOO_.Clone();
		oGPOFMOGPIP_ = ((other.oGPOFMOGPIP_ != null) ? other.oGPOFMOGPIP_.Clone() : null);
		lFHEJDDHFND_ = other.lFHEJDDHFND_.Clone();
		aNMBAIFOBJP_ = other.aNMBAIFOBJP_.Clone();
		iPKFMFDOPGN_ = ((other.iPKFMFDOPGN_ != null) ? other.iPKFMFDOPGN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics Clone()
	{
		return new BattleStatistics(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleStatistics);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleStatistics other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TotalBattleTurns != other.TotalBattleTurns)
		{
			return false;
		}
		if (TotalAutoTurns != other.TotalAutoTurns)
		{
			return false;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (UltraCnt != other.UltraCnt)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDelayCumulate, other.TotalDelayCumulate))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CostTime, other.CostTime))
		{
			return false;
		}
		if (!battleAvatarList_.Equals(other.battleAvatarList_))
		{
			return false;
		}
		if (!monsterList_.Equals(other.monsterList_))
		{
			return false;
		}
		if (RoundCnt != other.RoundCnt)
		{
			return false;
		}
		if (CocoonDeadWave != other.CocoonDeadWave)
		{
			return false;
		}
		if (AvatarBattleTurns != other.AvatarBattleTurns)
		{
			return false;
		}
		if (MonsterBattleTurns != other.MonsterBattleTurns)
		{
			return false;
		}
		if (!CustomValues.Equals(other.CustomValues))
		{
			return false;
		}
		if (ChallengeScore != other.ChallengeScore)
		{
			return false;
		}
		if (!pNHEDOLHBJL_.Equals(other.pNHEDOLHBJL_))
		{
			return false;
		}
		if (EndReason != other.EndReason)
		{
			return false;
		}
		if (!oMDMJICGKBB_.Equals(other.oMDMJICGKBB_))
		{
			return false;
		}
		if (!kAIDFMEJIFI_.Equals(other.kAIDFMEJIFI_))
		{
			return false;
		}
		if (!mOAJOPEJOPJ_.Equals(other.mOAJOPEJOPJ_))
		{
			return false;
		}
		if (!jKOBHNPGMHC_.Equals(other.jKOBHNPGMHC_))
		{
			return false;
		}
		if (!nHDDFCAIEGD_.Equals(other.nHDDFCAIEGD_))
		{
			return false;
		}
		if (!BattleTargetInfo.Equals(other.BattleTargetInfo))
		{
			return false;
		}
		if (!dDDCFCAAJHC_.Equals(other.dDDCFCAAJHC_))
		{
			return false;
		}
		if (!object.Equals(FMCJPPILPLL, other.FMCJPPILPLL))
		{
			return false;
		}
		if (!object.Equals(COIGGPCPLHG, other.COIGGPCPLHG))
		{
			return false;
		}
		if (NAJPMGFJKEO != other.NAJPMGFJKEO)
		{
			return false;
		}
		if (!hOBNHBCJIDM_.Equals(other.hOBNHBCJIDM_))
		{
			return false;
		}
		if (!kKJHGIAADKO_.Equals(other.kKJHGIAADKO_))
		{
			return false;
		}
		if (JFGLNIOEEHL != other.JFGLNIOEEHL)
		{
			return false;
		}
		if (!object.Equals(BKGBAEGPLMM, other.BKGBAEGPLMM))
		{
			return false;
		}
		if (!object.Equals(MEFGDGFLFMD, other.MEFGDGFLFMD))
		{
			return false;
		}
		if (!object.Equals(NLAJOMBNHNA, other.NLAJOMBNHNA))
		{
			return false;
		}
		if (!object.Equals(CEAIJOPGBAM, other.CEAIJOPGBAM))
		{
			return false;
		}
		if (!object.Equals(JPEOCICGPDO, other.JPEOCICGPDO))
		{
			return false;
		}
		if (KGKFADDEGNJ != other.KGKFADDEGNJ)
		{
			return false;
		}
		if (!iKEIDHHMFOO_.Equals(other.iKEIDHHMFOO_))
		{
			return false;
		}
		if (!object.Equals(OGPOFMOGPIP, other.OGPOFMOGPIP))
		{
			return false;
		}
		if (!lFHEJDDHFND_.Equals(other.lFHEJDDHFND_))
		{
			return false;
		}
		if (!aNMBAIFOBJP_.Equals(other.aNMBAIFOBJP_))
		{
			return false;
		}
		if (!object.Equals(IPKFMFDOPGN, other.IPKFMFDOPGN))
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
		if (TotalBattleTurns != 0)
		{
			num ^= TotalBattleTurns.GetHashCode();
		}
		if (TotalAutoTurns != 0)
		{
			num ^= TotalAutoTurns.GetHashCode();
		}
		num ^= avatarIdList_.GetHashCode();
		if (UltraCnt != 0)
		{
			num ^= UltraCnt.GetHashCode();
		}
		if (TotalDelayCumulate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDelayCumulate);
		}
		if (CostTime != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CostTime);
		}
		num ^= battleAvatarList_.GetHashCode();
		num ^= monsterList_.GetHashCode();
		if (RoundCnt != 0)
		{
			num ^= RoundCnt.GetHashCode();
		}
		if (CocoonDeadWave != 0)
		{
			num ^= CocoonDeadWave.GetHashCode();
		}
		if (AvatarBattleTurns != 0)
		{
			num ^= AvatarBattleTurns.GetHashCode();
		}
		if (MonsterBattleTurns != 0)
		{
			num ^= MonsterBattleTurns.GetHashCode();
		}
		num ^= CustomValues.GetHashCode();
		if (ChallengeScore != 0)
		{
			num ^= ChallengeScore.GetHashCode();
		}
		num ^= pNHEDOLHBJL_.GetHashCode();
		if (EndReason != BattleEndReason.None)
		{
			num ^= EndReason.GetHashCode();
		}
		num ^= oMDMJICGKBB_.GetHashCode();
		num ^= kAIDFMEJIFI_.GetHashCode();
		num ^= mOAJOPEJOPJ_.GetHashCode();
		num ^= jKOBHNPGMHC_.GetHashCode();
		num ^= nHDDFCAIEGD_.GetHashCode();
		num ^= BattleTargetInfo.GetHashCode();
		num ^= dDDCFCAAJHC_.GetHashCode();
		if (fMCJPPILPLL_ != null)
		{
			num ^= FMCJPPILPLL.GetHashCode();
		}
		if (cOIGGPCPLHG_ != null)
		{
			num ^= COIGGPCPLHG.GetHashCode();
		}
		if (NAJPMGFJKEO)
		{
			num ^= NAJPMGFJKEO.GetHashCode();
		}
		num ^= hOBNHBCJIDM_.GetHashCode();
		num ^= kKJHGIAADKO_.GetHashCode();
		if (JFGLNIOEEHL != 0)
		{
			num ^= JFGLNIOEEHL.GetHashCode();
		}
		if (bKGBAEGPLMM_ != null)
		{
			num ^= BKGBAEGPLMM.GetHashCode();
		}
		if (mEFGDGFLFMD_ != null)
		{
			num ^= MEFGDGFLFMD.GetHashCode();
		}
		if (nLAJOMBNHNA_ != null)
		{
			num ^= NLAJOMBNHNA.GetHashCode();
		}
		if (cEAIJOPGBAM_ != null)
		{
			num ^= CEAIJOPGBAM.GetHashCode();
		}
		if (jPEOCICGPDO_ != null)
		{
			num ^= JPEOCICGPDO.GetHashCode();
		}
		if (KGKFADDEGNJ != 0)
		{
			num ^= KGKFADDEGNJ.GetHashCode();
		}
		num ^= iKEIDHHMFOO_.GetHashCode();
		if (oGPOFMOGPIP_ != null)
		{
			num ^= OGPOFMOGPIP.GetHashCode();
		}
		num ^= lFHEJDDHFND_.GetHashCode();
		num ^= aNMBAIFOBJP_.GetHashCode();
		if (iPKFMFDOPGN_ != null)
		{
			num ^= IPKFMFDOPGN.GetHashCode();
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
		if (TotalBattleTurns != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TotalBattleTurns);
		}
		if (TotalAutoTurns != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(TotalAutoTurns);
		}
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		if (UltraCnt != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(UltraCnt);
		}
		if (TotalDelayCumulate != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(TotalDelayCumulate);
		}
		if (CostTime != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(CostTime);
		}
		battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
		monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
		if (RoundCnt != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RoundCnt);
		}
		if (CocoonDeadWave != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CocoonDeadWave);
		}
		if (AvatarBattleTurns != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AvatarBattleTurns);
		}
		if (MonsterBattleTurns != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MonsterBattleTurns);
		}
		customValues_.WriteTo(ref output, _map_customValues_codec);
		if (ChallengeScore != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ChallengeScore);
		}
		pNHEDOLHBJL_.WriteTo(ref output, _repeated_pNHEDOLHBJL_codec);
		if (EndReason != BattleEndReason.None)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)EndReason);
		}
		oMDMJICGKBB_.WriteTo(ref output, _repeated_oMDMJICGKBB_codec);
		kAIDFMEJIFI_.WriteTo(ref output, _repeated_kAIDFMEJIFI_codec);
		mOAJOPEJOPJ_.WriteTo(ref output, _repeated_mOAJOPEJOPJ_codec);
		jKOBHNPGMHC_.WriteTo(ref output, _repeated_jKOBHNPGMHC_codec);
		nHDDFCAIEGD_.WriteTo(ref output, _repeated_nHDDFCAIEGD_codec);
		battleTargetInfo_.WriteTo(ref output, _map_battleTargetInfo_codec);
		dDDCFCAAJHC_.WriteTo(ref output, _repeated_dDDCFCAAJHC_codec);
		if (fMCJPPILPLL_ != null)
		{
			output.WriteRawTag(242, 1);
			output.WriteMessage(FMCJPPILPLL);
		}
		if (cOIGGPCPLHG_ != null)
		{
			output.WriteRawTag(250, 1);
			output.WriteMessage(COIGGPCPLHG);
		}
		if (NAJPMGFJKEO)
		{
			output.WriteRawTag(128, 2);
			output.WriteBool(NAJPMGFJKEO);
		}
		hOBNHBCJIDM_.WriteTo(ref output, _repeated_hOBNHBCJIDM_codec);
		kKJHGIAADKO_.WriteTo(ref output, _repeated_kKJHGIAADKO_codec);
		if (JFGLNIOEEHL != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteUInt32(JFGLNIOEEHL);
		}
		if (bKGBAEGPLMM_ != null)
		{
			output.WriteRawTag(162, 2);
			output.WriteMessage(BKGBAEGPLMM);
		}
		if (mEFGDGFLFMD_ != null)
		{
			output.WriteRawTag(170, 2);
			output.WriteMessage(MEFGDGFLFMD);
		}
		if (nLAJOMBNHNA_ != null)
		{
			output.WriteRawTag(178, 2);
			output.WriteMessage(NLAJOMBNHNA);
		}
		if (cEAIJOPGBAM_ != null)
		{
			output.WriteRawTag(186, 2);
			output.WriteMessage(CEAIJOPGBAM);
		}
		if (jPEOCICGPDO_ != null)
		{
			output.WriteRawTag(194, 2);
			output.WriteMessage(JPEOCICGPDO);
		}
		if (KGKFADDEGNJ != 0)
		{
			output.WriteRawTag(200, 2);
			output.WriteUInt32(KGKFADDEGNJ);
		}
		iKEIDHHMFOO_.WriteTo(ref output, _repeated_iKEIDHHMFOO_codec);
		if (oGPOFMOGPIP_ != null)
		{
			output.WriteRawTag(218, 2);
			output.WriteMessage(OGPOFMOGPIP);
		}
		lFHEJDDHFND_.WriteTo(ref output, _repeated_lFHEJDDHFND_codec);
		aNMBAIFOBJP_.WriteTo(ref output, _repeated_aNMBAIFOBJP_codec);
		if (iPKFMFDOPGN_ != null)
		{
			output.WriteRawTag(242, 2);
			output.WriteMessage(IPKFMFDOPGN);
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
		if (TotalBattleTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalBattleTurns);
		}
		if (TotalAutoTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalAutoTurns);
		}
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		if (UltraCnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UltraCnt);
		}
		if (TotalDelayCumulate != 0.0)
		{
			num += 9;
		}
		if (CostTime != 0.0)
		{
			num += 9;
		}
		num += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
		num += monsterList_.CalculateSize(_repeated_monsterList_codec);
		if (RoundCnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundCnt);
		}
		if (CocoonDeadWave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CocoonDeadWave);
		}
		if (AvatarBattleTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarBattleTurns);
		}
		if (MonsterBattleTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterBattleTurns);
		}
		num += customValues_.CalculateSize(_map_customValues_codec);
		if (ChallengeScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeScore);
		}
		num += pNHEDOLHBJL_.CalculateSize(_repeated_pNHEDOLHBJL_codec);
		if (EndReason != BattleEndReason.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)EndReason);
		}
		num += oMDMJICGKBB_.CalculateSize(_repeated_oMDMJICGKBB_codec);
		num += kAIDFMEJIFI_.CalculateSize(_repeated_kAIDFMEJIFI_codec);
		num += mOAJOPEJOPJ_.CalculateSize(_repeated_mOAJOPEJOPJ_codec);
		num += jKOBHNPGMHC_.CalculateSize(_repeated_jKOBHNPGMHC_codec);
		num += nHDDFCAIEGD_.CalculateSize(_repeated_nHDDFCAIEGD_codec);
		num += battleTargetInfo_.CalculateSize(_map_battleTargetInfo_codec);
		num += dDDCFCAAJHC_.CalculateSize(_repeated_dDDCFCAAJHC_codec);
		if (fMCJPPILPLL_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FMCJPPILPLL);
		}
		if (cOIGGPCPLHG_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(COIGGPCPLHG);
		}
		if (NAJPMGFJKEO)
		{
			num += 3;
		}
		num += hOBNHBCJIDM_.CalculateSize(_repeated_hOBNHBCJIDM_codec);
		num += kKJHGIAADKO_.CalculateSize(_repeated_kKJHGIAADKO_codec);
		if (JFGLNIOEEHL != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(JFGLNIOEEHL);
		}
		if (bKGBAEGPLMM_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BKGBAEGPLMM);
		}
		if (mEFGDGFLFMD_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MEFGDGFLFMD);
		}
		if (nLAJOMBNHNA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NLAJOMBNHNA);
		}
		if (cEAIJOPGBAM_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CEAIJOPGBAM);
		}
		if (jPEOCICGPDO_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JPEOCICGPDO);
		}
		if (KGKFADDEGNJ != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KGKFADDEGNJ);
		}
		num += iKEIDHHMFOO_.CalculateSize(_repeated_iKEIDHHMFOO_codec);
		if (oGPOFMOGPIP_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OGPOFMOGPIP);
		}
		num += lFHEJDDHFND_.CalculateSize(_repeated_lFHEJDDHFND_codec);
		num += aNMBAIFOBJP_.CalculateSize(_repeated_aNMBAIFOBJP_codec);
		if (iPKFMFDOPGN_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IPKFMFDOPGN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleStatistics other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TotalBattleTurns != 0)
		{
			TotalBattleTurns = other.TotalBattleTurns;
		}
		if (other.TotalAutoTurns != 0)
		{
			TotalAutoTurns = other.TotalAutoTurns;
		}
		avatarIdList_.Add(other.avatarIdList_);
		if (other.UltraCnt != 0)
		{
			UltraCnt = other.UltraCnt;
		}
		if (other.TotalDelayCumulate != 0.0)
		{
			TotalDelayCumulate = other.TotalDelayCumulate;
		}
		if (other.CostTime != 0.0)
		{
			CostTime = other.CostTime;
		}
		battleAvatarList_.Add(other.battleAvatarList_);
		monsterList_.Add(other.monsterList_);
		if (other.RoundCnt != 0)
		{
			RoundCnt = other.RoundCnt;
		}
		if (other.CocoonDeadWave != 0)
		{
			CocoonDeadWave = other.CocoonDeadWave;
		}
		if (other.AvatarBattleTurns != 0)
		{
			AvatarBattleTurns = other.AvatarBattleTurns;
		}
		if (other.MonsterBattleTurns != 0)
		{
			MonsterBattleTurns = other.MonsterBattleTurns;
		}
		customValues_.MergeFrom(other.customValues_);
		if (other.ChallengeScore != 0)
		{
			ChallengeScore = other.ChallengeScore;
		}
		pNHEDOLHBJL_.Add(other.pNHEDOLHBJL_);
		if (other.EndReason != BattleEndReason.None)
		{
			EndReason = other.EndReason;
		}
		oMDMJICGKBB_.Add(other.oMDMJICGKBB_);
		kAIDFMEJIFI_.Add(other.kAIDFMEJIFI_);
		mOAJOPEJOPJ_.Add(other.mOAJOPEJOPJ_);
		jKOBHNPGMHC_.Add(other.jKOBHNPGMHC_);
		nHDDFCAIEGD_.Add(other.nHDDFCAIEGD_);
		battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
		dDDCFCAAJHC_.Add(other.dDDCFCAAJHC_);
		if (other.fMCJPPILPLL_ != null)
		{
			if (fMCJPPILPLL_ == null)
			{
				FMCJPPILPLL = new BattleGridFightSpecialBattleInfo();
			}
			FMCJPPILPLL.MergeFrom(other.FMCJPPILPLL);
		}
		if (other.cOIGGPCPLHG_ != null)
		{
			if (cOIGGPCPLHG_ == null)
			{
				COIGGPCPLHG = new FAGCFBEBKEO();
			}
			COIGGPCPLHG.MergeFrom(other.COIGGPCPLHG);
		}
		if (other.NAJPMGFJKEO)
		{
			NAJPMGFJKEO = other.NAJPMGFJKEO;
		}
		hOBNHBCJIDM_.Add(other.hOBNHBCJIDM_);
		kKJHGIAADKO_.Add(other.kKJHGIAADKO_);
		if (other.JFGLNIOEEHL != 0)
		{
			JFGLNIOEEHL = other.JFGLNIOEEHL;
		}
		if (other.bKGBAEGPLMM_ != null)
		{
			if (bKGBAEGPLMM_ == null)
			{
				BKGBAEGPLMM = new DCFMPNBKKPF();
			}
			BKGBAEGPLMM.MergeFrom(other.BKGBAEGPLMM);
		}
		if (other.mEFGDGFLFMD_ != null)
		{
			if (mEFGDGFLFMD_ == null)
			{
				MEFGDGFLFMD = new LFPNDKKDEKN();
			}
			MEFGDGFLFMD.MergeFrom(other.MEFGDGFLFMD);
		}
		if (other.nLAJOMBNHNA_ != null)
		{
			if (nLAJOMBNHNA_ == null)
			{
				NLAJOMBNHNA = new JNADLLIIIFP();
			}
			NLAJOMBNHNA.MergeFrom(other.NLAJOMBNHNA);
		}
		if (other.cEAIJOPGBAM_ != null)
		{
			if (cEAIJOPGBAM_ == null)
			{
				CEAIJOPGBAM = new FPFFHGOKBNK();
			}
			CEAIJOPGBAM.MergeFrom(other.CEAIJOPGBAM);
		}
		if (other.jPEOCICGPDO_ != null)
		{
			if (jPEOCICGPDO_ == null)
			{
				JPEOCICGPDO = new KFKHGLEFDKK();
			}
			JPEOCICGPDO.MergeFrom(other.JPEOCICGPDO);
		}
		if (other.KGKFADDEGNJ != 0)
		{
			KGKFADDEGNJ = other.KGKFADDEGNJ;
		}
		iKEIDHHMFOO_.Add(other.iKEIDHHMFOO_);
		if (other.oGPOFMOGPIP_ != null)
		{
			if (oGPOFMOGPIP_ == null)
			{
				OGPOFMOGPIP = new LEHCCNGFKGM();
			}
			OGPOFMOGPIP.MergeFrom(other.OGPOFMOGPIP);
		}
		lFHEJDDHFND_.Add(other.lFHEJDDHFND_);
		aNMBAIFOBJP_.Add(other.aNMBAIFOBJP_);
		if (other.iPKFMFDOPGN_ != null)
		{
			if (iPKFMFDOPGN_ == null)
			{
				IPKFMFDOPGN = new PPNEGMCIECE();
			}
			IPKFMFDOPGN.MergeFrom(other.IPKFMFDOPGN);
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
				TotalBattleTurns = input.ReadUInt32();
				break;
			case 16u:
				TotalAutoTurns = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 32u:
				UltraCnt = input.ReadUInt32();
				break;
			case 41u:
				TotalDelayCumulate = input.ReadDouble();
				break;
			case 49u:
				CostTime = input.ReadDouble();
				break;
			case 58u:
				battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
				break;
			case 66u:
				monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
				break;
			case 72u:
				RoundCnt = input.ReadUInt32();
				break;
			case 80u:
				CocoonDeadWave = input.ReadUInt32();
				break;
			case 88u:
				AvatarBattleTurns = input.ReadUInt32();
				break;
			case 96u:
				MonsterBattleTurns = input.ReadUInt32();
				break;
			case 106u:
				customValues_.AddEntriesFrom(ref input, _map_customValues_codec);
				break;
			case 112u:
				ChallengeScore = input.ReadUInt32();
				break;
			case 130u:
				pNHEDOLHBJL_.AddEntriesFrom(ref input, _repeated_pNHEDOLHBJL_codec);
				break;
			case 152u:
				EndReason = (BattleEndReason)input.ReadEnum();
				break;
			case 170u:
				oMDMJICGKBB_.AddEntriesFrom(ref input, _repeated_oMDMJICGKBB_codec);
				break;
			case 176u:
			case 178u:
				kAIDFMEJIFI_.AddEntriesFrom(ref input, _repeated_kAIDFMEJIFI_codec);
				break;
			case 186u:
				mOAJOPEJOPJ_.AddEntriesFrom(ref input, _repeated_mOAJOPEJOPJ_codec);
				break;
			case 210u:
				jKOBHNPGMHC_.AddEntriesFrom(ref input, _repeated_jKOBHNPGMHC_codec);
				break;
			case 218u:
				nHDDFCAIEGD_.AddEntriesFrom(ref input, _repeated_nHDDFCAIEGD_codec);
				break;
			case 226u:
				battleTargetInfo_.AddEntriesFrom(ref input, _map_battleTargetInfo_codec);
				break;
			case 234u:
				dDDCFCAAJHC_.AddEntriesFrom(ref input, _repeated_dDDCFCAAJHC_codec);
				break;
			case 242u:
				if (fMCJPPILPLL_ == null)
				{
					FMCJPPILPLL = new BattleGridFightSpecialBattleInfo();
				}
				input.ReadMessage(FMCJPPILPLL);
				break;
			case 250u:
				if (cOIGGPCPLHG_ == null)
				{
					COIGGPCPLHG = new FAGCFBEBKEO();
				}
				input.ReadMessage(COIGGPCPLHG);
				break;
			case 256u:
				NAJPMGFJKEO = input.ReadBool();
				break;
			case 266u:
				hOBNHBCJIDM_.AddEntriesFrom(ref input, _repeated_hOBNHBCJIDM_codec);
				break;
			case 274u:
				kKJHGIAADKO_.AddEntriesFrom(ref input, _repeated_kKJHGIAADKO_codec);
				break;
			case 280u:
				JFGLNIOEEHL = input.ReadUInt32();
				break;
			case 290u:
				if (bKGBAEGPLMM_ == null)
				{
					BKGBAEGPLMM = new DCFMPNBKKPF();
				}
				input.ReadMessage(BKGBAEGPLMM);
				break;
			case 298u:
				if (mEFGDGFLFMD_ == null)
				{
					MEFGDGFLFMD = new LFPNDKKDEKN();
				}
				input.ReadMessage(MEFGDGFLFMD);
				break;
			case 306u:
				if (nLAJOMBNHNA_ == null)
				{
					NLAJOMBNHNA = new JNADLLIIIFP();
				}
				input.ReadMessage(NLAJOMBNHNA);
				break;
			case 314u:
				if (cEAIJOPGBAM_ == null)
				{
					CEAIJOPGBAM = new FPFFHGOKBNK();
				}
				input.ReadMessage(CEAIJOPGBAM);
				break;
			case 322u:
				if (jPEOCICGPDO_ == null)
				{
					JPEOCICGPDO = new KFKHGLEFDKK();
				}
				input.ReadMessage(JPEOCICGPDO);
				break;
			case 328u:
				KGKFADDEGNJ = input.ReadUInt32();
				break;
			case 338u:
				iKEIDHHMFOO_.AddEntriesFrom(ref input, _repeated_iKEIDHHMFOO_codec);
				break;
			case 346u:
				if (oGPOFMOGPIP_ == null)
				{
					OGPOFMOGPIP = new LEHCCNGFKGM();
				}
				input.ReadMessage(OGPOFMOGPIP);
				break;
			case 352u:
			case 354u:
				lFHEJDDHFND_.AddEntriesFrom(ref input, _repeated_lFHEJDDHFND_codec);
				break;
			case 360u:
			case 362u:
				aNMBAIFOBJP_.AddEntriesFrom(ref input, _repeated_aNMBAIFOBJP_codec);
				break;
			case 370u:
				if (iPKFMFDOPGN_ == null)
				{
					IPKFMFDOPGN = new PPNEGMCIECE();
				}
				input.ReadMessage(IPKFMFDOPGN);
				break;
			}
		}
	}
}
