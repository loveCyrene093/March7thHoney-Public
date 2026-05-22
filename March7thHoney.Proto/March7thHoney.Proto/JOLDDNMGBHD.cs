using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JOLDDNMGBHD : IMessage<JOLDDNMGBHD>, IMessage, IEquatable<JOLDDNMGBHD>, IDeepCloneable<JOLDDNMGBHD>, IBufferMessage
{
	private static readonly MessageParser<JOLDDNMGBHD> _parser = new MessageParser<JOLDDNMGBHD>(() => new JOLDDNMGBHD());

	private UnknownFieldSet _unknownFields;

	public const int DFIDPJEIBJKFieldNumber = 1;

	private static readonly FieldCodec<PHOCECJOBHH> _repeated_dFIDPJEIBJK_codec = FieldCodec.ForMessage(10u, PHOCECJOBHH.Parser);

	private readonly RepeatedField<PHOCECJOBHH> dFIDPJEIBJK_ = new RepeatedField<PHOCECJOBHH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JOLDDNMGBHD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JOLDDNMGBHDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PHOCECJOBHH> DFIDPJEIBJK => dFIDPJEIBJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOLDDNMGBHD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOLDDNMGBHD(JOLDDNMGBHD other)
		: this()
	{
		dFIDPJEIBJK_ = other.dFIDPJEIBJK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOLDDNMGBHD Clone()
	{
		return new JOLDDNMGBHD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JOLDDNMGBHD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JOLDDNMGBHD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dFIDPJEIBJK_.Equals(other.dFIDPJEIBJK_))
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
		num ^= dFIDPJEIBJK_.GetHashCode();
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
		dFIDPJEIBJK_.WriteTo(ref output, _repeated_dFIDPJEIBJK_codec);
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
		num += dFIDPJEIBJK_.CalculateSize(_repeated_dFIDPJEIBJK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JOLDDNMGBHD other)
	{
		if (other != null)
		{
			dFIDPJEIBJK_.Add(other.dFIDPJEIBJK_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dFIDPJEIBJK_.AddEntriesFrom(ref input, _repeated_dFIDPJEIBJK_codec);
			}
		}
	}
}
