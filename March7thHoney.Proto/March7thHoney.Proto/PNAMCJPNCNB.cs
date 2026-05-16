using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNAMCJPNCNB : IMessage<PNAMCJPNCNB>, IMessage, IEquatable<PNAMCJPNCNB>, IDeepCloneable<PNAMCJPNCNB>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		MAECOFLEAGD = 1,
		HBMPBIOLCGD = 3,
		AJAIDIBLMAO = 4,
		LLNNPGEOFCD = 5,
		JGNAJOFIKEJ = 6,
		NJMKOPKJCGC = 7,
		APBBENFPNLL = 8,
		MBKDAFJCHAC = 10,
		EIENKJFFFJG = 11,
		NHHFADEBELO = 12,
		FHCPKOMPCDH = 15
	}

	private static readonly MessageParser<PNAMCJPNCNB> _parser = new MessageParser<PNAMCJPNCNB>(() => new PNAMCJPNCNB());

	private UnknownFieldSet _unknownFields;

	public const int MAECOFLEAGDFieldNumber = 1;

	public const int HBMPBIOLCGDFieldNumber = 3;

	public const int AJAIDIBLMAOFieldNumber = 4;

	public const int LLNNPGEOFCDFieldNumber = 5;

	public const int JGNAJOFIKEJFieldNumber = 6;

	public const int NJMKOPKJCGCFieldNumber = 7;

	public const int APBBENFPNLLFieldNumber = 8;

	public const int MBKDAFJCHACFieldNumber = 10;

	public const int EIENKJFFFJGFieldNumber = 11;

	public const int NHHFADEBELOFieldNumber = 12;

	public const int FHCPKOMPCDHFieldNumber = 15;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNAMCJPNCNB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNAMCJPNCNBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJHELAAIMBG MAECOFLEAGD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.MAECOFLEAGD)
			{
				return null;
			}
			return (AJHELAAIMBG)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.MAECOFLEAGD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JADJCGAJNJO HBMPBIOLCGD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.HBMPBIOLCGD)
			{
				return null;
			}
			return (JADJCGAJNJO)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.HBMPBIOLCGD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLNMEFLNPOA AJAIDIBLMAO
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.AJAIDIBLMAO)
			{
				return null;
			}
			return (JLNMEFLNPOA)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.AJAIDIBLMAO : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHONFMMAJEB LLNNPGEOFCD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.LLNNPGEOFCD)
			{
				return null;
			}
			return (OHONFMMAJEB)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.LLNNPGEOFCD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEHCHGIGBNC JGNAJOFIKEJ
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.JGNAJOFIKEJ)
			{
				return null;
			}
			return (FEHCHGIGBNC)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.JGNAJOFIKEJ : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJPBAJGNLMI NJMKOPKJCGC
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NJMKOPKJCGC)
			{
				return null;
			}
			return (LJPBAJGNLMI)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NJMKOPKJCGC : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNMAPBAGDGP APBBENFPNLL
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.APBBENFPNLL)
			{
				return null;
			}
			return (PNMAPBAGDGP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.APBBENFPNLL : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONPDAFNPDFE MBKDAFJCHAC
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.MBKDAFJCHAC)
			{
				return null;
			}
			return (ONPDAFNPDFE)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.MBKDAFJCHAC : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMIOBFIHNEC EIENKJFFFJG
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.EIENKJFFFJG)
			{
				return null;
			}
			return (CMIOBFIHNEC)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.EIENKJFFFJG : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNLKOLHEJDD NHHFADEBELO
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NHHFADEBELO)
			{
				return null;
			}
			return (CNLKOLHEJDD)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NHHFADEBELO : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPEFJJJIGHM FHCPKOMPCDH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FHCPKOMPCDH)
			{
				return null;
			}
			return (MPEFJJJIGHM)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FHCPKOMPCDH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNAMCJPNCNB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNAMCJPNCNB(PNAMCJPNCNB other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.MAECOFLEAGD:
			MAECOFLEAGD = other.MAECOFLEAGD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.HBMPBIOLCGD:
			HBMPBIOLCGD = other.HBMPBIOLCGD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.AJAIDIBLMAO:
			AJAIDIBLMAO = other.AJAIDIBLMAO.Clone();
			break;
		case NLPPPCHGGPFOneofCase.LLNNPGEOFCD:
			LLNNPGEOFCD = other.LLNNPGEOFCD.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JGNAJOFIKEJ:
			JGNAJOFIKEJ = other.JGNAJOFIKEJ.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NJMKOPKJCGC:
			NJMKOPKJCGC = other.NJMKOPKJCGC.Clone();
			break;
		case NLPPPCHGGPFOneofCase.APBBENFPNLL:
			APBBENFPNLL = other.APBBENFPNLL.Clone();
			break;
		case NLPPPCHGGPFOneofCase.MBKDAFJCHAC:
			MBKDAFJCHAC = other.MBKDAFJCHAC.Clone();
			break;
		case NLPPPCHGGPFOneofCase.EIENKJFFFJG:
			EIENKJFFFJG = other.EIENKJFFFJG.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NHHFADEBELO:
			NHHFADEBELO = other.NHHFADEBELO.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FHCPKOMPCDH:
			FHCPKOMPCDH = other.FHCPKOMPCDH.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNAMCJPNCNB Clone()
	{
		return new PNAMCJPNCNB(this);
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
		return Equals(other as PNAMCJPNCNB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNAMCJPNCNB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MAECOFLEAGD, other.MAECOFLEAGD))
		{
			return false;
		}
		if (!object.Equals(HBMPBIOLCGD, other.HBMPBIOLCGD))
		{
			return false;
		}
		if (!object.Equals(AJAIDIBLMAO, other.AJAIDIBLMAO))
		{
			return false;
		}
		if (!object.Equals(LLNNPGEOFCD, other.LLNNPGEOFCD))
		{
			return false;
		}
		if (!object.Equals(JGNAJOFIKEJ, other.JGNAJOFIKEJ))
		{
			return false;
		}
		if (!object.Equals(NJMKOPKJCGC, other.NJMKOPKJCGC))
		{
			return false;
		}
		if (!object.Equals(APBBENFPNLL, other.APBBENFPNLL))
		{
			return false;
		}
		if (!object.Equals(MBKDAFJCHAC, other.MBKDAFJCHAC))
		{
			return false;
		}
		if (!object.Equals(EIENKJFFFJG, other.EIENKJFFFJG))
		{
			return false;
		}
		if (!object.Equals(NHHFADEBELO, other.NHHFADEBELO))
		{
			return false;
		}
		if (!object.Equals(FHCPKOMPCDH, other.FHCPKOMPCDH))
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAECOFLEAGD)
		{
			num ^= MAECOFLEAGD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HBMPBIOLCGD)
		{
			num ^= HBMPBIOLCGD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AJAIDIBLMAO)
		{
			num ^= AJAIDIBLMAO.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LLNNPGEOFCD)
		{
			num ^= LLNNPGEOFCD.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JGNAJOFIKEJ)
		{
			num ^= JGNAJOFIKEJ.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NJMKOPKJCGC)
		{
			num ^= NJMKOPKJCGC.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.APBBENFPNLL)
		{
			num ^= APBBENFPNLL.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MBKDAFJCHAC)
		{
			num ^= MBKDAFJCHAC.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EIENKJFFFJG)
		{
			num ^= EIENKJFFFJG.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHHFADEBELO)
		{
			num ^= NHHFADEBELO.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHCPKOMPCDH)
		{
			num ^= FHCPKOMPCDH.GetHashCode();
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAECOFLEAGD)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MAECOFLEAGD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HBMPBIOLCGD)
		{
			output.WriteRawTag(26);
			output.WriteMessage(HBMPBIOLCGD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AJAIDIBLMAO)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AJAIDIBLMAO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LLNNPGEOFCD)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LLNNPGEOFCD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JGNAJOFIKEJ)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JGNAJOFIKEJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NJMKOPKJCGC)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NJMKOPKJCGC);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.APBBENFPNLL)
		{
			output.WriteRawTag(66);
			output.WriteMessage(APBBENFPNLL);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MBKDAFJCHAC)
		{
			output.WriteRawTag(82);
			output.WriteMessage(MBKDAFJCHAC);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EIENKJFFFJG)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EIENKJFFFJG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHHFADEBELO)
		{
			output.WriteRawTag(98);
			output.WriteMessage(NHHFADEBELO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHCPKOMPCDH)
		{
			output.WriteRawTag(122);
			output.WriteMessage(FHCPKOMPCDH);
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAECOFLEAGD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAECOFLEAGD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HBMPBIOLCGD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HBMPBIOLCGD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AJAIDIBLMAO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AJAIDIBLMAO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LLNNPGEOFCD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LLNNPGEOFCD);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JGNAJOFIKEJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JGNAJOFIKEJ);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NJMKOPKJCGC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NJMKOPKJCGC);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.APBBENFPNLL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(APBBENFPNLL);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MBKDAFJCHAC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBKDAFJCHAC);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EIENKJFFFJG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EIENKJFFFJG);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHHFADEBELO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NHHFADEBELO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHCPKOMPCDH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHCPKOMPCDH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNAMCJPNCNB other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.MAECOFLEAGD:
			if (MAECOFLEAGD == null)
			{
				MAECOFLEAGD = new AJHELAAIMBG();
			}
			MAECOFLEAGD.MergeFrom(other.MAECOFLEAGD);
			break;
		case NLPPPCHGGPFOneofCase.HBMPBIOLCGD:
			if (HBMPBIOLCGD == null)
			{
				HBMPBIOLCGD = new JADJCGAJNJO();
			}
			HBMPBIOLCGD.MergeFrom(other.HBMPBIOLCGD);
			break;
		case NLPPPCHGGPFOneofCase.AJAIDIBLMAO:
			if (AJAIDIBLMAO == null)
			{
				AJAIDIBLMAO = new JLNMEFLNPOA();
			}
			AJAIDIBLMAO.MergeFrom(other.AJAIDIBLMAO);
			break;
		case NLPPPCHGGPFOneofCase.LLNNPGEOFCD:
			if (LLNNPGEOFCD == null)
			{
				LLNNPGEOFCD = new OHONFMMAJEB();
			}
			LLNNPGEOFCD.MergeFrom(other.LLNNPGEOFCD);
			break;
		case NLPPPCHGGPFOneofCase.JGNAJOFIKEJ:
			if (JGNAJOFIKEJ == null)
			{
				JGNAJOFIKEJ = new FEHCHGIGBNC();
			}
			JGNAJOFIKEJ.MergeFrom(other.JGNAJOFIKEJ);
			break;
		case NLPPPCHGGPFOneofCase.NJMKOPKJCGC:
			if (NJMKOPKJCGC == null)
			{
				NJMKOPKJCGC = new LJPBAJGNLMI();
			}
			NJMKOPKJCGC.MergeFrom(other.NJMKOPKJCGC);
			break;
		case NLPPPCHGGPFOneofCase.APBBENFPNLL:
			if (APBBENFPNLL == null)
			{
				APBBENFPNLL = new PNMAPBAGDGP();
			}
			APBBENFPNLL.MergeFrom(other.APBBENFPNLL);
			break;
		case NLPPPCHGGPFOneofCase.MBKDAFJCHAC:
			if (MBKDAFJCHAC == null)
			{
				MBKDAFJCHAC = new ONPDAFNPDFE();
			}
			MBKDAFJCHAC.MergeFrom(other.MBKDAFJCHAC);
			break;
		case NLPPPCHGGPFOneofCase.EIENKJFFFJG:
			if (EIENKJFFFJG == null)
			{
				EIENKJFFFJG = new CMIOBFIHNEC();
			}
			EIENKJFFFJG.MergeFrom(other.EIENKJFFFJG);
			break;
		case NLPPPCHGGPFOneofCase.NHHFADEBELO:
			if (NHHFADEBELO == null)
			{
				NHHFADEBELO = new CNLKOLHEJDD();
			}
			NHHFADEBELO.MergeFrom(other.NHHFADEBELO);
			break;
		case NLPPPCHGGPFOneofCase.FHCPKOMPCDH:
			if (FHCPKOMPCDH == null)
			{
				FHCPKOMPCDH = new MPEFJJJIGHM();
			}
			FHCPKOMPCDH.MergeFrom(other.FHCPKOMPCDH);
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
				AJHELAAIMBG aJHELAAIMBG = new AJHELAAIMBG();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MAECOFLEAGD)
				{
					aJHELAAIMBG.MergeFrom(MAECOFLEAGD);
				}
				input.ReadMessage(aJHELAAIMBG);
				MAECOFLEAGD = aJHELAAIMBG;
				break;
			}
			case 26u:
			{
				JADJCGAJNJO jADJCGAJNJO = new JADJCGAJNJO();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.HBMPBIOLCGD)
				{
					jADJCGAJNJO.MergeFrom(HBMPBIOLCGD);
				}
				input.ReadMessage(jADJCGAJNJO);
				HBMPBIOLCGD = jADJCGAJNJO;
				break;
			}
			case 34u:
			{
				JLNMEFLNPOA jLNMEFLNPOA = new JLNMEFLNPOA();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AJAIDIBLMAO)
				{
					jLNMEFLNPOA.MergeFrom(AJAIDIBLMAO);
				}
				input.ReadMessage(jLNMEFLNPOA);
				AJAIDIBLMAO = jLNMEFLNPOA;
				break;
			}
			case 42u:
			{
				OHONFMMAJEB oHONFMMAJEB = new OHONFMMAJEB();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LLNNPGEOFCD)
				{
					oHONFMMAJEB.MergeFrom(LLNNPGEOFCD);
				}
				input.ReadMessage(oHONFMMAJEB);
				LLNNPGEOFCD = oHONFMMAJEB;
				break;
			}
			case 50u:
			{
				FEHCHGIGBNC fEHCHGIGBNC = new FEHCHGIGBNC();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JGNAJOFIKEJ)
				{
					fEHCHGIGBNC.MergeFrom(JGNAJOFIKEJ);
				}
				input.ReadMessage(fEHCHGIGBNC);
				JGNAJOFIKEJ = fEHCHGIGBNC;
				break;
			}
			case 58u:
			{
				LJPBAJGNLMI lJPBAJGNLMI = new LJPBAJGNLMI();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NJMKOPKJCGC)
				{
					lJPBAJGNLMI.MergeFrom(NJMKOPKJCGC);
				}
				input.ReadMessage(lJPBAJGNLMI);
				NJMKOPKJCGC = lJPBAJGNLMI;
				break;
			}
			case 66u:
			{
				PNMAPBAGDGP pNMAPBAGDGP = new PNMAPBAGDGP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.APBBENFPNLL)
				{
					pNMAPBAGDGP.MergeFrom(APBBENFPNLL);
				}
				input.ReadMessage(pNMAPBAGDGP);
				APBBENFPNLL = pNMAPBAGDGP;
				break;
			}
			case 82u:
			{
				ONPDAFNPDFE oNPDAFNPDFE = new ONPDAFNPDFE();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MBKDAFJCHAC)
				{
					oNPDAFNPDFE.MergeFrom(MBKDAFJCHAC);
				}
				input.ReadMessage(oNPDAFNPDFE);
				MBKDAFJCHAC = oNPDAFNPDFE;
				break;
			}
			case 90u:
			{
				CMIOBFIHNEC cMIOBFIHNEC = new CMIOBFIHNEC();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.EIENKJFFFJG)
				{
					cMIOBFIHNEC.MergeFrom(EIENKJFFFJG);
				}
				input.ReadMessage(cMIOBFIHNEC);
				EIENKJFFFJG = cMIOBFIHNEC;
				break;
			}
			case 98u:
			{
				CNLKOLHEJDD cNLKOLHEJDD = new CNLKOLHEJDD();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NHHFADEBELO)
				{
					cNLKOLHEJDD.MergeFrom(NHHFADEBELO);
				}
				input.ReadMessage(cNLKOLHEJDD);
				NHHFADEBELO = cNLKOLHEJDD;
				break;
			}
			case 122u:
			{
				MPEFJJJIGHM mPEFJJJIGHM = new MPEFJJJIGHM();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FHCPKOMPCDH)
				{
					mPEFJJJIGHM.MergeFrom(FHCPKOMPCDH);
				}
				input.ReadMessage(mPEFJJJIGHM);
				FHCPKOMPCDH = mPEFJJJIGHM;
				break;
			}
			}
		}
	}
}
