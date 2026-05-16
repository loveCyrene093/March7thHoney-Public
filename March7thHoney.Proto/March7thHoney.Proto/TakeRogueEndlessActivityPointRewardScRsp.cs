using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeRogueEndlessActivityPointRewardScRsp : IMessage<TakeRogueEndlessActivityPointRewardScRsp>, IMessage, IEquatable<TakeRogueEndlessActivityPointRewardScRsp>, IDeepCloneable<TakeRogueEndlessActivityPointRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeRogueEndlessActivityPointRewardScRsp> _parser = new MessageParser<TakeRogueEndlessActivityPointRewardScRsp>(() => new TakeRogueEndlessActivityPointRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 1;

	private ItemList reward_;

	public const int OINMENFPODPFieldNumber = 2;

	private bool oINMENFPODP_;

	public const int NAGLJDCLGGBFieldNumber = 4;

	private uint nAGLJDCLGGB_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int MOGBNJOHKLAFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_mOGBNJOHKLA_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> mOGBNJOHKLA_ = new RepeatedField<uint>();

	public const int LevelFieldNumber = 13;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeRogueEndlessActivityPointRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeRogueEndlessActivityPointRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public bool OINMENFPODP
	{
		get
		{
			return oINMENFPODP_;
		}
		set
		{
			oINMENFPODP_ = value;
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
	public RepeatedField<uint> MOGBNJOHKLA => mOGBNJOHKLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueEndlessActivityPointRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueEndlessActivityPointRewardScRsp(TakeRogueEndlessActivityPointRewardScRsp other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		oINMENFPODP_ = other.oINMENFPODP_;
		nAGLJDCLGGB_ = other.nAGLJDCLGGB_;
		retcode_ = other.retcode_;
		mOGBNJOHKLA_ = other.mOGBNJOHKLA_.Clone();
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueEndlessActivityPointRewardScRsp Clone()
	{
		return new TakeRogueEndlessActivityPointRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeRogueEndlessActivityPointRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeRogueEndlessActivityPointRewardScRsp other)
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
		if (OINMENFPODP != other.OINMENFPODP)
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
		if (!mOGBNJOHKLA_.Equals(other.mOGBNJOHKLA_))
		{
			return false;
		}
		if (Level != other.Level)
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
		if (OINMENFPODP)
		{
			num ^= OINMENFPODP.GetHashCode();
		}
		if (NAGLJDCLGGB != 0)
		{
			num ^= NAGLJDCLGGB.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= mOGBNJOHKLA_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
			output.WriteRawTag(10);
			output.WriteMessage(Reward);
		}
		if (OINMENFPODP)
		{
			output.WriteRawTag(16);
			output.WriteBool(OINMENFPODP);
		}
		if (NAGLJDCLGGB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NAGLJDCLGGB);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		mOGBNJOHKLA_.WriteTo(ref output, _repeated_mOGBNJOHKLA_codec);
		if (Level != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Level);
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
		if (OINMENFPODP)
		{
			num += 2;
		}
		if (NAGLJDCLGGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NAGLJDCLGGB);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += mOGBNJOHKLA_.CalculateSize(_repeated_mOGBNJOHKLA_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeRogueEndlessActivityPointRewardScRsp other)
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
		if (other.OINMENFPODP)
		{
			OINMENFPODP = other.OINMENFPODP;
		}
		if (other.NAGLJDCLGGB != 0)
		{
			NAGLJDCLGGB = other.NAGLJDCLGGB;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		mOGBNJOHKLA_.Add(other.mOGBNJOHKLA_);
		if (other.Level != 0)
		{
			Level = other.Level;
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
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 16u:
				OINMENFPODP = input.ReadBool();
				break;
			case 32u:
				NAGLJDCLGGB = input.ReadUInt32();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				mOGBNJOHKLA_.AddEntriesFrom(ref input, _repeated_mOGBNJOHKLA_codec);
				break;
			case 104u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
