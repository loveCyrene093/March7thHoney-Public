using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CAHPBBLMDCJ : IMessage<CAHPBBLMDCJ>, IMessage, IEquatable<CAHPBBLMDCJ>, IDeepCloneable<CAHPBBLMDCJ>, IBufferMessage
{
	private static readonly MessageParser<CAHPBBLMDCJ> _parser = new MessageParser<CAHPBBLMDCJ>(() => new CAHPBBLMDCJ());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int HCPBKALKGGLFieldNumber = 2;

	private uint hCPBKALKGGL_;

	public const int BEFJLFKJFJDFieldNumber = 3;

	private uint bEFJLFKJFJD_;

	public const int CELNCPCPMHAFieldNumber = 4;

	private uint cELNCPCPMHA_;

	public const int BJBABGBGGINFieldNumber = 5;

	private bool bJBABGBGGIN_;

	public const int MonsterBattleTypeFieldNumber = 6;

	private uint monsterBattleType_;

	public const int EEJCIOGHFCKFieldNumber = 7;

	private uint eEJCIOGHFCK_;

	public const int HOKFNCMJKBNFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_hOKFNCMJKBN_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> hOKFNCMJKBN_ = new RepeatedField<uint>();

	public const int FKEHOGMGLJFFieldNumber = 9;

	private CIMCDCBNNKJ fKEHOGMGLJF_;

	public const int DCJBFCPGNAJFieldNumber = 10;

	private CIMCDCBNNKJ dCJBFCPGNAJ_;

	public const int PHFMJGBJFPHFieldNumber = 11;

	private uint pHFMJGBJFPH_;

	public const int JJGLBPGNJMLFieldNumber = 12;

	private MKEINLFOAEA jJGLBPGNJML_;

	public const int GBMBBLNEGCIFieldNumber = 13;

	private MKEINLFOAEA gBMBBLNEGCI_;

	public const int IEAKHDKAKDMFieldNumber = 14;

	private uint iEAKHDKAKDM_;

	public const int CostTimeFieldNumber = 15;

	private uint costTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CAHPBBLMDCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CAHPBBLMDCJReflection.Descriptor.MessageTypes[0];

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
	public uint HCPBKALKGGL
	{
		get
		{
			return hCPBKALKGGL_;
		}
		set
		{
			hCPBKALKGGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEFJLFKJFJD
	{
		get
		{
			return bEFJLFKJFJD_;
		}
		set
		{
			bEFJLFKJFJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CELNCPCPMHA
	{
		get
		{
			return cELNCPCPMHA_;
		}
		set
		{
			cELNCPCPMHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BJBABGBGGIN
	{
		get
		{
			return bJBABGBGGIN_;
		}
		set
		{
			bJBABGBGGIN_ = value;
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
	public CIMCDCBNNKJ DCJBFCPGNAJ
	{
		get
		{
			return dCJBFCPGNAJ_;
		}
		set
		{
			dCJBFCPGNAJ_ = value;
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
	public MKEINLFOAEA JJGLBPGNJML
	{
		get
		{
			return jJGLBPGNJML_;
		}
		set
		{
			jJGLBPGNJML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA GBMBBLNEGCI
	{
		get
		{
			return gBMBBLNEGCI_;
		}
		set
		{
			gBMBBLNEGCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEAKHDKAKDM
	{
		get
		{
			return iEAKHDKAKDM_;
		}
		set
		{
			iEAKHDKAKDM_ = value;
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
	public CAHPBBLMDCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAHPBBLMDCJ(CAHPBBLMDCJ other)
		: this()
	{
		roomId_ = other.roomId_;
		hCPBKALKGGL_ = other.hCPBKALKGGL_;
		bEFJLFKJFJD_ = other.bEFJLFKJFJD_;
		cELNCPCPMHA_ = other.cELNCPCPMHA_;
		bJBABGBGGIN_ = other.bJBABGBGGIN_;
		monsterBattleType_ = other.monsterBattleType_;
		eEJCIOGHFCK_ = other.eEJCIOGHFCK_;
		hOKFNCMJKBN_ = other.hOKFNCMJKBN_.Clone();
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		dCJBFCPGNAJ_ = ((other.dCJBFCPGNAJ_ != null) ? other.dCJBFCPGNAJ_.Clone() : null);
		pHFMJGBJFPH_ = other.pHFMJGBJFPH_;
		jJGLBPGNJML_ = ((other.jJGLBPGNJML_ != null) ? other.jJGLBPGNJML_.Clone() : null);
		gBMBBLNEGCI_ = ((other.gBMBBLNEGCI_ != null) ? other.gBMBBLNEGCI_.Clone() : null);
		iEAKHDKAKDM_ = other.iEAKHDKAKDM_;
		costTime_ = other.costTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAHPBBLMDCJ Clone()
	{
		return new CAHPBBLMDCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CAHPBBLMDCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CAHPBBLMDCJ other)
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
		if (HCPBKALKGGL != other.HCPBKALKGGL)
		{
			return false;
		}
		if (BEFJLFKJFJD != other.BEFJLFKJFJD)
		{
			return false;
		}
		if (CELNCPCPMHA != other.CELNCPCPMHA)
		{
			return false;
		}
		if (BJBABGBGGIN != other.BJBABGBGGIN)
		{
			return false;
		}
		if (MonsterBattleType != other.MonsterBattleType)
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
		if (!object.Equals(DCJBFCPGNAJ, other.DCJBFCPGNAJ))
		{
			return false;
		}
		if (PHFMJGBJFPH != other.PHFMJGBJFPH)
		{
			return false;
		}
		if (!object.Equals(JJGLBPGNJML, other.JJGLBPGNJML))
		{
			return false;
		}
		if (!object.Equals(GBMBBLNEGCI, other.GBMBBLNEGCI))
		{
			return false;
		}
		if (IEAKHDKAKDM != other.IEAKHDKAKDM)
		{
			return false;
		}
		if (CostTime != other.CostTime)
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
		if (HCPBKALKGGL != 0)
		{
			num ^= HCPBKALKGGL.GetHashCode();
		}
		if (BEFJLFKJFJD != 0)
		{
			num ^= BEFJLFKJFJD.GetHashCode();
		}
		if (CELNCPCPMHA != 0)
		{
			num ^= CELNCPCPMHA.GetHashCode();
		}
		if (BJBABGBGGIN)
		{
			num ^= BJBABGBGGIN.GetHashCode();
		}
		if (MonsterBattleType != 0)
		{
			num ^= MonsterBattleType.GetHashCode();
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
		if (dCJBFCPGNAJ_ != null)
		{
			num ^= DCJBFCPGNAJ.GetHashCode();
		}
		if (PHFMJGBJFPH != 0)
		{
			num ^= PHFMJGBJFPH.GetHashCode();
		}
		if (jJGLBPGNJML_ != null)
		{
			num ^= JJGLBPGNJML.GetHashCode();
		}
		if (gBMBBLNEGCI_ != null)
		{
			num ^= GBMBBLNEGCI.GetHashCode();
		}
		if (IEAKHDKAKDM != 0)
		{
			num ^= IEAKHDKAKDM.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
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
		if (HCPBKALKGGL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HCPBKALKGGL);
		}
		if (BEFJLFKJFJD != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BEFJLFKJFJD);
		}
		if (CELNCPCPMHA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CELNCPCPMHA);
		}
		if (BJBABGBGGIN)
		{
			output.WriteRawTag(40);
			output.WriteBool(BJBABGBGGIN);
		}
		if (MonsterBattleType != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MonsterBattleType);
		}
		if (EEJCIOGHFCK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EEJCIOGHFCK);
		}
		hOKFNCMJKBN_.WriteTo(ref output, _repeated_hOKFNCMJKBN_codec);
		if (fKEHOGMGLJF_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(FKEHOGMGLJF);
		}
		if (dCJBFCPGNAJ_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DCJBFCPGNAJ);
		}
		if (PHFMJGBJFPH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PHFMJGBJFPH);
		}
		if (jJGLBPGNJML_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(JJGLBPGNJML);
		}
		if (gBMBBLNEGCI_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GBMBBLNEGCI);
		}
		if (IEAKHDKAKDM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IEAKHDKAKDM);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CostTime);
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
		if (HCPBKALKGGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCPBKALKGGL);
		}
		if (BEFJLFKJFJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEFJLFKJFJD);
		}
		if (CELNCPCPMHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CELNCPCPMHA);
		}
		if (BJBABGBGGIN)
		{
			num += 2;
		}
		if (MonsterBattleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterBattleType);
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
		if (dCJBFCPGNAJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCJBFCPGNAJ);
		}
		if (PHFMJGBJFPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHFMJGBJFPH);
		}
		if (jJGLBPGNJML_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JJGLBPGNJML);
		}
		if (gBMBBLNEGCI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GBMBBLNEGCI);
		}
		if (IEAKHDKAKDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEAKHDKAKDM);
		}
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CAHPBBLMDCJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
		}
		if (other.HCPBKALKGGL != 0)
		{
			HCPBKALKGGL = other.HCPBKALKGGL;
		}
		if (other.BEFJLFKJFJD != 0)
		{
			BEFJLFKJFJD = other.BEFJLFKJFJD;
		}
		if (other.CELNCPCPMHA != 0)
		{
			CELNCPCPMHA = other.CELNCPCPMHA;
		}
		if (other.BJBABGBGGIN)
		{
			BJBABGBGGIN = other.BJBABGBGGIN;
		}
		if (other.MonsterBattleType != 0)
		{
			MonsterBattleType = other.MonsterBattleType;
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
		if (other.dCJBFCPGNAJ_ != null)
		{
			if (dCJBFCPGNAJ_ == null)
			{
				DCJBFCPGNAJ = new CIMCDCBNNKJ();
			}
			DCJBFCPGNAJ.MergeFrom(other.DCJBFCPGNAJ);
		}
		if (other.PHFMJGBJFPH != 0)
		{
			PHFMJGBJFPH = other.PHFMJGBJFPH;
		}
		if (other.jJGLBPGNJML_ != null)
		{
			if (jJGLBPGNJML_ == null)
			{
				JJGLBPGNJML = new MKEINLFOAEA();
			}
			JJGLBPGNJML.MergeFrom(other.JJGLBPGNJML);
		}
		if (other.gBMBBLNEGCI_ != null)
		{
			if (gBMBBLNEGCI_ == null)
			{
				GBMBBLNEGCI = new MKEINLFOAEA();
			}
			GBMBBLNEGCI.MergeFrom(other.GBMBBLNEGCI);
		}
		if (other.IEAKHDKAKDM != 0)
		{
			IEAKHDKAKDM = other.IEAKHDKAKDM;
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
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
				HCPBKALKGGL = input.ReadUInt32();
				break;
			case 24u:
				BEFJLFKJFJD = input.ReadUInt32();
				break;
			case 32u:
				CELNCPCPMHA = input.ReadUInt32();
				break;
			case 40u:
				BJBABGBGGIN = input.ReadBool();
				break;
			case 48u:
				MonsterBattleType = input.ReadUInt32();
				break;
			case 56u:
				EEJCIOGHFCK = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				hOKFNCMJKBN_.AddEntriesFrom(ref input, _repeated_hOKFNCMJKBN_codec);
				break;
			case 74u:
				if (fKEHOGMGLJF_ == null)
				{
					FKEHOGMGLJF = new CIMCDCBNNKJ();
				}
				input.ReadMessage(FKEHOGMGLJF);
				break;
			case 82u:
				if (dCJBFCPGNAJ_ == null)
				{
					DCJBFCPGNAJ = new CIMCDCBNNKJ();
				}
				input.ReadMessage(DCJBFCPGNAJ);
				break;
			case 88u:
				PHFMJGBJFPH = input.ReadUInt32();
				break;
			case 98u:
				if (jJGLBPGNJML_ == null)
				{
					JJGLBPGNJML = new MKEINLFOAEA();
				}
				input.ReadMessage(JJGLBPGNJML);
				break;
			case 106u:
				if (gBMBBLNEGCI_ == null)
				{
					GBMBBLNEGCI = new MKEINLFOAEA();
				}
				input.ReadMessage(GBMBBLNEGCI);
				break;
			case 112u:
				IEAKHDKAKDM = input.ReadUInt32();
				break;
			case 120u:
				CostTime = input.ReadUInt32();
				break;
			}
		}
	}
}
