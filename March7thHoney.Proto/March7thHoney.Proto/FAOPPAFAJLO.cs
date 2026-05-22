using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FAOPPAFAJLO : IMessage<FAOPPAFAJLO>, IMessage, IEquatable<FAOPPAFAJLO>, IDeepCloneable<FAOPPAFAJLO>, IBufferMessage
{
	private static readonly MessageParser<FAOPPAFAJLO> _parser = new MessageParser<FAOPPAFAJLO>(() => new FAOPPAFAJLO());

	private UnknownFieldSet _unknownFields;

	public const int JNNKJAEMOBNFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_jNNKJAEMOBN_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> jNNKJAEMOBN_ = new RepeatedField<uint>();

	public const int NFODIBIIGMOFieldNumber = 6;

	private bool nFODIBIIGMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FAOPPAFAJLO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FAOPPAFAJLOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JNNKJAEMOBN => jNNKJAEMOBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NFODIBIIGMO
	{
		get
		{
			return nFODIBIIGMO_;
		}
		set
		{
			nFODIBIIGMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAOPPAFAJLO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAOPPAFAJLO(FAOPPAFAJLO other)
		: this()
	{
		jNNKJAEMOBN_ = other.jNNKJAEMOBN_.Clone();
		nFODIBIIGMO_ = other.nFODIBIIGMO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FAOPPAFAJLO Clone()
	{
		return new FAOPPAFAJLO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FAOPPAFAJLO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FAOPPAFAJLO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jNNKJAEMOBN_.Equals(other.jNNKJAEMOBN_))
		{
			return false;
		}
		if (NFODIBIIGMO != other.NFODIBIIGMO)
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
		num ^= jNNKJAEMOBN_.GetHashCode();
		if (NFODIBIIGMO)
		{
			num ^= NFODIBIIGMO.GetHashCode();
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
		jNNKJAEMOBN_.WriteTo(ref output, _repeated_jNNKJAEMOBN_codec);
		if (NFODIBIIGMO)
		{
			output.WriteRawTag(48);
			output.WriteBool(NFODIBIIGMO);
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
		num += jNNKJAEMOBN_.CalculateSize(_repeated_jNNKJAEMOBN_codec);
		if (NFODIBIIGMO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FAOPPAFAJLO other)
	{
		if (other != null)
		{
			jNNKJAEMOBN_.Add(other.jNNKJAEMOBN_);
			if (other.NFODIBIIGMO)
			{
				NFODIBIIGMO = other.NFODIBIIGMO;
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
			case 24u:
			case 26u:
				jNNKJAEMOBN_.AddEntriesFrom(ref input, _repeated_jNNKJAEMOBN_codec);
				break;
			case 48u:
				NFODIBIIGMO = input.ReadBool();
				break;
			}
		}
	}
}
