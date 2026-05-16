using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CMCJNKPKBEM : IMessage<CMCJNKPKBEM>, IMessage, IEquatable<CMCJNKPKBEM>, IDeepCloneable<CMCJNKPKBEM>, IBufferMessage
{
	private static readonly MessageParser<CMCJNKPKBEM> _parser = new MessageParser<CMCJNKPKBEM>(() => new CMCJNKPKBEM());

	private UnknownFieldSet _unknownFields;

	public const int CFNPGNMPNDNFieldNumber = 15;

	private static readonly MapField<string, uint>.Codec _map_cFNPGNMPNDN_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 122u);

	private readonly MapField<string, uint> cFNPGNMPNDN_ = new MapField<string, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CMCJNKPKBEM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CMCJNKPKBEMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> CFNPGNMPNDN => cFNPGNMPNDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMCJNKPKBEM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMCJNKPKBEM(CMCJNKPKBEM other)
		: this()
	{
		cFNPGNMPNDN_ = other.cFNPGNMPNDN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMCJNKPKBEM Clone()
	{
		return new CMCJNKPKBEM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CMCJNKPKBEM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CMCJNKPKBEM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!CFNPGNMPNDN.Equals(other.CFNPGNMPNDN))
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
		num ^= CFNPGNMPNDN.GetHashCode();
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
		cFNPGNMPNDN_.WriteTo(ref output, _map_cFNPGNMPNDN_codec);
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
		num += cFNPGNMPNDN_.CalculateSize(_map_cFNPGNMPNDN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CMCJNKPKBEM other)
	{
		if (other != null)
		{
			cFNPGNMPNDN_.MergeFrom(other.cFNPGNMPNDN_);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cFNPGNMPNDN_.AddEntriesFrom(ref input, _map_cFNPGNMPNDN_codec);
			}
		}
	}
}
