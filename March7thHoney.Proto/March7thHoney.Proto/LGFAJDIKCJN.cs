using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGFAJDIKCJN : IMessage<LGFAJDIKCJN>, IMessage, IEquatable<LGFAJDIKCJN>, IDeepCloneable<LGFAJDIKCJN>, IBufferMessage
{
	private static readonly MessageParser<LGFAJDIKCJN> _parser = new MessageParser<LGFAJDIKCJN>(() => new LGFAJDIKCJN());

	private UnknownFieldSet _unknownFields;

	public const int DAPDHLKIAIAFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_dAPDHLKIAIA_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> dAPDHLKIAIA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGFAJDIKCJN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGFAJDIKCJNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DAPDHLKIAIA => dAPDHLKIAIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGFAJDIKCJN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGFAJDIKCJN(LGFAJDIKCJN other)
		: this()
	{
		dAPDHLKIAIA_ = other.dAPDHLKIAIA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGFAJDIKCJN Clone()
	{
		return new LGFAJDIKCJN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGFAJDIKCJN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGFAJDIKCJN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dAPDHLKIAIA_.Equals(other.dAPDHLKIAIA_))
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
		num ^= dAPDHLKIAIA_.GetHashCode();
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
		dAPDHLKIAIA_.WriteTo(ref output, _repeated_dAPDHLKIAIA_codec);
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
		num += dAPDHLKIAIA_.CalculateSize(_repeated_dAPDHLKIAIA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGFAJDIKCJN other)
	{
		if (other != null)
		{
			dAPDHLKIAIA_.Add(other.dAPDHLKIAIA_);
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
			if (num != 112 && num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dAPDHLKIAIA_.AddEntriesFrom(ref input, _repeated_dAPDHLKIAIA_codec);
			}
		}
	}
}
