using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendChallengeLineup : IMessage<FriendChallengeLineup>, IMessage, IEquatable<FriendChallengeLineup>, IDeepCloneable<FriendChallengeLineup>, IBufferMessage
{
	private static readonly MessageParser<FriendChallengeLineup> _parser = new MessageParser<FriendChallengeLineup>(() => new FriendChallengeLineup());

	private UnknownFieldSet _unknownFields;

	public const int PlayerInfoFieldNumber = 5;

	private PlayerSimpleInfo playerInfo_;

	public const int ABJGNBJMJJGFieldNumber = 7;

	private uint aBJGNBJMJJG_;

	public const int BuffOneFieldNumber = 8;

	private uint buffOne_;

	public const int ScoreIdFieldNumber = 9;

	private uint scoreId_;

	public const int RemarkNameFieldNumber = 12;

	private string remarkName_ = "";

	public const int LineupListFieldNumber = 14;

	private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage(114u, ChallengeLineupList.Parser);

	private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

	public const int BuffTwoFieldNumber = 15;

	private uint buffTwo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendChallengeLineup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FriendChallengeLineupReflection.Descriptor.MessageTypes[0];

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
	public uint ABJGNBJMJJG
	{
		get
		{
			return aBJGNBJMJJG_;
		}
		set
		{
			aBJGNBJMJJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffOne
	{
		get
		{
			return buffOne_;
		}
		set
		{
			buffOne_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
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
	public RepeatedField<ChallengeLineupList> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffTwo
	{
		get
		{
			return buffTwo_;
		}
		set
		{
			buffTwo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeLineup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeLineup(FriendChallengeLineup other)
		: this()
	{
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		aBJGNBJMJJG_ = other.aBJGNBJMJJG_;
		buffOne_ = other.buffOne_;
		scoreId_ = other.scoreId_;
		remarkName_ = other.remarkName_;
		lineupList_ = other.lineupList_.Clone();
		buffTwo_ = other.buffTwo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeLineup Clone()
	{
		return new FriendChallengeLineup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendChallengeLineup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendChallengeLineup other)
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
		if (ABJGNBJMJJG != other.ABJGNBJMJJG)
		{
			return false;
		}
		if (BuffOne != other.BuffOne)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (RemarkName != other.RemarkName)
		{
			return false;
		}
		if (!lineupList_.Equals(other.lineupList_))
		{
			return false;
		}
		if (BuffTwo != other.BuffTwo)
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
		if (ABJGNBJMJJG != 0)
		{
			num ^= ABJGNBJMJJG.GetHashCode();
		}
		if (BuffOne != 0)
		{
			num ^= BuffOne.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (RemarkName.Length != 0)
		{
			num ^= RemarkName.GetHashCode();
		}
		num ^= lineupList_.GetHashCode();
		if (BuffTwo != 0)
		{
			num ^= BuffTwo.GetHashCode();
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
			output.WriteRawTag(42);
			output.WriteMessage(PlayerInfo);
		}
		if (ABJGNBJMJJG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ABJGNBJMJJG);
		}
		if (BuffOne != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BuffOne);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ScoreId);
		}
		if (RemarkName.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(RemarkName);
		}
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		if (BuffTwo != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BuffTwo);
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
		if (ABJGNBJMJJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABJGNBJMJJG);
		}
		if (BuffOne != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffOne);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (RemarkName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RemarkName);
		}
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (BuffTwo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffTwo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendChallengeLineup other)
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
		if (other.ABJGNBJMJJG != 0)
		{
			ABJGNBJMJJG = other.ABJGNBJMJJG;
		}
		if (other.BuffOne != 0)
		{
			BuffOne = other.BuffOne;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.RemarkName.Length != 0)
		{
			RemarkName = other.RemarkName;
		}
		lineupList_.Add(other.lineupList_);
		if (other.BuffTwo != 0)
		{
			BuffTwo = other.BuffTwo;
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
			case 42u:
				if (playerInfo_ == null)
				{
					PlayerInfo = new PlayerSimpleInfo();
				}
				input.ReadMessage(PlayerInfo);
				break;
			case 56u:
				ABJGNBJMJJG = input.ReadUInt32();
				break;
			case 64u:
				BuffOne = input.ReadUInt32();
				break;
			case 72u:
				ScoreId = input.ReadUInt32();
				break;
			case 98u:
				RemarkName = input.ReadString();
				break;
			case 114u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 120u:
				BuffTwo = input.ReadUInt32();
				break;
			}
		}
	}
}
