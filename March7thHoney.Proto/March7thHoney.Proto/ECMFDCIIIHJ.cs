using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ECMFDCIIIHJ : IMessage<ECMFDCIIIHJ>, IMessage, IEquatable<ECMFDCIIIHJ>, IDeepCloneable<ECMFDCIIIHJ>, IBufferMessage
{
	private static readonly MessageParser<ECMFDCIIIHJ> _parser = new MessageParser<ECMFDCIIIHJ>(() => new ECMFDCIIIHJ());

	private UnknownFieldSet _unknownFields;

	public const int CIGCKKGMLIDFieldNumber = 1;

	private static readonly FieldCodec<BDDBAKBOMKP> _repeated_cIGCKKGMLID_codec = FieldCodec.ForMessage(10u, BDDBAKBOMKP.Parser);

	private readonly RepeatedField<BDDBAKBOMKP> cIGCKKGMLID_ = new RepeatedField<BDDBAKBOMKP>();

	public const int EMBGAEMHDPAFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_eMBGAEMHDPA_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> eMBGAEMHDPA_ = new RepeatedField<uint>();

	public const int BDAOCNNKOJFFieldNumber = 4;

	private static readonly FieldCodec<CAIODCNEMHO> _repeated_bDAOCNNKOJF_codec = FieldCodec.ForMessage(34u, CAIODCNEMHO.Parser);

	private readonly RepeatedField<CAIODCNEMHO> bDAOCNNKOJF_ = new RepeatedField<CAIODCNEMHO>();

	public const int FHADIOPDMHPFieldNumber = 7;

	private uint fHADIOPDMHP_;

	public const int LMEEJJNOFIEFieldNumber = 11;

	private uint lMEEJJNOFIE_;

	public const int PEJMPHMPPKOFieldNumber = 12;

	private uint pEJMPHMPPKO_;

	public const int NMCACNNNBNDFieldNumber = 14;

	private uint nMCACNNNBND_;

	public const int DIDPABJPDLJFieldNumber = 15;

	private bool dIDPABJPDLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ECMFDCIIIHJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ECMFDCIIIHJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BDDBAKBOMKP> CIGCKKGMLID => cIGCKKGMLID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EMBGAEMHDPA => eMBGAEMHDPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CAIODCNEMHO> BDAOCNNKOJF => bDAOCNNKOJF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHADIOPDMHP
	{
		get
		{
			return fHADIOPDMHP_;
		}
		set
		{
			fHADIOPDMHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMEEJJNOFIE
	{
		get
		{
			return lMEEJJNOFIE_;
		}
		set
		{
			lMEEJJNOFIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEJMPHMPPKO
	{
		get
		{
			return pEJMPHMPPKO_;
		}
		set
		{
			pEJMPHMPPKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMCACNNNBND
	{
		get
		{
			return nMCACNNNBND_;
		}
		set
		{
			nMCACNNNBND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DIDPABJPDLJ
	{
		get
		{
			return dIDPABJPDLJ_;
		}
		set
		{
			dIDPABJPDLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECMFDCIIIHJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECMFDCIIIHJ(ECMFDCIIIHJ other)
		: this()
	{
		cIGCKKGMLID_ = other.cIGCKKGMLID_.Clone();
		eMBGAEMHDPA_ = other.eMBGAEMHDPA_.Clone();
		bDAOCNNKOJF_ = other.bDAOCNNKOJF_.Clone();
		fHADIOPDMHP_ = other.fHADIOPDMHP_;
		lMEEJJNOFIE_ = other.lMEEJJNOFIE_;
		pEJMPHMPPKO_ = other.pEJMPHMPPKO_;
		nMCACNNNBND_ = other.nMCACNNNBND_;
		dIDPABJPDLJ_ = other.dIDPABJPDLJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECMFDCIIIHJ Clone()
	{
		return new ECMFDCIIIHJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ECMFDCIIIHJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ECMFDCIIIHJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cIGCKKGMLID_.Equals(other.cIGCKKGMLID_))
		{
			return false;
		}
		if (!eMBGAEMHDPA_.Equals(other.eMBGAEMHDPA_))
		{
			return false;
		}
		if (!bDAOCNNKOJF_.Equals(other.bDAOCNNKOJF_))
		{
			return false;
		}
		if (FHADIOPDMHP != other.FHADIOPDMHP)
		{
			return false;
		}
		if (LMEEJJNOFIE != other.LMEEJJNOFIE)
		{
			return false;
		}
		if (PEJMPHMPPKO != other.PEJMPHMPPKO)
		{
			return false;
		}
		if (NMCACNNNBND != other.NMCACNNNBND)
		{
			return false;
		}
		if (DIDPABJPDLJ != other.DIDPABJPDLJ)
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
		num ^= cIGCKKGMLID_.GetHashCode();
		num ^= eMBGAEMHDPA_.GetHashCode();
		num ^= bDAOCNNKOJF_.GetHashCode();
		if (FHADIOPDMHP != 0)
		{
			num ^= FHADIOPDMHP.GetHashCode();
		}
		if (LMEEJJNOFIE != 0)
		{
			num ^= LMEEJJNOFIE.GetHashCode();
		}
		if (PEJMPHMPPKO != 0)
		{
			num ^= PEJMPHMPPKO.GetHashCode();
		}
		if (NMCACNNNBND != 0)
		{
			num ^= NMCACNNNBND.GetHashCode();
		}
		if (DIDPABJPDLJ)
		{
			num ^= DIDPABJPDLJ.GetHashCode();
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
		cIGCKKGMLID_.WriteTo(ref output, _repeated_cIGCKKGMLID_codec);
		eMBGAEMHDPA_.WriteTo(ref output, _repeated_eMBGAEMHDPA_codec);
		bDAOCNNKOJF_.WriteTo(ref output, _repeated_bDAOCNNKOJF_codec);
		if (FHADIOPDMHP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FHADIOPDMHP);
		}
		if (LMEEJJNOFIE != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LMEEJJNOFIE);
		}
		if (PEJMPHMPPKO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PEJMPHMPPKO);
		}
		if (NMCACNNNBND != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NMCACNNNBND);
		}
		if (DIDPABJPDLJ)
		{
			output.WriteRawTag(120);
			output.WriteBool(DIDPABJPDLJ);
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
		num += cIGCKKGMLID_.CalculateSize(_repeated_cIGCKKGMLID_codec);
		num += eMBGAEMHDPA_.CalculateSize(_repeated_eMBGAEMHDPA_codec);
		num += bDAOCNNKOJF_.CalculateSize(_repeated_bDAOCNNKOJF_codec);
		if (FHADIOPDMHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHADIOPDMHP);
		}
		if (LMEEJJNOFIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMEEJJNOFIE);
		}
		if (PEJMPHMPPKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEJMPHMPPKO);
		}
		if (NMCACNNNBND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMCACNNNBND);
		}
		if (DIDPABJPDLJ)
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
	public void MergeFrom(ECMFDCIIIHJ other)
	{
		if (other != null)
		{
			cIGCKKGMLID_.Add(other.cIGCKKGMLID_);
			eMBGAEMHDPA_.Add(other.eMBGAEMHDPA_);
			bDAOCNNKOJF_.Add(other.bDAOCNNKOJF_);
			if (other.FHADIOPDMHP != 0)
			{
				FHADIOPDMHP = other.FHADIOPDMHP;
			}
			if (other.LMEEJJNOFIE != 0)
			{
				LMEEJJNOFIE = other.LMEEJJNOFIE;
			}
			if (other.PEJMPHMPPKO != 0)
			{
				PEJMPHMPPKO = other.PEJMPHMPPKO;
			}
			if (other.NMCACNNNBND != 0)
			{
				NMCACNNNBND = other.NMCACNNNBND;
			}
			if (other.DIDPABJPDLJ)
			{
				DIDPABJPDLJ = other.DIDPABJPDLJ;
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
			case 10u:
				cIGCKKGMLID_.AddEntriesFrom(ref input, _repeated_cIGCKKGMLID_codec);
				break;
			case 16u:
			case 18u:
				eMBGAEMHDPA_.AddEntriesFrom(ref input, _repeated_eMBGAEMHDPA_codec);
				break;
			case 34u:
				bDAOCNNKOJF_.AddEntriesFrom(ref input, _repeated_bDAOCNNKOJF_codec);
				break;
			case 56u:
				FHADIOPDMHP = input.ReadUInt32();
				break;
			case 88u:
				LMEEJJNOFIE = input.ReadUInt32();
				break;
			case 96u:
				PEJMPHMPPKO = input.ReadUInt32();
				break;
			case 112u:
				NMCACNNNBND = input.ReadUInt32();
				break;
			case 120u:
				DIDPABJPDLJ = input.ReadBool();
				break;
			}
		}
	}
}
