using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateTakeExpRewardScRsp : IMessage<FateTakeExpRewardScRsp>, IMessage, IEquatable<FateTakeExpRewardScRsp>, IDeepCloneable<FateTakeExpRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<FateTakeExpRewardScRsp> _parser = new MessageParser<FateTakeExpRewardScRsp>(() => new FateTakeExpRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AKCJLIELLCCFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_aKCJLIELLCC_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> aKCJLIELLCC_ = new RepeatedField<uint>();

	public const int RewardFieldNumber = 7;

	private ItemList reward_;

	public const int NLCDIKNHMJMFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_nLCDIKNHMJM_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> nLCDIKNHMJM_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateTakeExpRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateTakeExpRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AKCJLIELLCC => aKCJLIELLCC_;

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
	public RepeatedField<uint> NLCDIKNHMJM => nLCDIKNHMJM_;

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
	public FateTakeExpRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateTakeExpRewardScRsp(FateTakeExpRewardScRsp other)
		: this()
	{
		aKCJLIELLCC_ = other.aKCJLIELLCC_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		nLCDIKNHMJM_ = other.nLCDIKNHMJM_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateTakeExpRewardScRsp Clone()
	{
		return new FateTakeExpRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateTakeExpRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateTakeExpRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aKCJLIELLCC_.Equals(other.aKCJLIELLCC_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!nLCDIKNHMJM_.Equals(other.nLCDIKNHMJM_))
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
		num ^= aKCJLIELLCC_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		num ^= nLCDIKNHMJM_.GetHashCode();
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
		aKCJLIELLCC_.WriteTo(ref output, _repeated_aKCJLIELLCC_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Reward);
		}
		nLCDIKNHMJM_.WriteTo(ref output, _repeated_nLCDIKNHMJM_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
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
		num += aKCJLIELLCC_.CalculateSize(_repeated_aKCJLIELLCC_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		num += nLCDIKNHMJM_.CalculateSize(_repeated_nLCDIKNHMJM_codec);
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
	public void MergeFrom(FateTakeExpRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		aKCJLIELLCC_.Add(other.aKCJLIELLCC_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		nLCDIKNHMJM_.Add(other.nLCDIKNHMJM_);
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
			case 16u:
			case 18u:
				aKCJLIELLCC_.AddEntriesFrom(ref input, _repeated_aKCJLIELLCC_codec);
				break;
			case 58u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 72u:
			case 74u:
				nLCDIKNHMJM_.AddEntriesFrom(ref input, _repeated_nLCDIKNHMJM_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
