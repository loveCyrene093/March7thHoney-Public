using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EFBDKEHLCDF : IMessage<EFBDKEHLCDF>, IMessage, IEquatable<EFBDKEHLCDF>, IDeepCloneable<EFBDKEHLCDF>, IBufferMessage
{
	private static readonly MessageParser<EFBDKEHLCDF> _parser = new MessageParser<EFBDKEHLCDF>(() => new EFBDKEHLCDF());

	private UnknownFieldSet _unknownFields;

	public const int DEPLLJPKKGDFieldNumber = 2;

	private static readonly FieldCodec<CKHDNJGMEJC> _repeated_dEPLLJPKKGD_codec = FieldCodec.ForMessage(18u, CKHDNJGMEJC.Parser);

	private readonly RepeatedField<CKHDNJGMEJC> dEPLLJPKKGD_ = new RepeatedField<CKHDNJGMEJC>();

	public const int BHABGAPJAHFFieldNumber = 10;

	private static readonly FieldCodec<CIPBBPHGEKJ> _repeated_bHABGAPJAHF_codec = FieldCodec.ForMessage(82u, CIPBBPHGEKJ.Parser);

	private readonly RepeatedField<CIPBBPHGEKJ> bHABGAPJAHF_ = new RepeatedField<CIPBBPHGEKJ>();

	public const int CDIFGIGFLELFieldNumber = 11;

	private static readonly FieldCodec<KACOOFIKHOG> _repeated_cDIFGIGFLEL_codec = FieldCodec.ForMessage(90u, KACOOFIKHOG.Parser);

	private readonly RepeatedField<KACOOFIKHOG> cDIFGIGFLEL_ = new RepeatedField<KACOOFIKHOG>();

	public const int NALLICMEEDIFieldNumber = 14;

	private uint nALLICMEEDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EFBDKEHLCDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EFBDKEHLCDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKHDNJGMEJC> DEPLLJPKKGD => dEPLLJPKKGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CIPBBPHGEKJ> BHABGAPJAHF => bHABGAPJAHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KACOOFIKHOG> CDIFGIGFLEL => cDIFGIGFLEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NALLICMEEDI
	{
		get
		{
			return nALLICMEEDI_;
		}
		set
		{
			nALLICMEEDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBDKEHLCDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBDKEHLCDF(EFBDKEHLCDF other)
		: this()
	{
		dEPLLJPKKGD_ = other.dEPLLJPKKGD_.Clone();
		bHABGAPJAHF_ = other.bHABGAPJAHF_.Clone();
		cDIFGIGFLEL_ = other.cDIFGIGFLEL_.Clone();
		nALLICMEEDI_ = other.nALLICMEEDI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBDKEHLCDF Clone()
	{
		return new EFBDKEHLCDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EFBDKEHLCDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EFBDKEHLCDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEPLLJPKKGD_.Equals(other.dEPLLJPKKGD_))
		{
			return false;
		}
		if (!bHABGAPJAHF_.Equals(other.bHABGAPJAHF_))
		{
			return false;
		}
		if (!cDIFGIGFLEL_.Equals(other.cDIFGIGFLEL_))
		{
			return false;
		}
		if (NALLICMEEDI != other.NALLICMEEDI)
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
		num ^= dEPLLJPKKGD_.GetHashCode();
		num ^= bHABGAPJAHF_.GetHashCode();
		num ^= cDIFGIGFLEL_.GetHashCode();
		if (NALLICMEEDI != 0)
		{
			num ^= NALLICMEEDI.GetHashCode();
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
		dEPLLJPKKGD_.WriteTo(ref output, _repeated_dEPLLJPKKGD_codec);
		bHABGAPJAHF_.WriteTo(ref output, _repeated_bHABGAPJAHF_codec);
		cDIFGIGFLEL_.WriteTo(ref output, _repeated_cDIFGIGFLEL_codec);
		if (NALLICMEEDI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NALLICMEEDI);
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
		num += dEPLLJPKKGD_.CalculateSize(_repeated_dEPLLJPKKGD_codec);
		num += bHABGAPJAHF_.CalculateSize(_repeated_bHABGAPJAHF_codec);
		num += cDIFGIGFLEL_.CalculateSize(_repeated_cDIFGIGFLEL_codec);
		if (NALLICMEEDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NALLICMEEDI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EFBDKEHLCDF other)
	{
		if (other != null)
		{
			dEPLLJPKKGD_.Add(other.dEPLLJPKKGD_);
			bHABGAPJAHF_.Add(other.bHABGAPJAHF_);
			cDIFGIGFLEL_.Add(other.cDIFGIGFLEL_);
			if (other.NALLICMEEDI != 0)
			{
				NALLICMEEDI = other.NALLICMEEDI;
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
			case 18u:
				dEPLLJPKKGD_.AddEntriesFrom(ref input, _repeated_dEPLLJPKKGD_codec);
				break;
			case 82u:
				bHABGAPJAHF_.AddEntriesFrom(ref input, _repeated_bHABGAPJAHF_codec);
				break;
			case 90u:
				cDIFGIGFLEL_.AddEntriesFrom(ref input, _repeated_cDIFGIGFLEL_codec);
				break;
			case 112u:
				NALLICMEEDI = input.ReadUInt32();
				break;
			}
		}
	}
}
