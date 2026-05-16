using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ONAMJANOBOM : IMessage<ONAMJANOBOM>, IMessage, IEquatable<ONAMJANOBOM>, IDeepCloneable<ONAMJANOBOM>, IBufferMessage
{
	private static readonly MessageParser<ONAMJANOBOM> _parser = new MessageParser<ONAMJANOBOM>(() => new ONAMJANOBOM());

	private UnknownFieldSet _unknownFields;

	public const int PHGLFHDDACMFieldNumber = 1;

	private static readonly FieldCodec<JAFPMLLOGDI> _repeated_pHGLFHDDACM_codec = FieldCodec.ForMessage(10u, JAFPMLLOGDI.Parser);

	private readonly RepeatedField<JAFPMLLOGDI> pHGLFHDDACM_ = new RepeatedField<JAFPMLLOGDI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ONAMJANOBOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ONAMJANOBOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAFPMLLOGDI> PHGLFHDDACM => pHGLFHDDACM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONAMJANOBOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONAMJANOBOM(ONAMJANOBOM other)
		: this()
	{
		pHGLFHDDACM_ = other.pHGLFHDDACM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONAMJANOBOM Clone()
	{
		return new ONAMJANOBOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ONAMJANOBOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ONAMJANOBOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pHGLFHDDACM_.Equals(other.pHGLFHDDACM_))
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
		num ^= pHGLFHDDACM_.GetHashCode();
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
		pHGLFHDDACM_.WriteTo(ref output, _repeated_pHGLFHDDACM_codec);
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
		num += pHGLFHDDACM_.CalculateSize(_repeated_pHGLFHDDACM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ONAMJANOBOM other)
	{
		if (other != null)
		{
			pHGLFHDDACM_.Add(other.pHGLFHDDACM_);
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
				pHGLFHDDACM_.AddEntriesFrom(ref input, _repeated_pHGLFHDDACM_codec);
			}
		}
	}
}
