using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FJPONJFLOOH : IMessage<FJPONJFLOOH>, IMessage, IEquatable<FJPONJFLOOH>, IDeepCloneable<FJPONJFLOOH>, IBufferMessage
{
	private static readonly MessageParser<FJPONJFLOOH> _parser = new MessageParser<FJPONJFLOOH>(() => new FJPONJFLOOH());

	private UnknownFieldSet _unknownFields;

	public const int EDJPMNLLGGBFieldNumber = 11;

	private static readonly FieldCodec<MJJEHCBNOKI> _repeated_eDJPMNLLGGB_codec = FieldCodec.ForMessage(90u, MJJEHCBNOKI.Parser);

	private readonly RepeatedField<MJJEHCBNOKI> eDJPMNLLGGB_ = new RepeatedField<MJJEHCBNOKI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FJPONJFLOOH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FJPONJFLOOHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MJJEHCBNOKI> EDJPMNLLGGB => eDJPMNLLGGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJPONJFLOOH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJPONJFLOOH(FJPONJFLOOH other)
		: this()
	{
		eDJPMNLLGGB_ = other.eDJPMNLLGGB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJPONJFLOOH Clone()
	{
		return new FJPONJFLOOH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FJPONJFLOOH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FJPONJFLOOH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eDJPMNLLGGB_.Equals(other.eDJPMNLLGGB_))
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
		num ^= eDJPMNLLGGB_.GetHashCode();
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
		eDJPMNLLGGB_.WriteTo(ref output, _repeated_eDJPMNLLGGB_codec);
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
		num += eDJPMNLLGGB_.CalculateSize(_repeated_eDJPMNLLGGB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FJPONJFLOOH other)
	{
		if (other != null)
		{
			eDJPMNLLGGB_.Add(other.eDJPMNLLGGB_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				eDJPMNLLGGB_.AddEntriesFrom(ref input, _repeated_eDJPMNLLGGB_codec);
			}
		}
	}
}
