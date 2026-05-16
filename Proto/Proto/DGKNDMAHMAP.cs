using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DGKNDMAHMAP : IMessage<DGKNDMAHMAP>, IMessage, IEquatable<DGKNDMAHMAP>, IDeepCloneable<DGKNDMAHMAP>, IBufferMessage
{
	private static readonly MessageParser<DGKNDMAHMAP> _parser = new MessageParser<DGKNDMAHMAP>(() => new DGKNDMAHMAP());

	private UnknownFieldSet _unknownFields;

	public const int BIBGHICIDKPFieldNumber = 2;

	private static readonly FieldCodec<HGELKDGCCOL> _repeated_bIBGHICIDKP_codec = FieldCodec.ForMessage(18u, HGELKDGCCOL.Parser);

	private readonly RepeatedField<HGELKDGCCOL> bIBGHICIDKP_ = new RepeatedField<HGELKDGCCOL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DGKNDMAHMAP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DGKNDMAHMAPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HGELKDGCCOL> BIBGHICIDKP => bIBGHICIDKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP(DGKNDMAHMAP other)
		: this()
	{
		bIBGHICIDKP_ = other.bIBGHICIDKP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP Clone()
	{
		return new DGKNDMAHMAP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DGKNDMAHMAP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DGKNDMAHMAP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bIBGHICIDKP_.Equals(other.bIBGHICIDKP_))
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
		num ^= bIBGHICIDKP_.GetHashCode();
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
		bIBGHICIDKP_.WriteTo(ref output, _repeated_bIBGHICIDKP_codec);
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
		num += bIBGHICIDKP_.CalculateSize(_repeated_bIBGHICIDKP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DGKNDMAHMAP other)
	{
		if (other != null)
		{
			bIBGHICIDKP_.Add(other.bIBGHICIDKP_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bIBGHICIDKP_.AddEntriesFrom(ref input, _repeated_bIBGHICIDKP_codec);
			}
		}
	}
}
