using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdatePlayerSettingCsReq : IMessage<UpdatePlayerSettingCsReq>, IMessage, IEquatable<UpdatePlayerSettingCsReq>, IDeepCloneable<UpdatePlayerSettingCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdatePlayerSettingCsReq> _parser = new MessageParser<UpdatePlayerSettingCsReq>(() => new UpdatePlayerSettingCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PlayerSettingFieldNumber = 3;

	private UpdatePlayerSetting playerSetting_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdatePlayerSettingCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdatePlayerSettingCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSetting PlayerSetting
	{
		get
		{
			return playerSetting_;
		}
		set
		{
			playerSetting_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSettingCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSettingCsReq(UpdatePlayerSettingCsReq other)
		: this()
	{
		playerSetting_ = ((other.playerSetting_ != null) ? other.playerSetting_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdatePlayerSettingCsReq Clone()
	{
		return new UpdatePlayerSettingCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdatePlayerSettingCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdatePlayerSettingCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PlayerSetting, other.PlayerSetting))
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
		if (playerSetting_ != null)
		{
			num ^= PlayerSetting.GetHashCode();
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
		if (playerSetting_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PlayerSetting);
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
		if (playerSetting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerSetting);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdatePlayerSettingCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.playerSetting_ != null)
		{
			if (playerSetting_ == null)
			{
				PlayerSetting = new UpdatePlayerSetting();
			}
			PlayerSetting.MergeFrom(other.PlayerSetting);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (playerSetting_ == null)
			{
				PlayerSetting = new UpdatePlayerSetting();
			}
			input.ReadMessage(PlayerSetting);
		}
	}
}
