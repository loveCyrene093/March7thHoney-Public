using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PVEBattleResultCsReq : IMessage<PVEBattleResultCsReq>, IMessage, IEquatable<PVEBattleResultCsReq>, IDeepCloneable<PVEBattleResultCsReq>, IBufferMessage
{
	private static readonly MessageParser<PVEBattleResultCsReq> _parser = new MessageParser<PVEBattleResultCsReq>(() => new PVEBattleResultCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CGKFIKKNGJNFieldNumber = 1;

	private static readonly MapField<string, uint>.Codec _map_cGKFIKKNGJN_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 10u);

	private readonly MapField<string, uint> cGKFIKKNGJN_ = new MapField<string, uint>();

	public const int OpListFieldNumber = 2;

	private static readonly FieldCodec<BattleOp> _repeated_opList_codec = FieldCodec.ForMessage(18u, BattleOp.Parser);

	private readonly RepeatedField<BattleOp> opList_ = new RepeatedField<BattleOp>();

	public const int SttFieldNumber = 3;

	private BattleStatistics stt_;

	public const int CostTimeFieldNumber = 4;

	private uint costTime_;

	public const int KIBMEMNCCDNFieldNumber = 5;

	private bool kIBMEMNCCDN_;

	public const int DebugExtraInfoFieldNumber = 6;

	private string debugExtraInfo_ = "";

	public const int ENECPEOGEKGFieldNumber = 7;

	private uint eNECPEOGEKG_;

	public const int EndStatusFieldNumber = 8;

	private BattleEndStatus endStatus_;

	public const int ABAIAEMNEOAFieldNumber = 9;

	private bool aBAIAEMNEOA_;

	public const int DGMPDHINPKKFieldNumber = 10;

	private uint dGMPDHINPKK_;

	public const int JIODDAHNMELFieldNumber = 11;

	private bool jIODDAHNMEL_;

	public const int ClientResVersionFieldNumber = 12;

	private uint clientResVersion_;

	public const int TurnSnapshotHashFieldNumber = 13;

	private ByteString turnSnapshotHash_ = ByteString.Empty;

	public const int StageIdFieldNumber = 14;

	private uint stageId_;

	public const int BattleIdFieldNumber = 15;

	private uint battleId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PVEBattleResultCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PVEBattleResultCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> CGKFIKKNGJN => cGKFIKKNGJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleOp> OpList => opList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KIBMEMNCCDN
	{
		get
		{
			return kIBMEMNCCDN_;
		}
		set
		{
			kIBMEMNCCDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DebugExtraInfo
	{
		get
		{
			return debugExtraInfo_;
		}
		set
		{
			debugExtraInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public BattleEndStatus EndStatus
	{
		get
		{
			return endStatus_;
		}
		set
		{
			endStatus_ = value;
		}
	}

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
	public uint DGMPDHINPKK
	{
		get
		{
			return dGMPDHINPKK_;
		}
		set
		{
			dGMPDHINPKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JIODDAHNMEL
	{
		get
		{
			return jIODDAHNMEL_;
		}
		set
		{
			jIODDAHNMEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClientResVersion
	{
		get
		{
			return clientResVersion_;
		}
		set
		{
			clientResVersion_ = value;
		}
	}

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
	public PVEBattleResultCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PVEBattleResultCsReq(PVEBattleResultCsReq other)
		: this()
	{
		cGKFIKKNGJN_ = other.cGKFIKKNGJN_.Clone();
		opList_ = other.opList_.Clone();
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		costTime_ = other.costTime_;
		kIBMEMNCCDN_ = other.kIBMEMNCCDN_;
		debugExtraInfo_ = other.debugExtraInfo_;
		eNECPEOGEKG_ = other.eNECPEOGEKG_;
		endStatus_ = other.endStatus_;
		aBAIAEMNEOA_ = other.aBAIAEMNEOA_;
		dGMPDHINPKK_ = other.dGMPDHINPKK_;
		jIODDAHNMEL_ = other.jIODDAHNMEL_;
		clientResVersion_ = other.clientResVersion_;
		turnSnapshotHash_ = other.turnSnapshotHash_;
		stageId_ = other.stageId_;
		battleId_ = other.battleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PVEBattleResultCsReq Clone()
	{
		return new PVEBattleResultCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PVEBattleResultCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PVEBattleResultCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!CGKFIKKNGJN.Equals(other.CGKFIKKNGJN))
		{
			return false;
		}
		if (!opList_.Equals(other.opList_))
		{
			return false;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (KIBMEMNCCDN != other.KIBMEMNCCDN)
		{
			return false;
		}
		if (DebugExtraInfo != other.DebugExtraInfo)
		{
			return false;
		}
		if (ENECPEOGEKG != other.ENECPEOGEKG)
		{
			return false;
		}
		if (EndStatus != other.EndStatus)
		{
			return false;
		}
		if (ABAIAEMNEOA != other.ABAIAEMNEOA)
		{
			return false;
		}
		if (DGMPDHINPKK != other.DGMPDHINPKK)
		{
			return false;
		}
		if (JIODDAHNMEL != other.JIODDAHNMEL)
		{
			return false;
		}
		if (ClientResVersion != other.ClientResVersion)
		{
			return false;
		}
		if (TurnSnapshotHash != other.TurnSnapshotHash)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (BattleId != other.BattleId)
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
		num ^= CGKFIKKNGJN.GetHashCode();
		num ^= opList_.GetHashCode();
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		if (KIBMEMNCCDN)
		{
			num ^= KIBMEMNCCDN.GetHashCode();
		}
		if (DebugExtraInfo.Length != 0)
		{
			num ^= DebugExtraInfo.GetHashCode();
		}
		if (ENECPEOGEKG != 0)
		{
			num ^= ENECPEOGEKG.GetHashCode();
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num ^= EndStatus.GetHashCode();
		}
		if (ABAIAEMNEOA)
		{
			num ^= ABAIAEMNEOA.GetHashCode();
		}
		if (DGMPDHINPKK != 0)
		{
			num ^= DGMPDHINPKK.GetHashCode();
		}
		if (JIODDAHNMEL)
		{
			num ^= JIODDAHNMEL.GetHashCode();
		}
		if (ClientResVersion != 0)
		{
			num ^= ClientResVersion.GetHashCode();
		}
		if (TurnSnapshotHash.Length != 0)
		{
			num ^= TurnSnapshotHash.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
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
		cGKFIKKNGJN_.WriteTo(ref output, _map_cGKFIKKNGJN_codec);
		opList_.WriteTo(ref output, _repeated_opList_codec);
		if (stt_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Stt);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CostTime);
		}
		if (KIBMEMNCCDN)
		{
			output.WriteRawTag(40);
			output.WriteBool(KIBMEMNCCDN);
		}
		if (DebugExtraInfo.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DebugExtraInfo);
		}
		if (ENECPEOGEKG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ENECPEOGEKG);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)EndStatus);
		}
		if (ABAIAEMNEOA)
		{
			output.WriteRawTag(72);
			output.WriteBool(ABAIAEMNEOA);
		}
		if (DGMPDHINPKK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DGMPDHINPKK);
		}
		if (JIODDAHNMEL)
		{
			output.WriteRawTag(88);
			output.WriteBool(JIODDAHNMEL);
		}
		if (ClientResVersion != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ClientResVersion);
		}
		if (TurnSnapshotHash.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteBytes(TurnSnapshotHash);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(StageId);
		}
		if (BattleId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BattleId);
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
		num += cGKFIKKNGJN_.CalculateSize(_map_cGKFIKKNGJN_codec);
		num += opList_.CalculateSize(_repeated_opList_codec);
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (KIBMEMNCCDN)
		{
			num += 2;
		}
		if (DebugExtraInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DebugExtraInfo);
		}
		if (ENECPEOGEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENECPEOGEKG);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndStatus);
		}
		if (ABAIAEMNEOA)
		{
			num += 2;
		}
		if (DGMPDHINPKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGMPDHINPKK);
		}
		if (JIODDAHNMEL)
		{
			num += 2;
		}
		if (ClientResVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientResVersion);
		}
		if (TurnSnapshotHash.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(TurnSnapshotHash);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PVEBattleResultCsReq other)
	{
		if (other == null)
		{
			return;
		}
		cGKFIKKNGJN_.MergeFrom(other.cGKFIKKNGJN_);
		opList_.Add(other.opList_);
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new BattleStatistics();
			}
			Stt.MergeFrom(other.Stt);
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
		}
		if (other.KIBMEMNCCDN)
		{
			KIBMEMNCCDN = other.KIBMEMNCCDN;
		}
		if (other.DebugExtraInfo.Length != 0)
		{
			DebugExtraInfo = other.DebugExtraInfo;
		}
		if (other.ENECPEOGEKG != 0)
		{
			ENECPEOGEKG = other.ENECPEOGEKG;
		}
		if (other.EndStatus != BattleEndStatus.BattleEndNone)
		{
			EndStatus = other.EndStatus;
		}
		if (other.ABAIAEMNEOA)
		{
			ABAIAEMNEOA = other.ABAIAEMNEOA;
		}
		if (other.DGMPDHINPKK != 0)
		{
			DGMPDHINPKK = other.DGMPDHINPKK;
		}
		if (other.JIODDAHNMEL)
		{
			JIODDAHNMEL = other.JIODDAHNMEL;
		}
		if (other.ClientResVersion != 0)
		{
			ClientResVersion = other.ClientResVersion;
		}
		if (other.TurnSnapshotHash.Length != 0)
		{
			TurnSnapshotHash = other.TurnSnapshotHash;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.BattleId != 0)
		{
			BattleId = other.BattleId;
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
			case 10u:
				cGKFIKKNGJN_.AddEntriesFrom(ref input, _map_cGKFIKKNGJN_codec);
				break;
			case 18u:
				opList_.AddEntriesFrom(ref input, _repeated_opList_codec);
				break;
			case 26u:
				if (stt_ == null)
				{
					Stt = new BattleStatistics();
				}
				input.ReadMessage(Stt);
				break;
			case 32u:
				CostTime = input.ReadUInt32();
				break;
			case 40u:
				KIBMEMNCCDN = input.ReadBool();
				break;
			case 50u:
				DebugExtraInfo = input.ReadString();
				break;
			case 56u:
				ENECPEOGEKG = input.ReadUInt32();
				break;
			case 64u:
				EndStatus = (BattleEndStatus)input.ReadEnum();
				break;
			case 72u:
				ABAIAEMNEOA = input.ReadBool();
				break;
			case 80u:
				DGMPDHINPKK = input.ReadUInt32();
				break;
			case 88u:
				JIODDAHNMEL = input.ReadBool();
				break;
			case 96u:
				ClientResVersion = input.ReadUInt32();
				break;
			case 106u:
				TurnSnapshotHash = input.ReadBytes();
				break;
			case 112u:
				StageId = input.ReadUInt32();
				break;
			case 120u:
				BattleId = input.ReadUInt32();
				break;
			}
		}
	}
}
