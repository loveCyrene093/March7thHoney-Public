using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPlanetFesDataScRsp : IMessage<GetPlanetFesDataScRsp>, IMessage, IEquatable<GetPlanetFesDataScRsp>, IDeepCloneable<GetPlanetFesDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPlanetFesDataScRsp> _parser = new MessageParser<GetPlanetFesDataScRsp>(() => new GetPlanetFesDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int KKCLNDFBPHBFieldNumber = 2;

	private EONNKCKPDKI kKCLNDFBPHB_;

	public const int EFIMNEGGKMHFieldNumber = 3;

	private OHLCKLEKPIN eFIMNEGGKMH_;

	public const int OPELALIBCILFieldNumber = 4;

	private BKNPGKNIOMG oPELALIBCIL_;

	public const int CustomValueListFieldNumber = 6;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_customValueList_codec = FieldCodec.ForMessage(50u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> customValueList_ = new RepeatedField<GKDEKJKOIJN>();

	public const int FKEHOGMGLJFFieldNumber = 7;

	private IPBGEGBFFHK fKEHOGMGLJF_;

	public const int NOLBPBMHOKAFieldNumber = 8;

	private GKMGHIBOOFE nOLBPBMHOKA_;

	public const int GOFFALBLHHNFieldNumber = 9;

	private NOAMCBLCAMH gOFFALBLHHN_;

	public const int PEABLDFCMICFieldNumber = 10;

	private OGACFIPDECD pEABLDFCMIC_;

	public const int SkillInfoFieldNumber = 11;

	private IPNPJJPPCCC skillInfo_;

	public const int OBOOODMPBBHFieldNumber = 12;

	private LLAGEIKJBJA oBOOODMPBBH_;

	public const int FCAPBPHLNCJFieldNumber = 14;

	private BCHDPKABMNO fCAPBPHLNCJ_;

	public const int MODDIBHCPPDFieldNumber = 15;

	private JBMMIPAGDCE mODDIBHCPPD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPlanetFesDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPlanetFesDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EONNKCKPDKI KKCLNDFBPHB
	{
		get
		{
			return kKCLNDFBPHB_;
		}
		set
		{
			kKCLNDFBPHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHLCKLEKPIN EFIMNEGGKMH
	{
		get
		{
			return eFIMNEGGKMH_;
		}
		set
		{
			eFIMNEGGKMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKNPGKNIOMG OPELALIBCIL
	{
		get
		{
			return oPELALIBCIL_;
		}
		set
		{
			oPELALIBCIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> CustomValueList => customValueList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPBGEGBFFHK FKEHOGMGLJF
	{
		get
		{
			return fKEHOGMGLJF_;
		}
		set
		{
			fKEHOGMGLJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKMGHIBOOFE NOLBPBMHOKA
	{
		get
		{
			return nOLBPBMHOKA_;
		}
		set
		{
			nOLBPBMHOKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOAMCBLCAMH GOFFALBLHHN
	{
		get
		{
			return gOFFALBLHHN_;
		}
		set
		{
			gOFFALBLHHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGACFIPDECD PEABLDFCMIC
	{
		get
		{
			return pEABLDFCMIC_;
		}
		set
		{
			pEABLDFCMIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPNPJJPPCCC SkillInfo
	{
		get
		{
			return skillInfo_;
		}
		set
		{
			skillInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLAGEIKJBJA OBOOODMPBBH
	{
		get
		{
			return oBOOODMPBBH_;
		}
		set
		{
			oBOOODMPBBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCHDPKABMNO FCAPBPHLNCJ
	{
		get
		{
			return fCAPBPHLNCJ_;
		}
		set
		{
			fCAPBPHLNCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBMMIPAGDCE MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlanetFesDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlanetFesDataScRsp(GetPlanetFesDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		kKCLNDFBPHB_ = ((other.kKCLNDFBPHB_ != null) ? other.kKCLNDFBPHB_.Clone() : null);
		eFIMNEGGKMH_ = ((other.eFIMNEGGKMH_ != null) ? other.eFIMNEGGKMH_.Clone() : null);
		oPELALIBCIL_ = ((other.oPELALIBCIL_ != null) ? other.oPELALIBCIL_.Clone() : null);
		customValueList_ = other.customValueList_.Clone();
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		nOLBPBMHOKA_ = ((other.nOLBPBMHOKA_ != null) ? other.nOLBPBMHOKA_.Clone() : null);
		gOFFALBLHHN_ = ((other.gOFFALBLHHN_ != null) ? other.gOFFALBLHHN_.Clone() : null);
		pEABLDFCMIC_ = ((other.pEABLDFCMIC_ != null) ? other.pEABLDFCMIC_.Clone() : null);
		skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
		oBOOODMPBBH_ = ((other.oBOOODMPBBH_ != null) ? other.oBOOODMPBBH_.Clone() : null);
		fCAPBPHLNCJ_ = ((other.fCAPBPHLNCJ_ != null) ? other.fCAPBPHLNCJ_.Clone() : null);
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlanetFesDataScRsp Clone()
	{
		return new GetPlanetFesDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPlanetFesDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPlanetFesDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(KKCLNDFBPHB, other.KKCLNDFBPHB))
		{
			return false;
		}
		if (!object.Equals(EFIMNEGGKMH, other.EFIMNEGGKMH))
		{
			return false;
		}
		if (!object.Equals(OPELALIBCIL, other.OPELALIBCIL))
		{
			return false;
		}
		if (!customValueList_.Equals(other.customValueList_))
		{
			return false;
		}
		if (!object.Equals(FKEHOGMGLJF, other.FKEHOGMGLJF))
		{
			return false;
		}
		if (!object.Equals(NOLBPBMHOKA, other.NOLBPBMHOKA))
		{
			return false;
		}
		if (!object.Equals(GOFFALBLHHN, other.GOFFALBLHHN))
		{
			return false;
		}
		if (!object.Equals(PEABLDFCMIC, other.PEABLDFCMIC))
		{
			return false;
		}
		if (!object.Equals(SkillInfo, other.SkillInfo))
		{
			return false;
		}
		if (!object.Equals(OBOOODMPBBH, other.OBOOODMPBBH))
		{
			return false;
		}
		if (!object.Equals(FCAPBPHLNCJ, other.FCAPBPHLNCJ))
		{
			return false;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (kKCLNDFBPHB_ != null)
		{
			num ^= KKCLNDFBPHB.GetHashCode();
		}
		if (eFIMNEGGKMH_ != null)
		{
			num ^= EFIMNEGGKMH.GetHashCode();
		}
		if (oPELALIBCIL_ != null)
		{
			num ^= OPELALIBCIL.GetHashCode();
		}
		num ^= customValueList_.GetHashCode();
		if (fKEHOGMGLJF_ != null)
		{
			num ^= FKEHOGMGLJF.GetHashCode();
		}
		if (nOLBPBMHOKA_ != null)
		{
			num ^= NOLBPBMHOKA.GetHashCode();
		}
		if (gOFFALBLHHN_ != null)
		{
			num ^= GOFFALBLHHN.GetHashCode();
		}
		if (pEABLDFCMIC_ != null)
		{
			num ^= PEABLDFCMIC.GetHashCode();
		}
		if (skillInfo_ != null)
		{
			num ^= SkillInfo.GetHashCode();
		}
		if (oBOOODMPBBH_ != null)
		{
			num ^= OBOOODMPBBH.GetHashCode();
		}
		if (fCAPBPHLNCJ_ != null)
		{
			num ^= FCAPBPHLNCJ.GetHashCode();
		}
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (kKCLNDFBPHB_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(KKCLNDFBPHB);
		}
		if (eFIMNEGGKMH_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EFIMNEGGKMH);
		}
		if (oPELALIBCIL_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OPELALIBCIL);
		}
		customValueList_.WriteTo(ref output, _repeated_customValueList_codec);
		if (fKEHOGMGLJF_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FKEHOGMGLJF);
		}
		if (nOLBPBMHOKA_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(NOLBPBMHOKA);
		}
		if (gOFFALBLHHN_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GOFFALBLHHN);
		}
		if (pEABLDFCMIC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(PEABLDFCMIC);
		}
		if (skillInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(SkillInfo);
		}
		if (oBOOODMPBBH_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(OBOOODMPBBH);
		}
		if (fCAPBPHLNCJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(FCAPBPHLNCJ);
		}
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(MODDIBHCPPD);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (kKCLNDFBPHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKCLNDFBPHB);
		}
		if (eFIMNEGGKMH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFIMNEGGKMH);
		}
		if (oPELALIBCIL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OPELALIBCIL);
		}
		num += customValueList_.CalculateSize(_repeated_customValueList_codec);
		if (fKEHOGMGLJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKEHOGMGLJF);
		}
		if (nOLBPBMHOKA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOLBPBMHOKA);
		}
		if (gOFFALBLHHN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GOFFALBLHHN);
		}
		if (pEABLDFCMIC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEABLDFCMIC);
		}
		if (skillInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SkillInfo);
		}
		if (oBOOODMPBBH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OBOOODMPBBH);
		}
		if (fCAPBPHLNCJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCAPBPHLNCJ);
		}
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPlanetFesDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.kKCLNDFBPHB_ != null)
		{
			if (kKCLNDFBPHB_ == null)
			{
				KKCLNDFBPHB = new EONNKCKPDKI();
			}
			KKCLNDFBPHB.MergeFrom(other.KKCLNDFBPHB);
		}
		if (other.eFIMNEGGKMH_ != null)
		{
			if (eFIMNEGGKMH_ == null)
			{
				EFIMNEGGKMH = new OHLCKLEKPIN();
			}
			EFIMNEGGKMH.MergeFrom(other.EFIMNEGGKMH);
		}
		if (other.oPELALIBCIL_ != null)
		{
			if (oPELALIBCIL_ == null)
			{
				OPELALIBCIL = new BKNPGKNIOMG();
			}
			OPELALIBCIL.MergeFrom(other.OPELALIBCIL);
		}
		customValueList_.Add(other.customValueList_);
		if (other.fKEHOGMGLJF_ != null)
		{
			if (fKEHOGMGLJF_ == null)
			{
				FKEHOGMGLJF = new IPBGEGBFFHK();
			}
			FKEHOGMGLJF.MergeFrom(other.FKEHOGMGLJF);
		}
		if (other.nOLBPBMHOKA_ != null)
		{
			if (nOLBPBMHOKA_ == null)
			{
				NOLBPBMHOKA = new GKMGHIBOOFE();
			}
			NOLBPBMHOKA.MergeFrom(other.NOLBPBMHOKA);
		}
		if (other.gOFFALBLHHN_ != null)
		{
			if (gOFFALBLHHN_ == null)
			{
				GOFFALBLHHN = new NOAMCBLCAMH();
			}
			GOFFALBLHHN.MergeFrom(other.GOFFALBLHHN);
		}
		if (other.pEABLDFCMIC_ != null)
		{
			if (pEABLDFCMIC_ == null)
			{
				PEABLDFCMIC = new OGACFIPDECD();
			}
			PEABLDFCMIC.MergeFrom(other.PEABLDFCMIC);
		}
		if (other.skillInfo_ != null)
		{
			if (skillInfo_ == null)
			{
				SkillInfo = new IPNPJJPPCCC();
			}
			SkillInfo.MergeFrom(other.SkillInfo);
		}
		if (other.oBOOODMPBBH_ != null)
		{
			if (oBOOODMPBBH_ == null)
			{
				OBOOODMPBBH = new LLAGEIKJBJA();
			}
			OBOOODMPBBH.MergeFrom(other.OBOOODMPBBH);
		}
		if (other.fCAPBPHLNCJ_ != null)
		{
			if (fCAPBPHLNCJ_ == null)
			{
				FCAPBPHLNCJ = new BCHDPKABMNO();
			}
			FCAPBPHLNCJ.MergeFrom(other.FCAPBPHLNCJ);
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new JBMMIPAGDCE();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
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
				Retcode = input.ReadUInt32();
				break;
			case 18u:
				if (kKCLNDFBPHB_ == null)
				{
					KKCLNDFBPHB = new EONNKCKPDKI();
				}
				input.ReadMessage(KKCLNDFBPHB);
				break;
			case 26u:
				if (eFIMNEGGKMH_ == null)
				{
					EFIMNEGGKMH = new OHLCKLEKPIN();
				}
				input.ReadMessage(EFIMNEGGKMH);
				break;
			case 34u:
				if (oPELALIBCIL_ == null)
				{
					OPELALIBCIL = new BKNPGKNIOMG();
				}
				input.ReadMessage(OPELALIBCIL);
				break;
			case 50u:
				customValueList_.AddEntriesFrom(ref input, _repeated_customValueList_codec);
				break;
			case 58u:
				if (fKEHOGMGLJF_ == null)
				{
					FKEHOGMGLJF = new IPBGEGBFFHK();
				}
				input.ReadMessage(FKEHOGMGLJF);
				break;
			case 66u:
				if (nOLBPBMHOKA_ == null)
				{
					NOLBPBMHOKA = new GKMGHIBOOFE();
				}
				input.ReadMessage(NOLBPBMHOKA);
				break;
			case 74u:
				if (gOFFALBLHHN_ == null)
				{
					GOFFALBLHHN = new NOAMCBLCAMH();
				}
				input.ReadMessage(GOFFALBLHHN);
				break;
			case 82u:
				if (pEABLDFCMIC_ == null)
				{
					PEABLDFCMIC = new OGACFIPDECD();
				}
				input.ReadMessage(PEABLDFCMIC);
				break;
			case 90u:
				if (skillInfo_ == null)
				{
					SkillInfo = new IPNPJJPPCCC();
				}
				input.ReadMessage(SkillInfo);
				break;
			case 98u:
				if (oBOOODMPBBH_ == null)
				{
					OBOOODMPBBH = new LLAGEIKJBJA();
				}
				input.ReadMessage(OBOOODMPBBH);
				break;
			case 114u:
				if (fCAPBPHLNCJ_ == null)
				{
					FCAPBPHLNCJ = new BCHDPKABMNO();
				}
				input.ReadMessage(FCAPBPHLNCJ);
				break;
			case 122u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new JBMMIPAGDCE();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			}
		}
	}
}
