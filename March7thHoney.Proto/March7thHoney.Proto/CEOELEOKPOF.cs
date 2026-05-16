using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CEOELEOKPOF : IMessage<CEOELEOKPOF>, IMessage, IEquatable<CEOELEOKPOF>, IDeepCloneable<CEOELEOKPOF>, IBufferMessage
{
	private static readonly MessageParser<CEOELEOKPOF> _parser = new MessageParser<CEOELEOKPOF>(() => new CEOELEOKPOF());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int HCPBKALKGGLFieldNumber = 2;

	private uint hCPBKALKGGL_;

	public const int BEFJLFKJFJDFieldNumber = 3;

	private uint bEFJLFKJFJD_;

	public const int CELNCPCPMHAFieldNumber = 4;

	private uint cELNCPCPMHA_;

	public const int MonsterBattleTypeFieldNumber = 5;

	private uint monsterBattleType_;

	public const int EEJCIOGHFCKFieldNumber = 6;

	private uint eEJCIOGHFCK_;

	public const int FKEHOGMGLJFFieldNumber = 7;

	private CIMCDCBNNKJ fKEHOGMGLJF_;

	public const int DCJBFCPGNAJFieldNumber = 8;

	private CIMCDCBNNKJ dCJBFCPGNAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CEOELEOKPOF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CEOELEOKPOFReflection.Descriptor.MessageTypes[0];

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
	public CEOELEOKPOF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEOELEOKPOF(CEOELEOKPOF other)
		: this()
	{
		roomId_ = other.roomId_;
		hCPBKALKGGL_ = other.hCPBKALKGGL_;
		bEFJLFKJFJD_ = other.bEFJLFKJFJD_;
		cELNCPCPMHA_ = other.cELNCPCPMHA_;
		monsterBattleType_ = other.monsterBattleType_;
		eEJCIOGHFCK_ = other.eEJCIOGHFCK_;
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		dCJBFCPGNAJ_ = ((other.dCJBFCPGNAJ_ != null) ? other.dCJBFCPGNAJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEOELEOKPOF Clone()
	{
		return new CEOELEOKPOF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CEOELEOKPOF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CEOELEOKPOF other)
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
		if (MonsterBattleType != other.MonsterBattleType)
		{
			return false;
		}
		if (EEJCIOGHFCK != other.EEJCIOGHFCK)
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
		if (MonsterBattleType != 0)
		{
			num ^= MonsterBattleType.GetHashCode();
		}
		if (EEJCIOGHFCK != 0)
		{
			num ^= EEJCIOGHFCK.GetHashCode();
		}
		if (fKEHOGMGLJF_ != null)
		{
			num ^= FKEHOGMGLJF.GetHashCode();
		}
		if (dCJBFCPGNAJ_ != null)
		{
			num ^= DCJBFCPGNAJ.GetHashCode();
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
		if (MonsterBattleType != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MonsterBattleType);
		}
		if (EEJCIOGHFCK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EEJCIOGHFCK);
		}
		if (fKEHOGMGLJF_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FKEHOGMGLJF);
		}
		if (dCJBFCPGNAJ_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DCJBFCPGNAJ);
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
		if (MonsterBattleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterBattleType);
		}
		if (EEJCIOGHFCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEJCIOGHFCK);
		}
		if (fKEHOGMGLJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKEHOGMGLJF);
		}
		if (dCJBFCPGNAJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCJBFCPGNAJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CEOELEOKPOF other)
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
		if (other.MonsterBattleType != 0)
		{
			MonsterBattleType = other.MonsterBattleType;
		}
		if (other.EEJCIOGHFCK != 0)
		{
			EEJCIOGHFCK = other.EEJCIOGHFCK;
		}
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
				MonsterBattleType = input.ReadUInt32();
				break;
			case 48u:
				EEJCIOGHFCK = input.ReadUInt32();
				break;
			case 58u:
				if (fKEHOGMGLJF_ == null)
				{
					FKEHOGMGLJF = new CIMCDCBNNKJ();
				}
				input.ReadMessage(FKEHOGMGLJF);
				break;
			case 66u:
				if (dCJBFCPGNAJ_ == null)
				{
					DCJBFCPGNAJ = new CIMCDCBNNKJ();
				}
				input.ReadMessage(DCJBFCPGNAJ);
				break;
			}
		}
	}
}
