using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BGKDOOJAHAM : IMessage<BGKDOOJAHAM>, IMessage, IEquatable<BGKDOOJAHAM>, IDeepCloneable<BGKDOOJAHAM>, IBufferMessage
{
	private static readonly MessageParser<BGKDOOJAHAM> _parser = new MessageParser<BGKDOOJAHAM>(() => new BGKDOOJAHAM());

	private UnknownFieldSet _unknownFields;

	public const int BNGJHJKJAMMFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_bNGJHJKJAMM_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> bNGJHJKJAMM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BGKDOOJAHAM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BGKDOOJAHAMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BNGJHJKJAMM => bNGJHJKJAMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKDOOJAHAM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKDOOJAHAM(BGKDOOJAHAM other)
		: this()
	{
		bNGJHJKJAMM_ = other.bNGJHJKJAMM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKDOOJAHAM Clone()
	{
		return new BGKDOOJAHAM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BGKDOOJAHAM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BGKDOOJAHAM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bNGJHJKJAMM_.Equals(other.bNGJHJKJAMM_))
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
		num ^= bNGJHJKJAMM_.GetHashCode();
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
		bNGJHJKJAMM_.WriteTo(ref output, _repeated_bNGJHJKJAMM_codec);
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
		num += bNGJHJKJAMM_.CalculateSize(_repeated_bNGJHJKJAMM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BGKDOOJAHAM other)
	{
		if (other != null)
		{
			bNGJHJKJAMM_.Add(other.bNGJHJKJAMM_);
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
			if (num != 56 && num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bNGJHJKJAMM_.AddEntriesFrom(ref input, _repeated_bNGJHJKJAMM_codec);
			}
		}
	}
}
