using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveGetDataScRsp : IMessage<IdleLiveGetDataScRsp>, IMessage, IEquatable<IdleLiveGetDataScRsp>, IDeepCloneable<IdleLiveGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveGetDataScRsp> _parser = new MessageParser<IdleLiveGetDataScRsp>(() => new IdleLiveGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IKJGDMGMIMLFieldNumber = 1;

	private LCFDGFOCHOJ iKJGDMGMIML_;

	public const int EBDHLJAONNJFieldNumber = 2;

	private HKJECENOHBI eBDHLJAONNJ_;

	public const int GMDLCGODDCLFieldNumber = 3;

	private BCJFAIHEBEM gMDLCGODDCL_;

	public const int OJMIFIDACHAFieldNumber = 4;

	private HLIBFMJMDAH oJMIFIDACHA_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int OKHLAELKJCHFieldNumber = 6;

	private PPCKPAHOBCB oKHLAELKJCH_;

	public const int GNAINKJAGHNFieldNumber = 7;

	private CDAILEHLPEJ gNAINKJAGHN_;

	public const int KIHKABCFBLOFieldNumber = 8;

	private AOHPHEKEJMC kIHKABCFBLO_;

	public const int DMDPNHLOLMOFieldNumber = 10;

	private BNNGELPBHAO dMDPNHLOLMO_;

	public const int LPNOKDOGFMIFieldNumber = 13;

	private HLJMFGGKMDM lPNOKDOGFMI_;

	public const int BCMJCFPKKAFFieldNumber = 14;

	private JKONPIILNJK bCMJCFPKKAF_;

	public const int PLAPCGBPNGHFieldNumber = 15;

	private EDGGKGPFLNP pLAPCGBPNGH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCFDGFOCHOJ IKJGDMGMIML
	{
		get
		{
			return iKJGDMGMIML_;
		}
		set
		{
			iKJGDMGMIML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJECENOHBI EBDHLJAONNJ
	{
		get
		{
			return eBDHLJAONNJ_;
		}
		set
		{
			eBDHLJAONNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCJFAIHEBEM GMDLCGODDCL
	{
		get
		{
			return gMDLCGODDCL_;
		}
		set
		{
			gMDLCGODDCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLIBFMJMDAH OJMIFIDACHA
	{
		get
		{
			return oJMIFIDACHA_;
		}
		set
		{
			oJMIFIDACHA_ = value;
		}
	}

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
	public PPCKPAHOBCB OKHLAELKJCH
	{
		get
		{
			return oKHLAELKJCH_;
		}
		set
		{
			oKHLAELKJCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDAILEHLPEJ GNAINKJAGHN
	{
		get
		{
			return gNAINKJAGHN_;
		}
		set
		{
			gNAINKJAGHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHPHEKEJMC KIHKABCFBLO
	{
		get
		{
			return kIHKABCFBLO_;
		}
		set
		{
			kIHKABCFBLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNNGELPBHAO DMDPNHLOLMO
	{
		get
		{
			return dMDPNHLOLMO_;
		}
		set
		{
			dMDPNHLOLMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLJMFGGKMDM LPNOKDOGFMI
	{
		get
		{
			return lPNOKDOGFMI_;
		}
		set
		{
			lPNOKDOGFMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKONPIILNJK BCMJCFPKKAF
	{
		get
		{
			return bCMJCFPKKAF_;
		}
		set
		{
			bCMJCFPKKAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDGGKGPFLNP PLAPCGBPNGH
	{
		get
		{
			return pLAPCGBPNGH_;
		}
		set
		{
			pLAPCGBPNGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveGetDataScRsp(IdleLiveGetDataScRsp other)
		: this()
	{
		iKJGDMGMIML_ = ((other.iKJGDMGMIML_ != null) ? other.iKJGDMGMIML_.Clone() : null);
		eBDHLJAONNJ_ = ((other.eBDHLJAONNJ_ != null) ? other.eBDHLJAONNJ_.Clone() : null);
		gMDLCGODDCL_ = ((other.gMDLCGODDCL_ != null) ? other.gMDLCGODDCL_.Clone() : null);
		oJMIFIDACHA_ = ((other.oJMIFIDACHA_ != null) ? other.oJMIFIDACHA_.Clone() : null);
		retcode_ = other.retcode_;
		oKHLAELKJCH_ = ((other.oKHLAELKJCH_ != null) ? other.oKHLAELKJCH_.Clone() : null);
		gNAINKJAGHN_ = ((other.gNAINKJAGHN_ != null) ? other.gNAINKJAGHN_.Clone() : null);
		kIHKABCFBLO_ = ((other.kIHKABCFBLO_ != null) ? other.kIHKABCFBLO_.Clone() : null);
		dMDPNHLOLMO_ = ((other.dMDPNHLOLMO_ != null) ? other.dMDPNHLOLMO_.Clone() : null);
		lPNOKDOGFMI_ = ((other.lPNOKDOGFMI_ != null) ? other.lPNOKDOGFMI_.Clone() : null);
		bCMJCFPKKAF_ = ((other.bCMJCFPKKAF_ != null) ? other.bCMJCFPKKAF_.Clone() : null);
		pLAPCGBPNGH_ = ((other.pLAPCGBPNGH_ != null) ? other.pLAPCGBPNGH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveGetDataScRsp Clone()
	{
		return new IdleLiveGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IKJGDMGMIML, other.IKJGDMGMIML))
		{
			return false;
		}
		if (!object.Equals(EBDHLJAONNJ, other.EBDHLJAONNJ))
		{
			return false;
		}
		if (!object.Equals(GMDLCGODDCL, other.GMDLCGODDCL))
		{
			return false;
		}
		if (!object.Equals(OJMIFIDACHA, other.OJMIFIDACHA))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(OKHLAELKJCH, other.OKHLAELKJCH))
		{
			return false;
		}
		if (!object.Equals(GNAINKJAGHN, other.GNAINKJAGHN))
		{
			return false;
		}
		if (!object.Equals(KIHKABCFBLO, other.KIHKABCFBLO))
		{
			return false;
		}
		if (!object.Equals(DMDPNHLOLMO, other.DMDPNHLOLMO))
		{
			return false;
		}
		if (!object.Equals(LPNOKDOGFMI, other.LPNOKDOGFMI))
		{
			return false;
		}
		if (!object.Equals(BCMJCFPKKAF, other.BCMJCFPKKAF))
		{
			return false;
		}
		if (!object.Equals(PLAPCGBPNGH, other.PLAPCGBPNGH))
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
		if (iKJGDMGMIML_ != null)
		{
			num ^= IKJGDMGMIML.GetHashCode();
		}
		if (eBDHLJAONNJ_ != null)
		{
			num ^= EBDHLJAONNJ.GetHashCode();
		}
		if (gMDLCGODDCL_ != null)
		{
			num ^= GMDLCGODDCL.GetHashCode();
		}
		if (oJMIFIDACHA_ != null)
		{
			num ^= OJMIFIDACHA.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (oKHLAELKJCH_ != null)
		{
			num ^= OKHLAELKJCH.GetHashCode();
		}
		if (gNAINKJAGHN_ != null)
		{
			num ^= GNAINKJAGHN.GetHashCode();
		}
		if (kIHKABCFBLO_ != null)
		{
			num ^= KIHKABCFBLO.GetHashCode();
		}
		if (dMDPNHLOLMO_ != null)
		{
			num ^= DMDPNHLOLMO.GetHashCode();
		}
		if (lPNOKDOGFMI_ != null)
		{
			num ^= LPNOKDOGFMI.GetHashCode();
		}
		if (bCMJCFPKKAF_ != null)
		{
			num ^= BCMJCFPKKAF.GetHashCode();
		}
		if (pLAPCGBPNGH_ != null)
		{
			num ^= PLAPCGBPNGH.GetHashCode();
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
		if (iKJGDMGMIML_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(IKJGDMGMIML);
		}
		if (eBDHLJAONNJ_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EBDHLJAONNJ);
		}
		if (gMDLCGODDCL_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GMDLCGODDCL);
		}
		if (oJMIFIDACHA_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OJMIFIDACHA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (oKHLAELKJCH_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OKHLAELKJCH);
		}
		if (gNAINKJAGHN_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(GNAINKJAGHN);
		}
		if (kIHKABCFBLO_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(KIHKABCFBLO);
		}
		if (dMDPNHLOLMO_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DMDPNHLOLMO);
		}
		if (lPNOKDOGFMI_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(LPNOKDOGFMI);
		}
		if (bCMJCFPKKAF_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BCMJCFPKKAF);
		}
		if (pLAPCGBPNGH_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(PLAPCGBPNGH);
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
		if (iKJGDMGMIML_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IKJGDMGMIML);
		}
		if (eBDHLJAONNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EBDHLJAONNJ);
		}
		if (gMDLCGODDCL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GMDLCGODDCL);
		}
		if (oJMIFIDACHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OJMIFIDACHA);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (oKHLAELKJCH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OKHLAELKJCH);
		}
		if (gNAINKJAGHN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GNAINKJAGHN);
		}
		if (kIHKABCFBLO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KIHKABCFBLO);
		}
		if (dMDPNHLOLMO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DMDPNHLOLMO);
		}
		if (lPNOKDOGFMI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LPNOKDOGFMI);
		}
		if (bCMJCFPKKAF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BCMJCFPKKAF);
		}
		if (pLAPCGBPNGH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLAPCGBPNGH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveGetDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iKJGDMGMIML_ != null)
		{
			if (iKJGDMGMIML_ == null)
			{
				IKJGDMGMIML = new LCFDGFOCHOJ();
			}
			IKJGDMGMIML.MergeFrom(other.IKJGDMGMIML);
		}
		if (other.eBDHLJAONNJ_ != null)
		{
			if (eBDHLJAONNJ_ == null)
			{
				EBDHLJAONNJ = new HKJECENOHBI();
			}
			EBDHLJAONNJ.MergeFrom(other.EBDHLJAONNJ);
		}
		if (other.gMDLCGODDCL_ != null)
		{
			if (gMDLCGODDCL_ == null)
			{
				GMDLCGODDCL = new BCJFAIHEBEM();
			}
			GMDLCGODDCL.MergeFrom(other.GMDLCGODDCL);
		}
		if (other.oJMIFIDACHA_ != null)
		{
			if (oJMIFIDACHA_ == null)
			{
				OJMIFIDACHA = new HLIBFMJMDAH();
			}
			OJMIFIDACHA.MergeFrom(other.OJMIFIDACHA);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.oKHLAELKJCH_ != null)
		{
			if (oKHLAELKJCH_ == null)
			{
				OKHLAELKJCH = new PPCKPAHOBCB();
			}
			OKHLAELKJCH.MergeFrom(other.OKHLAELKJCH);
		}
		if (other.gNAINKJAGHN_ != null)
		{
			if (gNAINKJAGHN_ == null)
			{
				GNAINKJAGHN = new CDAILEHLPEJ();
			}
			GNAINKJAGHN.MergeFrom(other.GNAINKJAGHN);
		}
		if (other.kIHKABCFBLO_ != null)
		{
			if (kIHKABCFBLO_ == null)
			{
				KIHKABCFBLO = new AOHPHEKEJMC();
			}
			KIHKABCFBLO.MergeFrom(other.KIHKABCFBLO);
		}
		if (other.dMDPNHLOLMO_ != null)
		{
			if (dMDPNHLOLMO_ == null)
			{
				DMDPNHLOLMO = new BNNGELPBHAO();
			}
			DMDPNHLOLMO.MergeFrom(other.DMDPNHLOLMO);
		}
		if (other.lPNOKDOGFMI_ != null)
		{
			if (lPNOKDOGFMI_ == null)
			{
				LPNOKDOGFMI = new HLJMFGGKMDM();
			}
			LPNOKDOGFMI.MergeFrom(other.LPNOKDOGFMI);
		}
		if (other.bCMJCFPKKAF_ != null)
		{
			if (bCMJCFPKKAF_ == null)
			{
				BCMJCFPKKAF = new JKONPIILNJK();
			}
			BCMJCFPKKAF.MergeFrom(other.BCMJCFPKKAF);
		}
		if (other.pLAPCGBPNGH_ != null)
		{
			if (pLAPCGBPNGH_ == null)
			{
				PLAPCGBPNGH = new EDGGKGPFLNP();
			}
			PLAPCGBPNGH.MergeFrom(other.PLAPCGBPNGH);
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
				if (iKJGDMGMIML_ == null)
				{
					IKJGDMGMIML = new LCFDGFOCHOJ();
				}
				input.ReadMessage(IKJGDMGMIML);
				break;
			case 18u:
				if (eBDHLJAONNJ_ == null)
				{
					EBDHLJAONNJ = new HKJECENOHBI();
				}
				input.ReadMessage(EBDHLJAONNJ);
				break;
			case 26u:
				if (gMDLCGODDCL_ == null)
				{
					GMDLCGODDCL = new BCJFAIHEBEM();
				}
				input.ReadMessage(GMDLCGODDCL);
				break;
			case 34u:
				if (oJMIFIDACHA_ == null)
				{
					OJMIFIDACHA = new HLIBFMJMDAH();
				}
				input.ReadMessage(OJMIFIDACHA);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				if (oKHLAELKJCH_ == null)
				{
					OKHLAELKJCH = new PPCKPAHOBCB();
				}
				input.ReadMessage(OKHLAELKJCH);
				break;
			case 58u:
				if (gNAINKJAGHN_ == null)
				{
					GNAINKJAGHN = new CDAILEHLPEJ();
				}
				input.ReadMessage(GNAINKJAGHN);
				break;
			case 66u:
				if (kIHKABCFBLO_ == null)
				{
					KIHKABCFBLO = new AOHPHEKEJMC();
				}
				input.ReadMessage(KIHKABCFBLO);
				break;
			case 82u:
				if (dMDPNHLOLMO_ == null)
				{
					DMDPNHLOLMO = new BNNGELPBHAO();
				}
				input.ReadMessage(DMDPNHLOLMO);
				break;
			case 106u:
				if (lPNOKDOGFMI_ == null)
				{
					LPNOKDOGFMI = new HLJMFGGKMDM();
				}
				input.ReadMessage(LPNOKDOGFMI);
				break;
			case 114u:
				if (bCMJCFPKKAF_ == null)
				{
					BCMJCFPKKAF = new JKONPIILNJK();
				}
				input.ReadMessage(BCMJCFPKKAF);
				break;
			case 122u:
				if (pLAPCGBPNGH_ == null)
				{
					PLAPCGBPNGH = new EDGGKGPFLNP();
				}
				input.ReadMessage(PLAPCGBPNGH);
				break;
			}
		}
	}
}
