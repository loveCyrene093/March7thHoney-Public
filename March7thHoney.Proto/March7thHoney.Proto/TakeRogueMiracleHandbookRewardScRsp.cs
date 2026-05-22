using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeRogueMiracleHandbookRewardScRsp : IMessage<TakeRogueMiracleHandbookRewardScRsp>, IMessage, IEquatable<TakeRogueMiracleHandbookRewardScRsp>, IDeepCloneable<TakeRogueMiracleHandbookRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeRogueMiracleHandbookRewardScRsp> _parser = new MessageParser<TakeRogueMiracleHandbookRewardScRsp>(() => new TakeRogueMiracleHandbookRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AGFOMKOIAEBFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_aGFOMKOIAEB_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> aGFOMKOIAEB_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int RewardFieldNumber = 12;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeRogueMiracleHandbookRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeRogueMiracleHandbookRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AGFOMKOIAEB => aGFOMKOIAEB_;

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
	public TakeRogueMiracleHandbookRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueMiracleHandbookRewardScRsp(TakeRogueMiracleHandbookRewardScRsp other)
		: this()
	{
		aGFOMKOIAEB_ = other.aGFOMKOIAEB_.Clone();
		retcode_ = other.retcode_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeRogueMiracleHandbookRewardScRsp Clone()
	{
		return new TakeRogueMiracleHandbookRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeRogueMiracleHandbookRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeRogueMiracleHandbookRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aGFOMKOIAEB_.Equals(other.aGFOMKOIAEB_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= aGFOMKOIAEB_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		aGFOMKOIAEB_.WriteTo(ref output, _repeated_aGFOMKOIAEB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(98);
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
		num += aGFOMKOIAEB_.CalculateSize(_repeated_aGFOMKOIAEB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
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
	public void MergeFrom(TakeRogueMiracleHandbookRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		aGFOMKOIAEB_.Add(other.aGFOMKOIAEB_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 8u:
			case 10u:
				aGFOMKOIAEB_.AddEntriesFrom(ref input, _repeated_aGFOMKOIAEB_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
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
