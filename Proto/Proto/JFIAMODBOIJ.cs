using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JFIAMODBOIJ : IMessage<JFIAMODBOIJ>, IMessage, IEquatable<JFIAMODBOIJ>, IDeepCloneable<JFIAMODBOIJ>, IBufferMessage
{
	private static readonly MessageParser<JFIAMODBOIJ> _parser = new MessageParser<JFIAMODBOIJ>(() => new JFIAMODBOIJ());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int MMLKFJIAKKHFieldNumber = 2;

	private uint mMLKFJIAKKH_;

	public const int NDKAIAFPNBJFieldNumber = 3;

	private uint nDKAIAFPNBJ_;

	public const int GLNMEPNKHLNFieldNumber = 4;

	private uint gLNMEPNKHLN_;

	public const int PKJAIJOKJLEFieldNumber = 5;

	private bool pKJAIJOKJLE_;

	public const int EEJCIOGHFCKFieldNumber = 6;

	private uint eEJCIOGHFCK_;

	public const int HOKFNCMJKBNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_hOKFNCMJKBN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> hOKFNCMJKBN_ = new RepeatedField<uint>();

	public const int FKEHOGMGLJFFieldNumber = 8;

	private CIMCDCBNNKJ fKEHOGMGLJF_;

	public const int HMDBAGELEIEFieldNumber = 9;

	private CIMCDCBNNKJ hMDBAGELEIE_;

	public const int PHFMJGBJFPHFieldNumber = 11;

	private uint pHFMJGBJFPH_;

	public const int PJANEJDIPLHFieldNumber = 12;

	private LOLKDKOCLLO pJANEJDIPLH_;

	public const int IHDAPMFEOPJFieldNumber = 13;

	private LOLKDKOCLLO iHDAPMFEOPJ_;

	public const int ScoreIdFieldNumber = 14;

	private uint scoreId_;

	public const int PDFPFFILENJFieldNumber = 15;

	private uint pDFPFFILENJ_;

	public const int CostTimeFieldNumber = 16;

	private uint costTime_;

	public const int MonsterBattleTypeFieldNumber = 17;

	private uint monsterBattleType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JFIAMODBOIJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JFIAMODBOIJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDKAIAFPNBJ
	{
		get
		{
			return nDKAIAFPNBJ_;
		}
		set
		{
			nDKAIAFPNBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLNMEPNKHLN
	{
		get
		{
			return gLNMEPNKHLN_;
		}
		set
		{
			gLNMEPNKHLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PKJAIJOKJLE
	{
		get
		{
			return pKJAIJOKJLE_;
		}
		set
		{
			pKJAIJOKJLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEJCIOGHFCK
	{
		get
		{
			return eEJCIOGHFCK_;
		}
		set
		{
			eEJCIOGHFCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HOKFNCMJKBN => hOKFNCMJKBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ FKEHOGMGLJF
	{
		get
		{
			return fKEHOGMGLJF_;
		}
		set
		{
			fKEHOGMGLJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ HMDBAGELEIE
	{
		get
		{
			return hMDBAGELEIE_;
		}
		set
		{
			hMDBAGELEIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHFMJGBJFPH
	{
		get
		{
			return pHFMJGBJFPH_;
		}
		set
		{
			pHFMJGBJFPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOLKDKOCLLO PJANEJDIPLH
	{
		get
		{
			return pJANEJDIPLH_;
		}
		set
		{
			pJANEJDIPLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOLKDKOCLLO IHDAPMFEOPJ
	{
		get
		{
			return iHDAPMFEOPJ_;
		}
		set
		{
			iHDAPMFEOPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDFPFFILENJ
	{
		get
		{
			return pDFPFFILENJ_;
		}
		set
		{
			pDFPFFILENJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterBattleType
	{
		get
		{
			return monsterBattleType_;
		}
		set
		{
			monsterBattleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFIAMODBOIJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFIAMODBOIJ(JFIAMODBOIJ other)
		: this()
	{
		roomId_ = other.roomId_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		nDKAIAFPNBJ_ = other.nDKAIAFPNBJ_;
		gLNMEPNKHLN_ = other.gLNMEPNKHLN_;
		pKJAIJOKJLE_ = other.pKJAIJOKJLE_;
		eEJCIOGHFCK_ = other.eEJCIOGHFCK_;
		hOKFNCMJKBN_ = other.hOKFNCMJKBN_.Clone();
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		hMDBAGELEIE_ = ((other.hMDBAGELEIE_ != null) ? other.hMDBAGELEIE_.Clone() : null);
		pHFMJGBJFPH_ = other.pHFMJGBJFPH_;
		pJANEJDIPLH_ = ((other.pJANEJDIPLH_ != null) ? other.pJANEJDIPLH_.Clone() : null);
		iHDAPMFEOPJ_ = ((other.iHDAPMFEOPJ_ != null) ? other.iHDAPMFEOPJ_.Clone() : null);
		scoreId_ = other.scoreId_;
		pDFPFFILENJ_ = other.pDFPFFILENJ_;
		costTime_ = other.costTime_;
		monsterBattleType_ = other.monsterBattleType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFIAMODBOIJ Clone()
	{
		return new JFIAMODBOIJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JFIAMODBOIJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JFIAMODBOIJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (NDKAIAFPNBJ != other.NDKAIAFPNBJ)
		{
			return false;
		}
		if (GLNMEPNKHLN != other.GLNMEPNKHLN)
		{
			return false;
		}
		if (PKJAIJOKJLE != other.PKJAIJOKJLE)
		{
			return false;
		}
		if (EEJCIOGHFCK != other.EEJCIOGHFCK)
		{
			return false;
		}
		if (!hOKFNCMJKBN_.Equals(other.hOKFNCMJKBN_))
		{
			return false;
		}
		if (!object.Equals(FKEHOGMGLJF, other.FKEHOGMGLJF))
		{
			return false;
		}
		if (!object.Equals(HMDBAGELEIE, other.HMDBAGELEIE))
		{
			return false;
		}
		if (PHFMJGBJFPH != other.PHFMJGBJFPH)
		{
			return false;
		}
		if (!object.Equals(PJANEJDIPLH, other.PJANEJDIPLH))
		{
			return false;
		}
		if (!object.Equals(IHDAPMFEOPJ, other.IHDAPMFEOPJ))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (PDFPFFILENJ != other.PDFPFFILENJ)
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (MonsterBattleType != other.MonsterBattleType)
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
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (NDKAIAFPNBJ != 0)
		{
			num ^= NDKAIAFPNBJ.GetHashCode();
		}
		if (GLNMEPNKHLN != 0)
		{
			num ^= GLNMEPNKHLN.GetHashCode();
		}
		if (PKJAIJOKJLE)
		{
			num ^= PKJAIJOKJLE.GetHashCode();
		}
		if (EEJCIOGHFCK != 0)
		{
			num ^= EEJCIOGHFCK.GetHashCode();
		}
		num ^= hOKFNCMJKBN_.GetHashCode();
		if (fKEHOGMGLJF_ != null)
		{
			num ^= FKEHOGMGLJF.GetHashCode();
		}
		if (hMDBAGELEIE_ != null)
		{
			num ^= HMDBAGELEIE.GetHashCode();
		}
		if (PHFMJGBJFPH != 0)
		{
			num ^= PHFMJGBJFPH.GetHashCode();
		}
		if (pJANEJDIPLH_ != null)
		{
			num ^= PJANEJDIPLH.GetHashCode();
		}
		if (iHDAPMFEOPJ_ != null)
		{
			num ^= IHDAPMFEOPJ.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (PDFPFFILENJ != 0)
		{
			num ^= PDFPFFILENJ.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		if (MonsterBattleType != 0)
		{
			num ^= MonsterBattleType.GetHashCode();
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
		if (RoomId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NDKAIAFPNBJ);
		}
		if (GLNMEPNKHLN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GLNMEPNKHLN);
		}
		if (PKJAIJOKJLE)
		{
			output.WriteRawTag(40);
			output.WriteBool(PKJAIJOKJLE);
		}
		if (EEJCIOGHFCK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EEJCIOGHFCK);
		}
		hOKFNCMJKBN_.WriteTo(ref output, _repeated_hOKFNCMJKBN_codec);
		if (fKEHOGMGLJF_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FKEHOGMGLJF);
		}
		if (hMDBAGELEIE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HMDBAGELEIE);
		}
		if (PHFMJGBJFPH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PHFMJGBJFPH);
		}
		if (pJANEJDIPLH_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(PJANEJDIPLH);
		}
		if (iHDAPMFEOPJ_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(IHDAPMFEOPJ);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ScoreId);
		}
		if (PDFPFFILENJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PDFPFFILENJ);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(CostTime);
		}
		if (MonsterBattleType != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteUInt32(MonsterBattleType);
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
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDKAIAFPNBJ);
		}
		if (GLNMEPNKHLN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLNMEPNKHLN);
		}
		if (PKJAIJOKJLE)
		{
			num += 2;
		}
		if (EEJCIOGHFCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEJCIOGHFCK);
		}
		num += hOKFNCMJKBN_.CalculateSize(_repeated_hOKFNCMJKBN_codec);
		if (fKEHOGMGLJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKEHOGMGLJF);
		}
		if (hMDBAGELEIE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMDBAGELEIE);
		}
		if (PHFMJGBJFPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHFMJGBJFPH);
		}
		if (pJANEJDIPLH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJANEJDIPLH);
		}
		if (iHDAPMFEOPJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHDAPMFEOPJ);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (PDFPFFILENJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDFPFFILENJ);
		}
		if (CostTime != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (MonsterBattleType != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MonsterBattleType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JFIAMODBOIJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
		}
		if (other.MMLKFJIAKKH != 0)
		{
			MMLKFJIAKKH = other.MMLKFJIAKKH;
		}
		if (other.NDKAIAFPNBJ != 0)
		{
			NDKAIAFPNBJ = other.NDKAIAFPNBJ;
		}
		if (other.GLNMEPNKHLN != 0)
		{
			GLNMEPNKHLN = other.GLNMEPNKHLN;
		}
		if (other.PKJAIJOKJLE)
		{
			PKJAIJOKJLE = other.PKJAIJOKJLE;
		}
		if (other.EEJCIOGHFCK != 0)
		{
			EEJCIOGHFCK = other.EEJCIOGHFCK;
		}
		hOKFNCMJKBN_.Add(other.hOKFNCMJKBN_);
		if (other.fKEHOGMGLJF_ != null)
		{
			if (fKEHOGMGLJF_ == null)
			{
				FKEHOGMGLJF = new CIMCDCBNNKJ();
			}
			FKEHOGMGLJF.MergeFrom(other.FKEHOGMGLJF);
		}
		if (other.hMDBAGELEIE_ != null)
		{
			if (hMDBAGELEIE_ == null)
			{
				HMDBAGELEIE = new CIMCDCBNNKJ();
			}
			HMDBAGELEIE.MergeFrom(other.HMDBAGELEIE);
		}
		if (other.PHFMJGBJFPH != 0)
		{
			PHFMJGBJFPH = other.PHFMJGBJFPH;
		}
		if (other.pJANEJDIPLH_ != null)
		{
			if (pJANEJDIPLH_ == null)
			{
				PJANEJDIPLH = new LOLKDKOCLLO();
			}
			PJANEJDIPLH.MergeFrom(other.PJANEJDIPLH);
		}
		if (other.iHDAPMFEOPJ_ != null)
		{
			if (iHDAPMFEOPJ_ == null)
			{
				IHDAPMFEOPJ = new LOLKDKOCLLO();
			}
			IHDAPMFEOPJ.MergeFrom(other.IHDAPMFEOPJ);
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.PDFPFFILENJ != 0)
		{
			PDFPFFILENJ = other.PDFPFFILENJ;
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
		}
		if (other.MonsterBattleType != 0)
		{
			MonsterBattleType = other.MonsterBattleType;
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
				RoomId = input.ReadUInt64();
				break;
			case 16u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 24u:
				NDKAIAFPNBJ = input.ReadUInt32();
				break;
			case 32u:
				GLNMEPNKHLN = input.ReadUInt32();
				break;
			case 40u:
				PKJAIJOKJLE = input.ReadBool();
				break;
			case 48u:
				EEJCIOGHFCK = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				hOKFNCMJKBN_.AddEntriesFrom(ref input, _repeated_hOKFNCMJKBN_codec);
				break;
			case 66u:
				if (fKEHOGMGLJF_ == null)
				{
					FKEHOGMGLJF = new CIMCDCBNNKJ();
				}
				input.ReadMessage(FKEHOGMGLJF);
				break;
			case 74u:
				if (hMDBAGELEIE_ == null)
				{
					HMDBAGELEIE = new CIMCDCBNNKJ();
				}
				input.ReadMessage(HMDBAGELEIE);
				break;
			case 88u:
				PHFMJGBJFPH = input.ReadUInt32();
				break;
			case 98u:
				if (pJANEJDIPLH_ == null)
				{
					PJANEJDIPLH = new LOLKDKOCLLO();
				}
				input.ReadMessage(PJANEJDIPLH);
				break;
			case 106u:
				if (iHDAPMFEOPJ_ == null)
				{
					IHDAPMFEOPJ = new LOLKDKOCLLO();
				}
				input.ReadMessage(IHDAPMFEOPJ);
				break;
			case 112u:
				ScoreId = input.ReadUInt32();
				break;
			case 120u:
				PDFPFFILENJ = input.ReadUInt32();
				break;
			case 128u:
				CostTime = input.ReadUInt32();
				break;
			case 136u:
				MonsterBattleType = input.ReadUInt32();
				break;
			}
		}
	}
}
