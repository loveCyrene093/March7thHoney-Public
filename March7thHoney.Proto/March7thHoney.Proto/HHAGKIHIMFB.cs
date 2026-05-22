using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHAGKIHIMFB : IMessage<HHAGKIHIMFB>, IMessage, IEquatable<HHAGKIHIMFB>, IDeepCloneable<HHAGKIHIMFB>, IBufferMessage
{
	private static readonly MessageParser<HHAGKIHIMFB> _parser = new MessageParser<HHAGKIHIMFB>(() => new HHAGKIHIMFB());

	private UnknownFieldSet _unknownFields;

	public const int PFDKKFPPAAAFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_pFDKKFPPAAA_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> pFDKKFPPAAA_ = new RepeatedField<uint>();

	public const int BFAHDINJDMAFieldNumber = 7;

	private static readonly FieldCodec<HNKMPCPLIBB> _repeated_bFAHDINJDMA_codec = FieldCodec.ForMessage(58u, HNKMPCPLIBB.Parser);

	private readonly RepeatedField<HNKMPCPLIBB> bFAHDINJDMA_ = new RepeatedField<HNKMPCPLIBB>();

	public const int KIICCOFLILNFieldNumber = 8;

	private static readonly FieldCodec<KNGLMKEJBAB> _repeated_kIICCOFLILN_codec = FieldCodec.ForMessage(66u, KNGLMKEJBAB.Parser);

	private readonly RepeatedField<KNGLMKEJBAB> kIICCOFLILN_ = new RepeatedField<KNGLMKEJBAB>();

	public const int AAJAOCGHHAAFieldNumber = 10;

	private static readonly FieldCodec<NOJNMAIACGB> _repeated_aAJAOCGHHAA_codec = FieldCodec.ForMessage(82u, NOJNMAIACGB.Parser);

	private readonly RepeatedField<NOJNMAIACGB> aAJAOCGHHAA_ = new RepeatedField<NOJNMAIACGB>();

	public const int GLGOHINBJLEFieldNumber = 12;

	private uint gLGOHINBJLE_;

	public const int GBLEFAMKILBFieldNumber = 13;

	private bool gBLEFAMKILB_;

	public const int FGIPICIJMDFFieldNumber = 14;

	private uint fGIPICIJMDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHAGKIHIMFB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHAGKIHIMFBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PFDKKFPPAAA => pFDKKFPPAAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HNKMPCPLIBB> BFAHDINJDMA => bFAHDINJDMA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNGLMKEJBAB> KIICCOFLILN => kIICCOFLILN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NOJNMAIACGB> AAJAOCGHHAA => aAJAOCGHHAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLGOHINBJLE
	{
		get
		{
			return gLGOHINBJLE_;
		}
		set
		{
			gLGOHINBJLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GBLEFAMKILB
	{
		get
		{
			return gBLEFAMKILB_;
		}
		set
		{
			gBLEFAMKILB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FGIPICIJMDF
	{
		get
		{
			return fGIPICIJMDF_;
		}
		set
		{
			fGIPICIJMDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAGKIHIMFB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAGKIHIMFB(HHAGKIHIMFB other)
		: this()
	{
		pFDKKFPPAAA_ = other.pFDKKFPPAAA_.Clone();
		bFAHDINJDMA_ = other.bFAHDINJDMA_.Clone();
		kIICCOFLILN_ = other.kIICCOFLILN_.Clone();
		aAJAOCGHHAA_ = other.aAJAOCGHHAA_.Clone();
		gLGOHINBJLE_ = other.gLGOHINBJLE_;
		gBLEFAMKILB_ = other.gBLEFAMKILB_;
		fGIPICIJMDF_ = other.fGIPICIJMDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAGKIHIMFB Clone()
	{
		return new HHAGKIHIMFB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHAGKIHIMFB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHAGKIHIMFB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pFDKKFPPAAA_.Equals(other.pFDKKFPPAAA_))
		{
			return false;
		}
		if (!bFAHDINJDMA_.Equals(other.bFAHDINJDMA_))
		{
			return false;
		}
		if (!kIICCOFLILN_.Equals(other.kIICCOFLILN_))
		{
			return false;
		}
		if (!aAJAOCGHHAA_.Equals(other.aAJAOCGHHAA_))
		{
			return false;
		}
		if (GLGOHINBJLE != other.GLGOHINBJLE)
		{
			return false;
		}
		if (GBLEFAMKILB != other.GBLEFAMKILB)
		{
			return false;
		}
		if (FGIPICIJMDF != other.FGIPICIJMDF)
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
		num ^= pFDKKFPPAAA_.GetHashCode();
		num ^= bFAHDINJDMA_.GetHashCode();
		num ^= kIICCOFLILN_.GetHashCode();
		num ^= aAJAOCGHHAA_.GetHashCode();
		if (GLGOHINBJLE != 0)
		{
			num ^= GLGOHINBJLE.GetHashCode();
		}
		if (GBLEFAMKILB)
		{
			num ^= GBLEFAMKILB.GetHashCode();
		}
		if (FGIPICIJMDF != 0)
		{
			num ^= FGIPICIJMDF.GetHashCode();
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
		pFDKKFPPAAA_.WriteTo(ref output, _repeated_pFDKKFPPAAA_codec);
		bFAHDINJDMA_.WriteTo(ref output, _repeated_bFAHDINJDMA_codec);
		kIICCOFLILN_.WriteTo(ref output, _repeated_kIICCOFLILN_codec);
		aAJAOCGHHAA_.WriteTo(ref output, _repeated_aAJAOCGHHAA_codec);
		if (GLGOHINBJLE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GLGOHINBJLE);
		}
		if (GBLEFAMKILB)
		{
			output.WriteRawTag(104);
			output.WriteBool(GBLEFAMKILB);
		}
		if (FGIPICIJMDF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FGIPICIJMDF);
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
		num += pFDKKFPPAAA_.CalculateSize(_repeated_pFDKKFPPAAA_codec);
		num += bFAHDINJDMA_.CalculateSize(_repeated_bFAHDINJDMA_codec);
		num += kIICCOFLILN_.CalculateSize(_repeated_kIICCOFLILN_codec);
		num += aAJAOCGHHAA_.CalculateSize(_repeated_aAJAOCGHHAA_codec);
		if (GLGOHINBJLE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLGOHINBJLE);
		}
		if (GBLEFAMKILB)
		{
			num += 2;
		}
		if (FGIPICIJMDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FGIPICIJMDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHAGKIHIMFB other)
	{
		if (other != null)
		{
			pFDKKFPPAAA_.Add(other.pFDKKFPPAAA_);
			bFAHDINJDMA_.Add(other.bFAHDINJDMA_);
			kIICCOFLILN_.Add(other.kIICCOFLILN_);
			aAJAOCGHHAA_.Add(other.aAJAOCGHHAA_);
			if (other.GLGOHINBJLE != 0)
			{
				GLGOHINBJLE = other.GLGOHINBJLE;
			}
			if (other.GBLEFAMKILB)
			{
				GBLEFAMKILB = other.GBLEFAMKILB;
			}
			if (other.FGIPICIJMDF != 0)
			{
				FGIPICIJMDF = other.FGIPICIJMDF;
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
				pFDKKFPPAAA_.AddEntriesFrom(ref input, _repeated_pFDKKFPPAAA_codec);
				break;
			case 58u:
				bFAHDINJDMA_.AddEntriesFrom(ref input, _repeated_bFAHDINJDMA_codec);
				break;
			case 66u:
				kIICCOFLILN_.AddEntriesFrom(ref input, _repeated_kIICCOFLILN_codec);
				break;
			case 82u:
				aAJAOCGHHAA_.AddEntriesFrom(ref input, _repeated_aAJAOCGHHAA_codec);
				break;
			case 96u:
				GLGOHINBJLE = input.ReadUInt32();
				break;
			case 104u:
				GBLEFAMKILB = input.ReadBool();
				break;
			case 112u:
				FGIPICIJMDF = input.ReadUInt32();
				break;
			}
		}
	}
}
