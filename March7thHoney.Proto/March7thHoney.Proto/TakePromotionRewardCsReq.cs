using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakePromotionRewardCsReq : IMessage<TakePromotionRewardCsReq>, IMessage, IEquatable<TakePromotionRewardCsReq>, IDeepCloneable<TakePromotionRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakePromotionRewardCsReq> _parser = new MessageParser<TakePromotionRewardCsReq>(() => new TakePromotionRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BaseAvatarIdFieldNumber = 8;

	private uint baseAvatarId_;

	public const int PromotionFieldNumber = 10;

	private uint promotion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakePromotionRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakePromotionRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BaseAvatarId
	{
		get
		{
			return baseAvatarId_;
		}
		set
		{
			baseAvatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakePromotionRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakePromotionRewardCsReq(TakePromotionRewardCsReq other)
		: this()
	{
		baseAvatarId_ = other.baseAvatarId_;
		promotion_ = other.promotion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakePromotionRewardCsReq Clone()
	{
		return new TakePromotionRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakePromotionRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakePromotionRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BaseAvatarId != other.BaseAvatarId)
		{
			return false;
		}
		if (Promotion != other.Promotion)
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
		if (BaseAvatarId != 0)
		{
			num ^= BaseAvatarId.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
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
		if (BaseAvatarId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BaseAvatarId);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Promotion);
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
		if (BaseAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakePromotionRewardCsReq other)
	{
		if (other != null)
		{
			if (other.BaseAvatarId != 0)
			{
				BaseAvatarId = other.BaseAvatarId;
			}
			if (other.Promotion != 0)
			{
				Promotion = other.Promotion;
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
			case 64u:
				BaseAvatarId = input.ReadUInt32();
				break;
			case 80u:
				Promotion = input.ReadUInt32();
				break;
			}
		}
	}
}
