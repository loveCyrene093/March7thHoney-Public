using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ODEGFOPOKAD : IMessage<ODEGFOPOKAD>, IMessage, IEquatable<ODEGFOPOKAD>, IDeepCloneable<ODEGFOPOKAD>, IBufferMessage
{
	private static readonly MessageParser<ODEGFOPOKAD> _parser = new MessageParser<ODEGFOPOKAD>(() => new ODEGFOPOKAD());

	private UnknownFieldSet _unknownFields;

	public const int GALNEOLMCPOFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gALNEOLMCPO_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gALNEOLMCPO_ = new RepeatedField<uint>();

	public const int LNDNPGACBJHFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_lNDNPGACBJH_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> lNDNPGACBJH_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ODEGFOPOKAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ODEGFOPOKADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GALNEOLMCPO => gALNEOLMCPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LNDNPGACBJH => lNDNPGACBJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODEGFOPOKAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODEGFOPOKAD(ODEGFOPOKAD other)
		: this()
	{
		gALNEOLMCPO_ = other.gALNEOLMCPO_.Clone();
		lNDNPGACBJH_ = other.lNDNPGACBJH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODEGFOPOKAD Clone()
	{
		return new ODEGFOPOKAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ODEGFOPOKAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ODEGFOPOKAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gALNEOLMCPO_.Equals(other.gALNEOLMCPO_))
		{
			return false;
		}
		if (!lNDNPGACBJH_.Equals(other.lNDNPGACBJH_))
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
		num ^= gALNEOLMCPO_.GetHashCode();
		num ^= lNDNPGACBJH_.GetHashCode();
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
		gALNEOLMCPO_.WriteTo(ref output, _repeated_gALNEOLMCPO_codec);
		lNDNPGACBJH_.WriteTo(ref output, _repeated_lNDNPGACBJH_codec);
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
		num += gALNEOLMCPO_.CalculateSize(_repeated_gALNEOLMCPO_codec);
		num += lNDNPGACBJH_.CalculateSize(_repeated_lNDNPGACBJH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ODEGFOPOKAD other)
	{
		if (other != null)
		{
			gALNEOLMCPO_.Add(other.gALNEOLMCPO_);
			lNDNPGACBJH_.Add(other.lNDNPGACBJH_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				gALNEOLMCPO_.AddEntriesFrom(ref input, _repeated_gALNEOLMCPO_codec);
				break;
			case 32u:
			case 34u:
				lNDNPGACBJH_.AddEntriesFrom(ref input, _repeated_lNDNPGACBJH_codec);
				break;
			}
		}
	}
}
