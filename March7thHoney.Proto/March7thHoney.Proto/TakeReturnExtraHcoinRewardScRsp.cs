using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeReturnExtraHcoinRewardScRsp : IMessage<TakeReturnExtraHcoinRewardScRsp>, IMessage, IEquatable<TakeReturnExtraHcoinRewardScRsp>, IDeepCloneable<TakeReturnExtraHcoinRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeReturnExtraHcoinRewardScRsp> _parser = new MessageParser<TakeReturnExtraHcoinRewardScRsp>(() => new TakeReturnExtraHcoinRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GEEFOKFBPDKFieldNumber = 4;

	private uint gEEFOKFBPDK_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int RewardFieldNumber = 7;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeReturnExtraHcoinRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeReturnExtraHcoinRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GEEFOKFBPDK
	{
		get
		{
			return gEEFOKFBPDK_;
		}
		set
		{
			gEEFOKFBPDK_ = value;
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
	public TakeReturnExtraHcoinRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeReturnExtraHcoinRewardScRsp(TakeReturnExtraHcoinRewardScRsp other)
		: this()
	{
		gEEFOKFBPDK_ = other.gEEFOKFBPDK_;
		retcode_ = other.retcode_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeReturnExtraHcoinRewardScRsp Clone()
	{
		return new TakeReturnExtraHcoinRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeReturnExtraHcoinRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeReturnExtraHcoinRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GEEFOKFBPDK != other.GEEFOKFBPDK)
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
		if (GEEFOKFBPDK != 0)
		{
			num ^= GEEFOKFBPDK.GetHashCode();
		}
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
		if (GEEFOKFBPDK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GEEFOKFBPDK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
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
		if (GEEFOKFBPDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GEEFOKFBPDK);
		}
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
	public void MergeFrom(TakeReturnExtraHcoinRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GEEFOKFBPDK != 0)
		{
			GEEFOKFBPDK = other.GEEFOKFBPDK;
		}
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
			case 32u:
				GEEFOKFBPDK = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
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
