using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EONNKCKPDKI : IMessage<EONNKCKPDKI>, IMessage, IEquatable<EONNKCKPDKI>, IDeepCloneable<EONNKCKPDKI>, IBufferMessage
{
	private static readonly MessageParser<EONNKCKPDKI> _parser = new MessageParser<EONNKCKPDKI>(() => new EONNKCKPDKI());

	private UnknownFieldSet _unknownFields;

	public const int FNCDCHJMHLFFieldNumber = 13;

	private static readonly FieldCodec<LBJMGIHILGB> _repeated_fNCDCHJMHLF_codec = FieldCodec.ForMessage(106u, LBJMGIHILGB.Parser);

	private readonly RepeatedField<LBJMGIHILGB> fNCDCHJMHLF_ = new RepeatedField<LBJMGIHILGB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EONNKCKPDKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EONNKCKPDKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LBJMGIHILGB> FNCDCHJMHLF => fNCDCHJMHLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EONNKCKPDKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EONNKCKPDKI(EONNKCKPDKI other)
		: this()
	{
		fNCDCHJMHLF_ = other.fNCDCHJMHLF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EONNKCKPDKI Clone()
	{
		return new EONNKCKPDKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EONNKCKPDKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EONNKCKPDKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fNCDCHJMHLF_.Equals(other.fNCDCHJMHLF_))
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
		num ^= fNCDCHJMHLF_.GetHashCode();
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
		fNCDCHJMHLF_.WriteTo(ref output, _repeated_fNCDCHJMHLF_codec);
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
		num += fNCDCHJMHLF_.CalculateSize(_repeated_fNCDCHJMHLF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EONNKCKPDKI other)
	{
		if (other != null)
		{
			fNCDCHJMHLF_.Add(other.fNCDCHJMHLF_);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fNCDCHJMHLF_.AddEntriesFrom(ref input, _repeated_fNCDCHJMHLF_codec);
			}
		}
	}
}
