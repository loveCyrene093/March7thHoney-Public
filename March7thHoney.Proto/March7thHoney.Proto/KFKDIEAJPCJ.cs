using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFKDIEAJPCJ : IMessage<KFKDIEAJPCJ>, IMessage, IEquatable<KFKDIEAJPCJ>, IDeepCloneable<KFKDIEAJPCJ>, IBufferMessage
{
	private static readonly MessageParser<KFKDIEAJPCJ> _parser = new MessageParser<KFKDIEAJPCJ>(() => new KFKDIEAJPCJ());

	private UnknownFieldSet _unknownFields;

	public const int CJFLLOBLNNGFieldNumber = 3;

	private static readonly FieldCodec<string> _repeated_cJFLLOBLNNG_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> cJFLLOBLNNG_ = new RepeatedField<string>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFKDIEAJPCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFKDIEAJPCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> CJFLLOBLNNG => cJFLLOBLNNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKDIEAJPCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKDIEAJPCJ(KFKDIEAJPCJ other)
		: this()
	{
		cJFLLOBLNNG_ = other.cJFLLOBLNNG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKDIEAJPCJ Clone()
	{
		return new KFKDIEAJPCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFKDIEAJPCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFKDIEAJPCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cJFLLOBLNNG_.Equals(other.cJFLLOBLNNG_))
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
		num ^= cJFLLOBLNNG_.GetHashCode();
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
		cJFLLOBLNNG_.WriteTo(ref output, _repeated_cJFLLOBLNNG_codec);
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
		num += cJFLLOBLNNG_.CalculateSize(_repeated_cJFLLOBLNNG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFKDIEAJPCJ other)
	{
		if (other != null)
		{
			cJFLLOBLNNG_.Add(other.cJFLLOBLNNG_);
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
				cJFLLOBLNNG_.AddEntriesFrom(ref input, _repeated_cJFLLOBLNNG_codec);
			}
		}
	}
}
