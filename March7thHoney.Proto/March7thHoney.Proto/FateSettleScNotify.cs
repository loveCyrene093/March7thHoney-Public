using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateSettleScNotify : IMessage<FateSettleScNotify>, IMessage, IEquatable<FateSettleScNotify>, IDeepCloneable<FateSettleScNotify>, IBufferMessage
{
	private static readonly MessageParser<FateSettleScNotify> _parser = new MessageParser<FateSettleScNotify>(() => new FateSettleScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ANLGOPHHHFPFieldNumber = 1;

	private IHGBDAGHDME aNLGOPHHHFP_;

	public const int ScoreIdFieldNumber = 2;

	private uint scoreId_;

	public const int RewardFieldNumber = 7;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateSettleScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateSettleScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHGBDAGHDME ANLGOPHHHFP
	{
		get
		{
			return aNLGOPHHHFP_;
		}
		set
		{
			aNLGOPHHHFP_ = value;
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
	public FateSettleScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSettleScNotify(FateSettleScNotify other)
		: this()
	{
		aNLGOPHHHFP_ = ((other.aNLGOPHHHFP_ != null) ? other.aNLGOPHHHFP_.Clone() : null);
		scoreId_ = other.scoreId_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSettleScNotify Clone()
	{
		return new FateSettleScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateSettleScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateSettleScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ANLGOPHHHFP, other.ANLGOPHHHFP))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		if (aNLGOPHHHFP_ != null)
		{
			num ^= ANLGOPHHHFP.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (aNLGOPHHHFP_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ANLGOPHHHFP);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ScoreId);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Reward);
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
		if (aNLGOPHHHFP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ANLGOPHHHFP);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateSettleScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aNLGOPHHHFP_ != null)
		{
			if (aNLGOPHHHFP_ == null)
			{
				ANLGOPHHHFP = new IHGBDAGHDME();
			}
			ANLGOPHHHFP.MergeFrom(other.ANLGOPHHHFP);
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
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
				if (aNLGOPHHHFP_ == null)
				{
					ANLGOPHHHFP = new IHGBDAGHDME();
				}
				input.ReadMessage(ANLGOPHHHFP);
				break;
			case 16u:
				ScoreId = input.ReadUInt32();
				break;
			case 58u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			}
		}
	}
}
