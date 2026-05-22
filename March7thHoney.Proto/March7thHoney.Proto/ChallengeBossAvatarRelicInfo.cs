using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossAvatarRelicInfo : IMessage<ChallengeBossAvatarRelicInfo>, IMessage, IEquatable<ChallengeBossAvatarRelicInfo>, IDeepCloneable<ChallengeBossAvatarRelicInfo>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossAvatarRelicInfo> _parser = new MessageParser<ChallengeBossAvatarRelicInfo>(() => new ChallengeBossAvatarRelicInfo());

	private UnknownFieldSet _unknownFields;

	public const int AvatarRelicSlotMapFieldNumber = 1;

	private static readonly MapField<uint, ChallengeBossRelicInfo>.Codec _map_avatarRelicSlotMap_codec = new MapField<uint, ChallengeBossRelicInfo>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, ChallengeBossRelicInfo.Parser), 10u);

	private readonly MapField<uint, ChallengeBossRelicInfo> avatarRelicSlotMap_ = new MapField<uint, ChallengeBossRelicInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossAvatarRelicInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossAvatarRelicInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, ChallengeBossRelicInfo> AvatarRelicSlotMap => avatarRelicSlotMap_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossAvatarRelicInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossAvatarRelicInfo(ChallengeBossAvatarRelicInfo other)
		: this()
	{
		avatarRelicSlotMap_ = other.avatarRelicSlotMap_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossAvatarRelicInfo Clone()
	{
		return new ChallengeBossAvatarRelicInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossAvatarRelicInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossAvatarRelicInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!AvatarRelicSlotMap.Equals(other.AvatarRelicSlotMap))
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
		num ^= AvatarRelicSlotMap.GetHashCode();
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
		avatarRelicSlotMap_.WriteTo(ref output, _map_avatarRelicSlotMap_codec);
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
		num += avatarRelicSlotMap_.CalculateSize(_map_avatarRelicSlotMap_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossAvatarRelicInfo other)
	{
		if (other != null)
		{
			avatarRelicSlotMap_.MergeFrom(other.avatarRelicSlotMap_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				avatarRelicSlotMap_.AddEntriesFrom(ref input, _map_avatarRelicSlotMap_codec);
			}
		}
	}
}
