using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGNEFKDLPKN : IMessage<PGNEFKDLPKN>, IMessage, IEquatable<PGNEFKDLPKN>, IDeepCloneable<PGNEFKDLPKN>, IBufferMessage
{
	private static readonly MessageParser<PGNEFKDLPKN> _parser = new MessageParser<PGNEFKDLPKN>(() => new PGNEFKDLPKN());

	private UnknownFieldSet _unknownFields;

	public const int PendingActionFieldNumber = 1;

	private EPPJHNIHAFL pendingAction_;

	public const int AMMJECHPGPEFieldNumber = 2;

	private ENEGIFOKGKL aMMJECHPGPE_;

	public const int FEILNIKNPCBFieldNumber = 3;

	private BABKEAFELGE fEILNIKNPCB_;

	public const int CGIFJAOHHAOFieldNumber = 4;

	private EJDFGNGBNOO cGIFJAOHHAO_;

	public const int IMPBELJGDJHFieldNumber = 6;

	private APBKAPPGPJC iMPBELJGDJH_;

	public const int DKIFGMICGPIFieldNumber = 8;

	private GLOONOCCEFG dKIFGMICGPI_;

	public const int StatusFieldNumber = 10;

	private RogueStatus status_;

	public const int LBNHKPPAJIMFieldNumber = 12;

	private PDDEEAJIOKG lBNHKPPAJIM_;

	public const int HKGKNEKKJHBFieldNumber = 14;

	private DLHLNGCJKJL hKGKNEKKJHB_;

	public const int FIEDLDNEMEDFieldNumber = 15;

	private bool fIEDLDNEMED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGNEFKDLPKN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGNEFKDLPKNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPPJHNIHAFL PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEGIFOKGKL AMMJECHPGPE
	{
		get
		{
			return aMMJECHPGPE_;
		}
		set
		{
			aMMJECHPGPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABKEAFELGE FEILNIKNPCB
	{
		get
		{
			return fEILNIKNPCB_;
		}
		set
		{
			fEILNIKNPCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJDFGNGBNOO CGIFJAOHHAO
	{
		get
		{
			return cGIFJAOHHAO_;
		}
		set
		{
			cGIFJAOHHAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APBKAPPGPJC IMPBELJGDJH
	{
		get
		{
			return iMPBELJGDJH_;
		}
		set
		{
			iMPBELJGDJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOONOCCEFG DKIFGMICGPI
	{
		get
		{
			return dKIFGMICGPI_;
		}
		set
		{
			dKIFGMICGPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueStatus Status
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
	public PDDEEAJIOKG LBNHKPPAJIM
	{
		get
		{
			return lBNHKPPAJIM_;
		}
		set
		{
			lBNHKPPAJIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLHLNGCJKJL HKGKNEKKJHB
	{
		get
		{
			return hKGKNEKKJHB_;
		}
		set
		{
			hKGKNEKKJHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FIEDLDNEMED
	{
		get
		{
			return fIEDLDNEMED_;
		}
		set
		{
			fIEDLDNEMED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGNEFKDLPKN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGNEFKDLPKN(PGNEFKDLPKN other)
		: this()
	{
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		aMMJECHPGPE_ = ((other.aMMJECHPGPE_ != null) ? other.aMMJECHPGPE_.Clone() : null);
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		cGIFJAOHHAO_ = ((other.cGIFJAOHHAO_ != null) ? other.cGIFJAOHHAO_.Clone() : null);
		iMPBELJGDJH_ = ((other.iMPBELJGDJH_ != null) ? other.iMPBELJGDJH_.Clone() : null);
		dKIFGMICGPI_ = ((other.dKIFGMICGPI_ != null) ? other.dKIFGMICGPI_.Clone() : null);
		status_ = other.status_;
		lBNHKPPAJIM_ = ((other.lBNHKPPAJIM_ != null) ? other.lBNHKPPAJIM_.Clone() : null);
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		fIEDLDNEMED_ = other.fIEDLDNEMED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGNEFKDLPKN Clone()
	{
		return new PGNEFKDLPKN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGNEFKDLPKN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGNEFKDLPKN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!object.Equals(AMMJECHPGPE, other.AMMJECHPGPE))
		{
			return false;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
		{
			return false;
		}
		if (!object.Equals(CGIFJAOHHAO, other.CGIFJAOHHAO))
		{
			return false;
		}
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
		{
			return false;
		}
		if (!object.Equals(DKIFGMICGPI, other.DKIFGMICGPI))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (!object.Equals(LBNHKPPAJIM, other.LBNHKPPAJIM))
		{
			return false;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
		{
			return false;
		}
		if (FIEDLDNEMED != other.FIEDLDNEMED)
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
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (aMMJECHPGPE_ != null)
		{
			num ^= AMMJECHPGPE.GetHashCode();
		}
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
		}
		if (cGIFJAOHHAO_ != null)
		{
			num ^= CGIFJAOHHAO.GetHashCode();
		}
		if (iMPBELJGDJH_ != null)
		{
			num ^= IMPBELJGDJH.GetHashCode();
		}
		if (dKIFGMICGPI_ != null)
		{
			num ^= DKIFGMICGPI.GetHashCode();
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (lBNHKPPAJIM_ != null)
		{
			num ^= LBNHKPPAJIM.GetHashCode();
		}
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (FIEDLDNEMED)
		{
			num ^= FIEDLDNEMED.GetHashCode();
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
		if (pendingAction_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PendingAction);
		}
		if (aMMJECHPGPE_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AMMJECHPGPE);
		}
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(FEILNIKNPCB);
		}
		if (cGIFJAOHHAO_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CGIFJAOHHAO);
		}
		if (iMPBELJGDJH_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(IMPBELJGDJH);
		}
		if (dKIFGMICGPI_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DKIFGMICGPI);
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)Status);
		}
		if (lBNHKPPAJIM_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(LBNHKPPAJIM);
		}
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (FIEDLDNEMED)
		{
			output.WriteRawTag(120);
			output.WriteBool(FIEDLDNEMED);
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
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (aMMJECHPGPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMMJECHPGPE);
		}
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (cGIFJAOHHAO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGIFJAOHHAO);
		}
		if (iMPBELJGDJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (dKIFGMICGPI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DKIFGMICGPI);
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (lBNHKPPAJIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBNHKPPAJIM);
		}
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (FIEDLDNEMED)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGNEFKDLPKN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new EPPJHNIHAFL();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		if (other.aMMJECHPGPE_ != null)
		{
			if (aMMJECHPGPE_ == null)
			{
				AMMJECHPGPE = new ENEGIFOKGKL();
			}
			AMMJECHPGPE.MergeFrom(other.AMMJECHPGPE);
		}
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new BABKEAFELGE();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
		}
		if (other.cGIFJAOHHAO_ != null)
		{
			if (cGIFJAOHHAO_ == null)
			{
				CGIFJAOHHAO = new EJDFGNGBNOO();
			}
			CGIFJAOHHAO.MergeFrom(other.CGIFJAOHHAO);
		}
		if (other.iMPBELJGDJH_ != null)
		{
			if (iMPBELJGDJH_ == null)
			{
				IMPBELJGDJH = new APBKAPPGPJC();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
		}
		if (other.dKIFGMICGPI_ != null)
		{
			if (dKIFGMICGPI_ == null)
			{
				DKIFGMICGPI = new GLOONOCCEFG();
			}
			DKIFGMICGPI.MergeFrom(other.DKIFGMICGPI);
		}
		if (other.Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			Status = other.Status;
		}
		if (other.lBNHKPPAJIM_ != null)
		{
			if (lBNHKPPAJIM_ == null)
			{
				LBNHKPPAJIM = new PDDEEAJIOKG();
			}
			LBNHKPPAJIM.MergeFrom(other.LBNHKPPAJIM);
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new DLHLNGCJKJL();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
		}
		if (other.FIEDLDNEMED)
		{
			FIEDLDNEMED = other.FIEDLDNEMED;
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
				if (pendingAction_ == null)
				{
					PendingAction = new EPPJHNIHAFL();
				}
				input.ReadMessage(PendingAction);
				break;
			case 18u:
				if (aMMJECHPGPE_ == null)
				{
					AMMJECHPGPE = new ENEGIFOKGKL();
				}
				input.ReadMessage(AMMJECHPGPE);
				break;
			case 26u:
				if (fEILNIKNPCB_ == null)
				{
					FEILNIKNPCB = new BABKEAFELGE();
				}
				input.ReadMessage(FEILNIKNPCB);
				break;
			case 34u:
				if (cGIFJAOHHAO_ == null)
				{
					CGIFJAOHHAO = new EJDFGNGBNOO();
				}
				input.ReadMessage(CGIFJAOHHAO);
				break;
			case 50u:
				if (iMPBELJGDJH_ == null)
				{
					IMPBELJGDJH = new APBKAPPGPJC();
				}
				input.ReadMessage(IMPBELJGDJH);
				break;
			case 66u:
				if (dKIFGMICGPI_ == null)
				{
					DKIFGMICGPI = new GLOONOCCEFG();
				}
				input.ReadMessage(DKIFGMICGPI);
				break;
			case 80u:
				Status = (RogueStatus)input.ReadEnum();
				break;
			case 98u:
				if (lBNHKPPAJIM_ == null)
				{
					LBNHKPPAJIM = new PDDEEAJIOKG();
				}
				input.ReadMessage(LBNHKPPAJIM);
				break;
			case 114u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new DLHLNGCJKJL();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			case 120u:
				FIEDLDNEMED = input.ReadBool();
				break;
			}
		}
	}
}
