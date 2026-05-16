using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FJCDAKICFKA : IMessage<FJCDAKICFKA>, IMessage, IEquatable<FJCDAKICFKA>, IDeepCloneable<FJCDAKICFKA>, IBufferMessage
{
	private static readonly MessageParser<FJCDAKICFKA> _parser = new MessageParser<FJCDAKICFKA>(() => new FJCDAKICFKA());

	private UnknownFieldSet _unknownFields;

	public const int JGKIBPDAEFEFieldNumber = 6;

	private uint jGKIBPDAEFE_;

	public const int BDKHHFFGNMAFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_bDKHHFFGNMA_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> bDKHHFFGNMA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FJCDAKICFKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FJCDAKICFKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGKIBPDAEFE
	{
		get
		{
			return jGKIBPDAEFE_;
		}
		set
		{
			jGKIBPDAEFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BDKHHFFGNMA => bDKHHFFGNMA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJCDAKICFKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJCDAKICFKA(FJCDAKICFKA other)
		: this()
	{
		jGKIBPDAEFE_ = other.jGKIBPDAEFE_;
		bDKHHFFGNMA_ = other.bDKHHFFGNMA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJCDAKICFKA Clone()
	{
		return new FJCDAKICFKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FJCDAKICFKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FJCDAKICFKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JGKIBPDAEFE != other.JGKIBPDAEFE)
		{
			return false;
		}
		if (!bDKHHFFGNMA_.Equals(other.bDKHHFFGNMA_))
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
		if (JGKIBPDAEFE != 0)
		{
			num ^= JGKIBPDAEFE.GetHashCode();
		}
		num ^= bDKHHFFGNMA_.GetHashCode();
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
		if (JGKIBPDAEFE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JGKIBPDAEFE);
		}
		bDKHHFFGNMA_.WriteTo(ref output, _repeated_bDKHHFFGNMA_codec);
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
		if (JGKIBPDAEFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGKIBPDAEFE);
		}
		num += bDKHHFFGNMA_.CalculateSize(_repeated_bDKHHFFGNMA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FJCDAKICFKA other)
	{
		if (other != null)
		{
			if (other.JGKIBPDAEFE != 0)
			{
				JGKIBPDAEFE = other.JGKIBPDAEFE;
			}
			bDKHHFFGNMA_.Add(other.bDKHHFFGNMA_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 48u:
				JGKIBPDAEFE = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				bDKHHFFGNMA_.AddEntriesFrom(ref input, _repeated_bDKHHFFGNMA_codec);
				break;
			}
		}
	}
}
