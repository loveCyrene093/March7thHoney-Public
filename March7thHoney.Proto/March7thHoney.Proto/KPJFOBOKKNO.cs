using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KPJFOBOKKNO : IMessage<KPJFOBOKKNO>, IMessage, IEquatable<KPJFOBOKKNO>, IDeepCloneable<KPJFOBOKKNO>, IBufferMessage
{
	private static readonly MessageParser<KPJFOBOKKNO> _parser = new MessageParser<KPJFOBOKKNO>(() => new KPJFOBOKKNO());

	private UnknownFieldSet _unknownFields;

	public const int HDKIHMEBNDCFieldNumber = 5;

	private bool hDKIHMEBNDC_;

	public const int ACMGBNNEACJFieldNumber = 7;

	private bool aCMGBNNEACJ_;

	public const int DKKOBPDNCLCFieldNumber = 8;

	private uint dKKOBPDNCLC_;

	public const int LPHDBPBILKEFieldNumber = 10;

	private bool lPHDBPBILKE_;

	public const int CDKEDFPEFIJFieldNumber = 11;

	private uint cDKEDFPEFIJ_;

	public const int NHDDHMGGKBOFieldNumber = 12;

	private uint nHDDHMGGKBO_;

	public const int MFMJBFDFMHGFieldNumber = 14;

	private uint mFMJBFDFMHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KPJFOBOKKNO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KPJFOBOKKNOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HDKIHMEBNDC
	{
		get
		{
			return hDKIHMEBNDC_;
		}
		set
		{
			hDKIHMEBNDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ACMGBNNEACJ
	{
		get
		{
			return aCMGBNNEACJ_;
		}
		set
		{
			aCMGBNNEACJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKKOBPDNCLC
	{
		get
		{
			return dKKOBPDNCLC_;
		}
		set
		{
			dKKOBPDNCLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LPHDBPBILKE
	{
		get
		{
			return lPHDBPBILKE_;
		}
		set
		{
			lPHDBPBILKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDKEDFPEFIJ
	{
		get
		{
			return cDKEDFPEFIJ_;
		}
		set
		{
			cDKEDFPEFIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHDDHMGGKBO
	{
		get
		{
			return nHDDHMGGKBO_;
		}
		set
		{
			nHDDHMGGKBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFMJBFDFMHG
	{
		get
		{
			return mFMJBFDFMHG_;
		}
		set
		{
			mFMJBFDFMHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPJFOBOKKNO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPJFOBOKKNO(KPJFOBOKKNO other)
		: this()
	{
		hDKIHMEBNDC_ = other.hDKIHMEBNDC_;
		aCMGBNNEACJ_ = other.aCMGBNNEACJ_;
		dKKOBPDNCLC_ = other.dKKOBPDNCLC_;
		lPHDBPBILKE_ = other.lPHDBPBILKE_;
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		nHDDHMGGKBO_ = other.nHDDHMGGKBO_;
		mFMJBFDFMHG_ = other.mFMJBFDFMHG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPJFOBOKKNO Clone()
	{
		return new KPJFOBOKKNO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KPJFOBOKKNO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KPJFOBOKKNO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HDKIHMEBNDC != other.HDKIHMEBNDC)
		{
			return false;
		}
		if (ACMGBNNEACJ != other.ACMGBNNEACJ)
		{
			return false;
		}
		if (DKKOBPDNCLC != other.DKKOBPDNCLC)
		{
			return false;
		}
		if (LPHDBPBILKE != other.LPHDBPBILKE)
		{
			return false;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
		{
			return false;
		}
		if (NHDDHMGGKBO != other.NHDDHMGGKBO)
		{
			return false;
		}
		if (MFMJBFDFMHG != other.MFMJBFDFMHG)
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
		if (HDKIHMEBNDC)
		{
			num ^= HDKIHMEBNDC.GetHashCode();
		}
		if (ACMGBNNEACJ)
		{
			num ^= ACMGBNNEACJ.GetHashCode();
		}
		if (DKKOBPDNCLC != 0)
		{
			num ^= DKKOBPDNCLC.GetHashCode();
		}
		if (LPHDBPBILKE)
		{
			num ^= LPHDBPBILKE.GetHashCode();
		}
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
		}
		if (NHDDHMGGKBO != 0)
		{
			num ^= NHDDHMGGKBO.GetHashCode();
		}
		if (MFMJBFDFMHG != 0)
		{
			num ^= MFMJBFDFMHG.GetHashCode();
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
		if (HDKIHMEBNDC)
		{
			output.WriteRawTag(40);
			output.WriteBool(HDKIHMEBNDC);
		}
		if (ACMGBNNEACJ)
		{
			output.WriteRawTag(56);
			output.WriteBool(ACMGBNNEACJ);
		}
		if (DKKOBPDNCLC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DKKOBPDNCLC);
		}
		if (LPHDBPBILKE)
		{
			output.WriteRawTag(80);
			output.WriteBool(LPHDBPBILKE);
		}
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CDKEDFPEFIJ);
		}
		if (NHDDHMGGKBO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NHDDHMGGKBO);
		}
		if (MFMJBFDFMHG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MFMJBFDFMHG);
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
		if (HDKIHMEBNDC)
		{
			num += 2;
		}
		if (ACMGBNNEACJ)
		{
			num += 2;
		}
		if (DKKOBPDNCLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKKOBPDNCLC);
		}
		if (LPHDBPBILKE)
		{
			num += 2;
		}
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (NHDDHMGGKBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHDDHMGGKBO);
		}
		if (MFMJBFDFMHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFMJBFDFMHG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KPJFOBOKKNO other)
	{
		if (other != null)
		{
			if (other.HDKIHMEBNDC)
			{
				HDKIHMEBNDC = other.HDKIHMEBNDC;
			}
			if (other.ACMGBNNEACJ)
			{
				ACMGBNNEACJ = other.ACMGBNNEACJ;
			}
			if (other.DKKOBPDNCLC != 0)
			{
				DKKOBPDNCLC = other.DKKOBPDNCLC;
			}
			if (other.LPHDBPBILKE)
			{
				LPHDBPBILKE = other.LPHDBPBILKE;
			}
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
			}
			if (other.NHDDHMGGKBO != 0)
			{
				NHDDHMGGKBO = other.NHDDHMGGKBO;
			}
			if (other.MFMJBFDFMHG != 0)
			{
				MFMJBFDFMHG = other.MFMJBFDFMHG;
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
			case 40u:
				HDKIHMEBNDC = input.ReadBool();
				break;
			case 56u:
				ACMGBNNEACJ = input.ReadBool();
				break;
			case 64u:
				DKKOBPDNCLC = input.ReadUInt32();
				break;
			case 80u:
				LPHDBPBILKE = input.ReadBool();
				break;
			case 88u:
				CDKEDFPEFIJ = input.ReadUInt32();
				break;
			case 96u:
				NHDDHMGGKBO = input.ReadUInt32();
				break;
			case 112u:
				MFMJBFDFMHG = input.ReadUInt32();
				break;
			}
		}
	}
}
