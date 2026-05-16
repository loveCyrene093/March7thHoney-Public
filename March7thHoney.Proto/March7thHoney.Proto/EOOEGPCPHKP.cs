using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EOOEGPCPHKP : IMessage<EOOEGPCPHKP>, IMessage, IEquatable<EOOEGPCPHKP>, IDeepCloneable<EOOEGPCPHKP>, IBufferMessage
{
	public enum FHPJJJDNKIOOneofCase
	{
		None = 0,
		FEILNIKNPCB = 1,
		BOCIPPBEBEA = 2,
		DAPJEDHFKCM = 6,
		HKGKNEKKJHB = 8,
		IMPBELJGDJH = 9,
		IADDBBBDGGM = 12,
		LBNHKPPAJIM = 13,
		ECJCCKFEFEJ = 15
	}

	private static readonly MessageParser<EOOEGPCPHKP> _parser = new MessageParser<EOOEGPCPHKP>(() => new EOOEGPCPHKP());

	private UnknownFieldSet _unknownFields;

	public const int FEILNIKNPCBFieldNumber = 1;

	public const int BOCIPPBEBEAFieldNumber = 2;

	public const int DAPJEDHFKCMFieldNumber = 6;

	public const int HKGKNEKKJHBFieldNumber = 8;

	public const int IMPBELJGDJHFieldNumber = 9;

	public const int IADDBBBDGGMFieldNumber = 12;

	public const int LBNHKPPAJIMFieldNumber = 13;

	public const int ECJCCKFEFEJFieldNumber = 15;

	private object fHPJJJDNKIO_;

	private FHPJJJDNKIOOneofCase fHPJJJDNKIOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EOOEGPCPHKP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EOOEGPCPHKPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKFANGIJAOF FEILNIKNPCB
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.FEILNIKNPCB)
			{
				return null;
			}
			return (KKFANGIJAOF)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.FEILNIKNPCB : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADJBBLEBIEN BOCIPPBEBEA
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.BOCIPPBEBEA)
			{
				return null;
			}
			return (ADJBBLEBIEN)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.BOCIPPBEBEA : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGJNBNANDEE DAPJEDHFKCM
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.DAPJEDHFKCM)
			{
				return null;
			}
			return (PGJNBNANDEE)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.DAPJEDHFKCM : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNJHCICPAIC HKGKNEKKJHB
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.HKGKNEKKJHB)
			{
				return null;
			}
			return (CNJHCICPAIC)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.HKGKNEKKJHB : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIIIHMJAC IMPBELJGDJH
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.IMPBELJGDJH)
			{
				return null;
			}
			return (CALIIIHMJAC)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.IMPBELJGDJH : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POIFGDAHJCJ IADDBBBDGGM
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.IADDBBBDGGM)
			{
				return null;
			}
			return (POIFGDAHJCJ)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.IADDBBBDGGM : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MICOMIBPIOA LBNHKPPAJIM
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.LBNHKPPAJIM)
			{
				return null;
			}
			return (MICOMIBPIOA)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.LBNHKPPAJIM : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBMHMEADLEC ECJCCKFEFEJ
	{
		get
		{
			if (fHPJJJDNKIOCase_ != FHPJJJDNKIOOneofCase.ECJCCKFEFEJ)
			{
				return null;
			}
			return (PBMHMEADLEC)fHPJJJDNKIO_;
		}
		set
		{
			fHPJJJDNKIO_ = value;
			fHPJJJDNKIOCase_ = ((value != null) ? FHPJJJDNKIOOneofCase.ECJCCKFEFEJ : FHPJJJDNKIOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHPJJJDNKIOOneofCase FHPJJJDNKIOCase => fHPJJJDNKIOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOEGPCPHKP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOEGPCPHKP(EOOEGPCPHKP other)
		: this()
	{
		switch (other.FHPJJJDNKIOCase)
		{
		case FHPJJJDNKIOOneofCase.FEILNIKNPCB:
			FEILNIKNPCB = other.FEILNIKNPCB.Clone();
			break;
		case FHPJJJDNKIOOneofCase.BOCIPPBEBEA:
			BOCIPPBEBEA = other.BOCIPPBEBEA.Clone();
			break;
		case FHPJJJDNKIOOneofCase.DAPJEDHFKCM:
			DAPJEDHFKCM = other.DAPJEDHFKCM.Clone();
			break;
		case FHPJJJDNKIOOneofCase.HKGKNEKKJHB:
			HKGKNEKKJHB = other.HKGKNEKKJHB.Clone();
			break;
		case FHPJJJDNKIOOneofCase.IMPBELJGDJH:
			IMPBELJGDJH = other.IMPBELJGDJH.Clone();
			break;
		case FHPJJJDNKIOOneofCase.IADDBBBDGGM:
			IADDBBBDGGM = other.IADDBBBDGGM.Clone();
			break;
		case FHPJJJDNKIOOneofCase.LBNHKPPAJIM:
			LBNHKPPAJIM = other.LBNHKPPAJIM.Clone();
			break;
		case FHPJJJDNKIOOneofCase.ECJCCKFEFEJ:
			ECJCCKFEFEJ = other.ECJCCKFEFEJ.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOEGPCPHKP Clone()
	{
		return new EOOEGPCPHKP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFHPJJJDNKIO()
	{
		fHPJJJDNKIOCase_ = FHPJJJDNKIOOneofCase.None;
		fHPJJJDNKIO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EOOEGPCPHKP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EOOEGPCPHKP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
		{
			return false;
		}
		if (!object.Equals(BOCIPPBEBEA, other.BOCIPPBEBEA))
		{
			return false;
		}
		if (!object.Equals(DAPJEDHFKCM, other.DAPJEDHFKCM))
		{
			return false;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
		{
			return false;
		}
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
		{
			return false;
		}
		if (!object.Equals(IADDBBBDGGM, other.IADDBBBDGGM))
		{
			return false;
		}
		if (!object.Equals(LBNHKPPAJIM, other.LBNHKPPAJIM))
		{
			return false;
		}
		if (!object.Equals(ECJCCKFEFEJ, other.ECJCCKFEFEJ))
		{
			return false;
		}
		if (FHPJJJDNKIOCase != other.FHPJJJDNKIOCase)
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
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.FEILNIKNPCB)
		{
			num ^= FEILNIKNPCB.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.BOCIPPBEBEA)
		{
			num ^= BOCIPPBEBEA.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.DAPJEDHFKCM)
		{
			num ^= DAPJEDHFKCM.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.HKGKNEKKJHB)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IMPBELJGDJH)
		{
			num ^= IMPBELJGDJH.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IADDBBBDGGM)
		{
			num ^= IADDBBBDGGM.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.LBNHKPPAJIM)
		{
			num ^= LBNHKPPAJIM.GetHashCode();
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.ECJCCKFEFEJ)
		{
			num ^= ECJCCKFEFEJ.GetHashCode();
		}
		num ^= (int)fHPJJJDNKIOCase_;
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
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.FEILNIKNPCB)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FEILNIKNPCB);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.BOCIPPBEBEA)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BOCIPPBEBEA);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.DAPJEDHFKCM)
		{
			output.WriteRawTag(50);
			output.WriteMessage(DAPJEDHFKCM);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.HKGKNEKKJHB)
		{
			output.WriteRawTag(66);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IMPBELJGDJH)
		{
			output.WriteRawTag(74);
			output.WriteMessage(IMPBELJGDJH);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IADDBBBDGGM)
		{
			output.WriteRawTag(98);
			output.WriteMessage(IADDBBBDGGM);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.LBNHKPPAJIM)
		{
			output.WriteRawTag(106);
			output.WriteMessage(LBNHKPPAJIM);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.ECJCCKFEFEJ)
		{
			output.WriteRawTag(122);
			output.WriteMessage(ECJCCKFEFEJ);
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
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.FEILNIKNPCB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.BOCIPPBEBEA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BOCIPPBEBEA);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.DAPJEDHFKCM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DAPJEDHFKCM);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.HKGKNEKKJHB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IMPBELJGDJH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IADDBBBDGGM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IADDBBBDGGM);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.LBNHKPPAJIM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBNHKPPAJIM);
		}
		if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.ECJCCKFEFEJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECJCCKFEFEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EOOEGPCPHKP other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.FHPJJJDNKIOCase)
		{
		case FHPJJJDNKIOOneofCase.FEILNIKNPCB:
			if (FEILNIKNPCB == null)
			{
				FEILNIKNPCB = new KKFANGIJAOF();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
			break;
		case FHPJJJDNKIOOneofCase.BOCIPPBEBEA:
			if (BOCIPPBEBEA == null)
			{
				BOCIPPBEBEA = new ADJBBLEBIEN();
			}
			BOCIPPBEBEA.MergeFrom(other.BOCIPPBEBEA);
			break;
		case FHPJJJDNKIOOneofCase.DAPJEDHFKCM:
			if (DAPJEDHFKCM == null)
			{
				DAPJEDHFKCM = new PGJNBNANDEE();
			}
			DAPJEDHFKCM.MergeFrom(other.DAPJEDHFKCM);
			break;
		case FHPJJJDNKIOOneofCase.HKGKNEKKJHB:
			if (HKGKNEKKJHB == null)
			{
				HKGKNEKKJHB = new CNJHCICPAIC();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
			break;
		case FHPJJJDNKIOOneofCase.IMPBELJGDJH:
			if (IMPBELJGDJH == null)
			{
				IMPBELJGDJH = new CALIIIHMJAC();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
			break;
		case FHPJJJDNKIOOneofCase.IADDBBBDGGM:
			if (IADDBBBDGGM == null)
			{
				IADDBBBDGGM = new POIFGDAHJCJ();
			}
			IADDBBBDGGM.MergeFrom(other.IADDBBBDGGM);
			break;
		case FHPJJJDNKIOOneofCase.LBNHKPPAJIM:
			if (LBNHKPPAJIM == null)
			{
				LBNHKPPAJIM = new MICOMIBPIOA();
			}
			LBNHKPPAJIM.MergeFrom(other.LBNHKPPAJIM);
			break;
		case FHPJJJDNKIOOneofCase.ECJCCKFEFEJ:
			if (ECJCCKFEFEJ == null)
			{
				ECJCCKFEFEJ = new PBMHMEADLEC();
			}
			ECJCCKFEFEJ.MergeFrom(other.ECJCCKFEFEJ);
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
			case 10u:
			{
				KKFANGIJAOF kKFANGIJAOF = new KKFANGIJAOF();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.FEILNIKNPCB)
				{
					kKFANGIJAOF.MergeFrom(FEILNIKNPCB);
				}
				input.ReadMessage(kKFANGIJAOF);
				FEILNIKNPCB = kKFANGIJAOF;
				break;
			}
			case 18u:
			{
				ADJBBLEBIEN aDJBBLEBIEN = new ADJBBLEBIEN();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.BOCIPPBEBEA)
				{
					aDJBBLEBIEN.MergeFrom(BOCIPPBEBEA);
				}
				input.ReadMessage(aDJBBLEBIEN);
				BOCIPPBEBEA = aDJBBLEBIEN;
				break;
			}
			case 50u:
			{
				PGJNBNANDEE pGJNBNANDEE = new PGJNBNANDEE();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.DAPJEDHFKCM)
				{
					pGJNBNANDEE.MergeFrom(DAPJEDHFKCM);
				}
				input.ReadMessage(pGJNBNANDEE);
				DAPJEDHFKCM = pGJNBNANDEE;
				break;
			}
			case 66u:
			{
				CNJHCICPAIC cNJHCICPAIC = new CNJHCICPAIC();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.HKGKNEKKJHB)
				{
					cNJHCICPAIC.MergeFrom(HKGKNEKKJHB);
				}
				input.ReadMessage(cNJHCICPAIC);
				HKGKNEKKJHB = cNJHCICPAIC;
				break;
			}
			case 74u:
			{
				CALIIIHMJAC cALIIIHMJAC = new CALIIIHMJAC();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IMPBELJGDJH)
				{
					cALIIIHMJAC.MergeFrom(IMPBELJGDJH);
				}
				input.ReadMessage(cALIIIHMJAC);
				IMPBELJGDJH = cALIIIHMJAC;
				break;
			}
			case 98u:
			{
				POIFGDAHJCJ pOIFGDAHJCJ = new POIFGDAHJCJ();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.IADDBBBDGGM)
				{
					pOIFGDAHJCJ.MergeFrom(IADDBBBDGGM);
				}
				input.ReadMessage(pOIFGDAHJCJ);
				IADDBBBDGGM = pOIFGDAHJCJ;
				break;
			}
			case 106u:
			{
				MICOMIBPIOA mICOMIBPIOA = new MICOMIBPIOA();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.LBNHKPPAJIM)
				{
					mICOMIBPIOA.MergeFrom(LBNHKPPAJIM);
				}
				input.ReadMessage(mICOMIBPIOA);
				LBNHKPPAJIM = mICOMIBPIOA;
				break;
			}
			case 122u:
			{
				PBMHMEADLEC pBMHMEADLEC = new PBMHMEADLEC();
				if (fHPJJJDNKIOCase_ == FHPJJJDNKIOOneofCase.ECJCCKFEFEJ)
				{
					pBMHMEADLEC.MergeFrom(ECJCCKFEFEJ);
				}
				input.ReadMessage(pBMHMEADLEC);
				ECJCCKFEFEJ = pBMHMEADLEC;
				break;
			}
			}
		}
	}
}
