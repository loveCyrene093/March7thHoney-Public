using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeRogueEndlessActivityAllBonusRewardScRsp : IMessage<TakeRogueEndlessActivityAllBonusRewardScRsp>, IMessage, IEquatable<TakeRogueEndlessActivityAllBonusRewardScRsp>, IDeepCloneable<TakeRogueEndlessActivityAllBonusRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> _parser = new MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp>(() => new TakeRogueEndlessActivityAllBonusRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MOGBNJOHKLAFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_mOGBNJOHKLA_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> mOGBNJOHKLA_ = new RepeatedField<uint>();

	public const int RewardFieldNumber = 5;

	private ItemList reward_;

	public const int NAGLJDCLGGBFieldNumber = 7;

	private uint nAGLJDCLGGB_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeRogueEndlessActivityAllBonusRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MOGBNJOHKLA => mOGBNJOHKLA_;

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
	public uint NAGLJDCLGGB
	{
		get
		{
			return nAGLJDCLGGB_;
		}
		set
		{
			nAGLJDCLGGB_ = value;
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
	public TakeRogueEndlessActivityAllBonusRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueEndlessActivityAllBonusRewardScRsp(TakeRogueEndlessActivityAllBonusRewardScRsp other)
		: this()
	{
		mOGBNJOHKLA_ = other.mOGBNJOHKLA_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		nAGLJDCLGGB_ = other.nAGLJDCLGGB_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueEndlessActivityAllBonusRewardScRsp Clone()
	{
		return new TakeRogueEndlessActivityAllBonusRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeRogueEndlessActivityAllBonusRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeRogueEndlessActivityAllBonusRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mOGBNJOHKLA_.Equals(other.mOGBNJOHKLA_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (NAGLJDCLGGB != other.NAGLJDCLGGB)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= mOGBNJOHKLA_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (NAGLJDCLGGB != 0)
		{
			num ^= NAGLJDCLGGB.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		mOGBNJOHKLA_.WriteTo(ref output, _repeated_mOGBNJOHKLA_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Reward);
		}
		if (NAGLJDCLGGB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NAGLJDCLGGB);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		num += mOGBNJOHKLA_.CalculateSize(_repeated_mOGBNJOHKLA_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (NAGLJDCLGGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NAGLJDCLGGB);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeRogueEndlessActivityAllBonusRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		mOGBNJOHKLA_.Add(other.mOGBNJOHKLA_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.NAGLJDCLGGB != 0)
		{
			NAGLJDCLGGB = other.NAGLJDCLGGB;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 26u:
				mOGBNJOHKLA_.AddEntriesFrom(ref input, _repeated_mOGBNJOHKLA_codec);
				break;
			case 42u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 56u:
				NAGLJDCLGGB = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
