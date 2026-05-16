using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IHGBDAGHDME : IMessage<IHGBDAGHDME>, IMessage, IEquatable<IHGBDAGHDME>, IDeepCloneable<IHGBDAGHDME>, IBufferMessage
{
	private static readonly MessageParser<IHGBDAGHDME> _parser = new MessageParser<IHGBDAGHDME>(() => new IHGBDAGHDME());

	private UnknownFieldSet _unknownFields;

	public const int GNAAKKMMODEFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gNAAKKMMODE_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gNAAKKMMODE_ = new RepeatedField<uint>();

	public const int AvatarListFieldNumber = 3;

	private static readonly FieldCodec<HMDLIBMBIHM> _repeated_avatarList_codec = FieldCodec.ForMessage(26u, HMDLIBMBIHM.Parser);

	private readonly RepeatedField<HMDLIBMBIHM> avatarList_ = new RepeatedField<HMDLIBMBIHM>();

	public const int DifficultyLevelFieldNumber = 4;

	private uint difficultyLevel_;

	public const int BNFHLIBFLIDFieldNumber = 5;

	private uint bNFHLIBFLID_;

	public const int LevelIdFieldNumber = 6;

	private uint levelId_;

	public const int IIDPHLIMMPFFieldNumber = 8;

	private static readonly MapField<uint, uint>.Codec _map_iIDPHLIMMPF_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 66u);

	private readonly MapField<uint, uint> iIDPHLIMMPF_ = new MapField<uint, uint>();

	public const int OMNFDNBEPLAFieldNumber = 9;

	private uint oMNFDNBEPLA_;

	public const int HEAMACGDPEKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_hEAMACGDPEK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> hEAMACGDPEK_ = new RepeatedField<uint>();

	public const int HJMGGLANHMLFieldNumber = 11;

	private uint hJMGGLANHML_;

	public const int NICNELOFHOLFieldNumber = 12;

	private uint nICNELOFHOL_;

	public const int KDBLAHBIHDOFieldNumber = 14;

	private static readonly MapField<uint, uint>.Codec _map_kDBLAHBIHDO_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 114u);

	private readonly MapField<uint, uint> kDBLAHBIHDO_ = new MapField<uint, uint>();

	public const int GNDEPOKFHPEFieldNumber = 15;

	private uint gNDEPOKFHPE_;

	public const int BNMOMHOCBPHFieldNumber = 160;

	private static readonly MapField<uint, uint>.Codec _map_bNMOMHOCBPH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 1282u);

	private readonly MapField<uint, uint> bNMOMHOCBPH_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IHGBDAGHDME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IHGBDAGHDMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GNAAKKMMODE => gNAAKKMMODE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HMDLIBMBIHM> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNFHLIBFLID
	{
		get
		{
			return bNFHLIBFLID_;
		}
		set
		{
			bNFHLIBFLID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> IIDPHLIMMPF => iIDPHLIMMPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OMNFDNBEPLA
	{
		get
		{
			return oMNFDNBEPLA_;
		}
		set
		{
			oMNFDNBEPLA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HEAMACGDPEK => hEAMACGDPEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMGGLANHML
	{
		get
		{
			return hJMGGLANHML_;
		}
		set
		{
			hJMGGLANHML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NICNELOFHOL
	{
		get
		{
			return nICNELOFHOL_;
		}
		set
		{
			nICNELOFHOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> KDBLAHBIHDO => kDBLAHBIHDO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GNDEPOKFHPE
	{
		get
		{
			return gNDEPOKFHPE_;
		}
		set
		{
			gNDEPOKFHPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BNMOMHOCBPH => bNMOMHOCBPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHGBDAGHDME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHGBDAGHDME(IHGBDAGHDME other)
		: this()
	{
		gNAAKKMMODE_ = other.gNAAKKMMODE_.Clone();
		avatarList_ = other.avatarList_.Clone();
		difficultyLevel_ = other.difficultyLevel_;
		bNFHLIBFLID_ = other.bNFHLIBFLID_;
		levelId_ = other.levelId_;
		iIDPHLIMMPF_ = other.iIDPHLIMMPF_.Clone();
		oMNFDNBEPLA_ = other.oMNFDNBEPLA_;
		hEAMACGDPEK_ = other.hEAMACGDPEK_.Clone();
		hJMGGLANHML_ = other.hJMGGLANHML_;
		nICNELOFHOL_ = other.nICNELOFHOL_;
		kDBLAHBIHDO_ = other.kDBLAHBIHDO_.Clone();
		gNDEPOKFHPE_ = other.gNDEPOKFHPE_;
		bNMOMHOCBPH_ = other.bNMOMHOCBPH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHGBDAGHDME Clone()
	{
		return new IHGBDAGHDME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IHGBDAGHDME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IHGBDAGHDME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gNAAKKMMODE_.Equals(other.gNAAKKMMODE_))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (BNFHLIBFLID != other.BNFHLIBFLID)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (!IIDPHLIMMPF.Equals(other.IIDPHLIMMPF))
		{
			return false;
		}
		if (OMNFDNBEPLA != other.OMNFDNBEPLA)
		{
			return false;
		}
		if (!hEAMACGDPEK_.Equals(other.hEAMACGDPEK_))
		{
			return false;
		}
		if (HJMGGLANHML != other.HJMGGLANHML)
		{
			return false;
		}
		if (NICNELOFHOL != other.NICNELOFHOL)
		{
			return false;
		}
		if (!KDBLAHBIHDO.Equals(other.KDBLAHBIHDO))
		{
			return false;
		}
		if (GNDEPOKFHPE != other.GNDEPOKFHPE)
		{
			return false;
		}
		if (!BNMOMHOCBPH.Equals(other.BNMOMHOCBPH))
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
		num ^= gNAAKKMMODE_.GetHashCode();
		num ^= avatarList_.GetHashCode();
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (BNFHLIBFLID != 0)
		{
			num ^= BNFHLIBFLID.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		num ^= IIDPHLIMMPF.GetHashCode();
		if (OMNFDNBEPLA != 0)
		{
			num ^= OMNFDNBEPLA.GetHashCode();
		}
		num ^= hEAMACGDPEK_.GetHashCode();
		if (HJMGGLANHML != 0)
		{
			num ^= HJMGGLANHML.GetHashCode();
		}
		if (NICNELOFHOL != 0)
		{
			num ^= NICNELOFHOL.GetHashCode();
		}
		num ^= KDBLAHBIHDO.GetHashCode();
		if (GNDEPOKFHPE != 0)
		{
			num ^= GNDEPOKFHPE.GetHashCode();
		}
		num ^= BNMOMHOCBPH.GetHashCode();
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
		gNAAKKMMODE_.WriteTo(ref output, _repeated_gNAAKKMMODE_codec);
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DifficultyLevel);
		}
		if (BNFHLIBFLID != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BNFHLIBFLID);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LevelId);
		}
		iIDPHLIMMPF_.WriteTo(ref output, _map_iIDPHLIMMPF_codec);
		if (OMNFDNBEPLA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OMNFDNBEPLA);
		}
		hEAMACGDPEK_.WriteTo(ref output, _repeated_hEAMACGDPEK_codec);
		if (HJMGGLANHML != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HJMGGLANHML);
		}
		if (NICNELOFHOL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NICNELOFHOL);
		}
		kDBLAHBIHDO_.WriteTo(ref output, _map_kDBLAHBIHDO_codec);
		if (GNDEPOKFHPE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GNDEPOKFHPE);
		}
		bNMOMHOCBPH_.WriteTo(ref output, _map_bNMOMHOCBPH_codec);
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
		num += gNAAKKMMODE_.CalculateSize(_repeated_gNAAKKMMODE_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (BNFHLIBFLID != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNFHLIBFLID);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		num += iIDPHLIMMPF_.CalculateSize(_map_iIDPHLIMMPF_codec);
		if (OMNFDNBEPLA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OMNFDNBEPLA);
		}
		num += hEAMACGDPEK_.CalculateSize(_repeated_hEAMACGDPEK_codec);
		if (HJMGGLANHML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMGGLANHML);
		}
		if (NICNELOFHOL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NICNELOFHOL);
		}
		num += kDBLAHBIHDO_.CalculateSize(_map_kDBLAHBIHDO_codec);
		if (GNDEPOKFHPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GNDEPOKFHPE);
		}
		num += bNMOMHOCBPH_.CalculateSize(_map_bNMOMHOCBPH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IHGBDAGHDME other)
	{
		if (other != null)
		{
			gNAAKKMMODE_.Add(other.gNAAKKMMODE_);
			avatarList_.Add(other.avatarList_);
			if (other.DifficultyLevel != 0)
			{
				DifficultyLevel = other.DifficultyLevel;
			}
			if (other.BNFHLIBFLID != 0)
			{
				BNFHLIBFLID = other.BNFHLIBFLID;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			iIDPHLIMMPF_.MergeFrom(other.iIDPHLIMMPF_);
			if (other.OMNFDNBEPLA != 0)
			{
				OMNFDNBEPLA = other.OMNFDNBEPLA;
			}
			hEAMACGDPEK_.Add(other.hEAMACGDPEK_);
			if (other.HJMGGLANHML != 0)
			{
				HJMGGLANHML = other.HJMGGLANHML;
			}
			if (other.NICNELOFHOL != 0)
			{
				NICNELOFHOL = other.NICNELOFHOL;
			}
			kDBLAHBIHDO_.MergeFrom(other.kDBLAHBIHDO_);
			if (other.GNDEPOKFHPE != 0)
			{
				GNDEPOKFHPE = other.GNDEPOKFHPE;
			}
			bNMOMHOCBPH_.MergeFrom(other.bNMOMHOCBPH_);
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
			case 16u:
			case 18u:
				gNAAKKMMODE_.AddEntriesFrom(ref input, _repeated_gNAAKKMMODE_codec);
				break;
			case 26u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 32u:
				DifficultyLevel = input.ReadUInt32();
				break;
			case 40u:
				BNFHLIBFLID = input.ReadUInt32();
				break;
			case 48u:
				LevelId = input.ReadUInt32();
				break;
			case 66u:
				iIDPHLIMMPF_.AddEntriesFrom(ref input, _map_iIDPHLIMMPF_codec);
				break;
			case 72u:
				OMNFDNBEPLA = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				hEAMACGDPEK_.AddEntriesFrom(ref input, _repeated_hEAMACGDPEK_codec);
				break;
			case 88u:
				HJMGGLANHML = input.ReadUInt32();
				break;
			case 96u:
				NICNELOFHOL = input.ReadUInt32();
				break;
			case 114u:
				kDBLAHBIHDO_.AddEntriesFrom(ref input, _map_kDBLAHBIHDO_codec);
				break;
			case 120u:
				GNDEPOKFHPE = input.ReadUInt32();
				break;
			case 1282u:
				bNMOMHOCBPH_.AddEntriesFrom(ref input, _map_bNMOMHOCBPH_codec);
				break;
			}
		}
	}
}
