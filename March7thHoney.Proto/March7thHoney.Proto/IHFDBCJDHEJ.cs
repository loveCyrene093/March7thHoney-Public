using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IHFDBCJDHEJ : IMessage<IHFDBCJDHEJ>, IMessage, IEquatable<IHFDBCJDHEJ>, IDeepCloneable<IHFDBCJDHEJ>, IBufferMessage
{
	private static readonly MessageParser<IHFDBCJDHEJ> _parser = new MessageParser<IHFDBCJDHEJ>(() => new IHFDBCJDHEJ());

	private UnknownFieldSet _unknownFields;

	public const int DACEDNGJLBMFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_dACEDNGJLBM_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> dACEDNGJLBM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IHFDBCJDHEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IHFDBCJDHEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DACEDNGJLBM => dACEDNGJLBM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHFDBCJDHEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHFDBCJDHEJ(IHFDBCJDHEJ other)
		: this()
	{
		dACEDNGJLBM_ = other.dACEDNGJLBM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHFDBCJDHEJ Clone()
	{
		return new IHFDBCJDHEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IHFDBCJDHEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IHFDBCJDHEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dACEDNGJLBM_.Equals(other.dACEDNGJLBM_))
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
		num ^= dACEDNGJLBM_.GetHashCode();
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
		dACEDNGJLBM_.WriteTo(ref output, _repeated_dACEDNGJLBM_codec);
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
		num += dACEDNGJLBM_.CalculateSize(_repeated_dACEDNGJLBM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IHFDBCJDHEJ other)
	{
		if (other != null)
		{
			dACEDNGJLBM_.Add(other.dACEDNGJLBM_);
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
			if (num != 40 && num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dACEDNGJLBM_.AddEntriesFrom(ref input, _repeated_dACEDNGJLBM_codec);
			}
		}
	}
}
