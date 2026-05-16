using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLOIKLNHBLN : IMessage<GLOIKLNHBLN>, IMessage, IEquatable<GLOIKLNHBLN>, IDeepCloneable<GLOIKLNHBLN>, IBufferMessage
{
	private static readonly MessageParser<GLOIKLNHBLN> _parser = new MessageParser<GLOIKLNHBLN>(() => new GLOIKLNHBLN());

	private UnknownFieldSet _unknownFields;

	public const int HBMJNOGHLBHFieldNumber = 1;

	private uint hBMJNOGHLBH_;

	public const int CFCEICJLJDHFieldNumber = 2;

	private uint cFCEICJLJDH_;

	public const int AAECKPNAHJNFieldNumber = 3;

	private uint aAECKPNAHJN_;

	public const int AICEKNALKBLFieldNumber = 4;

	private uint aICEKNALKBL_;

	public const int KMNHAMMLGJMFieldNumber = 6;

	private uint kMNHAMMLGJM_;

	public const int DMKNEIEKILNFieldNumber = 8;

	private uint dMKNEIEKILN_;

	public const int BEOAPNBFOCIFieldNumber = 11;

	private uint bEOAPNBFOCI_;

	public const int AEDMPNIAPCJFieldNumber = 12;

	private uint aEDMPNIAPCJ_;

	public const int IOABJKMGIOMFieldNumber = 13;

	private uint iOABJKMGIOM_;

	public const int OACBALDOFPCFieldNumber = 14;

	private uint oACBALDOFPC_;

	public const int FHHLKGCLHBDFieldNumber = 15;

	private static readonly FieldCodec<GLEFCCGNKDE> _repeated_fHHLKGCLHBD_codec = FieldCodec.ForMessage(122u, GLEFCCGNKDE.Parser);

	private readonly RepeatedField<GLEFCCGNKDE> fHHLKGCLHBD_ = new RepeatedField<GLEFCCGNKDE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLOIKLNHBLN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLOIKLNHBLNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBMJNOGHLBH
	{
		get
		{
			return hBMJNOGHLBH_;
		}
		set
		{
			hBMJNOGHLBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CFCEICJLJDH
	{
		get
		{
			return cFCEICJLJDH_;
		}
		set
		{
			cFCEICJLJDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAECKPNAHJN
	{
		get
		{
			return aAECKPNAHJN_;
		}
		set
		{
			aAECKPNAHJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AICEKNALKBL
	{
		get
		{
			return aICEKNALKBL_;
		}
		set
		{
			aICEKNALKBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KMNHAMMLGJM
	{
		get
		{
			return kMNHAMMLGJM_;
		}
		set
		{
			kMNHAMMLGJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMKNEIEKILN
	{
		get
		{
			return dMKNEIEKILN_;
		}
		set
		{
			dMKNEIEKILN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEOAPNBFOCI
	{
		get
		{
			return bEOAPNBFOCI_;
		}
		set
		{
			bEOAPNBFOCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AEDMPNIAPCJ
	{
		get
		{
			return aEDMPNIAPCJ_;
		}
		set
		{
			aEDMPNIAPCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IOABJKMGIOM
	{
		get
		{
			return iOABJKMGIOM_;
		}
		set
		{
			iOABJKMGIOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OACBALDOFPC
	{
		get
		{
			return oACBALDOFPC_;
		}
		set
		{
			oACBALDOFPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GLEFCCGNKDE> FHHLKGCLHBD => fHHLKGCLHBD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOIKLNHBLN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOIKLNHBLN(GLOIKLNHBLN other)
		: this()
	{
		hBMJNOGHLBH_ = other.hBMJNOGHLBH_;
		cFCEICJLJDH_ = other.cFCEICJLJDH_;
		aAECKPNAHJN_ = other.aAECKPNAHJN_;
		aICEKNALKBL_ = other.aICEKNALKBL_;
		kMNHAMMLGJM_ = other.kMNHAMMLGJM_;
		dMKNEIEKILN_ = other.dMKNEIEKILN_;
		bEOAPNBFOCI_ = other.bEOAPNBFOCI_;
		aEDMPNIAPCJ_ = other.aEDMPNIAPCJ_;
		iOABJKMGIOM_ = other.iOABJKMGIOM_;
		oACBALDOFPC_ = other.oACBALDOFPC_;
		fHHLKGCLHBD_ = other.fHHLKGCLHBD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOIKLNHBLN Clone()
	{
		return new GLOIKLNHBLN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLOIKLNHBLN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLOIKLNHBLN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBMJNOGHLBH != other.HBMJNOGHLBH)
		{
			return false;
		}
		if (CFCEICJLJDH != other.CFCEICJLJDH)
		{
			return false;
		}
		if (AAECKPNAHJN != other.AAECKPNAHJN)
		{
			return false;
		}
		if (AICEKNALKBL != other.AICEKNALKBL)
		{
			return false;
		}
		if (KMNHAMMLGJM != other.KMNHAMMLGJM)
		{
			return false;
		}
		if (DMKNEIEKILN != other.DMKNEIEKILN)
		{
			return false;
		}
		if (BEOAPNBFOCI != other.BEOAPNBFOCI)
		{
			return false;
		}
		if (AEDMPNIAPCJ != other.AEDMPNIAPCJ)
		{
			return false;
		}
		if (IOABJKMGIOM != other.IOABJKMGIOM)
		{
			return false;
		}
		if (OACBALDOFPC != other.OACBALDOFPC)
		{
			return false;
		}
		if (!fHHLKGCLHBD_.Equals(other.fHHLKGCLHBD_))
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
		if (HBMJNOGHLBH != 0)
		{
			num ^= HBMJNOGHLBH.GetHashCode();
		}
		if (CFCEICJLJDH != 0)
		{
			num ^= CFCEICJLJDH.GetHashCode();
		}
		if (AAECKPNAHJN != 0)
		{
			num ^= AAECKPNAHJN.GetHashCode();
		}
		if (AICEKNALKBL != 0)
		{
			num ^= AICEKNALKBL.GetHashCode();
		}
		if (KMNHAMMLGJM != 0)
		{
			num ^= KMNHAMMLGJM.GetHashCode();
		}
		if (DMKNEIEKILN != 0)
		{
			num ^= DMKNEIEKILN.GetHashCode();
		}
		if (BEOAPNBFOCI != 0)
		{
			num ^= BEOAPNBFOCI.GetHashCode();
		}
		if (AEDMPNIAPCJ != 0)
		{
			num ^= AEDMPNIAPCJ.GetHashCode();
		}
		if (IOABJKMGIOM != 0)
		{
			num ^= IOABJKMGIOM.GetHashCode();
		}
		if (OACBALDOFPC != 0)
		{
			num ^= OACBALDOFPC.GetHashCode();
		}
		num ^= fHHLKGCLHBD_.GetHashCode();
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
		if (HBMJNOGHLBH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HBMJNOGHLBH);
		}
		if (CFCEICJLJDH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CFCEICJLJDH);
		}
		if (AAECKPNAHJN != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AAECKPNAHJN);
		}
		if (AICEKNALKBL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AICEKNALKBL);
		}
		if (KMNHAMMLGJM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KMNHAMMLGJM);
		}
		if (DMKNEIEKILN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DMKNEIEKILN);
		}
		if (BEOAPNBFOCI != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BEOAPNBFOCI);
		}
		if (AEDMPNIAPCJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AEDMPNIAPCJ);
		}
		if (IOABJKMGIOM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IOABJKMGIOM);
		}
		if (OACBALDOFPC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OACBALDOFPC);
		}
		fHHLKGCLHBD_.WriteTo(ref output, _repeated_fHHLKGCLHBD_codec);
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
		if (HBMJNOGHLBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBMJNOGHLBH);
		}
		if (CFCEICJLJDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CFCEICJLJDH);
		}
		if (AAECKPNAHJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAECKPNAHJN);
		}
		if (AICEKNALKBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AICEKNALKBL);
		}
		if (KMNHAMMLGJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KMNHAMMLGJM);
		}
		if (DMKNEIEKILN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMKNEIEKILN);
		}
		if (BEOAPNBFOCI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEOAPNBFOCI);
		}
		if (AEDMPNIAPCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AEDMPNIAPCJ);
		}
		if (IOABJKMGIOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IOABJKMGIOM);
		}
		if (OACBALDOFPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OACBALDOFPC);
		}
		num += fHHLKGCLHBD_.CalculateSize(_repeated_fHHLKGCLHBD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GLOIKLNHBLN other)
	{
		if (other != null)
		{
			if (other.HBMJNOGHLBH != 0)
			{
				HBMJNOGHLBH = other.HBMJNOGHLBH;
			}
			if (other.CFCEICJLJDH != 0)
			{
				CFCEICJLJDH = other.CFCEICJLJDH;
			}
			if (other.AAECKPNAHJN != 0)
			{
				AAECKPNAHJN = other.AAECKPNAHJN;
			}
			if (other.AICEKNALKBL != 0)
			{
				AICEKNALKBL = other.AICEKNALKBL;
			}
			if (other.KMNHAMMLGJM != 0)
			{
				KMNHAMMLGJM = other.KMNHAMMLGJM;
			}
			if (other.DMKNEIEKILN != 0)
			{
				DMKNEIEKILN = other.DMKNEIEKILN;
			}
			if (other.BEOAPNBFOCI != 0)
			{
				BEOAPNBFOCI = other.BEOAPNBFOCI;
			}
			if (other.AEDMPNIAPCJ != 0)
			{
				AEDMPNIAPCJ = other.AEDMPNIAPCJ;
			}
			if (other.IOABJKMGIOM != 0)
			{
				IOABJKMGIOM = other.IOABJKMGIOM;
			}
			if (other.OACBALDOFPC != 0)
			{
				OACBALDOFPC = other.OACBALDOFPC;
			}
			fHHLKGCLHBD_.Add(other.fHHLKGCLHBD_);
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
				HBMJNOGHLBH = input.ReadUInt32();
				break;
			case 16u:
				CFCEICJLJDH = input.ReadUInt32();
				break;
			case 24u:
				AAECKPNAHJN = input.ReadUInt32();
				break;
			case 32u:
				AICEKNALKBL = input.ReadUInt32();
				break;
			case 48u:
				KMNHAMMLGJM = input.ReadUInt32();
				break;
			case 64u:
				DMKNEIEKILN = input.ReadUInt32();
				break;
			case 88u:
				BEOAPNBFOCI = input.ReadUInt32();
				break;
			case 96u:
				AEDMPNIAPCJ = input.ReadUInt32();
				break;
			case 104u:
				IOABJKMGIOM = input.ReadUInt32();
				break;
			case 112u:
				OACBALDOFPC = input.ReadUInt32();
				break;
			case 122u:
				fHHLKGCLHBD_.AddEntriesFrom(ref input, _repeated_fHHLKGCLHBD_codec);
				break;
			}
		}
	}
}
