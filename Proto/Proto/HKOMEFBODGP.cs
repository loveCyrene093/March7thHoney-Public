using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKOMEFBODGP : IMessage<HKOMEFBODGP>, IMessage, IEquatable<HKOMEFBODGP>, IDeepCloneable<HKOMEFBODGP>, IBufferMessage
{
	private static readonly MessageParser<HKOMEFBODGP> _parser = new MessageParser<HKOMEFBODGP>(() => new HKOMEFBODGP());

	private UnknownFieldSet _unknownFields;

	public const int FDJMJOKGOMFFieldNumber = 5;

	private static readonly FieldCodec<CMHAMBKCJBK> _repeated_fDJMJOKGOMF_codec = FieldCodec.ForMessage(42u, CMHAMBKCJBK.Parser);

	private readonly RepeatedField<CMHAMBKCJBK> fDJMJOKGOMF_ = new RepeatedField<CMHAMBKCJBK>();

	public const int IECNCJCANOCFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_iECNCJCANOC_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> iECNCJCANOC_ = new RepeatedField<uint>();

	public const int ILEMMKPGPNDFieldNumber = 7;

	private uint iLEMMKPGPND_;

	public const int OPLJDFOOMGFFieldNumber = 10;

	private static readonly MapField<string, int>.Codec _map_oPLJDFOOMGF_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 82u);

	private readonly MapField<string, int> oPLJDFOOMGF_ = new MapField<string, int>();

	public const int NKGIGKEBODGFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_nKGIGKEBODG_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> nKGIGKEBODG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKOMEFBODGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKOMEFBODGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CMHAMBKCJBK> FDJMJOKGOMF => fDJMJOKGOMF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IECNCJCANOC => iECNCJCANOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILEMMKPGPND
	{
		get
		{
			return iLEMMKPGPND_;
		}
		set
		{
			iLEMMKPGPND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> OPLJDFOOMGF => oPLJDFOOMGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NKGIGKEBODG => nKGIGKEBODG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKOMEFBODGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKOMEFBODGP(HKOMEFBODGP other)
		: this()
	{
		fDJMJOKGOMF_ = other.fDJMJOKGOMF_.Clone();
		iECNCJCANOC_ = other.iECNCJCANOC_.Clone();
		iLEMMKPGPND_ = other.iLEMMKPGPND_;
		oPLJDFOOMGF_ = other.oPLJDFOOMGF_.Clone();
		nKGIGKEBODG_ = other.nKGIGKEBODG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKOMEFBODGP Clone()
	{
		return new HKOMEFBODGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKOMEFBODGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKOMEFBODGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fDJMJOKGOMF_.Equals(other.fDJMJOKGOMF_))
		{
			return false;
		}
		if (!iECNCJCANOC_.Equals(other.iECNCJCANOC_))
		{
			return false;
		}
		if (ILEMMKPGPND != other.ILEMMKPGPND)
		{
			return false;
		}
		if (!OPLJDFOOMGF.Equals(other.OPLJDFOOMGF))
		{
			return false;
		}
		if (!nKGIGKEBODG_.Equals(other.nKGIGKEBODG_))
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
		num ^= fDJMJOKGOMF_.GetHashCode();
		num ^= iECNCJCANOC_.GetHashCode();
		if (ILEMMKPGPND != 0)
		{
			num ^= ILEMMKPGPND.GetHashCode();
		}
		num ^= OPLJDFOOMGF.GetHashCode();
		num ^= nKGIGKEBODG_.GetHashCode();
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
		fDJMJOKGOMF_.WriteTo(ref output, _repeated_fDJMJOKGOMF_codec);
		iECNCJCANOC_.WriteTo(ref output, _repeated_iECNCJCANOC_codec);
		if (ILEMMKPGPND != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ILEMMKPGPND);
		}
		oPLJDFOOMGF_.WriteTo(ref output, _map_oPLJDFOOMGF_codec);
		nKGIGKEBODG_.WriteTo(ref output, _repeated_nKGIGKEBODG_codec);
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
		num += fDJMJOKGOMF_.CalculateSize(_repeated_fDJMJOKGOMF_codec);
		num += iECNCJCANOC_.CalculateSize(_repeated_iECNCJCANOC_codec);
		if (ILEMMKPGPND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILEMMKPGPND);
		}
		num += oPLJDFOOMGF_.CalculateSize(_map_oPLJDFOOMGF_codec);
		num += nKGIGKEBODG_.CalculateSize(_repeated_nKGIGKEBODG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKOMEFBODGP other)
	{
		if (other != null)
		{
			fDJMJOKGOMF_.Add(other.fDJMJOKGOMF_);
			iECNCJCANOC_.Add(other.iECNCJCANOC_);
			if (other.ILEMMKPGPND != 0)
			{
				ILEMMKPGPND = other.ILEMMKPGPND;
			}
			oPLJDFOOMGF_.MergeFrom(other.oPLJDFOOMGF_);
			nKGIGKEBODG_.Add(other.nKGIGKEBODG_);
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
			case 42u:
				fDJMJOKGOMF_.AddEntriesFrom(ref input, _repeated_fDJMJOKGOMF_codec);
				break;
			case 48u:
			case 50u:
				iECNCJCANOC_.AddEntriesFrom(ref input, _repeated_iECNCJCANOC_codec);
				break;
			case 56u:
				ILEMMKPGPND = input.ReadUInt32();
				break;
			case 82u:
				oPLJDFOOMGF_.AddEntriesFrom(ref input, _map_oPLJDFOOMGF_codec);
				break;
			case 88u:
			case 90u:
				nKGIGKEBODG_.AddEntriesFrom(ref input, _repeated_nKGIGKEBODG_codec);
				break;
			}
		}
	}
}
