using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGIDNOCFEOH : IMessage<CGIDNOCFEOH>, IMessage, IEquatable<CGIDNOCFEOH>, IDeepCloneable<CGIDNOCFEOH>, IBufferMessage
{
	private static readonly MessageParser<CGIDNOCFEOH> _parser = new MessageParser<CGIDNOCFEOH>(() => new CGIDNOCFEOH());

	private UnknownFieldSet _unknownFields;

	public const int CIFOJDJAIADFieldNumber = 9;

	private static readonly FieldCodec<IHOGHILAEJE> _repeated_cIFOJDJAIAD_codec = FieldCodec.ForMessage(74u, IHOGHILAEJE.Parser);

	private readonly RepeatedField<IHOGHILAEJE> cIFOJDJAIAD_ = new RepeatedField<IHOGHILAEJE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGIDNOCFEOH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGIDNOCFEOHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IHOGHILAEJE> CIFOJDJAIAD => cIFOJDJAIAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGIDNOCFEOH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGIDNOCFEOH(CGIDNOCFEOH other)
		: this()
	{
		cIFOJDJAIAD_ = other.cIFOJDJAIAD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGIDNOCFEOH Clone()
	{
		return new CGIDNOCFEOH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGIDNOCFEOH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGIDNOCFEOH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cIFOJDJAIAD_.Equals(other.cIFOJDJAIAD_))
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
		num ^= cIFOJDJAIAD_.GetHashCode();
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
		cIFOJDJAIAD_.WriteTo(ref output, _repeated_cIFOJDJAIAD_codec);
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
		num += cIFOJDJAIAD_.CalculateSize(_repeated_cIFOJDJAIAD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGIDNOCFEOH other)
	{
		if (other != null)
		{
			cIFOJDJAIAD_.Add(other.cIFOJDJAIAD_);
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
				cIFOJDJAIAD_.AddEntriesFrom(ref input, _repeated_cIFOJDJAIAD_codec);
			}
		}
	}
}
