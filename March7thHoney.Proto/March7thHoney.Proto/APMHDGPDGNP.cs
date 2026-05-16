using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APMHDGPDGNP : IMessage<APMHDGPDGNP>, IMessage, IEquatable<APMHDGPDGNP>, IDeepCloneable<APMHDGPDGNP>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		KFPBACEHAMH = 636,
		OPDJKKPPPOD = 1042,
		CIMGCEEGDCF = 1742
	}

	private static readonly MessageParser<APMHDGPDGNP> _parser = new MessageParser<APMHDGPDGNP>(() => new APMHDGPDGNP());

	private UnknownFieldSet _unknownFields;

	public const int LPHOAIJFPNPFieldNumber = 3;

	private PNKEBBADONJ lPHOAIJFPNP_;

	public const int NLILNONCNFCFieldNumber = 10;

	private KGABJENCFDC nLILNONCNFC_;

	public const int KFPBACEHAMHFieldNumber = 636;

	public const int OPDJKKPPPODFieldNumber = 1042;

	public const int CIMGCEEGDCFFieldNumber = 1742;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APMHDGPDGNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APMHDGPDGNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNKEBBADONJ LPHOAIJFPNP
	{
		get
		{
			return lPHOAIJFPNP_;
		}
		set
		{
			lPHOAIJFPNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGABJENCFDC NLILNONCNFC
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
	public HPMJCOCCBJJ KFPBACEHAMH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KFPBACEHAMH)
			{
				return null;
			}
			return (HPMJCOCCBJJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KFPBACEHAMH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCIFMHFCDMG OPDJKKPPPOD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OPDJKKPPPOD)
			{
				return null;
			}
			return (BCIFMHFCDMG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OPDJKKPPPOD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHILIFOOIGH CIMGCEEGDCF
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CIMGCEEGDCF)
			{
				return null;
			}
			return (KHILIFOOIGH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CIMGCEEGDCF : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APMHDGPDGNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APMHDGPDGNP(APMHDGPDGNP other)
		: this()
	{
		lPHOAIJFPNP_ = ((other.lPHOAIJFPNP_ != null) ? other.lPHOAIJFPNP_.Clone() : null);
		nLILNONCNFC_ = ((other.nLILNONCNFC_ != null) ? other.nLILNONCNFC_.Clone() : null);
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.KFPBACEHAMH:
			KFPBACEHAMH = other.KFPBACEHAMH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.OPDJKKPPPOD:
			OPDJKKPPPOD = other.OPDJKKPPPOD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CIMGCEEGDCF:
			CIMGCEEGDCF = other.CIMGCEEGDCF.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APMHDGPDGNP Clone()
	{
		return new APMHDGPDGNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APMHDGPDGNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APMHDGPDGNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LPHOAIJFPNP, other.LPHOAIJFPNP))
		{
			return false;
		}
		if (!object.Equals(NLILNONCNFC, other.NLILNONCNFC))
		{
			return false;
		}
		if (!object.Equals(KFPBACEHAMH, other.KFPBACEHAMH))
		{
			return false;
		}
		if (!object.Equals(OPDJKKPPPOD, other.OPDJKKPPPOD))
		{
			return false;
		}
		if (!object.Equals(CIMGCEEGDCF, other.CIMGCEEGDCF))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (lPHOAIJFPNP_ != null)
		{
			num ^= LPHOAIJFPNP.GetHashCode();
		}
		if (nLILNONCNFC_ != null)
		{
			num ^= NLILNONCNFC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFPBACEHAMH)
		{
			num ^= KFPBACEHAMH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPDJKKPPPOD)
		{
			num ^= OPDJKKPPPOD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CIMGCEEGDCF)
		{
			num ^= CIMGCEEGDCF.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (lPHOAIJFPNP_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LPHOAIJFPNP);
		}
		if (nLILNONCNFC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(NLILNONCNFC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFPBACEHAMH)
		{
			output.WriteRawTag(226, 39);
			output.WriteMessage(KFPBACEHAMH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPDJKKPPPOD)
		{
			output.WriteRawTag(146, 65);
			output.WriteMessage(OPDJKKPPPOD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CIMGCEEGDCF)
		{
			output.WriteRawTag(242, 108);
			output.WriteMessage(CIMGCEEGDCF);
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
		if (lPHOAIJFPNP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LPHOAIJFPNP);
		}
		if (nLILNONCNFC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NLILNONCNFC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFPBACEHAMH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KFPBACEHAMH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPDJKKPPPOD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OPDJKKPPPOD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CIMGCEEGDCF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CIMGCEEGDCF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APMHDGPDGNP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lPHOAIJFPNP_ != null)
		{
			if (lPHOAIJFPNP_ == null)
			{
				LPHOAIJFPNP = new PNKEBBADONJ();
			}
			LPHOAIJFPNP.MergeFrom(other.LPHOAIJFPNP);
		}
		if (other.nLILNONCNFC_ != null)
		{
			if (nLILNONCNFC_ == null)
			{
				NLILNONCNFC = new KGABJENCFDC();
			}
			NLILNONCNFC.MergeFrom(other.NLILNONCNFC);
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.KFPBACEHAMH:
			if (KFPBACEHAMH == null)
			{
				KFPBACEHAMH = new HPMJCOCCBJJ();
			}
			KFPBACEHAMH.MergeFrom(other.KFPBACEHAMH);
			break;
		case BPIHFAJCLOCOneofCase.OPDJKKPPPOD:
			if (OPDJKKPPPOD == null)
			{
				OPDJKKPPPOD = new BCIFMHFCDMG();
			}
			OPDJKKPPPOD.MergeFrom(other.OPDJKKPPPOD);
			break;
		case BPIHFAJCLOCOneofCase.CIMGCEEGDCF:
			if (CIMGCEEGDCF == null)
			{
				CIMGCEEGDCF = new KHILIFOOIGH();
			}
			CIMGCEEGDCF.MergeFrom(other.CIMGCEEGDCF);
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
			case 26u:
				if (lPHOAIJFPNP_ == null)
				{
					LPHOAIJFPNP = new PNKEBBADONJ();
				}
				input.ReadMessage(LPHOAIJFPNP);
				break;
			case 82u:
				if (nLILNONCNFC_ == null)
				{
					NLILNONCNFC = new KGABJENCFDC();
				}
				input.ReadMessage(NLILNONCNFC);
				break;
			case 5090u:
			{
				HPMJCOCCBJJ hPMJCOCCBJJ = new HPMJCOCCBJJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KFPBACEHAMH)
				{
					hPMJCOCCBJJ.MergeFrom(KFPBACEHAMH);
				}
				input.ReadMessage(hPMJCOCCBJJ);
				KFPBACEHAMH = hPMJCOCCBJJ;
				break;
			}
			case 8338u:
			{
				BCIFMHFCDMG bCIFMHFCDMG = new BCIFMHFCDMG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OPDJKKPPPOD)
				{
					bCIFMHFCDMG.MergeFrom(OPDJKKPPPOD);
				}
				input.ReadMessage(bCIFMHFCDMG);
				OPDJKKPPPOD = bCIFMHFCDMG;
				break;
			}
			case 13938u:
			{
				KHILIFOOIGH kHILIFOOIGH = new KHILIFOOIGH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CIMGCEEGDCF)
				{
					kHILIFOOIGH.MergeFrom(CIMGCEEGDCF);
				}
				input.ReadMessage(kHILIFOOIGH);
				CIMGCEEGDCF = kHILIFOOIGH;
				break;
			}
			}
		}
	}
}
