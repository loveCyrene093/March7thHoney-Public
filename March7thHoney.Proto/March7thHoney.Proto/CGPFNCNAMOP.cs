using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGPFNCNAMOP : IMessage<CGPFNCNAMOP>, IMessage, IEquatable<CGPFNCNAMOP>, IDeepCloneable<CGPFNCNAMOP>, IBufferMessage
{
	private static readonly MessageParser<CGPFNCNAMOP> _parser = new MessageParser<CGPFNCNAMOP>(() => new CGPFNCNAMOP());

	private UnknownFieldSet _unknownFields;

	public const int KGNBJLBLMPJFieldNumber = 5;

	private static readonly FieldCodec<HIDPJPNFCKO> _repeated_kGNBJLBLMPJ_codec = FieldCodec.ForMessage(42u, HIDPJPNFCKO.Parser);

	private readonly RepeatedField<HIDPJPNFCKO> kGNBJLBLMPJ_ = new RepeatedField<HIDPJPNFCKO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGPFNCNAMOP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGPFNCNAMOPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HIDPJPNFCKO> KGNBJLBLMPJ => kGNBJLBLMPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGPFNCNAMOP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGPFNCNAMOP(CGPFNCNAMOP other)
		: this()
	{
		kGNBJLBLMPJ_ = other.kGNBJLBLMPJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGPFNCNAMOP Clone()
	{
		return new CGPFNCNAMOP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGPFNCNAMOP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGPFNCNAMOP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kGNBJLBLMPJ_.Equals(other.kGNBJLBLMPJ_))
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
		num ^= kGNBJLBLMPJ_.GetHashCode();
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
		kGNBJLBLMPJ_.WriteTo(ref output, _repeated_kGNBJLBLMPJ_codec);
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
		num += kGNBJLBLMPJ_.CalculateSize(_repeated_kGNBJLBLMPJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGPFNCNAMOP other)
	{
		if (other != null)
		{
			kGNBJLBLMPJ_.Add(other.kGNBJLBLMPJ_);
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
				kGNBJLBLMPJ_.AddEntriesFrom(ref input, _repeated_kGNBJLBLMPJ_codec);
			}
		}
	}
}
