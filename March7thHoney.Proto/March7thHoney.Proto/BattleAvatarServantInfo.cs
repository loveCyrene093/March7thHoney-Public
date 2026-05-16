using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleAvatarServantInfo : IMessage<BattleAvatarServantInfo>, IMessage, IEquatable<BattleAvatarServantInfo>, IDeepCloneable<BattleAvatarServantInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleAvatarServantInfo> _parser = new MessageParser<BattleAvatarServantInfo>(() => new BattleAvatarServantInfo());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int FIFHKNHEIBDFieldNumber = 2;

	private uint fIFHKNHEIBD_;

	public const int TotalTurnsFieldNumber = 3;

	private uint totalTurns_;

	public const int NFEHGEPLPAJFieldNumber = 4;

	private double nFEHGEPLPAJ_;

	public const int SkillTimesFieldNumber = 5;

	private static readonly FieldCodec<SkillUseProperty> _repeated_skillTimes_codec = FieldCodec.ForMessage(42u, SkillUseProperty.Parser);

	private readonly RepeatedField<SkillUseProperty> skillTimes_ = new RepeatedField<SkillUseProperty>();

	public const int TotalDamageFieldNumber = 6;

	private double totalDamage_;

	public const int TotalBreakDamageFieldNumber = 7;

	private double totalBreakDamage_;

	public const int AttackTypeDamageFieldNumber = 8;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeDamage_codec = FieldCodec.ForMessage(66u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int AttackTypeBreakDamageFieldNumber = 9;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeBreakDamage_codec = FieldCodec.ForMessage(74u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeBreakDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int AttackTypeMaxDamageFieldNumber = 10;

	private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeMaxDamage_codec = FieldCodec.ForMessage(82u, AttackDamageProperty.Parser);

	private readonly RepeatedField<AttackDamageProperty> attackTypeMaxDamage_ = new RepeatedField<AttackDamageProperty>();

	public const int TotalDamageTakenFieldNumber = 11;

	private double totalDamageTaken_;

	public const int TotalHealFieldNumber = 12;

	private double totalHeal_;

	public const int TotalHpRecoverFieldNumber = 13;

	private double totalHpRecover_;

	public const int TotalShieldFieldNumber = 14;

	private double totalShield_;

	public const int TotalShieldTakenFieldNumber = 15;

	private double totalShieldTaken_;

	public const int TotalShieldDamageFieldNumber = 16;

	private double totalShieldDamage_;

	public const int BreakTimesFieldNumber = 17;

	private uint breakTimes_;

	public const int CEHLLNCEMDNFieldNumber = 18;

	private uint cEHLLNCEMDN_;

	public const int HOOFEMEKKOBFieldNumber = 19;

	private uint hOOFEMEKKOB_;

	public const int DOAPBOLJOGFFieldNumber = 20;

	private uint dOAPBOLJOGF_;

	public const int FJLIHMDENMLFieldNumber = 21;

	private double fJLIHMDENML_;

	public const int EntityIdFieldNumber = 22;

	private uint entityId_;

	public const int ANMBAIFOBJPFieldNumber = 23;

	private uint aNMBAIFOBJP_;

	public const int OGDGEKFJAFOFieldNumber = 24;

	private double oGDGEKFJAFO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleAvatarServantInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleAvatarServantInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIFHKNHEIBD
	{
		get
		{
			return fIFHKNHEIBD_;
		}
		set
		{
			fIFHKNHEIBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalTurns
	{
		get
		{
			return totalTurns_;
		}
		set
		{
			totalTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double NFEHGEPLPAJ
	{
		get
		{
			return nFEHGEPLPAJ_;
		}
		set
		{
			nFEHGEPLPAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SkillUseProperty> SkillTimes => skillTimes_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalBreakDamage
	{
		get
		{
			return totalBreakDamage_;
		}
		set
		{
			totalBreakDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeDamage => attackTypeDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeBreakDamage => attackTypeBreakDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttackDamageProperty> AttackTypeMaxDamage => attackTypeMaxDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamageTaken
	{
		get
		{
			return totalDamageTaken_;
		}
		set
		{
			totalDamageTaken_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalHeal
	{
		get
		{
			return totalHeal_;
		}
		set
		{
			totalHeal_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalHpRecover
	{
		get
		{
			return totalHpRecover_;
		}
		set
		{
			totalHpRecover_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalShield
	{
		get
		{
			return totalShield_;
		}
		set
		{
			totalShield_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalShieldTaken
	{
		get
		{
			return totalShieldTaken_;
		}
		set
		{
			totalShieldTaken_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalShieldDamage
	{
		get
		{
			return totalShieldDamage_;
		}
		set
		{
			totalShieldDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BreakTimes
	{
		get
		{
			return breakTimes_;
		}
		set
		{
			breakTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEHLLNCEMDN
	{
		get
		{
			return cEHLLNCEMDN_;
		}
		set
		{
			cEHLLNCEMDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOOFEMEKKOB
	{
		get
		{
			return hOOFEMEKKOB_;
		}
		set
		{
			hOOFEMEKKOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAPBOLJOGF
	{
		get
		{
			return dOAPBOLJOGF_;
		}
		set
		{
			dOAPBOLJOGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double FJLIHMDENML
	{
		get
		{
			return fJLIHMDENML_;
		}
		set
		{
			fJLIHMDENML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntityId
	{
		get
		{
			return entityId_;
		}
		set
		{
			entityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANMBAIFOBJP
	{
		get
		{
			return aNMBAIFOBJP_;
		}
		set
		{
			aNMBAIFOBJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double OGDGEKFJAFO
	{
		get
		{
			return oGDGEKFJAFO_;
		}
		set
		{
			oGDGEKFJAFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatarServantInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatarServantInfo(BattleAvatarServantInfo other)
		: this()
	{
		avatarId_ = other.avatarId_;
		fIFHKNHEIBD_ = other.fIFHKNHEIBD_;
		totalTurns_ = other.totalTurns_;
		nFEHGEPLPAJ_ = other.nFEHGEPLPAJ_;
		skillTimes_ = other.skillTimes_.Clone();
		totalDamage_ = other.totalDamage_;
		totalBreakDamage_ = other.totalBreakDamage_;
		attackTypeDamage_ = other.attackTypeDamage_.Clone();
		attackTypeBreakDamage_ = other.attackTypeBreakDamage_.Clone();
		attackTypeMaxDamage_ = other.attackTypeMaxDamage_.Clone();
		totalDamageTaken_ = other.totalDamageTaken_;
		totalHeal_ = other.totalHeal_;
		totalHpRecover_ = other.totalHpRecover_;
		totalShield_ = other.totalShield_;
		totalShieldTaken_ = other.totalShieldTaken_;
		totalShieldDamage_ = other.totalShieldDamage_;
		breakTimes_ = other.breakTimes_;
		cEHLLNCEMDN_ = other.cEHLLNCEMDN_;
		hOOFEMEKKOB_ = other.hOOFEMEKKOB_;
		dOAPBOLJOGF_ = other.dOAPBOLJOGF_;
		fJLIHMDENML_ = other.fJLIHMDENML_;
		entityId_ = other.entityId_;
		aNMBAIFOBJP_ = other.aNMBAIFOBJP_;
		oGDGEKFJAFO_ = other.oGDGEKFJAFO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatarServantInfo Clone()
	{
		return new BattleAvatarServantInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleAvatarServantInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleAvatarServantInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (FIFHKNHEIBD != other.FIFHKNHEIBD)
		{
			return false;
		}
		if (TotalTurns != other.TotalTurns)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NFEHGEPLPAJ, other.NFEHGEPLPAJ))
		{
			return false;
		}
		if (!skillTimes_.Equals(other.skillTimes_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalBreakDamage, other.TotalBreakDamage))
		{
			return false;
		}
		if (!attackTypeDamage_.Equals(other.attackTypeDamage_))
		{
			return false;
		}
		if (!attackTypeBreakDamage_.Equals(other.attackTypeBreakDamage_))
		{
			return false;
		}
		if (!attackTypeMaxDamage_.Equals(other.attackTypeMaxDamage_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamageTaken, other.TotalDamageTaken))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalHeal, other.TotalHeal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalHpRecover, other.TotalHpRecover))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalShield, other.TotalShield))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalShieldTaken, other.TotalShieldTaken))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalShieldDamage, other.TotalShieldDamage))
		{
			return false;
		}
		if (BreakTimes != other.BreakTimes)
		{
			return false;
		}
		if (CEHLLNCEMDN != other.CEHLLNCEMDN)
		{
			return false;
		}
		if (HOOFEMEKKOB != other.HOOFEMEKKOB)
		{
			return false;
		}
		if (DOAPBOLJOGF != other.DOAPBOLJOGF)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FJLIHMDENML, other.FJLIHMDENML))
		{
			return false;
		}
		if (EntityId != other.EntityId)
		{
			return false;
		}
		if (ANMBAIFOBJP != other.ANMBAIFOBJP)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OGDGEKFJAFO, other.OGDGEKFJAFO))
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (FIFHKNHEIBD != 0)
		{
			num ^= FIFHKNHEIBD.GetHashCode();
		}
		if (TotalTurns != 0)
		{
			num ^= TotalTurns.GetHashCode();
		}
		if (NFEHGEPLPAJ != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NFEHGEPLPAJ);
		}
		num ^= skillTimes_.GetHashCode();
		if (TotalDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamage);
		}
		if (TotalBreakDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalBreakDamage);
		}
		num ^= attackTypeDamage_.GetHashCode();
		num ^= attackTypeBreakDamage_.GetHashCode();
		num ^= attackTypeMaxDamage_.GetHashCode();
		if (TotalDamageTaken != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamageTaken);
		}
		if (TotalHeal != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalHeal);
		}
		if (TotalHpRecover != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalHpRecover);
		}
		if (TotalShield != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalShield);
		}
		if (TotalShieldTaken != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalShieldTaken);
		}
		if (TotalShieldDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalShieldDamage);
		}
		if (BreakTimes != 0)
		{
			num ^= BreakTimes.GetHashCode();
		}
		if (CEHLLNCEMDN != 0)
		{
			num ^= CEHLLNCEMDN.GetHashCode();
		}
		if (HOOFEMEKKOB != 0)
		{
			num ^= HOOFEMEKKOB.GetHashCode();
		}
		if (DOAPBOLJOGF != 0)
		{
			num ^= DOAPBOLJOGF.GetHashCode();
		}
		if (FJLIHMDENML != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FJLIHMDENML);
		}
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
		}
		if (ANMBAIFOBJP != 0)
		{
			num ^= ANMBAIFOBJP.GetHashCode();
		}
		if (OGDGEKFJAFO != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OGDGEKFJAFO);
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (FIFHKNHEIBD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FIFHKNHEIBD);
		}
		if (TotalTurns != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TotalTurns);
		}
		if (NFEHGEPLPAJ != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(NFEHGEPLPAJ);
		}
		skillTimes_.WriteTo(ref output, _repeated_skillTimes_codec);
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(TotalDamage);
		}
		if (TotalBreakDamage != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(TotalBreakDamage);
		}
		attackTypeDamage_.WriteTo(ref output, _repeated_attackTypeDamage_codec);
		attackTypeBreakDamage_.WriteTo(ref output, _repeated_attackTypeBreakDamage_codec);
		attackTypeMaxDamage_.WriteTo(ref output, _repeated_attackTypeMaxDamage_codec);
		if (TotalDamageTaken != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(TotalDamageTaken);
		}
		if (TotalHeal != 0.0)
		{
			output.WriteRawTag(97);
			output.WriteDouble(TotalHeal);
		}
		if (TotalHpRecover != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(TotalHpRecover);
		}
		if (TotalShield != 0.0)
		{
			output.WriteRawTag(113);
			output.WriteDouble(TotalShield);
		}
		if (TotalShieldTaken != 0.0)
		{
			output.WriteRawTag(121);
			output.WriteDouble(TotalShieldTaken);
		}
		if (TotalShieldDamage != 0.0)
		{
			output.WriteRawTag(129, 1);
			output.WriteDouble(TotalShieldDamage);
		}
		if (BreakTimes != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(BreakTimes);
		}
		if (CEHLLNCEMDN != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteUInt32(CEHLLNCEMDN);
		}
		if (HOOFEMEKKOB != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteUInt32(HOOFEMEKKOB);
		}
		if (DOAPBOLJOGF != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteUInt32(DOAPBOLJOGF);
		}
		if (FJLIHMDENML != 0.0)
		{
			output.WriteRawTag(169, 1);
			output.WriteDouble(FJLIHMDENML);
		}
		if (EntityId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteUInt32(EntityId);
		}
		if (ANMBAIFOBJP != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteUInt32(ANMBAIFOBJP);
		}
		if (OGDGEKFJAFO != 0.0)
		{
			output.WriteRawTag(193, 1);
			output.WriteDouble(OGDGEKFJAFO);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (FIFHKNHEIBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIFHKNHEIBD);
		}
		if (TotalTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalTurns);
		}
		if (NFEHGEPLPAJ != 0.0)
		{
			num += 9;
		}
		num += skillTimes_.CalculateSize(_repeated_skillTimes_codec);
		if (TotalDamage != 0.0)
		{
			num += 9;
		}
		if (TotalBreakDamage != 0.0)
		{
			num += 9;
		}
		num += attackTypeDamage_.CalculateSize(_repeated_attackTypeDamage_codec);
		num += attackTypeBreakDamage_.CalculateSize(_repeated_attackTypeBreakDamage_codec);
		num += attackTypeMaxDamage_.CalculateSize(_repeated_attackTypeMaxDamage_codec);
		if (TotalDamageTaken != 0.0)
		{
			num += 9;
		}
		if (TotalHeal != 0.0)
		{
			num += 9;
		}
		if (TotalHpRecover != 0.0)
		{
			num += 9;
		}
		if (TotalShield != 0.0)
		{
			num += 9;
		}
		if (TotalShieldTaken != 0.0)
		{
			num += 9;
		}
		if (TotalShieldDamage != 0.0)
		{
			num += 10;
		}
		if (BreakTimes != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BreakTimes);
		}
		if (CEHLLNCEMDN != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(CEHLLNCEMDN);
		}
		if (HOOFEMEKKOB != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HOOFEMEKKOB);
		}
		if (DOAPBOLJOGF != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DOAPBOLJOGF);
		}
		if (FJLIHMDENML != 0.0)
		{
			num += 10;
		}
		if (EntityId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (ANMBAIFOBJP != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ANMBAIFOBJP);
		}
		if (OGDGEKFJAFO != 0.0)
		{
			num += 10;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleAvatarServantInfo other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.FIFHKNHEIBD != 0)
			{
				FIFHKNHEIBD = other.FIFHKNHEIBD;
			}
			if (other.TotalTurns != 0)
			{
				TotalTurns = other.TotalTurns;
			}
			if (other.NFEHGEPLPAJ != 0.0)
			{
				NFEHGEPLPAJ = other.NFEHGEPLPAJ;
			}
			skillTimes_.Add(other.skillTimes_);
			if (other.TotalDamage != 0.0)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.TotalBreakDamage != 0.0)
			{
				TotalBreakDamage = other.TotalBreakDamage;
			}
			attackTypeDamage_.Add(other.attackTypeDamage_);
			attackTypeBreakDamage_.Add(other.attackTypeBreakDamage_);
			attackTypeMaxDamage_.Add(other.attackTypeMaxDamage_);
			if (other.TotalDamageTaken != 0.0)
			{
				TotalDamageTaken = other.TotalDamageTaken;
			}
			if (other.TotalHeal != 0.0)
			{
				TotalHeal = other.TotalHeal;
			}
			if (other.TotalHpRecover != 0.0)
			{
				TotalHpRecover = other.TotalHpRecover;
			}
			if (other.TotalShield != 0.0)
			{
				TotalShield = other.TotalShield;
			}
			if (other.TotalShieldTaken != 0.0)
			{
				TotalShieldTaken = other.TotalShieldTaken;
			}
			if (other.TotalShieldDamage != 0.0)
			{
				TotalShieldDamage = other.TotalShieldDamage;
			}
			if (other.BreakTimes != 0)
			{
				BreakTimes = other.BreakTimes;
			}
			if (other.CEHLLNCEMDN != 0)
			{
				CEHLLNCEMDN = other.CEHLLNCEMDN;
			}
			if (other.HOOFEMEKKOB != 0)
			{
				HOOFEMEKKOB = other.HOOFEMEKKOB;
			}
			if (other.DOAPBOLJOGF != 0)
			{
				DOAPBOLJOGF = other.DOAPBOLJOGF;
			}
			if (other.FJLIHMDENML != 0.0)
			{
				FJLIHMDENML = other.FJLIHMDENML;
			}
			if (other.EntityId != 0)
			{
				EntityId = other.EntityId;
			}
			if (other.ANMBAIFOBJP != 0)
			{
				ANMBAIFOBJP = other.ANMBAIFOBJP;
			}
			if (other.OGDGEKFJAFO != 0.0)
			{
				OGDGEKFJAFO = other.OGDGEKFJAFO;
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
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 16u:
				FIFHKNHEIBD = input.ReadUInt32();
				break;
			case 24u:
				TotalTurns = input.ReadUInt32();
				break;
			case 33u:
				NFEHGEPLPAJ = input.ReadDouble();
				break;
			case 42u:
				skillTimes_.AddEntriesFrom(ref input, _repeated_skillTimes_codec);
				break;
			case 49u:
				TotalDamage = input.ReadDouble();
				break;
			case 57u:
				TotalBreakDamage = input.ReadDouble();
				break;
			case 66u:
				attackTypeDamage_.AddEntriesFrom(ref input, _repeated_attackTypeDamage_codec);
				break;
			case 74u:
				attackTypeBreakDamage_.AddEntriesFrom(ref input, _repeated_attackTypeBreakDamage_codec);
				break;
			case 82u:
				attackTypeMaxDamage_.AddEntriesFrom(ref input, _repeated_attackTypeMaxDamage_codec);
				break;
			case 89u:
				TotalDamageTaken = input.ReadDouble();
				break;
			case 97u:
				TotalHeal = input.ReadDouble();
				break;
			case 105u:
				TotalHpRecover = input.ReadDouble();
				break;
			case 113u:
				TotalShield = input.ReadDouble();
				break;
			case 121u:
				TotalShieldTaken = input.ReadDouble();
				break;
			case 129u:
				TotalShieldDamage = input.ReadDouble();
				break;
			case 136u:
				BreakTimes = input.ReadUInt32();
				break;
			case 144u:
				CEHLLNCEMDN = input.ReadUInt32();
				break;
			case 152u:
				HOOFEMEKKOB = input.ReadUInt32();
				break;
			case 160u:
				DOAPBOLJOGF = input.ReadUInt32();
				break;
			case 169u:
				FJLIHMDENML = input.ReadDouble();
				break;
			case 176u:
				EntityId = input.ReadUInt32();
				break;
			case 184u:
				ANMBAIFOBJP = input.ReadUInt32();
				break;
			case 193u:
				OGDGEKFJAFO = input.ReadDouble();
				break;
			}
		}
	}
}
