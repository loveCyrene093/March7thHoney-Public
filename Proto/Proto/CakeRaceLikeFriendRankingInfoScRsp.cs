using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceLikeFriendRankingInfoScRsp : IMessage<CakeRaceLikeFriendRankingInfoScRsp>, IMessage, IEquatable<CakeRaceLikeFriendRankingInfoScRsp>, IDeepCloneable<CakeRaceLikeFriendRankingInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<CakeRaceLikeFriendRankingInfoScRsp> _parser = new MessageParser<CakeRaceLikeFriendRankingInfoScRsp>(() => new CakeRaceLikeFriendRankingInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int TeleportIdFieldNumber = 5;

	private uint teleportId_;

	public const int HFJNDOAIDOPFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_hFJNDOAIDOP_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> hFJNDOAIDOP_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int RewardListFieldNumber = 15;

	private ItemList rewardList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceLikeFriendRankingInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceLikeFriendRankingInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HFJNDOAIDOP => hFJNDOAIDOP_;

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
	public ItemList RewardList
	{
		get
		{
			return rewardList_;
		}
		set
		{
			rewardList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceLikeFriendRankingInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceLikeFriendRankingInfoScRsp(CakeRaceLikeFriendRankingInfoScRsp other)
		: this()
	{
		teleportId_ = other.teleportId_;
		hFJNDOAIDOP_ = other.hFJNDOAIDOP_.Clone();
		retcode_ = other.retcode_;
		rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceLikeFriendRankingInfoScRsp Clone()
	{
		return new CakeRaceLikeFriendRankingInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceLikeFriendRankingInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceLikeFriendRankingInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TeleportId != other.TeleportId)
		{
			return false;
		}
		if (!hFJNDOAIDOP_.Equals(other.hFJNDOAIDOP_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(RewardList, other.RewardList))
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
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
		}
		num ^= hFJNDOAIDOP_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (rewardList_ != null)
		{
			num ^= RewardList.GetHashCode();
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
		if (TeleportId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(TeleportId);
		}
		hFJNDOAIDOP_.WriteTo(ref output, _repeated_hFJNDOAIDOP_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (rewardList_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(RewardList);
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
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		num += hFJNDOAIDOP_.CalculateSize(_repeated_hFJNDOAIDOP_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (rewardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceLikeFriendRankingInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TeleportId != 0)
		{
			TeleportId = other.TeleportId;
		}
		hFJNDOAIDOP_.Add(other.hFJNDOAIDOP_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.rewardList_ != null)
		{
			if (rewardList_ == null)
			{
				RewardList = new ItemList();
			}
			RewardList.MergeFrom(other.RewardList);
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
			case 40u:
				TeleportId = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				hFJNDOAIDOP_.AddEntriesFrom(ref input, _repeated_hFJNDOAIDOP_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (rewardList_ == null)
				{
					RewardList = new ItemList();
				}
				input.ReadMessage(RewardList);
				break;
			}
		}
	}
}
