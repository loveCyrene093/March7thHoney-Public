using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IPNPJJPPCCC : IMessage<IPNPJJPPCCC>, IMessage, IEquatable<IPNPJJPPCCC>, IDeepCloneable<IPNPJJPPCCC>, IBufferMessage
{
	private static readonly MessageParser<IPNPJJPPCCC> _parser = new MessageParser<IPNPJJPPCCC>(() => new IPNPJJPPCCC());

	private UnknownFieldSet _unknownFields;

	public const int PHGLFHDDACMFieldNumber = 4;

	private static readonly FieldCodec<GHLDMADOHHF> _repeated_pHGLFHDDACM_codec = FieldCodec.ForMessage(34u, GHLDMADOHHF.Parser);

	private readonly RepeatedField<GHLDMADOHHF> pHGLFHDDACM_ = new RepeatedField<GHLDMADOHHF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IPNPJJPPCCC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IPNPJJPPCCCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GHLDMADOHHF> PHGLFHDDACM => pHGLFHDDACM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPNPJJPPCCC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPNPJJPPCCC(IPNPJJPPCCC other)
		: this()
	{
		pHGLFHDDACM_ = other.pHGLFHDDACM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPNPJJPPCCC Clone()
	{
		return new IPNPJJPPCCC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IPNPJJPPCCC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IPNPJJPPCCC other)
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
	public void MergeFrom(IPNPJJPPCCC other)
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
			if (num != 34)
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
