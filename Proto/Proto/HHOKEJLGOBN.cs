using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHOKEJLGOBN : IMessage<HHOKEJLGOBN>, IMessage, IEquatable<HHOKEJLGOBN>, IDeepCloneable<HHOKEJLGOBN>, IBufferMessage
{
	private static readonly MessageParser<HHOKEJLGOBN> _parser = new MessageParser<HHOKEJLGOBN>(() => new HHOKEJLGOBN());

	private UnknownFieldSet _unknownFields;

	public const int EKDJEMEEHGAFieldNumber = 1;

	private static readonly FieldCodec<LDPLIJAMIOE> _repeated_eKDJEMEEHGA_codec = FieldCodec.ForMessage(10u, LDPLIJAMIOE.Parser);

	private readonly RepeatedField<LDPLIJAMIOE> eKDJEMEEHGA_ = new RepeatedField<LDPLIJAMIOE>();

	public const int CGIKOKLGDEAFieldNumber = 3;

	private LDPLIJAMIOE cGIKOKLGDEA_;

	public const int MALIIHMMDFPFieldNumber = 4;

	private LKBIPKDKDNP mALIIHMMDFP_;

	public const int GIIJHNMLOCBFieldNumber = 5;

	private DCDCGEIELJI gIIJHNMLOCB_;

	public const int INKGMFFPLHFFieldNumber = 6;

	private static readonly FieldCodec<KBOJACAEADL> _repeated_iNKGMFFPLHF_codec = FieldCodec.ForMessage(50u, KBOJACAEADL.Parser);

	private readonly RepeatedField<KBOJACAEADL> iNKGMFFPLHF_ = new RepeatedField<KBOJACAEADL>();

	public const int GBAEMAHODABFieldNumber = 7;

	private static readonly FieldCodec<HKLCEEEJIGO> _repeated_gBAEMAHODAB_codec = FieldCodec.ForMessage(58u, HKLCEEEJIGO.Parser);

	private readonly RepeatedField<HKLCEEEJIGO> gBAEMAHODAB_ = new RepeatedField<HKLCEEEJIGO>();

	public const int CKFBMAJMMACFieldNumber = 9;

	private static readonly FieldCodec<LDPLIJAMIOE> _repeated_cKFBMAJMMAC_codec = FieldCodec.ForMessage(74u, LDPLIJAMIOE.Parser);

	private readonly RepeatedField<LDPLIJAMIOE> cKFBMAJMMAC_ = new RepeatedField<LDPLIJAMIOE>();

	public const int NFPBAKBCCHGFieldNumber = 10;

	private uint nFPBAKBCCHG_;

	public const int PPNHNDEOOLJFieldNumber = 11;

	private ulong pPNHNDEOOLJ_;

	public const int NONMONPHBPEFieldNumber = 12;

	private bool nONMONPHBPE_;

	public const int NEBGNOFPAGEFieldNumber = 13;

	private static readonly FieldCodec<PHHKNAADBHA> _repeated_nEBGNOFPAGE_codec = FieldCodec.ForMessage(106u, PHHKNAADBHA.Parser);

	private readonly RepeatedField<PHHKNAADBHA> nEBGNOFPAGE_ = new RepeatedField<PHHKNAADBHA>();

	public const int DIKCBKKNINMFieldNumber = 14;

	private static readonly FieldCodec<GKDDGHBGGAM> _repeated_dIKCBKKNINM_codec = FieldCodec.ForMessage(114u, GKDDGHBGGAM.Parser);

	private readonly RepeatedField<GKDDGHBGGAM> dIKCBKKNINM_ = new RepeatedField<GKDDGHBGGAM>();

	public const int DDLHPDBHGJDFieldNumber = 15;

	private static readonly FieldCodec<KNGLMKEJBAB> _repeated_dDLHPDBHGJD_codec = FieldCodec.ForMessage(122u, KNGLMKEJBAB.Parser);

	private readonly RepeatedField<KNGLMKEJBAB> dDLHPDBHGJD_ = new RepeatedField<KNGLMKEJBAB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHOKEJLGOBN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHOKEJLGOBNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDPLIJAMIOE> EKDJEMEEHGA => eKDJEMEEHGA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDPLIJAMIOE CGIKOKLGDEA
	{
		get
		{
			return cGIKOKLGDEA_;
		}
		set
		{
			cGIKOKLGDEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBIPKDKDNP MALIIHMMDFP
	{
		get
		{
			return mALIIHMMDFP_;
		}
		set
		{
			mALIIHMMDFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCDCGEIELJI GIIJHNMLOCB
	{
		get
		{
			return gIIJHNMLOCB_;
		}
		set
		{
			gIIJHNMLOCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KBOJACAEADL> INKGMFFPLHF => iNKGMFFPLHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HKLCEEEJIGO> GBAEMAHODAB => gBAEMAHODAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDPLIJAMIOE> CKFBMAJMMAC => cKFBMAJMMAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFPBAKBCCHG
	{
		get
		{
			return nFPBAKBCCHG_;
		}
		set
		{
			nFPBAKBCCHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PPNHNDEOOLJ
	{
		get
		{
			return pPNHNDEOOLJ_;
		}
		set
		{
			pPNHNDEOOLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NONMONPHBPE
	{
		get
		{
			return nONMONPHBPE_;
		}
		set
		{
			nONMONPHBPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PHHKNAADBHA> NEBGNOFPAGE => nEBGNOFPAGE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDDGHBGGAM> DIKCBKKNINM => dIKCBKKNINM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNGLMKEJBAB> DDLHPDBHGJD => dDLHPDBHGJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHOKEJLGOBN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHOKEJLGOBN(HHOKEJLGOBN other)
		: this()
	{
		eKDJEMEEHGA_ = other.eKDJEMEEHGA_.Clone();
		cGIKOKLGDEA_ = ((other.cGIKOKLGDEA_ != null) ? other.cGIKOKLGDEA_.Clone() : null);
		mALIIHMMDFP_ = ((other.mALIIHMMDFP_ != null) ? other.mALIIHMMDFP_.Clone() : null);
		gIIJHNMLOCB_ = ((other.gIIJHNMLOCB_ != null) ? other.gIIJHNMLOCB_.Clone() : null);
		iNKGMFFPLHF_ = other.iNKGMFFPLHF_.Clone();
		gBAEMAHODAB_ = other.gBAEMAHODAB_.Clone();
		cKFBMAJMMAC_ = other.cKFBMAJMMAC_.Clone();
		nFPBAKBCCHG_ = other.nFPBAKBCCHG_;
		pPNHNDEOOLJ_ = other.pPNHNDEOOLJ_;
		nONMONPHBPE_ = other.nONMONPHBPE_;
		nEBGNOFPAGE_ = other.nEBGNOFPAGE_.Clone();
		dIKCBKKNINM_ = other.dIKCBKKNINM_.Clone();
		dDLHPDBHGJD_ = other.dDLHPDBHGJD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHOKEJLGOBN Clone()
	{
		return new HHOKEJLGOBN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHOKEJLGOBN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHOKEJLGOBN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eKDJEMEEHGA_.Equals(other.eKDJEMEEHGA_))
		{
			return false;
		}
		if (!object.Equals(CGIKOKLGDEA, other.CGIKOKLGDEA))
		{
			return false;
		}
		if (!object.Equals(MALIIHMMDFP, other.MALIIHMMDFP))
		{
			return false;
		}
		if (!object.Equals(GIIJHNMLOCB, other.GIIJHNMLOCB))
		{
			return false;
		}
		if (!iNKGMFFPLHF_.Equals(other.iNKGMFFPLHF_))
		{
			return false;
		}
		if (!gBAEMAHODAB_.Equals(other.gBAEMAHODAB_))
		{
			return false;
		}
		if (!cKFBMAJMMAC_.Equals(other.cKFBMAJMMAC_))
		{
			return false;
		}
		if (NFPBAKBCCHG != other.NFPBAKBCCHG)
		{
			return false;
		}
		if (PPNHNDEOOLJ != other.PPNHNDEOOLJ)
		{
			return false;
		}
		if (NONMONPHBPE != other.NONMONPHBPE)
		{
			return false;
		}
		if (!nEBGNOFPAGE_.Equals(other.nEBGNOFPAGE_))
		{
			return false;
		}
		if (!dIKCBKKNINM_.Equals(other.dIKCBKKNINM_))
		{
			return false;
		}
		if (!dDLHPDBHGJD_.Equals(other.dDLHPDBHGJD_))
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
		num ^= eKDJEMEEHGA_.GetHashCode();
		if (cGIKOKLGDEA_ != null)
		{
			num ^= CGIKOKLGDEA.GetHashCode();
		}
		if (mALIIHMMDFP_ != null)
		{
			num ^= MALIIHMMDFP.GetHashCode();
		}
		if (gIIJHNMLOCB_ != null)
		{
			num ^= GIIJHNMLOCB.GetHashCode();
		}
		num ^= iNKGMFFPLHF_.GetHashCode();
		num ^= gBAEMAHODAB_.GetHashCode();
		num ^= cKFBMAJMMAC_.GetHashCode();
		if (NFPBAKBCCHG != 0)
		{
			num ^= NFPBAKBCCHG.GetHashCode();
		}
		if (PPNHNDEOOLJ != 0L)
		{
			num ^= PPNHNDEOOLJ.GetHashCode();
		}
		if (NONMONPHBPE)
		{
			num ^= NONMONPHBPE.GetHashCode();
		}
		num ^= nEBGNOFPAGE_.GetHashCode();
		num ^= dIKCBKKNINM_.GetHashCode();
		num ^= dDLHPDBHGJD_.GetHashCode();
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
		eKDJEMEEHGA_.WriteTo(ref output, _repeated_eKDJEMEEHGA_codec);
		if (cGIKOKLGDEA_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CGIKOKLGDEA);
		}
		if (mALIIHMMDFP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MALIIHMMDFP);
		}
		if (gIIJHNMLOCB_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GIIJHNMLOCB);
		}
		iNKGMFFPLHF_.WriteTo(ref output, _repeated_iNKGMFFPLHF_codec);
		gBAEMAHODAB_.WriteTo(ref output, _repeated_gBAEMAHODAB_codec);
		cKFBMAJMMAC_.WriteTo(ref output, _repeated_cKFBMAJMMAC_codec);
		if (NFPBAKBCCHG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NFPBAKBCCHG);
		}
		if (PPNHNDEOOLJ != 0L)
		{
			output.WriteRawTag(88);
			output.WriteUInt64(PPNHNDEOOLJ);
		}
		if (NONMONPHBPE)
		{
			output.WriteRawTag(96);
			output.WriteBool(NONMONPHBPE);
		}
		nEBGNOFPAGE_.WriteTo(ref output, _repeated_nEBGNOFPAGE_codec);
		dIKCBKKNINM_.WriteTo(ref output, _repeated_dIKCBKKNINM_codec);
		dDLHPDBHGJD_.WriteTo(ref output, _repeated_dDLHPDBHGJD_codec);
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
		num += eKDJEMEEHGA_.CalculateSize(_repeated_eKDJEMEEHGA_codec);
		if (cGIKOKLGDEA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGIKOKLGDEA);
		}
		if (mALIIHMMDFP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MALIIHMMDFP);
		}
		if (gIIJHNMLOCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GIIJHNMLOCB);
		}
		num += iNKGMFFPLHF_.CalculateSize(_repeated_iNKGMFFPLHF_codec);
		num += gBAEMAHODAB_.CalculateSize(_repeated_gBAEMAHODAB_codec);
		num += cKFBMAJMMAC_.CalculateSize(_repeated_cKFBMAJMMAC_codec);
		if (NFPBAKBCCHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFPBAKBCCHG);
		}
		if (PPNHNDEOOLJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PPNHNDEOOLJ);
		}
		if (NONMONPHBPE)
		{
			num += 2;
		}
		num += nEBGNOFPAGE_.CalculateSize(_repeated_nEBGNOFPAGE_codec);
		num += dIKCBKKNINM_.CalculateSize(_repeated_dIKCBKKNINM_codec);
		num += dDLHPDBHGJD_.CalculateSize(_repeated_dDLHPDBHGJD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHOKEJLGOBN other)
	{
		if (other == null)
		{
			return;
		}
		eKDJEMEEHGA_.Add(other.eKDJEMEEHGA_);
		if (other.cGIKOKLGDEA_ != null)
		{
			if (cGIKOKLGDEA_ == null)
			{
				CGIKOKLGDEA = new LDPLIJAMIOE();
			}
			CGIKOKLGDEA.MergeFrom(other.CGIKOKLGDEA);
		}
		if (other.mALIIHMMDFP_ != null)
		{
			if (mALIIHMMDFP_ == null)
			{
				MALIIHMMDFP = new LKBIPKDKDNP();
			}
			MALIIHMMDFP.MergeFrom(other.MALIIHMMDFP);
		}
		if (other.gIIJHNMLOCB_ != null)
		{
			if (gIIJHNMLOCB_ == null)
			{
				GIIJHNMLOCB = new DCDCGEIELJI();
			}
			GIIJHNMLOCB.MergeFrom(other.GIIJHNMLOCB);
		}
		iNKGMFFPLHF_.Add(other.iNKGMFFPLHF_);
		gBAEMAHODAB_.Add(other.gBAEMAHODAB_);
		cKFBMAJMMAC_.Add(other.cKFBMAJMMAC_);
		if (other.NFPBAKBCCHG != 0)
		{
			NFPBAKBCCHG = other.NFPBAKBCCHG;
		}
		if (other.PPNHNDEOOLJ != 0L)
		{
			PPNHNDEOOLJ = other.PPNHNDEOOLJ;
		}
		if (other.NONMONPHBPE)
		{
			NONMONPHBPE = other.NONMONPHBPE;
		}
		nEBGNOFPAGE_.Add(other.nEBGNOFPAGE_);
		dIKCBKKNINM_.Add(other.dIKCBKKNINM_);
		dDLHPDBHGJD_.Add(other.dDLHPDBHGJD_);
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
				eKDJEMEEHGA_.AddEntriesFrom(ref input, _repeated_eKDJEMEEHGA_codec);
				break;
			case 26u:
				if (cGIKOKLGDEA_ == null)
				{
					CGIKOKLGDEA = new LDPLIJAMIOE();
				}
				input.ReadMessage(CGIKOKLGDEA);
				break;
			case 34u:
				if (mALIIHMMDFP_ == null)
				{
					MALIIHMMDFP = new LKBIPKDKDNP();
				}
				input.ReadMessage(MALIIHMMDFP);
				break;
			case 42u:
				if (gIIJHNMLOCB_ == null)
				{
					GIIJHNMLOCB = new DCDCGEIELJI();
				}
				input.ReadMessage(GIIJHNMLOCB);
				break;
			case 50u:
				iNKGMFFPLHF_.AddEntriesFrom(ref input, _repeated_iNKGMFFPLHF_codec);
				break;
			case 58u:
				gBAEMAHODAB_.AddEntriesFrom(ref input, _repeated_gBAEMAHODAB_codec);
				break;
			case 74u:
				cKFBMAJMMAC_.AddEntriesFrom(ref input, _repeated_cKFBMAJMMAC_codec);
				break;
			case 80u:
				NFPBAKBCCHG = input.ReadUInt32();
				break;
			case 88u:
				PPNHNDEOOLJ = input.ReadUInt64();
				break;
			case 96u:
				NONMONPHBPE = input.ReadBool();
				break;
			case 106u:
				nEBGNOFPAGE_.AddEntriesFrom(ref input, _repeated_nEBGNOFPAGE_codec);
				break;
			case 114u:
				dIKCBKKNINM_.AddEntriesFrom(ref input, _repeated_dIKCBKKNINM_codec);
				break;
			case 122u:
				dDLHPDBHGJD_.AddEntriesFrom(ref input, _repeated_dDLHPDBHGJD_codec);
				break;
			}
		}
	}
}
