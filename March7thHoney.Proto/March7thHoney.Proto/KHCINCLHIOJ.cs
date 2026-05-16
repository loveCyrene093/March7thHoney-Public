using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KHCINCLHIOJ : IMessage<KHCINCLHIOJ>, IMessage, IEquatable<KHCINCLHIOJ>, IDeepCloneable<KHCINCLHIOJ>, IBufferMessage
{
	private static readonly MessageParser<KHCINCLHIOJ> _parser = new MessageParser<KHCINCLHIOJ>(() => new KHCINCLHIOJ());

	private UnknownFieldSet _unknownFields;

	public const int LGLPAPAPKHMFieldNumber = 1;

	private static readonly FieldCodec<JAOHPOPIAFH> _repeated_lGLPAPAPKHM_codec = FieldCodec.ForMessage(10u, JAOHPOPIAFH.Parser);

	private readonly RepeatedField<JAOHPOPIAFH> lGLPAPAPKHM_ = new RepeatedField<JAOHPOPIAFH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KHCINCLHIOJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KHCINCLHIOJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAOHPOPIAFH> LGLPAPAPKHM => lGLPAPAPKHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCINCLHIOJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCINCLHIOJ(KHCINCLHIOJ other)
		: this()
	{
		lGLPAPAPKHM_ = other.lGLPAPAPKHM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHCINCLHIOJ Clone()
	{
		return new KHCINCLHIOJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KHCINCLHIOJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KHCINCLHIOJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lGLPAPAPKHM_.Equals(other.lGLPAPAPKHM_))
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
		num ^= lGLPAPAPKHM_.GetHashCode();
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
		lGLPAPAPKHM_.WriteTo(ref output, _repeated_lGLPAPAPKHM_codec);
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
		num += lGLPAPAPKHM_.CalculateSize(_repeated_lGLPAPAPKHM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KHCINCLHIOJ other)
	{
		if (other != null)
		{
			lGLPAPAPKHM_.Add(other.lGLPAPAPKHM_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lGLPAPAPKHM_.AddEntriesFrom(ref input, _repeated_lGLPAPAPKHM_codec);
			}
		}
	}
}
