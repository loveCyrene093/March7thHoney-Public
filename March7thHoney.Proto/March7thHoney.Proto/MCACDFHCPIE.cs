using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MCACDFHCPIE : IMessage<MCACDFHCPIE>, IMessage, IEquatable<MCACDFHCPIE>, IDeepCloneable<MCACDFHCPIE>, IBufferMessage
{
	private static readonly MessageParser<MCACDFHCPIE> _parser = new MessageParser<MCACDFHCPIE>(() => new MCACDFHCPIE());

	private UnknownFieldSet _unknownFields;

	public const int HAHKKEDKMCAFieldNumber = 2;

	private static readonly FieldCodec<LMIFJBLJFHP> _repeated_hAHKKEDKMCA_codec = FieldCodec.ForMessage(18u, LMIFJBLJFHP.Parser);

	private readonly RepeatedField<LMIFJBLJFHP> hAHKKEDKMCA_ = new RepeatedField<LMIFJBLJFHP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MCACDFHCPIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MCACDFHCPIEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LMIFJBLJFHP> HAHKKEDKMCA => hAHKKEDKMCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE(MCACDFHCPIE other)
		: this()
	{
		hAHKKEDKMCA_ = other.hAHKKEDKMCA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE Clone()
	{
		return new MCACDFHCPIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MCACDFHCPIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MCACDFHCPIE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hAHKKEDKMCA_.Equals(other.hAHKKEDKMCA_))
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
		num ^= hAHKKEDKMCA_.GetHashCode();
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
		hAHKKEDKMCA_.WriteTo(ref output, _repeated_hAHKKEDKMCA_codec);
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
		num += hAHKKEDKMCA_.CalculateSize(_repeated_hAHKKEDKMCA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MCACDFHCPIE other)
	{
		if (other != null)
		{
			hAHKKEDKMCA_.Add(other.hAHKKEDKMCA_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hAHKKEDKMCA_.AddEntriesFrom(ref input, _repeated_hAHKKEDKMCA_codec);
			}
		}
	}
}
