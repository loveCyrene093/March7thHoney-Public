using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBBJMHOHKMG : IMessage<LBBJMHOHKMG>, IMessage, IEquatable<LBBJMHOHKMG>, IDeepCloneable<LBBJMHOHKMG>, IBufferMessage
{
	private static readonly MessageParser<LBBJMHOHKMG> _parser = new MessageParser<LBBJMHOHKMG>(() => new LBBJMHOHKMG());

	private UnknownFieldSet _unknownFields;

	public const int HJLIECDFDLJFieldNumber = 1;

	private uint hJLIECDFDLJ_;

	public const int MBMICCJEBJBFieldNumber = 2;

	private uint mBMICCJEBJB_;

	public const int IFDBIMBMFGOFieldNumber = 3;

	private bool iFDBIMBMFGO_;

	public const int EAEGHDGJHGBFieldNumber = 4;

	private ulong eAEGHDGJHGB_;

	public const int MNMPDJADEFPFieldNumber = 5;

	private uint mNMPDJADEFP_;

	public const int LCCPLPKPPJLFieldNumber = 6;

	private static readonly FieldCodec<IKKMAAEBOKL> _repeated_lCCPLPKPPJL_codec = FieldCodec.ForMessage(50u, IKKMAAEBOKL.Parser);

	private readonly RepeatedField<IKKMAAEBOKL> lCCPLPKPPJL_ = new RepeatedField<IKKMAAEBOKL>();

	public const int EJGPPEFEGMKFieldNumber = 7;

	private ulong eJGPPEFEGMK_;

	public const int GKMJLEKGBPNFieldNumber = 8;

	private static readonly FieldCodec<IKKMAAEBOKL> _repeated_gKMJLEKGBPN_codec = FieldCodec.ForMessage(66u, IKKMAAEBOKL.Parser);

	private readonly RepeatedField<IKKMAAEBOKL> gKMJLEKGBPN_ = new RepeatedField<IKKMAAEBOKL>();

	public const int OEDLCAKBFDKFieldNumber = 9;

	private uint oEDLCAKBFDK_;

	public const int LCGOAPAHENHFieldNumber = 10;

	private uint lCGOAPAHENH_;

	public const int PCPOHHAHCCJFieldNumber = 11;

	private uint pCPOHHAHCCJ_;

	public const int JFGBLMMFODFFieldNumber = 12;

	private static readonly FieldCodec<PNDOKOLEPLC> _repeated_jFGBLMMFODF_codec = FieldCodec.ForMessage(98u, PNDOKOLEPLC.Parser);

	private readonly RepeatedField<PNDOKOLEPLC> jFGBLMMFODF_ = new RepeatedField<PNDOKOLEPLC>();

	public const int MBCEAEPNPOOFieldNumber = 13;

	private static readonly FieldCodec<IKKMAAEBOKL> _repeated_mBCEAEPNPOO_codec = FieldCodec.ForMessage(106u, IKKMAAEBOKL.Parser);

	private readonly RepeatedField<IKKMAAEBOKL> mBCEAEPNPOO_ = new RepeatedField<IKKMAAEBOKL>();

	public const int KMLAKHPCFFEFieldNumber = 14;

	private static readonly FieldCodec<IKKMAAEBOKL> _repeated_kMLAKHPCFFE_codec = FieldCodec.ForMessage(114u, IKKMAAEBOKL.Parser);

	private readonly RepeatedField<IKKMAAEBOKL> kMLAKHPCFFE_ = new RepeatedField<IKKMAAEBOKL>();

	public const int NICGPEENIPCFieldNumber = 15;

	private ulong nICGPEENIPC_;

	public const int BBNAINMBBEIFieldNumber = 333;

	private string bBNAINMBBEI_ = "";

	public const int EOEAOHIIKBBFieldNumber = 1615;

	private string eOEAOHIIKBB_ = "";

	public const int GOKIIDCGHJKFieldNumber = 1934;

	private string gOKIIDCGHJK_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBBJMHOHKMG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBBJMHOHKMGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJLIECDFDLJ
	{
		get
		{
			return hJLIECDFDLJ_;
		}
		set
		{
			hJLIECDFDLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBMICCJEBJB
	{
		get
		{
			return mBMICCJEBJB_;
		}
		set
		{
			mBMICCJEBJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IFDBIMBMFGO
	{
		get
		{
			return iFDBIMBMFGO_;
		}
		set
		{
			iFDBIMBMFGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EAEGHDGJHGB
	{
		get
		{
			return eAEGHDGJHGB_;
		}
		set
		{
			eAEGHDGJHGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNMPDJADEFP
	{
		get
		{
			return mNMPDJADEFP_;
		}
		set
		{
			mNMPDJADEFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IKKMAAEBOKL> LCCPLPKPPJL => lCCPLPKPPJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EJGPPEFEGMK
	{
		get
		{
			return eJGPPEFEGMK_;
		}
		set
		{
			eJGPPEFEGMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IKKMAAEBOKL> GKMJLEKGBPN => gKMJLEKGBPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEDLCAKBFDK
	{
		get
		{
			return oEDLCAKBFDK_;
		}
		set
		{
			oEDLCAKBFDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCGOAPAHENH
	{
		get
		{
			return lCGOAPAHENH_;
		}
		set
		{
			lCGOAPAHENH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PCPOHHAHCCJ
	{
		get
		{
			return pCPOHHAHCCJ_;
		}
		set
		{
			pCPOHHAHCCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PNDOKOLEPLC> JFGBLMMFODF => jFGBLMMFODF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IKKMAAEBOKL> MBCEAEPNPOO => mBCEAEPNPOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IKKMAAEBOKL> KMLAKHPCFFE => kMLAKHPCFFE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong NICGPEENIPC
	{
		get
		{
			return nICGPEENIPC_;
		}
		set
		{
			nICGPEENIPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BBNAINMBBEI
	{
		get
		{
			return bBNAINMBBEI_;
		}
		set
		{
			bBNAINMBBEI_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EOEAOHIIKBB
	{
		get
		{
			return eOEAOHIIKBB_;
		}
		set
		{
			eOEAOHIIKBB_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GOKIIDCGHJK
	{
		get
		{
			return gOKIIDCGHJK_;
		}
		set
		{
			gOKIIDCGHJK_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBBJMHOHKMG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBBJMHOHKMG(LBBJMHOHKMG other)
		: this()
	{
		hJLIECDFDLJ_ = other.hJLIECDFDLJ_;
		mBMICCJEBJB_ = other.mBMICCJEBJB_;
		iFDBIMBMFGO_ = other.iFDBIMBMFGO_;
		eAEGHDGJHGB_ = other.eAEGHDGJHGB_;
		mNMPDJADEFP_ = other.mNMPDJADEFP_;
		lCCPLPKPPJL_ = other.lCCPLPKPPJL_.Clone();
		eJGPPEFEGMK_ = other.eJGPPEFEGMK_;
		gKMJLEKGBPN_ = other.gKMJLEKGBPN_.Clone();
		oEDLCAKBFDK_ = other.oEDLCAKBFDK_;
		lCGOAPAHENH_ = other.lCGOAPAHENH_;
		pCPOHHAHCCJ_ = other.pCPOHHAHCCJ_;
		jFGBLMMFODF_ = other.jFGBLMMFODF_.Clone();
		mBCEAEPNPOO_ = other.mBCEAEPNPOO_.Clone();
		kMLAKHPCFFE_ = other.kMLAKHPCFFE_.Clone();
		nICGPEENIPC_ = other.nICGPEENIPC_;
		bBNAINMBBEI_ = other.bBNAINMBBEI_;
		eOEAOHIIKBB_ = other.eOEAOHIIKBB_;
		gOKIIDCGHJK_ = other.gOKIIDCGHJK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBBJMHOHKMG Clone()
	{
		return new LBBJMHOHKMG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBBJMHOHKMG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBBJMHOHKMG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HJLIECDFDLJ != other.HJLIECDFDLJ)
		{
			return false;
		}
		if (MBMICCJEBJB != other.MBMICCJEBJB)
		{
			return false;
		}
		if (IFDBIMBMFGO != other.IFDBIMBMFGO)
		{
			return false;
		}
		if (EAEGHDGJHGB != other.EAEGHDGJHGB)
		{
			return false;
		}
		if (MNMPDJADEFP != other.MNMPDJADEFP)
		{
			return false;
		}
		if (!lCCPLPKPPJL_.Equals(other.lCCPLPKPPJL_))
		{
			return false;
		}
		if (EJGPPEFEGMK != other.EJGPPEFEGMK)
		{
			return false;
		}
		if (!gKMJLEKGBPN_.Equals(other.gKMJLEKGBPN_))
		{
			return false;
		}
		if (OEDLCAKBFDK != other.OEDLCAKBFDK)
		{
			return false;
		}
		if (LCGOAPAHENH != other.LCGOAPAHENH)
		{
			return false;
		}
		if (PCPOHHAHCCJ != other.PCPOHHAHCCJ)
		{
			return false;
		}
		if (!jFGBLMMFODF_.Equals(other.jFGBLMMFODF_))
		{
			return false;
		}
		if (!mBCEAEPNPOO_.Equals(other.mBCEAEPNPOO_))
		{
			return false;
		}
		if (!kMLAKHPCFFE_.Equals(other.kMLAKHPCFFE_))
		{
			return false;
		}
		if (NICGPEENIPC != other.NICGPEENIPC)
		{
			return false;
		}
		if (BBNAINMBBEI != other.BBNAINMBBEI)
		{
			return false;
		}
		if (EOEAOHIIKBB != other.EOEAOHIIKBB)
		{
			return false;
		}
		if (GOKIIDCGHJK != other.GOKIIDCGHJK)
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
		if (HJLIECDFDLJ != 0)
		{
			num ^= HJLIECDFDLJ.GetHashCode();
		}
		if (MBMICCJEBJB != 0)
		{
			num ^= MBMICCJEBJB.GetHashCode();
		}
		if (IFDBIMBMFGO)
		{
			num ^= IFDBIMBMFGO.GetHashCode();
		}
		if (EAEGHDGJHGB != 0L)
		{
			num ^= EAEGHDGJHGB.GetHashCode();
		}
		if (MNMPDJADEFP != 0)
		{
			num ^= MNMPDJADEFP.GetHashCode();
		}
		num ^= lCCPLPKPPJL_.GetHashCode();
		if (EJGPPEFEGMK != 0L)
		{
			num ^= EJGPPEFEGMK.GetHashCode();
		}
		num ^= gKMJLEKGBPN_.GetHashCode();
		if (OEDLCAKBFDK != 0)
		{
			num ^= OEDLCAKBFDK.GetHashCode();
		}
		if (LCGOAPAHENH != 0)
		{
			num ^= LCGOAPAHENH.GetHashCode();
		}
		if (PCPOHHAHCCJ != 0)
		{
			num ^= PCPOHHAHCCJ.GetHashCode();
		}
		num ^= jFGBLMMFODF_.GetHashCode();
		num ^= mBCEAEPNPOO_.GetHashCode();
		num ^= kMLAKHPCFFE_.GetHashCode();
		if (NICGPEENIPC != 0L)
		{
			num ^= NICGPEENIPC.GetHashCode();
		}
		if (BBNAINMBBEI.Length != 0)
		{
			num ^= BBNAINMBBEI.GetHashCode();
		}
		if (EOEAOHIIKBB.Length != 0)
		{
			num ^= EOEAOHIIKBB.GetHashCode();
		}
		if (GOKIIDCGHJK.Length != 0)
		{
			num ^= GOKIIDCGHJK.GetHashCode();
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
		if (HJLIECDFDLJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HJLIECDFDLJ);
		}
		if (MBMICCJEBJB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MBMICCJEBJB);
		}
		if (IFDBIMBMFGO)
		{
			output.WriteRawTag(24);
			output.WriteBool(IFDBIMBMFGO);
		}
		if (EAEGHDGJHGB != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(EAEGHDGJHGB);
		}
		if (MNMPDJADEFP != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MNMPDJADEFP);
		}
		lCCPLPKPPJL_.WriteTo(ref output, _repeated_lCCPLPKPPJL_codec);
		if (EJGPPEFEGMK != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(EJGPPEFEGMK);
		}
		gKMJLEKGBPN_.WriteTo(ref output, _repeated_gKMJLEKGBPN_codec);
		if (OEDLCAKBFDK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OEDLCAKBFDK);
		}
		if (LCGOAPAHENH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LCGOAPAHENH);
		}
		if (PCPOHHAHCCJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PCPOHHAHCCJ);
		}
		jFGBLMMFODF_.WriteTo(ref output, _repeated_jFGBLMMFODF_codec);
		mBCEAEPNPOO_.WriteTo(ref output, _repeated_mBCEAEPNPOO_codec);
		kMLAKHPCFFE_.WriteTo(ref output, _repeated_kMLAKHPCFFE_codec);
		if (NICGPEENIPC != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(NICGPEENIPC);
		}
		if (BBNAINMBBEI.Length != 0)
		{
			output.WriteRawTag(234, 20);
			output.WriteString(BBNAINMBBEI);
		}
		if (EOEAOHIIKBB.Length != 0)
		{
			output.WriteRawTag(250, 100);
			output.WriteString(EOEAOHIIKBB);
		}
		if (GOKIIDCGHJK.Length != 0)
		{
			output.WriteRawTag(242, 120);
			output.WriteString(GOKIIDCGHJK);
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
		if (HJLIECDFDLJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJLIECDFDLJ);
		}
		if (MBMICCJEBJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBMICCJEBJB);
		}
		if (IFDBIMBMFGO)
		{
			num += 2;
		}
		if (EAEGHDGJHGB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EAEGHDGJHGB);
		}
		if (MNMPDJADEFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNMPDJADEFP);
		}
		num += lCCPLPKPPJL_.CalculateSize(_repeated_lCCPLPKPPJL_codec);
		if (EJGPPEFEGMK != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EJGPPEFEGMK);
		}
		num += gKMJLEKGBPN_.CalculateSize(_repeated_gKMJLEKGBPN_codec);
		if (OEDLCAKBFDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEDLCAKBFDK);
		}
		if (LCGOAPAHENH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCGOAPAHENH);
		}
		if (PCPOHHAHCCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PCPOHHAHCCJ);
		}
		num += jFGBLMMFODF_.CalculateSize(_repeated_jFGBLMMFODF_codec);
		num += mBCEAEPNPOO_.CalculateSize(_repeated_mBCEAEPNPOO_codec);
		num += kMLAKHPCFFE_.CalculateSize(_repeated_kMLAKHPCFFE_codec);
		if (NICGPEENIPC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(NICGPEENIPC);
		}
		if (BBNAINMBBEI.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BBNAINMBBEI);
		}
		if (EOEAOHIIKBB.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(EOEAOHIIKBB);
		}
		if (GOKIIDCGHJK.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(GOKIIDCGHJK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBBJMHOHKMG other)
	{
		if (other != null)
		{
			if (other.HJLIECDFDLJ != 0)
			{
				HJLIECDFDLJ = other.HJLIECDFDLJ;
			}
			if (other.MBMICCJEBJB != 0)
			{
				MBMICCJEBJB = other.MBMICCJEBJB;
			}
			if (other.IFDBIMBMFGO)
			{
				IFDBIMBMFGO = other.IFDBIMBMFGO;
			}
			if (other.EAEGHDGJHGB != 0L)
			{
				EAEGHDGJHGB = other.EAEGHDGJHGB;
			}
			if (other.MNMPDJADEFP != 0)
			{
				MNMPDJADEFP = other.MNMPDJADEFP;
			}
			lCCPLPKPPJL_.Add(other.lCCPLPKPPJL_);
			if (other.EJGPPEFEGMK != 0L)
			{
				EJGPPEFEGMK = other.EJGPPEFEGMK;
			}
			gKMJLEKGBPN_.Add(other.gKMJLEKGBPN_);
			if (other.OEDLCAKBFDK != 0)
			{
				OEDLCAKBFDK = other.OEDLCAKBFDK;
			}
			if (other.LCGOAPAHENH != 0)
			{
				LCGOAPAHENH = other.LCGOAPAHENH;
			}
			if (other.PCPOHHAHCCJ != 0)
			{
				PCPOHHAHCCJ = other.PCPOHHAHCCJ;
			}
			jFGBLMMFODF_.Add(other.jFGBLMMFODF_);
			mBCEAEPNPOO_.Add(other.mBCEAEPNPOO_);
			kMLAKHPCFFE_.Add(other.kMLAKHPCFFE_);
			if (other.NICGPEENIPC != 0L)
			{
				NICGPEENIPC = other.NICGPEENIPC;
			}
			if (other.BBNAINMBBEI.Length != 0)
			{
				BBNAINMBBEI = other.BBNAINMBBEI;
			}
			if (other.EOEAOHIIKBB.Length != 0)
			{
				EOEAOHIIKBB = other.EOEAOHIIKBB;
			}
			if (other.GOKIIDCGHJK.Length != 0)
			{
				GOKIIDCGHJK = other.GOKIIDCGHJK;
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
				HJLIECDFDLJ = input.ReadUInt32();
				break;
			case 16u:
				MBMICCJEBJB = input.ReadUInt32();
				break;
			case 24u:
				IFDBIMBMFGO = input.ReadBool();
				break;
			case 32u:
				EAEGHDGJHGB = input.ReadUInt64();
				break;
			case 40u:
				MNMPDJADEFP = input.ReadUInt32();
				break;
			case 50u:
				lCCPLPKPPJL_.AddEntriesFrom(ref input, _repeated_lCCPLPKPPJL_codec);
				break;
			case 56u:
				EJGPPEFEGMK = input.ReadUInt64();
				break;
			case 66u:
				gKMJLEKGBPN_.AddEntriesFrom(ref input, _repeated_gKMJLEKGBPN_codec);
				break;
			case 72u:
				OEDLCAKBFDK = input.ReadUInt32();
				break;
			case 80u:
				LCGOAPAHENH = input.ReadUInt32();
				break;
			case 88u:
				PCPOHHAHCCJ = input.ReadUInt32();
				break;
			case 98u:
				jFGBLMMFODF_.AddEntriesFrom(ref input, _repeated_jFGBLMMFODF_codec);
				break;
			case 106u:
				mBCEAEPNPOO_.AddEntriesFrom(ref input, _repeated_mBCEAEPNPOO_codec);
				break;
			case 114u:
				kMLAKHPCFFE_.AddEntriesFrom(ref input, _repeated_kMLAKHPCFFE_codec);
				break;
			case 120u:
				NICGPEENIPC = input.ReadUInt64();
				break;
			case 2666u:
				BBNAINMBBEI = input.ReadString();
				break;
			case 12922u:
				EOEAOHIIKBB = input.ReadString();
				break;
			case 15474u:
				GOKIIDCGHJK = input.ReadString();
				break;
			}
		}
	}
}
