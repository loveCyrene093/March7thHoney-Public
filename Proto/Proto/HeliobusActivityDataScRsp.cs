using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusActivityDataScRsp : IMessage<HeliobusActivityDataScRsp>, IMessage, IEquatable<HeliobusActivityDataScRsp>, IDeepCloneable<HeliobusActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<HeliobusActivityDataScRsp> _parser = new MessageParser<HeliobusActivityDataScRsp>(() => new HeliobusActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CHGNKDNFNLFFieldNumber = 1;

	private static readonly FieldCodec<HeliobusChallengeLineup> _repeated_cHGNKDNFNLF_codec = FieldCodec.ForMessage(10u, HeliobusChallengeLineup.Parser);

	private readonly RepeatedField<HeliobusChallengeLineup> cHGNKDNFNLF_ = new RepeatedField<HeliobusChallengeLineup>();

	public const int IMBOKGFIACAFieldNumber = 2;

	private uint iMBOKGFIACA_;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int PhaseFieldNumber = 5;

	private uint phase_;

	public const int DKOGNOKOPKGFieldNumber = 9;

	private uint dKOGNOKOPKG_;

	public const int ChallengeListFieldNumber = 10;

	private static readonly FieldCodec<HeliobusChallengeData> _repeated_challengeList_codec = FieldCodec.ForMessage(82u, HeliobusChallengeData.Parser);

	private readonly RepeatedField<HeliobusChallengeData> challengeList_ = new RepeatedField<HeliobusChallengeData>();

	public const int GCDLCPMFLMHFieldNumber = 11;

	private uint gCDLCPMFLMH_;

	public const int SkillInfoFieldNumber = 12;

	private FJCDAKICFKA skillInfo_;

	public const int LPMIHBLOIAKFieldNumber = 15;

	private static readonly FieldCodec<DLFOGJGCCGP> _repeated_lPMIHBLOIAK_codec = FieldCodec.ForMessage(122u, DLFOGJGCCGP.Parser);

	private readonly RepeatedField<DLFOGJGCCGP> lPMIHBLOIAK_ = new RepeatedField<DLFOGJGCCGP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HeliobusChallengeLineup> CHGNKDNFNLF => cHGNKDNFNLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMBOKGFIACA
	{
		get
		{
			return iMBOKGFIACA_;
		}
		set
		{
			iMBOKGFIACA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Phase
	{
		get
		{
			return phase_;
		}
		set
		{
			phase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKOGNOKOPKG
	{
		get
		{
			return dKOGNOKOPKG_;
		}
		set
		{
			dKOGNOKOPKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HeliobusChallengeData> ChallengeList => challengeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCDLCPMFLMH
	{
		get
		{
			return gCDLCPMFLMH_;
		}
		set
		{
			gCDLCPMFLMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJCDAKICFKA SkillInfo
	{
		get
		{
			return skillInfo_;
		}
		set
		{
			skillInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DLFOGJGCCGP> LPMIHBLOIAK => lPMIHBLOIAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusActivityDataScRsp(HeliobusActivityDataScRsp other)
		: this()
	{
		cHGNKDNFNLF_ = other.cHGNKDNFNLF_.Clone();
		iMBOKGFIACA_ = other.iMBOKGFIACA_;
		level_ = other.level_;
		retcode_ = other.retcode_;
		phase_ = other.phase_;
		dKOGNOKOPKG_ = other.dKOGNOKOPKG_;
		challengeList_ = other.challengeList_.Clone();
		gCDLCPMFLMH_ = other.gCDLCPMFLMH_;
		skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
		lPMIHBLOIAK_ = other.lPMIHBLOIAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusActivityDataScRsp Clone()
	{
		return new HeliobusActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cHGNKDNFNLF_.Equals(other.cHGNKDNFNLF_))
		{
			return false;
		}
		if (IMBOKGFIACA != other.IMBOKGFIACA)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Phase != other.Phase)
		{
			return false;
		}
		if (DKOGNOKOPKG != other.DKOGNOKOPKG)
		{
			return false;
		}
		if (!challengeList_.Equals(other.challengeList_))
		{
			return false;
		}
		if (GCDLCPMFLMH != other.GCDLCPMFLMH)
		{
			return false;
		}
		if (!object.Equals(SkillInfo, other.SkillInfo))
		{
			return false;
		}
		if (!lPMIHBLOIAK_.Equals(other.lPMIHBLOIAK_))
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
		num ^= cHGNKDNFNLF_.GetHashCode();
		if (IMBOKGFIACA != 0)
		{
			num ^= IMBOKGFIACA.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Phase != 0)
		{
			num ^= Phase.GetHashCode();
		}
		if (DKOGNOKOPKG != 0)
		{
			num ^= DKOGNOKOPKG.GetHashCode();
		}
		num ^= challengeList_.GetHashCode();
		if (GCDLCPMFLMH != 0)
		{
			num ^= GCDLCPMFLMH.GetHashCode();
		}
		if (skillInfo_ != null)
		{
			num ^= SkillInfo.GetHashCode();
		}
		num ^= lPMIHBLOIAK_.GetHashCode();
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
		cHGNKDNFNLF_.WriteTo(ref output, _repeated_cHGNKDNFNLF_codec);
		if (IMBOKGFIACA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IMBOKGFIACA);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (Phase != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Phase);
		}
		if (DKOGNOKOPKG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DKOGNOKOPKG);
		}
		challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
		if (GCDLCPMFLMH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GCDLCPMFLMH);
		}
		if (skillInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(SkillInfo);
		}
		lPMIHBLOIAK_.WriteTo(ref output, _repeated_lPMIHBLOIAK_codec);
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
		num += cHGNKDNFNLF_.CalculateSize(_repeated_cHGNKDNFNLF_codec);
		if (IMBOKGFIACA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMBOKGFIACA);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Phase != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Phase);
		}
		if (DKOGNOKOPKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKOGNOKOPKG);
		}
		num += challengeList_.CalculateSize(_repeated_challengeList_codec);
		if (GCDLCPMFLMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCDLCPMFLMH);
		}
		if (skillInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SkillInfo);
		}
		num += lPMIHBLOIAK_.CalculateSize(_repeated_lPMIHBLOIAK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusActivityDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		cHGNKDNFNLF_.Add(other.cHGNKDNFNLF_);
		if (other.IMBOKGFIACA != 0)
		{
			IMBOKGFIACA = other.IMBOKGFIACA;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.Phase != 0)
		{
			Phase = other.Phase;
		}
		if (other.DKOGNOKOPKG != 0)
		{
			DKOGNOKOPKG = other.DKOGNOKOPKG;
		}
		challengeList_.Add(other.challengeList_);
		if (other.GCDLCPMFLMH != 0)
		{
			GCDLCPMFLMH = other.GCDLCPMFLMH;
		}
		if (other.skillInfo_ != null)
		{
			if (skillInfo_ == null)
			{
				SkillInfo = new FJCDAKICFKA();
			}
			SkillInfo.MergeFrom(other.SkillInfo);
		}
		lPMIHBLOIAK_.Add(other.lPMIHBLOIAK_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				cHGNKDNFNLF_.AddEntriesFrom(ref input, _repeated_cHGNKDNFNLF_codec);
				break;
			case 16u:
				IMBOKGFIACA = input.ReadUInt32();
				break;
			case 24u:
				Level = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				Phase = input.ReadUInt32();
				break;
			case 72u:
				DKOGNOKOPKG = input.ReadUInt32();
				break;
			case 82u:
				challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
				break;
			case 88u:
				GCDLCPMFLMH = input.ReadUInt32();
				break;
			case 98u:
				if (skillInfo_ == null)
				{
					SkillInfo = new FJCDAKICFKA();
				}
				input.ReadMessage(SkillInfo);
				break;
			case 122u:
				lPMIHBLOIAK_.AddEntriesFrom(ref input, _repeated_lPMIHBLOIAK_codec);
				break;
			}
		}
	}
}
