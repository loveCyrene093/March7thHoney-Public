using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetGrowthTargetAvatarCsReq : IMessage<SetGrowthTargetAvatarCsReq>, IMessage, IEquatable<SetGrowthTargetAvatarCsReq>, IDeepCloneable<SetGrowthTargetAvatarCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetGrowthTargetAvatarCsReq> _parser = new MessageParser<SetGrowthTargetAvatarCsReq>(() => new SetGrowthTargetAvatarCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KNCJPJFMPAJFieldNumber = 1;

	private uint kNCJPJFMPAJ_;

	public const int DHAIJLJCJAFFieldNumber = 4;

	private static readonly FieldCodec<GrowthTartgetFuncType> _repeated_dHAIJLJCJAF_codec = FieldCodec.ForEnum(34u, (GrowthTartgetFuncType x) => (int)x, (int x) => (GrowthTartgetFuncType)x);

	private readonly RepeatedField<GrowthTartgetFuncType> dHAIJLJCJAF_ = new RepeatedField<GrowthTartgetFuncType>();

	public const int AvatarIdFieldNumber = 9;

	private uint avatarId_;

	public const int SourceFieldNumber = 14;

	private GrowthTargetState source_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetGrowthTargetAvatarCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetGrowthTargetAvatarCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KNCJPJFMPAJ
	{
		get
		{
			return kNCJPJFMPAJ_;
		}
		set
		{
			kNCJPJFMPAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GrowthTartgetFuncType> DHAIJLJCJAF => dHAIJLJCJAF_;

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
	public GrowthTargetState Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGrowthTargetAvatarCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGrowthTargetAvatarCsReq(SetGrowthTargetAvatarCsReq other)
		: this()
	{
		kNCJPJFMPAJ_ = other.kNCJPJFMPAJ_;
		dHAIJLJCJAF_ = other.dHAIJLJCJAF_.Clone();
		avatarId_ = other.avatarId_;
		source_ = other.source_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGrowthTargetAvatarCsReq Clone()
	{
		return new SetGrowthTargetAvatarCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetGrowthTargetAvatarCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetGrowthTargetAvatarCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KNCJPJFMPAJ != other.KNCJPJFMPAJ)
		{
			return false;
		}
		if (!dHAIJLJCJAF_.Equals(other.dHAIJLJCJAF_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Source != other.Source)
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
		if (KNCJPJFMPAJ != 0)
		{
			num ^= KNCJPJFMPAJ.GetHashCode();
		}
		num ^= dHAIJLJCJAF_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Source != GrowthTargetState.HdjkgmlafnpAabjfikbhjk)
		{
			num ^= Source.GetHashCode();
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
		if (KNCJPJFMPAJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KNCJPJFMPAJ);
		}
		dHAIJLJCJAF_.WriteTo(ref output, _repeated_dHAIJLJCJAF_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AvatarId);
		}
		if (Source != GrowthTargetState.HdjkgmlafnpAabjfikbhjk)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)Source);
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
		if (KNCJPJFMPAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KNCJPJFMPAJ);
		}
		num += dHAIJLJCJAF_.CalculateSize(_repeated_dHAIJLJCJAF_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Source != GrowthTargetState.HdjkgmlafnpAabjfikbhjk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetGrowthTargetAvatarCsReq other)
	{
		if (other != null)
		{
			if (other.KNCJPJFMPAJ != 0)
			{
				KNCJPJFMPAJ = other.KNCJPJFMPAJ;
			}
			dHAIJLJCJAF_.Add(other.dHAIJLJCJAF_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Source != GrowthTargetState.HdjkgmlafnpAabjfikbhjk)
			{
				Source = other.Source;
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
			case 8u:
				KNCJPJFMPAJ = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				dHAIJLJCJAF_.AddEntriesFrom(ref input, _repeated_dHAIJLJCJAF_codec);
				break;
			case 72u:
				AvatarId = input.ReadUInt32();
				break;
			case 112u:
				Source = (GrowthTargetState)input.ReadEnum();
				break;
			}
		}
	}
}
