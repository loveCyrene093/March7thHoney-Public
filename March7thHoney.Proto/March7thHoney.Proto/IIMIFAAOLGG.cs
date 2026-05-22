using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IIMIFAAOLGG : IMessage<IIMIFAAOLGG>, IMessage, IEquatable<IIMIFAAOLGG>, IDeepCloneable<IIMIFAAOLGG>, IBufferMessage
{
	private static readonly MessageParser<IIMIFAAOLGG> _parser = new MessageParser<IIMIFAAOLGG>(() => new IIMIFAAOLGG());

	private UnknownFieldSet _unknownFields;

	public const int HCEHOHDCCFEFieldNumber = 1;

	private EPPGPHKLHNF hCEHOHDCCFE_;

	public const int AHBFAAMNKNOFieldNumber = 8;

	private BGKINCFGKGI aHBFAAMNKNO_;

	public const int LHNCGDKFAGMFieldNumber = 9;

	private NCDCKHHPDDE lHNCGDKFAGM_;

	public const int ICJFLLDCFHMFieldNumber = 12;

	private BADCGBPEANI iCJFLLDCFHM_;

	public const int IMPBELJGDJHFieldNumber = 15;

	private BLADONILKHO iMPBELJGDJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IIMIFAAOLGG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IIMIFAAOLGGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPPGPHKLHNF HCEHOHDCCFE
	{
		get
		{
			return hCEHOHDCCFE_;
		}
		set
		{
			hCEHOHDCCFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI AHBFAAMNKNO
	{
		get
		{
			return aHBFAAMNKNO_;
		}
		set
		{
			aHBFAAMNKNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDCKHHPDDE LHNCGDKFAGM
	{
		get
		{
			return lHNCGDKFAGM_;
		}
		set
		{
			lHNCGDKFAGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BADCGBPEANI ICJFLLDCFHM
	{
		get
		{
			return iCJFLLDCFHM_;
		}
		set
		{
			iCJFLLDCFHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLADONILKHO IMPBELJGDJH
	{
		get
		{
			return iMPBELJGDJH_;
		}
		set
		{
			iMPBELJGDJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIMIFAAOLGG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIMIFAAOLGG(IIMIFAAOLGG other)
		: this()
	{
		hCEHOHDCCFE_ = ((other.hCEHOHDCCFE_ != null) ? other.hCEHOHDCCFE_.Clone() : null);
		aHBFAAMNKNO_ = ((other.aHBFAAMNKNO_ != null) ? other.aHBFAAMNKNO_.Clone() : null);
		lHNCGDKFAGM_ = ((other.lHNCGDKFAGM_ != null) ? other.lHNCGDKFAGM_.Clone() : null);
		iCJFLLDCFHM_ = ((other.iCJFLLDCFHM_ != null) ? other.iCJFLLDCFHM_.Clone() : null);
		iMPBELJGDJH_ = ((other.iMPBELJGDJH_ != null) ? other.iMPBELJGDJH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIMIFAAOLGG Clone()
	{
		return new IIMIFAAOLGG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IIMIFAAOLGG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IIMIFAAOLGG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HCEHOHDCCFE, other.HCEHOHDCCFE))
		{
			return false;
		}
		if (!object.Equals(AHBFAAMNKNO, other.AHBFAAMNKNO))
		{
			return false;
		}
		if (!object.Equals(LHNCGDKFAGM, other.LHNCGDKFAGM))
		{
			return false;
		}
		if (!object.Equals(ICJFLLDCFHM, other.ICJFLLDCFHM))
		{
			return false;
		}
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
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
		if (hCEHOHDCCFE_ != null)
		{
			num ^= HCEHOHDCCFE.GetHashCode();
		}
		if (aHBFAAMNKNO_ != null)
		{
			num ^= AHBFAAMNKNO.GetHashCode();
		}
		if (lHNCGDKFAGM_ != null)
		{
			num ^= LHNCGDKFAGM.GetHashCode();
		}
		if (iCJFLLDCFHM_ != null)
		{
			num ^= ICJFLLDCFHM.GetHashCode();
		}
		if (iMPBELJGDJH_ != null)
		{
			num ^= IMPBELJGDJH.GetHashCode();
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
		if (hCEHOHDCCFE_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HCEHOHDCCFE);
		}
		if (aHBFAAMNKNO_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(AHBFAAMNKNO);
		}
		if (lHNCGDKFAGM_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(LHNCGDKFAGM);
		}
		if (iCJFLLDCFHM_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ICJFLLDCFHM);
		}
		if (iMPBELJGDJH_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(IMPBELJGDJH);
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
		if (hCEHOHDCCFE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HCEHOHDCCFE);
		}
		if (aHBFAAMNKNO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AHBFAAMNKNO);
		}
		if (lHNCGDKFAGM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LHNCGDKFAGM);
		}
		if (iCJFLLDCFHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ICJFLLDCFHM);
		}
		if (iMPBELJGDJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IIMIFAAOLGG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hCEHOHDCCFE_ != null)
		{
			if (hCEHOHDCCFE_ == null)
			{
				HCEHOHDCCFE = new EPPGPHKLHNF();
			}
			HCEHOHDCCFE.MergeFrom(other.HCEHOHDCCFE);
		}
		if (other.aHBFAAMNKNO_ != null)
		{
			if (aHBFAAMNKNO_ == null)
			{
				AHBFAAMNKNO = new BGKINCFGKGI();
			}
			AHBFAAMNKNO.MergeFrom(other.AHBFAAMNKNO);
		}
		if (other.lHNCGDKFAGM_ != null)
		{
			if (lHNCGDKFAGM_ == null)
			{
				LHNCGDKFAGM = new NCDCKHHPDDE();
			}
			LHNCGDKFAGM.MergeFrom(other.LHNCGDKFAGM);
		}
		if (other.iCJFLLDCFHM_ != null)
		{
			if (iCJFLLDCFHM_ == null)
			{
				ICJFLLDCFHM = new BADCGBPEANI();
			}
			ICJFLLDCFHM.MergeFrom(other.ICJFLLDCFHM);
		}
		if (other.iMPBELJGDJH_ != null)
		{
			if (iMPBELJGDJH_ == null)
			{
				IMPBELJGDJH = new BLADONILKHO();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
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
				if (hCEHOHDCCFE_ == null)
				{
					HCEHOHDCCFE = new EPPGPHKLHNF();
				}
				input.ReadMessage(HCEHOHDCCFE);
				break;
			case 66u:
				if (aHBFAAMNKNO_ == null)
				{
					AHBFAAMNKNO = new BGKINCFGKGI();
				}
				input.ReadMessage(AHBFAAMNKNO);
				break;
			case 74u:
				if (lHNCGDKFAGM_ == null)
				{
					LHNCGDKFAGM = new NCDCKHHPDDE();
				}
				input.ReadMessage(LHNCGDKFAGM);
				break;
			case 98u:
				if (iCJFLLDCFHM_ == null)
				{
					ICJFLLDCFHM = new BADCGBPEANI();
				}
				input.ReadMessage(ICJFLLDCFHM);
				break;
			case 122u:
				if (iMPBELJGDJH_ == null)
				{
					IMPBELJGDJH = new BLADONILKHO();
				}
				input.ReadMessage(IMPBELJGDJH);
				break;
			}
		}
	}
}
