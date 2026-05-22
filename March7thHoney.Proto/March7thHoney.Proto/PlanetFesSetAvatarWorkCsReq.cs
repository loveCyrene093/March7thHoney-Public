using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesSetAvatarWorkCsReq : IMessage<PlanetFesSetAvatarWorkCsReq>, IMessage, IEquatable<PlanetFesSetAvatarWorkCsReq>, IDeepCloneable<PlanetFesSetAvatarWorkCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesSetAvatarWorkCsReq> _parser = new MessageParser<PlanetFesSetAvatarWorkCsReq>(() => new PlanetFesSetAvatarWorkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CLKAILDCPJCFieldNumber = 5;

	private static readonly FieldCodec<JNHCBCKHCEM> _repeated_cLKAILDCPJC_codec = FieldCodec.ForMessage(42u, JNHCBCKHCEM.Parser);

	private readonly RepeatedField<JNHCBCKHCEM> cLKAILDCPJC_ = new RepeatedField<JNHCBCKHCEM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesSetAvatarWorkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesSetAvatarWorkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JNHCBCKHCEM> CLKAILDCPJC => cLKAILDCPJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesSetAvatarWorkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesSetAvatarWorkCsReq(PlanetFesSetAvatarWorkCsReq other)
		: this()
	{
		cLKAILDCPJC_ = other.cLKAILDCPJC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesSetAvatarWorkCsReq Clone()
	{
		return new PlanetFesSetAvatarWorkCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesSetAvatarWorkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesSetAvatarWorkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cLKAILDCPJC_.Equals(other.cLKAILDCPJC_))
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
		num ^= cLKAILDCPJC_.GetHashCode();
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
		cLKAILDCPJC_.WriteTo(ref output, _repeated_cLKAILDCPJC_codec);
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
		num += cLKAILDCPJC_.CalculateSize(_repeated_cLKAILDCPJC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesSetAvatarWorkCsReq other)
	{
		if (other != null)
		{
			cLKAILDCPJC_.Add(other.cLKAILDCPJC_);
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
				cLKAILDCPJC_.AddEntriesFrom(ref input, _repeated_cLKAILDCPJC_codec);
			}
		}
	}
}
