using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BEBEOMBMDFB : IMessage<BEBEOMBMDFB>, IMessage, IEquatable<BEBEOMBMDFB>, IDeepCloneable<BEBEOMBMDFB>, IBufferMessage
{
	private static readonly MessageParser<BEBEOMBMDFB> _parser = new MessageParser<BEBEOMBMDFB>(() => new BEBEOMBMDFB());

	private UnknownFieldSet _unknownFields;

	public const int BNAJPPKFFBDFieldNumber = 1;

	private HLGALKACKLJ bNAJPPKFFBD_;

	public const int IANMKEGOGMGFieldNumber = 2;

	private DPHNLKIPDGJ iANMKEGOGMG_;

	public const int PPOKGBJEIENFieldNumber = 4;

	private NAKPLIGJELP pPOKGBJEIEN_;

	public const int FEJALPEDHEHFieldNumber = 6;

	private EGOEEMFIJFO fEJALPEDHEH_;

	public const int HCEHOHDCCFEFieldNumber = 7;

	private CNMBIPOPOFH hCEHOHDCCFE_;

	public const int NIPCEAFLCAAFieldNumber = 8;

	private static readonly FieldCodec<OGNFOGJBPNJ> _repeated_nIPCEAFLCAA_codec = FieldCodec.ForMessage(66u, OGNFOGJBPNJ.Parser);

	private readonly RepeatedField<OGNFOGJBPNJ> nIPCEAFLCAA_ = new RepeatedField<OGNFOGJBPNJ>();

	public const int IGFPODGEPIBFieldNumber = 9;

	private IBFOFJCOAFF iGFPODGEPIB_;

	public const int FMKEFGJMCHAFieldNumber = 11;

	private ECJNAIOLKJD fMKEFGJMCHA_;

	public const int BFHJHAKFBIGFieldNumber = 12;

	private static readonly FieldCodec<GDMLNIJOFEE> _repeated_bFHJHAKFBIG_codec = FieldCodec.ForMessage(98u, GDMLNIJOFEE.Parser);

	private readonly RepeatedField<GDMLNIJOFEE> bFHJHAKFBIG_ = new RepeatedField<GDMLNIJOFEE>();

	public const int FDMILCHKFLBFieldNumber = 14;

	private static readonly FieldCodec<OJKAHCEKDGN> _repeated_fDMILCHKFLB_codec = FieldCodec.ForMessage(114u, OJKAHCEKDGN.Parser);

	private readonly RepeatedField<OJKAHCEKDGN> fDMILCHKFLB_ = new RepeatedField<OJKAHCEKDGN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BEBEOMBMDFB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BEBEOMBMDFBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLGALKACKLJ BNAJPPKFFBD
	{
		get
		{
			return bNAJPPKFFBD_;
		}
		set
		{
			bNAJPPKFFBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPHNLKIPDGJ IANMKEGOGMG
	{
		get
		{
			return iANMKEGOGMG_;
		}
		set
		{
			iANMKEGOGMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKPLIGJELP PPOKGBJEIEN
	{
		get
		{
			return pPOKGBJEIEN_;
		}
		set
		{
			pPOKGBJEIEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGOEEMFIJFO FEJALPEDHEH
	{
		get
		{
			return fEJALPEDHEH_;
		}
		set
		{
			fEJALPEDHEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNMBIPOPOFH HCEHOHDCCFE
	{
		get
		{
			return hCEHOHDCCFE_;
		}
		set
		{
			hCEHOHDCCFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OGNFOGJBPNJ> NIPCEAFLCAA => nIPCEAFLCAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFOFJCOAFF IGFPODGEPIB
	{
		get
		{
			return iGFPODGEPIB_;
		}
		set
		{
			iGFPODGEPIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECJNAIOLKJD FMKEFGJMCHA
	{
		get
		{
			return fMKEFGJMCHA_;
		}
		set
		{
			fMKEFGJMCHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GDMLNIJOFEE> BFHJHAKFBIG => bFHJHAKFBIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OJKAHCEKDGN> FDMILCHKFLB => fDMILCHKFLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEBEOMBMDFB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEBEOMBMDFB(BEBEOMBMDFB other)
		: this()
	{
		bNAJPPKFFBD_ = ((other.bNAJPPKFFBD_ != null) ? other.bNAJPPKFFBD_.Clone() : null);
		iANMKEGOGMG_ = ((other.iANMKEGOGMG_ != null) ? other.iANMKEGOGMG_.Clone() : null);
		pPOKGBJEIEN_ = ((other.pPOKGBJEIEN_ != null) ? other.pPOKGBJEIEN_.Clone() : null);
		fEJALPEDHEH_ = ((other.fEJALPEDHEH_ != null) ? other.fEJALPEDHEH_.Clone() : null);
		hCEHOHDCCFE_ = ((other.hCEHOHDCCFE_ != null) ? other.hCEHOHDCCFE_.Clone() : null);
		nIPCEAFLCAA_ = other.nIPCEAFLCAA_.Clone();
		iGFPODGEPIB_ = ((other.iGFPODGEPIB_ != null) ? other.iGFPODGEPIB_.Clone() : null);
		fMKEFGJMCHA_ = ((other.fMKEFGJMCHA_ != null) ? other.fMKEFGJMCHA_.Clone() : null);
		bFHJHAKFBIG_ = other.bFHJHAKFBIG_.Clone();
		fDMILCHKFLB_ = other.fDMILCHKFLB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEBEOMBMDFB Clone()
	{
		return new BEBEOMBMDFB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BEBEOMBMDFB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BEBEOMBMDFB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BNAJPPKFFBD, other.BNAJPPKFFBD))
		{
			return false;
		}
		if (!object.Equals(IANMKEGOGMG, other.IANMKEGOGMG))
		{
			return false;
		}
		if (!object.Equals(PPOKGBJEIEN, other.PPOKGBJEIEN))
		{
			return false;
		}
		if (!object.Equals(FEJALPEDHEH, other.FEJALPEDHEH))
		{
			return false;
		}
		if (!object.Equals(HCEHOHDCCFE, other.HCEHOHDCCFE))
		{
			return false;
		}
		if (!nIPCEAFLCAA_.Equals(other.nIPCEAFLCAA_))
		{
			return false;
		}
		if (!object.Equals(IGFPODGEPIB, other.IGFPODGEPIB))
		{
			return false;
		}
		if (!object.Equals(FMKEFGJMCHA, other.FMKEFGJMCHA))
		{
			return false;
		}
		if (!bFHJHAKFBIG_.Equals(other.bFHJHAKFBIG_))
		{
			return false;
		}
		if (!fDMILCHKFLB_.Equals(other.fDMILCHKFLB_))
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
		if (bNAJPPKFFBD_ != null)
		{
			num ^= BNAJPPKFFBD.GetHashCode();
		}
		if (iANMKEGOGMG_ != null)
		{
			num ^= IANMKEGOGMG.GetHashCode();
		}
		if (pPOKGBJEIEN_ != null)
		{
			num ^= PPOKGBJEIEN.GetHashCode();
		}
		if (fEJALPEDHEH_ != null)
		{
			num ^= FEJALPEDHEH.GetHashCode();
		}
		if (hCEHOHDCCFE_ != null)
		{
			num ^= HCEHOHDCCFE.GetHashCode();
		}
		num ^= nIPCEAFLCAA_.GetHashCode();
		if (iGFPODGEPIB_ != null)
		{
			num ^= IGFPODGEPIB.GetHashCode();
		}
		if (fMKEFGJMCHA_ != null)
		{
			num ^= FMKEFGJMCHA.GetHashCode();
		}
		num ^= bFHJHAKFBIG_.GetHashCode();
		num ^= fDMILCHKFLB_.GetHashCode();
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
		if (bNAJPPKFFBD_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BNAJPPKFFBD);
		}
		if (iANMKEGOGMG_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(IANMKEGOGMG);
		}
		if (pPOKGBJEIEN_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PPOKGBJEIEN);
		}
		if (fEJALPEDHEH_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(FEJALPEDHEH);
		}
		if (hCEHOHDCCFE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HCEHOHDCCFE);
		}
		nIPCEAFLCAA_.WriteTo(ref output, _repeated_nIPCEAFLCAA_codec);
		if (iGFPODGEPIB_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(IGFPODGEPIB);
		}
		if (fMKEFGJMCHA_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FMKEFGJMCHA);
		}
		bFHJHAKFBIG_.WriteTo(ref output, _repeated_bFHJHAKFBIG_codec);
		fDMILCHKFLB_.WriteTo(ref output, _repeated_fDMILCHKFLB_codec);
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
		if (bNAJPPKFFBD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNAJPPKFFBD);
		}
		if (iANMKEGOGMG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IANMKEGOGMG);
		}
		if (pPOKGBJEIEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPOKGBJEIEN);
		}
		if (fEJALPEDHEH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEJALPEDHEH);
		}
		if (hCEHOHDCCFE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HCEHOHDCCFE);
		}
		num += nIPCEAFLCAA_.CalculateSize(_repeated_nIPCEAFLCAA_codec);
		if (iGFPODGEPIB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IGFPODGEPIB);
		}
		if (fMKEFGJMCHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMKEFGJMCHA);
		}
		num += bFHJHAKFBIG_.CalculateSize(_repeated_bFHJHAKFBIG_codec);
		num += fDMILCHKFLB_.CalculateSize(_repeated_fDMILCHKFLB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BEBEOMBMDFB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bNAJPPKFFBD_ != null)
		{
			if (bNAJPPKFFBD_ == null)
			{
				BNAJPPKFFBD = new HLGALKACKLJ();
			}
			BNAJPPKFFBD.MergeFrom(other.BNAJPPKFFBD);
		}
		if (other.iANMKEGOGMG_ != null)
		{
			if (iANMKEGOGMG_ == null)
			{
				IANMKEGOGMG = new DPHNLKIPDGJ();
			}
			IANMKEGOGMG.MergeFrom(other.IANMKEGOGMG);
		}
		if (other.pPOKGBJEIEN_ != null)
		{
			if (pPOKGBJEIEN_ == null)
			{
				PPOKGBJEIEN = new NAKPLIGJELP();
			}
			PPOKGBJEIEN.MergeFrom(other.PPOKGBJEIEN);
		}
		if (other.fEJALPEDHEH_ != null)
		{
			if (fEJALPEDHEH_ == null)
			{
				FEJALPEDHEH = new EGOEEMFIJFO();
			}
			FEJALPEDHEH.MergeFrom(other.FEJALPEDHEH);
		}
		if (other.hCEHOHDCCFE_ != null)
		{
			if (hCEHOHDCCFE_ == null)
			{
				HCEHOHDCCFE = new CNMBIPOPOFH();
			}
			HCEHOHDCCFE.MergeFrom(other.HCEHOHDCCFE);
		}
		nIPCEAFLCAA_.Add(other.nIPCEAFLCAA_);
		if (other.iGFPODGEPIB_ != null)
		{
			if (iGFPODGEPIB_ == null)
			{
				IGFPODGEPIB = new IBFOFJCOAFF();
			}
			IGFPODGEPIB.MergeFrom(other.IGFPODGEPIB);
		}
		if (other.fMKEFGJMCHA_ != null)
		{
			if (fMKEFGJMCHA_ == null)
			{
				FMKEFGJMCHA = new ECJNAIOLKJD();
			}
			FMKEFGJMCHA.MergeFrom(other.FMKEFGJMCHA);
		}
		bFHJHAKFBIG_.Add(other.bFHJHAKFBIG_);
		fDMILCHKFLB_.Add(other.fDMILCHKFLB_);
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
				if (bNAJPPKFFBD_ == null)
				{
					BNAJPPKFFBD = new HLGALKACKLJ();
				}
				input.ReadMessage(BNAJPPKFFBD);
				break;
			case 18u:
				if (iANMKEGOGMG_ == null)
				{
					IANMKEGOGMG = new DPHNLKIPDGJ();
				}
				input.ReadMessage(IANMKEGOGMG);
				break;
			case 34u:
				if (pPOKGBJEIEN_ == null)
				{
					PPOKGBJEIEN = new NAKPLIGJELP();
				}
				input.ReadMessage(PPOKGBJEIEN);
				break;
			case 50u:
				if (fEJALPEDHEH_ == null)
				{
					FEJALPEDHEH = new EGOEEMFIJFO();
				}
				input.ReadMessage(FEJALPEDHEH);
				break;
			case 58u:
				if (hCEHOHDCCFE_ == null)
				{
					HCEHOHDCCFE = new CNMBIPOPOFH();
				}
				input.ReadMessage(HCEHOHDCCFE);
				break;
			case 66u:
				nIPCEAFLCAA_.AddEntriesFrom(ref input, _repeated_nIPCEAFLCAA_codec);
				break;
			case 74u:
				if (iGFPODGEPIB_ == null)
				{
					IGFPODGEPIB = new IBFOFJCOAFF();
				}
				input.ReadMessage(IGFPODGEPIB);
				break;
			case 90u:
				if (fMKEFGJMCHA_ == null)
				{
					FMKEFGJMCHA = new ECJNAIOLKJD();
				}
				input.ReadMessage(FMKEFGJMCHA);
				break;
			case 98u:
				bFHJHAKFBIG_.AddEntriesFrom(ref input, _repeated_bFHJHAKFBIG_codec);
				break;
			case 114u:
				fDMILCHKFLB_.AddEntriesFrom(ref input, _repeated_fDMILCHKFLB_codec);
				break;
			}
		}
	}
}
