using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KLCICNHAOPF : IMessage<KLCICNHAOPF>, IMessage, IEquatable<KLCICNHAOPF>, IDeepCloneable<KLCICNHAOPF>, IBufferMessage
{
	private static readonly MessageParser<KLCICNHAOPF> _parser = new MessageParser<KLCICNHAOPF>(() => new KLCICNHAOPF());

	private UnknownFieldSet _unknownFields;

	public const int ELCPONIPEIHFieldNumber = 12;

	private static readonly FieldCodec<OLNPCLEFANN> _repeated_eLCPONIPEIH_codec = FieldCodec.ForMessage(98u, OLNPCLEFANN.Parser);

	private readonly RepeatedField<OLNPCLEFANN> eLCPONIPEIH_ = new RepeatedField<OLNPCLEFANN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KLCICNHAOPF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KLCICNHAOPFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLNPCLEFANN> ELCPONIPEIH => eLCPONIPEIH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLCICNHAOPF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLCICNHAOPF(KLCICNHAOPF other)
		: this()
	{
		eLCPONIPEIH_ = other.eLCPONIPEIH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLCICNHAOPF Clone()
	{
		return new KLCICNHAOPF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KLCICNHAOPF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KLCICNHAOPF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eLCPONIPEIH_.Equals(other.eLCPONIPEIH_))
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
		num ^= eLCPONIPEIH_.GetHashCode();
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
		eLCPONIPEIH_.WriteTo(ref output, _repeated_eLCPONIPEIH_codec);
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
		num += eLCPONIPEIH_.CalculateSize(_repeated_eLCPONIPEIH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KLCICNHAOPF other)
	{
		if (other != null)
		{
			eLCPONIPEIH_.Add(other.eLCPONIPEIH_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				eLCPONIPEIH_.AddEntriesFrom(ref input, _repeated_eLCPONIPEIH_codec);
			}
		}
	}
}
