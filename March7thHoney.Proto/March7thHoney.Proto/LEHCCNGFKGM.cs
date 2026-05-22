using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LEHCCNGFKGM : IMessage<LEHCCNGFKGM>, IMessage, IEquatable<LEHCCNGFKGM>, IDeepCloneable<LEHCCNGFKGM>, IBufferMessage
{
	private static readonly MessageParser<LEHCCNGFKGM> _parser = new MessageParser<LEHCCNGFKGM>(() => new LEHCCNGFKGM());

	private UnknownFieldSet _unknownFields;

	public const int KDOINLGKMBIFieldNumber = 1;

	private uint kDOINLGKMBI_;

	public const int MKCHLGOGJNBFieldNumber = 2;

	private uint mKCHLGOGJNB_;

	public const int BHCFHEOIPNMFieldNumber = 3;

	private static readonly FieldCodec<CJGMECNIJIL> _repeated_bHCFHEOIPNM_codec = FieldCodec.ForMessage(26u, CJGMECNIJIL.Parser);

	private readonly RepeatedField<CJGMECNIJIL> bHCFHEOIPNM_ = new RepeatedField<CJGMECNIJIL>();

	public const int PJHHNBADOMHFieldNumber = 4;

	private static readonly FieldCodec<IMPEJAJCHPC> _repeated_pJHHNBADOMH_codec = FieldCodec.ForMessage(34u, IMPEJAJCHPC.Parser);

	private readonly RepeatedField<IMPEJAJCHPC> pJHHNBADOMH_ = new RepeatedField<IMPEJAJCHPC>();

	public const int GGELCKGFDCPFieldNumber = 5;

	private static readonly FieldCodec<LHPPIAKKFME> _repeated_gGELCKGFDCP_codec = FieldCodec.ForMessage(42u, LHPPIAKKFME.Parser);

	private readonly RepeatedField<LHPPIAKKFME> gGELCKGFDCP_ = new RepeatedField<LHPPIAKKFME>();

	public const int LNMBHILLHEHFieldNumber = 6;

	private static readonly FieldCodec<APDJGIIDJAA> _repeated_lNMBHILLHEH_codec = FieldCodec.ForMessage(50u, APDJGIIDJAA.Parser);

	private readonly RepeatedField<APDJGIIDJAA> lNMBHILLHEH_ = new RepeatedField<APDJGIIDJAA>();

	public const int JPDJMCCKENIFieldNumber = 8;

	private static readonly FieldCodec<KJFFJMAMJLD> _repeated_jPDJMCCKENI_codec = FieldCodec.ForMessage(66u, KJFFJMAMJLD.Parser);

	private readonly RepeatedField<KJFFJMAMJLD> jPDJMCCKENI_ = new RepeatedField<KJFFJMAMJLD>();

	public const int IDEAAPCCFPFFieldNumber = 9;

	private uint iDEAAPCCFPF_;

	public const int GNJMHIHJDJOFieldNumber = 10;

	private static readonly FieldCodec<PGJKONMBGOC> _repeated_gNJMHIHJDJO_codec = FieldCodec.ForMessage(82u, PGJKONMBGOC.Parser);

	private readonly RepeatedField<PGJKONMBGOC> gNJMHIHJDJO_ = new RepeatedField<PGJKONMBGOC>();

	public const int IGCPHODFFIJFieldNumber = 11;

	private double iGCPHODFFIJ_;

	public const int GMOBFEBBFIEFieldNumber = 12;

	private double gMOBFEBBFIE_;

	public const int NKBOEPHLCGLFieldNumber = 13;

	private double nKBOEPHLCGL_;

	public const int LJKBINKKBLHFieldNumber = 14;

	private uint lJKBINKKBLH_;

	public const int JIDMDNGPNJHFieldNumber = 15;

	private static readonly FieldCodec<JBJAKAMMKMD> _repeated_jIDMDNGPNJH_codec = FieldCodec.ForMessage(122u, JBJAKAMMKMD.Parser);

	private readonly RepeatedField<JBJAKAMMKMD> jIDMDNGPNJH_ = new RepeatedField<JBJAKAMMKMD>();

	public const int OGHGLMGJGEMFieldNumber = 16;

	private static readonly MapField<string, uint>.Codec _map_oGHGLMGJGEM_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 130u);

	private readonly MapField<string, uint> oGHGLMGJGEM_ = new MapField<string, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LEHCCNGFKGM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LEHCCNGFKGMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KDOINLGKMBI
	{
		get
		{
			return kDOINLGKMBI_;
		}
		set
		{
			kDOINLGKMBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKCHLGOGJNB
	{
		get
		{
			return mKCHLGOGJNB_;
		}
		set
		{
			mKCHLGOGJNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CJGMECNIJIL> BHCFHEOIPNM => bHCFHEOIPNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IMPEJAJCHPC> PJHHNBADOMH => pJHHNBADOMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHPPIAKKFME> GGELCKGFDCP => gGELCKGFDCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<APDJGIIDJAA> LNMBHILLHEH => lNMBHILLHEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KJFFJMAMJLD> JPDJMCCKENI => jPDJMCCKENI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IDEAAPCCFPF
	{
		get
		{
			return iDEAAPCCFPF_;
		}
		set
		{
			iDEAAPCCFPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PGJKONMBGOC> GNJMHIHJDJO => gNJMHIHJDJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double IGCPHODFFIJ
	{
		get
		{
			return iGCPHODFFIJ_;
		}
		set
		{
			iGCPHODFFIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double GMOBFEBBFIE
	{
		get
		{
			return gMOBFEBBFIE_;
		}
		set
		{
			gMOBFEBBFIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double NKBOEPHLCGL
	{
		get
		{
			return nKBOEPHLCGL_;
		}
		set
		{
			nKBOEPHLCGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJKBINKKBLH
	{
		get
		{
			return lJKBINKKBLH_;
		}
		set
		{
			lJKBINKKBLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JBJAKAMMKMD> JIDMDNGPNJH => jIDMDNGPNJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> OGHGLMGJGEM => oGHGLMGJGEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHCCNGFKGM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHCCNGFKGM(LEHCCNGFKGM other)
		: this()
	{
		kDOINLGKMBI_ = other.kDOINLGKMBI_;
		mKCHLGOGJNB_ = other.mKCHLGOGJNB_;
		bHCFHEOIPNM_ = other.bHCFHEOIPNM_.Clone();
		pJHHNBADOMH_ = other.pJHHNBADOMH_.Clone();
		gGELCKGFDCP_ = other.gGELCKGFDCP_.Clone();
		lNMBHILLHEH_ = other.lNMBHILLHEH_.Clone();
		jPDJMCCKENI_ = other.jPDJMCCKENI_.Clone();
		iDEAAPCCFPF_ = other.iDEAAPCCFPF_;
		gNJMHIHJDJO_ = other.gNJMHIHJDJO_.Clone();
		iGCPHODFFIJ_ = other.iGCPHODFFIJ_;
		gMOBFEBBFIE_ = other.gMOBFEBBFIE_;
		nKBOEPHLCGL_ = other.nKBOEPHLCGL_;
		lJKBINKKBLH_ = other.lJKBINKKBLH_;
		jIDMDNGPNJH_ = other.jIDMDNGPNJH_.Clone();
		oGHGLMGJGEM_ = other.oGHGLMGJGEM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHCCNGFKGM Clone()
	{
		return new LEHCCNGFKGM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LEHCCNGFKGM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LEHCCNGFKGM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KDOINLGKMBI != other.KDOINLGKMBI)
		{
			return false;
		}
		if (MKCHLGOGJNB != other.MKCHLGOGJNB)
		{
			return false;
		}
		if (!bHCFHEOIPNM_.Equals(other.bHCFHEOIPNM_))
		{
			return false;
		}
		if (!pJHHNBADOMH_.Equals(other.pJHHNBADOMH_))
		{
			return false;
		}
		if (!gGELCKGFDCP_.Equals(other.gGELCKGFDCP_))
		{
			return false;
		}
		if (!lNMBHILLHEH_.Equals(other.lNMBHILLHEH_))
		{
			return false;
		}
		if (!jPDJMCCKENI_.Equals(other.jPDJMCCKENI_))
		{
			return false;
		}
		if (IDEAAPCCFPF != other.IDEAAPCCFPF)
		{
			return false;
		}
		if (!gNJMHIHJDJO_.Equals(other.gNJMHIHJDJO_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(IGCPHODFFIJ, other.IGCPHODFFIJ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GMOBFEBBFIE, other.GMOBFEBBFIE))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NKBOEPHLCGL, other.NKBOEPHLCGL))
		{
			return false;
		}
		if (LJKBINKKBLH != other.LJKBINKKBLH)
		{
			return false;
		}
		if (!jIDMDNGPNJH_.Equals(other.jIDMDNGPNJH_))
		{
			return false;
		}
		if (!OGHGLMGJGEM.Equals(other.OGHGLMGJGEM))
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
		if (KDOINLGKMBI != 0)
		{
			num ^= KDOINLGKMBI.GetHashCode();
		}
		if (MKCHLGOGJNB != 0)
		{
			num ^= MKCHLGOGJNB.GetHashCode();
		}
		num ^= bHCFHEOIPNM_.GetHashCode();
		num ^= pJHHNBADOMH_.GetHashCode();
		num ^= gGELCKGFDCP_.GetHashCode();
		num ^= lNMBHILLHEH_.GetHashCode();
		num ^= jPDJMCCKENI_.GetHashCode();
		if (IDEAAPCCFPF != 0)
		{
			num ^= IDEAAPCCFPF.GetHashCode();
		}
		num ^= gNJMHIHJDJO_.GetHashCode();
		if (IGCPHODFFIJ != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(IGCPHODFFIJ);
		}
		if (GMOBFEBBFIE != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GMOBFEBBFIE);
		}
		if (NKBOEPHLCGL != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NKBOEPHLCGL);
		}
		if (LJKBINKKBLH != 0)
		{
			num ^= LJKBINKKBLH.GetHashCode();
		}
		num ^= jIDMDNGPNJH_.GetHashCode();
		num ^= OGHGLMGJGEM.GetHashCode();
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
		if (KDOINLGKMBI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KDOINLGKMBI);
		}
		if (MKCHLGOGJNB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MKCHLGOGJNB);
		}
		bHCFHEOIPNM_.WriteTo(ref output, _repeated_bHCFHEOIPNM_codec);
		pJHHNBADOMH_.WriteTo(ref output, _repeated_pJHHNBADOMH_codec);
		gGELCKGFDCP_.WriteTo(ref output, _repeated_gGELCKGFDCP_codec);
		lNMBHILLHEH_.WriteTo(ref output, _repeated_lNMBHILLHEH_codec);
		jPDJMCCKENI_.WriteTo(ref output, _repeated_jPDJMCCKENI_codec);
		if (IDEAAPCCFPF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(IDEAAPCCFPF);
		}
		gNJMHIHJDJO_.WriteTo(ref output, _repeated_gNJMHIHJDJO_codec);
		if (IGCPHODFFIJ != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(IGCPHODFFIJ);
		}
		if (GMOBFEBBFIE != 0.0)
		{
			output.WriteRawTag(97);
			output.WriteDouble(GMOBFEBBFIE);
		}
		if (NKBOEPHLCGL != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(NKBOEPHLCGL);
		}
		if (LJKBINKKBLH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LJKBINKKBLH);
		}
		jIDMDNGPNJH_.WriteTo(ref output, _repeated_jIDMDNGPNJH_codec);
		oGHGLMGJGEM_.WriteTo(ref output, _map_oGHGLMGJGEM_codec);
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
		if (KDOINLGKMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KDOINLGKMBI);
		}
		if (MKCHLGOGJNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKCHLGOGJNB);
		}
		num += bHCFHEOIPNM_.CalculateSize(_repeated_bHCFHEOIPNM_codec);
		num += pJHHNBADOMH_.CalculateSize(_repeated_pJHHNBADOMH_codec);
		num += gGELCKGFDCP_.CalculateSize(_repeated_gGELCKGFDCP_codec);
		num += lNMBHILLHEH_.CalculateSize(_repeated_lNMBHILLHEH_codec);
		num += jPDJMCCKENI_.CalculateSize(_repeated_jPDJMCCKENI_codec);
		if (IDEAAPCCFPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IDEAAPCCFPF);
		}
		num += gNJMHIHJDJO_.CalculateSize(_repeated_gNJMHIHJDJO_codec);
		if (IGCPHODFFIJ != 0.0)
		{
			num += 9;
		}
		if (GMOBFEBBFIE != 0.0)
		{
			num += 9;
		}
		if (NKBOEPHLCGL != 0.0)
		{
			num += 9;
		}
		if (LJKBINKKBLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJKBINKKBLH);
		}
		num += jIDMDNGPNJH_.CalculateSize(_repeated_jIDMDNGPNJH_codec);
		num += oGHGLMGJGEM_.CalculateSize(_map_oGHGLMGJGEM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LEHCCNGFKGM other)
	{
		if (other != null)
		{
			if (other.KDOINLGKMBI != 0)
			{
				KDOINLGKMBI = other.KDOINLGKMBI;
			}
			if (other.MKCHLGOGJNB != 0)
			{
				MKCHLGOGJNB = other.MKCHLGOGJNB;
			}
			bHCFHEOIPNM_.Add(other.bHCFHEOIPNM_);
			pJHHNBADOMH_.Add(other.pJHHNBADOMH_);
			gGELCKGFDCP_.Add(other.gGELCKGFDCP_);
			lNMBHILLHEH_.Add(other.lNMBHILLHEH_);
			jPDJMCCKENI_.Add(other.jPDJMCCKENI_);
			if (other.IDEAAPCCFPF != 0)
			{
				IDEAAPCCFPF = other.IDEAAPCCFPF;
			}
			gNJMHIHJDJO_.Add(other.gNJMHIHJDJO_);
			if (other.IGCPHODFFIJ != 0.0)
			{
				IGCPHODFFIJ = other.IGCPHODFFIJ;
			}
			if (other.GMOBFEBBFIE != 0.0)
			{
				GMOBFEBBFIE = other.GMOBFEBBFIE;
			}
			if (other.NKBOEPHLCGL != 0.0)
			{
				NKBOEPHLCGL = other.NKBOEPHLCGL;
			}
			if (other.LJKBINKKBLH != 0)
			{
				LJKBINKKBLH = other.LJKBINKKBLH;
			}
			jIDMDNGPNJH_.Add(other.jIDMDNGPNJH_);
			oGHGLMGJGEM_.MergeFrom(other.oGHGLMGJGEM_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				KDOINLGKMBI = input.ReadUInt32();
				break;
			case 16u:
				MKCHLGOGJNB = input.ReadUInt32();
				break;
			case 26u:
				bHCFHEOIPNM_.AddEntriesFrom(ref input, _repeated_bHCFHEOIPNM_codec);
				break;
			case 34u:
				pJHHNBADOMH_.AddEntriesFrom(ref input, _repeated_pJHHNBADOMH_codec);
				break;
			case 42u:
				gGELCKGFDCP_.AddEntriesFrom(ref input, _repeated_gGELCKGFDCP_codec);
				break;
			case 50u:
				lNMBHILLHEH_.AddEntriesFrom(ref input, _repeated_lNMBHILLHEH_codec);
				break;
			case 66u:
				jPDJMCCKENI_.AddEntriesFrom(ref input, _repeated_jPDJMCCKENI_codec);
				break;
			case 72u:
				IDEAAPCCFPF = input.ReadUInt32();
				break;
			case 82u:
				gNJMHIHJDJO_.AddEntriesFrom(ref input, _repeated_gNJMHIHJDJO_codec);
				break;
			case 89u:
				IGCPHODFFIJ = input.ReadDouble();
				break;
			case 97u:
				GMOBFEBBFIE = input.ReadDouble();
				break;
			case 105u:
				NKBOEPHLCGL = input.ReadDouble();
				break;
			case 112u:
				LJKBINKKBLH = input.ReadUInt32();
				break;
			case 122u:
				jIDMDNGPNJH_.AddEntriesFrom(ref input, _repeated_jIDMDNGPNJH_codec);
				break;
			case 130u:
				oGHGLMGJGEM_.AddEntriesFrom(ref input, _map_oGHGLMGJGEM_codec);
				break;
			}
		}
	}
}
