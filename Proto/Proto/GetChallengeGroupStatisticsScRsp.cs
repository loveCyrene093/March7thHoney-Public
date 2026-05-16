using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChallengeGroupStatisticsScRsp : IMessage<GetChallengeGroupStatisticsScRsp>, IMessage, IEquatable<GetChallengeGroupStatisticsScRsp>, IDeepCloneable<GetChallengeGroupStatisticsScRsp>, IBufferMessage
{
	public enum HIACNHNLCGLOneofCase
	{
		None = 0,
		ChallengeStory = 1,
		ChallengeDefault = 6,
		ChallengeBoss = 7
	}

	private static readonly MessageParser<GetChallengeGroupStatisticsScRsp> _parser = new MessageParser<GetChallengeGroupStatisticsScRsp>(() => new GetChallengeGroupStatisticsScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 8;

	private uint groupId_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int ChallengeStoryFieldNumber = 1;

	public const int ChallengeDefaultFieldNumber = 6;

	public const int ChallengeBossFieldNumber = 7;

	private object hIACNHNLCGL_;

	private HIACNHNLCGLOneofCase hIACNHNLCGLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChallengeGroupStatisticsScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChallengeGroupStatisticsScRspReflection.Descriptor.MessageTypes[0];

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
	public HIACNHNLCGLOneofCase HIACNHNLCGLCase => hIACNHNLCGLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChallengeGroupStatisticsScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChallengeGroupStatisticsScRsp(GetChallengeGroupStatisticsScRsp other)
		: this()
	{
		groupId_ = other.groupId_;
		retcode_ = other.retcode_;
		switch (other.HIACNHNLCGLCase)
		{
		case HIACNHNLCGLOneofCase.ChallengeStory:
			ChallengeStory = other.ChallengeStory.Clone();
			break;
		case HIACNHNLCGLOneofCase.ChallengeDefault:
			ChallengeDefault = other.ChallengeDefault.Clone();
			break;
		case HIACNHNLCGLOneofCase.ChallengeBoss:
			ChallengeBoss = other.ChallengeBoss.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChallengeGroupStatisticsScRsp Clone()
	{
		return new GetChallengeGroupStatisticsScRsp(this);
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
		return Equals(other as GetChallengeGroupStatisticsScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChallengeGroupStatisticsScRsp other)
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
		if (Retcode != other.Retcode)
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
		if (!object.Equals(ChallengeBoss, other.ChallengeBoss))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
		{
			num ^= ChallengeStory.GetHashCode();
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
		{
			num ^= ChallengeDefault.GetHashCode();
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
		{
			num ^= ChallengeBoss.GetHashCode();
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
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ChallengeStory);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ChallengeDefault);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ChallengeBoss);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GroupId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeStory)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChallengeStory);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeDefault)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChallengeDefault);
		}
		if (hIACNHNLCGLCase_ == HIACNHNLCGLOneofCase.ChallengeBoss)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChallengeBoss);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChallengeGroupStatisticsScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		switch (other.HIACNHNLCGLCase)
		{
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
		case HIACNHNLCGLOneofCase.ChallengeBoss:
			if (ChallengeBoss == null)
			{
				ChallengeBoss = new ChallengeBossStatistics();
			}
			ChallengeBoss.MergeFrom(other.ChallengeBoss);
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
			case 10u:
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
			case 50u:
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
			case 58u:
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
			case 64u:
				GroupId = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
