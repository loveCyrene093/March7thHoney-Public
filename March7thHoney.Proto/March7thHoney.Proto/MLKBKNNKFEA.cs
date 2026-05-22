using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MLKBKNNKFEA : IMessage<MLKBKNNKFEA>, IMessage, IEquatable<MLKBKNNKFEA>, IDeepCloneable<MLKBKNNKFEA>, IBufferMessage
{
	private static readonly MessageParser<MLKBKNNKFEA> _parser = new MessageParser<MLKBKNNKFEA>(() => new MLKBKNNKFEA());

	private UnknownFieldSet _unknownFields;

	public const int HLJPCIDLCKAFieldNumber = 2;

	private DKBNDPLMNCO hLJPCIDLCKA_;

	public const int NIIEKCMBENIFieldNumber = 4;

	private uint nIIEKCMBENI_;

	public const int MLJDIDHMJMJFieldNumber = 5;

	private bool mLJDIDHMJMJ_;

	public const int EJMJMEAGMOCFieldNumber = 6;

	private uint eJMJMEAGMOC_;

	public const int KHHKJKADACBFieldNumber = 7;

	private OPGJPLKHLKJ kHHKJKADACB_;

	public const int LCEKOMJAAOCFieldNumber = 8;

	private float lCEKOMJAAOC_;

	public const int ADCJOJMPNPHFieldNumber = 9;

	private DKBNDPLMNCO aDCJOJMPNPH_;

	public const int LLOFGMDMIJMFieldNumber = 10;

	private static readonly FieldCodec<OLCPICDAOKI> _repeated_lLOFGMDMIJM_codec = FieldCodec.ForMessage(82u, OLCPICDAOKI.Parser);

	private readonly RepeatedField<OLCPICDAOKI> lLOFGMDMIJM_ = new RepeatedField<OLCPICDAOKI>();

	public const int AGAPFHKAODLFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_aGAPFHKAODL_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> aGAPFHKAODL_ = new RepeatedField<uint>();

	public const int PhaseFieldNumber = 12;

	private OEHDBMBNLOF phase_;

	public const int EFHOPMMKLIFFieldNumber = 13;

	private static readonly FieldCodec<OLCPICDAOKI> _repeated_eFHOPMMKLIF_codec = FieldCodec.ForMessage(106u, OLCPICDAOKI.Parser);

	private readonly RepeatedField<OLCPICDAOKI> eFHOPMMKLIF_ = new RepeatedField<OLCPICDAOKI>();

	public const int FBCJCKEAHCMFieldNumber = 14;

	private uint fBCJCKEAHCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MLKBKNNKFEA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MLKBKNNKFEAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNDPLMNCO HLJPCIDLCKA
	{
		get
		{
			return hLJPCIDLCKA_;
		}
		set
		{
			hLJPCIDLCKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NIIEKCMBENI
	{
		get
		{
			return nIIEKCMBENI_;
		}
		set
		{
			nIIEKCMBENI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MLJDIDHMJMJ
	{
		get
		{
			return mLJDIDHMJMJ_;
		}
		set
		{
			mLJDIDHMJMJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJMJMEAGMOC
	{
		get
		{
			return eJMJMEAGMOC_;
		}
		set
		{
			eJMJMEAGMOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPGJPLKHLKJ KHHKJKADACB
	{
		get
		{
			return kHHKJKADACB_;
		}
		set
		{
			kHHKJKADACB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float LCEKOMJAAOC
	{
		get
		{
			return lCEKOMJAAOC_;
		}
		set
		{
			lCEKOMJAAOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNDPLMNCO ADCJOJMPNPH
	{
		get
		{
			return aDCJOJMPNPH_;
		}
		set
		{
			aDCJOJMPNPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLCPICDAOKI> LLOFGMDMIJM => lLOFGMDMIJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AGAPFHKAODL => aGAPFHKAODL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEHDBMBNLOF Phase
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
	public RepeatedField<OLCPICDAOKI> EFHOPMMKLIF => eFHOPMMKLIF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBCJCKEAHCM
	{
		get
		{
			return fBCJCKEAHCM_;
		}
		set
		{
			fBCJCKEAHCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLKBKNNKFEA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLKBKNNKFEA(MLKBKNNKFEA other)
		: this()
	{
		hLJPCIDLCKA_ = ((other.hLJPCIDLCKA_ != null) ? other.hLJPCIDLCKA_.Clone() : null);
		nIIEKCMBENI_ = other.nIIEKCMBENI_;
		mLJDIDHMJMJ_ = other.mLJDIDHMJMJ_;
		eJMJMEAGMOC_ = other.eJMJMEAGMOC_;
		kHHKJKADACB_ = ((other.kHHKJKADACB_ != null) ? other.kHHKJKADACB_.Clone() : null);
		lCEKOMJAAOC_ = other.lCEKOMJAAOC_;
		aDCJOJMPNPH_ = ((other.aDCJOJMPNPH_ != null) ? other.aDCJOJMPNPH_.Clone() : null);
		lLOFGMDMIJM_ = other.lLOFGMDMIJM_.Clone();
		aGAPFHKAODL_ = other.aGAPFHKAODL_.Clone();
		phase_ = other.phase_;
		eFHOPMMKLIF_ = other.eFHOPMMKLIF_.Clone();
		fBCJCKEAHCM_ = other.fBCJCKEAHCM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLKBKNNKFEA Clone()
	{
		return new MLKBKNNKFEA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MLKBKNNKFEA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MLKBKNNKFEA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HLJPCIDLCKA, other.HLJPCIDLCKA))
		{
			return false;
		}
		if (NIIEKCMBENI != other.NIIEKCMBENI)
		{
			return false;
		}
		if (MLJDIDHMJMJ != other.MLJDIDHMJMJ)
		{
			return false;
		}
		if (EJMJMEAGMOC != other.EJMJMEAGMOC)
		{
			return false;
		}
		if (!object.Equals(KHHKJKADACB, other.KHHKJKADACB))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LCEKOMJAAOC, other.LCEKOMJAAOC))
		{
			return false;
		}
		if (!object.Equals(ADCJOJMPNPH, other.ADCJOJMPNPH))
		{
			return false;
		}
		if (!lLOFGMDMIJM_.Equals(other.lLOFGMDMIJM_))
		{
			return false;
		}
		if (!aGAPFHKAODL_.Equals(other.aGAPFHKAODL_))
		{
			return false;
		}
		if (Phase != other.Phase)
		{
			return false;
		}
		if (!eFHOPMMKLIF_.Equals(other.eFHOPMMKLIF_))
		{
			return false;
		}
		if (FBCJCKEAHCM != other.FBCJCKEAHCM)
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
		if (hLJPCIDLCKA_ != null)
		{
			num ^= HLJPCIDLCKA.GetHashCode();
		}
		if (NIIEKCMBENI != 0)
		{
			num ^= NIIEKCMBENI.GetHashCode();
		}
		if (MLJDIDHMJMJ)
		{
			num ^= MLJDIDHMJMJ.GetHashCode();
		}
		if (EJMJMEAGMOC != 0)
		{
			num ^= EJMJMEAGMOC.GetHashCode();
		}
		if (kHHKJKADACB_ != null)
		{
			num ^= KHHKJKADACB.GetHashCode();
		}
		if (LCEKOMJAAOC != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LCEKOMJAAOC);
		}
		if (aDCJOJMPNPH_ != null)
		{
			num ^= ADCJOJMPNPH.GetHashCode();
		}
		num ^= lLOFGMDMIJM_.GetHashCode();
		num ^= aGAPFHKAODL_.GetHashCode();
		if (Phase != OEHDBMBNLOF.Hlpochdnjma)
		{
			num ^= Phase.GetHashCode();
		}
		num ^= eFHOPMMKLIF_.GetHashCode();
		if (FBCJCKEAHCM != 0)
		{
			num ^= FBCJCKEAHCM.GetHashCode();
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
		if (hLJPCIDLCKA_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HLJPCIDLCKA);
		}
		if (NIIEKCMBENI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NIIEKCMBENI);
		}
		if (MLJDIDHMJMJ)
		{
			output.WriteRawTag(40);
			output.WriteBool(MLJDIDHMJMJ);
		}
		if (EJMJMEAGMOC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EJMJMEAGMOC);
		}
		if (kHHKJKADACB_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(KHHKJKADACB);
		}
		if (LCEKOMJAAOC != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(LCEKOMJAAOC);
		}
		if (aDCJOJMPNPH_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ADCJOJMPNPH);
		}
		lLOFGMDMIJM_.WriteTo(ref output, _repeated_lLOFGMDMIJM_codec);
		aGAPFHKAODL_.WriteTo(ref output, _repeated_aGAPFHKAODL_codec);
		if (Phase != OEHDBMBNLOF.Hlpochdnjma)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Phase);
		}
		eFHOPMMKLIF_.WriteTo(ref output, _repeated_eFHOPMMKLIF_codec);
		if (FBCJCKEAHCM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FBCJCKEAHCM);
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
		if (hLJPCIDLCKA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HLJPCIDLCKA);
		}
		if (NIIEKCMBENI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIIEKCMBENI);
		}
		if (MLJDIDHMJMJ)
		{
			num += 2;
		}
		if (EJMJMEAGMOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJMJMEAGMOC);
		}
		if (kHHKJKADACB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KHHKJKADACB);
		}
		if (LCEKOMJAAOC != 0f)
		{
			num += 5;
		}
		if (aDCJOJMPNPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ADCJOJMPNPH);
		}
		num += lLOFGMDMIJM_.CalculateSize(_repeated_lLOFGMDMIJM_codec);
		num += aGAPFHKAODL_.CalculateSize(_repeated_aGAPFHKAODL_codec);
		if (Phase != OEHDBMBNLOF.Hlpochdnjma)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Phase);
		}
		num += eFHOPMMKLIF_.CalculateSize(_repeated_eFHOPMMKLIF_codec);
		if (FBCJCKEAHCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBCJCKEAHCM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MLKBKNNKFEA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hLJPCIDLCKA_ != null)
		{
			if (hLJPCIDLCKA_ == null)
			{
				HLJPCIDLCKA = new DKBNDPLMNCO();
			}
			HLJPCIDLCKA.MergeFrom(other.HLJPCIDLCKA);
		}
		if (other.NIIEKCMBENI != 0)
		{
			NIIEKCMBENI = other.NIIEKCMBENI;
		}
		if (other.MLJDIDHMJMJ)
		{
			MLJDIDHMJMJ = other.MLJDIDHMJMJ;
		}
		if (other.EJMJMEAGMOC != 0)
		{
			EJMJMEAGMOC = other.EJMJMEAGMOC;
		}
		if (other.kHHKJKADACB_ != null)
		{
			if (kHHKJKADACB_ == null)
			{
				KHHKJKADACB = new OPGJPLKHLKJ();
			}
			KHHKJKADACB.MergeFrom(other.KHHKJKADACB);
		}
		if (other.LCEKOMJAAOC != 0f)
		{
			LCEKOMJAAOC = other.LCEKOMJAAOC;
		}
		if (other.aDCJOJMPNPH_ != null)
		{
			if (aDCJOJMPNPH_ == null)
			{
				ADCJOJMPNPH = new DKBNDPLMNCO();
			}
			ADCJOJMPNPH.MergeFrom(other.ADCJOJMPNPH);
		}
		lLOFGMDMIJM_.Add(other.lLOFGMDMIJM_);
		aGAPFHKAODL_.Add(other.aGAPFHKAODL_);
		if (other.Phase != OEHDBMBNLOF.Hlpochdnjma)
		{
			Phase = other.Phase;
		}
		eFHOPMMKLIF_.Add(other.eFHOPMMKLIF_);
		if (other.FBCJCKEAHCM != 0)
		{
			FBCJCKEAHCM = other.FBCJCKEAHCM;
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
				if (hLJPCIDLCKA_ == null)
				{
					HLJPCIDLCKA = new DKBNDPLMNCO();
				}
				input.ReadMessage(HLJPCIDLCKA);
				break;
			case 32u:
				NIIEKCMBENI = input.ReadUInt32();
				break;
			case 40u:
				MLJDIDHMJMJ = input.ReadBool();
				break;
			case 48u:
				EJMJMEAGMOC = input.ReadUInt32();
				break;
			case 58u:
				if (kHHKJKADACB_ == null)
				{
					KHHKJKADACB = new OPGJPLKHLKJ();
				}
				input.ReadMessage(KHHKJKADACB);
				break;
			case 69u:
				LCEKOMJAAOC = input.ReadFloat();
				break;
			case 74u:
				if (aDCJOJMPNPH_ == null)
				{
					ADCJOJMPNPH = new DKBNDPLMNCO();
				}
				input.ReadMessage(ADCJOJMPNPH);
				break;
			case 82u:
				lLOFGMDMIJM_.AddEntriesFrom(ref input, _repeated_lLOFGMDMIJM_codec);
				break;
			case 88u:
			case 90u:
				aGAPFHKAODL_.AddEntriesFrom(ref input, _repeated_aGAPFHKAODL_codec);
				break;
			case 96u:
				Phase = (OEHDBMBNLOF)input.ReadEnum();
				break;
			case 106u:
				eFHOPMMKLIF_.AddEntriesFrom(ref input, _repeated_eFHOPMMKLIF_codec);
				break;
			case 112u:
				FBCJCKEAHCM = input.ReadUInt32();
				break;
			}
		}
	}
}
