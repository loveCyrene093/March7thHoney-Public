using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EGOEEMFIJFO : IMessage<EGOEEMFIJFO>, IMessage, IEquatable<EGOEEMFIJFO>, IDeepCloneable<EGOEEMFIJFO>, IBufferMessage
{
	private static readonly MessageParser<EGOEEMFIJFO> _parser = new MessageParser<EGOEEMFIJFO>(() => new EGOEEMFIJFO());

	private UnknownFieldSet _unknownFields;

	public const int ExpFieldNumber = 8;

	private uint exp_;

	public const int EILLOHOIOMEFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_eILLOHOIOME_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> eILLOHOIOME_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EGOEEMFIJFO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EGOEEMFIJFOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EILLOHOIOME => eILLOHOIOME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGOEEMFIJFO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGOEEMFIJFO(EGOEEMFIJFO other)
		: this()
	{
		exp_ = other.exp_;
		eILLOHOIOME_ = other.eILLOHOIOME_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGOEEMFIJFO Clone()
	{
		return new EGOEEMFIJFO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EGOEEMFIJFO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EGOEEMFIJFO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (!eILLOHOIOME_.Equals(other.eILLOHOIOME_))
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
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		num ^= eILLOHOIOME_.GetHashCode();
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
		if (Exp != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Exp);
		}
		eILLOHOIOME_.WriteTo(ref output, _repeated_eILLOHOIOME_codec);
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
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		num += eILLOHOIOME_.CalculateSize(_repeated_eILLOHOIOME_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EGOEEMFIJFO other)
	{
		if (other != null)
		{
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			eILLOHOIOME_.Add(other.eILLOHOIOME_);
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
			case 64u:
				Exp = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				eILLOHOIOME_.AddEntriesFrom(ref input, _repeated_eILLOHOIOME_codec);
				break;
			}
		}
	}
}
