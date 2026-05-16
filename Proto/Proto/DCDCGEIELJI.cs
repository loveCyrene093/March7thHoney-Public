using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCDCGEIELJI : IMessage<DCDCGEIELJI>, IMessage, IEquatable<DCDCGEIELJI>, IDeepCloneable<DCDCGEIELJI>, IBufferMessage
{
	private static readonly MessageParser<DCDCGEIELJI> _parser = new MessageParser<DCDCGEIELJI>(() => new DCDCGEIELJI());

	private UnknownFieldSet _unknownFields;

	public const int AMBFEJIFLNCFieldNumber = 4;

	private static readonly FieldCodec<BNFIBKPENEF> _repeated_aMBFEJIFLNC_codec = FieldCodec.ForMessage(34u, BNFIBKPENEF.Parser);

	private readonly RepeatedField<BNFIBKPENEF> aMBFEJIFLNC_ = new RepeatedField<BNFIBKPENEF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCDCGEIELJI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCDCGEIELJIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BNFIBKPENEF> AMBFEJIFLNC => aMBFEJIFLNC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCDCGEIELJI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCDCGEIELJI(DCDCGEIELJI other)
		: this()
	{
		aMBFEJIFLNC_ = other.aMBFEJIFLNC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCDCGEIELJI Clone()
	{
		return new DCDCGEIELJI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCDCGEIELJI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCDCGEIELJI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aMBFEJIFLNC_.Equals(other.aMBFEJIFLNC_))
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
		num ^= aMBFEJIFLNC_.GetHashCode();
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
		aMBFEJIFLNC_.WriteTo(ref output, _repeated_aMBFEJIFLNC_codec);
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
		num += aMBFEJIFLNC_.CalculateSize(_repeated_aMBFEJIFLNC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DCDCGEIELJI other)
	{
		if (other != null)
		{
			aMBFEJIFLNC_.Add(other.aMBFEJIFLNC_);
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
				aMBFEJIFLNC_.AddEntriesFrom(ref input, _repeated_aMBFEJIFLNC_codec);
			}
		}
	}
}
