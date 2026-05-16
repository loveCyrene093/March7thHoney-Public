using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AiPamMotionScNotify : IMessage<AiPamMotionScNotify>, IMessage, IEquatable<AiPamMotionScNotify>, IDeepCloneable<AiPamMotionScNotify>, IBufferMessage
{
	private static readonly MessageParser<AiPamMotionScNotify> _parser = new MessageParser<AiPamMotionScNotify>(() => new AiPamMotionScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BDJACHGHCHFFieldNumber = 6;

	private static readonly FieldCodec<string> _repeated_bDJACHGHCHF_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> bDJACHGHCHF_ = new RepeatedField<string>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AiPamMotionScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AiPamMotionScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> BDJACHGHCHF => bDJACHGHCHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamMotionScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamMotionScNotify(AiPamMotionScNotify other)
		: this()
	{
		bDJACHGHCHF_ = other.bDJACHGHCHF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamMotionScNotify Clone()
	{
		return new AiPamMotionScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AiPamMotionScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AiPamMotionScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bDJACHGHCHF_.Equals(other.bDJACHGHCHF_))
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
		num ^= bDJACHGHCHF_.GetHashCode();
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
		bDJACHGHCHF_.WriteTo(ref output, _repeated_bDJACHGHCHF_codec);
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
		num += bDJACHGHCHF_.CalculateSize(_repeated_bDJACHGHCHF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AiPamMotionScNotify other)
	{
		if (other != null)
		{
			bDJACHGHCHF_.Add(other.bDJACHGHCHF_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bDJACHGHCHF_.AddEntriesFrom(ref input, _repeated_bDJACHGHCHF_codec);
			}
		}
	}
}
