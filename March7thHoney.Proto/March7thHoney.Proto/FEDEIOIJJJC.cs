using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FEDEIOIJJJC : IMessage<FEDEIOIJJJC>, IMessage, IEquatable<FEDEIOIJJJC>, IDeepCloneable<FEDEIOIJJJC>, IBufferMessage
{
	private static readonly MessageParser<FEDEIOIJJJC> _parser = new MessageParser<FEDEIOIJJJC>(() => new FEDEIOIJJJC());

	private UnknownFieldSet _unknownFields;

	public const int PJCIONEPINEFieldNumber = 3;

	private static readonly MapField<uint, uint>.Codec _map_pJCIONEPINE_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 26u);

	private readonly MapField<uint, uint> pJCIONEPINE_ = new MapField<uint, uint>();

	public const int EDMBIKHBICGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_eDMBIKHBICG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> eDMBIKHBICG_ = new RepeatedField<uint>();

	public const int KPNEPNELPNHFieldNumber = 6;

	private static readonly MapField<uint, CGHJPDIDOBI>.Codec _map_kPNEPNELPNH_codec = new MapField<uint, CGHJPDIDOBI>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, CGHJPDIDOBI.Parser), 50u);

	private readonly MapField<uint, CGHJPDIDOBI> kPNEPNELPNH_ = new MapField<uint, CGHJPDIDOBI>();

	public const int NLBKDNKGBCKFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_nLBKDNKGBCK_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> nLBKDNKGBCK_ = new RepeatedField<uint>();

	public const int CEIMNDJFDJDFieldNumber = 12;

	private uint cEIMNDJFDJD_;

	public const int EFJLGEAAHEKFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_eFJLGEAAHEK_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> eFJLGEAAHEK_ = new RepeatedField<uint>();

	public const int ELGFFACNECKFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_eLGFFACNECK_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> eLGFFACNECK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FEDEIOIJJJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FEDEIOIJJJCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> PJCIONEPINE => pJCIONEPINE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EDMBIKHBICG => eDMBIKHBICG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, CGHJPDIDOBI> KPNEPNELPNH => kPNEPNELPNH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NLBKDNKGBCK => nLBKDNKGBCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEIMNDJFDJD
	{
		get
		{
			return cEIMNDJFDJD_;
		}
		set
		{
			cEIMNDJFDJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EFJLGEAAHEK => eFJLGEAAHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ELGFFACNECK => eLGFFACNECK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEDEIOIJJJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEDEIOIJJJC(FEDEIOIJJJC other)
		: this()
	{
		pJCIONEPINE_ = other.pJCIONEPINE_.Clone();
		eDMBIKHBICG_ = other.eDMBIKHBICG_.Clone();
		kPNEPNELPNH_ = other.kPNEPNELPNH_.Clone();
		nLBKDNKGBCK_ = other.nLBKDNKGBCK_.Clone();
		cEIMNDJFDJD_ = other.cEIMNDJFDJD_;
		eFJLGEAAHEK_ = other.eFJLGEAAHEK_.Clone();
		eLGFFACNECK_ = other.eLGFFACNECK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEDEIOIJJJC Clone()
	{
		return new FEDEIOIJJJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FEDEIOIJJJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FEDEIOIJJJC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!PJCIONEPINE.Equals(other.PJCIONEPINE))
		{
			return false;
		}
		if (!eDMBIKHBICG_.Equals(other.eDMBIKHBICG_))
		{
			return false;
		}
		if (!KPNEPNELPNH.Equals(other.KPNEPNELPNH))
		{
			return false;
		}
		if (!nLBKDNKGBCK_.Equals(other.nLBKDNKGBCK_))
		{
			return false;
		}
		if (CEIMNDJFDJD != other.CEIMNDJFDJD)
		{
			return false;
		}
		if (!eFJLGEAAHEK_.Equals(other.eFJLGEAAHEK_))
		{
			return false;
		}
		if (!eLGFFACNECK_.Equals(other.eLGFFACNECK_))
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
		num ^= PJCIONEPINE.GetHashCode();
		num ^= eDMBIKHBICG_.GetHashCode();
		num ^= KPNEPNELPNH.GetHashCode();
		num ^= nLBKDNKGBCK_.GetHashCode();
		if (CEIMNDJFDJD != 0)
		{
			num ^= CEIMNDJFDJD.GetHashCode();
		}
		num ^= eFJLGEAAHEK_.GetHashCode();
		num ^= eLGFFACNECK_.GetHashCode();
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
		pJCIONEPINE_.WriteTo(ref output, _map_pJCIONEPINE_codec);
		eDMBIKHBICG_.WriteTo(ref output, _repeated_eDMBIKHBICG_codec);
		kPNEPNELPNH_.WriteTo(ref output, _map_kPNEPNELPNH_codec);
		nLBKDNKGBCK_.WriteTo(ref output, _repeated_nLBKDNKGBCK_codec);
		if (CEIMNDJFDJD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CEIMNDJFDJD);
		}
		eFJLGEAAHEK_.WriteTo(ref output, _repeated_eFJLGEAAHEK_codec);
		eLGFFACNECK_.WriteTo(ref output, _repeated_eLGFFACNECK_codec);
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
		num += pJCIONEPINE_.CalculateSize(_map_pJCIONEPINE_codec);
		num += eDMBIKHBICG_.CalculateSize(_repeated_eDMBIKHBICG_codec);
		num += kPNEPNELPNH_.CalculateSize(_map_kPNEPNELPNH_codec);
		num += nLBKDNKGBCK_.CalculateSize(_repeated_nLBKDNKGBCK_codec);
		if (CEIMNDJFDJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEIMNDJFDJD);
		}
		num += eFJLGEAAHEK_.CalculateSize(_repeated_eFJLGEAAHEK_codec);
		num += eLGFFACNECK_.CalculateSize(_repeated_eLGFFACNECK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FEDEIOIJJJC other)
	{
		if (other != null)
		{
			pJCIONEPINE_.MergeFrom(other.pJCIONEPINE_);
			eDMBIKHBICG_.Add(other.eDMBIKHBICG_);
			kPNEPNELPNH_.MergeFrom(other.kPNEPNELPNH_);
			nLBKDNKGBCK_.Add(other.nLBKDNKGBCK_);
			if (other.CEIMNDJFDJD != 0)
			{
				CEIMNDJFDJD = other.CEIMNDJFDJD;
			}
			eFJLGEAAHEK_.Add(other.eFJLGEAAHEK_);
			eLGFFACNECK_.Add(other.eLGFFACNECK_);
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
			case 26u:
				pJCIONEPINE_.AddEntriesFrom(ref input, _map_pJCIONEPINE_codec);
				break;
			case 32u:
			case 34u:
				eDMBIKHBICG_.AddEntriesFrom(ref input, _repeated_eDMBIKHBICG_codec);
				break;
			case 50u:
				kPNEPNELPNH_.AddEntriesFrom(ref input, _map_kPNEPNELPNH_codec);
				break;
			case 64u:
			case 66u:
				nLBKDNKGBCK_.AddEntriesFrom(ref input, _repeated_nLBKDNKGBCK_codec);
				break;
			case 96u:
				CEIMNDJFDJD = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				eFJLGEAAHEK_.AddEntriesFrom(ref input, _repeated_eFJLGEAAHEK_codec);
				break;
			case 120u:
			case 122u:
				eLGFFACNECK_.AddEntriesFrom(ref input, _repeated_eLGFFACNECK_codec);
				break;
			}
		}
	}
}
