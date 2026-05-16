using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNAEFBKJOGE : IMessage<BNAEFBKJOGE>, IMessage, IEquatable<BNAEFBKJOGE>, IDeepCloneable<BNAEFBKJOGE>, IBufferMessage
{
	private static readonly MessageParser<BNAEFBKJOGE> _parser = new MessageParser<BNAEFBKJOGE>(() => new BNAEFBKJOGE());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<BattleAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, BattleAvatar.Parser);

	private readonly RepeatedField<BattleAvatar> avatarList_ = new RepeatedField<BattleAvatar>();

	public const int MonsterWaveListFieldNumber = 2;

	private static readonly FieldCodec<BattleMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage(18u, BattleMonsterWave.Parser);

	private readonly RepeatedField<BattleMonsterWave> monsterWaveList_ = new RepeatedField<BattleMonsterWave>();

	public const int BuffListFieldNumber = 3;

	private static readonly FieldCodec<BattleBuff> _repeated_buffList_codec = FieldCodec.ForMessage(26u, BattleBuff.Parser);

	private readonly RepeatedField<BattleBuff> buffList_ = new RepeatedField<BattleBuff>();

	public const int WorldLevelFieldNumber = 7;

	private uint worldLevel_;

	public const int BattleTargetInfoFieldNumber = 9;

	private static readonly MapField<uint, BattleTargetList>.Codec _map_battleTargetInfo_codec = new MapField<uint, BattleTargetList>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, BattleTargetList.Parser), 74u);

	private readonly MapField<uint, BattleTargetList> battleTargetInfo_ = new MapField<uint, BattleTargetList>();

	public const int GDAGHIJADODFieldNumber = 10;

	private KCGPMNNKIKN gDAGHIJADOD_;

	public const int LILELAAIGIKFieldNumber = 11;

	private static readonly FieldCodec<BattleAvatar> _repeated_lILELAAIGIK_codec = FieldCodec.ForMessage(90u, BattleAvatar.Parser);

	private readonly RepeatedField<BattleAvatar> lILELAAIGIK_ = new RepeatedField<BattleAvatar>();

	public const int FMCJPPILPLLFieldNumber = 12;

	private BattleGridFightSpecialBattleInfo fMCJPPILPLL_;

	public const int OBOFOCPCBPKFieldNumber = 13;

	private MLDEDCCOHBF oBOFOCPCBPK_;

	public const int BattleRogueMagicInfoFieldNumber = 14;

	private BattleRogueMagicInfo battleRogueMagicInfo_;

	public const int IAJDCJIAHFPFieldNumber = 15;

	private CAKGOGMEJOF iAJDCJIAHFP_;

	public const int AFCMOOFGBPKFieldNumber = 16;

	private OGEOMDJIAGI aFCMOOFGBPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNAEFBKJOGE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNAEFBKJOGEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleAvatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleMonsterWave> MonsterWaveList => monsterWaveList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleBuff> BuffList => buffList_;

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
	public RepeatedField<BattleAvatar> LILELAAIGIK => lILELAAIGIK_;

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
	public BNAEFBKJOGE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNAEFBKJOGE(BNAEFBKJOGE other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		monsterWaveList_ = other.monsterWaveList_.Clone();
		buffList_ = other.buffList_.Clone();
		worldLevel_ = other.worldLevel_;
		battleTargetInfo_ = other.battleTargetInfo_.Clone();
		gDAGHIJADOD_ = ((other.gDAGHIJADOD_ != null) ? other.gDAGHIJADOD_.Clone() : null);
		lILELAAIGIK_ = other.lILELAAIGIK_.Clone();
		fMCJPPILPLL_ = ((other.fMCJPPILPLL_ != null) ? other.fMCJPPILPLL_.Clone() : null);
		oBOFOCPCBPK_ = ((other.oBOFOCPCBPK_ != null) ? other.oBOFOCPCBPK_.Clone() : null);
		battleRogueMagicInfo_ = ((other.battleRogueMagicInfo_ != null) ? other.battleRogueMagicInfo_.Clone() : null);
		iAJDCJIAHFP_ = ((other.iAJDCJIAHFP_ != null) ? other.iAJDCJIAHFP_.Clone() : null);
		aFCMOOFGBPK_ = ((other.aFCMOOFGBPK_ != null) ? other.aFCMOOFGBPK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNAEFBKJOGE Clone()
	{
		return new BNAEFBKJOGE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNAEFBKJOGE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNAEFBKJOGE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!monsterWaveList_.Equals(other.monsterWaveList_))
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
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
		if (!lILELAAIGIK_.Equals(other.lILELAAIGIK_))
		{
			return false;
		}
		if (!object.Equals(FMCJPPILPLL, other.FMCJPPILPLL))
		{
			return false;
		}
		if (!object.Equals(OBOFOCPCBPK, other.OBOFOCPCBPK))
		{
			return false;
		}
		if (!object.Equals(BattleRogueMagicInfo, other.BattleRogueMagicInfo))
		{
			return false;
		}
		if (!object.Equals(IAJDCJIAHFP, other.IAJDCJIAHFP))
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
		num ^= avatarList_.GetHashCode();
		num ^= monsterWaveList_.GetHashCode();
		num ^= buffList_.GetHashCode();
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		num ^= BattleTargetInfo.GetHashCode();
		if (gDAGHIJADOD_ != null)
		{
			num ^= GDAGHIJADOD.GetHashCode();
		}
		num ^= lILELAAIGIK_.GetHashCode();
		if (fMCJPPILPLL_ != null)
		{
			num ^= FMCJPPILPLL.GetHashCode();
		}
		if (oBOFOCPCBPK_ != null)
		{
			num ^= OBOFOCPCBPK.GetHashCode();
		}
		if (battleRogueMagicInfo_ != null)
		{
			num ^= BattleRogueMagicInfo.GetHashCode();
		}
		if (iAJDCJIAHFP_ != null)
		{
			num ^= IAJDCJIAHFP.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		if (WorldLevel != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(WorldLevel);
		}
		battleTargetInfo_.WriteTo(ref output, _map_battleTargetInfo_codec);
		if (gDAGHIJADOD_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(GDAGHIJADOD);
		}
		lILELAAIGIK_.WriteTo(ref output, _repeated_lILELAAIGIK_codec);
		if (fMCJPPILPLL_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FMCJPPILPLL);
		}
		if (oBOFOCPCBPK_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(OBOFOCPCBPK);
		}
		if (battleRogueMagicInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BattleRogueMagicInfo);
		}
		if (iAJDCJIAHFP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(IAJDCJIAHFP);
		}
		if (aFCMOOFGBPK_ != null)
		{
			output.WriteRawTag(130, 1);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		num += battleTargetInfo_.CalculateSize(_map_battleTargetInfo_codec);
		if (gDAGHIJADOD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GDAGHIJADOD);
		}
		num += lILELAAIGIK_.CalculateSize(_repeated_lILELAAIGIK_codec);
		if (fMCJPPILPLL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMCJPPILPLL);
		}
		if (oBOFOCPCBPK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OBOFOCPCBPK);
		}
		if (battleRogueMagicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleRogueMagicInfo);
		}
		if (iAJDCJIAHFP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IAJDCJIAHFP);
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
	public void MergeFrom(BNAEFBKJOGE other)
	{
		if (other == null)
		{
			return;
		}
		avatarList_.Add(other.avatarList_);
		monsterWaveList_.Add(other.monsterWaveList_);
		buffList_.Add(other.buffList_);
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
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
		lILELAAIGIK_.Add(other.lILELAAIGIK_);
		if (other.fMCJPPILPLL_ != null)
		{
			if (fMCJPPILPLL_ == null)
			{
				FMCJPPILPLL = new BattleGridFightSpecialBattleInfo();
			}
			FMCJPPILPLL.MergeFrom(other.FMCJPPILPLL);
		}
		if (other.oBOFOCPCBPK_ != null)
		{
			if (oBOFOCPCBPK_ == null)
			{
				OBOFOCPCBPK = new MLDEDCCOHBF();
			}
			OBOFOCPCBPK.MergeFrom(other.OBOFOCPCBPK);
		}
		if (other.battleRogueMagicInfo_ != null)
		{
			if (battleRogueMagicInfo_ == null)
			{
				BattleRogueMagicInfo = new BattleRogueMagicInfo();
			}
			BattleRogueMagicInfo.MergeFrom(other.BattleRogueMagicInfo);
		}
		if (other.iAJDCJIAHFP_ != null)
		{
			if (iAJDCJIAHFP_ == null)
			{
				IAJDCJIAHFP = new CAKGOGMEJOF();
			}
			IAJDCJIAHFP.MergeFrom(other.IAJDCJIAHFP);
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
			case 10u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 18u:
				monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
				break;
			case 26u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 56u:
				WorldLevel = input.ReadUInt32();
				break;
			case 74u:
				battleTargetInfo_.AddEntriesFrom(ref input, _map_battleTargetInfo_codec);
				break;
			case 82u:
				if (gDAGHIJADOD_ == null)
				{
					GDAGHIJADOD = new KCGPMNNKIKN();
				}
				input.ReadMessage(GDAGHIJADOD);
				break;
			case 90u:
				lILELAAIGIK_.AddEntriesFrom(ref input, _repeated_lILELAAIGIK_codec);
				break;
			case 98u:
				if (fMCJPPILPLL_ == null)
				{
					FMCJPPILPLL = new BattleGridFightSpecialBattleInfo();
				}
				input.ReadMessage(FMCJPPILPLL);
				break;
			case 106u:
				if (oBOFOCPCBPK_ == null)
				{
					OBOFOCPCBPK = new MLDEDCCOHBF();
				}
				input.ReadMessage(OBOFOCPCBPK);
				break;
			case 114u:
				if (battleRogueMagicInfo_ == null)
				{
					BattleRogueMagicInfo = new BattleRogueMagicInfo();
				}
				input.ReadMessage(BattleRogueMagicInfo);
				break;
			case 122u:
				if (iAJDCJIAHFP_ == null)
				{
					IAJDCJIAHFP = new CAKGOGMEJOF();
				}
				input.ReadMessage(IAJDCJIAHFP);
				break;
			case 130u:
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
