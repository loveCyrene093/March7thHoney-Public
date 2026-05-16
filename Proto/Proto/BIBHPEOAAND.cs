using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BIBHPEOAAND : IMessage<BIBHPEOAAND>, IMessage, IEquatable<BIBHPEOAAND>, IDeepCloneable<BIBHPEOAAND>, IBufferMessage
{
	private static readonly MessageParser<BIBHPEOAAND> _parser = new MessageParser<BIBHPEOAAND>(() => new BIBHPEOAAND());

	private UnknownFieldSet _unknownFields;

	public const int ODMGIDMJHOLFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_oDMGIDMJHOL_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> oDMGIDMJHOL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BIBHPEOAAND> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BIBHPEOAANDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ODMGIDMJHOL => oDMGIDMJHOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBHPEOAAND()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBHPEOAAND(BIBHPEOAAND other)
		: this()
	{
		oDMGIDMJHOL_ = other.oDMGIDMJHOL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBHPEOAAND Clone()
	{
		return new BIBHPEOAAND(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BIBHPEOAAND);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BIBHPEOAAND other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oDMGIDMJHOL_.Equals(other.oDMGIDMJHOL_))
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
		num ^= oDMGIDMJHOL_.GetHashCode();
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
		oDMGIDMJHOL_.WriteTo(ref output, _repeated_oDMGIDMJHOL_codec);
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
		num += oDMGIDMJHOL_.CalculateSize(_repeated_oDMGIDMJHOL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BIBHPEOAAND other)
	{
		if (other != null)
		{
			oDMGIDMJHOL_.Add(other.oDMGIDMJHOL_);
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
			if (num != 56 && num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				oDMGIDMJHOL_.AddEntriesFrom(ref input, _repeated_oDMGIDMJHOL_codec);
			}
		}
	}
}
