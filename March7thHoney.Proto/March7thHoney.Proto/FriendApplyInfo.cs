using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendApplyInfo : IMessage<FriendApplyInfo>, IMessage, IEquatable<FriendApplyInfo>, IDeepCloneable<FriendApplyInfo>, IBufferMessage
{
	private static readonly MessageParser<FriendApplyInfo> _parser = new MessageParser<FriendApplyInfo>(() => new FriendApplyInfo());

	private UnknownFieldSet _unknownFields;

	public const int ApplyTimeFieldNumber = 13;

	private long applyTime_;

	public const int PlayerInfoFieldNumber = 14;

	private PlayerSimpleInfo playerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendApplyInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FriendApplyInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ApplyTime
	{
		get
		{
			return applyTime_;
		}
		set
		{
			applyTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo PlayerInfo
	{
		get
		{
			return playerInfo_;
		}
		set
		{
			playerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendApplyInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendApplyInfo(FriendApplyInfo other)
		: this()
	{
		applyTime_ = other.applyTime_;
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendApplyInfo Clone()
	{
		return new FriendApplyInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendApplyInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendApplyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ApplyTime != other.ApplyTime)
		{
			return false;
		}
		if (!object.Equals(PlayerInfo, other.PlayerInfo))
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
		if (ApplyTime != 0L)
		{
			num ^= ApplyTime.GetHashCode();
		}
		if (playerInfo_ != null)
		{
			num ^= PlayerInfo.GetHashCode();
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
		if (ApplyTime != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(ApplyTime);
		}
		if (playerInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(PlayerInfo);
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
		if (ApplyTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ApplyTime);
		}
		if (playerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendApplyInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ApplyTime != 0L)
		{
			ApplyTime = other.ApplyTime;
		}
		if (other.playerInfo_ != null)
		{
			if (playerInfo_ == null)
			{
				PlayerInfo = new PlayerSimpleInfo();
			}
			PlayerInfo.MergeFrom(other.PlayerInfo);
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
			case 104u:
				ApplyTime = input.ReadInt64();
				break;
			case 114u:
				if (playerInfo_ == null)
				{
					PlayerInfo = new PlayerSimpleInfo();
				}
				input.ReadMessage(PlayerInfo);
				break;
			}
		}
	}
}
