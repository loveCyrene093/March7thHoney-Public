using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMDPAIOOHMF : IMessage<IMDPAIOOHMF>, IMessage, IEquatable<IMDPAIOOHMF>, IDeepCloneable<IMDPAIOOHMF>, IBufferMessage
{
	private static readonly MessageParser<IMDPAIOOHMF> _parser = new MessageParser<IMDPAIOOHMF>(() => new IMDPAIOOHMF());

	private UnknownFieldSet _unknownFields;

	public const int LCPIODCLNHLFieldNumber = 2;

	private static readonly FieldCodec<AAHBECICOEN> _repeated_lCPIODCLNHL_codec = FieldCodec.ForMessage(18u, AAHBECICOEN.Parser);

	private readonly RepeatedField<AAHBECICOEN> lCPIODCLNHL_ = new RepeatedField<AAHBECICOEN>();

	public const int AFCAOBEBOMHFieldNumber = 4;

	private uint aFCAOBEBOMH_;

	public const int LJHDOFBFNJHFieldNumber = 10;

	private AAHBECICOEN lJHDOFBFNJH_;

	public const int FPLDAKNALKLFieldNumber = 12;

	private uint fPLDAKNALKL_;

	public const int PGIHGNOLIOIFieldNumber = 13;

	private static readonly FieldCodec<AAHBECICOEN> _repeated_pGIHGNOLIOI_codec = FieldCodec.ForMessage(106u, AAHBECICOEN.Parser);

	private readonly RepeatedField<AAHBECICOEN> pGIHGNOLIOI_ = new RepeatedField<AAHBECICOEN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMDPAIOOHMF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IMDPAIOOHMFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AAHBECICOEN> LCPIODCLNHL => lCPIODCLNHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFCAOBEBOMH
	{
		get
		{
			return aFCAOBEBOMH_;
		}
		set
		{
			aFCAOBEBOMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHBECICOEN LJHDOFBFNJH
	{
		get
		{
			return lJHDOFBFNJH_;
		}
		set
		{
			lJHDOFBFNJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPLDAKNALKL
	{
		get
		{
			return fPLDAKNALKL_;
		}
		set
		{
			fPLDAKNALKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AAHBECICOEN> PGIHGNOLIOI => pGIHGNOLIOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMDPAIOOHMF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMDPAIOOHMF(IMDPAIOOHMF other)
		: this()
	{
		lCPIODCLNHL_ = other.lCPIODCLNHL_.Clone();
		aFCAOBEBOMH_ = other.aFCAOBEBOMH_;
		lJHDOFBFNJH_ = ((other.lJHDOFBFNJH_ != null) ? other.lJHDOFBFNJH_.Clone() : null);
		fPLDAKNALKL_ = other.fPLDAKNALKL_;
		pGIHGNOLIOI_ = other.pGIHGNOLIOI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMDPAIOOHMF Clone()
	{
		return new IMDPAIOOHMF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IMDPAIOOHMF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IMDPAIOOHMF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lCPIODCLNHL_.Equals(other.lCPIODCLNHL_))
		{
			return false;
		}
		if (AFCAOBEBOMH != other.AFCAOBEBOMH)
		{
			return false;
		}
		if (!object.Equals(LJHDOFBFNJH, other.LJHDOFBFNJH))
		{
			return false;
		}
		if (FPLDAKNALKL != other.FPLDAKNALKL)
		{
			return false;
		}
		if (!pGIHGNOLIOI_.Equals(other.pGIHGNOLIOI_))
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
		num ^= lCPIODCLNHL_.GetHashCode();
		if (AFCAOBEBOMH != 0)
		{
			num ^= AFCAOBEBOMH.GetHashCode();
		}
		if (lJHDOFBFNJH_ != null)
		{
			num ^= LJHDOFBFNJH.GetHashCode();
		}
		if (FPLDAKNALKL != 0)
		{
			num ^= FPLDAKNALKL.GetHashCode();
		}
		num ^= pGIHGNOLIOI_.GetHashCode();
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
		lCPIODCLNHL_.WriteTo(ref output, _repeated_lCPIODCLNHL_codec);
		if (AFCAOBEBOMH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AFCAOBEBOMH);
		}
		if (lJHDOFBFNJH_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LJHDOFBFNJH);
		}
		if (FPLDAKNALKL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FPLDAKNALKL);
		}
		pGIHGNOLIOI_.WriteTo(ref output, _repeated_pGIHGNOLIOI_codec);
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
		num += lCPIODCLNHL_.CalculateSize(_repeated_lCPIODCLNHL_codec);
		if (AFCAOBEBOMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFCAOBEBOMH);
		}
		if (lJHDOFBFNJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJHDOFBFNJH);
		}
		if (FPLDAKNALKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPLDAKNALKL);
		}
		num += pGIHGNOLIOI_.CalculateSize(_repeated_pGIHGNOLIOI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IMDPAIOOHMF other)
	{
		if (other == null)
		{
			return;
		}
		lCPIODCLNHL_.Add(other.lCPIODCLNHL_);
		if (other.AFCAOBEBOMH != 0)
		{
			AFCAOBEBOMH = other.AFCAOBEBOMH;
		}
		if (other.lJHDOFBFNJH_ != null)
		{
			if (lJHDOFBFNJH_ == null)
			{
				LJHDOFBFNJH = new AAHBECICOEN();
			}
			LJHDOFBFNJH.MergeFrom(other.LJHDOFBFNJH);
		}
		if (other.FPLDAKNALKL != 0)
		{
			FPLDAKNALKL = other.FPLDAKNALKL;
		}
		pGIHGNOLIOI_.Add(other.pGIHGNOLIOI_);
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
			case 18u:
				lCPIODCLNHL_.AddEntriesFrom(ref input, _repeated_lCPIODCLNHL_codec);
				break;
			case 32u:
				AFCAOBEBOMH = input.ReadUInt32();
				break;
			case 82u:
				if (lJHDOFBFNJH_ == null)
				{
					LJHDOFBFNJH = new AAHBECICOEN();
				}
				input.ReadMessage(LJHDOFBFNJH);
				break;
			case 96u:
				FPLDAKNALKL = input.ReadUInt32();
				break;
			case 106u:
				pGIHGNOLIOI_.AddEntriesFrom(ref input, _repeated_pGIHGNOLIOI_codec);
				break;
			}
		}
	}
}
