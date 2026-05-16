using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFOLIJCNDBK : IMessage<KFOLIJCNDBK>, IMessage, IEquatable<KFOLIJCNDBK>, IDeepCloneable<KFOLIJCNDBK>, IBufferMessage
{
	private static readonly MessageParser<KFOLIJCNDBK> _parser = new MessageParser<KFOLIJCNDBK>(() => new KFOLIJCNDBK());

	private UnknownFieldSet _unknownFields;

	public const int FCHIKAAFCPLFieldNumber = 1;

	private uint fCHIKAAFCPL_;

	public const int HOBNHBCJIDMFieldNumber = 2;

	private static readonly FieldCodec<GGBDCOICGJG> _repeated_hOBNHBCJIDM_codec = FieldCodec.ForMessage(18u, GGBDCOICGJG.Parser);

	private readonly RepeatedField<GGBDCOICGJG> hOBNHBCJIDM_ = new RepeatedField<GGBDCOICGJG>();

	public const int HHBHOBOJOCFFieldNumber = 3;

	private static readonly FieldCodec<HKNDILDOJFP> _repeated_hHBHOBOJOCF_codec = FieldCodec.ForMessage(26u, HKNDILDOJFP.Parser);

	private readonly RepeatedField<HKNDILDOJFP> hHBHOBOJOCF_ = new RepeatedField<HKNDILDOJFP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFOLIJCNDBK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFOLIJCNDBKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCHIKAAFCPL
	{
		get
		{
			return fCHIKAAFCPL_;
		}
		set
		{
			fCHIKAAFCPL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GGBDCOICGJG> HOBNHBCJIDM => hOBNHBCJIDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HKNDILDOJFP> HHBHOBOJOCF => hHBHOBOJOCF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFOLIJCNDBK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFOLIJCNDBK(KFOLIJCNDBK other)
		: this()
	{
		fCHIKAAFCPL_ = other.fCHIKAAFCPL_;
		hOBNHBCJIDM_ = other.hOBNHBCJIDM_.Clone();
		hHBHOBOJOCF_ = other.hHBHOBOJOCF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFOLIJCNDBK Clone()
	{
		return new KFOLIJCNDBK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFOLIJCNDBK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFOLIJCNDBK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FCHIKAAFCPL != other.FCHIKAAFCPL)
		{
			return false;
		}
		if (!hOBNHBCJIDM_.Equals(other.hOBNHBCJIDM_))
		{
			return false;
		}
		if (!hHBHOBOJOCF_.Equals(other.hHBHOBOJOCF_))
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
		if (FCHIKAAFCPL != 0)
		{
			num ^= FCHIKAAFCPL.GetHashCode();
		}
		num ^= hOBNHBCJIDM_.GetHashCode();
		num ^= hHBHOBOJOCF_.GetHashCode();
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
		if (FCHIKAAFCPL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FCHIKAAFCPL);
		}
		hOBNHBCJIDM_.WriteTo(ref output, _repeated_hOBNHBCJIDM_codec);
		hHBHOBOJOCF_.WriteTo(ref output, _repeated_hHBHOBOJOCF_codec);
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
		if (FCHIKAAFCPL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCHIKAAFCPL);
		}
		num += hOBNHBCJIDM_.CalculateSize(_repeated_hOBNHBCJIDM_codec);
		num += hHBHOBOJOCF_.CalculateSize(_repeated_hHBHOBOJOCF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFOLIJCNDBK other)
	{
		if (other != null)
		{
			if (other.FCHIKAAFCPL != 0)
			{
				FCHIKAAFCPL = other.FCHIKAAFCPL;
			}
			hOBNHBCJIDM_.Add(other.hOBNHBCJIDM_);
			hHBHOBOJOCF_.Add(other.hHBHOBOJOCF_);
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
			case 8u:
				FCHIKAAFCPL = input.ReadUInt32();
				break;
			case 18u:
				hOBNHBCJIDM_.AddEntriesFrom(ref input, _repeated_hOBNHBCJIDM_codec);
				break;
			case 26u:
				hHBHOBOJOCF_.AddEntriesFrom(ref input, _repeated_hHBHOBOJOCF_codec);
				break;
			}
		}
	}
}
