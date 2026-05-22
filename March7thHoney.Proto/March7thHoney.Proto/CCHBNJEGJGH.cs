using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCHBNJEGJGH : IMessage<CCHBNJEGJGH>, IMessage, IEquatable<CCHBNJEGJGH>, IDeepCloneable<CCHBNJEGJGH>, IBufferMessage
{
	private static readonly MessageParser<CCHBNJEGJGH> _parser = new MessageParser<CCHBNJEGJGH>(() => new CCHBNJEGJGH());

	private UnknownFieldSet _unknownFields;

	public const int NCBFLPMBCHJFieldNumber = 6;

	private static readonly FieldCodec<OOJKKECPOJA> _repeated_nCBFLPMBCHJ_codec = FieldCodec.ForMessage(50u, OOJKKECPOJA.Parser);

	private readonly RepeatedField<OOJKKECPOJA> nCBFLPMBCHJ_ = new RepeatedField<OOJKKECPOJA>();

	public const int NMDDAFKIGDFFieldNumber = 9;

	private uint nMDDAFKIGDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCHBNJEGJGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCHBNJEGJGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OOJKKECPOJA> NCBFLPMBCHJ => nCBFLPMBCHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMDDAFKIGDF
	{
		get
		{
			return nMDDAFKIGDF_;
		}
		set
		{
			nMDDAFKIGDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCHBNJEGJGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCHBNJEGJGH(CCHBNJEGJGH other)
		: this()
	{
		nCBFLPMBCHJ_ = other.nCBFLPMBCHJ_.Clone();
		nMDDAFKIGDF_ = other.nMDDAFKIGDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCHBNJEGJGH Clone()
	{
		return new CCHBNJEGJGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCHBNJEGJGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCHBNJEGJGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nCBFLPMBCHJ_.Equals(other.nCBFLPMBCHJ_))
		{
			return false;
		}
		if (NMDDAFKIGDF != other.NMDDAFKIGDF)
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
		num ^= nCBFLPMBCHJ_.GetHashCode();
		if (NMDDAFKIGDF != 0)
		{
			num ^= NMDDAFKIGDF.GetHashCode();
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
		nCBFLPMBCHJ_.WriteTo(ref output, _repeated_nCBFLPMBCHJ_codec);
		if (NMDDAFKIGDF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NMDDAFKIGDF);
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
		num += nCBFLPMBCHJ_.CalculateSize(_repeated_nCBFLPMBCHJ_codec);
		if (NMDDAFKIGDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMDDAFKIGDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCHBNJEGJGH other)
	{
		if (other != null)
		{
			nCBFLPMBCHJ_.Add(other.nCBFLPMBCHJ_);
			if (other.NMDDAFKIGDF != 0)
			{
				NMDDAFKIGDF = other.NMDDAFKIGDF;
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
			case 50u:
				nCBFLPMBCHJ_.AddEntriesFrom(ref input, _repeated_nCBFLPMBCHJ_codec);
				break;
			case 72u:
				NMDDAFKIGDF = input.ReadUInt32();
				break;
			}
		}
	}
}
