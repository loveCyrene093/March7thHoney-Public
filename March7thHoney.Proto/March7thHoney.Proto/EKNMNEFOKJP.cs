using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EKNMNEFOKJP : IMessage<EKNMNEFOKJP>, IMessage, IEquatable<EKNMNEFOKJP>, IDeepCloneable<EKNMNEFOKJP>, IBufferMessage
{
	private static readonly MessageParser<EKNMNEFOKJP> _parser = new MessageParser<EKNMNEFOKJP>(() => new EKNMNEFOKJP());

	private UnknownFieldSet _unknownFields;

	public const int CDDJDGHEKMHFieldNumber = 6;

	private static readonly FieldCodec<AHMMECMMPBL> _repeated_cDDJDGHEKMH_codec = FieldCodec.ForMessage(50u, AHMMECMMPBL.Parser);

	private readonly RepeatedField<AHMMECMMPBL> cDDJDGHEKMH_ = new RepeatedField<AHMMECMMPBL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EKNMNEFOKJP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EKNMNEFOKJPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AHMMECMMPBL> CDDJDGHEKMH => cDDJDGHEKMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKNMNEFOKJP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKNMNEFOKJP(EKNMNEFOKJP other)
		: this()
	{
		cDDJDGHEKMH_ = other.cDDJDGHEKMH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKNMNEFOKJP Clone()
	{
		return new EKNMNEFOKJP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EKNMNEFOKJP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EKNMNEFOKJP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cDDJDGHEKMH_.Equals(other.cDDJDGHEKMH_))
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
		num ^= cDDJDGHEKMH_.GetHashCode();
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
		cDDJDGHEKMH_.WriteTo(ref output, _repeated_cDDJDGHEKMH_codec);
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
		num += cDDJDGHEKMH_.CalculateSize(_repeated_cDDJDGHEKMH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EKNMNEFOKJP other)
	{
		if (other != null)
		{
			cDDJDGHEKMH_.Add(other.cDDJDGHEKMH_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cDDJDGHEKMH_.AddEntriesFrom(ref input, _repeated_cDDJDGHEKMH_codec);
			}
		}
	}
}
