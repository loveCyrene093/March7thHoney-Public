using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RecomendedAvatarInfo : IMessage<RecomendedAvatarInfo>, IMessage, IEquatable<RecomendedAvatarInfo>, IDeepCloneable<RecomendedAvatarInfo>, IBufferMessage
{
	private static readonly MessageParser<RecomendedAvatarInfo> _parser = new MessageParser<RecomendedAvatarInfo>(() => new RecomendedAvatarInfo());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

	public const int RecommendAvatarIdFieldNumber = 8;

	private uint recommendAvatarId_;

	public const int RelicSetIdFieldNumber = 9;

	private uint relicSetId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RecomendedAvatarInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RecomendedAvatarInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarIdList => avatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RecommendAvatarId
	{
		get
		{
			return recommendAvatarId_;
		}
		set
		{
			recommendAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicSetId
	{
		get
		{
			return relicSetId_;
		}
		set
		{
			relicSetId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecomendedAvatarInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecomendedAvatarInfo(RecomendedAvatarInfo other)
		: this()
	{
		avatarIdList_ = other.avatarIdList_.Clone();
		recommendAvatarId_ = other.recommendAvatarId_;
		relicSetId_ = other.relicSetId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecomendedAvatarInfo Clone()
	{
		return new RecomendedAvatarInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RecomendedAvatarInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RecomendedAvatarInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarIdList_.Equals(other.avatarIdList_))
		{
			return false;
		}
		if (RecommendAvatarId != other.RecommendAvatarId)
		{
			return false;
		}
		if (RelicSetId != other.RelicSetId)
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
		num ^= avatarIdList_.GetHashCode();
		if (RecommendAvatarId != 0)
		{
			num ^= RecommendAvatarId.GetHashCode();
		}
		if (RelicSetId != 0)
		{
			num ^= RelicSetId.GetHashCode();
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
		avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
		if (RecommendAvatarId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(RecommendAvatarId);
		}
		if (RelicSetId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RelicSetId);
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
		num += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
		if (RecommendAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecommendAvatarId);
		}
		if (RelicSetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicSetId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RecomendedAvatarInfo other)
	{
		if (other != null)
		{
			avatarIdList_.Add(other.avatarIdList_);
			if (other.RecommendAvatarId != 0)
			{
				RecommendAvatarId = other.RecommendAvatarId;
			}
			if (other.RelicSetId != 0)
			{
				RelicSetId = other.RelicSetId;
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
			case 16u:
			case 18u:
				avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
				break;
			case 64u:
				RecommendAvatarId = input.ReadUInt32();
				break;
			case 72u:
				RelicSetId = input.ReadUInt32();
				break;
			}
		}
	}
}
