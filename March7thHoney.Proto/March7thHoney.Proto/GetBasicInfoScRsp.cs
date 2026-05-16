using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBasicInfoScRsp : IMessage<GetBasicInfoScRsp>, IMessage, IEquatable<GetBasicInfoScRsp>, IDeepCloneable<GetBasicInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetBasicInfoScRsp> _parser = new MessageParser<GetBasicInfoScRsp>(() => new GetBasicInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IsGenderSetFieldNumber = 2;

	private bool isGenderSet_;

	public const int GenderFieldNumber = 4;

	private uint gender_;

	public const int PlayerSettingInfoFieldNumber = 5;

	private PlayerSettingInfo playerSettingInfo_;

	public const int CurDayFieldNumber = 7;

	private uint curDay_;

	public const int NextRecoverTimeFieldNumber = 8;

	private long nextRecoverTime_;

	public const int GameplayBirthdayFieldNumber = 10;

	private uint gameplayBirthday_;

	public const int WeekCocoonFinishedCountFieldNumber = 11;

	private uint weekCocoonFinishedCount_;

	public const int ExchangeTimesFieldNumber = 12;

	private uint exchangeTimes_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int LastSetNicknameTimeFieldNumber = 14;

	private long lastSetNicknameTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBasicInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBasicInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsGenderSet
	{
		get
		{
			return isGenderSet_;
		}
		set
		{
			isGenderSet_ = value;
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
	public PlayerSettingInfo PlayerSettingInfo
	{
		get
		{
			return playerSettingInfo_;
		}
		set
		{
			playerSettingInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurDay
	{
		get
		{
			return curDay_;
		}
		set
		{
			curDay_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NextRecoverTime
	{
		get
		{
			return nextRecoverTime_;
		}
		set
		{
			nextRecoverTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GameplayBirthday
	{
		get
		{
			return gameplayBirthday_;
		}
		set
		{
			gameplayBirthday_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WeekCocoonFinishedCount
	{
		get
		{
			return weekCocoonFinishedCount_;
		}
		set
		{
			weekCocoonFinishedCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExchangeTimes
	{
		get
		{
			return exchangeTimes_;
		}
		set
		{
			exchangeTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LastSetNicknameTime
	{
		get
		{
			return lastSetNicknameTime_;
		}
		set
		{
			lastSetNicknameTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBasicInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBasicInfoScRsp(GetBasicInfoScRsp other)
		: this()
	{
		isGenderSet_ = other.isGenderSet_;
		gender_ = other.gender_;
		playerSettingInfo_ = ((other.playerSettingInfo_ != null) ? other.playerSettingInfo_.Clone() : null);
		curDay_ = other.curDay_;
		nextRecoverTime_ = other.nextRecoverTime_;
		gameplayBirthday_ = other.gameplayBirthday_;
		weekCocoonFinishedCount_ = other.weekCocoonFinishedCount_;
		exchangeTimes_ = other.exchangeTimes_;
		retcode_ = other.retcode_;
		lastSetNicknameTime_ = other.lastSetNicknameTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBasicInfoScRsp Clone()
	{
		return new GetBasicInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBasicInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBasicInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsGenderSet != other.IsGenderSet)
		{
			return false;
		}
		if (Gender != other.Gender)
		{
			return false;
		}
		if (!object.Equals(PlayerSettingInfo, other.PlayerSettingInfo))
		{
			return false;
		}
		if (CurDay != other.CurDay)
		{
			return false;
		}
		if (NextRecoverTime != other.NextRecoverTime)
		{
			return false;
		}
		if (GameplayBirthday != other.GameplayBirthday)
		{
			return false;
		}
		if (WeekCocoonFinishedCount != other.WeekCocoonFinishedCount)
		{
			return false;
		}
		if (ExchangeTimes != other.ExchangeTimes)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (LastSetNicknameTime != other.LastSetNicknameTime)
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
		if (IsGenderSet)
		{
			num ^= IsGenderSet.GetHashCode();
		}
		if (Gender != 0)
		{
			num ^= Gender.GetHashCode();
		}
		if (playerSettingInfo_ != null)
		{
			num ^= PlayerSettingInfo.GetHashCode();
		}
		if (CurDay != 0)
		{
			num ^= CurDay.GetHashCode();
		}
		if (NextRecoverTime != 0L)
		{
			num ^= NextRecoverTime.GetHashCode();
		}
		if (GameplayBirthday != 0)
		{
			num ^= GameplayBirthday.GetHashCode();
		}
		if (WeekCocoonFinishedCount != 0)
		{
			num ^= WeekCocoonFinishedCount.GetHashCode();
		}
		if (ExchangeTimes != 0)
		{
			num ^= ExchangeTimes.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (LastSetNicknameTime != 0L)
		{
			num ^= LastSetNicknameTime.GetHashCode();
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
		if (IsGenderSet)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsGenderSet);
		}
		if (Gender != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Gender);
		}
		if (playerSettingInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PlayerSettingInfo);
		}
		if (CurDay != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(CurDay);
		}
		if (NextRecoverTime != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(NextRecoverTime);
		}
		if (GameplayBirthday != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GameplayBirthday);
		}
		if (WeekCocoonFinishedCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(WeekCocoonFinishedCount);
		}
		if (ExchangeTimes != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ExchangeTimes);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (LastSetNicknameTime != 0L)
		{
			output.WriteRawTag(112);
			output.WriteInt64(LastSetNicknameTime);
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
		if (IsGenderSet)
		{
			num += 2;
		}
		if (Gender != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gender);
		}
		if (playerSettingInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerSettingInfo);
		}
		if (CurDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurDay);
		}
		if (NextRecoverTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NextRecoverTime);
		}
		if (GameplayBirthday != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameplayBirthday);
		}
		if (WeekCocoonFinishedCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WeekCocoonFinishedCount);
		}
		if (ExchangeTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExchangeTimes);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (LastSetNicknameTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LastSetNicknameTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBasicInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsGenderSet)
		{
			IsGenderSet = other.IsGenderSet;
		}
		if (other.Gender != 0)
		{
			Gender = other.Gender;
		}
		if (other.playerSettingInfo_ != null)
		{
			if (playerSettingInfo_ == null)
			{
				PlayerSettingInfo = new PlayerSettingInfo();
			}
			PlayerSettingInfo.MergeFrom(other.PlayerSettingInfo);
		}
		if (other.CurDay != 0)
		{
			CurDay = other.CurDay;
		}
		if (other.NextRecoverTime != 0L)
		{
			NextRecoverTime = other.NextRecoverTime;
		}
		if (other.GameplayBirthday != 0)
		{
			GameplayBirthday = other.GameplayBirthday;
		}
		if (other.WeekCocoonFinishedCount != 0)
		{
			WeekCocoonFinishedCount = other.WeekCocoonFinishedCount;
		}
		if (other.ExchangeTimes != 0)
		{
			ExchangeTimes = other.ExchangeTimes;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.LastSetNicknameTime != 0L)
		{
			LastSetNicknameTime = other.LastSetNicknameTime;
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
			case 16u:
				IsGenderSet = input.ReadBool();
				break;
			case 32u:
				Gender = input.ReadUInt32();
				break;
			case 42u:
				if (playerSettingInfo_ == null)
				{
					PlayerSettingInfo = new PlayerSettingInfo();
				}
				input.ReadMessage(PlayerSettingInfo);
				break;
			case 56u:
				CurDay = input.ReadUInt32();
				break;
			case 64u:
				NextRecoverTime = input.ReadInt64();
				break;
			case 80u:
				GameplayBirthday = input.ReadUInt32();
				break;
			case 88u:
				WeekCocoonFinishedCount = input.ReadUInt32();
				break;
			case 96u:
				ExchangeTimes = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				LastSetNicknameTime = input.ReadInt64();
				break;
			}
		}
	}
}
