using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MALLAGHCFFL : IMessage<MALLAGHCFFL>, IMessage, IEquatable<MALLAGHCFFL>, IDeepCloneable<MALLAGHCFFL>, IBufferMessage
{
	private static readonly MessageParser<MALLAGHCFFL> _parser = new MessageParser<MALLAGHCFFL>(() => new MALLAGHCFFL());

	private UnknownFieldSet _unknownFields;

	public const int LECFKGLEKCJFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_lECFKGLEKCJ_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> lECFKGLEKCJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MALLAGHCFFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MALLAGHCFFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LECFKGLEKCJ => lECFKGLEKCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MALLAGHCFFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MALLAGHCFFL(MALLAGHCFFL other)
		: this()
	{
		lECFKGLEKCJ_ = other.lECFKGLEKCJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MALLAGHCFFL Clone()
	{
		return new MALLAGHCFFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MALLAGHCFFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MALLAGHCFFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lECFKGLEKCJ_.Equals(other.lECFKGLEKCJ_))
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
		num ^= lECFKGLEKCJ_.GetHashCode();
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
		lECFKGLEKCJ_.WriteTo(ref output, _repeated_lECFKGLEKCJ_codec);
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
		num += lECFKGLEKCJ_.CalculateSize(_repeated_lECFKGLEKCJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MALLAGHCFFL other)
	{
		if (other != null)
		{
			lECFKGLEKCJ_.Add(other.lECFKGLEKCJ_);
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
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lECFKGLEKCJ_.AddEntriesFrom(ref input, _repeated_lECFKGLEKCJ_codec);
			}
		}
	}
}
