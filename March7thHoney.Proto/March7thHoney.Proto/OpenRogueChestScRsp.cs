using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpenRogueChestScRsp : IMessage<OpenRogueChestScRsp>, IMessage, IEquatable<OpenRogueChestScRsp>, IDeepCloneable<OpenRogueChestScRsp>, IBufferMessage
{
	private static readonly MessageParser<OpenRogueChestScRsp> _parser = new MessageParser<OpenRogueChestScRsp>(() => new OpenRogueChestScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int RewardFieldNumber = 2;

	private ItemList reward_;

	public const int DropDataFieldNumber = 7;

	private ItemList dropData_;

	public const int HICNFJDGGGLFieldNumber = 12;

	private NNOIJJNCHJB hICNFJDGGGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OpenRogueChestScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OpenRogueChestScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public OpenRogueChestScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRogueChestScRsp(OpenRogueChestScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		dropData_ = ((other.dropData_ != null) ? other.dropData_.Clone() : null);
		hICNFJDGGGL_ = ((other.hICNFJDGGGL_ != null) ? other.hICNFJDGGGL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRogueChestScRsp Clone()
	{
		return new OpenRogueChestScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OpenRogueChestScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpenRogueChestScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!object.Equals(DropData, other.DropData))
		{
			return false;
		}
		if (!object.Equals(HICNFJDGGGL, other.HICNFJDGGGL))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (dropData_ != null)
		{
			num ^= DropData.GetHashCode();
		}
		if (hICNFJDGGGL_ != null)
		{
			num ^= HICNFJDGGGL.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Reward);
		}
		if (dropData_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(DropData);
		}
		if (hICNFJDGGGL_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(HICNFJDGGGL);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (dropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropData);
		}
		if (hICNFJDGGGL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HICNFJDGGGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpenRogueChestScRsp other)
	{
		if (other == null)
		{
			return;
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
		if (other.dropData_ != null)
		{
			if (dropData_ == null)
			{
				DropData = new ItemList();
			}
			DropData.MergeFrom(other.DropData);
		}
		if (other.hICNFJDGGGL_ != null)
		{
			if (hICNFJDGGGL_ == null)
			{
				HICNFJDGGGL = new NNOIJJNCHJB();
			}
			HICNFJDGGGL.MergeFrom(other.HICNFJDGGGL);
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
				Retcode = input.ReadUInt32();
				break;
			case 18u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 58u:
				if (dropData_ == null)
				{
					DropData = new ItemList();
				}
				input.ReadMessage(DropData);
				break;
			case 98u:
				if (hICNFJDGGGL_ == null)
				{
					HICNFJDGGGL = new NNOIJJNCHJB();
				}
				input.ReadMessage(HICNFJDGGGL);
				break;
			}
		}
	}
}
