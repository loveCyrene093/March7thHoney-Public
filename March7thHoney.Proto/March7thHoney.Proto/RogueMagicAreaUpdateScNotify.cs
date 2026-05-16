using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicAreaUpdateScNotify : IMessage<RogueMagicAreaUpdateScNotify>, IMessage, IEquatable<RogueMagicAreaUpdateScNotify>, IDeepCloneable<RogueMagicAreaUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicAreaUpdateScNotify> _parser = new MessageParser<RogueMagicAreaUpdateScNotify>(() => new RogueMagicAreaUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BFHJHAKFBIGFieldNumber = 5;

	private static readonly FieldCodec<MAGHEFEELAB> _repeated_bFHJHAKFBIG_codec = FieldCodec.ForMessage(42u, MAGHEFEELAB.Parser);

	private readonly RepeatedField<MAGHEFEELAB> bFHJHAKFBIG_ = new RepeatedField<MAGHEFEELAB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicAreaUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicAreaUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MAGHEFEELAB> BFHJHAKFBIG => bFHJHAKFBIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicAreaUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicAreaUpdateScNotify(RogueMagicAreaUpdateScNotify other)
		: this()
	{
		bFHJHAKFBIG_ = other.bFHJHAKFBIG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicAreaUpdateScNotify Clone()
	{
		return new RogueMagicAreaUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicAreaUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicAreaUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bFHJHAKFBIG_.Equals(other.bFHJHAKFBIG_))
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
		num ^= bFHJHAKFBIG_.GetHashCode();
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
		bFHJHAKFBIG_.WriteTo(ref output, _repeated_bFHJHAKFBIG_codec);
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
		num += bFHJHAKFBIG_.CalculateSize(_repeated_bFHJHAKFBIG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicAreaUpdateScNotify other)
	{
		if (other != null)
		{
			bFHJHAKFBIG_.Add(other.bFHJHAKFBIG_);
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
				bFHJHAKFBIG_.AddEntriesFrom(ref input, _repeated_bFHJHAKFBIG_codec);
			}
		}
	}
}
