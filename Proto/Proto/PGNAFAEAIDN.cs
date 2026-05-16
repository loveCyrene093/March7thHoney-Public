using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGNAFAEAIDN : IMessage<PGNAFAEAIDN>, IMessage, IEquatable<PGNAFAEAIDN>, IDeepCloneable<PGNAFAEAIDN>, IBufferMessage
{
	private static readonly MessageParser<PGNAFAEAIDN> _parser = new MessageParser<PGNAFAEAIDN>(() => new PGNAFAEAIDN());

	private UnknownFieldSet _unknownFields;

	public const int HLKAFPCLMEOFieldNumber = 2;

	private bool hLKAFPCLMEO_;

	public const int GGFIJFDFGCMFieldNumber = 3;

	private bool gGFIJFDFGCM_;

	public const int CJOPNFDBJHDFieldNumber = 8;

	private uint cJOPNFDBJHD_;

	public const int IMLOEHHAJOIFieldNumber = 10;

	private bool iMLOEHHAJOI_;

	public const int PGHPKHCNPMFFieldNumber = 11;

	private uint pGHPKHCNPMF_;

	public const int JJNKPCBKOKBFieldNumber = 13;

	private uint jJNKPCBKOKB_;

	public const int KLONCIGADNIFieldNumber = 15;

	private bool kLONCIGADNI_;

	public const int BuffListFieldNumber = 1748;

	private static readonly FieldCodec<FFKGOGNCNAJ> _repeated_buffList_codec = FieldCodec.ForMessage(13986u, FFKGOGNCNAJ.Parser);

	private readonly RepeatedField<FFKGOGNCNAJ> buffList_ = new RepeatedField<FFKGOGNCNAJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGNAFAEAIDN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGNAFAEAIDNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HLKAFPCLMEO
	{
		get
		{
			return hLKAFPCLMEO_;
		}
		set
		{
			hLKAFPCLMEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GGFIJFDFGCM
	{
		get
		{
			return gGFIJFDFGCM_;
		}
		set
		{
			gGFIJFDFGCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJOPNFDBJHD
	{
		get
		{
			return cJOPNFDBJHD_;
		}
		set
		{
			cJOPNFDBJHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IMLOEHHAJOI
	{
		get
		{
			return iMLOEHHAJOI_;
		}
		set
		{
			iMLOEHHAJOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGHPKHCNPMF
	{
		get
		{
			return pGHPKHCNPMF_;
		}
		set
		{
			pGHPKHCNPMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJNKPCBKOKB
	{
		get
		{
			return jJNKPCBKOKB_;
		}
		set
		{
			jJNKPCBKOKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KLONCIGADNI
	{
		get
		{
			return kLONCIGADNI_;
		}
		set
		{
			kLONCIGADNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FFKGOGNCNAJ> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGNAFAEAIDN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGNAFAEAIDN(PGNAFAEAIDN other)
		: this()
	{
		hLKAFPCLMEO_ = other.hLKAFPCLMEO_;
		gGFIJFDFGCM_ = other.gGFIJFDFGCM_;
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		iMLOEHHAJOI_ = other.iMLOEHHAJOI_;
		pGHPKHCNPMF_ = other.pGHPKHCNPMF_;
		jJNKPCBKOKB_ = other.jJNKPCBKOKB_;
		kLONCIGADNI_ = other.kLONCIGADNI_;
		buffList_ = other.buffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGNAFAEAIDN Clone()
	{
		return new PGNAFAEAIDN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGNAFAEAIDN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGNAFAEAIDN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HLKAFPCLMEO != other.HLKAFPCLMEO)
		{
			return false;
		}
		if (GGFIJFDFGCM != other.GGFIJFDFGCM)
		{
			return false;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
		{
			return false;
		}
		if (IMLOEHHAJOI != other.IMLOEHHAJOI)
		{
			return false;
		}
		if (PGHPKHCNPMF != other.PGHPKHCNPMF)
		{
			return false;
		}
		if (JJNKPCBKOKB != other.JJNKPCBKOKB)
		{
			return false;
		}
		if (KLONCIGADNI != other.KLONCIGADNI)
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
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
		if (HLKAFPCLMEO)
		{
			num ^= HLKAFPCLMEO.GetHashCode();
		}
		if (GGFIJFDFGCM)
		{
			num ^= GGFIJFDFGCM.GetHashCode();
		}
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
		}
		if (IMLOEHHAJOI)
		{
			num ^= IMLOEHHAJOI.GetHashCode();
		}
		if (PGHPKHCNPMF != 0)
		{
			num ^= PGHPKHCNPMF.GetHashCode();
		}
		if (JJNKPCBKOKB != 0)
		{
			num ^= JJNKPCBKOKB.GetHashCode();
		}
		if (KLONCIGADNI)
		{
			num ^= KLONCIGADNI.GetHashCode();
		}
		num ^= buffList_.GetHashCode();
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
		if (HLKAFPCLMEO)
		{
			output.WriteRawTag(16);
			output.WriteBool(HLKAFPCLMEO);
		}
		if (GGFIJFDFGCM)
		{
			output.WriteRawTag(24);
			output.WriteBool(GGFIJFDFGCM);
		}
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CJOPNFDBJHD);
		}
		if (IMLOEHHAJOI)
		{
			output.WriteRawTag(80);
			output.WriteBool(IMLOEHHAJOI);
		}
		if (PGHPKHCNPMF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PGHPKHCNPMF);
		}
		if (JJNKPCBKOKB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JJNKPCBKOKB);
		}
		if (KLONCIGADNI)
		{
			output.WriteRawTag(120);
			output.WriteBool(KLONCIGADNI);
		}
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
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
		if (HLKAFPCLMEO)
		{
			num += 2;
		}
		if (GGFIJFDFGCM)
		{
			num += 2;
		}
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		if (IMLOEHHAJOI)
		{
			num += 2;
		}
		if (PGHPKHCNPMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGHPKHCNPMF);
		}
		if (JJNKPCBKOKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJNKPCBKOKB);
		}
		if (KLONCIGADNI)
		{
			num += 2;
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGNAFAEAIDN other)
	{
		if (other != null)
		{
			if (other.HLKAFPCLMEO)
			{
				HLKAFPCLMEO = other.HLKAFPCLMEO;
			}
			if (other.GGFIJFDFGCM)
			{
				GGFIJFDFGCM = other.GGFIJFDFGCM;
			}
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			if (other.IMLOEHHAJOI)
			{
				IMLOEHHAJOI = other.IMLOEHHAJOI;
			}
			if (other.PGHPKHCNPMF != 0)
			{
				PGHPKHCNPMF = other.PGHPKHCNPMF;
			}
			if (other.JJNKPCBKOKB != 0)
			{
				JJNKPCBKOKB = other.JJNKPCBKOKB;
			}
			if (other.KLONCIGADNI)
			{
				KLONCIGADNI = other.KLONCIGADNI;
			}
			buffList_.Add(other.buffList_);
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
			case 16u:
				HLKAFPCLMEO = input.ReadBool();
				break;
			case 24u:
				GGFIJFDFGCM = input.ReadBool();
				break;
			case 64u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			case 80u:
				IMLOEHHAJOI = input.ReadBool();
				break;
			case 88u:
				PGHPKHCNPMF = input.ReadUInt32();
				break;
			case 104u:
				JJNKPCBKOKB = input.ReadUInt32();
				break;
			case 120u:
				KLONCIGADNI = input.ReadBool();
				break;
			case 13986u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			}
		}
	}
}
