using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeCurBuffInfo : IMessage<ChallengeCurBuffInfo>, IMessage, IEquatable<ChallengeCurBuffInfo>, IDeepCloneable<ChallengeCurBuffInfo>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		CurStoryBuffs = 3,
		CurBossBuffs = 15
	}

	private static readonly MessageParser<ChallengeCurBuffInfo> _parser = new MessageParser<ChallengeCurBuffInfo>(() => new ChallengeCurBuffInfo());

	private UnknownFieldSet _unknownFields;

	public const int CurStoryBuffsFieldNumber = 3;

	public const int CurBossBuffsFieldNumber = 15;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeCurBuffInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeCurBuffInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStoryBuffList CurStoryBuffs
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CurStoryBuffs)
			{
				return null;
			}
			return (ChallengeStoryBuffList)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CurStoryBuffs : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffList CurBossBuffs
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CurBossBuffs)
			{
				return null;
			}
			return (ChallengeBossBuffList)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CurBossBuffs : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeCurBuffInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeCurBuffInfo(ChallengeCurBuffInfo other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.CurStoryBuffs:
			CurStoryBuffs = other.CurStoryBuffs.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CurBossBuffs:
			CurBossBuffs = other.CurBossBuffs.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeCurBuffInfo Clone()
	{
		return new ChallengeCurBuffInfo(this);
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
		return Equals(other as ChallengeCurBuffInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeCurBuffInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CurStoryBuffs, other.CurStoryBuffs))
		{
			return false;
		}
		if (!object.Equals(CurBossBuffs, other.CurBossBuffs))
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurStoryBuffs)
		{
			num ^= CurStoryBuffs.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurBossBuffs)
		{
			num ^= CurBossBuffs.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurStoryBuffs)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CurStoryBuffs);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurBossBuffs)
		{
			output.WriteRawTag(122);
			output.WriteMessage(CurBossBuffs);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurStoryBuffs)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurStoryBuffs);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurBossBuffs)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurBossBuffs);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeCurBuffInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.CurStoryBuffs:
			if (CurStoryBuffs == null)
			{
				CurStoryBuffs = new ChallengeStoryBuffList();
			}
			CurStoryBuffs.MergeFrom(other.CurStoryBuffs);
			break;
		case BPIHFAJCLOCOneofCase.CurBossBuffs:
			if (CurBossBuffs == null)
			{
				CurBossBuffs = new ChallengeBossBuffList();
			}
			CurBossBuffs.MergeFrom(other.CurBossBuffs);
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
			case 26u:
			{
				ChallengeStoryBuffList challengeStoryBuffList = new ChallengeStoryBuffList();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurStoryBuffs)
				{
					challengeStoryBuffList.MergeFrom(CurStoryBuffs);
				}
				input.ReadMessage(challengeStoryBuffList);
				CurStoryBuffs = challengeStoryBuffList;
				break;
			}
			case 122u:
			{
				ChallengeBossBuffList challengeBossBuffList = new ChallengeBossBuffList();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CurBossBuffs)
				{
					challengeBossBuffList.MergeFrom(CurBossBuffs);
				}
				input.ReadMessage(challengeBossBuffList);
				CurBossBuffs = challengeBossBuffList;
				break;
			}
			}
		}
	}
}
