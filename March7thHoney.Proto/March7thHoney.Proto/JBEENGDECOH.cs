using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JBEENGDECOH : IMessage<JBEENGDECOH>, IMessage, IEquatable<JBEENGDECOH>, IDeepCloneable<JBEENGDECOH>, IBufferMessage
{
	private static readonly MessageParser<JBEENGDECOH> _parser = new MessageParser<JBEENGDECOH>(() => new JBEENGDECOH());

	private UnknownFieldSet _unknownFields;

	public const int AHHJHHOPHPJFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aHHJHHOPHPJ_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aHHJHHOPHPJ_ = new RepeatedField<uint>();

	public const int FAPFKFJIELEFieldNumber = 4;

	private uint fAPFKFJIELE_;

	public const int JCFEPOKIFPDFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_jCFEPOKIFPD_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> jCFEPOKIFPD_ = new RepeatedField<uint>();

	public const int IENBKIAGPBAFieldNumber = 6;

	private uint iENBKIAGPBA_;

	public const int BBHMFANKCAOFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_bBHMFANKCAO_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> bBHMFANKCAO_ = new RepeatedField<uint>();

	public const int BKDINONLAHDFieldNumber = 8;

	private bool bKDINONLAHD_;

	public const int CBJIFCGANIKFieldNumber = 10;

	private bool cBJIFCGANIK_;

	public const int IEHKDAJNALEFieldNumber = 15;

	private uint iEHKDAJNALE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JBEENGDECOH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JBEENGDECOHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AHHJHHOPHPJ => aHHJHHOPHPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAPFKFJIELE
	{
		get
		{
			return fAPFKFJIELE_;
		}
		set
		{
			fAPFKFJIELE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JCFEPOKIFPD => jCFEPOKIFPD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IENBKIAGPBA
	{
		get
		{
			return iENBKIAGPBA_;
		}
		set
		{
			iENBKIAGPBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BBHMFANKCAO => bBHMFANKCAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BKDINONLAHD
	{
		get
		{
			return bKDINONLAHD_;
		}
		set
		{
			bKDINONLAHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CBJIFCGANIK
	{
		get
		{
			return cBJIFCGANIK_;
		}
		set
		{
			cBJIFCGANIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEHKDAJNALE
	{
		get
		{
			return iEHKDAJNALE_;
		}
		set
		{
			iEHKDAJNALE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBEENGDECOH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBEENGDECOH(JBEENGDECOH other)
		: this()
	{
		aHHJHHOPHPJ_ = other.aHHJHHOPHPJ_.Clone();
		fAPFKFJIELE_ = other.fAPFKFJIELE_;
		jCFEPOKIFPD_ = other.jCFEPOKIFPD_.Clone();
		iENBKIAGPBA_ = other.iENBKIAGPBA_;
		bBHMFANKCAO_ = other.bBHMFANKCAO_.Clone();
		bKDINONLAHD_ = other.bKDINONLAHD_;
		cBJIFCGANIK_ = other.cBJIFCGANIK_;
		iEHKDAJNALE_ = other.iEHKDAJNALE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBEENGDECOH Clone()
	{
		return new JBEENGDECOH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JBEENGDECOH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JBEENGDECOH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aHHJHHOPHPJ_.Equals(other.aHHJHHOPHPJ_))
		{
			return false;
		}
		if (FAPFKFJIELE != other.FAPFKFJIELE)
		{
			return false;
		}
		if (!jCFEPOKIFPD_.Equals(other.jCFEPOKIFPD_))
		{
			return false;
		}
		if (IENBKIAGPBA != other.IENBKIAGPBA)
		{
			return false;
		}
		if (!bBHMFANKCAO_.Equals(other.bBHMFANKCAO_))
		{
			return false;
		}
		if (BKDINONLAHD != other.BKDINONLAHD)
		{
			return false;
		}
		if (CBJIFCGANIK != other.CBJIFCGANIK)
		{
			return false;
		}
		if (IEHKDAJNALE != other.IEHKDAJNALE)
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
		num ^= aHHJHHOPHPJ_.GetHashCode();
		if (FAPFKFJIELE != 0)
		{
			num ^= FAPFKFJIELE.GetHashCode();
		}
		num ^= jCFEPOKIFPD_.GetHashCode();
		if (IENBKIAGPBA != 0)
		{
			num ^= IENBKIAGPBA.GetHashCode();
		}
		num ^= bBHMFANKCAO_.GetHashCode();
		if (BKDINONLAHD)
		{
			num ^= BKDINONLAHD.GetHashCode();
		}
		if (CBJIFCGANIK)
		{
			num ^= CBJIFCGANIK.GetHashCode();
		}
		if (IEHKDAJNALE != 0)
		{
			num ^= IEHKDAJNALE.GetHashCode();
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
		aHHJHHOPHPJ_.WriteTo(ref output, _repeated_aHHJHHOPHPJ_codec);
		if (FAPFKFJIELE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FAPFKFJIELE);
		}
		jCFEPOKIFPD_.WriteTo(ref output, _repeated_jCFEPOKIFPD_codec);
		if (IENBKIAGPBA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IENBKIAGPBA);
		}
		bBHMFANKCAO_.WriteTo(ref output, _repeated_bBHMFANKCAO_codec);
		if (BKDINONLAHD)
		{
			output.WriteRawTag(64);
			output.WriteBool(BKDINONLAHD);
		}
		if (CBJIFCGANIK)
		{
			output.WriteRawTag(80);
			output.WriteBool(CBJIFCGANIK);
		}
		if (IEHKDAJNALE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IEHKDAJNALE);
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
		num += aHHJHHOPHPJ_.CalculateSize(_repeated_aHHJHHOPHPJ_codec);
		if (FAPFKFJIELE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAPFKFJIELE);
		}
		num += jCFEPOKIFPD_.CalculateSize(_repeated_jCFEPOKIFPD_codec);
		if (IENBKIAGPBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IENBKIAGPBA);
		}
		num += bBHMFANKCAO_.CalculateSize(_repeated_bBHMFANKCAO_codec);
		if (BKDINONLAHD)
		{
			num += 2;
		}
		if (CBJIFCGANIK)
		{
			num += 2;
		}
		if (IEHKDAJNALE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEHKDAJNALE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JBEENGDECOH other)
	{
		if (other != null)
		{
			aHHJHHOPHPJ_.Add(other.aHHJHHOPHPJ_);
			if (other.FAPFKFJIELE != 0)
			{
				FAPFKFJIELE = other.FAPFKFJIELE;
			}
			jCFEPOKIFPD_.Add(other.jCFEPOKIFPD_);
			if (other.IENBKIAGPBA != 0)
			{
				IENBKIAGPBA = other.IENBKIAGPBA;
			}
			bBHMFANKCAO_.Add(other.bBHMFANKCAO_);
			if (other.BKDINONLAHD)
			{
				BKDINONLAHD = other.BKDINONLAHD;
			}
			if (other.CBJIFCGANIK)
			{
				CBJIFCGANIK = other.CBJIFCGANIK;
			}
			if (other.IEHKDAJNALE != 0)
			{
				IEHKDAJNALE = other.IEHKDAJNALE;
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
			case 24u:
			case 26u:
				aHHJHHOPHPJ_.AddEntriesFrom(ref input, _repeated_aHHJHHOPHPJ_codec);
				break;
			case 32u:
				FAPFKFJIELE = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				jCFEPOKIFPD_.AddEntriesFrom(ref input, _repeated_jCFEPOKIFPD_codec);
				break;
			case 48u:
				IENBKIAGPBA = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				bBHMFANKCAO_.AddEntriesFrom(ref input, _repeated_bBHMFANKCAO_codec);
				break;
			case 64u:
				BKDINONLAHD = input.ReadBool();
				break;
			case 80u:
				CBJIFCGANIK = input.ReadBool();
				break;
			case 120u:
				IEHKDAJNALE = input.ReadUInt32();
				break;
			}
		}
	}
}
