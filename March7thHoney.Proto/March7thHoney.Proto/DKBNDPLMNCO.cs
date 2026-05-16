using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DKBNDPLMNCO : IMessage<DKBNDPLMNCO>, IMessage, IEquatable<DKBNDPLMNCO>, IDeepCloneable<DKBNDPLMNCO>, IBufferMessage
{
	private static readonly MessageParser<DKBNDPLMNCO> _parser = new MessageParser<DKBNDPLMNCO>(() => new DKBNDPLMNCO());

	private UnknownFieldSet _unknownFields;

	public const int JPONLDDDEMIFieldNumber = 1;

	private static readonly FieldCodec<OLCPICDAOKI> _repeated_jPONLDDDEMI_codec = FieldCodec.ForMessage(10u, OLCPICDAOKI.Parser);

	private readonly RepeatedField<OLCPICDAOKI> jPONLDDDEMI_ = new RepeatedField<OLCPICDAOKI>();

	public const int BEPKBMGKCGBFieldNumber = 2;

	private bool bEPKBMGKCGB_;

	public const int CODOFDEHJCJFieldNumber = 3;

	private uint cODOFDEHJCJ_;

	public const int IPACGBDKFNAFieldNumber = 4;

	private bool iPACGBDKFNA_;

	public const int FKFHMMHBIKCFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_fKFHMMHBIKC_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> fKFHMMHBIKC_ = new RepeatedField<uint>();

	public const int OEDMCLBPADGFieldNumber = 10;

	private uint oEDMCLBPADG_;

	public const int CPJDHFJOIALFieldNumber = 14;

	private static readonly FieldCodec<OOCCLBMLECE> _repeated_cPJDHFJOIAL_codec = FieldCodec.ForMessage(114u, OOCCLBMLECE.Parser);

	private readonly RepeatedField<OOCCLBMLECE> cPJDHFJOIAL_ = new RepeatedField<OOCCLBMLECE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DKBNDPLMNCO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DKBNDPLMNCOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLCPICDAOKI> JPONLDDDEMI => jPONLDDDEMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BEPKBMGKCGB
	{
		get
		{
			return bEPKBMGKCGB_;
		}
		set
		{
			bEPKBMGKCGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CODOFDEHJCJ
	{
		get
		{
			return cODOFDEHJCJ_;
		}
		set
		{
			cODOFDEHJCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IPACGBDKFNA
	{
		get
		{
			return iPACGBDKFNA_;
		}
		set
		{
			iPACGBDKFNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FKFHMMHBIKC => fKFHMMHBIKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEDMCLBPADG
	{
		get
		{
			return oEDMCLBPADG_;
		}
		set
		{
			oEDMCLBPADG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OOCCLBMLECE> CPJDHFJOIAL => cPJDHFJOIAL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNDPLMNCO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNDPLMNCO(DKBNDPLMNCO other)
		: this()
	{
		jPONLDDDEMI_ = other.jPONLDDDEMI_.Clone();
		bEPKBMGKCGB_ = other.bEPKBMGKCGB_;
		cODOFDEHJCJ_ = other.cODOFDEHJCJ_;
		iPACGBDKFNA_ = other.iPACGBDKFNA_;
		fKFHMMHBIKC_ = other.fKFHMMHBIKC_.Clone();
		oEDMCLBPADG_ = other.oEDMCLBPADG_;
		cPJDHFJOIAL_ = other.cPJDHFJOIAL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNDPLMNCO Clone()
	{
		return new DKBNDPLMNCO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DKBNDPLMNCO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DKBNDPLMNCO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jPONLDDDEMI_.Equals(other.jPONLDDDEMI_))
		{
			return false;
		}
		if (BEPKBMGKCGB != other.BEPKBMGKCGB)
		{
			return false;
		}
		if (CODOFDEHJCJ != other.CODOFDEHJCJ)
		{
			return false;
		}
		if (IPACGBDKFNA != other.IPACGBDKFNA)
		{
			return false;
		}
		if (!fKFHMMHBIKC_.Equals(other.fKFHMMHBIKC_))
		{
			return false;
		}
		if (OEDMCLBPADG != other.OEDMCLBPADG)
		{
			return false;
		}
		if (!cPJDHFJOIAL_.Equals(other.cPJDHFJOIAL_))
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
		num ^= jPONLDDDEMI_.GetHashCode();
		if (BEPKBMGKCGB)
		{
			num ^= BEPKBMGKCGB.GetHashCode();
		}
		if (CODOFDEHJCJ != 0)
		{
			num ^= CODOFDEHJCJ.GetHashCode();
		}
		if (IPACGBDKFNA)
		{
			num ^= IPACGBDKFNA.GetHashCode();
		}
		num ^= fKFHMMHBIKC_.GetHashCode();
		if (OEDMCLBPADG != 0)
		{
			num ^= OEDMCLBPADG.GetHashCode();
		}
		num ^= cPJDHFJOIAL_.GetHashCode();
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
		jPONLDDDEMI_.WriteTo(ref output, _repeated_jPONLDDDEMI_codec);
		if (BEPKBMGKCGB)
		{
			output.WriteRawTag(16);
			output.WriteBool(BEPKBMGKCGB);
		}
		if (CODOFDEHJCJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CODOFDEHJCJ);
		}
		if (IPACGBDKFNA)
		{
			output.WriteRawTag(32);
			output.WriteBool(IPACGBDKFNA);
		}
		fKFHMMHBIKC_.WriteTo(ref output, _repeated_fKFHMMHBIKC_codec);
		if (OEDMCLBPADG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OEDMCLBPADG);
		}
		cPJDHFJOIAL_.WriteTo(ref output, _repeated_cPJDHFJOIAL_codec);
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
		num += jPONLDDDEMI_.CalculateSize(_repeated_jPONLDDDEMI_codec);
		if (BEPKBMGKCGB)
		{
			num += 2;
		}
		if (CODOFDEHJCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CODOFDEHJCJ);
		}
		if (IPACGBDKFNA)
		{
			num += 2;
		}
		num += fKFHMMHBIKC_.CalculateSize(_repeated_fKFHMMHBIKC_codec);
		if (OEDMCLBPADG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEDMCLBPADG);
		}
		num += cPJDHFJOIAL_.CalculateSize(_repeated_cPJDHFJOIAL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DKBNDPLMNCO other)
	{
		if (other != null)
		{
			jPONLDDDEMI_.Add(other.jPONLDDDEMI_);
			if (other.BEPKBMGKCGB)
			{
				BEPKBMGKCGB = other.BEPKBMGKCGB;
			}
			if (other.CODOFDEHJCJ != 0)
			{
				CODOFDEHJCJ = other.CODOFDEHJCJ;
			}
			if (other.IPACGBDKFNA)
			{
				IPACGBDKFNA = other.IPACGBDKFNA;
			}
			fKFHMMHBIKC_.Add(other.fKFHMMHBIKC_);
			if (other.OEDMCLBPADG != 0)
			{
				OEDMCLBPADG = other.OEDMCLBPADG;
			}
			cPJDHFJOIAL_.Add(other.cPJDHFJOIAL_);
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
				jPONLDDDEMI_.AddEntriesFrom(ref input, _repeated_jPONLDDDEMI_codec);
				break;
			case 16u:
				BEPKBMGKCGB = input.ReadBool();
				break;
			case 24u:
				CODOFDEHJCJ = input.ReadUInt32();
				break;
			case 32u:
				IPACGBDKFNA = input.ReadBool();
				break;
			case 40u:
			case 42u:
				fKFHMMHBIKC_.AddEntriesFrom(ref input, _repeated_fKFHMMHBIKC_codec);
				break;
			case 80u:
				OEDMCLBPADG = input.ReadUInt32();
				break;
			case 114u:
				cPJDHFJOIAL_.AddEntriesFrom(ref input, _repeated_cPJDHFJOIAL_codec);
				break;
			}
		}
	}
}
