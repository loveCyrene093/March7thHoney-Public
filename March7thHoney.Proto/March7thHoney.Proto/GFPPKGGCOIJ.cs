using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFPPKGGCOIJ : IMessage<GFPPKGGCOIJ>, IMessage, IEquatable<GFPPKGGCOIJ>, IDeepCloneable<GFPPKGGCOIJ>, IBufferMessage
{
	private static readonly MessageParser<GFPPKGGCOIJ> _parser = new MessageParser<GFPPKGGCOIJ>(() => new GFPPKGGCOIJ());

	private UnknownFieldSet _unknownFields;

	public const int EJALOMHNGCJFieldNumber = 3;

	private uint eJALOMHNGCJ_;

	public const int MMINJCFNADKFieldNumber = 9;

	private uint mMINJCFNADK_;

	public const int OFHCNGHJFHIFieldNumber = 10;

	private uint oFHCNGHJFHI_;

	public const int COLDNELLIIEFieldNumber = 12;

	private static readonly FieldCodec<EIPPGFCFJEO> _repeated_cOLDNELLIIE_codec = FieldCodec.ForMessage(98u, EIPPGFCFJEO.Parser);

	private readonly RepeatedField<EIPPGFCFJEO> cOLDNELLIIE_ = new RepeatedField<EIPPGFCFJEO>();

	public const int CLAHGLGKBEEFieldNumber = 14;

	private EIPPGFCFJEO cLAHGLGKBEE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFPPKGGCOIJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFPPKGGCOIJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJALOMHNGCJ
	{
		get
		{
			return eJALOMHNGCJ_;
		}
		set
		{
			eJALOMHNGCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMINJCFNADK
	{
		get
		{
			return mMINJCFNADK_;
		}
		set
		{
			mMINJCFNADK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EIPPGFCFJEO> COLDNELLIIE => cOLDNELLIIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIPPGFCFJEO CLAHGLGKBEE
	{
		get
		{
			return cLAHGLGKBEE_;
		}
		set
		{
			cLAHGLGKBEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ(GFPPKGGCOIJ other)
		: this()
	{
		eJALOMHNGCJ_ = other.eJALOMHNGCJ_;
		mMINJCFNADK_ = other.mMINJCFNADK_;
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		cOLDNELLIIE_ = other.cOLDNELLIIE_.Clone();
		cLAHGLGKBEE_ = ((other.cLAHGLGKBEE_ != null) ? other.cLAHGLGKBEE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFPPKGGCOIJ Clone()
	{
		return new GFPPKGGCOIJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFPPKGGCOIJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFPPKGGCOIJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EJALOMHNGCJ != other.EJALOMHNGCJ)
		{
			return false;
		}
		if (MMINJCFNADK != other.MMINJCFNADK)
		{
			return false;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (!cOLDNELLIIE_.Equals(other.cOLDNELLIIE_))
		{
			return false;
		}
		if (!object.Equals(CLAHGLGKBEE, other.CLAHGLGKBEE))
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
		if (EJALOMHNGCJ != 0)
		{
			num ^= EJALOMHNGCJ.GetHashCode();
		}
		if (MMINJCFNADK != 0)
		{
			num ^= MMINJCFNADK.GetHashCode();
		}
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		num ^= cOLDNELLIIE_.GetHashCode();
		if (cLAHGLGKBEE_ != null)
		{
			num ^= CLAHGLGKBEE.GetHashCode();
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
		if (EJALOMHNGCJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EJALOMHNGCJ);
		}
		if (MMINJCFNADK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MMINJCFNADK);
		}
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		cOLDNELLIIE_.WriteTo(ref output, _repeated_cOLDNELLIIE_codec);
		if (cLAHGLGKBEE_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CLAHGLGKBEE);
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
		if (EJALOMHNGCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJALOMHNGCJ);
		}
		if (MMINJCFNADK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMINJCFNADK);
		}
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		num += cOLDNELLIIE_.CalculateSize(_repeated_cOLDNELLIIE_codec);
		if (cLAHGLGKBEE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CLAHGLGKBEE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFPPKGGCOIJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EJALOMHNGCJ != 0)
		{
			EJALOMHNGCJ = other.EJALOMHNGCJ;
		}
		if (other.MMINJCFNADK != 0)
		{
			MMINJCFNADK = other.MMINJCFNADK;
		}
		if (other.OFHCNGHJFHI != 0)
		{
			OFHCNGHJFHI = other.OFHCNGHJFHI;
		}
		cOLDNELLIIE_.Add(other.cOLDNELLIIE_);
		if (other.cLAHGLGKBEE_ != null)
		{
			if (cLAHGLGKBEE_ == null)
			{
				CLAHGLGKBEE = new EIPPGFCFJEO();
			}
			CLAHGLGKBEE.MergeFrom(other.CLAHGLGKBEE);
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
			case 24u:
				EJALOMHNGCJ = input.ReadUInt32();
				break;
			case 72u:
				MMINJCFNADK = input.ReadUInt32();
				break;
			case 80u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 98u:
				cOLDNELLIIE_.AddEntriesFrom(ref input, _repeated_cOLDNELLIIE_codec);
				break;
			case 114u:
				if (cLAHGLGKBEE_ == null)
				{
					CLAHGLGKBEE = new EIPPGFCFJEO();
				}
				input.ReadMessage(CLAHGLGKBEE);
				break;
			}
		}
	}
}
