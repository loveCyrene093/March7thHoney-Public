using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOMINGEFPAF : IMessage<OOMINGEFPAF>, IMessage, IEquatable<OOMINGEFPAF>, IDeepCloneable<OOMINGEFPAF>, IBufferMessage
{
	private static readonly MessageParser<OOMINGEFPAF> _parser = new MessageParser<OOMINGEFPAF>(() => new OOMINGEFPAF());

	private UnknownFieldSet _unknownFields;

	public const int ChallengeIdFieldNumber = 1;

	private uint challengeId_;

	public const int PAAJDLBBIKGFieldNumber = 2;

	private uint pAAJDLBBIKG_;

	public const int IGIEHEOCMJLFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iGIEHEOCMJL_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iGIEHEOCMJL_ = new RepeatedField<uint>();

	public const int BKNPPAEOLJHFieldNumber = 5;

	private uint bKNPPAEOLJH_;

	public const int IDOIDDEHIJGFieldNumber = 6;

	private static readonly FieldCodec<ALMCIEPOODP> _repeated_iDOIDDEHIJG_codec = FieldCodec.ForMessage(50u, ALMCIEPOODP.Parser);

	private readonly RepeatedField<ALMCIEPOODP> iDOIDDEHIJG_ = new RepeatedField<ALMCIEPOODP>();

	public const int NGBACICAAPOFieldNumber = 7;

	private uint nGBACICAAPO_;

	public const int JJOGGBIOIKBFieldNumber = 12;

	private uint jJOGGBIOIKB_;

	public const int PILPAGJEENBFieldNumber = 13;

	private bool pILPAGJEENB_;

	public const int BKMEDGFOMKFFieldNumber = 14;

	private uint bKMEDGFOMKF_;

	public const int AvatarListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOMINGEFPAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOMINGEFPAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeId
	{
		get
		{
			return challengeId_;
		}
		set
		{
			challengeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PAAJDLBBIKG
	{
		get
		{
			return pAAJDLBBIKG_;
		}
		set
		{
			pAAJDLBBIKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IGIEHEOCMJL => iGIEHEOCMJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKNPPAEOLJH
	{
		get
		{
			return bKNPPAEOLJH_;
		}
		set
		{
			bKNPPAEOLJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ALMCIEPOODP> IDOIDDEHIJG => iDOIDDEHIJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGBACICAAPO
	{
		get
		{
			return nGBACICAAPO_;
		}
		set
		{
			nGBACICAAPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJOGGBIOIKB
	{
		get
		{
			return jJOGGBIOIKB_;
		}
		set
		{
			jJOGGBIOIKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PILPAGJEENB
	{
		get
		{
			return pILPAGJEENB_;
		}
		set
		{
			pILPAGJEENB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKMEDGFOMKF
	{
		get
		{
			return bKMEDGFOMKF_;
		}
		set
		{
			bKMEDGFOMKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOMINGEFPAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOMINGEFPAF(OOMINGEFPAF other)
		: this()
	{
		challengeId_ = other.challengeId_;
		pAAJDLBBIKG_ = other.pAAJDLBBIKG_;
		iGIEHEOCMJL_ = other.iGIEHEOCMJL_.Clone();
		bKNPPAEOLJH_ = other.bKNPPAEOLJH_;
		iDOIDDEHIJG_ = other.iDOIDDEHIJG_.Clone();
		nGBACICAAPO_ = other.nGBACICAAPO_;
		jJOGGBIOIKB_ = other.jJOGGBIOIKB_;
		pILPAGJEENB_ = other.pILPAGJEENB_;
		bKMEDGFOMKF_ = other.bKMEDGFOMKF_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOMINGEFPAF Clone()
	{
		return new OOMINGEFPAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOMINGEFPAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOMINGEFPAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (PAAJDLBBIKG != other.PAAJDLBBIKG)
		{
			return false;
		}
		if (!iGIEHEOCMJL_.Equals(other.iGIEHEOCMJL_))
		{
			return false;
		}
		if (BKNPPAEOLJH != other.BKNPPAEOLJH)
		{
			return false;
		}
		if (!iDOIDDEHIJG_.Equals(other.iDOIDDEHIJG_))
		{
			return false;
		}
		if (NGBACICAAPO != other.NGBACICAAPO)
		{
			return false;
		}
		if (JJOGGBIOIKB != other.JJOGGBIOIKB)
		{
			return false;
		}
		if (PILPAGJEENB != other.PILPAGJEENB)
		{
			return false;
		}
		if (BKMEDGFOMKF != other.BKMEDGFOMKF)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (PAAJDLBBIKG != 0)
		{
			num ^= PAAJDLBBIKG.GetHashCode();
		}
		num ^= iGIEHEOCMJL_.GetHashCode();
		if (BKNPPAEOLJH != 0)
		{
			num ^= BKNPPAEOLJH.GetHashCode();
		}
		num ^= iDOIDDEHIJG_.GetHashCode();
		if (NGBACICAAPO != 0)
		{
			num ^= NGBACICAAPO.GetHashCode();
		}
		if (JJOGGBIOIKB != 0)
		{
			num ^= JJOGGBIOIKB.GetHashCode();
		}
		if (PILPAGJEENB)
		{
			num ^= PILPAGJEENB.GetHashCode();
		}
		if (BKMEDGFOMKF != 0)
		{
			num ^= BKMEDGFOMKF.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (ChallengeId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ChallengeId);
		}
		if (PAAJDLBBIKG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PAAJDLBBIKG);
		}
		iGIEHEOCMJL_.WriteTo(ref output, _repeated_iGIEHEOCMJL_codec);
		if (BKNPPAEOLJH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BKNPPAEOLJH);
		}
		iDOIDDEHIJG_.WriteTo(ref output, _repeated_iDOIDDEHIJG_codec);
		if (NGBACICAAPO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NGBACICAAPO);
		}
		if (JJOGGBIOIKB != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JJOGGBIOIKB);
		}
		if (PILPAGJEENB)
		{
			output.WriteRawTag(104);
			output.WriteBool(PILPAGJEENB);
		}
		if (BKMEDGFOMKF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BKMEDGFOMKF);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (PAAJDLBBIKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PAAJDLBBIKG);
		}
		num += iGIEHEOCMJL_.CalculateSize(_repeated_iGIEHEOCMJL_codec);
		if (BKNPPAEOLJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKNPPAEOLJH);
		}
		num += iDOIDDEHIJG_.CalculateSize(_repeated_iDOIDDEHIJG_codec);
		if (NGBACICAAPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGBACICAAPO);
		}
		if (JJOGGBIOIKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJOGGBIOIKB);
		}
		if (PILPAGJEENB)
		{
			num += 2;
		}
		if (BKMEDGFOMKF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKMEDGFOMKF);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOMINGEFPAF other)
	{
		if (other != null)
		{
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.PAAJDLBBIKG != 0)
			{
				PAAJDLBBIKG = other.PAAJDLBBIKG;
			}
			iGIEHEOCMJL_.Add(other.iGIEHEOCMJL_);
			if (other.BKNPPAEOLJH != 0)
			{
				BKNPPAEOLJH = other.BKNPPAEOLJH;
			}
			iDOIDDEHIJG_.Add(other.iDOIDDEHIJG_);
			if (other.NGBACICAAPO != 0)
			{
				NGBACICAAPO = other.NGBACICAAPO;
			}
			if (other.JJOGGBIOIKB != 0)
			{
				JJOGGBIOIKB = other.JJOGGBIOIKB;
			}
			if (other.PILPAGJEENB)
			{
				PILPAGJEENB = other.PILPAGJEENB;
			}
			if (other.BKMEDGFOMKF != 0)
			{
				BKMEDGFOMKF = other.BKMEDGFOMKF;
			}
			avatarList_.Add(other.avatarList_);
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
				ChallengeId = input.ReadUInt32();
				break;
			case 16u:
				PAAJDLBBIKG = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				iGIEHEOCMJL_.AddEntriesFrom(ref input, _repeated_iGIEHEOCMJL_codec);
				break;
			case 40u:
				BKNPPAEOLJH = input.ReadUInt32();
				break;
			case 50u:
				iDOIDDEHIJG_.AddEntriesFrom(ref input, _repeated_iDOIDDEHIJG_codec);
				break;
			case 56u:
				NGBACICAAPO = input.ReadUInt32();
				break;
			case 96u:
				JJOGGBIOIKB = input.ReadUInt32();
				break;
			case 104u:
				PILPAGJEENB = input.ReadBool();
				break;
			case 112u:
				BKMEDGFOMKF = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
