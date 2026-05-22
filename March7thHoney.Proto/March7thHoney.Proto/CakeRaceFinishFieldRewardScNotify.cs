using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceFinishFieldRewardScNotify : IMessage<CakeRaceFinishFieldRewardScNotify>, IMessage, IEquatable<CakeRaceFinishFieldRewardScNotify>, IDeepCloneable<CakeRaceFinishFieldRewardScNotify>, IBufferMessage
{
	private static readonly MessageParser<CakeRaceFinishFieldRewardScNotify> _parser = new MessageParser<CakeRaceFinishFieldRewardScNotify>(() => new CakeRaceFinishFieldRewardScNotify());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 10;

	private ItemList reward_;

	public const int JAFNCOMGABGFieldNumber = 14;

	private uint jAFNCOMGABG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceFinishFieldRewardScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceFinishFieldRewardScNotifyReflection.Descriptor.MessageTypes[0];

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
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceFinishFieldRewardScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceFinishFieldRewardScNotify(CakeRaceFinishFieldRewardScNotify other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceFinishFieldRewardScNotify Clone()
	{
		return new CakeRaceFinishFieldRewardScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceFinishFieldRewardScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceFinishFieldRewardScNotify other)
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
		if (JAFNCOMGABG != other.JAFNCOMGABG)
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
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
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
			output.WriteRawTag(82);
			output.WriteMessage(Reward);
		}
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JAFNCOMGABG);
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
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceFinishFieldRewardScNotify other)
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
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
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
			case 82u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 112u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			}
		}
	}
}
