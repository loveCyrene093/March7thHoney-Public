using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneBattleInfo : IMessage<SceneBattleInfo>, IMessage, IEquatable<SceneBattleInfo>, IDeepCloneable<SceneBattleInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneBattleInfo> _parser = new MessageParser<SceneBattleInfo>(() => new SceneBattleInfo());

	private UnknownFieldSet _unknownFields;

	public const int BattleIdFieldNumber = 1;

	private uint battleId_;

	public const int StageIdFieldNumber = 2;

	private uint stageId_;

	public const int EODHMOBOENGFieldNumber = 3;

	private bool eODHMOBOENG_;

	public const int MonsterWaveListFieldNumber = 4;

	private static readonly FieldCodec<SceneMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage(34u, SceneMonsterWave.Parser);

	private readonly RepeatedField<SceneMonsterWave> monsterWaveList_ = new RepeatedField<SceneMonsterWave>();

	public const int WorldLevelFieldNumber = 6;

	private uint worldLevel_;

	public const int LogicRandomSeedFieldNumber = 8;

	private uint logicRandomSeed_;

	public const int BattleAvatarListFieldNumber = 9;

	private static readonly FieldCodec<BattleAvatar> _repeated_battleAvatarList_codec = FieldCodec.ForMessage(74u, BattleAvatar.Parser);

	private readonly RepeatedField<BattleAvatar> battleAvatarList_ = new RepeatedField<BattleAvatar>();

	public const int BuffListFieldNumber = 13;

	private static readonly FieldCodec<BattleBuff> _repeated_buffList_codec = FieldCodec.ForMessage(106u, BattleBuff.Parser);

	private readonly RepeatedField<BattleBuff> buffList_ = new RepeatedField<BattleBuff>();

	public const int RoundsLimitFieldNumber = 14;

	private uint roundsLimit_;

	public const int MonsterWaveLengthFieldNumber = 15;

	private uint monsterWaveLength_;

	public const int BattleEventFieldNumber = 234;

	private static readonly FieldCodec<BattleEventBattleInfo> _repeated_battleEvent_codec = FieldCodec.ForMessage(1874u, BattleEventBattleInfo.Parser);

	private readonly RepeatedField<BattleEventBattleInfo> battleEvent_ = new RepeatedField<BattleEventBattleInfo>();

	public const int IAJDCJIAHFPFieldNumber = 508;

	private CAKGOGMEJOF iAJDCJIAHFP_;

	public const int BattleRogueMagicInfoFieldNumber = 558;

	private BattleRogueMagicInfo battleRogueMagicInfo_;

	public const int BattleTargetInfoFieldNumber = 761;

	private static readonly MapField<uint, BattleTargetList>.Codec _map_battleTargetInfo_codec = new MapField<uint, BattleTargetList>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, BattleTargetList.Parser), 6090u);

	private readonly MapField<uint, BattleTargetList> battleTargetInfo_ = new MapField<uint, BattleTargetList>();

	public const int GDAGHIJADODFieldNumber = 838;

	private KCGPMNNKIKN gDAGHIJADOD_;

	public const int OBOFOCPCBPKFieldNumber = 1383;

	private MLDEDCCOHBF oBOFOCPCBPK_;

	public const int FMCJPPILPLLFieldNumber = 1654;

	private BattleGridFightSpecialBattleInfo fMCJPPILPLL_;

	public const int AFCMOOFGBPKFieldNumber = 1831;

	private OGEOMDJIAGI aFCMOOFGBPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneBattleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneBattleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EODHMOBOENG
	{
		get
		{
			return eODHMOBOENG_;
		}
		set
		{
			eODHMOBOENG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneMonsterWave> MonsterWaveList => monsterWaveList_;

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
	public uint LogicRandomSeed
	{
		get
		{
			return logicRandomSeed_;
		}
		set
		{
			logicRandomSeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleAvatar> BattleAvatarList => battleAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleBuff> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoundsLimit
	{
		get
		{
			return roundsLimit_;
		}
		set
		{
			roundsLimit_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterWaveLength
	{
		get
		{
			return monsterWaveLength_;
		}
		set
		{
			monsterWaveLength_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleEventBattleInfo> BattleEvent => battleEvent_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAKGOGMEJOF IAJDCJIAHFP
	{
		get
		{
			return iAJDCJIAHFP_;
		}
		set
		{
			iAJDCJIAHFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRogueMagicInfo BattleRogueMagicInfo
	{
		get
		{
			return battleRogueMagicInfo_;
		}
		set
		{
			battleRogueMagicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, BattleTargetList> BattleTargetInfo => battleTargetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCGPMNNKIKN GDAGHIJADOD
	{
		get
		{
			return gDAGHIJADOD_;
		}
		set
		{
			gDAGHIJADOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLDEDCCOHBF OBOFOCPCBPK
	{
		get
		{
			return oBOFOCPCBPK_;
		}
		set
		{
			oBOFOCPCBPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightSpecialBattleInfo FMCJPPILPLL
	{
		get
		{
			return fMCJPPILPLL_;
		}
		set
		{
			fMCJPPILPLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGEOMDJIAGI AFCMOOFGBPK
	{
		get
		{
			return aFCMOOFGBPK_;
		}
		set
		{
			aFCMOOFGBPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo(SceneBattleInfo other)
		: this()
	{
		battleId_ = other.battleId_;
		stageId_ = other.stageId_;
		eODHMOBOENG_ = other.eODHMOBOENG_;
		monsterWaveList_ = other.monsterWaveList_.Clone();
		worldLevel_ = other.worldLevel_;
		logicRandomSeed_ = other.logicRandomSeed_;
		battleAvatarList_ = other.battleAvatarList_.Clone();
		buffList_ = other.buffList_.Clone();
		roundsLimit_ = other.roundsLimit_;
		monsterWaveLength_ = other.monsterWaveLength_;
		battleEvent_ = other.battleEvent_.Clone();
		iAJDCJIAHFP_ = ((other.iAJDCJIAHFP_ != null) ? other.iAJDCJIAHFP_.Clone() : null);
		battleRogueMagicInfo_ = ((other.battleRogueMagicInfo_ != null) ? other.battleRogueMagicInfo_.Clone() : null);
		battleTargetInfo_ = other.battleTargetInfo_.Clone();
		gDAGHIJADOD_ = ((other.gDAGHIJADOD_ != null) ? other.gDAGHIJADOD_.Clone() : null);
		oBOFOCPCBPK_ = ((other.oBOFOCPCBPK_ != null) ? other.oBOFOCPCBPK_.Clone() : null);
		fMCJPPILPLL_ = ((other.fMCJPPILPLL_ != null) ? other.fMCJPPILPLL_.Clone() : null);
		aFCMOOFGBPK_ = ((other.aFCMOOFGBPK_ != null) ? other.aFCMOOFGBPK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo Clone()
	{
		return new SceneBattleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneBattleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneBattleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (EODHMOBOENG != other.EODHMOBOENG)
		{
			return false;
		}
		if (!monsterWaveList_.Equals(other.monsterWaveList_))
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (LogicRandomSeed != other.LogicRandomSeed)
		{
			return false;
		}
		if (!battleAvatarList_.Equals(other.battleAvatarList_))
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (RoundsLimit != other.RoundsLimit)
		{
			return false;
		}
		if (MonsterWaveLength != other.MonsterWaveLength)
		{
			return false;
		}
		if (!battleEvent_.Equals(other.battleEvent_))
		{
			return false;
		}
		if (!object.Equals(IAJDCJIAHFP, other.IAJDCJIAHFP))
		{
			return false;
		}
		if (!object.Equals(BattleRogueMagicInfo, other.BattleRogueMagicInfo))
		{
			return false;
		}
		if (!BattleTargetInfo.Equals(other.BattleTargetInfo))
		{
			return false;
		}
		if (!object.Equals(GDAGHIJADOD, other.GDAGHIJADOD))
		{
			return false;
		}
		if (!object.Equals(OBOFOCPCBPK, other.OBOFOCPCBPK))
		{
			return false;
		}
		if (!object.Equals(FMCJPPILPLL, other.FMCJPPILPLL))
		{
			return false;
		}
		if (!object.Equals(AFCMOOFGBPK, other.AFCMOOFGBPK))
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
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (EODHMOBOENG)
		{
			num ^= EODHMOBOENG.GetHashCode();
		}
		num ^= monsterWaveList_.GetHashCode();
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (LogicRandomSeed != 0)
		{
			num ^= LogicRandomSeed.GetHashCode();
		}
		num ^= battleAvatarList_.GetHashCode();
		num ^= buffList_.GetHashCode();
		if (RoundsLimit != 0)
		{
			num ^= RoundsLimit.GetHashCode();
		}
		if (MonsterWaveLength != 0)
		{
			num ^= MonsterWaveLength.GetHashCode();
		}
		num ^= battleEvent_.GetHashCode();
		if (iAJDCJIAHFP_ != null)
		{
			num ^= IAJDCJIAHFP.GetHashCode();
		}
		if (battleRogueMagicInfo_ != null)
		{
			num ^= BattleRogueMagicInfo.GetHashCode();
		}
		num ^= BattleTargetInfo.GetHashCode();
		if (gDAGHIJADOD_ != null)
		{
			num ^= GDAGHIJADOD.GetHashCode();
		}
		if (oBOFOCPCBPK_ != null)
		{
			num ^= OBOFOCPCBPK.GetHashCode();
		}
		if (fMCJPPILPLL_ != null)
		{
			num ^= FMCJPPILPLL.GetHashCode();
		}
		if (aFCMOOFGBPK_ != null)
		{
			num ^= AFCMOOFGBPK.GetHashCode();
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
		if (BattleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BattleId);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(StageId);
		}
		if (EODHMOBOENG)
		{
			output.WriteRawTag(24);
			output.WriteBool(EODHMOBOENG);
		}
		monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
		if (WorldLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(WorldLevel);
		}
		if (LogicRandomSeed != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LogicRandomSeed);
		}
		battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		if (RoundsLimit != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(RoundsLimit);
		}
		if (MonsterWaveLength != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MonsterWaveLength);
		}
		battleEvent_.WriteTo(ref output, _repeated_battleEvent_codec);
		if (iAJDCJIAHFP_ != null)
		{
			output.WriteRawTag(226, 31);
			output.WriteMessage(IAJDCJIAHFP);
		}
		if (battleRogueMagicInfo_ != null)
		{
			output.WriteRawTag(242, 34);
			output.WriteMessage(BattleRogueMagicInfo);
		}
		battleTargetInfo_.WriteTo(ref output, _map_battleTargetInfo_codec);
		if (gDAGHIJADOD_ != null)
		{
			output.WriteRawTag(178, 52);
			output.WriteMessage(GDAGHIJADOD);
		}
		if (oBOFOCPCBPK_ != null)
		{
			output.WriteRawTag(186, 86);
			output.WriteMessage(OBOFOCPCBPK);
		}
		if (fMCJPPILPLL_ != null)
		{
			output.WriteRawTag(178, 103);
			output.WriteMessage(FMCJPPILPLL);
		}
		if (aFCMOOFGBPK_ != null)
		{
			output.WriteRawTag(186, 114);
			output.WriteMessage(AFCMOOFGBPK);
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
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (EODHMOBOENG)
		{
			num += 2;
		}
		num += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (LogicRandomSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LogicRandomSeed);
		}
		num += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (RoundsLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundsLimit);
		}
		if (MonsterWaveLength != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterWaveLength);
		}
		num += battleEvent_.CalculateSize(_repeated_battleEvent_codec);
		if (iAJDCJIAHFP_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IAJDCJIAHFP);
		}
		if (battleRogueMagicInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BattleRogueMagicInfo);
		}
		num += battleTargetInfo_.CalculateSize(_map_battleTargetInfo_codec);
		if (gDAGHIJADOD_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GDAGHIJADOD);
		}
		if (oBOFOCPCBPK_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OBOFOCPCBPK);
		}
		if (fMCJPPILPLL_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FMCJPPILPLL);
		}
		if (aFCMOOFGBPK_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AFCMOOFGBPK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneBattleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleId != 0)
		{
			BattleId = other.BattleId;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.EODHMOBOENG)
		{
			EODHMOBOENG = other.EODHMOBOENG;
		}
		monsterWaveList_.Add(other.monsterWaveList_);
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.LogicRandomSeed != 0)
		{
			LogicRandomSeed = other.LogicRandomSeed;
		}
		battleAvatarList_.Add(other.battleAvatarList_);
		buffList_.Add(other.buffList_);
		if (other.RoundsLimit != 0)
		{
			RoundsLimit = other.RoundsLimit;
		}
		if (other.MonsterWaveLength != 0)
		{
			MonsterWaveLength = other.MonsterWaveLength;
		}
		battleEvent_.Add(other.battleEvent_);
		if (other.iAJDCJIAHFP_ != null)
		{
			if (iAJDCJIAHFP_ == null)
			{
				IAJDCJIAHFP = new CAKGOGMEJOF();
			}
			IAJDCJIAHFP.MergeFrom(other.IAJDCJIAHFP);
		}
		if (other.battleRogueMagicInfo_ != null)
		{
			if (battleRogueMagicInfo_ == null)
			{
				BattleRogueMagicInfo = new BattleRogueMagicInfo();
			}
			BattleRogueMagicInfo.MergeFrom(other.BattleRogueMagicInfo);
		}
		battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
		if (other.gDAGHIJADOD_ != null)
		{
			if (gDAGHIJADOD_ == null)
			{
				GDAGHIJADOD = new KCGPMNNKIKN();
			}
			GDAGHIJADOD.MergeFrom(other.GDAGHIJADOD);
		}
		if (other.oBOFOCPCBPK_ != null)
		{
			if (oBOFOCPCBPK_ == null)
			{
				OBOFOCPCBPK = new MLDEDCCOHBF();
			}
			OBOFOCPCBPK.MergeFrom(other.OBOFOCPCBPK);
		}
		if (other.fMCJPPILPLL_ != null)
		{
			if (fMCJPPILPLL_ == null)
			{
				FMCJPPILPLL = new BattleGridFightSpecialBattleInfo();
			}
			FMCJPPILPLL.MergeFrom(other.FMCJPPILPLL);
		}
		if (other.aFCMOOFGBPK_ != null)
		{
			if (aFCMOOFGBPK_ == null)
			{
				AFCMOOFGBPK = new OGEOMDJIAGI();
			}
			AFCMOOFGBPK.MergeFrom(other.AFCMOOFGBPK);
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
				BattleId = input.ReadUInt32();
				break;
			case 16u:
				StageId = input.ReadUInt32();
				break;
			case 24u:
				EODHMOBOENG = input.ReadBool();
				break;
			case 34u:
				monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
				break;
			case 48u:
				WorldLevel = input.ReadUInt32();
				break;
			case 64u:
				LogicRandomSeed = input.ReadUInt32();
				break;
			case 74u:
				battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
				break;
			case 106u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 112u:
				RoundsLimit = input.ReadUInt32();
				break;
			case 120u:
				MonsterWaveLength = input.ReadUInt32();
				break;
			case 1874u:
				battleEvent_.AddEntriesFrom(ref input, _repeated_battleEvent_codec);
				break;
			case 4066u:
				if (iAJDCJIAHFP_ == null)
				{
					IAJDCJIAHFP = new CAKGOGMEJOF();
				}
				input.ReadMessage(IAJDCJIAHFP);
				break;
			case 4466u:
				if (battleRogueMagicInfo_ == null)
				{
					BattleRogueMagicInfo = new BattleRogueMagicInfo();
				}
				input.ReadMessage(BattleRogueMagicInfo);
				break;
			case 6090u:
				battleTargetInfo_.AddEntriesFrom(ref input, _map_battleTargetInfo_codec);
				break;
			case 6706u:
				if (gDAGHIJADOD_ == null)
				{
					GDAGHIJADOD = new KCGPMNNKIKN();
				}
				input.ReadMessage(GDAGHIJADOD);
				break;
			case 11066u:
				if (oBOFOCPCBPK_ == null)
				{
					OBOFOCPCBPK = new MLDEDCCOHBF();
				}
				input.ReadMessage(OBOFOCPCBPK);
				break;
			case 13234u:
				if (fMCJPPILPLL_ == null)
				{
					FMCJPPILPLL = new BattleGridFightSpecialBattleInfo();
				}
				input.ReadMessage(FMCJPPILPLL);
				break;
			case 14650u:
				if (aFCMOOFGBPK_ == null)
				{
					AFCMOOFGBPK = new OGEOMDJIAGI();
				}
				input.ReadMessage(AFCMOOFGBPK);
				break;
			}
		}
	}
}
