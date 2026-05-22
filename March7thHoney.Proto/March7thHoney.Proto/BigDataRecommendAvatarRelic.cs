using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BigDataRecommendAvatarRelic : IMessage<BigDataRecommendAvatarRelic>, IMessage, IEquatable<BigDataRecommendAvatarRelic>, IDeepCloneable<BigDataRecommendAvatarRelic>, IBufferMessage
{
	private static readonly MessageParser<BigDataRecommendAvatarRelic> _parser = new MessageParser<BigDataRecommendAvatarRelic>(() => new BigDataRecommendAvatarRelic());

	private UnknownFieldSet _unknownFields;

	public const int RecomendedRelicInfoListFieldNumber = 12;

	private static readonly FieldCodec<BigDataAvatarRelicRecommend> _repeated_recomendedRelicInfoList_codec = FieldCodec.ForMessage(98u, BigDataAvatarRelicRecommend.Parser);

	private readonly RepeatedField<BigDataAvatarRelicRecommend> recomendedRelicInfoList_ = new RepeatedField<BigDataAvatarRelicRecommend>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BigDataRecommendAvatarRelic> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BigDataRecommendAvatarRelicReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BigDataAvatarRelicRecommend> RecomendedRelicInfoList => recomendedRelicInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendAvatarRelic()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendAvatarRelic(BigDataRecommendAvatarRelic other)
		: this()
	{
		recomendedRelicInfoList_ = other.recomendedRelicInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendAvatarRelic Clone()
	{
		return new BigDataRecommendAvatarRelic(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BigDataRecommendAvatarRelic);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BigDataRecommendAvatarRelic other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!recomendedRelicInfoList_.Equals(other.recomendedRelicInfoList_))
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
		num ^= recomendedRelicInfoList_.GetHashCode();
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
		recomendedRelicInfoList_.WriteTo(ref output, _repeated_recomendedRelicInfoList_codec);
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
		num += recomendedRelicInfoList_.CalculateSize(_repeated_recomendedRelicInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BigDataRecommendAvatarRelic other)
	{
		if (other != null)
		{
			recomendedRelicInfoList_.Add(other.recomendedRelicInfoList_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				recomendedRelicInfoList_.AddEntriesFrom(ref input, _repeated_recomendedRelicInfoList_codec);
			}
		}
	}
}
