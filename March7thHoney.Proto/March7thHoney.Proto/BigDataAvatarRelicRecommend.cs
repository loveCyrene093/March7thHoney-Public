using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BigDataAvatarRelicRecommend : IMessage<BigDataAvatarRelicRecommend>, IMessage, IEquatable<BigDataAvatarRelicRecommend>, IDeepCloneable<BigDataAvatarRelicRecommend>, IBufferMessage
{
	private static readonly MessageParser<BigDataAvatarRelicRecommend> _parser = new MessageParser<BigDataAvatarRelicRecommend>(() => new BigDataAvatarRelicRecommend());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int OuterSetListFieldNumber = 2;

	private static readonly FieldCodec<FNBJPMGMJDP> _repeated_outerSetList_codec = FieldCodec.ForMessage(18u, FNBJPMGMJDP.Parser);

	private readonly RepeatedField<FNBJPMGMJDP> outerSetList_ = new RepeatedField<FNBJPMGMJDP>();

	public const int SphereMainPropertyListFieldNumber = 4;

	private static readonly FieldCodec<BKODLDOFMMJ> _repeated_sphereMainPropertyList_codec = FieldCodec.ForMessage(34u, BKODLDOFMMJ.Parser);

	private readonly RepeatedField<BKODLDOFMMJ> sphereMainPropertyList_ = new RepeatedField<BKODLDOFMMJ>();

	public const int RopeMainPropertyListFieldNumber = 7;

	private static readonly FieldCodec<BKODLDOFMMJ> _repeated_ropeMainPropertyList_codec = FieldCodec.ForMessage(58u, BKODLDOFMMJ.Parser);

	private readonly RepeatedField<BKODLDOFMMJ> ropeMainPropertyList_ = new RepeatedField<BKODLDOFMMJ>();

	public const int InnerSetListFieldNumber = 9;

	private static readonly FieldCodec<FNBJPMGMJDP> _repeated_innerSetList_codec = FieldCodec.ForMessage(74u, FNBJPMGMJDP.Parser);

	private readonly RepeatedField<FNBJPMGMJDP> innerSetList_ = new RepeatedField<FNBJPMGMJDP>();

	public const int FootMainPropertyListFieldNumber = 13;

	private static readonly FieldCodec<BKODLDOFMMJ> _repeated_footMainPropertyList_codec = FieldCodec.ForMessage(106u, BKODLDOFMMJ.Parser);

	private readonly RepeatedField<BKODLDOFMMJ> footMainPropertyList_ = new RepeatedField<BKODLDOFMMJ>();

	public const int BodyMainPropertyListFieldNumber = 15;

	private static readonly FieldCodec<BKODLDOFMMJ> _repeated_bodyMainPropertyList_codec = FieldCodec.ForMessage(122u, BKODLDOFMMJ.Parser);

	private readonly RepeatedField<BKODLDOFMMJ> bodyMainPropertyList_ = new RepeatedField<BKODLDOFMMJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BigDataAvatarRelicRecommend> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BigDataAvatarRelicRecommendReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<FNBJPMGMJDP> OuterSetList => outerSetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BKODLDOFMMJ> SphereMainPropertyList => sphereMainPropertyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BKODLDOFMMJ> RopeMainPropertyList => ropeMainPropertyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FNBJPMGMJDP> InnerSetList => innerSetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BKODLDOFMMJ> FootMainPropertyList => footMainPropertyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BKODLDOFMMJ> BodyMainPropertyList => bodyMainPropertyList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataAvatarRelicRecommend()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataAvatarRelicRecommend(BigDataAvatarRelicRecommend other)
		: this()
	{
		avatarId_ = other.avatarId_;
		outerSetList_ = other.outerSetList_.Clone();
		sphereMainPropertyList_ = other.sphereMainPropertyList_.Clone();
		ropeMainPropertyList_ = other.ropeMainPropertyList_.Clone();
		innerSetList_ = other.innerSetList_.Clone();
		footMainPropertyList_ = other.footMainPropertyList_.Clone();
		bodyMainPropertyList_ = other.bodyMainPropertyList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataAvatarRelicRecommend Clone()
	{
		return new BigDataAvatarRelicRecommend(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BigDataAvatarRelicRecommend);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BigDataAvatarRelicRecommend other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!outerSetList_.Equals(other.outerSetList_))
		{
			return false;
		}
		if (!sphereMainPropertyList_.Equals(other.sphereMainPropertyList_))
		{
			return false;
		}
		if (!ropeMainPropertyList_.Equals(other.ropeMainPropertyList_))
		{
			return false;
		}
		if (!innerSetList_.Equals(other.innerSetList_))
		{
			return false;
		}
		if (!footMainPropertyList_.Equals(other.footMainPropertyList_))
		{
			return false;
		}
		if (!bodyMainPropertyList_.Equals(other.bodyMainPropertyList_))
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= outerSetList_.GetHashCode();
		num ^= sphereMainPropertyList_.GetHashCode();
		num ^= ropeMainPropertyList_.GetHashCode();
		num ^= innerSetList_.GetHashCode();
		num ^= footMainPropertyList_.GetHashCode();
		num ^= bodyMainPropertyList_.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		outerSetList_.WriteTo(ref output, _repeated_outerSetList_codec);
		sphereMainPropertyList_.WriteTo(ref output, _repeated_sphereMainPropertyList_codec);
		ropeMainPropertyList_.WriteTo(ref output, _repeated_ropeMainPropertyList_codec);
		innerSetList_.WriteTo(ref output, _repeated_innerSetList_codec);
		footMainPropertyList_.WriteTo(ref output, _repeated_footMainPropertyList_codec);
		bodyMainPropertyList_.WriteTo(ref output, _repeated_bodyMainPropertyList_codec);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += outerSetList_.CalculateSize(_repeated_outerSetList_codec);
		num += sphereMainPropertyList_.CalculateSize(_repeated_sphereMainPropertyList_codec);
		num += ropeMainPropertyList_.CalculateSize(_repeated_ropeMainPropertyList_codec);
		num += innerSetList_.CalculateSize(_repeated_innerSetList_codec);
		num += footMainPropertyList_.CalculateSize(_repeated_footMainPropertyList_codec);
		num += bodyMainPropertyList_.CalculateSize(_repeated_bodyMainPropertyList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BigDataAvatarRelicRecommend other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			outerSetList_.Add(other.outerSetList_);
			sphereMainPropertyList_.Add(other.sphereMainPropertyList_);
			ropeMainPropertyList_.Add(other.ropeMainPropertyList_);
			innerSetList_.Add(other.innerSetList_);
			footMainPropertyList_.Add(other.footMainPropertyList_);
			bodyMainPropertyList_.Add(other.bodyMainPropertyList_);
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
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 18u:
				outerSetList_.AddEntriesFrom(ref input, _repeated_outerSetList_codec);
				break;
			case 34u:
				sphereMainPropertyList_.AddEntriesFrom(ref input, _repeated_sphereMainPropertyList_codec);
				break;
			case 58u:
				ropeMainPropertyList_.AddEntriesFrom(ref input, _repeated_ropeMainPropertyList_codec);
				break;
			case 74u:
				innerSetList_.AddEntriesFrom(ref input, _repeated_innerSetList_codec);
				break;
			case 106u:
				footMainPropertyList_.AddEntriesFrom(ref input, _repeated_footMainPropertyList_codec);
				break;
			case 122u:
				bodyMainPropertyList_.AddEntriesFrom(ref input, _repeated_bodyMainPropertyList_codec);
				break;
			}
		}
	}
}
