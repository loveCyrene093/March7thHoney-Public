using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPGJPLKHLKJ : IMessage<OPGJPLKHLKJ>, IMessage, IEquatable<OPGJPLKHLKJ>, IDeepCloneable<OPGJPLKHLKJ>, IBufferMessage
{
	private static readonly MessageParser<OPGJPLKHLKJ> _parser = new MessageParser<OPGJPLKHLKJ>(() => new OPGJPLKHLKJ());

	private UnknownFieldSet _unknownFields;

	public const int DJJNGGFBAOGFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dJJNGGFBAOG_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dJJNGGFBAOG_ = new RepeatedField<uint>();

	public const int PPGOFLDJPIOFieldNumber = 2;

	private uint pPGOFLDJPIO_;

	public const int FJBFCPBLNLEFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_fJBFCPBLNLE_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> fJBFCPBLNLE_ = new RepeatedField<uint>();

	public const int BEDKAHEBGCCFieldNumber = 4;

	private uint bEDKAHEBGCC_;

	public const int IOJKDGCFCGGFieldNumber = 5;

	private uint iOJKDGCFCGG_;

	public const int AKHDCMLBGKNFieldNumber = 6;

	private uint aKHDCMLBGKN_;

	public const int GLDAEMLKJJHFieldNumber = 7;

	private BCKFECKKLOH gLDAEMLKJJH_;

	public const int ADCJOJMPNPHFieldNumber = 8;

	private uint aDCJOJMPNPH_;

	public const int HLJPCIDLCKAFieldNumber = 9;

	private uint hLJPCIDLCKA_;

	public const int GDOHPMLEMAEFieldNumber = 10;

	private uint gDOHPMLEMAE_;

	public const int EMPIGIEDOMOFieldNumber = 11;

	private uint eMPIGIEDOMO_;

	public const int GHIBGEBPOCGFieldNumber = 12;

	private bool gHIBGEBPOCG_;

	public const int LevelIdFieldNumber = 13;

	private uint levelId_;

	public const int ADAPELOIGCIFieldNumber = 14;

	private BCKFECKKLOH aDAPELOIGCI_;

	public const int GBLEFAMKILBFieldNumber = 15;

	private bool gBLEFAMKILB_;

	public const int BIEBFHECEPMFieldNumber = 493;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(3946u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPGJPLKHLKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPGJPLKHLKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DJJNGGFBAOG => dJJNGGFBAOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPGOFLDJPIO
	{
		get
		{
			return pPGOFLDJPIO_;
		}
		set
		{
			pPGOFLDJPIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FJBFCPBLNLE => fJBFCPBLNLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEDKAHEBGCC
	{
		get
		{
			return bEDKAHEBGCC_;
		}
		set
		{
			bEDKAHEBGCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IOJKDGCFCGG
	{
		get
		{
			return iOJKDGCFCGG_;
		}
		set
		{
			iOJKDGCFCGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKHDCMLBGKN
	{
		get
		{
			return aKHDCMLBGKN_;
		}
		set
		{
			aKHDCMLBGKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCKFECKKLOH GLDAEMLKJJH
	{
		get
		{
			return gLDAEMLKJJH_;
		}
		set
		{
			gLDAEMLKJJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ADCJOJMPNPH
	{
		get
		{
			return aDCJOJMPNPH_;
		}
		set
		{
			aDCJOJMPNPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HLJPCIDLCKA
	{
		get
		{
			return hLJPCIDLCKA_;
		}
		set
		{
			hLJPCIDLCKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDOHPMLEMAE
	{
		get
		{
			return gDOHPMLEMAE_;
		}
		set
		{
			gDOHPMLEMAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMPIGIEDOMO
	{
		get
		{
			return eMPIGIEDOMO_;
		}
		set
		{
			eMPIGIEDOMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GHIBGEBPOCG
	{
		get
		{
			return gHIBGEBPOCG_;
		}
		set
		{
			gHIBGEBPOCG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCKFECKKLOH ADAPELOIGCI
	{
		get
		{
			return aDAPELOIGCI_;
		}
		set
		{
			aDAPELOIGCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GBLEFAMKILB
	{
		get
		{
			return gBLEFAMKILB_;
		}
		set
		{
			gBLEFAMKILB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPGJPLKHLKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPGJPLKHLKJ(OPGJPLKHLKJ other)
		: this()
	{
		dJJNGGFBAOG_ = other.dJJNGGFBAOG_.Clone();
		pPGOFLDJPIO_ = other.pPGOFLDJPIO_;
		fJBFCPBLNLE_ = other.fJBFCPBLNLE_.Clone();
		bEDKAHEBGCC_ = other.bEDKAHEBGCC_;
		iOJKDGCFCGG_ = other.iOJKDGCFCGG_;
		aKHDCMLBGKN_ = other.aKHDCMLBGKN_;
		gLDAEMLKJJH_ = other.gLDAEMLKJJH_;
		aDCJOJMPNPH_ = other.aDCJOJMPNPH_;
		hLJPCIDLCKA_ = other.hLJPCIDLCKA_;
		gDOHPMLEMAE_ = other.gDOHPMLEMAE_;
		eMPIGIEDOMO_ = other.eMPIGIEDOMO_;
		gHIBGEBPOCG_ = other.gHIBGEBPOCG_;
		levelId_ = other.levelId_;
		aDAPELOIGCI_ = other.aDAPELOIGCI_;
		gBLEFAMKILB_ = other.gBLEFAMKILB_;
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPGJPLKHLKJ Clone()
	{
		return new OPGJPLKHLKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPGJPLKHLKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPGJPLKHLKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dJJNGGFBAOG_.Equals(other.dJJNGGFBAOG_))
		{
			return false;
		}
		if (PPGOFLDJPIO != other.PPGOFLDJPIO)
		{
			return false;
		}
		if (!fJBFCPBLNLE_.Equals(other.fJBFCPBLNLE_))
		{
			return false;
		}
		if (BEDKAHEBGCC != other.BEDKAHEBGCC)
		{
			return false;
		}
		if (IOJKDGCFCGG != other.IOJKDGCFCGG)
		{
			return false;
		}
		if (AKHDCMLBGKN != other.AKHDCMLBGKN)
		{
			return false;
		}
		if (GLDAEMLKJJH != other.GLDAEMLKJJH)
		{
			return false;
		}
		if (ADCJOJMPNPH != other.ADCJOJMPNPH)
		{
			return false;
		}
		if (HLJPCIDLCKA != other.HLJPCIDLCKA)
		{
			return false;
		}
		if (GDOHPMLEMAE != other.GDOHPMLEMAE)
		{
			return false;
		}
		if (EMPIGIEDOMO != other.EMPIGIEDOMO)
		{
			return false;
		}
		if (GHIBGEBPOCG != other.GHIBGEBPOCG)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (ADAPELOIGCI != other.ADAPELOIGCI)
		{
			return false;
		}
		if (GBLEFAMKILB != other.GBLEFAMKILB)
		{
			return false;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
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
		num ^= dJJNGGFBAOG_.GetHashCode();
		if (PPGOFLDJPIO != 0)
		{
			num ^= PPGOFLDJPIO.GetHashCode();
		}
		num ^= fJBFCPBLNLE_.GetHashCode();
		if (BEDKAHEBGCC != 0)
		{
			num ^= BEDKAHEBGCC.GetHashCode();
		}
		if (IOJKDGCFCGG != 0)
		{
			num ^= IOJKDGCFCGG.GetHashCode();
		}
		if (AKHDCMLBGKN != 0)
		{
			num ^= AKHDCMLBGKN.GetHashCode();
		}
		if (GLDAEMLKJJH != BCKFECKKLOH.Jokempeliib)
		{
			num ^= GLDAEMLKJJH.GetHashCode();
		}
		if (ADCJOJMPNPH != 0)
		{
			num ^= ADCJOJMPNPH.GetHashCode();
		}
		if (HLJPCIDLCKA != 0)
		{
			num ^= HLJPCIDLCKA.GetHashCode();
		}
		if (GDOHPMLEMAE != 0)
		{
			num ^= GDOHPMLEMAE.GetHashCode();
		}
		if (EMPIGIEDOMO != 0)
		{
			num ^= EMPIGIEDOMO.GetHashCode();
		}
		if (GHIBGEBPOCG)
		{
			num ^= GHIBGEBPOCG.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (ADAPELOIGCI != BCKFECKKLOH.Jokempeliib)
		{
			num ^= ADAPELOIGCI.GetHashCode();
		}
		if (GBLEFAMKILB)
		{
			num ^= GBLEFAMKILB.GetHashCode();
		}
		num ^= bIEBFHECEPM_.GetHashCode();
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
		dJJNGGFBAOG_.WriteTo(ref output, _repeated_dJJNGGFBAOG_codec);
		if (PPGOFLDJPIO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PPGOFLDJPIO);
		}
		fJBFCPBLNLE_.WriteTo(ref output, _repeated_fJBFCPBLNLE_codec);
		if (BEDKAHEBGCC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BEDKAHEBGCC);
		}
		if (IOJKDGCFCGG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IOJKDGCFCGG);
		}
		if (AKHDCMLBGKN != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AKHDCMLBGKN);
		}
		if (GLDAEMLKJJH != BCKFECKKLOH.Jokempeliib)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)GLDAEMLKJJH);
		}
		if (ADCJOJMPNPH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ADCJOJMPNPH);
		}
		if (HLJPCIDLCKA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HLJPCIDLCKA);
		}
		if (GDOHPMLEMAE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GDOHPMLEMAE);
		}
		if (EMPIGIEDOMO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EMPIGIEDOMO);
		}
		if (GHIBGEBPOCG)
		{
			output.WriteRawTag(96);
			output.WriteBool(GHIBGEBPOCG);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LevelId);
		}
		if (ADAPELOIGCI != BCKFECKKLOH.Jokempeliib)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)ADAPELOIGCI);
		}
		if (GBLEFAMKILB)
		{
			output.WriteRawTag(120);
			output.WriteBool(GBLEFAMKILB);
		}
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
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
		num += dJJNGGFBAOG_.CalculateSize(_repeated_dJJNGGFBAOG_codec);
		if (PPGOFLDJPIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPGOFLDJPIO);
		}
		num += fJBFCPBLNLE_.CalculateSize(_repeated_fJBFCPBLNLE_codec);
		if (BEDKAHEBGCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEDKAHEBGCC);
		}
		if (IOJKDGCFCGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IOJKDGCFCGG);
		}
		if (AKHDCMLBGKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AKHDCMLBGKN);
		}
		if (GLDAEMLKJJH != BCKFECKKLOH.Jokempeliib)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GLDAEMLKJJH);
		}
		if (ADCJOJMPNPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ADCJOJMPNPH);
		}
		if (HLJPCIDLCKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HLJPCIDLCKA);
		}
		if (GDOHPMLEMAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDOHPMLEMAE);
		}
		if (EMPIGIEDOMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMPIGIEDOMO);
		}
		if (GHIBGEBPOCG)
		{
			num += 2;
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (ADAPELOIGCI != BCKFECKKLOH.Jokempeliib)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ADAPELOIGCI);
		}
		if (GBLEFAMKILB)
		{
			num += 2;
		}
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPGJPLKHLKJ other)
	{
		if (other != null)
		{
			dJJNGGFBAOG_.Add(other.dJJNGGFBAOG_);
			if (other.PPGOFLDJPIO != 0)
			{
				PPGOFLDJPIO = other.PPGOFLDJPIO;
			}
			fJBFCPBLNLE_.Add(other.fJBFCPBLNLE_);
			if (other.BEDKAHEBGCC != 0)
			{
				BEDKAHEBGCC = other.BEDKAHEBGCC;
			}
			if (other.IOJKDGCFCGG != 0)
			{
				IOJKDGCFCGG = other.IOJKDGCFCGG;
			}
			if (other.AKHDCMLBGKN != 0)
			{
				AKHDCMLBGKN = other.AKHDCMLBGKN;
			}
			if (other.GLDAEMLKJJH != BCKFECKKLOH.Jokempeliib)
			{
				GLDAEMLKJJH = other.GLDAEMLKJJH;
			}
			if (other.ADCJOJMPNPH != 0)
			{
				ADCJOJMPNPH = other.ADCJOJMPNPH;
			}
			if (other.HLJPCIDLCKA != 0)
			{
				HLJPCIDLCKA = other.HLJPCIDLCKA;
			}
			if (other.GDOHPMLEMAE != 0)
			{
				GDOHPMLEMAE = other.GDOHPMLEMAE;
			}
			if (other.EMPIGIEDOMO != 0)
			{
				EMPIGIEDOMO = other.EMPIGIEDOMO;
			}
			if (other.GHIBGEBPOCG)
			{
				GHIBGEBPOCG = other.GHIBGEBPOCG;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.ADAPELOIGCI != BCKFECKKLOH.Jokempeliib)
			{
				ADAPELOIGCI = other.ADAPELOIGCI;
			}
			if (other.GBLEFAMKILB)
			{
				GBLEFAMKILB = other.GBLEFAMKILB;
			}
			bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
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
			case 10u:
				dJJNGGFBAOG_.AddEntriesFrom(ref input, _repeated_dJJNGGFBAOG_codec);
				break;
			case 16u:
				PPGOFLDJPIO = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				fJBFCPBLNLE_.AddEntriesFrom(ref input, _repeated_fJBFCPBLNLE_codec);
				break;
			case 32u:
				BEDKAHEBGCC = input.ReadUInt32();
				break;
			case 40u:
				IOJKDGCFCGG = input.ReadUInt32();
				break;
			case 48u:
				AKHDCMLBGKN = input.ReadUInt32();
				break;
			case 56u:
				GLDAEMLKJJH = (BCKFECKKLOH)input.ReadEnum();
				break;
			case 64u:
				ADCJOJMPNPH = input.ReadUInt32();
				break;
			case 72u:
				HLJPCIDLCKA = input.ReadUInt32();
				break;
			case 80u:
				GDOHPMLEMAE = input.ReadUInt32();
				break;
			case 88u:
				EMPIGIEDOMO = input.ReadUInt32();
				break;
			case 96u:
				GHIBGEBPOCG = input.ReadBool();
				break;
			case 104u:
				LevelId = input.ReadUInt32();
				break;
			case 112u:
				ADAPELOIGCI = (BCKFECKKLOH)input.ReadEnum();
				break;
			case 120u:
				GBLEFAMKILB = input.ReadBool();
				break;
			case 3946u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			}
		}
	}
}
