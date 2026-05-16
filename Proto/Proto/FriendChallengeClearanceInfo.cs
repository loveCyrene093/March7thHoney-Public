using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendChallengeClearanceInfo : IMessage<FriendChallengeClearanceInfo>, IMessage, IEquatable<FriendChallengeClearanceInfo>, IDeepCloneable<FriendChallengeClearanceInfo>, IBufferMessage
{
	public enum HIACNHNLCGLOneofCase
	{
		None = 0,
		ChallengeBoss = 1055,
		ChallengeStory = 1513,
		ChallengeDefault = 1929
	}

	private static readonly MessageParser<FriendChallengeClearanceInfo> _parser = new MessageParser<FriendChallengeClearanceInfo>(() => new FriendChallengeClearanceInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 3;

	private uint groupId_;

	public const int HCHCOAPJLMGFieldNumber = 4;

	private uint hCHCOAPJLMG_;

	public const int ChallengeBossFieldNumber = 1055;

	public const int ChallengeStoryFieldNumber = 1513;

	public const int ChallengeDefaultFieldNumber = 1929;

	private object hIACNHNLCGL_;

	private HIACNHNLCGLOneofCase hIACNHNLCGLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendChallengeClearanceInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FriendChallengeClearanceInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCHCOAPJLMG
	{
		get
		{
			return hCHCOAPJLMG_;
		}
		set
		{
			hCHCOAPJLMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossStatistics ChallengeBoss
	{
		get
		{
			if (hIACNHNLCGLCase_ != HIACNHNLCGLOneofCase.ChallengeBoss)
			{
				return null;
			}
			return (ChallengeBossStatistics)hIACNHNLCGL_;
		}
		set
		{
			hIACNHNLCGL_ = value;
			hIACNHNLCGLCase_ = ((value != null) ? HIACNHNLCGLOneofCase.ChallengeBoss : HIACNHNLCGLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStoryStatistics ChallengeStory
	{
		get
		{
			if (hIACNHNLCGLCase_ != HIACNHNLCGLOneofCase.ChallengeStory)
			{
				return null;
			}
			return (ChallengeStoryStatistics)hIACNHNLCGL_;
		}
		set
		{
			hIACNHNLCGL_ = value;
			hIACNHNLCGLCase_ = ((value != null) ? HIACNHNLCGLOneofCase.ChallengeStory : HIACNHNLCGLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStatistics ChallengeDefault
	{
		get
		{
			if (hIACNHNLCGLCase_ != HIACNHNLCGLOneofCase.ChallengeDefault)
			{
				return null;
			}
			return (ChallengeStatistics)hIACNHNLCGL_;
		}
		set
		{
			hIACNHNLCGL_ = value;
			hIACNHNLCGLCase_ = ((value != null) ? HIACNHNLCGLOneofCase.ChallengeDefault : HIACNHNLCGLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIACNHNLCGLOneofCase HIACNHNLCGLCase => hIACNHNLCGLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeClearanceInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeClearanceInfo(FriendChallengeClearanceInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		hCHCOAPJLMG_ = other.hCHCOAPJLMG_;
		switch (other.HIACNHNLCGLCase)
		{
		case HIACNHNLCGLOneofCase.ChallengeBoss:
			ChallengeBoss = other.ChallengeBoss.Clone();
			break;
		case HIACNHNLCGLOneofCase.ChallengeStory:
			ChallengeStory = other.ChallengeStory.Clone();
			break;
		case HIACNHNLCGLOneofCase.ChallengeDefault:
			ChallengeDefault = other.ChallengeDefault.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendChallengeClearanceInfo Clone()
	{
		return new FriendChallengeClearanceInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHIACNHNLCGL()
	{
		hIACNHNLCGLCase_ = HIACNHNLCGLOneofCase.None;
		hIACNHNLCGL_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendChallengeClearanceInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendChallengeClearanceInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (HCHCOAPJLMG != other.HCHCOAPJLMG)
		{
			return false;
		}
		if (!object.Equals(ChallengeBoss, other.ChallengeBoss))
		{
			return false;
		}
		if (!object.Equals(ChallengeStory, other.ChallengeStory))
		{
			return false;
		}
		if (!object.Equals(ChallengeDefault, other.ChallengeDefault))
		{
			return false;
		}
		if (HIACNHNLCGLCase != other.HIACNHNLCGLCase)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (HCHCOAPJLMG != 0)
		{
			num ^= HCHCOAPJLMG.GetHashCode();
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
		{
			num ^= ChallengeBoss.GetHashCode();
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
		{
			num ^= ChallengeStory.GetHashCode();
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
		{
			num ^= ChallengeDefault.GetHashCode();
		}
		num ^= (int)hIACNHNLCGLCase_;
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
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GroupId);
		}
		if (HCHCOAPJLMG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HCHCOAPJLMG);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
		{
			output.WriteRawTag(250, 65);
			output.WriteMessage(ChallengeBoss);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
		{
			output.WriteRawTag(202, 94);
			output.WriteMessage(ChallengeStory);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
		{
			output.WriteRawTag(202, 120);
			output.WriteMessage(ChallengeDefault);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (HCHCOAPJLMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCHCOAPJLMG);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChallengeBoss);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChallengeStory);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChallengeDefault);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendChallengeClearanceInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.HCHCOAPJLMG != 0)
		{
			HCHCOAPJLMG = other.HCHCOAPJLMG;
		}
		switch (other.HIACNHNLCGLCase)
		{
		case HIACNHNLCGLOneofCase.ChallengeBoss:
			if (ChallengeBoss == null)
			{
				ChallengeBoss = new ChallengeBossStatistics();
			}
			ChallengeBoss.MergeFrom(other.ChallengeBoss);
			break;
		case HIACNHNLCGLOneofCase.ChallengeStory:
			if (ChallengeStory == null)
			{
				ChallengeStory = new ChallengeStoryStatistics();
			}
			ChallengeStory.MergeFrom(other.ChallengeStory);
			break;
		case HIACNHNLCGLOneofCase.ChallengeDefault:
			if (ChallengeDefault == null)
			{
				ChallengeDefault = new ChallengeStatistics();
			}
			ChallengeDefault.MergeFrom(other.ChallengeDefault);
			break;
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
			case 24u:
				GroupId = input.ReadUInt32();
				break;
			case 32u:
				HCHCOAPJLMG = input.ReadUInt32();
				break;
			case 8442u:
			{
				ChallengeBossStatistics challengeBossStatistics = new ChallengeBossStatistics();
				if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
				{
					challengeBossStatistics.MergeFrom(ChallengeBoss);
				}
				input.ReadMessage(challengeBossStatistics);
				ChallengeBoss = challengeBossStatistics;
				break;
			}
			case 12106u:
			{
				ChallengeStoryStatistics challengeStoryStatistics = new ChallengeStoryStatistics();
				if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
				{
					challengeStoryStatistics.MergeFrom(ChallengeStory);
				}
				input.ReadMessage(challengeStoryStatistics);
				ChallengeStory = challengeStoryStatistics;
				break;
			}
			case 15434u:
			{
				ChallengeStatistics challengeStatistics = new ChallengeStatistics();
				if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
				{
					challengeStatistics.MergeFrom(ChallengeDefault);
				}
				input.ReadMessage(challengeStatistics);
				ChallengeDefault = challengeStatistics;
				break;
			}
			}
		}
	}
}
