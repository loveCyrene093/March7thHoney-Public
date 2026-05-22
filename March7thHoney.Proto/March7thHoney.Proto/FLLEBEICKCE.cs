using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FLLEBEICKCE : IMessage<FLLEBEICKCE>, IMessage, IEquatable<FLLEBEICKCE>, IDeepCloneable<FLLEBEICKCE>, IBufferMessage
{
	private static readonly MessageParser<FLLEBEICKCE> _parser = new MessageParser<FLLEBEICKCE>(() => new FLLEBEICKCE());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private uint level_;

	public const int ExpFieldNumber = 3;

	private uint exp_;

	public const int NAJCPOPJGLBFieldNumber = 4;

	private int nAJCPOPJGLB_;

	public const int IndexFieldNumber = 5;

	private uint index_;

	public const int MLLGEOINJOGFieldNumber = 6;

	private uint mLLGEOINJOG_;

	public const int StatusFieldNumber = 7;

	private MBKMLJABCBE status_;

	public const int UniqueIdFieldNumber = 8;

	private uint uniqueId_;

	public const int LLHJAGGEGOKFieldNumber = 9;

	private uint lLHJAGGEGOK_;

	public const int HpFieldNumber = 10;

	private int hp_;

	public const int PNCNGMFBANDFieldNumber = 11;

	private uint pNCNGMFBAND_;

	public const int DDGEOOLHAPGFieldNumber = 12;

	private uint dDGEOOLHAPG_;

	public const int GridFightEquipmentIdFieldNumber = 14;

	private uint gridFightEquipmentId_;

	public const int ELEBGNHEIMLFieldNumber = 15;

	private uint eLEBGNHEIML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FLLEBEICKCE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FLLEBEICKCEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int NAJCPOPJGLB
	{
		get
		{
			return nAJCPOPJGLB_;
		}
		set
		{
			nAJCPOPJGLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLLGEOINJOG
	{
		get
		{
			return mLLGEOINJOG_;
		}
		set
		{
			mLLGEOINJOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBKMLJABCBE Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLHJAGGEGOK
	{
		get
		{
			return lLHJAGGEGOK_;
		}
		set
		{
			lLHJAGGEGOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNCNGMFBAND
	{
		get
		{
			return pNCNGMFBAND_;
		}
		set
		{
			pNCNGMFBAND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDGEOOLHAPG
	{
		get
		{
			return dDGEOOLHAPG_;
		}
		set
		{
			dDGEOOLHAPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightEquipmentId
	{
		get
		{
			return gridFightEquipmentId_;
		}
		set
		{
			gridFightEquipmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ELEBGNHEIML
	{
		get
		{
			return eLEBGNHEIML_;
		}
		set
		{
			eLEBGNHEIML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLLEBEICKCE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLLEBEICKCE(FLLEBEICKCE other)
		: this()
	{
		level_ = other.level_;
		exp_ = other.exp_;
		nAJCPOPJGLB_ = other.nAJCPOPJGLB_;
		index_ = other.index_;
		mLLGEOINJOG_ = other.mLLGEOINJOG_;
		status_ = other.status_;
		uniqueId_ = other.uniqueId_;
		lLHJAGGEGOK_ = other.lLHJAGGEGOK_;
		hp_ = other.hp_;
		pNCNGMFBAND_ = other.pNCNGMFBAND_;
		dDGEOOLHAPG_ = other.dDGEOOLHAPG_;
		gridFightEquipmentId_ = other.gridFightEquipmentId_;
		eLEBGNHEIML_ = other.eLEBGNHEIML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLLEBEICKCE Clone()
	{
		return new FLLEBEICKCE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FLLEBEICKCE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FLLEBEICKCE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (NAJCPOPJGLB != other.NAJCPOPJGLB)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (MLLGEOINJOG != other.MLLGEOINJOG)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (LLHJAGGEGOK != other.LLHJAGGEGOK)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (PNCNGMFBAND != other.PNCNGMFBAND)
		{
			return false;
		}
		if (DDGEOOLHAPG != other.DDGEOOLHAPG)
		{
			return false;
		}
		if (GridFightEquipmentId != other.GridFightEquipmentId)
		{
			return false;
		}
		if (ELEBGNHEIML != other.ELEBGNHEIML)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (NAJCPOPJGLB != 0)
		{
			num ^= NAJCPOPJGLB.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (MLLGEOINJOG != 0)
		{
			num ^= MLLGEOINJOG.GetHashCode();
		}
		if (Status != MBKMLJABCBE.Bnjmpchfina)
		{
			num ^= Status.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (LLHJAGGEGOK != 0)
		{
			num ^= LLHJAGGEGOK.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (PNCNGMFBAND != 0)
		{
			num ^= PNCNGMFBAND.GetHashCode();
		}
		if (DDGEOOLHAPG != 0)
		{
			num ^= DDGEOOLHAPG.GetHashCode();
		}
		if (GridFightEquipmentId != 0)
		{
			num ^= GridFightEquipmentId.GetHashCode();
		}
		if (ELEBGNHEIML != 0)
		{
			num ^= ELEBGNHEIML.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Level);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Exp);
		}
		if (NAJCPOPJGLB != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(NAJCPOPJGLB);
		}
		if (Index != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Index);
		}
		if (MLLGEOINJOG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MLLGEOINJOG);
		}
		if (Status != MBKMLJABCBE.Bnjmpchfina)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Status);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(UniqueId);
		}
		if (LLHJAGGEGOK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LLHJAGGEGOK);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Hp);
		}
		if (PNCNGMFBAND != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PNCNGMFBAND);
		}
		if (DDGEOOLHAPG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DDGEOOLHAPG);
		}
		if (GridFightEquipmentId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GridFightEquipmentId);
		}
		if (ELEBGNHEIML != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ELEBGNHEIML);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (NAJCPOPJGLB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NAJCPOPJGLB);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (MLLGEOINJOG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLLGEOINJOG);
		}
		if (Status != MBKMLJABCBE.Bnjmpchfina)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (LLHJAGGEGOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLHJAGGEGOK);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (PNCNGMFBAND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNCNGMFBAND);
		}
		if (DDGEOOLHAPG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDGEOOLHAPG);
		}
		if (GridFightEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightEquipmentId);
		}
		if (ELEBGNHEIML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ELEBGNHEIML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FLLEBEICKCE other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.NAJCPOPJGLB != 0)
			{
				NAJCPOPJGLB = other.NAJCPOPJGLB;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.MLLGEOINJOG != 0)
			{
				MLLGEOINJOG = other.MLLGEOINJOG;
			}
			if (other.Status != MBKMLJABCBE.Bnjmpchfina)
			{
				Status = other.Status;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.LLHJAGGEGOK != 0)
			{
				LLHJAGGEGOK = other.LLHJAGGEGOK;
			}
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			if (other.PNCNGMFBAND != 0)
			{
				PNCNGMFBAND = other.PNCNGMFBAND;
			}
			if (other.DDGEOOLHAPG != 0)
			{
				DDGEOOLHAPG = other.DDGEOOLHAPG;
			}
			if (other.GridFightEquipmentId != 0)
			{
				GridFightEquipmentId = other.GridFightEquipmentId;
			}
			if (other.ELEBGNHEIML != 0)
			{
				ELEBGNHEIML = other.ELEBGNHEIML;
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
			case 8u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				Exp = input.ReadUInt32();
				break;
			case 32u:
				NAJCPOPJGLB = input.ReadInt32();
				break;
			case 40u:
				Index = input.ReadUInt32();
				break;
			case 48u:
				MLLGEOINJOG = input.ReadUInt32();
				break;
			case 56u:
				Status = (MBKMLJABCBE)input.ReadEnum();
				break;
			case 64u:
				UniqueId = input.ReadUInt32();
				break;
			case 72u:
				LLHJAGGEGOK = input.ReadUInt32();
				break;
			case 80u:
				Hp = input.ReadInt32();
				break;
			case 88u:
				PNCNGMFBAND = input.ReadUInt32();
				break;
			case 96u:
				DDGEOOLHAPG = input.ReadUInt32();
				break;
			case 112u:
				GridFightEquipmentId = input.ReadUInt32();
				break;
			case 120u:
				ELEBGNHEIML = input.ReadUInt32();
				break;
			}
		}
	}
}
