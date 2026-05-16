using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeQuestRewardScRsp : IMessage<TakeQuestRewardScRsp>, IMessage, IEquatable<TakeQuestRewardScRsp>, IDeepCloneable<TakeQuestRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeQuestRewardScRsp> _parser = new MessageParser<TakeQuestRewardScRsp>(() => new TakeQuestRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 1;

	private ItemList reward_;

	public const int FNIPKMFJMCEFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_fNIPKMFJMCE_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> fNIPKMFJMCE_ = new RepeatedField<uint>();

	public const int SuccQuestIdListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_succQuestIdList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> succQuestIdList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeQuestRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeQuestRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> FNIPKMFJMCE => fNIPKMFJMCE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SuccQuestIdList => succQuestIdList_;

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
	public TakeQuestRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeQuestRewardScRsp(TakeQuestRewardScRsp other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		fNIPKMFJMCE_ = other.fNIPKMFJMCE_.Clone();
		succQuestIdList_ = other.succQuestIdList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeQuestRewardScRsp Clone()
	{
		return new TakeQuestRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeQuestRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeQuestRewardScRsp other)
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
		if (!fNIPKMFJMCE_.Equals(other.fNIPKMFJMCE_))
		{
			return false;
		}
		if (!succQuestIdList_.Equals(other.succQuestIdList_))
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		num ^= fNIPKMFJMCE_.GetHashCode();
		num ^= succQuestIdList_.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Reward);
		}
		fNIPKMFJMCE_.WriteTo(ref output, _repeated_fNIPKMFJMCE_codec);
		succQuestIdList_.WriteTo(ref output, _repeated_succQuestIdList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		num += fNIPKMFJMCE_.CalculateSize(_repeated_fNIPKMFJMCE_codec);
		num += succQuestIdList_.CalculateSize(_repeated_succQuestIdList_codec);
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
	public void MergeFrom(TakeQuestRewardScRsp other)
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
		fNIPKMFJMCE_.Add(other.fNIPKMFJMCE_);
		succQuestIdList_.Add(other.succQuestIdList_);
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
			case 10u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 16u:
			case 18u:
				fNIPKMFJMCE_.AddEntriesFrom(ref input, _repeated_fNIPKMFJMCE_codec);
				break;
			case 32u:
			case 34u:
				succQuestIdList_.AddEntriesFrom(ref input, _repeated_succQuestIdList_codec);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
