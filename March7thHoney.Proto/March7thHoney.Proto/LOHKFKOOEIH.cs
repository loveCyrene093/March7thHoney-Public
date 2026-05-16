using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOHKFKOOEIH : IMessage<LOHKFKOOEIH>, IMessage, IEquatable<LOHKFKOOEIH>, IDeepCloneable<LOHKFKOOEIH>, IBufferMessage
{
	private static readonly MessageParser<LOHKFKOOEIH> _parser = new MessageParser<LOHKFKOOEIH>(() => new LOHKFKOOEIH());

	private UnknownFieldSet _unknownFields;

	public const int PhaseFieldNumber = 1;

	private string phase_ = "";

	public const int NPJIENCGJAHFieldNumber = 2;

	private float nPJIENCGJAH_;

	public const int IFMAEILKJHLFieldNumber = 3;

	private float iFMAEILKJHL_;

	public const int INFGMLPIKEEFieldNumber = 4;

	private uint iNFGMLPIKEE_;

	public const int NGDMNDEJFJCFieldNumber = 5;

	private uint nGDMNDEJFJC_;

	public const int JJMCABHIHJBFieldNumber = 6;

	private uint jJMCABHIHJB_;

	public const int NLCCLJKBBNJFieldNumber = 7;

	private uint nLCCLJKBBNJ_;

	public const int PKJKKIOBEOIFieldNumber = 8;

	private uint pKJKKIOBEOI_;

	public const int EHALEONHDLGFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_eHALEONHDLG_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> eHALEONHDLG_ = new RepeatedField<uint>();

	public const int EJCAKDILHPAFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_eJCAKDILHPA_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> eJCAKDILHPA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOHKFKOOEIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOHKFKOOEIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Phase
	{
		get
		{
			return phase_;
		}
		set
		{
			phase_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float NPJIENCGJAH
	{
		get
		{
			return nPJIENCGJAH_;
		}
		set
		{
			nPJIENCGJAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float IFMAEILKJHL
	{
		get
		{
			return iFMAEILKJHL_;
		}
		set
		{
			iFMAEILKJHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INFGMLPIKEE
	{
		get
		{
			return iNFGMLPIKEE_;
		}
		set
		{
			iNFGMLPIKEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGDMNDEJFJC
	{
		get
		{
			return nGDMNDEJFJC_;
		}
		set
		{
			nGDMNDEJFJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJMCABHIHJB
	{
		get
		{
			return jJMCABHIHJB_;
		}
		set
		{
			jJMCABHIHJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLCCLJKBBNJ
	{
		get
		{
			return nLCCLJKBBNJ_;
		}
		set
		{
			nLCCLJKBBNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKJKKIOBEOI
	{
		get
		{
			return pKJKKIOBEOI_;
		}
		set
		{
			pKJKKIOBEOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EHALEONHDLG => eHALEONHDLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EJCAKDILHPA => eJCAKDILHPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOHKFKOOEIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOHKFKOOEIH(LOHKFKOOEIH other)
		: this()
	{
		phase_ = other.phase_;
		nPJIENCGJAH_ = other.nPJIENCGJAH_;
		iFMAEILKJHL_ = other.iFMAEILKJHL_;
		iNFGMLPIKEE_ = other.iNFGMLPIKEE_;
		nGDMNDEJFJC_ = other.nGDMNDEJFJC_;
		jJMCABHIHJB_ = other.jJMCABHIHJB_;
		nLCCLJKBBNJ_ = other.nLCCLJKBBNJ_;
		pKJKKIOBEOI_ = other.pKJKKIOBEOI_;
		eHALEONHDLG_ = other.eHALEONHDLG_.Clone();
		eJCAKDILHPA_ = other.eJCAKDILHPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOHKFKOOEIH Clone()
	{
		return new LOHKFKOOEIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOHKFKOOEIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOHKFKOOEIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Phase != other.Phase)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NPJIENCGJAH, other.NPJIENCGJAH))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IFMAEILKJHL, other.IFMAEILKJHL))
		{
			return false;
		}
		if (INFGMLPIKEE != other.INFGMLPIKEE)
		{
			return false;
		}
		if (NGDMNDEJFJC != other.NGDMNDEJFJC)
		{
			return false;
		}
		if (JJMCABHIHJB != other.JJMCABHIHJB)
		{
			return false;
		}
		if (NLCCLJKBBNJ != other.NLCCLJKBBNJ)
		{
			return false;
		}
		if (PKJKKIOBEOI != other.PKJKKIOBEOI)
		{
			return false;
		}
		if (!eHALEONHDLG_.Equals(other.eHALEONHDLG_))
		{
			return false;
		}
		if (!eJCAKDILHPA_.Equals(other.eJCAKDILHPA_))
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
		if (Phase.Length != 0)
		{
			num ^= Phase.GetHashCode();
		}
		if (NPJIENCGJAH != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NPJIENCGJAH);
		}
		if (IFMAEILKJHL != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IFMAEILKJHL);
		}
		if (INFGMLPIKEE != 0)
		{
			num ^= INFGMLPIKEE.GetHashCode();
		}
		if (NGDMNDEJFJC != 0)
		{
			num ^= NGDMNDEJFJC.GetHashCode();
		}
		if (JJMCABHIHJB != 0)
		{
			num ^= JJMCABHIHJB.GetHashCode();
		}
		if (NLCCLJKBBNJ != 0)
		{
			num ^= NLCCLJKBBNJ.GetHashCode();
		}
		if (PKJKKIOBEOI != 0)
		{
			num ^= PKJKKIOBEOI.GetHashCode();
		}
		num ^= eHALEONHDLG_.GetHashCode();
		num ^= eJCAKDILHPA_.GetHashCode();
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
		if (Phase.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Phase);
		}
		if (NPJIENCGJAH != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(NPJIENCGJAH);
		}
		if (IFMAEILKJHL != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(IFMAEILKJHL);
		}
		if (INFGMLPIKEE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(INFGMLPIKEE);
		}
		if (NGDMNDEJFJC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NGDMNDEJFJC);
		}
		if (JJMCABHIHJB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JJMCABHIHJB);
		}
		if (NLCCLJKBBNJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NLCCLJKBBNJ);
		}
		if (PKJKKIOBEOI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PKJKKIOBEOI);
		}
		eHALEONHDLG_.WriteTo(ref output, _repeated_eHALEONHDLG_codec);
		eJCAKDILHPA_.WriteTo(ref output, _repeated_eJCAKDILHPA_codec);
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
		if (Phase.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Phase);
		}
		if (NPJIENCGJAH != 0f)
		{
			num += 5;
		}
		if (IFMAEILKJHL != 0f)
		{
			num += 5;
		}
		if (INFGMLPIKEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INFGMLPIKEE);
		}
		if (NGDMNDEJFJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGDMNDEJFJC);
		}
		if (JJMCABHIHJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJMCABHIHJB);
		}
		if (NLCCLJKBBNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLCCLJKBBNJ);
		}
		if (PKJKKIOBEOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKJKKIOBEOI);
		}
		num += eHALEONHDLG_.CalculateSize(_repeated_eHALEONHDLG_codec);
		num += eJCAKDILHPA_.CalculateSize(_repeated_eJCAKDILHPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOHKFKOOEIH other)
	{
		if (other != null)
		{
			if (other.Phase.Length != 0)
			{
				Phase = other.Phase;
			}
			if (other.NPJIENCGJAH != 0f)
			{
				NPJIENCGJAH = other.NPJIENCGJAH;
			}
			if (other.IFMAEILKJHL != 0f)
			{
				IFMAEILKJHL = other.IFMAEILKJHL;
			}
			if (other.INFGMLPIKEE != 0)
			{
				INFGMLPIKEE = other.INFGMLPIKEE;
			}
			if (other.NGDMNDEJFJC != 0)
			{
				NGDMNDEJFJC = other.NGDMNDEJFJC;
			}
			if (other.JJMCABHIHJB != 0)
			{
				JJMCABHIHJB = other.JJMCABHIHJB;
			}
			if (other.NLCCLJKBBNJ != 0)
			{
				NLCCLJKBBNJ = other.NLCCLJKBBNJ;
			}
			if (other.PKJKKIOBEOI != 0)
			{
				PKJKKIOBEOI = other.PKJKKIOBEOI;
			}
			eHALEONHDLG_.Add(other.eHALEONHDLG_);
			eJCAKDILHPA_.Add(other.eJCAKDILHPA_);
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
				Phase = input.ReadString();
				break;
			case 21u:
				NPJIENCGJAH = input.ReadFloat();
				break;
			case 29u:
				IFMAEILKJHL = input.ReadFloat();
				break;
			case 32u:
				INFGMLPIKEE = input.ReadUInt32();
				break;
			case 40u:
				NGDMNDEJFJC = input.ReadUInt32();
				break;
			case 48u:
				JJMCABHIHJB = input.ReadUInt32();
				break;
			case 56u:
				NLCCLJKBBNJ = input.ReadUInt32();
				break;
			case 64u:
				PKJKKIOBEOI = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				eHALEONHDLG_.AddEntriesFrom(ref input, _repeated_eHALEONHDLG_codec);
				break;
			case 80u:
			case 82u:
				eJCAKDILHPA_.AddEntriesFrom(ref input, _repeated_eJCAKDILHPA_codec);
				break;
			}
		}
	}
}
