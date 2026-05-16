using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFNFHIAEKIN : IMessage<KFNFHIAEKIN>, IMessage, IEquatable<KFNFHIAEKIN>, IDeepCloneable<KFNFHIAEKIN>, IBufferMessage
{
	private static readonly MessageParser<KFNFHIAEKIN> _parser = new MessageParser<KFNFHIAEKIN>(() => new KFNFHIAEKIN());

	private UnknownFieldSet _unknownFields;

	public const int FPOIEFHOHINFieldNumber = 2;

	private uint fPOIEFHOHIN_;

	public const int NEBPANIDIMGFieldNumber = 3;

	private static readonly FieldCodec<EPLIGJEGEMJ> _repeated_nEBPANIDIMG_codec = FieldCodec.ForMessage(26u, EPLIGJEGEMJ.Parser);

	private readonly RepeatedField<EPLIGJEGEMJ> nEBPANIDIMG_ = new RepeatedField<EPLIGJEGEMJ>();

	public const int EFGGDDEALGMFieldNumber = 5;

	private static readonly FieldCodec<EPLIGJEGEMJ> _repeated_eFGGDDEALGM_codec = FieldCodec.ForMessage(42u, EPLIGJEGEMJ.Parser);

	private readonly RepeatedField<EPLIGJEGEMJ> eFGGDDEALGM_ = new RepeatedField<EPLIGJEGEMJ>();

	public const int TotalDamageFieldNumber = 7;

	private double totalDamage_;

	public const int AKABDDGNLCPFieldNumber = 9;

	private uint aKABDDGNLCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFNFHIAEKIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFNFHIAEKINReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPOIEFHOHIN
	{
		get
		{
			return fPOIEFHOHIN_;
		}
		set
		{
			fPOIEFHOHIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPLIGJEGEMJ> NEBPANIDIMG => nEBPANIDIMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPLIGJEGEMJ> EFGGDDEALGM => eFGGDDEALGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKABDDGNLCP
	{
		get
		{
			return aKABDDGNLCP_;
		}
		set
		{
			aKABDDGNLCP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFNFHIAEKIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFNFHIAEKIN(KFNFHIAEKIN other)
		: this()
	{
		fPOIEFHOHIN_ = other.fPOIEFHOHIN_;
		nEBPANIDIMG_ = other.nEBPANIDIMG_.Clone();
		eFGGDDEALGM_ = other.eFGGDDEALGM_.Clone();
		totalDamage_ = other.totalDamage_;
		aKABDDGNLCP_ = other.aKABDDGNLCP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFNFHIAEKIN Clone()
	{
		return new KFNFHIAEKIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFNFHIAEKIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFNFHIAEKIN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FPOIEFHOHIN != other.FPOIEFHOHIN)
		{
			return false;
		}
		if (!nEBPANIDIMG_.Equals(other.nEBPANIDIMG_))
		{
			return false;
		}
		if (!eFGGDDEALGM_.Equals(other.eFGGDDEALGM_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
		{
			return false;
		}
		if (AKABDDGNLCP != other.AKABDDGNLCP)
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
		if (FPOIEFHOHIN != 0)
		{
			num ^= FPOIEFHOHIN.GetHashCode();
		}
		num ^= nEBPANIDIMG_.GetHashCode();
		num ^= eFGGDDEALGM_.GetHashCode();
		if (TotalDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamage);
		}
		if (AKABDDGNLCP != 0)
		{
			num ^= AKABDDGNLCP.GetHashCode();
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
		if (FPOIEFHOHIN != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FPOIEFHOHIN);
		}
		nEBPANIDIMG_.WriteTo(ref output, _repeated_nEBPANIDIMG_codec);
		eFGGDDEALGM_.WriteTo(ref output, _repeated_eFGGDDEALGM_codec);
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(TotalDamage);
		}
		if (AKABDDGNLCP != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AKABDDGNLCP);
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
		if (FPOIEFHOHIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPOIEFHOHIN);
		}
		num += nEBPANIDIMG_.CalculateSize(_repeated_nEBPANIDIMG_codec);
		num += eFGGDDEALGM_.CalculateSize(_repeated_eFGGDDEALGM_codec);
		if (TotalDamage != 0.0)
		{
			num += 9;
		}
		if (AKABDDGNLCP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AKABDDGNLCP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFNFHIAEKIN other)
	{
		if (other != null)
		{
			if (other.FPOIEFHOHIN != 0)
			{
				FPOIEFHOHIN = other.FPOIEFHOHIN;
			}
			nEBPANIDIMG_.Add(other.nEBPANIDIMG_);
			eFGGDDEALGM_.Add(other.eFGGDDEALGM_);
			if (other.TotalDamage != 0.0)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.AKABDDGNLCP != 0)
			{
				AKABDDGNLCP = other.AKABDDGNLCP;
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
				FPOIEFHOHIN = input.ReadUInt32();
				break;
			case 26u:
				nEBPANIDIMG_.AddEntriesFrom(ref input, _repeated_nEBPANIDIMG_codec);
				break;
			case 42u:
				eFGGDDEALGM_.AddEntriesFrom(ref input, _repeated_eFGGDDEALGM_codec);
				break;
			case 57u:
				TotalDamage = input.ReadDouble();
				break;
			case 72u:
				AKABDDGNLCP = input.ReadUInt32();
				break;
			}
		}
	}
}
