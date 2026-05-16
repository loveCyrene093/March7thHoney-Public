using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendSimpleInfo : IMessage<FriendSimpleInfo>, IMessage, IEquatable<FriendSimpleInfo>, IDeepCloneable<FriendSimpleInfo>, IBufferMessage
{
	private static readonly MessageParser<FriendSimpleInfo> _parser = new MessageParser<FriendSimpleInfo>(() => new FriendSimpleInfo());

	private UnknownFieldSet _unknownFields;

	public const int PlayerInfoFieldNumber = 1;

	private PlayerSimpleInfo playerInfo_;

	public const int RemarkNameFieldNumber = 7;

	private string remarkName_ = "";

	public const int IsMarkedFieldNumber = 9;

	private bool isMarked_;

	public const int PlayingStateFieldNumber = 11;

	private PlayingState playingState_;

	public const int CreateTimeFieldNumber = 12;

	private long createTime_;

	public const int FCKDHFFMECCFieldNumber = 14;

	private PHNHEEOLADL fCKDHFFMECC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendSimpleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FriendSimpleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo PlayerInfo
	{
		get
		{
			return playerInfo_;
		}
		set
		{
			playerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RemarkName
	{
		get
		{
			return remarkName_;
		}
		set
		{
			remarkName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsMarked
	{
		get
		{
			return isMarked_;
		}
		set
		{
			isMarked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayingState PlayingState
	{
		get
		{
			return playingState_;
		}
		set
		{
			playingState_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHNHEEOLADL FCKDHFFMECC
	{
		get
		{
			return fCKDHFFMECC_;
		}
		set
		{
			fCKDHFFMECC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSimpleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSimpleInfo(FriendSimpleInfo other)
		: this()
	{
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		remarkName_ = other.remarkName_;
		isMarked_ = other.isMarked_;
		playingState_ = other.playingState_;
		createTime_ = other.createTime_;
		fCKDHFFMECC_ = ((other.fCKDHFFMECC_ != null) ? other.fCKDHFFMECC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSimpleInfo Clone()
	{
		return new FriendSimpleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendSimpleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendSimpleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PlayerInfo, other.PlayerInfo))
		{
			return false;
		}
		if (RemarkName != other.RemarkName)
		{
			return false;
		}
		if (IsMarked != other.IsMarked)
		{
			return false;
		}
		if (PlayingState != other.PlayingState)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (!object.Equals(FCKDHFFMECC, other.FCKDHFFMECC))
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
		if (playerInfo_ != null)
		{
			num ^= PlayerInfo.GetHashCode();
		}
		if (RemarkName.Length != 0)
		{
			num ^= RemarkName.GetHashCode();
		}
		if (IsMarked)
		{
			num ^= IsMarked.GetHashCode();
		}
		if (PlayingState != PlayingState.None)
		{
			num ^= PlayingState.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (fCKDHFFMECC_ != null)
		{
			num ^= FCKDHFFMECC.GetHashCode();
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
		if (playerInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PlayerInfo);
		}
		if (RemarkName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(RemarkName);
		}
		if (IsMarked)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsMarked);
		}
		if (PlayingState != PlayingState.None)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)PlayingState);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(CreateTime);
		}
		if (fCKDHFFMECC_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(FCKDHFFMECC);
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
		if (playerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerInfo);
		}
		if (RemarkName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RemarkName);
		}
		if (IsMarked)
		{
			num += 2;
		}
		if (PlayingState != PlayingState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PlayingState);
		}
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreateTime);
		}
		if (fCKDHFFMECC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCKDHFFMECC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendSimpleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.playerInfo_ != null)
		{
			if (playerInfo_ == null)
			{
				PlayerInfo = new PlayerSimpleInfo();
			}
			PlayerInfo.MergeFrom(other.PlayerInfo);
		}
		if (other.RemarkName.Length != 0)
		{
			RemarkName = other.RemarkName;
		}
		if (other.IsMarked)
		{
			IsMarked = other.IsMarked;
		}
		if (other.PlayingState != PlayingState.None)
		{
			PlayingState = other.PlayingState;
		}
		if (other.CreateTime != 0L)
		{
			CreateTime = other.CreateTime;
		}
		if (other.fCKDHFFMECC_ != null)
		{
			if (fCKDHFFMECC_ == null)
			{
				FCKDHFFMECC = new PHNHEEOLADL();
			}
			FCKDHFFMECC.MergeFrom(other.FCKDHFFMECC);
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
				if (playerInfo_ == null)
				{
					PlayerInfo = new PlayerSimpleInfo();
				}
				input.ReadMessage(PlayerInfo);
				break;
			case 58u:
				RemarkName = input.ReadString();
				break;
			case 72u:
				IsMarked = input.ReadBool();
				break;
			case 88u:
				PlayingState = (PlayingState)input.ReadEnum();
				break;
			case 96u:
				CreateTime = input.ReadInt64();
				break;
			case 114u:
				if (fCKDHFFMECC_ == null)
				{
					FCKDHFFMECC = new PHNHEEOLADL();
				}
				input.ReadMessage(FCKDHFFMECC);
				break;
			}
		}
	}
}
