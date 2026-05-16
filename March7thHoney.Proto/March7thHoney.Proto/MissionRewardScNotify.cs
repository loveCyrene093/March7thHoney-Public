using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionRewardScNotify : IMessage<MissionRewardScNotify>, IMessage, IEquatable<MissionRewardScNotify>, IDeepCloneable<MissionRewardScNotify>, IBufferMessage
{
	private static readonly MessageParser<MissionRewardScNotify> _parser = new MessageParser<MissionRewardScNotify>(() => new MissionRewardScNotify());

	private UnknownFieldSet _unknownFields;

	public const int SubMissionIdFieldNumber = 2;

	private uint subMissionId_;

	public const int MainMissionIdFieldNumber = 6;

	private uint mainMissionId_;

	public const int RewardFieldNumber = 10;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionRewardScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionRewardScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SubMissionId
	{
		get
		{
			return subMissionId_;
		}
		set
		{
			subMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainMissionId
	{
		get
		{
			return mainMissionId_;
		}
		set
		{
			mainMissionId_ = value;
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
	public MissionRewardScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionRewardScNotify(MissionRewardScNotify other)
		: this()
	{
		subMissionId_ = other.subMissionId_;
		mainMissionId_ = other.mainMissionId_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionRewardScNotify Clone()
	{
		return new MissionRewardScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionRewardScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionRewardScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SubMissionId != other.SubMissionId)
		{
			return false;
		}
		if (MainMissionId != other.MainMissionId)
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
		if (SubMissionId != 0)
		{
			num ^= SubMissionId.GetHashCode();
		}
		if (MainMissionId != 0)
		{
			num ^= MainMissionId.GetHashCode();
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
		if (SubMissionId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SubMissionId);
		}
		if (MainMissionId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MainMissionId);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(82);
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
		if (SubMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SubMissionId);
		}
		if (MainMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainMissionId);
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
	public void MergeFrom(MissionRewardScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SubMissionId != 0)
		{
			SubMissionId = other.SubMissionId;
		}
		if (other.MainMissionId != 0)
		{
			MainMissionId = other.MainMissionId;
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
			case 16u:
				SubMissionId = input.ReadUInt32();
				break;
			case 48u:
				MainMissionId = input.ReadUInt32();
				break;
			case 82u:
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
