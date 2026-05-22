using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPDMGOACIEP : IMessage<OPDMGOACIEP>, IMessage, IEquatable<OPDMGOACIEP>, IDeepCloneable<OPDMGOACIEP>, IBufferMessage
{
	private static readonly MessageParser<OPDMGOACIEP> _parser = new MessageParser<OPDMGOACIEP>(() => new OPDMGOACIEP());

	private UnknownFieldSet _unknownFields;

	public const int FGACEKLGGBEFieldNumber = 3;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_fGACEKLGGBE_codec = FieldCodec.ForMessage(26u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> fGACEKLGGBE_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPDMGOACIEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPDMGOACIEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> FGACEKLGGBE => fGACEKLGGBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPDMGOACIEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPDMGOACIEP(OPDMGOACIEP other)
		: this()
	{
		fGACEKLGGBE_ = other.fGACEKLGGBE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPDMGOACIEP Clone()
	{
		return new OPDMGOACIEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPDMGOACIEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPDMGOACIEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fGACEKLGGBE_.Equals(other.fGACEKLGGBE_))
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
		num ^= fGACEKLGGBE_.GetHashCode();
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
		fGACEKLGGBE_.WriteTo(ref output, _repeated_fGACEKLGGBE_codec);
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
		num += fGACEKLGGBE_.CalculateSize(_repeated_fGACEKLGGBE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPDMGOACIEP other)
	{
		if (other != null)
		{
			fGACEKLGGBE_.Add(other.fGACEKLGGBE_);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fGACEKLGGBE_.AddEntriesFrom(ref input, _repeated_fGACEKLGGBE_codec);
			}
		}
	}
}
