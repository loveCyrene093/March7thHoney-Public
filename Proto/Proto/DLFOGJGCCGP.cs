using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLFOGJGCCGP : IMessage<DLFOGJGCCGP>, IMessage, IEquatable<DLFOGJGCCGP>, IDeepCloneable<DLFOGJGCCGP>, IBufferMessage
{
	private static readonly MessageParser<DLFOGJGCCGP> _parser = new MessageParser<DLFOGJGCCGP>(() => new DLFOGJGCCGP());

	private UnknownFieldSet _unknownFields;

	public const int AKGICOFNHONFieldNumber = 4;

	private bool aKGICOFNHON_;

	public const int IAONGEDPLICFieldNumber = 5;

	private static readonly FieldCodec<BBNDBHBHNLB> _repeated_iAONGEDPLIC_codec = FieldCodec.ForMessage(42u, BBNDBHBHNLB.Parser);

	private readonly RepeatedField<BBNDBHBHNLB> iAONGEDPLIC_ = new RepeatedField<BBNDBHBHNLB>();

	public const int BFIBIHLBLHFFieldNumber = 6;

	private uint bFIBIHLBLHF_;

	public const int BOLCAEPIHJHFieldNumber = 7;

	private bool bOLCAEPIHJH_;

	public const int HBEGBPFIJJMFieldNumber = 10;

	private uint hBEGBPFIJJM_;

	public const int CDKEDFPEFIJFieldNumber = 11;

	private uint cDKEDFPEFIJ_;

	public const int HFOKNODFIJIFieldNumber = 12;

	private uint hFOKNODFIJI_;

	public const int ILEMMKPGPNDFieldNumber = 13;

	private uint iLEMMKPGPND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLFOGJGCCGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLFOGJGCCGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AKGICOFNHON
	{
		get
		{
			return aKGICOFNHON_;
		}
		set
		{
			aKGICOFNHON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BBNDBHBHNLB> IAONGEDPLIC => iAONGEDPLIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFIBIHLBLHF
	{
		get
		{
			return bFIBIHLBLHF_;
		}
		set
		{
			bFIBIHLBLHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BOLCAEPIHJH
	{
		get
		{
			return bOLCAEPIHJH_;
		}
		set
		{
			bOLCAEPIHJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBEGBPFIJJM
	{
		get
		{
			return hBEGBPFIJJM_;
		}
		set
		{
			hBEGBPFIJJM_ = value;
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
	public uint HFOKNODFIJI
	{
		get
		{
			return hFOKNODFIJI_;
		}
		set
		{
			hFOKNODFIJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILEMMKPGPND
	{
		get
		{
			return iLEMMKPGPND_;
		}
		set
		{
			iLEMMKPGPND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLFOGJGCCGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLFOGJGCCGP(DLFOGJGCCGP other)
		: this()
	{
		aKGICOFNHON_ = other.aKGICOFNHON_;
		iAONGEDPLIC_ = other.iAONGEDPLIC_.Clone();
		bFIBIHLBLHF_ = other.bFIBIHLBLHF_;
		bOLCAEPIHJH_ = other.bOLCAEPIHJH_;
		hBEGBPFIJJM_ = other.hBEGBPFIJJM_;
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		hFOKNODFIJI_ = other.hFOKNODFIJI_;
		iLEMMKPGPND_ = other.iLEMMKPGPND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLFOGJGCCGP Clone()
	{
		return new DLFOGJGCCGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLFOGJGCCGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLFOGJGCCGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AKGICOFNHON != other.AKGICOFNHON)
		{
			return false;
		}
		if (!iAONGEDPLIC_.Equals(other.iAONGEDPLIC_))
		{
			return false;
		}
		if (BFIBIHLBLHF != other.BFIBIHLBLHF)
		{
			return false;
		}
		if (BOLCAEPIHJH != other.BOLCAEPIHJH)
		{
			return false;
		}
		if (HBEGBPFIJJM != other.HBEGBPFIJJM)
		{
			return false;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
		{
			return false;
		}
		if (HFOKNODFIJI != other.HFOKNODFIJI)
		{
			return false;
		}
		if (ILEMMKPGPND != other.ILEMMKPGPND)
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
		if (AKGICOFNHON)
		{
			num ^= AKGICOFNHON.GetHashCode();
		}
		num ^= iAONGEDPLIC_.GetHashCode();
		if (BFIBIHLBLHF != 0)
		{
			num ^= BFIBIHLBLHF.GetHashCode();
		}
		if (BOLCAEPIHJH)
		{
			num ^= BOLCAEPIHJH.GetHashCode();
		}
		if (HBEGBPFIJJM != 0)
		{
			num ^= HBEGBPFIJJM.GetHashCode();
		}
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
		}
		if (HFOKNODFIJI != 0)
		{
			num ^= HFOKNODFIJI.GetHashCode();
		}
		if (ILEMMKPGPND != 0)
		{
			num ^= ILEMMKPGPND.GetHashCode();
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
		if (AKGICOFNHON)
		{
			output.WriteRawTag(32);
			output.WriteBool(AKGICOFNHON);
		}
		iAONGEDPLIC_.WriteTo(ref output, _repeated_iAONGEDPLIC_codec);
		if (BFIBIHLBLHF != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BFIBIHLBLHF);
		}
		if (BOLCAEPIHJH)
		{
			output.WriteRawTag(56);
			output.WriteBool(BOLCAEPIHJH);
		}
		if (HBEGBPFIJJM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(HBEGBPFIJJM);
		}
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CDKEDFPEFIJ);
		}
		if (HFOKNODFIJI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HFOKNODFIJI);
		}
		if (ILEMMKPGPND != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ILEMMKPGPND);
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
		if (AKGICOFNHON)
		{
			num += 2;
		}
		num += iAONGEDPLIC_.CalculateSize(_repeated_iAONGEDPLIC_codec);
		if (BFIBIHLBLHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFIBIHLBLHF);
		}
		if (BOLCAEPIHJH)
		{
			num += 2;
		}
		if (HBEGBPFIJJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBEGBPFIJJM);
		}
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (HFOKNODFIJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFOKNODFIJI);
		}
		if (ILEMMKPGPND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILEMMKPGPND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLFOGJGCCGP other)
	{
		if (other != null)
		{
			if (other.AKGICOFNHON)
			{
				AKGICOFNHON = other.AKGICOFNHON;
			}
			iAONGEDPLIC_.Add(other.iAONGEDPLIC_);
			if (other.BFIBIHLBLHF != 0)
			{
				BFIBIHLBLHF = other.BFIBIHLBLHF;
			}
			if (other.BOLCAEPIHJH)
			{
				BOLCAEPIHJH = other.BOLCAEPIHJH;
			}
			if (other.HBEGBPFIJJM != 0)
			{
				HBEGBPFIJJM = other.HBEGBPFIJJM;
			}
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
			}
			if (other.HFOKNODFIJI != 0)
			{
				HFOKNODFIJI = other.HFOKNODFIJI;
			}
			if (other.ILEMMKPGPND != 0)
			{
				ILEMMKPGPND = other.ILEMMKPGPND;
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
			case 32u:
				AKGICOFNHON = input.ReadBool();
				break;
			case 42u:
				iAONGEDPLIC_.AddEntriesFrom(ref input, _repeated_iAONGEDPLIC_codec);
				break;
			case 48u:
				BFIBIHLBLHF = input.ReadUInt32();
				break;
			case 56u:
				BOLCAEPIHJH = input.ReadBool();
				break;
			case 80u:
				HBEGBPFIJJM = input.ReadUInt32();
				break;
			case 88u:
				CDKEDFPEFIJ = input.ReadUInt32();
				break;
			case 96u:
				HFOKNODFIJI = input.ReadUInt32();
				break;
			case 104u:
				ILEMMKPGPND = input.ReadUInt32();
				break;
			}
		}
	}
}
