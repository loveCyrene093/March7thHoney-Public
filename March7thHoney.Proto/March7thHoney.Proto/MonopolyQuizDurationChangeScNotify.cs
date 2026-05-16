using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyQuizDurationChangeScNotify : IMessage<MonopolyQuizDurationChangeScNotify>, IMessage, IEquatable<MonopolyQuizDurationChangeScNotify>, IDeepCloneable<MonopolyQuizDurationChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyQuizDurationChangeScNotify> _parser = new MessageParser<MonopolyQuizDurationChangeScNotify>(() => new MonopolyQuizDurationChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CJFBLHNPHAKFieldNumber = 5;

	private static readonly FieldCodec<CIFMOICFJDF> _repeated_cJFBLHNPHAK_codec = FieldCodec.ForMessage(42u, CIFMOICFJDF.Parser);

	private readonly RepeatedField<CIFMOICFJDF> cJFBLHNPHAK_ = new RepeatedField<CIFMOICFJDF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyQuizDurationChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyQuizDurationChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CIFMOICFJDF> CJFBLHNPHAK => cJFBLHNPHAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyQuizDurationChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyQuizDurationChangeScNotify(MonopolyQuizDurationChangeScNotify other)
		: this()
	{
		cJFBLHNPHAK_ = other.cJFBLHNPHAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyQuizDurationChangeScNotify Clone()
	{
		return new MonopolyQuizDurationChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyQuizDurationChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyQuizDurationChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cJFBLHNPHAK_.Equals(other.cJFBLHNPHAK_))
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
		num ^= cJFBLHNPHAK_.GetHashCode();
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
		cJFBLHNPHAK_.WriteTo(ref output, _repeated_cJFBLHNPHAK_codec);
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
		num += cJFBLHNPHAK_.CalculateSize(_repeated_cJFBLHNPHAK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyQuizDurationChangeScNotify other)
	{
		if (other != null)
		{
			cJFBLHNPHAK_.Add(other.cJFBLHNPHAK_);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cJFBLHNPHAK_.AddEntriesFrom(ref input, _repeated_cJFBLHNPHAK_codec);
			}
		}
	}
}
