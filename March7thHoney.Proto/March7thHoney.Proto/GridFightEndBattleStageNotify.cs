using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEndBattleStageNotify : IMessage<GridFightEndBattleStageNotify>, IMessage, IEquatable<GridFightEndBattleStageNotify>, IDeepCloneable<GridFightEndBattleStageNotify>, IBufferMessage
{
	private static readonly MessageParser<GridFightEndBattleStageNotify> _parser = new MessageParser<GridFightEndBattleStageNotify>(() => new GridFightEndBattleStageNotify());

	private UnknownFieldSet _unknownFields;

	public const int GridFightDamageSttInfoFieldNumber = 1;

	private GridFightDamageSttInfo gridFightDamageSttInfo_;

	public const int NDOCIKPLKIFFieldNumber = 2;

	private uint nDOCIKPLKIF_;

	public const int FHHPDFKLJKCFieldNumber = 3;

	private uint fHHPDFKLJKC_;

	public const int PNOJLNNHBIHFieldNumber = 4;

	private uint pNOJLNNHBIH_;

	public const int DCPKPNLKGMMFieldNumber = 5;

	private uint dCPKPNLKGMM_;

	public const int MKCHLGOGJNBFieldNumber = 6;

	private uint mKCHLGOGJNB_;

	public const int KDOINLGKMBIFieldNumber = 7;

	private uint kDOINLGKMBI_;

	public const int JGLEDADBNGPFieldNumber = 8;

	private uint jGLEDADBNGP_;

	public const int SectionIdFieldNumber = 9;

	private uint sectionId_;

	public const int PACIAIJBOHOFieldNumber = 11;

	private uint pACIAIJBOHO_;

	public const int KIAFMFGAONAFieldNumber = 12;

	private uint kIAFMFGAONA_;

	public const int HPOACJCPJHNFieldNumber = 13;

	private bool hPOACJCPJHN_;

	public const int DHMBKAPKJFNFieldNumber = 14;

	private static readonly MapField<uint, GridFightDropInfo>.Codec _map_dHMBKAPKJFN_codec = new MapField<uint, GridFightDropInfo>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, GridFightDropInfo.Parser), 114u);

	private readonly MapField<uint, GridFightDropInfo> dHMBKAPKJFN_ = new MapField<uint, GridFightDropInfo>();

	public const int MAGCGPMHHEAFieldNumber = 15;

	private uint mAGCGPMHHEA_;

	public const int BCOLJFHDLLDFieldNumber = 69;

	private uint bCOLJFHDLLD_;

	public const int IJEIEJLPGGJFieldNumber = 370;

	private uint iJEIEJLPGGJ_;

	public const int DHHPEBDPKJJFieldNumber = 654;

	private static readonly FieldCodec<ILGOPHIAJIG> _repeated_dHHPEBDPKJJ_codec = FieldCodec.ForMessage(5234u, ILGOPHIAJIG.Parser);

	private readonly RepeatedField<ILGOPHIAJIG> dHHPEBDPKJJ_ = new RepeatedField<ILGOPHIAJIG>();

	public const int IDEAAPCCFPFFieldNumber = 904;

	private uint iDEAAPCCFPF_;

	public const int IPCFJBAKLCGFieldNumber = 1029;

	private uint iPCFJBAKLCG_;

	public const int NNFAFGCGMBBFieldNumber = 1413;

	private static readonly FieldCodec<GridFightHpModifyInfo> _repeated_nNFAFGCGMBB_codec = FieldCodec.ForMessage(11306u, GridFightHpModifyInfo.Parser);

	private readonly RepeatedField<GridFightHpModifyInfo> nNFAFGCGMBB_ = new RepeatedField<GridFightHpModifyInfo>();

	public const int FGEDKOINMAGFieldNumber = 1735;

	private uint fGEDKOINMAG_;

	public const int GCBBEEGANEGFieldNumber = 1785;

	private MIOMFOAEHEC gCBBEEGANEG_;

	public const int EJEIBPEKHLDFieldNumber = 2044;

	private uint eJEIBPEKHLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEndBattleStageNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightEndBattleStageNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDamageSttInfo GridFightDamageSttInfo
	{
		get
		{
			return gridFightDamageSttInfo_;
		}
		set
		{
			gridFightDamageSttInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDOCIKPLKIF
	{
		get
		{
			return nDOCIKPLKIF_;
		}
		set
		{
			nDOCIKPLKIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHHPDFKLJKC
	{
		get
		{
			return fHHPDFKLJKC_;
		}
		set
		{
			fHHPDFKLJKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNOJLNNHBIH
	{
		get
		{
			return pNOJLNNHBIH_;
		}
		set
		{
			pNOJLNNHBIH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKCHLGOGJNB
	{
		get
		{
			return mKCHLGOGJNB_;
		}
		set
		{
			mKCHLGOGJNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KDOINLGKMBI
	{
		get
		{
			return kDOINLGKMBI_;
		}
		set
		{
			kDOINLGKMBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGLEDADBNGP
	{
		get
		{
			return jGLEDADBNGP_;
		}
		set
		{
			jGLEDADBNGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PACIAIJBOHO
	{
		get
		{
			return pACIAIJBOHO_;
		}
		set
		{
			pACIAIJBOHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KIAFMFGAONA
	{
		get
		{
			return kIAFMFGAONA_;
		}
		set
		{
			kIAFMFGAONA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HPOACJCPJHN
	{
		get
		{
			return hPOACJCPJHN_;
		}
		set
		{
			hPOACJCPJHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, GridFightDropInfo> DHMBKAPKJFN => dHMBKAPKJFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAGCGPMHHEA
	{
		get
		{
			return mAGCGPMHHEA_;
		}
		set
		{
			mAGCGPMHHEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCOLJFHDLLD
	{
		get
		{
			return bCOLJFHDLLD_;
		}
		set
		{
			bCOLJFHDLLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJEIEJLPGGJ
	{
		get
		{
			return iJEIEJLPGGJ_;
		}
		set
		{
			iJEIEJLPGGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ILGOPHIAJIG> DHHPEBDPKJJ => dHHPEBDPKJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IDEAAPCCFPF
	{
		get
		{
			return iDEAAPCCFPF_;
		}
		set
		{
			iDEAAPCCFPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPCFJBAKLCG
	{
		get
		{
			return iPCFJBAKLCG_;
		}
		set
		{
			iPCFJBAKLCG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightHpModifyInfo> NNFAFGCGMBB => nNFAFGCGMBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FGEDKOINMAG
	{
		get
		{
			return fGEDKOINMAG_;
		}
		set
		{
			fGEDKOINMAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIOMFOAEHEC GCBBEEGANEG
	{
		get
		{
			return gCBBEEGANEG_;
		}
		set
		{
			gCBBEEGANEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJEIBPEKHLD
	{
		get
		{
			return eJEIBPEKHLD_;
		}
		set
		{
			eJEIBPEKHLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEndBattleStageNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEndBattleStageNotify(GridFightEndBattleStageNotify other)
		: this()
	{
		gridFightDamageSttInfo_ = ((other.gridFightDamageSttInfo_ != null) ? other.gridFightDamageSttInfo_.Clone() : null);
		nDOCIKPLKIF_ = other.nDOCIKPLKIF_;
		fHHPDFKLJKC_ = other.fHHPDFKLJKC_;
		pNOJLNNHBIH_ = other.pNOJLNNHBIH_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		mKCHLGOGJNB_ = other.mKCHLGOGJNB_;
		kDOINLGKMBI_ = other.kDOINLGKMBI_;
		jGLEDADBNGP_ = other.jGLEDADBNGP_;
		sectionId_ = other.sectionId_;
		pACIAIJBOHO_ = other.pACIAIJBOHO_;
		kIAFMFGAONA_ = other.kIAFMFGAONA_;
		hPOACJCPJHN_ = other.hPOACJCPJHN_;
		dHMBKAPKJFN_ = other.dHMBKAPKJFN_.Clone();
		mAGCGPMHHEA_ = other.mAGCGPMHHEA_;
		bCOLJFHDLLD_ = other.bCOLJFHDLLD_;
		iJEIEJLPGGJ_ = other.iJEIEJLPGGJ_;
		dHHPEBDPKJJ_ = other.dHHPEBDPKJJ_.Clone();
		iDEAAPCCFPF_ = other.iDEAAPCCFPF_;
		iPCFJBAKLCG_ = other.iPCFJBAKLCG_;
		nNFAFGCGMBB_ = other.nNFAFGCGMBB_.Clone();
		fGEDKOINMAG_ = other.fGEDKOINMAG_;
		gCBBEEGANEG_ = ((other.gCBBEEGANEG_ != null) ? other.gCBBEEGANEG_.Clone() : null);
		eJEIBPEKHLD_ = other.eJEIBPEKHLD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEndBattleStageNotify Clone()
	{
		return new GridFightEndBattleStageNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEndBattleStageNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEndBattleStageNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GridFightDamageSttInfo, other.GridFightDamageSttInfo))
		{
			return false;
		}
		if (NDOCIKPLKIF != other.NDOCIKPLKIF)
		{
			return false;
		}
		if (FHHPDFKLJKC != other.FHHPDFKLJKC)
		{
			return false;
		}
		if (PNOJLNNHBIH != other.PNOJLNNHBIH)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (MKCHLGOGJNB != other.MKCHLGOGJNB)
		{
			return false;
		}
		if (KDOINLGKMBI != other.KDOINLGKMBI)
		{
			return false;
		}
		if (JGLEDADBNGP != other.JGLEDADBNGP)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (PACIAIJBOHO != other.PACIAIJBOHO)
		{
			return false;
		}
		if (KIAFMFGAONA != other.KIAFMFGAONA)
		{
			return false;
		}
		if (HPOACJCPJHN != other.HPOACJCPJHN)
		{
			return false;
		}
		if (!DHMBKAPKJFN.Equals(other.DHMBKAPKJFN))
		{
			return false;
		}
		if (MAGCGPMHHEA != other.MAGCGPMHHEA)
		{
			return false;
		}
		if (BCOLJFHDLLD != other.BCOLJFHDLLD)
		{
			return false;
		}
		if (IJEIEJLPGGJ != other.IJEIEJLPGGJ)
		{
			return false;
		}
		if (!dHHPEBDPKJJ_.Equals(other.dHHPEBDPKJJ_))
		{
			return false;
		}
		if (IDEAAPCCFPF != other.IDEAAPCCFPF)
		{
			return false;
		}
		if (IPCFJBAKLCG != other.IPCFJBAKLCG)
		{
			return false;
		}
		if (!nNFAFGCGMBB_.Equals(other.nNFAFGCGMBB_))
		{
			return false;
		}
		if (FGEDKOINMAG != other.FGEDKOINMAG)
		{
			return false;
		}
		if (!object.Equals(GCBBEEGANEG, other.GCBBEEGANEG))
		{
			return false;
		}
		if (EJEIBPEKHLD != other.EJEIBPEKHLD)
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
		if (gridFightDamageSttInfo_ != null)
		{
			num ^= GridFightDamageSttInfo.GetHashCode();
		}
		if (NDOCIKPLKIF != 0)
		{
			num ^= NDOCIKPLKIF.GetHashCode();
		}
		if (FHHPDFKLJKC != 0)
		{
			num ^= FHHPDFKLJKC.GetHashCode();
		}
		if (PNOJLNNHBIH != 0)
		{
			num ^= PNOJLNNHBIH.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (MKCHLGOGJNB != 0)
		{
			num ^= MKCHLGOGJNB.GetHashCode();
		}
		if (KDOINLGKMBI != 0)
		{
			num ^= KDOINLGKMBI.GetHashCode();
		}
		if (JGLEDADBNGP != 0)
		{
			num ^= JGLEDADBNGP.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (PACIAIJBOHO != 0)
		{
			num ^= PACIAIJBOHO.GetHashCode();
		}
		if (KIAFMFGAONA != 0)
		{
			num ^= KIAFMFGAONA.GetHashCode();
		}
		if (HPOACJCPJHN)
		{
			num ^= HPOACJCPJHN.GetHashCode();
		}
		num ^= DHMBKAPKJFN.GetHashCode();
		if (MAGCGPMHHEA != 0)
		{
			num ^= MAGCGPMHHEA.GetHashCode();
		}
		if (BCOLJFHDLLD != 0)
		{
			num ^= BCOLJFHDLLD.GetHashCode();
		}
		if (IJEIEJLPGGJ != 0)
		{
			num ^= IJEIEJLPGGJ.GetHashCode();
		}
		num ^= dHHPEBDPKJJ_.GetHashCode();
		if (IDEAAPCCFPF != 0)
		{
			num ^= IDEAAPCCFPF.GetHashCode();
		}
		if (IPCFJBAKLCG != 0)
		{
			num ^= IPCFJBAKLCG.GetHashCode();
		}
		num ^= nNFAFGCGMBB_.GetHashCode();
		if (FGEDKOINMAG != 0)
		{
			num ^= FGEDKOINMAG.GetHashCode();
		}
		if (gCBBEEGANEG_ != null)
		{
			num ^= GCBBEEGANEG.GetHashCode();
		}
		if (EJEIBPEKHLD != 0)
		{
			num ^= EJEIBPEKHLD.GetHashCode();
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
		if (gridFightDamageSttInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GridFightDamageSttInfo);
		}
		if (NDOCIKPLKIF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NDOCIKPLKIF);
		}
		if (FHHPDFKLJKC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FHHPDFKLJKC);
		}
		if (PNOJLNNHBIH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PNOJLNNHBIH);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (MKCHLGOGJNB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MKCHLGOGJNB);
		}
		if (KDOINLGKMBI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KDOINLGKMBI);
		}
		if (JGLEDADBNGP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JGLEDADBNGP);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(SectionId);
		}
		if (PACIAIJBOHO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PACIAIJBOHO);
		}
		if (KIAFMFGAONA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KIAFMFGAONA);
		}
		if (HPOACJCPJHN)
		{
			output.WriteRawTag(104);
			output.WriteBool(HPOACJCPJHN);
		}
		dHMBKAPKJFN_.WriteTo(ref output, _map_dHMBKAPKJFN_codec);
		if (MAGCGPMHHEA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MAGCGPMHHEA);
		}
		if (BCOLJFHDLLD != 0)
		{
			output.WriteRawTag(168, 4);
			output.WriteUInt32(BCOLJFHDLLD);
		}
		if (IJEIEJLPGGJ != 0)
		{
			output.WriteRawTag(144, 23);
			output.WriteUInt32(IJEIEJLPGGJ);
		}
		dHHPEBDPKJJ_.WriteTo(ref output, _repeated_dHHPEBDPKJJ_codec);
		if (IDEAAPCCFPF != 0)
		{
			output.WriteRawTag(192, 56);
			output.WriteUInt32(IDEAAPCCFPF);
		}
		if (IPCFJBAKLCG != 0)
		{
			output.WriteRawTag(168, 64);
			output.WriteUInt32(IPCFJBAKLCG);
		}
		nNFAFGCGMBB_.WriteTo(ref output, _repeated_nNFAFGCGMBB_codec);
		if (FGEDKOINMAG != 0)
		{
			output.WriteRawTag(184, 108);
			output.WriteUInt32(FGEDKOINMAG);
		}
		if (gCBBEEGANEG_ != null)
		{
			output.WriteRawTag(202, 111);
			output.WriteMessage(GCBBEEGANEG);
		}
		if (EJEIBPEKHLD != 0)
		{
			output.WriteRawTag(224, 127);
			output.WriteUInt32(EJEIBPEKHLD);
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
		if (gridFightDamageSttInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightDamageSttInfo);
		}
		if (NDOCIKPLKIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDOCIKPLKIF);
		}
		if (FHHPDFKLJKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHHPDFKLJKC);
		}
		if (PNOJLNNHBIH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNOJLNNHBIH);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (MKCHLGOGJNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKCHLGOGJNB);
		}
		if (KDOINLGKMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KDOINLGKMBI);
		}
		if (JGLEDADBNGP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGLEDADBNGP);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (PACIAIJBOHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PACIAIJBOHO);
		}
		if (KIAFMFGAONA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KIAFMFGAONA);
		}
		if (HPOACJCPJHN)
		{
			num += 2;
		}
		num += dHMBKAPKJFN_.CalculateSize(_map_dHMBKAPKJFN_codec);
		if (MAGCGPMHHEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAGCGPMHHEA);
		}
		if (BCOLJFHDLLD != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BCOLJFHDLLD);
		}
		if (IJEIEJLPGGJ != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(IJEIEJLPGGJ);
		}
		num += dHHPEBDPKJJ_.CalculateSize(_repeated_dHHPEBDPKJJ_codec);
		if (IDEAAPCCFPF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(IDEAAPCCFPF);
		}
		if (IPCFJBAKLCG != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(IPCFJBAKLCG);
		}
		num += nNFAFGCGMBB_.CalculateSize(_repeated_nNFAFGCGMBB_codec);
		if (FGEDKOINMAG != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(FGEDKOINMAG);
		}
		if (gCBBEEGANEG_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GCBBEEGANEG);
		}
		if (EJEIBPEKHLD != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EJEIBPEKHLD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEndBattleStageNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gridFightDamageSttInfo_ != null)
		{
			if (gridFightDamageSttInfo_ == null)
			{
				GridFightDamageSttInfo = new GridFightDamageSttInfo();
			}
			GridFightDamageSttInfo.MergeFrom(other.GridFightDamageSttInfo);
		}
		if (other.NDOCIKPLKIF != 0)
		{
			NDOCIKPLKIF = other.NDOCIKPLKIF;
		}
		if (other.FHHPDFKLJKC != 0)
		{
			FHHPDFKLJKC = other.FHHPDFKLJKC;
		}
		if (other.PNOJLNNHBIH != 0)
		{
			PNOJLNNHBIH = other.PNOJLNNHBIH;
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		if (other.MKCHLGOGJNB != 0)
		{
			MKCHLGOGJNB = other.MKCHLGOGJNB;
		}
		if (other.KDOINLGKMBI != 0)
		{
			KDOINLGKMBI = other.KDOINLGKMBI;
		}
		if (other.JGLEDADBNGP != 0)
		{
			JGLEDADBNGP = other.JGLEDADBNGP;
		}
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		if (other.PACIAIJBOHO != 0)
		{
			PACIAIJBOHO = other.PACIAIJBOHO;
		}
		if (other.KIAFMFGAONA != 0)
		{
			KIAFMFGAONA = other.KIAFMFGAONA;
		}
		if (other.HPOACJCPJHN)
		{
			HPOACJCPJHN = other.HPOACJCPJHN;
		}
		dHMBKAPKJFN_.MergeFrom(other.dHMBKAPKJFN_);
		if (other.MAGCGPMHHEA != 0)
		{
			MAGCGPMHHEA = other.MAGCGPMHHEA;
		}
		if (other.BCOLJFHDLLD != 0)
		{
			BCOLJFHDLLD = other.BCOLJFHDLLD;
		}
		if (other.IJEIEJLPGGJ != 0)
		{
			IJEIEJLPGGJ = other.IJEIEJLPGGJ;
		}
		dHHPEBDPKJJ_.Add(other.dHHPEBDPKJJ_);
		if (other.IDEAAPCCFPF != 0)
		{
			IDEAAPCCFPF = other.IDEAAPCCFPF;
		}
		if (other.IPCFJBAKLCG != 0)
		{
			IPCFJBAKLCG = other.IPCFJBAKLCG;
		}
		nNFAFGCGMBB_.Add(other.nNFAFGCGMBB_);
		if (other.FGEDKOINMAG != 0)
		{
			FGEDKOINMAG = other.FGEDKOINMAG;
		}
		if (other.gCBBEEGANEG_ != null)
		{
			if (gCBBEEGANEG_ == null)
			{
				GCBBEEGANEG = new MIOMFOAEHEC();
			}
			GCBBEEGANEG.MergeFrom(other.GCBBEEGANEG);
		}
		if (other.EJEIBPEKHLD != 0)
		{
			EJEIBPEKHLD = other.EJEIBPEKHLD;
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
				if (gridFightDamageSttInfo_ == null)
				{
					GridFightDamageSttInfo = new GridFightDamageSttInfo();
				}
				input.ReadMessage(GridFightDamageSttInfo);
				break;
			case 16u:
				NDOCIKPLKIF = input.ReadUInt32();
				break;
			case 24u:
				FHHPDFKLJKC = input.ReadUInt32();
				break;
			case 32u:
				PNOJLNNHBIH = input.ReadUInt32();
				break;
			case 40u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 48u:
				MKCHLGOGJNB = input.ReadUInt32();
				break;
			case 56u:
				KDOINLGKMBI = input.ReadUInt32();
				break;
			case 64u:
				JGLEDADBNGP = input.ReadUInt32();
				break;
			case 72u:
				SectionId = input.ReadUInt32();
				break;
			case 88u:
				PACIAIJBOHO = input.ReadUInt32();
				break;
			case 96u:
				KIAFMFGAONA = input.ReadUInt32();
				break;
			case 104u:
				HPOACJCPJHN = input.ReadBool();
				break;
			case 114u:
				dHMBKAPKJFN_.AddEntriesFrom(ref input, _map_dHMBKAPKJFN_codec);
				break;
			case 120u:
				MAGCGPMHHEA = input.ReadUInt32();
				break;
			case 552u:
				BCOLJFHDLLD = input.ReadUInt32();
				break;
			case 2960u:
				IJEIEJLPGGJ = input.ReadUInt32();
				break;
			case 5234u:
				dHHPEBDPKJJ_.AddEntriesFrom(ref input, _repeated_dHHPEBDPKJJ_codec);
				break;
			case 7232u:
				IDEAAPCCFPF = input.ReadUInt32();
				break;
			case 8232u:
				IPCFJBAKLCG = input.ReadUInt32();
				break;
			case 11306u:
				nNFAFGCGMBB_.AddEntriesFrom(ref input, _repeated_nNFAFGCGMBB_codec);
				break;
			case 13880u:
				FGEDKOINMAG = input.ReadUInt32();
				break;
			case 14282u:
				if (gCBBEEGANEG_ == null)
				{
					GCBBEEGANEG = new MIOMFOAEHEC();
				}
				input.ReadMessage(GCBBEEGANEG);
				break;
			case 16352u:
				EJEIBPEKHLD = input.ReadUInt32();
				break;
			}
		}
	}
}
