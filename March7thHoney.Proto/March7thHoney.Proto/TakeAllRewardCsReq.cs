using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeAllRewardCsReq : IMessage<TakeAllRewardCsReq>, IMessage, IEquatable<TakeAllRewardCsReq>, IDeepCloneable<TakeAllRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeAllRewardCsReq> _parser = new MessageParser<TakeAllRewardCsReq>(() => new TakeAllRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GGBKOFKEHNDFieldNumber = 9;

	private static readonly FieldCodec<OptionalReward> _repeated_gGBKOFKEHND_codec = FieldCodec.ForMessage(74u, OptionalReward.Parser);

	private readonly RepeatedField<OptionalReward> gGBKOFKEHND_ = new RepeatedField<OptionalReward>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeAllRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeAllRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OptionalReward> GGBKOFKEHND => gGBKOFKEHND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeAllRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeAllRewardCsReq(TakeAllRewardCsReq other)
		: this()
	{
		gGBKOFKEHND_ = other.gGBKOFKEHND_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeAllRewardCsReq Clone()
	{
		return new TakeAllRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeAllRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeAllRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gGBKOFKEHND_.Equals(other.gGBKOFKEHND_))
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
		num ^= gGBKOFKEHND_.GetHashCode();
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
		gGBKOFKEHND_.WriteTo(ref output, _repeated_gGBKOFKEHND_codec);
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
		num += gGBKOFKEHND_.CalculateSize(_repeated_gGBKOFKEHND_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeAllRewardCsReq other)
	{
		if (other != null)
		{
			gGBKOFKEHND_.Add(other.gGBKOFKEHND_);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gGBKOFKEHND_.AddEntriesFrom(ref input, _repeated_gGBKOFKEHND_codec);
			}
		}
	}
}
