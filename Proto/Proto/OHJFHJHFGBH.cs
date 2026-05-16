using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OHJFHJHFGBH : IMessage<OHJFHJHFGBH>, IMessage, IEquatable<OHJFHJHFGBH>, IDeepCloneable<OHJFHJHFGBH>, IBufferMessage
{
	private static readonly MessageParser<OHJFHJHFGBH> _parser = new MessageParser<OHJFHJHFGBH>(() => new OHJFHJHFGBH());

	private UnknownFieldSet _unknownFields;

	public const int GGJFJOFNJPAFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gGJFJOFNJPA_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gGJFJOFNJPA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OHJFHJHFGBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OHJFHJHFGBHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GGJFJOFNJPA => gGJFJOFNJPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHJFHJHFGBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHJFHJHFGBH(OHJFHJHFGBH other)
		: this()
	{
		gGJFJOFNJPA_ = other.gGJFJOFNJPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHJFHJHFGBH Clone()
	{
		return new OHJFHJHFGBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OHJFHJHFGBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OHJFHJHFGBH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gGJFJOFNJPA_.Equals(other.gGJFJOFNJPA_))
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
		num ^= gGJFJOFNJPA_.GetHashCode();
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
		gGJFJOFNJPA_.WriteTo(ref output, _repeated_gGJFJOFNJPA_codec);
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
		num += gGJFJOFNJPA_.CalculateSize(_repeated_gGJFJOFNJPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OHJFHJHFGBH other)
	{
		if (other != null)
		{
			gGJFJOFNJPA_.Add(other.gGJFJOFNJPA_);
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
			if (num != 16 && num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gGJFJOFNJPA_.AddEntriesFrom(ref input, _repeated_gGJFJOFNJPA_codec);
			}
		}
	}
}
