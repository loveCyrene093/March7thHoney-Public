using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PEHOCGJJMNF : IMessage<PEHOCGJJMNF>, IMessage, IEquatable<PEHOCGJJMNF>, IDeepCloneable<PEHOCGJJMNF>, IBufferMessage
{
	private static readonly MessageParser<PEHOCGJJMNF> _parser = new MessageParser<PEHOCGJJMNF>(() => new PEHOCGJJMNF());

	private UnknownFieldSet _unknownFields;

	public const int CGOMCPEBBIAFieldNumber = 1;

	private static readonly FieldCodec<FBBMDFDOEEF> _repeated_cGOMCPEBBIA_codec = FieldCodec.ForMessage(10u, FBBMDFDOEEF.Parser);

	private readonly RepeatedField<FBBMDFDOEEF> cGOMCPEBBIA_ = new RepeatedField<FBBMDFDOEEF>();

	public const int LLGHOBDIBOMFieldNumber = 3;

	private long lLGHOBDIBOM_;

	public const int JHNJKOHPIJNFieldNumber = 8;

	private static readonly FieldCodec<HHKHKGDAMNB> _repeated_jHNJKOHPIJN_codec = FieldCodec.ForMessage(66u, HHKHKGDAMNB.Parser);

	private readonly RepeatedField<HHKHKGDAMNB> jHNJKOHPIJN_ = new RepeatedField<HHKHKGDAMNB>();

	public const int AFIHGFCCHPKFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_aFIHGFCCHPK_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> aFIHGFCCHPK_ = new RepeatedField<uint>();

	public const int UidFieldNumber = 11;

	private uint uid_;

	public const int FLIFCIPEPLOFieldNumber = 12;

	private uint fLIFCIPEPLO_;

	public const int AHLLMHGEEMFFieldNumber = 13;

	private uint aHLLMHGEEMF_;

	public const int MLFNLIBCBMOFieldNumber = 15;

	private static readonly FieldCodec<BBOGAPHFIBG> _repeated_mLFNLIBCBMO_codec = FieldCodec.ForMessage(122u, BBOGAPHFIBG.Parser);

	private readonly RepeatedField<BBOGAPHFIBG> mLFNLIBCBMO_ = new RepeatedField<BBOGAPHFIBG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PEHOCGJJMNF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PEHOCGJJMNFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FBBMDFDOEEF> CGOMCPEBBIA => cGOMCPEBBIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LLGHOBDIBOM
	{
		get
		{
			return lLGHOBDIBOM_;
		}
		set
		{
			lLGHOBDIBOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HHKHKGDAMNB> JHNJKOHPIJN => jHNJKOHPIJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AFIHGFCCHPK => aFIHGFCCHPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLIFCIPEPLO
	{
		get
		{
			return fLIFCIPEPLO_;
		}
		set
		{
			fLIFCIPEPLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHLLMHGEEMF
	{
		get
		{
			return aHLLMHGEEMF_;
		}
		set
		{
			aHLLMHGEEMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BBOGAPHFIBG> MLFNLIBCBMO => mLFNLIBCBMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEHOCGJJMNF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEHOCGJJMNF(PEHOCGJJMNF other)
		: this()
	{
		cGOMCPEBBIA_ = other.cGOMCPEBBIA_.Clone();
		lLGHOBDIBOM_ = other.lLGHOBDIBOM_;
		jHNJKOHPIJN_ = other.jHNJKOHPIJN_.Clone();
		aFIHGFCCHPK_ = other.aFIHGFCCHPK_.Clone();
		uid_ = other.uid_;
		fLIFCIPEPLO_ = other.fLIFCIPEPLO_;
		aHLLMHGEEMF_ = other.aHLLMHGEEMF_;
		mLFNLIBCBMO_ = other.mLFNLIBCBMO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEHOCGJJMNF Clone()
	{
		return new PEHOCGJJMNF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PEHOCGJJMNF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PEHOCGJJMNF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cGOMCPEBBIA_.Equals(other.cGOMCPEBBIA_))
		{
			return false;
		}
		if (LLGHOBDIBOM != other.LLGHOBDIBOM)
		{
			return false;
		}
		if (!jHNJKOHPIJN_.Equals(other.jHNJKOHPIJN_))
		{
			return false;
		}
		if (!aFIHGFCCHPK_.Equals(other.aFIHGFCCHPK_))
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (FLIFCIPEPLO != other.FLIFCIPEPLO)
		{
			return false;
		}
		if (AHLLMHGEEMF != other.AHLLMHGEEMF)
		{
			return false;
		}
		if (!mLFNLIBCBMO_.Equals(other.mLFNLIBCBMO_))
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
		num ^= cGOMCPEBBIA_.GetHashCode();
		if (LLGHOBDIBOM != 0L)
		{
			num ^= LLGHOBDIBOM.GetHashCode();
		}
		num ^= jHNJKOHPIJN_.GetHashCode();
		num ^= aFIHGFCCHPK_.GetHashCode();
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (FLIFCIPEPLO != 0)
		{
			num ^= FLIFCIPEPLO.GetHashCode();
		}
		if (AHLLMHGEEMF != 0)
		{
			num ^= AHLLMHGEEMF.GetHashCode();
		}
		num ^= mLFNLIBCBMO_.GetHashCode();
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
		cGOMCPEBBIA_.WriteTo(ref output, _repeated_cGOMCPEBBIA_codec);
		if (LLGHOBDIBOM != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(LLGHOBDIBOM);
		}
		jHNJKOHPIJN_.WriteTo(ref output, _repeated_jHNJKOHPIJN_codec);
		aFIHGFCCHPK_.WriteTo(ref output, _repeated_aFIHGFCCHPK_codec);
		if (Uid != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Uid);
		}
		if (FLIFCIPEPLO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FLIFCIPEPLO);
		}
		if (AHLLMHGEEMF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AHLLMHGEEMF);
		}
		mLFNLIBCBMO_.WriteTo(ref output, _repeated_mLFNLIBCBMO_codec);
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
		num += cGOMCPEBBIA_.CalculateSize(_repeated_cGOMCPEBBIA_codec);
		if (LLGHOBDIBOM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LLGHOBDIBOM);
		}
		num += jHNJKOHPIJN_.CalculateSize(_repeated_jHNJKOHPIJN_codec);
		num += aFIHGFCCHPK_.CalculateSize(_repeated_aFIHGFCCHPK_codec);
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (FLIFCIPEPLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLIFCIPEPLO);
		}
		if (AHLLMHGEEMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHLLMHGEEMF);
		}
		num += mLFNLIBCBMO_.CalculateSize(_repeated_mLFNLIBCBMO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PEHOCGJJMNF other)
	{
		if (other != null)
		{
			cGOMCPEBBIA_.Add(other.cGOMCPEBBIA_);
			if (other.LLGHOBDIBOM != 0L)
			{
				LLGHOBDIBOM = other.LLGHOBDIBOM;
			}
			jHNJKOHPIJN_.Add(other.jHNJKOHPIJN_);
			aFIHGFCCHPK_.Add(other.aFIHGFCCHPK_);
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.FLIFCIPEPLO != 0)
			{
				FLIFCIPEPLO = other.FLIFCIPEPLO;
			}
			if (other.AHLLMHGEEMF != 0)
			{
				AHLLMHGEEMF = other.AHLLMHGEEMF;
			}
			mLFNLIBCBMO_.Add(other.mLFNLIBCBMO_);
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
			case 10u:
				cGOMCPEBBIA_.AddEntriesFrom(ref input, _repeated_cGOMCPEBBIA_codec);
				break;
			case 24u:
				LLGHOBDIBOM = input.ReadInt64();
				break;
			case 66u:
				jHNJKOHPIJN_.AddEntriesFrom(ref input, _repeated_jHNJKOHPIJN_codec);
				break;
			case 72u:
			case 74u:
				aFIHGFCCHPK_.AddEntriesFrom(ref input, _repeated_aFIHGFCCHPK_codec);
				break;
			case 88u:
				Uid = input.ReadUInt32();
				break;
			case 96u:
				FLIFCIPEPLO = input.ReadUInt32();
				break;
			case 104u:
				AHLLMHGEEMF = input.ReadUInt32();
				break;
			case 122u:
				mLFNLIBCBMO_.AddEntriesFrom(ref input, _repeated_mLFNLIBCBMO_codec);
				break;
			}
		}
	}
}
