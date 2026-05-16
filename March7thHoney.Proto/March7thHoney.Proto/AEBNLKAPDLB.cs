using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AEBNLKAPDLB : IMessage<AEBNLKAPDLB>, IMessage, IEquatable<AEBNLKAPDLB>, IDeepCloneable<AEBNLKAPDLB>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		MOKBKLPIMOA = 3,
		LNBILCHBHAD = 4,
		JIPBJJOGHDE = 5,
		PPBKEPIAKEF = 6,
		JGLKNEOCJCH = 7,
		ADPHCOJGLGN = 8,
		JNMBJHJPBOK = 9,
		GBEOBOPHKLH = 10,
		AMAGLNLFFEP = 12,
		ALIICNJOIBM = 13,
		FGGCGENJOAH = 15
	}

	private static readonly MessageParser<AEBNLKAPDLB> _parser = new MessageParser<AEBNLKAPDLB>(() => new AEBNLKAPDLB());

	private UnknownFieldSet _unknownFields;

	public const int MOKBKLPIMOAFieldNumber = 3;

	public const int LNBILCHBHADFieldNumber = 4;

	public const int JIPBJJOGHDEFieldNumber = 5;

	public const int PPBKEPIAKEFFieldNumber = 6;

	public const int JGLKNEOCJCHFieldNumber = 7;

	public const int ADPHCOJGLGNFieldNumber = 8;

	public const int JNMBJHJPBOKFieldNumber = 9;

	public const int GBEOBOPHKLHFieldNumber = 10;

	public const int AMAGLNLFFEPFieldNumber = 12;

	public const int ALIICNJOIBMFieldNumber = 13;

	public const int FGGCGENJOAHFieldNumber = 15;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AEBNLKAPDLB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AEBNLKAPDLBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOKBKLPIMOA
	{
		get
		{
			if (!HasMOKBKLPIMOA)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.MOKBKLPIMOA;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMOKBKLPIMOA => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.MOKBKLPIMOA;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNBILCHBHAD
	{
		get
		{
			if (!HasLNBILCHBHAD)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.LNBILCHBHAD;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLNBILCHBHAD => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.LNBILCHBHAD;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JIPBJJOGHDE
	{
		get
		{
			if (!HasJIPBJJOGHDE)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.JIPBJJOGHDE;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJIPBJJOGHDE => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JIPBJJOGHDE;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLAJNANGALB PPBKEPIAKEF
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PPBKEPIAKEF)
			{
				return null;
			}
			return (MLAJNANGALB)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PPBKEPIAKEF : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGLKNEOCJCH
	{
		get
		{
			if (!HasJGLKNEOCJCH)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.JGLKNEOCJCH;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJGLKNEOCJCH => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JGLKNEOCJCH;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNLNBGNFDF ADPHCOJGLGN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.ADPHCOJGLGN)
			{
				return null;
			}
			return (PKNLNBGNFDF)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.ADPHCOJGLGN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNMBJHJPBOK
	{
		get
		{
			if (!HasJNMBJHJPBOK)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.JNMBJHJPBOK;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJNMBJHJPBOK => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.JNMBJHJPBOK;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBEOBOPHKLH
	{
		get
		{
			if (!HasGBEOBOPHKLH)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.GBEOBOPHKLH;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGBEOBOPHKLH => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.GBEOBOPHKLH;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPHMMPDFMAK AMAGLNLFFEP
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.AMAGLNLFFEP)
			{
				return null;
			}
			return (HPHMMPDFMAK)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.AMAGLNLFFEP : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLBJNHJILFP ALIICNJOIBM
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.ALIICNJOIBM)
			{
				return null;
			}
			return (JLBJNHJILFP)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.ALIICNJOIBM : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNCBIMAAFJG FGGCGENJOAH
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.FGGCGENJOAH)
			{
				return null;
			}
			return (KNCBIMAAFJG)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.FGGCGENJOAH : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEBNLKAPDLB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEBNLKAPDLB(AEBNLKAPDLB other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.MOKBKLPIMOA:
			MOKBKLPIMOA = other.MOKBKLPIMOA;
			break;
		case NLPPPCHGGPFOneofCase.LNBILCHBHAD:
			LNBILCHBHAD = other.LNBILCHBHAD;
			break;
		case NLPPPCHGGPFOneofCase.JIPBJJOGHDE:
			JIPBJJOGHDE = other.JIPBJJOGHDE;
			break;
		case NLPPPCHGGPFOneofCase.PPBKEPIAKEF:
			PPBKEPIAKEF = other.PPBKEPIAKEF.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JGLKNEOCJCH:
			JGLKNEOCJCH = other.JGLKNEOCJCH;
			break;
		case NLPPPCHGGPFOneofCase.ADPHCOJGLGN:
			ADPHCOJGLGN = other.ADPHCOJGLGN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.JNMBJHJPBOK:
			JNMBJHJPBOK = other.JNMBJHJPBOK;
			break;
		case NLPPPCHGGPFOneofCase.GBEOBOPHKLH:
			GBEOBOPHKLH = other.GBEOBOPHKLH;
			break;
		case NLPPPCHGGPFOneofCase.AMAGLNLFFEP:
			AMAGLNLFFEP = other.AMAGLNLFFEP.Clone();
			break;
		case NLPPPCHGGPFOneofCase.ALIICNJOIBM:
			ALIICNJOIBM = other.ALIICNJOIBM.Clone();
			break;
		case NLPPPCHGGPFOneofCase.FGGCGENJOAH:
			FGGCGENJOAH = other.FGGCGENJOAH.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEBNLKAPDLB Clone()
	{
		return new AEBNLKAPDLB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMOKBKLPIMOA()
	{
		if (HasMOKBKLPIMOA)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLNBILCHBHAD()
	{
		if (HasLNBILCHBHAD)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJIPBJJOGHDE()
	{
		if (HasJIPBJJOGHDE)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJGLKNEOCJCH()
	{
		if (HasJGLKNEOCJCH)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJNMBJHJPBOK()
	{
		if (HasJNMBJHJPBOK)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGBEOBOPHKLH()
	{
		if (HasGBEOBOPHKLH)
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
		return Equals(other as AEBNLKAPDLB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AEBNLKAPDLB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOKBKLPIMOA != other.MOKBKLPIMOA)
		{
			return false;
		}
		if (LNBILCHBHAD != other.LNBILCHBHAD)
		{
			return false;
		}
		if (JIPBJJOGHDE != other.JIPBJJOGHDE)
		{
			return false;
		}
		if (!object.Equals(PPBKEPIAKEF, other.PPBKEPIAKEF))
		{
			return false;
		}
		if (JGLKNEOCJCH != other.JGLKNEOCJCH)
		{
			return false;
		}
		if (!object.Equals(ADPHCOJGLGN, other.ADPHCOJGLGN))
		{
			return false;
		}
		if (JNMBJHJPBOK != other.JNMBJHJPBOK)
		{
			return false;
		}
		if (GBEOBOPHKLH != other.GBEOBOPHKLH)
		{
			return false;
		}
		if (!object.Equals(AMAGLNLFFEP, other.AMAGLNLFFEP))
		{
			return false;
		}
		if (!object.Equals(ALIICNJOIBM, other.ALIICNJOIBM))
		{
			return false;
		}
		if (!object.Equals(FGGCGENJOAH, other.FGGCGENJOAH))
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
		if (HasMOKBKLPIMOA)
		{
			num ^= MOKBKLPIMOA.GetHashCode();
		}
		if (HasLNBILCHBHAD)
		{
			num ^= LNBILCHBHAD.GetHashCode();
		}
		if (HasJIPBJJOGHDE)
		{
			num ^= JIPBJJOGHDE.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPBKEPIAKEF)
		{
			num ^= PPBKEPIAKEF.GetHashCode();
		}
		if (HasJGLKNEOCJCH)
		{
			num ^= JGLKNEOCJCH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADPHCOJGLGN)
		{
			num ^= ADPHCOJGLGN.GetHashCode();
		}
		if (HasJNMBJHJPBOK)
		{
			num ^= JNMBJHJPBOK.GetHashCode();
		}
		if (HasGBEOBOPHKLH)
		{
			num ^= GBEOBOPHKLH.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AMAGLNLFFEP)
		{
			num ^= AMAGLNLFFEP.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ALIICNJOIBM)
		{
			num ^= ALIICNJOIBM.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FGGCGENJOAH)
		{
			num ^= FGGCGENJOAH.GetHashCode();
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
		if (HasMOKBKLPIMOA)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MOKBKLPIMOA);
		}
		if (HasLNBILCHBHAD)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LNBILCHBHAD);
		}
		if (HasJIPBJJOGHDE)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JIPBJJOGHDE);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPBKEPIAKEF)
		{
			output.WriteRawTag(50);
			output.WriteMessage(PPBKEPIAKEF);
		}
		if (HasJGLKNEOCJCH)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JGLKNEOCJCH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADPHCOJGLGN)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ADPHCOJGLGN);
		}
		if (HasJNMBJHJPBOK)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(JNMBJHJPBOK);
		}
		if (HasGBEOBOPHKLH)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GBEOBOPHKLH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AMAGLNLFFEP)
		{
			output.WriteRawTag(98);
			output.WriteMessage(AMAGLNLFFEP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ALIICNJOIBM)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ALIICNJOIBM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FGGCGENJOAH)
		{
			output.WriteRawTag(122);
			output.WriteMessage(FGGCGENJOAH);
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
		if (HasMOKBKLPIMOA)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOKBKLPIMOA);
		}
		if (HasLNBILCHBHAD)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNBILCHBHAD);
		}
		if (HasJIPBJJOGHDE)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JIPBJJOGHDE);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPBKEPIAKEF)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPBKEPIAKEF);
		}
		if (HasJGLKNEOCJCH)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGLKNEOCJCH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADPHCOJGLGN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ADPHCOJGLGN);
		}
		if (HasJNMBJHJPBOK)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNMBJHJPBOK);
		}
		if (HasGBEOBOPHKLH)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBEOBOPHKLH);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AMAGLNLFFEP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMAGLNLFFEP);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ALIICNJOIBM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ALIICNJOIBM);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FGGCGENJOAH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FGGCGENJOAH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AEBNLKAPDLB other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.MOKBKLPIMOA:
			MOKBKLPIMOA = other.MOKBKLPIMOA;
			break;
		case NLPPPCHGGPFOneofCase.LNBILCHBHAD:
			LNBILCHBHAD = other.LNBILCHBHAD;
			break;
		case NLPPPCHGGPFOneofCase.JIPBJJOGHDE:
			JIPBJJOGHDE = other.JIPBJJOGHDE;
			break;
		case NLPPPCHGGPFOneofCase.PPBKEPIAKEF:
			if (PPBKEPIAKEF == null)
			{
				PPBKEPIAKEF = new MLAJNANGALB();
			}
			PPBKEPIAKEF.MergeFrom(other.PPBKEPIAKEF);
			break;
		case NLPPPCHGGPFOneofCase.JGLKNEOCJCH:
			JGLKNEOCJCH = other.JGLKNEOCJCH;
			break;
		case NLPPPCHGGPFOneofCase.ADPHCOJGLGN:
			if (ADPHCOJGLGN == null)
			{
				ADPHCOJGLGN = new PKNLNBGNFDF();
			}
			ADPHCOJGLGN.MergeFrom(other.ADPHCOJGLGN);
			break;
		case NLPPPCHGGPFOneofCase.JNMBJHJPBOK:
			JNMBJHJPBOK = other.JNMBJHJPBOK;
			break;
		case NLPPPCHGGPFOneofCase.GBEOBOPHKLH:
			GBEOBOPHKLH = other.GBEOBOPHKLH;
			break;
		case NLPPPCHGGPFOneofCase.AMAGLNLFFEP:
			if (AMAGLNLFFEP == null)
			{
				AMAGLNLFFEP = new HPHMMPDFMAK();
			}
			AMAGLNLFFEP.MergeFrom(other.AMAGLNLFFEP);
			break;
		case NLPPPCHGGPFOneofCase.ALIICNJOIBM:
			if (ALIICNJOIBM == null)
			{
				ALIICNJOIBM = new JLBJNHJILFP();
			}
			ALIICNJOIBM.MergeFrom(other.ALIICNJOIBM);
			break;
		case NLPPPCHGGPFOneofCase.FGGCGENJOAH:
			if (FGGCGENJOAH == null)
			{
				FGGCGENJOAH = new KNCBIMAAFJG();
			}
			FGGCGENJOAH.MergeFrom(other.FGGCGENJOAH);
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
			case 24u:
				MOKBKLPIMOA = input.ReadUInt32();
				break;
			case 32u:
				LNBILCHBHAD = input.ReadUInt32();
				break;
			case 40u:
				JIPBJJOGHDE = input.ReadUInt32();
				break;
			case 50u:
			{
				MLAJNANGALB mLAJNANGALB = new MLAJNANGALB();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPBKEPIAKEF)
				{
					mLAJNANGALB.MergeFrom(PPBKEPIAKEF);
				}
				input.ReadMessage(mLAJNANGALB);
				PPBKEPIAKEF = mLAJNANGALB;
				break;
			}
			case 56u:
				JGLKNEOCJCH = input.ReadUInt32();
				break;
			case 66u:
			{
				PKNLNBGNFDF pKNLNBGNFDF = new PKNLNBGNFDF();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ADPHCOJGLGN)
				{
					pKNLNBGNFDF.MergeFrom(ADPHCOJGLGN);
				}
				input.ReadMessage(pKNLNBGNFDF);
				ADPHCOJGLGN = pKNLNBGNFDF;
				break;
			}
			case 72u:
				JNMBJHJPBOK = input.ReadUInt32();
				break;
			case 80u:
				GBEOBOPHKLH = input.ReadUInt32();
				break;
			case 98u:
			{
				HPHMMPDFMAK hPHMMPDFMAK = new HPHMMPDFMAK();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.AMAGLNLFFEP)
				{
					hPHMMPDFMAK.MergeFrom(AMAGLNLFFEP);
				}
				input.ReadMessage(hPHMMPDFMAK);
				AMAGLNLFFEP = hPHMMPDFMAK;
				break;
			}
			case 106u:
			{
				JLBJNHJILFP jLBJNHJILFP = new JLBJNHJILFP();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.ALIICNJOIBM)
				{
					jLBJNHJILFP.MergeFrom(ALIICNJOIBM);
				}
				input.ReadMessage(jLBJNHJILFP);
				ALIICNJOIBM = jLBJNHJILFP;
				break;
			}
			case 122u:
			{
				KNCBIMAAFJG kNCBIMAAFJG = new KNCBIMAAFJG();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FGGCGENJOAH)
				{
					kNCBIMAAFJG.MergeFrom(FGGCGENJOAH);
				}
				input.ReadMessage(kNCBIMAAFJG);
				FGGCGENJOAH = kNCBIMAAFJG;
				break;
			}
			}
		}
	}
}
