using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournUseSuperRewardKeyScRsp : IMessage<RogueTournUseSuperRewardKeyScRsp>, IMessage, IEquatable<RogueTournUseSuperRewardKeyScRsp>, IDeepCloneable<RogueTournUseSuperRewardKeyScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournUseSuperRewardKeyScRsp> _parser = new MessageParser<RogueTournUseSuperRewardKeyScRsp>(() => new RogueTournUseSuperRewardKeyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HICNFJDGGGLFieldNumber = 1;

	private NNOIJJNCHJB hICNFJDGGGL_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int DropDataFieldNumber = 14;

	private ItemList dropData_;

	public const int RewardFieldNumber = 15;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournUseSuperRewardKeyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournUseSuperRewardKeyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNOIJJNCHJB HICNFJDGGGL
	{
		get
		{
			return hICNFJDGGGL_;
		}
		set
		{
			hICNFJDGGGL_ = value;
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
	public ItemList DropData
	{
		get
		{
			return dropData_;
		}
		set
		{
			dropData_ = value;
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
	public RogueTournUseSuperRewardKeyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournUseSuperRewardKeyScRsp(RogueTournUseSuperRewardKeyScRsp other)
		: this()
	{
		hICNFJDGGGL_ = ((other.hICNFJDGGGL_ != null) ? other.hICNFJDGGGL_.Clone() : null);
		retcode_ = other.retcode_;
		dropData_ = ((other.dropData_ != null) ? other.dropData_.Clone() : null);
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournUseSuperRewardKeyScRsp Clone()
	{
		return new RogueTournUseSuperRewardKeyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournUseSuperRewardKeyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournUseSuperRewardKeyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HICNFJDGGGL, other.HICNFJDGGGL))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(DropData, other.DropData))
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
		if (hICNFJDGGGL_ != null)
		{
			num ^= HICNFJDGGGL.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (dropData_ != null)
		{
			num ^= DropData.GetHashCode();
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
		if (hICNFJDGGGL_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HICNFJDGGGL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (dropData_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(DropData);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(122);
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
		if (hICNFJDGGGL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HICNFJDGGGL);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (dropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropData);
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
	public void MergeFrom(RogueTournUseSuperRewardKeyScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hICNFJDGGGL_ != null)
		{
			if (hICNFJDGGGL_ == null)
			{
				HICNFJDGGGL = new NNOIJJNCHJB();
			}
			HICNFJDGGGL.MergeFrom(other.HICNFJDGGGL);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dropData_ != null)
		{
			if (dropData_ == null)
			{
				DropData = new ItemList();
			}
			DropData.MergeFrom(other.DropData);
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
				if (hICNFJDGGGL_ == null)
				{
					HICNFJDGGGL = new NNOIJJNCHJB();
				}
				input.ReadMessage(HICNFJDGGGL);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (dropData_ == null)
				{
					DropData = new ItemList();
				}
				input.ReadMessage(DropData);
				break;
			case 122u:
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
