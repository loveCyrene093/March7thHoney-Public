using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerDetailInfo : IMessage<PlayerDetailInfo>, IMessage, IEquatable<PlayerDetailInfo>, IDeepCloneable<PlayerDetailInfo>, IBufferMessage
{
	private static readonly MessageParser<PlayerDetailInfo> _parser = new MessageParser<PlayerDetailInfo>(() => new PlayerDetailInfo());

	private UnknownFieldSet _unknownFields;

	public const int HBIDCAFOPMGFieldNumber = 1;

	private string hBIDCAFOPMG_ = "";

	public const int HeadIconFieldNumber = 2;

	private uint headIcon_;

	public const int RecordInfoFieldNumber = 3;

	private PlayerRecordInfo recordInfo_;

	public const int ICJIGHOMDNLFieldNumber = 4;

	private string iCJIGHOMDNL_ = "";

	public const int NicknameFieldNumber = 5;

	private string nickname_ = "";

	public const int LevelFieldNumber = 6;

	private uint level_;

	public const int OGJGMNBPPLEFieldNumber = 7;

	private uint oGJGMNBPPLE_;

	public const int DisplayAvatarListFieldNumber = 8;

	private static readonly FieldCodec<DisplayAvatarDetailInfo> _repeated_displayAvatarList_codec = FieldCodec.ForMessage(66u, DisplayAvatarDetailInfo.Parser);

	private readonly RepeatedField<DisplayAvatarDetailInfo> displayAvatarList_ = new RepeatedField<DisplayAvatarDetailInfo>();

	public const int OLJFBHKLAJPFieldNumber = 9;

	private uint oLJFBHKLAJP_;

	public const int UidFieldNumber = 10;

	private uint uid_;

	public const int SignatureFieldNumber = 11;

	private string signature_ = "";

	public const int NHIDOAAMLNFFieldNumber = 12;

	private bool nHIDOAAMLNF_;

	public const int PlatformFieldNumber = 13;

	private PlatformType platform_;

	public const int IsBannedFieldNumber = 14;

	private bool isBanned_;

	public const int WorldLevelFieldNumber = 15;

	private uint worldLevel_;

	public const int PHKAMFFCKMLFieldNumber = 371;

	private uint pHKAMFFCKML_;

	public const int PlayerOutfitDataFieldNumber = 831;

	private PlayerOutfitInfo playerOutfitData_;

	public const int HeadFrameInfoFieldNumber = 1012;

	private HeadFrameInfo headFrameInfo_;

	public const int JIJOICCDFCAFieldNumber = 1039;

	private JKFBFGOEBKI jIJOICCDFCA_;

	public const int LCBGFPMCLNOFieldNumber = 1052;

	private MNBHEHAMOKL lCBGFPMCLNO_;

	public const int AssistAvatarListFieldNumber = 1809;

	private static readonly FieldCodec<DisplayAvatarDetailInfo> _repeated_assistAvatarList_codec = FieldCodec.ForMessage(14474u, DisplayAvatarDetailInfo.Parser);

	private readonly RepeatedField<DisplayAvatarDetailInfo> assistAvatarList_ = new RepeatedField<DisplayAvatarDetailInfo>();

	public const int GFPMLPGHONGFieldNumber = 1966;

	private KJGMAEGNBKL gFPMLPGHONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerDetailInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerDetailInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HBIDCAFOPMG
	{
		get
		{
			return hBIDCAFOPMG_;
		}
		set
		{
			hBIDCAFOPMG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HeadIcon
	{
		get
		{
			return headIcon_;
		}
		set
		{
			headIcon_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerRecordInfo RecordInfo
	{
		get
		{
			return recordInfo_;
		}
		set
		{
			recordInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ICJIGHOMDNL
	{
		get
		{
			return iCJIGHOMDNL_;
		}
		set
		{
			iCJIGHOMDNL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Nickname
	{
		get
		{
			return nickname_;
		}
		set
		{
			nickname_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint OGJGMNBPPLE
	{
		get
		{
			return oGJGMNBPPLE_;
		}
		set
		{
			oGJGMNBPPLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarDetailInfo> DisplayAvatarList => displayAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OLJFBHKLAJP
	{
		get
		{
			return oLJFBHKLAJP_;
		}
		set
		{
			oLJFBHKLAJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Signature
	{
		get
		{
			return signature_;
		}
		set
		{
			signature_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NHIDOAAMLNF
	{
		get
		{
			return nHIDOAAMLNF_;
		}
		set
		{
			nHIDOAAMLNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlatformType Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsBanned
	{
		get
		{
			return isBanned_;
		}
		set
		{
			isBanned_ = value;
		}
	}

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
	public uint PHKAMFFCKML
	{
		get
		{
			return pHKAMFFCKML_;
		}
		set
		{
			pHKAMFFCKML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerOutfitInfo PlayerOutfitData
	{
		get
		{
			return playerOutfitData_;
		}
		set
		{
			playerOutfitData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeadFrameInfo HeadFrameInfo
	{
		get
		{
			return headFrameInfo_;
		}
		set
		{
			headFrameInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKFBFGOEBKI JIJOICCDFCA
	{
		get
		{
			return jIJOICCDFCA_;
		}
		set
		{
			jIJOICCDFCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBHEHAMOKL LCBGFPMCLNO
	{
		get
		{
			return lCBGFPMCLNO_;
		}
		set
		{
			lCBGFPMCLNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarDetailInfo> AssistAvatarList => assistAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJGMAEGNBKL GFPMLPGHONG
	{
		get
		{
			return gFPMLPGHONG_;
		}
		set
		{
			gFPMLPGHONG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerDetailInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerDetailInfo(PlayerDetailInfo other)
		: this()
	{
		hBIDCAFOPMG_ = other.hBIDCAFOPMG_;
		headIcon_ = other.headIcon_;
		recordInfo_ = ((other.recordInfo_ != null) ? other.recordInfo_.Clone() : null);
		iCJIGHOMDNL_ = other.iCJIGHOMDNL_;
		nickname_ = other.nickname_;
		level_ = other.level_;
		oGJGMNBPPLE_ = other.oGJGMNBPPLE_;
		displayAvatarList_ = other.displayAvatarList_.Clone();
		oLJFBHKLAJP_ = other.oLJFBHKLAJP_;
		uid_ = other.uid_;
		signature_ = other.signature_;
		nHIDOAAMLNF_ = other.nHIDOAAMLNF_;
		platform_ = other.platform_;
		isBanned_ = other.isBanned_;
		worldLevel_ = other.worldLevel_;
		pHKAMFFCKML_ = other.pHKAMFFCKML_;
		playerOutfitData_ = ((other.playerOutfitData_ != null) ? other.playerOutfitData_.Clone() : null);
		headFrameInfo_ = ((other.headFrameInfo_ != null) ? other.headFrameInfo_.Clone() : null);
		jIJOICCDFCA_ = ((other.jIJOICCDFCA_ != null) ? other.jIJOICCDFCA_.Clone() : null);
		lCBGFPMCLNO_ = ((other.lCBGFPMCLNO_ != null) ? other.lCBGFPMCLNO_.Clone() : null);
		assistAvatarList_ = other.assistAvatarList_.Clone();
		gFPMLPGHONG_ = ((other.gFPMLPGHONG_ != null) ? other.gFPMLPGHONG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerDetailInfo Clone()
	{
		return new PlayerDetailInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerDetailInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerDetailInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBIDCAFOPMG != other.HBIDCAFOPMG)
		{
			return false;
		}
		if (HeadIcon != other.HeadIcon)
		{
			return false;
		}
		if (!object.Equals(RecordInfo, other.RecordInfo))
		{
			return false;
		}
		if (ICJIGHOMDNL != other.ICJIGHOMDNL)
		{
			return false;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (OGJGMNBPPLE != other.OGJGMNBPPLE)
		{
			return false;
		}
		if (!displayAvatarList_.Equals(other.displayAvatarList_))
		{
			return false;
		}
		if (OLJFBHKLAJP != other.OLJFBHKLAJP)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Signature != other.Signature)
		{
			return false;
		}
		if (NHIDOAAMLNF != other.NHIDOAAMLNF)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (IsBanned != other.IsBanned)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (PHKAMFFCKML != other.PHKAMFFCKML)
		{
			return false;
		}
		if (!object.Equals(PlayerOutfitData, other.PlayerOutfitData))
		{
			return false;
		}
		if (!object.Equals(HeadFrameInfo, other.HeadFrameInfo))
		{
			return false;
		}
		if (!object.Equals(JIJOICCDFCA, other.JIJOICCDFCA))
		{
			return false;
		}
		if (!object.Equals(LCBGFPMCLNO, other.LCBGFPMCLNO))
		{
			return false;
		}
		if (!assistAvatarList_.Equals(other.assistAvatarList_))
		{
			return false;
		}
		if (!object.Equals(GFPMLPGHONG, other.GFPMLPGHONG))
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
		if (HBIDCAFOPMG.Length != 0)
		{
			num ^= HBIDCAFOPMG.GetHashCode();
		}
		if (HeadIcon != 0)
		{
			num ^= HeadIcon.GetHashCode();
		}
		if (recordInfo_ != null)
		{
			num ^= RecordInfo.GetHashCode();
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			num ^= ICJIGHOMDNL.GetHashCode();
		}
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (OGJGMNBPPLE != 0)
		{
			num ^= OGJGMNBPPLE.GetHashCode();
		}
		num ^= displayAvatarList_.GetHashCode();
		if (OLJFBHKLAJP != 0)
		{
			num ^= OLJFBHKLAJP.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Signature.Length != 0)
		{
			num ^= Signature.GetHashCode();
		}
		if (NHIDOAAMLNF)
		{
			num ^= NHIDOAAMLNF.GetHashCode();
		}
		if (Platform != PlatformType.Editor)
		{
			num ^= Platform.GetHashCode();
		}
		if (IsBanned)
		{
			num ^= IsBanned.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (PHKAMFFCKML != 0)
		{
			num ^= PHKAMFFCKML.GetHashCode();
		}
		if (playerOutfitData_ != null)
		{
			num ^= PlayerOutfitData.GetHashCode();
		}
		if (headFrameInfo_ != null)
		{
			num ^= HeadFrameInfo.GetHashCode();
		}
		if (jIJOICCDFCA_ != null)
		{
			num ^= JIJOICCDFCA.GetHashCode();
		}
		if (lCBGFPMCLNO_ != null)
		{
			num ^= LCBGFPMCLNO.GetHashCode();
		}
		num ^= assistAvatarList_.GetHashCode();
		if (gFPMLPGHONG_ != null)
		{
			num ^= GFPMLPGHONG.GetHashCode();
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
		if (HBIDCAFOPMG.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(HBIDCAFOPMG);
		}
		if (HeadIcon != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HeadIcon);
		}
		if (recordInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RecordInfo);
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ICJIGHOMDNL);
		}
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Nickname);
		}
		if (Level != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Level);
		}
		if (OGJGMNBPPLE != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OGJGMNBPPLE);
		}
		displayAvatarList_.WriteTo(ref output, _repeated_displayAvatarList_codec);
		if (OLJFBHKLAJP != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OLJFBHKLAJP);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Uid);
		}
		if (Signature.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Signature);
		}
		if (NHIDOAAMLNF)
		{
			output.WriteRawTag(96);
			output.WriteBool(NHIDOAAMLNF);
		}
		if (Platform != PlatformType.Editor)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)Platform);
		}
		if (IsBanned)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsBanned);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(WorldLevel);
		}
		if (PHKAMFFCKML != 0)
		{
			output.WriteRawTag(152, 23);
			output.WriteUInt32(PHKAMFFCKML);
		}
		if (playerOutfitData_ != null)
		{
			output.WriteRawTag(250, 51);
			output.WriteMessage(PlayerOutfitData);
		}
		if (headFrameInfo_ != null)
		{
			output.WriteRawTag(162, 63);
			output.WriteMessage(HeadFrameInfo);
		}
		if (jIJOICCDFCA_ != null)
		{
			output.WriteRawTag(250, 64);
			output.WriteMessage(JIJOICCDFCA);
		}
		if (lCBGFPMCLNO_ != null)
		{
			output.WriteRawTag(226, 65);
			output.WriteMessage(LCBGFPMCLNO);
		}
		assistAvatarList_.WriteTo(ref output, _repeated_assistAvatarList_codec);
		if (gFPMLPGHONG_ != null)
		{
			output.WriteRawTag(242, 122);
			output.WriteMessage(GFPMLPGHONG);
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
		if (HBIDCAFOPMG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HBIDCAFOPMG);
		}
		if (HeadIcon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadIcon);
		}
		if (recordInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RecordInfo);
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ICJIGHOMDNL);
		}
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (OGJGMNBPPLE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGJGMNBPPLE);
		}
		num += displayAvatarList_.CalculateSize(_repeated_displayAvatarList_codec);
		if (OLJFBHKLAJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OLJFBHKLAJP);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Signature.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Signature);
		}
		if (NHIDOAAMLNF)
		{
			num += 2;
		}
		if (Platform != PlatformType.Editor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Platform);
		}
		if (IsBanned)
		{
			num += 2;
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (PHKAMFFCKML != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PHKAMFFCKML);
		}
		if (playerOutfitData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerOutfitData);
		}
		if (headFrameInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HeadFrameInfo);
		}
		if (jIJOICCDFCA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JIJOICCDFCA);
		}
		if (lCBGFPMCLNO_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LCBGFPMCLNO);
		}
		num += assistAvatarList_.CalculateSize(_repeated_assistAvatarList_codec);
		if (gFPMLPGHONG_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GFPMLPGHONG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerDetailInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HBIDCAFOPMG.Length != 0)
		{
			HBIDCAFOPMG = other.HBIDCAFOPMG;
		}
		if (other.HeadIcon != 0)
		{
			HeadIcon = other.HeadIcon;
		}
		if (other.recordInfo_ != null)
		{
			if (recordInfo_ == null)
			{
				RecordInfo = new PlayerRecordInfo();
			}
			RecordInfo.MergeFrom(other.RecordInfo);
		}
		if (other.ICJIGHOMDNL.Length != 0)
		{
			ICJIGHOMDNL = other.ICJIGHOMDNL;
		}
		if (other.Nickname.Length != 0)
		{
			Nickname = other.Nickname;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.OGJGMNBPPLE != 0)
		{
			OGJGMNBPPLE = other.OGJGMNBPPLE;
		}
		displayAvatarList_.Add(other.displayAvatarList_);
		if (other.OLJFBHKLAJP != 0)
		{
			OLJFBHKLAJP = other.OLJFBHKLAJP;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.Signature.Length != 0)
		{
			Signature = other.Signature;
		}
		if (other.NHIDOAAMLNF)
		{
			NHIDOAAMLNF = other.NHIDOAAMLNF;
		}
		if (other.Platform != PlatformType.Editor)
		{
			Platform = other.Platform;
		}
		if (other.IsBanned)
		{
			IsBanned = other.IsBanned;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.PHKAMFFCKML != 0)
		{
			PHKAMFFCKML = other.PHKAMFFCKML;
		}
		if (other.playerOutfitData_ != null)
		{
			if (playerOutfitData_ == null)
			{
				PlayerOutfitData = new PlayerOutfitInfo();
			}
			PlayerOutfitData.MergeFrom(other.PlayerOutfitData);
		}
		if (other.headFrameInfo_ != null)
		{
			if (headFrameInfo_ == null)
			{
				HeadFrameInfo = new HeadFrameInfo();
			}
			HeadFrameInfo.MergeFrom(other.HeadFrameInfo);
		}
		if (other.jIJOICCDFCA_ != null)
		{
			if (jIJOICCDFCA_ == null)
			{
				JIJOICCDFCA = new JKFBFGOEBKI();
			}
			JIJOICCDFCA.MergeFrom(other.JIJOICCDFCA);
		}
		if (other.lCBGFPMCLNO_ != null)
		{
			if (lCBGFPMCLNO_ == null)
			{
				LCBGFPMCLNO = new MNBHEHAMOKL();
			}
			LCBGFPMCLNO.MergeFrom(other.LCBGFPMCLNO);
		}
		assistAvatarList_.Add(other.assistAvatarList_);
		if (other.gFPMLPGHONG_ != null)
		{
			if (gFPMLPGHONG_ == null)
			{
				GFPMLPGHONG = new KJGMAEGNBKL();
			}
			GFPMLPGHONG.MergeFrom(other.GFPMLPGHONG);
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
				HBIDCAFOPMG = input.ReadString();
				break;
			case 16u:
				HeadIcon = input.ReadUInt32();
				break;
			case 26u:
				if (recordInfo_ == null)
				{
					RecordInfo = new PlayerRecordInfo();
				}
				input.ReadMessage(RecordInfo);
				break;
			case 34u:
				ICJIGHOMDNL = input.ReadString();
				break;
			case 42u:
				Nickname = input.ReadString();
				break;
			case 48u:
				Level = input.ReadUInt32();
				break;
			case 56u:
				OGJGMNBPPLE = input.ReadUInt32();
				break;
			case 66u:
				displayAvatarList_.AddEntriesFrom(ref input, _repeated_displayAvatarList_codec);
				break;
			case 72u:
				OLJFBHKLAJP = input.ReadUInt32();
				break;
			case 80u:
				Uid = input.ReadUInt32();
				break;
			case 90u:
				Signature = input.ReadString();
				break;
			case 96u:
				NHIDOAAMLNF = input.ReadBool();
				break;
			case 104u:
				Platform = (PlatformType)input.ReadEnum();
				break;
			case 112u:
				IsBanned = input.ReadBool();
				break;
			case 120u:
				WorldLevel = input.ReadUInt32();
				break;
			case 2968u:
				PHKAMFFCKML = input.ReadUInt32();
				break;
			case 6650u:
				if (playerOutfitData_ == null)
				{
					PlayerOutfitData = new PlayerOutfitInfo();
				}
				input.ReadMessage(PlayerOutfitData);
				break;
			case 8098u:
				if (headFrameInfo_ == null)
				{
					HeadFrameInfo = new HeadFrameInfo();
				}
				input.ReadMessage(HeadFrameInfo);
				break;
			case 8314u:
				if (jIJOICCDFCA_ == null)
				{
					JIJOICCDFCA = new JKFBFGOEBKI();
				}
				input.ReadMessage(JIJOICCDFCA);
				break;
			case 8418u:
				if (lCBGFPMCLNO_ == null)
				{
					LCBGFPMCLNO = new MNBHEHAMOKL();
				}
				input.ReadMessage(LCBGFPMCLNO);
				break;
			case 14474u:
				assistAvatarList_.AddEntriesFrom(ref input, _repeated_assistAvatarList_codec);
				break;
			case 15730u:
				if (gFPMLPGHONG_ == null)
				{
					GFPMLPGHONG = new KJGMAEGNBKL();
				}
				input.ReadMessage(GFPMLPGHONG);
				break;
			}
		}
	}
}
