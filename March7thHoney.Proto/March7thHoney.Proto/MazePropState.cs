using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MazePropState : IMessage<MazePropState>, IMessage, IEquatable<MazePropState>, IDeepCloneable<MazePropState>, IBufferMessage
{
	private static readonly MessageParser<MazePropState> _parser = new MessageParser<MazePropState>(() => new MazePropState());

	private UnknownFieldSet _unknownFields;

	public const int ConfigIdFieldNumber = 8;

	private uint configId_;

	public const int ExtraInfoFieldNumber = 9;

	private PropExtraInfo extraInfo_;

	public const int StateFieldNumber = 11;

	private uint state_;

	public const int GroupIdFieldNumber = 13;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MazePropState> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MazePropStateReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropExtraInfo ExtraInfo
	{
		get
		{
			return extraInfo_;
		}
		set
		{
			extraInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazePropState()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazePropState(MazePropState other)
		: this()
	{
		configId_ = other.configId_;
		extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
		state_ = other.state_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazePropState Clone()
	{
		return new MazePropState(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MazePropState);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MazePropState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (!object.Equals(ExtraInfo, other.ExtraInfo))
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (GroupId != other.GroupId)
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
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (extraInfo_ != null)
		{
			num ^= ExtraInfo.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		if (ConfigId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ConfigId);
		}
		if (extraInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ExtraInfo);
		}
		if (State != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(State);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GroupId);
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
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (extraInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraInfo);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(State);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MazePropState other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
		}
		if (other.extraInfo_ != null)
		{
			if (extraInfo_ == null)
			{
				ExtraInfo = new PropExtraInfo();
			}
			ExtraInfo.MergeFrom(other.ExtraInfo);
		}
		if (other.State != 0)
		{
			State = other.State;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
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
			case 64u:
				ConfigId = input.ReadUInt32();
				break;
			case 74u:
				if (extraInfo_ == null)
				{
					ExtraInfo = new PropExtraInfo();
				}
				input.ReadMessage(ExtraInfo);
				break;
			case 88u:
				State = input.ReadUInt32();
				break;
			case 104u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
