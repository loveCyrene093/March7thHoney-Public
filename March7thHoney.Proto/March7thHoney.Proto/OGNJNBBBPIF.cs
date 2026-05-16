using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGNJNBBBPIF : IMessage<OGNJNBBBPIF>, IMessage, IEquatable<OGNJNBBBPIF>, IDeepCloneable<OGNJNBBBPIF>, IBufferMessage
{
	private static readonly MessageParser<OGNJNBBBPIF> _parser = new MessageParser<OGNJNBBBPIF>(() => new OGNJNBBBPIF());

	private UnknownFieldSet _unknownFields;

	public const int BINLAPELLBOFieldNumber = 296;

	private static readonly FieldCodec<uint> _repeated_bINLAPELLBO_codec = FieldCodec.ForUInt32(2370u);

	private readonly RepeatedField<uint> bINLAPELLBO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGNJNBBBPIF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGNJNBBBPIFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BINLAPELLBO => bINLAPELLBO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGNJNBBBPIF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGNJNBBBPIF(OGNJNBBBPIF other)
		: this()
	{
		bINLAPELLBO_ = other.bINLAPELLBO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGNJNBBBPIF Clone()
	{
		return new OGNJNBBBPIF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGNJNBBBPIF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGNJNBBBPIF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bINLAPELLBO_.Equals(other.bINLAPELLBO_))
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
		num ^= bINLAPELLBO_.GetHashCode();
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
		bINLAPELLBO_.WriteTo(ref output, _repeated_bINLAPELLBO_codec);
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
		num += bINLAPELLBO_.CalculateSize(_repeated_bINLAPELLBO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGNJNBBBPIF other)
	{
		if (other != null)
		{
			bINLAPELLBO_.Add(other.bINLAPELLBO_);
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
			if (num != 2368 && num != 2370)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bINLAPELLBO_.AddEntriesFrom(ref input, _repeated_bINLAPELLBO_codec);
			}
		}
	}
}
