using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IEACMDFDLBF : IMessage<IEACMDFDLBF>, IMessage, IEquatable<IEACMDFDLBF>, IDeepCloneable<IEACMDFDLBF>, IBufferMessage
{
	public enum KPPNKFGPNHNOneofCase
	{
		None = 0,
		Lineup = 10,
		CGCJLHFLEPN = 11,
		PJIGHNFHFKD = 12,
		KFPKHHAOGPP = 13,
		LEFOIGFGJGJ = 14
	}

	private static readonly MessageParser<IEACMDFDLBF> _parser = new MessageParser<IEACMDFDLBF>(() => new IEACMDFDLBF());

	private UnknownFieldSet _unknownFields;

	public const int LineupFieldNumber = 10;

	public const int CGCJLHFLEPNFieldNumber = 11;

	public const int PJIGHNFHFKDFieldNumber = 12;

	public const int KFPKHHAOGPPFieldNumber = 13;

	public const int LEFOIGFGJGJFieldNumber = 14;

	private object kPPNKFGPNHN_;

	private KPPNKFGPNHNOneofCase kPPNKFGPNHNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IEACMDFDLBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IEACMDFDLBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DHKFLIKNMJO Lineup
	{
		get
		{
			if (kPPNKFGPNHNCase_ != KPPNKFGPNHNOneofCase.Lineup)
			{
				return null;
			}
			return (DHKFLIKNMJO)kPPNKFGPNHN_;
		}
		set
		{
			kPPNKFGPNHN_ = value;
			kPPNKFGPNHNCase_ = ((value != null) ? KPPNKFGPNHNOneofCase.Lineup : KPPNKFGPNHNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPHLEOBMMKM CGCJLHFLEPN
	{
		get
		{
			if (kPPNKFGPNHNCase_ != KPPNKFGPNHNOneofCase.CGCJLHFLEPN)
			{
				return null;
			}
			return (BPHLEOBMMKM)kPPNKFGPNHN_;
		}
		set
		{
			kPPNKFGPNHN_ = value;
			kPPNKFGPNHNCase_ = ((value != null) ? KPPNKFGPNHNOneofCase.CGCJLHFLEPN : KPPNKFGPNHNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFIFNMIIOHF PJIGHNFHFKD
	{
		get
		{
			if (kPPNKFGPNHNCase_ != KPPNKFGPNHNOneofCase.PJIGHNFHFKD)
			{
				return null;
			}
			return (PFIFNMIIOHF)kPPNKFGPNHN_;
		}
		set
		{
			kPPNKFGPNHN_ = value;
			kPPNKFGPNHNCase_ = ((value != null) ? KPPNKFGPNHNOneofCase.PJIGHNFHFKD : KPPNKFGPNHNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJEDAOPDIPM KFPKHHAOGPP
	{
		get
		{
			if (kPPNKFGPNHNCase_ != KPPNKFGPNHNOneofCase.KFPKHHAOGPP)
			{
				return null;
			}
			return (MJEDAOPDIPM)kPPNKFGPNHN_;
		}
		set
		{
			kPPNKFGPNHN_ = value;
			kPPNKFGPNHNCase_ = ((value != null) ? KPPNKFGPNHNOneofCase.KFPKHHAOGPP : KPPNKFGPNHNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJAIHNBKEM LEFOIGFGJGJ
	{
		get
		{
			if (kPPNKFGPNHNCase_ != KPPNKFGPNHNOneofCase.LEFOIGFGJGJ)
			{
				return null;
			}
			return (CLJAIHNBKEM)kPPNKFGPNHN_;
		}
		set
		{
			kPPNKFGPNHN_ = value;
			kPPNKFGPNHNCase_ = ((value != null) ? KPPNKFGPNHNOneofCase.LEFOIGFGJGJ : KPPNKFGPNHNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPPNKFGPNHNOneofCase KPPNKFGPNHNCase => kPPNKFGPNHNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEACMDFDLBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEACMDFDLBF(IEACMDFDLBF other)
		: this()
	{
		switch (other.KPPNKFGPNHNCase)
		{
		case KPPNKFGPNHNOneofCase.Lineup:
			Lineup = other.Lineup.Clone();
			break;
		case KPPNKFGPNHNOneofCase.CGCJLHFLEPN:
			CGCJLHFLEPN = other.CGCJLHFLEPN.Clone();
			break;
		case KPPNKFGPNHNOneofCase.PJIGHNFHFKD:
			PJIGHNFHFKD = other.PJIGHNFHFKD.Clone();
			break;
		case KPPNKFGPNHNOneofCase.KFPKHHAOGPP:
			KFPKHHAOGPP = other.KFPKHHAOGPP.Clone();
			break;
		case KPPNKFGPNHNOneofCase.LEFOIGFGJGJ:
			LEFOIGFGJGJ = other.LEFOIGFGJGJ.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEACMDFDLBF Clone()
	{
		return new IEACMDFDLBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKPPNKFGPNHN()
	{
		kPPNKFGPNHNCase_ = KPPNKFGPNHNOneofCase.None;
		kPPNKFGPNHN_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IEACMDFDLBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IEACMDFDLBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!object.Equals(CGCJLHFLEPN, other.CGCJLHFLEPN))
		{
			return false;
		}
		if (!object.Equals(PJIGHNFHFKD, other.PJIGHNFHFKD))
		{
			return false;
		}
		if (!object.Equals(KFPKHHAOGPP, other.KFPKHHAOGPP))
		{
			return false;
		}
		if (!object.Equals(LEFOIGFGJGJ, other.LEFOIGFGJGJ))
		{
			return false;
		}
		if (KPPNKFGPNHNCase != other.KPPNKFGPNHNCase)
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
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.Lineup)
		{
			num ^= Lineup.GetHashCode();
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.CGCJLHFLEPN)
		{
			num ^= CGCJLHFLEPN.GetHashCode();
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.PJIGHNFHFKD)
		{
			num ^= PJIGHNFHFKD.GetHashCode();
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.KFPKHHAOGPP)
		{
			num ^= KFPKHHAOGPP.GetHashCode();
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.LEFOIGFGJGJ)
		{
			num ^= LEFOIGFGJGJ.GetHashCode();
		}
		num ^= (int)kPPNKFGPNHNCase_;
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
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.Lineup)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Lineup);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.CGCJLHFLEPN)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CGCJLHFLEPN);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.PJIGHNFHFKD)
		{
			output.WriteRawTag(98);
			output.WriteMessage(PJIGHNFHFKD);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.KFPKHHAOGPP)
		{
			output.WriteRawTag(106);
			output.WriteMessage(KFPKHHAOGPP);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.LEFOIGFGJGJ)
		{
			output.WriteRawTag(114);
			output.WriteMessage(LEFOIGFGJGJ);
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
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.Lineup)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.CGCJLHFLEPN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGCJLHFLEPN);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.PJIGHNFHFKD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJIGHNFHFKD);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.KFPKHHAOGPP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KFPKHHAOGPP);
		}
		if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.LEFOIGFGJGJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LEFOIGFGJGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IEACMDFDLBF other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.KPPNKFGPNHNCase)
		{
		case KPPNKFGPNHNOneofCase.Lineup:
			if (Lineup == null)
			{
				Lineup = new DHKFLIKNMJO();
			}
			Lineup.MergeFrom(other.Lineup);
			break;
		case KPPNKFGPNHNOneofCase.CGCJLHFLEPN:
			if (CGCJLHFLEPN == null)
			{
				CGCJLHFLEPN = new BPHLEOBMMKM();
			}
			CGCJLHFLEPN.MergeFrom(other.CGCJLHFLEPN);
			break;
		case KPPNKFGPNHNOneofCase.PJIGHNFHFKD:
			if (PJIGHNFHFKD == null)
			{
				PJIGHNFHFKD = new PFIFNMIIOHF();
			}
			PJIGHNFHFKD.MergeFrom(other.PJIGHNFHFKD);
			break;
		case KPPNKFGPNHNOneofCase.KFPKHHAOGPP:
			if (KFPKHHAOGPP == null)
			{
				KFPKHHAOGPP = new MJEDAOPDIPM();
			}
			KFPKHHAOGPP.MergeFrom(other.KFPKHHAOGPP);
			break;
		case KPPNKFGPNHNOneofCase.LEFOIGFGJGJ:
			if (LEFOIGFGJGJ == null)
			{
				LEFOIGFGJGJ = new CLJAIHNBKEM();
			}
			LEFOIGFGJGJ.MergeFrom(other.LEFOIGFGJGJ);
			break;
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
			case 82u:
			{
				DHKFLIKNMJO dHKFLIKNMJO = new DHKFLIKNMJO();
				if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.Lineup)
				{
					dHKFLIKNMJO.MergeFrom(Lineup);
				}
				input.ReadMessage(dHKFLIKNMJO);
				Lineup = dHKFLIKNMJO;
				break;
			}
			case 90u:
			{
				BPHLEOBMMKM bPHLEOBMMKM = new BPHLEOBMMKM();
				if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.CGCJLHFLEPN)
				{
					bPHLEOBMMKM.MergeFrom(CGCJLHFLEPN);
				}
				input.ReadMessage(bPHLEOBMMKM);
				CGCJLHFLEPN = bPHLEOBMMKM;
				break;
			}
			case 98u:
			{
				PFIFNMIIOHF pFIFNMIIOHF = new PFIFNMIIOHF();
				if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.PJIGHNFHFKD)
				{
					pFIFNMIIOHF.MergeFrom(PJIGHNFHFKD);
				}
				input.ReadMessage(pFIFNMIIOHF);
				PJIGHNFHFKD = pFIFNMIIOHF;
				break;
			}
			case 106u:
			{
				MJEDAOPDIPM mJEDAOPDIPM = new MJEDAOPDIPM();
				if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.KFPKHHAOGPP)
				{
					mJEDAOPDIPM.MergeFrom(KFPKHHAOGPP);
				}
				input.ReadMessage(mJEDAOPDIPM);
				KFPKHHAOGPP = mJEDAOPDIPM;
				break;
			}
			case 114u:
			{
				CLJAIHNBKEM cLJAIHNBKEM = new CLJAIHNBKEM();
				if (kPPNKFGPNHNCase_ == KPPNKFGPNHNOneofCase.LEFOIGFGJGJ)
				{
					cLJAIHNBKEM.MergeFrom(LEFOIGFGJGJ);
				}
				input.ReadMessage(cLJAIHNBKEM);
				LEFOIGFGJGJ = cLJAIHNBKEM;
				break;
			}
			}
		}
	}
}
