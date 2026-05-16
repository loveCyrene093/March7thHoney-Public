using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BABAGEDCCBG : IMessage<BABAGEDCCBG>, IMessage, IEquatable<BABAGEDCCBG>, IDeepCloneable<BABAGEDCCBG>, IBufferMessage
{
	private static readonly MessageParser<BABAGEDCCBG> _parser = new MessageParser<BABAGEDCCBG>(() => new BABAGEDCCBG());

	private UnknownFieldSet _unknownFields;

	public const int BOCIPPBEBEAFieldNumber = 2;

	private HGOILCGHKNM bOCIPPBEBEA_;

	public const int TalentInfoFieldNumber = 4;

	private HCGEGGGLOFI talentInfo_;

	public const int JHCMEALPDEBFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_jHCMEALPDEB_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> jHCMEALPDEB_ = new RepeatedField<uint>();

	public const int JLDKKEDEKIMFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_jLDKKEDEKIM_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> jLDKKEDEKIM_ = new RepeatedField<uint>();

	public const int BDJDBMICKKPFieldNumber = 8;

	private GCIMMIHKPEI bDJDBMICKKP_;

	public const int EPKENDEAJPBFieldNumber = 13;

	private ICHBGLCHLDP ePKENDEAJPB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BABAGEDCCBG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BABAGEDCCBGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HGOILCGHKNM BOCIPPBEBEA
	{
		get
		{
			return bOCIPPBEBEA_;
		}
		set
		{
			bOCIPPBEBEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCGEGGGLOFI TalentInfo
	{
		get
		{
			return talentInfo_;
		}
		set
		{
			talentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JHCMEALPDEB => jHCMEALPDEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JLDKKEDEKIM => jLDKKEDEKIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCIMMIHKPEI BDJDBMICKKP
	{
		get
		{
			return bDJDBMICKKP_;
		}
		set
		{
			bDJDBMICKKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICHBGLCHLDP EPKENDEAJPB
	{
		get
		{
			return ePKENDEAJPB_;
		}
		set
		{
			ePKENDEAJPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABAGEDCCBG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABAGEDCCBG(BABAGEDCCBG other)
		: this()
	{
		bOCIPPBEBEA_ = ((other.bOCIPPBEBEA_ != null) ? other.bOCIPPBEBEA_.Clone() : null);
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		jHCMEALPDEB_ = other.jHCMEALPDEB_.Clone();
		jLDKKEDEKIM_ = other.jLDKKEDEKIM_.Clone();
		bDJDBMICKKP_ = ((other.bDJDBMICKKP_ != null) ? other.bDJDBMICKKP_.Clone() : null);
		ePKENDEAJPB_ = ((other.ePKENDEAJPB_ != null) ? other.ePKENDEAJPB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BABAGEDCCBG Clone()
	{
		return new BABAGEDCCBG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BABAGEDCCBG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BABAGEDCCBG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BOCIPPBEBEA, other.BOCIPPBEBEA))
		{
			return false;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
		{
			return false;
		}
		if (!jHCMEALPDEB_.Equals(other.jHCMEALPDEB_))
		{
			return false;
		}
		if (!jLDKKEDEKIM_.Equals(other.jLDKKEDEKIM_))
		{
			return false;
		}
		if (!object.Equals(BDJDBMICKKP, other.BDJDBMICKKP))
		{
			return false;
		}
		if (!object.Equals(EPKENDEAJPB, other.EPKENDEAJPB))
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
		if (bOCIPPBEBEA_ != null)
		{
			num ^= BOCIPPBEBEA.GetHashCode();
		}
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
		}
		num ^= jHCMEALPDEB_.GetHashCode();
		num ^= jLDKKEDEKIM_.GetHashCode();
		if (bDJDBMICKKP_ != null)
		{
			num ^= BDJDBMICKKP.GetHashCode();
		}
		if (ePKENDEAJPB_ != null)
		{
			num ^= EPKENDEAJPB.GetHashCode();
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
		if (bOCIPPBEBEA_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BOCIPPBEBEA);
		}
		if (talentInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(TalentInfo);
		}
		jHCMEALPDEB_.WriteTo(ref output, _repeated_jHCMEALPDEB_codec);
		jLDKKEDEKIM_.WriteTo(ref output, _repeated_jLDKKEDEKIM_codec);
		if (bDJDBMICKKP_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BDJDBMICKKP);
		}
		if (ePKENDEAJPB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EPKENDEAJPB);
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
		if (bOCIPPBEBEA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BOCIPPBEBEA);
		}
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		num += jHCMEALPDEB_.CalculateSize(_repeated_jHCMEALPDEB_codec);
		num += jLDKKEDEKIM_.CalculateSize(_repeated_jLDKKEDEKIM_codec);
		if (bDJDBMICKKP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDJDBMICKKP);
		}
		if (ePKENDEAJPB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EPKENDEAJPB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BABAGEDCCBG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bOCIPPBEBEA_ != null)
		{
			if (bOCIPPBEBEA_ == null)
			{
				BOCIPPBEBEA = new HGOILCGHKNM();
			}
			BOCIPPBEBEA.MergeFrom(other.BOCIPPBEBEA);
		}
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new HCGEGGGLOFI();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
		}
		jHCMEALPDEB_.Add(other.jHCMEALPDEB_);
		jLDKKEDEKIM_.Add(other.jLDKKEDEKIM_);
		if (other.bDJDBMICKKP_ != null)
		{
			if (bDJDBMICKKP_ == null)
			{
				BDJDBMICKKP = new GCIMMIHKPEI();
			}
			BDJDBMICKKP.MergeFrom(other.BDJDBMICKKP);
		}
		if (other.ePKENDEAJPB_ != null)
		{
			if (ePKENDEAJPB_ == null)
			{
				EPKENDEAJPB = new ICHBGLCHLDP();
			}
			EPKENDEAJPB.MergeFrom(other.EPKENDEAJPB);
		}
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
			case 18u:
				if (bOCIPPBEBEA_ == null)
				{
					BOCIPPBEBEA = new HGOILCGHKNM();
				}
				input.ReadMessage(BOCIPPBEBEA);
				break;
			case 34u:
				if (talentInfo_ == null)
				{
					TalentInfo = new HCGEGGGLOFI();
				}
				input.ReadMessage(TalentInfo);
				break;
			case 48u:
			case 50u:
				jHCMEALPDEB_.AddEntriesFrom(ref input, _repeated_jHCMEALPDEB_codec);
				break;
			case 56u:
			case 58u:
				jLDKKEDEKIM_.AddEntriesFrom(ref input, _repeated_jLDKKEDEKIM_codec);
				break;
			case 66u:
				if (bDJDBMICKKP_ == null)
				{
					BDJDBMICKKP = new GCIMMIHKPEI();
				}
				input.ReadMessage(BDJDBMICKKP);
				break;
			case 106u:
				if (ePKENDEAJPB_ == null)
				{
					EPKENDEAJPB = new ICHBGLCHLDP();
				}
				input.ReadMessage(EPKENDEAJPB);
				break;
			}
		}
	}
}
