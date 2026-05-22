using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KKNDEDPDFFL : IMessage<KKNDEDPDFFL>, IMessage, IEquatable<KKNDEDPDFFL>, IDeepCloneable<KKNDEDPDFFL>, IBufferMessage
{
	private static readonly MessageParser<KKNDEDPDFFL> _parser = new MessageParser<KKNDEDPDFFL>(() => new KKNDEDPDFFL());

	private UnknownFieldSet _unknownFields;

	public const int LCDALEEEDJJFieldNumber = 1;

	private uint lCDALEEEDJJ_;

	public const int CAGMJCAPAALFieldNumber = 2;

	private bool cAGMJCAPAAL_;

	public const int OCEKFIEFMJDFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_oCEKFIEFMJD_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> oCEKFIEFMJD_ = new RepeatedField<uint>();

	public const int BKCLBLBGEMKFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_bKCLBLBGEMK_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> bKCLBLBGEMK_ = new RepeatedField<uint>();

	public const int JPFKOBEAJOGFieldNumber = 5;

	private uint jPFKOBEAJOG_;

	public const int FinishTimeFieldNumber = 6;

	private long finishTime_;

	public const int BDHGHALJJHCFieldNumber = 7;

	private uint bDHGHALJJHC_;

	public const int WorldLevelFieldNumber = 8;

	private uint worldLevel_;

	public const int DNNHCNCKJCMFieldNumber = 9;

	private long dNNHCNCKJCM_;

	public const int StatusFieldNumber = 10;

	private GGFCMMIFOHM status_;

	public const int BJIBAOBEAJJFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_bJIBAOBEAJJ_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> bJIBAOBEAJJ_ = new RepeatedField<uint>();

	public const int IsTakenRewardFieldNumber = 12;

	private bool isTakenReward_;

	public const int IPGLGFPMANLFieldNumber = 13;

	private static readonly FieldCodec<PileItem> _repeated_iPGLGFPMANL_codec = FieldCodec.ForMessage(106u, PileItem.Parser);

	private readonly RepeatedField<PileItem> iPGLGFPMANL_ = new RepeatedField<PileItem>();

	public const int GOEOGCJDACNFieldNumber = 14;

	private uint gOEOGCJDACN_;

	public const int GODBPOHKDOHFieldNumber = 736;

	private bool gODBPOHKDOH_;

	public const int GGALMCJNCNMFieldNumber = 783;

	private uint gGALMCJNCNM_;

	public const int NMEFGMICHONFieldNumber = 897;

	private uint nMEFGMICHON_;

	public const int BFEDHCOIOPNFieldNumber = 1035;

	private bool bFEDHCOIOPN_;

	public const int JOBDOFHGGLNFieldNumber = 1038;

	private ILMJJCJMIPB jOBDOFHGGLN_;

	public const int PPCAPBMKGACFieldNumber = 1269;

	private uint pPCAPBMKGAC_;

	public const int GEEFOKFBPDKFieldNumber = 2038;

	private uint gEEFOKFBPDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KKNDEDPDFFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KKNDEDPDFFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCDALEEEDJJ
	{
		get
		{
			return lCDALEEEDJJ_;
		}
		set
		{
			lCDALEEEDJJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CAGMJCAPAAL
	{
		get
		{
			return cAGMJCAPAAL_;
		}
		set
		{
			cAGMJCAPAAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OCEKFIEFMJD => oCEKFIEFMJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BKCLBLBGEMK => bKCLBLBGEMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JPFKOBEAJOG
	{
		get
		{
			return jPFKOBEAJOG_;
		}
		set
		{
			jPFKOBEAJOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FinishTime
	{
		get
		{
			return finishTime_;
		}
		set
		{
			finishTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BDHGHALJJHC
	{
		get
		{
			return bDHGHALJJHC_;
		}
		set
		{
			bDHGHALJJHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DNNHCNCKJCM
	{
		get
		{
			return dNNHCNCKJCM_;
		}
		set
		{
			dNNHCNCKJCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGFCMMIFOHM Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BJIBAOBEAJJ => bJIBAOBEAJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PileItem> IPGLGFPMANL => iPGLGFPMANL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GOEOGCJDACN
	{
		get
		{
			return gOEOGCJDACN_;
		}
		set
		{
			gOEOGCJDACN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GODBPOHKDOH
	{
		get
		{
			return gODBPOHKDOH_;
		}
		set
		{
			gODBPOHKDOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGALMCJNCNM
	{
		get
		{
			return gGALMCJNCNM_;
		}
		set
		{
			gGALMCJNCNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMEFGMICHON
	{
		get
		{
			return nMEFGMICHON_;
		}
		set
		{
			nMEFGMICHON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BFEDHCOIOPN
	{
		get
		{
			return bFEDHCOIOPN_;
		}
		set
		{
			bFEDHCOIOPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILMJJCJMIPB JOBDOFHGGLN
	{
		get
		{
			return jOBDOFHGGLN_;
		}
		set
		{
			jOBDOFHGGLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPCAPBMKGAC
	{
		get
		{
			return pPCAPBMKGAC_;
		}
		set
		{
			pPCAPBMKGAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GEEFOKFBPDK
	{
		get
		{
			return gEEFOKFBPDK_;
		}
		set
		{
			gEEFOKFBPDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNDEDPDFFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNDEDPDFFL(KKNDEDPDFFL other)
		: this()
	{
		lCDALEEEDJJ_ = other.lCDALEEEDJJ_;
		cAGMJCAPAAL_ = other.cAGMJCAPAAL_;
		oCEKFIEFMJD_ = other.oCEKFIEFMJD_.Clone();
		bKCLBLBGEMK_ = other.bKCLBLBGEMK_.Clone();
		jPFKOBEAJOG_ = other.jPFKOBEAJOG_;
		finishTime_ = other.finishTime_;
		bDHGHALJJHC_ = other.bDHGHALJJHC_;
		worldLevel_ = other.worldLevel_;
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		status_ = other.status_;
		bJIBAOBEAJJ_ = other.bJIBAOBEAJJ_.Clone();
		isTakenReward_ = other.isTakenReward_;
		iPGLGFPMANL_ = other.iPGLGFPMANL_.Clone();
		gOEOGCJDACN_ = other.gOEOGCJDACN_;
		gODBPOHKDOH_ = other.gODBPOHKDOH_;
		gGALMCJNCNM_ = other.gGALMCJNCNM_;
		nMEFGMICHON_ = other.nMEFGMICHON_;
		bFEDHCOIOPN_ = other.bFEDHCOIOPN_;
		jOBDOFHGGLN_ = ((other.jOBDOFHGGLN_ != null) ? other.jOBDOFHGGLN_.Clone() : null);
		pPCAPBMKGAC_ = other.pPCAPBMKGAC_;
		gEEFOKFBPDK_ = other.gEEFOKFBPDK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNDEDPDFFL Clone()
	{
		return new KKNDEDPDFFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KKNDEDPDFFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KKNDEDPDFFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LCDALEEEDJJ != other.LCDALEEEDJJ)
		{
			return false;
		}
		if (CAGMJCAPAAL != other.CAGMJCAPAAL)
		{
			return false;
		}
		if (!oCEKFIEFMJD_.Equals(other.oCEKFIEFMJD_))
		{
			return false;
		}
		if (!bKCLBLBGEMK_.Equals(other.bKCLBLBGEMK_))
		{
			return false;
		}
		if (JPFKOBEAJOG != other.JPFKOBEAJOG)
		{
			return false;
		}
		if (FinishTime != other.FinishTime)
		{
			return false;
		}
		if (BDHGHALJJHC != other.BDHGHALJJHC)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (!bJIBAOBEAJJ_.Equals(other.bJIBAOBEAJJ_))
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
		{
			return false;
		}
		if (!iPGLGFPMANL_.Equals(other.iPGLGFPMANL_))
		{
			return false;
		}
		if (GOEOGCJDACN != other.GOEOGCJDACN)
		{
			return false;
		}
		if (GODBPOHKDOH != other.GODBPOHKDOH)
		{
			return false;
		}
		if (GGALMCJNCNM != other.GGALMCJNCNM)
		{
			return false;
		}
		if (NMEFGMICHON != other.NMEFGMICHON)
		{
			return false;
		}
		if (BFEDHCOIOPN != other.BFEDHCOIOPN)
		{
			return false;
		}
		if (!object.Equals(JOBDOFHGGLN, other.JOBDOFHGGLN))
		{
			return false;
		}
		if (PPCAPBMKGAC != other.PPCAPBMKGAC)
		{
			return false;
		}
		if (GEEFOKFBPDK != other.GEEFOKFBPDK)
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
		if (LCDALEEEDJJ != 0)
		{
			num ^= LCDALEEEDJJ.GetHashCode();
		}
		if (CAGMJCAPAAL)
		{
			num ^= CAGMJCAPAAL.GetHashCode();
		}
		num ^= oCEKFIEFMJD_.GetHashCode();
		num ^= bKCLBLBGEMK_.GetHashCode();
		if (JPFKOBEAJOG != 0)
		{
			num ^= JPFKOBEAJOG.GetHashCode();
		}
		if (FinishTime != 0L)
		{
			num ^= FinishTime.GetHashCode();
		}
		if (BDHGHALJJHC != 0)
		{
			num ^= BDHGHALJJHC.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
		}
		if (Status != GGFCMMIFOHM.Djgmimchcmb)
		{
			num ^= Status.GetHashCode();
		}
		num ^= bJIBAOBEAJJ_.GetHashCode();
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
		}
		num ^= iPGLGFPMANL_.GetHashCode();
		if (GOEOGCJDACN != 0)
		{
			num ^= GOEOGCJDACN.GetHashCode();
		}
		if (GODBPOHKDOH)
		{
			num ^= GODBPOHKDOH.GetHashCode();
		}
		if (GGALMCJNCNM != 0)
		{
			num ^= GGALMCJNCNM.GetHashCode();
		}
		if (NMEFGMICHON != 0)
		{
			num ^= NMEFGMICHON.GetHashCode();
		}
		if (BFEDHCOIOPN)
		{
			num ^= BFEDHCOIOPN.GetHashCode();
		}
		if (jOBDOFHGGLN_ != null)
		{
			num ^= JOBDOFHGGLN.GetHashCode();
		}
		if (PPCAPBMKGAC != 0)
		{
			num ^= PPCAPBMKGAC.GetHashCode();
		}
		if (GEEFOKFBPDK != 0)
		{
			num ^= GEEFOKFBPDK.GetHashCode();
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
		if (LCDALEEEDJJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LCDALEEEDJJ);
		}
		if (CAGMJCAPAAL)
		{
			output.WriteRawTag(16);
			output.WriteBool(CAGMJCAPAAL);
		}
		oCEKFIEFMJD_.WriteTo(ref output, _repeated_oCEKFIEFMJD_codec);
		bKCLBLBGEMK_.WriteTo(ref output, _repeated_bKCLBLBGEMK_codec);
		if (JPFKOBEAJOG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JPFKOBEAJOG);
		}
		if (FinishTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(FinishTime);
		}
		if (BDHGHALJJHC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BDHGHALJJHC);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(WorldLevel);
		}
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(DNNHCNCKJCM);
		}
		if (Status != GGFCMMIFOHM.Djgmimchcmb)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)Status);
		}
		bJIBAOBEAJJ_.WriteTo(ref output, _repeated_bJIBAOBEAJJ_codec);
		if (IsTakenReward)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsTakenReward);
		}
		iPGLGFPMANL_.WriteTo(ref output, _repeated_iPGLGFPMANL_codec);
		if (GOEOGCJDACN != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GOEOGCJDACN);
		}
		if (GODBPOHKDOH)
		{
			output.WriteRawTag(128, 46);
			output.WriteBool(GODBPOHKDOH);
		}
		if (GGALMCJNCNM != 0)
		{
			output.WriteRawTag(248, 48);
			output.WriteUInt32(GGALMCJNCNM);
		}
		if (NMEFGMICHON != 0)
		{
			output.WriteRawTag(136, 56);
			output.WriteUInt32(NMEFGMICHON);
		}
		if (BFEDHCOIOPN)
		{
			output.WriteRawTag(216, 64);
			output.WriteBool(BFEDHCOIOPN);
		}
		if (jOBDOFHGGLN_ != null)
		{
			output.WriteRawTag(242, 64);
			output.WriteMessage(JOBDOFHGGLN);
		}
		if (PPCAPBMKGAC != 0)
		{
			output.WriteRawTag(168, 79);
			output.WriteUInt32(PPCAPBMKGAC);
		}
		if (GEEFOKFBPDK != 0)
		{
			output.WriteRawTag(176, 127);
			output.WriteUInt32(GEEFOKFBPDK);
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
		if (LCDALEEEDJJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCDALEEEDJJ);
		}
		if (CAGMJCAPAAL)
		{
			num += 2;
		}
		num += oCEKFIEFMJD_.CalculateSize(_repeated_oCEKFIEFMJD_codec);
		num += bKCLBLBGEMK_.CalculateSize(_repeated_bKCLBLBGEMK_codec);
		if (JPFKOBEAJOG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JPFKOBEAJOG);
		}
		if (FinishTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(FinishTime);
		}
		if (BDHGHALJJHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BDHGHALJJHC);
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		if (Status != GGFCMMIFOHM.Djgmimchcmb)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		num += bJIBAOBEAJJ_.CalculateSize(_repeated_bJIBAOBEAJJ_codec);
		if (IsTakenReward)
		{
			num += 2;
		}
		num += iPGLGFPMANL_.CalculateSize(_repeated_iPGLGFPMANL_codec);
		if (GOEOGCJDACN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GOEOGCJDACN);
		}
		if (GODBPOHKDOH)
		{
			num += 3;
		}
		if (GGALMCJNCNM != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GGALMCJNCNM);
		}
		if (NMEFGMICHON != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(NMEFGMICHON);
		}
		if (BFEDHCOIOPN)
		{
			num += 3;
		}
		if (jOBDOFHGGLN_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JOBDOFHGGLN);
		}
		if (PPCAPBMKGAC != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PPCAPBMKGAC);
		}
		if (GEEFOKFBPDK != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GEEFOKFBPDK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KKNDEDPDFFL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LCDALEEEDJJ != 0)
		{
			LCDALEEEDJJ = other.LCDALEEEDJJ;
		}
		if (other.CAGMJCAPAAL)
		{
			CAGMJCAPAAL = other.CAGMJCAPAAL;
		}
		oCEKFIEFMJD_.Add(other.oCEKFIEFMJD_);
		bKCLBLBGEMK_.Add(other.bKCLBLBGEMK_);
		if (other.JPFKOBEAJOG != 0)
		{
			JPFKOBEAJOG = other.JPFKOBEAJOG;
		}
		if (other.FinishTime != 0L)
		{
			FinishTime = other.FinishTime;
		}
		if (other.BDHGHALJJHC != 0)
		{
			BDHGHALJJHC = other.BDHGHALJJHC;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.DNNHCNCKJCM != 0L)
		{
			DNNHCNCKJCM = other.DNNHCNCKJCM;
		}
		if (other.Status != GGFCMMIFOHM.Djgmimchcmb)
		{
			Status = other.Status;
		}
		bJIBAOBEAJJ_.Add(other.bJIBAOBEAJJ_);
		if (other.IsTakenReward)
		{
			IsTakenReward = other.IsTakenReward;
		}
		iPGLGFPMANL_.Add(other.iPGLGFPMANL_);
		if (other.GOEOGCJDACN != 0)
		{
			GOEOGCJDACN = other.GOEOGCJDACN;
		}
		if (other.GODBPOHKDOH)
		{
			GODBPOHKDOH = other.GODBPOHKDOH;
		}
		if (other.GGALMCJNCNM != 0)
		{
			GGALMCJNCNM = other.GGALMCJNCNM;
		}
		if (other.NMEFGMICHON != 0)
		{
			NMEFGMICHON = other.NMEFGMICHON;
		}
		if (other.BFEDHCOIOPN)
		{
			BFEDHCOIOPN = other.BFEDHCOIOPN;
		}
		if (other.jOBDOFHGGLN_ != null)
		{
			if (jOBDOFHGGLN_ == null)
			{
				JOBDOFHGGLN = new ILMJJCJMIPB();
			}
			JOBDOFHGGLN.MergeFrom(other.JOBDOFHGGLN);
		}
		if (other.PPCAPBMKGAC != 0)
		{
			PPCAPBMKGAC = other.PPCAPBMKGAC;
		}
		if (other.GEEFOKFBPDK != 0)
		{
			GEEFOKFBPDK = other.GEEFOKFBPDK;
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
				LCDALEEEDJJ = input.ReadUInt32();
				break;
			case 16u:
				CAGMJCAPAAL = input.ReadBool();
				break;
			case 24u:
			case 26u:
				oCEKFIEFMJD_.AddEntriesFrom(ref input, _repeated_oCEKFIEFMJD_codec);
				break;
			case 32u:
			case 34u:
				bKCLBLBGEMK_.AddEntriesFrom(ref input, _repeated_bKCLBLBGEMK_codec);
				break;
			case 40u:
				JPFKOBEAJOG = input.ReadUInt32();
				break;
			case 48u:
				FinishTime = input.ReadInt64();
				break;
			case 56u:
				BDHGHALJJHC = input.ReadUInt32();
				break;
			case 64u:
				WorldLevel = input.ReadUInt32();
				break;
			case 72u:
				DNNHCNCKJCM = input.ReadInt64();
				break;
			case 80u:
				Status = (GGFCMMIFOHM)input.ReadEnum();
				break;
			case 88u:
			case 90u:
				bJIBAOBEAJJ_.AddEntriesFrom(ref input, _repeated_bJIBAOBEAJJ_codec);
				break;
			case 96u:
				IsTakenReward = input.ReadBool();
				break;
			case 106u:
				iPGLGFPMANL_.AddEntriesFrom(ref input, _repeated_iPGLGFPMANL_codec);
				break;
			case 112u:
				GOEOGCJDACN = input.ReadUInt32();
				break;
			case 5888u:
				GODBPOHKDOH = input.ReadBool();
				break;
			case 6264u:
				GGALMCJNCNM = input.ReadUInt32();
				break;
			case 7176u:
				NMEFGMICHON = input.ReadUInt32();
				break;
			case 8280u:
				BFEDHCOIOPN = input.ReadBool();
				break;
			case 8306u:
				if (jOBDOFHGGLN_ == null)
				{
					JOBDOFHGGLN = new ILMJJCJMIPB();
				}
				input.ReadMessage(JOBDOFHGGLN);
				break;
			case 10152u:
				PPCAPBMKGAC = input.ReadUInt32();
				break;
			case 16304u:
				GEEFOKFBPDK = input.ReadUInt32();
				break;
			}
		}
	}
}
