using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FMGJFLEPDBB : IMessage<FMGJFLEPDBB>, IMessage, IEquatable<FMGJFLEPDBB>, IDeepCloneable<FMGJFLEPDBB>, IBufferMessage
{
	private static readonly MessageParser<FMGJFLEPDBB> _parser = new MessageParser<FMGJFLEPDBB>(() => new FMGJFLEPDBB());

	private UnknownFieldSet _unknownFields;

	public const int DEJAHCPFEIDFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_dEJAHCPFEID_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> dEJAHCPFEID_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FMGJFLEPDBB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FMGJFLEPDBBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DEJAHCPFEID => dEJAHCPFEID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGJFLEPDBB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGJFLEPDBB(FMGJFLEPDBB other)
		: this()
	{
		dEJAHCPFEID_ = other.dEJAHCPFEID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGJFLEPDBB Clone()
	{
		return new FMGJFLEPDBB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FMGJFLEPDBB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FMGJFLEPDBB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEJAHCPFEID_.Equals(other.dEJAHCPFEID_))
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
		num ^= dEJAHCPFEID_.GetHashCode();
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
		dEJAHCPFEID_.WriteTo(ref output, _repeated_dEJAHCPFEID_codec);
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
		num += dEJAHCPFEID_.CalculateSize(_repeated_dEJAHCPFEID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FMGJFLEPDBB other)
	{
		if (other != null)
		{
			dEJAHCPFEID_.Add(other.dEJAHCPFEID_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dEJAHCPFEID_.AddEntriesFrom(ref input, _repeated_dEJAHCPFEID_codec);
			}
		}
	}
}
