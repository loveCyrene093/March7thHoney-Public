using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCAOLJLFPBA : IMessage<PCAOLJLFPBA>, IMessage, IEquatable<PCAOLJLFPBA>, IDeepCloneable<PCAOLJLFPBA>, IBufferMessage
{
	private static readonly MessageParser<PCAOLJLFPBA> _parser = new MessageParser<PCAOLJLFPBA>(() => new PCAOLJLFPBA());

	private UnknownFieldSet _unknownFields;

	public const int LLHJAGGEGOKFieldNumber = 1;

	private uint lLHJAGGEGOK_;

	public const int PNCNGMFBANDFieldNumber = 2;

	private uint pNCNGMFBAND_;

	public const int DDGEOOLHAPGFieldNumber = 4;

	private uint dDGEOOLHAPG_;

	public const int ELEBGNHEIMLFieldNumber = 6;

	private uint eLEBGNHEIML_;

	public const int HpFieldNumber = 7;

	private int hp_;

	public const int MLLGEOINJOGFieldNumber = 10;

	private uint mLLGEOINJOG_;

	public const int IndexFieldNumber = 11;

	private uint index_;

	public const int AttackFieldNumber = 14;

	private int attack_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCAOLJLFPBA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCAOLJLFPBAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int Attack
	{
		get
		{
			return attack_;
		}
		set
		{
			attack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAOLJLFPBA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAOLJLFPBA(PCAOLJLFPBA other)
		: this()
	{
		lLHJAGGEGOK_ = other.lLHJAGGEGOK_;
		pNCNGMFBAND_ = other.pNCNGMFBAND_;
		dDGEOOLHAPG_ = other.dDGEOOLHAPG_;
		eLEBGNHEIML_ = other.eLEBGNHEIML_;
		hp_ = other.hp_;
		mLLGEOINJOG_ = other.mLLGEOINJOG_;
		index_ = other.index_;
		attack_ = other.attack_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCAOLJLFPBA Clone()
	{
		return new PCAOLJLFPBA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCAOLJLFPBA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCAOLJLFPBA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLHJAGGEGOK != other.LLHJAGGEGOK)
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
		if (ELEBGNHEIML != other.ELEBGNHEIML)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (MLLGEOINJOG != other.MLLGEOINJOG)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Attack != other.Attack)
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
		if (LLHJAGGEGOK != 0)
		{
			num ^= LLHJAGGEGOK.GetHashCode();
		}
		if (PNCNGMFBAND != 0)
		{
			num ^= PNCNGMFBAND.GetHashCode();
		}
		if (DDGEOOLHAPG != 0)
		{
			num ^= DDGEOOLHAPG.GetHashCode();
		}
		if (ELEBGNHEIML != 0)
		{
			num ^= ELEBGNHEIML.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (MLLGEOINJOG != 0)
		{
			num ^= MLLGEOINJOG.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Attack != 0)
		{
			num ^= Attack.GetHashCode();
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
		if (LLHJAGGEGOK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LLHJAGGEGOK);
		}
		if (PNCNGMFBAND != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PNCNGMFBAND);
		}
		if (DDGEOOLHAPG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DDGEOOLHAPG);
		}
		if (ELEBGNHEIML != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ELEBGNHEIML);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Hp);
		}
		if (MLLGEOINJOG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MLLGEOINJOG);
		}
		if (Index != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Index);
		}
		if (Attack != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Attack);
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
		if (LLHJAGGEGOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLHJAGGEGOK);
		}
		if (PNCNGMFBAND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNCNGMFBAND);
		}
		if (DDGEOOLHAPG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDGEOOLHAPG);
		}
		if (ELEBGNHEIML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ELEBGNHEIML);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (MLLGEOINJOG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLLGEOINJOG);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (Attack != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Attack);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCAOLJLFPBA other)
	{
		if (other != null)
		{
			if (other.LLHJAGGEGOK != 0)
			{
				LLHJAGGEGOK = other.LLHJAGGEGOK;
			}
			if (other.PNCNGMFBAND != 0)
			{
				PNCNGMFBAND = other.PNCNGMFBAND;
			}
			if (other.DDGEOOLHAPG != 0)
			{
				DDGEOOLHAPG = other.DDGEOOLHAPG;
			}
			if (other.ELEBGNHEIML != 0)
			{
				ELEBGNHEIML = other.ELEBGNHEIML;
			}
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			if (other.MLLGEOINJOG != 0)
			{
				MLLGEOINJOG = other.MLLGEOINJOG;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.Attack != 0)
			{
				Attack = other.Attack;
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
				LLHJAGGEGOK = input.ReadUInt32();
				break;
			case 16u:
				PNCNGMFBAND = input.ReadUInt32();
				break;
			case 32u:
				DDGEOOLHAPG = input.ReadUInt32();
				break;
			case 48u:
				ELEBGNHEIML = input.ReadUInt32();
				break;
			case 56u:
				Hp = input.ReadInt32();
				break;
			case 80u:
				MLLGEOINJOG = input.ReadUInt32();
				break;
			case 88u:
				Index = input.ReadUInt32();
				break;
			case 112u:
				Attack = input.ReadInt32();
				break;
			}
		}
	}
}
