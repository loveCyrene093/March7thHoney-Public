using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMNAPNOMPME : IMessage<HMNAPNOMPME>, IMessage, IEquatable<HMNAPNOMPME>, IDeepCloneable<HMNAPNOMPME>, IBufferMessage
{
	private static readonly MessageParser<HMNAPNOMPME> _parser = new MessageParser<HMNAPNOMPME>(() => new HMNAPNOMPME());

	private UnknownFieldSet _unknownFields;

	public const int DBPOEMNBMPAFieldNumber = 1;

	private uint dBPOEMNBMPA_;

	public const int GJFMAFINMOIFieldNumber = 2;

	private uint gJFMAFINMOI_;

	public const int AEDFGHHBCJHFieldNumber = 3;

	private bool aEDFGHHBCJH_;

	public const int DOKNFOLKNKOFieldNumber = 4;

	private uint dOKNFOLKNKO_;

	public const int IFFDGDJPANJFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_iFFDGDJPANJ_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> iFFDGDJPANJ_ = new RepeatedField<uint>();

	public const int EOFCECPMHLCFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_eOFCECPMHLC_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> eOFCECPMHLC_ = new RepeatedField<uint>();

	public const int IHKDGCFCEHMFieldNumber = 7;

	private uint iHKDGCFCEHM_;

	public const int DamageFieldNumber = 8;

	private uint damage_;

	public const int IJEKHBFIEDAFieldNumber = 9;

	private uint iJEKHBFIEDA_;

	public const int AMGOEIALMIAFieldNumber = 10;

	private bool aMGOEIALMIA_;

	public const int NCNHCAFKJOIFieldNumber = 11;

	private uint nCNHCAFKJOI_;

	public const int FAOCEDDHADJFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_fAOCEDDHADJ_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> fAOCEDDHADJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMNAPNOMPME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMNAPNOMPMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBPOEMNBMPA
	{
		get
		{
			return dBPOEMNBMPA_;
		}
		set
		{
			dBPOEMNBMPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJFMAFINMOI
	{
		get
		{
			return gJFMAFINMOI_;
		}
		set
		{
			gJFMAFINMOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AEDFGHHBCJH
	{
		get
		{
			return aEDFGHHBCJH_;
		}
		set
		{
			aEDFGHHBCJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOKNFOLKNKO
	{
		get
		{
			return dOKNFOLKNKO_;
		}
		set
		{
			dOKNFOLKNKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IFFDGDJPANJ => iFFDGDJPANJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EOFCECPMHLC => eOFCECPMHLC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHKDGCFCEHM
	{
		get
		{
			return iHKDGCFCEHM_;
		}
		set
		{
			iHKDGCFCEHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJEKHBFIEDA
	{
		get
		{
			return iJEKHBFIEDA_;
		}
		set
		{
			iJEKHBFIEDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AMGOEIALMIA
	{
		get
		{
			return aMGOEIALMIA_;
		}
		set
		{
			aMGOEIALMIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCNHCAFKJOI
	{
		get
		{
			return nCNHCAFKJOI_;
		}
		set
		{
			nCNHCAFKJOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FAOCEDDHADJ => fAOCEDDHADJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMNAPNOMPME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMNAPNOMPME(HMNAPNOMPME other)
		: this()
	{
		dBPOEMNBMPA_ = other.dBPOEMNBMPA_;
		gJFMAFINMOI_ = other.gJFMAFINMOI_;
		aEDFGHHBCJH_ = other.aEDFGHHBCJH_;
		dOKNFOLKNKO_ = other.dOKNFOLKNKO_;
		iFFDGDJPANJ_ = other.iFFDGDJPANJ_.Clone();
		eOFCECPMHLC_ = other.eOFCECPMHLC_.Clone();
		iHKDGCFCEHM_ = other.iHKDGCFCEHM_;
		damage_ = other.damage_;
		iJEKHBFIEDA_ = other.iJEKHBFIEDA_;
		aMGOEIALMIA_ = other.aMGOEIALMIA_;
		nCNHCAFKJOI_ = other.nCNHCAFKJOI_;
		fAOCEDDHADJ_ = other.fAOCEDDHADJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMNAPNOMPME Clone()
	{
		return new HMNAPNOMPME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMNAPNOMPME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMNAPNOMPME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DBPOEMNBMPA != other.DBPOEMNBMPA)
		{
			return false;
		}
		if (GJFMAFINMOI != other.GJFMAFINMOI)
		{
			return false;
		}
		if (AEDFGHHBCJH != other.AEDFGHHBCJH)
		{
			return false;
		}
		if (DOKNFOLKNKO != other.DOKNFOLKNKO)
		{
			return false;
		}
		if (!iFFDGDJPANJ_.Equals(other.iFFDGDJPANJ_))
		{
			return false;
		}
		if (!eOFCECPMHLC_.Equals(other.eOFCECPMHLC_))
		{
			return false;
		}
		if (IHKDGCFCEHM != other.IHKDGCFCEHM)
		{
			return false;
		}
		if (Damage != other.Damage)
		{
			return false;
		}
		if (IJEKHBFIEDA != other.IJEKHBFIEDA)
		{
			return false;
		}
		if (AMGOEIALMIA != other.AMGOEIALMIA)
		{
			return false;
		}
		if (NCNHCAFKJOI != other.NCNHCAFKJOI)
		{
			return false;
		}
		if (!fAOCEDDHADJ_.Equals(other.fAOCEDDHADJ_))
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
		if (DBPOEMNBMPA != 0)
		{
			num ^= DBPOEMNBMPA.GetHashCode();
		}
		if (GJFMAFINMOI != 0)
		{
			num ^= GJFMAFINMOI.GetHashCode();
		}
		if (AEDFGHHBCJH)
		{
			num ^= AEDFGHHBCJH.GetHashCode();
		}
		if (DOKNFOLKNKO != 0)
		{
			num ^= DOKNFOLKNKO.GetHashCode();
		}
		num ^= iFFDGDJPANJ_.GetHashCode();
		num ^= eOFCECPMHLC_.GetHashCode();
		if (IHKDGCFCEHM != 0)
		{
			num ^= IHKDGCFCEHM.GetHashCode();
		}
		if (Damage != 0)
		{
			num ^= Damage.GetHashCode();
		}
		if (IJEKHBFIEDA != 0)
		{
			num ^= IJEKHBFIEDA.GetHashCode();
		}
		if (AMGOEIALMIA)
		{
			num ^= AMGOEIALMIA.GetHashCode();
		}
		if (NCNHCAFKJOI != 0)
		{
			num ^= NCNHCAFKJOI.GetHashCode();
		}
		num ^= fAOCEDDHADJ_.GetHashCode();
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
		if (DBPOEMNBMPA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DBPOEMNBMPA);
		}
		if (GJFMAFINMOI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GJFMAFINMOI);
		}
		if (AEDFGHHBCJH)
		{
			output.WriteRawTag(24);
			output.WriteBool(AEDFGHHBCJH);
		}
		if (DOKNFOLKNKO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DOKNFOLKNKO);
		}
		iFFDGDJPANJ_.WriteTo(ref output, _repeated_iFFDGDJPANJ_codec);
		eOFCECPMHLC_.WriteTo(ref output, _repeated_eOFCECPMHLC_codec);
		if (IHKDGCFCEHM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IHKDGCFCEHM);
		}
		if (Damage != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Damage);
		}
		if (IJEKHBFIEDA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(IJEKHBFIEDA);
		}
		if (AMGOEIALMIA)
		{
			output.WriteRawTag(80);
			output.WriteBool(AMGOEIALMIA);
		}
		if (NCNHCAFKJOI != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NCNHCAFKJOI);
		}
		fAOCEDDHADJ_.WriteTo(ref output, _repeated_fAOCEDDHADJ_codec);
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
		if (DBPOEMNBMPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBPOEMNBMPA);
		}
		if (GJFMAFINMOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJFMAFINMOI);
		}
		if (AEDFGHHBCJH)
		{
			num += 2;
		}
		if (DOKNFOLKNKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOKNFOLKNKO);
		}
		num += iFFDGDJPANJ_.CalculateSize(_repeated_iFFDGDJPANJ_codec);
		num += eOFCECPMHLC_.CalculateSize(_repeated_eOFCECPMHLC_codec);
		if (IHKDGCFCEHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHKDGCFCEHM);
		}
		if (Damage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Damage);
		}
		if (IJEKHBFIEDA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJEKHBFIEDA);
		}
		if (AMGOEIALMIA)
		{
			num += 2;
		}
		if (NCNHCAFKJOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCNHCAFKJOI);
		}
		num += fAOCEDDHADJ_.CalculateSize(_repeated_fAOCEDDHADJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMNAPNOMPME other)
	{
		if (other != null)
		{
			if (other.DBPOEMNBMPA != 0)
			{
				DBPOEMNBMPA = other.DBPOEMNBMPA;
			}
			if (other.GJFMAFINMOI != 0)
			{
				GJFMAFINMOI = other.GJFMAFINMOI;
			}
			if (other.AEDFGHHBCJH)
			{
				AEDFGHHBCJH = other.AEDFGHHBCJH;
			}
			if (other.DOKNFOLKNKO != 0)
			{
				DOKNFOLKNKO = other.DOKNFOLKNKO;
			}
			iFFDGDJPANJ_.Add(other.iFFDGDJPANJ_);
			eOFCECPMHLC_.Add(other.eOFCECPMHLC_);
			if (other.IHKDGCFCEHM != 0)
			{
				IHKDGCFCEHM = other.IHKDGCFCEHM;
			}
			if (other.Damage != 0)
			{
				Damage = other.Damage;
			}
			if (other.IJEKHBFIEDA != 0)
			{
				IJEKHBFIEDA = other.IJEKHBFIEDA;
			}
			if (other.AMGOEIALMIA)
			{
				AMGOEIALMIA = other.AMGOEIALMIA;
			}
			if (other.NCNHCAFKJOI != 0)
			{
				NCNHCAFKJOI = other.NCNHCAFKJOI;
			}
			fAOCEDDHADJ_.Add(other.fAOCEDDHADJ_);
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
				DBPOEMNBMPA = input.ReadUInt32();
				break;
			case 16u:
				GJFMAFINMOI = input.ReadUInt32();
				break;
			case 24u:
				AEDFGHHBCJH = input.ReadBool();
				break;
			case 32u:
				DOKNFOLKNKO = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				iFFDGDJPANJ_.AddEntriesFrom(ref input, _repeated_iFFDGDJPANJ_codec);
				break;
			case 48u:
			case 50u:
				eOFCECPMHLC_.AddEntriesFrom(ref input, _repeated_eOFCECPMHLC_codec);
				break;
			case 56u:
				IHKDGCFCEHM = input.ReadUInt32();
				break;
			case 64u:
				Damage = input.ReadUInt32();
				break;
			case 72u:
				IJEKHBFIEDA = input.ReadUInt32();
				break;
			case 80u:
				AMGOEIALMIA = input.ReadBool();
				break;
			case 88u:
				NCNHCAFKJOI = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				fAOCEDDHADJ_.AddEntriesFrom(ref input, _repeated_fAOCEDDHADJ_codec);
				break;
			}
		}
	}
}
