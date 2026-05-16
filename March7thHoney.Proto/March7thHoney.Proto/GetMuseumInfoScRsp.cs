using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMuseumInfoScRsp : IMessage<GetMuseumInfoScRsp>, IMessage, IEquatable<GetMuseumInfoScRsp>, IDeepCloneable<GetMuseumInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMuseumInfoScRsp> _parser = new MessageParser<GetMuseumInfoScRsp>(() => new GetMuseumInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CKDACHPJLJDFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_cKDACHPJLJD_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> cKDACHPJLJD_ = new RepeatedField<uint>();

	public const int CurFundFieldNumber = 3;

	private uint curFund_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int ExpFieldNumber = 5;

	private uint exp_;

	public const int AAOKFFGNBNEFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_aAOKFFGNBNE_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> aAOKFFGNBNE_ = new RepeatedField<uint>();

	public const int ABIJHKNBGHJFieldNumber = 7;

	private uint aBIJHKNBGHJ_;

	public const int BODAPOLFADFFieldNumber = 8;

	private static readonly FieldCodec<FKMKIGFJODF> _repeated_bODAPOLFADF_codec = FieldCodec.ForMessage(66u, FKMKIGFJODF.Parser);

	private readonly RepeatedField<FKMKIGFJODF> bODAPOLFADF_ = new RepeatedField<FKMKIGFJODF>();

	public const int GPEAFAJGCPHFieldNumber = 9;

	private DBHPNLHPCMD gPEAFAJGCPH_;

	public const int NOGABDKMAGBFieldNumber = 10;

	private uint nOGABDKMAGB_;

	public const int OKMGHNCGPOLFieldNumber = 11;

	private KNNODAPAKJA oKMGHNCGPOL_;

	public const int DJFLHFMJPCDFieldNumber = 12;

	private uint dJFLHFMJPCD_;

	public const int ANBEHCINFLDFieldNumber = 13;

	private uint aNBEHCINFLD_;

	public const int AreaListFieldNumber = 14;

	private static readonly FieldCodec<FOKOPECFCOP> _repeated_areaList_codec = FieldCodec.ForMessage(114u, FOKOPECFCOP.Parser);

	private readonly RepeatedField<FOKOPECFCOP> areaList_ = new RepeatedField<FOKOPECFCOP>();

	public const int LevelFieldNumber = 15;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMuseumInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMuseumInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CKDACHPJLJD => cKDACHPJLJD_;

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
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AAOKFFGNBNE => aAOKFFGNBNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABIJHKNBGHJ
	{
		get
		{
			return aBIJHKNBGHJ_;
		}
		set
		{
			aBIJHKNBGHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FKMKIGFJODF> BODAPOLFADF => bODAPOLFADF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DBHPNLHPCMD GPEAFAJGCPH
	{
		get
		{
			return gPEAFAJGCPH_;
		}
		set
		{
			gPEAFAJGCPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOGABDKMAGB
	{
		get
		{
			return nOGABDKMAGB_;
		}
		set
		{
			nOGABDKMAGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNNODAPAKJA OKMGHNCGPOL
	{
		get
		{
			return oKMGHNCGPOL_;
		}
		set
		{
			oKMGHNCGPOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DJFLHFMJPCD
	{
		get
		{
			return dJFLHFMJPCD_;
		}
		set
		{
			dJFLHFMJPCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANBEHCINFLD
	{
		get
		{
			return aNBEHCINFLD_;
		}
		set
		{
			aNBEHCINFLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FOKOPECFCOP> AreaList => areaList_;

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
	public GetMuseumInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMuseumInfoScRsp(GetMuseumInfoScRsp other)
		: this()
	{
		cKDACHPJLJD_ = other.cKDACHPJLJD_.Clone();
		curFund_ = other.curFund_;
		retcode_ = other.retcode_;
		exp_ = other.exp_;
		aAOKFFGNBNE_ = other.aAOKFFGNBNE_.Clone();
		aBIJHKNBGHJ_ = other.aBIJHKNBGHJ_;
		bODAPOLFADF_ = other.bODAPOLFADF_.Clone();
		gPEAFAJGCPH_ = ((other.gPEAFAJGCPH_ != null) ? other.gPEAFAJGCPH_.Clone() : null);
		nOGABDKMAGB_ = other.nOGABDKMAGB_;
		oKMGHNCGPOL_ = ((other.oKMGHNCGPOL_ != null) ? other.oKMGHNCGPOL_.Clone() : null);
		dJFLHFMJPCD_ = other.dJFLHFMJPCD_;
		aNBEHCINFLD_ = other.aNBEHCINFLD_;
		areaList_ = other.areaList_.Clone();
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMuseumInfoScRsp Clone()
	{
		return new GetMuseumInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMuseumInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMuseumInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cKDACHPJLJD_.Equals(other.cKDACHPJLJD_))
		{
			return false;
		}
		if (CurFund != other.CurFund)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (!aAOKFFGNBNE_.Equals(other.aAOKFFGNBNE_))
		{
			return false;
		}
		if (ABIJHKNBGHJ != other.ABIJHKNBGHJ)
		{
			return false;
		}
		if (!bODAPOLFADF_.Equals(other.bODAPOLFADF_))
		{
			return false;
		}
		if (!object.Equals(GPEAFAJGCPH, other.GPEAFAJGCPH))
		{
			return false;
		}
		if (NOGABDKMAGB != other.NOGABDKMAGB)
		{
			return false;
		}
		if (!object.Equals(OKMGHNCGPOL, other.OKMGHNCGPOL))
		{
			return false;
		}
		if (DJFLHFMJPCD != other.DJFLHFMJPCD)
		{
			return false;
		}
		if (ANBEHCINFLD != other.ANBEHCINFLD)
		{
			return false;
		}
		if (!areaList_.Equals(other.areaList_))
		{
			return false;
		}
		if (Level != other.Level)
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
		num ^= cKDACHPJLJD_.GetHashCode();
		if (CurFund != 0)
		{
			num ^= CurFund.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		num ^= aAOKFFGNBNE_.GetHashCode();
		if (ABIJHKNBGHJ != 0)
		{
			num ^= ABIJHKNBGHJ.GetHashCode();
		}
		num ^= bODAPOLFADF_.GetHashCode();
		if (gPEAFAJGCPH_ != null)
		{
			num ^= GPEAFAJGCPH.GetHashCode();
		}
		if (NOGABDKMAGB != 0)
		{
			num ^= NOGABDKMAGB.GetHashCode();
		}
		if (oKMGHNCGPOL_ != null)
		{
			num ^= OKMGHNCGPOL.GetHashCode();
		}
		if (DJFLHFMJPCD != 0)
		{
			num ^= DJFLHFMJPCD.GetHashCode();
		}
		if (ANBEHCINFLD != 0)
		{
			num ^= ANBEHCINFLD.GetHashCode();
		}
		num ^= areaList_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		cKDACHPJLJD_.WriteTo(ref output, _repeated_cKDACHPJLJD_codec);
		if (CurFund != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CurFund);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Exp);
		}
		aAOKFFGNBNE_.WriteTo(ref output, _repeated_aAOKFFGNBNE_codec);
		if (ABIJHKNBGHJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ABIJHKNBGHJ);
		}
		bODAPOLFADF_.WriteTo(ref output, _repeated_bODAPOLFADF_codec);
		if (gPEAFAJGCPH_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GPEAFAJGCPH);
		}
		if (NOGABDKMAGB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NOGABDKMAGB);
		}
		if (oKMGHNCGPOL_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(OKMGHNCGPOL);
		}
		if (DJFLHFMJPCD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DJFLHFMJPCD);
		}
		if (ANBEHCINFLD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ANBEHCINFLD);
		}
		areaList_.WriteTo(ref output, _repeated_areaList_codec);
		if (Level != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Level);
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
		num += cKDACHPJLJD_.CalculateSize(_repeated_cKDACHPJLJD_codec);
		if (CurFund != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurFund);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		num += aAOKFFGNBNE_.CalculateSize(_repeated_aAOKFFGNBNE_codec);
		if (ABIJHKNBGHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABIJHKNBGHJ);
		}
		num += bODAPOLFADF_.CalculateSize(_repeated_bODAPOLFADF_codec);
		if (gPEAFAJGCPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GPEAFAJGCPH);
		}
		if (NOGABDKMAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOGABDKMAGB);
		}
		if (oKMGHNCGPOL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OKMGHNCGPOL);
		}
		if (DJFLHFMJPCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DJFLHFMJPCD);
		}
		if (ANBEHCINFLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANBEHCINFLD);
		}
		num += areaList_.CalculateSize(_repeated_areaList_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMuseumInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		cKDACHPJLJD_.Add(other.cKDACHPJLJD_);
		if (other.CurFund != 0)
		{
			CurFund = other.CurFund;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		aAOKFFGNBNE_.Add(other.aAOKFFGNBNE_);
		if (other.ABIJHKNBGHJ != 0)
		{
			ABIJHKNBGHJ = other.ABIJHKNBGHJ;
		}
		bODAPOLFADF_.Add(other.bODAPOLFADF_);
		if (other.gPEAFAJGCPH_ != null)
		{
			if (gPEAFAJGCPH_ == null)
			{
				GPEAFAJGCPH = new DBHPNLHPCMD();
			}
			GPEAFAJGCPH.MergeFrom(other.GPEAFAJGCPH);
		}
		if (other.NOGABDKMAGB != 0)
		{
			NOGABDKMAGB = other.NOGABDKMAGB;
		}
		if (other.oKMGHNCGPOL_ != null)
		{
			if (oKMGHNCGPOL_ == null)
			{
				OKMGHNCGPOL = new KNNODAPAKJA();
			}
			OKMGHNCGPOL.MergeFrom(other.OKMGHNCGPOL);
		}
		if (other.DJFLHFMJPCD != 0)
		{
			DJFLHFMJPCD = other.DJFLHFMJPCD;
		}
		if (other.ANBEHCINFLD != 0)
		{
			ANBEHCINFLD = other.ANBEHCINFLD;
		}
		areaList_.Add(other.areaList_);
		if (other.Level != 0)
		{
			Level = other.Level;
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
			case 10u:
				cKDACHPJLJD_.AddEntriesFrom(ref input, _repeated_cKDACHPJLJD_codec);
				break;
			case 24u:
				CurFund = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				Exp = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				aAOKFFGNBNE_.AddEntriesFrom(ref input, _repeated_aAOKFFGNBNE_codec);
				break;
			case 56u:
				ABIJHKNBGHJ = input.ReadUInt32();
				break;
			case 66u:
				bODAPOLFADF_.AddEntriesFrom(ref input, _repeated_bODAPOLFADF_codec);
				break;
			case 74u:
				if (gPEAFAJGCPH_ == null)
				{
					GPEAFAJGCPH = new DBHPNLHPCMD();
				}
				input.ReadMessage(GPEAFAJGCPH);
				break;
			case 80u:
				NOGABDKMAGB = input.ReadUInt32();
				break;
			case 90u:
				if (oKMGHNCGPOL_ == null)
				{
					OKMGHNCGPOL = new KNNODAPAKJA();
				}
				input.ReadMessage(OKMGHNCGPOL);
				break;
			case 96u:
				DJFLHFMJPCD = input.ReadUInt32();
				break;
			case 104u:
				ANBEHCINFLD = input.ReadUInt32();
				break;
			case 114u:
				areaList_.AddEntriesFrom(ref input, _repeated_areaList_codec);
				break;
			case 120u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
