using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BigDataRecommendRelicAvatar : IMessage<BigDataRecommendRelicAvatar>, IMessage, IEquatable<BigDataRecommendRelicAvatar>, IDeepCloneable<BigDataRecommendRelicAvatar>, IBufferMessage
{
	private static readonly MessageParser<BigDataRecommendRelicAvatar> _parser = new MessageParser<BigDataRecommendRelicAvatar>(() => new BigDataRecommendRelicAvatar());

	private UnknownFieldSet _unknownFields;

	public const int RecommendedAvatarInfoListFieldNumber = 3;

	private static readonly FieldCodec<RecomendedAvatarInfo> _repeated_recommendedAvatarInfoList_codec = FieldCodec.ForMessage(26u, RecomendedAvatarInfo.Parser);

	private readonly RepeatedField<RecomendedAvatarInfo> recommendedAvatarInfoList_ = new RepeatedField<RecomendedAvatarInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BigDataRecommendRelicAvatar> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BigDataRecommendRelicAvatarReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RecomendedAvatarInfo> RecommendedAvatarInfoList => recommendedAvatarInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendRelicAvatar()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendRelicAvatar(BigDataRecommendRelicAvatar other)
		: this()
	{
		recommendedAvatarInfoList_ = other.recommendedAvatarInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendRelicAvatar Clone()
	{
		return new BigDataRecommendRelicAvatar(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BigDataRecommendRelicAvatar);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BigDataRecommendRelicAvatar other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!recommendedAvatarInfoList_.Equals(other.recommendedAvatarInfoList_))
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
		num ^= recommendedAvatarInfoList_.GetHashCode();
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
		recommendedAvatarInfoList_.WriteTo(ref output, _repeated_recommendedAvatarInfoList_codec);
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
		num += recommendedAvatarInfoList_.CalculateSize(_repeated_recommendedAvatarInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BigDataRecommendRelicAvatar other)
	{
		if (other != null)
		{
			recommendedAvatarInfoList_.Add(other.recommendedAvatarInfoList_);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				recommendedAvatarInfoList_.AddEntriesFrom(ref input, _repeated_recommendedAvatarInfoList_codec);
			}
		}
	}
}
