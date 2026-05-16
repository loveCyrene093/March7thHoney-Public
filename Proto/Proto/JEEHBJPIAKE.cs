using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JEEHBJPIAKE : IMessage<JEEHBJPIAKE>, IMessage, IEquatable<JEEHBJPIAKE>, IDeepCloneable<JEEHBJPIAKE>, IBufferMessage
{
	private static readonly MessageParser<JEEHBJPIAKE> _parser = new MessageParser<JEEHBJPIAKE>(() => new JEEHBJPIAKE());

	private UnknownFieldSet _unknownFields;

	public const int ABAFOPBHILKFieldNumber = 1;

	private bool aBAFOPBHILK_;

	public const int GFGFEHHHDADFieldNumber = 2;

	private uint gFGFEHHHDAD_;

	public const int AMABBMOCBKDFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aMABBMOCBKD_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aMABBMOCBKD_ = new RepeatedField<uint>();

	public const int AGAPFHKAODLFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_aGAPFHKAODL_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> aGAPFHKAODL_ = new RepeatedField<uint>();

	public const int DBPDDHMAHABFieldNumber = 5;

	private bool dBPDDHMAHAB_;

	public const int JFHKACLKHHCFieldNumber = 6;

	private float jFHKACLKHHC_;

	public const int QueuePositionFieldNumber = 7;

	private uint queuePosition_;

	public const int ExtraIdFieldNumber = 8;

	private uint extraId_;

	public const int NIIEKCMBENIFieldNumber = 9;

	private uint nIIEKCMBENI_;

	public const int IPBOBNMLNHPFieldNumber = 10;

	private uint iPBOBNMLNHP_;

	public const int DFAKOMHIBGJFieldNumber = 11;

	private static readonly FieldCodec<CCNFGGMIKJF> _repeated_dFAKOMHIBGJ_codec = FieldCodec.ForMessage(90u, CCNFGGMIKJF.Parser);

	private readonly RepeatedField<CCNFGGMIKJF> dFAKOMHIBGJ_ = new RepeatedField<CCNFGGMIKJF>();

	public const int DNPIEJNNJJMFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_dNPIEJNNJJM_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> dNPIEJNNJJM_ = new RepeatedField<uint>();

	public const int FJLDAACGJGIFieldNumber = 13;

	private uint fJLDAACGJGI_;

	public const int APEBCDDKGOGFieldNumber = 14;

	private uint aPEBCDDKGOG_;

	public const int GOKEOHPOMDCFieldNumber = 15;

	private KJEAGFEINEB gOKEOHPOMDC_;

	public const int MAILGEJLKENFieldNumber = 769;

	private uint mAILGEJLKEN_;

	public const int MLJDIDHMJMJFieldNumber = 806;

	private bool mLJDIDHMJMJ_;

	public const int DDMMMPFPOALFieldNumber = 1426;

	private uint dDMMMPFPOAL_;

	public const int KCJMNLDPMKIFieldNumber = 1592;

	private static readonly FieldCodec<CCNFGGMIKJF> _repeated_kCJMNLDPMKI_codec = FieldCodec.ForMessage(12738u, CCNFGGMIKJF.Parser);

	private readonly RepeatedField<CCNFGGMIKJF> kCJMNLDPMKI_ = new RepeatedField<CCNFGGMIKJF>();

	public const int DOHDEDHOOLLFieldNumber = 1915;

	private uint dOHDEDHOOLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JEEHBJPIAKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JEEHBJPIAKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ABAFOPBHILK
	{
		get
		{
			return aBAFOPBHILK_;
		}
		set
		{
			aBAFOPBHILK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFGFEHHHDAD
	{
		get
		{
			return gFGFEHHHDAD_;
		}
		set
		{
			gFGFEHHHDAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AMABBMOCBKD => aMABBMOCBKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AGAPFHKAODL => aGAPFHKAODL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DBPDDHMAHAB
	{
		get
		{
			return dBPDDHMAHAB_;
		}
		set
		{
			dBPDDHMAHAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float JFHKACLKHHC
	{
		get
		{
			return jFHKACLKHHC_;
		}
		set
		{
			jFHKACLKHHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExtraId
	{
		get
		{
			return extraId_;
		}
		set
		{
			extraId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NIIEKCMBENI
	{
		get
		{
			return nIIEKCMBENI_;
		}
		set
		{
			nIIEKCMBENI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPBOBNMLNHP
	{
		get
		{
			return iPBOBNMLNHP_;
		}
		set
		{
			iPBOBNMLNHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCNFGGMIKJF> DFAKOMHIBGJ => dFAKOMHIBGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DNPIEJNNJJM => dNPIEJNNJJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJLDAACGJGI
	{
		get
		{
			return fJLDAACGJGI_;
		}
		set
		{
			fJLDAACGJGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APEBCDDKGOG
	{
		get
		{
			return aPEBCDDKGOG_;
		}
		set
		{
			aPEBCDDKGOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJEAGFEINEB GOKEOHPOMDC
	{
		get
		{
			return gOKEOHPOMDC_;
		}
		set
		{
			gOKEOHPOMDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAILGEJLKEN
	{
		get
		{
			return mAILGEJLKEN_;
		}
		set
		{
			mAILGEJLKEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MLJDIDHMJMJ
	{
		get
		{
			return mLJDIDHMJMJ_;
		}
		set
		{
			mLJDIDHMJMJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDMMMPFPOAL
	{
		get
		{
			return dDMMMPFPOAL_;
		}
		set
		{
			dDMMMPFPOAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCNFGGMIKJF> KCJMNLDPMKI => kCJMNLDPMKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOHDEDHOOLL
	{
		get
		{
			return dOHDEDHOOLL_;
		}
		set
		{
			dOHDEDHOOLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEHBJPIAKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEHBJPIAKE(JEEHBJPIAKE other)
		: this()
	{
		aBAFOPBHILK_ = other.aBAFOPBHILK_;
		gFGFEHHHDAD_ = other.gFGFEHHHDAD_;
		aMABBMOCBKD_ = other.aMABBMOCBKD_.Clone();
		aGAPFHKAODL_ = other.aGAPFHKAODL_.Clone();
		dBPDDHMAHAB_ = other.dBPDDHMAHAB_;
		jFHKACLKHHC_ = other.jFHKACLKHHC_;
		queuePosition_ = other.queuePosition_;
		extraId_ = other.extraId_;
		nIIEKCMBENI_ = other.nIIEKCMBENI_;
		iPBOBNMLNHP_ = other.iPBOBNMLNHP_;
		dFAKOMHIBGJ_ = other.dFAKOMHIBGJ_.Clone();
		dNPIEJNNJJM_ = other.dNPIEJNNJJM_.Clone();
		fJLDAACGJGI_ = other.fJLDAACGJGI_;
		aPEBCDDKGOG_ = other.aPEBCDDKGOG_;
		gOKEOHPOMDC_ = other.gOKEOHPOMDC_;
		mAILGEJLKEN_ = other.mAILGEJLKEN_;
		mLJDIDHMJMJ_ = other.mLJDIDHMJMJ_;
		dDMMMPFPOAL_ = other.dDMMMPFPOAL_;
		kCJMNLDPMKI_ = other.kCJMNLDPMKI_.Clone();
		dOHDEDHOOLL_ = other.dOHDEDHOOLL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEHBJPIAKE Clone()
	{
		return new JEEHBJPIAKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JEEHBJPIAKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JEEHBJPIAKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ABAFOPBHILK != other.ABAFOPBHILK)
		{
			return false;
		}
		if (GFGFEHHHDAD != other.GFGFEHHHDAD)
		{
			return false;
		}
		if (!aMABBMOCBKD_.Equals(other.aMABBMOCBKD_))
		{
			return false;
		}
		if (!aGAPFHKAODL_.Equals(other.aGAPFHKAODL_))
		{
			return false;
		}
		if (DBPDDHMAHAB != other.DBPDDHMAHAB)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JFHKACLKHHC, other.JFHKACLKHHC))
		{
			return false;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (ExtraId != other.ExtraId)
		{
			return false;
		}
		if (NIIEKCMBENI != other.NIIEKCMBENI)
		{
			return false;
		}
		if (IPBOBNMLNHP != other.IPBOBNMLNHP)
		{
			return false;
		}
		if (!dFAKOMHIBGJ_.Equals(other.dFAKOMHIBGJ_))
		{
			return false;
		}
		if (!dNPIEJNNJJM_.Equals(other.dNPIEJNNJJM_))
		{
			return false;
		}
		if (FJLDAACGJGI != other.FJLDAACGJGI)
		{
			return false;
		}
		if (APEBCDDKGOG != other.APEBCDDKGOG)
		{
			return false;
		}
		if (GOKEOHPOMDC != other.GOKEOHPOMDC)
		{
			return false;
		}
		if (MAILGEJLKEN != other.MAILGEJLKEN)
		{
			return false;
		}
		if (MLJDIDHMJMJ != other.MLJDIDHMJMJ)
		{
			return false;
		}
		if (DDMMMPFPOAL != other.DDMMMPFPOAL)
		{
			return false;
		}
		if (!kCJMNLDPMKI_.Equals(other.kCJMNLDPMKI_))
		{
			return false;
		}
		if (DOHDEDHOOLL != other.DOHDEDHOOLL)
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
		if (ABAFOPBHILK)
		{
			num ^= ABAFOPBHILK.GetHashCode();
		}
		if (GFGFEHHHDAD != 0)
		{
			num ^= GFGFEHHHDAD.GetHashCode();
		}
		num ^= aMABBMOCBKD_.GetHashCode();
		num ^= aGAPFHKAODL_.GetHashCode();
		if (DBPDDHMAHAB)
		{
			num ^= DBPDDHMAHAB.GetHashCode();
		}
		if (JFHKACLKHHC != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JFHKACLKHHC);
		}
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (ExtraId != 0)
		{
			num ^= ExtraId.GetHashCode();
		}
		if (NIIEKCMBENI != 0)
		{
			num ^= NIIEKCMBENI.GetHashCode();
		}
		if (IPBOBNMLNHP != 0)
		{
			num ^= IPBOBNMLNHP.GetHashCode();
		}
		num ^= dFAKOMHIBGJ_.GetHashCode();
		num ^= dNPIEJNNJJM_.GetHashCode();
		if (FJLDAACGJGI != 0)
		{
			num ^= FJLDAACGJGI.GetHashCode();
		}
		if (APEBCDDKGOG != 0)
		{
			num ^= APEBCDDKGOG.GetHashCode();
		}
		if (GOKEOHPOMDC != KJEAGFEINEB.Amdbenagmbh)
		{
			num ^= GOKEOHPOMDC.GetHashCode();
		}
		if (MAILGEJLKEN != 0)
		{
			num ^= MAILGEJLKEN.GetHashCode();
		}
		if (MLJDIDHMJMJ)
		{
			num ^= MLJDIDHMJMJ.GetHashCode();
		}
		if (DDMMMPFPOAL != 0)
		{
			num ^= DDMMMPFPOAL.GetHashCode();
		}
		num ^= kCJMNLDPMKI_.GetHashCode();
		if (DOHDEDHOOLL != 0)
		{
			num ^= DOHDEDHOOLL.GetHashCode();
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
		if (ABAFOPBHILK)
		{
			output.WriteRawTag(8);
			output.WriteBool(ABAFOPBHILK);
		}
		if (GFGFEHHHDAD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GFGFEHHHDAD);
		}
		aMABBMOCBKD_.WriteTo(ref output, _repeated_aMABBMOCBKD_codec);
		aGAPFHKAODL_.WriteTo(ref output, _repeated_aGAPFHKAODL_codec);
		if (DBPDDHMAHAB)
		{
			output.WriteRawTag(40);
			output.WriteBool(DBPDDHMAHAB);
		}
		if (JFHKACLKHHC != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(JFHKACLKHHC);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(QueuePosition);
		}
		if (ExtraId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ExtraId);
		}
		if (NIIEKCMBENI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NIIEKCMBENI);
		}
		if (IPBOBNMLNHP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IPBOBNMLNHP);
		}
		dFAKOMHIBGJ_.WriteTo(ref output, _repeated_dFAKOMHIBGJ_codec);
		dNPIEJNNJJM_.WriteTo(ref output, _repeated_dNPIEJNNJJM_codec);
		if (FJLDAACGJGI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FJLDAACGJGI);
		}
		if (APEBCDDKGOG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(APEBCDDKGOG);
		}
		if (GOKEOHPOMDC != KJEAGFEINEB.Amdbenagmbh)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)GOKEOHPOMDC);
		}
		if (MAILGEJLKEN != 0)
		{
			output.WriteRawTag(136, 48);
			output.WriteUInt32(MAILGEJLKEN);
		}
		if (MLJDIDHMJMJ)
		{
			output.WriteRawTag(176, 50);
			output.WriteBool(MLJDIDHMJMJ);
		}
		if (DDMMMPFPOAL != 0)
		{
			output.WriteRawTag(144, 89);
			output.WriteUInt32(DDMMMPFPOAL);
		}
		kCJMNLDPMKI_.WriteTo(ref output, _repeated_kCJMNLDPMKI_codec);
		if (DOHDEDHOOLL != 0)
		{
			output.WriteRawTag(216, 119);
			output.WriteUInt32(DOHDEDHOOLL);
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
		if (ABAFOPBHILK)
		{
			num += 2;
		}
		if (GFGFEHHHDAD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFGFEHHHDAD);
		}
		num += aMABBMOCBKD_.CalculateSize(_repeated_aMABBMOCBKD_codec);
		num += aGAPFHKAODL_.CalculateSize(_repeated_aGAPFHKAODL_codec);
		if (DBPDDHMAHAB)
		{
			num += 2;
		}
		if (JFHKACLKHHC != 0f)
		{
			num += 5;
		}
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (ExtraId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExtraId);
		}
		if (NIIEKCMBENI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIIEKCMBENI);
		}
		if (IPBOBNMLNHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPBOBNMLNHP);
		}
		num += dFAKOMHIBGJ_.CalculateSize(_repeated_dFAKOMHIBGJ_codec);
		num += dNPIEJNNJJM_.CalculateSize(_repeated_dNPIEJNNJJM_codec);
		if (FJLDAACGJGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJLDAACGJGI);
		}
		if (APEBCDDKGOG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APEBCDDKGOG);
		}
		if (GOKEOHPOMDC != KJEAGFEINEB.Amdbenagmbh)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GOKEOHPOMDC);
		}
		if (MAILGEJLKEN != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(MAILGEJLKEN);
		}
		if (MLJDIDHMJMJ)
		{
			num += 3;
		}
		if (DDMMMPFPOAL != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DDMMMPFPOAL);
		}
		num += kCJMNLDPMKI_.CalculateSize(_repeated_kCJMNLDPMKI_codec);
		if (DOHDEDHOOLL != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(DOHDEDHOOLL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JEEHBJPIAKE other)
	{
		if (other != null)
		{
			if (other.ABAFOPBHILK)
			{
				ABAFOPBHILK = other.ABAFOPBHILK;
			}
			if (other.GFGFEHHHDAD != 0)
			{
				GFGFEHHHDAD = other.GFGFEHHHDAD;
			}
			aMABBMOCBKD_.Add(other.aMABBMOCBKD_);
			aGAPFHKAODL_.Add(other.aGAPFHKAODL_);
			if (other.DBPDDHMAHAB)
			{
				DBPDDHMAHAB = other.DBPDDHMAHAB;
			}
			if (other.JFHKACLKHHC != 0f)
			{
				JFHKACLKHHC = other.JFHKACLKHHC;
			}
			if (other.QueuePosition != 0)
			{
				QueuePosition = other.QueuePosition;
			}
			if (other.ExtraId != 0)
			{
				ExtraId = other.ExtraId;
			}
			if (other.NIIEKCMBENI != 0)
			{
				NIIEKCMBENI = other.NIIEKCMBENI;
			}
			if (other.IPBOBNMLNHP != 0)
			{
				IPBOBNMLNHP = other.IPBOBNMLNHP;
			}
			dFAKOMHIBGJ_.Add(other.dFAKOMHIBGJ_);
			dNPIEJNNJJM_.Add(other.dNPIEJNNJJM_);
			if (other.FJLDAACGJGI != 0)
			{
				FJLDAACGJGI = other.FJLDAACGJGI;
			}
			if (other.APEBCDDKGOG != 0)
			{
				APEBCDDKGOG = other.APEBCDDKGOG;
			}
			if (other.GOKEOHPOMDC != KJEAGFEINEB.Amdbenagmbh)
			{
				GOKEOHPOMDC = other.GOKEOHPOMDC;
			}
			if (other.MAILGEJLKEN != 0)
			{
				MAILGEJLKEN = other.MAILGEJLKEN;
			}
			if (other.MLJDIDHMJMJ)
			{
				MLJDIDHMJMJ = other.MLJDIDHMJMJ;
			}
			if (other.DDMMMPFPOAL != 0)
			{
				DDMMMPFPOAL = other.DDMMMPFPOAL;
			}
			kCJMNLDPMKI_.Add(other.kCJMNLDPMKI_);
			if (other.DOHDEDHOOLL != 0)
			{
				DOHDEDHOOLL = other.DOHDEDHOOLL;
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
				ABAFOPBHILK = input.ReadBool();
				break;
			case 16u:
				GFGFEHHHDAD = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				aMABBMOCBKD_.AddEntriesFrom(ref input, _repeated_aMABBMOCBKD_codec);
				break;
			case 32u:
			case 34u:
				aGAPFHKAODL_.AddEntriesFrom(ref input, _repeated_aGAPFHKAODL_codec);
				break;
			case 40u:
				DBPDDHMAHAB = input.ReadBool();
				break;
			case 53u:
				JFHKACLKHHC = input.ReadFloat();
				break;
			case 56u:
				QueuePosition = input.ReadUInt32();
				break;
			case 64u:
				ExtraId = input.ReadUInt32();
				break;
			case 72u:
				NIIEKCMBENI = input.ReadUInt32();
				break;
			case 80u:
				IPBOBNMLNHP = input.ReadUInt32();
				break;
			case 90u:
				dFAKOMHIBGJ_.AddEntriesFrom(ref input, _repeated_dFAKOMHIBGJ_codec);
				break;
			case 96u:
			case 98u:
				dNPIEJNNJJM_.AddEntriesFrom(ref input, _repeated_dNPIEJNNJJM_codec);
				break;
			case 104u:
				FJLDAACGJGI = input.ReadUInt32();
				break;
			case 112u:
				APEBCDDKGOG = input.ReadUInt32();
				break;
			case 120u:
				GOKEOHPOMDC = (KJEAGFEINEB)input.ReadEnum();
				break;
			case 6152u:
				MAILGEJLKEN = input.ReadUInt32();
				break;
			case 6448u:
				MLJDIDHMJMJ = input.ReadBool();
				break;
			case 11408u:
				DDMMMPFPOAL = input.ReadUInt32();
				break;
			case 12738u:
				kCJMNLDPMKI_.AddEntriesFrom(ref input, _repeated_kCJMNLDPMKI_codec);
				break;
			case 15320u:
				DOHDEDHOOLL = input.ReadUInt32();
				break;
			}
		}
	}
}
