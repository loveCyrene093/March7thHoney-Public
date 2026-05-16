using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AGLBGFLKIME : IMessage<AGLBGFLKIME>, IMessage, IEquatable<AGLBGFLKIME>, IDeepCloneable<AGLBGFLKIME>, IBufferMessage
{
	private static readonly MessageParser<AGLBGFLKIME> _parser = new MessageParser<AGLBGFLKIME>(() => new AGLBGFLKIME());

	private UnknownFieldSet _unknownFields;

	public const int NBAODFGCEBFFieldNumber = 9;

	private static readonly FieldCodec<HOBHGEGJFEN> _repeated_nBAODFGCEBF_codec = FieldCodec.ForMessage(74u, HOBHGEGJFEN.Parser);

	private readonly RepeatedField<HOBHGEGJFEN> nBAODFGCEBF_ = new RepeatedField<HOBHGEGJFEN>();

	public const int EALGMDDILKBFieldNumber = 10;

	private uint eALGMDDILKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AGLBGFLKIME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AGLBGFLKIMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HOBHGEGJFEN> NBAODFGCEBF => nBAODFGCEBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EALGMDDILKB
	{
		get
		{
			return eALGMDDILKB_;
		}
		set
		{
			eALGMDDILKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLBGFLKIME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLBGFLKIME(AGLBGFLKIME other)
		: this()
	{
		nBAODFGCEBF_ = other.nBAODFGCEBF_.Clone();
		eALGMDDILKB_ = other.eALGMDDILKB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLBGFLKIME Clone()
	{
		return new AGLBGFLKIME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AGLBGFLKIME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AGLBGFLKIME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nBAODFGCEBF_.Equals(other.nBAODFGCEBF_))
		{
			return false;
		}
		if (EALGMDDILKB != other.EALGMDDILKB)
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
		num ^= nBAODFGCEBF_.GetHashCode();
		if (EALGMDDILKB != 0)
		{
			num ^= EALGMDDILKB.GetHashCode();
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
		nBAODFGCEBF_.WriteTo(ref output, _repeated_nBAODFGCEBF_codec);
		if (EALGMDDILKB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EALGMDDILKB);
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
		num += nBAODFGCEBF_.CalculateSize(_repeated_nBAODFGCEBF_codec);
		if (EALGMDDILKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EALGMDDILKB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AGLBGFLKIME other)
	{
		if (other != null)
		{
			nBAODFGCEBF_.Add(other.nBAODFGCEBF_);
			if (other.EALGMDDILKB != 0)
			{
				EALGMDDILKB = other.EALGMDDILKB;
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
			case 74u:
				nBAODFGCEBF_.AddEntriesFrom(ref input, _repeated_nBAODFGCEBF_codec);
				break;
			case 80u:
				EALGMDDILKB = input.ReadUInt32();
				break;
			}
		}
	}
}
