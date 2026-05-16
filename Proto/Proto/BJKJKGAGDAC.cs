using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJKJKGAGDAC : IMessage<BJKJKGAGDAC>, IMessage, IEquatable<BJKJKGAGDAC>, IDeepCloneable<BJKJKGAGDAC>, IBufferMessage
{
	private static readonly MessageParser<BJKJKGAGDAC> _parser = new MessageParser<BJKJKGAGDAC>(() => new BJKJKGAGDAC());

	private UnknownFieldSet _unknownFields;

	public const int DBBAEOHIAPAFieldNumber = 1;

	private uint dBBAEOHIAPA_;

	public const int GBOCDPDNFLFFieldNumber = 2;

	private uint gBOCDPDNFLF_;

	public const int IBLNHMFCLPPFieldNumber = 4;

	private uint iBLNHMFCLPP_;

	public const int DIOGJKODMPKFieldNumber = 5;

	private uint dIOGJKODMPK_;

	public const int DOBENIECLNNFieldNumber = 7;

	private uint dOBENIECLNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJKJKGAGDAC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJKJKGAGDACReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBBAEOHIAPA
	{
		get
		{
			return dBBAEOHIAPA_;
		}
		set
		{
			dBBAEOHIAPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBOCDPDNFLF
	{
		get
		{
			return gBOCDPDNFLF_;
		}
		set
		{
			gBOCDPDNFLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBLNHMFCLPP
	{
		get
		{
			return iBLNHMFCLPP_;
		}
		set
		{
			iBLNHMFCLPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DIOGJKODMPK
	{
		get
		{
			return dIOGJKODMPK_;
		}
		set
		{
			dIOGJKODMPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOBENIECLNN
	{
		get
		{
			return dOBENIECLNN_;
		}
		set
		{
			dOBENIECLNN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJKJKGAGDAC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJKJKGAGDAC(BJKJKGAGDAC other)
		: this()
	{
		dBBAEOHIAPA_ = other.dBBAEOHIAPA_;
		gBOCDPDNFLF_ = other.gBOCDPDNFLF_;
		iBLNHMFCLPP_ = other.iBLNHMFCLPP_;
		dIOGJKODMPK_ = other.dIOGJKODMPK_;
		dOBENIECLNN_ = other.dOBENIECLNN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJKJKGAGDAC Clone()
	{
		return new BJKJKGAGDAC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJKJKGAGDAC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJKJKGAGDAC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DBBAEOHIAPA != other.DBBAEOHIAPA)
		{
			return false;
		}
		if (GBOCDPDNFLF != other.GBOCDPDNFLF)
		{
			return false;
		}
		if (IBLNHMFCLPP != other.IBLNHMFCLPP)
		{
			return false;
		}
		if (DIOGJKODMPK != other.DIOGJKODMPK)
		{
			return false;
		}
		if (DOBENIECLNN != other.DOBENIECLNN)
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
		if (DBBAEOHIAPA != 0)
		{
			num ^= DBBAEOHIAPA.GetHashCode();
		}
		if (GBOCDPDNFLF != 0)
		{
			num ^= GBOCDPDNFLF.GetHashCode();
		}
		if (IBLNHMFCLPP != 0)
		{
			num ^= IBLNHMFCLPP.GetHashCode();
		}
		if (DIOGJKODMPK != 0)
		{
			num ^= DIOGJKODMPK.GetHashCode();
		}
		if (DOBENIECLNN != 0)
		{
			num ^= DOBENIECLNN.GetHashCode();
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
		if (DBBAEOHIAPA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DBBAEOHIAPA);
		}
		if (GBOCDPDNFLF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GBOCDPDNFLF);
		}
		if (IBLNHMFCLPP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IBLNHMFCLPP);
		}
		if (DIOGJKODMPK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DIOGJKODMPK);
		}
		if (DOBENIECLNN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DOBENIECLNN);
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
		if (DBBAEOHIAPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBBAEOHIAPA);
		}
		if (GBOCDPDNFLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBOCDPDNFLF);
		}
		if (IBLNHMFCLPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBLNHMFCLPP);
		}
		if (DIOGJKODMPK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DIOGJKODMPK);
		}
		if (DOBENIECLNN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOBENIECLNN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJKJKGAGDAC other)
	{
		if (other != null)
		{
			if (other.DBBAEOHIAPA != 0)
			{
				DBBAEOHIAPA = other.DBBAEOHIAPA;
			}
			if (other.GBOCDPDNFLF != 0)
			{
				GBOCDPDNFLF = other.GBOCDPDNFLF;
			}
			if (other.IBLNHMFCLPP != 0)
			{
				IBLNHMFCLPP = other.IBLNHMFCLPP;
			}
			if (other.DIOGJKODMPK != 0)
			{
				DIOGJKODMPK = other.DIOGJKODMPK;
			}
			if (other.DOBENIECLNN != 0)
			{
				DOBENIECLNN = other.DOBENIECLNN;
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
				DBBAEOHIAPA = input.ReadUInt32();
				break;
			case 16u:
				GBOCDPDNFLF = input.ReadUInt32();
				break;
			case 32u:
				IBLNHMFCLPP = input.ReadUInt32();
				break;
			case 40u:
				DIOGJKODMPK = input.ReadUInt32();
				break;
			case 56u:
				DOBENIECLNN = input.ReadUInt32();
				break;
			}
		}
	}
}
