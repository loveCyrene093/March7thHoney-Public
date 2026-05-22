using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightFinishInfo : IMessage<GridFightFinishInfo>, IMessage, IEquatable<GridFightFinishInfo>, IDeepCloneable<GridFightFinishInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightFinishInfo> _parser = new MessageParser<GridFightFinishInfo>(() => new GridFightFinishInfo());

	private UnknownFieldSet _unknownFields;

	public const int NLILNONCNFCFieldNumber = 3;

	private JCFJADFEOJN nLILNONCNFC_;

	public const int CEAFFNCKDDDFieldNumber = 6;

	private static readonly FieldCodec<GridFightGamePortalBuffInfo> _repeated_cEAFFNCKDDD_codec = FieldCodec.ForMessage(50u, GridFightGamePortalBuffInfo.Parser);

	private readonly RepeatedField<GridFightGamePortalBuffInfo> cEAFFNCKDDD_ = new RepeatedField<GridFightGamePortalBuffInfo>();

	public const int HBNHKPDMGIPFieldNumber = 7;

	private uint hBNHKPDMGIP_;

	public const int EABPCKEDDBHFieldNumber = 10;

	private static readonly FieldCodec<HHHMMJBGCNG> _repeated_eABPCKEDDBH_codec = FieldCodec.ForMessage(82u, HHHMMJBGCNG.Parser);

	private readonly RepeatedField<HHHMMJBGCNG> eABPCKEDDBH_ = new RepeatedField<HHHMMJBGCNG>();

	public const int SyncAugmentInfoFieldNumber = 14;

	private static readonly FieldCodec<GridGameAugmentInfo> _repeated_syncAugmentInfo_codec = FieldCodec.ForMessage(114u, GridGameAugmentInfo.Parser);

	private readonly RepeatedField<GridGameAugmentInfo> syncAugmentInfo_ = new RepeatedField<GridGameAugmentInfo>();

	public const int GridFightTraitInfoFieldNumber = 15;

	private static readonly FieldCodec<GridGameTraitInfo> _repeated_gridFightTraitInfo_codec = FieldCodec.ForMessage(122u, GridGameTraitInfo.Parser);

	private readonly RepeatedField<GridGameTraitInfo> gridFightTraitInfo_ = new RepeatedField<GridGameTraitInfo>();

	public const int MMAJCLACOBNFieldNumber = 80;

	private static readonly FieldCodec<CKCKIDHMMEG> _repeated_mMAJCLACOBN_codec = FieldCodec.ForMessage(642u, CKCKIDHMMEG.Parser);

	private readonly RepeatedField<CKCKIDHMMEG> mMAJCLACOBN_ = new RepeatedField<CKCKIDHMMEG>();

	public const int GGKCDEIDDLKFieldNumber = 94;

	private static readonly FieldCodec<uint> _repeated_gGKCDEIDDLK_codec = FieldCodec.ForUInt32(754u);

	private readonly RepeatedField<uint> gGKCDEIDDLK_ = new RepeatedField<uint>();

	public const int IAKFPMOEJLFFieldNumber = 106;

	private static readonly FieldCodec<DIBJGAKOCLO> _repeated_iAKFPMOEJLF_codec = FieldCodec.ForMessage(850u, DIBJGAKOCLO.Parser);

	private readonly RepeatedField<DIBJGAKOCLO> iAKFPMOEJLF_ = new RepeatedField<DIBJGAKOCLO>();

	public const int GridGameRoleListFieldNumber = 261;

	private static readonly FieldCodec<GridGameRoleInfo> _repeated_gridGameRoleList_codec = FieldCodec.ForMessage(2090u, GridGameRoleInfo.Parser);

	private readonly RepeatedField<GridGameRoleInfo> gridGameRoleList_ = new RepeatedField<GridGameRoleInfo>();

	public const int KIBLKCANNGIFieldNumber = 316;

	private uint kIBLKCANNGI_;

	public const int GridGameNpcListFieldNumber = 501;

	private static readonly FieldCodec<GridGameNpcInfo> _repeated_gridGameNpcList_codec = FieldCodec.ForMessage(4010u, GridGameNpcInfo.Parser);

	private readonly RepeatedField<GridGameNpcInfo> gridGameNpcList_ = new RepeatedField<GridGameNpcInfo>();

	public const int IsOverlockFieldNumber = 726;

	private bool isOverlock_;

	public const int CDLAIJCKJJNFieldNumber = 875;

	private static readonly FieldCodec<uint> _repeated_cDLAIJCKJJN_codec = FieldCodec.ForUInt32(7002u);

	private readonly RepeatedField<uint> cDLAIJCKJJN_ = new RepeatedField<uint>();

	public const int GridFightEquipmentListFieldNumber = 968;

	private static readonly FieldCodec<GridFightEquipmentInfo> _repeated_gridFightEquipmentList_codec = FieldCodec.ForMessage(7746u, GridFightEquipmentInfo.Parser);

	private readonly RepeatedField<GridFightEquipmentInfo> gridFightEquipmentList_ = new RepeatedField<GridFightEquipmentInfo>();

	public const int OFJNBPAMPGDFieldNumber = 1012;

	private uint oFJNBPAMPGD_;

	public const int IONFNCECKGIFieldNumber = 1054;

	private static readonly FieldCodec<uint> _repeated_iONFNCECKGI_codec = FieldCodec.ForUInt32(8434u);

	private readonly RepeatedField<uint> iONFNCECKGI_ = new RepeatedField<uint>();

	public const int PGPKPMOIAILFieldNumber = 1085;

	private CLOEPPBCKGF pGPKPMOIAIL_;

	public const int BossInfoFieldNumber = 1239;

	private GridFightBossInfo bossInfo_;

	public const int MOIDLNFKAICFieldNumber = 1346;

	private static readonly FieldCodec<ELAGCLMOFFI> _repeated_mOIDLNFKAIC_codec = FieldCodec.ForMessage(10770u, ELAGCLMOFFI.Parser);

	private readonly RepeatedField<ELAGCLMOFFI> mOIDLNFKAIC_ = new RepeatedField<ELAGCLMOFFI>();

	public const int PHDEOPEJIIDFieldNumber = 1349;

	private static readonly FieldCodec<DACJDMPICEL> _repeated_pHDEOPEJIID_codec = FieldCodec.ForMessage(10794u, DACJDMPICEL.Parser);

	private readonly RepeatedField<DACJDMPICEL> pHDEOPEJIID_ = new RepeatedField<DACJDMPICEL>();

	public const int BCHPAOCOHILFieldNumber = 1360;

	private FCBEHGJBJCN bCHPAOCOHIL_;

	public const int ReasonFieldNumber = 1474;

	private GridFightSettleReason reason_;

	public const int MPGFGKDBAHNFieldNumber = 1548;

	private bool mPGFGKDBAHN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightFinishInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightFinishInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCFJADFEOJN NLILNONCNFC
	{
		get
		{
			return nLILNONCNFC_;
		}
		set
		{
			nLILNONCNFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightGamePortalBuffInfo> CEAFFNCKDDD => cEAFFNCKDDD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBNHKPDMGIP
	{
		get
		{
			return hBNHKPDMGIP_;
		}
		set
		{
			hBNHKPDMGIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HHHMMJBGCNG> EABPCKEDDBH => eABPCKEDDBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameAugmentInfo> SyncAugmentInfo => syncAugmentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameTraitInfo> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKCKIDHMMEG> MMAJCLACOBN => mMAJCLACOBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GGKCDEIDDLK => gGKCDEIDDLK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DIBJGAKOCLO> IAKFPMOEJLF => iAKFPMOEJLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameRoleInfo> GridGameRoleList => gridGameRoleList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KIBLKCANNGI
	{
		get
		{
			return kIBLKCANNGI_;
		}
		set
		{
			kIBLKCANNGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameNpcInfo> GridGameNpcList => gridGameNpcList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOverlock
	{
		get
		{
			return isOverlock_;
		}
		set
		{
			isOverlock_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CDLAIJCKJJN => cDLAIJCKJJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightEquipmentInfo> GridFightEquipmentList => gridFightEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFJNBPAMPGD
	{
		get
		{
			return oFJNBPAMPGD_;
		}
		set
		{
			oFJNBPAMPGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IONFNCECKGI => iONFNCECKGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLOEPPBCKGF PGPKPMOIAIL
	{
		get
		{
			return pGPKPMOIAIL_;
		}
		set
		{
			pGPKPMOIAIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightBossInfo BossInfo
	{
		get
		{
			return bossInfo_;
		}
		set
		{
			bossInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ELAGCLMOFFI> MOIDLNFKAIC => mOIDLNFKAIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DACJDMPICEL> PHDEOPEJIID => pHDEOPEJIID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCBEHGJBJCN BCHPAOCOHIL
	{
		get
		{
			return bCHPAOCOHIL_;
		}
		set
		{
			bCHPAOCOHIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSettleReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MPGFGKDBAHN
	{
		get
		{
			return mPGFGKDBAHN_;
		}
		set
		{
			mPGFGKDBAHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishInfo(GridFightFinishInfo other)
		: this()
	{
		nLILNONCNFC_ = ((other.nLILNONCNFC_ != null) ? other.nLILNONCNFC_.Clone() : null);
		cEAFFNCKDDD_ = other.cEAFFNCKDDD_.Clone();
		hBNHKPDMGIP_ = other.hBNHKPDMGIP_;
		eABPCKEDDBH_ = other.eABPCKEDDBH_.Clone();
		syncAugmentInfo_ = other.syncAugmentInfo_.Clone();
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		mMAJCLACOBN_ = other.mMAJCLACOBN_.Clone();
		gGKCDEIDDLK_ = other.gGKCDEIDDLK_.Clone();
		iAKFPMOEJLF_ = other.iAKFPMOEJLF_.Clone();
		gridGameRoleList_ = other.gridGameRoleList_.Clone();
		kIBLKCANNGI_ = other.kIBLKCANNGI_;
		gridGameNpcList_ = other.gridGameNpcList_.Clone();
		isOverlock_ = other.isOverlock_;
		cDLAIJCKJJN_ = other.cDLAIJCKJJN_.Clone();
		gridFightEquipmentList_ = other.gridFightEquipmentList_.Clone();
		oFJNBPAMPGD_ = other.oFJNBPAMPGD_;
		iONFNCECKGI_ = other.iONFNCECKGI_.Clone();
		pGPKPMOIAIL_ = ((other.pGPKPMOIAIL_ != null) ? other.pGPKPMOIAIL_.Clone() : null);
		bossInfo_ = ((other.bossInfo_ != null) ? other.bossInfo_.Clone() : null);
		mOIDLNFKAIC_ = other.mOIDLNFKAIC_.Clone();
		pHDEOPEJIID_ = other.pHDEOPEJIID_.Clone();
		bCHPAOCOHIL_ = ((other.bCHPAOCOHIL_ != null) ? other.bCHPAOCOHIL_.Clone() : null);
		reason_ = other.reason_;
		mPGFGKDBAHN_ = other.mPGFGKDBAHN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishInfo Clone()
	{
		return new GridFightFinishInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightFinishInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightFinishInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NLILNONCNFC, other.NLILNONCNFC))
		{
			return false;
		}
		if (!cEAFFNCKDDD_.Equals(other.cEAFFNCKDDD_))
		{
			return false;
		}
		if (HBNHKPDMGIP != other.HBNHKPDMGIP)
		{
			return false;
		}
		if (!eABPCKEDDBH_.Equals(other.eABPCKEDDBH_))
		{
			return false;
		}
		if (!syncAugmentInfo_.Equals(other.syncAugmentInfo_))
		{
			return false;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
		{
			return false;
		}
		if (!mMAJCLACOBN_.Equals(other.mMAJCLACOBN_))
		{
			return false;
		}
		if (!gGKCDEIDDLK_.Equals(other.gGKCDEIDDLK_))
		{
			return false;
		}
		if (!iAKFPMOEJLF_.Equals(other.iAKFPMOEJLF_))
		{
			return false;
		}
		if (!gridGameRoleList_.Equals(other.gridGameRoleList_))
		{
			return false;
		}
		if (KIBLKCANNGI != other.KIBLKCANNGI)
		{
			return false;
		}
		if (!gridGameNpcList_.Equals(other.gridGameNpcList_))
		{
			return false;
		}
		if (IsOverlock != other.IsOverlock)
		{
			return false;
		}
		if (!cDLAIJCKJJN_.Equals(other.cDLAIJCKJJN_))
		{
			return false;
		}
		if (!gridFightEquipmentList_.Equals(other.gridFightEquipmentList_))
		{
			return false;
		}
		if (OFJNBPAMPGD != other.OFJNBPAMPGD)
		{
			return false;
		}
		if (!iONFNCECKGI_.Equals(other.iONFNCECKGI_))
		{
			return false;
		}
		if (!object.Equals(PGPKPMOIAIL, other.PGPKPMOIAIL))
		{
			return false;
		}
		if (!object.Equals(BossInfo, other.BossInfo))
		{
			return false;
		}
		if (!mOIDLNFKAIC_.Equals(other.mOIDLNFKAIC_))
		{
			return false;
		}
		if (!pHDEOPEJIID_.Equals(other.pHDEOPEJIID_))
		{
			return false;
		}
		if (!object.Equals(BCHPAOCOHIL, other.BCHPAOCOHIL))
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (MPGFGKDBAHN != other.MPGFGKDBAHN)
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
		if (nLILNONCNFC_ != null)
		{
			num ^= NLILNONCNFC.GetHashCode();
		}
		num ^= cEAFFNCKDDD_.GetHashCode();
		if (HBNHKPDMGIP != 0)
		{
			num ^= HBNHKPDMGIP.GetHashCode();
		}
		num ^= eABPCKEDDBH_.GetHashCode();
		num ^= syncAugmentInfo_.GetHashCode();
		num ^= gridFightTraitInfo_.GetHashCode();
		num ^= mMAJCLACOBN_.GetHashCode();
		num ^= gGKCDEIDDLK_.GetHashCode();
		num ^= iAKFPMOEJLF_.GetHashCode();
		num ^= gridGameRoleList_.GetHashCode();
		if (KIBLKCANNGI != 0)
		{
			num ^= KIBLKCANNGI.GetHashCode();
		}
		num ^= gridGameNpcList_.GetHashCode();
		if (IsOverlock)
		{
			num ^= IsOverlock.GetHashCode();
		}
		num ^= cDLAIJCKJJN_.GetHashCode();
		num ^= gridFightEquipmentList_.GetHashCode();
		if (OFJNBPAMPGD != 0)
		{
			num ^= OFJNBPAMPGD.GetHashCode();
		}
		num ^= iONFNCECKGI_.GetHashCode();
		if (pGPKPMOIAIL_ != null)
		{
			num ^= PGPKPMOIAIL.GetHashCode();
		}
		if (bossInfo_ != null)
		{
			num ^= BossInfo.GetHashCode();
		}
		num ^= mOIDLNFKAIC_.GetHashCode();
		num ^= pHDEOPEJIID_.GetHashCode();
		if (bCHPAOCOHIL_ != null)
		{
			num ^= BCHPAOCOHIL.GetHashCode();
		}
		if (Reason != GridFightSettleReason.CdphdhnlhaoFmpbhelfgee)
		{
			num ^= Reason.GetHashCode();
		}
		if (MPGFGKDBAHN)
		{
			num ^= MPGFGKDBAHN.GetHashCode();
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
		if (nLILNONCNFC_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NLILNONCNFC);
		}
		cEAFFNCKDDD_.WriteTo(ref output, _repeated_cEAFFNCKDDD_codec);
		if (HBNHKPDMGIP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HBNHKPDMGIP);
		}
		eABPCKEDDBH_.WriteTo(ref output, _repeated_eABPCKEDDBH_codec);
		syncAugmentInfo_.WriteTo(ref output, _repeated_syncAugmentInfo_codec);
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
		mMAJCLACOBN_.WriteTo(ref output, _repeated_mMAJCLACOBN_codec);
		gGKCDEIDDLK_.WriteTo(ref output, _repeated_gGKCDEIDDLK_codec);
		iAKFPMOEJLF_.WriteTo(ref output, _repeated_iAKFPMOEJLF_codec);
		gridGameRoleList_.WriteTo(ref output, _repeated_gridGameRoleList_codec);
		if (KIBLKCANNGI != 0)
		{
			output.WriteRawTag(224, 19);
			output.WriteUInt32(KIBLKCANNGI);
		}
		gridGameNpcList_.WriteTo(ref output, _repeated_gridGameNpcList_codec);
		if (IsOverlock)
		{
			output.WriteRawTag(176, 45);
			output.WriteBool(IsOverlock);
		}
		cDLAIJCKJJN_.WriteTo(ref output, _repeated_cDLAIJCKJJN_codec);
		gridFightEquipmentList_.WriteTo(ref output, _repeated_gridFightEquipmentList_codec);
		if (OFJNBPAMPGD != 0)
		{
			output.WriteRawTag(160, 63);
			output.WriteUInt32(OFJNBPAMPGD);
		}
		iONFNCECKGI_.WriteTo(ref output, _repeated_iONFNCECKGI_codec);
		if (pGPKPMOIAIL_ != null)
		{
			output.WriteRawTag(234, 67);
			output.WriteMessage(PGPKPMOIAIL);
		}
		if (bossInfo_ != null)
		{
			output.WriteRawTag(186, 77);
			output.WriteMessage(BossInfo);
		}
		mOIDLNFKAIC_.WriteTo(ref output, _repeated_mOIDLNFKAIC_codec);
		pHDEOPEJIID_.WriteTo(ref output, _repeated_pHDEOPEJIID_codec);
		if (bCHPAOCOHIL_ != null)
		{
			output.WriteRawTag(130, 85);
			output.WriteMessage(BCHPAOCOHIL);
		}
		if (Reason != GridFightSettleReason.CdphdhnlhaoFmpbhelfgee)
		{
			output.WriteRawTag(144, 92);
			output.WriteEnum((int)Reason);
		}
		if (MPGFGKDBAHN)
		{
			output.WriteRawTag(224, 96);
			output.WriteBool(MPGFGKDBAHN);
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
		if (nLILNONCNFC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NLILNONCNFC);
		}
		num += cEAFFNCKDDD_.CalculateSize(_repeated_cEAFFNCKDDD_codec);
		if (HBNHKPDMGIP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBNHKPDMGIP);
		}
		num += eABPCKEDDBH_.CalculateSize(_repeated_eABPCKEDDBH_codec);
		num += syncAugmentInfo_.CalculateSize(_repeated_syncAugmentInfo_codec);
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		num += mMAJCLACOBN_.CalculateSize(_repeated_mMAJCLACOBN_codec);
		num += gGKCDEIDDLK_.CalculateSize(_repeated_gGKCDEIDDLK_codec);
		num += iAKFPMOEJLF_.CalculateSize(_repeated_iAKFPMOEJLF_codec);
		num += gridGameRoleList_.CalculateSize(_repeated_gridGameRoleList_codec);
		if (KIBLKCANNGI != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KIBLKCANNGI);
		}
		num += gridGameNpcList_.CalculateSize(_repeated_gridGameNpcList_codec);
		if (IsOverlock)
		{
			num += 3;
		}
		num += cDLAIJCKJJN_.CalculateSize(_repeated_cDLAIJCKJJN_codec);
		num += gridFightEquipmentList_.CalculateSize(_repeated_gridFightEquipmentList_codec);
		if (OFJNBPAMPGD != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(OFJNBPAMPGD);
		}
		num += iONFNCECKGI_.CalculateSize(_repeated_iONFNCECKGI_codec);
		if (pGPKPMOIAIL_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PGPKPMOIAIL);
		}
		if (bossInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BossInfo);
		}
		num += mOIDLNFKAIC_.CalculateSize(_repeated_mOIDLNFKAIC_codec);
		num += pHDEOPEJIID_.CalculateSize(_repeated_pHDEOPEJIID_codec);
		if (bCHPAOCOHIL_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BCHPAOCOHIL);
		}
		if (Reason != GridFightSettleReason.CdphdhnlhaoFmpbhelfgee)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (MPGFGKDBAHN)
		{
			num += 3;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightFinishInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nLILNONCNFC_ != null)
		{
			if (nLILNONCNFC_ == null)
			{
				NLILNONCNFC = new JCFJADFEOJN();
			}
			NLILNONCNFC.MergeFrom(other.NLILNONCNFC);
		}
		cEAFFNCKDDD_.Add(other.cEAFFNCKDDD_);
		if (other.HBNHKPDMGIP != 0)
		{
			HBNHKPDMGIP = other.HBNHKPDMGIP;
		}
		eABPCKEDDBH_.Add(other.eABPCKEDDBH_);
		syncAugmentInfo_.Add(other.syncAugmentInfo_);
		gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
		mMAJCLACOBN_.Add(other.mMAJCLACOBN_);
		gGKCDEIDDLK_.Add(other.gGKCDEIDDLK_);
		iAKFPMOEJLF_.Add(other.iAKFPMOEJLF_);
		gridGameRoleList_.Add(other.gridGameRoleList_);
		if (other.KIBLKCANNGI != 0)
		{
			KIBLKCANNGI = other.KIBLKCANNGI;
		}
		gridGameNpcList_.Add(other.gridGameNpcList_);
		if (other.IsOverlock)
		{
			IsOverlock = other.IsOverlock;
		}
		cDLAIJCKJJN_.Add(other.cDLAIJCKJJN_);
		gridFightEquipmentList_.Add(other.gridFightEquipmentList_);
		if (other.OFJNBPAMPGD != 0)
		{
			OFJNBPAMPGD = other.OFJNBPAMPGD;
		}
		iONFNCECKGI_.Add(other.iONFNCECKGI_);
		if (other.pGPKPMOIAIL_ != null)
		{
			if (pGPKPMOIAIL_ == null)
			{
				PGPKPMOIAIL = new CLOEPPBCKGF();
			}
			PGPKPMOIAIL.MergeFrom(other.PGPKPMOIAIL);
		}
		if (other.bossInfo_ != null)
		{
			if (bossInfo_ == null)
			{
				BossInfo = new GridFightBossInfo();
			}
			BossInfo.MergeFrom(other.BossInfo);
		}
		mOIDLNFKAIC_.Add(other.mOIDLNFKAIC_);
		pHDEOPEJIID_.Add(other.pHDEOPEJIID_);
		if (other.bCHPAOCOHIL_ != null)
		{
			if (bCHPAOCOHIL_ == null)
			{
				BCHPAOCOHIL = new FCBEHGJBJCN();
			}
			BCHPAOCOHIL.MergeFrom(other.BCHPAOCOHIL);
		}
		if (other.Reason != GridFightSettleReason.CdphdhnlhaoFmpbhelfgee)
		{
			Reason = other.Reason;
		}
		if (other.MPGFGKDBAHN)
		{
			MPGFGKDBAHN = other.MPGFGKDBAHN;
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
			case 26u:
				if (nLILNONCNFC_ == null)
				{
					NLILNONCNFC = new JCFJADFEOJN();
				}
				input.ReadMessage(NLILNONCNFC);
				break;
			case 50u:
				cEAFFNCKDDD_.AddEntriesFrom(ref input, _repeated_cEAFFNCKDDD_codec);
				break;
			case 56u:
				HBNHKPDMGIP = input.ReadUInt32();
				break;
			case 82u:
				eABPCKEDDBH_.AddEntriesFrom(ref input, _repeated_eABPCKEDDBH_codec);
				break;
			case 114u:
				syncAugmentInfo_.AddEntriesFrom(ref input, _repeated_syncAugmentInfo_codec);
				break;
			case 122u:
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
				break;
			case 642u:
				mMAJCLACOBN_.AddEntriesFrom(ref input, _repeated_mMAJCLACOBN_codec);
				break;
			case 752u:
			case 754u:
				gGKCDEIDDLK_.AddEntriesFrom(ref input, _repeated_gGKCDEIDDLK_codec);
				break;
			case 850u:
				iAKFPMOEJLF_.AddEntriesFrom(ref input, _repeated_iAKFPMOEJLF_codec);
				break;
			case 2090u:
				gridGameRoleList_.AddEntriesFrom(ref input, _repeated_gridGameRoleList_codec);
				break;
			case 2528u:
				KIBLKCANNGI = input.ReadUInt32();
				break;
			case 4010u:
				gridGameNpcList_.AddEntriesFrom(ref input, _repeated_gridGameNpcList_codec);
				break;
			case 5808u:
				IsOverlock = input.ReadBool();
				break;
			case 7000u:
			case 7002u:
				cDLAIJCKJJN_.AddEntriesFrom(ref input, _repeated_cDLAIJCKJJN_codec);
				break;
			case 7746u:
				gridFightEquipmentList_.AddEntriesFrom(ref input, _repeated_gridFightEquipmentList_codec);
				break;
			case 8096u:
				OFJNBPAMPGD = input.ReadUInt32();
				break;
			case 8432u:
			case 8434u:
				iONFNCECKGI_.AddEntriesFrom(ref input, _repeated_iONFNCECKGI_codec);
				break;
			case 8682u:
				if (pGPKPMOIAIL_ == null)
				{
					PGPKPMOIAIL = new CLOEPPBCKGF();
				}
				input.ReadMessage(PGPKPMOIAIL);
				break;
			case 9914u:
				if (bossInfo_ == null)
				{
					BossInfo = new GridFightBossInfo();
				}
				input.ReadMessage(BossInfo);
				break;
			case 10770u:
				mOIDLNFKAIC_.AddEntriesFrom(ref input, _repeated_mOIDLNFKAIC_codec);
				break;
			case 10794u:
				pHDEOPEJIID_.AddEntriesFrom(ref input, _repeated_pHDEOPEJIID_codec);
				break;
			case 10882u:
				if (bCHPAOCOHIL_ == null)
				{
					BCHPAOCOHIL = new FCBEHGJBJCN();
				}
				input.ReadMessage(BCHPAOCOHIL);
				break;
			case 11792u:
				Reason = (GridFightSettleReason)input.ReadEnum();
				break;
			case 12384u:
				MPGFGKDBAHN = input.ReadBool();
				break;
			}
		}
	}
}
