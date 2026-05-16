using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JBLDOIIILEC : IMessage<JBLDOIIILEC>, IMessage, IEquatable<JBLDOIIILEC>, IDeepCloneable<JBLDOIIILEC>, IBufferMessage
{
	private static readonly MessageParser<JBLDOIIILEC> _parser = new MessageParser<JBLDOIIILEC>(() => new JBLDOIIILEC());

	private UnknownFieldSet _unknownFields;

	public const int EBKDJHLFOGNFieldNumber = 4;

	private static readonly FieldCodec<EAODPIFMANC> _repeated_eBKDJHLFOGN_codec = FieldCodec.ForMessage(34u, EAODPIFMANC.Parser);

	private readonly RepeatedField<EAODPIFMANC> eBKDJHLFOGN_ = new RepeatedField<EAODPIFMANC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JBLDOIIILEC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JBLDOIIILECReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EAODPIFMANC> EBKDJHLFOGN => eBKDJHLFOGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBLDOIIILEC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBLDOIIILEC(JBLDOIIILEC other)
		: this()
	{
		eBKDJHLFOGN_ = other.eBKDJHLFOGN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBLDOIIILEC Clone()
	{
		return new JBLDOIIILEC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JBLDOIIILEC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JBLDOIIILEC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eBKDJHLFOGN_.Equals(other.eBKDJHLFOGN_))
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
		num ^= eBKDJHLFOGN_.GetHashCode();
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
		eBKDJHLFOGN_.WriteTo(ref output, _repeated_eBKDJHLFOGN_codec);
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
		num += eBKDJHLFOGN_.CalculateSize(_repeated_eBKDJHLFOGN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JBLDOIIILEC other)
	{
		if (other != null)
		{
			eBKDJHLFOGN_.Add(other.eBKDJHLFOGN_);
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
				eBKDJHLFOGN_.AddEntriesFrom(ref input, _repeated_eBKDJHLFOGN_codec);
			}
		}
	}
}
