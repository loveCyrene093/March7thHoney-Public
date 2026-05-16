using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBBEGDELEEI : IMessage<LBBEGDELEEI>, IMessage, IEquatable<LBBEGDELEEI>, IDeepCloneable<LBBEGDELEEI>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		KPFAPJLOJCL = 1,
		PGOODEGCBFO = 2,
		CLCDMKJHCGD = 3,
		PEGKAAFHFKI = 6,
		ADGJILHIIAB = 7,
		DOINBJJKLFP = 8,
		ODALNGOKHMF = 10,
		FIMNPEBOBHL = 12,
		LFBBILEKCKC = 14
	}

	private static readonly MessageParser<LBBEGDELEEI> _parser = new MessageParser<LBBEGDELEEI>(() => new LBBEGDELEEI());

	private UnknownFieldSet _unknownFields;

	public const int KPFAPJLOJCLFieldNumber = 1;

	public const int PGOODEGCBFOFieldNumber = 2;

	public const int CLCDMKJHCGDFieldNumber = 3;

	public const int PEGKAAFHFKIFieldNumber = 6;

	public const int ADGJILHIIABFieldNumber = 7;

	public const int DOINBJJKLFPFieldNumber = 8;

	public const int ODALNGOKHMFFieldNumber = 10;

	public const int FIMNPEBOBHLFieldNumber = 12;

	public const int LFBBILEKCKCFieldNumber = 14;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBBEGDELEEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBBEGDELEEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPFAPJLOJCL
	{
		get
		{
			if (!HasKPFAPJLOJCL)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.KPFAPJLOJCL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKPFAPJLOJCL => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.KPFAPJLOJCL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGOODEGCBFO
	{
		get
		{
			if (!HasPGOODEGCBFO)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.PGOODEGCBFO;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPGOODEGCBFO => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PGOODEGCBFO;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLMHJIHCMBB CLCDMKJHCGD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.CLCDMKJHCGD)
			{
				return null;
			}
			return (OLMHJIHCMBB)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.CLCDMKJHCGD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPDHIFKGDCL PEGKAAFHFKI
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PEGKAAFHFKI)
			{
				return null;
			}
			return (MPDHIFKGDCL)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PEGKAAFHFKI : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ADGJILHIIAB
	{
		get
		{
			if (!HasADGJILHIIAB)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.ADGJILHIIAB;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasADGJILHIIAB => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADGJILHIIAB;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPJFOBOKKNO DOINBJJKLFP
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.DOINBJJKLFP)
			{
				return null;
			}
			return (KPJFOBOKKNO)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.DOINBJJKLFP : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODALNGOKHMF
	{
		get
		{
			if (!HasODALNGOKHMF)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.ODALNGOKHMF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasODALNGOKHMF => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ODALNGOKHMF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIMNPEBOBHL
	{
		get
		{
			if (!HasFIMNPEBOBHL)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.FIMNPEBOBHL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFIMNPEBOBHL => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FIMNPEBOBHL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPJCDAMNIMJ LFBBILEKCKC
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.LFBBILEKCKC)
			{
				return null;
			}
			return (OPJCDAMNIMJ)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.LFBBILEKCKC : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBBEGDELEEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBBEGDELEEI(LBBEGDELEEI other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.KPFAPJLOJCL:
			KPFAPJLOJCL = other.KPFAPJLOJCL;
			break;
		case NLPPPCHGGPFOneofCase.PGOODEGCBFO:
			PGOODEGCBFO = other.PGOODEGCBFO;
			break;
		case NLPPPCHGGPFOneofCase.CLCDMKJHCGD:
			CLCDMKJHCGD = other.CLCDMKJHCGD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.PEGKAAFHFKI:
			PEGKAAFHFKI = other.PEGKAAFHFKI.Clone();
			break;
		case NLPPPCHGGPFOneofCase.ADGJILHIIAB:
			ADGJILHIIAB = other.ADGJILHIIAB;
			break;
		case NLPPPCHGGPFOneofCase.DOINBJJKLFP:
			DOINBJJKLFP = other.DOINBJJKLFP.Clone();
			break;
		case NLPPPCHGGPFOneofCase.ODALNGOKHMF:
			ODALNGOKHMF = other.ODALNGOKHMF;
			break;
		case NLPPPCHGGPFOneofCase.FIMNPEBOBHL:
			FIMNPEBOBHL = other.FIMNPEBOBHL;
			break;
		case NLPPPCHGGPFOneofCase.LFBBILEKCKC:
			LFBBILEKCKC = other.LFBBILEKCKC.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBBEGDELEEI Clone()
	{
		return new LBBEGDELEEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKPFAPJLOJCL()
	{
		if (HasKPFAPJLOJCL)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPGOODEGCBFO()
	{
		if (HasPGOODEGCBFO)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearADGJILHIIAB()
	{
		if (HasADGJILHIIAB)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearODALNGOKHMF()
	{
		if (HasODALNGOKHMF)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFIMNPEBOBHL()
	{
		if (HasFIMNPEBOBHL)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBBEGDELEEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBBEGDELEEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KPFAPJLOJCL != other.KPFAPJLOJCL)
		{
			return false;
		}
		if (PGOODEGCBFO != other.PGOODEGCBFO)
		{
			return false;
		}
		if (!object.Equals(CLCDMKJHCGD, other.CLCDMKJHCGD))
		{
			return false;
		}
		if (!object.Equals(PEGKAAFHFKI, other.PEGKAAFHFKI))
		{
			return false;
		}
		if (ADGJILHIIAB != other.ADGJILHIIAB)
		{
			return false;
		}
		if (!object.Equals(DOINBJJKLFP, other.DOINBJJKLFP))
		{
			return false;
		}
		if (ODALNGOKHMF != other.ODALNGOKHMF)
		{
			return false;
		}
		if (FIMNPEBOBHL != other.FIMNPEBOBHL)
		{
			return false;
		}
		if (!object.Equals(LFBBILEKCKC, other.LFBBILEKCKC))
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (HasKPFAPJLOJCL)
		{
			num ^= KPFAPJLOJCL.GetHashCode();
		}
		if (HasPGOODEGCBFO)
		{
			num ^= PGOODEGCBFO.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CLCDMKJHCGD)
		{
			num ^= CLCDMKJHCGD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PEGKAAFHFKI)
		{
			num ^= PEGKAAFHFKI.GetHashCode();
		}
		if (HasADGJILHIIAB)
		{
			num ^= ADGJILHIIAB.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOINBJJKLFP)
		{
			num ^= DOINBJJKLFP.GetHashCode();
		}
		if (HasODALNGOKHMF)
		{
			num ^= ODALNGOKHMF.GetHashCode();
		}
		if (HasFIMNPEBOBHL)
		{
			num ^= FIMNPEBOBHL.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LFBBILEKCKC)
		{
			num ^= LFBBILEKCKC.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
		if (HasKPFAPJLOJCL)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KPFAPJLOJCL);
		}
		if (HasPGOODEGCBFO)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PGOODEGCBFO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CLCDMKJHCGD)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CLCDMKJHCGD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PEGKAAFHFKI)
		{
			output.WriteRawTag(50);
			output.WriteMessage(PEGKAAFHFKI);
		}
		if (HasADGJILHIIAB)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ADGJILHIIAB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOINBJJKLFP)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DOINBJJKLFP);
		}
		if (HasODALNGOKHMF)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ODALNGOKHMF);
		}
		if (HasFIMNPEBOBHL)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FIMNPEBOBHL);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LFBBILEKCKC)
		{
			output.WriteRawTag(114);
			output.WriteMessage(LFBBILEKCKC);
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
		if (HasKPFAPJLOJCL)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPFAPJLOJCL);
		}
		if (HasPGOODEGCBFO)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGOODEGCBFO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CLCDMKJHCGD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CLCDMKJHCGD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PEGKAAFHFKI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEGKAAFHFKI);
		}
		if (HasADGJILHIIAB)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ADGJILHIIAB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOINBJJKLFP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DOINBJJKLFP);
		}
		if (HasODALNGOKHMF)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODALNGOKHMF);
		}
		if (HasFIMNPEBOBHL)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIMNPEBOBHL);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LFBBILEKCKC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LFBBILEKCKC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBBEGDELEEI other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.KPFAPJLOJCL:
			KPFAPJLOJCL = other.KPFAPJLOJCL;
			break;
		case NLPPPCHGGPFOneofCase.PGOODEGCBFO:
			PGOODEGCBFO = other.PGOODEGCBFO;
			break;
		case NLPPPCHGGPFOneofCase.CLCDMKJHCGD:
			if (CLCDMKJHCGD == null)
			{
				CLCDMKJHCGD = new OLMHJIHCMBB();
			}
			CLCDMKJHCGD.MergeFrom(other.CLCDMKJHCGD);
			break;
		case NLPPPCHGGPFOneofCase.PEGKAAFHFKI:
			if (PEGKAAFHFKI == null)
			{
				PEGKAAFHFKI = new MPDHIFKGDCL();
			}
			PEGKAAFHFKI.MergeFrom(other.PEGKAAFHFKI);
			break;
		case NLPPPCHGGPFOneofCase.ADGJILHIIAB:
			ADGJILHIIAB = other.ADGJILHIIAB;
			break;
		case NLPPPCHGGPFOneofCase.DOINBJJKLFP:
			if (DOINBJJKLFP == null)
			{
				DOINBJJKLFP = new KPJFOBOKKNO();
			}
			DOINBJJKLFP.MergeFrom(other.DOINBJJKLFP);
			break;
		case NLPPPCHGGPFOneofCase.ODALNGOKHMF:
			ODALNGOKHMF = other.ODALNGOKHMF;
			break;
		case NLPPPCHGGPFOneofCase.FIMNPEBOBHL:
			FIMNPEBOBHL = other.FIMNPEBOBHL;
			break;
		case NLPPPCHGGPFOneofCase.LFBBILEKCKC:
			if (LFBBILEKCKC == null)
			{
				LFBBILEKCKC = new OPJCDAMNIMJ();
			}
			LFBBILEKCKC.MergeFrom(other.LFBBILEKCKC);
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
			case 8u:
				KPFAPJLOJCL = input.ReadUInt32();
				break;
			case 16u:
				PGOODEGCBFO = input.ReadUInt32();
				break;
			case 26u:
			{
				OLMHJIHCMBB oLMHJIHCMBB = new OLMHJIHCMBB();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.CLCDMKJHCGD)
				{
					oLMHJIHCMBB.MergeFrom(CLCDMKJHCGD);
				}
				input.ReadMessage(oLMHJIHCMBB);
				CLCDMKJHCGD = oLMHJIHCMBB;
				break;
			}
			case 50u:
			{
				MPDHIFKGDCL mPDHIFKGDCL = new MPDHIFKGDCL();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PEGKAAFHFKI)
				{
					mPDHIFKGDCL.MergeFrom(PEGKAAFHFKI);
				}
				input.ReadMessage(mPDHIFKGDCL);
				PEGKAAFHFKI = mPDHIFKGDCL;
				break;
			}
			case 56u:
				ADGJILHIIAB = input.ReadUInt32();
				break;
			case 66u:
			{
				KPJFOBOKKNO kPJFOBOKKNO = new KPJFOBOKKNO();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOINBJJKLFP)
				{
					kPJFOBOKKNO.MergeFrom(DOINBJJKLFP);
				}
				input.ReadMessage(kPJFOBOKKNO);
				DOINBJJKLFP = kPJFOBOKKNO;
				break;
			}
			case 80u:
				ODALNGOKHMF = input.ReadUInt32();
				break;
			case 96u:
				FIMNPEBOBHL = input.ReadUInt32();
				break;
			case 114u:
			{
				OPJCDAMNIMJ oPJCDAMNIMJ = new OPJCDAMNIMJ();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LFBBILEKCKC)
				{
					oPJCDAMNIMJ.MergeFrom(LFBBILEKCKC);
				}
				input.ReadMessage(oPJCDAMNIMJ);
				LFBBILEKCKC = oPJCDAMNIMJ;
				break;
			}
			}
		}
	}
}
