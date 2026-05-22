using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ABOLGABIPJA : IMessage<ABOLGABIPJA>, IMessage, IEquatable<ABOLGABIPJA>, IDeepCloneable<ABOLGABIPJA>, IBufferMessage
{
	private static readonly MessageParser<ABOLGABIPJA> _parser = new MessageParser<ABOLGABIPJA>(() => new ABOLGABIPJA());

	private UnknownFieldSet _unknownFields;

	public const int MLOFNLCKNBLFieldNumber = 1;

	private uint mLOFNLCKNBL_;

	public const int AuthkeyVerFieldNumber = 2;

	private uint authkeyVer_;

	public const int LDEBCMJBCLDFieldNumber = 3;

	private uint lDEBCMJBCLD_;

	public const int NHDDHMGGKBOFieldNumber = 4;

	private uint nHDDHMGGKBO_;

	public const int HDHJEFFIPOLFieldNumber = 5;

	private uint hDHJEFFIPOL_;

	public const int NGCFMHKACDOFieldNumber = 6;

	private uint nGCFMHKACDO_;

	public const int AJKHDLNMBMPFieldNumber = 7;

	private uint aJKHDLNMBMP_;

	public const int IGJOBFGJAMIFieldNumber = 8;

	private uint iGJOBFGJAMI_;

	public const int EBABMGKJIAFFieldNumber = 9;

	private ulong eBABMGKJIAF_;

	public const int JEBNJPNCPMPFieldNumber = 10;

	private uint jEBNJPNCPMP_;

	public const int IdFieldNumber = 11;

	private uint id_;

	public const int HKEHIIPBDHAFieldNumber = 12;

	private uint hKEHIIPBDHA_;

	public const int FLMEHIPGBJNFieldNumber = 13;

	private uint fLMEHIPGBJN_;

	public const int EMHMHACKBOIFieldNumber = 14;

	private string eMHMHACKBOI_ = "";

	public const int DDALNHLOGJKFieldNumber = 15;

	private uint dDALNHLOGJK_;

	public const int LHHMLLFGFLIFieldNumber = 16;

	private uint lHHMLLFGFLI_;

	public const int DAMFMNKHFIHFieldNumber = 17;

	private ulong dAMFMNKHFIH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ABOLGABIPJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ABOLGABIPJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLOFNLCKNBL
	{
		get
		{
			return mLOFNLCKNBL_;
		}
		set
		{
			mLOFNLCKNBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AuthkeyVer
	{
		get
		{
			return authkeyVer_;
		}
		set
		{
			authkeyVer_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDEBCMJBCLD
	{
		get
		{
			return lDEBCMJBCLD_;
		}
		set
		{
			lDEBCMJBCLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHDDHMGGKBO
	{
		get
		{
			return nHDDHMGGKBO_;
		}
		set
		{
			nHDDHMGGKBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HDHJEFFIPOL
	{
		get
		{
			return hDHJEFFIPOL_;
		}
		set
		{
			hDHJEFFIPOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGCFMHKACDO
	{
		get
		{
			return nGCFMHKACDO_;
		}
		set
		{
			nGCFMHKACDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AJKHDLNMBMP
	{
		get
		{
			return aJKHDLNMBMP_;
		}
		set
		{
			aJKHDLNMBMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGJOBFGJAMI
	{
		get
		{
			return iGJOBFGJAMI_;
		}
		set
		{
			iGJOBFGJAMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EBABMGKJIAF
	{
		get
		{
			return eBABMGKJIAF_;
		}
		set
		{
			eBABMGKJIAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JEBNJPNCPMP
	{
		get
		{
			return jEBNJPNCPMP_;
		}
		set
		{
			jEBNJPNCPMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HKEHIIPBDHA
	{
		get
		{
			return hKEHIIPBDHA_;
		}
		set
		{
			hKEHIIPBDHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLMEHIPGBJN
	{
		get
		{
			return fLMEHIPGBJN_;
		}
		set
		{
			fLMEHIPGBJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EMHMHACKBOI
	{
		get
		{
			return eMHMHACKBOI_;
		}
		set
		{
			eMHMHACKBOI_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDALNHLOGJK
	{
		get
		{
			return dDALNHLOGJK_;
		}
		set
		{
			dDALNHLOGJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LHHMLLFGFLI
	{
		get
		{
			return lHHMLLFGFLI_;
		}
		set
		{
			lHHMLLFGFLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong DAMFMNKHFIH
	{
		get
		{
			return dAMFMNKHFIH_;
		}
		set
		{
			dAMFMNKHFIH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABOLGABIPJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABOLGABIPJA(ABOLGABIPJA other)
		: this()
	{
		mLOFNLCKNBL_ = other.mLOFNLCKNBL_;
		authkeyVer_ = other.authkeyVer_;
		lDEBCMJBCLD_ = other.lDEBCMJBCLD_;
		nHDDHMGGKBO_ = other.nHDDHMGGKBO_;
		hDHJEFFIPOL_ = other.hDHJEFFIPOL_;
		nGCFMHKACDO_ = other.nGCFMHKACDO_;
		aJKHDLNMBMP_ = other.aJKHDLNMBMP_;
		iGJOBFGJAMI_ = other.iGJOBFGJAMI_;
		eBABMGKJIAF_ = other.eBABMGKJIAF_;
		jEBNJPNCPMP_ = other.jEBNJPNCPMP_;
		id_ = other.id_;
		hKEHIIPBDHA_ = other.hKEHIIPBDHA_;
		fLMEHIPGBJN_ = other.fLMEHIPGBJN_;
		eMHMHACKBOI_ = other.eMHMHACKBOI_;
		dDALNHLOGJK_ = other.dDALNHLOGJK_;
		lHHMLLFGFLI_ = other.lHHMLLFGFLI_;
		dAMFMNKHFIH_ = other.dAMFMNKHFIH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABOLGABIPJA Clone()
	{
		return new ABOLGABIPJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ABOLGABIPJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ABOLGABIPJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MLOFNLCKNBL != other.MLOFNLCKNBL)
		{
			return false;
		}
		if (AuthkeyVer != other.AuthkeyVer)
		{
			return false;
		}
		if (LDEBCMJBCLD != other.LDEBCMJBCLD)
		{
			return false;
		}
		if (NHDDHMGGKBO != other.NHDDHMGGKBO)
		{
			return false;
		}
		if (HDHJEFFIPOL != other.HDHJEFFIPOL)
		{
			return false;
		}
		if (NGCFMHKACDO != other.NGCFMHKACDO)
		{
			return false;
		}
		if (AJKHDLNMBMP != other.AJKHDLNMBMP)
		{
			return false;
		}
		if (IGJOBFGJAMI != other.IGJOBFGJAMI)
		{
			return false;
		}
		if (EBABMGKJIAF != other.EBABMGKJIAF)
		{
			return false;
		}
		if (JEBNJPNCPMP != other.JEBNJPNCPMP)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (HKEHIIPBDHA != other.HKEHIIPBDHA)
		{
			return false;
		}
		if (FLMEHIPGBJN != other.FLMEHIPGBJN)
		{
			return false;
		}
		if (EMHMHACKBOI != other.EMHMHACKBOI)
		{
			return false;
		}
		if (DDALNHLOGJK != other.DDALNHLOGJK)
		{
			return false;
		}
		if (LHHMLLFGFLI != other.LHHMLLFGFLI)
		{
			return false;
		}
		if (DAMFMNKHFIH != other.DAMFMNKHFIH)
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
		if (MLOFNLCKNBL != 0)
		{
			num ^= MLOFNLCKNBL.GetHashCode();
		}
		if (AuthkeyVer != 0)
		{
			num ^= AuthkeyVer.GetHashCode();
		}
		if (LDEBCMJBCLD != 0)
		{
			num ^= LDEBCMJBCLD.GetHashCode();
		}
		if (NHDDHMGGKBO != 0)
		{
			num ^= NHDDHMGGKBO.GetHashCode();
		}
		if (HDHJEFFIPOL != 0)
		{
			num ^= HDHJEFFIPOL.GetHashCode();
		}
		if (NGCFMHKACDO != 0)
		{
			num ^= NGCFMHKACDO.GetHashCode();
		}
		if (AJKHDLNMBMP != 0)
		{
			num ^= AJKHDLNMBMP.GetHashCode();
		}
		if (IGJOBFGJAMI != 0)
		{
			num ^= IGJOBFGJAMI.GetHashCode();
		}
		if (EBABMGKJIAF != 0L)
		{
			num ^= EBABMGKJIAF.GetHashCode();
		}
		if (JEBNJPNCPMP != 0)
		{
			num ^= JEBNJPNCPMP.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (HKEHIIPBDHA != 0)
		{
			num ^= HKEHIIPBDHA.GetHashCode();
		}
		if (FLMEHIPGBJN != 0)
		{
			num ^= FLMEHIPGBJN.GetHashCode();
		}
		if (EMHMHACKBOI.Length != 0)
		{
			num ^= EMHMHACKBOI.GetHashCode();
		}
		if (DDALNHLOGJK != 0)
		{
			num ^= DDALNHLOGJK.GetHashCode();
		}
		if (LHHMLLFGFLI != 0)
		{
			num ^= LHHMLLFGFLI.GetHashCode();
		}
		if (DAMFMNKHFIH != 0L)
		{
			num ^= DAMFMNKHFIH.GetHashCode();
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
		if (MLOFNLCKNBL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MLOFNLCKNBL);
		}
		if (AuthkeyVer != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AuthkeyVer);
		}
		if (LDEBCMJBCLD != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LDEBCMJBCLD);
		}
		if (NHDDHMGGKBO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NHDDHMGGKBO);
		}
		if (HDHJEFFIPOL != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HDHJEFFIPOL);
		}
		if (NGCFMHKACDO != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NGCFMHKACDO);
		}
		if (AJKHDLNMBMP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AJKHDLNMBMP);
		}
		if (IGJOBFGJAMI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(IGJOBFGJAMI);
		}
		if (EBABMGKJIAF != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(EBABMGKJIAF);
		}
		if (JEBNJPNCPMP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JEBNJPNCPMP);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Id);
		}
		if (HKEHIIPBDHA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HKEHIIPBDHA);
		}
		if (FLMEHIPGBJN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FLMEHIPGBJN);
		}
		if (EMHMHACKBOI.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(EMHMHACKBOI);
		}
		if (DDALNHLOGJK != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DDALNHLOGJK);
		}
		if (LHHMLLFGFLI != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(LHHMLLFGFLI);
		}
		if (DAMFMNKHFIH != 0L)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt64(DAMFMNKHFIH);
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
		if (MLOFNLCKNBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLOFNLCKNBL);
		}
		if (AuthkeyVer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AuthkeyVer);
		}
		if (LDEBCMJBCLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDEBCMJBCLD);
		}
		if (NHDDHMGGKBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHDDHMGGKBO);
		}
		if (HDHJEFFIPOL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HDHJEFFIPOL);
		}
		if (NGCFMHKACDO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGCFMHKACDO);
		}
		if (AJKHDLNMBMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AJKHDLNMBMP);
		}
		if (IGJOBFGJAMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGJOBFGJAMI);
		}
		if (EBABMGKJIAF != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EBABMGKJIAF);
		}
		if (JEBNJPNCPMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JEBNJPNCPMP);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (HKEHIIPBDHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HKEHIIPBDHA);
		}
		if (FLMEHIPGBJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLMEHIPGBJN);
		}
		if (EMHMHACKBOI.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EMHMHACKBOI);
		}
		if (DDALNHLOGJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDALNHLOGJK);
		}
		if (LHHMLLFGFLI != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(LHHMLLFGFLI);
		}
		if (DAMFMNKHFIH != 0L)
		{
			num += 2 + CodedOutputStream.ComputeUInt64Size(DAMFMNKHFIH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ABOLGABIPJA other)
	{
		if (other != null)
		{
			if (other.MLOFNLCKNBL != 0)
			{
				MLOFNLCKNBL = other.MLOFNLCKNBL;
			}
			if (other.AuthkeyVer != 0)
			{
				AuthkeyVer = other.AuthkeyVer;
			}
			if (other.LDEBCMJBCLD != 0)
			{
				LDEBCMJBCLD = other.LDEBCMJBCLD;
			}
			if (other.NHDDHMGGKBO != 0)
			{
				NHDDHMGGKBO = other.NHDDHMGGKBO;
			}
			if (other.HDHJEFFIPOL != 0)
			{
				HDHJEFFIPOL = other.HDHJEFFIPOL;
			}
			if (other.NGCFMHKACDO != 0)
			{
				NGCFMHKACDO = other.NGCFMHKACDO;
			}
			if (other.AJKHDLNMBMP != 0)
			{
				AJKHDLNMBMP = other.AJKHDLNMBMP;
			}
			if (other.IGJOBFGJAMI != 0)
			{
				IGJOBFGJAMI = other.IGJOBFGJAMI;
			}
			if (other.EBABMGKJIAF != 0L)
			{
				EBABMGKJIAF = other.EBABMGKJIAF;
			}
			if (other.JEBNJPNCPMP != 0)
			{
				JEBNJPNCPMP = other.JEBNJPNCPMP;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.HKEHIIPBDHA != 0)
			{
				HKEHIIPBDHA = other.HKEHIIPBDHA;
			}
			if (other.FLMEHIPGBJN != 0)
			{
				FLMEHIPGBJN = other.FLMEHIPGBJN;
			}
			if (other.EMHMHACKBOI.Length != 0)
			{
				EMHMHACKBOI = other.EMHMHACKBOI;
			}
			if (other.DDALNHLOGJK != 0)
			{
				DDALNHLOGJK = other.DDALNHLOGJK;
			}
			if (other.LHHMLLFGFLI != 0)
			{
				LHHMLLFGFLI = other.LHHMLLFGFLI;
			}
			if (other.DAMFMNKHFIH != 0L)
			{
				DAMFMNKHFIH = other.DAMFMNKHFIH;
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
				MLOFNLCKNBL = input.ReadUInt32();
				break;
			case 16u:
				AuthkeyVer = input.ReadUInt32();
				break;
			case 24u:
				LDEBCMJBCLD = input.ReadUInt32();
				break;
			case 32u:
				NHDDHMGGKBO = input.ReadUInt32();
				break;
			case 40u:
				HDHJEFFIPOL = input.ReadUInt32();
				break;
			case 48u:
				NGCFMHKACDO = input.ReadUInt32();
				break;
			case 56u:
				AJKHDLNMBMP = input.ReadUInt32();
				break;
			case 64u:
				IGJOBFGJAMI = input.ReadUInt32();
				break;
			case 72u:
				EBABMGKJIAF = input.ReadUInt64();
				break;
			case 80u:
				JEBNJPNCPMP = input.ReadUInt32();
				break;
			case 88u:
				Id = input.ReadUInt32();
				break;
			case 96u:
				HKEHIIPBDHA = input.ReadUInt32();
				break;
			case 104u:
				FLMEHIPGBJN = input.ReadUInt32();
				break;
			case 114u:
				EMHMHACKBOI = input.ReadString();
				break;
			case 120u:
				DDALNHLOGJK = input.ReadUInt32();
				break;
			case 128u:
				LHHMLLFGFLI = input.ReadUInt32();
				break;
			case 136u:
				DAMFMNKHFIH = input.ReadUInt64();
				break;
			}
		}
	}
}
