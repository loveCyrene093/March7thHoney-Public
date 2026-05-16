using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HNCKGFGHJAC : IMessage<HNCKGFGHJAC>, IMessage, IEquatable<HNCKGFGHJAC>, IDeepCloneable<HNCKGFGHJAC>, IBufferMessage
{
	private static readonly MessageParser<HNCKGFGHJAC> _parser = new MessageParser<HNCKGFGHJAC>(() => new HNCKGFGHJAC());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 2;

	private uint oFHCNGHJFHI_;

	public const int JHADMBDCPEOFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_jHADMBDCPEO_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> jHADMBDCPEO_ = new RepeatedField<uint>();

	public const int GEDEBJHLGGAFieldNumber = 5;

	private uint gEDEBJHLGGA_;

	public const int MELANHHFEMKFieldNumber = 6;

	private bool mELANHHFEMK_;

	public const int PDEAIMNIAPIFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_pDEAIMNIAPI_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> pDEAIMNIAPI_ = new RepeatedField<uint>();

	public const int JHKFKLEGDDOFieldNumber = 13;

	private uint jHKFKLEGDDO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HNCKGFGHJAC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HNCKGFGHJACReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> JHADMBDCPEO => jHADMBDCPEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GEDEBJHLGGA
	{
		get
		{
			return gEDEBJHLGGA_;
		}
		set
		{
			gEDEBJHLGGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MELANHHFEMK
	{
		get
		{
			return mELANHHFEMK_;
		}
		set
		{
			mELANHHFEMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PDEAIMNIAPI => pDEAIMNIAPI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHKFKLEGDDO
	{
		get
		{
			return jHKFKLEGDDO_;
		}
		set
		{
			jHKFKLEGDDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HNCKGFGHJAC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HNCKGFGHJAC(HNCKGFGHJAC other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		jHADMBDCPEO_ = other.jHADMBDCPEO_.Clone();
		gEDEBJHLGGA_ = other.gEDEBJHLGGA_;
		mELANHHFEMK_ = other.mELANHHFEMK_;
		pDEAIMNIAPI_ = other.pDEAIMNIAPI_.Clone();
		jHKFKLEGDDO_ = other.jHKFKLEGDDO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HNCKGFGHJAC Clone()
	{
		return new HNCKGFGHJAC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HNCKGFGHJAC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HNCKGFGHJAC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (!jHADMBDCPEO_.Equals(other.jHADMBDCPEO_))
		{
			return false;
		}
		if (GEDEBJHLGGA != other.GEDEBJHLGGA)
		{
			return false;
		}
		if (MELANHHFEMK != other.MELANHHFEMK)
		{
			return false;
		}
		if (!pDEAIMNIAPI_.Equals(other.pDEAIMNIAPI_))
		{
			return false;
		}
		if (JHKFKLEGDDO != other.JHKFKLEGDDO)
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
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		num ^= jHADMBDCPEO_.GetHashCode();
		if (GEDEBJHLGGA != 0)
		{
			num ^= GEDEBJHLGGA.GetHashCode();
		}
		if (MELANHHFEMK)
		{
			num ^= MELANHHFEMK.GetHashCode();
		}
		num ^= pDEAIMNIAPI_.GetHashCode();
		if (JHKFKLEGDDO != 0)
		{
			num ^= JHKFKLEGDDO.GetHashCode();
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
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		jHADMBDCPEO_.WriteTo(ref output, _repeated_jHADMBDCPEO_codec);
		if (GEDEBJHLGGA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GEDEBJHLGGA);
		}
		if (MELANHHFEMK)
		{
			output.WriteRawTag(48);
			output.WriteBool(MELANHHFEMK);
		}
		pDEAIMNIAPI_.WriteTo(ref output, _repeated_pDEAIMNIAPI_codec);
		if (JHKFKLEGDDO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JHKFKLEGDDO);
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
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		num += jHADMBDCPEO_.CalculateSize(_repeated_jHADMBDCPEO_codec);
		if (GEDEBJHLGGA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GEDEBJHLGGA);
		}
		if (MELANHHFEMK)
		{
			num += 2;
		}
		num += pDEAIMNIAPI_.CalculateSize(_repeated_pDEAIMNIAPI_codec);
		if (JHKFKLEGDDO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHKFKLEGDDO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HNCKGFGHJAC other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			jHADMBDCPEO_.Add(other.jHADMBDCPEO_);
			if (other.GEDEBJHLGGA != 0)
			{
				GEDEBJHLGGA = other.GEDEBJHLGGA;
			}
			if (other.MELANHHFEMK)
			{
				MELANHHFEMK = other.MELANHHFEMK;
			}
			pDEAIMNIAPI_.Add(other.pDEAIMNIAPI_);
			if (other.JHKFKLEGDDO != 0)
			{
				JHKFKLEGDDO = other.JHKFKLEGDDO;
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
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				jHADMBDCPEO_.AddEntriesFrom(ref input, _repeated_jHADMBDCPEO_codec);
				break;
			case 40u:
				GEDEBJHLGGA = input.ReadUInt32();
				break;
			case 48u:
				MELANHHFEMK = input.ReadBool();
				break;
			case 64u:
			case 66u:
				pDEAIMNIAPI_.AddEntriesFrom(ref input, _repeated_pDEAIMNIAPI_codec);
				break;
			case 104u:
				JHKFKLEGDDO = input.ReadUInt32();
				break;
			}
		}
	}
}
