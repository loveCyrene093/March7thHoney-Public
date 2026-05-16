using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OKIGCEPLMKA : IMessage<OKIGCEPLMKA>, IMessage, IEquatable<OKIGCEPLMKA>, IDeepCloneable<OKIGCEPLMKA>, IBufferMessage
{
	private static readonly MessageParser<OKIGCEPLMKA> _parser = new MessageParser<OKIGCEPLMKA>(() => new OKIGCEPLMKA());

	private UnknownFieldSet _unknownFields;

	public const int IDMEFDEFOKGFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_iDMEFDEFOKG_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> iDMEFDEFOKG_ = new RepeatedField<uint>();

	public const int PENLMEIJIFKFieldNumber = 12;

	private uint pENLMEIJIFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OKIGCEPLMKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OKIGCEPLMKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IDMEFDEFOKG => iDMEFDEFOKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIGCEPLMKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIGCEPLMKA(OKIGCEPLMKA other)
		: this()
	{
		iDMEFDEFOKG_ = other.iDMEFDEFOKG_.Clone();
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIGCEPLMKA Clone()
	{
		return new OKIGCEPLMKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OKIGCEPLMKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OKIGCEPLMKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iDMEFDEFOKG_.Equals(other.iDMEFDEFOKG_))
		{
			return false;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
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
		num ^= iDMEFDEFOKG_.GetHashCode();
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
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
		iDMEFDEFOKG_.WriteTo(ref output, _repeated_iDMEFDEFOKG_codec);
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PENLMEIJIFK);
		}
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
		num += iDMEFDEFOKG_.CalculateSize(_repeated_iDMEFDEFOKG_codec);
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OKIGCEPLMKA other)
	{
		if (other != null)
		{
			iDMEFDEFOKG_.Add(other.iDMEFDEFOKG_);
			if (other.PENLMEIJIFK != 0)
			{
				PENLMEIJIFK = other.PENLMEIJIFK;
			}
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
			case 40u:
			case 42u:
				iDMEFDEFOKG_.AddEntriesFrom(ref input, _repeated_iDMEFDEFOKG_codec);
				break;
			case 96u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			}
		}
	}
}
