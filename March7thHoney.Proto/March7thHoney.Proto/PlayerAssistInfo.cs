using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerAssistInfo : IMessage<PlayerAssistInfo>, IMessage, IEquatable<PlayerAssistInfo>, IDeepCloneable<PlayerAssistInfo>, IBufferMessage
{
	private static readonly MessageParser<PlayerAssistInfo> _parser = new MessageParser<PlayerAssistInfo>(() => new PlayerAssistInfo());

	private UnknownFieldSet _unknownFields;

	public const int AssistAvatarFieldNumber = 11;

	private DisplayAvatarDetailInfo assistAvatar_;

	public const int PlayerInfoFieldNumber = 15;

	private PlayerSimpleInfo playerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerAssistInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerAssistInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarDetailInfo AssistAvatar
	{
		get
		{
			return assistAvatar_;
		}
		set
		{
			assistAvatar_ = value;
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
	public PlayerAssistInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerAssistInfo(PlayerAssistInfo other)
		: this()
	{
		assistAvatar_ = ((other.assistAvatar_ != null) ? other.assistAvatar_.Clone() : null);
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerAssistInfo Clone()
	{
		return new PlayerAssistInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerAssistInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerAssistInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AssistAvatar, other.AssistAvatar))
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
		if (assistAvatar_ != null)
		{
			num ^= AssistAvatar.GetHashCode();
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
		if (assistAvatar_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(AssistAvatar);
		}
		if (playerInfo_ != null)
		{
			output.WriteRawTag(122);
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
		if (assistAvatar_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AssistAvatar);
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
	public void MergeFrom(PlayerAssistInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.assistAvatar_ != null)
		{
			if (assistAvatar_ == null)
			{
				AssistAvatar = new DisplayAvatarDetailInfo();
			}
			AssistAvatar.MergeFrom(other.AssistAvatar);
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
			case 90u:
				if (assistAvatar_ == null)
				{
					AssistAvatar = new DisplayAvatarDetailInfo();
				}
				input.ReadMessage(AssistAvatar);
				break;
			case 122u:
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
