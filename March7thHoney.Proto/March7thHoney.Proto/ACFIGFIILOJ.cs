using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ACFIGFIILOJ : IMessage<ACFIGFIILOJ>, IMessage, IEquatable<ACFIGFIILOJ>, IDeepCloneable<ACFIGFIILOJ>, IBufferMessage
{
	private static readonly MessageParser<ACFIGFIILOJ> _parser = new MessageParser<ACFIGFIILOJ>(() => new ACFIGFIILOJ());

	private UnknownFieldSet _unknownFields;

	public const int ExpFieldNumber = 3;

	private uint exp_;

	public const int POPPGIDKLMFFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_pOPPGIDKLMF_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> pOPPGIDKLMF_ = new RepeatedField<uint>();

	public const int GDIPEGFBLABFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_gDIPEGFBLAB_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> gDIPEGFBLAB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ACFIGFIILOJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ACFIGFIILOJReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> POPPGIDKLMF => pOPPGIDKLMF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GDIPEGFBLAB => gDIPEGFBLAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFIGFIILOJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFIGFIILOJ(ACFIGFIILOJ other)
		: this()
	{
		exp_ = other.exp_;
		pOPPGIDKLMF_ = other.pOPPGIDKLMF_.Clone();
		gDIPEGFBLAB_ = other.gDIPEGFBLAB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFIGFIILOJ Clone()
	{
		return new ACFIGFIILOJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ACFIGFIILOJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ACFIGFIILOJ other)
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
		if (!pOPPGIDKLMF_.Equals(other.pOPPGIDKLMF_))
		{
			return false;
		}
		if (!gDIPEGFBLAB_.Equals(other.gDIPEGFBLAB_))
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
		num ^= pOPPGIDKLMF_.GetHashCode();
		num ^= gDIPEGFBLAB_.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Exp);
		}
		pOPPGIDKLMF_.WriteTo(ref output, _repeated_pOPPGIDKLMF_codec);
		gDIPEGFBLAB_.WriteTo(ref output, _repeated_gDIPEGFBLAB_codec);
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
		num += pOPPGIDKLMF_.CalculateSize(_repeated_pOPPGIDKLMF_codec);
		num += gDIPEGFBLAB_.CalculateSize(_repeated_gDIPEGFBLAB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ACFIGFIILOJ other)
	{
		if (other != null)
		{
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			pOPPGIDKLMF_.Add(other.pOPPGIDKLMF_);
			gDIPEGFBLAB_.Add(other.gDIPEGFBLAB_);
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
				Exp = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				pOPPGIDKLMF_.AddEntriesFrom(ref input, _repeated_pOPPGIDKLMF_codec);
				break;
			case 96u:
			case 98u:
				gDIPEGFBLAB_.AddEntriesFrom(ref input, _repeated_gDIPEGFBLAB_codec);
				break;
			}
		}
	}
}
