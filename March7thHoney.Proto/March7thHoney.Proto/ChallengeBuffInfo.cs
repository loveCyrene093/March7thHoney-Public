using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBuffInfo : IMessage<ChallengeBuffInfo>, IMessage, IEquatable<ChallengeBuffInfo>, IDeepCloneable<ChallengeBuffInfo>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		StoryInfo = 2,
		BossInfo = 8
	}

	private static readonly MessageParser<ChallengeBuffInfo> _parser = new MessageParser<ChallengeBuffInfo>(() => new ChallengeBuffInfo());

	private UnknownFieldSet _unknownFields;

	public const int StoryInfoFieldNumber = 2;

	public const int BossInfoFieldNumber = 8;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBuffInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBuffInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStoryBuffInfo StoryInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.StoryInfo)
			{
				return null;
			}
			return (ChallengeStoryBuffInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.StoryInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffInfo BossInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BossInfo)
			{
				return null;
			}
			return (ChallengeBossBuffInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BossInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBuffInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBuffInfo(ChallengeBuffInfo other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.StoryInfo:
			StoryInfo = other.StoryInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BossInfo:
			BossInfo = other.BossInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBuffInfo Clone()
	{
		return new ChallengeBuffInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBuffInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBuffInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StoryInfo, other.StoryInfo))
		{
			return false;
		}
		if (!object.Equals(BossInfo, other.BossInfo))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.StoryInfo)
		{
			num ^= StoryInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BossInfo)
		{
			num ^= BossInfo.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.StoryInfo)
		{
			output.WriteRawTag(18);
			output.WriteMessage(StoryInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BossInfo)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BossInfo);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.StoryInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoryInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BossInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BossInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBuffInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.StoryInfo:
			if (StoryInfo == null)
			{
				StoryInfo = new ChallengeStoryBuffInfo();
			}
			StoryInfo.MergeFrom(other.StoryInfo);
			break;
		case BPIHFAJCLOCOneofCase.BossInfo:
			if (BossInfo == null)
			{
				BossInfo = new ChallengeBossBuffInfo();
			}
			BossInfo.MergeFrom(other.BossInfo);
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
			case 18u:
			{
				ChallengeStoryBuffInfo challengeStoryBuffInfo = new ChallengeStoryBuffInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.StoryInfo)
				{
					challengeStoryBuffInfo.MergeFrom(StoryInfo);
				}
				input.ReadMessage(challengeStoryBuffInfo);
				StoryInfo = challengeStoryBuffInfo;
				break;
			}
			case 66u:
			{
				ChallengeBossBuffInfo challengeBossBuffInfo = new ChallengeBossBuffInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BossInfo)
				{
					challengeBossBuffInfo.MergeFrom(BossInfo);
				}
				input.ReadMessage(challengeBossBuffInfo);
				BossInfo = challengeBossBuffInfo;
				break;
			}
			}
		}
	}
}
