using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PDAMBCFFPDI : IMessage<PDAMBCFFPDI>, IMessage, IEquatable<PDAMBCFFPDI>, IDeepCloneable<PDAMBCFFPDI>, IBufferMessage
{
	private static readonly MessageParser<PDAMBCFFPDI> _parser = new MessageParser<PDAMBCFFPDI>(() => new PDAMBCFFPDI());

	private UnknownFieldSet _unknownFields;

	public const int EPKENDEAJPBFieldNumber = 3;

	private ICHBGLCHLDP ePKENDEAJPB_;

	public const int JHCMEALPDEBFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_jHCMEALPDEB_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> jHCMEALPDEB_ = new RepeatedField<uint>();

	public const int TalentInfoFieldNumber = 5;

	private HCGEGGGLOFI talentInfo_;

	public const int BOCIPPBEBEAFieldNumber = 6;

	private HGOILCGHKNM bOCIPPBEBEA_;

	public const int BDJDBMICKKPFieldNumber = 13;

	private GCIMMIHKPEI bDJDBMICKKP_;

	public const int JLDKKEDEKIMFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_jLDKKEDEKIM_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> jLDKKEDEKIM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PDAMBCFFPDI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PDAMBCFFPDIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> JHCMEALPDEB => jHCMEALPDEB_;

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
	public RepeatedField<uint> JLDKKEDEKIM => jLDKKEDEKIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDAMBCFFPDI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDAMBCFFPDI(PDAMBCFFPDI other)
		: this()
	{
		ePKENDEAJPB_ = ((other.ePKENDEAJPB_ != null) ? other.ePKENDEAJPB_.Clone() : null);
		jHCMEALPDEB_ = other.jHCMEALPDEB_.Clone();
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		bOCIPPBEBEA_ = ((other.bOCIPPBEBEA_ != null) ? other.bOCIPPBEBEA_.Clone() : null);
		bDJDBMICKKP_ = ((other.bDJDBMICKKP_ != null) ? other.bDJDBMICKKP_.Clone() : null);
		jLDKKEDEKIM_ = other.jLDKKEDEKIM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDAMBCFFPDI Clone()
	{
		return new PDAMBCFFPDI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PDAMBCFFPDI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PDAMBCFFPDI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EPKENDEAJPB, other.EPKENDEAJPB))
		{
			return false;
		}
		if (!jHCMEALPDEB_.Equals(other.jHCMEALPDEB_))
		{
			return false;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
		{
			return false;
		}
		if (!object.Equals(BOCIPPBEBEA, other.BOCIPPBEBEA))
		{
			return false;
		}
		if (!object.Equals(BDJDBMICKKP, other.BDJDBMICKKP))
		{
			return false;
		}
		if (!jLDKKEDEKIM_.Equals(other.jLDKKEDEKIM_))
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
		if (ePKENDEAJPB_ != null)
		{
			num ^= EPKENDEAJPB.GetHashCode();
		}
		num ^= jHCMEALPDEB_.GetHashCode();
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
		}
		if (bOCIPPBEBEA_ != null)
		{
			num ^= BOCIPPBEBEA.GetHashCode();
		}
		if (bDJDBMICKKP_ != null)
		{
			num ^= BDJDBMICKKP.GetHashCode();
		}
		num ^= jLDKKEDEKIM_.GetHashCode();
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
		if (ePKENDEAJPB_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EPKENDEAJPB);
		}
		jHCMEALPDEB_.WriteTo(ref output, _repeated_jHCMEALPDEB_codec);
		if (talentInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(TalentInfo);
		}
		if (bOCIPPBEBEA_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BOCIPPBEBEA);
		}
		if (bDJDBMICKKP_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BDJDBMICKKP);
		}
		jLDKKEDEKIM_.WriteTo(ref output, _repeated_jLDKKEDEKIM_codec);
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
		if (ePKENDEAJPB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EPKENDEAJPB);
		}
		num += jHCMEALPDEB_.CalculateSize(_repeated_jHCMEALPDEB_codec);
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		if (bOCIPPBEBEA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BOCIPPBEBEA);
		}
		if (bDJDBMICKKP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDJDBMICKKP);
		}
		num += jLDKKEDEKIM_.CalculateSize(_repeated_jLDKKEDEKIM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PDAMBCFFPDI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ePKENDEAJPB_ != null)
		{
			if (ePKENDEAJPB_ == null)
			{
				EPKENDEAJPB = new ICHBGLCHLDP();
			}
			EPKENDEAJPB.MergeFrom(other.EPKENDEAJPB);
		}
		jHCMEALPDEB_.Add(other.jHCMEALPDEB_);
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new HCGEGGGLOFI();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
		}
		if (other.bOCIPPBEBEA_ != null)
		{
			if (bOCIPPBEBEA_ == null)
			{
				BOCIPPBEBEA = new HGOILCGHKNM();
			}
			BOCIPPBEBEA.MergeFrom(other.BOCIPPBEBEA);
		}
		if (other.bDJDBMICKKP_ != null)
		{
			if (bDJDBMICKKP_ == null)
			{
				BDJDBMICKKP = new GCIMMIHKPEI();
			}
			BDJDBMICKKP.MergeFrom(other.BDJDBMICKKP);
		}
		jLDKKEDEKIM_.Add(other.jLDKKEDEKIM_);
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
			case 26u:
				if (ePKENDEAJPB_ == null)
				{
					EPKENDEAJPB = new ICHBGLCHLDP();
				}
				input.ReadMessage(EPKENDEAJPB);
				break;
			case 32u:
			case 34u:
				jHCMEALPDEB_.AddEntriesFrom(ref input, _repeated_jHCMEALPDEB_codec);
				break;
			case 42u:
				if (talentInfo_ == null)
				{
					TalentInfo = new HCGEGGGLOFI();
				}
				input.ReadMessage(TalentInfo);
				break;
			case 50u:
				if (bOCIPPBEBEA_ == null)
				{
					BOCIPPBEBEA = new HGOILCGHKNM();
				}
				input.ReadMessage(BOCIPPBEBEA);
				break;
			case 106u:
				if (bDJDBMICKKP_ == null)
				{
					BDJDBMICKKP = new GCIMMIHKPEI();
				}
				input.ReadMessage(BDJDBMICKKP);
				break;
			case 112u:
			case 114u:
				jLDKKEDEKIM_.AddEntriesFrom(ref input, _repeated_jLDKKEDEKIM_codec);
				break;
			}
		}
	}
}
