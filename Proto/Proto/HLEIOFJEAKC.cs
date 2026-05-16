using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLEIOFJEAKC : IMessage<HLEIOFJEAKC>, IMessage, IEquatable<HLEIOFJEAKC>, IDeepCloneable<HLEIOFJEAKC>, IBufferMessage
{
	private static readonly MessageParser<HLEIOFJEAKC> _parser = new MessageParser<HLEIOFJEAKC>(() => new HLEIOFJEAKC());

	private UnknownFieldSet _unknownFields;

	public const int HEGNHNFNIOOFieldNumber = 1;

	private static readonly FieldCodec<NEFPAKHFIHB> _repeated_hEGNHNFNIOO_codec = FieldCodec.ForMessage(10u, NEFPAKHFIHB.Parser);

	private readonly RepeatedField<NEFPAKHFIHB> hEGNHNFNIOO_ = new RepeatedField<NEFPAKHFIHB>();

	public const int IIFLBJNMNBOFieldNumber = 5;

	private uint iIFLBJNMNBO_;

	public const int HKCEJCNILFDFieldNumber = 6;

	private static readonly FieldCodec<DDFAFGMLLFD> _repeated_hKCEJCNILFD_codec = FieldCodec.ForMessage(50u, DDFAFGMLLFD.Parser);

	private readonly RepeatedField<DDFAFGMLLFD> hKCEJCNILFD_ = new RepeatedField<DDFAFGMLLFD>();

	public const int DNJEEOENMAAFieldNumber = 8;

	private ulong dNJEEOENMAA_;

	public const int KHOIDDHNNGOFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_kHOIDDHNNGO_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> kHOIDDHNNGO_ = new RepeatedField<uint>();

	public const int CPFOCLCFFJFFieldNumber = 13;

	private uint cPFOCLCFFJF_;

	public const int APDFLLLJABBFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_aPDFLLLJABB_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> aPDFLLLJABB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLEIOFJEAKC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLEIOFJEAKCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NEFPAKHFIHB> HEGNHNFNIOO => hEGNHNFNIOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIFLBJNMNBO
	{
		get
		{
			return iIFLBJNMNBO_;
		}
		set
		{
			iIFLBJNMNBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DDFAFGMLLFD> HKCEJCNILFD => hKCEJCNILFD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong DNJEEOENMAA
	{
		get
		{
			return dNJEEOENMAA_;
		}
		set
		{
			dNJEEOENMAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KHOIDDHNNGO => kHOIDDHNNGO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPFOCLCFFJF
	{
		get
		{
			return cPFOCLCFFJF_;
		}
		set
		{
			cPFOCLCFFJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> APDFLLLJABB => aPDFLLLJABB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLEIOFJEAKC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLEIOFJEAKC(HLEIOFJEAKC other)
		: this()
	{
		hEGNHNFNIOO_ = other.hEGNHNFNIOO_.Clone();
		iIFLBJNMNBO_ = other.iIFLBJNMNBO_;
		hKCEJCNILFD_ = other.hKCEJCNILFD_.Clone();
		dNJEEOENMAA_ = other.dNJEEOENMAA_;
		kHOIDDHNNGO_ = other.kHOIDDHNNGO_.Clone();
		cPFOCLCFFJF_ = other.cPFOCLCFFJF_;
		aPDFLLLJABB_ = other.aPDFLLLJABB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLEIOFJEAKC Clone()
	{
		return new HLEIOFJEAKC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLEIOFJEAKC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLEIOFJEAKC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hEGNHNFNIOO_.Equals(other.hEGNHNFNIOO_))
		{
			return false;
		}
		if (IIFLBJNMNBO != other.IIFLBJNMNBO)
		{
			return false;
		}
		if (!hKCEJCNILFD_.Equals(other.hKCEJCNILFD_))
		{
			return false;
		}
		if (DNJEEOENMAA != other.DNJEEOENMAA)
		{
			return false;
		}
		if (!kHOIDDHNNGO_.Equals(other.kHOIDDHNNGO_))
		{
			return false;
		}
		if (CPFOCLCFFJF != other.CPFOCLCFFJF)
		{
			return false;
		}
		if (!aPDFLLLJABB_.Equals(other.aPDFLLLJABB_))
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
		num ^= hEGNHNFNIOO_.GetHashCode();
		if (IIFLBJNMNBO != 0)
		{
			num ^= IIFLBJNMNBO.GetHashCode();
		}
		num ^= hKCEJCNILFD_.GetHashCode();
		if (DNJEEOENMAA != 0L)
		{
			num ^= DNJEEOENMAA.GetHashCode();
		}
		num ^= kHOIDDHNNGO_.GetHashCode();
		if (CPFOCLCFFJF != 0)
		{
			num ^= CPFOCLCFFJF.GetHashCode();
		}
		num ^= aPDFLLLJABB_.GetHashCode();
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
		hEGNHNFNIOO_.WriteTo(ref output, _repeated_hEGNHNFNIOO_codec);
		if (IIFLBJNMNBO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IIFLBJNMNBO);
		}
		hKCEJCNILFD_.WriteTo(ref output, _repeated_hKCEJCNILFD_codec);
		if (DNJEEOENMAA != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(DNJEEOENMAA);
		}
		kHOIDDHNNGO_.WriteTo(ref output, _repeated_kHOIDDHNNGO_codec);
		if (CPFOCLCFFJF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CPFOCLCFFJF);
		}
		aPDFLLLJABB_.WriteTo(ref output, _repeated_aPDFLLLJABB_codec);
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
		num += hEGNHNFNIOO_.CalculateSize(_repeated_hEGNHNFNIOO_codec);
		if (IIFLBJNMNBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIFLBJNMNBO);
		}
		num += hKCEJCNILFD_.CalculateSize(_repeated_hKCEJCNILFD_codec);
		if (DNJEEOENMAA != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(DNJEEOENMAA);
		}
		num += kHOIDDHNNGO_.CalculateSize(_repeated_kHOIDDHNNGO_codec);
		if (CPFOCLCFFJF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPFOCLCFFJF);
		}
		num += aPDFLLLJABB_.CalculateSize(_repeated_aPDFLLLJABB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLEIOFJEAKC other)
	{
		if (other != null)
		{
			hEGNHNFNIOO_.Add(other.hEGNHNFNIOO_);
			if (other.IIFLBJNMNBO != 0)
			{
				IIFLBJNMNBO = other.IIFLBJNMNBO;
			}
			hKCEJCNILFD_.Add(other.hKCEJCNILFD_);
			if (other.DNJEEOENMAA != 0L)
			{
				DNJEEOENMAA = other.DNJEEOENMAA;
			}
			kHOIDDHNNGO_.Add(other.kHOIDDHNNGO_);
			if (other.CPFOCLCFFJF != 0)
			{
				CPFOCLCFFJF = other.CPFOCLCFFJF;
			}
			aPDFLLLJABB_.Add(other.aPDFLLLJABB_);
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
			case 10u:
				hEGNHNFNIOO_.AddEntriesFrom(ref input, _repeated_hEGNHNFNIOO_codec);
				break;
			case 40u:
				IIFLBJNMNBO = input.ReadUInt32();
				break;
			case 50u:
				hKCEJCNILFD_.AddEntriesFrom(ref input, _repeated_hKCEJCNILFD_codec);
				break;
			case 64u:
				DNJEEOENMAA = input.ReadUInt64();
				break;
			case 80u:
			case 82u:
				kHOIDDHNNGO_.AddEntriesFrom(ref input, _repeated_kHOIDDHNNGO_codec);
				break;
			case 104u:
				CPFOCLCFFJF = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				aPDFLLLJABB_.AddEntriesFrom(ref input, _repeated_aPDFLLLJABB_codec);
				break;
			}
		}
	}
}
