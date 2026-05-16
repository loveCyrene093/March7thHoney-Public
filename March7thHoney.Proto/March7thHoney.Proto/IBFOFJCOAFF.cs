using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IBFOFJCOAFF : IMessage<IBFOFJCOAFF>, IMessage, IEquatable<IBFOFJCOAFF>, IDeepCloneable<IBFOFJCOAFF>, IBufferMessage
{
	private static readonly MessageParser<IBFOFJCOAFF> _parser = new MessageParser<IBFOFJCOAFF>(() => new IBFOFJCOAFF());

	private UnknownFieldSet _unknownFields;

	public const int PEFLHKMBOCMFieldNumber = 2;

	private uint pEFLHKMBOCM_;

	public const int AAOGKKKEIILFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aAOGKKKEIIL_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aAOGKKKEIIL_ = new RepeatedField<uint>();

	public const int HAHHPFOLAIGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_hAHHPFOLAIG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> hAHHPFOLAIG_ = new RepeatedField<uint>();

	public const int MEHBFKDFGNFFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_mEHBFKDFGNF_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> mEHBFKDFGNF_ = new RepeatedField<uint>();

	public const int CGIPDJCNFLJFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_cGIPDJCNFLJ_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> cGIPDJCNFLJ_ = new RepeatedField<uint>();

	public const int FJNPLPNIFBAFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_fJNPLPNIFBA_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> fJNPLPNIFBA_ = new RepeatedField<uint>();

	public const int LADCEEHAJDGFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_lADCEEHAJDG_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> lADCEEHAJDG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IBFOFJCOAFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IBFOFJCOAFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEFLHKMBOCM
	{
		get
		{
			return pEFLHKMBOCM_;
		}
		set
		{
			pEFLHKMBOCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AAOGKKKEIIL => aAOGKKKEIIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HAHHPFOLAIG => hAHHPFOLAIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MEHBFKDFGNF => mEHBFKDFGNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CGIPDJCNFLJ => cGIPDJCNFLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FJNPLPNIFBA => fJNPLPNIFBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LADCEEHAJDG => lADCEEHAJDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFOFJCOAFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFOFJCOAFF(IBFOFJCOAFF other)
		: this()
	{
		pEFLHKMBOCM_ = other.pEFLHKMBOCM_;
		aAOGKKKEIIL_ = other.aAOGKKKEIIL_.Clone();
		hAHHPFOLAIG_ = other.hAHHPFOLAIG_.Clone();
		mEHBFKDFGNF_ = other.mEHBFKDFGNF_.Clone();
		cGIPDJCNFLJ_ = other.cGIPDJCNFLJ_.Clone();
		fJNPLPNIFBA_ = other.fJNPLPNIFBA_.Clone();
		lADCEEHAJDG_ = other.lADCEEHAJDG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBFOFJCOAFF Clone()
	{
		return new IBFOFJCOAFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IBFOFJCOAFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IBFOFJCOAFF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PEFLHKMBOCM != other.PEFLHKMBOCM)
		{
			return false;
		}
		if (!aAOGKKKEIIL_.Equals(other.aAOGKKKEIIL_))
		{
			return false;
		}
		if (!hAHHPFOLAIG_.Equals(other.hAHHPFOLAIG_))
		{
			return false;
		}
		if (!mEHBFKDFGNF_.Equals(other.mEHBFKDFGNF_))
		{
			return false;
		}
		if (!cGIPDJCNFLJ_.Equals(other.cGIPDJCNFLJ_))
		{
			return false;
		}
		if (!fJNPLPNIFBA_.Equals(other.fJNPLPNIFBA_))
		{
			return false;
		}
		if (!lADCEEHAJDG_.Equals(other.lADCEEHAJDG_))
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
		if (PEFLHKMBOCM != 0)
		{
			num ^= PEFLHKMBOCM.GetHashCode();
		}
		num ^= aAOGKKKEIIL_.GetHashCode();
		num ^= hAHHPFOLAIG_.GetHashCode();
		num ^= mEHBFKDFGNF_.GetHashCode();
		num ^= cGIPDJCNFLJ_.GetHashCode();
		num ^= fJNPLPNIFBA_.GetHashCode();
		num ^= lADCEEHAJDG_.GetHashCode();
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
		if (PEFLHKMBOCM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PEFLHKMBOCM);
		}
		aAOGKKKEIIL_.WriteTo(ref output, _repeated_aAOGKKKEIIL_codec);
		hAHHPFOLAIG_.WriteTo(ref output, _repeated_hAHHPFOLAIG_codec);
		mEHBFKDFGNF_.WriteTo(ref output, _repeated_mEHBFKDFGNF_codec);
		cGIPDJCNFLJ_.WriteTo(ref output, _repeated_cGIPDJCNFLJ_codec);
		fJNPLPNIFBA_.WriteTo(ref output, _repeated_fJNPLPNIFBA_codec);
		lADCEEHAJDG_.WriteTo(ref output, _repeated_lADCEEHAJDG_codec);
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
		if (PEFLHKMBOCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEFLHKMBOCM);
		}
		num += aAOGKKKEIIL_.CalculateSize(_repeated_aAOGKKKEIIL_codec);
		num += hAHHPFOLAIG_.CalculateSize(_repeated_hAHHPFOLAIG_codec);
		num += mEHBFKDFGNF_.CalculateSize(_repeated_mEHBFKDFGNF_codec);
		num += cGIPDJCNFLJ_.CalculateSize(_repeated_cGIPDJCNFLJ_codec);
		num += fJNPLPNIFBA_.CalculateSize(_repeated_fJNPLPNIFBA_codec);
		num += lADCEEHAJDG_.CalculateSize(_repeated_lADCEEHAJDG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IBFOFJCOAFF other)
	{
		if (other != null)
		{
			if (other.PEFLHKMBOCM != 0)
			{
				PEFLHKMBOCM = other.PEFLHKMBOCM;
			}
			aAOGKKKEIIL_.Add(other.aAOGKKKEIIL_);
			hAHHPFOLAIG_.Add(other.hAHHPFOLAIG_);
			mEHBFKDFGNF_.Add(other.mEHBFKDFGNF_);
			cGIPDJCNFLJ_.Add(other.cGIPDJCNFLJ_);
			fJNPLPNIFBA_.Add(other.fJNPLPNIFBA_);
			lADCEEHAJDG_.Add(other.lADCEEHAJDG_);
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
			case 16u:
				PEFLHKMBOCM = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				aAOGKKKEIIL_.AddEntriesFrom(ref input, _repeated_aAOGKKKEIIL_codec);
				break;
			case 32u:
			case 34u:
				hAHHPFOLAIG_.AddEntriesFrom(ref input, _repeated_hAHHPFOLAIG_codec);
				break;
			case 40u:
			case 42u:
				mEHBFKDFGNF_.AddEntriesFrom(ref input, _repeated_mEHBFKDFGNF_codec);
				break;
			case 56u:
			case 58u:
				cGIPDJCNFLJ_.AddEntriesFrom(ref input, _repeated_cGIPDJCNFLJ_codec);
				break;
			case 88u:
			case 90u:
				fJNPLPNIFBA_.AddEntriesFrom(ref input, _repeated_fJNPLPNIFBA_codec);
				break;
			case 104u:
			case 106u:
				lADCEEHAJDG_.AddEntriesFrom(ref input, _repeated_lADCEEHAJDG_codec);
				break;
			}
		}
	}
}
