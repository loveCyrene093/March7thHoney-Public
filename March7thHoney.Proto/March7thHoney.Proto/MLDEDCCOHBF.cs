using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MLDEDCCOHBF : IMessage<MLDEDCCOHBF>, IMessage, IEquatable<MLDEDCCOHBF>, IDeepCloneable<MLDEDCCOHBF>, IBufferMessage
{
	private static readonly MessageParser<MLDEDCCOHBF> _parser = new MessageParser<MLDEDCCOHBF>(() => new MLDEDCCOHBF());

	private UnknownFieldSet _unknownFields;

	public const int HAEEJBFFKGFFieldNumber = 1;

	private static readonly MapField<uint, uint>.Codec _map_hAEEJBFFKGF_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 10u);

	private readonly MapField<uint, uint> hAEEJBFFKGF_ = new MapField<uint, uint>();

	public const int FHKINAKGBBKFieldNumber = 2;

	private uint fHKINAKGBBK_;

	public const int OFNDICJJCIOFieldNumber = 3;

	private uint oFNDICJJCIO_;

	public const int PHPFBNJOONPFieldNumber = 4;

	private uint pHPFBNJOONP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MLDEDCCOHBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MLDEDCCOHBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> HAEEJBFFKGF => hAEEJBFFKGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHKINAKGBBK
	{
		get
		{
			return fHKINAKGBBK_;
		}
		set
		{
			fHKINAKGBBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFNDICJJCIO
	{
		get
		{
			return oFNDICJJCIO_;
		}
		set
		{
			oFNDICJJCIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHPFBNJOONP
	{
		get
		{
			return pHPFBNJOONP_;
		}
		set
		{
			pHPFBNJOONP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLDEDCCOHBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLDEDCCOHBF(MLDEDCCOHBF other)
		: this()
	{
		hAEEJBFFKGF_ = other.hAEEJBFFKGF_.Clone();
		fHKINAKGBBK_ = other.fHKINAKGBBK_;
		oFNDICJJCIO_ = other.oFNDICJJCIO_;
		pHPFBNJOONP_ = other.pHPFBNJOONP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLDEDCCOHBF Clone()
	{
		return new MLDEDCCOHBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MLDEDCCOHBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MLDEDCCOHBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!HAEEJBFFKGF.Equals(other.HAEEJBFFKGF))
		{
			return false;
		}
		if (FHKINAKGBBK != other.FHKINAKGBBK)
		{
			return false;
		}
		if (OFNDICJJCIO != other.OFNDICJJCIO)
		{
			return false;
		}
		if (PHPFBNJOONP != other.PHPFBNJOONP)
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
		num ^= HAEEJBFFKGF.GetHashCode();
		if (FHKINAKGBBK != 0)
		{
			num ^= FHKINAKGBBK.GetHashCode();
		}
		if (OFNDICJJCIO != 0)
		{
			num ^= OFNDICJJCIO.GetHashCode();
		}
		if (PHPFBNJOONP != 0)
		{
			num ^= PHPFBNJOONP.GetHashCode();
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
		hAEEJBFFKGF_.WriteTo(ref output, _map_hAEEJBFFKGF_codec);
		if (FHKINAKGBBK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FHKINAKGBBK);
		}
		if (OFNDICJJCIO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OFNDICJJCIO);
		}
		if (PHPFBNJOONP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PHPFBNJOONP);
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
		num += hAEEJBFFKGF_.CalculateSize(_map_hAEEJBFFKGF_codec);
		if (FHKINAKGBBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHKINAKGBBK);
		}
		if (OFNDICJJCIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFNDICJJCIO);
		}
		if (PHPFBNJOONP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHPFBNJOONP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MLDEDCCOHBF other)
	{
		if (other != null)
		{
			hAEEJBFFKGF_.MergeFrom(other.hAEEJBFFKGF_);
			if (other.FHKINAKGBBK != 0)
			{
				FHKINAKGBBK = other.FHKINAKGBBK;
			}
			if (other.OFNDICJJCIO != 0)
			{
				OFNDICJJCIO = other.OFNDICJJCIO;
			}
			if (other.PHPFBNJOONP != 0)
			{
				PHPFBNJOONP = other.PHPFBNJOONP;
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
			case 10u:
				hAEEJBFFKGF_.AddEntriesFrom(ref input, _map_hAEEJBFFKGF_codec);
				break;
			case 16u:
				FHKINAKGBBK = input.ReadUInt32();
				break;
			case 24u:
				OFNDICJJCIO = input.ReadUInt32();
				break;
			case 32u:
				PHPFBNJOONP = input.ReadUInt32();
				break;
			}
		}
	}
}
