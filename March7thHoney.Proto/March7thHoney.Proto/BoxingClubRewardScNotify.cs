using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BoxingClubRewardScNotify : IMessage<BoxingClubRewardScNotify>, IMessage, IEquatable<BoxingClubRewardScNotify>, IDeepCloneable<BoxingClubRewardScNotify>, IBufferMessage
{
	private static readonly MessageParser<BoxingClubRewardScNotify> _parser = new MessageParser<BoxingClubRewardScNotify>(() => new BoxingClubRewardScNotify());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 5;

	private ItemList reward_;

	public const int BKMEDGFOMKFFieldNumber = 6;

	private uint bKMEDGFOMKF_;

	public const int ChallengeIdFieldNumber = 11;

	private uint challengeId_;

	public const int IsWinFieldNumber = 13;

	private bool isWin_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BoxingClubRewardScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BoxingClubRewardScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKMEDGFOMKF
	{
		get
		{
			return bKMEDGFOMKF_;
		}
		set
		{
			bKMEDGFOMKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeId
	{
		get
		{
			return challengeId_;
		}
		set
		{
			challengeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BoxingClubRewardScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BoxingClubRewardScNotify(BoxingClubRewardScNotify other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		bKMEDGFOMKF_ = other.bKMEDGFOMKF_;
		challengeId_ = other.challengeId_;
		isWin_ = other.isWin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BoxingClubRewardScNotify Clone()
	{
		return new BoxingClubRewardScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BoxingClubRewardScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BoxingClubRewardScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (BKMEDGFOMKF != other.BKMEDGFOMKF)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (IsWin != other.IsWin)
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (BKMEDGFOMKF != 0)
		{
			num ^= BKMEDGFOMKF.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Reward);
		}
		if (BKMEDGFOMKF != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BKMEDGFOMKF);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ChallengeId);
		}
		if (IsWin)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsWin);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (BKMEDGFOMKF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKMEDGFOMKF);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BoxingClubRewardScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.BKMEDGFOMKF != 0)
		{
			BKMEDGFOMKF = other.BKMEDGFOMKF;
		}
		if (other.ChallengeId != 0)
		{
			ChallengeId = other.ChallengeId;
		}
		if (other.IsWin)
		{
			IsWin = other.IsWin;
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
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 48u:
				BKMEDGFOMKF = input.ReadUInt32();
				break;
			case 88u:
				ChallengeId = input.ReadUInt32();
				break;
			case 104u:
				IsWin = input.ReadBool();
				break;
			}
		}
	}
}
