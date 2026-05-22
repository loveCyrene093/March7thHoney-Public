using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAlleyInfoScRsp : IMessage<GetAlleyInfoScRsp>, IMessage, IEquatable<GetAlleyInfoScRsp>, IDeepCloneable<GetAlleyInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAlleyInfoScRsp> _parser = new MessageParser<GetAlleyInfoScRsp>(() => new GetAlleyInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HBMJIGGBFKPFieldNumber = 1;

	private GEOAAAOAPGK hBMJIGGBFKP_;

	public const int LevelFieldNumber = 4;

	private uint level_;

	public const int JONKHPKNNLDFieldNumber = 5;

	private uint jONKHPKNNLD_;

	public const int PADDEJDLFLAFieldNumber = 6;

	private static readonly FieldCodec<DCMJCNOKKNN> _repeated_pADDEJDLFLA_codec = FieldCodec.ForMessage(50u, DCMJCNOKKNN.Parser);

	private readonly RepeatedField<DCMJCNOKKNN> pADDEJDLFLA_ = new RepeatedField<DCMJCNOKKNN>();

	public const int CurFundFieldNumber = 7;

	private uint curFund_;

	public const int JKCDJIPNLPIFieldNumber = 8;

	private MKPDCILELAA jKCDJIPNLPI_;

	public const int IBNPANJGKOIFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_iBNPANJGKOI_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> iBNPANJGKOI_ = new RepeatedField<uint>();

	public const int NLEJPMEDBNHFieldNumber = 11;

	private PLIEEDKHGNN nLEJPMEDBNH_;

	public const int BENEIFAHIGJFieldNumber = 12;

	private static readonly MapField<uint, uint>.Codec _map_bENEIFAHIGJ_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 98u);

	private readonly MapField<uint, uint> bENEIFAHIGJ_ = new MapField<uint, uint>();

	public const int LAFIBGBIIIEFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_lAFIBGBIIIE_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> lAFIBGBIIIE_ = new RepeatedField<uint>();

	public const int GCFECPJKDMKFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_gCFECPJKDMK_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> gCFECPJKDMK_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAlleyInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAlleyInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOAAAOAPGK HBMJIGGBFKP
	{
		get
		{
			return hBMJIGGBFKP_;
		}
		set
		{
			hBMJIGGBFKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JONKHPKNNLD
	{
		get
		{
			return jONKHPKNNLD_;
		}
		set
		{
			jONKHPKNNLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DCMJCNOKKNN> PADDEJDLFLA => pADDEJDLFLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurFund
	{
		get
		{
			return curFund_;
		}
		set
		{
			curFund_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPDCILELAA JKCDJIPNLPI
	{
		get
		{
			return jKCDJIPNLPI_;
		}
		set
		{
			jKCDJIPNLPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IBNPANJGKOI => iBNPANJGKOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLIEEDKHGNN NLEJPMEDBNH
	{
		get
		{
			return nLEJPMEDBNH_;
		}
		set
		{
			nLEJPMEDBNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BENEIFAHIGJ => bENEIFAHIGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LAFIBGBIIIE => lAFIBGBIIIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GCFECPJKDMK => gCFECPJKDMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAlleyInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAlleyInfoScRsp(GetAlleyInfoScRsp other)
		: this()
	{
		hBMJIGGBFKP_ = ((other.hBMJIGGBFKP_ != null) ? other.hBMJIGGBFKP_.Clone() : null);
		level_ = other.level_;
		jONKHPKNNLD_ = other.jONKHPKNNLD_;
		pADDEJDLFLA_ = other.pADDEJDLFLA_.Clone();
		curFund_ = other.curFund_;
		jKCDJIPNLPI_ = ((other.jKCDJIPNLPI_ != null) ? other.jKCDJIPNLPI_.Clone() : null);
		iBNPANJGKOI_ = other.iBNPANJGKOI_.Clone();
		nLEJPMEDBNH_ = ((other.nLEJPMEDBNH_ != null) ? other.nLEJPMEDBNH_.Clone() : null);
		bENEIFAHIGJ_ = other.bENEIFAHIGJ_.Clone();
		lAFIBGBIIIE_ = other.lAFIBGBIIIE_.Clone();
		gCFECPJKDMK_ = other.gCFECPJKDMK_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAlleyInfoScRsp Clone()
	{
		return new GetAlleyInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAlleyInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAlleyInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HBMJIGGBFKP, other.HBMJIGGBFKP))
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (JONKHPKNNLD != other.JONKHPKNNLD)
		{
			return false;
		}
		if (!pADDEJDLFLA_.Equals(other.pADDEJDLFLA_))
		{
			return false;
		}
		if (CurFund != other.CurFund)
		{
			return false;
		}
		if (!object.Equals(JKCDJIPNLPI, other.JKCDJIPNLPI))
		{
			return false;
		}
		if (!iBNPANJGKOI_.Equals(other.iBNPANJGKOI_))
		{
			return false;
		}
		if (!object.Equals(NLEJPMEDBNH, other.NLEJPMEDBNH))
		{
			return false;
		}
		if (!BENEIFAHIGJ.Equals(other.BENEIFAHIGJ))
		{
			return false;
		}
		if (!lAFIBGBIIIE_.Equals(other.lAFIBGBIIIE_))
		{
			return false;
		}
		if (!gCFECPJKDMK_.Equals(other.gCFECPJKDMK_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (hBMJIGGBFKP_ != null)
		{
			num ^= HBMJIGGBFKP.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (JONKHPKNNLD != 0)
		{
			num ^= JONKHPKNNLD.GetHashCode();
		}
		num ^= pADDEJDLFLA_.GetHashCode();
		if (CurFund != 0)
		{
			num ^= CurFund.GetHashCode();
		}
		if (jKCDJIPNLPI_ != null)
		{
			num ^= JKCDJIPNLPI.GetHashCode();
		}
		num ^= iBNPANJGKOI_.GetHashCode();
		if (nLEJPMEDBNH_ != null)
		{
			num ^= NLEJPMEDBNH.GetHashCode();
		}
		num ^= BENEIFAHIGJ.GetHashCode();
		num ^= lAFIBGBIIIE_.GetHashCode();
		num ^= gCFECPJKDMK_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (hBMJIGGBFKP_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HBMJIGGBFKP);
		}
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Level);
		}
		if (JONKHPKNNLD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JONKHPKNNLD);
		}
		pADDEJDLFLA_.WriteTo(ref output, _repeated_pADDEJDLFLA_codec);
		if (CurFund != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(CurFund);
		}
		if (jKCDJIPNLPI_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(JKCDJIPNLPI);
		}
		iBNPANJGKOI_.WriteTo(ref output, _repeated_iBNPANJGKOI_codec);
		if (nLEJPMEDBNH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(NLEJPMEDBNH);
		}
		bENEIFAHIGJ_.WriteTo(ref output, _map_bENEIFAHIGJ_codec);
		lAFIBGBIIIE_.WriteTo(ref output, _repeated_lAFIBGBIIIE_codec);
		gCFECPJKDMK_.WriteTo(ref output, _repeated_gCFECPJKDMK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (hBMJIGGBFKP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HBMJIGGBFKP);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (JONKHPKNNLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JONKHPKNNLD);
		}
		num += pADDEJDLFLA_.CalculateSize(_repeated_pADDEJDLFLA_codec);
		if (CurFund != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurFund);
		}
		if (jKCDJIPNLPI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JKCDJIPNLPI);
		}
		num += iBNPANJGKOI_.CalculateSize(_repeated_iBNPANJGKOI_codec);
		if (nLEJPMEDBNH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NLEJPMEDBNH);
		}
		num += bENEIFAHIGJ_.CalculateSize(_map_bENEIFAHIGJ_codec);
		num += lAFIBGBIIIE_.CalculateSize(_repeated_lAFIBGBIIIE_codec);
		num += gCFECPJKDMK_.CalculateSize(_repeated_gCFECPJKDMK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAlleyInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hBMJIGGBFKP_ != null)
		{
			if (hBMJIGGBFKP_ == null)
			{
				HBMJIGGBFKP = new GEOAAAOAPGK();
			}
			HBMJIGGBFKP.MergeFrom(other.HBMJIGGBFKP);
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.JONKHPKNNLD != 0)
		{
			JONKHPKNNLD = other.JONKHPKNNLD;
		}
		pADDEJDLFLA_.Add(other.pADDEJDLFLA_);
		if (other.CurFund != 0)
		{
			CurFund = other.CurFund;
		}
		if (other.jKCDJIPNLPI_ != null)
		{
			if (jKCDJIPNLPI_ == null)
			{
				JKCDJIPNLPI = new MKPDCILELAA();
			}
			JKCDJIPNLPI.MergeFrom(other.JKCDJIPNLPI);
		}
		iBNPANJGKOI_.Add(other.iBNPANJGKOI_);
		if (other.nLEJPMEDBNH_ != null)
		{
			if (nLEJPMEDBNH_ == null)
			{
				NLEJPMEDBNH = new PLIEEDKHGNN();
			}
			NLEJPMEDBNH.MergeFrom(other.NLEJPMEDBNH);
		}
		bENEIFAHIGJ_.MergeFrom(other.bENEIFAHIGJ_);
		lAFIBGBIIIE_.Add(other.lAFIBGBIIIE_);
		gCFECPJKDMK_.Add(other.gCFECPJKDMK_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 10u:
				if (hBMJIGGBFKP_ == null)
				{
					HBMJIGGBFKP = new GEOAAAOAPGK();
				}
				input.ReadMessage(HBMJIGGBFKP);
				break;
			case 32u:
				Level = input.ReadUInt32();
				break;
			case 40u:
				JONKHPKNNLD = input.ReadUInt32();
				break;
			case 50u:
				pADDEJDLFLA_.AddEntriesFrom(ref input, _repeated_pADDEJDLFLA_codec);
				break;
			case 56u:
				CurFund = input.ReadUInt32();
				break;
			case 66u:
				if (jKCDJIPNLPI_ == null)
				{
					JKCDJIPNLPI = new MKPDCILELAA();
				}
				input.ReadMessage(JKCDJIPNLPI);
				break;
			case 80u:
			case 82u:
				iBNPANJGKOI_.AddEntriesFrom(ref input, _repeated_iBNPANJGKOI_codec);
				break;
			case 90u:
				if (nLEJPMEDBNH_ == null)
				{
					NLEJPMEDBNH = new PLIEEDKHGNN();
				}
				input.ReadMessage(NLEJPMEDBNH);
				break;
			case 98u:
				bENEIFAHIGJ_.AddEntriesFrom(ref input, _map_bENEIFAHIGJ_codec);
				break;
			case 104u:
			case 106u:
				lAFIBGBIIIE_.AddEntriesFrom(ref input, _repeated_lAFIBGBIIIE_codec);
				break;
			case 112u:
			case 114u:
				gCFECPJKDMK_.AddEntriesFrom(ref input, _repeated_gCFECPJKDMK_codec);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
