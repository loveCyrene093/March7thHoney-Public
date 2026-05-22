using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DNFCAMIIAKJ : IMessage<DNFCAMIIAKJ>, IMessage, IEquatable<DNFCAMIIAKJ>, IDeepCloneable<DNFCAMIIAKJ>, IBufferMessage
{
	private static readonly MessageParser<DNFCAMIIAKJ> _parser = new MessageParser<DNFCAMIIAKJ>(() => new DNFCAMIIAKJ());

	private UnknownFieldSet _unknownFields;

	public const int CABEIFHKGBGFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_cABEIFHKGBG_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> cABEIFHKGBG_ = new RepeatedField<uint>();

	public const int PDNCLPEDJIFFieldNumber = 10;

	private static readonly MapField<uint, uint>.Codec _map_pDNCLPEDJIF_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 82u);

	private readonly MapField<uint, uint> pDNCLPEDJIF_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DNFCAMIIAKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DNFCAMIIAKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CABEIFHKGBG => cABEIFHKGBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> PDNCLPEDJIF => pDNCLPEDJIF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFCAMIIAKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFCAMIIAKJ(DNFCAMIIAKJ other)
		: this()
	{
		cABEIFHKGBG_ = other.cABEIFHKGBG_.Clone();
		pDNCLPEDJIF_ = other.pDNCLPEDJIF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFCAMIIAKJ Clone()
	{
		return new DNFCAMIIAKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DNFCAMIIAKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DNFCAMIIAKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cABEIFHKGBG_.Equals(other.cABEIFHKGBG_))
		{
			return false;
		}
		if (!PDNCLPEDJIF.Equals(other.PDNCLPEDJIF))
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
		num ^= cABEIFHKGBG_.GetHashCode();
		num ^= PDNCLPEDJIF.GetHashCode();
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
		cABEIFHKGBG_.WriteTo(ref output, _repeated_cABEIFHKGBG_codec);
		pDNCLPEDJIF_.WriteTo(ref output, _map_pDNCLPEDJIF_codec);
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
		num += cABEIFHKGBG_.CalculateSize(_repeated_cABEIFHKGBG_codec);
		num += pDNCLPEDJIF_.CalculateSize(_map_pDNCLPEDJIF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DNFCAMIIAKJ other)
	{
		if (other != null)
		{
			cABEIFHKGBG_.Add(other.cABEIFHKGBG_);
			pDNCLPEDJIF_.MergeFrom(other.pDNCLPEDJIF_);
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
			case 72u:
			case 74u:
				cABEIFHKGBG_.AddEntriesFrom(ref input, _repeated_cABEIFHKGBG_codec);
				break;
			case 82u:
				pDNCLPEDJIF_.AddEntriesFrom(ref input, _map_pDNCLPEDJIF_codec);
				break;
			}
		}
	}
}
