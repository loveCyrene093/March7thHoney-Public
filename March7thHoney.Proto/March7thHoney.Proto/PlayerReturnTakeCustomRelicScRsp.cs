using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnTakeCustomRelicScRsp : IMessage<PlayerReturnTakeCustomRelicScRsp>, IMessage, IEquatable<PlayerReturnTakeCustomRelicScRsp>, IDeepCloneable<PlayerReturnTakeCustomRelicScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnTakeCustomRelicScRsp> _parser = new MessageParser<PlayerReturnTakeCustomRelicScRsp>(() => new PlayerReturnTakeCustomRelicScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RelicListFieldNumber = 2;

	private static readonly FieldCodec<Relic> _repeated_relicList_codec = FieldCodec.ForMessage(18u, Relic.Parser);

	private readonly RepeatedField<Relic> relicList_ = new RepeatedField<Relic>();

	public const int AvatarIdFieldNumber = 7;

	private uint avatarId_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnTakeCustomRelicScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnTakeCustomRelicScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Relic> RelicList => relicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
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
	public PlayerReturnTakeCustomRelicScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeCustomRelicScRsp(PlayerReturnTakeCustomRelicScRsp other)
		: this()
	{
		relicList_ = other.relicList_.Clone();
		avatarId_ = other.avatarId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeCustomRelicScRsp Clone()
	{
		return new PlayerReturnTakeCustomRelicScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnTakeCustomRelicScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnTakeCustomRelicScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!relicList_.Equals(other.relicList_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= relicList_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		relicList_.WriteTo(ref output, _repeated_relicList_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AvatarId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
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
		num += relicList_.CalculateSize(_repeated_relicList_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnTakeCustomRelicScRsp other)
	{
		if (other != null)
		{
			relicList_.Add(other.relicList_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 18u:
				relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
				break;
			case 56u:
				AvatarId = input.ReadUInt32();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
