using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBOKDHDOKAD : IMessage<OBOKDHDOKAD>, IMessage, IEquatable<OBOKDHDOKAD>, IDeepCloneable<OBOKDHDOKAD>, IBufferMessage
{
	private static readonly MessageParser<OBOKDHDOKAD> _parser = new MessageParser<OBOKDHDOKAD>(() => new OBOKDHDOKAD());

	private UnknownFieldSet _unknownFields;

	public const int CEKCLDPNFEAFieldNumber = 1;

	private uint cEKCLDPNFEA_;

	public const int GECPCNOMFFGFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gECPCNOMFFG_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gECPCNOMFFG_ = new RepeatedField<uint>();

	public const int JCHFMDEPBMKFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_jCHFMDEPBMK_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> jCHFMDEPBMK_ = new RepeatedField<uint>();

	public const int NPBKMKIPKOHFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_nPBKMKIPKOH_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> nPBKMKIPKOH_ = new RepeatedField<uint>();

	public const int CBPBCDPJOKOFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_cBPBCDPJOKO_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> cBPBCDPJOKO_ = new RepeatedField<uint>();

	public const int IIOBBODPCKNFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_iIOBBODPCKN_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> iIOBBODPCKN_ = new RepeatedField<uint>();

	public const int ELBALPJIPNKFieldNumber = 7;

	private bool eLBALPJIPNK_;

	public const int JNBMENGEDFCFieldNumber = 8;

	private uint jNBMENGEDFC_;

	public const int BCCFDCELEKIFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_bCCFDCELEKI_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> bCCFDCELEKI_ = new RepeatedField<uint>();

	public const int FKDOIKIMHAOFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_fKDOIKIMHAO_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> fKDOIKIMHAO_ = new RepeatedField<uint>();

	public const int NCKJEPIODADFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_nCKJEPIODAD_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> nCKJEPIODAD_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBOKDHDOKAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBOKDHDOKADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEKCLDPNFEA
	{
		get
		{
			return cEKCLDPNFEA_;
		}
		set
		{
			cEKCLDPNFEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GECPCNOMFFG => gECPCNOMFFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JCHFMDEPBMK => jCHFMDEPBMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NPBKMKIPKOH => nPBKMKIPKOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CBPBCDPJOKO => cBPBCDPJOKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IIOBBODPCKN => iIOBBODPCKN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ELBALPJIPNK
	{
		get
		{
			return eLBALPJIPNK_;
		}
		set
		{
			eLBALPJIPNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNBMENGEDFC
	{
		get
		{
			return jNBMENGEDFC_;
		}
		set
		{
			jNBMENGEDFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BCCFDCELEKI => bCCFDCELEKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FKDOIKIMHAO => fKDOIKIMHAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NCKJEPIODAD => nCKJEPIODAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBOKDHDOKAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBOKDHDOKAD(OBOKDHDOKAD other)
		: this()
	{
		cEKCLDPNFEA_ = other.cEKCLDPNFEA_;
		gECPCNOMFFG_ = other.gECPCNOMFFG_.Clone();
		jCHFMDEPBMK_ = other.jCHFMDEPBMK_.Clone();
		nPBKMKIPKOH_ = other.nPBKMKIPKOH_.Clone();
		cBPBCDPJOKO_ = other.cBPBCDPJOKO_.Clone();
		iIOBBODPCKN_ = other.iIOBBODPCKN_.Clone();
		eLBALPJIPNK_ = other.eLBALPJIPNK_;
		jNBMENGEDFC_ = other.jNBMENGEDFC_;
		bCCFDCELEKI_ = other.bCCFDCELEKI_.Clone();
		fKDOIKIMHAO_ = other.fKDOIKIMHAO_.Clone();
		nCKJEPIODAD_ = other.nCKJEPIODAD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBOKDHDOKAD Clone()
	{
		return new OBOKDHDOKAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBOKDHDOKAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBOKDHDOKAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEKCLDPNFEA != other.CEKCLDPNFEA)
		{
			return false;
		}
		if (!gECPCNOMFFG_.Equals(other.gECPCNOMFFG_))
		{
			return false;
		}
		if (!jCHFMDEPBMK_.Equals(other.jCHFMDEPBMK_))
		{
			return false;
		}
		if (!nPBKMKIPKOH_.Equals(other.nPBKMKIPKOH_))
		{
			return false;
		}
		if (!cBPBCDPJOKO_.Equals(other.cBPBCDPJOKO_))
		{
			return false;
		}
		if (!iIOBBODPCKN_.Equals(other.iIOBBODPCKN_))
		{
			return false;
		}
		if (ELBALPJIPNK != other.ELBALPJIPNK)
		{
			return false;
		}
		if (JNBMENGEDFC != other.JNBMENGEDFC)
		{
			return false;
		}
		if (!bCCFDCELEKI_.Equals(other.bCCFDCELEKI_))
		{
			return false;
		}
		if (!fKDOIKIMHAO_.Equals(other.fKDOIKIMHAO_))
		{
			return false;
		}
		if (!nCKJEPIODAD_.Equals(other.nCKJEPIODAD_))
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
		if (CEKCLDPNFEA != 0)
		{
			num ^= CEKCLDPNFEA.GetHashCode();
		}
		num ^= gECPCNOMFFG_.GetHashCode();
		num ^= jCHFMDEPBMK_.GetHashCode();
		num ^= nPBKMKIPKOH_.GetHashCode();
		num ^= cBPBCDPJOKO_.GetHashCode();
		num ^= iIOBBODPCKN_.GetHashCode();
		if (ELBALPJIPNK)
		{
			num ^= ELBALPJIPNK.GetHashCode();
		}
		if (JNBMENGEDFC != 0)
		{
			num ^= JNBMENGEDFC.GetHashCode();
		}
		num ^= bCCFDCELEKI_.GetHashCode();
		num ^= fKDOIKIMHAO_.GetHashCode();
		num ^= nCKJEPIODAD_.GetHashCode();
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
		if (CEKCLDPNFEA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CEKCLDPNFEA);
		}
		gECPCNOMFFG_.WriteTo(ref output, _repeated_gECPCNOMFFG_codec);
		jCHFMDEPBMK_.WriteTo(ref output, _repeated_jCHFMDEPBMK_codec);
		nPBKMKIPKOH_.WriteTo(ref output, _repeated_nPBKMKIPKOH_codec);
		cBPBCDPJOKO_.WriteTo(ref output, _repeated_cBPBCDPJOKO_codec);
		iIOBBODPCKN_.WriteTo(ref output, _repeated_iIOBBODPCKN_codec);
		if (ELBALPJIPNK)
		{
			output.WriteRawTag(56);
			output.WriteBool(ELBALPJIPNK);
		}
		if (JNBMENGEDFC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JNBMENGEDFC);
		}
		bCCFDCELEKI_.WriteTo(ref output, _repeated_bCCFDCELEKI_codec);
		fKDOIKIMHAO_.WriteTo(ref output, _repeated_fKDOIKIMHAO_codec);
		nCKJEPIODAD_.WriteTo(ref output, _repeated_nCKJEPIODAD_codec);
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
		if (CEKCLDPNFEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEKCLDPNFEA);
		}
		num += gECPCNOMFFG_.CalculateSize(_repeated_gECPCNOMFFG_codec);
		num += jCHFMDEPBMK_.CalculateSize(_repeated_jCHFMDEPBMK_codec);
		num += nPBKMKIPKOH_.CalculateSize(_repeated_nPBKMKIPKOH_codec);
		num += cBPBCDPJOKO_.CalculateSize(_repeated_cBPBCDPJOKO_codec);
		num += iIOBBODPCKN_.CalculateSize(_repeated_iIOBBODPCKN_codec);
		if (ELBALPJIPNK)
		{
			num += 2;
		}
		if (JNBMENGEDFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNBMENGEDFC);
		}
		num += bCCFDCELEKI_.CalculateSize(_repeated_bCCFDCELEKI_codec);
		num += fKDOIKIMHAO_.CalculateSize(_repeated_fKDOIKIMHAO_codec);
		num += nCKJEPIODAD_.CalculateSize(_repeated_nCKJEPIODAD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OBOKDHDOKAD other)
	{
		if (other != null)
		{
			if (other.CEKCLDPNFEA != 0)
			{
				CEKCLDPNFEA = other.CEKCLDPNFEA;
			}
			gECPCNOMFFG_.Add(other.gECPCNOMFFG_);
			jCHFMDEPBMK_.Add(other.jCHFMDEPBMK_);
			nPBKMKIPKOH_.Add(other.nPBKMKIPKOH_);
			cBPBCDPJOKO_.Add(other.cBPBCDPJOKO_);
			iIOBBODPCKN_.Add(other.iIOBBODPCKN_);
			if (other.ELBALPJIPNK)
			{
				ELBALPJIPNK = other.ELBALPJIPNK;
			}
			if (other.JNBMENGEDFC != 0)
			{
				JNBMENGEDFC = other.JNBMENGEDFC;
			}
			bCCFDCELEKI_.Add(other.bCCFDCELEKI_);
			fKDOIKIMHAO_.Add(other.fKDOIKIMHAO_);
			nCKJEPIODAD_.Add(other.nCKJEPIODAD_);
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
				CEKCLDPNFEA = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				gECPCNOMFFG_.AddEntriesFrom(ref input, _repeated_gECPCNOMFFG_codec);
				break;
			case 24u:
			case 26u:
				jCHFMDEPBMK_.AddEntriesFrom(ref input, _repeated_jCHFMDEPBMK_codec);
				break;
			case 32u:
			case 34u:
				nPBKMKIPKOH_.AddEntriesFrom(ref input, _repeated_nPBKMKIPKOH_codec);
				break;
			case 40u:
			case 42u:
				cBPBCDPJOKO_.AddEntriesFrom(ref input, _repeated_cBPBCDPJOKO_codec);
				break;
			case 48u:
			case 50u:
				iIOBBODPCKN_.AddEntriesFrom(ref input, _repeated_iIOBBODPCKN_codec);
				break;
			case 56u:
				ELBALPJIPNK = input.ReadBool();
				break;
			case 64u:
				JNBMENGEDFC = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				bCCFDCELEKI_.AddEntriesFrom(ref input, _repeated_bCCFDCELEKI_codec);
				break;
			case 80u:
			case 82u:
				fKDOIKIMHAO_.AddEntriesFrom(ref input, _repeated_fKDOIKIMHAO_codec);
				break;
			case 88u:
			case 90u:
				nCKJEPIODAD_.AddEntriesFrom(ref input, _repeated_nCKJEPIODAD_codec);
				break;
			}
		}
	}
}
