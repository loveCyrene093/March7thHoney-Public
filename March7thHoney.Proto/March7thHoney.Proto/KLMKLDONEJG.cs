using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KLMKLDONEJG : IMessage<KLMKLDONEJG>, IMessage, IEquatable<KLMKLDONEJG>, IDeepCloneable<KLMKLDONEJG>, IBufferMessage
{
	private static readonly MessageParser<KLMKLDONEJG> _parser = new MessageParser<KLMKLDONEJG>(() => new KLMKLDONEJG());

	private UnknownFieldSet _unknownFields;

	public const int EnergyInfoFieldNumber = 1;

	private uint energyInfo_;

	public const int IHPGCAAAGBCFieldNumber = 2;

	private uint iHPGCAAAGBC_;

	public const int IIPDAIEBIHAFieldNumber = 3;

	private uint iIPDAIEBIHA_;

	public const int GIKABEMCFAOFieldNumber = 4;

	private bool gIKABEMCFAO_;

	public const int ScoreIdFieldNumber = 5;

	private uint scoreId_;

	public const int KPCKLNCPPAJFieldNumber = 7;

	private uint kPCKLNCPPAJ_;

	public const int DEMGBJCJGNOFieldNumber = 9;

	private PBKPPEAPBOM dEMGBJCJGNO_;

	public const int JKPGACLKEECFieldNumber = 11;

	private uint jKPGACLKEEC_;

	public const int KHDKNKLJGOJFieldNumber = 13;

	private bool kHDKNKLJGOJ_;

	public const int ItemListFieldNumber = 14;

	private static readonly FieldCodec<MPGIOHDMFCG> _repeated_itemList_codec = FieldCodec.ForMessage(114u, MPGIOHDMFCG.Parser);

	private readonly RepeatedField<MPGIOHDMFCG> itemList_ = new RepeatedField<MPGIOHDMFCG>();

	public const int MHFHODDBOPMFieldNumber = 15;

	private ECKIDLIFAFG mHFHODDBOPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KLMKLDONEJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KLMKLDONEJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHPGCAAAGBC
	{
		get
		{
			return iHPGCAAAGBC_;
		}
		set
		{
			iHPGCAAAGBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIPDAIEBIHA
	{
		get
		{
			return iIPDAIEBIHA_;
		}
		set
		{
			iIPDAIEBIHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GIKABEMCFAO
	{
		get
		{
			return gIKABEMCFAO_;
		}
		set
		{
			gIKABEMCFAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPCKLNCPPAJ
	{
		get
		{
			return kPCKLNCPPAJ_;
		}
		set
		{
			kPCKLNCPPAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBKPPEAPBOM DEMGBJCJGNO
	{
		get
		{
			return dEMGBJCJGNO_;
		}
		set
		{
			dEMGBJCJGNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KHDKNKLJGOJ
	{
		get
		{
			return kHDKNKLJGOJ_;
		}
		set
		{
			kHDKNKLJGOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MPGIOHDMFCG> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG MHFHODDBOPM
	{
		get
		{
			return mHFHODDBOPM_;
		}
		set
		{
			mHFHODDBOPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLMKLDONEJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLMKLDONEJG(KLMKLDONEJG other)
		: this()
	{
		energyInfo_ = other.energyInfo_;
		iHPGCAAAGBC_ = other.iHPGCAAAGBC_;
		iIPDAIEBIHA_ = other.iIPDAIEBIHA_;
		gIKABEMCFAO_ = other.gIKABEMCFAO_;
		scoreId_ = other.scoreId_;
		kPCKLNCPPAJ_ = other.kPCKLNCPPAJ_;
		dEMGBJCJGNO_ = other.dEMGBJCJGNO_;
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		kHDKNKLJGOJ_ = other.kHDKNKLJGOJ_;
		itemList_ = other.itemList_.Clone();
		mHFHODDBOPM_ = ((other.mHFHODDBOPM_ != null) ? other.mHFHODDBOPM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLMKLDONEJG Clone()
	{
		return new KLMKLDONEJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KLMKLDONEJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KLMKLDONEJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EnergyInfo != other.EnergyInfo)
		{
			return false;
		}
		if (IHPGCAAAGBC != other.IHPGCAAAGBC)
		{
			return false;
		}
		if (IIPDAIEBIHA != other.IIPDAIEBIHA)
		{
			return false;
		}
		if (GIKABEMCFAO != other.GIKABEMCFAO)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (KPCKLNCPPAJ != other.KPCKLNCPPAJ)
		{
			return false;
		}
		if (DEMGBJCJGNO != other.DEMGBJCJGNO)
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (KHDKNKLJGOJ != other.KHDKNKLJGOJ)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!object.Equals(MHFHODDBOPM, other.MHFHODDBOPM))
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
		if (EnergyInfo != 0)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		if (IHPGCAAAGBC != 0)
		{
			num ^= IHPGCAAAGBC.GetHashCode();
		}
		if (IIPDAIEBIHA != 0)
		{
			num ^= IIPDAIEBIHA.GetHashCode();
		}
		if (GIKABEMCFAO)
		{
			num ^= GIKABEMCFAO.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (KPCKLNCPPAJ != 0)
		{
			num ^= KPCKLNCPPAJ.GetHashCode();
		}
		if (DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			num ^= DEMGBJCJGNO.GetHashCode();
		}
		if (JKPGACLKEEC != 0)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (KHDKNKLJGOJ)
		{
			num ^= KHDKNKLJGOJ.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (mHFHODDBOPM_ != null)
		{
			num ^= MHFHODDBOPM.GetHashCode();
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
		if (EnergyInfo != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EnergyInfo);
		}
		if (IHPGCAAAGBC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IHPGCAAAGBC);
		}
		if (IIPDAIEBIHA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IIPDAIEBIHA);
		}
		if (GIKABEMCFAO)
		{
			output.WriteRawTag(32);
			output.WriteBool(GIKABEMCFAO);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ScoreId);
		}
		if (KPCKLNCPPAJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KPCKLNCPPAJ);
		}
		if (DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)DEMGBJCJGNO);
		}
		if (JKPGACLKEEC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JKPGACLKEEC);
		}
		if (KHDKNKLJGOJ)
		{
			output.WriteRawTag(104);
			output.WriteBool(KHDKNKLJGOJ);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (mHFHODDBOPM_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(MHFHODDBOPM);
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
		if (EnergyInfo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnergyInfo);
		}
		if (IHPGCAAAGBC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHPGCAAAGBC);
		}
		if (IIPDAIEBIHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIPDAIEBIHA);
		}
		if (GIKABEMCFAO)
		{
			num += 2;
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (KPCKLNCPPAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPCKLNCPPAJ);
		}
		if (DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DEMGBJCJGNO);
		}
		if (JKPGACLKEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKPGACLKEEC);
		}
		if (KHDKNKLJGOJ)
		{
			num += 2;
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (mHFHODDBOPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHFHODDBOPM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KLMKLDONEJG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EnergyInfo != 0)
		{
			EnergyInfo = other.EnergyInfo;
		}
		if (other.IHPGCAAAGBC != 0)
		{
			IHPGCAAAGBC = other.IHPGCAAAGBC;
		}
		if (other.IIPDAIEBIHA != 0)
		{
			IIPDAIEBIHA = other.IIPDAIEBIHA;
		}
		if (other.GIKABEMCFAO)
		{
			GIKABEMCFAO = other.GIKABEMCFAO;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.KPCKLNCPPAJ != 0)
		{
			KPCKLNCPPAJ = other.KPCKLNCPPAJ;
		}
		if (other.DEMGBJCJGNO != PBKPPEAPBOM.Bnjmpchfina)
		{
			DEMGBJCJGNO = other.DEMGBJCJGNO;
		}
		if (other.JKPGACLKEEC != 0)
		{
			JKPGACLKEEC = other.JKPGACLKEEC;
		}
		if (other.KHDKNKLJGOJ)
		{
			KHDKNKLJGOJ = other.KHDKNKLJGOJ;
		}
		itemList_.Add(other.itemList_);
		if (other.mHFHODDBOPM_ != null)
		{
			if (mHFHODDBOPM_ == null)
			{
				MHFHODDBOPM = new ECKIDLIFAFG();
			}
			MHFHODDBOPM.MergeFrom(other.MHFHODDBOPM);
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
			case 8u:
				EnergyInfo = input.ReadUInt32();
				break;
			case 16u:
				IHPGCAAAGBC = input.ReadUInt32();
				break;
			case 24u:
				IIPDAIEBIHA = input.ReadUInt32();
				break;
			case 32u:
				GIKABEMCFAO = input.ReadBool();
				break;
			case 40u:
				ScoreId = input.ReadUInt32();
				break;
			case 56u:
				KPCKLNCPPAJ = input.ReadUInt32();
				break;
			case 72u:
				DEMGBJCJGNO = (PBKPPEAPBOM)input.ReadEnum();
				break;
			case 88u:
				JKPGACLKEEC = input.ReadUInt32();
				break;
			case 104u:
				KHDKNKLJGOJ = input.ReadBool();
				break;
			case 114u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 122u:
				if (mHFHODDBOPM_ == null)
				{
					MHFHODDBOPM = new ECKIDLIFAFG();
				}
				input.ReadMessage(MHFHODDBOPM);
				break;
			}
		}
	}
}
