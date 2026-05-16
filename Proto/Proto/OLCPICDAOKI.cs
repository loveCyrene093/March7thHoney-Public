using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OLCPICDAOKI : IMessage<OLCPICDAOKI>, IMessage, IEquatable<OLCPICDAOKI>, IDeepCloneable<OLCPICDAOKI>, IBufferMessage
{
	private static readonly MessageParser<OLCPICDAOKI> _parser = new MessageParser<OLCPICDAOKI>(() => new OLCPICDAOKI());

	private UnknownFieldSet _unknownFields;

	public const int AttackFieldNumber = 1;

	private int attack_;

	public const int BuffIdFieldNumber = 2;

	private uint buffId_;

	public const int NBEKCEIHJACFieldNumber = 3;

	private bool nBEKCEIHJAC_;

	public const int KFAEMIBBPHAFieldNumber = 4;

	private uint kFAEMIBBPHA_;

	public const int OAIMADEEEPEFieldNumber = 5;

	private KGCLNMHAAMM oAIMADEEEPE_;

	public const int NFOFIPGGJGPFieldNumber = 7;

	private bool nFOFIPGGJGP_;

	public const int HpFieldNumber = 8;

	private int hp_;

	public const int MaxHpFieldNumber = 9;

	private int maxHp_;

	public const int MBAFIOCLMAIFieldNumber = 10;

	private KGCLNMHAAMM mBAFIOCLMAI_;

	public const int ABAFOPBHILKFieldNumber = 11;

	private bool aBAFOPBHILK_;

	public const int LevelFieldNumber = 12;

	private uint level_;

	public const int IdFieldNumber = 13;

	private uint id_;

	public const int OLKBHJNOIADFieldNumber = 14;

	private bool oLKBHJNOIAD_;

	public const int KHNNELPGKIMFieldNumber = 15;

	private float kHNNELPGKIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OLCPICDAOKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OLCPICDAOKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Attack
	{
		get
		{
			return attack_;
		}
		set
		{
			attack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NBEKCEIHJAC
	{
		get
		{
			return nBEKCEIHJAC_;
		}
		set
		{
			nBEKCEIHJAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFAEMIBBPHA
	{
		get
		{
			return kFAEMIBBPHA_;
		}
		set
		{
			kFAEMIBBPHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM OAIMADEEEPE
	{
		get
		{
			return oAIMADEEEPE_;
		}
		set
		{
			oAIMADEEEPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NFOFIPGGJGP
	{
		get
		{
			return nFOFIPGGJGP_;
		}
		set
		{
			nFOFIPGGJGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM MBAFIOCLMAI
	{
		get
		{
			return mBAFIOCLMAI_;
		}
		set
		{
			mBAFIOCLMAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ABAFOPBHILK
	{
		get
		{
			return aBAFOPBHILK_;
		}
		set
		{
			aBAFOPBHILK_ = value;
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
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OLKBHJNOIAD
	{
		get
		{
			return oLKBHJNOIAD_;
		}
		set
		{
			oLKBHJNOIAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float KHNNELPGKIM
	{
		get
		{
			return kHNNELPGKIM_;
		}
		set
		{
			kHNNELPGKIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLCPICDAOKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLCPICDAOKI(OLCPICDAOKI other)
		: this()
	{
		attack_ = other.attack_;
		buffId_ = other.buffId_;
		nBEKCEIHJAC_ = other.nBEKCEIHJAC_;
		kFAEMIBBPHA_ = other.kFAEMIBBPHA_;
		oAIMADEEEPE_ = ((other.oAIMADEEEPE_ != null) ? other.oAIMADEEEPE_.Clone() : null);
		nFOFIPGGJGP_ = other.nFOFIPGGJGP_;
		hp_ = other.hp_;
		maxHp_ = other.maxHp_;
		mBAFIOCLMAI_ = ((other.mBAFIOCLMAI_ != null) ? other.mBAFIOCLMAI_.Clone() : null);
		aBAFOPBHILK_ = other.aBAFOPBHILK_;
		level_ = other.level_;
		id_ = other.id_;
		oLKBHJNOIAD_ = other.oLKBHJNOIAD_;
		kHNNELPGKIM_ = other.kHNNELPGKIM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLCPICDAOKI Clone()
	{
		return new OLCPICDAOKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OLCPICDAOKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OLCPICDAOKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Attack != other.Attack)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (NBEKCEIHJAC != other.NBEKCEIHJAC)
		{
			return false;
		}
		if (KFAEMIBBPHA != other.KFAEMIBBPHA)
		{
			return false;
		}
		if (!object.Equals(OAIMADEEEPE, other.OAIMADEEEPE))
		{
			return false;
		}
		if (NFOFIPGGJGP != other.NFOFIPGGJGP)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (!object.Equals(MBAFIOCLMAI, other.MBAFIOCLMAI))
		{
			return false;
		}
		if (ABAFOPBHILK != other.ABAFOPBHILK)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (OLKBHJNOIAD != other.OLKBHJNOIAD)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KHNNELPGKIM, other.KHNNELPGKIM))
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
		if (Attack != 0)
		{
			num ^= Attack.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (NBEKCEIHJAC)
		{
			num ^= NBEKCEIHJAC.GetHashCode();
		}
		if (KFAEMIBBPHA != 0)
		{
			num ^= KFAEMIBBPHA.GetHashCode();
		}
		if (oAIMADEEEPE_ != null)
		{
			num ^= OAIMADEEEPE.GetHashCode();
		}
		if (NFOFIPGGJGP)
		{
			num ^= NFOFIPGGJGP.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (mBAFIOCLMAI_ != null)
		{
			num ^= MBAFIOCLMAI.GetHashCode();
		}
		if (ABAFOPBHILK)
		{
			num ^= ABAFOPBHILK.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (OLKBHJNOIAD)
		{
			num ^= OLKBHJNOIAD.GetHashCode();
		}
		if (KHNNELPGKIM != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KHNNELPGKIM);
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
		if (Attack != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Attack);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BuffId);
		}
		if (NBEKCEIHJAC)
		{
			output.WriteRawTag(24);
			output.WriteBool(NBEKCEIHJAC);
		}
		if (KFAEMIBBPHA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KFAEMIBBPHA);
		}
		if (oAIMADEEEPE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(OAIMADEEEPE);
		}
		if (NFOFIPGGJGP)
		{
			output.WriteRawTag(56);
			output.WriteBool(NFOFIPGGJGP);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Hp);
		}
		if (MaxHp != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MaxHp);
		}
		if (mBAFIOCLMAI_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(MBAFIOCLMAI);
		}
		if (ABAFOPBHILK)
		{
			output.WriteRawTag(88);
			output.WriteBool(ABAFOPBHILK);
		}
		if (Level != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Level);
		}
		if (Id != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Id);
		}
		if (OLKBHJNOIAD)
		{
			output.WriteRawTag(112);
			output.WriteBool(OLKBHJNOIAD);
		}
		if (KHNNELPGKIM != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(KHNNELPGKIM);
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
		if (Attack != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Attack);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (NBEKCEIHJAC)
		{
			num += 2;
		}
		if (KFAEMIBBPHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFAEMIBBPHA);
		}
		if (oAIMADEEEPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OAIMADEEEPE);
		}
		if (NFOFIPGGJGP)
		{
			num += 2;
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxHp);
		}
		if (mBAFIOCLMAI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBAFIOCLMAI);
		}
		if (ABAFOPBHILK)
		{
			num += 2;
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (OLKBHJNOIAD)
		{
			num += 2;
		}
		if (KHNNELPGKIM != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OLCPICDAOKI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Attack != 0)
		{
			Attack = other.Attack;
		}
		if (other.BuffId != 0)
		{
			BuffId = other.BuffId;
		}
		if (other.NBEKCEIHJAC)
		{
			NBEKCEIHJAC = other.NBEKCEIHJAC;
		}
		if (other.KFAEMIBBPHA != 0)
		{
			KFAEMIBBPHA = other.KFAEMIBBPHA;
		}
		if (other.oAIMADEEEPE_ != null)
		{
			if (oAIMADEEEPE_ == null)
			{
				OAIMADEEEPE = new KGCLNMHAAMM();
			}
			OAIMADEEEPE.MergeFrom(other.OAIMADEEEPE);
		}
		if (other.NFOFIPGGJGP)
		{
			NFOFIPGGJGP = other.NFOFIPGGJGP;
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		if (other.MaxHp != 0)
		{
			MaxHp = other.MaxHp;
		}
		if (other.mBAFIOCLMAI_ != null)
		{
			if (mBAFIOCLMAI_ == null)
			{
				MBAFIOCLMAI = new KGCLNMHAAMM();
			}
			MBAFIOCLMAI.MergeFrom(other.MBAFIOCLMAI);
		}
		if (other.ABAFOPBHILK)
		{
			ABAFOPBHILK = other.ABAFOPBHILK;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.OLKBHJNOIAD)
		{
			OLKBHJNOIAD = other.OLKBHJNOIAD;
		}
		if (other.KHNNELPGKIM != 0f)
		{
			KHNNELPGKIM = other.KHNNELPGKIM;
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
				Attack = input.ReadInt32();
				break;
			case 16u:
				BuffId = input.ReadUInt32();
				break;
			case 24u:
				NBEKCEIHJAC = input.ReadBool();
				break;
			case 32u:
				KFAEMIBBPHA = input.ReadUInt32();
				break;
			case 42u:
				if (oAIMADEEEPE_ == null)
				{
					OAIMADEEEPE = new KGCLNMHAAMM();
				}
				input.ReadMessage(OAIMADEEEPE);
				break;
			case 56u:
				NFOFIPGGJGP = input.ReadBool();
				break;
			case 64u:
				Hp = input.ReadInt32();
				break;
			case 72u:
				MaxHp = input.ReadInt32();
				break;
			case 82u:
				if (mBAFIOCLMAI_ == null)
				{
					MBAFIOCLMAI = new KGCLNMHAAMM();
				}
				input.ReadMessage(MBAFIOCLMAI);
				break;
			case 88u:
				ABAFOPBHILK = input.ReadBool();
				break;
			case 96u:
				Level = input.ReadUInt32();
				break;
			case 104u:
				Id = input.ReadUInt32();
				break;
			case 112u:
				OLKBHJNOIAD = input.ReadBool();
				break;
			case 125u:
				KHNNELPGKIM = input.ReadFloat();
				break;
			}
		}
	}
}
