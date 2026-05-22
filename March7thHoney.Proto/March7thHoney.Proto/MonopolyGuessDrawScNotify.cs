using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGuessDrawScNotify : IMessage<MonopolyGuessDrawScNotify>, IMessage, IEquatable<MonopolyGuessDrawScNotify>, IDeepCloneable<MonopolyGuessDrawScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGuessDrawScNotify> _parser = new MessageParser<MonopolyGuessDrawScNotify>(() => new MonopolyGuessDrawScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CCGJKBOLCDLFieldNumber = 10;

	private static readonly FieldCodec<LNINNLAEANB> _repeated_cCGJKBOLCDL_codec = FieldCodec.ForMessage(82u, LNINNLAEANB.Parser);

	private readonly RepeatedField<LNINNLAEANB> cCGJKBOLCDL_ = new RepeatedField<LNINNLAEANB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGuessDrawScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGuessDrawScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LNINNLAEANB> CCGJKBOLCDL => cCGJKBOLCDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGuessDrawScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGuessDrawScNotify(MonopolyGuessDrawScNotify other)
		: this()
	{
		cCGJKBOLCDL_ = other.cCGJKBOLCDL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGuessDrawScNotify Clone()
	{
		return new MonopolyGuessDrawScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGuessDrawScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGuessDrawScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cCGJKBOLCDL_.Equals(other.cCGJKBOLCDL_))
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
		num ^= cCGJKBOLCDL_.GetHashCode();
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
		cCGJKBOLCDL_.WriteTo(ref output, _repeated_cCGJKBOLCDL_codec);
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
		num += cCGJKBOLCDL_.CalculateSize(_repeated_cCGJKBOLCDL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGuessDrawScNotify other)
	{
		if (other != null)
		{
			cCGJKBOLCDL_.Add(other.cCGJKBOLCDL_);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cCGJKBOLCDL_.AddEntriesFrom(ref input, _repeated_cCGJKBOLCDL_codec);
			}
		}
	}
}
