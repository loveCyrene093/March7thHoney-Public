using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusSnsUpdateScNotify : IMessage<HeliobusSnsUpdateScNotify>, IMessage, IEquatable<HeliobusSnsUpdateScNotify>, IDeepCloneable<HeliobusSnsUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<HeliobusSnsUpdateScNotify> _parser = new MessageParser<HeliobusSnsUpdateScNotify>(() => new HeliobusSnsUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HPKHBLEJBIJFieldNumber = 5;

	private static readonly FieldCodec<DLFOGJGCCGP> _repeated_hPKHBLEJBIJ_codec = FieldCodec.ForMessage(42u, DLFOGJGCCGP.Parser);

	private readonly RepeatedField<DLFOGJGCCGP> hPKHBLEJBIJ_ = new RepeatedField<DLFOGJGCCGP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusSnsUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusSnsUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DLFOGJGCCGP> HPKHBLEJBIJ => hPKHBLEJBIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsUpdateScNotify(HeliobusSnsUpdateScNotify other)
		: this()
	{
		hPKHBLEJBIJ_ = other.hPKHBLEJBIJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsUpdateScNotify Clone()
	{
		return new HeliobusSnsUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusSnsUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusSnsUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hPKHBLEJBIJ_.Equals(other.hPKHBLEJBIJ_))
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
		num ^= hPKHBLEJBIJ_.GetHashCode();
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
		hPKHBLEJBIJ_.WriteTo(ref output, _repeated_hPKHBLEJBIJ_codec);
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
		num += hPKHBLEJBIJ_.CalculateSize(_repeated_hPKHBLEJBIJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusSnsUpdateScNotify other)
	{
		if (other != null)
		{
			hPKHBLEJBIJ_.Add(other.hPKHBLEJBIJ_);
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
				hPKHBLEJBIJ_.AddEntriesFrom(ref input, _repeated_hPKHBLEJBIJ_codec);
			}
		}
	}
}
