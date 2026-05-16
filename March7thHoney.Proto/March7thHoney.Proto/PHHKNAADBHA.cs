using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHHKNAADBHA : IMessage<PHHKNAADBHA>, IMessage, IEquatable<PHHKNAADBHA>, IDeepCloneable<PHHKNAADBHA>, IBufferMessage
{
	private static readonly MessageParser<PHHKNAADBHA> _parser = new MessageParser<PHHKNAADBHA>(() => new PHHKNAADBHA());

	private UnknownFieldSet _unknownFields;

	public const int HHHNONKPFGPFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_hHHNONKPFGP_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> hHHNONKPFGP_ = new RepeatedField<uint>();

	public const int PKCOBJBILEOFieldNumber = 2;

	private uint pKCOBJBILEO_;

	public const int SectionIdFieldNumber = 4;

	private uint sectionId_;

	public const int DJCILMADPKCFieldNumber = 5;

	private static readonly MapField<uint, uint>.Codec _map_dJCILMADPKC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 42u);

	private readonly MapField<uint, uint> dJCILMADPKC_ = new MapField<uint, uint>();

	public const int DEMDFDBCOAJFieldNumber = 6;

	private static readonly FieldCodec<DPOGOCFMOFP> _repeated_dEMDFDBCOAJ_codec = FieldCodec.ForMessage(50u, DPOGOCFMOFP.Parser);

	private readonly RepeatedField<DPOGOCFMOFP> dEMDFDBCOAJ_ = new RepeatedField<DPOGOCFMOFP>();

	public const int NLBOGKNFNNEFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_nLBOGKNFNNE_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> nLBOGKNFNNE_ = new RepeatedField<uint>();

	public const int LFMEPGNEHHFFieldNumber = 9;

	private uint lFMEPGNEHHF_;

	public const int MHAAMIGLIKIFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_mHAAMIGLIKI_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> mHAAMIGLIKI_ = new RepeatedField<uint>();

	public const int CIFOJDJAIADFieldNumber = 13;

	private static readonly FieldCodec<IHOGHILAEJE> _repeated_cIFOJDJAIAD_codec = FieldCodec.ForMessage(106u, IHOGHILAEJE.Parser);

	private readonly RepeatedField<IHOGHILAEJE> cIFOJDJAIAD_ = new RepeatedField<IHOGHILAEJE>();

	public const int PGKHBPKIFBEFieldNumber = 14;

	private ulong pGKHBPKIFBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHHKNAADBHA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHHKNAADBHAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HHHNONKPFGP => hHHNONKPFGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKCOBJBILEO
	{
		get
		{
			return pKCOBJBILEO_;
		}
		set
		{
			pKCOBJBILEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> DJCILMADPKC => dJCILMADPKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPOGOCFMOFP> DEMDFDBCOAJ => dEMDFDBCOAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NLBOGKNFNNE => nLBOGKNFNNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFMEPGNEHHF
	{
		get
		{
			return lFMEPGNEHHF_;
		}
		set
		{
			lFMEPGNEHHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MHAAMIGLIKI => mHAAMIGLIKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IHOGHILAEJE> CIFOJDJAIAD => cIFOJDJAIAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PGKHBPKIFBE
	{
		get
		{
			return pGKHBPKIFBE_;
		}
		set
		{
			pGKHBPKIFBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHHKNAADBHA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHHKNAADBHA(PHHKNAADBHA other)
		: this()
	{
		hHHNONKPFGP_ = other.hHHNONKPFGP_.Clone();
		pKCOBJBILEO_ = other.pKCOBJBILEO_;
		sectionId_ = other.sectionId_;
		dJCILMADPKC_ = other.dJCILMADPKC_.Clone();
		dEMDFDBCOAJ_ = other.dEMDFDBCOAJ_.Clone();
		nLBOGKNFNNE_ = other.nLBOGKNFNNE_.Clone();
		lFMEPGNEHHF_ = other.lFMEPGNEHHF_;
		mHAAMIGLIKI_ = other.mHAAMIGLIKI_.Clone();
		cIFOJDJAIAD_ = other.cIFOJDJAIAD_.Clone();
		pGKHBPKIFBE_ = other.pGKHBPKIFBE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHHKNAADBHA Clone()
	{
		return new PHHKNAADBHA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHHKNAADBHA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHHKNAADBHA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hHHNONKPFGP_.Equals(other.hHHNONKPFGP_))
		{
			return false;
		}
		if (PKCOBJBILEO != other.PKCOBJBILEO)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (!DJCILMADPKC.Equals(other.DJCILMADPKC))
		{
			return false;
		}
		if (!dEMDFDBCOAJ_.Equals(other.dEMDFDBCOAJ_))
		{
			return false;
		}
		if (!nLBOGKNFNNE_.Equals(other.nLBOGKNFNNE_))
		{
			return false;
		}
		if (LFMEPGNEHHF != other.LFMEPGNEHHF)
		{
			return false;
		}
		if (!mHAAMIGLIKI_.Equals(other.mHAAMIGLIKI_))
		{
			return false;
		}
		if (!cIFOJDJAIAD_.Equals(other.cIFOJDJAIAD_))
		{
			return false;
		}
		if (PGKHBPKIFBE != other.PGKHBPKIFBE)
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
		num ^= hHHNONKPFGP_.GetHashCode();
		if (PKCOBJBILEO != 0)
		{
			num ^= PKCOBJBILEO.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		num ^= DJCILMADPKC.GetHashCode();
		num ^= dEMDFDBCOAJ_.GetHashCode();
		num ^= nLBOGKNFNNE_.GetHashCode();
		if (LFMEPGNEHHF != 0)
		{
			num ^= LFMEPGNEHHF.GetHashCode();
		}
		num ^= mHAAMIGLIKI_.GetHashCode();
		num ^= cIFOJDJAIAD_.GetHashCode();
		if (PGKHBPKIFBE != 0L)
		{
			num ^= PGKHBPKIFBE.GetHashCode();
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
		hHHNONKPFGP_.WriteTo(ref output, _repeated_hHHNONKPFGP_codec);
		if (PKCOBJBILEO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PKCOBJBILEO);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(SectionId);
		}
		dJCILMADPKC_.WriteTo(ref output, _map_dJCILMADPKC_codec);
		dEMDFDBCOAJ_.WriteTo(ref output, _repeated_dEMDFDBCOAJ_codec);
		nLBOGKNFNNE_.WriteTo(ref output, _repeated_nLBOGKNFNNE_codec);
		if (LFMEPGNEHHF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LFMEPGNEHHF);
		}
		mHAAMIGLIKI_.WriteTo(ref output, _repeated_mHAAMIGLIKI_codec);
		cIFOJDJAIAD_.WriteTo(ref output, _repeated_cIFOJDJAIAD_codec);
		if (PGKHBPKIFBE != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(PGKHBPKIFBE);
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
		num += hHHNONKPFGP_.CalculateSize(_repeated_hHHNONKPFGP_codec);
		if (PKCOBJBILEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKCOBJBILEO);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		num += dJCILMADPKC_.CalculateSize(_map_dJCILMADPKC_codec);
		num += dEMDFDBCOAJ_.CalculateSize(_repeated_dEMDFDBCOAJ_codec);
		num += nLBOGKNFNNE_.CalculateSize(_repeated_nLBOGKNFNNE_codec);
		if (LFMEPGNEHHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFMEPGNEHHF);
		}
		num += mHAAMIGLIKI_.CalculateSize(_repeated_mHAAMIGLIKI_codec);
		num += cIFOJDJAIAD_.CalculateSize(_repeated_cIFOJDJAIAD_codec);
		if (PGKHBPKIFBE != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PGKHBPKIFBE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHHKNAADBHA other)
	{
		if (other != null)
		{
			hHHNONKPFGP_.Add(other.hHHNONKPFGP_);
			if (other.PKCOBJBILEO != 0)
			{
				PKCOBJBILEO = other.PKCOBJBILEO;
			}
			if (other.SectionId != 0)
			{
				SectionId = other.SectionId;
			}
			dJCILMADPKC_.MergeFrom(other.dJCILMADPKC_);
			dEMDFDBCOAJ_.Add(other.dEMDFDBCOAJ_);
			nLBOGKNFNNE_.Add(other.nLBOGKNFNNE_);
			if (other.LFMEPGNEHHF != 0)
			{
				LFMEPGNEHHF = other.LFMEPGNEHHF;
			}
			mHAAMIGLIKI_.Add(other.mHAAMIGLIKI_);
			cIFOJDJAIAD_.Add(other.cIFOJDJAIAD_);
			if (other.PGKHBPKIFBE != 0L)
			{
				PGKHBPKIFBE = other.PGKHBPKIFBE;
			}
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
			case 10u:
				hHHNONKPFGP_.AddEntriesFrom(ref input, _repeated_hHHNONKPFGP_codec);
				break;
			case 16u:
				PKCOBJBILEO = input.ReadUInt32();
				break;
			case 32u:
				SectionId = input.ReadUInt32();
				break;
			case 42u:
				dJCILMADPKC_.AddEntriesFrom(ref input, _map_dJCILMADPKC_codec);
				break;
			case 50u:
				dEMDFDBCOAJ_.AddEntriesFrom(ref input, _repeated_dEMDFDBCOAJ_codec);
				break;
			case 64u:
			case 66u:
				nLBOGKNFNNE_.AddEntriesFrom(ref input, _repeated_nLBOGKNFNNE_codec);
				break;
			case 72u:
				LFMEPGNEHHF = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				mHAAMIGLIKI_.AddEntriesFrom(ref input, _repeated_mHAAMIGLIKI_codec);
				break;
			case 106u:
				cIFOJDJAIAD_.AddEntriesFrom(ref input, _repeated_cIFOJDJAIAD_codec);
				break;
			case 112u:
				PGKHBPKIFBE = input.ReadUInt64();
				break;
			}
		}
	}
}
