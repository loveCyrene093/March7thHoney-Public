using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLKILGMHPFM : IMessage<DLKILGMHPFM>, IMessage, IEquatable<DLKILGMHPFM>, IDeepCloneable<DLKILGMHPFM>, IBufferMessage
{
	private static readonly MessageParser<DLKILGMHPFM> _parser = new MessageParser<DLKILGMHPFM>(() => new DLKILGMHPFM());

	private UnknownFieldSet _unknownFields;

	public const int JHKFKLEGDDOFieldNumber = 1;

	private uint jHKFKLEGDDO_;

	public const int BCBGCPLEJIOFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_bCBGCPLEJIO_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> bCBGCPLEJIO_ = new RepeatedField<uint>();

	public const int DMHDJGEBLBMFieldNumber = 3;

	private static readonly MapField<uint, uint>.Codec _map_dMHDJGEBLBM_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 26u);

	private readonly MapField<uint, uint> dMHDJGEBLBM_ = new MapField<uint, uint>();

	public const int FPKADJBDBPOFieldNumber = 5;

	private GNLMENKBHLE fPKADJBDBPO_;

	public const int OHLGEEHPHJLFieldNumber = 6;

	private bool oHLGEEHPHJL_;

	public const int JEKPBICCDELFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_jEKPBICCDEL_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> jEKPBICCDEL_ = new RepeatedField<uint>();

	public const int GEDEBJHLGGAFieldNumber = 9;

	private uint gEDEBJHLGGA_;

	public const int KEIJOPOJGIPFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_kEIJOPOJGIP_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> kEIJOPOJGIP_ = new RepeatedField<uint>();

	public const int LEOLGONCDKOFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_lEOLGONCDKO_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> lEOLGONCDKO_ = new RepeatedField<uint>();

	public const int FDHBFNANLAHFieldNumber = 15;

	private bool fDHBFNANLAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLKILGMHPFM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLKILGMHPFMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> BCBGCPLEJIO => bCBGCPLEJIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> DMHDJGEBLBM => dMHDJGEBLBM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNLMENKBHLE FPKADJBDBPO
	{
		get
		{
			return fPKADJBDBPO_;
		}
		set
		{
			fPKADJBDBPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OHLGEEHPHJL
	{
		get
		{
			return oHLGEEHPHJL_;
		}
		set
		{
			oHLGEEHPHJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JEKPBICCDEL => jEKPBICCDEL_;

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
	public RepeatedField<uint> KEIJOPOJGIP => kEIJOPOJGIP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LEOLGONCDKO => lEOLGONCDKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FDHBFNANLAH
	{
		get
		{
			return fDHBFNANLAH_;
		}
		set
		{
			fDHBFNANLAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLKILGMHPFM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLKILGMHPFM(DLKILGMHPFM other)
		: this()
	{
		jHKFKLEGDDO_ = other.jHKFKLEGDDO_;
		bCBGCPLEJIO_ = other.bCBGCPLEJIO_.Clone();
		dMHDJGEBLBM_ = other.dMHDJGEBLBM_.Clone();
		fPKADJBDBPO_ = ((other.fPKADJBDBPO_ != null) ? other.fPKADJBDBPO_.Clone() : null);
		oHLGEEHPHJL_ = other.oHLGEEHPHJL_;
		jEKPBICCDEL_ = other.jEKPBICCDEL_.Clone();
		gEDEBJHLGGA_ = other.gEDEBJHLGGA_;
		kEIJOPOJGIP_ = other.kEIJOPOJGIP_.Clone();
		lEOLGONCDKO_ = other.lEOLGONCDKO_.Clone();
		fDHBFNANLAH_ = other.fDHBFNANLAH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLKILGMHPFM Clone()
	{
		return new DLKILGMHPFM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLKILGMHPFM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLKILGMHPFM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHKFKLEGDDO != other.JHKFKLEGDDO)
		{
			return false;
		}
		if (!bCBGCPLEJIO_.Equals(other.bCBGCPLEJIO_))
		{
			return false;
		}
		if (!DMHDJGEBLBM.Equals(other.DMHDJGEBLBM))
		{
			return false;
		}
		if (!object.Equals(FPKADJBDBPO, other.FPKADJBDBPO))
		{
			return false;
		}
		if (OHLGEEHPHJL != other.OHLGEEHPHJL)
		{
			return false;
		}
		if (!jEKPBICCDEL_.Equals(other.jEKPBICCDEL_))
		{
			return false;
		}
		if (GEDEBJHLGGA != other.GEDEBJHLGGA)
		{
			return false;
		}
		if (!kEIJOPOJGIP_.Equals(other.kEIJOPOJGIP_))
		{
			return false;
		}
		if (!lEOLGONCDKO_.Equals(other.lEOLGONCDKO_))
		{
			return false;
		}
		if (FDHBFNANLAH != other.FDHBFNANLAH)
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
		if (JHKFKLEGDDO != 0)
		{
			num ^= JHKFKLEGDDO.GetHashCode();
		}
		num ^= bCBGCPLEJIO_.GetHashCode();
		num ^= DMHDJGEBLBM.GetHashCode();
		if (fPKADJBDBPO_ != null)
		{
			num ^= FPKADJBDBPO.GetHashCode();
		}
		if (OHLGEEHPHJL)
		{
			num ^= OHLGEEHPHJL.GetHashCode();
		}
		num ^= jEKPBICCDEL_.GetHashCode();
		if (GEDEBJHLGGA != 0)
		{
			num ^= GEDEBJHLGGA.GetHashCode();
		}
		num ^= kEIJOPOJGIP_.GetHashCode();
		num ^= lEOLGONCDKO_.GetHashCode();
		if (FDHBFNANLAH)
		{
			num ^= FDHBFNANLAH.GetHashCode();
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
		if (JHKFKLEGDDO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JHKFKLEGDDO);
		}
		bCBGCPLEJIO_.WriteTo(ref output, _repeated_bCBGCPLEJIO_codec);
		dMHDJGEBLBM_.WriteTo(ref output, _map_dMHDJGEBLBM_codec);
		if (fPKADJBDBPO_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(FPKADJBDBPO);
		}
		if (OHLGEEHPHJL)
		{
			output.WriteRawTag(48);
			output.WriteBool(OHLGEEHPHJL);
		}
		jEKPBICCDEL_.WriteTo(ref output, _repeated_jEKPBICCDEL_codec);
		if (GEDEBJHLGGA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GEDEBJHLGGA);
		}
		kEIJOPOJGIP_.WriteTo(ref output, _repeated_kEIJOPOJGIP_codec);
		lEOLGONCDKO_.WriteTo(ref output, _repeated_lEOLGONCDKO_codec);
		if (FDHBFNANLAH)
		{
			output.WriteRawTag(120);
			output.WriteBool(FDHBFNANLAH);
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
		if (JHKFKLEGDDO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHKFKLEGDDO);
		}
		num += bCBGCPLEJIO_.CalculateSize(_repeated_bCBGCPLEJIO_codec);
		num += dMHDJGEBLBM_.CalculateSize(_map_dMHDJGEBLBM_codec);
		if (fPKADJBDBPO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FPKADJBDBPO);
		}
		if (OHLGEEHPHJL)
		{
			num += 2;
		}
		num += jEKPBICCDEL_.CalculateSize(_repeated_jEKPBICCDEL_codec);
		if (GEDEBJHLGGA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GEDEBJHLGGA);
		}
		num += kEIJOPOJGIP_.CalculateSize(_repeated_kEIJOPOJGIP_codec);
		num += lEOLGONCDKO_.CalculateSize(_repeated_lEOLGONCDKO_codec);
		if (FDHBFNANLAH)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLKILGMHPFM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JHKFKLEGDDO != 0)
		{
			JHKFKLEGDDO = other.JHKFKLEGDDO;
		}
		bCBGCPLEJIO_.Add(other.bCBGCPLEJIO_);
		dMHDJGEBLBM_.MergeFrom(other.dMHDJGEBLBM_);
		if (other.fPKADJBDBPO_ != null)
		{
			if (fPKADJBDBPO_ == null)
			{
				FPKADJBDBPO = new GNLMENKBHLE();
			}
			FPKADJBDBPO.MergeFrom(other.FPKADJBDBPO);
		}
		if (other.OHLGEEHPHJL)
		{
			OHLGEEHPHJL = other.OHLGEEHPHJL;
		}
		jEKPBICCDEL_.Add(other.jEKPBICCDEL_);
		if (other.GEDEBJHLGGA != 0)
		{
			GEDEBJHLGGA = other.GEDEBJHLGGA;
		}
		kEIJOPOJGIP_.Add(other.kEIJOPOJGIP_);
		lEOLGONCDKO_.Add(other.lEOLGONCDKO_);
		if (other.FDHBFNANLAH)
		{
			FDHBFNANLAH = other.FDHBFNANLAH;
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
			case 8u:
				JHKFKLEGDDO = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				bCBGCPLEJIO_.AddEntriesFrom(ref input, _repeated_bCBGCPLEJIO_codec);
				break;
			case 26u:
				dMHDJGEBLBM_.AddEntriesFrom(ref input, _map_dMHDJGEBLBM_codec);
				break;
			case 42u:
				if (fPKADJBDBPO_ == null)
				{
					FPKADJBDBPO = new GNLMENKBHLE();
				}
				input.ReadMessage(FPKADJBDBPO);
				break;
			case 48u:
				OHLGEEHPHJL = input.ReadBool();
				break;
			case 56u:
			case 58u:
				jEKPBICCDEL_.AddEntriesFrom(ref input, _repeated_jEKPBICCDEL_codec);
				break;
			case 72u:
				GEDEBJHLGGA = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				kEIJOPOJGIP_.AddEntriesFrom(ref input, _repeated_kEIJOPOJGIP_codec);
				break;
			case 112u:
			case 114u:
				lEOLGONCDKO_.AddEntriesFrom(ref input, _repeated_lEOLGONCDKO_codec);
				break;
			case 120u:
				FDHBFNANLAH = input.ReadBool();
				break;
			}
		}
	}
}
