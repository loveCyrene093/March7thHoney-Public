using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BHDDKILAJCJ : IMessage<BHDDKILAJCJ>, IMessage, IEquatable<BHDDKILAJCJ>, IDeepCloneable<BHDDKILAJCJ>, IBufferMessage
{
	private static readonly MessageParser<BHDDKILAJCJ> _parser = new MessageParser<BHDDKILAJCJ>(() => new BHDDKILAJCJ());

	private UnknownFieldSet _unknownFields;

	public const int VersionFieldNumber = 1;

	private uint version_;

	public const int LogicRandomSeedFieldNumber = 2;

	private uint logicRandomSeed_;

	public const int StageIdFieldNumber = 3;

	private uint stageId_;

	public const int LineupFieldNumber = 4;

	private BNAEFBKJOGE lineup_;

	public const int OpListFieldNumber = 5;

	private static readonly FieldCodec<BattleOp> _repeated_opList_codec = FieldCodec.ForMessage(42u, BattleOp.Parser);

	private readonly RepeatedField<BattleOp> opList_ = new RepeatedField<BattleOp>();

	public const int TurnSnapshotHashFieldNumber = 6;

	private ByteString turnSnapshotHash_ = ByteString.Empty;

	public const int KKPEEKMDJNEFieldNumber = 7;

	private uint kKPEEKMDJNE_;

	public const int EHGEMEIKJBHFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_eHGEMEIKJBH_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> eHGEMEIKJBH_ = new RepeatedField<uint>();

	public const int ABAIAEMNEOAFieldNumber = 9;

	private bool aBAIAEMNEOA_;

	public const int GMOAOGGMCPDFieldNumber = 10;

	private JILAPGBHFJI gMOAOGGMCPD_;

	public const int KIOBEGHMGAEFieldNumber = 11;

	private BattleModuleType kIOBEGHMGAE_;

	public const int BattleEventFieldNumber = 12;

	private static readonly FieldCodec<BattleEventBattleInfo> _repeated_battleEvent_codec = FieldCodec.ForMessage(98u, BattleEventBattleInfo.Parser);

	private readonly RepeatedField<BattleEventBattleInfo> battleEvent_ = new RepeatedField<BattleEventBattleInfo>();

	public const int RoundsLimitFieldNumber = 14;

	private uint roundsLimit_;

	public const int ODLBOKHDANLFieldNumber = 15;

	private MCKLCDAOECD oDLBOKHDANL_;

	public const int PLIAFNPANGNFieldNumber = 16;

	private ByteString pLIAFNPANGN_ = ByteString.Empty;

	public const int ENECPEOGEKGFieldNumber = 17;

	private uint eNECPEOGEKG_;

	public const int MonsterWaveLengthFieldNumber = 18;

	private uint monsterWaveLength_;

	public const int PJPFIIGBIAHFieldNumber = 19;

	private BAFDFBJHLGK pJPFIIGBIAH_;

	public const int DGEMJCAEOJIFieldNumber = 100;

	private LBMPELPKFHH dGEMJCAEOJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BHDDKILAJCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BHDDKILAJCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
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
	public BNAEFBKJOGE Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleOp> OpList => opList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString TurnSnapshotHash
	{
		get
		{
			return turnSnapshotHash_;
		}
		set
		{
			turnSnapshotHash_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKPEEKMDJNE
	{
		get
		{
			return kKPEEKMDJNE_;
		}
		set
		{
			kKPEEKMDJNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EHGEMEIKJBH => eHGEMEIKJBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ABAIAEMNEOA
	{
		get
		{
			return aBAIAEMNEOA_;
		}
		set
		{
			aBAIAEMNEOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JILAPGBHFJI GMOAOGGMCPD
	{
		get
		{
			return gMOAOGGMCPD_;
		}
		set
		{
			gMOAOGGMCPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleModuleType KIOBEGHMGAE
	{
		get
		{
			return kIOBEGHMGAE_;
		}
		set
		{
			kIOBEGHMGAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleEventBattleInfo> BattleEvent => battleEvent_;

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
	public MCKLCDAOECD ODLBOKHDANL
	{
		get
		{
			return oDLBOKHDANL_;
		}
		set
		{
			oDLBOKHDANL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString PLIAFNPANGN
	{
		get
		{
			return pLIAFNPANGN_;
		}
		set
		{
			pLIAFNPANGN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ENECPEOGEKG
	{
		get
		{
			return eNECPEOGEKG_;
		}
		set
		{
			eNECPEOGEKG_ = value;
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
	public BAFDFBJHLGK PJPFIIGBIAH
	{
		get
		{
			return pJPFIIGBIAH_;
		}
		set
		{
			pJPFIIGBIAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMPELPKFHH DGEMJCAEOJI
	{
		get
		{
			return dGEMJCAEOJI_;
		}
		set
		{
			dGEMJCAEOJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHDDKILAJCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHDDKILAJCJ(BHDDKILAJCJ other)
		: this()
	{
		version_ = other.version_;
		logicRandomSeed_ = other.logicRandomSeed_;
		stageId_ = other.stageId_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		opList_ = other.opList_.Clone();
		turnSnapshotHash_ = other.turnSnapshotHash_;
		kKPEEKMDJNE_ = other.kKPEEKMDJNE_;
		eHGEMEIKJBH_ = other.eHGEMEIKJBH_.Clone();
		aBAIAEMNEOA_ = other.aBAIAEMNEOA_;
		gMOAOGGMCPD_ = other.gMOAOGGMCPD_;
		kIOBEGHMGAE_ = other.kIOBEGHMGAE_;
		battleEvent_ = other.battleEvent_.Clone();
		roundsLimit_ = other.roundsLimit_;
		oDLBOKHDANL_ = ((other.oDLBOKHDANL_ != null) ? other.oDLBOKHDANL_.Clone() : null);
		pLIAFNPANGN_ = other.pLIAFNPANGN_;
		eNECPEOGEKG_ = other.eNECPEOGEKG_;
		monsterWaveLength_ = other.monsterWaveLength_;
		pJPFIIGBIAH_ = ((other.pJPFIIGBIAH_ != null) ? other.pJPFIIGBIAH_.Clone() : null);
		dGEMJCAEOJI_ = ((other.dGEMJCAEOJI_ != null) ? other.dGEMJCAEOJI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHDDKILAJCJ Clone()
	{
		return new BHDDKILAJCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BHDDKILAJCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BHDDKILAJCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (LogicRandomSeed != other.LogicRandomSeed)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!opList_.Equals(other.opList_))
		{
			return false;
		}
		if (TurnSnapshotHash != other.TurnSnapshotHash)
		{
			return false;
		}
		if (KKPEEKMDJNE != other.KKPEEKMDJNE)
		{
			return false;
		}
		if (!eHGEMEIKJBH_.Equals(other.eHGEMEIKJBH_))
		{
			return false;
		}
		if (ABAIAEMNEOA != other.ABAIAEMNEOA)
		{
			return false;
		}
		if (GMOAOGGMCPD != other.GMOAOGGMCPD)
		{
			return false;
		}
		if (KIOBEGHMGAE != other.KIOBEGHMGAE)
		{
			return false;
		}
		if (!battleEvent_.Equals(other.battleEvent_))
		{
			return false;
		}
		if (RoundsLimit != other.RoundsLimit)
		{
			return false;
		}
		if (!object.Equals(ODLBOKHDANL, other.ODLBOKHDANL))
		{
			return false;
		}
		if (PLIAFNPANGN != other.PLIAFNPANGN)
		{
			return false;
		}
		if (ENECPEOGEKG != other.ENECPEOGEKG)
		{
			return false;
		}
		if (MonsterWaveLength != other.MonsterWaveLength)
		{
			return false;
		}
		if (!object.Equals(PJPFIIGBIAH, other.PJPFIIGBIAH))
		{
			return false;
		}
		if (!object.Equals(DGEMJCAEOJI, other.DGEMJCAEOJI))
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
		if (Version != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (LogicRandomSeed != 0)
		{
			num ^= LogicRandomSeed.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		num ^= opList_.GetHashCode();
		if (TurnSnapshotHash.Length != 0)
		{
			num ^= TurnSnapshotHash.GetHashCode();
		}
		if (KKPEEKMDJNE != 0)
		{
			num ^= KKPEEKMDJNE.GetHashCode();
		}
		num ^= eHGEMEIKJBH_.GetHashCode();
		if (ABAIAEMNEOA)
		{
			num ^= ABAIAEMNEOA.GetHashCode();
		}
		if (GMOAOGGMCPD != JILAPGBHFJI.Lmjldgfjflc)
		{
			num ^= GMOAOGGMCPD.GetHashCode();
		}
		if (KIOBEGHMGAE != BattleModuleType.InhpdhlohhoHajdakfienm)
		{
			num ^= KIOBEGHMGAE.GetHashCode();
		}
		num ^= battleEvent_.GetHashCode();
		if (RoundsLimit != 0)
		{
			num ^= RoundsLimit.GetHashCode();
		}
		if (oDLBOKHDANL_ != null)
		{
			num ^= ODLBOKHDANL.GetHashCode();
		}
		if (PLIAFNPANGN.Length != 0)
		{
			num ^= PLIAFNPANGN.GetHashCode();
		}
		if (ENECPEOGEKG != 0)
		{
			num ^= ENECPEOGEKG.GetHashCode();
		}
		if (MonsterWaveLength != 0)
		{
			num ^= MonsterWaveLength.GetHashCode();
		}
		if (pJPFIIGBIAH_ != null)
		{
			num ^= PJPFIIGBIAH.GetHashCode();
		}
		if (dGEMJCAEOJI_ != null)
		{
			num ^= DGEMJCAEOJI.GetHashCode();
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
		if (Version != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Version);
		}
		if (LogicRandomSeed != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LogicRandomSeed);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(StageId);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Lineup);
		}
		opList_.WriteTo(ref output, _repeated_opList_codec);
		if (TurnSnapshotHash.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteBytes(TurnSnapshotHash);
		}
		if (KKPEEKMDJNE != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KKPEEKMDJNE);
		}
		eHGEMEIKJBH_.WriteTo(ref output, _repeated_eHGEMEIKJBH_codec);
		if (ABAIAEMNEOA)
		{
			output.WriteRawTag(72);
			output.WriteBool(ABAIAEMNEOA);
		}
		if (GMOAOGGMCPD != JILAPGBHFJI.Lmjldgfjflc)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)GMOAOGGMCPD);
		}
		if (KIOBEGHMGAE != BattleModuleType.InhpdhlohhoHajdakfienm)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)KIOBEGHMGAE);
		}
		battleEvent_.WriteTo(ref output, _repeated_battleEvent_codec);
		if (RoundsLimit != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(RoundsLimit);
		}
		if (oDLBOKHDANL_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(ODLBOKHDANL);
		}
		if (PLIAFNPANGN.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteBytes(PLIAFNPANGN);
		}
		if (ENECPEOGEKG != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(ENECPEOGEKG);
		}
		if (MonsterWaveLength != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteUInt32(MonsterWaveLength);
		}
		if (pJPFIIGBIAH_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(PJPFIIGBIAH);
		}
		if (dGEMJCAEOJI_ != null)
		{
			output.WriteRawTag(162, 6);
			output.WriteMessage(DGEMJCAEOJI);
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
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		if (LogicRandomSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LogicRandomSeed);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		num += opList_.CalculateSize(_repeated_opList_codec);
		if (TurnSnapshotHash.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(TurnSnapshotHash);
		}
		if (KKPEEKMDJNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKPEEKMDJNE);
		}
		num += eHGEMEIKJBH_.CalculateSize(_repeated_eHGEMEIKJBH_codec);
		if (ABAIAEMNEOA)
		{
			num += 2;
		}
		if (GMOAOGGMCPD != JILAPGBHFJI.Lmjldgfjflc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GMOAOGGMCPD);
		}
		if (KIOBEGHMGAE != BattleModuleType.InhpdhlohhoHajdakfienm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KIOBEGHMGAE);
		}
		num += battleEvent_.CalculateSize(_repeated_battleEvent_codec);
		if (RoundsLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoundsLimit);
		}
		if (oDLBOKHDANL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ODLBOKHDANL);
		}
		if (PLIAFNPANGN.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeBytesSize(PLIAFNPANGN);
		}
		if (ENECPEOGEKG != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ENECPEOGEKG);
		}
		if (MonsterWaveLength != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MonsterWaveLength);
		}
		if (pJPFIIGBIAH_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PJPFIIGBIAH);
		}
		if (dGEMJCAEOJI_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DGEMJCAEOJI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BHDDKILAJCJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Version != 0)
		{
			Version = other.Version;
		}
		if (other.LogicRandomSeed != 0)
		{
			LogicRandomSeed = other.LogicRandomSeed;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new BNAEFBKJOGE();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		opList_.Add(other.opList_);
		if (other.TurnSnapshotHash.Length != 0)
		{
			TurnSnapshotHash = other.TurnSnapshotHash;
		}
		if (other.KKPEEKMDJNE != 0)
		{
			KKPEEKMDJNE = other.KKPEEKMDJNE;
		}
		eHGEMEIKJBH_.Add(other.eHGEMEIKJBH_);
		if (other.ABAIAEMNEOA)
		{
			ABAIAEMNEOA = other.ABAIAEMNEOA;
		}
		if (other.GMOAOGGMCPD != JILAPGBHFJI.Lmjldgfjflc)
		{
			GMOAOGGMCPD = other.GMOAOGGMCPD;
		}
		if (other.KIOBEGHMGAE != BattleModuleType.InhpdhlohhoHajdakfienm)
		{
			KIOBEGHMGAE = other.KIOBEGHMGAE;
		}
		battleEvent_.Add(other.battleEvent_);
		if (other.RoundsLimit != 0)
		{
			RoundsLimit = other.RoundsLimit;
		}
		if (other.oDLBOKHDANL_ != null)
		{
			if (oDLBOKHDANL_ == null)
			{
				ODLBOKHDANL = new MCKLCDAOECD();
			}
			ODLBOKHDANL.MergeFrom(other.ODLBOKHDANL);
		}
		if (other.PLIAFNPANGN.Length != 0)
		{
			PLIAFNPANGN = other.PLIAFNPANGN;
		}
		if (other.ENECPEOGEKG != 0)
		{
			ENECPEOGEKG = other.ENECPEOGEKG;
		}
		if (other.MonsterWaveLength != 0)
		{
			MonsterWaveLength = other.MonsterWaveLength;
		}
		if (other.pJPFIIGBIAH_ != null)
		{
			if (pJPFIIGBIAH_ == null)
			{
				PJPFIIGBIAH = new BAFDFBJHLGK();
			}
			PJPFIIGBIAH.MergeFrom(other.PJPFIIGBIAH);
		}
		if (other.dGEMJCAEOJI_ != null)
		{
			if (dGEMJCAEOJI_ == null)
			{
				DGEMJCAEOJI = new LBMPELPKFHH();
			}
			DGEMJCAEOJI.MergeFrom(other.DGEMJCAEOJI);
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
				Version = input.ReadUInt32();
				break;
			case 16u:
				LogicRandomSeed = input.ReadUInt32();
				break;
			case 24u:
				StageId = input.ReadUInt32();
				break;
			case 34u:
				if (lineup_ == null)
				{
					Lineup = new BNAEFBKJOGE();
				}
				input.ReadMessage(Lineup);
				break;
			case 42u:
				opList_.AddEntriesFrom(ref input, _repeated_opList_codec);
				break;
			case 50u:
				TurnSnapshotHash = input.ReadBytes();
				break;
			case 56u:
				KKPEEKMDJNE = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				eHGEMEIKJBH_.AddEntriesFrom(ref input, _repeated_eHGEMEIKJBH_codec);
				break;
			case 72u:
				ABAIAEMNEOA = input.ReadBool();
				break;
			case 80u:
				GMOAOGGMCPD = (JILAPGBHFJI)input.ReadEnum();
				break;
			case 88u:
				KIOBEGHMGAE = (BattleModuleType)input.ReadEnum();
				break;
			case 98u:
				battleEvent_.AddEntriesFrom(ref input, _repeated_battleEvent_codec);
				break;
			case 112u:
				RoundsLimit = input.ReadUInt32();
				break;
			case 122u:
				if (oDLBOKHDANL_ == null)
				{
					ODLBOKHDANL = new MCKLCDAOECD();
				}
				input.ReadMessage(ODLBOKHDANL);
				break;
			case 130u:
				PLIAFNPANGN = input.ReadBytes();
				break;
			case 136u:
				ENECPEOGEKG = input.ReadUInt32();
				break;
			case 144u:
				MonsterWaveLength = input.ReadUInt32();
				break;
			case 154u:
				if (pJPFIIGBIAH_ == null)
				{
					PJPFIIGBIAH = new BAFDFBJHLGK();
				}
				input.ReadMessage(PJPFIIGBIAH);
				break;
			case 802u:
				if (dGEMJCAEOJI_ == null)
				{
					DGEMJCAEOJI = new LBMPELPKFHH();
				}
				input.ReadMessage(DGEMJCAEOJI);
				break;
			}
		}
	}
}
