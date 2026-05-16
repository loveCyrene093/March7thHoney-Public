using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerSimpleInfo : IMessage<PlayerSimpleInfo>, IMessage, IEquatable<PlayerSimpleInfo>, IDeepCloneable<PlayerSimpleInfo>, IBufferMessage
{
	private static readonly MessageParser<PlayerSimpleInfo> _parser = new MessageParser<PlayerSimpleInfo>(() => new PlayerSimpleInfo());

	private UnknownFieldSet _unknownFields;

	public const int NicknameFieldNumber = 1;

	private string nickname_ = "";

	public const int SignatureFieldNumber = 2;

	private string signature_ = "";

	public const int PlatformUuidFieldNumber = 3;

	private string platformUuid_ = "";

	public const int PlayerOutfitDataFieldNumber = 4;

	private PlayerOutfitInfo playerOutfitData_;

	public const int UidFieldNumber = 5;

	private uint uid_;

	public const int PlatformNickFieldNumber = 6;

	private string platformNick_ = "";

	public const int PlatformFieldNumber = 7;

	private PlatformType platform_;

	public const int PersonalCardFieldNumber = 8;

	private uint personalCard_;

	public const int LastActiveTimeFieldNumber = 9;

	private long lastActiveTime_;

	public const int OnlineStatusFieldNumber = 10;

	private FriendOnlineStatus onlineStatus_;

	public const int ChatBubbleIdFieldNumber = 11;

	private uint chatBubbleId_;

	public const int HeadIconFieldNumber = 12;

	private uint headIcon_;

	public const int IsBannedFieldNumber = 13;

	private bool isBanned_;

	public const int LevelFieldNumber = 14;

	private uint level_;

	public const int AssistSimpleInfoListFieldNumber = 15;

	private static readonly FieldCodec<AssistSimpleInfo> _repeated_assistSimpleInfoList_codec = FieldCodec.ForMessage(122u, AssistSimpleInfo.Parser);

	private readonly RepeatedField<AssistSimpleInfo> assistSimpleInfoList_ = new RepeatedField<AssistSimpleInfo>();

	public const int HeadFrameInfoFieldNumber = 105;

	private HeadFrameInfo headFrameInfo_;

	public const int GenderFieldNumber = 1403;

	private uint gender_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerSimpleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerSimpleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public string PlatformUuid
	{
		get
		{
			return platformUuid_;
		}
		set
		{
			platformUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public string PlatformNick
	{
		get
		{
			return platformNick_;
		}
		set
		{
			platformNick_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint PersonalCard
	{
		get
		{
			return personalCard_;
		}
		set
		{
			personalCard_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LastActiveTime
	{
		get
		{
			return lastActiveTime_;
		}
		set
		{
			lastActiveTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendOnlineStatus OnlineStatus
	{
		get
		{
			return onlineStatus_;
		}
		set
		{
			onlineStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChatBubbleId
	{
		get
		{
			return chatBubbleId_;
		}
		set
		{
			chatBubbleId_ = value;
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
	public RepeatedField<AssistSimpleInfo> AssistSimpleInfoList => assistSimpleInfoList_;

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
	public uint Gender
	{
		get
		{
			return gender_;
		}
		set
		{
			gender_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo(PlayerSimpleInfo other)
		: this()
	{
		nickname_ = other.nickname_;
		signature_ = other.signature_;
		platformUuid_ = other.platformUuid_;
		playerOutfitData_ = ((other.playerOutfitData_ != null) ? other.playerOutfitData_.Clone() : null);
		uid_ = other.uid_;
		platformNick_ = other.platformNick_;
		platform_ = other.platform_;
		personalCard_ = other.personalCard_;
		lastActiveTime_ = other.lastActiveTime_;
		onlineStatus_ = other.onlineStatus_;
		chatBubbleId_ = other.chatBubbleId_;
		headIcon_ = other.headIcon_;
		isBanned_ = other.isBanned_;
		level_ = other.level_;
		assistSimpleInfoList_ = other.assistSimpleInfoList_.Clone();
		headFrameInfo_ = ((other.headFrameInfo_ != null) ? other.headFrameInfo_.Clone() : null);
		gender_ = other.gender_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo Clone()
	{
		return new PlayerSimpleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerSimpleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerSimpleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (Signature != other.Signature)
		{
			return false;
		}
		if (PlatformUuid != other.PlatformUuid)
		{
			return false;
		}
		if (!object.Equals(PlayerOutfitData, other.PlayerOutfitData))
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (PlatformNick != other.PlatformNick)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (PersonalCard != other.PersonalCard)
		{
			return false;
		}
		if (LastActiveTime != other.LastActiveTime)
		{
			return false;
		}
		if (OnlineStatus != other.OnlineStatus)
		{
			return false;
		}
		if (ChatBubbleId != other.ChatBubbleId)
		{
			return false;
		}
		if (HeadIcon != other.HeadIcon)
		{
			return false;
		}
		if (IsBanned != other.IsBanned)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!assistSimpleInfoList_.Equals(other.assistSimpleInfoList_))
		{
			return false;
		}
		if (!object.Equals(HeadFrameInfo, other.HeadFrameInfo))
		{
			return false;
		}
		if (Gender != other.Gender)
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
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (Signature.Length != 0)
		{
			num ^= Signature.GetHashCode();
		}
		if (PlatformUuid.Length != 0)
		{
			num ^= PlatformUuid.GetHashCode();
		}
		if (playerOutfitData_ != null)
		{
			num ^= PlayerOutfitData.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (PlatformNick.Length != 0)
		{
			num ^= PlatformNick.GetHashCode();
		}
		if (Platform != PlatformType.Editor)
		{
			num ^= Platform.GetHashCode();
		}
		if (PersonalCard != 0)
		{
			num ^= PersonalCard.GetHashCode();
		}
		if (LastActiveTime != 0L)
		{
			num ^= LastActiveTime.GetHashCode();
		}
		if (OnlineStatus != FriendOnlineStatus.Offline)
		{
			num ^= OnlineStatus.GetHashCode();
		}
		if (ChatBubbleId != 0)
		{
			num ^= ChatBubbleId.GetHashCode();
		}
		if (HeadIcon != 0)
		{
			num ^= HeadIcon.GetHashCode();
		}
		if (IsBanned)
		{
			num ^= IsBanned.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= assistSimpleInfoList_.GetHashCode();
		if (headFrameInfo_ != null)
		{
			num ^= HeadFrameInfo.GetHashCode();
		}
		if (Gender != 0)
		{
			num ^= Gender.GetHashCode();
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
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Nickname);
		}
		if (Signature.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Signature);
		}
		if (PlatformUuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PlatformUuid);
		}
		if (playerOutfitData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerOutfitData);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Uid);
		}
		if (PlatformNick.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(PlatformNick);
		}
		if (Platform != PlatformType.Editor)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Platform);
		}
		if (PersonalCard != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PersonalCard);
		}
		if (LastActiveTime != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(LastActiveTime);
		}
		if (OnlineStatus != FriendOnlineStatus.Offline)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)OnlineStatus);
		}
		if (ChatBubbleId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ChatBubbleId);
		}
		if (HeadIcon != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HeadIcon);
		}
		if (IsBanned)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsBanned);
		}
		if (Level != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Level);
		}
		assistSimpleInfoList_.WriteTo(ref output, _repeated_assistSimpleInfoList_codec);
		if (headFrameInfo_ != null)
		{
			output.WriteRawTag(202, 6);
			output.WriteMessage(HeadFrameInfo);
		}
		if (Gender != 0)
		{
			output.WriteRawTag(216, 87);
			output.WriteUInt32(Gender);
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
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (Signature.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Signature);
		}
		if (PlatformUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlatformUuid);
		}
		if (playerOutfitData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerOutfitData);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (PlatformNick.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlatformNick);
		}
		if (Platform != PlatformType.Editor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Platform);
		}
		if (PersonalCard != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PersonalCard);
		}
		if (LastActiveTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LastActiveTime);
		}
		if (OnlineStatus != FriendOnlineStatus.Offline)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OnlineStatus);
		}
		if (ChatBubbleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChatBubbleId);
		}
		if (HeadIcon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadIcon);
		}
		if (IsBanned)
		{
			num += 2;
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		num += assistSimpleInfoList_.CalculateSize(_repeated_assistSimpleInfoList_codec);
		if (headFrameInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HeadFrameInfo);
		}
		if (Gender != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(Gender);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerSimpleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Nickname.Length != 0)
		{
			Nickname = other.Nickname;
		}
		if (other.Signature.Length != 0)
		{
			Signature = other.Signature;
		}
		if (other.PlatformUuid.Length != 0)
		{
			PlatformUuid = other.PlatformUuid;
		}
		if (other.playerOutfitData_ != null)
		{
			if (playerOutfitData_ == null)
			{
				PlayerOutfitData = new PlayerOutfitInfo();
			}
			PlayerOutfitData.MergeFrom(other.PlayerOutfitData);
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.PlatformNick.Length != 0)
		{
			PlatformNick = other.PlatformNick;
		}
		if (other.Platform != PlatformType.Editor)
		{
			Platform = other.Platform;
		}
		if (other.PersonalCard != 0)
		{
			PersonalCard = other.PersonalCard;
		}
		if (other.LastActiveTime != 0L)
		{
			LastActiveTime = other.LastActiveTime;
		}
		if (other.OnlineStatus != FriendOnlineStatus.Offline)
		{
			OnlineStatus = other.OnlineStatus;
		}
		if (other.ChatBubbleId != 0)
		{
			ChatBubbleId = other.ChatBubbleId;
		}
		if (other.HeadIcon != 0)
		{
			HeadIcon = other.HeadIcon;
		}
		if (other.IsBanned)
		{
			IsBanned = other.IsBanned;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		assistSimpleInfoList_.Add(other.assistSimpleInfoList_);
		if (other.headFrameInfo_ != null)
		{
			if (headFrameInfo_ == null)
			{
				HeadFrameInfo = new HeadFrameInfo();
			}
			HeadFrameInfo.MergeFrom(other.HeadFrameInfo);
		}
		if (other.Gender != 0)
		{
			Gender = other.Gender;
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
				Nickname = input.ReadString();
				break;
			case 18u:
				Signature = input.ReadString();
				break;
			case 26u:
				PlatformUuid = input.ReadString();
				break;
			case 34u:
				if (playerOutfitData_ == null)
				{
					PlayerOutfitData = new PlayerOutfitInfo();
				}
				input.ReadMessage(PlayerOutfitData);
				break;
			case 40u:
				Uid = input.ReadUInt32();
				break;
			case 50u:
				PlatformNick = input.ReadString();
				break;
			case 56u:
				Platform = (PlatformType)input.ReadEnum();
				break;
			case 64u:
				PersonalCard = input.ReadUInt32();
				break;
			case 72u:
				LastActiveTime = input.ReadInt64();
				break;
			case 80u:
				OnlineStatus = (FriendOnlineStatus)input.ReadEnum();
				break;
			case 88u:
				ChatBubbleId = input.ReadUInt32();
				break;
			case 96u:
				HeadIcon = input.ReadUInt32();
				break;
			case 104u:
				IsBanned = input.ReadBool();
				break;
			case 112u:
				Level = input.ReadUInt32();
				break;
			case 122u:
				assistSimpleInfoList_.AddEntriesFrom(ref input, _repeated_assistSimpleInfoList_codec);
				break;
			case 842u:
				if (headFrameInfo_ == null)
				{
					HeadFrameInfo = new HeadFrameInfo();
				}
				input.ReadMessage(HeadFrameInfo);
				break;
			case 11224u:
				Gender = input.ReadUInt32();
				break;
			}
		}
	}
}
