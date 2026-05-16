using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LLFONBIODFK : IMessage<LLFONBIODFK>, IMessage, IEquatable<LLFONBIODFK>, IDeepCloneable<LLFONBIODFK>, IBufferMessage
{
	private static readonly MessageParser<LLFONBIODFK> _parser = new MessageParser<LLFONBIODFK>(() => new LLFONBIODFK());

	private UnknownFieldSet _unknownFields;

	public const int ICHMKFMAIBBFieldNumber = 1;

	private static readonly FieldCodec<IAMALMLBOEI> _repeated_iCHMKFMAIBB_codec = FieldCodec.ForMessage(10u, IAMALMLBOEI.Parser);

	private readonly RepeatedField<IAMALMLBOEI> iCHMKFMAIBB_ = new RepeatedField<IAMALMLBOEI>();

	public const int BICBJMPAAANFieldNumber = 2;

	private MLOFJFBHGLG bICBJMPAAAN_;

	public const int OMFKIFADFOCFieldNumber = 3;

	private bool oMFKIFADFOC_;

	public const int JMIKPCPIFCDFieldNumber = 5;

	private static readonly FieldCodec<IFLOGJBONHI> _repeated_jMIKPCPIFCD_codec = FieldCodec.ForMessage(42u, IFLOGJBONHI.Parser);

	private readonly RepeatedField<IFLOGJBONHI> jMIKPCPIFCD_ = new RepeatedField<IFLOGJBONHI>();

	public const int DamageFieldNumber = 6;

	private uint damage_;

	public const int BEEMJECDMGBFieldNumber = 7;

	private uint bEEMJECDMGB_;

	public const int LNOPKMMELCCFieldNumber = 9;

	private uint lNOPKMMELCC_;

	public const int IHONDJOAPBMFieldNumber = 11;

	private uint iHONDJOAPBM_;

	public const int JKPGACLKEECFieldNumber = 13;

	private ulong jKPGACLKEEC_;

	public const int IIAJPADOLMCFieldNumber = 14;

	private uint iIAJPADOLMC_;

	public const int BIODAJLLINOFieldNumber = 15;

	private bool bIODAJLLINO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LLFONBIODFK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LLFONBIODFKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IAMALMLBOEI> ICHMKFMAIBB => iCHMKFMAIBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLOFJFBHGLG BICBJMPAAAN
	{
		get
		{
			return bICBJMPAAAN_;
		}
		set
		{
			bICBJMPAAAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OMFKIFADFOC
	{
		get
		{
			return oMFKIFADFOC_;
		}
		set
		{
			oMFKIFADFOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFLOGJBONHI> JMIKPCPIFCD => jMIKPCPIFCD_;

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
	public uint BEEMJECDMGB
	{
		get
		{
			return bEEMJECDMGB_;
		}
		set
		{
			bEEMJECDMGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNOPKMMELCC
	{
		get
		{
			return lNOPKMMELCC_;
		}
		set
		{
			lNOPKMMELCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHONDJOAPBM
	{
		get
		{
			return iHONDJOAPBM_;
		}
		set
		{
			iHONDJOAPBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong JKPGACLKEEC
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
	public uint IIAJPADOLMC
	{
		get
		{
			return iIAJPADOLMC_;
		}
		set
		{
			iIAJPADOLMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BIODAJLLINO
	{
		get
		{
			return bIODAJLLINO_;
		}
		set
		{
			bIODAJLLINO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLFONBIODFK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLFONBIODFK(LLFONBIODFK other)
		: this()
	{
		iCHMKFMAIBB_ = other.iCHMKFMAIBB_.Clone();
		bICBJMPAAAN_ = other.bICBJMPAAAN_;
		oMFKIFADFOC_ = other.oMFKIFADFOC_;
		jMIKPCPIFCD_ = other.jMIKPCPIFCD_.Clone();
		damage_ = other.damage_;
		bEEMJECDMGB_ = other.bEEMJECDMGB_;
		lNOPKMMELCC_ = other.lNOPKMMELCC_;
		iHONDJOAPBM_ = other.iHONDJOAPBM_;
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		iIAJPADOLMC_ = other.iIAJPADOLMC_;
		bIODAJLLINO_ = other.bIODAJLLINO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLFONBIODFK Clone()
	{
		return new LLFONBIODFK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LLFONBIODFK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LLFONBIODFK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iCHMKFMAIBB_.Equals(other.iCHMKFMAIBB_))
		{
			return false;
		}
		if (BICBJMPAAAN != other.BICBJMPAAAN)
		{
			return false;
		}
		if (OMFKIFADFOC != other.OMFKIFADFOC)
		{
			return false;
		}
		if (!jMIKPCPIFCD_.Equals(other.jMIKPCPIFCD_))
		{
			return false;
		}
		if (Damage != other.Damage)
		{
			return false;
		}
		if (BEEMJECDMGB != other.BEEMJECDMGB)
		{
			return false;
		}
		if (LNOPKMMELCC != other.LNOPKMMELCC)
		{
			return false;
		}
		if (IHONDJOAPBM != other.IHONDJOAPBM)
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (IIAJPADOLMC != other.IIAJPADOLMC)
		{
			return false;
		}
		if (BIODAJLLINO != other.BIODAJLLINO)
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
		num ^= iCHMKFMAIBB_.GetHashCode();
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num ^= BICBJMPAAAN.GetHashCode();
		}
		if (OMFKIFADFOC)
		{
			num ^= OMFKIFADFOC.GetHashCode();
		}
		num ^= jMIKPCPIFCD_.GetHashCode();
		if (Damage != 0)
		{
			num ^= Damage.GetHashCode();
		}
		if (BEEMJECDMGB != 0)
		{
			num ^= BEEMJECDMGB.GetHashCode();
		}
		if (LNOPKMMELCC != 0)
		{
			num ^= LNOPKMMELCC.GetHashCode();
		}
		if (IHONDJOAPBM != 0)
		{
			num ^= IHONDJOAPBM.GetHashCode();
		}
		if (JKPGACLKEEC != 0L)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (IIAJPADOLMC != 0)
		{
			num ^= IIAJPADOLMC.GetHashCode();
		}
		if (BIODAJLLINO)
		{
			num ^= BIODAJLLINO.GetHashCode();
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
		iCHMKFMAIBB_.WriteTo(ref output, _repeated_iCHMKFMAIBB_codec);
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)BICBJMPAAAN);
		}
		if (OMFKIFADFOC)
		{
			output.WriteRawTag(24);
			output.WriteBool(OMFKIFADFOC);
		}
		jMIKPCPIFCD_.WriteTo(ref output, _repeated_jMIKPCPIFCD_codec);
		if (Damage != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Damage);
		}
		if (BEEMJECDMGB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BEEMJECDMGB);
		}
		if (LNOPKMMELCC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LNOPKMMELCC);
		}
		if (IHONDJOAPBM != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IHONDJOAPBM);
		}
		if (JKPGACLKEEC != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(JKPGACLKEEC);
		}
		if (IIAJPADOLMC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IIAJPADOLMC);
		}
		if (BIODAJLLINO)
		{
			output.WriteRawTag(120);
			output.WriteBool(BIODAJLLINO);
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
		num += iCHMKFMAIBB_.CalculateSize(_repeated_iCHMKFMAIBB_codec);
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BICBJMPAAAN);
		}
		if (OMFKIFADFOC)
		{
			num += 2;
		}
		num += jMIKPCPIFCD_.CalculateSize(_repeated_jMIKPCPIFCD_codec);
		if (Damage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Damage);
		}
		if (BEEMJECDMGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEEMJECDMGB);
		}
		if (LNOPKMMELCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNOPKMMELCC);
		}
		if (IHONDJOAPBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHONDJOAPBM);
		}
		if (JKPGACLKEEC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JKPGACLKEEC);
		}
		if (IIAJPADOLMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIAJPADOLMC);
		}
		if (BIODAJLLINO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LLFONBIODFK other)
	{
		if (other != null)
		{
			iCHMKFMAIBB_.Add(other.iCHMKFMAIBB_);
			if (other.BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
			{
				BICBJMPAAAN = other.BICBJMPAAAN;
			}
			if (other.OMFKIFADFOC)
			{
				OMFKIFADFOC = other.OMFKIFADFOC;
			}
			jMIKPCPIFCD_.Add(other.jMIKPCPIFCD_);
			if (other.Damage != 0)
			{
				Damage = other.Damage;
			}
			if (other.BEEMJECDMGB != 0)
			{
				BEEMJECDMGB = other.BEEMJECDMGB;
			}
			if (other.LNOPKMMELCC != 0)
			{
				LNOPKMMELCC = other.LNOPKMMELCC;
			}
			if (other.IHONDJOAPBM != 0)
			{
				IHONDJOAPBM = other.IHONDJOAPBM;
			}
			if (other.JKPGACLKEEC != 0L)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
			}
			if (other.IIAJPADOLMC != 0)
			{
				IIAJPADOLMC = other.IIAJPADOLMC;
			}
			if (other.BIODAJLLINO)
			{
				BIODAJLLINO = other.BIODAJLLINO;
			}
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
				iCHMKFMAIBB_.AddEntriesFrom(ref input, _repeated_iCHMKFMAIBB_codec);
				break;
			case 16u:
				BICBJMPAAAN = (MLOFJFBHGLG)input.ReadEnum();
				break;
			case 24u:
				OMFKIFADFOC = input.ReadBool();
				break;
			case 42u:
				jMIKPCPIFCD_.AddEntriesFrom(ref input, _repeated_jMIKPCPIFCD_codec);
				break;
			case 48u:
				Damage = input.ReadUInt32();
				break;
			case 56u:
				BEEMJECDMGB = input.ReadUInt32();
				break;
			case 72u:
				LNOPKMMELCC = input.ReadUInt32();
				break;
			case 88u:
				IHONDJOAPBM = input.ReadUInt32();
				break;
			case 104u:
				JKPGACLKEEC = input.ReadUInt64();
				break;
			case 112u:
				IIAJPADOLMC = input.ReadUInt32();
				break;
			case 120u:
				BIODAJLLINO = input.ReadBool();
				break;
			}
		}
	}
}
