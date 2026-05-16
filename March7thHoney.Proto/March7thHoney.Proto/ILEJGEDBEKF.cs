using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ILEJGEDBEKF : IMessage<ILEJGEDBEKF>, IMessage, IEquatable<ILEJGEDBEKF>, IDeepCloneable<ILEJGEDBEKF>, IBufferMessage
{
	private static readonly MessageParser<ILEJGEDBEKF> _parser = new MessageParser<ILEJGEDBEKF>(() => new ILEJGEDBEKF());

	private UnknownFieldSet _unknownFields;

	public const int StoryInfoFieldNumber = 1;

	private AMGMAIOKJLN storyInfo_;

	public const int MODDIBHCPPDFieldNumber = 2;

	private CGDFGMMKJAH mODDIBHCPPD_;

	public const int BHOOLFGEIAAFieldNumber = 3;

	private NAMGFEONKFK bHOOLFGEIAA_;

	public const int LBNHKPPAJIMFieldNumber = 4;

	private MPKGLGCLAID lBNHKPPAJIM_;

	public const int CGIFJAOHHAOFieldNumber = 5;

	private EJDFGNGBNOO cGIFJAOHHAO_;

	public const int JGHIBCLBLAGFieldNumber = 6;

	private JBEENGDECOH jGHIBCLBLAG_;

	public const int RogueCurrentGameInfoFieldNumber = 7;

	private static readonly FieldCodec<EOOEGPCPHKP> _repeated_rogueCurrentGameInfo_codec = FieldCodec.ForMessage(58u, EOOEGPCPHKP.Parser);

	private readonly RepeatedField<EOOEGPCPHKP> rogueCurrentGameInfo_ = new RepeatedField<EOOEGPCPHKP>();

	public const int PJABKDBFPIMFieldNumber = 8;

	private DFAOIALEBOH pJABKDBFPIM_;

	public const int HKGKNEKKJHBFieldNumber = 9;

	private CNJHCICPAIC hKGKNEKKJHB_;

	public const int IMPBELJGDJHFieldNumber = 12;

	private JMOGPMCJGLE iMPBELJGDJH_;

	public const int LOIDOGEENOBFieldNumber = 13;

	private uint lOIDOGEENOB_;

	public const int PendingActionFieldNumber = 14;

	private EPPJHNIHAFL pendingAction_;

	public const int FEILNIKNPCBFieldNumber = 15;

	private KKFANGIJAOF fEILNIKNPCB_;

	public const int BOCIPPBEBEAFieldNumber = 1635;

	private MKJPDJNHNBO bOCIPPBEBEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ILEJGEDBEKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ILEJGEDBEKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMGMAIOKJLN StoryInfo
	{
		get
		{
			return storyInfo_;
		}
		set
		{
			storyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDFGMMKJAH MODDIBHCPPD
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
	public NAMGFEONKFK BHOOLFGEIAA
	{
		get
		{
			return bHOOLFGEIAA_;
		}
		set
		{
			bHOOLFGEIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPKGLGCLAID LBNHKPPAJIM
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
	public JBEENGDECOH JGHIBCLBLAG
	{
		get
		{
			return jGHIBCLBLAG_;
		}
		set
		{
			jGHIBCLBLAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EOOEGPCPHKP> RogueCurrentGameInfo => rogueCurrentGameInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAOIALEBOH PJABKDBFPIM
	{
		get
		{
			return pJABKDBFPIM_;
		}
		set
		{
			pJABKDBFPIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNJHCICPAIC HKGKNEKKJHB
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
	public JMOGPMCJGLE IMPBELJGDJH
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
	public uint LOIDOGEENOB
	{
		get
		{
			return lOIDOGEENOB_;
		}
		set
		{
			lOIDOGEENOB_ = value;
		}
	}

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
	public KKFANGIJAOF FEILNIKNPCB
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
	public MKJPDJNHNBO BOCIPPBEBEA
	{
		get
		{
			return bOCIPPBEBEA_;
		}
		set
		{
			bOCIPPBEBEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILEJGEDBEKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILEJGEDBEKF(ILEJGEDBEKF other)
		: this()
	{
		storyInfo_ = ((other.storyInfo_ != null) ? other.storyInfo_.Clone() : null);
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		bHOOLFGEIAA_ = ((other.bHOOLFGEIAA_ != null) ? other.bHOOLFGEIAA_.Clone() : null);
		lBNHKPPAJIM_ = ((other.lBNHKPPAJIM_ != null) ? other.lBNHKPPAJIM_.Clone() : null);
		cGIFJAOHHAO_ = ((other.cGIFJAOHHAO_ != null) ? other.cGIFJAOHHAO_.Clone() : null);
		jGHIBCLBLAG_ = ((other.jGHIBCLBLAG_ != null) ? other.jGHIBCLBLAG_.Clone() : null);
		rogueCurrentGameInfo_ = other.rogueCurrentGameInfo_.Clone();
		pJABKDBFPIM_ = ((other.pJABKDBFPIM_ != null) ? other.pJABKDBFPIM_.Clone() : null);
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		iMPBELJGDJH_ = ((other.iMPBELJGDJH_ != null) ? other.iMPBELJGDJH_.Clone() : null);
		lOIDOGEENOB_ = other.lOIDOGEENOB_;
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		bOCIPPBEBEA_ = ((other.bOCIPPBEBEA_ != null) ? other.bOCIPPBEBEA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILEJGEDBEKF Clone()
	{
		return new ILEJGEDBEKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ILEJGEDBEKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ILEJGEDBEKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StoryInfo, other.StoryInfo))
		{
			return false;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
		{
			return false;
		}
		if (!object.Equals(BHOOLFGEIAA, other.BHOOLFGEIAA))
		{
			return false;
		}
		if (!object.Equals(LBNHKPPAJIM, other.LBNHKPPAJIM))
		{
			return false;
		}
		if (!object.Equals(CGIFJAOHHAO, other.CGIFJAOHHAO))
		{
			return false;
		}
		if (!object.Equals(JGHIBCLBLAG, other.JGHIBCLBLAG))
		{
			return false;
		}
		if (!rogueCurrentGameInfo_.Equals(other.rogueCurrentGameInfo_))
		{
			return false;
		}
		if (!object.Equals(PJABKDBFPIM, other.PJABKDBFPIM))
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
		if (LOIDOGEENOB != other.LOIDOGEENOB)
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
		{
			return false;
		}
		if (!object.Equals(BOCIPPBEBEA, other.BOCIPPBEBEA))
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
		if (storyInfo_ != null)
		{
			num ^= StoryInfo.GetHashCode();
		}
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
		}
		if (bHOOLFGEIAA_ != null)
		{
			num ^= BHOOLFGEIAA.GetHashCode();
		}
		if (lBNHKPPAJIM_ != null)
		{
			num ^= LBNHKPPAJIM.GetHashCode();
		}
		if (cGIFJAOHHAO_ != null)
		{
			num ^= CGIFJAOHHAO.GetHashCode();
		}
		if (jGHIBCLBLAG_ != null)
		{
			num ^= JGHIBCLBLAG.GetHashCode();
		}
		num ^= rogueCurrentGameInfo_.GetHashCode();
		if (pJABKDBFPIM_ != null)
		{
			num ^= PJABKDBFPIM.GetHashCode();
		}
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (iMPBELJGDJH_ != null)
		{
			num ^= IMPBELJGDJH.GetHashCode();
		}
		if (LOIDOGEENOB != 0)
		{
			num ^= LOIDOGEENOB.GetHashCode();
		}
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
		}
		if (bOCIPPBEBEA_ != null)
		{
			num ^= BOCIPPBEBEA.GetHashCode();
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
		if (storyInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StoryInfo);
		}
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (bHOOLFGEIAA_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BHOOLFGEIAA);
		}
		if (lBNHKPPAJIM_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(LBNHKPPAJIM);
		}
		if (cGIFJAOHHAO_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CGIFJAOHHAO);
		}
		if (jGHIBCLBLAG_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JGHIBCLBLAG);
		}
		rogueCurrentGameInfo_.WriteTo(ref output, _repeated_rogueCurrentGameInfo_codec);
		if (pJABKDBFPIM_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PJABKDBFPIM);
		}
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (iMPBELJGDJH_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(IMPBELJGDJH);
		}
		if (LOIDOGEENOB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LOIDOGEENOB);
		}
		if (pendingAction_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(PendingAction);
		}
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(FEILNIKNPCB);
		}
		if (bOCIPPBEBEA_ != null)
		{
			output.WriteRawTag(154, 102);
			output.WriteMessage(BOCIPPBEBEA);
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
		if (storyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoryInfo);
		}
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (bHOOLFGEIAA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BHOOLFGEIAA);
		}
		if (lBNHKPPAJIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBNHKPPAJIM);
		}
		if (cGIFJAOHHAO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGIFJAOHHAO);
		}
		if (jGHIBCLBLAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JGHIBCLBLAG);
		}
		num += rogueCurrentGameInfo_.CalculateSize(_repeated_rogueCurrentGameInfo_codec);
		if (pJABKDBFPIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJABKDBFPIM);
		}
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (iMPBELJGDJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (LOIDOGEENOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIDOGEENOB);
		}
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (bOCIPPBEBEA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BOCIPPBEBEA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ILEJGEDBEKF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.storyInfo_ != null)
		{
			if (storyInfo_ == null)
			{
				StoryInfo = new AMGMAIOKJLN();
			}
			StoryInfo.MergeFrom(other.StoryInfo);
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new CGDFGMMKJAH();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
		}
		if (other.bHOOLFGEIAA_ != null)
		{
			if (bHOOLFGEIAA_ == null)
			{
				BHOOLFGEIAA = new NAMGFEONKFK();
			}
			BHOOLFGEIAA.MergeFrom(other.BHOOLFGEIAA);
		}
		if (other.lBNHKPPAJIM_ != null)
		{
			if (lBNHKPPAJIM_ == null)
			{
				LBNHKPPAJIM = new MPKGLGCLAID();
			}
			LBNHKPPAJIM.MergeFrom(other.LBNHKPPAJIM);
		}
		if (other.cGIFJAOHHAO_ != null)
		{
			if (cGIFJAOHHAO_ == null)
			{
				CGIFJAOHHAO = new EJDFGNGBNOO();
			}
			CGIFJAOHHAO.MergeFrom(other.CGIFJAOHHAO);
		}
		if (other.jGHIBCLBLAG_ != null)
		{
			if (jGHIBCLBLAG_ == null)
			{
				JGHIBCLBLAG = new JBEENGDECOH();
			}
			JGHIBCLBLAG.MergeFrom(other.JGHIBCLBLAG);
		}
		rogueCurrentGameInfo_.Add(other.rogueCurrentGameInfo_);
		if (other.pJABKDBFPIM_ != null)
		{
			if (pJABKDBFPIM_ == null)
			{
				PJABKDBFPIM = new DFAOIALEBOH();
			}
			PJABKDBFPIM.MergeFrom(other.PJABKDBFPIM);
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new CNJHCICPAIC();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
		}
		if (other.iMPBELJGDJH_ != null)
		{
			if (iMPBELJGDJH_ == null)
			{
				IMPBELJGDJH = new JMOGPMCJGLE();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
		}
		if (other.LOIDOGEENOB != 0)
		{
			LOIDOGEENOB = other.LOIDOGEENOB;
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new EPPJHNIHAFL();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new KKFANGIJAOF();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
		}
		if (other.bOCIPPBEBEA_ != null)
		{
			if (bOCIPPBEBEA_ == null)
			{
				BOCIPPBEBEA = new MKJPDJNHNBO();
			}
			BOCIPPBEBEA.MergeFrom(other.BOCIPPBEBEA);
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
				if (storyInfo_ == null)
				{
					StoryInfo = new AMGMAIOKJLN();
				}
				input.ReadMessage(StoryInfo);
				break;
			case 18u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new CGDFGMMKJAH();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 26u:
				if (bHOOLFGEIAA_ == null)
				{
					BHOOLFGEIAA = new NAMGFEONKFK();
				}
				input.ReadMessage(BHOOLFGEIAA);
				break;
			case 34u:
				if (lBNHKPPAJIM_ == null)
				{
					LBNHKPPAJIM = new MPKGLGCLAID();
				}
				input.ReadMessage(LBNHKPPAJIM);
				break;
			case 42u:
				if (cGIFJAOHHAO_ == null)
				{
					CGIFJAOHHAO = new EJDFGNGBNOO();
				}
				input.ReadMessage(CGIFJAOHHAO);
				break;
			case 50u:
				if (jGHIBCLBLAG_ == null)
				{
					JGHIBCLBLAG = new JBEENGDECOH();
				}
				input.ReadMessage(JGHIBCLBLAG);
				break;
			case 58u:
				rogueCurrentGameInfo_.AddEntriesFrom(ref input, _repeated_rogueCurrentGameInfo_codec);
				break;
			case 66u:
				if (pJABKDBFPIM_ == null)
				{
					PJABKDBFPIM = new DFAOIALEBOH();
				}
				input.ReadMessage(PJABKDBFPIM);
				break;
			case 74u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new CNJHCICPAIC();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			case 98u:
				if (iMPBELJGDJH_ == null)
				{
					IMPBELJGDJH = new JMOGPMCJGLE();
				}
				input.ReadMessage(IMPBELJGDJH);
				break;
			case 104u:
				LOIDOGEENOB = input.ReadUInt32();
				break;
			case 114u:
				if (pendingAction_ == null)
				{
					PendingAction = new EPPJHNIHAFL();
				}
				input.ReadMessage(PendingAction);
				break;
			case 122u:
				if (fEILNIKNPCB_ == null)
				{
					FEILNIKNPCB = new KKFANGIJAOF();
				}
				input.ReadMessage(FEILNIKNPCB);
				break;
			case 13082u:
				if (bOCIPPBEBEA_ == null)
				{
					BOCIPPBEBEA = new MKJPDJNHNBO();
				}
				input.ReadMessage(BOCIPPBEBEA);
				break;
			}
		}
	}
}
