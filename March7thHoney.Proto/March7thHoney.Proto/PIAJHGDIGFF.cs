using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PIAJHGDIGFF : IMessage<PIAJHGDIGFF>, IMessage, IEquatable<PIAJHGDIGFF>, IDeepCloneable<PIAJHGDIGFF>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		EGNDJGKKJHO = 1,
		KCDOLIAAECN = 3,
		LDIACAGJKJM = 4,
		MNEBDMJGLEJ = 5,
		KDGMBIMPKEH = 8,
		PPFFBGBMLPC = 11,
		BLLJFKDJKEN = 13,
		PEMLOLMLOJO = 14
	}

	private static readonly MessageParser<PIAJHGDIGFF> _parser = new MessageParser<PIAJHGDIGFF>(() => new PIAJHGDIGFF());

	private UnknownFieldSet _unknownFields;

	public const int EGNDJGKKJHOFieldNumber = 1;

	public const int KCDOLIAAECNFieldNumber = 3;

	public const int LDIACAGJKJMFieldNumber = 4;

	public const int MNEBDMJGLEJFieldNumber = 5;

	public const int KDGMBIMPKEHFieldNumber = 8;

	public const int PPFFBGBMLPCFieldNumber = 11;

	public const int BLLJFKDJKENFieldNumber = 13;

	public const int PEMLOLMLOJOFieldNumber = 14;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PIAJHGDIGFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PIAJHGDIGFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJBHNEHJMHE EGNDJGKKJHO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EGNDJGKKJHO)
			{
				return null;
			}
			return (AJBHNEHJMHE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EGNDJGKKJHO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBJOGKPIFMC KCDOLIAAECN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KCDOLIAAECN)
			{
				return null;
			}
			return (PBJOGKPIFMC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KCDOLIAAECN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLGAHIAAFHL LDIACAGJKJM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LDIACAGJKJM)
			{
				return null;
			}
			return (HLGAHIAAFHL)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LDIACAGJKJM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDNFMEMPFHK MNEBDMJGLEJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.MNEBDMJGLEJ)
			{
				return null;
			}
			return (BDNFMEMPFHK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.MNEBDMJGLEJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPKHODIPBKA KDGMBIMPKEH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.KDGMBIMPKEH)
			{
				return null;
			}
			return (DPKHODIPBKA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.KDGMBIMPKEH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COIKCGMPJCH PPFFBGBMLPC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PPFFBGBMLPC)
			{
				return null;
			}
			return (COIKCGMPJCH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PPFFBGBMLPC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONCJDNJMCIN BLLJFKDJKEN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BLLJFKDJKEN)
			{
				return null;
			}
			return (ONCJDNJMCIN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BLLJFKDJKEN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIMDKELDBN PEMLOLMLOJO
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PEMLOLMLOJO)
			{
				return null;
			}
			return (BNIMDKELDBN)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PEMLOLMLOJO : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIAJHGDIGFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIAJHGDIGFF(PIAJHGDIGFF other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.EGNDJGKKJHO:
			EGNDJGKKJHO = other.EGNDJGKKJHO.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KCDOLIAAECN:
			KCDOLIAAECN = other.KCDOLIAAECN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LDIACAGJKJM:
			LDIACAGJKJM = other.LDIACAGJKJM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.MNEBDMJGLEJ:
			MNEBDMJGLEJ = other.MNEBDMJGLEJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.KDGMBIMPKEH:
			KDGMBIMPKEH = other.KDGMBIMPKEH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PPFFBGBMLPC:
			PPFFBGBMLPC = other.PPFFBGBMLPC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BLLJFKDJKEN:
			BLLJFKDJKEN = other.BLLJFKDJKEN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PEMLOLMLOJO:
			PEMLOLMLOJO = other.PEMLOLMLOJO.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIAJHGDIGFF Clone()
	{
		return new PIAJHGDIGFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PIAJHGDIGFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PIAJHGDIGFF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EGNDJGKKJHO, other.EGNDJGKKJHO))
		{
			return false;
		}
		if (!object.Equals(KCDOLIAAECN, other.KCDOLIAAECN))
		{
			return false;
		}
		if (!object.Equals(LDIACAGJKJM, other.LDIACAGJKJM))
		{
			return false;
		}
		if (!object.Equals(MNEBDMJGLEJ, other.MNEBDMJGLEJ))
		{
			return false;
		}
		if (!object.Equals(KDGMBIMPKEH, other.KDGMBIMPKEH))
		{
			return false;
		}
		if (!object.Equals(PPFFBGBMLPC, other.PPFFBGBMLPC))
		{
			return false;
		}
		if (!object.Equals(BLLJFKDJKEN, other.BLLJFKDJKEN))
		{
			return false;
		}
		if (!object.Equals(PEMLOLMLOJO, other.PEMLOLMLOJO))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGNDJGKKJHO)
		{
			num ^= EGNDJGKKJHO.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCDOLIAAECN)
		{
			num ^= KCDOLIAAECN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LDIACAGJKJM)
		{
			num ^= LDIACAGJKJM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MNEBDMJGLEJ)
		{
			num ^= MNEBDMJGLEJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KDGMBIMPKEH)
		{
			num ^= KDGMBIMPKEH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPFFBGBMLPC)
		{
			num ^= PPFFBGBMLPC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLLJFKDJKEN)
		{
			num ^= BLLJFKDJKEN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMLOLMLOJO)
		{
			num ^= PEMLOLMLOJO.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGNDJGKKJHO)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EGNDJGKKJHO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCDOLIAAECN)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KCDOLIAAECN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LDIACAGJKJM)
		{
			output.WriteRawTag(34);
			output.WriteMessage(LDIACAGJKJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MNEBDMJGLEJ)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MNEBDMJGLEJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KDGMBIMPKEH)
		{
			output.WriteRawTag(66);
			output.WriteMessage(KDGMBIMPKEH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPFFBGBMLPC)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PPFFBGBMLPC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLLJFKDJKEN)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BLLJFKDJKEN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMLOLMLOJO)
		{
			output.WriteRawTag(114);
			output.WriteMessage(PEMLOLMLOJO);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGNDJGKKJHO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EGNDJGKKJHO);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCDOLIAAECN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KCDOLIAAECN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LDIACAGJKJM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LDIACAGJKJM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MNEBDMJGLEJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNEBDMJGLEJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KDGMBIMPKEH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KDGMBIMPKEH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPFFBGBMLPC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPFFBGBMLPC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLLJFKDJKEN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BLLJFKDJKEN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMLOLMLOJO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEMLOLMLOJO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PIAJHGDIGFF other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.EGNDJGKKJHO:
			if (EGNDJGKKJHO == null)
			{
				EGNDJGKKJHO = new AJBHNEHJMHE();
			}
			EGNDJGKKJHO.MergeFrom(other.EGNDJGKKJHO);
			break;
		case BPIHFAJCLOCOneofCase.KCDOLIAAECN:
			if (KCDOLIAAECN == null)
			{
				KCDOLIAAECN = new PBJOGKPIFMC();
			}
			KCDOLIAAECN.MergeFrom(other.KCDOLIAAECN);
			break;
		case BPIHFAJCLOCOneofCase.LDIACAGJKJM:
			if (LDIACAGJKJM == null)
			{
				LDIACAGJKJM = new HLGAHIAAFHL();
			}
			LDIACAGJKJM.MergeFrom(other.LDIACAGJKJM);
			break;
		case BPIHFAJCLOCOneofCase.MNEBDMJGLEJ:
			if (MNEBDMJGLEJ == null)
			{
				MNEBDMJGLEJ = new BDNFMEMPFHK();
			}
			MNEBDMJGLEJ.MergeFrom(other.MNEBDMJGLEJ);
			break;
		case BPIHFAJCLOCOneofCase.KDGMBIMPKEH:
			if (KDGMBIMPKEH == null)
			{
				KDGMBIMPKEH = new DPKHODIPBKA();
			}
			KDGMBIMPKEH.MergeFrom(other.KDGMBIMPKEH);
			break;
		case BPIHFAJCLOCOneofCase.PPFFBGBMLPC:
			if (PPFFBGBMLPC == null)
			{
				PPFFBGBMLPC = new COIKCGMPJCH();
			}
			PPFFBGBMLPC.MergeFrom(other.PPFFBGBMLPC);
			break;
		case BPIHFAJCLOCOneofCase.BLLJFKDJKEN:
			if (BLLJFKDJKEN == null)
			{
				BLLJFKDJKEN = new ONCJDNJMCIN();
			}
			BLLJFKDJKEN.MergeFrom(other.BLLJFKDJKEN);
			break;
		case BPIHFAJCLOCOneofCase.PEMLOLMLOJO:
			if (PEMLOLMLOJO == null)
			{
				PEMLOLMLOJO = new BNIMDKELDBN();
			}
			PEMLOLMLOJO.MergeFrom(other.PEMLOLMLOJO);
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
			case 10u:
			{
				AJBHNEHJMHE aJBHNEHJMHE = new AJBHNEHJMHE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EGNDJGKKJHO)
				{
					aJBHNEHJMHE.MergeFrom(EGNDJGKKJHO);
				}
				input.ReadMessage(aJBHNEHJMHE);
				EGNDJGKKJHO = aJBHNEHJMHE;
				break;
			}
			case 26u:
			{
				PBJOGKPIFMC pBJOGKPIFMC = new PBJOGKPIFMC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KCDOLIAAECN)
				{
					pBJOGKPIFMC.MergeFrom(KCDOLIAAECN);
				}
				input.ReadMessage(pBJOGKPIFMC);
				KCDOLIAAECN = pBJOGKPIFMC;
				break;
			}
			case 34u:
			{
				HLGAHIAAFHL hLGAHIAAFHL = new HLGAHIAAFHL();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LDIACAGJKJM)
				{
					hLGAHIAAFHL.MergeFrom(LDIACAGJKJM);
				}
				input.ReadMessage(hLGAHIAAFHL);
				LDIACAGJKJM = hLGAHIAAFHL;
				break;
			}
			case 42u:
			{
				BDNFMEMPFHK bDNFMEMPFHK = new BDNFMEMPFHK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.MNEBDMJGLEJ)
				{
					bDNFMEMPFHK.MergeFrom(MNEBDMJGLEJ);
				}
				input.ReadMessage(bDNFMEMPFHK);
				MNEBDMJGLEJ = bDNFMEMPFHK;
				break;
			}
			case 66u:
			{
				DPKHODIPBKA dPKHODIPBKA = new DPKHODIPBKA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.KDGMBIMPKEH)
				{
					dPKHODIPBKA.MergeFrom(KDGMBIMPKEH);
				}
				input.ReadMessage(dPKHODIPBKA);
				KDGMBIMPKEH = dPKHODIPBKA;
				break;
			}
			case 90u:
			{
				COIKCGMPJCH cOIKCGMPJCH = new COIKCGMPJCH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PPFFBGBMLPC)
				{
					cOIKCGMPJCH.MergeFrom(PPFFBGBMLPC);
				}
				input.ReadMessage(cOIKCGMPJCH);
				PPFFBGBMLPC = cOIKCGMPJCH;
				break;
			}
			case 106u:
			{
				ONCJDNJMCIN oNCJDNJMCIN = new ONCJDNJMCIN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLLJFKDJKEN)
				{
					oNCJDNJMCIN.MergeFrom(BLLJFKDJKEN);
				}
				input.ReadMessage(oNCJDNJMCIN);
				BLLJFKDJKEN = oNCJDNJMCIN;
				break;
			}
			case 114u:
			{
				BNIMDKELDBN bNIMDKELDBN = new BNIMDKELDBN();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PEMLOLMLOJO)
				{
					bNIMDKELDBN.MergeFrom(PEMLOLMLOJO);
				}
				input.ReadMessage(bNIMDKELDBN);
				PEMLOLMLOJO = bNIMDKELDBN;
				break;
			}
			}
		}
	}
}
