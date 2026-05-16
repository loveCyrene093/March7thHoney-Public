using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOCPKDNGLKM : IMessage<LOCPKDNGLKM>, IMessage, IEquatable<LOCPKDNGLKM>, IDeepCloneable<LOCPKDNGLKM>, IBufferMessage
{
	private static readonly MessageParser<LOCPKDNGLKM> _parser = new MessageParser<LOCPKDNGLKM>(() => new LOCPKDNGLKM());

	private UnknownFieldSet _unknownFields;

	public const int WaveFieldNumber = 1;

	private uint wave_;

	public const int BPMCGKKJGPFFieldNumber = 2;

	private double bPMCGKKJGPF_;

	public const int BNFCAAPABCFFieldNumber = 3;

	private double bNFCAAPABCF_;

	public const int FHOLBJGOPGIFieldNumber = 4;

	private uint fHOLBJGOPGI_;

	public const int DLHLPNLIBAFFieldNumber = 5;

	private uint dLHLPNLIBAF_;

	public const int StatusFieldNumber = 6;

	private uint status_;

	public const int ODIACLIKIFPFieldNumber = 7;

	private uint oDIACLIKIFP_;

	public const int FLMFHDHFIOJFieldNumber = 8;

	private uint fLMFHDHFIOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOCPKDNGLKM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOCPKDNGLKMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BPMCGKKJGPF
	{
		get
		{
			return bPMCGKKJGPF_;
		}
		set
		{
			bPMCGKKJGPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BNFCAAPABCF
	{
		get
		{
			return bNFCAAPABCF_;
		}
		set
		{
			bNFCAAPABCF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHOLBJGOPGI
	{
		get
		{
			return fHOLBJGOPGI_;
		}
		set
		{
			fHOLBJGOPGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DLHLPNLIBAF
	{
		get
		{
			return dLHLPNLIBAF_;
		}
		set
		{
			dLHLPNLIBAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODIACLIKIFP
	{
		get
		{
			return oDIACLIKIFP_;
		}
		set
		{
			oDIACLIKIFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLMFHDHFIOJ
	{
		get
		{
			return fLMFHDHFIOJ_;
		}
		set
		{
			fLMFHDHFIOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOCPKDNGLKM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOCPKDNGLKM(LOCPKDNGLKM other)
		: this()
	{
		wave_ = other.wave_;
		bPMCGKKJGPF_ = other.bPMCGKKJGPF_;
		bNFCAAPABCF_ = other.bNFCAAPABCF_;
		fHOLBJGOPGI_ = other.fHOLBJGOPGI_;
		dLHLPNLIBAF_ = other.dLHLPNLIBAF_;
		status_ = other.status_;
		oDIACLIKIFP_ = other.oDIACLIKIFP_;
		fLMFHDHFIOJ_ = other.fLMFHDHFIOJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOCPKDNGLKM Clone()
	{
		return new LOCPKDNGLKM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOCPKDNGLKM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOCPKDNGLKM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BPMCGKKJGPF, other.BPMCGKKJGPF))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BNFCAAPABCF, other.BNFCAAPABCF))
		{
			return false;
		}
		if (FHOLBJGOPGI != other.FHOLBJGOPGI)
		{
			return false;
		}
		if (DLHLPNLIBAF != other.DLHLPNLIBAF)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (ODIACLIKIFP != other.ODIACLIKIFP)
		{
			return false;
		}
		if (FLMFHDHFIOJ != other.FLMFHDHFIOJ)
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
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (BPMCGKKJGPF != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BPMCGKKJGPF);
		}
		if (BNFCAAPABCF != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BNFCAAPABCF);
		}
		if (FHOLBJGOPGI != 0)
		{
			num ^= FHOLBJGOPGI.GetHashCode();
		}
		if (DLHLPNLIBAF != 0)
		{
			num ^= DLHLPNLIBAF.GetHashCode();
		}
		if (Status != 0)
		{
			num ^= Status.GetHashCode();
		}
		if (ODIACLIKIFP != 0)
		{
			num ^= ODIACLIKIFP.GetHashCode();
		}
		if (FLMFHDHFIOJ != 0)
		{
			num ^= FLMFHDHFIOJ.GetHashCode();
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
		if (Wave != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Wave);
		}
		if (BPMCGKKJGPF != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(BPMCGKKJGPF);
		}
		if (BNFCAAPABCF != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(BNFCAAPABCF);
		}
		if (FHOLBJGOPGI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FHOLBJGOPGI);
		}
		if (DLHLPNLIBAF != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DLHLPNLIBAF);
		}
		if (Status != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Status);
		}
		if (ODIACLIKIFP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ODIACLIKIFP);
		}
		if (FLMFHDHFIOJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FLMFHDHFIOJ);
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
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (BPMCGKKJGPF != 0.0)
		{
			num += 9;
		}
		if (BNFCAAPABCF != 0.0)
		{
			num += 9;
		}
		if (FHOLBJGOPGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHOLBJGOPGI);
		}
		if (DLHLPNLIBAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DLHLPNLIBAF);
		}
		if (Status != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Status);
		}
		if (ODIACLIKIFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODIACLIKIFP);
		}
		if (FLMFHDHFIOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLMFHDHFIOJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOCPKDNGLKM other)
	{
		if (other != null)
		{
			if (other.Wave != 0)
			{
				Wave = other.Wave;
			}
			if (other.BPMCGKKJGPF != 0.0)
			{
				BPMCGKKJGPF = other.BPMCGKKJGPF;
			}
			if (other.BNFCAAPABCF != 0.0)
			{
				BNFCAAPABCF = other.BNFCAAPABCF;
			}
			if (other.FHOLBJGOPGI != 0)
			{
				FHOLBJGOPGI = other.FHOLBJGOPGI;
			}
			if (other.DLHLPNLIBAF != 0)
			{
				DLHLPNLIBAF = other.DLHLPNLIBAF;
			}
			if (other.Status != 0)
			{
				Status = other.Status;
			}
			if (other.ODIACLIKIFP != 0)
			{
				ODIACLIKIFP = other.ODIACLIKIFP;
			}
			if (other.FLMFHDHFIOJ != 0)
			{
				FLMFHDHFIOJ = other.FLMFHDHFIOJ;
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
			case 8u:
				Wave = input.ReadUInt32();
				break;
			case 17u:
				BPMCGKKJGPF = input.ReadDouble();
				break;
			case 25u:
				BNFCAAPABCF = input.ReadDouble();
				break;
			case 32u:
				FHOLBJGOPGI = input.ReadUInt32();
				break;
			case 40u:
				DLHLPNLIBAF = input.ReadUInt32();
				break;
			case 48u:
				Status = input.ReadUInt32();
				break;
			case 56u:
				ODIACLIKIFP = input.ReadUInt32();
				break;
			case 64u:
				FLMFHDHFIOJ = input.ReadUInt32();
				break;
			}
		}
	}
}
