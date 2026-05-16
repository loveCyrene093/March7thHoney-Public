using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncMuseumInfoChangedScNotify : IMessage<SyncMuseumInfoChangedScNotify>, IMessage, IEquatable<SyncMuseumInfoChangedScNotify>, IDeepCloneable<SyncMuseumInfoChangedScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncMuseumInfoChangedScNotify> _parser = new MessageParser<SyncMuseumInfoChangedScNotify>(() => new SyncMuseumInfoChangedScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ANBEHCINFLDFieldNumber = 1;

	private uint aNBEHCINFLD_;

	public const int ABIJHKNBGHJFieldNumber = 2;

	private uint aBIJHKNBGHJ_;

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int ExpFieldNumber = 4;

	private uint exp_;

	public const int BODAPOLFADFFieldNumber = 5;

	private static readonly FieldCodec<FKMKIGFJODF> _repeated_bODAPOLFADF_codec = FieldCodec.ForMessage(42u, FKMKIGFJODF.Parser);

	private readonly RepeatedField<FKMKIGFJODF> bODAPOLFADF_ = new RepeatedField<FKMKIGFJODF>();

	public const int OKMGHNCGPOLFieldNumber = 6;

	private KNNODAPAKJA oKMGHNCGPOL_;

	public const int GPEAFAJGCPHFieldNumber = 7;

	private DBHPNLHPCMD gPEAFAJGCPH_;

	public const int CKDACHPJLJDFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_cKDACHPJLJD_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> cKDACHPJLJD_ = new RepeatedField<uint>();

	public const int AAOKFFGNBNEFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_aAOKFFGNBNE_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> aAOKFFGNBNE_ = new RepeatedField<uint>();

	public const int CurFundFieldNumber = 12;

	private uint curFund_;

	public const int DJFLHFMJPCDFieldNumber = 13;

	private uint dJFLHFMJPCD_;

	public const int AreaListFieldNumber = 14;

	private static readonly FieldCodec<FOKOPECFCOP> _repeated_areaList_codec = FieldCodec.ForMessage(114u, FOKOPECFCOP.Parser);

	private readonly RepeatedField<FOKOPECFCOP> areaList_ = new RepeatedField<FOKOPECFCOP>();

	public const int NOGABDKMAGBFieldNumber = 15;

	private uint nOGABDKMAGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncMuseumInfoChangedScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncMuseumInfoChangedScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<FKMKIGFJODF> BODAPOLFADF => bODAPOLFADF_;

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
	public RepeatedField<uint> CKDACHPJLJD => cKDACHPJLJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AAOKFFGNBNE => aAOKFFGNBNE_;

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
	public RepeatedField<FOKOPECFCOP> AreaList => areaList_;

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
	public SyncMuseumInfoChangedScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumInfoChangedScNotify(SyncMuseumInfoChangedScNotify other)
		: this()
	{
		aNBEHCINFLD_ = other.aNBEHCINFLD_;
		aBIJHKNBGHJ_ = other.aBIJHKNBGHJ_;
		level_ = other.level_;
		exp_ = other.exp_;
		bODAPOLFADF_ = other.bODAPOLFADF_.Clone();
		oKMGHNCGPOL_ = ((other.oKMGHNCGPOL_ != null) ? other.oKMGHNCGPOL_.Clone() : null);
		gPEAFAJGCPH_ = ((other.gPEAFAJGCPH_ != null) ? other.gPEAFAJGCPH_.Clone() : null);
		cKDACHPJLJD_ = other.cKDACHPJLJD_.Clone();
		aAOKFFGNBNE_ = other.aAOKFFGNBNE_.Clone();
		curFund_ = other.curFund_;
		dJFLHFMJPCD_ = other.dJFLHFMJPCD_;
		areaList_ = other.areaList_.Clone();
		nOGABDKMAGB_ = other.nOGABDKMAGB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumInfoChangedScNotify Clone()
	{
		return new SyncMuseumInfoChangedScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncMuseumInfoChangedScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncMuseumInfoChangedScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ANBEHCINFLD != other.ANBEHCINFLD)
		{
			return false;
		}
		if (ABIJHKNBGHJ != other.ABIJHKNBGHJ)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (!bODAPOLFADF_.Equals(other.bODAPOLFADF_))
		{
			return false;
		}
		if (!object.Equals(OKMGHNCGPOL, other.OKMGHNCGPOL))
		{
			return false;
		}
		if (!object.Equals(GPEAFAJGCPH, other.GPEAFAJGCPH))
		{
			return false;
		}
		if (!cKDACHPJLJD_.Equals(other.cKDACHPJLJD_))
		{
			return false;
		}
		if (!aAOKFFGNBNE_.Equals(other.aAOKFFGNBNE_))
		{
			return false;
		}
		if (CurFund != other.CurFund)
		{
			return false;
		}
		if (DJFLHFMJPCD != other.DJFLHFMJPCD)
		{
			return false;
		}
		if (!areaList_.Equals(other.areaList_))
		{
			return false;
		}
		if (NOGABDKMAGB != other.NOGABDKMAGB)
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
		if (ANBEHCINFLD != 0)
		{
			num ^= ANBEHCINFLD.GetHashCode();
		}
		if (ABIJHKNBGHJ != 0)
		{
			num ^= ABIJHKNBGHJ.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		num ^= bODAPOLFADF_.GetHashCode();
		if (oKMGHNCGPOL_ != null)
		{
			num ^= OKMGHNCGPOL.GetHashCode();
		}
		if (gPEAFAJGCPH_ != null)
		{
			num ^= GPEAFAJGCPH.GetHashCode();
		}
		num ^= cKDACHPJLJD_.GetHashCode();
		num ^= aAOKFFGNBNE_.GetHashCode();
		if (CurFund != 0)
		{
			num ^= CurFund.GetHashCode();
		}
		if (DJFLHFMJPCD != 0)
		{
			num ^= DJFLHFMJPCD.GetHashCode();
		}
		num ^= areaList_.GetHashCode();
		if (NOGABDKMAGB != 0)
		{
			num ^= NOGABDKMAGB.GetHashCode();
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
		if (ANBEHCINFLD != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ANBEHCINFLD);
		}
		if (ABIJHKNBGHJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ABIJHKNBGHJ);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Exp);
		}
		bODAPOLFADF_.WriteTo(ref output, _repeated_bODAPOLFADF_codec);
		if (oKMGHNCGPOL_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OKMGHNCGPOL);
		}
		if (gPEAFAJGCPH_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(GPEAFAJGCPH);
		}
		cKDACHPJLJD_.WriteTo(ref output, _repeated_cKDACHPJLJD_codec);
		aAOKFFGNBNE_.WriteTo(ref output, _repeated_aAOKFFGNBNE_codec);
		if (CurFund != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CurFund);
		}
		if (DJFLHFMJPCD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DJFLHFMJPCD);
		}
		areaList_.WriteTo(ref output, _repeated_areaList_codec);
		if (NOGABDKMAGB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NOGABDKMAGB);
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
		if (ANBEHCINFLD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANBEHCINFLD);
		}
		if (ABIJHKNBGHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABIJHKNBGHJ);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		num += bODAPOLFADF_.CalculateSize(_repeated_bODAPOLFADF_codec);
		if (oKMGHNCGPOL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OKMGHNCGPOL);
		}
		if (gPEAFAJGCPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GPEAFAJGCPH);
		}
		num += cKDACHPJLJD_.CalculateSize(_repeated_cKDACHPJLJD_codec);
		num += aAOKFFGNBNE_.CalculateSize(_repeated_aAOKFFGNBNE_codec);
		if (CurFund != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurFund);
		}
		if (DJFLHFMJPCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DJFLHFMJPCD);
		}
		num += areaList_.CalculateSize(_repeated_areaList_codec);
		if (NOGABDKMAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOGABDKMAGB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncMuseumInfoChangedScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ANBEHCINFLD != 0)
		{
			ANBEHCINFLD = other.ANBEHCINFLD;
		}
		if (other.ABIJHKNBGHJ != 0)
		{
			ABIJHKNBGHJ = other.ABIJHKNBGHJ;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		bODAPOLFADF_.Add(other.bODAPOLFADF_);
		if (other.oKMGHNCGPOL_ != null)
		{
			if (oKMGHNCGPOL_ == null)
			{
				OKMGHNCGPOL = new KNNODAPAKJA();
			}
			OKMGHNCGPOL.MergeFrom(other.OKMGHNCGPOL);
		}
		if (other.gPEAFAJGCPH_ != null)
		{
			if (gPEAFAJGCPH_ == null)
			{
				GPEAFAJGCPH = new DBHPNLHPCMD();
			}
			GPEAFAJGCPH.MergeFrom(other.GPEAFAJGCPH);
		}
		cKDACHPJLJD_.Add(other.cKDACHPJLJD_);
		aAOKFFGNBNE_.Add(other.aAOKFFGNBNE_);
		if (other.CurFund != 0)
		{
			CurFund = other.CurFund;
		}
		if (other.DJFLHFMJPCD != 0)
		{
			DJFLHFMJPCD = other.DJFLHFMJPCD;
		}
		areaList_.Add(other.areaList_);
		if (other.NOGABDKMAGB != 0)
		{
			NOGABDKMAGB = other.NOGABDKMAGB;
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
				ANBEHCINFLD = input.ReadUInt32();
				break;
			case 16u:
				ABIJHKNBGHJ = input.ReadUInt32();
				break;
			case 24u:
				Level = input.ReadUInt32();
				break;
			case 32u:
				Exp = input.ReadUInt32();
				break;
			case 42u:
				bODAPOLFADF_.AddEntriesFrom(ref input, _repeated_bODAPOLFADF_codec);
				break;
			case 50u:
				if (oKMGHNCGPOL_ == null)
				{
					OKMGHNCGPOL = new KNNODAPAKJA();
				}
				input.ReadMessage(OKMGHNCGPOL);
				break;
			case 58u:
				if (gPEAFAJGCPH_ == null)
				{
					GPEAFAJGCPH = new DBHPNLHPCMD();
				}
				input.ReadMessage(GPEAFAJGCPH);
				break;
			case 72u:
			case 74u:
				cKDACHPJLJD_.AddEntriesFrom(ref input, _repeated_cKDACHPJLJD_codec);
				break;
			case 80u:
			case 82u:
				aAOKFFGNBNE_.AddEntriesFrom(ref input, _repeated_aAOKFFGNBNE_codec);
				break;
			case 96u:
				CurFund = input.ReadUInt32();
				break;
			case 104u:
				DJFLHFMJPCD = input.ReadUInt32();
				break;
			case 114u:
				areaList_.AddEntriesFrom(ref input, _repeated_areaList_codec);
				break;
			case 120u:
				NOGABDKMAGB = input.ReadUInt32();
				break;
			}
		}
	}
}
