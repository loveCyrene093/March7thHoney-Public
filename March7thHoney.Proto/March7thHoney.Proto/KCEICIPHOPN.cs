using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KCEICIPHOPN : IMessage<KCEICIPHOPN>, IMessage, IEquatable<KCEICIPHOPN>, IDeepCloneable<KCEICIPHOPN>, IBufferMessage
{
	private static readonly MessageParser<KCEICIPHOPN> _parser = new MessageParser<KCEICIPHOPN>(() => new KCEICIPHOPN());

	private UnknownFieldSet _unknownFields;

	public const int BICPNKOCHGNFieldNumber = 8;

	private static readonly FieldCodec<LHDOBOHHKMB> _repeated_bICPNKOCHGN_codec = FieldCodec.ForMessage(66u, LHDOBOHHKMB.Parser);

	private readonly RepeatedField<LHDOBOHHKMB> bICPNKOCHGN_ = new RepeatedField<LHDOBOHHKMB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KCEICIPHOPN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KCEICIPHOPNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LHDOBOHHKMB> BICPNKOCHGN => bICPNKOCHGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEICIPHOPN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEICIPHOPN(KCEICIPHOPN other)
		: this()
	{
		bICPNKOCHGN_ = other.bICPNKOCHGN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEICIPHOPN Clone()
	{
		return new KCEICIPHOPN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KCEICIPHOPN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KCEICIPHOPN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bICPNKOCHGN_.Equals(other.bICPNKOCHGN_))
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
		num ^= bICPNKOCHGN_.GetHashCode();
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
		bICPNKOCHGN_.WriteTo(ref output, _repeated_bICPNKOCHGN_codec);
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
		num += bICPNKOCHGN_.CalculateSize(_repeated_bICPNKOCHGN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KCEICIPHOPN other)
	{
		if (other != null)
		{
			bICPNKOCHGN_.Add(other.bICPNKOCHGN_);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bICPNKOCHGN_.AddEntriesFrom(ref input, _repeated_bICPNKOCHGN_codec);
			}
		}
	}
}
