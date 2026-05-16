using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleAvatar : IMessage<BattleAvatar>, IMessage, IEquatable<BattleAvatar>, IDeepCloneable<BattleAvatar>, IBufferMessage
{
	private static readonly MessageParser<BattleAvatar> _parser = new MessageParser<BattleAvatar>(() => new BattleAvatar());

	private UnknownFieldSet _unknownFields;

	public const int AvatarTypeFieldNumber = 1;

	private AvatarType avatarType_;

	public const int IdFieldNumber = 2;

	private uint id_;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int RankFieldNumber = 4;

	private uint rank_;

	public const int IndexFieldNumber = 5;

	private uint index_;

	public const int SkilltreeListFieldNumber = 6;

	private static readonly FieldCodec<AvatarSkillTree> _repeated_skilltreeList_codec = FieldCodec.ForMessage(50u, AvatarSkillTree.Parser);

	private readonly RepeatedField<AvatarSkillTree> skilltreeList_ = new RepeatedField<AvatarSkillTree>();

	public const int EquipmentListFieldNumber = 7;

	private static readonly FieldCodec<BattleEquipment> _repeated_equipmentList_codec = FieldCodec.ForMessage(58u, BattleEquipment.Parser);

	private readonly RepeatedField<BattleEquipment> equipmentList_ = new RepeatedField<BattleEquipment>();

	public const int HpFieldNumber = 8;

	private uint hp_;

	public const int PromotionFieldNumber = 10;

	private uint promotion_;

	public const int RelicListFieldNumber = 11;

	private static readonly FieldCodec<BattleRelic> _repeated_relicList_codec = FieldCodec.ForMessage(90u, BattleRelic.Parser);

	private readonly RepeatedField<BattleRelic> relicList_ = new RepeatedField<BattleRelic>();

	public const int WorldLevelFieldNumber = 12;

	private uint worldLevel_;

	public const int AssistUidFieldNumber = 13;

	private uint assistUid_;

	public const int AKNHONDBNMMFieldNumber = 15;

	private AAKHENHMIFM aKNHONDBNMM_;

	public const int SpBarFieldNumber = 16;

	private SpBarInfo spBar_;

	public const int PJLADGOOFKEFieldNumber = 17;

	private uint pJLADGOOFKE_;

	public const int LFPOAOFBGPJFieldNumber = 18;

	private static readonly FieldCodec<AvatarSkillTree> _repeated_lFPOAOFBGPJ_codec = FieldCodec.ForMessage(146u, AvatarSkillTree.Parser);

	private readonly RepeatedField<AvatarSkillTree> lFPOAOFBGPJ_ = new RepeatedField<AvatarSkillTree>();

	public const int EnhancedIdFieldNumber = 19;

	private uint enhancedId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleAvatar> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleAvatarReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarType AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
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
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarSkillTree> SkilltreeList => skilltreeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleEquipment> EquipmentList => equipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Hp
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
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleRelic> RelicList => relicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AssistUid
	{
		get
		{
			return assistUid_;
		}
		set
		{
			assistUid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAKHENHMIFM AKNHONDBNMM
	{
		get
		{
			return aKNHONDBNMM_;
		}
		set
		{
			aKNHONDBNMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpBarInfo SpBar
	{
		get
		{
			return spBar_;
		}
		set
		{
			spBar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJLADGOOFKE
	{
		get
		{
			return pJLADGOOFKE_;
		}
		set
		{
			pJLADGOOFKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarSkillTree> LFPOAOFBGPJ => lFPOAOFBGPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnhancedId
	{
		get
		{
			return enhancedId_;
		}
		set
		{
			enhancedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatar()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatar(BattleAvatar other)
		: this()
	{
		avatarType_ = other.avatarType_;
		id_ = other.id_;
		level_ = other.level_;
		rank_ = other.rank_;
		index_ = other.index_;
		skilltreeList_ = other.skilltreeList_.Clone();
		equipmentList_ = other.equipmentList_.Clone();
		hp_ = other.hp_;
		promotion_ = other.promotion_;
		relicList_ = other.relicList_.Clone();
		worldLevel_ = other.worldLevel_;
		assistUid_ = other.assistUid_;
		aKNHONDBNMM_ = ((other.aKNHONDBNMM_ != null) ? other.aKNHONDBNMM_.Clone() : null);
		spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
		pJLADGOOFKE_ = other.pJLADGOOFKE_;
		lFPOAOFBGPJ_ = other.lFPOAOFBGPJ_.Clone();
		enhancedId_ = other.enhancedId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatar Clone()
	{
		return new BattleAvatar(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleAvatar);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleAvatar other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (!skilltreeList_.Equals(other.skilltreeList_))
		{
			return false;
		}
		if (!equipmentList_.Equals(other.equipmentList_))
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (Promotion != other.Promotion)
		{
			return false;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (AssistUid != other.AssistUid)
		{
			return false;
		}
		if (!object.Equals(AKNHONDBNMM, other.AKNHONDBNMM))
		{
			return false;
		}
		if (!object.Equals(SpBar, other.SpBar))
		{
			return false;
		}
		if (PJLADGOOFKE != other.PJLADGOOFKE)
		{
			return false;
		}
		if (!lFPOAOFBGPJ_.Equals(other.lFPOAOFBGPJ_))
		{
			return false;
		}
		if (EnhancedId != other.EnhancedId)
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
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		num ^= skilltreeList_.GetHashCode();
		num ^= equipmentList_.GetHashCode();
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
		}
		num ^= relicList_.GetHashCode();
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (AssistUid != 0)
		{
			num ^= AssistUid.GetHashCode();
		}
		if (aKNHONDBNMM_ != null)
		{
			num ^= AKNHONDBNMM.GetHashCode();
		}
		if (spBar_ != null)
		{
			num ^= SpBar.GetHashCode();
		}
		if (PJLADGOOFKE != 0)
		{
			num ^= PJLADGOOFKE.GetHashCode();
		}
		num ^= lFPOAOFBGPJ_.GetHashCode();
		if (EnhancedId != 0)
		{
			num ^= EnhancedId.GetHashCode();
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
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)AvatarType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Rank);
		}
		if (Index != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Index);
		}
		skilltreeList_.WriteTo(ref output, _repeated_skilltreeList_codec);
		equipmentList_.WriteTo(ref output, _repeated_equipmentList_codec);
		if (Hp != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Hp);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Promotion);
		}
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		if (WorldLevel != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(WorldLevel);
		}
		if (AssistUid != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AssistUid);
		}
		if (aKNHONDBNMM_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(AKNHONDBNMM);
		}
		if (spBar_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(SpBar);
		}
		if (PJLADGOOFKE != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(PJLADGOOFKE);
		}
		lFPOAOFBGPJ_.WriteTo(ref output, _repeated_lFPOAOFBGPJ_codec);
		if (EnhancedId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteUInt32(EnhancedId);
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
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		num += skilltreeList_.CalculateSize(_repeated_skilltreeList_codec);
		num += equipmentList_.CalculateSize(_repeated_equipmentList_codec);
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (AssistUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AssistUid);
		}
		if (aKNHONDBNMM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AKNHONDBNMM);
		}
		if (spBar_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SpBar);
		}
		if (PJLADGOOFKE != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PJLADGOOFKE);
		}
		num += lFPOAOFBGPJ_.CalculateSize(_repeated_lFPOAOFBGPJ_codec);
		if (EnhancedId != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EnhancedId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleAvatar other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AvatarType != AvatarType.None)
		{
			AvatarType = other.AvatarType;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
		}
		if (other.Index != 0)
		{
			Index = other.Index;
		}
		skilltreeList_.Add(other.skilltreeList_);
		equipmentList_.Add(other.equipmentList_);
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		if (other.Promotion != 0)
		{
			Promotion = other.Promotion;
		}
		relicList_.Add(other.relicList_);
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.AssistUid != 0)
		{
			AssistUid = other.AssistUid;
		}
		if (other.aKNHONDBNMM_ != null)
		{
			if (aKNHONDBNMM_ == null)
			{
				AKNHONDBNMM = new AAKHENHMIFM();
			}
			AKNHONDBNMM.MergeFrom(other.AKNHONDBNMM);
		}
		if (other.spBar_ != null)
		{
			if (spBar_ == null)
			{
				SpBar = new SpBarInfo();
			}
			SpBar.MergeFrom(other.SpBar);
		}
		if (other.PJLADGOOFKE != 0)
		{
			PJLADGOOFKE = other.PJLADGOOFKE;
		}
		lFPOAOFBGPJ_.Add(other.lFPOAOFBGPJ_);
		if (other.EnhancedId != 0)
		{
			EnhancedId = other.EnhancedId;
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
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 16u:
				Id = input.ReadUInt32();
				break;
			case 24u:
				Level = input.ReadUInt32();
				break;
			case 32u:
				Rank = input.ReadUInt32();
				break;
			case 40u:
				Index = input.ReadUInt32();
				break;
			case 50u:
				skilltreeList_.AddEntriesFrom(ref input, _repeated_skilltreeList_codec);
				break;
			case 58u:
				equipmentList_.AddEntriesFrom(ref input, _repeated_equipmentList_codec);
				break;
			case 64u:
				Hp = input.ReadUInt32();
				break;
			case 80u:
				Promotion = input.ReadUInt32();
				break;
			case 90u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 96u:
				WorldLevel = input.ReadUInt32();
				break;
			case 104u:
				AssistUid = input.ReadUInt32();
				break;
			case 122u:
				if (aKNHONDBNMM_ == null)
				{
					AKNHONDBNMM = new AAKHENHMIFM();
				}
				input.ReadMessage(AKNHONDBNMM);
				break;
			case 130u:
				if (spBar_ == null)
				{
					SpBar = new SpBarInfo();
				}
				input.ReadMessage(SpBar);
				break;
			case 136u:
				PJLADGOOFKE = input.ReadUInt32();
				break;
			case 146u:
				lFPOAOFBGPJ_.AddEntriesFrom(ref input, _repeated_lFPOAOFBGPJ_codec);
				break;
			case 152u:
				EnhancedId = input.ReadUInt32();
				break;
			}
		}
	}
}
