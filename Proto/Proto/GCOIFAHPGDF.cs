using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCOIFAHPGDF : IMessage<GCOIFAHPGDF>, IMessage, IEquatable<GCOIFAHPGDF>, IDeepCloneable<GCOIFAHPGDF>, IBufferMessage
{
	private static readonly MessageParser<GCOIFAHPGDF> _parser = new MessageParser<GCOIFAHPGDF>(() => new GCOIFAHPGDF());

	private UnknownFieldSet _unknownFields;

	public const int AFEJACMLOLHFieldNumber = 1;

	private static readonly FieldCodec<NPLEDHFMFDM> _repeated_aFEJACMLOLH_codec = FieldCodec.ForMessage(10u, NPLEDHFMFDM.Parser);

	private readonly RepeatedField<NPLEDHFMFDM> aFEJACMLOLH_ = new RepeatedField<NPLEDHFMFDM>();

	public const int PEOECDDANNPFieldNumber = 2;

	private FOFNOBHLKGO pEOECDDANNP_;

	public const int FIHMHJHGHOGFieldNumber = 3;

	private long fIHMHJHGHOG_;

	public const int DHLGCEGONIBFieldNumber = 4;

	private long dHLGCEGONIB_;

	public const int GJGAGFEJABCFieldNumber = 5;

	private uint gJGAGFEJABC_;

	public const int GIIIBCKEODPFieldNumber = 6;

	private uint gIIIBCKEODP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCOIFAHPGDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCOIFAHPGDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NPLEDHFMFDM> AFEJACMLOLH => aFEJACMLOLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO PEOECDDANNP
	{
		get
		{
			return pEOECDDANNP_;
		}
		set
		{
			pEOECDDANNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FIHMHJHGHOG
	{
		get
		{
			return fIHMHJHGHOG_;
		}
		set
		{
			fIHMHJHGHOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DHLGCEGONIB
	{
		get
		{
			return dHLGCEGONIB_;
		}
		set
		{
			dHLGCEGONIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJGAGFEJABC
	{
		get
		{
			return gJGAGFEJABC_;
		}
		set
		{
			gJGAGFEJABC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIIIBCKEODP
	{
		get
		{
			return gIIIBCKEODP_;
		}
		set
		{
			gIIIBCKEODP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOIFAHPGDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOIFAHPGDF(GCOIFAHPGDF other)
		: this()
	{
		aFEJACMLOLH_ = other.aFEJACMLOLH_.Clone();
		pEOECDDANNP_ = ((other.pEOECDDANNP_ != null) ? other.pEOECDDANNP_.Clone() : null);
		fIHMHJHGHOG_ = other.fIHMHJHGHOG_;
		dHLGCEGONIB_ = other.dHLGCEGONIB_;
		gJGAGFEJABC_ = other.gJGAGFEJABC_;
		gIIIBCKEODP_ = other.gIIIBCKEODP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOIFAHPGDF Clone()
	{
		return new GCOIFAHPGDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCOIFAHPGDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCOIFAHPGDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aFEJACMLOLH_.Equals(other.aFEJACMLOLH_))
		{
			return false;
		}
		if (!object.Equals(PEOECDDANNP, other.PEOECDDANNP))
		{
			return false;
		}
		if (FIHMHJHGHOG != other.FIHMHJHGHOG)
		{
			return false;
		}
		if (DHLGCEGONIB != other.DHLGCEGONIB)
		{
			return false;
		}
		if (GJGAGFEJABC != other.GJGAGFEJABC)
		{
			return false;
		}
		if (GIIIBCKEODP != other.GIIIBCKEODP)
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
		num ^= aFEJACMLOLH_.GetHashCode();
		if (pEOECDDANNP_ != null)
		{
			num ^= PEOECDDANNP.GetHashCode();
		}
		if (FIHMHJHGHOG != 0L)
		{
			num ^= FIHMHJHGHOG.GetHashCode();
		}
		if (DHLGCEGONIB != 0L)
		{
			num ^= DHLGCEGONIB.GetHashCode();
		}
		if (GJGAGFEJABC != 0)
		{
			num ^= GJGAGFEJABC.GetHashCode();
		}
		if (GIIIBCKEODP != 0)
		{
			num ^= GIIIBCKEODP.GetHashCode();
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
		aFEJACMLOLH_.WriteTo(ref output, _repeated_aFEJACMLOLH_codec);
		if (pEOECDDANNP_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PEOECDDANNP);
		}
		if (FIHMHJHGHOG != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(FIHMHJHGHOG);
		}
		if (DHLGCEGONIB != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(DHLGCEGONIB);
		}
		if (GJGAGFEJABC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GJGAGFEJABC);
		}
		if (GIIIBCKEODP != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GIIIBCKEODP);
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
		num += aFEJACMLOLH_.CalculateSize(_repeated_aFEJACMLOLH_codec);
		if (pEOECDDANNP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEOECDDANNP);
		}
		if (FIHMHJHGHOG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(FIHMHJHGHOG);
		}
		if (DHLGCEGONIB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DHLGCEGONIB);
		}
		if (GJGAGFEJABC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJGAGFEJABC);
		}
		if (GIIIBCKEODP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIIIBCKEODP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCOIFAHPGDF other)
	{
		if (other == null)
		{
			return;
		}
		aFEJACMLOLH_.Add(other.aFEJACMLOLH_);
		if (other.pEOECDDANNP_ != null)
		{
			if (pEOECDDANNP_ == null)
			{
				PEOECDDANNP = new FOFNOBHLKGO();
			}
			PEOECDDANNP.MergeFrom(other.PEOECDDANNP);
		}
		if (other.FIHMHJHGHOG != 0L)
		{
			FIHMHJHGHOG = other.FIHMHJHGHOG;
		}
		if (other.DHLGCEGONIB != 0L)
		{
			DHLGCEGONIB = other.DHLGCEGONIB;
		}
		if (other.GJGAGFEJABC != 0)
		{
			GJGAGFEJABC = other.GJGAGFEJABC;
		}
		if (other.GIIIBCKEODP != 0)
		{
			GIIIBCKEODP = other.GIIIBCKEODP;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				aFEJACMLOLH_.AddEntriesFrom(ref input, _repeated_aFEJACMLOLH_codec);
				break;
			case 18u:
				if (pEOECDDANNP_ == null)
				{
					PEOECDDANNP = new FOFNOBHLKGO();
				}
				input.ReadMessage(PEOECDDANNP);
				break;
			case 24u:
				FIHMHJHGHOG = input.ReadInt64();
				break;
			case 32u:
				DHLGCEGONIB = input.ReadInt64();
				break;
			case 40u:
				GJGAGFEJABC = input.ReadUInt32();
				break;
			case 48u:
				GIIIBCKEODP = input.ReadUInt32();
				break;
			}
		}
	}
}
