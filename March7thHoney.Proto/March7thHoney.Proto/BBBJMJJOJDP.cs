using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBBJMJJOJDP : IMessage<BBBJMJJOJDP>, IMessage, IEquatable<BBBJMJJOJDP>, IDeepCloneable<BBBJMJJOJDP>, IBufferMessage
{
	private static readonly MessageParser<BBBJMJJOJDP> _parser = new MessageParser<BBBJMJJOJDP>(() => new BBBJMJJOJDP());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private string roomId_ = "";

	public const int JAFNCOMGABGFieldNumber = 2;

	private uint jAFNCOMGABG_;

	public const int SectionIdFieldNumber = 3;

	private uint sectionId_;

	public const int BICBJMPAAANFieldNumber = 4;

	private uint bICBJMPAAAN_;

	public const int AGOODNEGKBAFieldNumber = 5;

	private uint aGOODNEGKBA_;

	public const int FCKNPGPHCELFieldNumber = 6;

	private uint fCKNPGPHCEL_;

	public const int CONJDDKAFKOFieldNumber = 7;

	private static readonly FieldCodec<EMBCNJNGMKI> _repeated_cONJDDKAFKO_codec = FieldCodec.ForMessage(58u, EMBCNJNGMKI.Parser);

	private readonly RepeatedField<EMBCNJNGMKI> cONJDDKAFKO_ = new RepeatedField<EMBCNJNGMKI>();

	public const int LODDNBBEFKBFieldNumber = 8;

	private uint lODDNBBEFKB_;

	public const int OGKNEBGDEFNFieldNumber = 9;

	private uint oGKNEBGDEFN_;

	public const int ODFMPNINDELFieldNumber = 10;

	private float oDFMPNINDEL_;

	public const int AMIBFOEAJGLFieldNumber = 11;

	private int aMIBFOEAJGL_;

	public const int FHJFFLDHJGJFieldNumber = 12;

	private int fHJFFLDHJGJ_;

	public const int NGCACDGALBIFieldNumber = 13;

	private int nGCACDGALBI_;

	public const int OEEJPPJGKDIFieldNumber = 14;

	private uint oEEJPPJGKDI_;

	public const int AGDPOMEMMNBFieldNumber = 15;

	private int aGDPOMEMMNB_;

	public const int IFLBGGLOPLFFieldNumber = 16;

	private int iFLBGGLOPLF_;

	public const int GFDLPEIOCOGFieldNumber = 17;

	private uint gFDLPEIOCOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBBJMJJOJDP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBBJMJJOJDPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
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
	public uint BICBJMPAAAN
	{
		get
		{
			return bICBJMPAAAN_;
		}
		set
		{
			bICBJMPAAAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AGOODNEGKBA
	{
		get
		{
			return aGOODNEGKBA_;
		}
		set
		{
			aGOODNEGKBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCKNPGPHCEL
	{
		get
		{
			return fCKNPGPHCEL_;
		}
		set
		{
			fCKNPGPHCEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EMBCNJNGMKI> CONJDDKAFKO => cONJDDKAFKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LODDNBBEFKB
	{
		get
		{
			return lODDNBBEFKB_;
		}
		set
		{
			lODDNBBEFKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGKNEBGDEFN
	{
		get
		{
			return oGKNEBGDEFN_;
		}
		set
		{
			oGKNEBGDEFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float ODFMPNINDEL
	{
		get
		{
			return oDFMPNINDEL_;
		}
		set
		{
			oDFMPNINDEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AMIBFOEAJGL
	{
		get
		{
			return aMIBFOEAJGL_;
		}
		set
		{
			aMIBFOEAJGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FHJFFLDHJGJ
	{
		get
		{
			return fHJFFLDHJGJ_;
		}
		set
		{
			fHJFFLDHJGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NGCACDGALBI
	{
		get
		{
			return nGCACDGALBI_;
		}
		set
		{
			nGCACDGALBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OEEJPPJGKDI
	{
		get
		{
			return oEEJPPJGKDI_;
		}
		set
		{
			oEEJPPJGKDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AGDPOMEMMNB
	{
		get
		{
			return aGDPOMEMMNB_;
		}
		set
		{
			aGDPOMEMMNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IFLBGGLOPLF
	{
		get
		{
			return iFLBGGLOPLF_;
		}
		set
		{
			iFLBGGLOPLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFDLPEIOCOG
	{
		get
		{
			return gFDLPEIOCOG_;
		}
		set
		{
			gFDLPEIOCOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBBJMJJOJDP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBBJMJJOJDP(BBBJMJJOJDP other)
		: this()
	{
		roomId_ = other.roomId_;
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		sectionId_ = other.sectionId_;
		bICBJMPAAAN_ = other.bICBJMPAAAN_;
		aGOODNEGKBA_ = other.aGOODNEGKBA_;
		fCKNPGPHCEL_ = other.fCKNPGPHCEL_;
		cONJDDKAFKO_ = other.cONJDDKAFKO_.Clone();
		lODDNBBEFKB_ = other.lODDNBBEFKB_;
		oGKNEBGDEFN_ = other.oGKNEBGDEFN_;
		oDFMPNINDEL_ = other.oDFMPNINDEL_;
		aMIBFOEAJGL_ = other.aMIBFOEAJGL_;
		fHJFFLDHJGJ_ = other.fHJFFLDHJGJ_;
		nGCACDGALBI_ = other.nGCACDGALBI_;
		oEEJPPJGKDI_ = other.oEEJPPJGKDI_;
		aGDPOMEMMNB_ = other.aGDPOMEMMNB_;
		iFLBGGLOPLF_ = other.iFLBGGLOPLF_;
		gFDLPEIOCOG_ = other.gFDLPEIOCOG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBBJMJJOJDP Clone()
	{
		return new BBBJMJJOJDP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBBJMJJOJDP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBBJMJJOJDP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (BICBJMPAAAN != other.BICBJMPAAAN)
		{
			return false;
		}
		if (AGOODNEGKBA != other.AGOODNEGKBA)
		{
			return false;
		}
		if (FCKNPGPHCEL != other.FCKNPGPHCEL)
		{
			return false;
		}
		if (!cONJDDKAFKO_.Equals(other.cONJDDKAFKO_))
		{
			return false;
		}
		if (LODDNBBEFKB != other.LODDNBBEFKB)
		{
			return false;
		}
		if (OGKNEBGDEFN != other.OGKNEBGDEFN)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ODFMPNINDEL, other.ODFMPNINDEL))
		{
			return false;
		}
		if (AMIBFOEAJGL != other.AMIBFOEAJGL)
		{
			return false;
		}
		if (FHJFFLDHJGJ != other.FHJFFLDHJGJ)
		{
			return false;
		}
		if (NGCACDGALBI != other.NGCACDGALBI)
		{
			return false;
		}
		if (OEEJPPJGKDI != other.OEEJPPJGKDI)
		{
			return false;
		}
		if (AGDPOMEMMNB != other.AGDPOMEMMNB)
		{
			return false;
		}
		if (IFLBGGLOPLF != other.IFLBGGLOPLF)
		{
			return false;
		}
		if (GFDLPEIOCOG != other.GFDLPEIOCOG)
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
		if (RoomId.Length != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (BICBJMPAAAN != 0)
		{
			num ^= BICBJMPAAAN.GetHashCode();
		}
		if (AGOODNEGKBA != 0)
		{
			num ^= AGOODNEGKBA.GetHashCode();
		}
		if (FCKNPGPHCEL != 0)
		{
			num ^= FCKNPGPHCEL.GetHashCode();
		}
		num ^= cONJDDKAFKO_.GetHashCode();
		if (LODDNBBEFKB != 0)
		{
			num ^= LODDNBBEFKB.GetHashCode();
		}
		if (OGKNEBGDEFN != 0)
		{
			num ^= OGKNEBGDEFN.GetHashCode();
		}
		if (ODFMPNINDEL != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ODFMPNINDEL);
		}
		if (AMIBFOEAJGL != 0)
		{
			num ^= AMIBFOEAJGL.GetHashCode();
		}
		if (FHJFFLDHJGJ != 0)
		{
			num ^= FHJFFLDHJGJ.GetHashCode();
		}
		if (NGCACDGALBI != 0)
		{
			num ^= NGCACDGALBI.GetHashCode();
		}
		if (OEEJPPJGKDI != 0)
		{
			num ^= OEEJPPJGKDI.GetHashCode();
		}
		if (AGDPOMEMMNB != 0)
		{
			num ^= AGDPOMEMMNB.GetHashCode();
		}
		if (IFLBGGLOPLF != 0)
		{
			num ^= IFLBGGLOPLF.GetHashCode();
		}
		if (GFDLPEIOCOG != 0)
		{
			num ^= GFDLPEIOCOG.GetHashCode();
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
		if (RoomId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RoomId);
		}
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SectionId);
		}
		if (BICBJMPAAAN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BICBJMPAAAN);
		}
		if (AGOODNEGKBA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AGOODNEGKBA);
		}
		if (FCKNPGPHCEL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(FCKNPGPHCEL);
		}
		cONJDDKAFKO_.WriteTo(ref output, _repeated_cONJDDKAFKO_codec);
		if (LODDNBBEFKB != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LODDNBBEFKB);
		}
		if (OGKNEBGDEFN != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OGKNEBGDEFN);
		}
		if (ODFMPNINDEL != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(ODFMPNINDEL);
		}
		if (AMIBFOEAJGL != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(AMIBFOEAJGL);
		}
		if (FHJFFLDHJGJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(FHJFFLDHJGJ);
		}
		if (NGCACDGALBI != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(NGCACDGALBI);
		}
		if (OEEJPPJGKDI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OEEJPPJGKDI);
		}
		if (AGDPOMEMMNB != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(AGDPOMEMMNB);
		}
		if (IFLBGGLOPLF != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(IFLBGGLOPLF);
		}
		if (GFDLPEIOCOG != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(GFDLPEIOCOG);
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
		if (RoomId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoomId);
		}
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (BICBJMPAAAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BICBJMPAAAN);
		}
		if (AGOODNEGKBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AGOODNEGKBA);
		}
		if (FCKNPGPHCEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCKNPGPHCEL);
		}
		num += cONJDDKAFKO_.CalculateSize(_repeated_cONJDDKAFKO_codec);
		if (LODDNBBEFKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LODDNBBEFKB);
		}
		if (OGKNEBGDEFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGKNEBGDEFN);
		}
		if (ODFMPNINDEL != 0f)
		{
			num += 5;
		}
		if (AMIBFOEAJGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AMIBFOEAJGL);
		}
		if (FHJFFLDHJGJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FHJFFLDHJGJ);
		}
		if (NGCACDGALBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NGCACDGALBI);
		}
		if (OEEJPPJGKDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OEEJPPJGKDI);
		}
		if (AGDPOMEMMNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AGDPOMEMMNB);
		}
		if (IFLBGGLOPLF != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IFLBGGLOPLF);
		}
		if (GFDLPEIOCOG != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(GFDLPEIOCOG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBBJMJJOJDP other)
	{
		if (other != null)
		{
			if (other.RoomId.Length != 0)
			{
				RoomId = other.RoomId;
			}
			if (other.JAFNCOMGABG != 0)
			{
				JAFNCOMGABG = other.JAFNCOMGABG;
			}
			if (other.SectionId != 0)
			{
				SectionId = other.SectionId;
			}
			if (other.BICBJMPAAAN != 0)
			{
				BICBJMPAAAN = other.BICBJMPAAAN;
			}
			if (other.AGOODNEGKBA != 0)
			{
				AGOODNEGKBA = other.AGOODNEGKBA;
			}
			if (other.FCKNPGPHCEL != 0)
			{
				FCKNPGPHCEL = other.FCKNPGPHCEL;
			}
			cONJDDKAFKO_.Add(other.cONJDDKAFKO_);
			if (other.LODDNBBEFKB != 0)
			{
				LODDNBBEFKB = other.LODDNBBEFKB;
			}
			if (other.OGKNEBGDEFN != 0)
			{
				OGKNEBGDEFN = other.OGKNEBGDEFN;
			}
			if (other.ODFMPNINDEL != 0f)
			{
				ODFMPNINDEL = other.ODFMPNINDEL;
			}
			if (other.AMIBFOEAJGL != 0)
			{
				AMIBFOEAJGL = other.AMIBFOEAJGL;
			}
			if (other.FHJFFLDHJGJ != 0)
			{
				FHJFFLDHJGJ = other.FHJFFLDHJGJ;
			}
			if (other.NGCACDGALBI != 0)
			{
				NGCACDGALBI = other.NGCACDGALBI;
			}
			if (other.OEEJPPJGKDI != 0)
			{
				OEEJPPJGKDI = other.OEEJPPJGKDI;
			}
			if (other.AGDPOMEMMNB != 0)
			{
				AGDPOMEMMNB = other.AGDPOMEMMNB;
			}
			if (other.IFLBGGLOPLF != 0)
			{
				IFLBGGLOPLF = other.IFLBGGLOPLF;
			}
			if (other.GFDLPEIOCOG != 0)
			{
				GFDLPEIOCOG = other.GFDLPEIOCOG;
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
				RoomId = input.ReadString();
				break;
			case 16u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 24u:
				SectionId = input.ReadUInt32();
				break;
			case 32u:
				BICBJMPAAAN = input.ReadUInt32();
				break;
			case 40u:
				AGOODNEGKBA = input.ReadUInt32();
				break;
			case 48u:
				FCKNPGPHCEL = input.ReadUInt32();
				break;
			case 58u:
				cONJDDKAFKO_.AddEntriesFrom(ref input, _repeated_cONJDDKAFKO_codec);
				break;
			case 64u:
				LODDNBBEFKB = input.ReadUInt32();
				break;
			case 72u:
				OGKNEBGDEFN = input.ReadUInt32();
				break;
			case 85u:
				ODFMPNINDEL = input.ReadFloat();
				break;
			case 88u:
				AMIBFOEAJGL = input.ReadInt32();
				break;
			case 96u:
				FHJFFLDHJGJ = input.ReadInt32();
				break;
			case 104u:
				NGCACDGALBI = input.ReadInt32();
				break;
			case 112u:
				OEEJPPJGKDI = input.ReadUInt32();
				break;
			case 120u:
				AGDPOMEMMNB = input.ReadInt32();
				break;
			case 128u:
				IFLBGGLOPLF = input.ReadInt32();
				break;
			case 136u:
				GFDLPEIOCOG = input.ReadUInt32();
				break;
			}
		}
	}
}
