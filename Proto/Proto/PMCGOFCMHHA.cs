using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PMCGOFCMHHA : IMessage<PMCGOFCMHHA>, IMessage, IEquatable<PMCGOFCMHHA>, IDeepCloneable<PMCGOFCMHHA>, IBufferMessage
{
	private static readonly MessageParser<PMCGOFCMHHA> _parser = new MessageParser<PMCGOFCMHHA>(() => new PMCGOFCMHHA());

	private UnknownFieldSet _unknownFields;

	public const int BFLHMIDIFKFFieldNumber = 1;

	private uint bFLHMIDIFKF_;

	public const int MMOJOECDMILFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_mMOJOECDMIL_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> mMOJOECDMIL_ = new RepeatedField<uint>();

	public const int HKBPEHBLIACFieldNumber = 4;

	private uint hKBPEHBLIAC_;

	public const int EPAINHHNBLOFieldNumber = 9;

	private uint ePAINHHNBLO_;

	public const int GIJOAADKDINFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_gIJOAADKDIN_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> gIJOAADKDIN_ = new RepeatedField<uint>();

	public const int IMKOJKJAHMMFieldNumber = 15;

	private static readonly FieldCodec<KKJNFIPPDDO> _repeated_iMKOJKJAHMM_codec = FieldCodec.ForMessage(122u, KKJNFIPPDDO.Parser);

	private readonly RepeatedField<KKJNFIPPDDO> iMKOJKJAHMM_ = new RepeatedField<KKJNFIPPDDO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PMCGOFCMHHA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PMCGOFCMHHAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFLHMIDIFKF
	{
		get
		{
			return bFLHMIDIFKF_;
		}
		set
		{
			bFLHMIDIFKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MMOJOECDMIL => mMOJOECDMIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HKBPEHBLIAC
	{
		get
		{
			return hKBPEHBLIAC_;
		}
		set
		{
			hKBPEHBLIAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPAINHHNBLO
	{
		get
		{
			return ePAINHHNBLO_;
		}
		set
		{
			ePAINHHNBLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GIJOAADKDIN => gIJOAADKDIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KKJNFIPPDDO> IMKOJKJAHMM => iMKOJKJAHMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMCGOFCMHHA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMCGOFCMHHA(PMCGOFCMHHA other)
		: this()
	{
		bFLHMIDIFKF_ = other.bFLHMIDIFKF_;
		mMOJOECDMIL_ = other.mMOJOECDMIL_.Clone();
		hKBPEHBLIAC_ = other.hKBPEHBLIAC_;
		ePAINHHNBLO_ = other.ePAINHHNBLO_;
		gIJOAADKDIN_ = other.gIJOAADKDIN_.Clone();
		iMKOJKJAHMM_ = other.iMKOJKJAHMM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMCGOFCMHHA Clone()
	{
		return new PMCGOFCMHHA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PMCGOFCMHHA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PMCGOFCMHHA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BFLHMIDIFKF != other.BFLHMIDIFKF)
		{
			return false;
		}
		if (!mMOJOECDMIL_.Equals(other.mMOJOECDMIL_))
		{
			return false;
		}
		if (HKBPEHBLIAC != other.HKBPEHBLIAC)
		{
			return false;
		}
		if (EPAINHHNBLO != other.EPAINHHNBLO)
		{
			return false;
		}
		if (!gIJOAADKDIN_.Equals(other.gIJOAADKDIN_))
		{
			return false;
		}
		if (!iMKOJKJAHMM_.Equals(other.iMKOJKJAHMM_))
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
		if (BFLHMIDIFKF != 0)
		{
			num ^= BFLHMIDIFKF.GetHashCode();
		}
		num ^= mMOJOECDMIL_.GetHashCode();
		if (HKBPEHBLIAC != 0)
		{
			num ^= HKBPEHBLIAC.GetHashCode();
		}
		if (EPAINHHNBLO != 0)
		{
			num ^= EPAINHHNBLO.GetHashCode();
		}
		num ^= gIJOAADKDIN_.GetHashCode();
		num ^= iMKOJKJAHMM_.GetHashCode();
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
		if (BFLHMIDIFKF != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BFLHMIDIFKF);
		}
		mMOJOECDMIL_.WriteTo(ref output, _repeated_mMOJOECDMIL_codec);
		if (HKBPEHBLIAC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HKBPEHBLIAC);
		}
		if (EPAINHHNBLO != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EPAINHHNBLO);
		}
		gIJOAADKDIN_.WriteTo(ref output, _repeated_gIJOAADKDIN_codec);
		iMKOJKJAHMM_.WriteTo(ref output, _repeated_iMKOJKJAHMM_codec);
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
		if (BFLHMIDIFKF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFLHMIDIFKF);
		}
		num += mMOJOECDMIL_.CalculateSize(_repeated_mMOJOECDMIL_codec);
		if (HKBPEHBLIAC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HKBPEHBLIAC);
		}
		if (EPAINHHNBLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPAINHHNBLO);
		}
		num += gIJOAADKDIN_.CalculateSize(_repeated_gIJOAADKDIN_codec);
		num += iMKOJKJAHMM_.CalculateSize(_repeated_iMKOJKJAHMM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PMCGOFCMHHA other)
	{
		if (other != null)
		{
			if (other.BFLHMIDIFKF != 0)
			{
				BFLHMIDIFKF = other.BFLHMIDIFKF;
			}
			mMOJOECDMIL_.Add(other.mMOJOECDMIL_);
			if (other.HKBPEHBLIAC != 0)
			{
				HKBPEHBLIAC = other.HKBPEHBLIAC;
			}
			if (other.EPAINHHNBLO != 0)
			{
				EPAINHHNBLO = other.EPAINHHNBLO;
			}
			gIJOAADKDIN_.Add(other.gIJOAADKDIN_);
			iMKOJKJAHMM_.Add(other.iMKOJKJAHMM_);
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
				BFLHMIDIFKF = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				mMOJOECDMIL_.AddEntriesFrom(ref input, _repeated_mMOJOECDMIL_codec);
				break;
			case 32u:
				HKBPEHBLIAC = input.ReadUInt32();
				break;
			case 72u:
				EPAINHHNBLO = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				gIJOAADKDIN_.AddEntriesFrom(ref input, _repeated_gIJOAADKDIN_codec);
				break;
			case 122u:
				iMKOJKJAHMM_.AddEntriesFrom(ref input, _repeated_iMKOJKJAHMM_codec);
				break;
			}
		}
	}
}
