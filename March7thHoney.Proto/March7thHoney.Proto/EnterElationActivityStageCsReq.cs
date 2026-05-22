using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterElationActivityStageCsReq : IMessage<EnterElationActivityStageCsReq>, IMessage, IEquatable<EnterElationActivityStageCsReq>, IDeepCloneable<EnterElationActivityStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterElationActivityStageCsReq> _parser = new MessageParser<EnterElationActivityStageCsReq>(() => new EnterElationActivityStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PlayerSelectedAvatarListFieldNumber = 7;

	private static readonly FieldCodec<ElationActivityAvatar> _repeated_playerSelectedAvatarList_codec = FieldCodec.ForMessage(58u, ElationActivityAvatar.Parser);

	private readonly RepeatedField<ElationActivityAvatar> playerSelectedAvatarList_ = new RepeatedField<ElationActivityAvatar>();

	public const int FixedAvatarListFieldNumber = 8;

	private static readonly FieldCodec<ElationActivityAvatar> _repeated_fixedAvatarList_codec = FieldCodec.ForMessage(66u, ElationActivityAvatar.Parser);

	private readonly RepeatedField<ElationActivityAvatar> fixedAvatarList_ = new RepeatedField<ElationActivityAvatar>();

	public const int LevelIdFieldNumber = 11;

	private uint levelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterElationActivityStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterElationActivityStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ElationActivityAvatar> PlayerSelectedAvatarList => playerSelectedAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ElationActivityAvatar> FixedAvatarList => fixedAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterElationActivityStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterElationActivityStageCsReq(EnterElationActivityStageCsReq other)
		: this()
	{
		playerSelectedAvatarList_ = other.playerSelectedAvatarList_.Clone();
		fixedAvatarList_ = other.fixedAvatarList_.Clone();
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterElationActivityStageCsReq Clone()
	{
		return new EnterElationActivityStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterElationActivityStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterElationActivityStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!playerSelectedAvatarList_.Equals(other.playerSelectedAvatarList_))
		{
			return false;
		}
		if (!fixedAvatarList_.Equals(other.fixedAvatarList_))
		{
			return false;
		}
		if (LevelId != other.LevelId)
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
		num ^= playerSelectedAvatarList_.GetHashCode();
		num ^= fixedAvatarList_.GetHashCode();
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
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
		playerSelectedAvatarList_.WriteTo(ref output, _repeated_playerSelectedAvatarList_codec);
		fixedAvatarList_.WriteTo(ref output, _repeated_fixedAvatarList_codec);
		if (LevelId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LevelId);
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
		num += playerSelectedAvatarList_.CalculateSize(_repeated_playerSelectedAvatarList_codec);
		num += fixedAvatarList_.CalculateSize(_repeated_fixedAvatarList_codec);
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterElationActivityStageCsReq other)
	{
		if (other != null)
		{
			playerSelectedAvatarList_.Add(other.playerSelectedAvatarList_);
			fixedAvatarList_.Add(other.fixedAvatarList_);
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
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
			case 58u:
				playerSelectedAvatarList_.AddEntriesFrom(ref input, _repeated_playerSelectedAvatarList_codec);
				break;
			case 66u:
				fixedAvatarList_.AddEntriesFrom(ref input, _repeated_fixedAvatarList_codec);
				break;
			case 88u:
				LevelId = input.ReadUInt32();
				break;
			}
		}
	}
}
