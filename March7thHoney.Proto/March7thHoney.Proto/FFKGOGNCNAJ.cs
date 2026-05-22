using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFKGOGNCNAJ : IMessage<FFKGOGNCNAJ>, IMessage, IEquatable<FFKGOGNCNAJ>, IDeepCloneable<FFKGOGNCNAJ>, IBufferMessage
{
	private static readonly MessageParser<FFKGOGNCNAJ> _parser = new MessageParser<FFKGOGNCNAJ>(() => new FFKGOGNCNAJ());

	private UnknownFieldSet _unknownFields;

	public const int BuffIdFieldNumber = 2;

	private uint buffId_;

	public const int HAFFDDDPFGAFieldNumber = 5;

	private uint hAFFDDDPFGA_;

	public const int DKJDNNKMNGFFieldNumber = 10;

	private uint dKJDNNKMNGF_;

	public const int CJOPNFDBJHDFieldNumber = 13;

	private uint cJOPNFDBJHD_;

	public const int CHPHBCOKCEOFieldNumber = 14;

	private uint cHPHBCOKCEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFKGOGNCNAJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFKGOGNCNAJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAFFDDDPFGA
	{
		get
		{
			return hAFFDDDPFGA_;
		}
		set
		{
			hAFFDDDPFGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKJDNNKMNGF
	{
		get
		{
			return dKJDNNKMNGF_;
		}
		set
		{
			dKJDNNKMNGF_ = value;
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
	public uint CHPHBCOKCEO
	{
		get
		{
			return cHPHBCOKCEO_;
		}
		set
		{
			cHPHBCOKCEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFKGOGNCNAJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFKGOGNCNAJ(FFKGOGNCNAJ other)
		: this()
	{
		buffId_ = other.buffId_;
		hAFFDDDPFGA_ = other.hAFFDDDPFGA_;
		dKJDNNKMNGF_ = other.dKJDNNKMNGF_;
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		cHPHBCOKCEO_ = other.cHPHBCOKCEO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFKGOGNCNAJ Clone()
	{
		return new FFKGOGNCNAJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFKGOGNCNAJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFKGOGNCNAJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (HAFFDDDPFGA != other.HAFFDDDPFGA)
		{
			return false;
		}
		if (DKJDNNKMNGF != other.DKJDNNKMNGF)
		{
			return false;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
		{
			return false;
		}
		if (CHPHBCOKCEO != other.CHPHBCOKCEO)
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
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (HAFFDDDPFGA != 0)
		{
			num ^= HAFFDDDPFGA.GetHashCode();
		}
		if (DKJDNNKMNGF != 0)
		{
			num ^= DKJDNNKMNGF.GetHashCode();
		}
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
		}
		if (CHPHBCOKCEO != 0)
		{
			num ^= CHPHBCOKCEO.GetHashCode();
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
		if (BuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BuffId);
		}
		if (HAFFDDDPFGA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HAFFDDDPFGA);
		}
		if (DKJDNNKMNGF != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DKJDNNKMNGF);
		}
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CJOPNFDBJHD);
		}
		if (CHPHBCOKCEO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CHPHBCOKCEO);
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
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (HAFFDDDPFGA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAFFDDDPFGA);
		}
		if (DKJDNNKMNGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKJDNNKMNGF);
		}
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		if (CHPHBCOKCEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHPHBCOKCEO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FFKGOGNCNAJ other)
	{
		if (other != null)
		{
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.HAFFDDDPFGA != 0)
			{
				HAFFDDDPFGA = other.HAFFDDDPFGA;
			}
			if (other.DKJDNNKMNGF != 0)
			{
				DKJDNNKMNGF = other.DKJDNNKMNGF;
			}
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			if (other.CHPHBCOKCEO != 0)
			{
				CHPHBCOKCEO = other.CHPHBCOKCEO;
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
			case 16u:
				BuffId = input.ReadUInt32();
				break;
			case 40u:
				HAFFDDDPFGA = input.ReadUInt32();
				break;
			case 80u:
				DKJDNNKMNGF = input.ReadUInt32();
				break;
			case 104u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			case 112u:
				CHPHBCOKCEO = input.ReadUInt32();
				break;
			}
		}
	}
}
